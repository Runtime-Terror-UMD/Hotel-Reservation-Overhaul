namespace Hotel_Reservation_Overhaul
{
    partial class CreateReservation
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
            this.monthStart = new System.Windows.Forms.MonthCalendar();
            this.monthEnd = new System.Windows.Forms.MonthCalendar();
            this.cboxHotel = new System.Windows.Forms.ComboBox();
            this.locationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSet = new Hotel_Reservation_Overhaul.dboDataSet();
            this.cboxNumGuests = new System.Windows.Forms.ComboBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.checkPackages = new System.Windows.Forms.CheckedListBox();
            this.packageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmgmt1 = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddOn = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSubTotalDesc = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDepositDesc = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Hotel_Reservation_Overhaul.dboDataSetTableAdapters.locationTableAdapter();
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter1 = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.locationTableAdapter();
            this.packageTableAdapter = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.packageTableAdapter();
            this.tableAdapterManager = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.TableAdapterManager();
            this.lblError = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnMakeRes = new System.Windows.Forms.Button();
            this.txtCostNightly = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(18, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 9;
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
            this.lblDescribe.TabIndex = 11;
            this.lblDescribe.Text = "Make a reservation.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1046, 18);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 38);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(225, 138);
            this.monthStart.Margin = new System.Windows.Forms.Padding(14);
            this.monthStart.MaxSelectionCount = 1;
            this.monthStart.Name = "monthStart";
            this.monthStart.ShowToday = false;
            this.monthStart.ShowTodayCircle = false;
            this.monthStart.TabIndex = 14;
            this.monthStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthStart_DateChanged);
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(765, 138);
            this.monthEnd.Margin = new System.Windows.Forms.Padding(14);
            this.monthEnd.MaxSelectionCount = 1;
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.ShowToday = false;
            this.monthEnd.ShowTodayCircle = false;
            this.monthEnd.TabIndex = 15;
            this.monthEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthend_dateChanged);
            // 
            // cboxHotel
            // 
            this.cboxHotel.DataSource = this.locationBindingSource2;
            this.cboxHotel.DisplayMember = "locationName";
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(245, 489);
            this.cboxHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(338, 28);
            this.cboxHotel.TabIndex = 3;
            this.cboxHotel.ValueMember = "locationID";
            // 
            // locationBindingSource2
            // 
            this.locationBindingSource2.DataMember = "location";
            this.locationBindingSource2.DataSource = this.hotelmgmt;
            // 
            // hotelmgmt
            // 
            this.hotelmgmt.DataSetName = "hotelmgmt";
            this.hotelmgmt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            this.locationBindingSource.DataSource = this.dboDataSet;
            // 
            // dboDataSet
            // 
            this.dboDataSet.DataSetName = "dboDataSet";
            this.dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxNumGuests
            // 
            this.cboxNumGuests.FormattingEnabled = true;
            this.cboxNumGuests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboxNumGuests.Location = new System.Drawing.Point(785, 489);
            this.cboxNumGuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxNumGuests.Name = "cboxNumGuests";
            this.cboxNumGuests.Size = new System.Drawing.Size(338, 28);
            this.cboxNumGuests.TabIndex = 16;
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(590, 489);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(188, 31);
            this.lblGuests.TabIndex = 17;
            this.lblGuests.Text = "Number of Guests:";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(35, 489);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(188, 31);
            this.lblHotel.TabIndex = 18;
            this.lblHotel.Text = "Hotel:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkPackages
            // 
            this.checkPackages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.packageBindingSource1, "packageName", true));
            this.checkPackages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "packageID", true));
            this.checkPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPackages.FormattingEnabled = true;
            this.checkPackages.Location = new System.Drawing.Point(245, 566);
            this.checkPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkPackages.Name = "checkPackages";
            this.checkPackages.Size = new System.Drawing.Size(338, 139);
            this.checkPackages.TabIndex = 5;
            // 
            // packageBindingSource1
            // 
            this.packageBindingSource1.DataMember = "package";
            this.packageBindingSource1.DataSource = this.hotelmgmt1;
            // 
            // hotelmgmt1
            // 
            this.hotelmgmt1.DataSetName = "hotelmgmt";
            this.hotelmgmt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataMember = "package";
            this.packageBindingSource.DataSource = this.hotelmgmt;
            // 
            // lblAddOn
            // 
            this.lblAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOn.Location = new System.Drawing.Point(35, 566);
            this.lblAddOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddOn.Name = "lblAddOn";
            this.lblAddOn.Size = new System.Drawing.Size(188, 31);
            this.lblAddOn.TabIndex = 0;
            this.lblAddOn.Text = "Packages:";
            this.lblAddOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(928, 544);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Continue";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(928, 656);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 46);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblSubTotalDesc
            // 
            this.lblSubTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalDesc.Location = new System.Drawing.Point(607, 667);
            this.lblSubTotalDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalDesc.Name = "lblSubTotalDesc";
            this.lblSubTotalDesc.Size = new System.Drawing.Size(148, 31);
            this.lblSubTotalDesc.TabIndex = 0;
            this.lblSubTotalDesc.Text = "Total:";
            this.lblSubTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(763, 667);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(150, 31);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(763, 620);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(150, 31);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepositDesc
            // 
            this.lblDepositDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositDesc.Location = new System.Drawing.Point(607, 620);
            this.lblDepositDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositDesc.Name = "lblDepositDesc";
            this.lblDepositDesc.Size = new System.Drawing.Size(148, 31);
            this.lblDepositDesc.TabIndex = 0;
            this.lblDepositDesc.Text = "Deposit:";
            this.lblDepositDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // dboDataSetBindingSource
            // 
            this.dboDataSetBindingSource.DataSource = this.dboDataSet;
            this.dboDataSetBindingSource.Position = 0;
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataMember = "location";
            this.locationBindingSource1.DataSource = this.hotelmgmt;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // packageTableAdapter
            // 
            this.packageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activitylogTableAdapter = null;
            this.tableAdapterManager.activitytypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingmethodTableAdapter = null;
            this.tableAdapterManager.locationTableAdapter = this.locationTableAdapter1;
            this.tableAdapterManager.maintenanceTableAdapter = null;
            this.tableAdapterManager.packageTableAdapter = this.packageTableAdapter;
            this.tableAdapterManager.paymentmethodTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.rewardofferTableAdapter = null;
            this.tableAdapterManager.roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.waitlistTableAdapter = null;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(225, 446);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(852, 31);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "Error: Start date later than end date or no start date selected";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(220, 402);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(317, 31);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(760, 402);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(317, 31);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakeRes
            // 
            this.btnMakeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeRes.Location = new System.Drawing.Point(928, 600);
            this.btnMakeRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMakeRes.Name = "btnMakeRes";
            this.btnMakeRes.Size = new System.Drawing.Size(195, 46);
            this.btnMakeRes.TabIndex = 25;
            this.btnMakeRes.Text = "Book Reservation";
            this.btnMakeRes.UseVisualStyleBackColor = true;
            this.btnMakeRes.Click += new System.EventHandler(this.btnMakeRes_Click);
            // 
            // txtCostNightly
            // 
            this.txtCostNightly.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostNightly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCostNightly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostNightly.Location = new System.Drawing.Point(763, 576);
            this.txtCostNightly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCostNightly.Name = "txtCostNightly";
            this.txtCostNightly.Size = new System.Drawing.Size(150, 31);
            this.txtCostNightly.TabIndex = 26;
            this.txtCostNightly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(607, 576);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(148, 31);
            this.lblCost.TabIndex = 27;
            this.lblCost.Text = "Cost Per Night:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 863);
            this.Controls.Add(this.txtCostNightly);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnMakeRes);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDepositDesc);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalDesc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAddOn);
            this.Controls.Add(this.checkPackages);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.cboxNumGuests);
            this.Controls.Add(this.cboxHotel);
            this.Controls.Add(this.monthEnd);
            this.Controls.Add(this.monthStart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reservation";
            this.Text = "Hotel Reservation: Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.MonthCalendar monthStart;
        private System.Windows.Forms.MonthCalendar monthEnd;
        private System.Windows.Forms.ComboBox cboxHotel;
        private System.Windows.Forms.ComboBox cboxNumGuests;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.CheckedListBox checkPackages;
        private System.Windows.Forms.Label lblAddOn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSubTotalDesc;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblDepositDesc;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private dboDataSetTableAdapters.locationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
        private hotelmgmt hotelmgmt;
        private System.Windows.Forms.BindingSource locationBindingSource1;
        private hotelmgmtTableAdapters.locationTableAdapter locationTableAdapter1;
        private System.Windows.Forms.BindingSource locationBindingSource2;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private hotelmgmtTableAdapters.packageTableAdapter packageTableAdapter;
        private hotelmgmtTableAdapters.TableAdapterManager tableAdapterManager;
        private hotelmgmt hotelmgmt1;
        private System.Windows.Forms.BindingSource packageBindingSource1;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnMakeRes;
        private System.Windows.Forms.Label txtCostNightly;
        private System.Windows.Forms.Label lblCost;
    }
}