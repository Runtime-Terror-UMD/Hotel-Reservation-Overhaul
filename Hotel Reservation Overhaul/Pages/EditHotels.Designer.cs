namespace Hotel_Reservation_Overhaul.Pages
{
    partial class EditHotels
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
            this.cboxHotel = new System.Windows.Forms.ComboBox();
            this.btnEditHotel = new System.Windows.Forms.Button();
            this.btnNewHotel = new System.Windows.Forms.Button();
            this.btnNewRoomType = new System.Windows.Forms.Button();
            this.btnEditRoomTypeName = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.btnEditRoomName = new System.Windows.Forms.Button();
            this.grpHotel = new System.Windows.Forms.GroupBox();
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.btnAssignRooms = new System.Windows.Forms.Button();
            this.btnAddToHotel = new System.Windows.Forms.Button();
            this.btnUpRTDesc = new System.Windows.Forms.Button();
            this.txtRoomTypeDesc = new System.Windows.Forms.TextBox();
            this.cboxRType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRTypeDesc = new System.Windows.Forms.Label();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.btnUpdateDescRoom = new System.Windows.Forms.Button();
            this.lblRoomDesc = new System.Windows.Forms.Label();
            this.txtRoomDesc = new System.Windows.Forms.TextBox();
            this.cboxRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnAssignRoomType = new System.Windows.Forms.Button();
            this.btnToggleAvailability = new System.Windows.Forms.Button();
            this.grpHotel.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.grpRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 14;
            this.lblDescribe.Text = "Manage the hotel chain.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Hotel Reservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(25, 30);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(60, 20);
            this.lblHotel.TabIndex = 0;
            this.lblHotel.Text = "Hotel:";
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxHotel
            // 
            this.cboxHotel.FormattingEnabled = true;
            this.cboxHotel.Location = new System.Drawing.Point(90, 30);
            this.cboxHotel.Name = "cboxHotel";
            this.cboxHotel.Size = new System.Drawing.Size(250, 21);
            this.cboxHotel.TabIndex = 1;
            // 
            // btnEditHotel
            // 
            this.btnEditHotel.Location = new System.Drawing.Point(470, 30);
            this.btnEditHotel.Name = "btnEditHotel";
            this.btnEditHotel.Size = new System.Drawing.Size(100, 20);
            this.btnEditHotel.TabIndex = 3;
            this.btnEditHotel.Text = "Edit Hotel";
            this.btnEditHotel.UseVisualStyleBackColor = true;
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.Location = new System.Drawing.Point(350, 30);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(100, 20);
            this.btnNewHotel.TabIndex = 2;
            this.btnNewHotel.Text = "New Hotel";
            this.btnNewHotel.UseVisualStyleBackColor = true;
            // 
            // btnNewRoomType
            // 
            this.btnNewRoomType.Location = new System.Drawing.Point(400, 30);
            this.btnNewRoomType.Name = "btnNewRoomType";
            this.btnNewRoomType.Size = new System.Drawing.Size(120, 25);
            this.btnNewRoomType.TabIndex = 7;
            this.btnNewRoomType.Text = "New Room Type";
            this.btnNewRoomType.UseVisualStyleBackColor = true;
            // 
            // btnEditRoomTypeName
            // 
            this.btnEditRoomTypeName.Location = new System.Drawing.Point(550, 44);
            this.btnEditRoomTypeName.Name = "btnEditRoomTypeName";
            this.btnEditRoomTypeName.Size = new System.Drawing.Size(120, 40);
            this.btnEditRoomTypeName.TabIndex = 10;
            this.btnEditRoomTypeName.Text = "Edit Room Type Name";
            this.btnEditRoomTypeName.UseVisualStyleBackColor = true;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(400, 30);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(120, 25);
            this.btnNewRoom.TabIndex = 14;
            this.btnNewRoom.Text = "New Room";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            // 
            // btnEditRoomName
            // 
            this.btnEditRoomName.Location = new System.Drawing.Point(550, 30);
            this.btnEditRoomName.Name = "btnEditRoomName";
            this.btnEditRoomName.Size = new System.Drawing.Size(120, 25);
            this.btnEditRoomName.TabIndex = 16;
            this.btnEditRoomName.Text = "Edit Room Name";
            this.btnEditRoomName.UseVisualStyleBackColor = true;
            // 
            // grpHotel
            // 
            this.grpHotel.Controls.Add(this.btnDeleteHotel);
            this.grpHotel.Controls.Add(this.btnNewHotel);
            this.grpHotel.Controls.Add(this.btnEditHotel);
            this.grpHotel.Controls.Add(this.cboxHotel);
            this.grpHotel.Controls.Add(this.lblHotel);
            this.grpHotel.Location = new System.Drawing.Point(50, 100);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Size = new System.Drawing.Size(700, 75);
            this.grpHotel.TabIndex = 0;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Hotel";
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.Location = new System.Drawing.Point(590, 30);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(100, 20);
            this.btnDeleteHotel.TabIndex = 4;
            this.btnDeleteHotel.Text = "Delete Hotel";
            this.btnDeleteHotel.UseVisualStyleBackColor = true;
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.btnAssignRooms);
            this.grpRoomType.Controls.Add(this.btnAddToHotel);
            this.grpRoomType.Controls.Add(this.btnUpRTDesc);
            this.grpRoomType.Controls.Add(this.txtRoomTypeDesc);
            this.grpRoomType.Controls.Add(this.cboxRType);
            this.grpRoomType.Controls.Add(this.lblRoomType);
            this.grpRoomType.Controls.Add(this.lblRTypeDesc);
            this.grpRoomType.Controls.Add(this.btnNewRoomType);
            this.grpRoomType.Controls.Add(this.btnEditRoomTypeName);
            this.grpRoomType.Location = new System.Drawing.Point(50, 200);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(700, 150);
            this.grpRoomType.TabIndex = 0;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room Types at Hotel";
            // 
            // btnAssignRooms
            // 
            this.btnAssignRooms.Location = new System.Drawing.Point(400, 110);
            this.btnAssignRooms.Name = "btnAssignRooms";
            this.btnAssignRooms.Size = new System.Drawing.Size(120, 25);
            this.btnAssignRooms.TabIndex = 9;
            this.btnAssignRooms.Text = "Assign Rooms";
            this.btnAssignRooms.UseVisualStyleBackColor = true;
            // 
            // btnAddToHotel
            // 
            this.btnAddToHotel.Location = new System.Drawing.Point(400, 70);
            this.btnAddToHotel.Name = "btnAddToHotel";
            this.btnAddToHotel.Size = new System.Drawing.Size(120, 25);
            this.btnAddToHotel.TabIndex = 8;
            this.btnAddToHotel.Text = "Add to Another Hotel";
            this.btnAddToHotel.UseVisualStyleBackColor = true;
            // 
            // btnUpRTDesc
            // 
            this.btnUpRTDesc.Location = new System.Drawing.Point(550, 95);
            this.btnUpRTDesc.Name = "btnUpRTDesc";
            this.btnUpRTDesc.Size = new System.Drawing.Size(120, 25);
            this.btnUpRTDesc.TabIndex = 11;
            this.btnUpRTDesc.Text = "Update Description";
            this.btnUpRTDesc.UseVisualStyleBackColor = true;
            // 
            // txtRoomTypeDesc
            // 
            this.txtRoomTypeDesc.Location = new System.Drawing.Point(115, 60);
            this.txtRoomTypeDesc.Multiline = true;
            this.txtRoomTypeDesc.Name = "txtRoomTypeDesc";
            this.txtRoomTypeDesc.Size = new System.Drawing.Size(250, 70);
            this.txtRoomTypeDesc.TabIndex = 6;
            // 
            // cboxRType
            // 
            this.cboxRType.FormattingEnabled = true;
            this.cboxRType.Location = new System.Drawing.Point(115, 30);
            this.cboxRType.Name = "cboxRType";
            this.cboxRType.Size = new System.Drawing.Size(250, 21);
            this.cboxRType.TabIndex = 5;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(25, 30);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(85, 20);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type:";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRTypeDesc
            // 
            this.lblRTypeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTypeDesc.Location = new System.Drawing.Point(25, 60);
            this.lblRTypeDesc.Name = "lblRTypeDesc";
            this.lblRTypeDesc.Size = new System.Drawing.Size(85, 20);
            this.lblRTypeDesc.TabIndex = 0;
            this.lblRTypeDesc.Text = "Description:";
            this.lblRTypeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.btnUpdateDescRoom);
            this.grpRoom.Controls.Add(this.lblRoomDesc);
            this.grpRoom.Controls.Add(this.txtRoomDesc);
            this.grpRoom.Controls.Add(this.cboxRoom);
            this.grpRoom.Controls.Add(this.lblRoom);
            this.grpRoom.Controls.Add(this.btnAssignRoomType);
            this.grpRoom.Controls.Add(this.btnToggleAvailability);
            this.grpRoom.Controls.Add(this.btnNewRoom);
            this.grpRoom.Controls.Add(this.btnEditRoomName);
            this.grpRoom.Location = new System.Drawing.Point(50, 375);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(700, 150);
            this.grpRoom.TabIndex = 0;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Rooms at Hotel";
            // 
            // btnUpdateDescRoom
            // 
            this.btnUpdateDescRoom.Location = new System.Drawing.Point(550, 91);
            this.btnUpdateDescRoom.Name = "btnUpdateDescRoom";
            this.btnUpdateDescRoom.Size = new System.Drawing.Size(120, 25);
            this.btnUpdateDescRoom.TabIndex = 18;
            this.btnUpdateDescRoom.Text = "Update Description";
            this.btnUpdateDescRoom.UseVisualStyleBackColor = true;
            // 
            // lblRoomDesc
            // 
            this.lblRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDesc.Location = new System.Drawing.Point(25, 60);
            this.lblRoomDesc.Name = "lblRoomDesc";
            this.lblRoomDesc.Size = new System.Drawing.Size(85, 20);
            this.lblRoomDesc.TabIndex = 0;
            this.lblRoomDesc.Text = "Description:";
            this.lblRoomDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomDesc
            // 
            this.txtRoomDesc.Location = new System.Drawing.Point(115, 60);
            this.txtRoomDesc.Multiline = true;
            this.txtRoomDesc.Name = "txtRoomDesc";
            this.txtRoomDesc.Size = new System.Drawing.Size(250, 70);
            this.txtRoomDesc.TabIndex = 13;
            // 
            // cboxRoom
            // 
            this.cboxRoom.FormattingEnabled = true;
            this.cboxRoom.Location = new System.Drawing.Point(115, 30);
            this.cboxRoom.Name = "cboxRoom";
            this.cboxRoom.Size = new System.Drawing.Size(250, 21);
            this.cboxRoom.TabIndex = 12;
            // 
            // lblRoom
            // 
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(25, 30);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(85, 20);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room:";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAssignRoomType
            // 
            this.btnAssignRoomType.Location = new System.Drawing.Point(400, 91);
            this.btnAssignRoomType.Name = "btnAssignRoomType";
            this.btnAssignRoomType.Size = new System.Drawing.Size(120, 25);
            this.btnAssignRoomType.TabIndex = 15;
            this.btnAssignRoomType.Text = "Assign Room Type";
            this.btnAssignRoomType.UseVisualStyleBackColor = true;
            // 
            // btnToggleAvailability
            // 
            this.btnToggleAvailability.Location = new System.Drawing.Point(550, 60);
            this.btnToggleAvailability.Name = "btnToggleAvailability";
            this.btnToggleAvailability.Size = new System.Drawing.Size(120, 25);
            this.btnToggleAvailability.TabIndex = 17;
            this.btnToggleAvailability.Text = "Toggle Availability";
            this.btnToggleAvailability.UseVisualStyleBackColor = true;
            // 
            // EditHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.grpHotel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "EditHotels";
            this.Text = "Hotel Reservation: Edit Hotels";
            this.grpHotel.ResumeLayout(false);
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cboxHotel;
        private System.Windows.Forms.Button btnEditHotel;
        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Button btnNewRoomType;
        private System.Windows.Forms.Button btnEditRoomTypeName;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Button btnEditRoomName;
        private System.Windows.Forms.GroupBox grpHotel;
        private System.Windows.Forms.Button btnDeleteHotel;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.Button btnAssignRooms;
        private System.Windows.Forms.Button btnAddToHotel;
        private System.Windows.Forms.Button btnUpRTDesc;
        private System.Windows.Forms.TextBox txtRoomTypeDesc;
        private System.Windows.Forms.ComboBox cboxRType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRTypeDesc;
        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.Label lblRoomDesc;
        private System.Windows.Forms.TextBox txtRoomDesc;
        private System.Windows.Forms.ComboBox cboxRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnAssignRoomType;
        private System.Windows.Forms.Button btnToggleAvailability;
        private System.Windows.Forms.Button btnUpdateDescRoom;
    }
}