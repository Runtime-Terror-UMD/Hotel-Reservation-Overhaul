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

namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class HotelSettings : Form
    {
        private int UserID;
        public HotelSettings(int userID)
        {
            InitializeComponent();
            UserID = userID;
            //get hotel settings from file
            decimal minCharge, cancelFee;
            int cancelDays, notifyDays, pointDays;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            decimal.TryParse(fileLines[0].Substring(fileLines[0].IndexOf(' ')), out minCharge);
            decimal.TryParse(fileLines[1].Substring(fileLines[1].IndexOf(' ')), out cancelFee);
            int.TryParse(fileLines[2].Substring(fileLines[2].IndexOf(' ')), out cancelDays);
            int.TryParse(fileLines[3].Substring(fileLines[3].IndexOf(' ')), out pointDays);
            int.TryParse(fileLines[4].Substring(fileLines[4].IndexOf(' ')), out notifyDays);
            txtMinimumCharge.Text = "" + minCharge;
            txtCancelationFee.Text = "" + cancelFee;
            txtCancelationWindow.Text = "" + cancelDays;
            txtPointsPerDay.Text = "" + pointDays;
            txtNotifyCustomer.Text = "" + notifyDays;
        }

        private void displayMessage(string message, bool error)
        {
            lblError.Visible = true;
            lblError.Text = message;
            if (error)
            {
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblError.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnMinCharge_Click(object sender, EventArgs e)
        {
            decimal minCharge;
            bool success = decimal.TryParse(txtMinimumCharge.Text, out minCharge);
            if(success && minCharge >=0)
            {
                displayMessage("Minimum charge changed successfully.", false);
            }
            else
            {
                displayMessage("Minimum charge could not be changed.", true);
            }
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            using (StreamWriter sw = File.AppendText("tempHotelSettings.txt"))
            {
                for(int i = 0; i < fileLines.Length; i++)
                {
                    if(i == 0)
                    {
                        sw.WriteLine("MinimumCharge= " + minCharge);
                    }
                    else
                    {
                        sw.WriteLine(fileLines[i]);
                    }
                }    
            }
            File.Replace("tempHotelSettings.txt", "HotelSettings.txt", null);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelationFee_Click(object sender, EventArgs e)
        {
            decimal cancelFee;
            bool success = decimal.TryParse(txtCancelationFee.Text, out cancelFee);
            if (success && cancelFee >= 0)
            {
                displayMessage("Cancelation fee changed successfully.", false);
            }
            else
            {
                displayMessage("Cancelation fee could not be changed.", true);
            }
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            using (StreamWriter sw = File.AppendText("tempHotelSettings.txt"))
            {
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (i == 1)
                    {
                        sw.WriteLine("CancelFee= " + cancelFee);
                    }
                    else
                    {
                        sw.WriteLine(fileLines[i]);
                    }
                }
            }
            File.Replace("tempHotelSettings.txt", "HotelSettings.txt", null);
        }

        private void btnCancelationWindow_Click(object sender, EventArgs e)
        {
            int cancelDays;
            bool success = int.TryParse(txtCancelationWindow.Text, out cancelDays);
            if (success && cancelDays >= 0)
            {
                displayMessage("Cancelation window changed successfully.", false);
            }
            else
            {
                displayMessage("Cancelation window could not be changed.", true);
            }
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            using (StreamWriter sw = File.AppendText("tempHotelSettings.txt"))
            {
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (i == 2)
                    {
                        sw.WriteLine("CancelationFeeDays= " + cancelDays);
                    }
                    else
                    {
                        sw.WriteLine(fileLines[i]);
                    }
                }
            }
            File.Replace("tempHotelSettings.txt", "HotelSettings.txt", null);
        }

        private void btnPointsPerDay_Click(object sender, EventArgs e)
        {
            int points;
            bool success = int.TryParse(txtPointsPerDay.Text, out points);
            if (success && points >= 0)
            {
                displayMessage("Rewards points per day changed successfully.", false);
            }
            else
            {
                displayMessage("Rewards points per day could not be changed.", true);
            }
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            using (StreamWriter sw = File.AppendText("tempHotelSettings.txt"))
            {
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (i == 3)
                    {
                        sw.WriteLine("PointsPerDay= " + points);
                    }
                    else
                    {
                        sw.WriteLine(fileLines[i]);
                    }
                }
            }
            File.Replace("tempHotelSettings.txt", "HotelSettings.txt", null);
        }

        private void btnNotifyDays_Click(object sender, EventArgs e)
        {
            int waitlistDays;
            bool success = int.TryParse(txtNotifyCustomer.Text, out waitlistDays);
            if (success && waitlistDays >= 0)
            {
                displayMessage("Notification window changed successfully.", false);
            }
            else
            {
                displayMessage("Notification window could not be changed.", true);
            }
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            using (StreamWriter sw = File.AppendText("tempHotelSettings.txt"))
            {
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (i == 4)
                    {
                        sw.WriteLine("NotifyCustomerDays= " + waitlistDays);
                    }
                    else
                    {
                        sw.WriteLine(fileLines[i]);
                    }
                }
            }
            File.Replace("tempHotelSettings.txt", "HotelSettings.txt", null);
        }

        private void btnCustomerID_Click(object sender, EventArgs e)
        {
            Utilities account = new Utilities();
            int user;
            if(int.TryParse(txtCustomerID.Text, out user) && account.userIDExists(user))
            {
                int rewardsPoints = account.getRewardsPoints(user);
                txtCustomerRewards.Text = "" + rewardsPoints;
                txtCustomerRewards.Visible = true;
                btnCustomerRewards.Visible = true;
                txtCustomerID.Enabled = false;
                btnCustomerID.Enabled = false;
                btnReset.Visible = true;
                lblCustomerPoints.Visible = true;
                txtAdjustPoints.Visible = true;
                lblAdjustPoints.Visible = true;
            }
            else
            {
                displayMessage("Invalid user ID", true);
            }
        }

        private void btnCustomerRewards_Click(object sender, EventArgs e)
        {
            Utilities account = new Utilities();
            int rewards;
            int user;
            int.TryParse(txtCustomerID.Text, out user);
            int points = account.getRewardsPoints(user);
            if (int.TryParse(txtAdjustPoints.Text, out rewards)) //rewards is the added/removed points amount
            {
                points = points + rewards;
                if(points >= 0 && account.setRewardsPoints(user, points, UserID))
                {
                    displayMessage("Rewards points updated for " + user, false);
                    txtCustomerRewards.Text = "" + points;
                    txtAdjustPoints.Clear();
                    //TODO: add rewards tracking here
                }
                else
                {
                    displayMessage("Unable to update points.", true);
                }
            }
            else
            {
                displayMessage("Invalid point amount", true) ;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            btnCustomerID.Enabled = true;
            txtCustomerRewards.Visible = false;
            btnCustomerRewards.Visible = false;
            txtAdjustPoints.Visible = false;
            lblAdjustPoints.Visible = false;
            lblCustomerPoints.Visible = false;
            lblAdjustPoints.Visible = false;
            btnReset.Visible = false;
            txtCustomerRewards.Clear();
            txtAdjustPoints.Clear();
            txtCustomerID.Clear();
        }
    }
}
