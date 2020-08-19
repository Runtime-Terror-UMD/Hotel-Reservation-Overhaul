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
    public partial class CustomerSummary : Form
    {
        public CustomerSummary(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.dateStart.Value = startDate;
            this.dateEnd.Value = endDate;
        }

        private void btnRepeatCx_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnUpgrades_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["HotelManagement"].Close();
            Application.OpenForms["Menu"].Close();
        }
    }
}
