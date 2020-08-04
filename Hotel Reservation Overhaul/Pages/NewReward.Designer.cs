namespace Hotel_Reservation_Overhaul.Pages
{
    partial class NewReward
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.lblRewardTypeDesc = new System.Windows.Forms.Label();
            this.lblRewardDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.clistHotels = new System.Windows.Forms.CheckedListBox();
            this.lblModifier = new System.Windows.Forms.Label();
            this.txtModify = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPointPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRedeemedNum = new System.Windows.Forms.Label();
            this.lblNumRedeemDesc = new System.Windows.Forms.Label();
            this.lblRevenueLost = new System.Windows.Forms.Label();
            this.lblRevenueDesc = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRewardIDNum = new System.Windows.Forms.Label();
            this.lblRewardIDDesc = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Create a new reward.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(50, 100);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(95, 20);
            this.lblHotel.TabIndex = 0;
            this.lblHotel.Text = "Hotels:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(580, 100);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(150, 21);
            this.cboxType.TabIndex = 2;
            // 
            // lblRewardTypeDesc
            // 
            this.lblRewardTypeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardTypeDesc.Location = new System.Drawing.Point(450, 100);
            this.lblRewardTypeDesc.Name = "lblRewardTypeDesc";
            this.lblRewardTypeDesc.Size = new System.Drawing.Size(125, 20);
            this.lblRewardTypeDesc.TabIndex = 0;
            this.lblRewardTypeDesc.Text = "Reward Type:";
            this.lblRewardTypeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRewardDesc
            // 
            this.lblRewardDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardDesc.Location = new System.Drawing.Point(50, 250);
            this.lblRewardDesc.Name = "lblRewardDesc";
            this.lblRewardDesc.Size = new System.Drawing.Size(95, 40);
            this.lblRewardDesc.TabIndex = 0;
            this.lblRewardDesc.Text = "Reward Description:";
            this.lblRewardDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(170, 250);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(250, 200);
            this.txtDesc.TabIndex = 6;
            // 
            // clistHotels
            // 
            this.clistHotels.FormattingEnabled = true;
            this.clistHotels.Location = new System.Drawing.Point(170, 100);
            this.clistHotels.Name = "clistHotels";
            this.clistHotels.Size = new System.Drawing.Size(250, 124);
            this.clistHotels.TabIndex = 1;
            // 
            // lblModifier
            // 
            this.lblModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier.Location = new System.Drawing.Point(450, 150);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(125, 20);
            this.lblModifier.TabIndex = 18;
            this.lblModifier.Text = "Reward Modifier:";
            this.lblModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModify
            // 
            this.txtModify.Location = new System.Drawing.Point(580, 150);
            this.txtModify.Name = "txtModify";
            this.txtModify.Size = new System.Drawing.Size(150, 20);
            this.txtModify.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(580, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Create Reward";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPointPrice
            // 
            this.txtPointPrice.Location = new System.Drawing.Point(580, 200);
            this.txtPointPrice.Name = "txtPointPrice";
            this.txtPointPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPointPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(450, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(125, 20);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Reward Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRedeemedNum
            // 
            this.lblRedeemedNum.BackColor = System.Drawing.SystemColors.Window;
            this.lblRedeemedNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedeemedNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedeemedNum.Location = new System.Drawing.Point(580, 360);
            this.lblRedeemedNum.Name = "lblRedeemedNum";
            this.lblRedeemedNum.Size = new System.Drawing.Size(150, 20);
            this.lblRedeemedNum.TabIndex = 0;
            this.lblRedeemedNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumRedeemDesc
            // 
            this.lblNumRedeemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRedeemDesc.Location = new System.Drawing.Point(438, 350);
            this.lblNumRedeemDesc.Name = "lblNumRedeemDesc";
            this.lblNumRedeemDesc.Size = new System.Drawing.Size(125, 40);
            this.lblNumRedeemDesc.TabIndex = 0;
            this.lblNumRedeemDesc.Text = "Number of Redeems:";
            this.lblNumRedeemDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRevenueLost
            // 
            this.lblRevenueLost.BackColor = System.Drawing.SystemColors.Window;
            this.lblRevenueLost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenueLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueLost.Location = new System.Drawing.Point(580, 410);
            this.lblRevenueLost.Name = "lblRevenueLost";
            this.lblRevenueLost.Size = new System.Drawing.Size(150, 20);
            this.lblRevenueLost.TabIndex = 0;
            this.lblRevenueLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRevenueDesc
            // 
            this.lblRevenueDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueDesc.Location = new System.Drawing.Point(450, 410);
            this.lblRevenueDesc.Name = "lblRevenueDesc";
            this.lblRevenueDesc.Size = new System.Drawing.Size(125, 20);
            this.lblRevenueDesc.TabIndex = 0;
            this.lblRevenueDesc.Text = "Revenue Lost:";
            this.lblRevenueDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable
            // 
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(450, 250);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(125, 20);
            this.lblAvailable.TabIndex = 0;
            this.lblAvailable.Text = "Availibility:";
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(580, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblRewardIDNum
            // 
            this.lblRewardIDNum.BackColor = System.Drawing.SystemColors.Window;
            this.lblRewardIDNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRewardIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardIDNum.Location = new System.Drawing.Point(170, 490);
            this.lblRewardIDNum.Name = "lblRewardIDNum";
            this.lblRewardIDNum.Size = new System.Drawing.Size(150, 20);
            this.lblRewardIDNum.TabIndex = 0;
            this.lblRewardIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRewardIDDesc
            // 
            this.lblRewardIDDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardIDDesc.Location = new System.Drawing.Point(20, 490);
            this.lblRewardIDDesc.Name = "lblRewardIDDesc";
            this.lblRewardIDDesc.Size = new System.Drawing.Size(125, 20);
            this.lblRewardIDDesc.TabIndex = 0;
            this.lblRewardIDDesc.Text = "Reward ID:";
            this.lblRewardIDDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(413, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel Reward";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRewardIDNum);
            this.Controls.Add(this.lblRewardIDDesc);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRevenueLost);
            this.Controls.Add(this.lblRevenueDesc);
            this.Controls.Add(this.lblRedeemedNum);
            this.Controls.Add(this.lblNumRedeemDesc);
            this.Controls.Add(this.txtPointPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtModify);
            this.Controls.Add(this.lblModifier);
            this.Controls.Add(this.clistHotels);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblRewardDesc);
            this.Controls.Add(this.lblRewardTypeDesc);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "NewReward";
            this.Text = "Hotel Reservation: New Reward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label lblRewardTypeDesc;
        private System.Windows.Forms.Label lblRewardDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.CheckedListBox clistHotels;
        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.TextBox txtModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPointPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRedeemedNum;
        private System.Windows.Forms.Label lblNumRedeemDesc;
        private System.Windows.Forms.Label lblRevenueLost;
        private System.Windows.Forms.Label lblRevenueDesc;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRewardIDNum;
        private System.Windows.Forms.Label lblRewardIDDesc;
        private System.Windows.Forms.Button btnCancel;
    }
}