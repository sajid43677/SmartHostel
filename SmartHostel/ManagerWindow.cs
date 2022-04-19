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
    public partial class ManagerWindow : Form
    {
        private DataAccesss Da { get; set; }
        private Form F { get; set; }
        public ManagerWindow()
        {
            InitializeComponent();
        }

        public ManagerWindow(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;    
        }

        private void btnManWinLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F.Visible = true;
        }

        private void ManagerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManWinSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ResidentInfo where Id = '"+this.txtManWinUID.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            while(ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }
            this.lbManWinName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.lbManWinPhnNUm.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
            this.btnServiceAccess.Visible = true;
            this.btnMonthlyExpence.Visible = true;
        }

        private void btnServiceAccess_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            new ServiceAccess(this,txtManWinUID.Text.ToString()).Show();
        }

        private void btnMonthlyExpence_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            new ShowMonthlyExpense(this, txtManWinUID.Text.ToString()).Show();
        }
    }
}
