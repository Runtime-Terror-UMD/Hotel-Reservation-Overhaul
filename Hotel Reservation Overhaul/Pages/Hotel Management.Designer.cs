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
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.btnNewHotel = new System.Windows.Forms.Button();
            this.btnNewPackages = new System.Windows.Forms.Button();
            this.btnThirdParty = new System.Windows.Forms.Button();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.btnWaitlist = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.grpReports.SuspendLayout();
            this.grpHotelSettings.SuspendLayout();
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
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Manage the hotel chain.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
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
            this.grpReports.Location = new System.Drawing.Point(50, 325);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(700, 200);
            this.grpReports.TabIndex = 19;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(235, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(235, 115);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(100, 20);
            this.lblHotel.TabIndex = 0;
            this.lblHotel.Text = "Hotel:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxHotel
            // 
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(335, 115);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(200, 21);
            this.cboxHotel.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(235, 70);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 20);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(335, 70);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(235, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(335, 160);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 10;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(335, 25);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 7;
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.Location = new System.Drawing.Point(25, 25);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(200, 160);
            this.lstReports.TabIndex = 6;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(580, 80);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 40);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // grpHotelSettings
            // 
            this.grpHotelSettings.Controls.Add(this.btnNewMaintenance);
            this.grpHotelSettings.Controls.Add(this.btnNewHotel);
            this.grpHotelSettings.Controls.Add(this.btnNewPackages);
            this.grpHotelSettings.Controls.Add(this.btnThirdParty);
            this.grpHotelSettings.Controls.Add(this.btnAccountDetails);
            this.grpHotelSettings.Controls.Add(this.btnWaitlist);
            this.grpHotelSettings.Location = new System.Drawing.Point(50, 100);
            this.grpHotelSettings.Name = "grpHotelSettings";
            this.grpHotelSettings.Size = new System.Drawing.Size(700, 200);
            this.grpHotelSettings.TabIndex = 20;
            this.grpHotelSettings.TabStop = false;
            this.grpHotelSettings.Text = "Hotel Settings";
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMaintenance.Location = new System.Drawing.Point(100, 120);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(150, 50);
            this.btnNewMaintenance.TabIndex = 8;
            this.btnNewMaintenance.Text = "New Maintainance File";
            this.btnNewMaintenance.UseVisualStyleBackColor = true;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click);
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHotel.Location = new System.Drawing.Point(275, 44);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(150, 50);
            this.btnNewHotel.TabIndex = 7;
            this.btnNewHotel.Text = "New Hotel File";
            this.btnNewHotel.UseVisualStyleBackColor = true;
            this.btnNewHotel.Click += new System.EventHandler(this.btnNewHotel_Click);
            // 
            // btnNewPackages
            // 
            this.btnNewPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPackages.Location = new System.Drawing.Point(450, 44);
            this.btnNewPackages.Name = "btnNewPackages";
            this.btnNewPackages.Size = new System.Drawing.Size(150, 50);
            this.btnNewPackages.TabIndex = 6;
            this.btnNewPackages.Text = "New Packages";
            this.btnNewPackages.UseVisualStyleBackColor = true;
            this.btnNewPackages.Click += new System.EventHandler(this.btnNewPackages_Click);
            // 
            // btnThirdParty
            // 
            this.btnThirdParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdParty.Location = new System.Drawing.Point(100, 44);
            this.btnThirdParty.Name = "btnThirdParty";
            this.btnThirdParty.Size = new System.Drawing.Size(150, 50);
            this.btnThirdParty.TabIndex = 5;
            this.btnThirdParty.Text = "Third-Party Reservation File";
            this.btnThirdParty.UseVisualStyleBackColor = true;
            this.btnThirdParty.Click += new System.EventHandler(this.btnThirdParty_Click);
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountDetails.Location = new System.Drawing.Point(450, 120);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(150, 50);
            this.btnAccountDetails.TabIndex = 4;
            this.btnAccountDetails.Text = "Change Account Details";
            this.btnAccountDetails.UseVisualStyleBackColor = true;
            // 
            // btnWaitlist
            // 
            this.btnWaitlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitlist.Location = new System.Drawing.Point(275, 120);
            this.btnWaitlist.Name = "btnWaitlist";
            this.btnWaitlist.Size = new System.Drawing.Size(150, 50);
            this.btnWaitlist.TabIndex = 3;
            this.btnWaitlist.Text = "Edit Waitlist Settings";
            this.btnWaitlist.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileStatus.Location = new System.Drawing.Point(203, 80);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(400, 20);
            this.lblFileStatus.TabIndex = 21;
            this.lblFileStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.grpHotelSettings);
            this.Controls.Add(this.grpReports);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
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
        private System.Windows.Forms.Button btnThirdParty;
        private System.Windows.Forms.Button btnNewMaintenance;
        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Button btnNewPackages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileStatus;
    }
}