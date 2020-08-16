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
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpHotelSettings = new System.Windows.Forms.GroupBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.btnNewHotel = new System.Windows.Forms.Button();
            this.btnNewPackages = new System.Windows.Forms.Button();
            this.btnThirdParty = new System.Windows.Forms.Button();
            this.btnHotelSettings = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.locationTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTime = new System.Windows.Forms.Button();
            this.grpReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            this.grpHotelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(18, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.lblError);
            this.grpReports.Controls.Add(this.lblUsername);
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
            this.grpReports.Size = new System.Drawing.Size(1050, 334);
            this.grpReports.TabIndex = 19;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(134, 288);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(766, 31);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(352, 159);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User ID:";
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
            this.cboxHotel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locationBindingSource, "locationName", true));
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(335, 115);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(200, 21);
            this.cboxHotel.TabIndex = 10;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            this.locationBindingSource.DataSource = this.hotelmgmt;
            // 
            // hotelmgmt
            // 
            this.hotelmgmt.DataSetName = "hotelmgmt";
            this.hotelmgmt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 9;
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
            this.txtUser.Location = new System.Drawing.Point(502, 159);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 11;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(502, 38);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 8;
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 20;
            this.lstReports.Items.AddRange(new object[] {
            "Customer History",
            "Employee History",
            "Reward Summary",
            "Occupancy Summary",
            "Customer Summary"});
            this.lstReports.Location = new System.Drawing.Point(25, 25);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(200, 160);
            this.lstReports.TabIndex = 7;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged_1);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(870, 123);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 40);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // grpHotelSettings
            // 
            this.grpHotelSettings.Controls.Add(this.btnTime);
            this.grpHotelSettings.Controls.Add(this.btnNewMaintenance);
            this.grpHotelSettings.Controls.Add(this.btnNewHotel);
            this.grpHotelSettings.Controls.Add(this.btnNewPackages);
            this.grpHotelSettings.Controls.Add(this.btnThirdParty);
            this.grpHotelSettings.Controls.Add(this.btnHotelSettings);
            this.grpHotelSettings.Location = new System.Drawing.Point(75, 154);
            this.grpHotelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHotelSettings.Name = "grpHotelSettings";
            this.grpHotelSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHotelSettings.Size = new System.Drawing.Size(1050, 308);
            this.grpHotelSettings.TabIndex = 20;
            this.grpHotelSettings.TabStop = false;
            this.grpHotelSettings.Text = "Hotel Settings";
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(450, 120);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(150, 50);
            this.btnTime.TabIndex = 6;
            this.btnTime.Text = "Go to Next Day";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMaintenance.Location = new System.Drawing.Point(150, 185);
            this.btnNewMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(150, 50);
            this.btnNewMaintenance.TabIndex = 4;
            this.btnNewMaintenance.Text = "New Maintainance File";
            this.btnNewMaintenance.UseVisualStyleBackColor = true;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click);
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHotel.Location = new System.Drawing.Point(412, 68);
            this.btnNewHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(150, 50);
            this.btnNewHotel.TabIndex = 2;
            this.btnNewHotel.Text = "New Hotel File";
            this.btnNewHotel.UseVisualStyleBackColor = true;
            this.btnNewHotel.Click += new System.EventHandler(this.btnNewHotel_Click);
            // 
            // btnNewPackages
            // 
            this.btnNewPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPackages.Location = new System.Drawing.Point(675, 68);
            this.btnNewPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewPackages.Name = "btnNewPackages";
            this.btnNewPackages.Size = new System.Drawing.Size(150, 50);
            this.btnNewPackages.TabIndex = 3;
            this.btnNewPackages.Text = "New Packages";
            this.btnNewPackages.UseVisualStyleBackColor = true;
            this.btnNewPackages.Click += new System.EventHandler(this.btnNewPackages_Click);
            // 
            // btnThirdParty
            // 
            this.btnThirdParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdParty.Location = new System.Drawing.Point(150, 68);
            this.btnThirdParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThirdParty.Name = "btnThirdParty";
            this.btnThirdParty.Size = new System.Drawing.Size(150, 50);
            this.btnThirdParty.TabIndex = 1;
            this.btnThirdParty.Text = "Third-Party Reservation File";
            this.btnThirdParty.UseVisualStyleBackColor = true;
            this.btnThirdParty.Click += new System.EventHandler(this.btnThirdParty_Click);
            // 
            // btnHotelSettings
            // 
            this.btnHotelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelSettings.Location = new System.Drawing.Point(412, 185);
            this.btnHotelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHotelSettings.Name = "btnHotelSettings";
            this.btnHotelSettings.Size = new System.Drawing.Size(150, 50);
            this.btnHotelSettings.TabIndex = 5;
            this.btnHotelSettings.Text = "Edit Hotel Chain Settings";
            this.btnHotelSettings.UseVisualStyleBackColor = true;
            this.btnHotelSettings.Click += new System.EventHandler(this.btnHotelSettings_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileStatus.Location = new System.Drawing.Point(304, 123);
            this.lblFileStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(600, 31);
            this.lblFileStatus.TabIndex = 21;
            this.lblFileStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(450, 120);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(150, 50);
            this.btnTime.TabIndex = 6;
            this.btnTime.Text = "Go to Next Day";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 857);
            this.Controls.Add(this.lblFileStatus);
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
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
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
        private System.Windows.Forms.Button btnHotelSettings;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnThirdParty;
        private System.Windows.Forms.Button btnNewMaintenance;
        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Button btnNewPackages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Label lblError;
        private hotelmgmt hotelmgmt;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private hotelmgmtTableAdapters.locationTableAdapter locationTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTime;
    }
}