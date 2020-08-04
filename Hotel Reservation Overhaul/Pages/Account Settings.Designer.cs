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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grpChangeQuestion = new System.Windows.Forms.GroupBox();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.txtNewAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentQuestionDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentAnswer = new System.Windows.Forms.TextBox();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.grpNameEmail = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAccountIDDesc = new System.Windows.Forms.Label();
            this.lblEmailDesc = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnChangeEmployeeDetails = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpChangePass.SuspendLayout();
            this.grpChangeQuestion.SuspendLayout();
            this.grpNameEmail.SuspendLayout();
            this.grpEmployee.SuspendLayout();
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
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(180, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(150, 20);
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
            this.grpChangePass.Location = new System.Drawing.Point(400, 100);
            this.grpChangePass.Name = "grpChangePass";
            this.grpChangePass.Size = new System.Drawing.Size(350, 150);
            this.grpChangePass.TabIndex = 0;
            this.grpChangePass.TabStop = false;
            this.grpChangePass.Text = "Change Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(180, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(100, 100);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 25);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
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
            this.grpChangeQuestion.Location = new System.Drawing.Point(40, 300);
            this.grpChangeQuestion.Name = "grpChangeQuestion";
            this.grpChangeQuestion.Size = new System.Drawing.Size(500, 225);
            this.grpChangeQuestion.TabIndex = 0;
            this.grpChangeQuestion.TabStop = false;
            this.grpChangeQuestion.Text = "Change Secret Question";
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Location = new System.Drawing.Point(175, 175);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(150, 25);
            this.btnChangeQuestion.TabIndex = 9;
            this.btnChangeQuestion.Text = "Change Question";
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            // 
            // txtNewAnswer
            // 
            this.txtNewAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewAnswer.Location = new System.Drawing.Point(180, 135);
            this.txtNewAnswer.Name = "txtNewAnswer";
            this.txtNewAnswer.Size = new System.Drawing.Size(273, 21);
            this.txtNewAnswer.TabIndex = 8;
            this.txtNewAnswer.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNewQuestion
            // 
            this.txtNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewQuestion.Location = new System.Drawing.Point(180, 100);
            this.txtNewQuestion.Name = "txtNewQuestion";
            this.txtNewQuestion.Size = new System.Drawing.Size(273, 21);
            this.txtNewQuestion.TabIndex = 7;
            this.txtNewQuestion.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Question:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Answer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCurrentAnswer
            // 
            this.txtCurrentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAnswer.Location = new System.Drawing.Point(180, 65);
            this.txtCurrentAnswer.Name = "txtCurrentAnswer";
            this.txtCurrentAnswer.Size = new System.Drawing.Size(273, 21);
            this.txtCurrentAnswer.TabIndex = 6;
            this.txtCurrentAnswer.UseSystemPasswordChar = true;
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(180, 30);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(273, 20);
            this.lblCurrentQuestion.TabIndex = 0;
            this.lblCurrentQuestion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpNameEmail
            // 
            this.grpNameEmail.Controls.Add(this.button1);
            this.grpNameEmail.Controls.Add(this.textBox3);
            this.grpNameEmail.Controls.Add(this.label6);
            this.grpNameEmail.Location = new System.Drawing.Point(40, 150);
            this.grpNameEmail.Name = "grpNameEmail";
            this.grpNameEmail.Size = new System.Drawing.Size(350, 100);
            this.grpNameEmail.TabIndex = 0;
            this.grpNameEmail.TabStop = false;
            this.grpNameEmail.Text = "Change Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Name";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(180, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Full Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // lblEmailDesc
            // 
            this.lblEmailDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDesc.Location = new System.Drawing.Point(65, 125);
            this.lblEmailDesc.Name = "lblEmailDesc";
            this.lblEmailDesc.Size = new System.Drawing.Size(150, 20);
            this.lblEmailDesc.TabIndex = 0;
            this.lblEmailDesc.Text = "Email:";
            this.lblEmailDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(220, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnChangeEmployeeDetails);
            this.grpEmployee.Controls.Add(this.textBox2);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Location = new System.Drawing.Point(568, 300);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(182, 100);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Change Employee Details";
            this.grpEmployee.Visible = false;
            // 
            // btnChangeEmployeeDetails
            // 
            this.btnChangeEmployeeDetails.Location = new System.Drawing.Point(12, 65);
            this.btnChangeEmployeeDetails.Name = "btnChangeEmployeeDetails";
            this.btnChangeEmployeeDetails.Size = new System.Drawing.Size(150, 25);
            this.btnChangeEmployeeDetails.TabIndex = 11;
            this.btnChangeEmployeeDetails.Text = "Change Employee Details";
            this.btnChangeEmployeeDetails.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(86, 30);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salary:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.lblEmailDesc);
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
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAccountIDDesc;
        private System.Windows.Forms.Label lblEmailDesc;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnChangeEmployeeDetails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}