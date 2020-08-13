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


namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class HotelManagement : Form
    {
        public HotelManagement(int userID)
        {
            InitializeComponent();
        }

        private void btnThirdParty_Click(object sender, EventArgs e)
        {
            OpenFileDialog resFile = new OpenFileDialog();
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
            }
        }

        private void btnNewHotel_Click(object sender, EventArgs e)
        {
            OpenFileDialog resFile = new OpenFileDialog();
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
                                if(!successHotelNum) //INSERT CODE TO VERIFY HOTELID DOES NOT EXIST
                                {
                                    hotelID = 0;
                                    throw new Exception("Invalid hotel number");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                hotelName = fileLines[i].Substring(start, position - start + 1).Trim();
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                hotelCity = fileLines[i].Substring(start, position - start + 1).Trim();
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                hotelState = fileLines[i].Substring(start).Trim();

                                //INSERT CODE TO VERIFY HOTELID DOES NOT EXIST AND ADD TO DATABASE
                                //IF HOTEL ID EXISTS, CHANGE HOTEL ID TO 0
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
                                //IF ROOMNUM EXISTS AT HOTEL, DO NOT ADD

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
                                            //IF PACK IS NOT IN DB, DO NOT ADD
                                            roomPackages.Add(pack);
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

                                //ADD ROOM TO HOTEL IN DB

                            }
                            else
                            {
                                throw new Exception("Invalid file format.");
                            }
                        }
                    }//end of file
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
                lblFileStatus.Text = "Date: " + fileDate + " Number of hotels: " + hotelCount;
            }

        }

        private void btnNewPackages_Click(object sender, EventArgs e)
        {
            OpenFileDialog resFile = new OpenFileDialog();
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
                                if (packID <= 0)
                                {
                                    //IF PACKAGE ID EXISTS, THROW EXCEPTION
                                    throw new Exception("Invalid package ID.");
                                }
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                packName = fileLines[i].Substring(start, position - start + 1).Trim();
                                //IF PACKAGE NAME EXISTS, THROW EXCEPTION
                                start = position + 1;
                                position = fileLines[i].IndexOf(' ', start);
                                bool successPackCost = decimal.TryParse(fileLines[i].Substring(start + 1), out packCost); //set pack cost
                                if (packCost < 0)
                                {
                                    throw new Exception("Invalid package cost.");
                                }
                                //ADD PACKAGE TO DATABASE
                                packageCount++;
                            }
                            else if (startCode == "A") //get line for package information
                            {
                                if(packID <= 0)
                                {
                                    throw new Exception("Unable to add amenity without valid package.");
                                }
                                string amenity;
                                amenity = fileLines[i].Substring(position).Trim();
                                //ADD AMENITY PACKAGE IN DATABASE
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
            }
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            OpenFileDialog resFile = new OpenFileDialog();
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
                    DateTime maintainDate;
                    int hotelID;
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
                                if(!successHotel || hotelID < 0) // IF HOTEL DOESNT EXIST THROW EXCEPTION
                                {
                                    throw new Exception("Unable to retrieve hotel ID.");
                                }
                            }
                            else if (startCode == "R") //get line for room ID
                            {
                                int roomNum;
                                bool successRoom = int.TryParse(fileLines[i].Substring(start), out roomNum);
                                if (!successRoom || roomNum < 0) // IF ROOM DOESNT EXIST THROW EXCEPTION
                                {
                                    throw new Exception("Unable to retrieve room number.");
                                }
                                //SET ROOMNUM IN HOTELID TO UNAVAILABLE ON MAINTAINDATE
                                maintainCount++;
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
            }
        }
    }
}
