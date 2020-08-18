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
            DBConnect reportConn = new DBConnect();
            DataTable ReportData = new DataTable();
            BindingSource bindingSource1 = new BindingSource();

            InitializeComponent();
            try
            {
                // build and execute query
                MySqlCommand cmd = new MySqlCommand(@"select al.created 'Action Date',
	                                                     concat(activityTypeDescription, al.refID) Action
                                                         from activitylog al
                                                        join activitytype at
	                                                    on at.activityTypeID = al.activityTypeID
                                                        where al.userID = @userID");
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
