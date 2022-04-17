namespace SmartHostel
{
    partial class UpdateEmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeInfo));
            this.pnlUpdateEmp = new System.Windows.Forms.Panel();
            this.btnEmpIdSearch = new System.Windows.Forms.Button();
            this.lblEmpNIDAdd = new System.Windows.Forms.Label();
            this.btnEmpUpdateClear = new System.Windows.Forms.Button();
            this.lblEmpPhoneAdd = new System.Windows.Forms.Label();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.txtEmpNIDUpdate = new System.Windows.Forms.TextBox();
            this.txtEmpPhoneUpdate = new System.Windows.Forms.TextBox();
            this.lblEmpNameAdd = new System.Windows.Forms.Label();
            this.txtEmpNameUpdate = new System.Windows.Forms.TextBox();
            this.pnlUpdateEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdateEmp
            // 
            this.pnlUpdateEmp.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdateEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUpdateEmp.BackgroundImage")));
            this.pnlUpdateEmp.Controls.Add(this.btnEmpIdSearch);
            this.pnlUpdateEmp.Controls.Add(this.lblEmpNIDAdd);
            this.pnlUpdateEmp.Controls.Add(this.btnEmpUpdateClear);
            this.pnlUpdateEmp.Controls.Add(this.lblEmpPhoneAdd);
            this.pnlUpdateEmp.Controls.Add(this.btnEmpUpdate);
            this.pnlUpdateEmp.Controls.Add(this.txtEmpNIDUpdate);
            this.pnlUpdateEmp.Controls.Add(this.txtEmpPhoneUpdate);
            this.pnlUpdateEmp.Controls.Add(this.lblEmpNameAdd);
            this.pnlUpdateEmp.Controls.Add(this.txtEmpNameUpdate);
            this.pnlUpdateEmp.Location = new System.Drawing.Point(0, 2);
            this.pnlUpdateEmp.Name = "pnlUpdateEmp";
            this.pnlUpdateEmp.Size = new System.Drawing.Size(798, 446);
            this.pnlUpdateEmp.TabIndex = 10;
            // 
            // btnEmpIdSearch
            // 
            this.btnEmpIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmpIdSearch.ForeColor = System.Drawing.Color.Black;
            this.btnEmpIdSearch.Location = new System.Drawing.Point(344, 100);
            this.btnEmpIdSearch.Name = "btnEmpIdSearch";
            this.btnEmpIdSearch.Size = new System.Drawing.Size(75, 32);
            this.btnEmpIdSearch.TabIndex = 16;
            this.btnEmpIdSearch.Text = "Search";
            this.btnEmpIdSearch.UseVisualStyleBackColor = false;
            this.btnEmpIdSearch.Click += new System.EventHandler(this.btnEmpIdSearch_Click);
            // 
            // lblEmpNIDAdd
            // 
            this.lblEmpNIDAdd.AutoSize = true;
            this.lblEmpNIDAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpNIDAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNIDAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpNIDAdd.Location = new System.Drawing.Point(172, 25);
            this.lblEmpNIDAdd.Name = "lblEmpNIDAdd";
            this.lblEmpNIDAdd.Size = new System.Drawing.Size(48, 28);
            this.lblEmpNIDAdd.TabIndex = 5;
            this.lblEmpNIDAdd.Text = "NID";
            // 
            // btnEmpUpdateClear
            // 
            this.btnEmpUpdateClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmpUpdateClear.ForeColor = System.Drawing.Color.Black;
            this.btnEmpUpdateClear.Location = new System.Drawing.Point(661, 369);
            this.btnEmpUpdateClear.Name = "btnEmpUpdateClear";
            this.btnEmpUpdateClear.Size = new System.Drawing.Size(75, 32);
            this.btnEmpUpdateClear.TabIndex = 13;
            this.btnEmpUpdateClear.Text = "Clear";
            this.btnEmpUpdateClear.UseVisualStyleBackColor = false;
            this.btnEmpUpdateClear.Click += new System.EventHandler(this.btnEmpUpdateClear_Click);
            // 
            // lblEmpPhoneAdd
            // 
            this.lblEmpPhoneAdd.AutoSize = true;
            this.lblEmpPhoneAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpPhoneAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPhoneAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpPhoneAdd.Location = new System.Drawing.Point(72, 237);
            this.lblEmpPhoneAdd.Name = "lblEmpPhoneAdd";
            this.lblEmpPhoneAdd.Size = new System.Drawing.Size(148, 28);
            this.lblEmpPhoneAdd.TabIndex = 4;
            this.lblEmpPhoneAdd.Text = "Phone Number";
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmpUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnEmpUpdate.Location = new System.Drawing.Point(344, 360);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnEmpUpdate.TabIndex = 12;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Visible = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // txtEmpNIDUpdate
            // 
            this.txtEmpNIDUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpNIDUpdate.Location = new System.Drawing.Point(257, 25);
            this.txtEmpNIDUpdate.Multiline = true;
            this.txtEmpNIDUpdate.Name = "txtEmpNIDUpdate";
            this.txtEmpNIDUpdate.Size = new System.Drawing.Size(259, 36);
            this.txtEmpNIDUpdate.TabIndex = 11;
            // 
            // txtEmpPhoneUpdate
            // 
            this.txtEmpPhoneUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpPhoneUpdate.Location = new System.Drawing.Point(257, 229);
            this.txtEmpPhoneUpdate.Multiline = true;
            this.txtEmpPhoneUpdate.Name = "txtEmpPhoneUpdate";
            this.txtEmpPhoneUpdate.Size = new System.Drawing.Size(259, 36);
            this.txtEmpPhoneUpdate.TabIndex = 10;
            this.txtEmpPhoneUpdate.Visible = false;
            // 
            // lblEmpNameAdd
            // 
            this.lblEmpNameAdd.AutoSize = true;
            this.lblEmpNameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpNameAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpNameAdd.Location = new System.Drawing.Point(154, 173);
            this.lblEmpNameAdd.Name = "lblEmpNameAdd";
            this.lblEmpNameAdd.Size = new System.Drawing.Size(66, 28);
            this.lblEmpNameAdd.TabIndex = 2;
            this.lblEmpNameAdd.Text = "Name";
            // 
            // txtEmpNameUpdate
            // 
            this.txtEmpNameUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpNameUpdate.Location = new System.Drawing.Point(257, 165);
            this.txtEmpNameUpdate.Multiline = true;
            this.txtEmpNameUpdate.Name = "txtEmpNameUpdate";
            this.txtEmpNameUpdate.Size = new System.Drawing.Size(259, 36);
            this.txtEmpNameUpdate.TabIndex = 8;
            this.txtEmpNameUpdate.Visible = false;
            // 
            // UpdateEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pnlUpdateEmp);
            this.Name = "UpdateEmployeeInfo";
            this.Text = "UpdateEmployeeInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateEmployeeInfo_FormClosed);
            this.pnlUpdateEmp.ResumeLayout(false);
            this.pnlUpdateEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateEmp;
        private System.Windows.Forms.Label lblEmpNIDAdd;
        private System.Windows.Forms.Button btnEmpUpdateClear;
        private System.Windows.Forms.Label lblEmpPhoneAdd;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.TextBox txtEmpNIDUpdate;
        private System.Windows.Forms.TextBox txtEmpPhoneUpdate;
        private System.Windows.Forms.Label lblEmpNameAdd;
        private System.Windows.Forms.TextBox txtEmpNameUpdate;
        private System.Windows.Forms.Button btnEmpIdSearch;
    }
}