using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
public class Waitlist
{
    private int waitlistID { get; set; }
    private int reservationID { get; set; }
    private int customerID { get; set; }
    private DateTime date { get; set; }
    Waitlist(int reservation, int customer, DateTime date_)
    {
        //this.waitlistID = ?? from database
        this.reservationID = reservation;
        this.customerID = customer;
        this.date = date_;
    }

    public Waitlist() { }

    public bool addToWaitlist(int wlUserID, int wlLocationID, DateTime wlStartDate, DateTime wlEndDate, int wlNumGuests, int wlNumRooms, string combinedString)

    {
        DBConnect addToWLConn = new DBConnect();
        MySqlCommand getNextWlID = new MySqlCommand("select waitlistID from dbo.waitlist order by waitlistID desc limit 1");
        int waitlistID = addToWLConn.intScalar(getNextWlID) + 1;

        MySqlCommand addToWL = new MySqlCommand(@"INSERT INTO `dbo`.`waitlist`(`waitlistID`,`customerID`,`locationID`,`startDate`,`endDate`,`numGuests`,`numRooms`,`packages`)
                                                  VALUES(@waitlistID, @userID, @locationID, @startDate, @endDate, @numGuests,@numRooms, @packages)");

        addToWL.Parameters.Add("@waitlistID", MySqlDbType.Int32).Value = waitlistID;
        addToWL.Parameters.Add("@locationID", MySqlDbType.Int32).Value = wlLocationID;
        addToWL.Parameters.Add("@userID", MySqlDbType.Int32).Value = wlUserID;
        addToWL.Parameters.Add("@startDate", MySqlDbType.Date).Value = wlStartDate;
        addToWL.Parameters.Add("@endDate", MySqlDbType.Date).Value = wlEndDate;
        addToWL.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = wlNumGuests;
        addToWL.Parameters.Add("@numRooms", MySqlDbType.Int32).Value = wlNumRooms;
        addToWL.Parameters.Add("@packages", MySqlDbType.VarChar, 45).Value = combinedString;
       
        if (addToWLConn.NonQuery(addToWL) > 0)
        {
            return true;
        }
        return false;
    }
}