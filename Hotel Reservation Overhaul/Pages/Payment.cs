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
            lblPoints.Text = userInfo.pointsBalance.ToString();
            dateTimePicker1.Value = currentDate;
            if (isReserving)
                lblDeposit.Text = "$" + getInfo.getMinCharge();
            else
            {
                lblDeposit.Visible = false;
                lblDepDue.Visible = false;
            }
            lblResPrice.Text = "$" + resInfo.totalPrice;
            lblBalance.Text = "$" + resInfo.amountDue;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            resInfo.deleteReservation();
            this.Close();
            if(Application.OpenForms["CreateReservation"] != null)
                Application.OpenForms["CreateReservation"].Close();
            Application.OpenForms["ReservationList"].Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            resInfo.deleteReservation();
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
                else if (long.TryParse(txtCardNum.Text.Replace(" ", string.Empty), out _) == false)
                {
                    lblCardNumError.Visible = true;
                    lblCardNumError.Text = "Error: Your credit card number is not numeric";
                    proceed = false;
                }
                else if(txtCardNum.Text.Length != 19)
                {
                    lblCardNumError.Visible = true;
                    lblCardNumError.Text = "Error: Invalid card number entry";
                    proceed = false;
                }
            }
            if (chkReward.Checked && userInfo.pointsBalance < 50)
            {
                lblrewardError.Text = "You don't have enough points";
                lblrewardError.Visible = true;
                proceed = false;
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
                
                else if (double.Parse(txtPrice.Text) > resInfo.amountDue)
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "Error: Amount exceeds your\nbalance due";
                    proceed = false;
                }
                if (chkReward.Checked && getInfo.checkIfRewardApplied(resInfo.confirmatonID))
                {
                    lblrewardError.Text = "Error: 10% is already applied to this reservation";
                    lblrewardError.Visible = true;
                    proceed = false;
                }

                if (proceed)
                {
                    if (chkReward.Checked)
                    {     
                        resInfo.totalPrice *= 0.9;
                        //resInfo.amountDue -= resInfo.amountPaid;
                        // update reservation in database
                        resInfo.updateReservation(resInfo);
                    }
                    
                    ccNumber = txtCardNum.Text;
                    PaymentRecord payment = new PaymentRecord();
                    if (payment.makePayment(userInfo.userID, resInfo.confirmatonID, double.Parse(txtPrice.Text), cboxMethod.SelectedItem.ToString(), this.appliedReward, currentDate, ccNumber))
                    {
                        lblBalance.Text = "$" + (resInfo.amountDue);// - double.Parse(txtPrice.Text));
                        if (resInfo.amountDue != 0)
                            MessageBox.Show("Your payment was successful! Please be adviced that your card will be charged any remaining balance at check out.");
                        else
                            MessageBox.Show("Your payment was successful!");
                    }
                    this.Close();
                    Application.OpenForms["ReservationList"].Close();    
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
                    if(chkReward.Checked)
                    {
                        resInfo.totalPrice *= 0.9;
                        //resInfo.amountDue -= double.Parse(txtPrice.Text);
                        resInfo.updateReservation(resInfo);
                    }
                    
                    // update reservation in database
                    
                    ccNumber = txtCardNum.Text;
                    PaymentRecord payment = new PaymentRecord();
                    if (payment.makePayment(userInfo.userID, resInfo.confirmatonID, double.Parse(txtPrice.Text), cboxMethod.SelectedItem.ToString(), this.appliedReward, currentDate, ccNumber))
                    {
                        lblBalance.Text = "$" + resInfo.amountDue;
                        if (resInfo.amountDue != 0)
                            MessageBox.Show("Your payment was successful! Please be adviced that your card will be charged any remaining balance at check out.");
                        else
                            MessageBox.Show("Your payment was successful!");
                    }
                    this.Close();
                    Application.OpenForms["CreateReservation"].Close();
                    Application.OpenForms["ReservationList"].Close();
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
            /*if(txtCardNum.Text.Length == 4 || txtCardNum.Text.Length == 9 || txtCardNum.Text.Length == 14)
            {
                txtCardNum.Text = txtCardNum.Text + " ";
                txtCardNum.SelectionStart = txtCardNum.Text.Length;
                txtCardNum.SelectionLength = 0;
            }*/
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
                    if (getInfo.checkIfRewardApplied(resInfo.confirmatonID))
                    {
                        lblrewardError.Text = "Error: 10% is already applied to this reservation";
                        lblrewardError.Visible = true;
                    }
                    else
                    {
                        lblrewardError.Visible = false;
                        //resInfo.amountDue *= 0.9;
                        //userInfo.pointsBalance -= 50;
                        lblBalance.Text = "$" + resInfo.amountDue*0.9;
                        lblPoints.Text = (userInfo.pointsBalance - 50).ToString();
                        lblApplyReward.Visible = true;
                        appliedReward = true;
                    }
                }
            }
            else 
            {
                if(this.appliedReward)
                {
                    //resInfo.amountDue /= 0.9;
                    //userInfo.pointsBalance += 50;
                    lblBalance.Text = "$" + resInfo.amountDue;
                    lblPoints.Text = userInfo.pointsBalance.ToString();
                    lblApplyReward.Visible = false;
                    appliedReward = false;
                }
                if (lblrewardError.Visible)
                    lblrewardError.Visible = false;
            }
        }

    }
}
