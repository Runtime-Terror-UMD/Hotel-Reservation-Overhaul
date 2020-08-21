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
        public ReportViewer(string report, int userID, DateTime startDate, DateTime endDate)
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
                                                        case 
	                                                        when al.activityTypeID in (1,2,3) then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
                                                            when al.activityTypeID = 6 then concat(atype.activityTypeDescription, ' - Points: ', rl.pointsAmount, ' - Customer ID ',al.userID) 
                                                            when al.activityTypeID = 8 then concat(atype.activityTypeDescription, '- Pay ID: ', al.refID, ' - Customer ID ',al.userID) 
	                                                        when al.activityTypeID = 4 then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
	                                                        when al.activityTypeID = 5 then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
                                                           end as 'Activity'
                                                        from activitylog al
                                                        join activitytype atype
                                                            on atype.activityTypeID = al.activityTypeID
                                                        left join reward_log rl
	                                                        on rl.rewardLogID = al.refID
                                                            and al.activityTypeID = 6
                                                        left join payment p
	                                                        on p.paymentID = al.refID
                                                            and al.activityTypeID = 8
                                                        where al.userID = @userID
                                                        and al.created between @startDate and @endDate");
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
                    cmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
                    cmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;
                    ReportData = reportConn.ExecuteDataTable(cmd);
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
                                                        case 
	                                                        when al.activityTypeID in (1,2,3) then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
                                                            when al.activityTypeID = 6 then concat(atype.activityTypeDescription, ' - Points: ', rl.pointsAmount, ' - Customer ID ',al.userID) 
                                                            when al.activityTypeID = 8 then concat(atype.activityTypeDescription, '- Pay ID: ', al.refID, ' - Customer ID ',al.userID) 
	                                                        when al.activityTypeID = 4 then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
	                                                        when al.activityTypeID = 5 then concat(atype.activityTypeDescription, ' - ', al.refID, ' - Customer ID ',al.userID) 
                                                           end as 'Activity'
                                                        from activitylog al
                                                        join activitytype atype
                                                            on atype.activityTypeID = al.activityTypeID
                                                        left join reward_log rl
	                                                        on rl.rewardLogID = al.refID
                                                            and al.activityTypeID = 6
                                                        left join payment p
	                                                        on p.paymentID = al.refID
                                                            and al.activityTypeID = 8
                                                        where al.createdBy = @createdBy
                                                        and al.created between @startDate and @endDate");
                    cmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = userID;
                    cmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
                    cmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;
                    ReportData = reportConn.ExecuteDataTable(cmd);
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
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
