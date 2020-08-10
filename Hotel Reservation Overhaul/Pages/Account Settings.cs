using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class AccountSettings : Form
    {
        public AccountSettings(int userID)
        {
            InitializeComponent();
            User userInfo = new User(userID);
            if(userInfo.isCustomer == 1)
            {

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
