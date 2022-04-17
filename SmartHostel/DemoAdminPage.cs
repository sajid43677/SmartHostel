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

        public DemoAdminPage(Form login)
        {
            InitializeComponent();
        }

        private void btnResSec_Click(object sender, EventArgs e)
        {
            this.btnResSec.ForeColor = Color.FromArgb(56, 182, 255);
            this.btnResSec.BackColor = Color.White;
            this.pnlResSec.Visible = true;
            this.pnlEmpSec.Visible = false;
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
            this.btnEmpSec.ForeColor = Color.FromArgb(56, 182, 255);
            this.btnEmpSec.BackColor = Color.White;
            this.pnlEmpSec.Visible = true;
            this.pnlResSec.Visible = false;
        }

        private void btnEmpSecBack_Click(object sender, EventArgs e)
        {
            this.pnlEmpSec.Visible = false;
            this.btnEmpSec.BackColor = Color.FromArgb(56, 182, 255);
            this.btnEmpSec.ForeColor = Color.White;
        }

        private void DemoAdminPage_Load(object sender, EventArgs e)
        {

        }

        private void DemoAdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            new EmployeeInfo(this).Show();
            this.Visible = false;
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            new UpdateEmployeeInfo(this).Show();
            this.Visible=false;
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            new AddResident(this).Show();
            this.Visible = false;
        }
    }
}
