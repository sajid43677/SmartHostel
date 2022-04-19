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
    public partial class Register : Form
    {
        private DataAccesss Da { get; set; }
        private Form F { get; set; }

        public Register()
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        public Register(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;
        }

        private string AutoId()
        {
            string newId = "";
            var sql = "select * from EmployeeInfo order by Id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            if (dt.Rows.Count == 0)
            {
                newId = "E-" + (1).ToString("d4") + "-22";
                return newId;
            }

            string lastId = dt.Rows[0][0].ToString();
            string[] temp = lastId.Split('-');
            int no = Convert.ToInt32(temp[1]);
            newId = "E-" + (++no).ToString("d4") + "-22";
            return newId;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string newId = AutoId();
                string sql = "insert into EmployeeInfo values('"+newId+"','"+this.txtRegisterName.Text+"','"+this.txtRegisterPassword.Text+"','"+this.txtRegisterPhone.Text+"','"+this.txtRegisterNID.Text+"','"+this.cmbRegisterRole.Text.ToLower()+"');";
                var rowCount = this.Da.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                {

                    MessageBox.Show("Registration Successful.\nLogin Id: "+ newId);
                }
                else
                {
                    MessageBox.Show("Resident Add Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured." + ex.Message.ToString());
            }

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F.Visible = true;
        }
    }
}
