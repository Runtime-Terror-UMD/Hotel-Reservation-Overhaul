using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;

class User
{
    private int userID { get; set; }
    private string firstName { get; set; }
    private string lastName { get; set; }
    private int rewardPoints { get; set; }
    private decimal balance { get; set; }
    private string email { get; set; }
    private string username { get; set; }
    private string password { get; set; }
    private string secretQuestion { get; set; }
    private string secretAnswer { get; set; }
    private int isCustomer { get; set; }

    User(int userID)
    {

        // query to run 
        string UserProfileQuery = "SELECT * from dbo.user where email = @userID";

        // declare and parameterize mySQL Command

        MySqlCommand cmd = new MySqlCommand(UserProfileQuery);
        cmd.Parameters.Add("@userID", MySqlDbType.Int32);
        cmd.Parameters["@userID"].Value = userID;

        // connect to database
        DBConnect UserProfileConn = new DBConnect();


        //Create a data reader and Execute the command
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            userID = Convert.ToInt32(dataReader["userid"].ToString());
            firstName = dataReader["firstName"].ToString();
            lastName = dataReader["lastName"].ToString();
            email = dataReader["email"].ToString();
            secretQuestion = dataReader["secretQuestion"].ToString();
            secretAnswer = dataReader["secretAnswer"].ToString();
            username = dataReader["username"].ToString();
            isCustomer = Convert.ToInt32(dataReader["isCustomer"].ToString());
        }

        //close Data Reader
        dataReader.Close();
        UserProfileConn.CloseConnection();
    }
}
