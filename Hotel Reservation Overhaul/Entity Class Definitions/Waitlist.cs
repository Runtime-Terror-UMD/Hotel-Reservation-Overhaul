using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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
    // DESCRIPTION: Deletes any waitlist entries with startdate < currentDate

    public void dailyPurgeWaitlist(DateTime currentDate)
    {
        DBConnect purgeWLConn = new DBConnect();
        MySqlCommand purgeWL = new MySqlCommand("delete from dbo.waitlist where startDate > @currentDate");
        purgeWL.Parameters.Add("@currentDate", MySqlDbType.Date).Value = currentDate;
        purgeWLConn.NonQuery(purgeWL);
    }

    // DESCRIPTION: Creates reservation from waitlist if room is available

    public void dailyWaitlistUpdate(DateTime currentDate)
    {
        int waitlistID = -1;
        int customerID = -1;
        int locationID = -1;
        int numGuests = -1;
        int numRooms = -1;
        int confirmationID = -1;
        string packages = "";
        DateTime startDate;
        DateTime endDate;
        List<int> roomNumList = new List<int>();

        DBConnect waitlistConn = new DBConnect();
        MySqlCommand getWL = new MySqlCommand("SELECT * from dbo.waitlist order by waitlistID");
        DataTable waitlistDT = waitlistConn.ExecuteDataTable(getWL);
        foreach(DataRow row in waitlistDT.Rows)
        {
            // get waitlist parameters
            waitlistID = Convert.ToInt32(row["waitlistID"]);
            customerID = Convert.ToInt32(row["customerID"]);
            locationID = Convert.ToInt32(row["locationID"]);
            startDate = Convert.ToDateTime(row["startDate"]);
            endDate = Convert.ToDateTime(row["endDate"]);
            numGuests = Convert.ToInt32(row["numGuests"]);
            numRooms = Convert.ToInt32(row["numRooms"]);
            packages = row["packages"].ToString();

            // check for availability
            Reservation checkWL = new Reservation();
            roomNumList = checkWL.getAvailability(numGuests, locationID, numRooms, packages, currentDate, startDate, endDate);
            if(roomNumList.Count == numRooms)
            {
            // reservation available, create reservation
            Utilities calcPrice = new Utilities();
            double pricePerNight = (calcPrice.getPricePerNight(locationID, roomNumList[0])) * numRooms;
            double price = (calcPrice.calculatePrice(((endDate - startDate).TotalDays), pricePerNight)) * numRooms;
            int points = Convert.ToInt32(calcPrice.calculatePoints(((endDate - startDate).TotalDays)));
            
            confirmationID = checkWL.makeReservation(locationID, customerID, customerID, startDate, endDate, price, points, roomNumList, numGuests, currentDate);
            // reservation created successfully, remove from waitlist
            if(confirmationID > 0)
                {
                    DBConnect removeFromWLConn = new DBConnect();
                    MySqlCommand removeFromWL = new MySqlCommand("DELETE FROM dbo.waitlist WHERE waitlistID = @waitlistID");
                    removeFromWL.Parameters.Add("@waitlistID", MySqlDbType.Int32).Value = waitlistID;
                    removeFromWLConn.NonQuery(removeFromWL);                     
                }
            }
        }
    }
}