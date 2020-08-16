using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class Reservation
{

    public int reservationID { get; set; }
    public int confirmatonID { get; set; }
    public int locationID { get; set; }
  
    public int roomNum { get; set; }
    public int userID { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public double duration { get; set; }
    public double totalPrice { get; set; }
    public double amountPaid { get; set; }
    public double amountDue { get; set; }

    public int points { get; set; }
    public string status { get; set; }

    public Reservation() { }
    public Reservation(int confirmationID)
    {

        // query to run 
        string reservationQuery = "SELECT * FROM dbo.reservation WHERE confirmationID = @confirmationID";
        MySqlCommand cmd = new MySqlCommand(reservationQuery);
        cmd.Parameters.AddWithValue("@confirmationID", confirmationID);


        // connect to database
        DBConnect ReservationConn = new DBConnect();


        //Create a data reader and Execute the command
        MySqlDataReader dataReader = ReservationConn.ExecuteReader(cmd);

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            reservationID = Convert.ToInt32(dataReader["reservationID"]);
            confirmatonID = Convert.ToInt32(dataReader["confirmationID"]);
            roomNum = Convert.ToInt32(dataReader["roomNum"]);
            userID = Convert.ToInt32(dataReader["userID"]);
            locationID = Convert.ToInt32(dataReader["locationID"]);
            points = Convert.ToInt32(dataReader["pointsAccumulated"]);
            startDate = Convert.ToDateTime(dataReader["startDate"]);
            endDate = Convert.ToDateTime(dataReader["endDate"]);
            duration = (endDate - startDate).TotalDays;
            totalPrice = Convert.ToDouble(dataReader["price"]);
            amountPaid = Convert.ToDouble(dataReader["amountPaid"]);
            amountDue = Convert.ToDouble(dataReader["amountDue"]);
            status = dataReader["reservationStatus"].ToString();
        }

        //close Data Reader
        dataReader.Close();
        ReservationConn.CloseConnection();
    }

    public bool updateReservation(Reservation resInfo)
    {
        DBConnect updateResConn = new DBConnect();
        MySqlCommand  updateRes = new MySqlCommand(@"UPDATE `dbo`.`reservation`
                                                    SET
                                                    `locationID` = @locationID,
                                                    `roomNum` = @roomNum,
                                                    `startDate` = @startDate,
                                                    `endDate` = @endDate,
                                                    `pointsAccumulated` = @points,
                                                    `price` = @price,
                                                    `amountDue` = @amountDue,
                                                    `amountPaid` = @amountPaid,
                                                    `reservationStatus` = @status,
                                                     WHERE `confirmationID` = @confirmationID");
      
        updateRes.Parameters.Add("@locationID", MySqlDbType.Int32).Value = resInfo.locationID;
        updateRes.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = resInfo.roomNum;
        updateRes.Parameters.Add("@startDate", MySqlDbType.Int32).Value = resInfo.startDate;
        updateRes.Parameters.Add("@endDate", MySqlDbType.Int32).Value = resInfo.endDate;
        updateRes.Parameters.Add("@points", MySqlDbType.Int32).Value = resInfo.points;
        updateRes.Parameters.Add("@price", MySqlDbType.Int32).Value = resInfo.totalPrice;
        updateRes.Parameters.Add("@amountDue", MySqlDbType.Int32).Value = resInfo.amountDue;
        updateRes.Parameters.Add("@amountPaid", MySqlDbType.Int32).Value = resInfo.amountPaid;
        updateRes.Parameters.Add("@status", MySqlDbType.Int32).Value = resInfo.status;
        if(updateResConn.NonQuery(updateRes) > 0)
            return true;
        return false;
    }

    // DESCRIPTION: Adds cancellation to activity log
    public void logCancellation(int cancelledBy, int userID, DateTime current)
    {
        DBConnect cancelResConn = new DBConnect();
        MySqlCommand cancelRes = new MySqlCommand(@"INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`.`createdBy`)
                                                    VALUES(@userID,3,@confirmationID,@created,@createdBy");
        cancelRes.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        cancelRes.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = this.confirmatonID;
        cancelRes.Parameters.Add("@created", MySqlDbType.Int32).Value = current;      //FIXME: Replace with date varialbe
        cancelRes.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = cancelledBy;
        cancelResConn.NonQuery(cancelRes);
    }

    //DESCRIPTION: Gets availability for specified reservation request
    public int getAvailability(List<int> packages, int numGuests,int hotelID, string combindstring)
    {
        int roomAvailable = -1;
        DBConnect checkAvailabilityConn = new DBConnect();
        // Select available rooms at location not in maintenance
        MySqlCommand cmd = new MySqlCommand(@"select roomNum
                                                    from dbo.relation_room_package rrp
                                                    where packageID in (" + combindstring + @") and locationID = @locationID
                                                    and roomNum not in (select roomNum from dbo.reservation where @startDate between startDate and endDate and reservationStatus <> 'cancelled' and locationID = @locationID)
                                                    and roomNum not in (select roomNum from dbo.maintenance where locationID = @locationID and maintenanceDate BETWEEN @startDate and @endDate) 
                                                    group by roomNum
                                                    having count(distinct packageID) = @numPackages limit 1");
        cmd.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = startDate;
        cmd.Parameters.Add("@endDate", MySqlDbType.DateTime).Value = endDate;
        cmd.Parameters.Add("@numPackages", MySqlDbType.Int32).Value = packages.Count;
        cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = hotelID;
        cmd.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = numGuests;

        MySqlDataReader dataReader = checkAvailabilityConn.ExecuteReader(cmd);
        if (dataReader.HasRows)
        {
            // gets roomNum if one is available
            while (dataReader.Read())
            {
                roomAvailable = Convert.ToInt32(dataReader["roomNum"]);
            }
            dataReader.Close();
            checkAvailabilityConn.CloseConnection();
            return roomAvailable;
        }
        return roomAvailable;
    }

    // DESCRIPTION: Adds reservation to dbo.reservation and activity log
    public int makeReservation(int locationID, int newResUserID, int resUserID, DateTime startDate, DateTime endDate, double newResPrice, int newResPoints, int newResRoomNum, DateTime current)
    {
        DBConnect createResConn = new DBConnect();
        MySqlCommand createResCmd = new MySqlCommand("INSERT INTO `dbo`.`reservation`(`confirmationID`,`userID`,`locationID`,`roomNum`,`startDate`,`endDate`,`pointsAccumulated`,`price`,`amountDue`,`amountPaid`,`reservationStatus`,`created`)VALUES(@confirmationID,@userID,@locationID,@roomNum,@startDate,@endDate,@points,@price,@price,0,@status,@created)");

        string getNextConfID = "select confirmationID from dbo.reservation order by confirmationID desc limit 1";
        MySqlCommand cmd = new MySqlCommand(getNextConfID);
        int comfirmationID = createResConn.intScalar(cmd) + 1;

        createResCmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
        createResCmd.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = resUserID;
        createResCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
        createResCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;
        createResCmd.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
        createResCmd.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = newResRoomNum;
        createResCmd.Parameters.Add("@points", MySqlDbType.Int32).Value = newResPoints;
        createResCmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = newResPrice;
        createResCmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = "upcoming";
        createResCmd.Parameters.Add("@created", MySqlDbType.Date).Value = current;

        if (createResConn.NonQuery(createResCmd) > 0)
        {
            // add to activity log
            MySqlCommand logActivity = new MySqlCommand("INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`,`createdBy`)VALUES(@userID, 1, @confirmationID, @date, @createdBy)");
            logActivity.Parameters.Add("@confirmationID", MySqlDbType.Int32, 10).Value = comfirmationID;
            logActivity.Parameters.Add("@createdBy", MySqlDbType.Int32, 10).Value = newResUserID;
            logActivity.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = resUserID;
            logActivity.Parameters.Add("@date", MySqlDbType.Date).Value = current;
            if(createResConn.NonQuery(logActivity) > 0)
            {
                return comfirmationID;
            }
            return -1;
        }
        return -1;
    }

    // DESCRIPTION: Adds request to dbo.waitlist
    public bool addToWaitlist(int wlUserID, int wlLocationID, DateTime wlStartDate, DateTime wlEndDate, int wlNumGuests, string combinedString)

    {
        DBConnect addToWLConn = new DBConnect();
        MySqlCommand addToWL = new MySqlCommand(@"INSERT INTO `dbo`.`waitlist`(`customerID`,`locationID`,`startDate`,`endDate`,`numGuests`,`packages`)
                                                  VALUES(@userID, @locationID, @startDate, @endDate, @numGuests,@packages)");
        addToWL.Parameters.Add("@locationID", MySqlDbType.Int32).Value = wlLocationID;
        addToWL.Parameters.Add("@userID", MySqlDbType.Int32, 10).Value = wlUserID;
        addToWL.Parameters.Add("@startDate", MySqlDbType.Date).Value = wlStartDate;
        addToWL.Parameters.Add("@endDate", MySqlDbType.Date).Value = wlEndDate;
        addToWL.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = wlNumGuests;
        addToWL.Parameters.Add("@packages", MySqlDbType.VarChar, 45).Value = combinedString;
        if (addToWLConn.NonQuery(addToWL) > 0)
        {
            return true;
        }
        return false;
    }

    //  DESCRIPTION: 
    public bool checkOut()
    {

    }
    public bool checkIn()
    {

    }
}