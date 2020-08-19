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
    public partial class OccupancySummary : Form
    {
        public OccupancySummary(DateTime startDate, DateTime endDate, string hotel)
        { 
            InitializeComponent();
            this.dateStart.Value = startDate;
            this.dateEnd.Value = endDate;
            this.txtHotel.Text = hotel;
        }

        private void btnUnOccupied_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnOccupied_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }

        private void btnRevenue_Click(object sender, EventArgs e)
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
