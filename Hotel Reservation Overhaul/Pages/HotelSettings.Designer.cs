namespace Hotel_Reservation_Overhaul.Pages
{
    partial class HotelSettings
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
            this.lblMinimumCharge = new System.Windows.Forms.Label();
            this.btnMinCharge = new System.Windows.Forms.Button();
            this.txtMinimumCharge = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpHotelSettings = new System.Windows.Forms.GroupBox();
            this.txtNotifyCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNotifyDays = new System.Windows.Forms.Button();
            this.txtPointsPerDay = new System.Windows.Forms.TextBox();
            this.lblPointsPerDay = new System.Windows.Forms.Label();
            this.btnPointsPerDay = new System.Windows.Forms.Button();
            this.txtCancelationWindow = new System.Windows.Forms.TextBox();
            this.lblCancelationWindow = new System.Windows.Forms.Label();
            this.btnCancelationWindow = new System.Windows.Forms.Button();
            this.txtCancelationFee = new System.Windows.Forms.TextBox();
            this.lblCancelationFee = new System.Windows.Forms.Label();
            this.btnCancelationFee = new System.Windows.Forms.Button();
            this.grpRewards = new System.Windows.Forms.GroupBox();
            this.txtCustomerRewards = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustomerRewards = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnCustomerID = new System.Windows.Forms.Button();
            this.grpHotelSettings.SuspendLayout();
            this.grpRewards.SuspendLayout();
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
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 21;
            this.lblDescribe.Text = "Edit your account.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMinimumCharge
            // 
            this.lblMinimumCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumCharge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinimumCharge.Location = new System.Drawing.Point(45, 30);
            this.lblMinimumCharge.Name = "lblMinimumCharge";
            this.lblMinimumCharge.Size = new System.Drawing.Size(210, 20);
            this.lblMinimumCharge.TabIndex = 23;
            this.lblMinimumCharge.Text = "Minimum Charge:";
            this.lblMinimumCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMinCharge
            // 
            this.btnMinCharge.Location = new System.Drawing.Point(385, 27);
            this.btnMinCharge.Name = "btnMinCharge";
            this.btnMinCharge.Size = new System.Drawing.Size(150, 25);
            this.btnMinCharge.TabIndex = 24;
            this.btnMinCharge.Text = "Set Minimum Charge";
            this.btnMinCharge.UseVisualStyleBackColor = true;
            // 
            // txtMinimumCharge
            // 
            this.txtMinimumCharge.Location = new System.Drawing.Point(265, 30);
            this.txtMinimumCharge.Name = "txtMinimumCharge";
            this.txtMinimumCharge.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumCharge.TabIndex = 25;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 26;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // grpHotelSettings
            // 
            this.grpHotelSettings.Controls.Add(this.txtNotifyCustomer);
            this.grpHotelSettings.Controls.Add(this.label2);
            this.grpHotelSettings.Controls.Add(this.btnNotifyDays);
            this.grpHotelSettings.Controls.Add(this.txtPointsPerDay);
            this.grpHotelSettings.Controls.Add(this.lblPointsPerDay);
            this.grpHotelSettings.Controls.Add(this.btnPointsPerDay);
            this.grpHotelSettings.Controls.Add(this.txtCancelationWindow);
            this.grpHotelSettings.Controls.Add(this.lblCancelationWindow);
            this.grpHotelSettings.Controls.Add(this.btnCancelationWindow);
            this.grpHotelSettings.Controls.Add(this.txtCancelationFee);
            this.grpHotelSettings.Controls.Add(this.lblCancelationFee);
            this.grpHotelSettings.Controls.Add(this.btnCancelationFee);
            this.grpHotelSettings.Controls.Add(this.txtMinimumCharge);
            this.grpHotelSettings.Controls.Add(this.lblMinimumCharge);
            this.grpHotelSettings.Controls.Add(this.btnMinCharge);
            this.grpHotelSettings.Location = new System.Drawing.Point(100, 100);
            this.grpHotelSettings.Name = "grpHotelSettings";
            this.grpHotelSettings.Size = new System.Drawing.Size(600, 239);
            this.grpHotelSettings.TabIndex = 27;
            this.grpHotelSettings.TabStop = false;
            this.grpHotelSettings.Text = "Hotel Settings";
            // 
            // txtNotifyCustomer
            // 
            this.txtNotifyCustomer.Location = new System.Drawing.Point(265, 190);
            this.txtNotifyCustomer.Name = "txtNotifyCustomer";
            this.txtNotifyCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtNotifyCustomer.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Notify Customer (days):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNotifyDays
            // 
            this.btnNotifyDays.Location = new System.Drawing.Point(385, 187);
            this.btnNotifyDays.Name = "btnNotifyDays";
            this.btnNotifyDays.Size = new System.Drawing.Size(150, 25);
            this.btnNotifyDays.TabIndex = 36;
            this.btnNotifyDays.Text = "Set Notification Window";
            this.btnNotifyDays.UseVisualStyleBackColor = true;
            // 
            // txtPointsPerDay
            // 
            this.txtPointsPerDay.Location = new System.Drawing.Point(265, 150);
            this.txtPointsPerDay.Name = "txtPointsPerDay";
            this.txtPointsPerDay.Size = new System.Drawing.Size(100, 20);
            this.txtPointsPerDay.TabIndex = 34;
            // 
            // lblPointsPerDay
            // 
            this.lblPointsPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPerDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPointsPerDay.Location = new System.Drawing.Point(45, 150);
            this.lblPointsPerDay.Name = "lblPointsPerDay";
            this.lblPointsPerDay.Size = new System.Drawing.Size(210, 20);
            this.lblPointsPerDay.TabIndex = 32;
            this.lblPointsPerDay.Text = "Points Per Day:";
            this.lblPointsPerDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPointsPerDay
            // 
            this.btnPointsPerDay.Location = new System.Drawing.Point(385, 147);
            this.btnPointsPerDay.Name = "btnPointsPerDay";
            this.btnPointsPerDay.Size = new System.Drawing.Size(150, 25);
            this.btnPointsPerDay.TabIndex = 33;
            this.btnPointsPerDay.Text = "Set Points Per Day";
            this.btnPointsPerDay.UseVisualStyleBackColor = true;
            // 
            // txtCancelationWindow
            // 
            this.txtCancelationWindow.Location = new System.Drawing.Point(265, 110);
            this.txtCancelationWindow.Name = "txtCancelationWindow";
            this.txtCancelationWindow.Size = new System.Drawing.Size(100, 20);
            this.txtCancelationWindow.TabIndex = 31;
            // 
            // lblCancelationWindow
            // 
            this.lblCancelationWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelationWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCancelationWindow.Location = new System.Drawing.Point(45, 110);
            this.lblCancelationWindow.Name = "lblCancelationWindow";
            this.lblCancelationWindow.Size = new System.Drawing.Size(210, 20);
            this.lblCancelationWindow.TabIndex = 29;
            this.lblCancelationWindow.Text = "Cancelation Window (days):";
            this.lblCancelationWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelationWindow
            // 
            this.btnCancelationWindow.Location = new System.Drawing.Point(385, 107);
            this.btnCancelationWindow.Name = "btnCancelationWindow";
            this.btnCancelationWindow.Size = new System.Drawing.Size(150, 25);
            this.btnCancelationWindow.TabIndex = 30;
            this.btnCancelationWindow.Text = "Set Cancelation Window";
            this.btnCancelationWindow.UseVisualStyleBackColor = true;
            // 
            // txtCancelationFee
            // 
            this.txtCancelationFee.Location = new System.Drawing.Point(265, 70);
            this.txtCancelationFee.Name = "txtCancelationFee";
            this.txtCancelationFee.Size = new System.Drawing.Size(100, 20);
            this.txtCancelationFee.TabIndex = 28;
            // 
            // lblCancelationFee
            // 
            this.lblCancelationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelationFee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCancelationFee.Location = new System.Drawing.Point(45, 70);
            this.lblCancelationFee.Name = "lblCancelationFee";
            this.lblCancelationFee.Size = new System.Drawing.Size(210, 20);
            this.lblCancelationFee.TabIndex = 26;
            this.lblCancelationFee.Text = "Cancelation Fee:";
            this.lblCancelationFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelationFee
            // 
            this.btnCancelationFee.Location = new System.Drawing.Point(385, 67);
            this.btnCancelationFee.Name = "btnCancelationFee";
            this.btnCancelationFee.Size = new System.Drawing.Size(150, 25);
            this.btnCancelationFee.TabIndex = 27;
            this.btnCancelationFee.Text = "Set Cancelation Fee";
            this.btnCancelationFee.UseVisualStyleBackColor = true;
            // 
            // grpRewards
            // 
            this.grpRewards.Controls.Add(this.txtCustomerRewards);
            this.grpRewards.Controls.Add(this.label3);
            this.grpRewards.Controls.Add(this.btnCustomerRewards);
            this.grpRewards.Controls.Add(this.txtCustomerID);
            this.grpRewards.Controls.Add(this.lblCustomerID);
            this.grpRewards.Controls.Add(this.btnCustomerID);
            this.grpRewards.Location = new System.Drawing.Point(100, 350);
            this.grpRewards.Name = "grpRewards";
            this.grpRewards.Size = new System.Drawing.Size(600, 150);
            this.grpRewards.TabIndex = 28;
            this.grpRewards.TabStop = false;
            this.grpRewards.Text = "Rewards Points";
            // 
            // txtCustomerRewards
            // 
            this.txtCustomerRewards.Location = new System.Drawing.Point(265, 66);
            this.txtCustomerRewards.Name = "txtCustomerRewards";
            this.txtCustomerRewards.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerRewards.TabIndex = 43;
            this.txtCustomerRewards.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(45, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Customer Rewards Points:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // btnCustomerRewards
            // 
            this.btnCustomerRewards.Location = new System.Drawing.Point(385, 63);
            this.btnCustomerRewards.Name = "btnCustomerRewards";
            this.btnCustomerRewards.Size = new System.Drawing.Size(150, 25);
            this.btnCustomerRewards.TabIndex = 42;
            this.btnCustomerRewards.Text = "Set Rewards Points";
            this.btnCustomerRewards.UseVisualStyleBackColor = true;
            this.btnCustomerRewards.Visible = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(265, 30);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 40;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustomerID.Location = new System.Drawing.Point(45, 30);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(210, 20);
            this.lblCustomerID.TabIndex = 38;
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCustomerID
            // 
            this.btnCustomerID.Location = new System.Drawing.Point(385, 27);
            this.btnCustomerID.Name = "btnCustomerID";
            this.btnCustomerID.Size = new System.Drawing.Size(150, 25);
            this.btnCustomerID.TabIndex = 39;
            this.btnCustomerID.Text = "Search";
            this.btnCustomerID.UseVisualStyleBackColor = true;
            // 
            // HotelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpRewards);
            this.Controls.Add(this.grpHotelSettings);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Name = "HotelSettings";
            this.Text = "HotelSettings";
            this.grpHotelSettings.ResumeLayout(false);
            this.grpHotelSettings.PerformLayout();
            this.grpRewards.ResumeLayout(false);
            this.grpRewards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMinimumCharge;
        private System.Windows.Forms.Button btnMinCharge;
        private System.Windows.Forms.TextBox txtMinimumCharge;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox grpHotelSettings;
        private System.Windows.Forms.TextBox txtCancelationWindow;
        private System.Windows.Forms.Label lblCancelationWindow;
        private System.Windows.Forms.Button btnCancelationWindow;
        private System.Windows.Forms.TextBox txtCancelationFee;
        private System.Windows.Forms.Label lblCancelationFee;
        private System.Windows.Forms.Button btnCancelationFee;
        private System.Windows.Forms.TextBox txtNotifyCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNotifyDays;
        private System.Windows.Forms.TextBox txtPointsPerDay;
        private System.Windows.Forms.Label lblPointsPerDay;
        private System.Windows.Forms.Button btnPointsPerDay;
        private System.Windows.Forms.GroupBox grpRewards;
        private System.Windows.Forms.TextBox txtCustomerRewards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomerRewards;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnCustomerID;
    }
}