﻿using MySql.Data.MySqlClient;
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
    public partial class ReservationList : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;

        public ReservationList(int userID)
        {
            InitializeComponent();
            User userinfo = new User(userID);
            if (userinfo.isCustomer == 1)
            {

                DBConnect reservationListConn = new DBConnect();

            }
        }
    }
}
