namespace Hotel_Reservation_Overhaul
{
    partial class Recovery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecover = new System.Windows.Forms.Button();
            this.txtSAns = new System.Windows.Forms.TextBox();
            this.lblSAns = new System.Windows.Forms.Label();
            this.lblSQuest = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuest = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnVerifyAcct = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecover
            // 
            this.btnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.Location = new System.Drawing.Point(488, 612);
            this.btnRecover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(225, 46);
            this.btnRecover.TabIndex = 4;
            this.btnRecover.Text = "Reset Password";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // txtSAns
            // 
            this.txtSAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAns.Location = new System.Drawing.Point(565, 441);
            this.txtSAns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSAns.Name = "txtSAns";
            this.txtSAns.Size = new System.Drawing.Size(223, 28);
            this.txtSAns.TabIndex = 2;
            this.txtSAns.UseSystemPasswordChar = true;
            this.txtSAns.Visible = false;
            // 
            // lblSAns
            // 
            this.lblSAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAns.Location = new System.Drawing.Point(358, 441);
            this.lblSAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSAns.Name = "lblSAns";
            this.lblSAns.Size = new System.Drawing.Size(192, 31);
            this.lblSAns.TabIndex = 21;
            this.lblSAns.Text = "Secret Answer:";
            this.lblSAns.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSAns.Visible = false;
            // 
            // lblSQuest
            // 
            this.lblSQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQuest.Location = new System.Drawing.Point(334, 380);
            this.lblSQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSQuest.Name = "lblSQuest";
            this.lblSQuest.Size = new System.Drawing.Size(216, 31);
            this.lblSQuest.TabIndex = 22;
            this.lblSQuest.Text = "Secret Question:";
            this.lblSQuest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSQuest.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(300, 692);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(600, 62);
            this.lblError.TabIndex = 23;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(300, 215);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 62);
            this.lblDescribe.TabIndex = 24;
            this.lblDescribe.Text = "Password Reset: Enter username and answer your secret question, and the desired n" +
    "ew password.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(565, 318);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(223, 28);
            this.txtUser.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(400, 318);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 31);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 154);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuest
            // 
            this.lblQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.Location = new System.Drawing.Point(565, 380);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(420, 32);
            this.lblQuest.TabIndex = 33;
            this.lblQuest.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(565, 503);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(364, 503);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(186, 31);
            this.lblPassword.TabIndex = 35;
            this.lblPassword.Text = "New Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPassword.Visible = false;
            // 
            // btnVerifyAcct
            // 
            this.btnVerifyAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyAcct.Location = new System.Drawing.Point(488, 612);
            this.btnVerifyAcct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerifyAcct.Name = "btnVerifyAcct";
            this.btnVerifyAcct.Size = new System.Drawing.Size(225, 46);
            this.btnVerifyAcct.TabIndex = 36;
            this.btnVerifyAcct.Text = "Verify Account";
            this.btnVerifyAcct.UseVisualStyleBackColor = true;
            this.btnVerifyAcct.Click += new System.EventHandler(this.btnVerifyAcct_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(13, 30);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(225, 46);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.Text = "Return to Login";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Recovery
            // 
            this.AcceptButton = this.btnVerifyAcct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnVerifyAcct);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.txtSAns);
            this.Controls.Add(this.lblSAns);
            this.Controls.Add(this.lblSQuest);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Recovery";
            this.Text = "Hotel Reservation: Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.TextBox txtSAns;
        private System.Windows.Forms.Label lblSAns;
        private System.Windows.Forms.Label lblSQuest;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnVerifyAcct;
        private System.Windows.Forms.Button btnReturn;
    }
}