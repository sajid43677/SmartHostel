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
    public partial class Login : Form
    {
        private DataAccesss Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from EmployeeInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtUserPass.Text + "';";
                var ds = Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Wellcome");
                    if (ds.Tables[0].Rows[0][5].ToString() == "admin")
                    {
                        new DemoAdminPage(this).Show();
                        this.Visible = false;
                    }
                    else
                    {
                        new ManagerWindow(this).Show();
                        this.Visible=false;
                    }

                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured." + ex.Message.ToString());
            }
            

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new Register(this).Show();
            this.Visible = false;
        }
    }
}
