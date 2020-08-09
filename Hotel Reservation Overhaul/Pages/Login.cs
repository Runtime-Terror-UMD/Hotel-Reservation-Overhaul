using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //DESCRIPTION: opens NewAccount page
        private void btnNew_Click(object sender, EventArgs e)
        {
            var newAcct = new NewAccount(this);
            newAcct.FormClosed += new FormClosedEventHandler(newAcct_FormClosed);
            this.Hide();
            newAcct.Show();
        }

        // DESCRIPTION: un-hides page after newAccount page is closed
        void newAcct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void recovery_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }

        // DESCRIPTION: Display "account created" message
        public void accountCreated(string message)
        {
            lblError.ForeColor = System.Drawing.Color.Green;
            lblError.Text = message;
            lblError.Visible = true;

        }

        // DESCRIPTION: Checks if entered password matches specified username
        private bool passwordMatches(string username, string password)
        {
            // construct query
            string passwordMatchesQuery = "SELECT Count(*) from dbo.user where username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(passwordMatchesQuery);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45);
            cmd.Parameters["@password"].Value = password;

            // connect to database
            DBConnect passwordMatches = new DBConnect();

            // if records exist
            if (passwordMatches.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: checks if user is customer account
        private bool isCustomer(string username)
        {
            bool customerAcct = false;

            // connect to database
            DBConnect isCustomerConn = new DBConnect();
        
            // construct query
            string iCustomerQuery = "SELECT isCustomer from dbo.user where username = @username";
            MySqlCommand cmd = new MySqlCommand(iCustomerQuery);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
            cmd.Parameters["@username"].Value = username;

            MySqlDataReader myReader;
            myReader = isCustomerConn.ExecuteReader(cmd);

            // pull data from record
            while (myReader.Read())
            {
                string customer = myReader["isCustomer"].ToString();
                if (customer == "1")
                    customerAcct = true;
            }
            // close connections
            myReader.Close();
            isCustomerConn.CloseConnection();
            return customerAcct;

            }
        
         // DESCRIPTION: Login process
         private void btnLogin_Click(object sender, EventArgs e)
        {
            Utilities verifyCredentials = new Utilities();

            // reset error status
            lblError.Visible = false;
            lblError.ForeColor = System.Drawing.Color.Red;

            // if username not entered
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Error: Username is required";
                lblError.Visible = true;
            }
            // if password not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Error: Password is required";
                lblError.Visible = true;
            }

            else
            {
                if(verifyCredentials.usernameExists(txtUsername.Text))
                {
                    if(passwordMatches(txtUsername.Text, txtPassword.Text))
                    {
                        if(isCustomer(txtUsername.Text))
                        {
                            // re-drecit to menu, hide hotel management button
                            var menuScreen = new Menu(1);
                            this.Hide();
                            menuScreen.Show();
                        }
                        else
                        {   // re-drecit to menu, show hotel management button
                            var menuScreen = new Menu(0);
                            this.Hide();
                            menuScreen.Show();
                        }                       
                    }
                    else
                    {
                        lblError.Text = "Error invalid password";
                        lblError.Visible = true;
                    }    
                }
                else
                {
                    lblError.Text = "Error: Username does not exist";
                    lblError.Visible = true;
                }
            }
        }

        //DESCRIPTION: re-directs to username recovery page
        private void linklblUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverUsername = new Recovery("username");
            recoverUsername.FormClosed += new FormClosedEventHandler(recovery_FormClosed);
            this.Hide();
            recoverUsername.Show();
        }

        //DESCRIPTION: re-directs to password reset page
        private void linklblPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resetPassword = new Recovery("password");
            resetPassword.FormClosed += new FormClosedEventHandler(recovery_FormClosed);
            this.Hide();
            resetPassword.Show();
        }
    }
}
