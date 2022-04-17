namespace SmartHostel
{
    partial class EmplyeeInfoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmplyeeInfoPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpNIDAdd = new System.Windows.Forms.Label();
            this.lblEmpPhoneAdd = new System.Windows.Forms.Label();
            this.lblEmpPasswordAdd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmpClear = new System.Windows.Forms.Button();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.txtEmpNIDAdd = new System.Windows.Forms.TextBox();
            this.txtEmpPhoneAdd = new System.Windows.Forms.TextBox();
            this.lblEmpNameAdd = new System.Windows.Forms.Label();
            this.txtEmpPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtEmpNameAdd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 449);
            this.panel1.TabIndex = 0;
            // 
            // lblEmpNIDAdd
            // 
            this.lblEmpNIDAdd.AutoSize = true;
            this.lblEmpNIDAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpNIDAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNIDAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpNIDAdd.Location = new System.Drawing.Point(201, 234);
            this.lblEmpNIDAdd.Name = "lblEmpNIDAdd";
            this.lblEmpNIDAdd.Size = new System.Drawing.Size(48, 28);
            this.lblEmpNIDAdd.TabIndex = 5;
            this.lblEmpNIDAdd.Text = "NID";
            // 
            // lblEmpPhoneAdd
            // 
            this.lblEmpPhoneAdd.AutoSize = true;
            this.lblEmpPhoneAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpPhoneAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPhoneAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpPhoneAdd.Location = new System.Drawing.Point(101, 180);
            this.lblEmpPhoneAdd.Name = "lblEmpPhoneAdd";
            this.lblEmpPhoneAdd.Size = new System.Drawing.Size(148, 28);
            this.lblEmpPhoneAdd.TabIndex = 4;
            this.lblEmpPhoneAdd.Text = "Phone Number";
            // 
            // lblEmpPasswordAdd
            // 
            this.lblEmpPasswordAdd.AutoSize = true;
            this.lblEmpPasswordAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpPasswordAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPasswordAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpPasswordAdd.Location = new System.Drawing.Point(153, 121);
            this.lblEmpPasswordAdd.Name = "lblEmpPasswordAdd";
            this.lblEmpPasswordAdd.Size = new System.Drawing.Size(96, 28);
            this.lblEmpPasswordAdd.TabIndex = 3;
            this.lblEmpPasswordAdd.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblEmpNIDAdd);
            this.panel2.Controls.Add(this.btnEmpClear);
            this.panel2.Controls.Add(this.lblEmpPhoneAdd);
            this.panel2.Controls.Add(this.btnEmpSave);
            this.panel2.Controls.Add(this.lblEmpPasswordAdd);
            this.panel2.Controls.Add(this.txtEmpNIDAdd);
            this.panel2.Controls.Add(this.txtEmpPhoneAdd);
            this.panel2.Controls.Add(this.lblEmpNameAdd);
            this.panel2.Controls.Add(this.txtEmpPasswordAdd);
            this.panel2.Controls.Add(this.txtEmpNameAdd);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 446);
            this.panel2.TabIndex = 7;
            // 
            // btnEmpClear
            // 
            this.btnEmpClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmpClear.ForeColor = System.Drawing.Color.Black;
            this.btnEmpClear.Location = new System.Drawing.Point(661, 369);
            this.btnEmpClear.Name = "btnEmpClear";
            this.btnEmpClear.Size = new System.Drawing.Size(75, 32);
            this.btnEmpClear.TabIndex = 13;
            this.btnEmpClear.Text = "Clear";
            this.btnEmpClear.UseVisualStyleBackColor = false;
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmpSave.ForeColor = System.Drawing.Color.Black;
            this.btnEmpSave.Location = new System.Drawing.Point(373, 288);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(75, 32);
            this.btnEmpSave.TabIndex = 12;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.UseVisualStyleBackColor = false;
            // 
            // txtEmpNIDAdd
            // 
            this.txtEmpNIDAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpNIDAdd.Location = new System.Drawing.Point(287, 226);
            this.txtEmpNIDAdd.Multiline = true;
            this.txtEmpNIDAdd.Name = "txtEmpNIDAdd";
            this.txtEmpNIDAdd.Size = new System.Drawing.Size(259, 36);
            this.txtEmpNIDAdd.TabIndex = 11;
            // 
            // txtEmpPhoneAdd
            // 
            this.txtEmpPhoneAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpPhoneAdd.Location = new System.Drawing.Point(286, 172);
            this.txtEmpPhoneAdd.Multiline = true;
            this.txtEmpPhoneAdd.Name = "txtEmpPhoneAdd";
            this.txtEmpPhoneAdd.Size = new System.Drawing.Size(259, 36);
            this.txtEmpPhoneAdd.TabIndex = 10;
            // 
            // lblEmpNameAdd
            // 
            this.lblEmpNameAdd.AutoSize = true;
            this.lblEmpNameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblEmpNameAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameAdd.ForeColor = System.Drawing.Color.Black;
            this.lblEmpNameAdd.Location = new System.Drawing.Point(183, 67);
            this.lblEmpNameAdd.Name = "lblEmpNameAdd";
            this.lblEmpNameAdd.Size = new System.Drawing.Size(66, 28);
            this.lblEmpNameAdd.TabIndex = 2;
            this.lblEmpNameAdd.Text = "Name";
            // 
            // txtEmpPasswordAdd
            // 
            this.txtEmpPasswordAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpPasswordAdd.Location = new System.Drawing.Point(286, 113);
            this.txtEmpPasswordAdd.Multiline = true;
            this.txtEmpPasswordAdd.Name = "txtEmpPasswordAdd";
            this.txtEmpPasswordAdd.Size = new System.Drawing.Size(259, 36);
            this.txtEmpPasswordAdd.TabIndex = 9;
            // 
            // txtEmpNameAdd
            // 
            this.txtEmpNameAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmpNameAdd.Location = new System.Drawing.Point(286, 59);
            this.txtEmpNameAdd.Multiline = true;
            this.txtEmpNameAdd.Name = "txtEmpNameAdd";
            this.txtEmpNameAdd.Size = new System.Drawing.Size(259, 36);
            this.txtEmpNameAdd.TabIndex = 8;
            // 
            // EmplyeeInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmplyeeInfoPage";
            this.Text = "Employee Info";
            this.Load += new System.EventHandler(this.EmplyeeInfoPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpNIDAdd;
        private System.Windows.Forms.Label lblEmpPhoneAdd;
        private System.Windows.Forms.Label lblEmpPasswordAdd;
        private System.Windows.Forms.Label lblEmpNameAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmpNIDAdd;
        private System.Windows.Forms.TextBox txtEmpPhoneAdd;
        private System.Windows.Forms.TextBox txtEmpPasswordAdd;
        private System.Windows.Forms.TextBox txtEmpNameAdd;
        private System.Windows.Forms.Button btnEmpClear;
        private System.Windows.Forms.Button btnEmpSave;
    }
}