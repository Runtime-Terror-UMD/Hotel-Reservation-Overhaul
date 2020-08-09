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

        public Menu(int isCustomer, int userID)
        {
            InitializeComponent();
            if (isCustomer == 1)
                btnHotelManagement.Visible = false;
            UserID = userID;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
