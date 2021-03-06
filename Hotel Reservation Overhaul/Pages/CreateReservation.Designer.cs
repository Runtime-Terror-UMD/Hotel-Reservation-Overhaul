﻿namespace Hotel_Reservation_Overhaul
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
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.locationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblNumRooms = new System.Windows.Forms.Label();
            this.cboxNumRooms = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.checkFreeUpgrade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 9;
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
            this.lblDescribe.TabIndex = 11;
            this.lblDescribe.Text = "Make a reservation.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(150, 90);
            this.monthStart.MaxSelectionCount = 1;
            this.monthStart.Name = "monthStart";
            this.monthStart.ShowToday = false;
            this.monthStart.ShowTodayCircle = false;
            this.monthStart.TabIndex = 14;
            this.monthStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthStart_DateChanged);
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(510, 90);
            this.monthEnd.MaxSelectionCount = 1;
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.ShowToday = false;
            this.monthEnd.ShowTodayCircle = false;
            this.monthEnd.TabIndex = 15;
            this.monthEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthend_dateChanged);
            // 
            // cboxHotel
            // 
            this.cboxHotel.DataSource = this.hotelmgmt;
            this.cboxHotel.DisplayMember = "location.locationName";
            this.cboxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(163, 318);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(227, 21);
            this.cboxHotel.TabIndex = 3;
            this.cboxHotel.ValueMember = "locationID";
            // 
            // hotelmgmt
            // 
            this.hotelmgmt.DataSetName = "hotelmgmt";
            this.hotelmgmt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource2
            // 
            this.locationBindingSource2.DataMember = "location";
            this.locationBindingSource2.DataSource = this.hotelmgmt;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            // 
            // cboxNumGuests
            // 
            this.cboxNumGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNumGuests.FormattingEnabled = true;
            this.cboxNumGuests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboxNumGuests.Location = new System.Drawing.Point(523, 318);
            this.cboxNumGuests.Name = "cboxNumGuests";
            this.cboxNumGuests.Size = new System.Drawing.Size(227, 21);
            this.cboxNumGuests.TabIndex = 16;
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(393, 318);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(125, 20);
            this.lblGuests.TabIndex = 17;
            this.lblGuests.Text = "Number of Guests:";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(23, 318);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(125, 20);
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
            this.checkPackages.Location = new System.Drawing.Point(163, 374);
            this.checkPackages.Name = "checkPackages";
            this.checkPackages.Size = new System.Drawing.Size(227, 89);
            this.checkPackages.TabIndex = 5;
            this.checkPackages.SelectedIndexChanged += new System.EventHandler(this.checkPackages_SelectedIndexChanged);
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
            this.lblAddOn.Location = new System.Drawing.Point(23, 374);
            this.lblAddOn.Name = "lblAddOn";
            this.lblAddOn.Size = new System.Drawing.Size(125, 20);
            this.lblAddOn.TabIndex = 0;
            this.lblAddOn.Text = "Packages:";
            this.lblAddOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(620, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Continue";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(619, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSubTotalDesc
            // 
            this.lblSubTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalDesc.Location = new System.Drawing.Point(405, 406);
            this.lblSubTotalDesc.Name = "lblSubTotalDesc";
            this.lblSubTotalDesc.Size = new System.Drawing.Size(99, 20);
            this.lblSubTotalDesc.TabIndex = 0;
            this.lblSubTotalDesc.Text = "Total:";
            this.lblSubTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(510, 404);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 22);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableAdapterManager.amenityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.locationTableAdapter = this.locationTableAdapter1;
            this.tableAdapterManager.maintenanceTableAdapter = null;
            this.tableAdapterManager.packageTableAdapter = this.packageTableAdapter;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.relation_package_amenityTableAdapter = null;
            this.tableAdapterManager.relation_room_packageTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.reward_logTableAdapter = null;
            this.tableAdapterManager.roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.waitlistTableAdapter = null;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(150, 295);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(568, 20);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(147, 261);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(211, 20);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(507, 261);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(211, 20);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakeRes
            // 
            this.btnMakeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeRes.Location = new System.Drawing.Point(619, 396);
            this.btnMakeRes.Name = "btnMakeRes";
            this.btnMakeRes.Size = new System.Drawing.Size(130, 30);
            this.btnMakeRes.TabIndex = 25;
            this.btnMakeRes.Text = "Book Reservation";
            this.btnMakeRes.UseVisualStyleBackColor = true;
            this.btnMakeRes.Visible = false;
            this.btnMakeRes.Click += new System.EventHandler(this.btnMakeRes_Click);
            // 
            // txtCostNightly
            // 
            this.txtCostNightly.BackColor = System.Drawing.SystemColors.Window;
            this.txtCostNightly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCostNightly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostNightly.Location = new System.Drawing.Point(510, 368);
            this.txtCostNightly.Name = "txtCostNightly";
            this.txtCostNightly.Size = new System.Drawing.Size(100, 22);
            this.txtCostNightly.TabIndex = 26;
            this.txtCostNightly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(405, 369);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(99, 20);
            this.lblCost.TabIndex = 27;
            this.lblCost.Text = "Cost Per Night:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRooms.Location = new System.Drawing.Point(23, 338);
            this.lblNumRooms.Name = "lblNumRooms";
            this.lblNumRooms.Size = new System.Drawing.Size(125, 20);
            this.lblNumRooms.TabIndex = 28;
            this.lblNumRooms.Text = "Number of rooms:";
            this.lblNumRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxNumRooms
            // 
            this.cboxNumRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNumRooms.FormattingEnabled = true;
            this.cboxNumRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboxNumRooms.Location = new System.Drawing.Point(163, 343);
            this.cboxNumRooms.Name = "cboxNumRooms";
            this.cboxNumRooms.Size = new System.Drawing.Size(227, 21);
            this.cboxNumRooms.TabIndex = 29;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(619, 396);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 30);
            this.btnModify.TabIndex = 30;
            this.btnModify.Text = "Modify Reservation";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // checkFreeUpgrade
            // 
            this.checkFreeUpgrade.AutoSize = true;
            this.checkFreeUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkFreeUpgrade.Location = new System.Drawing.Point(163, 469);
            this.checkFreeUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.checkFreeUpgrade.Name = "checkFreeUpgrade";
            this.checkFreeUpgrade.Size = new System.Drawing.Size(174, 20);
            this.checkFreeUpgrade.TabIndex = 31;
            this.checkFreeUpgrade.Text = "Complimentary Upgrade";
            this.checkFreeUpgrade.UseVisualStyleBackColor = true;
            this.checkFreeUpgrade.Visible = false;
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 515);
            this.Controls.Add(this.checkFreeUpgrade);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cboxNumRooms);
            this.Controls.Add(this.lblNumRooms);
            this.Controls.Add(this.txtCostNightly);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnMakeRes);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblError);
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
            this.Name = "CreateReservation";
            this.Text = "Hotel Reservation: Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingSource locationBindingSource;
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
        private System.Windows.Forms.Label lblNumRooms;
        private System.Windows.Forms.ComboBox cboxNumRooms;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.CheckBox checkFreeUpgrade;
    }
}