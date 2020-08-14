namespace Hotel_Reservation_Overhaul.Pages
{
    partial class HotelManagement
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
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cboxHotel = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpHotelSettings = new System.Windows.Forms.GroupBox();
            this.btnThirdParty = new System.Windows.Forms.Button();
            this.btnEditRewards = new System.Windows.Forms.Button();
            this.btnEditHotels = new System.Windows.Forms.Button();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.btnWaitlist = new System.Windows.Forms.Button();
            this.grpReports.SuspendLayout();
            this.grpHotelSettings.SuspendLayout();
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
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Manage the hotel chain.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 0;
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
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.lblUsername);
            this.grpReports.Controls.Add(this.lblHotel);
            this.grpReports.Controls.Add(this.cboxHotel);
            this.grpReports.Controls.Add(this.lblEndDate);
            this.grpReports.Controls.Add(this.dateEnd);
            this.grpReports.Controls.Add(this.lblStartDate);
            this.grpReports.Controls.Add(this.txtUser);
            this.grpReports.Controls.Add(this.dateStart);
            this.grpReports.Controls.Add(this.lstReports);
            this.grpReports.Controls.Add(this.btnReport);
            this.grpReports.Location = new System.Drawing.Point(75, 500);
            this.grpReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReports.Name = "grpReports";
            this.grpReports.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReports.Size = new System.Drawing.Size(1050, 308);
            this.grpReports.TabIndex = 19;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(352, 246);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(352, 177);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(150, 31);
            this.lblHotel.TabIndex = 0;
            this.lblHotel.Text = "Hotel:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxHotel
            // 
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(502, 177);
            this.cboxHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(298, 28);
            this.cboxHotel.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(352, 108);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(150, 31);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(502, 108);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(298, 26);
            this.dateEnd.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(352, 38);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(150, 31);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(502, 246);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(298, 26);
            this.txtUser.TabIndex = 10;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(502, 38);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(298, 26);
            this.dateStart.TabIndex = 7;
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 20;
            this.lstReports.Items.AddRange(new object[] {
            "Customer History Report"});
            this.lstReports.Location = new System.Drawing.Point(38, 38);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(298, 244);
            this.lstReports.TabIndex = 6;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(870, 123);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 62);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // grpHotelSettings
            // 
            this.grpHotelSettings.Controls.Add(this.btnThirdParty);
            this.grpHotelSettings.Controls.Add(this.btnEditRewards);
            this.grpHotelSettings.Controls.Add(this.btnEditHotels);
            this.grpHotelSettings.Controls.Add(this.btnAccountDetails);
            this.grpHotelSettings.Controls.Add(this.btnWaitlist);
            this.grpHotelSettings.Location = new System.Drawing.Point(75, 154);
            this.grpHotelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHotelSettings.Name = "grpHotelSettings";
            this.grpHotelSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHotelSettings.Size = new System.Drawing.Size(1050, 308);
            this.grpHotelSettings.TabIndex = 20;
            this.grpHotelSettings.TabStop = false;
            this.grpHotelSettings.Text = "Hotel Settings";
            // 
            // btnThirdParty
            // 
            this.btnThirdParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdParty.Location = new System.Drawing.Point(412, 115);
            this.btnThirdParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThirdParty.Name = "btnThirdParty";
            this.btnThirdParty.Size = new System.Drawing.Size(225, 77);
            this.btnThirdParty.TabIndex = 5;
            this.btnThirdParty.Text = "Run Third-Party Files";
            this.btnThirdParty.UseVisualStyleBackColor = true;
            // 
            // btnEditRewards
            // 
            this.btnEditRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRewards.Location = new System.Drawing.Point(675, 62);
            this.btnEditRewards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditRewards.Name = "btnEditRewards";
            this.btnEditRewards.Size = new System.Drawing.Size(225, 77);
            this.btnEditRewards.TabIndex = 2;
            this.btnEditRewards.Text = "Edit Rewards Settings";
            this.btnEditRewards.UseVisualStyleBackColor = true;
            // 
            // btnEditHotels
            // 
            this.btnEditHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHotels.Location = new System.Drawing.Point(150, 62);
            this.btnEditHotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditHotels.Name = "btnEditHotels";
            this.btnEditHotels.Size = new System.Drawing.Size(225, 77);
            this.btnEditHotels.TabIndex = 1;
            this.btnEditHotels.Text = "Edit Hotels";
            this.btnEditHotels.UseVisualStyleBackColor = true;
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountDetails.Location = new System.Drawing.Point(675, 185);
            this.btnAccountDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(225, 77);
            this.btnAccountDetails.TabIndex = 4;
            this.btnAccountDetails.Text = "Change Account Details";
            this.btnAccountDetails.UseVisualStyleBackColor = true;
            // 
            // btnWaitlist
            // 
            this.btnWaitlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitlist.Location = new System.Drawing.Point(150, 185);
            this.btnWaitlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWaitlist.Name = "btnWaitlist";
            this.btnWaitlist.Size = new System.Drawing.Size(225, 77);
            this.btnWaitlist.TabIndex = 3;
            this.btnWaitlist.Text = "Edit Waitlist Settings";
            this.btnWaitlist.UseVisualStyleBackColor = true;
            // 
            // HotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.grpHotelSettings);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotelManagement";
            this.Text = "Hotel Reservation: Hotel Management";
            this.grpReports.ResumeLayout(false);
            this.grpReports.PerformLayout();
            this.grpHotelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.GroupBox grpHotelSettings;
        private System.Windows.Forms.Button btnWaitlist;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cboxHotel;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAccountDetails;
        private System.Windows.Forms.Button btnEditHotels;
        private System.Windows.Forms.Button btnEditRewards;
        private System.Windows.Forms.Button btnThirdParty;
    }
}