using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Overhaul.Pages
{
    public partial class AccountSettings : Form
    {
        private int UserID;
        public AccountSettings(int userID)
        {
            InitializeComponent();
            UserID = userID;
            lblAccountID.Text = "" + UserID;
            Utilities accountInfo = new Utilities();
            lblUsername.Text = accountInfo.getUsername(UserID);
            lblRewardsPoints.Text = "" + accountInfo.getRewardsPoints(UserID);
            lblEmail.Text = accountInfo.getEmail(UserID);
            txtFirstName.Text = accountInfo.getFirstName(UserID);
            txtLastName.Text = accountInfo.getLastName(UserID);
            lblCurrentQuestion.Text = accountInfo.getSecretQuestion(UserID);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DESCRIPTION: changes the name of the user
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            Utilities accountInfo = new Utilities();
            string newFirstName = txtFirstName.Text;
            string newLastName = txtLastName.Text;
            if(newFirstName.Length > 45 || newLastName.Length > 45) //name cannot be longer than 45 char
            {
                MessageBox.Show("Full name was not changed. First or last name cannot be longer than 45 characters.");
            }
            else if(accountInfo.setFirstName(UserID, newFirstName) && accountInfo.setLastName(UserID, newLastName))
            {
                MessageBox.Show("Full name was successfully changed.");
            }
            else
            {
                MessageBox.Show("Full name was not changed.");
            }
            txtFirstName.Text = accountInfo.getFirstName(UserID);
            txtLastName.Text = accountInfo.getLastName(UserID);
        }

        //DESCRIPTION: changes the password if the original password matches
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Utilities accountInfo = new Utilities();
            string oldPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            if(newPassword.Length > 45) //if password is longer than 45 char
            {
                MessageBox.Show("New password is too long. Unable to change password.");
            }
            else if (accountInfo.passwordMatches(UserID, oldPassword))
            {
                if(accountInfo.updatePassword(UserID, newPassword))
                {
                    MessageBox.Show("Account password changed successfully.");
                }
                else
                {
                    MessageBox.Show("Unable to change password.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect password. Unable to change password.");
            }
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
        }

        private void btnChangeQuestion_Click(object sender, EventArgs e)
        {
            Utilities accountInfo = new Utilities();
            string currentans = txtCurrentAnswer.Text;
            string newquest = txtNewQuestion.Text;
            string newans = txtNewAnswer.Text;
            if(newquest.Length > 250 || newans.Length > 250)
            {
                MessageBox.Show("New question or answer are too long, they must be less than 250 characters.");
            }
            else if(accountInfo.secretAnswerMatches(UserID, currentans))
            {
                if (accountInfo.setSecretQuestion(UserID, newquest) && accountInfo.setSecretAnswer(UserID, newans))
                {
                    MessageBox.Show("Account secret question and answer has been change successfully.");
                }
                else
                {
                    MessageBox.Show("Account secret question and answer could not be changed.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect secret answer. Account secret question and answer could not be changed.");
            }
            txtCurrentAnswer.Clear();
            txtNewAnswer.Clear();
            txtNewQuestion.Clear();
            lblCurrentQuestion.Text = accountInfo.getSecretQuestion(UserID);
        }
    }
}
