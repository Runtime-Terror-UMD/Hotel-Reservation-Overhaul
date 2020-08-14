using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
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
            confirmatonID = Convert.ToInt32(dataReader["confirmatonID"]);
            roomNum = Convert.ToInt32(dataReader["roomNum"]);
            userID = Convert.ToInt32(dataReader["customerID"]);
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

    public void logCancellation(int cancelledBy, int userID)
    {
        DBConnect cancelResConn = new DBConnect();
        MySqlCommand cancelRes = new MySqlCommand(@"INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`.`createdBy`)
                                                    VALUES(@userID,3,@confirmationID,@created");
        cancelRes.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        cancelRes.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = this.confirmatonID;
        cancelRes.Parameters.Add("@created", MySqlDbType.Int32).Value = DateTime.Today;      //FIXME: Replace with date varialbe
        cancelRes.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = cancelledBy;
        cancelResConn.NonQuery(cancelRes);
    }
}