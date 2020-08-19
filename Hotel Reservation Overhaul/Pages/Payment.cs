using Microsoft.Win32.SafeHandles;
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
        public User userInfo;
        public Reservation resInfo;
        public DateTime currentDate;
        public bool isReserving;
        public string ccNumber;
        public bool appliedReward = false;
        Utilities getInfo = new Utilities();
        public Payment(int confirmationID, int userID, DateTime current, bool isReserving)
        {
            InitializeComponent();
            currentDate = current;
            resInfo = new Reservation(confirmationID);
            userInfo = new User(userID);
            if(getInfo.isCustomer(userID))
            {
                cboxMethod.SelectedIndex = 1;
                cboxMethod.Enabled = false;
            }
            this.isReserving = isReserving;
            lblPoints.Text = "" + userInfo.pointsBalance;
            dateTimePicker1.Value = currentDate;
            if (isReserving)
            {
                lblDeposit.Text = "$" + getInfo.getMinCharge();
                resInfo.amountDue += getInfo.getMinCharge();
            }
            else
                lblDeposit.Text = "$0.00";
            lblBalance.Text = "$" + resInfo.amountDue.ToString();
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
                if (String.IsNullOrEmpty(txtCardNum.Text))
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
            if (!isReserving)
            {
                
                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Enter your payment amount";
                    proceed = false;
                }
                else if (double.TryParse(txtPrice.Text, out _) == false)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount entered is not numeric";
                    proceed = false;
                }
                else if (double.Parse(txtPrice.Text) == 0)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount should not be zero";
                    proceed = false;
                }
                else if ((dateTimePicker1.Value == resInfo.endDate) && (double.Parse(txtPrice.Text) < resInfo.amountDue))
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: your reservation ends today\nYou should pay the whole amount";
                    proceed = false;
                }
                else if (double.Parse(txtPrice.Text) > resInfo.amountDue)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount exceeds your\nbalance due";
                    proceed = false;
                }

                if (proceed)
                {
                    ccNumber = txtCardNum.Text;
                    PaymentRecord payment = new PaymentRecord();
                    if(payment.makePayment(userInfo.userID, resInfo.confirmatonID, double.Parse(txtPrice.Text), cboxMethod.SelectedItem.ToString(), this.appliedReward, currentDate, ccNumber))
                    {
                        MessageBox.Show("Your payment was successful!");
                    }
                    if (dateTimePicker1.Value == resInfo.endDate)
                    {
                        //update amount due and deposit amount
                        MessageBox.Show("Your payment was successful!\nThe deposit amount will be refunded to you");
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Enter your payment amount";
                    proceed = false;
                }
                else if (double.TryParse(txtPrice.Text, out _) == false)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount entered is not numeric";
                    proceed = false;
                }
                else if (double.Parse(txtPrice.Text) == 0)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount should not be zero";
                    proceed = false;
                }
                else if (double.Parse(txtPrice.Text) < getInfo.getMinCharge())
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: You should pay the minimum charge";
                    proceed = false;
                }
                else if (double.Parse(txtPrice.Text) > resInfo.amountDue)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount exceeds your\nbalance due";
                    proceed = false;
                }
                if(proceed)
                {
                    ccNumber = txtCardNum.Text;
                    PaymentRecord payment = new PaymentRecord();
                    if (payment.makePayment(userInfo.userID, resInfo.confirmatonID, double.Parse(txtPrice.Text), cboxMethod.SelectedItem.ToString(), this.appliedReward, currentDate, ccNumber))
                    {
                        MessageBox.Show("Your payment was successful");
                    }
                }
            }

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
                {
                    lblrewardError.Visible = true;
                }
                else
                {
                    if (isReserving && !String.IsNullOrEmpty(txtPrice.Text) && double.Parse(txtPrice.Text) < 56)
                    {
                        lblrewardError.Text = "Error: You should pay a minimum of\n$56.00 to apply reward points";
                        lblrewardError.Visible = true;
                    }
                    else
                    {
                        lblrewardError.Visible = false;
                        resInfo.amountDue *= 0.9;
                        userInfo.pointsBalance -= 50;
                        lblBalance.Text = "$" + resInfo.amountDue;
                        lblPoints.Text = "" + userInfo.pointsBalance;
                        lblApplyReward.Visible = true;
                        appliedReward = true;
                    }
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
                    //change values in database
                    lblApplyReward.Visible = false;
                    appliedReward = false;
                }
                if (lblrewardError.Visible)
                    lblrewardError.Visible = false;
            }
        }

    }
}
