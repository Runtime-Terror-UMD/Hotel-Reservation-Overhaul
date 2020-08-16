using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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

        // DESCRIPTION: Checks to see if user-entered email exists 
        public bool emailExists(string email)
        {
            // declare and parameterize mySQL Command

            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;

            // connect to database
            DBConnect emailExistsConn = new DBConnect();

            // if records exist
            if (emailExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user-entered username exists
        public bool usernameExists(string username)
        {
            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;

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
            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where userID = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

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
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where userid = @userID AND secretAnswer = @secretAnswer");
            cmd.Parameters.Add("@userid", MySqlDbType.Int32).Value = userid;
            cmd.Parameters.Add("@secretAnswer", MySqlDbType.VarChar, 45).Value = secretAnswer;

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
            MySqlCommand cmd = new MySqlCommand("SELECT userid from dbo.user where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;
            
            // assign value to variable
            userID = getUserIDFromEmailConn.intScalar(cmd);
            return userID;
        }

        public bool isCustomer(int userID)
        {
            DBConnect isCustomerConn = new DBConnect();
            MySqlCommand cmd = new MySqlCommand("SELECT isCustomer from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
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
            MySqlCommand cmd = new MySqlCommand("SELECT userid from dbo.user where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;

            // assign value to variable
            userID = getUserIDFromUsernameConn.intScalar(cmd);
            return userID;
        }

        //  DESCRIPTION: Gets username based on userID
        public string getUsername(int userID)
        {
            string username;
            DBConnect getUsernameConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT username from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            username = getUsernameConn.stringScalar(cmd);
            return username;
        }

        // DESCRIPTION: Checks if entered password matches specified username
        public bool passwordMatches(string username, string password)
        {
            // construct query
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where username = @username AND password = @password");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = password;

            // connect to database
            DBConnect passwordMatchesConn = new DBConnect();
            // if records exist
            if (passwordMatchesConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }
        public bool passwordMatches(int userID, string password)
        {
            // construct query
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where userID = @userID AND password = @password");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = password;

            // connect to database
            DBConnect passwordMatchesConn = new DBConnect();

            // if records exist
            if (passwordMatchesConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        //  DESCRIPTION: Updates account password
        public bool updatePassword(string username, string newPassword)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `password` = @newpassword WHERE `username` = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;
            cmd.Parameters.Add("@newpassword", MySqlDbType.VarChar, 45).Value = newPassword;

            DBConnect updatePassword = new DBConnect();
            if ((updatePassword.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }
        public bool updatePassword(int userID, string newPassword)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `password` = @newpassword WHERE `userID` = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newpassword", MySqlDbType.VarChar, 45).Value = newPassword;

            DBConnect updatePassword = new DBConnect();
            if ((updatePassword.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Gets rewards points based on userid
        public int getRewardsPoints(int userID)
        {
            int rewards;
            DBConnect getPointsBalanceConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT pointsBalance from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            rewards = getPointsBalanceConn.intScalar(cmd);
            return rewards;
        }
        //DESCRIPTION: Sets rewards points based on userid
        public bool setRewardsPoints(int userID, int points, int createdBy)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `pointsBalance` = pointsBalance + @newPoints WHERE `userID` = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newPoints", MySqlDbType.Int32).Value = points;
            DBConnect updatePoints = new DBConnect();
            if ((updatePoints.NonQuery(cmd)) > 0)
            {
                // add to rewards log
                cmd.CommandText = @"INSERT INTO `dbo`.`reward_log` (`customerID`,`PointsAmount`,`createdBy`,`created`)
                                    VALUES(@userID, @newPoints, @createdBy, @created)";
                cmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
                cmd.Parameters.Add("@created", MySqlDbType.Date).Value = DateTime.Today;
                if ((updatePoints.NonQuery(cmd)) > 0)
                    return true;
                return false;
            }              
                return false;
        }

        //  DESCRIPTION: Gets email based on userID
        public string getEmail(int userID)
        {
            string email;
            DBConnect getEmailConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT email from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            email = getEmailConn.stringScalar(cmd);
            getEmailConn.CloseConnection();
            return email;
        }

        //  DESCRIPTION: Gets secretQuestion based on userID
        public string getSecretQuestion(int userID)
        {
            string secretQuestion;
            DBConnect getSecretQuestionConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT secretQuestion from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            secretQuestion = getSecretQuestionConn.stringScalar(cmd);
            getSecretQuestionConn.CloseConnection();
            return secretQuestion;
        }
        //  DESCRIPTION: Gets first name based on userID
        public string getFirstName(int userID)
        {
            string firstName;
            DBConnect getFirstNameConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT firstName from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            firstName = getFirstNameConn.stringScalar(cmd);
            getFirstNameConn.CloseConnection();
            return firstName;
        }
        //  DESCRIPTION: Gets last name based on userID
        public string getLastName(int userID)
        {
            string lastName;
            DBConnect getLastNameConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT lastName from dbo.user where userid = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            //assign value to variable
            lastName = getLastNameConn.stringScalar(cmd);
            getLastNameConn.CloseConnection();
            return lastName;
        }
        //  DESCRIPTION: sets first name based on userID
        public bool setFirstName(int userID, string firstName)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `firstName` = @newfirstName WHERE `userID` = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newFirstName", MySqlDbType.VarChar, 45).Value = firstName;

            DBConnect updateFirstName = new DBConnect();
            if ((updateFirstName.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }
        //  DESCRIPTION: sets last name based on userID
        public bool setLastName(int userID, string lastName)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `lastName` = @newLastName WHERE `userID` = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newLastName", MySqlDbType.VarChar, 45).Value = lastName;

            DBConnect updateLastName = new DBConnect();
            if ((updateLastName.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }
        //DESCRIPTION: Change the secret question given the user id
        public bool setSecretQuestion(int userID, string secretQuestion)
        {
            // build query
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `secretQuestion` = @newQuestion WHERE `userID` = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newQuestion", MySqlDbType.VarChar, 250).Value = secretQuestion;
            DBConnect updatesecretQuestion = new DBConnect();
            if ((updatesecretQuestion.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }
        //DESCRIPTION: Change the secret answer given the user id
        public bool setSecretAnswer(int userID, string secretAnswer)
        {
            // build query
            string updateLastNameQuery = "UPDATE `dbo`.`user` SET `secretAnswer` = @newAnswer WHERE `userID` = @userID";
            MySqlCommand cmd = new MySqlCommand(updateLastNameQuery);
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            cmd.Parameters.Add("@newAnswer", MySqlDbType.VarChar, 250).Value = secretAnswer;

            DBConnect updatesecretAnswer = new DBConnect();
            if ((updatesecretAnswer.NonQuery(cmd)) > 0)
                return true;
            else
                return false;
        }
        //  DESCRIPTION: get minimum charge for a hotel stay from file
        public decimal getMinCharge()
        {
            decimal minCharge;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if(decimal.TryParse(fileLines[0].Substring(fileLines[0].IndexOf(' ')), out minCharge))
            {
                return minCharge;
            }
            else
            {
                MessageBox.Show("Unable to retrieve minimum charge. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get cancelation fee for a hotel stay from file
        public decimal getCancelCharge()
        {
            decimal cancelCharge;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (decimal.TryParse(fileLines[1].Substring(fileLines[0].IndexOf(' ')), out cancelCharge))
            {
                return cancelCharge;
            }
            else
            {
                MessageBox.Show("Unable to retrieve cancelation charge. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get cancelation window from the file
        public int getCancelWindow()
        {
            int cancelWindow;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[2].Substring(fileLines[0].IndexOf(' ')), out cancelWindow))
            {
                return cancelWindow;
            }
            else
            {
                MessageBox.Show("Unable to retrieve cancelation window. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get points per day for stay from the file
        public int getDailyPointAmount()
        {
            int points;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[3].Substring(fileLines[0].IndexOf(' ')), out points))
            {
                return points;
            }
            else
            {
                MessageBox.Show("Unable to retrieve rewards points per night. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get notification window from the file
        public int getNotificationWindow()
        {
            int notifDays;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[4].Substring(fileLines[0].IndexOf(' ')), out notifDays))
            {
                return notifDays;
            }
            else
            {
                MessageBox.Show("Unable to retrieve notification window. 0 will be used.");
                return 0;
            }
        }

        // DESCRIPTION: calculates total price of reservation
        public double calculatePrice(double days, double pricePerNight)
        {
            double price =pricePerNight * days;
            return price;
        }

        // DESCRIPTION: Calculates total points accrued by reservation
        public double calculatePoints(double days)
        {
            double points = days * getDailyPointAmount();
            return points;
        }

        // DESCRIPTION: Gets price per night of roomNum at locationID
        public double getPricePerNight(int locationID, int roomNum)
        {
            DBConnect getPricePerNightConn = new DBConnect();
            MySqlCommand getPricePerNight = new MySqlCommand("SELECT pricePerNight from dbo.room WHERE locationID = @locationID and roomNum = @roomNum");
            getPricePerNight.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
            getPricePerNight.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
            double pricePerNight = getPricePerNightConn.doubleScalar(getPricePerNight);
            return pricePerNight;
        }
    }
}
