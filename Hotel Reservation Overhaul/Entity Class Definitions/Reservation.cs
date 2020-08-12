using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
public class Reservation
{
  public enum Status
    {
        WAITLISTED,
        UPCOMING,
        CHECKED_IN,
        CHECKED_OUT,
        CANCELLED
    }
    public int reservationID { get; set; }
    public int confirmatonID { get; set; }
    public int locationID { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public double duration { get; set; }
    public decimal totalPrice { get; set; }
    public string status { get; set; }

    public Reservation(int confirmationID)
 {

    // query to run 
    string reservationQuery = "SELECT * FROM dbo.reservation WHERE confirmationID = @confirmationID";
    // declare and parameterize mySQL Command

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
            locationID = Convert.ToInt32(dataReader["locationID"]);
            startDate = Convert.ToDateTime(dataReader["startDate"]);
            endDate = Convert.ToDateTime(dataReader["endDate"]);
            duration = (endDate - startDate).TotalDays;
            totalPrice = Convert.ToDecimal(dataReader["price"]);
            status = dataReader["reservationStatus"].ToString();         
        }

//close Data Reader
    dataReader.Close();
    ReservationConn.CloseConnection();
    }

    public bool cancelReservation(int confirmationID)
    {
        string cancelResUpdate;



        if ((DateTime.Today-startDate).TotalDays <= 3)
        {
            cancelResUpdate = "update dbo.reservation set status = 'cancelled' where confirmationID = @confirmationID";
        }
        else
        {
            cancelResUpdate = "update dbo.reservation set status = 'cancelled', amountPaid = 0.00 where confirmationID = @confirmationID";
        }

        MySqlCommand cancelResCmd = new MySqlCommand("update dbo.reservation set status = 'cancelled' where confirmationID = @confirmationID");
        cancelResCmd.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = confirmationID;
        DBConnect cancelResConn = new DBConnect();

        if (cancelResConn.NonQuery(cancelResCmd) > 0)
        { 
            return true; 
        }
        return false;
    }
}