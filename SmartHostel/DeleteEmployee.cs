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
    public partial class DeleteEmployee : Form
    {
        private DataAccesss Da { get; set; }
        private Form F { get; set; }
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        public DeleteEmployee(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;

        }

        private void showData()
        {
            this.lblDeleteEmployeeName.Visible = true;
            this.lblDeleteEmployeePhone.Visible = true;
            this.txtDeleteEmployeeName.Visible = true;
            this.txtDeleteEmployeePhone.Visible = true;
            this.btnRemoveEmployee.Visible = true;


        }

        private void btnDeleteEmployeeSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from WorkEmployee where NID = '"+this.txtDeleteEmployeeNID.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows.Count == 1)
            {
                showData();
                this.txtDeleteEmployeeName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                this.txtDeleteEmployeePhone.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();

            }
            else
            {
                MessageBox.Show("Invalid NID!");
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            string sql = "delete from WorkEmployee where NID = '"+this.txtDeleteEmployeeNID.Text+"';";
            var ds = Da.ExecuteDMLQuery(sql);
            MessageBox.Show("Employee Data Removed");
        }

        private void DeleteEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
