using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHostel
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            this.btnAddResident.ForeColor = Color.FromArgb(56, 182, 255);
            this.btnAddResident.BackColor = Color.White;
            this.pnlAddRes.Visible = true;
        }

        private void pnlAddResBack_Click(object sender, EventArgs e)
        {
            this.btnAddResident.BackColor = Color.FromArgb(56, 182, 255);
            this.btnAddResident.ForeColor = Color.White;
            this.pnlAddRes.Visible = false;
        }
    }
}
