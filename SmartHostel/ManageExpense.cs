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
    public partial class ManageExpense : Form
    {
        private DataAccesss Da { get; set; }
        public Form F { get; set; }
        public ManageExpense()
        {
            InitializeComponent();
        }

        public ManageExpense(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;
            loadData();
        }

        private void loadData()
        {
            string sql = "select * from ServiceNameExpense;";
            var ds = Da.ExecuteQuery(sql);
            this.txtManExpGym.Text = ds.Tables[0].Rows[1]["Expense"].ToString();
            this.txtManExpGameRoom.Text = ds.Tables[0].Rows[0]["Expense"].ToString();
            this.txtManExpLaundry.Text = ds.Tables[0].Rows[2]["Expense"].ToString();
            this.txtManExpMeal.Text = ds.Tables[0].Rows[3]["Expense"].ToString();
        }

        private void btnManExpSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from ServiceNameExpense;";
            var ds = Da.ExecuteQuery(sql);
            string gymT = this.txtManExpGym.Text;
            string gameT = this.txtManExpGameRoom.Text;
            string laundryT = this.txtManExpLaundry.Text;
            string mealT = this.txtManExpMeal.Text;
            int gym = int.Parse(gymT);
            int game = int.Parse(gameT);
            int laundry = int.Parse(laundryT);
            int meal = int.Parse(mealT);
            sql = "update ServiceNameExpense set Expense = "+game+" where Service = 'Game';";
            var da = Da.ExecuteDMLQuery(sql);
            sql = "update ServiceNameExpense set Expense = "+gym+" where Service = 'Gym';";
            da = Da.ExecuteDMLQuery(sql);
            sql = "update ServiceNameExpense set Expense = "+laundry+" where Service = 'Laundry';";
            da = Da.ExecuteDMLQuery(sql);
            sql = "update ServiceNameExpense set Expense = "+meal+" where Service = 'Meal';";
            da = Da.ExecuteDMLQuery(sql);

            MessageBox.Show("Data updated");

        }

        private void ManageExpense_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManExpBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F.Visible = true;
        }

        
    }
}
