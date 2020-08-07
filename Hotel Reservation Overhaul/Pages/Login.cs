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

        // DESCRIPTION: Display "account created" message
        public void accountCreated(string message)
        {
            this.lblError.ForeColor = System.Drawing.Color.Green;
            this.lblError.Text = message;
            this.lblError.Visible = true;

        }
    }
}
