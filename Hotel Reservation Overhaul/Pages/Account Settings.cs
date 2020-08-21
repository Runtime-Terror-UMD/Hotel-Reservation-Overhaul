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
        User userInfo;
        public AccountSettings(int userID)
        {
            InitializeComponent();
            UserID = userID;
            lblAccountID.Text = "" + UserID;
            Utilities accountInfo = new Utilities();
            userInfo = new User(userID);
            lblUsername.Text = userInfo.username;
            lblRewardsPoints.Text = "" + userInfo.rewardPoints;
            lblEmail.Text = userInfo.email;
            txtFirstName.Text = userInfo.firstName;
            txtLastName.Text = userInfo.lastName;
            lblCurrentQuestion.Text = userInfo.secretQuestion;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //DESCRIPTION: changes the name of the user
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Unable to change name");
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Unable to change name");
            }
            else
            {
                User oldNames = new User(UserID);

                userInfo.firstName = txtFirstName.Text;
                userInfo.lastName = txtLastName.Text;
                if(userInfo.updateUser())
                {
                    MessageBox.Show("Full name was successfully changed.");
                    txtFirstName.Text = userInfo.firstName.ToString();
                    txtLastName.Text = userInfo.lastName.ToString();
                }
                else
                {
                    MessageBox.Show("Error updating name");
                    txtFirstName.Text = oldNames.firstName.ToString();
                    txtLastName.Text = oldNames.lastName.ToString();
                }
            } 
        }

        //DESCRIPTION: changes the password if the original password matches
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Unable to change password");
            }
            Utilities accountInfo = new Utilities();
            if (accountInfo.passwordMatches(UserID, txtCurrentPassword.Text))
            {
                userInfo.password = txtNewPassword.Text;
                if(userInfo.updateUser())
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
            if(string.IsNullOrWhiteSpace(txtCurrentAnswer.Text))
            {
                MessageBox.Show("Unable to change question");
            }    
            else if(string.IsNullOrWhiteSpace(txtNewQuestion.Text))
            {
                MessageBox.Show("Unable to change question");
            }
            else if(userInfo.secretAnswer == txtCurrentAnswer.Text)
            {
                userInfo.secretQuestion = txtNewQuestion.Text;
                userInfo.secretAnswer = txtNewAnswer.Text;
                
                if(userInfo.updateUser())
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
            lblCurrentQuestion.Text = userInfo.secretQuestion.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
    }
}
