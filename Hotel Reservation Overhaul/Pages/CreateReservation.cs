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
using System.Windows.Forms.VisualStyles;

namespace Hotel_Reservation_Overhaul
{
    public partial class CreateReservation : Form
    {
        public DateTime? startDate = null;
        public DateTime? endDate = null;
        public bool waitlist = false;
        public int resUserID;
        public int roomNum = -1;
        public double pricePerNight;
        public double price;
        public int points;
        public string combindstring;

        public CreateReservation(int userID)
        {
            InitializeComponent();
            PopulateCheckBoxes();
            resUserID = userID;
        }

        public CreateReservation(int userID, int confirmationID)
        {
            InitializeComponent();
            PopulateCheckBoxes();
            resUserID = userID;
            Reservation resInfo = new Reservation(confirmationID);
            monthStart.SelectionRange.Start = resInfo.startDate;
            monthEnd.SelectionRange.Start = resInfo.endDate;
            lblCost.Text = resInfo.totalPrice.ToString();
            cboxHotel.SelectedIndex = resInfo.locationID + 1;
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

            checkPackages.SetItemChecked(0, true);
            checkPackages.SetItemCheckState(0, CheckState.Checked);
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
            if (checkPackages.GetItemCheckState(0) == CheckState.Unchecked)
            {
                checkPackages.SetItemCheckState(0, CheckState.Checked);
                lblError.Text = "All rooms contain basic package.";
            }
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
                // get selected packages
                List<int> packages = new List<int>();

                {   foreach (int indexChecked in checkPackages.CheckedIndices)
                    {
                        if (checkPackages.GetItemCheckState(indexChecked) == CheckState.Checked)
                        {
                            packages.Add(indexChecked + 1);
                            lblError.Visible = true;
                        }
                    }
                }

                // put selected package IDs in list
                combindstring = string.Join(",", packages);
                
                DBConnect checkAvailabilityConn = new DBConnect();
                // Select available rooms at location not in maintenance
                MySqlCommand cmd = new MySqlCommand(@"select roomNum
                                                    from dbo.relation_room_package rrp
                                                    where packageID in (" + combindstring + @") and locationID = @locationID
                                                    and roomNum not in (select roomNum from dbo.reservation where @startDate between startDate and endDate and reservationStatus <> 'cancelled' and locationID = @locationID)
                                                    and roomNum not in (select roomNum from dbo.maintenance where locationID = @locationID and @startDate between startDate and endDate) 
                                                    group by roomNum
                                                    having count(distinct packageID) = @numPackages limit 1");
                cmd.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = startDate;
                cmd.Parameters.Add("@numPackages", MySqlDbType.Int32).Value = packages.Count;
                cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = Convert.ToInt32(cboxHotel.SelectedValue);
                cmd.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = Convert.ToInt32(cboxNumGuests.SelectedItem);

                MySqlDataReader dataReader = checkAvailabilityConn.ExecuteReader(cmd);
                if (dataReader.HasRows)
                {
                    // gets roomNum if one is available
                    while (dataReader.Read())
                    {
                        roomNum = Convert.ToInt32(dataReader["roomNum"]);
                    }
                    Utilities getPricePerNight = new Utilities();
                    pricePerNight = getPricePerNight.getPricePerNight(Convert.ToInt32(cboxHotel.SelectedValue),roomNum);
                    dataReader.Close();
                    checkAvailabilityConn.CloseConnection();
                }
                else
                {   // no room available, gets roomNum to reference for price 
                    checkAvailabilityConn.OpenConnection();
                    cmd.CommandText = @"select roomNum
                                        from dbo.relation_room_package rrp
                                        where packageID in (" + combindstring + @") and locationID = @locationID
                                        group by roomNum
                                        having count(distinct packageID) = @numPackages limit 1";

                    MySqlDataReader nonAvailableDR = checkAvailabilityConn.ExecuteReader(cmd);
                    if (nonAvailableDR.HasRows)
                    {
                        while (nonAvailableDR.Read())
                        {
                            roomNum = Convert.ToInt32(nonAvailableDR["roomNum"]);
                        }
                        Utilities getWLPricePerNight = new Utilities();
                        pricePerNight = getWLPricePerNight.getPricePerNight(Convert.ToInt32(cboxHotel.SelectedValue), roomNum);
                        displayError("No room with those criteria are available. Your reservation will be added to the waitlist");
                        waitlist = true;
                    }            
                    else if (pricePerNight == 0)
                    {
                        displayError("No room with those criteria exists");
                        return;
                    }
                    nonAvailableDR.Close();
                }

                checkAvailabilityConn.CloseConnection();

                // calculate price and rewards
                Utilities calcPrice = new Utilities();
                price = calcPrice.calculatePrice(((endDate.Value - startDate.Value).TotalDays), pricePerNight);
                points = Convert.ToInt32(calcPrice.calculatePoints(((endDate.Value - startDate.Value).TotalDays)));

                // fill fields
                lblDeposit.Text = "50.00";
                txtCostNightly.Text = pricePerNight.ToString();
                lblSubTotal.Text = (price + 50).ToString();
                lblError.Visible = false;
                cboxHotel.Enabled = false;
                cboxNumGuests.Enabled = false;
                monthStart.Enabled = false;
                monthEnd.Enabled = false;
                checkPackages.Enabled = false;
                btnSubmit.Visible = false;
                btnMakeRes.Visible = true;
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
                createResCmd.Parameters.Add("@packages", MySqlDbType.VarChar, 45).Value = combindstring;

                createResCmd.CommandText = "INSERT INTO `dbo`.`waitlist`(`customerID`,`locationID`,`startDate`,`endDate`,`numGuests`,`packages`)VALUES(@userID, @locationID, @startDate, @endDate, @numGuests,@packages)";
                createResConn.NonQuery(createResCmd);
            }
            //If creating reservation
            else
            {   // Get next confirmation ID
                string getNextConfID = "select confirmationID from dbo.reservation order by confirmationID desc limit 1";
                MySqlCommand cmd = new MySqlCommand(getNextConfID);
                int comfirmationID = createResConn.intScalar(cmd) + 1;

                // add to reservation table
                createResCmd.CommandText = "INSERT INTO `dbo`.`reservation`(`confirmationID`,`userID`,`locationID`,`roomNum`,`startDate`,`endDate`,`pointsAccumulated`,`price`,`amountDue`,`amountPaid`,`reservationStatus`,`created`)VALUES(@confirmationID,@userID,@locationID,@roomNum,@startDate,@endDate,@points,@price,@price,@amountPaid,@status,@created)";
                createResCmd.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
                createResCmd.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
                createResCmd.Parameters.Add("@points", MySqlDbType.Int32).Value = points;
                createResCmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                createResCmd.Parameters.Add("@amountPaid", MySqlDbType.Decimal).Value = 0;
                createResCmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = "upcoming";
                createResCmd.Parameters.Add("@created", MySqlDbType.Date).Value = DateTime.Today;
                createResConn.NonQuery(createResCmd);

                // add to activity log
                MySqlCommand logActivity = new MySqlCommand("INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`)VALUES(@userID, 1, @confirmationID, @date)");
                logActivity.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
                logActivity.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = resUserID;
                logActivity.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Today;      // FIXME: Replace with date variable
                createResConn.NonQuery(logActivity);

                // opens payment screen for user to pay deposit
                if (waitlist == false)
                {
                    var makePayment = new Payment(comfirmationID, resUserID);
                    this.Hide();
                    makePayment.Show();
                }
                else
                {
                    lblError.ForeColor = System.Drawing.Color.Green;
                    lblError.Text = "You have been added to the waitlist";
                }
            }
        }

        private void checkPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkPackages.GetItemCheckState(0) == CheckState.Unchecked)
            {
                checkPackages.SetItemCheckState(0, CheckState.Checked);
                lblError.Text = "All rooms contain basic package.";
                lblError.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkPackages.CheckedIndices)
            {
                checkPackages.SetItemChecked(indexChecked, false);
            }
            checkPackages.SetItemChecked(0, true);
            cboxHotel.SelectedIndex = 0;
            cboxNumGuests.SelectedIndex = 0;
            cboxHotel.Enabled = true;
            cboxNumGuests.Enabled = true;
            monthStart.Enabled = true;
            monthEnd.Enabled = true;
            checkPackages.Enabled = true;
            btnSubmit.Visible = true;
            btnMakeRes.Visible = false;
        }
    }
}
