using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

public class Reservation
{

    public int reservationID { get; set; }
    public int confirmatonID { get; set; }
    public int locationID { get; set; }
     public int numGuests { get; set; }
    public List<int> roomNumList { get; set; }
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
        roomNumList = new List<int>();
        //Read the data and store them in the list
        while (dataReader.Read())
        {
            reservationID = Convert.ToInt32(dataReader["reservationID"]);
            confirmatonID = Convert.ToInt32(dataReader["confirmationID"]);
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
            numGuests = Convert.ToInt32(dataReader["numGuests"]);
            roomNumList.Add((Convert.ToInt32(dataReader["roomNum"])));
        }

        //close Data Reader
        dataReader.Close();
    }
    public bool updateReservation(Reservation resInfo)
    {
        DBConnect updateResConn = new DBConnect();
        MySqlCommand updateRes = new MySqlCommand();
        updateRes.CommandText = "UPDATE `dbo`.`reservation` SET `locationID` = @locationID, `roomNum` = @roomNum, `startDate` = @startDate, `endDate` = @endDate, `pointsAccumulated` = @points, `price` = @price, `amountDue` = @amountDue, `amountPaid` = @amountPaid, `reservationStatus` = @resStatus, `numGuests` = @numGuests WHERE `confirmationID` = @confirmationID";
      
        updateRes.Parameters.Add("@locationID", MySqlDbType.Int32).Value = resInfo.locationID;
        updateRes.Parameters.Add("@startDate", MySqlDbType.Date).Value = resInfo.startDate.Date;
        updateRes.Parameters.Add("@endDate", MySqlDbType.Date).Value = resInfo.endDate.Date;
        updateRes.Parameters.Add("@points", MySqlDbType.Int32).Value = resInfo.points;
        updateRes.Parameters.Add("@price", MySqlDbType.Decimal).Value = Convert.ToDecimal(resInfo.totalPrice);
        updateRes.Parameters.Add("@amountDue", MySqlDbType.Decimal).Value = Convert.ToDecimal(resInfo.amountDue);
        updateRes.Parameters.Add("@amountPaid", MySqlDbType.Decimal).Value = Convert.ToDecimal(resInfo.amountPaid);
        updateRes.Parameters.Add("@resStatus", MySqlDbType.VarChar, 45).Value = resInfo.status;
        updateRes.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = resInfo.numGuests;
        updateRes.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = resInfo.confirmatonID;
        updateRes.Parameters.Add("@roomNum", MySqlDbType.Int32);

        foreach (int roomNum in resInfo.roomNumList)
        {
            updateRes.Parameters["@roomNum"].Value = roomNum;
            updateResConn.NonQuery(updateRes);
        }     
        return true;
    }

    // DESCRIPTION: Adds cancellation to activity log
    public bool logCancellation(int cancelledBy, int userID, DateTime currentDate)
    {
        LoggedActivity logCancellation = new LoggedActivity();
        if (logCancellation.logActivity(userID, 3, this.confirmatonID, currentDate, cancelledBy)) 
            return true;
        return false;
    }

    //public bool upgradeMaintenanceRoom(Reservation resInfo, int roomNum)
    //{
    //    Room getPackages = new Room();
    //    getPackages.roomPackages(resInfo.roomNumList[0], resInfo.locationID);

    //}

    public void addRoomToRes(Reservation modResInfo, List<int> roomNumList)
    {
        foreach (int roomNum in roomNumList)
        {
            DBConnect updateRoomConn = new DBConnect();
            MySqlCommand addRoom = new MySqlCommand("INSERT INTO `dbo`.`reservation`(`confirmationID`,`userID`,`locationID`,`roomNum`,`startDate`,`endDate`,`pointsAccumulated`,`price`,`amountDue`,`amountPaid`,`reservationStatus`,`created`,`numGuests`) VALUES(@confirmationID,@userID,@locationID,@roomNum,@startDate,@endDate,@points,@price,@price,0,@status,@created,@numGuests)");

            addRoom.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
            addRoom.Parameters.Add("@locationID", MySqlDbType.Int32).Value = modResInfo.locationID;
            addRoom.Parameters.Add("@userID", MySqlDbType.Int32).Value = modResInfo.userID;
            addRoom.Parameters.Add("@startDate", MySqlDbType.Date).Value = modResInfo.startDate;
            addRoom.Parameters.Add("@endDate", MySqlDbType.Date).Value = modResInfo.endDate;
            addRoom.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = modResInfo.confirmatonID;
            addRoom.Parameters.Add("@points", MySqlDbType.Int32).Value = modResInfo.points;
            addRoom.Parameters.Add("@price", MySqlDbType.Decimal).Value = modResInfo.totalPrice;
            addRoom.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = "upcoming";
            addRoom.Parameters.Add("@created", MySqlDbType.Date).Value = DateTime.Today;
            addRoom.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = modResInfo.numGuests;

            updateRoomConn.NonQuery(addRoom);
            modResInfo.roomNumList.Add(roomNum);
        }
    }

    //DESCRIPTION: Gets availability for specified reservation request
    public List<int> getAvailability(int numGuests,int hotelID, int numRooms, string combinedstring, DateTime currentDate, DateTime resStart, DateTime resEnd)
    {
        List<int> roomNumsAvailable = new List<int>();
        DBConnect checkAvailabilityConn = new DBConnect();
        // Select available rooms at location not in maintenance
        MySqlCommand cmd = new MySqlCommand("SELECT rrp.roomNum,group_concat(packageID separator \",\") as packages from dbo.relation_room_package rrp join dbo.room room on room.locationID = rrp.locationID and room.roomNum = rrp.roomNum where rrp.locationID = @locationID and rrp.roomNum not in (select roomNum from dbo.reservation where @startDate between startDate and endDate and reservationStatus <> 'cancelled' and locationID = @locationID) and rrp.roomNum not in (select roomNum from dbo.maintenance where locationID = @locationID and maintenanceDate BETWEEN @startDate and @endDate) group by rrp.roomNum having(packages = @packages and(sum(room.occupancy) >= @numGuests)) limit @numRooms");
            
        cmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = resStart;
        cmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = resEnd;
        cmd.Parameters.Add("@packages", MySqlDbType.VarChar).Value = combinedstring;
        cmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = hotelID;
        cmd.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = numGuests;
        cmd.Parameters.Add("@numRooms", MySqlDbType.Int32).Value = numRooms;

        MySqlDataReader dataReader = checkAvailabilityConn.ExecuteReader(cmd);
        if (dataReader.HasRows)
        {
            // gets roomNum(s) if available
            while (dataReader.Read())
            {
                roomNumsAvailable.Add(Convert.ToInt32(dataReader["roomNum"]));
            }
            dataReader.Close();
            return roomNumsAvailable;
        }
        else
        {
            return roomNumsAvailable;
        }
    }

    // DESCRIPTION: Adds reservation to dbo.reservation and activity log
    public int makeReservation(int locationID, int newResUserID, int resUserID, DateTime startDate, DateTime endDate, double newResPrice, int newResPoints, List<int> newResRoomList, int numGuests, DateTime currentDate)
    {
        int confirmationID = -1;
        DBConnect createResConn = new DBConnect();
        MySqlCommand createResCmd = new MySqlCommand("INSERT INTO `dbo`.`reservation`(`confirmationID`,`userID`,`locationID`,`roomNum`,`startDate`,`endDate`,`pointsAccumulated`,`price`,`amountDue`,`amountPaid`,`reservationStatus`,`created`,`numGuests`) VALUES(@confirmationID,@userID,@locationID,@roomNum,@startDate,@endDate,@points,@price,@price,0,@status,@created,@numGuests)");
       
        DBConnect getNextConfConn = new DBConnect();
        MySqlCommand cmd = new MySqlCommand("select confirmationID from dbo.reservation order by confirmationID desc limit 1");
        confirmationID = getNextConfConn.intScalar(cmd) + 1;

        createResCmd.Parameters.Add("@roomNum", MySqlDbType.Int32);
        createResCmd.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
        createResCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = resUserID;
        createResCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
        createResCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;
        createResCmd.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = confirmationID;
        createResCmd.Parameters.Add("@points", MySqlDbType.Int32).Value = newResPoints;
        createResCmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = newResPrice;
        createResCmd.Parameters.Add("@status", MySqlDbType.VarChar, 45).Value = "upcoming";
        createResCmd.Parameters.Add("@created", MySqlDbType.Date).Value = currentDate;
        createResCmd.Parameters.Add("@numGuests", MySqlDbType.Int32).Value = numGuests;            

        // insert one row for each room
        foreach (int newResRoomNum in newResRoomList)   
        {
            createResCmd.Parameters["@roomNum"].Value = newResRoomNum;
            createResConn.NonQuery(createResCmd);
        }
        return confirmationID;
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

            LoggedActivity logNewReservation = new LoggedActivity();
            return true;
        }
        else
        {
            return false;
        }
    }

    //  DESCRIPTION: 
    public bool checkOut(DateTime currentDate)
    {
        Utilities getInfo = new Utilities();
        if(endDate != currentDate)
        {
            this.endDate = currentDate;
            double pricePerNight = getInfo.getPricePerNight(locationID, roomNum);
            totalPrice = pricePerNight * 
        }
    }
    public bool checkIn()
    {

    }
}