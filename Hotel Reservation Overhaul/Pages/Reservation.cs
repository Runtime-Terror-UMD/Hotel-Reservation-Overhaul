using MySql.Data.MySqlClient;
using System;
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
    public partial class Reservation : Form
    {
        public DateTime? startDate = null;
        public DateTime? endDate = null;
        public bool waitlist = false;
        public int resUserID;
        public int roomNum = -1;
        public double pricePerNight;
        public double price;
        public int points;

        public Reservation(int userID)
        {
            InitializeComponent();
            PopulateCheckBoxes();
            resUserID = userID;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        // DESCRIPTION: 
        private void displayError(string message)
        {
            lblError.Visible = true;
            lblError.Text = message;
        }

        // DESCRIPTION: Populates location combobox
        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmgmt1.package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.hotelmgmt1.package);
            // TODO: This line of code loads data into the 'hotelmgmt.package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.hotelmgmt.package);
            // TODO: This line of code loads data into the 'hotelmgmt.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this.hotelmgmt.location);

        }

        // DESCRIPTION: Populates package checkbox list
        private void PopulateCheckBoxes()
        {
            DBConnect checkBoxConn = new DBConnect();
            string checkBoxQuery = "SELECT packageName FROM dbo.package";
            MySqlCommand cmd = new MySqlCommand(checkBoxQuery);
            checkBoxConn.OpenConnection();
            DataTable checkBoxDT = checkBoxConn.ExecuteDataTable(cmd);

            foreach (DataRow row in checkBoxDT.Rows)
            {
                string package = row["packageName"].ToString();
                checkPackages.Items.Add(package);
            }
        }


        // DESCRIPTION: Handles when the selected start date is changed
        private void monthStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            // reset error status
            lblError.Visible = false;
            // set start date
            startDate = monthStart.SelectionStart.Date;

            // if start date in past
            if (startDate < DateTime.Today)                                     // FIXME: Change DateTime.Today to @Date variable
            {
                displayError("Selected start date cannot be in the past");
                lblStartDate.Text = "Start Date: ";
            }
            // if reservation not >= 1 night
            else if (startDate == endDate)
            {
                displayError("Stay must be at least one night");
            }
            // display start date
            else
            {
                lblStartDate.Text = "Start Date: " + monthStart.SelectionStart.ToShortDateString();
            }
        }

        // DESCRIPTION: Handles when the selected end date is changed
        private void monthend_dateChanged(object sender, DateRangeEventArgs e)
        {
            // reset error status
            lblError.Visible = false;

            // set end date
            endDate = monthEnd.SelectionStart.Date;

            // if end date before start date
            if (endDate < startDate)
            {
                displayError("Selected end date is earlier than selected start date");
                lblEndDate.Text = "End Date: ";
            }

            // if reservation not >= 1 night
            else if (startDate == endDate)
            {
                displayError("Stay must be at least one night");
            }

            // display end date
            else
            {
                lblEndDate.Text = "End Date: " + monthEnd.SelectionStart.ToShortDateString();
            }
        }

        // DESCRIPTION: Checks for reservation availability
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // reset error
            lblError.Visible = false;

            // verify fields are valid
            if (startDate == null) { displayError("Please select a start date"); }
            else if (endDate == null) { displayError("Please select an end date"); }
            else if (startDate < DateTime.Today) { displayError("Selected start date cannot be in the past"); }
            else if (endDate < startDate) { displayError("Selected end date is earlier than selected start date"); }
            else if (cboxNumGuests.SelectedItem == null) { displayError("Please select number of guests"); }
            else if (cboxHotel.SelectedItem == null) { displayError("Please select a hotel"); }
            else
            {
                DBConnect checkAvailabilityConn = new DBConnect();
                // Select available rooms at location not in maintenance
                MySqlCommand cmd = new MySqlCommand("SELECT roomNum, pricePerNight FROM dbo.room r where r.locationID = @locationID and r.hasPackage2 = @hasPackage2 and r.hasPackage3 = @hasPackage3 and r.hasPackage4 = @hasPackage4 and r.occupancy >= @numGuests and r.roomNum not in (select roomNum from dbo.reservation where @startDate between startDate and endDate and reservationStatus <> 3) and r.roomNum not in (select roomNum from dbo.maintenance where @startDate between startDate and endDate) LIMIT 1");
                cmd.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = startDate;
                //   cmd.Parameters.Add("@hasPackage1", MySqlDbType.Bit).Value = 1;
                cmd.Parameters.Add("@hasPackage2", MySqlDbType.Bit).Value = 0;
                cmd.Parameters.Add("@hasPackage3", MySqlDbType.Bit).Value = 0;
                cmd.Parameters.Add("@hasPackage4", MySqlDbType.Bit).Value = 0;
                cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = Convert.ToInt32(cboxHotel.SelectedValue);
                cmd.Parameters.Add("numGuests", MySqlDbType.Int32).Value = Convert.ToInt32(cboxNumGuests.SelectedItem);

                // updates parameter values based on checkboxes
                if (checkPackages.GetItemCheckState(1) == CheckState.Checked) { cmd.Parameters["@hasPackage2"].Value = 1; }
                if (checkPackages.GetItemCheckState(2) == CheckState.Checked) { cmd.Parameters["@hasPackage3"].Value = 1; }
                if (checkPackages.GetItemCheckState(3) == CheckState.Checked) { cmd.Parameters["@hasPackage4"].Value = 1; }

                MySqlDataReader dataReader = checkAvailabilityConn.ExecuteReader(cmd);


                while (dataReader.Read())
                {
                    roomNum = Convert.ToInt32(dataReader["roomNum"]);
                    pricePerNight = Convert.ToDouble(dataReader["pricePerNight"]);
                }
                dataReader.Close();
                checkAvailabilityConn.CloseConnection();

                if (roomNum == -1)
                {
                    displayError("No room with those criteria are available. Your reservation will be added to the waitlist");
                    waitlist = true;

                }

                // calculate price
                double days = (endDate.Value - startDate.Value).TotalDays;
                price = pricePerNight * days;
                points = Convert.ToInt32(days * 25);

                // fill fields
                lblDeposit.Text = "50.00";
                txtCostNightly.Text = pricePerNight.ToString();
                lblSubTotal.Text = (price + 50).ToString();
            }
        }

        // DESCRIPTION: Creates reservation or adds to waitlist depending on availability
        private void btnMakeRes_Click(object sender, EventArgs e)
        {
            //Build base command
            DBConnect createResConn = new DBConnect();
            MySqlCommand createResCmd = new MySqlCommand();

            int locationID = Convert.ToInt32(cboxHotel.SelectedValue);
            createResCmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = Convert.ToInt32(cboxHotel.SelectedValue);
            createResCmd.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = resUserID;
            createResCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate.Value;
            createResCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate.Value;

            // If adding to waitlist
            if (waitlist == true)
            {
                // add to waitlist table 
                createResCmd.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = Convert.ToInt32(cboxNumGuests.SelectedItem);
                createResCmd.Parameters.Add("@package2", MySqlDbType.Bit).Value = 0;
                createResCmd.Parameters.Add("@package3", MySqlDbType.Bit).Value = 0;
                createResCmd.Parameters.Add("@package4", MySqlDbType.Bit).Value = 0;
                if (checkPackages.GetItemCheckState(1) == CheckState.Checked) { createResCmd.Parameters["@package2"].Value = 1; }
                if (checkPackages.GetItemCheckState(2) == CheckState.Checked) { createResCmd.Parameters["@package3"].Value = 1; }
                if (checkPackages.GetItemCheckState(3) == CheckState.Checked) { createResCmd.Parameters["@package4"].Value = 1; }

                createResCmd.CommandText = "INSERT INTO `dbo`.`waitlist`(`customerID`,`locationID`,`startDate`,`endDate`,`package2`,`package3`,`package4`,`numGuests`)VALUES(@userID, @locationID, @startDate, @endDate, @package2, @package3, @package4, @numGuests)";
                createResConn.NonQuery(createResCmd);
            }
            //If creating reservation
            else
            {   // Get next confirmation ID
                string getNextConfID = "select confirmationID from dbo.reservation order by confirmationID desc limit 1";
                MySqlCommand cmd = new MySqlCommand(getNextConfID);
                int comfirmationID = createResConn.intScalar(cmd) + 1;

                // add to reservation table
                createResCmd.CommandText = "INSERT INTO `dbo`.`reservation`(`confirmationID`,`userID`,`locationID`,`roomNum`,`startDate`,`endDate`,`bookingMethod`,`pointsAccumulated`,`price`,`amountDue`,`amountPaid`,`reservationStatus`)VALUES(@confirmationID,@userID,@locationID,@roomNum,@startDate,@endDate,@bookingMethod,@points,@price,@price,@amountPaid,@status)";
                createResCmd.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
                createResCmd.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
                createResCmd.Parameters.Add("@points", MySqlDbType.Int32).Value = points;
                createResCmd.Parameters.Add("@bookingMethod", MySqlDbType.VarChar, 45).Value = "application";
                createResCmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                createResCmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = "Upcoming";
                createResCmd.Parameters.Add("@amountPaid", MySqlDbType.Decimal).Value = 0;
                createResConn.NonQuery(createResCmd);

                // add to activity log
                MySqlCommand logActivity = new MySqlCommand("INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`)VALUES(@userID, 1, @confirmationID, @date)");
                logActivity.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
                logActivity.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = resUserID;
                logActivity.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Today;      // FIXME: Replace with date variable
                createResConn.NonQuery(logActivity);
            }
        }
    }
}
