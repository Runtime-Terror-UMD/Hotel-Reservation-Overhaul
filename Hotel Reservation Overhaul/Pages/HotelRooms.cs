using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class HotelRooms : Form
    {
        public HotelRooms()
        {
            DBConnect reportConn = new DBConnect();
            DataTable ReportData = new DataTable();
            BindingSource bindingSource1 = new BindingSource();

            InitializeComponent();
            hotelDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // build and execute query
                MySqlCommand cmd = new MySqlCommand("SELECT locationName, locationCity, locationState, locationID from location");
                ReportData = reportConn.ExecuteDataTable(cmd);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        
            bindingSource1.DataSource = ReportData;
            hotelDataGrid.DataSource = bindingSource1;
            BindingSource bindingSource2 = new BindingSource();

            try
            {
                // build and execute query
                MySqlCommand cmd = new MySqlCommand("SELECT packageName, pricePerNight from package");
                ReportData = reportConn.ExecuteDataTable(cmd);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            bindingSource2.DataSource = ReportData;
            packageDataGrid.DataSource = bindingSource2;
        }


        private void HotelRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmgmt.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.hotelmgmt.location);
           

}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string getPackageName()
        {
            int selectedrowindex = packageDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = packageDataGrid.Rows[selectedrowindex];
            string packageName = Convert.ToString(selectedRow.Cells["packageName"].Value);
            return packageName;
        }
        private void packageDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string packageName = getPackageName();
                DBConnect packageAmmenitiesConn = new DBConnect();
                MySqlCommand cmd = new MySqlCommand("select a.description from relation_package_amenity rra join package p on p.packageID = rra.packageID join amenity a on a.amenityID = rra.amenityID where packageName = @pack");
                cmd.Parameters.Add("@pack", MySqlDbType.VarChar, 45).Value = packageName;
                DataSet ammenReport = packageAmmenitiesConn.ExecuteDataSet(cmd);

                // pipe dataset to report
                ammenitiesDataGrid.DataSource = ammenReport.Tables[0];
                packageAmmenitiesConn.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, unable to display ammenities." + ex);
            }
        }

        private int getLocationID()
        {
            int selectedrowindex = hotelDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = hotelDataGrid.Rows[selectedrowindex];
            int locationID = Convert.ToInt32(selectedRow.Cells["locationID"].Value);
            return locationID;
        }

        private void hotelDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int locationID = getLocationID();
                DBConnect hotelRoomsConn = new DBConnect();
                MySqlCommand cmd = new MySqlCommand("select r.roomNum, loc.locationName, r.occupancy, r.pricePerNight from room r join location loc on loc.locationID = r.locationID and loc.locationID = @locationID");
                cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
                DataSet roomReport = hotelRoomsConn.ExecuteDataSet(cmd);

                // pipe dataset to report
                roomDataGrid.DataSource = roomReport.Tables[0];
                hotelRoomsConn.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, unable to display ammenities." + ex);
            }
        }
    }
}
