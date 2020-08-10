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
            resUserID = userID;
            
            // gets user info
            userInfo = new User(userID);

            // shows or hides customer search bar based on isCustomer value
            if (userInfo.isCustomer == true)
            {
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
            // TODO: This line of code loads data into the 'dboDataSet.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.dboDataSet.reservation);
            // TODO: This line of code loads data into the 'dboDataSet.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.dboDataSet.location);

        }
    }

}
