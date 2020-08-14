using MySql.Data.MySqlClient;
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
    public partial class ReportViewer : Form
    {
        public ReportViewer(string report, int userID)
        {
            BindingSource bindingSource1 = new BindingSource();
            InitializeComponent();
            if(report == "customerHistory")
            {
                lblDescribe.Text = "Customer History Report";
                User userInfo = new User(userID);
                lblAccountID.Text = userID.ToString();
                lblFirstName.Text = userInfo.firstName;
                lblLastName.Text = userInfo.lastName;
                lblEmail.Text = userInfo.email;
                lblUsername.Text = userInfo.username;
                lblRewardsPoints.Text = userInfo.rewardPoints.ToString();

                try
                {
                    // build and execute query
                    DBConnect custHistoryConn = new DBConnect();                  
                    MySqlCommand cmd = new MySqlCommand(@"select al.created 'Action Date',
	                                                     concat(activityTypeDescription, al.refID) Action
                                                         from activitylog al
                                                        join activitytype at
	                                                        on at.activityTypeID = al.activityTypeID
                                                        where al.userID = @userID");
                    cmd.Parameters.AddWithValue("@userID", userID);
                    DataTable customerHistoryReport = custHistoryConn.ExecuteDataTable(cmd);
                    bindingSource1.DataSource = customerHistoryReport;
                    reportDataGrid.DataSource = bindingSource1;
                    }
  
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
             this.Close();
              Application.OpenForms["Menu"].Close();           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
