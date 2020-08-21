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
    public partial class OccupancySummary : Form
    {
        public OccupancySummary(DateTime startDate, DateTime endDate)
        { 
            InitializeComponent();
            lblFromDate.Text = startDate.ToString("MM'/'dd'/'yyyy");
            lblToDate.Text = endDate.ToString("MM'/'dd'/'yyyy");

            // total rooms (used for calculations)
            DBConnect reportConn = new DBConnect();
            MySqlCommand reportCmd = new MySqlCommand(@"SELECT ifnull(count(roomNum), 0) from room");
            int roomTotal = reportConn.intScalar(reportCmd);

            // total rooms occupied
            reportCmd.CommandText = "select count(reservationID) from dbo.reservation where startDate >= @startDate and endDate <= @endDate and reservationStatus = 'checked-in';";
            reportCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate.Date;
            reportCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate.Date;
            int occupied = Convert.ToInt32(reportConn.intScalar(reportCmd));
          
            // total rooms unoccupied
            int unoccupied = roomTotal - occupied;

            // percentage of rooms occupied
            double percentOcc = (Convert.ToDouble(occupied) / Convert.ToDouble(roomTotal)) * 100;

            // percentage of rooms unoccupied
            double percentUnOcc = (Convert.ToDouble(unoccupied) / Convert.ToDouble(roomTotal)) * 100;

            // number of rooms unoccupied due to maintenance
            reportCmd.CommandText = @"SELECT ifnull(count(*), 0)
                                     from dbo.maintenance m
                                     where maintenanceDate >= @startDate
                                     and maintenanceDate   <= @endDate";         
            int maintenance = reportConn.intScalar(reportCmd);

            // percentage of rooms unoccupied due to maintenance
            double percentMaintenance = Convert.ToDouble(maintenance) / Convert.ToDouble(roomTotal);

            // total revenue
            reportCmd.CommandText = @"select sum(p.amountPaid)
                                     from dbo.payment p
                                    where p.created >= @startDate
                                    and p.created  <= @endDate";
            double revenue = reportConn.doubleScalar(reportCmd);

            txtOccupied.Text = "" + String.Format("{0:F2}", percentOcc) + "%";
            txtUnoccupied.Text = "" + String.Format("{0:F2}", percentUnOcc) + "%";
            txtMaintenance.Text = "" + String.Format("{0:F2}", percentMaintenance) + "%";
            txtRevenue.Text = "$" + String.Format("{0:F2}", revenue);

        }
    }
}
