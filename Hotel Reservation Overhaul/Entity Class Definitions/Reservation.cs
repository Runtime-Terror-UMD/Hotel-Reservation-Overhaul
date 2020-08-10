﻿using Hotel_Reservation_Overhaul;
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
    public int roomTypeID { get; set; }
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
            roomTypeID = Convert.ToInt32(dataReader["roomTypeID"]);
            startDate = Convert.ToDateTime(dataReader["StartDate"]);
            endDate = Convert.ToDateTime(dataReader["endDate"]);
            duration = (endDate - startDate).TotalDays;
            totalPrice = Convert.ToDecimal(dataReader["price"]);
            status = dataReader["reservationStatus"].ToString();
}

//close Data Reader
    dataReader.Close();
    ReservationConn.CloseConnection();
    }
}