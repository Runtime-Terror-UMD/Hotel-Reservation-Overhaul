using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Reservation_Overhaul
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        // DESCRIPTION: Checks to see if user-entered email address is in valid format
        private bool isValidEmail(string email)

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
        private bool emailExists(string email)
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
            if (emailExistsConn.Count(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user-entered username address is already in use
        private bool usernameExists(string username)
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
            if (usernameExistsConn.Count(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Begins user account creation process
        private void btnNew_Click(object sender, EventArgs e)
        {
            //reset error status
            lblError.Visible = false;              

            // check that fields are entered and valid
            
            // if no account type selected
            if ((rbtnCustomer.Checked == false) && (rbtnEmployee.Checked == false)) 
            {
                lblError.Text = "Error: Please select account type";  
                lblError.Visible = true;
            }
            // if first name not entered
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))    
            {
                lblError.Text = "Error: First Name is required";  
                lblError.Visible = true;
            }
            // if last name not entered
            else if (string.IsNullOrWhiteSpace(txtLastName.Text)) 
            {
                lblError.Text = "Error: Last Name is required";  
                lblError.Visible = true;
            }
            // if username  not entered
            else if (string.IsNullOrWhiteSpace(txtUsername.Text)) 
            {
                lblError.Text = "Error: Username is required";  
                lblError.Visible = true;
            }
            // if password  not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text)) 
            {
                lblError.Text = "Error: Password is required"; 
                lblError.Visible = true;
            }
            // if email not entered
            else if (string.IsNullOrWhiteSpace(txtEmail.Text)) 
            {
                lblError.Text = "Error: Email address is required";  
                lblError.Visible = true;
            }
            // if email format is invalid
            else if (!(isValidEmail(txtEmail.Text)))     
            {
                lblError.Text = "Error: Invalid email format";  
                lblError.Visible = true;
            }
            // if secret question not entered
            else if (string.IsNullOrWhiteSpace(txtSQuest.Text)) 
            {
                lblError.Text = "Error: Secret Question is required";  
                lblError.Visible = true;
            }
            // if secret answer  not entered
            else if (string.IsNullOrWhiteSpace(txtSAns.Text))
            {
                lblError.Text = "Error: Secret Answer is required"; 
                lblError.Visible = true;
            }
            else
            {
                //Fields are entered and valid. Proceed with mySQL
                // if email address already in use
                if (emailExists(txtEmail.Text))          
                {
                    lblError.Text = "Error: Email address already in use"; 
                    lblError.Visible = true;
                }
                // if username already in use
                else if (usernameExists(txtUsername.Text))           
                {
                    lblError.Text = "Error: Username already in use";  
                    lblError.Visible = true;
                }

                else
                {
                    // Everything is good. Create user account

                    string createUser = "INSERT INTO `dbo`.`user`(`firstName`,`lastName`,`email`,`secretQuestion`,`secretAnswer`,`username`,`password`,`isCustomer`)VALUES(@firstName,@lastName,@email,@secretQuestion,@secretAnswer,@username,@password,@isCustomer)";
                    MySqlCommand cmd = new MySqlCommand(createUser);

                    // add parameters to command

                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@secretQuestion", MySqlDbType.VarChar, 250);
                    cmd.Parameters.Add("@secretAnswer", MySqlDbType.VarChar, 250);
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@isCustomer", MySqlDbType.Bit);

                    // assign parameter values 

                    cmd.Parameters["@firstName"].Value = txtFirstName.Text;
                    cmd.Parameters["@lastName"].Value = txtLastName.Text;
                    cmd.Parameters["@email"].Value = txtEmail.Text;
                    cmd.Parameters["@secretQuestion"].Value = txtSQuest.Text;
                    cmd.Parameters["@secretAnswer"].Value = txtSAns.Text;
                    cmd.Parameters["@username"].Value = txtUsername.Text;
                    cmd.Parameters["@password"].Value = txtPassword.Text;

                    // set user type

                    if (rbtnCustomer.Checked == true)                    
                    { cmd.Parameters["@isCustomer"].Value = 1; }
                    else { cmd.Parameters["@isCustomer"].Value = 0; }

                    // connect to database
                    DBConnect userCreationConn = new DBConnect();

                    // execute statement
                    userCreationConn.NonQuery(cmd);

                    /*
                    
                    RETURN TO LOGIN SCREEN. DISPLAY "ACCOUNT CREATED SUCCESSFULLY" MESSAGE

                     */
                    this.Close();  
                                      
                }

            }

        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            /*
             RETURN TO LOGIN SCREEN. 
             */
            this.Close();
        }
    }
}
