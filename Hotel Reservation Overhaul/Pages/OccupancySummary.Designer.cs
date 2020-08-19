namespace Hotel_Reservation_Overhaul.Pages
{
    partial class OccupancySummary
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnUnOccupied = new System.Windows.Forms.Button();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lBoxReportData = new System.Windows.Forms.ListBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(24, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 31);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(622, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRevenue);
            this.groupBox1.Controls.Add(this.btnMaintenance);
            this.groupBox1.Controls.Add(this.btnOccupied);
            this.groupBox1.Controls.Add(this.btnUnOccupied);
            this.groupBox1.Location = new System.Drawing.Point(46, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 263);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Occupancy Summary";
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(49, 140);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(155, 31);
            this.btnMaintenance.TabIndex = 5;
            this.btnMaintenance.Text = "Rooms Under Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnUnOccupied
            // 
            this.btnUnOccupied.Location = new System.Drawing.Point(49, 91);
            this.btnUnOccupied.Name = "btnUnOccupied";
            this.btnUnOccupied.Size = new System.Drawing.Size(155, 31);
            this.btnUnOccupied.TabIndex = 4;
            this.btnUnOccupied.Text = "Unoccupied Rooms";
            this.btnUnOccupied.UseVisualStyleBackColor = true;
            this.btnUnOccupied.Click += new System.EventHandler(this.btnUnOccupied_Click);
            // 
            // btnOccupied
            // 
            this.btnOccupied.Location = new System.Drawing.Point(49, 43);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(155, 31);
            this.btnOccupied.TabIndex = 3;
            this.btnOccupied.Text = "Occupied Rooms";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(49, 189);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(155, 31);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Total Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(163, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHotel);
            this.groupBox2.Controls.Add(this.lblHotel);
            this.groupBox2.Controls.Add(this.lBoxReportData);
            this.groupBox2.Controls.Add(this.dateEnd);
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.lblStart);
            this.groupBox2.Location = new System.Drawing.Point(334, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 263);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Information";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStart.Location = new System.Drawing.Point(22, 33);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(76, 17);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date:";
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(114, 33);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEnd.Location = new System.Drawing.Point(22, 73);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 17);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "End Date:";
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(114, 75);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 9;
            // 
            // lBoxReportData
            // 
            this.lBoxReportData.FormattingEnabled = true;
            this.lBoxReportData.Location = new System.Drawing.Point(25, 147);
            this.lBoxReportData.Name = "lBoxReportData";
            this.lBoxReportData.Size = new System.Drawing.Size(289, 95);
            this.lBoxReportData.TabIndex = 29;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHotel.Location = new System.Drawing.Point(22, 113);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(45, 17);
            this.lblHotel.TabIndex = 30;
            this.lblHotel.Text = "Hotel:";
            // 
            // txtHotel
            // 
            this.txtHotel.Enabled = false;
            this.txtHotel.Location = new System.Drawing.Point(114, 114);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(200, 20);
            this.txtHotel.TabIndex = 31;
            // 
            // OccupancySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Name = "OccupancySummary";
            this.Text = "Hotel Reservation: Occupancy Summary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Button btnUnOccupied;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ListBox lBoxReportData;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label lblHotel;
    }
}