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
    public partial class UpdateEmployeeInfo : Form
    {
        private DataAccesss Da { get; set; }
        private DataSet ds;
        public UpdateEmployeeInfo()
        {
            InitializeComponent();
        }

        public UpdateEmployeeInfo(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        private void btnEmpIdSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from WorkEmployee where NID = '"+this.txtEmpNIDUpdate.Text+"';";
            ds = Da.ExecuteQuery(sql);
            int cnt = ds.Tables[0].Rows.Count;
            while(cnt == 0)
            {
                MessageBox.Show("Employee Not Found! Please Try again!");
                return;
            }

            if(cnt > 0)
            {
                MessageBox.Show("Employee Found! Update Info!");
                this.txtEmpNameUpdate.Visible = true;
                this.txtEmpPhoneUpdate.Visible = true;
                this.btnEmpUpdate.Visible = true;
            }
        }

        private void UpdateEmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showDataRes()
        {
            string sql = "select * from WorkEmployee where NID = '"+this.txtEmpNIDUpdate+"';";
            var ds = Da.ExecuteQuery(sql);
            this.txtEmpNIDUpdate.ReadOnly = true;
            this.txtEmpNameUpdate.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.txtEmpPhoneUpdate.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            showDataRes();
            string sql = "update WorkEmployee set PhoneNumber = '"+this.txtEmpPhoneUpdate.Text+"',Name = '"+this.txtEmpNameUpdate.Text+"' where NID = '"+this.txtEmpNIDUpdate.Text+"'; ";
            int cnt = Da.ExecuteDMLQuery(sql);
            if(cnt > 0)
            {
                MessageBox.Show("Employee Data Updated");
            }
            else
            {
                MessageBox.Show("Error Found");
            }
        }

        private void btnEmpUpdateClear_Click(object sender, EventArgs e)
        {
            this.txtEmpNameUpdate.Clear();
            this.txtEmpNIDUpdate.Clear();
            this.txtEmpPhoneUpdate.Clear();
            this.txtEmpNameUpdate.Visible = false;
            this.txtEmpPhoneUpdate.Visible = false;
            this.btnEmpUpdate.Visible = false;

        }
    }
}
