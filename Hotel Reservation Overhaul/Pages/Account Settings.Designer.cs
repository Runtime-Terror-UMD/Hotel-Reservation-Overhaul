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
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordDesc = new System.Windows.Forms.Label();
            this.grpChangePass = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassDesc = new System.Windows.Forms.Label();
            this.grpChangeQuestion = new System.Windows.Forms.GroupBox();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.txtCurrentAnswer = new System.Windows.Forms.TextBox();
            this.lblCurrentAnswDesc = new System.Windows.Forms.Label();
            this.lblCurrentQuestionDesc = new System.Windows.Forms.Label();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.txtNewAnswer = new System.Windows.Forms.TextBox();
            this.lblNewAnswDesc = new System.Windows.Forms.Label();
            this.txtNewQuestion = new System.Windows.Forms.TextBox();
            this.lblNewQuestDesc = new System.Windows.Forms.Label();
            this.grpNameEmail = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstNameDesc = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameDesc = new System.Windows.Forms.Label();
            this.lblAccountIDDesc = new System.Windows.Forms.Label();
            this.lblUsernameDesc = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmailDesc = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRewardsPoints = new System.Windows.Forms.Label();
            this.lblRewardDesc = new System.Windows.Forms.Label();
            this.grpChangePass.SuspendLayout();
            this.grpChangeQuestion.SuspendLayout();
            this.grpNameEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 19;
            this.lblDescribe.Text = "Edit your account.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(180, 30);
            this.txtCurrentPassword.MaxLength = 45;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(150, 21);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordDesc
            // 
            this.lblPasswordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDesc.Location = new System.Drawing.Point(25, 30);
            this.lblPasswordDesc.Name = "lblPasswordDesc";
            this.lblPasswordDesc.Size = new System.Drawing.Size(150, 20);
            this.lblPasswordDesc.TabIndex = 0;
            this.lblPasswordDesc.Text = "Current Password:";
            this.lblPasswordDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpChangePass
            // 
            this.grpChangePass.Controls.Add(this.btnChangePassword);
            this.grpChangePass.Controls.Add(this.txtNewPassword);
            this.grpChangePass.Controls.Add(this.lblNewPassDesc);
            this.grpChangePass.Controls.Add(this.txtCurrentPassword);
            this.grpChangePass.Controls.Add(this.lblPasswordDesc);
            this.grpChangePass.Location = new System.Drawing.Point(396, 163);
            this.grpChangePass.Name = "grpChangePass";
            this.grpChangePass.Size = new System.Drawing.Size(350, 150);
            this.grpChangePass.TabIndex = 0;
            this.grpChangePass.TabStop = false;
            this.grpChangePass.Text = "Change Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(100, 100);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 25);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(180, 65);
            this.txtNewPassword.MaxLength = 45;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(150, 21);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassDesc
            // 
            this.lblNewPassDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassDesc.Location = new System.Drawing.Point(25, 65);
            this.lblNewPassDesc.Name = "lblNewPassDesc";
            this.lblNewPassDesc.Size = new System.Drawing.Size(150, 20);
            this.lblNewPassDesc.TabIndex = 0;
            this.lblNewPassDesc.Text = "New Password:";
            this.lblNewPassDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpChangeQuestion
            // 
            this.grpChangeQuestion.Controls.Add(this.lblCurrentQuestion);
            this.grpChangeQuestion.Controls.Add(this.txtCurrentAnswer);
            this.grpChangeQuestion.Controls.Add(this.lblCurrentAnswDesc);
            this.grpChangeQuestion.Controls.Add(this.lblCurrentQuestionDesc);
            this.grpChangeQuestion.Controls.Add(this.btnChangeQuestion);
            this.grpChangeQuestion.Controls.Add(this.txtNewAnswer);
            this.grpChangeQuestion.Controls.Add(this.lblNewAnswDesc);
            this.grpChangeQuestion.Controls.Add(this.txtNewQuestion);
            this.grpChangeQuestion.Controls.Add(this.lblNewQuestDesc);
            this.grpChangeQuestion.Location = new System.Drawing.Point(40, 327);
            this.grpChangeQuestion.Name = "grpChangeQuestion";
            this.grpChangeQuestion.Size = new System.Drawing.Size(706, 225);
            this.grpChangeQuestion.TabIndex = 0;
            this.grpChangeQuestion.TabStop = false;
            this.grpChangeQuestion.Text = "Change Secret Question";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(180, 30);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(506, 20);
            this.lblCurrentQuestion.TabIndex = 0;
            // 
            // txtCurrentAnswer
            // 
            this.txtCurrentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAnswer.Location = new System.Drawing.Point(180, 65);
            this.txtCurrentAnswer.MaxLength = 250;
            this.txtCurrentAnswer.Name = "txtCurrentAnswer";
            this.txtCurrentAnswer.Size = new System.Drawing.Size(506, 21);
            this.txtCurrentAnswer.TabIndex = 6;
            this.txtCurrentAnswer.UseSystemPasswordChar = true;
            // 
            // lblCurrentAnswDesc
            // 
            this.lblCurrentAnswDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAnswDesc.Location = new System.Drawing.Point(25, 65);
            this.lblCurrentAnswDesc.Name = "lblCurrentAnswDesc";
            this.lblCurrentAnswDesc.Size = new System.Drawing.Size(150, 20);
            this.lblCurrentAnswDesc.TabIndex = 0;
            this.lblCurrentAnswDesc.Text = "Current Answer:";
            this.lblCurrentAnswDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCurrentQuestionDesc
            // 
            this.lblCurrentQuestionDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestionDesc.Location = new System.Drawing.Point(25, 30);
            this.lblCurrentQuestionDesc.Name = "lblCurrentQuestionDesc";
            this.lblCurrentQuestionDesc.Size = new System.Drawing.Size(150, 20);
            this.lblCurrentQuestionDesc.TabIndex = 0;
            this.lblCurrentQuestionDesc.Text = "Current Question:";
            this.lblCurrentQuestionDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Location = new System.Drawing.Point(300, 175);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(150, 25);
            this.btnChangeQuestion.TabIndex = 9;
            this.btnChangeQuestion.Text = "Change Question";
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            this.btnChangeQuestion.Click += new System.EventHandler(this.btnChangeQuestion_Click);
            // 
            // txtNewAnswer
            // 
            this.txtNewAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewAnswer.Location = new System.Drawing.Point(180, 135);
            this.txtNewAnswer.MaxLength = 250;
            this.txtNewAnswer.Name = "txtNewAnswer";
            this.txtNewAnswer.Size = new System.Drawing.Size(506, 21);
            this.txtNewAnswer.TabIndex = 8;
            // 
            // lblNewAnswDesc
            // 
            this.lblNewAnswDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAnswDesc.Location = new System.Drawing.Point(25, 135);
            this.lblNewAnswDesc.Name = "lblNewAnswDesc";
            this.lblNewAnswDesc.Size = new System.Drawing.Size(150, 20);
            this.lblNewAnswDesc.TabIndex = 0;
            this.lblNewAnswDesc.Text = "New Answer:";
            this.lblNewAnswDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNewQuestion
            // 
            this.txtNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewQuestion.Location = new System.Drawing.Point(180, 100);
            this.txtNewQuestion.MaxLength = 250;
            this.txtNewQuestion.Name = "txtNewQuestion";
            this.txtNewQuestion.Size = new System.Drawing.Size(506, 21);
            this.txtNewQuestion.TabIndex = 7;
            // 
            // lblNewQuestDesc
            // 
            this.lblNewQuestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewQuestDesc.Location = new System.Drawing.Point(25, 100);
            this.lblNewQuestDesc.Name = "lblNewQuestDesc";
            this.lblNewQuestDesc.Size = new System.Drawing.Size(150, 20);
            this.lblNewQuestDesc.TabIndex = 0;
            this.lblNewQuestDesc.Text = "New Question:";
            this.lblNewQuestDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpNameEmail
            // 
            this.grpNameEmail.Controls.Add(this.txtFirstName);
            this.grpNameEmail.Controls.Add(this.lblFirstNameDesc);
            this.grpNameEmail.Controls.Add(this.btnChangeName);
            this.grpNameEmail.Controls.Add(this.txtLastName);
            this.grpNameEmail.Controls.Add(this.lblLastNameDesc);
            this.grpNameEmail.Location = new System.Drawing.Point(40, 163);
            this.grpNameEmail.Name = "grpNameEmail";
            this.grpNameEmail.Size = new System.Drawing.Size(350, 150);
            this.grpNameEmail.TabIndex = 0;
            this.grpNameEmail.TabStop = false;
            this.grpNameEmail.Text = "Change Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(181, 29);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 21);
            this.txtFirstName.TabIndex = 24;
            // 
            // lblFirstNameDesc
            // 
            this.lblFirstNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameDesc.Location = new System.Drawing.Point(25, 30);
            this.lblFirstNameDesc.Name = "lblFirstNameDesc";
            this.lblFirstNameDesc.Size = new System.Drawing.Size(150, 20);
            this.lblFirstNameDesc.TabIndex = 23;
            this.lblFirstNameDesc.Text = "First Name:";
            this.lblFirstNameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(100, 100);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(150, 25);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(181, 64);
            this.txtLastName.MaxLength = 45;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 21);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastNameDesc
            // 
            this.lblLastNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameDesc.Location = new System.Drawing.Point(26, 62);
            this.lblLastNameDesc.Name = "lblLastNameDesc";
            this.lblLastNameDesc.Size = new System.Drawing.Size(150, 20);
            this.lblLastNameDesc.TabIndex = 22;
            this.lblLastNameDesc.Text = "Last Name:";
            this.lblLastNameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountIDDesc
            // 
            this.lblAccountIDDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountIDDesc.Location = new System.Drawing.Point(65, 100);
            this.lblAccountIDDesc.Name = "lblAccountIDDesc";
            this.lblAccountIDDesc.Size = new System.Drawing.Size(150, 20);
            this.lblAccountIDDesc.TabIndex = 0;
            this.lblAccountIDDesc.Text = "Account ID:";
            this.lblAccountIDDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsernameDesc
            // 
            this.lblUsernameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDesc.Location = new System.Drawing.Point(65, 125);
            this.lblUsernameDesc.Name = "lblUsernameDesc";
            this.lblUsernameDesc.Size = new System.Drawing.Size(150, 20);
            this.lblUsernameDesc.TabIndex = 0;
            this.lblUsernameDesc.Text = "Username:";
            this.lblUsernameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountID
            // 
            this.lblAccountID.BackColor = System.Drawing.SystemColors.Window;
            this.lblAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(220, 100);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(150, 20);
            this.lblAccountID.TabIndex = 0;
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(220, 125);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailDesc
            // 
            this.lblEmailDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDesc.Location = new System.Drawing.Point(420, 101);
            this.lblEmailDesc.Name = "lblEmailDesc";
            this.lblEmailDesc.Size = new System.Drawing.Size(150, 20);
            this.lblEmailDesc.TabIndex = 21;
            this.lblEmailDesc.Text = "Email:";
            this.lblEmailDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(576, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRewardsPoints
            // 
            this.lblRewardsPoints.BackColor = System.Drawing.SystemColors.Window;
            this.lblRewardsPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRewardsPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardsPoints.Location = new System.Drawing.Point(576, 126);
            this.lblRewardsPoints.Name = "lblRewardsPoints";
            this.lblRewardsPoints.Size = new System.Drawing.Size(150, 20);
            this.lblRewardsPoints.TabIndex = 24;
            this.lblRewardsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRewardDesc
            // 
            this.lblRewardDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardDesc.Location = new System.Drawing.Point(420, 126);
            this.lblRewardDesc.Name = "lblRewardDesc";
            this.lblRewardDesc.Size = new System.Drawing.Size(150, 20);
            this.lblRewardDesc.TabIndex = 23;
            this.lblRewardDesc.Text = "Reward Points:";
            this.lblRewardDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblRewardsPoints);
            this.Controls.Add(this.lblRewardDesc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailDesc);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.lblUsernameDesc);
            this.Controls.Add(this.lblAccountIDDesc);
            this.Controls.Add(this.grpNameEmail);
            this.Controls.Add(this.grpChangeQuestion);
            this.Controls.Add(this.grpChangePass);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
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
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblPasswordDesc;
        private System.Windows.Forms.GroupBox grpChangePass;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassDesc;
        private System.Windows.Forms.GroupBox grpChangeQuestion;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.TextBox txtCurrentAnswer;
        private System.Windows.Forms.Label lblCurrentAnswDesc;
        private System.Windows.Forms.Label lblCurrentQuestionDesc;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.TextBox txtNewAnswer;
        private System.Windows.Forms.Label lblNewAnswDesc;
        private System.Windows.Forms.Label lblNewQuestDesc;
        private System.Windows.Forms.GroupBox grpNameEmail;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastNameDesc;
        private System.Windows.Forms.Label lblAccountIDDesc;
        private System.Windows.Forms.Label lblUsernameDesc;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstNameDesc;
        private System.Windows.Forms.Label lblEmailDesc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRewardsPoints;
        private System.Windows.Forms.Label lblRewardDesc;
        private System.Windows.Forms.TextBox txtNewQuestion;
    }
}