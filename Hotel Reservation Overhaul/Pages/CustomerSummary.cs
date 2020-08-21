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
    public partial class CustomerSummary : Form
    {
        public CustomerSummary(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.lblFromDate.Text= startDate.ToString("MM'/'dd'/'yyyy");
            this.lblToDate.Text = endDate.ToString("MM'/'dd'/'yyyy");

            DBConnect reportConn = new DBConnect();
            MySqlCommand reportQuery = new MySqlCommand("select IFNULL(count(activityLogID), 0) from activitylog where activityTypeID = 1 and created between @startDate and @endDate");

            reportQuery.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate.Date;
            reportQuery.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate.Date;

            int numReservation = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtReservations.Text = numReservation.ToString();

            reportQuery.CommandText = "select IFNULL(count(distinct confirmationID),0) from reservation where startDate >= @startDate AND endDate <= @endDate";
            int totalCustomers = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtNumCustomers.Text = totalCustomers.ToString();

            reportQuery.CommandText = @"select IFNULL(count(userID),0) from reservation
                                        where startDate >= @startDate AND endDate <= @endDate
                                        and userID in (select userID from reservation group by userID, confirmationID having(count(*) > 1))";
            int repeatCustomers = Convert.ToInt32(reportConn.intScalar(reportQuery));

            if (repeatCustomers == 0)
            {
                txtRepeat.Text = "0.0%";
            }
            else
            {
                double repeatPercentage = (Convert.ToDouble(repeatCustomers)) / (Convert.ToDouble(totalCustomers)) * 100;
                txtRepeat.Text = "" + String.Format("{0:F2}", repeatPercentage) + "%";
            }

            reportQuery.CommandText = "select IFNULL(count(*),0) from activitylog where activityTypeID = 3 and created between @startDate and @endDate";
            int numCancelled = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtCancellations.Text = numCancelled.ToString();

            reportQuery.CommandText = @"select IFNULL(count(*), 0) from activitylog al
                                         join dbo.user u
                                             on u.userID = al.createdBy
                                         where al.activityTypeID = 2
                                         and al.created between @startDate and @endDate
                                         and u.isCustomer = 1";
            int userModified = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtCxUpgrade.Text = userModified.ToString();

            reportQuery.CommandText = @"select IFNULL(count(*), 0) from activitylog al
                                         join dbo.user u
                                             on u.userID = al.createdBy
                                         where al.activityTypeID = 2
                                         and al.created between @startDate and @endDate
                                         and u.isCustomer = 0";
            int employeeModified = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtEmpUpgrade.Text = employeeModified.ToString();


            reportQuery.CommandText = @"select IFNULL(count(*), 0) from activitylog al
                                         join dbo.user u
                                             on u.userID = al.createdBy
                                         where al.activityTypeID = 2
                                         and al.created between @startDate and @endDate";
            int totalChanges = Convert.ToInt32(reportConn.intScalar(reportQuery));
            txtChanges.Text = totalChanges.ToString();
        }


    }
}
