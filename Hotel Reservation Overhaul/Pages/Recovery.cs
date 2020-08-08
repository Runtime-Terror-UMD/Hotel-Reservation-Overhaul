using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul
{
    public partial class Recovery : Form
    {
        private int typeToRecover;
        public int userID;


        //DESCRIPTION: Displays different buttons/text depending on which recovery option was selected
        public Recovery(string recoveryType)
        {
            if (recoveryType == "password")
            {
                typeToRecover = 1;
                InitializeComponent();
            }
            else if (recoveryType == "username")
            {
                InitializeComponent();
                typeToRecover = 0;
                lblDescribe.Text = "Username Recovery: Enter email address and answer your secret question. Your username will be displayed below";
                lblUsername.Text = "Email";
                btnRecover.Text = "Recover Username";
                lblPassword.Text = "Username";
            }
        }

        private void unhideFields()
        {
            lblQuest.Text = displaySecretQuestion(txtUser.Text);
            lblQuest.Visible = true;
            lblSQuest.Visible = true;
            lblSAns.Visible = true;
            txtSAns.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnVerifyAcct.Visible = false;
        }

        private void displayError(string errorMessage)
        {
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Error: " + errorMessage;
        }

        //DESCRIPTION: Displays secret question associated with username

        public string displaySecretQuestion(string uniqueID)
        {
            string secretQuestion = null;
            string displaySecretQuestionQuery = "SELECT secretQuestion from dbo.user where userid = @userid";
           
            // connect to database
            DBConnect displaySecretQuestionConn = new DBConnect();
            MySqlCommand cmd = new MySqlCommand(displaySecretQuestionQuery);
            Utilities displaySecretQuestion = new Utilities();
          
            // construct query
            if (typeToRecover == 1)
            {
                userID = displaySecretQuestion.getUserIDFromUsername(uniqueID);
            }
            else
            {
                userID = displaySecretQuestion.getUserIDFromEmail(uniqueID);
            }
            cmd.Parameters.Add("@userid", MySqlDbType.VarChar, 45);
            cmd.Parameters["@userid"].Value = userID;

            secretQuestion = displaySecretQuestionConn.stringScalar(cmd);

            displaySecretQuestionConn.CloseConnection();
            return secretQuestion;
        }



        private void btnRecover_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            Utilities recoveryVerification = new Utilities();

            // check that secret answer matches secret question

            //FIXME: Need to change secretAnswerMatches query depending on typeToRecover

            if (recoveryVerification.secretAnswerMatches(userID, txtSAns.Text))
            {

                if (typeToRecover == 1)
                {
                    // if new password field empty

                    if ((string.IsNullOrWhiteSpace(txtPassword.Text)))
                    {
                        displayError("New password not entered");
                    }
                    else
                    {
                        // reset password

                        recoveryVerification.updatePassword(txtUser.Text, txtPassword.Text);
                        lblError.Text = "Your password has been updated";
                        lblError.ForeColor = System.Drawing.Color.Green;
                        lblError.Visible = true;
                    }
                }
                else
                {
                    Utilities getUsername = new Utilities();
                    txtPassword.Text = getUsername.getUsername(userID);
                }
            }
            else
            {
                displayError("Secret answer is incorrect");
            }

        }

        // DESCRIPTION: Verify account exists
        private void btnVerifyAcct_Click(object sender, EventArgs e)
        {
            // reset error status
            lblError.Visible = false;

            // declare and initialize utlity object
            Utilities recoveryVerification = new Utilities();

            // if password reset
            if (typeToRecover == 1)
            {
                //if username exists
                if (recoveryVerification.usernameExists(txtUser.Text))
                {
                    // display secret question and secret answer text fields
                    unhideFields();
                }
                else
                {
                    displayError("Username does not exist");
                }
            }
            else
            {    // if username recovery
                // if valid email format
                if (recoveryVerification.isValidEmail(txtUser.Text))
                {
                    // if email exists
                    if (recoveryVerification.emailExists(txtUser.Text))
                    {
                        unhideFields();
                        txtPassword.ReadOnly = true;
                    }
                    else
                    {
                        displayError("No account associated with that email address");
                    }
                }
                else
                {
                    displayError("Invalid email format");
                }
            }
        }
    }
}
