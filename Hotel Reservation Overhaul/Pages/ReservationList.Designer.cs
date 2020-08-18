﻿namespace Hotel_Reservation_Overhaul
{
    partial class ReservationList
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
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCustDesc = new System.Windows.Forms.Label();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmgmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resListDataGrid = new System.Windows.Forms.DataGridView();
            this.ConfirmationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTableAdapter = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.reservationTableAdapter();
            this.locationTableAdapter = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.locationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 7;
            this.lblDescribe.Text = "Manage your reservations.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(600, 100);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Book New Reservation";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(600, 413);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 50);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify Reservation";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(600, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(600, 205);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 50);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay for Reservation";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCustDesc
            // 
            this.lblCustDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustDesc.Location = new System.Drawing.Point(50, 500);
            this.lblCustDesc.Name = "lblCustDesc";
            this.lblCustDesc.Size = new System.Drawing.Size(180, 20);
            this.lblCustDesc.TabIndex = 0;
            this.lblCustDesc.Text = "Seach Customer:";
            this.lblCustDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustDesc.Visible = false;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(250, 500);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerSearch.TabIndex = 5;
            this.txtCustomerSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 500);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(247, 530);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error:";
            this.lblError.Visible = false;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.hotelmgmtBindingSource;
            // 
            // hotelmgmtBindingSource
            // 
            this.hotelmgmtBindingSource.DataSource = this.hotelmgmt;
            this.hotelmgmtBindingSource.Position = 0;
            // 
            // hotelmgmt
            // 
            this.hotelmgmt.DataSetName = "hotelmgmt";
            this.hotelmgmt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataMember = "reservation";
            this.reservationBindingSource1.DataSource = this.hotelmgmtBindingSource;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            this.locationBindingSource.DataSource = this.hotelmgmtBindingSource;
            // 
            // resListDataGrid
            // 
            this.resListDataGrid.AllowUserToAddRows = false;
            this.resListDataGrid.AllowUserToDeleteRows = false;
            this.resListDataGrid.AutoGenerateColumns = false;
            this.resListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConfirmationID,
            this.StartDate,
            this.EndDate,
            this.Location});
            this.resListDataGrid.DataSource = this.hotelmgmt;
            this.resListDataGrid.Location = new System.Drawing.Point(50, 100);
            this.resListDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resListDataGrid.MultiSelect = false;
            this.resListDataGrid.Name = "resListDataGrid";
            this.resListDataGrid.ReadOnly = true;
            this.resListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resListDataGrid.RowTemplate.Height = 28;
            this.resListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resListDataGrid.Size = new System.Drawing.Size(529, 363);
            this.resListDataGrid.TabIndex = 10;
            // 
            // ConfirmationID
            // 
            this.ConfirmationID.DataPropertyName = "confirmationID";
            this.ConfirmationID.HeaderText = "Confirmation ID";
            this.ConfirmationID.MinimumWidth = 8;
            this.ConfirmationID.Name = "ConfirmationID";
            this.ConfirmationID.ReadOnly = true;
            this.ConfirmationID.Width = 150;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "startDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 150;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "endDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 150;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "locationName";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 8;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 150;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.resListDataGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.lblCustDesc);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "ReservationList";
            this.Text = "Hotel Reservation: Reservation List";
            this.Load += new System.EventHandler(this.ReservationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCustDesc;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView resListDataGrid;
        private System.Windows.Forms.Label lblError;
        private hotelmgmt hotelmgmt;
        private System.Windows.Forms.BindingSource hotelmgmtBindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private hotelmgmtTableAdapters.reservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private hotelmgmtTableAdapters.locationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}