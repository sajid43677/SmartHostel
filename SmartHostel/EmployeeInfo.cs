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
    public partial class EmployeeInfo : Form
    {
        private DataAccesss Da { get; set; }
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        public EmployeeInfo(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        private void txtEmpNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into WorkEmployee values('"+this.txtEmpNameAdd.Text.ToString()+"','"+this.txtEmpPhoneAdd.Text.ToString()+"','"+this.txtEmpNIDAdd.Text.ToString()+"');";
            var rowCount = this.Da.ExecuteDMLQuery(sql);

            if (rowCount == 1)
            {
                MessageBox.Show("Employee Added.");
            }
            else
            {
                MessageBox.Show("Employee Add Failed.");
            }
        }

        private void EmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            this.txtEmpNameAdd.Clear();
            this.txtEmpPhoneAdd.Clear();
            this.txtEmpNIDAdd.Clear();
        }
    }
}
