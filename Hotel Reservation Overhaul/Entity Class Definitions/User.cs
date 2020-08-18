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

    public bool updateUser(User userinfo)
    {
        DBConnect updateUserConn = new DBConnect();
        MySqlCommand updateUserCmd = new MySqlCommand(@"UPDATE `dbo`.`user`
                                                        SET
                                                        firstName = @firstName,
                                                        lastName = @lastName,
                                                        email = @email,
                                                        secretQuestion = @secretQuestion,
                                                        secretAnswer= @secretAnswer,
                                                        username = @userName,
                                                        password = @password,
                                                        pointsBalance = @points
                                                        WHERE userID = @userID;");
        updateUserCmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = userinfo.firstName;
        updateUserCmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = userinfo.lastName;
        updateUserCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = userinfo.email;
        updateUserCmd.Parameters.Add("@secretQuestion", MySqlDbType.VarChar, 45).Value = userinfo.secretQuestion;
        updateUserCmd.Parameters.Add("@secretAnswer", MySqlDbType.VarChar, 45).Value = userinfo.secretAnswer;
        updateUserCmd.Parameters.Add("@userName", MySqlDbType.VarChar, 45).Value = userinfo.username;
        updateUserCmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = userinfo.password;
        updateUserCmd.Parameters.Add("@points", MySqlDbType.Int32).Value = userinfo.pointsBalance;
        updateUserCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userinfo.userID;
        if (updateUserConn.NonQuery(updateUserCmd) > 0)
            return true;
        return false;
    }

}

