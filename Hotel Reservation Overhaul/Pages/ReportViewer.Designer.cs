namespace Hotel_Reservation_Overhaul.Pages
{
    partial class ReportViewer
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
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.hotelmgmt = new Hotel_Reservation_Overhaul.hotelmgmt();
            this.hotelmgmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpProfileInfo = new System.Windows.Forms.GroupBox();
            this.lblRewardDesc = new System.Windows.Forms.Label();
            this.lblEmailDesc = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstNameDesc = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameDesc = new System.Windows.Forms.Label();
            this.lblRewardsPoints = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblUsernameDesc = new System.Windows.Forms.Label();
            this.lblAccountIDDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).BeginInit();
            this.grpProfileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.AllowUserToAddRows = false;
            this.reportDataGrid.AllowUserToDeleteRows = false;
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Location = new System.Drawing.Point(69, 235);
            this.reportDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.ReadOnly = true;
            this.reportDataGrid.RowHeadersWidth = 62;
            this.reportDataGrid.RowTemplate.Height = 28;
            this.reportDataGrid.Size = new System.Drawing.Size(675, 318);
            this.reportDataGrid.TabIndex = 11;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(203, 66);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 13;
            this.lblDescribe.Text = "Report";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(203, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(700, 18);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 15;
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
            // grpProfileInfo
            // 
            this.grpProfileInfo.Controls.Add(this.lblRewardDesc);
            this.grpProfileInfo.Controls.Add(this.lblEmailDesc);
            this.grpProfileInfo.Controls.Add(this.lblFirstName);
            this.grpProfileInfo.Controls.Add(this.lblFirstNameDesc);
            this.grpProfileInfo.Controls.Add(this.lblLastName);
            this.grpProfileInfo.Controls.Add(this.lblLastNameDesc);
            this.grpProfileInfo.Controls.Add(this.lblRewardsPoints);
            this.grpProfileInfo.Controls.Add(this.lblEmail);
            this.grpProfileInfo.Controls.Add(this.lblUsername);
            this.grpProfileInfo.Controls.Add(this.lblAccountID);
            this.grpProfileInfo.Controls.Add(this.lblUsernameDesc);
            this.grpProfileInfo.Controls.Add(this.lblAccountIDDesc);
            this.grpProfileInfo.Location = new System.Drawing.Point(69, 99);
            this.grpProfileInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProfileInfo.Name = "grpProfileInfo";
            this.grpProfileInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProfileInfo.Size = new System.Drawing.Size(675, 108);
            this.grpProfileInfo.TabIndex = 16;
            this.grpProfileInfo.TabStop = false;
            this.grpProfileInfo.Text = "Customer Profile";
            // 
            // lblRewardDesc
            // 
            this.lblRewardDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardDesc.Location = new System.Drawing.Point(371, 74);
            this.lblRewardDesc.Name = "lblRewardDesc";
            this.lblRewardDesc.Size = new System.Drawing.Size(120, 20);
            this.lblRewardDesc.TabIndex = 36;
            this.lblRewardDesc.Text = "Reward Points:";
            this.lblRewardDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmailDesc
            // 
            this.lblEmailDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDesc.Location = new System.Drawing.Point(5, 74);
            this.lblEmailDesc.Name = "lblEmailDesc";
            this.lblEmailDesc.Size = new System.Drawing.Size(104, 20);
            this.lblEmailDesc.TabIndex = 35;
            this.lblEmailDesc.Text = "Email:";
            this.lblEmailDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(497, 23);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(150, 21);
            this.lblFirstName.TabIndex = 33;
            // 
            // lblFirstNameDesc
            // 
            this.lblFirstNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameDesc.Location = new System.Drawing.Point(397, 23);
            this.lblFirstNameDesc.Name = "lblFirstNameDesc";
            this.lblFirstNameDesc.Size = new System.Drawing.Size(94, 20);
            this.lblFirstNameDesc.TabIndex = 32;
            this.lblFirstNameDesc.Text = "First Name:";
            this.lblFirstNameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(497, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(150, 21);
            this.lblLastName.TabIndex = 29;
            // 
            // lblLastNameDesc
            // 
            this.lblLastNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameDesc.Location = new System.Drawing.Point(398, 45);
            this.lblLastNameDesc.Name = "lblLastNameDesc";
            this.lblLastNameDesc.Size = new System.Drawing.Size(94, 20);
            this.lblLastNameDesc.TabIndex = 30;
            this.lblLastNameDesc.Text = "Last Name:";
            this.lblLastNameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRewardsPoints
            // 
            this.lblRewardsPoints.BackColor = System.Drawing.SystemColors.Window;
            this.lblRewardsPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRewardsPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardsPoints.Location = new System.Drawing.Point(497, 74);
            this.lblRewardsPoints.Name = "lblRewardsPoints";
            this.lblRewardsPoints.Size = new System.Drawing.Size(150, 20);
            this.lblRewardsPoints.TabIndex = 34;
            this.lblRewardsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(113, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(113, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 20);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountID
            // 
            this.lblAccountID.BackColor = System.Drawing.SystemColors.Window;
            this.lblAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(113, 23);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(150, 20);
            this.lblAccountID.TabIndex = 26;
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsernameDesc
            // 
            this.lblUsernameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDesc.Location = new System.Drawing.Point(20, 48);
            this.lblUsernameDesc.Name = "lblUsernameDesc";
            this.lblUsernameDesc.Size = new System.Drawing.Size(89, 20);
            this.lblUsernameDesc.TabIndex = 27;
            this.lblUsernameDesc.Text = "Username:";
            this.lblUsernameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountIDDesc
            // 
            this.lblAccountIDDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountIDDesc.Location = new System.Drawing.Point(20, 23);
            this.lblAccountIDDesc.Name = "lblAccountIDDesc";
            this.lblAccountIDDesc.Size = new System.Drawing.Size(89, 20);
            this.lblAccountIDDesc.TabIndex = 28;
            this.lblAccountIDDesc.Text = "Account ID:";
            this.lblAccountIDDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.grpProfileInfo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.reportDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmgmtBindingSource)).EndInit();
            this.grpProfileInfo.ResumeLayout(false);
            this.grpProfileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.BindingSource hotelmgmtBindingSource;
        private hotelmgmt hotelmgmt;
        private System.Windows.Forms.GroupBox grpProfileInfo;
        private System.Windows.Forms.TextBox lblFirstName;
        private System.Windows.Forms.Label lblFirstNameDesc;
        private System.Windows.Forms.TextBox lblLastName;
        private System.Windows.Forms.Label lblLastNameDesc;
        private System.Windows.Forms.Label lblRewardsPoints;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblUsernameDesc;
        private System.Windows.Forms.Label lblAccountIDDesc;
        private System.Windows.Forms.Label lblRewardDesc;
        private System.Windows.Forms.Label lblEmailDesc;
    }
}