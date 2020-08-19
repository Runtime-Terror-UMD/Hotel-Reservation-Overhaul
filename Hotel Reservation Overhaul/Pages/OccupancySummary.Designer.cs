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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.txtOccupied = new System.Windows.Forms.Label();
            this.lblUnOccupied = new System.Windows.Forms.Label();
            this.txtUnoccupied = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStart.Location = new System.Drawing.Point(32, 28);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(78, 17);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "From Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEnd.Location = new System.Drawing.Point(32, 68);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 17);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(132, 28);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(150, 20);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToDate
            // 
            this.lblToDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(132, 68);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(150, 20);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOccupied.Location = new System.Drawing.Point(96, 143);
            this.lblOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(152, 17);
            this.lblOccupied.TabIndex = 5;
            this.lblOccupied.Text = "% of Occupied Rooms:";
            // 
            // txtOccupied
            // 
            this.txtOccupied.BackColor = System.Drawing.SystemColors.Window;
            this.txtOccupied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupied.Location = new System.Drawing.Point(260, 143);
            this.txtOccupied.Name = "txtOccupied";
            this.txtOccupied.Size = new System.Drawing.Size(150, 20);
            this.txtOccupied.TabIndex = 6;
            this.txtOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnOccupied
            // 
            this.lblUnOccupied.AutoSize = true;
            this.lblUnOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnOccupied.Location = new System.Drawing.Point(78, 179);
            this.lblUnOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnOccupied.Name = "lblUnOccupied";
            this.lblUnOccupied.Size = new System.Drawing.Size(170, 17);
            this.lblUnOccupied.TabIndex = 7;
            this.lblUnOccupied.Text = "% of UnOccupied Rooms:";
            // 
            // txtUnoccupied
            // 
            this.txtUnoccupied.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnoccupied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnoccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnoccupied.Location = new System.Drawing.Point(260, 179);
            this.txtUnoccupied.Name = "txtUnoccupied";
            this.txtUnoccupied.Size = new System.Drawing.Size(150, 20);
            this.txtUnoccupied.TabIndex = 8;
            this.txtUnoccupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "% of Rooms Under Maintenance:";
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenance.Location = new System.Drawing.Point(260, 218);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(150, 20);
            this.txtMaintenance.TabIndex = 10;
            this.txtMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(143, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Revenue:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.SystemColors.Window;
            this.txtRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.Location = new System.Drawing.Point(260, 253);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(150, 20);
            this.txtRevenue.TabIndex = 12;
            this.txtRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OccupancySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaintenance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnoccupied);
            this.Controls.Add(this.lblUnOccupied);
            this.Controls.Add(this.txtOccupied);
            this.Controls.Add(this.lblOccupied);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Name = "OccupancySummary";
            this.Text = "Hotel Reservation: Occupancy Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.Label txtOccupied;
        private System.Windows.Forms.Label lblUnOccupied;
        private System.Windows.Forms.Label txtUnoccupied;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMaintenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtRevenue;
    }
}