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
            this.lblFromDate.Text= startDate.ToString("MM'/'dd'/'yyyy");
            this.lblToDate.Text = endDate.ToString("MM'/'dd'/'yyyy");
        }

    }
}
