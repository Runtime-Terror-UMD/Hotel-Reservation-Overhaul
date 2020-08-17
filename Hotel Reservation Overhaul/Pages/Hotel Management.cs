using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using MySql.Data.MySqlClient;

namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class HotelManagement : Form
    {
        private int UserID;
        DateTime currentDate;
        public HotelManagement(int userID, DateTime current)
        {
            InitializeComponent();
            UserID = userID;
            currentDate = current;
        }
        public void displayError(string message)
        {
            lblError.Text = "Error: " + message;
            lblError.Visible = true;
        }
        private void btnThirdParty_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog resFile = new OpenFileDialog();
            resFile.Title = "Open Third Party Reservation File";
            resFile.Filter = "TXT files|*.txt";
            resFile.InitialDirectory = @"C:\";
            if (resFile.ShowDialog() == DialogResult.OK)
            {
                DateTime fileDate = new DateTime(2020, 1, 1);
                int numReserv = 0; //count number of reservations in file
                try
                {
                    string fileName = resFile.FileName;
                    string[] fileLines = File.ReadAllLines(fileName);
                    for (int i = 0; i < fileLines.Length; i++)
                    { //new line
                      //get position of space char
                        int start = 0; 
                        int position = fileLines[i].IndexOf(' ', start);
                        if (position >= 0)
                        {
                            string startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                            int year, month, day;
                            start = position + 1;
                            if (startCode == "D") //get line for new date
                            {
                                bool successYear = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                bool successMonth = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                bool successDay = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                if (successYear && successMonth && successDay) //able to get date
                                {
                                    fileDate = new DateTime(year, month, day);
                                    lblFileStatus.Text = "date: " + year + month + day;
                                }
                                else //invalid date
                                {
                                    throw new Exception("Unable to retrieve date.");
                                }
                            }
                            else if (startCode == "RI") //get line for reservation
                            {
                                int resID, custID, hotelID, occNum, credit;
                                decimal charge;
                                var packages = new List<int>();
                                DateTime checkIn, checkOut;
                                bool redeemRew;

                                position = fileLines[i].IndexOf(' ', start);
                                bool successResNum = int.TryParse(fileLines[i].Substring(start, position - start + 1), out resID); //get reservation number
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successCust;
                                if (startCode == "CU")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successCust = int.TryParse(fileLines[i].Substring(start, position - start + 1), out custID); //get customer id
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve user ID.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successHotel;
                                if (startCode == "H")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successHotel = int.TryParse(fileLines[i].Substring(start, position - start + 1), out hotelID); //get hotel id
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve hotel ID.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successOcc;
                                if (startCode == "O")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successOcc = int.TryParse(fileLines[i].Substring(start, position - start + 1), out occNum); //get occupancy
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve occupancy.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successYearIN, successMonthIN, successDayIN;
                                if (startCode == "CI") //checkout
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successYearIN = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                    successMonthIN = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                    successDayIN = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                    checkIn = new DateTime(year, month, day);
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve check in date.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successYearOut, successMonthOut, successDayOut;
                                if (startCode == "CO") //checkout
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successYearOut = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                    successMonthOut = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                    successDayOut = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                    checkOut = new DateTime(year, month, day);
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve check out date.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successPack = true;
                                if (startCode == "P")
                                {
                                    while(successPack)
                                    {
                                        int pack;
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        successPack = int.TryParse(fileLines[i].Substring(start, position - start + 1), out pack);
                                        if(pack != 0)
                                            packages.Add(pack);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve packages.");
                                }
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successCredit;
                                if (startCode == "CC")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successCredit = int.TryParse(fileLines[i].Substring(start, position - start + 1), out credit);
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve credit card.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successCharge;
                                if (startCode == "CH")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successCharge = decimal.TryParse(fileLines[i].Substring(start, position - start + 1), out charge);
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve charge amount.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                if (startCode == "RW")
                                {
                                    string YN;
                                    start = position + 1;
                                    YN = fileLines[i].Substring(start, 1);
                                    if (YN == "Y")
                                        redeemRew = true;
                                    else if (YN == "N")
                                        redeemRew = false;
                                    else
                                        throw new Exception("Invalid reward choice.");
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve reward choice.");
                                }
                                numReserv++;

                                // verify reservation information
                                Utilities verifyReservation = new Utilities();
                                // if user ID exists
                                if (verifyReservation.userIDExists(custID))
                                {
                                    User userInfo = new User(custID);
                                    // if user ID is customer account
                                    if (userInfo.isCustomer)
                                    {
                                        // if hotel ID exists
                                        Location HoteExists = new Location();
                                        if(HoteExists.hotelExists(hotelID))
                                        {
                                            // check for availability
                                            string combindstring = string.Join(",", packages);
                                            Reservation resInfo = new Reservation();
                                            List<int> roomAvailable = resInfo.getAvailability(packages, occNum, hotelID, 1, combindstring, currentDate);
                                            // no room available
                                            if(roomAvailable.Count == 0)
                                            {
                                               MessageBox.Show("No rooms with specified criteria. Please add user to waitlist");   // ADD YESNO MESSAGE BOX
                                                DBConnect checkAvailabilityConn = new DBConnect();
                                                MySqlCommand cmd = new MySqlCommand(@"select roomNum
                                                                                    from dbo.relation_room_package rrp
                                                                                    where packageID in (" + combindstring + @") and locationID = @locationID
                                                                                    group by roomNum
                                                                                    having count(distinct packageID) = @numPackages limit 1");
                                                MySqlDataReader nonAvailableDR = checkAvailabilityConn.ExecuteReader(cmd);
                                                if (nonAvailableDR.HasRows)
                                                {
                                                    Waitlist addToWaitlist = new Waitlist();
                                                    addToWaitlist.addToWaitlist(custID, hotelID, checkIn, checkOut, occNum, 1, combindstring);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("No room with those criteria are available. Reservation will be added to the waitlist");
                                                }
                                            }
                                            else
                                            {
                                                // calculate price and create reservation
                                                Utilities calcPrice = new Utilities();
                                                double pricePerNight = calcPrice.getPricePerNight(Convert.ToInt32(cboxHotel.SelectedValue), roomAvailable[0]);
                                                double price = calcPrice.calculatePrice(((checkIn - checkOut).TotalDays), pricePerNight);
                                                int points = Convert.ToInt32(calcPrice.calculatePoints(((checkIn - checkOut).TotalDays)));
                                                Reservation createReservation = new Reservation();
                                                createReservation.makeReservation(hotelID, custID, custID, checkIn, checkOut, price, points, roomAvailable, occNum, currentDate);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("User ID is not a customer account");
                                    }
                                }
                                else
                                    throw new Exception("User account does not exist");

                                
                                
                                
                                //VERIFY RESERVATION DETAILS AND ADD RESERVATION TO DATABASE
                            }
                            else
                            {
                                throw new Exception("Invalid file format.");
                            }
                        }
                    }//end of file

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
                //display date of file and number of reservations read
                lblFileStatus.Text = "Date: " + fileDate + " Number of reservations: " + numReserv;
            }*/
        }

        private void btnNewHotel_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog resFile = new OpenFileDialog();
            resFile.Title = "Open Third Party Reservation File";
            resFile.Filter = "TXT files|*.txt";
            resFile.InitialDirectory = @"C:\";
            if (resFile.ShowDialog() == DialogResult.OK)
            {
                DateTime fileDate = new DateTime(2020, 1, 1);
                int hotelCount = 0;
                try
                {
                    string fileName = resFile.FileName;
                    string[] fileLines = File.ReadAllLines(fileName);
                    int hotelID = 0;

                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        int start = 0;
                        int position = fileLines[i].IndexOf(' ', start);
                        if (position >= 0)
                        {
                            string startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                            int year, month, day;

                            start = position + 1;
                            if (startCode == "D") //get line for new date
                            {
                                bool successYear = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                bool successMonth = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                bool successDay = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                if (successYear && successMonth && successDay) //able to get date
                                {
                                    fileDate = new DateTime(year, month, day);
                                    lblFileStatus.Text = "date: " + year + month + day;
                                }
                                else //invalid date
                                {
                                    throw new Exception("Unable to retrieve date.");
                                }
                            }
                            else if (startCode == "H") //get line for hotel information
                            {
                                string hotelName, hotelCity, hotelState;
                                position = fileLines[i].IndexOf(' ', start);
                                bool successHotelNum = int.TryParse(fileLines[i].Substring(start, position - start + 1), out hotelID); //set hotelID
                                if (!successHotelNum) 
                                {
                                    hotelID = 0;
                                    throw new Exception("Invalid hotel number");
                                }

                                else
                                {   // check if hotel ID already exists in DB
                                    Location HotelExists = new Location();
                                    if(HotelExists.hotelExists(hotelID))
                                    {
                                        hotelID = 0;
                                        throw new Exception("hotel already exists");
                                    }
                                    else
                                    {
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        hotelName = fileLines[i].Substring(start, position - start + 1).Trim();
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        hotelCity = fileLines[i].Substring(start, position - start + 1).Trim();
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        hotelState = fileLines[i].Substring(start).Trim();

                                        // insert hotel into database
                                        Location insertHotel = new Location();
                                        if(!(insertHotel.addLocation(hotelID, hotelName, hotelCity, hotelState)))
                                        {
                                            throw new Exception("Error inserting hotel into database. Contact database admin");
                                        }
                                    }
                                }
                                hotelCount++;
                            }
                            else if (startCode == "R") //get line for room information
                            {
                                if(hotelID == 0)
                                {
                                    throw new Exception("Hotel required to add new room.");
                                }
                                int roomNum, roomOcc;
                                decimal roomCost;
                                var roomPackages = new List<int>();

                                position = fileLines[i].IndexOf(' ', start);
                                bool successRoomNum = int.TryParse(fileLines[i].Substring(start, position - start + 1), out roomNum);
                                Room roomExists = new Room();
                                bool RoomExists = roomExists.roomExists(roomNum, hotelID);

                                // if roomNum exists at hotelID, do not add to DB
                                if(RoomExists)
                                {
                                    throw new Exception("Room number is already defined at that location");
                                }    
                                
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successRoomOcc;
                                if (startCode == "O")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successRoomOcc = int.TryParse(fileLines[i].Substring(start, position - start + 1), out roomOcc);
                                    if(!successRoomOcc || roomOcc < 1)
                                    {
                                        throw new Exception("Invalid occupancy number.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve room occupancy");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successRoomCost;
                                if (startCode == "C")
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    successRoomCost = decimal.TryParse(fileLines[i].Substring(start + 1, position - start), out roomCost);
                                    if (!successRoomCost || roomCost < 0)
                                    {
                                        throw new Exception("Invalid room cost.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve room cost");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                                bool successPack = true;
                                if (startCode == "P")
                                {
                                    while (successPack)
                                    {
                                        int pack;
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        if(position >=0)
                                        {
                                            successPack = int.TryParse(fileLines[i].Substring(start, position - start + 1), out pack);
                                        }
                                        else
                                        {
                                            successPack = int.TryParse(fileLines[i].Substring(start), out pack);
                                            successPack = false;
                                        }
                                        if (pack > 0)
                                        {
                                            Package packageExists = new Package(); 
                                            if(!packageExists.packageExists(pack))
                                            {
                                                throw new Exception("Invalid package ID.");
                                            }
                                            else
                                            {
                                                roomPackages.Add(pack);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to retrieve packages.");
                                }
                                if(roomPackages.Count <= 0)
                                {
                                    throw new Exception("Unable to retrieve packages.");
                                }

                                //Add room to hotel in DB

                                Room addRoom = new Room();
                                if (!(addRoom.addRoom(roomNum, hotelID, roomOcc, roomCost, roomPackages)))
                                {
                                    throw new Exception("Invalid file format.");
                                }
                            }
                        }
                    }//end of file
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
                lblFileStatus.Text = "Date: " + fileDate + " Number of hotels: " + hotelCount;
            }*/

        }

        private void btnNewPackages_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog resFile = new OpenFileDialog();
            resFile.Title = "Open Third Party Reservation File";
            resFile.Filter = "TXT files|*.txt";
            resFile.InitialDirectory = @"C:\";
            if (resFile.ShowDialog() == DialogResult.OK)
            {
                DateTime fileDate = new DateTime(2020, 1, 1);
                int packageCount = 0;
                try
                {
                    string fileName = resFile.FileName;
                    string[] fileLines = File.ReadAllLines(fileName);
                    int packID = 0;

                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        int start = 0;
                        int position = fileLines[i].IndexOf(' ', start);
                        if (position >= 0)
                        {
                            string startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                            int year, month, day;

                            start = position + 1;
                            if (startCode == "D") //get line for new date
                            {
                                bool successYear = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                bool successMonth = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                bool successDay = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                if (successYear && successMonth && successDay) //able to get date
                                {
                                    fileDate = new DateTime(year, month, day);
                                    lblFileStatus.Text = "date: " + year + month + day;
                                }
                                else //invalid date
                                {
                                    throw new Exception("Unable to retrieve date.");
                                }
                            }
                            else if (startCode == "P") //get line for package information
                            {
                                string packName;
                                decimal packCost;
                                position = fileLines[i].IndexOf(' ', start);
                                bool successPackID = int.TryParse(fileLines[i].Substring(start, position - start + 1), out packID); //set packid
                                Package packageExists = new Package();
                                if (packID <= 0)
                                {
                                    throw new Exception("Invalid package ID.");
                                }
                                //If package exists in DB, throw exception
                                else if (packageExists.packageExists(packID))
                                {
                                    throw new Exception("Package already exists.");
                                }
                                else
                                {
                                    start = position + 1;
                                    position = fileLines[i].IndexOf(' ', start);
                                    packName = fileLines[i].Substring(start, position - start + 1).Trim();

                                    //If package name exists already, throw exception
                                    DBConnect checkForPackNameConn = new DBConnect();
                                    MySqlCommand checkForPackName = new MySqlCommand("SELECT COUNT(*) from dbo.package where packageName = @packName");
                                    checkForPackName.Parameters.Add("@packName", MySqlDbType.VarChar, 45).Value = packName;
                                    if (checkForPackNameConn.intScalar(checkForPackName) > 0)
                                    {
                                        throw new Exception("A package with that name already exists.");
                                    }
                                    else
                                    {
                                        start = position + 1;
                                        position = fileLines[i].IndexOf(' ', start);
                                        bool successPackCost = decimal.TryParse(fileLines[i].Substring(start + 1), out packCost); //set pack cost
                                        if (packCost < 0)
                                        {
                                            throw new Exception("Invalid package cost.");
                                        }
                                        else
                                        {
                                            //add package to database
                                            Package insertPackage = new Package();
                                            if (insertPackage.addPackage(packID, packName, packCost))
                                                packageCount++;
                                            else
                                                throw new Exception("Error inserting package to database");
                                        }
                                    }
                                }
                            }
                            else if (startCode == "A") //get line for package information
                            {
                                if (packID <= 0)
                                {
                                    throw new Exception("Unable to add amenity without valid package.");
                                }
                                string amenity;
                                amenity = fileLines[i].Substring(position).Trim();

                                // If amenity doesn't exist
                                DBConnect checkForAmenityConn = new DBConnect();
                                MySqlCommand checkForAmenity = new MySqlCommand("select count(*) from amenity where description = @amenity");
                                checkForAmenity.Parameters.Add("@amenity", MySqlDbType.VarChar, 45).Value = amenity;
                                if (checkForAmenityConn.intScalar(checkForAmenity) < 1)
                                {    // Insert into DB
                                    DBConnect insertAmenityConn = new DBConnect();
                                    MySqlCommand insertAmenity = new MySqlCommand("INSERT INTO `dbo`.`amenity` (`description`) VALUES (@amenity)");
                                    insertAmenity.Parameters.Add("@amenity", MySqlDbType.VarChar, 45).Value = amenity;
                                    insertAmenityConn.NonQuery(insertAmenity);

                                    if (insertAmenityConn.NonQuery(insertAmenity) < 1)
                                    {
                                        throw new Exception("Error inserting amenity into database. Contact database admin");
                                    }
                                    else
                                    {
                                        //Add amenity-package relationship in DB
                                        DBConnect getAmenityIDConn = new DBConnect();
                                        MySqlCommand getAmenityID = new MySqlCommand("SELECT amenityID from amenity where description = @amenity");
                                        int amenityID = getAmenityIDConn.intScalar(getAmenityID);
                                        if (amenityID == -1)
                                        {
                                            throw new Exception("Error inserting amenity into database. Contact database admin");
                                        }
                                        else
                                        {
                                            DBConnect insertAmenityRelationConn = new DBConnect();
                                            MySqlCommand insertAmenityRelation = new MySqlCommand("INSERT INTO `dbo`.`relation_package_amenity` (`packageID`, `amenityID`) VALUES (@packID, @amenityID)");
                                            insertAmenityRelation.Parameters.Add("@packID", MySqlDbType.Int32).Value = packID;
                                            insertAmenityRelation.Parameters.Add("@amenityID", MySqlDbType.Int32).Value = amenityID;

                                            if (insertAmenityRelationConn.NonQuery(insertAmenityRelation) < 1)
                                            {
                                                throw new Exception("Error inserting amenity into database. Contact database admin");
                                            }
                                        }
                                    }
                                }
                                packageCount++;
                               }
                            else
                            {
                                throw new Exception("Invalid file format.");
                            }
                        }
                    }//end of file
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
                lblFileStatus.Text = "Date: " + fileDate + " Number of packages: " + packageCount;
            }*/
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog resFile = new OpenFileDialog();
            resFile.Title = "Open Third Party Reservation File";
            resFile.Filter = "TXT files|*.txt";
            resFile.InitialDirectory = @"C:\";
            if (resFile.ShowDialog() == DialogResult.OK)
            {
                DateTime fileDate = new DateTime(2020, 1, 1);
                int maintainCount = 0;
                try
                {
                    string fileName = resFile.FileName;
                    string[] fileLines = File.ReadAllLines(fileName);
                    DateTime maintainDate = DateTime.Now;
                    int hotelID = 0;
                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        int start = 0;
                        int position = fileLines[i].IndexOf(' ', start);
                        if (position >= 0)
                        {
                            string startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                            int year, month, day;

                            start = position + 1;
                            if (startCode == "D") //get line for new date
                            {
                                bool successYear = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                bool successMonth = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                bool successDay = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                if (successYear && successMonth && successDay) //able to get date
                                {
                                    fileDate = new DateTime(year, month, day);
                                    lblFileStatus.Text = "date: " + year + month + day;
                                }
                                else //invalid date
                                {
                                    throw new Exception("Unable to retrieve date.");
                                }
                            }
                            else if (startCode == "M") //get line for maintainance date
                            {
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                bool successYear = int.TryParse(fileLines[i].Substring(start, 4), out year);
                                bool successMonth = int.TryParse(fileLines[i].Substring(start + 4, 2), out month);
                                bool successDay = int.TryParse(fileLines[i].Substring(start + 6, 2), out day);
                                if (successYear && successMonth && successDay) //able to get date
                                {
                                    maintainDate = new DateTime(year, month, day);
                                    lblFileStatus.Text = "date: " + year + month + day;
                                }
                                else //invalid date
                                {
                                    throw new Exception("Unable to retrieve date.");
                                }
                            }
                            else if (startCode == "H") //get line for hotel ID
                            {
                                bool successHotel = int.TryParse(fileLines[i].Substring(start), out hotelID);
                                Location HotelExists = new Location();
                                if(!successHotel || hotelID < 0 || (!HotelExists.hotelExists(hotelID))) // IF HOTEL DOESNT EXIST THROW EXCEPTION
                                {
                                    throw new Exception("Unable to retrieve hotel ID.");
                                }
                            }
                            else if (startCode == "R") //get line for room ID
                            {
                                int roomNum;
                                bool successRoom = int.TryParse(fileLines[i].Substring(start), out roomNum);
                                Room roomExists = new Room();
                                bool RoomExists = roomExists.roomExists(roomNum, hotelID);
                                // if room doesn't exist, throw exception
                                if (!successRoom || roomNum < 0 || !RoomExists) 
                                {
                                    throw new Exception("Unable to retrieve room number.");
                                }

                                //Insert maintenance record in database
                                DBConnect insertMaintenanceConn = new DBConnect();
                                MySqlCommand insertMaintenance = new MySqlCommand(@"INSERT INTO `dbo`.`maintenance`(`locationID`,`mainteanceDate`,`roomNum`)
                                                                                    VALUES(@hotelID, @maintainDate, @roomNum");
                                insertMaintenance.Parameters.Add("@hotelID", MySqlDbType.Int32).Value = hotelID;
                                insertMaintenance.Parameters.Add("@maintainDate", MySqlDbType.Date).Value = maintainDate;
                                insertMaintenance.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
                                if (insertMaintenanceConn.NonQuery(insertMaintenance) < 1)
                                {
                                    throw new Exception("Error inserting maintenance record. Contact database admin");
                                }
                                else
                                {
                                    maintainCount++;
                                }
                            }
                            else
                            {
                                throw new Exception("Invalid file format.");
                            }
                        }
                    }//end of file
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
                lblFileStatus.Text = "Date: " + fileDate + " Number of unavailable rooms: " + maintainCount;
            }*/
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnClose_Click(object sender, EventArgs eventArgs)
        {
            System.Windows.Forms.Application.Exit();
        }
    
        private void lstReports_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstReports.SelectedItem.ToString() == "Customer History" || lstReports.SelectedItem.ToString() == "Employee History")
            {
                cboxHotel.Enabled = false;
            }
        }

        // DESCRIPTION: Pulls specified report
        private void btnReport_Click_1(object sender, EventArgs e)
        {
            lblError.Visible = false;
            // if no report selected
            if (lstReports.SelectedIndex == -1)
            {
                displayError("Please select a report to run");
            }
            else
            {
                if (lstReports.SelectedItem.ToString() == "Customer History" || lstReports.SelectedItem.ToString() == "Employee History")
                {
                    // if no user ID entered
                    if (string.IsNullOrWhiteSpace(txtUser.Text))
                    {
                        displayError("User ID not entered");
                    }
                    else
                    {   Utilities userReport = new Utilities();
                        // verify user ID exists
                        if (userReport.userIDExists(Convert.ToInt32(txtUser.Text)))
                        {   // verify user ID is a customer account
                            if (lstReports.SelectedItem.ToString() == "Customer History")
                            {
                                if (userReport.isCustomer(Convert.ToInt32(txtUser.Text)))
                                {   // pull report
                                    var customerHistory = new ReportViewer("customerHistory", Convert.ToInt32(txtUser.Text));
                                    customerHistory.FormClosed += new FormClosedEventHandler(userHistory_FormClosed);
                                    this.Hide();
                                    customerHistory.Show();
                                }
                                else
                                {
                                    displayError("User ID is not a customer");
                                }
                            }
                            else if (lstReports.SelectedItem.ToString() == "Employee History")
                            {
                                if (!(userReport.isCustomer(Convert.ToInt32(txtUser.Text))))
                                {   // pull report
                                    var employeeHistory = new ReportViewer("employeeHistory", Convert.ToInt32(txtUser.Text));
                                    employeeHistory.FormClosed += new FormClosedEventHandler(userHistory_FormClosed);
                                    this.Hide();
                                    employeeHistory.Show();
                                }
                                else
                                {
                                    displayError("User ID is not an emploee");
                                }
                            }
                        }
                        else
                        {
                            displayError("User ID does not exist");
                        }
                    }                  
                }
            }
        }

        private void userHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnHotelSettings_Click(object sender, EventArgs e)
        {
            var hotelSett = new HotelSettings(UserID, currentDate);
            hotelSett.FormClosed += new FormClosedEventHandler(hotelSett_FormClosed);
            this.Hide();
            hotelSett.Show();
        }
        void hotelSett_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
