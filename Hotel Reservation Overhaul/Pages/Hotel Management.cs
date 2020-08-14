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
    public partial class HotelManagement : Form
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstReports.SelectedItem.ToString() == "Customer History")
            {
                cboxHotel.Enabled = false;
            }
        }
    }
}
