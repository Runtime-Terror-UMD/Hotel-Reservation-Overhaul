using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel_Reservation_Overhaul
{
    class Utilities
    {
        // DESCRIPTION: Checks to see if user-entered email address is in valid format
        public bool isValidEmail(string email)
        {
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // DESCRIPTION: Checks to see if user-entered email address is already in use
        public bool emailExists(string email)
        {
            // query to run 
            string emailExistsQuery = "SELECT Count(*) from dbo.user where email = @email";

            // declare and parameterize mySQL Command

            MySqlCommand cmd = new MySqlCommand(emailExistsQuery);
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45);
            cmd.Parameters["@email"].Value = email;

            // connect to database
            DBConnect emailExistsConn = new DBConnect();

            // if records exist
            if (emailExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user-entered username is already in use
        public bool usernameExists(string username)
        {
            // query to run 
            string usernameExistsQuery = "SELECT Count(*) from dbo.user where username = @username";

            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand(usernameExistsQuery);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
            cmd.Parameters["@username"].Value = username;

            // connect to database
            DBConnect usernameExistsConn = new DBConnect();

            // if records exist
            if (usernameExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user ID exists
        public bool userIDExists(int userID)
        {
            // query to run 
            string userIDExistsQuery = "SELECT Count(*) from dbo.user where userID = @userID";

            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand(userIDExistsQuery);
            cmd.Parameters.Add("@userID", MySqlDbType.Int32);
            cmd.Parameters["@userID"].Value = userID;

            // connect to database
            DBConnect userIDExistsConn = new DBConnect();

            // if records exist
            if (userIDExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks if entered password matches specified username
        public bool secretAnswerMatches(int userid, string secretAnswer)
        {
            // construct query
            string secretAnswerMatchesQuery = "SELECT Count(*) from dbo.user where userid = @userID AND secretAnswer = @secretAnswer";
            MySqlCommand cmd = new MySqlCommand(secretAnswerMatchesQuery);
            cmd.Parameters.Add("@userid", MySqlDbType.VarChar, 45);
            cmd.Parameters["@userid"].Value = userid;
            cmd.Parameters.Add("@secretAnswer", MySqlDbType.VarChar, 45);
            cmd.Parameters["@secretAnswer"].Value = secretAnswer;

            // connect to database
            DBConnect secretAnswerMatches = new DBConnect();

            // if records exist
            if (secretAnswerMatches.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Gets userID based on email address
        public int getUserIDFromEmail(string email)
        {
            int userID = -1;
            DBConnect getUserIDFromEmailConn = new DBConnect();

            // build query
            string getUserIDFromEmailQuery = "SELECT userid from dbo.user where email = @email";
            MySqlCommand cmd = new MySqlCommand(getUserIDFromEmailQuery);
            cmd.Parameters.AddWithValue("@email", email);
            
            // assign value to variable
            userID = getUserIDFromEmailConn.intScalar(cmd);

            getUserIDFromEmailConn.CloseConnection();
            return userID;
        }

        public bool isCustomer(int userID)
        {
            DBConnect isCustomerConn = new DBConnect();
            string isCustomerQuery = "SELECT isCustomer from dbo.user where userid = @userID";
            MySqlCommand cmd = new MySqlCommand(isCustomerQuery);
            cmd.Parameters.AddWithValue("@userID", userID);
            if (isCustomerConn.intScalar(cmd) == 0)
                return false;
            return true;
        }

        // DESCRIPTION: Gets userID based on username
        public int getUserIDFromUsername(string username)
        {
            int userID = -1;
            DBConnect getUserIDFromUsernameConn = new DBConnect();
           
            // build query
            string getUserIDFromUsernameQuery = "SELECT userid from dbo.user where username = @username";
            MySqlCommand cmd = new MySqlCommand(getUserIDFromUsernameQuery);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
            cmd.Parameters["@username"].Value = username;

            // assign value to variable
            userID = getUserIDFromUsernameConn.intScalar(cmd);

            getUserIDFromUsernameConn.CloseConnection();
            return userID;
        }

        //  DESCRIPTION: Gets username based on userID
        public string getUsername(int userID)
        {
            string username;
            DBConnect getUsernameConn = new DBConnect();

            // build query
            string getUsernameQuery = "SELECT username from dbo.user where userid = @userID";
            MySqlCommand cmd = new MySqlCommand(getUsernameQuery);
            cmd.Parameters.Add("@userID", MySqlDbType.Int32);
            cmd.Parameters["@userID"].Value = userID;

            //assign value to variable
            username = getUsernameConn.stringScalar(cmd);
            getUsernameConn.CloseConnection();
            return username;
        }

        //  DESCRIPTION: Updates account password
        public bool updatePassword(string username, string newPassword)
        {
            // build query
            string updatePasswordQuery = "UPDATE `dbo`.`user` SET `password` = @newpassword WHERE `username` = @username";
            MySqlCommand cmd = new MySqlCommand(updatePasswordQuery);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@newpassword", MySqlDbType.VarChar, 45).Value = newPassword;

            DBConnect updatePassword = new DBConnect();
            if ((updatePassword.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }

        public double calculatePrice(double days, double pricePerNight)
        {
            double price =pricePerNight * days;
            return price;
        }

        public double calculatePoints(double days)
        {
            double points = days * 25;
            return points;
        }
    }
}
