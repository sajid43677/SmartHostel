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
    public partial class ShowMonthlyExpense : Form
    {
        private DataAccesss Da { get; set; }
        private Form F { get; set; }
        private string Id { get; set; }
        public ShowMonthlyExpense()
        {
            InitializeComponent();
        }

        public ShowMonthlyExpense(Form f, string id)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;
            this.Id = id;
            loadData();
        }

        private void showService(string sql)
        {
            var ds = Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows[0]["Gym"].ToString() == "1")
            {
                this.lbResGymShow.Text =  "Yes";
            }
            else
            {
                this.lbResGymShow.Text =  "No";
            }
            if (ds.Tables[0].Rows[0]["Game"].ToString() == "1")
            {
                this.lbResGameShow.Text =  "Yes";
            }
            else
            {
                this.lbResGameShow.Text =  "No";
            }
            if (ds.Tables[0].Rows[0]["Laundry"].ToString() == "1")
            {
                this.lbResLaundryShow.Text =  "Yes";
            }
            else
            {
                this.lbResLaundryShow.Text =  "No";
            }
            if (ds.Tables[0].Rows[0]["Meal"].ToString() == "1")
            {
                this.lbResMealShow.Text =  "Yes";
            }
            else
            {
                this.lbResMealShow.Text =  "No";
            }
        }

        private void loadData()
        {
            this.lbResIdShow.Text = Id;
            string sql = "select * from ResidentInfo where Id = '"+Id+"';";
            var ds = Da.ExecuteQuery(sql);
            this.lbResNameShow.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.lbResPhoneShow.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
            sql = "select * from ServiceExpense where Id = '"+Id+"';";
            ds = Da.ExecuteQuery(sql);
            this.lbResServiceBill.Text = ds.Tables[0].Rows[0]["ServiceExpense"].ToString();
            sql = "select * from ResidentRoomInfo where Id = '"+Id+"';";
            ds = Da.ExecuteQuery(sql);
            this.lbResRentsShow.Text = ds.Tables[0].Rows[0]["Expense"].ToString();
            sql = "select * from ServiceAccess where Id = '"+Id+"';";
            showService(sql);
            int totExp = int.Parse(this.lbResRentsShow.Text) + int.Parse(this.lbResServiceBill.Text);
            this.lbResTotBill.Text = totExp.ToString();

        }

        private void ShowMonthlyExpense_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowMonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F.Visible = true;
        }
    }
}
