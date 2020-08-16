using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class ReservationList : Form
    {
        public User userInfo;
        public int resUserID = -1;
        private DateTime currentDate;

        public void displayError(string errorMessage)
        {
            lblError.Visible = true;
            lblError.Text = "Error: " + errorMessage;
        }
        public ReservationList(int userID, DateTime current)
        {
            InitializeComponent();
            resListDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // gets user info
            userInfo = new User(userID);

            // shows or hides customer search bar based on isCustomer value
            if (userInfo.isCustomer == true)
            {
                resUserID = userID;
                GetData();
            }
            else
            {
                lblCustDesc.Visible = true;
                txtCustomerSearch.Visible = true;
                btnSearch.Visible = true;
                btnModify.Visible = true;
            }
        }

        // DESCRIPTION: Pulls reservation report
        private void GetData()
        {
            try
            {
                // build and execute query
                DBConnect reservationListConn = new DBConnect();
                MySqlCommand cmd = new MySqlCommand("SELECT distinct r.confirmationID, r.startDate, r.endDate, loc.locationName  FROM dbo.reservation r join location loc on loc.locationID = r.locationID where r.userID = @userID and r.reservationStatus <> 'cancelled'");
                cmd.Parameters.AddWithValue("@userID", resUserID);
                DataSet resReport = reservationListConn.ExecuteDataSet(cmd);

                // pipe dataset to report
                resListDataGrid.DataSource = resReport.Tables[0];
                reservationListConn.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        // DESCRIPTION: Logs out of system
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        // DESCRIPTION: Searches for specified customer ID reservations
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // reset error status
            lblError.Visible = false;

            // if no customer ID entered
            if (string.IsNullOrEmpty(txtCustomerSearch.Text))
            {
                displayError("Customer ID not entered");
            }
            else
            {
                // check that customer ID exists
                resUserID = Convert.ToInt32(txtCustomerSearch.Text);
                Utilities checkForUser = new Utilities();

                // check that user exists
                if (!(checkForUser.userIDExists(resUserID)))
                {
                    displayError("Error: Customer ID does not exist");
                }
                // ensure entered user ID is customer
                else if (!(checkForUser.isCustomer(resUserID)))
                {
                    displayError("Entered user ID is not customer");
                }
                else
                // customer ID exists, pull report
                {
                    GetData();
                }
            }
        }

        // DESCRIPTION: Returns to Menu page
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DESCRIPTION: Loads the reservation report
        private void ReservationList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmgmt.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.hotelmgmt.location);
            // TODO: This line of code loads data into the 'hotelmgmt.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.hotelmgmt.reservation);

        }
        // DESCRIPTION: Gets confirmation ID of selected reservation row
        private int getConfirmationID()
        {
            int selectedrowindex = resListDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = resListDataGrid.Rows[selectedrowindex];
            int confirmationID = Convert.ToInt32(selectedRow.Cells["ConfirmationID"].Value);
            return confirmationID;
        }
        // DESCRIPTION: Re-directs user to payment page, passes confirmation ID of selected reservation and userID of user
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (resListDataGrid.SelectedRows.Count > 0)
            {
                // Pulls out confirmation ID from selected row
                int confirmationID = getConfirmationID();

                Reservation makeResPayment = new Reservation(confirmationID);

                // check that reservation not already paid
                if (makeResPayment.amountDue > 0)
                { // Passes confirmation ID and user ID to payment page
                   var makePayment = new Payment(confirmationID, resUserID, currentDate);
                    makePayment.FormClosed += new FormClosedEventHandler(makePayment_FormClosed);
                    this.Hide();
                    makePayment.Show();
                }
                else
                {
                    displayError("This reservation has been paid in full");
                }
            }
            else
            {
                displayError("No reservation selected");
            }

        }

        private void makePayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (userInfo.isCustomer == false && resUserID == -1)
            {
                displayError("Please enter a customer ID");
            }
            else
            {
                var newReservation = new CreateReservation(userInfo.userID, resUserID);
                newReservation.FormClosed += new FormClosedEventHandler(newReservation_FormClosed);
                this.Hide();
                newReservation.Show();
            }
        }

        private void newReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (resUserID == -1)
            {
                displayError("Please enter a customer ID");
            }
            else if (resListDataGrid.SelectedRows.Count < 1)
            {
                displayError("Please select a reservation");
            }
            else
            {
                // Pulls out confirmation ID from selected row
                int confirmationID = getConfirmationID();
                var modReservation = new CreateReservation(userInfo.userID, confirmationID, true);
                this.Hide();
                modReservation.Show();
            }
        }

        // DESCRIPTION: Reservation cancellation process
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Utilities getFileSettings = new Utilities();
            if (resListDataGrid.SelectedRows.Count > 0)
            {
                string cancelMessage = "Please note, a " + getFileSettings.getCancelCharge() + " charge will apply to any reservation cancelled within " + getFileSettings.getCancelWindow() +" days of the start date. Continue with cancellation?";
                var selectedOption = MessageBox.Show(cancelMessage, "Cancel reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (selectedOption == DialogResult.Yes)
                {
                    {   // begin cancellation process
                        int confirmationID = getConfirmationID();
                        Reservation resInfo = new Reservation(confirmationID);

                        // check if reservation can be cancelled
                        if (resInfo.status == "cancelled")
                        {
                            displayError("This reservation has already been cancelled");
                        }
                        else if (resInfo.status == "checked-out")
                        {
                            displayError("This reservation has already been completed");
                        }
                        else if (resInfo.status == "checked-in")
                        {
                            // update reservation info
                            Utilities recalc = new Utilities();
                            DateTime newEndDate = currentDate;       //FIXME: Replace with date variable
                            resInfo.totalPrice = recalc.calculatePrice((newEndDate - resInfo.endDate).TotalDays, recalc.getPricePerNight(resInfo.locationID, resInfo.roomNumList[0]));
                            resInfo.points = Convert.ToInt32(recalc.calculatePoints((newEndDate - resInfo.endDate).TotalDays));
                            resInfo.amountDue = resInfo.totalPrice - resInfo.amountPaid;
                            resInfo.status = "checked-out";
                        }
                        else if (resInfo.status == "upcoming")
                        {
                            // if reservation is within 3 days
                            if (((resInfo.startDate - currentDate).TotalDays) <= getFileSettings.getCancelWindow())
                            {
                                resInfo.totalPrice = (double)getFileSettings.getCancelCharge();
                            }
                            else
                            {
                                resInfo.totalPrice = 0;
                            }
                            resInfo.status = "cancelled";
                            resInfo.points = 0;
                            resInfo.amountDue = resInfo.totalPrice - resInfo.amountPaid;
                        }
                        if (resInfo.amountDue < 0)
                        {
                            PaymentRecord issueRefund = new PaymentRecord();
                            // system account issues refund payment
                            issueRefund.makePayment(17, resInfo.confirmatonID, resInfo.amountDue, "refund", false);                                                     
                        }
                        // update reservation record
                        resInfo.updateReservation(resInfo);

                        // log cancellation
                        if(userInfo.isCustomer) 
                        {
                            resInfo.logCancellation(userInfo.userID, userInfo.userID, currentDate);
                        }
                        else
                        {
                            resInfo.logCancellation(userInfo.userID, resUserID, currentDate);
                        }
                        GetData();
                    }
                }             
            }
            else
            {
                displayError("No reservation selected"); 
            }

        }
    }

}
