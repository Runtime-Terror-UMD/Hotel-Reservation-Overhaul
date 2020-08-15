using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;

public class User
{
    public int userID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int rewardPoints { get { return pointsBalance; } set { } }
    public decimal balance { get; set; }
    public string email { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string secretQuestion { get; set; }
    public string secretAnswer { get; set; }
    public bool isCustomer { get; set; }
    public int pointsBalance { get; set; }
    public User(int UserID)
    {
        // declare and parameterize mySQL Command

        MySqlCommand cmd = new MySqlCommand("SELECT * FROM dbo.user WHERE userID = @UserID");
        cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = UserID;

        // connect to database
        DBConnect UserProfileConn = new DBConnect();

        //Create a data reader and Execute the command
        MySqlDataReader dataReader = UserProfileConn.ExecuteReader(cmd);

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            userID = Convert.ToInt32(dataReader["userID"]);
            firstName = dataReader["firstName"].ToString();
            lastName = dataReader["lastName"].ToString();
            email = dataReader["email"].ToString();
            secretQuestion = dataReader["secretQuestion"].ToString();
            secretAnswer = dataReader["secretAnswer"].ToString();
            username = dataReader["username"].ToString();
            password = dataReader["password"].ToString();
            isCustomer = Convert.ToBoolean(dataReader["isCustomer"]);
            pointsBalance = Convert.ToInt32(dataReader["pointsBalance"]);
        }

        //close Data Reader
        dataReader.Close();
        UserProfileConn.CloseConnection();
    }
}
