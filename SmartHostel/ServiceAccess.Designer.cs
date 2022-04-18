namespace SmartHostel
{
    partial class ServiceAccess
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
            this.btnSerAccBack = new System.Windows.Forms.Button();
            this.lbSerAccUID = new System.Windows.Forms.Label();
            this.lbNameSerAccUID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbMeal = new System.Windows.Forms.CheckBox();
            this.ckbLaundryAcc = new System.Windows.Forms.CheckBox();
            this.ckbGameRoomAcc = new System.Windows.Forms.CheckBox();
            this.ckbGymAcc = new System.Windows.Forms.CheckBox();
            this.btnSerAccCon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerAccBack
            // 
            this.btnSerAccBack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerAccBack.Location = new System.Drawing.Point(12, 409);
            this.btnSerAccBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSerAccBack.Name = "btnSerAccBack";
            this.btnSerAccBack.Size = new System.Drawing.Size(88, 30);
            this.btnSerAccBack.TabIndex = 20;
            this.btnSerAccBack.Text = "Back";
            this.btnSerAccBack.UseVisualStyleBackColor = true;
            this.btnSerAccBack.Click += new System.EventHandler(this.btnSerAccBack_Click);
            // 
            // lbSerAccUID
            // 
            this.lbSerAccUID.AutoSize = true;
            this.lbSerAccUID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerAccUID.Location = new System.Drawing.Point(100, 9);
            this.lbSerAccUID.Name = "lbSerAccUID";
            this.lbSerAccUID.Size = new System.Drawing.Size(125, 23);
            this.lbSerAccUID.TabIndex = 19;
            this.lbSerAccUID.Text = ".......................";
            // 
            // lbNameSerAccUID
            // 
            this.lbNameSerAccUID.AutoSize = true;
            this.lbNameSerAccUID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSerAccUID.Location = new System.Drawing.Point(12, 9);
            this.lbNameSerAccUID.Name = "lbNameSerAccUID";
            this.lbNameSerAccUID.Size = new System.Drawing.Size(81, 23);
            this.lbNameSerAccUID.TabIndex = 18;
            this.lbNameSerAccUID.Text = "User ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbMeal);
            this.panel1.Controls.Add(this.ckbLaundryAcc);
            this.panel1.Controls.Add(this.ckbGameRoomAcc);
            this.panel1.Controls.Add(this.ckbGymAcc);
            this.panel1.Location = new System.Drawing.Point(201, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 231);
            this.panel1.TabIndex = 17;
            // 
            // ckbMeal
            // 
            this.ckbMeal.AutoSize = true;
            this.ckbMeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMeal.ForeColor = System.Drawing.Color.White;
            this.ckbMeal.Location = new System.Drawing.Point(21, 198);
            this.ckbMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbMeal.Name = "ckbMeal";
            this.ckbMeal.Size = new System.Drawing.Size(81, 27);
            this.ckbMeal.TabIndex = 11;
            this.ckbMeal.Text = "Meal";
            this.ckbMeal.UseVisualStyleBackColor = true;
            // 
            // ckbLaundryAcc
            // 
            this.ckbLaundryAcc.AutoSize = true;
            this.ckbLaundryAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLaundryAcc.ForeColor = System.Drawing.Color.White;
            this.ckbLaundryAcc.Location = new System.Drawing.Point(21, 139);
            this.ckbLaundryAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbLaundryAcc.Name = "ckbLaundryAcc";
            this.ckbLaundryAcc.Size = new System.Drawing.Size(212, 27);
            this.ckbLaundryAcc.TabIndex = 6;
            this.ckbLaundryAcc.Text = "Laundry Amenities";
            this.ckbLaundryAcc.UseVisualStyleBackColor = true;
            // 
            // ckbGameRoomAcc
            // 
            this.ckbGameRoomAcc.AutoSize = true;
            this.ckbGameRoomAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGameRoomAcc.ForeColor = System.Drawing.Color.White;
            this.ckbGameRoomAcc.Location = new System.Drawing.Point(21, 81);
            this.ckbGameRoomAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbGameRoomAcc.Name = "ckbGameRoomAcc";
            this.ckbGameRoomAcc.Size = new System.Drawing.Size(235, 27);
            this.ckbGameRoomAcc.TabIndex = 4;
            this.ckbGameRoomAcc.Text = "Game Room Access";
            this.ckbGameRoomAcc.UseVisualStyleBackColor = true;
            // 
            // ckbGymAcc
            // 
            this.ckbGymAcc.AutoSize = true;
            this.ckbGymAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGymAcc.ForeColor = System.Drawing.Color.White;
            this.ckbGymAcc.Location = new System.Drawing.Point(21, 22);
            this.ckbGymAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbGymAcc.Name = "ckbGymAcc";
            this.ckbGymAcc.Size = new System.Drawing.Size(158, 27);
            this.ckbGymAcc.TabIndex = 3;
            this.ckbGymAcc.Text = "Gym Access";
            this.ckbGymAcc.UseVisualStyleBackColor = true;
            // 
            // btnSerAccCon
            // 
            this.btnSerAccCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerAccCon.Location = new System.Drawing.Point(301, 323);
            this.btnSerAccCon.Name = "btnSerAccCon";
            this.btnSerAccCon.Size = new System.Drawing.Size(96, 33);
            this.btnSerAccCon.TabIndex = 21;
            this.btnSerAccCon.Text = "Confirm";
            this.btnSerAccCon.UseVisualStyleBackColor = true;
            this.btnSerAccCon.Click += new System.EventHandler(this.btnSerAccCon_Click);
            // 
            // ServiceAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSerAccCon);
            this.Controls.Add(this.btnSerAccBack);
            this.Controls.Add(this.lbSerAccUID);
            this.Controls.Add(this.lbNameSerAccUID);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ServiceAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceAccess";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceAccess_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerAccBack;
        private System.Windows.Forms.Label lbSerAccUID;
        private System.Windows.Forms.Label lbNameSerAccUID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbMeal;
        private System.Windows.Forms.CheckBox ckbLaundryAcc;
        private System.Windows.Forms.CheckBox ckbGameRoomAcc;
        private System.Windows.Forms.CheckBox ckbGymAcc;
        private System.Windows.Forms.Button btnSerAccCon;
    }
}