using Hotel_Reservation_Overhaul.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class Menu : Form
    {
        private int UserID;
        public Menu()
        {
            InitializeComponent();
        }

        // DESCRIPTION: Initializer. Shows/hides hotel management button based on isCustomer
        public Menu(bool isCustomer, int userID)
        {
            InitializeComponent();
            UserID = userID;
            if (isCustomer == true)
                btnHotelManagement.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
        void resMgmt_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }

        // DESCRIPTION: Opens Reservation Management page
        private void btnReservations_Click(object sender, EventArgs e)
        {
            var reservationMgmt = new ReservationList(UserID);
            reservationMgmt.FormClosed += new FormClosedEventHandler(resMgmt_FormClosed);
            this.Hide();
            reservationMgmt.Show();
        }

        private void btnHotelManagement_Click(object sender, EventArgs e)
        {
            var hotelMgmt = new HotelManagement();
            hotelMgmt.Show();
            this.Hide();
        }
    }
}
