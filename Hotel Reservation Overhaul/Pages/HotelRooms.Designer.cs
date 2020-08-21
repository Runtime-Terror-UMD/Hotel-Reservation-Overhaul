namespace Hotel_Reservation_Overhaul.Pages
{
    partial class HotelRooms
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
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.hotelmgmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Hotel_Reservation_Overhaul.hotelmgmtTableAdapters.locationTableAdapter();
            this.hotelDataGrid = new System.Windows.Forms.DataGridView();
            this.packageDataGrid = new System.Windows.Forms.DataGridView();
            this.ammenitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblPackages = new System.Windows.Forms.Label();
            this.lblAmmenities = new System.Windows.Forms.Label();
            this.roomDataGrid = new System.Windows.Forms.DataGridView();
            this.lblRooms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammenitiesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGrid)).BeginInit();
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
            this.lblDescribe.Text = "View Hotels and Rooms";
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // hotelmgmt
            // 
            this.hotelmgmt.DataSetName = "hotelmgmt";
            this.hotelmgmt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelmgmtBindingSource
            // 
            this.hotelmgmtBindingSource.DataSource = this.hotelmgmt;
            this.hotelmgmtBindingSource.Position = 0;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            this.locationBindingSource.DataSource = this.hotelmgmtBindingSource;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // hotelDataGrid
            // 
            this.hotelDataGrid.AllowUserToAddRows = false;
            this.hotelDataGrid.AllowUserToDeleteRows = false;
            this.hotelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelDataGrid.Location = new System.Drawing.Point(50, 100);
            this.hotelDataGrid.Name = "hotelDataGrid";
            this.hotelDataGrid.ReadOnly = true;
            this.hotelDataGrid.Size = new System.Drawing.Size(376, 221);
            this.hotelDataGrid.TabIndex = 2;
            this.hotelDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelDataGrid_CellContentClick);
            // 
            // packageDataGrid
            // 
            this.packageDataGrid.AllowUserToAddRows = false;
            this.packageDataGrid.AllowUserToDeleteRows = false;
            this.packageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageDataGrid.Location = new System.Drawing.Point(500, 100);
            this.packageDataGrid.Name = "packageDataGrid";
            this.packageDataGrid.ReadOnly = true;
            this.packageDataGrid.Size = new System.Drawing.Size(250, 221);
            this.packageDataGrid.TabIndex = 19;
            this.packageDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packageDataGrid_CellContentClick);
            // 
            // ammenitiesDataGrid
            // 
            this.ammenitiesDataGrid.AllowUserToAddRows = false;
            this.ammenitiesDataGrid.AllowUserToDeleteRows = false;
            this.ammenitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ammenitiesDataGrid.Location = new System.Drawing.Point(500, 350);
            this.ammenitiesDataGrid.Name = "ammenitiesDataGrid";
            this.ammenitiesDataGrid.ReadOnly = true;
            this.ammenitiesDataGrid.Size = new System.Drawing.Size(250, 173);
            this.ammenitiesDataGrid.TabIndex = 20;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(47, 77);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(100, 20);
            this.lblHotel.TabIndex = 21;
            this.lblHotel.Text = "Hotels";
            // 
            // lblPackages
            // 
            this.lblPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackages.Location = new System.Drawing.Point(500, 77);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(100, 20);
            this.lblPackages.TabIndex = 22;
            this.lblPackages.Text = "Packages";
            // 
            // lblAmmenities
            // 
            this.lblAmmenities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmenities.Location = new System.Drawing.Point(500, 327);
            this.lblAmmenities.Name = "lblAmmenities";
            this.lblAmmenities.Size = new System.Drawing.Size(100, 20);
            this.lblAmmenities.TabIndex = 23;
            this.lblAmmenities.Text = "Ammenities";
            // 
            // roomDataGrid
            // 
            this.roomDataGrid.AllowUserToAddRows = false;
            this.roomDataGrid.AllowUserToDeleteRows = false;
            this.roomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGrid.Location = new System.Drawing.Point(50, 350);
            this.roomDataGrid.Name = "roomDataGrid";
            this.roomDataGrid.ReadOnly = true;
            this.roomDataGrid.Size = new System.Drawing.Size(376, 180);
            this.roomDataGrid.TabIndex = 24;
            // 
            // lblRooms
            // 
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(50, 324);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(100, 20);
            this.lblRooms.TabIndex = 25;
            this.lblRooms.Text = "Rooms";
            // 
            // HotelRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.roomDataGrid);
            this.Controls.Add(this.lblAmmenities);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.ammenitiesDataGrid);
            this.Controls.Add(this.packageDataGrid);
            this.Controls.Add(this.hotelDataGrid);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "HotelRooms";
            this.Text = "Hotel Reservation: Hotel Rooms";
            this.Load += new System.EventHandler(this.HotelRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammenitiesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private hotelmgmt hotelmgmt;
        private System.Windows.Forms.BindingSource hotelmgmtBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private hotelmgmtTableAdapters.locationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridView hotelDataGrid;
        private System.Windows.Forms.DataGridView packageDataGrid;
        private System.Windows.Forms.DataGridView ammenitiesDataGrid;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.Label lblAmmenities;
        private System.Windows.Forms.DataGridView roomDataGrid;
        private System.Windows.Forms.Label lblRooms;
    }
}