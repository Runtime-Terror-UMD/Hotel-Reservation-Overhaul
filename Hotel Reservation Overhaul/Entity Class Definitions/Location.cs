using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;

public class Location
{
    private int locationID { get; set; }
    private string name { get; set; }
    Location(string name_)
    {
        //this.locationID = ?? from database
        this.name = name_;
    }

    public Location() { }

    public bool hotelExists(int hotelID)
    {
        // checks to make sure hotelID does not exist in database
        DBConnect checkForHotelConn = new DBConnect();
        MySqlCommand checkForHotel = new MySqlCommand("SELECT COUNT(*) FROM dbo.location WHERE locationID = @hotelID");
        checkForHotel.Parameters.Add("@hotelID", MySqlDbType.Int32).Value = hotelID;

        // hotel already exists, set hotelID = 0
        if (checkForHotelConn.intScalar(checkForHotel) > 0)
        {
            return true;
        }
        return false;
    }

    public bool addLocation(int hotelID, string hotelName, string hotelCity, string hotelState)
    {
        DBConnect insertHotelConn = new DBConnect();
        MySqlCommand insertHotel = new MySqlCommand(@"INSERT INTO `dbo`.`location` (`locationID`, `locationName`, `locationCity`,`locationState`)
                                                                                  VALUES (@hotelID, @hotelName, @hotelCity, @hotelState");
        insertHotel.Parameters.Add("@hotelID", MySqlDbType.Int32).Value = hotelID;
        insertHotel.Parameters.Add("@hotelName", MySqlDbType.VarChar, 100).Value = hotelName;
        insertHotel.Parameters.Add("@hotelCity", MySqlDbType.VarChar, 45).Value = hotelCity;
        insertHotel.Parameters.Add("@hotelState", MySqlDbType.VarChar, 45).Value = hotelState;
        if (insertHotelConn.NonQuery(insertHotel) > 0)
        {
            return true;
        }
        return false;
    }

}