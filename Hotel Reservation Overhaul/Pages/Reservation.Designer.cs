namespace Hotel_Reservation_Overhaul
{
    partial class Reservation
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.monthStart = new System.Windows.Forms.MonthCalendar();
            this.monthEnd = new System.Windows.Forms.MonthCalendar();
            this.cboxHotel = new System.Windows.Forms.ComboBox();
            this.cboxRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.checkAddOn = new System.Windows.Forms.CheckedListBox();
            this.lblAddOn = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWaitlist = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.lblRoomDesc = new System.Windows.Forms.Label();
            this.lblSubTotalDesc = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxDesc = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceDesc = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDepositDesc = new System.Windows.Forms.Label();
            this.dboDataSet = new Hotel_Reservation_Overhaul.dboDataSet();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Hotel_Reservation_Overhaul.dboDataSetTableAdapters.locationTableAdapter();
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
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
            this.lblDescribe.Text = "Make your reservation.";
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
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(15, 154);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(188, 31);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(570, 154);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(188, 31);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "End Date:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(225, 138);
            this.monthStart.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.monthStart.Name = "monthStart";
            this.monthStart.TabIndex = 14;
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(765, 138);
            this.monthEnd.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.TabIndex = 15;
            // 
            // cboxHotel
            // 
            this.cboxHotel.DataSource = this.locationBindingSource;
            this.cboxHotel.DisplayMember = "locationName";
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(225, 431);
            this.cboxHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(338, 28);
            this.cboxHotel.TabIndex = 3;
            this.cboxHotel.ValueMember = "locationName";
            // 
            // cboxRoomType
            // 
            this.cboxRoomType.FormattingEnabled = true;
            this.cboxRoomType.Location = new System.Drawing.Point(765, 431);
            this.cboxRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxRoomType.Name = "cboxRoomType";
            this.cboxRoomType.Size = new System.Drawing.Size(338, 28);
            this.cboxRoomType.TabIndex = 16;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(570, 431);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(188, 31);
            this.lblRoomType.TabIndex = 17;
            this.lblRoomType.Text = "Room Type:";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(15, 431);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(188, 31);
            this.lblHotel.TabIndex = 18;
            this.lblHotel.Text = "Hotel:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkAddOn
            // 
            this.checkAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAddOn.FormattingEnabled = true;
            this.checkAddOn.Location = new System.Drawing.Point(225, 508);
            this.checkAddOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkAddOn.Name = "checkAddOn";
            this.checkAddOn.Size = new System.Drawing.Size(338, 112);
            this.checkAddOn.TabIndex = 5;
            // 
            // lblAddOn
            // 
            this.lblAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOn.Location = new System.Drawing.Point(15, 508);
            this.lblAddOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddOn.Name = "lblAddOn";
            this.lblAddOn.Size = new System.Drawing.Size(188, 31);
            this.lblAddOn.TabIndex = 0;
            this.lblAddOn.Text = "Add-ons:";
            this.lblAddOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(930, 723);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Book Reservation";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblWaitlist
            // 
            this.lblWaitlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitlist.ForeColor = System.Drawing.Color.Red;
            this.lblWaitlist.Location = new System.Drawing.Point(150, 723);
            this.lblWaitlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaitlist.Name = "lblWaitlist";
            this.lblWaitlist.Size = new System.Drawing.Size(375, 108);
            this.lblWaitlist.TabIndex = 0;
            this.lblWaitlist.Text = "Note:";
            this.lblWaitlist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWaitlist.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(930, 792);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRoomDetails
            // 
            this.lblRoomDetails.BackColor = System.Drawing.SystemColors.Window;
            this.lblRoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoomDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetails.Location = new System.Drawing.Point(765, 508);
            this.lblRoomDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new System.Drawing.Size(340, 144);
            this.lblRoomDetails.TabIndex = 0;
            // 
            // lblRoomDesc
            // 
            this.lblRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDesc.Location = new System.Drawing.Point(570, 508);
            this.lblRoomDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomDesc.Name = "lblRoomDesc";
            this.lblRoomDesc.Size = new System.Drawing.Size(188, 31);
            this.lblRoomDesc.TabIndex = 21;
            this.lblRoomDesc.Text = "Room Description:";
            this.lblRoomDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalDesc
            // 
            this.lblSubTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalDesc.Location = new System.Drawing.Point(609, 731);
            this.lblSubTotalDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalDesc.Name = "lblSubTotalDesc";
            this.lblSubTotalDesc.Size = new System.Drawing.Size(148, 31);
            this.lblSubTotalDesc.TabIndex = 0;
            this.lblSubTotalDesc.Text = "Subtotal:";
            this.lblSubTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(765, 731);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(150, 31);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.Window;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(765, 769);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(150, 31);
            this.lblTax.TabIndex = 0;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaxDesc
            // 
            this.lblTaxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxDesc.Location = new System.Drawing.Point(609, 769);
            this.lblTaxDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxDesc.Name = "lblTaxDesc";
            this.lblTaxDesc.Size = new System.Drawing.Size(148, 31);
            this.lblTaxDesc.TabIndex = 0;
            this.lblTaxDesc.Text = "Tax:";
            this.lblTaxDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.Window;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(765, 808);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(150, 31);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalanceDesc
            // 
            this.lblBalanceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDesc.Location = new System.Drawing.Point(609, 808);
            this.lblBalanceDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceDesc.Name = "lblBalanceDesc";
            this.lblBalanceDesc.Size = new System.Drawing.Size(148, 31);
            this.lblBalanceDesc.TabIndex = 0;
            this.lblBalanceDesc.Text = "Balance:";
            this.lblBalanceDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(765, 692);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(150, 31);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepositDesc
            // 
            this.lblDepositDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositDesc.Location = new System.Drawing.Point(609, 692);
            this.lblDepositDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositDesc.Name = "lblDepositDesc";
            this.lblDepositDesc.Size = new System.Drawing.Size(148, 31);
            this.lblDepositDesc.TabIndex = 0;
            this.lblDepositDesc.Text = "Deposit:";
            this.lblDepositDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dboDataSet
            // 
            this.dboDataSet.DataSetName = "dboDataSet";
            this.dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "location";
            this.locationBindingSource.DataSource = this.dboDataSet;
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
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceDesc);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDepositDesc);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTaxDesc);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalDesc);
            this.Controls.Add(this.lblRoomDesc);
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWaitlist);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAddOn);
            this.Controls.Add(this.checkAddOn);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.cboxRoomType);
            this.Controls.Add(this.cboxHotel);
            this.Controls.Add(this.monthEnd);
            this.Controls.Add(this.monthStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reservation";
            this.Text = "Hotel Reservation: Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MonthCalendar monthStart;
        private System.Windows.Forms.MonthCalendar monthEnd;
        private System.Windows.Forms.ComboBox cboxHotel;
        private System.Windows.Forms.ComboBox cboxRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.CheckedListBox checkAddOn;
        private System.Windows.Forms.Label lblAddOn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWaitlist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRoomDetails;
        private System.Windows.Forms.Label lblRoomDesc;
        private System.Windows.Forms.Label lblSubTotalDesc;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxDesc;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceDesc;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblDepositDesc;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private dboDataSetTableAdapters.locationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
    }
}