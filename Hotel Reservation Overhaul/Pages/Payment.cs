using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class Payment : Form
    {
        User userInfo;
        Reservation resInfo;
        private DateTime currentDate = new DateTime(2020, 08, 21);
        bool isReserving;
        bool appliedReward = false;
        public Payment(int confirmationID, int userID, DateTime current, bool isReserving)
        {
            InitializeComponent();
            //currentDate = current;
            resInfo = new Reservation(confirmationID);
            userInfo = new User(userID);
            this.isReserving = isReserving;
            lblPoints.Text = "" + userInfo.pointsBalance;
            dateTimePicker1.Value = currentDate;
            lblDeposit.Text = (isReserving) ? "$50.00" : "$0.00";//if the customer is currently reserving he must pay the deposit now
            lblBalance.Text = "$" + resInfo.amountDue;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ReservationList"].Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool proceed = true;
            if (cboxMethod.SelectedItem == null)
            {
                lblMethodError.Visible = true;
                lblMethodError.Text = "Error: You should select a payment method";
                proceed = false;//don't proceed with payment process
            }
            else if (cboxMethod.SelectedItem.ToString() == "Credit Card")
            {
                if(String.IsNullOrEmpty(txtCardNum.Text))
                {
                    lblCardNumError.Visible = true;
                    lblCardNumError.Text = "Error: Enter your credit card number";
                    proceed = false;
                }
                else if (long.TryParse(txtCardNum.Text, out _) == false)
                {
                    lblCardNumError.Visible = true;
                    lblCardNumError.Text = "Error: Your credit card number is not numeric";
                    proceed = false;
                }
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                lblAmountError.Visible = true;
                lblAmountError.Text = "Error: Enter your payment amount";
                proceed = false;
            }
            else if (double.TryParse(txtPrice.Text, out _) == false || Int32.Parse(txtPrice.Text) == 0)
            {
                lblAmountError.Visible = true;
                lblAmountError.Text = "Error: Amount entered is not numeric";
                proceed = false;
            }
            else if ((dateTimePicker1.Value == resInfo.endDate) && (Int32.Parse(txtPrice.Text) < resInfo.amountDue))
            {
                lblAmountError.Visible = true;
                lblAmountError.Text = "Error: your reservation ends today\nYou should pay the whole amount";
                proceed = false;
            }
            else if (Int32.Parse(txtPrice.Text) > resInfo.amountDue)
            {
                lblAmountError.Visible = true;
                lblAmountError.Text = "Error: Amount exceeds your\nbalance due";
                proceed = false;
            }

            /*if (proceed)
            {
                PaymentRecord payment = new PaymentRecord();
                payment.paymentDate = dateTimePicker1.Value;
                payment.paymentMethod = cboxMethod.SelectedItem.ToString();
                payment.cardNumber = txtCardNum.Text;
                payment.applyRewards = (chkReward.Checked) ? true : false;
                //payment.rewardBalance =
            }*/
        }

        private void cboxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMethod.SelectedItem.ToString() == "Cash")
                txtCardNum.Enabled = false;
            else if (cboxMethod.SelectedItem.ToString() == "Credit Card")
                txtCardNum.Enabled = true;
            if (lblMethodError.Visible)
                lblMethodError.Visible = false;
        }

        private void txtCardNum_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCardNum.Text))
                lblCardNumError.Visible = false;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrice.Text))
                lblAmountError.Visible = false;
        }

        private void chkReward_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReward.Checked)
            {
                if (userInfo.pointsBalance < 50)
                    lblrewardError.Visible = true;
                else
                {
                    lblrewardError.Visible = false;
                    resInfo.amountDue *= 0.9;
                    userInfo.pointsBalance -= 50;
                    lblBalance.Text = "$" + resInfo.amountDue;
                    lblPoints.Text = "" + userInfo.pointsBalance;
                    lblApplyReward.Visible = true;
                    appliedReward = true;
                    //change the value in the database;
                }
            }
            else 
            {
                if(this.appliedReward)
                {
                    resInfo.amountDue /= 0.9;
                    userInfo.pointsBalance += 50;
                    lblBalance.Text = "$" + resInfo.amountDue;
                    lblPoints.Text = "" + userInfo.pointsBalance;
                    lblApplyReward.Visible = false;
                    appliedReward = false;
                }
                if (lblrewardError.Visible)
                    lblrewardError.Visible = false;
            }
        }
    }
}
