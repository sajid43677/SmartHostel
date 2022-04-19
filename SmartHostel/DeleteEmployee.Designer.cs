namespace SmartHostel
{
    partial class DeleteEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployee));
            this.pnlDeleteEmployee = new System.Windows.Forms.Panel();
            this.btnDeleteEmployeeSearch = new System.Windows.Forms.Button();
            this.lblDeleteEmployeeNID = new System.Windows.Forms.Label();
            this.lblDeleteEmployeePhone = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.txtDeleteEmployeeNID = new System.Windows.Forms.TextBox();
            this.txtDeleteEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblDeleteEmployeeName = new System.Windows.Forms.Label();
            this.txtDeleteEmployeeName = new System.Windows.Forms.TextBox();
            this.pnlDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeleteEmployee
            // 
            this.pnlDeleteEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeleteEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeleteEmployee.BackgroundImage")));
            this.pnlDeleteEmployee.Controls.Add(this.btnDeleteEmployeeSearch);
            this.pnlDeleteEmployee.Controls.Add(this.lblDeleteEmployeeNID);
            this.pnlDeleteEmployee.Controls.Add(this.lblDeleteEmployeePhone);
            this.pnlDeleteEmployee.Controls.Add(this.btnRemoveEmployee);
            this.pnlDeleteEmployee.Controls.Add(this.txtDeleteEmployeeNID);
            this.pnlDeleteEmployee.Controls.Add(this.txtDeleteEmployeePhone);
            this.pnlDeleteEmployee.Controls.Add(this.lblDeleteEmployeeName);
            this.pnlDeleteEmployee.Controls.Add(this.txtDeleteEmployeeName);
            this.pnlDeleteEmployee.Location = new System.Drawing.Point(1, 4);
            this.pnlDeleteEmployee.Name = "pnlDeleteEmployee";
            this.pnlDeleteEmployee.Size = new System.Drawing.Size(798, 446);
            this.pnlDeleteEmployee.TabIndex = 12;
            // 
            // btnDeleteEmployeeSearch
            // 
            this.btnDeleteEmployeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteEmployeeSearch.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEmployeeSearch.Location = new System.Drawing.Point(359, 90);
            this.btnDeleteEmployeeSearch.Name = "btnDeleteEmployeeSearch";
            this.btnDeleteEmployeeSearch.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteEmployeeSearch.TabIndex = 16;
            this.btnDeleteEmployeeSearch.Text = "Search";
            this.btnDeleteEmployeeSearch.UseVisualStyleBackColor = false;
            this.btnDeleteEmployeeSearch.Click += new System.EventHandler(this.btnDeleteEmployeeSearch_Click);
            // 
            // lblDeleteEmployeeNID
            // 
            this.lblDeleteEmployeeNID.AutoSize = true;
            this.lblDeleteEmployeeNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDeleteEmployeeNID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmployeeNID.ForeColor = System.Drawing.Color.Black;
            this.lblDeleteEmployeeNID.Location = new System.Drawing.Point(199, 48);
            this.lblDeleteEmployeeNID.Name = "lblDeleteEmployeeNID";
            this.lblDeleteEmployeeNID.Size = new System.Drawing.Size(48, 28);
            this.lblDeleteEmployeeNID.TabIndex = 5;
            this.lblDeleteEmployeeNID.Text = "NID";
            // 
            // lblDeleteEmployeePhone
            // 
            this.lblDeleteEmployeePhone.AutoSize = true;
            this.lblDeleteEmployeePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDeleteEmployeePhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmployeePhone.ForeColor = System.Drawing.Color.Black;
            this.lblDeleteEmployeePhone.Location = new System.Drawing.Point(99, 261);
            this.lblDeleteEmployeePhone.Name = "lblDeleteEmployeePhone";
            this.lblDeleteEmployeePhone.Size = new System.Drawing.Size(148, 28);
            this.lblDeleteEmployeePhone.TabIndex = 4;
            this.lblDeleteEmployeePhone.Text = "Phone Number";
            this.lblDeleteEmployeePhone.Visible = false;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(324, 328);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(142, 38);
            this.btnRemoveEmployee.TabIndex = 12;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Visible = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // txtDeleteEmployeeNID
            // 
            this.txtDeleteEmployeeNID.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDeleteEmployeeNID.Location = new System.Drawing.Point(271, 40);
            this.txtDeleteEmployeeNID.Multiline = true;
            this.txtDeleteEmployeeNID.Name = "txtDeleteEmployeeNID";
            this.txtDeleteEmployeeNID.Size = new System.Drawing.Size(259, 36);
            this.txtDeleteEmployeeNID.TabIndex = 11;
            // 
            // txtDeleteEmployeePhone
            // 
            this.txtDeleteEmployeePhone.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDeleteEmployeePhone.Location = new System.Drawing.Point(271, 253);
            this.txtDeleteEmployeePhone.Multiline = true;
            this.txtDeleteEmployeePhone.Name = "txtDeleteEmployeePhone";
            this.txtDeleteEmployeePhone.ReadOnly = true;
            this.txtDeleteEmployeePhone.Size = new System.Drawing.Size(259, 36);
            this.txtDeleteEmployeePhone.TabIndex = 10;
            this.txtDeleteEmployeePhone.Visible = false;
            // 
            // lblDeleteEmployeeName
            // 
            this.lblDeleteEmployeeName.AutoSize = true;
            this.lblDeleteEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDeleteEmployeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblDeleteEmployeeName.Location = new System.Drawing.Point(181, 197);
            this.lblDeleteEmployeeName.Name = "lblDeleteEmployeeName";
            this.lblDeleteEmployeeName.Size = new System.Drawing.Size(66, 28);
            this.lblDeleteEmployeeName.TabIndex = 2;
            this.lblDeleteEmployeeName.Text = "Name";
            this.lblDeleteEmployeeName.Visible = false;
            // 
            // txtDeleteEmployeeName
            // 
            this.txtDeleteEmployeeName.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDeleteEmployeeName.Location = new System.Drawing.Point(271, 189);
            this.txtDeleteEmployeeName.Multiline = true;
            this.txtDeleteEmployeeName.Name = "txtDeleteEmployeeName";
            this.txtDeleteEmployeeName.ReadOnly = true;
            this.txtDeleteEmployeeName.Size = new System.Drawing.Size(259, 36);
            this.txtDeleteEmployeeName.TabIndex = 8;
            this.txtDeleteEmployeeName.Visible = false;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pnlDeleteEmployee);
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteEmployee_FormClosed);
            this.pnlDeleteEmployee.ResumeLayout(false);
            this.pnlDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteEmployeeSearch;
        private System.Windows.Forms.Label lblDeleteEmployeeNID;
        private System.Windows.Forms.Label lblDeleteEmployeePhone;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.TextBox txtDeleteEmployeeNID;
        private System.Windows.Forms.TextBox txtDeleteEmployeePhone;
        private System.Windows.Forms.Label lblDeleteEmployeeName;
        private System.Windows.Forms.TextBox txtDeleteEmployeeName;
    }
}