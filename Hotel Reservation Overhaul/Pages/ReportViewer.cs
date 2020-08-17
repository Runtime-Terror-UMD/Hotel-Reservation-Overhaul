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
            DBConnect reportConn = new DBConnect();
            DataTable ReportData = new DataTable();
            BindingSource bindingSource1 = new BindingSource();

            InitializeComponent();
            reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (report == "customerHistory")
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
                    MySqlCommand cmd = new MySqlCommand(@"select al.created 'Action Date',
	                                                     concat(activityTypeDescription, al.refID) Action
                                                         from activitylog al
                                                        join activitytype at
	                                                    on at.activityTypeID = al.activityTypeID
                                                        where al.userID = @userID
                                                        and al.created BETWEEN @startDate and @endDate");
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
                    ReportData = reportConn.ExecuteDataTable(cmd);
                    bindingSource1.DataSource = ReportData;
                    reportDataGrid.DataSource = bindingSource1;
                    }
  
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
            else if(report == "employeeHistory")
            {
                lblDescribe.Text = "Employee History Report";
                User userInfo = new User(userID);
                lblAccountID.Text = userID.ToString();
                lblFirstName.Text = userInfo.firstName;
                lblLastName.Text = userInfo.lastName;
                lblEmail.Text = userInfo.email;
                lblUsername.Text = userInfo.username;
                lblRewardsPoints.Visible = false;
                lblRewardDesc.Visible = false;

                try
                {
                    // build and execute query
                    MySqlCommand cmd = new MySqlCommand(@"select al.created 'Action Date',
	                                                        concat(activityTypeDescription, al.refID ', customer ID ', al.userID) ) Action
                                                             from activitylog al
                                                            join activitytype at
                                                                on at.activityTypeID = al.activityTypeID
                                                            where al.createdBy = @userID");
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
                    ReportData = reportConn.ExecuteDataTable(cmd);
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            else if(report == "RewardSummary")
            {

            }
            else if(report == "OccupancySummary")
            {

            }   
            else if(report == "CustomerSummary")
            {

            }

            bindingSource1.DataSource = ReportData;
            reportDataGrid.DataSource = bindingSource1;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
             this.Close();
            Application.OpenForms["HotelManagement"].Close();
            Application.OpenForms["Menu"].Close();           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
