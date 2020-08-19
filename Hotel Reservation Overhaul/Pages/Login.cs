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
        Utilities verifyCredentials = new Utilities();
        DateTime currentDate;

        public Login()
        {
            InitializeComponent();
            currentDate = DateTime.Today;
        }

        // DESCRIPTION: Utility function for error display
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
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
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            this.Show();
        }

        void recovery_FormClosed(object send, FormClosedEventArgs e)
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            this.Show();
        }

        // DESCRIPTION: Display "account created" message
        public void accountCreated(string message)
        {
            lblError.ForeColor = System.Drawing.Color.Green;
            lblError.Text = message;
            lblError.Visible = true;

        }

        

        // DESCRIPTION: checks if user is customer account
        private bool isCustomer(string username)
        {
            Utilities getUserID = new Utilities();
            int userID = getUserID.getUserIDFromUsername(username);
            User isCustomerCheck = new User(userID);
            bool customerAcct = false;

            if(isCustomerCheck.isCustomer == true)
            
            { customerAcct = true; }
        
            return customerAcct;
        }
        
         // DESCRIPTION: Login process
         private void btnLogin_Click(object sender, EventArgs e)
        {
            Utilities account = new Utilities();
            // reset error status
            lblError.Visible = false;

            // if username not entered
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                displayError("Username is required");
            }
            // if password not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                displayError("Password is required");
            }

            else
            {
                if(verifyCredentials.usernameExists(txtUsername.Text))
                {
                    if(verifyCredentials.passwordMatches(txtUsername.Text, txtPassword.Text))
                    {
                        if(isCustomer(txtUsername.Text))
                        {
                            // re-drecit to menu, hide hotel management button
                            var menuScreen = new Menu(true, verifyCredentials.getUserIDFromUsername(txtUsername.Text), this, currentDate);
                            menuScreen.FormClosed += new FormClosedEventHandler(menuScreen_FormClosed);
                            this.Hide();
                            menuScreen.Show();
                        }
                        else
                        {   // re-drecit to menu, show hotel management button
                            var menuScreen = new Menu(false, verifyCredentials.getUserIDFromUsername(txtUsername.Text), this, currentDate);
                            menuScreen.FormClosed += new FormClosedEventHandler(menuScreen_FormClosed);
                            this.Hide();
                            menuScreen.Show();
                        }                       
                    }
                    else
                    {
                        displayError("Invalid password");
                    }    
                }
                else
                {
                    displayError("Username does not exist");
                }
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void menuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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
