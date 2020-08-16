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
    public partial class Payment : Form
    {
        User userInfo;
        Reservation resInfo;
        private DateTime currentDate;
        public Payment(int confirmationID, int userID, DateTime current)
        {
            InitializeComponent();
            currentDate = current;
            resInfo = new Reservation(confirmationID);
            userInfo = new User(userID);
            lblPoints.Text = "" + userInfo.rewardPoints;
            dateTimePicker1.Value = currentDate;
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
    }
}
