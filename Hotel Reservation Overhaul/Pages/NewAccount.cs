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

namespace Hotel_Reservation_Overhaul
{
    public partial class NewAccount : Form
    {
        private bool isValidEmail(string email) 
        
        {
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

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

        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // check that fields are entered and valid

            if ((rbtnCustomer.Checked == false) && (rbtnEmployee.Checked == false)) // if no account type selected
            {
                lblError.Text = "Error: Please select account type";   // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))     // if first name not entered
            {
                lblError.Text = "Error: First Name is required";   // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text)) // if last name not entered
            {
                lblError.Text = "Error: Last Name is required";  // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text)) // if username  not entered
            {
                lblError.Text = "Error: Username is required";  // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text)) // if password  not entered
            {
                lblError.Text = "Error: Password is required";  // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text)) // if email not entered
            {
                lblError.Text = "Error: Email address is required";  // throw error
                lblError.Visible = true;
            }
            else if (!(isValidEmail(txtEmail.Text)))     // if email format is invalid
            {
                lblError.Text = "Error: Invalid email format";  // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtSQuest.Text)) // if secret question not entered
            {
                lblError.Text = "Error: Secret Question is required";  // throw error
                lblError.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtSAns.Text)) // if secret answer  not entered
            {
                lblError.Text = "Error: Secret Answer is required";  // throw error
                lblError.Visible = true;
            }
            else
            { 
            //Fields are entered and valid. Proceed with mySQL.
            }    
            
        }
    }
}
