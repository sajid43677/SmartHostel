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
    public partial class DeleteResident : Form
    {
        private DataAccesss Da { get; set; }
        public DeleteResident()
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        private void showAll()
        {
            this.lblDeleteResidentFatherName.Visible = true;
            this.lblDeleteResidentName.Visible = true;
            this.lblDeleteResidentMotherName.Visible = true;
            this.lblDeleteResidentEmail.Visible = true;
            this.lblDeleteResidentPhone.Visible = true;
            this.lblDeleteResidentOccupation.Visible = true;
            this.lblDeleteResidentNID.Visible = true;
            this.txtDeleteResidentFatherName.Visible = true;
            this.txtDeleteResidentName.Visible = true;
            this.txtDeleteResidentMotherName.Visible = true;
            this.txtDeleteResidentEmail.Visible = true;
            this.txtDeleteResidentPhone.Visible = true;
            this.txtDeleteResidentOccupation.Visible = true;
            this.txtDeleteResidentNID.Visible = true;
            this.btnDeleteResident.Visible = true;
        }

        private void btnDeleteResidentSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ResidentInfo where Id = '"+this.txtDeleteResidentId.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows.Count == 1)
            {
                showAll();
                this.txtDeleteResidentFatherName.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
                this.txtDeleteResidentName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                this.txtDeleteResidentMotherName.Text = ds.Tables[0].Rows[0]["MotherName"].ToString();
                this.txtDeleteResidentEmail.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
                this.txtDeleteResidentPhone.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
                this.txtDeleteResidentOccupation.Text = ds.Tables[0].Rows[0]["Occuption"].ToString();
                this.txtDeleteResidentNID.Text = ds.Tables[0].Rows[0]["NID"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void btnDeleteResident_Click(object sender, EventArgs e)
        {
            string sql = "delete from ResidentInfo where Id = '"+this.txtDeleteResidentId.Text+"';";
            var da = Da.ExecuteDMLQuery(sql);
            sql = "delete from ServiceExpense where Id = '"+this.txtDeleteResidentId.Text+"';";
            da = Da.ExecuteDMLQuery(sql);
            sql = "delete from ServiceAccess where Id = '"+this.txtDeleteResidentId.Text+"';";
            da = Da.ExecuteDMLQuery(sql);
            sql = "delete from ResidentRoomInfo where Id = '"+this.txtDeleteResidentId.Text+"';";
            da = Da.ExecuteDMLQuery(sql);
            MessageBox.Show("Resident Data Removed");
        }

        private void DeleteResident_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
