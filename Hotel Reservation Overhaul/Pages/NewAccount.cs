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
            else if (!(verifyNewAccount.isValidEmail(txtEmail.Text)))
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
                if (verifyNewAccount.emailExists(txtEmail.Text))
                {
                    lblError.Text = "Error: Email address already in use";
                    lblError.Visible = true;
                }
                // if username already in use
                else if (verifyNewAccount.usernameExists(txtUsername.Text))
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

                    // return to login page
                    this.Close();
                    loginForm.accountCreated("Account created successfully!");
                }

            }

        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
