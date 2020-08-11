using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class Reservation : Form
    {
        public DateTime startDate = DateTime.Today;
        public DateTime endDate = DateTime.Today.AddDays(1.0);  

        public Reservation(int userID)
        {
            InitializeComponent();
            PopulateCheckBoxes();
            cboxHotel.SelectedItem = null;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void displayError(string message)
        {
            lblError.Visible = true;
            lblError.Text = "Error: " + message;
        }
        // DESCRIPTION: Populates location combobox
        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmgmt1.package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.hotelmgmt1.package);
            // TODO: This line of code loads data into the 'hotelmgmt.package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.hotelmgmt.package);
            // TODO: This line of code loads data into the 'hotelmgmt.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this.hotelmgmt.location);

        }

        private void PopulateCheckBoxes()
        {
            DBConnect checkBoxConn = new DBConnect();
            string checkBoxQuery = "SELECT packageName FROM dbo.package";
            MySqlCommand cmd = new MySqlCommand(checkBoxQuery);
            checkBoxConn.OpenConnection();
            DataTable checkBoxDT = checkBoxConn.ExecuteDataTable(cmd);

            foreach (DataRow row in checkBoxDT.Rows)
            {
                string package = row["packageName"].ToString();
                checkPackages.Items.Add(package);
            }

            checkBoxConn.CloseConnection();
        }

      

        private void monthStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblError.Visible = false;
            startDate = monthStart.SelectionStart;
            if(startDate < DateTime.Today)
            {
                displayError("Selected start date cannot be in the past");
                lblStartDate.Text = "Start Date: ";
            }
            else
            {
                lblStartDate.Text = "Start Date: " + monthStart.SelectionStart.ToShortDateString();
            }
        }

        private void monthend_dateSelected(object sender, DateRangeEventArgs e)
        {
            lblError.Visible = false;
            endDate = monthEnd.SelectionStart;
            if(endDate < startDate)
            {
                displayError("Selected end date is earlier than selected start date");
                lblEndDate.Text = "End Date: ";
            }
            else
            {
                lblEndDate.Text = "End Date: " + monthEnd.SelectionStart.ToShortDateString();
            }
        }
    }
}
