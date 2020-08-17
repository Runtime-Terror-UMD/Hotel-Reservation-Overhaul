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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hotel_Reservation_Overhaul
{
    public partial class CreateReservation : Form
    {
        Reservation modResInfo;
        public DateTime? startDate = null;
        public DateTime? endDate = null;
        public bool waitlist = false;
        public int resUserID;
        public int confirmationID;
        public int userID;
        public double pricePerNight;
        public double price;
        public int refRoomNum;
        public int points;
        public string combindstring;
        public bool mod = false;
        List<int> roomNumList = new List<int>();
        DateTime currentDate;

        public CreateReservation(int UserID, int ResUserID, DateTime current )
        {
            InitializeComponent();
            PopulateCheckBoxes();
            resUserID = ResUserID;
            userID = UserID;
            currentDate = current;
        }

        // DESCRIPTION: Fills fields with reservation info for reservation to modify
        public CreateReservation(int userID, int confirmationID, bool modify)
        {
            // fills fields with current reservation information
            InitializeComponent();
            PopulateCheckBoxes();
            Utilities getDeposit = new Utilities();
            modResInfo = new Reservation(confirmationID);
            resUserID = modResInfo.userID;
            monthStart.SetDate(modResInfo.startDate);
            monthEnd.SetDate(modResInfo.endDate);
            lblSubTotal.Text = modResInfo.totalPrice.ToString();
            txtCostNightly.Text = (modResInfo.totalPrice / modResInfo.duration).ToString();
            lblDeposit.Text = (getDeposit.getMinCharge()).ToString();
            cboxHotel.SelectedValue = modResInfo.locationID;
            Room roomInfo = new Room();
            List<int> roomPacks = roomInfo.roomPackages(modResInfo.roomNumList[0], modResInfo.locationID);
            cboxNumRooms.SelectedItem = modResInfo.roomNumList.Count.ToString();
            mod = true;
            checkFreeUpgrade.Visible = true;
            foreach(int packID in roomPacks)
            {
                checkPackages.SetItemChecked(packID-1, true);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ReservationList"].Close();
            Application.OpenForms["Menu"].Close();
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
            MySqlCommand cmd = new MySqlCommand("SELECT packageName FROM dbo.package");
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
                Utilities calcPrice = new Utilities();
                List<int> packages = new List<int>();

                foreach (int indexChecked in checkPackages.CheckedIndices)
                {
                    if (checkPackages.GetItemCheckState(indexChecked) == CheckState.Checked)
                    {
                        packages.Add(indexChecked + 1);
                        lblError.Visible = true;
                    }
                }
                
                // put selected package IDs in list
                combindstring = string.Join(",", packages);

                // check for availability
                Reservation resInfo = new Reservation();
                int locationID = Convert.ToInt32(cboxHotel.SelectedValue);
                int numGuests = Convert.ToInt32(cboxNumGuests.SelectedItem);
                int numRooms = Convert.ToInt32(cboxNumRooms.SelectedItem);

                roomNumList =  resInfo.getAvailability(packages, numGuests, locationID, numRooms, combindstring, currentDate);

                if (roomNumList.Count != numRooms)
                {   // no room available, gets roomNum to reference for price 
                    DBConnect checkAvailabilityConn = new DBConnect();
                    MySqlCommand cmd = new MySqlCommand(@"select roomNum
                                        from dbo.relation_room_package rrp
                                        where packageID in (" + combindstring + @") and locationID = @locationID
                                        group by roomNum
                                        having count(distinct packageID) = @numPackages limit 1");

                    cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
                    cmd.Parameters.Add("@numPackages", MySqlDbType.Int32).Value = packages.Count();

                    MySqlDataReader nonAvailableDR = checkAvailabilityConn.ExecuteReader(cmd);
                    if (nonAvailableDR.HasRows)
                    {
                        while (nonAvailableDR.Read())
                        {
                            refRoomNum = Convert.ToInt32(nonAvailableDR["roomNum"]);
                        }
                        Utilities getWLPricePerNight = new Utilities();
                        pricePerNight = getWLPricePerNight.getPricePerNight(Convert.ToInt32(cboxHotel.SelectedValue), refRoomNum);
                        displayError("No room with those criteria are available. Your reservation will be added to the waitlist");
                        waitlist = true;
                    }
                    else
                    {
                        displayError("No room with those criteria exists");
                        return;
                    }
                    nonAvailableDR.Close();
                    checkAvailabilityConn.CloseConnection();
                }
                else
                {
                    // calculate price and rewards
                    pricePerNight = calcPrice.getPricePerNight(Convert.ToInt32(cboxHotel.SelectedValue), roomNumList[0]) * numRooms;
                }
                price = calcPrice.calculatePrice(((endDate.Value - startDate.Value).TotalDays), pricePerNight) * numRooms;
                points = Convert.ToInt32(calcPrice.calculatePoints(((endDate.Value - startDate.Value).TotalDays)));
                
                // fill fields
                Utilities getDeposit = new Utilities();
                lblDeposit.Text = getDeposit.getMinCharge().ToString();
                txtCostNightly.Text = pricePerNight.ToString();
                lblSubTotal.Text = (price + Convert.ToDouble(getDeposit.getMinCharge())).ToString();
                lblError.Visible = false;
                cboxHotel.Enabled = false;
                cboxNumGuests.Enabled = false;
                monthStart.Enabled = false;
                monthEnd.Enabled = false;
                checkPackages.Enabled = false;
                btnSubmit.Visible = false;

                if (mod)
                {
                    btnModify.Visible = true;
                }
                else
                { 
                    btnMakeRes.Visible = true; 
                }
            }
        }

        // DESCRIPTION: Creates reservation or adds to waitlist depending on availability
        private void btnMakeRes_Click(object sender, EventArgs e)
        {  
            if (waitlist == true)
            {
                // add request to waitlist
                Waitlist addToWaitlist = new Waitlist();
                addToWaitlist.addToWaitlist(resUserID, Convert.ToInt32(cboxHotel.SelectedItem), startDate.Value, endDate.Value, Convert.ToInt32(cboxNumGuests.SelectedItem), Convert.ToInt32(cboxNumRooms.SelectedItem), combindstring);
                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "You have been added to the waitlist";
            }
            //If creating reservation
            else
            {   // Get next confirmation ID
                Reservation createReservation = new Reservation();

                     

                int confirmationID = createReservation.makeReservation(Convert.ToInt32(cboxHotel.SelectedValue), resUserID, userID, startDate.Value, endDate.Value, price, points, roomNumList, Convert.ToInt32(cboxNumGuests.SelectedItem), currentDate);
                var makePayment = new Payment(confirmationID, resUserID, currentDate);
                makePayment.FormClosed += new FormClosedEventHandler(makePayment_FormClosed);
                this.Hide();
                makePayment.Show();     

            }
        }

        private void makePayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

        // DESCRIPTION: Resets form fields
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
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modResInfo.locationID = Convert.ToInt32(cboxHotel.SelectedValue);
            modResInfo.numGuests = Convert.ToInt32(cboxNumGuests.SelectedItem);
            modResInfo.startDate = startDate.Value;
            modResInfo.endDate = endDate.Value;
            modResInfo.roomNumList = roomNumList;
            modResInfo.totalPrice = price;
            modResInfo.amountDue = price - modResInfo.amountPaid;
            modResInfo.points = points;
            modResInfo.updateReservation(modResInfo);
        }
    }
}
