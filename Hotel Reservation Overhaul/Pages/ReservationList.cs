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
        User userInfo;
        public int resUserID;

        public ReservationList(int userID)
        {
            InitializeComponent();
            resListDataGrid.MultiSelect = false;

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
            }
        }
        
        // DESCRIPTION: Pulls reservation report
        private void GetData()
        {
            try
            {
                // build and execute query
                DBConnect reservationListConn = new DBConnect();
                reservationListConn.OpenConnection();
                string reservationListQuery = "SELECT r.confirmationID, r.startDate, r.endDate, r.bookingMethod, loc.locationName  FROM dbo.reservation r join location loc on loc.locationID = r.locationID where r.userID = @userID";
                MySqlCommand cmd = new MySqlCommand(reservationListQuery);
                cmd.Parameters.Add("@userID", MySqlDbType.Int32);
                cmd.Parameters["@userID"].Value = resUserID;
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

        }

        // DESCRIPTION: Searches for specified customer ID reservations
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // reset error status
            lblError.Visible = false;

            // if no customer ID entered
            if (string.IsNullOrEmpty(txtCustomerSearch.Text))
            {
                lblError.Text = "Error: Customer ID not entered";
                lblError.Visible = true;
            }
            else
            {
                // check that customer ID exists
                resUserID = Convert.ToInt32(txtCustomerSearch.Text);
                Utilities checkForUser = new Utilities();
                if (!(checkForUser.userIDExists(resUserID)))
                {
                    lblError.Text = "Error: Customer ID does not exist";
                    lblError.Visible = true;
                }

                else
                // customer ID exists, pull report
                { GetData(); }
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

      
        // DESCRIPTION: Re-directs user to payment page, passes confirmation ID of selected reservation and userID of user
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (resListDataGrid.SelectedRows.Count > 0)

            {
                // Pulls out confirmation ID from selected row
                int selectedrowindex = resListDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = resListDataGrid.Rows[selectedrowindex];
                int confirmationID = Convert.ToInt32(selectedRow.Cells["ConfirmationID"].Value);
                
                // Passes confirmation ID and user ID to payment page
                var makePayment = new Payment(confirmationID, resUserID);
                this.Hide();
                makePayment.Show();

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Error: No reservation selected";
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var newReservation = new Reservation(resUserID);
            this.Hide();
            newReservation.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

      
    }

}
