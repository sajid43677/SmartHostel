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
    public partial class DemoAdminPage : Form
    {
        public DemoAdminPage()
        {
            InitializeComponent();
        }

        private void btnResSec_Click(object sender, EventArgs e)
        {
            this.btnResSec.ForeColor = Color.FromArgb(56, 182, 255);
            this.btnResSec.BackColor = Color.White;
            this.pnlResSec.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResSecBack_Click(object sender, EventArgs e)
        {
            this.pnlResSec.Visible=false;
            this.btnResSec.BackColor = Color.FromArgb(56, 182, 255);
            this.btnResSec.ForeColor = Color.White;

        }

        private void btnEmpSec_Click(object sender, EventArgs e)
        {
            this.btnAddEmp.ForeColor = Color.FromArgb(56, 182, 255);
            this.btnAddEmp.BackColor = Color.White;
            this.pnlEmpSec.Visible = true;
        }

        private void btnEmpSecBack_Click(object sender, EventArgs e)
        {
            this.pnlEmpSec.Visible = false;
            this.btnEmpSec.BackColor = Color.FromArgb(56, 182, 255);
            this.btnEmpSec.ForeColor = Color.White;
        }
    }
}
