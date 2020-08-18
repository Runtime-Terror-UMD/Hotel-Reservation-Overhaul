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
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboxMethod = new System.Windows.Forms.ComboBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblRewards = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPriceAmount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDepDue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalDue = new System.Windows.Forms.Label();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblrewardError = new System.Windows.Forms.Label();
            this.lblCardNumError = new System.Windows.Forms.Label();
            this.lblMethodError = new System.Windows.Forms.Label();
            this.chkReward = new System.Windows.Forms.CheckBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointDesc = new System.Windows.Forms.Label();
            this.lblAmountError = new System.Windows.Forms.Label();
            this.lblApplyReward = new System.Windows.Forms.Label();
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.btnLogOut.Location = new System.Drawing.Point(709, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.cboxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMethod.FormattingEnabled = true;
            this.cboxMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cboxMethod.Location = new System.Drawing.Point(220, 86);
            this.cboxMethod.Name = "cboxMethod";
            this.cboxMethod.Size = new System.Drawing.Size(120, 21);
            this.cboxMethod.TabIndex = 1;
            this.cboxMethod.SelectedIndexChanged += new System.EventHandler(this.cboxMethod_SelectedIndexChanged);
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
            this.txtCardNum.MaxLength = 16;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(200, 20);
            this.txtCardNum.TabIndex = 2;
            this.txtCardNum.TextChanged += new System.EventHandler(this.txtCardNum_TextChanged);
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
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
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
            this.groupPaymentDetails.Controls.Add(this.lblrewardError);
            this.groupPaymentDetails.Controls.Add(this.lblCardNumError);
            this.groupPaymentDetails.Controls.Add(this.lblMethodError);
            this.groupPaymentDetails.Controls.Add(this.chkReward);
            this.groupPaymentDetails.Controls.Add(this.lblPoints);
            this.groupPaymentDetails.Controls.Add(this.lblPointDesc);
            this.groupPaymentDetails.Controls.Add(this.lblRewards);
            this.groupPaymentDetails.Controls.Add(this.lblCardNum);
            this.groupPaymentDetails.Controls.Add(this.txtCardNum);
            this.groupPaymentDetails.Controls.Add(this.cboxMethod);
            this.groupPaymentDetails.Controls.Add(this.lblMethod);
            this.groupPaymentDetails.Controls.Add(this.lblDate);
            this.groupPaymentDetails.Controls.Add(this.dateTimePicker1);
            this.groupPaymentDetails.Location = new System.Drawing.Point(30, 115);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Size = new System.Drawing.Size(500, 400);
            this.groupPaymentDetails.TabIndex = 27;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Information";
            // 
            // lblrewardError
            // 
            this.lblrewardError.AutoSize = true;
            this.lblrewardError.ForeColor = System.Drawing.Color.Red;
            this.lblrewardError.Location = new System.Drawing.Point(226, 309);
            this.lblrewardError.Name = "lblrewardError";
            this.lblrewardError.Size = new System.Drawing.Size(180, 13);
            this.lblrewardError.TabIndex = 28;
            this.lblrewardError.Text = "Error: You don\' t have enough points";
            this.lblrewardError.Visible = false;
            // 
            // lblCardNumError
            // 
            this.lblCardNumError.AutoSize = true;
            this.lblCardNumError.ForeColor = System.Drawing.Color.Red;
            this.lblCardNumError.Location = new System.Drawing.Point(226, 159);
            this.lblCardNumError.Name = "lblCardNumError";
            this.lblCardNumError.Size = new System.Drawing.Size(151, 13);
            this.lblCardNumError.TabIndex = 29;
            this.lblCardNumError.Text = "Error message for card number";
            this.lblCardNumError.Visible = false;
            // 
            // lblMethodError
            // 
            this.lblMethodError.AutoSize = true;
            this.lblMethodError.ForeColor = System.Drawing.Color.Red;
            this.lblMethodError.Location = new System.Drawing.Point(226, 110);
            this.lblMethodError.Name = "lblMethodError";
            this.lblMethodError.Size = new System.Drawing.Size(170, 13);
            this.lblMethodError.TabIndex = 28;
            this.lblMethodError.Text = "Error message for payment method";
            this.lblMethodError.Visible = false;
            // 
            // chkReward
            // 
            this.chkReward.AutoSize = true;
            this.chkReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkReward.Location = new System.Drawing.Point(220, 286);
            this.chkReward.Name = "chkReward";
            this.chkReward.Size = new System.Drawing.Size(182, 20);
            this.chkReward.TabIndex = 3;
            this.chkReward.Text = "10% off reservation - 50pts";
            this.chkReward.UseVisualStyleBackColor = true;
            this.chkReward.CheckedChanged += new System.EventHandler(this.chkReward_CheckedChanged);
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
            // lblAmountError
            // 
            this.lblAmountError.AutoSize = true;
            this.lblAmountError.ForeColor = System.Drawing.Color.Red;
            this.lblAmountError.Location = new System.Drawing.Point(597, 329);
            this.lblAmountError.Name = "lblAmountError";
            this.lblAmountError.Size = new System.Drawing.Size(127, 13);
            this.lblAmountError.TabIndex = 28;
            this.lblAmountError.Text = "Error message for amount";
            this.lblAmountError.Visible = false;
            // 
            // lblApplyReward
            // 
            this.lblApplyReward.AutoSize = true;
            this.lblApplyReward.ForeColor = System.Drawing.Color.Green;
            this.lblApplyReward.Location = new System.Drawing.Point(593, 235);
            this.lblApplyReward.Name = "lblApplyReward";
            this.lblApplyReward.Size = new System.Drawing.Size(131, 13);
            this.lblApplyReward.TabIndex = 29;
            this.lblApplyReward.Text = "10% Discount was applied";
            this.lblApplyReward.Visible = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 549);
            this.Controls.Add(this.lblApplyReward);
            this.Controls.Add(this.lblAmountError);
            this.Controls.Add(this.groupPaymentDetails);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalDue);
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
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboxMethod;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.TextBox txtCardNum;
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
        private System.Windows.Forms.CheckBox chkReward;
        private System.Windows.Forms.Label lblCardNumError;
        private System.Windows.Forms.Label lblMethodError;
        private System.Windows.Forms.Label lblrewardError;
        private System.Windows.Forms.Label lblAmountError;
        private System.Windows.Forms.Label lblApplyReward;
    }
}