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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalDue = new System.Windows.Forms.Label();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointDesc = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.groupPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(18, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 13;
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
            this.lblDescribe.TabIndex = 15;
            this.lblDescribe.Text = "Manage your reservations.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1046, 18);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 38);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(30, 55);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(225, 31);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date of Payment:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(330, 363);
            this.txtMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMethod.MaxLength = 5;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(73, 26);
            this.txtMethod.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(30, 132);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(225, 31);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Payment Method:";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxMethod
            // 
            this.cboxMethod.FormattingEnabled = true;
            this.cboxMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cboxMethod.Location = new System.Drawing.Point(330, 132);
            this.cboxMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(178, 28);
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
            this.cboxMonth.Location = new System.Drawing.Point(330, 286);
            this.cboxMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(73, 28);
            this.cboxMonth.TabIndex = 3;
            // 
            // lblExpire
            // 
            this.lblExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.Location = new System.Drawing.Point(30, 286);
            this.lblExpire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(225, 31);
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
            this.cboxYear.Location = new System.Drawing.Point(435, 286);
            this.cboxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(148, 28);
            this.cboxYear.TabIndex = 4;
            // 
            // lblSecurity
            // 
            this.lblSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.Location = new System.Drawing.Point(30, 363);
            this.lblSecurity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(225, 31);
            this.lblSecurity.TabIndex = 0;
            this.lblSecurity.Text = "Security Code:";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardNum
            // 
            this.lblCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.Location = new System.Drawing.Point(30, 209);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(225, 31);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "Card Number:";
            this.lblCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(330, 209);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardNum.MaxLength = 12;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(298, 26);
            this.txtCardNum.TabIndex = 2;
            // 
            // checkRewards
            // 
            this.checkRewards.FormattingEnabled = true;
            this.checkRewards.Location = new System.Drawing.Point(330, 440);
            this.checkRewards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRewards.Name = "checkRewards";
            this.checkRewards.Size = new System.Drawing.Size(373, 142);
            this.checkRewards.TabIndex = 6;
            // 
            // lblRewards
            // 
            this.lblRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewards.Location = new System.Drawing.Point(30, 440);
            this.lblRewards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(225, 31);
            this.lblRewards.TabIndex = 0;
            this.lblRewards.Text = "Redeem Rewards:";
            this.lblRewards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(900, 746);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 46);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Payment";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblPriceAmount
            // 
            this.lblPriceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAmount.Location = new System.Drawing.Point(818, 462);
            this.lblPriceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceAmount.Name = "lblPriceAmount";
            this.lblPriceAmount.Size = new System.Drawing.Size(150, 31);
            this.lblPriceAmount.TabIndex = 0;
            this.lblPriceAmount.Text = "Amount:";
            this.lblPriceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(975, 462);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.MaxLength = 7;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(975, 231);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(149, 30);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepDue
            // 
            this.lblDepDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepDue.Location = new System.Drawing.Point(816, 231);
            this.lblDepDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepDue.Name = "lblDepDue";
            this.lblDepDue.Size = new System.Drawing.Size(150, 31);
            this.lblDepDue.TabIndex = 0;
            this.lblDepDue.Text = "Deposit Due:";
            this.lblDepDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.Window;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(975, 308);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(149, 30);
            this.lblBalance.TabIndex = 26;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalDue
            // 
            this.lblBalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalDue.Location = new System.Drawing.Point(816, 308);
            this.lblBalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalDue.Name = "lblBalDue";
            this.lblBalDue.Size = new System.Drawing.Size(150, 31);
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
            this.groupPaymentDetails.Location = new System.Drawing.Point(45, 177);
            this.groupPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPaymentDetails.Size = new System.Drawing.Size(750, 615);
            this.groupPaymentDetails.TabIndex = 27;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Information";
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.SystemColors.Window;
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(129, 485);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(126, 30);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointDesc
            // 
            this.lblPointDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointDesc.Location = new System.Drawing.Point(30, 485);
            this.lblPointDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointDesc.Name = "lblPointDesc";
            this.lblPointDesc.Size = new System.Drawing.Size(90, 31);
            this.lblPointDesc.TabIndex = 0;
            this.lblPointDesc.Text = "Points:";
            this.lblPointDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(818, 538);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(150, 31);
            this.lblTip.TabIndex = 23;
            this.lblTip.Text = "Tip:";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(975, 538);
            this.txtTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTip.MaxLength = 7;
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(148, 26);
            this.txtTip.TabIndex = 8;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalDue;
        private System.Windows.Forms.GroupBox groupPaymentDetails;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointDesc;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtTip;
    }
}