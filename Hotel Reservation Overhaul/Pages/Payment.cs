﻿using System;
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
    public partial class Payment : Form
    {
        User userInfo;
        CreateReservation resInfo;
        public Payment(int confirmationID, int userID)
        {
            InitializeComponent();
            resInfo = new CreateReservation(confirmationID);
            userInfo = new User(userID);
            lblPoints.Text = "" + userInfo.rewardPoints;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ReservationList"].Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
