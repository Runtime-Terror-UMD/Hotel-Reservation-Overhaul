using MySql.Data.MySqlClient;

namespace Hotel_Reservation_Overhaul.Pages
{
    partial class AccountSettings
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpChangePass = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChangeQuestion = new System.Windows.Forms.GroupBox();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.txtCurrentAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentQuestionDesc = new System.Windows.Forms.Label();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.txtNewAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNameEmail = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAccountIDDesc = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.grpChangePass.SuspendLayout();
            this.grpChangeQuestion.SuspendLayout();
            this.grpNameEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(18, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(300, 92);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 31);
            this.lblDescribe.TabIndex = 19;
            this.lblDescribe.Text = "Edit your account.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1046, 18);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 38);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(270, 46);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 46);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(225, 31);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Current Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpChangePass
            // 
            this.grpChangePass.Controls.Add(this.btnChangePassword);
            this.grpChangePass.Controls.Add(this.textBox1);
            this.grpChangePass.Controls.Add(this.label1);
            this.grpChangePass.Controls.Add(this.txtPassword);
            this.grpChangePass.Controls.Add(this.lblPassword);
            this.grpChangePass.Location = new System.Drawing.Point(600, 154);
            this.grpChangePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangePass.Name = "grpChangePass";
            this.grpChangePass.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangePass.Size = new System.Drawing.Size(525, 231);
            this.grpChangePass.TabIndex = 0;
            this.grpChangePass.TabStop = false;
            this.grpChangePass.Text = "Change Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(150, 154);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(225, 38);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(270, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpChangeQuestion
            // 
            this.grpChangeQuestion.Controls.Add(this.lblCurrentQuestion);
            this.grpChangeQuestion.Controls.Add(this.txtCurrentAnswer);
            this.grpChangeQuestion.Controls.Add(this.label5);
            this.grpChangeQuestion.Controls.Add(this.lblCurrentQuestionDesc);
            this.grpChangeQuestion.Controls.Add(this.btnChangeQuestion);
            this.grpChangeQuestion.Controls.Add(this.txtNewAnswer);
            this.grpChangeQuestion.Controls.Add(this.label2);
            this.grpChangeQuestion.Controls.Add(this.txtNewQuestion);
            this.grpChangeQuestion.Controls.Add(this.label3);
            this.grpChangeQuestion.Location = new System.Drawing.Point(60, 503);
            this.grpChangeQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangeQuestion.Name = "grpChangeQuestion";
            this.grpChangeQuestion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangeQuestion.Size = new System.Drawing.Size(750, 346);
            this.grpChangeQuestion.TabIndex = 0;
            this.grpChangeQuestion.TabStop = false;
            this.grpChangeQuestion.Text = "Change Secret Question";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(270, 46);
            this.lblCurrentQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(408, 30);
            this.lblCurrentQuestion.TabIndex = 0;
            this.lblCurrentQuestion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCurrentAnswer
            // 
            this.txtCurrentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAnswer.Location = new System.Drawing.Point(270, 100);
            this.txtCurrentAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentAnswer.Name = "txtCurrentAnswer";
            this.txtCurrentAnswer.Size = new System.Drawing.Size(408, 28);
            this.txtCurrentAnswer.TabIndex = 6;
            this.txtCurrentAnswer.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Answer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCurrentQuestionDesc
            // 
            this.lblCurrentQuestionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestionDesc.Location = new System.Drawing.Point(38, 46);
            this.lblCurrentQuestionDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentQuestionDesc.Name = "lblCurrentQuestionDesc";
            this.lblCurrentQuestionDesc.Size = new System.Drawing.Size(225, 31);
            this.lblCurrentQuestionDesc.TabIndex = 0;
            this.lblCurrentQuestionDesc.Text = "Current Question:";
            this.lblCurrentQuestionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Location = new System.Drawing.Point(262, 269);
            this.btnChangeQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(225, 38);
            this.btnChangeQuestion.TabIndex = 9;
            this.btnChangeQuestion.Text = "Change Question";
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            // 
            // txtNewAnswer
            // 
            this.txtNewAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewAnswer.Location = new System.Drawing.Point(270, 208);
            this.txtNewAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewAnswer.Name = "txtNewAnswer";
            this.txtNewAnswer.Size = new System.Drawing.Size(408, 28);
            this.txtNewAnswer.TabIndex = 8;
            this.txtNewAnswer.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNewQuestion
            // 
            this.txtNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewQuestion.Location = new System.Drawing.Point(270, 154);
            this.txtNewQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewQuestion.Name = "txtNewQuestion";
            this.txtNewQuestion.Size = new System.Drawing.Size(408, 28);
            this.txtNewQuestion.TabIndex = 7;
            this.txtNewQuestion.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Question:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpNameEmail
            // 
            this.grpNameEmail.Controls.Add(this.textBox2);
            this.grpNameEmail.Controls.Add(this.lblFirstName);
            this.grpNameEmail.Controls.Add(this.button1);
            this.grpNameEmail.Controls.Add(this.textBox3);
            this.grpNameEmail.Controls.Add(this.lblLastName);
            this.grpNameEmail.Location = new System.Drawing.Point(60, 327);
            this.grpNameEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNameEmail.Name = "grpNameEmail";
            this.grpNameEmail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNameEmail.Size = new System.Drawing.Size(525, 154);
            this.grpNameEmail.TabIndex = 0;
            this.grpNameEmail.TabStop = false;
            this.grpNameEmail.Text = "Change Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Name";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(270, 59);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 28);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(38, 56);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(225, 31);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountIDDesc
            // 
            this.lblAccountIDDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountIDDesc.Location = new System.Drawing.Point(98, 154);
            this.lblAccountIDDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountIDDesc.Name = "lblAccountIDDesc";
            this.lblAccountIDDesc.Size = new System.Drawing.Size(225, 31);
            this.lblAccountIDDesc.TabIndex = 0;
            this.lblAccountIDDesc.Text = "Account ID:";
            this.lblAccountIDDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(98, 192);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(225, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountID
            // 
            this.lblAccountID.BackColor = System.Drawing.SystemColors.Window;
            this.lblAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(330, 154);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(224, 30);
            this.lblAccountID.TabIndex = 0;
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(330, 192);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 30);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(38, 24);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(225, 31);
            this.lblFirstName.TabIndex = 23;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(271, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 28);
            this.textBox2.TabIndex = 24;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(98, 235);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(225, 31);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(331, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 30);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAccountIDDesc);
            this.Controls.Add(this.grpNameEmail);
            this.Controls.Add(this.grpChangeQuestion);
            this.Controls.Add(this.grpChangePass);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountSettings";
            this.Text = "Hotel Reservation: Account Settings";
            this.grpChangePass.ResumeLayout(false);
            this.grpChangePass.PerformLayout();
            this.grpChangeQuestion.ResumeLayout(false);
            this.grpChangeQuestion.PerformLayout();
            this.grpNameEmail.ResumeLayout(false);
            this.grpNameEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpChangePass;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChangeQuestion;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.TextBox txtCurrentAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentQuestionDesc;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.TextBox txtNewAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNameEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAccountIDDesc;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label txtEmail;
    }
}