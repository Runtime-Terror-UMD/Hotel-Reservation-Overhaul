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

    public partial class Summary_Reports : Form
    {
        public int TotalCustomersRedeemed;
        public int TotalRedeemed;

        public Summary_Reports()
        {
            InitializeComponent();
        }

        public Summary_Reports(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();


            lblFromDate.Text = startDate.ToString("MM'/'dd'/'yyyy");
            lblToDate.Text = endDate.ToString("MM'/'dd'/'yyyy");
            
            lblRewardsDateXDesc.Text = "Rewards outstanding on " + lblFromDate.Text;
            lblRewardsDateYDesc.Text = "Rewards outstanding on " + lblToDate.Text;


            DBConnect reportConn = new DBConnect();
            MySqlCommand reportQuery = new MySqlCommand();

            reportQuery.CommandText = @"SELECT IFNULL(sum(pointsAmount), 0) as total
                                     FROM dbo.reward_log
                                    where created <= @startDate";

            reportQuery.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate.Date;
            int xOutstanding = reportConn.intScalar(reportQuery);
            lblRewardsDateX.Text = xOutstanding.ToString();


            reportQuery.CommandText = @"SELECT IFNULL(sum(pointsAmount), 0)
                                        FROM dbo.reward_log 
                                        where created <= @endDate;";

            reportQuery.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate.Date;
            int yOutstanding = reportConn.intScalar(reportQuery);
            lblRewardsDateY.Text = yOutstanding.ToString();


            reportQuery.CommandText = @"select IFNULL(count(rl.customerID),0) as 'CustomerCount',
                                        IFNULL(sum(rl.pointsAmount),0) * -1 as 'TotalRedeemed'
                                        from dbo.reward_log rl
                                        where rl.created >= @startDate and rl.created <= @endDate
                                        and rl.pointsAmount < 0;";
  

            MySqlDataReader dataReader = reportConn.ExecuteReader(reportQuery);
            while (dataReader.Read())
            {
                TotalCustomersRedeemed = Convert.ToInt32(dataReader["CustomerCount"]);
                TotalRedeemed = Convert.ToInt32(dataReader["TotalRedeemed"]);
            }
            dataReader.Close();

            lblRedeemed.Text = TotalRedeemed.ToString();
            lblTotalCust.Text = TotalCustomersRedeemed.ToString();

            reportQuery.CommandText = @"select IFNULL(sum(rl.pointsAmount),0) as 'Total points Earned'
                                        from dbo.reward_log rl
                                        where rl.created >= @startDate and rl.created <= @endDate
                                        and rl.pointsAmount > 0;";

            int totalEarned = reportConn.intScalar(reportQuery);
            lblEarned.Text = totalEarned.ToString();
        }

        private void Summary_Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
