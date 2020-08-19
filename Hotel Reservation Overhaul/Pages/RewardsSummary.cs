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
    public partial class RewardsSummary : Form
    {
        public RewardsSummary(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.dateStart.Value = startDate;
            this.dateEnd.Value = endDate;
        }

        //rewards outstanding to all customers on date x
        private void btnOutstanding_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }
        //rewards redeemed between date x and date y inclusive by z customers
        private void btnRedeemed_Click(object sender, EventArgs e)
        {
            //get information from database and display it in list box
        }
        //rewards earned between date x and date y inclusive
        private void btnEarned_Click(object sender, EventArgs e)
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
