namespace Hotel_Reservation_Overhaul.Pages
{
    partial class RewardsSummary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEarned = new System.Windows.Forms.Button();
            this.btnRedeemed = new System.Windows.Forms.Button();
            this.btnOutstanding = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lboxReportData = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEarned);
            this.groupBox1.Controls.Add(this.btnRedeemed);
            this.groupBox1.Controls.Add(this.btnOutstanding);
            this.groupBox1.Location = new System.Drawing.Point(37, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rewards Summary";
            // 
            // btnEarned
            // 
            this.btnEarned.Location = new System.Drawing.Point(43, 185);
            this.btnEarned.Name = "btnEarned";
            this.btnEarned.Size = new System.Drawing.Size(155, 41);
            this.btnEarned.TabIndex = 5;
            this.btnEarned.Text = "Rewards Earned";
            this.btnEarned.UseVisualStyleBackColor = true;
            this.btnEarned.Click += new System.EventHandler(this.btnEarned_Click);
            // 
            // btnRedeemed
            // 
            this.btnRedeemed.Location = new System.Drawing.Point(43, 110);
            this.btnRedeemed.Name = "btnRedeemed";
            this.btnRedeemed.Size = new System.Drawing.Size(155, 41);
            this.btnRedeemed.TabIndex = 4;
            this.btnRedeemed.Text = "Rewards Redeemed";
            this.btnRedeemed.UseVisualStyleBackColor = true;
            this.btnRedeemed.Click += new System.EventHandler(this.btnRedeemed_Click);
            // 
            // btnOutstanding
            // 
            this.btnOutstanding.Location = new System.Drawing.Point(43, 36);
            this.btnOutstanding.Name = "btnOutstanding";
            this.btnOutstanding.Size = new System.Drawing.Size(155, 41);
            this.btnOutstanding.TabIndex = 3;
            this.btnOutstanding.Text = "Rewards Outstanding";
            this.btnOutstanding.UseVisualStyleBackColor = true;
            this.btnOutstanding.Click += new System.EventHandler(this.btnOutstanding_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxReportData);
            this.groupBox2.Controls.Add(this.dateEnd);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Controls.Add(this.lblStart);
            this.groupBox2.Location = new System.Drawing.Point(306, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 262);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Information";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStart.Location = new System.Drawing.Point(24, 36);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(76, 17);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEnd.Location = new System.Drawing.Point(27, 84);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 17);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "End Date:";
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(119, 34);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 6;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(119, 82);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(159, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lboxReportData
            // 
            this.lboxReportData.FormattingEnabled = true;
            this.lboxReportData.Location = new System.Drawing.Point(30, 131);
            this.lboxReportData.Name = "lboxReportData";
            this.lboxReportData.Size = new System.Drawing.Size(289, 95);
            this.lboxReportData.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(602, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(23, 16);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 31);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // RewardsSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 392);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RewardsSummary";
            this.Text = "Hotel Reservation: Rewards Summary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEarned;
        private System.Windows.Forms.Button btnRedeemed;
        private System.Windows.Forms.Button btnOutstanding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lboxReportData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturn;
    }
}