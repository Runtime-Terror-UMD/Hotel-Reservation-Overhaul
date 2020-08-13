using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
public class Reservation
{

    public int reservationID { get; set; }
    public int confirmatonID { get; set; }
    public int locationID { get; set; }
  
    public int userID { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public double duration { get; set; }
    public double totalPrice { get; set; }
    public double amountPaid { get; set; }
    public double amountDue { get; set; }

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
            userID = Convert.ToInt32(dataReader["customerID"]);
            locationID = Convert.ToInt32(dataReader["locationID"]);
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

}