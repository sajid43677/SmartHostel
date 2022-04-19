namespace SmartHostel
{
    partial class ManageRoom
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
            this.pnlManageRoom = new System.Windows.Forms.Panel();
            this.btnManageRoomBack = new System.Windows.Forms.Button();
            this.pnlManageRoom2 = new System.Windows.Forms.Panel();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblManageRoomShowName = new System.Windows.Forms.Label();
            this.lblManageRoomShowPhone = new System.Windows.Forms.Label();
            this.lblManageRoomName = new System.Windows.Forms.Label();
            this.lblManageRoomPhone = new System.Windows.Forms.Label();
            this.btnManageRoomSave = new System.Windows.Forms.Button();
            this.btnManageRoomSearch = new System.Windows.Forms.Button();
            this.lblManageRoomId = new System.Windows.Forms.Label();
            this.txtManageRoomId = new System.Windows.Forms.TextBox();
            this.pnlManageRoom.SuspendLayout();
            this.pnlManageRoom2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageRoom
            // 
            this.pnlManageRoom.Controls.Add(this.btnManageRoomBack);
            this.pnlManageRoom.Controls.Add(this.pnlManageRoom2);
            this.pnlManageRoom.Controls.Add(this.btnManageRoomSave);
            this.pnlManageRoom.Controls.Add(this.btnManageRoomSearch);
            this.pnlManageRoom.Controls.Add(this.lblManageRoomId);
            this.pnlManageRoom.Controls.Add(this.txtManageRoomId);
            this.pnlManageRoom.Location = new System.Drawing.Point(156, 37);
            this.pnlManageRoom.Name = "pnlManageRoom";
            this.pnlManageRoom.Size = new System.Drawing.Size(685, 504);
            this.pnlManageRoom.TabIndex = 18;
            // 
            // btnManageRoomBack
            // 
            this.btnManageRoomBack.Location = new System.Drawing.Point(15, 462);
            this.btnManageRoomBack.Name = "btnManageRoomBack";
            this.btnManageRoomBack.Size = new System.Drawing.Size(84, 29);
            this.btnManageRoomBack.TabIndex = 17;
            this.btnManageRoomBack.Text = "Back";
            this.btnManageRoomBack.UseVisualStyleBackColor = true;
            this.btnManageRoomBack.Click += new System.EventHandler(this.btnManageRoomBack_Click);
            // 
            // pnlManageRoom2
            // 
            this.pnlManageRoom2.BackColor = System.Drawing.Color.Pink;
            this.pnlManageRoom2.Controls.Add(this.cmbRoomType);
            this.pnlManageRoom2.Controls.Add(this.lblRoomType);
            this.pnlManageRoom2.Controls.Add(this.lblManageRoomShowName);
            this.pnlManageRoom2.Controls.Add(this.lblManageRoomShowPhone);
            this.pnlManageRoom2.Controls.Add(this.lblManageRoomName);
            this.pnlManageRoom2.Controls.Add(this.lblManageRoomPhone);
            this.pnlManageRoom2.Location = new System.Drawing.Point(102, 168);
            this.pnlManageRoom2.Name = "pnlManageRoom2";
            this.pnlManageRoom2.Size = new System.Drawing.Size(475, 248);
            this.pnlManageRoom2.TabIndex = 15;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Economy",
            "Elegant",
            "Vip",
            " "});
            this.cmbRoomType.Location = new System.Drawing.Point(230, 146);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(150, 26);
            this.cmbRoomType.TabIndex = 16;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(77, 145);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(101, 21);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblManageRoomShowName
            // 
            this.lblManageRoomShowName.AutoSize = true;
            this.lblManageRoomShowName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRoomShowName.Location = new System.Drawing.Point(237, 24);
            this.lblManageRoomShowName.Name = "lblManageRoomShowName";
            this.lblManageRoomShowName.Size = new System.Drawing.Size(125, 21);
            this.lblManageRoomShowName.TabIndex = 14;
            this.lblManageRoomShowName.Text = ".......................";
            // 
            // lblManageRoomShowPhone
            // 
            this.lblManageRoomShowPhone.AutoSize = true;
            this.lblManageRoomShowPhone.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRoomShowPhone.Location = new System.Drawing.Point(237, 88);
            this.lblManageRoomShowPhone.Name = "lblManageRoomShowPhone";
            this.lblManageRoomShowPhone.Size = new System.Drawing.Size(125, 21);
            this.lblManageRoomShowPhone.TabIndex = 13;
            this.lblManageRoomShowPhone.Text = ".......................";
            // 
            // lblManageRoomName
            // 
            this.lblManageRoomName.AutoSize = true;
            this.lblManageRoomName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRoomName.Location = new System.Drawing.Point(97, 24);
            this.lblManageRoomName.Name = "lblManageRoomName";
            this.lblManageRoomName.Size = new System.Drawing.Size(61, 21);
            this.lblManageRoomName.TabIndex = 2;
            this.lblManageRoomName.Text = "Name";
            // 
            // lblManageRoomPhone
            // 
            this.lblManageRoomPhone.AutoSize = true;
            this.lblManageRoomPhone.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRoomPhone.Location = new System.Drawing.Point(68, 88);
            this.lblManageRoomPhone.Name = "lblManageRoomPhone";
            this.lblManageRoomPhone.Size = new System.Drawing.Size(133, 21);
            this.lblManageRoomPhone.TabIndex = 1;
            this.lblManageRoomPhone.Text = "Phone Number";
            // 
            // btnManageRoomSave
            // 
            this.btnManageRoomSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoomSave.Location = new System.Drawing.Point(267, 437);
            this.btnManageRoomSave.Name = "btnManageRoomSave";
            this.btnManageRoomSave.Size = new System.Drawing.Size(178, 38);
            this.btnManageRoomSave.TabIndex = 11;
            this.btnManageRoomSave.Text = "Save";
            this.btnManageRoomSave.UseVisualStyleBackColor = true;
            this.btnManageRoomSave.Click += new System.EventHandler(this.btnManageRoomSave_Click);
            // 
            // btnManageRoomSearch
            // 
            this.btnManageRoomSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoomSearch.Location = new System.Drawing.Point(290, 95);
            this.btnManageRoomSearch.Name = "btnManageRoomSearch";
            this.btnManageRoomSearch.Size = new System.Drawing.Size(99, 38);
            this.btnManageRoomSearch.TabIndex = 9;
            this.btnManageRoomSearch.Text = "Search";
            this.btnManageRoomSearch.UseVisualStyleBackColor = true;
            this.btnManageRoomSearch.Click += new System.EventHandler(this.btnManageRoomSearch_Click);
            // 
            // lblManageRoomId
            // 
            this.lblManageRoomId.AutoSize = true;
            this.lblManageRoomId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRoomId.ForeColor = System.Drawing.Color.White;
            this.lblManageRoomId.Location = new System.Drawing.Point(179, 16);
            this.lblManageRoomId.Name = "lblManageRoomId";
            this.lblManageRoomId.Size = new System.Drawing.Size(144, 19);
            this.lblManageRoomId.TabIndex = 8;
            this.lblManageRoomId.Text = "Enter Resident ID";
            // 
            // txtManageRoomId
            // 
            this.txtManageRoomId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManageRoomId.Location = new System.Drawing.Point(183, 43);
            this.txtManageRoomId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManageRoomId.Name = "txtManageRoomId";
            this.txtManageRoomId.Size = new System.Drawing.Size(312, 32);
            this.txtManageRoomId.TabIndex = 7;
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(977, 579);
            this.Controls.Add(this.pnlManageRoom);
            this.Name = "ManageRoom";
            this.Text = "Manage Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageRoom_FormClosed);
            this.pnlManageRoom.ResumeLayout(false);
            this.pnlManageRoom.PerformLayout();
            this.pnlManageRoom2.ResumeLayout(false);
            this.pnlManageRoom2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageRoom;
        private System.Windows.Forms.Panel pnlManageRoom2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblManageRoomShowName;
        private System.Windows.Forms.Label lblManageRoomShowPhone;
        private System.Windows.Forms.Label lblManageRoomName;
        private System.Windows.Forms.Label lblManageRoomPhone;
        private System.Windows.Forms.Button btnManageRoomSave;
        private System.Windows.Forms.Button btnManageRoomSearch;
        private System.Windows.Forms.Label lblManageRoomId;
        private System.Windows.Forms.TextBox txtManageRoomId;
        private System.Windows.Forms.Button btnManageRoomBack;
    }
}