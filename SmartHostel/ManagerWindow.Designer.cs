namespace SmartHostel
{
    partial class ManagerWindow
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
            this.btnManWinLogout = new System.Windows.Forms.Button();
            this.pnlManWin1 = new System.Windows.Forms.Panel();
            this.pnlManWin2 = new System.Windows.Forms.Panel();
            this.lbManWinName = new System.Windows.Forms.Label();
            this.lbManWinPhnNUm = new System.Windows.Forms.Label();
            this.lbNameManWin = new System.Windows.Forms.Label();
            this.lbPhnumManWin = new System.Windows.Forms.Label();
            this.btnMonthlyExpence = new System.Windows.Forms.Button();
            this.btnServiceAccess = new System.Windows.Forms.Button();
            this.btnManWinSearch = new System.Windows.Forms.Button();
            this.lblManWinRes = new System.Windows.Forms.Label();
            this.txtManWinUID = new System.Windows.Forms.TextBox();
            this.pnlManWin1.SuspendLayout();
            this.pnlManWin2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManWinLogout
            // 
            this.btnManWinLogout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManWinLogout.Location = new System.Drawing.Point(12, 558);
            this.btnManWinLogout.Name = "btnManWinLogout";
            this.btnManWinLogout.Size = new System.Drawing.Size(99, 38);
            this.btnManWinLogout.TabIndex = 19;
            this.btnManWinLogout.Text = "Logout";
            this.btnManWinLogout.UseVisualStyleBackColor = true;
            this.btnManWinLogout.Click += new System.EventHandler(this.btnManWinLogout_Click);
            // 
            // pnlManWin1
            // 
            this.pnlManWin1.Controls.Add(this.pnlManWin2);
            this.pnlManWin1.Controls.Add(this.btnMonthlyExpence);
            this.pnlManWin1.Controls.Add(this.btnServiceAccess);
            this.pnlManWin1.Controls.Add(this.btnManWinSearch);
            this.pnlManWin1.Controls.Add(this.lblManWinRes);
            this.pnlManWin1.Controls.Add(this.txtManWinUID);
            this.pnlManWin1.Location = new System.Drawing.Point(175, 31);
            this.pnlManWin1.Name = "pnlManWin1";
            this.pnlManWin1.Size = new System.Drawing.Size(685, 502);
            this.pnlManWin1.TabIndex = 18;
            // 
            // pnlManWin2
            // 
            this.pnlManWin2.BackColor = System.Drawing.Color.Pink;
            this.pnlManWin2.Controls.Add(this.lbManWinName);
            this.pnlManWin2.Controls.Add(this.lbManWinPhnNUm);
            this.pnlManWin2.Controls.Add(this.lbNameManWin);
            this.pnlManWin2.Controls.Add(this.lbPhnumManWin);
            this.pnlManWin2.Location = new System.Drawing.Point(102, 168);
            this.pnlManWin2.Name = "pnlManWin2";
            this.pnlManWin2.Size = new System.Drawing.Size(475, 248);
            this.pnlManWin2.TabIndex = 15;
            // 
            // lbManWinName
            // 
            this.lbManWinName.AutoSize = true;
            this.lbManWinName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManWinName.Location = new System.Drawing.Point(237, 71);
            this.lbManWinName.Name = "lbManWinName";
            this.lbManWinName.Size = new System.Drawing.Size(125, 21);
            this.lbManWinName.TabIndex = 14;
            this.lbManWinName.Text = ".......................";
            // 
            // lbManWinPhnNUm
            // 
            this.lbManWinPhnNUm.AutoSize = true;
            this.lbManWinPhnNUm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManWinPhnNUm.Location = new System.Drawing.Point(237, 141);
            this.lbManWinPhnNUm.Name = "lbManWinPhnNUm";
            this.lbManWinPhnNUm.Size = new System.Drawing.Size(125, 21);
            this.lbManWinPhnNUm.TabIndex = 13;
            this.lbManWinPhnNUm.Text = ".......................";
            // 
            // lbNameManWin
            // 
            this.lbNameManWin.AutoSize = true;
            this.lbNameManWin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameManWin.Location = new System.Drawing.Point(68, 71);
            this.lbNameManWin.Name = "lbNameManWin";
            this.lbNameManWin.Size = new System.Drawing.Size(61, 21);
            this.lbNameManWin.TabIndex = 2;
            this.lbNameManWin.Text = "Name";
            // 
            // lbPhnumManWin
            // 
            this.lbPhnumManWin.AutoSize = true;
            this.lbPhnumManWin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhnumManWin.Location = new System.Drawing.Point(68, 141);
            this.lbPhnumManWin.Name = "lbPhnumManWin";
            this.lbPhnumManWin.Size = new System.Drawing.Size(133, 21);
            this.lbPhnumManWin.TabIndex = 1;
            this.lbPhnumManWin.Text = "Phone Number";
            // 
            // btnMonthlyExpence
            // 
            this.btnMonthlyExpence.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyExpence.Location = new System.Drawing.Point(365, 441);
            this.btnMonthlyExpence.Name = "btnMonthlyExpence";
            this.btnMonthlyExpence.Size = new System.Drawing.Size(212, 38);
            this.btnMonthlyExpence.TabIndex = 12;
            this.btnMonthlyExpence.Text = "Monthly Expence";
            this.btnMonthlyExpence.UseVisualStyleBackColor = true;
            this.btnMonthlyExpence.Visible = false;
            // 
            // btnServiceAccess
            // 
            this.btnServiceAccess.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAccess.Location = new System.Drawing.Point(102, 441);
            this.btnServiceAccess.Name = "btnServiceAccess";
            this.btnServiceAccess.Size = new System.Drawing.Size(212, 38);
            this.btnServiceAccess.TabIndex = 11;
            this.btnServiceAccess.Text = "Service Access";
            this.btnServiceAccess.UseVisualStyleBackColor = true;
            this.btnServiceAccess.Visible = false;
            this.btnServiceAccess.Click += new System.EventHandler(this.btnServiceAccess_Click);
            // 
            // btnManWinSearch
            // 
            this.btnManWinSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManWinSearch.Location = new System.Drawing.Point(290, 105);
            this.btnManWinSearch.Name = "btnManWinSearch";
            this.btnManWinSearch.Size = new System.Drawing.Size(99, 38);
            this.btnManWinSearch.TabIndex = 9;
            this.btnManWinSearch.Text = "Search";
            this.btnManWinSearch.UseVisualStyleBackColor = true;
            this.btnManWinSearch.Click += new System.EventHandler(this.btnManWinSearch_Click);
            // 
            // lblManWinRes
            // 
            this.lblManWinRes.AutoSize = true;
            this.lblManWinRes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManWinRes.ForeColor = System.Drawing.Color.White;
            this.lblManWinRes.Location = new System.Drawing.Point(179, 16);
            this.lblManWinRes.Name = "lblManWinRes";
            this.lblManWinRes.Size = new System.Drawing.Size(144, 19);
            this.lblManWinRes.TabIndex = 8;
            this.lblManWinRes.Text = "Enter Resident ID";
            // 
            // txtManWinUID
            // 
            this.txtManWinUID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManWinUID.Location = new System.Drawing.Point(183, 43);
            this.txtManWinUID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtManWinUID.Name = "txtManWinUID";
            this.txtManWinUID.Size = new System.Drawing.Size(312, 32);
            this.txtManWinUID.TabIndex = 7;
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(977, 608);
            this.Controls.Add(this.btnManWinLogout);
            this.Controls.Add(this.pnlManWin1);
            this.Name = "ManagerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerWindow_FormClosed);
            this.pnlManWin1.ResumeLayout(false);
            this.pnlManWin1.PerformLayout();
            this.pnlManWin2.ResumeLayout(false);
            this.pnlManWin2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManWinLogout;
        private System.Windows.Forms.Panel pnlManWin1;
        private System.Windows.Forms.Panel pnlManWin2;
        private System.Windows.Forms.Label lbManWinName;
        private System.Windows.Forms.Label lbManWinPhnNUm;
        private System.Windows.Forms.Label lbNameManWin;
        private System.Windows.Forms.Label lbPhnumManWin;
        private System.Windows.Forms.Button btnMonthlyExpence;
        private System.Windows.Forms.Button btnServiceAccess;
        private System.Windows.Forms.Button btnManWinSearch;
        private System.Windows.Forms.Label lblManWinRes;
        private System.Windows.Forms.TextBox txtManWinUID;
    }
}