using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Reservation_Overhaul.Pages;

namespace Hotel_Reservation_Overhaul
{
    public partial class Menu : Form
    {
        public int UserID;
        private DateTime currentDate;
        Login loginWind;
        public Menu(Login loginInstance, DateTime current)
        {
            InitializeComponent();
            currentDate = current;
            loginWind = loginInstance;
            lblNotification.Text = "Current Date: " + currentDate.Date;
        }

        // DESCRIPTION: Initializer. Shows/hides hotel management button based on isCustomer
        public Menu(bool isCustomer, int userID, Login loginInstance, DateTime current)
        {
            InitializeComponent();
            loginWind = loginInstance;
            UserID = userID;
            if (isCustomer == true)
                btnHotelManagement.Visible = false;
            currentDate = current;
            lblNotification.Text = "Current Date: " + currentDate.Date;

        }
        //DESCRIPTION: Opens account settings page
        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountSettings = new AccountSettings(UserID);
            accountSettings.FormClosed += new FormClosedEventHandler(accountSettings_FormClosed);
            this.Hide();
            accountSettings.Show();
        }
        void accountSettings_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }
        void resMgmt_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }

        // DESCRIPTION: Opens Reservation Management page
        private void btnReservations_Click(object sender, EventArgs e)
        {
            var reservationMgmt = new ReservationList(UserID, currentDate);
            reservationMgmt.FormClosed += new FormClosedEventHandler(resMgmt_FormClosed);
            this.Hide();
            reservationMgmt.Show();
        }

        private void btnHotelManagement_Click(object sender, EventArgs e)
        {
            var hotelMgmt = new HotelManagement(UserID, currentDate, this);
            hotelMgmt.FormClosed += new FormClosedEventHandler(hotMgmt_FormClosed);
            this.Hide();
            hotelMgmt.Show();
        }

        public void updateDate(DateTime newDay)
        {
            currentDate = newDay;
            lblNotification.Text = "Current Date: " + currentDate.Date;
            loginWind.updateDate(newDay);
        }

        void hotMgmt_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = new History(UserID);
            history.FormClosed += new FormClosedEventHandler(history_FormClosed);
            this.Hide();
            history.Show();
        }

        private void history_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


    }
}
