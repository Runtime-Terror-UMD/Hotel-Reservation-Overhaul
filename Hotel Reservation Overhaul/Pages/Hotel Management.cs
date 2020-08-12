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
                try
                {
                    DateTime fileDate = new DateTime(2020, 1, 1);
                    string fileName = resFile.FileName;
                    string[] fileLines = File.ReadAllLines(fileName);
                    for(int i = 0; i < fileLines.Length; i++)
                    { //new line
                      //get position of space char
                        int start = 0; 
                        int position = fileLines[i].IndexOf(' ', start);
                        if (position >= 0)
                        {
                            string startCode = fileLines[i].Substring(start, position - start + 1).Trim();
                            int year, month, day;
                            int resID, custID, hotelID, occNum, credit;
                            decimal charge;
                            var packages = new List<int>();
                            DateTime checkIn, checkOut;
                            bool redeemRew;
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
                            }
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. " + ex.Message);
                }
            }





        }
    }
}
