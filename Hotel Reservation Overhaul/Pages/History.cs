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
    public partial class History : Form
    {
        public History(int userID)
        {
            
            InitializeComponent();

            User userInfo = new User(userID);
            lblAccountID.Text = userID.ToString();
            lblFirstName.Text = userInfo.firstName;
            lblLastName.Text = userInfo.lastName;
            lblEmail.Text = userInfo.email;
            lblUsername.Text = userInfo.username;
            lblRewardsPoints.Text = userInfo.rewardPoints.ToString();

            DBConnect reportConn = new DBConnect();
            DataTable ReportData = new DataTable();
            BindingSource bindingSource1 = new BindingSource();
            MySqlCommand cmd = new MySqlCommand();

            if (userInfo.isCustomer == true)
            {
                try
                {
                    cmd.CommandText = @"select al.created 'Action Date',
                                                        case 
	                                                        when al.activityTypeID in (1,2,3) then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID) 
                                                            when al.activityTypeID = 8 then concat(atype.activityTypeDescription, '- Pay ID: ', al.refID) 
	                                                        when al.activityTypeID = 4 then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID) 
	                                                        when al.activityTypeID = 5 then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID) 
                                                           end as 'Activity'
                                                        from activitylog al
                                                        join activitytype atype
                                                            on atype.activityTypeID = al.activityTypeID
                                                        left join payment p
	                                                        on p.paymentID = al.refID
                                                            and al.activityTypeID = 8
                                                        where al.userID = @userID 
                                                        and al.createdBy = @userID
                                                        order by al.created desc";
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

                    ReportData = reportConn.ExecuteDataTable(cmd);
                    bindingSource1.DataSource = ReportData;
                    reportDataGrid.DataSource = bindingSource1;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            else
            {
                try
                {
                    cmd.CommandText = @"select al.created 'Action Date',
                                     case 
	                                     when al.activityTypeID in (1,2,3) then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID, ' - Customer ID ',al.userID) 
                                         when al.activityTypeID = 6 then concat(atype.activityTypeDescription, ' - Points: ', rl.pointsAmount, ' - Customer ID ',al.userID) 
                                         when al.activityTypeID = 8 then concat('Processed customer payment '- Pay ID: ', al.refID, ' - Customer ID ',al.userID) 
	                                     when al.activityTypeID = 4 then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID, ' - Customer ID ',al.userID) 
	                                     when al.activityTypeID = 5 then concat(atype.activityTypeDescription, ' - Confirmation ID: ', al.refID, ' - Customer ID ',al.userID) 
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
                                     order by al.created desc";
                    cmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = userID;

                    ReportData = reportConn.ExecuteDataTable(cmd);
                    bindingSource1.DataSource = ReportData;
                    reportDataGrid.DataSource = bindingSource1;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
    }
}
