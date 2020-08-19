namespace Hotel_Reservation_Overhaul.Pages
{
    partial class CustomerSummary
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnUpgrades = new System.Windows.Forms.Button();
            this.btnRepeatCx = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBoxReportData = new System.Windows.Forms.ListBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(28, 23);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 31);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(619, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnReserve);
            this.groupBox1.Controls.Add(this.btnUpgrades);
            this.groupBox1.Controls.Add(this.btnRepeatCx);
            this.groupBox1.Location = new System.Drawing.Point(48, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 263);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Summary";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(49, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancellations";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(49, 164);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(155, 25);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modifications";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(49, 123);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(155, 25);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reservations";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnUpgrades
            // 
            this.btnUpgrades.Location = new System.Drawing.Point(49, 83);
            this.btnUpgrades.Name = "btnUpgrades";
            this.btnUpgrades.Size = new System.Drawing.Size(155, 25);
            this.btnUpgrades.TabIndex = 4;
            this.btnUpgrades.Text = "Upgrades";
            this.btnUpgrades.UseVisualStyleBackColor = true;
            this.btnUpgrades.Click += new System.EventHandler(this.btnUpgrades_Click);
            // 
            // btnRepeatCx
            // 
            this.btnRepeatCx.Location = new System.Drawing.Point(49, 43);
            this.btnRepeatCx.Name = "btnRepeatCx";
            this.btnRepeatCx.Size = new System.Drawing.Size(155, 25);
            this.btnRepeatCx.TabIndex = 3;
            this.btnRepeatCx.Text = "Repeat Customers";
            this.btnRepeatCx.UseVisualStyleBackColor = true;
            this.btnRepeatCx.Click += new System.EventHandler(this.btnRepeatCx_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBoxReportData);
            this.groupBox2.Controls.Add(this.dateEnd);
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.lblStart);
            this.groupBox2.Location = new System.Drawing.Point(340, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 263);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Information";
            // 
            // lBoxReportData
            // 
            this.lBoxReportData.FormattingEnabled = true;
            this.lBoxReportData.Location = new System.Drawing.Point(25, 137);
            this.lBoxReportData.Name = "lBoxReportData";
            this.lBoxReportData.Size = new System.Drawing.Size(289, 95);
            this.lBoxReportData.TabIndex = 29;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(114, 91);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 9;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEnd.Location = new System.Drawing.Point(22, 93);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 17);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "End Date:";
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(114, 43);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 7;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStart.Location = new System.Drawing.Point(22, 43);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(76, 17);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date:";
            // 
            // CustomerSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Name = "CustomerSummary";
            this.Text = "Hotel Reservation: Customer Summary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnUpgrades;
        private System.Windows.Forms.Button btnRepeatCx;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lBoxReportData;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblStart;
    }
}