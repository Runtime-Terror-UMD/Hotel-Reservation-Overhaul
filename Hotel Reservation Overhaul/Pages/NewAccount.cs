using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Reservation_Overhaul
{
    public partial class NewAccount : Form
    {
        Login loginForm;
        public NewAccount(Login loginScreen)
        {
            InitializeComponent();
            this.loginForm = loginScreen;
        }

        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        // DESCRIPTION: Begins user account creation process
        private void btnNew_Click(object sender, EventArgs e)
        {
            //reset error status
            lblError.Visible = false;

            Utilities verifyNewAccount = new Utilities();

            // check that fields are entered and valid

            // if no account type selected
            if ((rbtnCustomer.Checked == false) && (rbtnEmployee.Checked == false))
            {
               displayError("Please select account type");
            }
            // if first name not entered
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                displayError("First Name is required");
            }
            // if last name not entered
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                displayError("Last Name is required");
            }
            // if username  not entered
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                displayError("Username is required");
            }
            else if (verifyNewAccount.isValidEmail(txtUsername.Text))
            {
                displayError("Username cannot be an email address");
            }
            // if password  not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                displayError("Password is required");
            }
            else if((txtPassword.Text.Length) > 45)
            {
                displayError("Password cannot exceed 45 characters");
            }
            // if email not entered
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                displayError("Email address is required");
            }
            // if email format is invalid
            else if (!(verifyNewAccount.isValidEmail(txtEmail.Text)))
            {
                displayError("Invalid email format");
            }
            // if secret question not entered
            else if (string.IsNullOrWhiteSpace(txtSQuest.Text))
            {
                displayError("Secret Question is required");
            }
            // if secret answer  not entered
            else if (string.IsNullOrWhiteSpace(txtSAns.Text))
            {
                displayError("Secret Answer is required");
            }
            else
            {
                //Fields are entered and valid. Proceed with mySQL
                // if email address already in use
                if (verifyNewAccount.emailExists(txtEmail.Text))
                {
                    displayError("Email address already in use");
                }
                // if username already in use
                else if (verifyNewAccount.usernameExists(txtUsername.Text))
                {
                    displayError("Username already in use");
                }

                else
                {
                    // Everything is good. Create user account

                    MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `dbo`.`user`(`firstName`,`lastName`,`email`,`secretQuestion`,`secretAnswer`,`username`,`password`,`isCustomer`)
                                                        VALUES(@firstName,@lastName,@email,@secretQuestion,@secretAnswer,@username,@password,@isCustomer)");

                    // assign parameter values 
                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value =  txtFirstName.Text;
                    cmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = txtLastName.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = txtEmail.Text;
                    cmd.Parameters.Add("@secretQuestion", MySqlDbType.VarChar, 45).Value = txtSQuest.Text;
                    cmd.Parameters.Add("@secretAnswer", MySqlDbType.VarChar, 45).Value = txtSAns.Text;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = txtUsername.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = txtPassword.Text;
                    cmd.Parameters.Add("@isCustomer", MySqlDbType.Bit);
                    // set user type

                    if (rbtnCustomer.Checked == true)
                    { cmd.Parameters["@isCustomer"].Value = 1; }
                    else { cmd.Parameters["@isCustomer"].Value = 0; }

                    // connect to database
                    DBConnect userCreationConn = new DBConnect();

                    // execute statement
                    if(userCreationConn.NonQuery(cmd) > 0)
                    {
                        // return to login page
                        this.Close();
                        loginForm.accountCreated("Account created successfully!");
                    }
                    else
                    {
                        displayError("Error creating account");
                    }

                }

            }

        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
