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
    public partial class ServiceAccess : Form
    {
        public Form F { get; set; }
        private DataAccesss Da { get; set; }
        public string Id { get; set; }
        public ServiceAccess()
        {
            InitializeComponent();
        }

   

        public ServiceAccess(Form f,string id)
        {
            InitializeComponent();
            this.F = f;
            this.Da = new DataAccesss();
            this.Id = id;
            this.lbSerAccUID.Text = Id;
            

        }


        private void btnSerAccBack_Click(object sender, EventArgs e)
        {
            F.Visible = true;
            this.Visible = false;
        }

        private void ServiceAccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSerAccCon_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                DataSet ds = null;
                int cnt = 0;
                int totalExp = 0;
                if (this.ckbGymAcc.Checked)
                {
                    sql = "update ServiceAccess set Gym = 1 where Id = '"+Id+"';";
                    cnt = Da.ExecuteDMLQuery(sql);
                    sql = "select * from ServiceNameExpense where Service = 'Gym';";
                    ds = Da.ExecuteQuery(sql);
                    totalExp += int.Parse(ds.Tables[0].Rows[0]["Expense"].ToString());
                }
                if (this.ckbGameRoomAcc.Checked)
                {
                    sql = "update ServiceAccess set Game = 1 where Id = '"+Id+"';";
                    cnt = Da.ExecuteDMLQuery(sql);
                    sql = "select * from ServiceNameExpense where Service = 'Game';";
                    ds = Da.ExecuteQuery(sql);
                    totalExp += int.Parse(ds.Tables[0].Rows[0]["Expense"].ToString());

                }
                if (this.ckbLaundryAcc.Checked)
                {
                    sql = "update ServiceAccess set Laundry = 1 where Id = '"+Id+"';";
                    cnt = Da.ExecuteDMLQuery(sql);
                    sql = "select * from ServiceNameExpense where Service = 'Laundry';";
                    ds = Da.ExecuteQuery(sql);
                    totalExp += int.Parse(ds.Tables[0].Rows[0]["Expense"].ToString());

                }
                if (this.ckbMeal.Checked)
                {
                    sql = "update ServiceAccess set Meal = 1 where Id = '"+Id+"';";
                    cnt = Da.ExecuteDMLQuery(sql);
                    sql = "select * from ServiceNameExpense where Service = 'Meal';";
                    ds = Da.ExecuteQuery(sql);
                    totalExp += int.Parse(ds.Tables[0].Rows[0]["Expense"].ToString());

                }
                sql = "update ServiceExpense set ServiceExpense = "+totalExp+" where Id = '"+Id+"';";
                var da = Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Services Confirmed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured." + ex.Message.ToString());
            }
        }
    }
}
