namespace Hotel_Reservation_Overhaul
{
    partial class Payment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboxMethod = new System.Windows.Forms.ComboBox();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.lblExpire = new System.Windows.Forms.Label();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.checkRewards = new System.Windows.Forms.CheckedListBox();
            this.lblRewards = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPriceAmount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDepDue = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalDue = new System.Windows.Forms.Label();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPointDesc = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.groupPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 15;
            this.lblDescribe.Text = "Manage your reservations.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date of Payment:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(220, 236);
            this.txtMethod.MaxLength = 5;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(50, 20);
            this.txtMethod.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(20, 86);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(150, 20);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Payment Method:";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxMethod
            // 
            this.cboxMethod.FormattingEnabled = true;
            this.cboxMethod.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express",
            "Discover"});
            this.cboxMethod.Location = new System.Drawing.Point(220, 86);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(120, 21);
            this.cboxMethod.TabIndex = 1;
            // 
            // cboxMonth
            // 
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboxMonth.Location = new System.Drawing.Point(220, 186);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(50, 21);
            this.cboxMonth.TabIndex = 3;
            // 
            // lblExpire
            // 
            this.lblExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.Location = new System.Drawing.Point(20, 186);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(150, 20);
            this.lblExpire.TabIndex = 0;
            this.lblExpire.Text = "Card Expiration Date:";
            this.lblExpire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboxYear.Location = new System.Drawing.Point(290, 186);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(100, 21);
            this.cboxYear.TabIndex = 4;
            // 
            // lblSecurity
            // 
            this.lblSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.Location = new System.Drawing.Point(20, 236);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(150, 20);
            this.lblSecurity.TabIndex = 0;
            this.lblSecurity.Text = "Security Code:";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardNum
            // 
            this.lblCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.Location = new System.Drawing.Point(20, 136);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(150, 20);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "Card Number:";
            this.lblCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(220, 136);
            this.txtCardNum.MaxLength = 12;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(200, 20);
            this.txtCardNum.TabIndex = 2;
            // 
            // checkRewards
            // 
            this.checkRewards.FormattingEnabled = true;
            this.checkRewards.Location = new System.Drawing.Point(220, 286);
            this.checkRewards.Name = "checkRewards";
            this.checkRewards.Size = new System.Drawing.Size(250, 94);
            this.checkRewards.TabIndex = 6;
            // 
            // lblRewards
            // 
            this.lblRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewards.Location = new System.Drawing.Point(20, 286);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(150, 20);
            this.lblRewards.TabIndex = 0;
            this.lblRewards.Text = "Redeem Rewards:";
            this.lblRewards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(600, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Payment";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblPriceAmount
            // 
            this.lblPriceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAmount.Location = new System.Drawing.Point(545, 300);
            this.lblPriceAmount.Name = "lblPriceAmount";
            this.lblPriceAmount.Size = new System.Drawing.Size(100, 20);
            this.lblPriceAmount.TabIndex = 0;
            this.lblPriceAmount.Text = "Amount:";
            this.lblPriceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(650, 300);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(650, 150);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(100, 20);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepDue
            // 
            this.lblDepDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepDue.Location = new System.Drawing.Point(544, 150);
            this.lblDepDue.Name = "lblDepDue";
            this.lblDepDue.Size = new System.Drawing.Size(100, 20);
            this.lblDepDue.TabIndex = 0;
            this.lblDepDue.Text = "Deposit Due:";
            this.lblDepDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(650, 350);
            this.txtTip.MaxLength = 7;
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 8;
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(545, 350);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(100, 20);
            this.lblTip.TabIndex = 23;
            this.lblTip.Text = "Tip:";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.Window;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(650, 200);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 20);
            this.lblBalance.TabIndex = 26;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalDue
            // 
            this.lblBalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalDue.Location = new System.Drawing.Point(544, 200);
            this.lblBalDue.Name = "lblBalDue";
            this.lblBalDue.Size = new System.Drawing.Size(100, 20);
            this.lblBalDue.TabIndex = 0;
            this.lblBalDue.Text = "Balance Due:";
            this.lblBalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupPaymentDetails
            // 
            this.groupPaymentDetails.Controls.Add(this.lblPoints);
            this.groupPaymentDetails.Controls.Add(this.lblPointDesc);
            this.groupPaymentDetails.Controls.Add(this.lblRewards);
            this.groupPaymentDetails.Controls.Add(this.checkRewards);
            this.groupPaymentDetails.Controls.Add(this.lblCardNum);
            this.groupPaymentDetails.Controls.Add(this.txtCardNum);
            this.groupPaymentDetails.Controls.Add(this.lblSecurity);
            this.groupPaymentDetails.Controls.Add(this.cboxYear);
            this.groupPaymentDetails.Controls.Add(this.cboxMonth);
            this.groupPaymentDetails.Controls.Add(this.lblExpire);
            this.groupPaymentDetails.Controls.Add(this.cboxMethod);
            this.groupPaymentDetails.Controls.Add(this.lblMethod);
            this.groupPaymentDetails.Controls.Add(this.txtMethod);
            this.groupPaymentDetails.Controls.Add(this.lblDate);
            this.groupPaymentDetails.Controls.Add(this.dateTimePicker1);
            this.groupPaymentDetails.Location = new System.Drawing.Point(30, 115);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Size = new System.Drawing.Size(500, 400);
            this.groupPaymentDetails.TabIndex = 27;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Information";
            // 
            // lblPointDesc
            // 
            this.lblPointDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointDesc.Location = new System.Drawing.Point(20, 315);
            this.lblPointDesc.Name = "lblPointDesc";
            this.lblPointDesc.Size = new System.Drawing.Size(60, 20);
            this.lblPointDesc.TabIndex = 0;
            this.lblPointDesc.Text = "Points:";
            this.lblPointDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.SystemColors.Window;
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(86, 315);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(85, 20);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupPaymentDetails);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalDue);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDepDue);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPriceAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Payment";
            this.Text = "Hotel Reservation: Payment";
            this.groupPaymentDetails.ResumeLayout(false);
            this.groupPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboxMethod;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.CheckedListBox checkRewards;
        private System.Windows.Forms.Label lblRewards;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPriceAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblDepDue;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalDue;
        private System.Windows.Forms.GroupBox groupPaymentDetails;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointDesc;
    }
}