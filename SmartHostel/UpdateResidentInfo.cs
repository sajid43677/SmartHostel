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
    public partial class UpdateResidentInfo : Form
    {
        private DataAccesss Da { get; set; }
        private Form F { get; set; }
        public UpdateResidentInfo()
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        public UpdateResidentInfo(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;
        }

        private void visibleAll()
        {
            this.lblResidentNameUpdate.Visible = true;
            this.lblResidentFatherNameUpdate.Visible = true;
            this.lblResidentMotherNameUpdate.Visible = true;
            this.lblResidentEmailUpdate.Visible = true;
            this.lblResidentPhoneUpdate.Visible = true;
            this.lblResidentOccupationUpdate.Visible = true;
            this.txtResidentNameUpdate.Visible=true;
            this.txtResidentFatherNameUpdate.Visible=true;
            this.txtResidentMotherNameUpdate.Visible=true;
            this.txtResidentEmailUpdate.Visible=true;
            this.txtResidentPhoneUpdate.Visible=true;
            this.txtResidentOccupationUpdate.Visible=true;

            string sql = "select * from ResidentInfo where Id = '"+this.txtSearchResidentId.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            this.txtResidentNameUpdate.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.txtResidentFatherNameUpdate.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
            this.txtResidentMotherNameUpdate.Text = ds.Tables[0].Rows[0]["MotherName"].ToString();
            this.txtResidentEmailUpdate.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
            this.txtResidentPhoneUpdate.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
            this.txtResidentOccupationUpdate.Text = ds.Tables[0].Rows[0]["MotherName"].ToString();
            this.btnResidentUpdate.Visible=true;

        }

        private void UpdateRes()
        {
            string sql = "update ResidentInfo set Name = '"+this.txtResidentNameUpdate.Text+"',FatherName = '"+this.txtResidentFatherNameUpdate.Text+"', MotherName = '"+this.txtResidentMotherNameUpdate.Text+"', EmailId = '"+this.txtResidentEmailUpdate.Text+"', PhoneNumber = '"+this.txtResidentPhoneUpdate.Text+"', Occuption = '"+this.txtResidentOccupationUpdate.Text+"' where Id = '"+this.txtSearchResidentId.Text+"';";
            int cnt = Da.ExecuteDMLQuery(sql);
        }

        private void btnResidentIdSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ResidentInfo where Id = '"+this.txtSearchResidentId.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows.Count == 1)
            {
                visibleAll();
                
            }
            else
            {
                MessageBox.Show("Invalid Id");
            }
            

        }
        
        private void RefreshRes()
        {
            this.txtResidentNameUpdate.Clear();
            this.txtResidentFatherNameUpdate.Clear();
            this.txtResidentMotherNameUpdate.Clear();
            this.txtResidentEmailUpdate.Clear();
            this.txtResidentPhoneUpdate.Clear();
            this.txtResidentOccupationUpdate.Clear();
        }

        private void btnResidentClear_Click(object sender, EventArgs e)
        {
            RefreshRes();
            
        }

        private void UpdateResidentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnResidentUpdate_Click(object sender, EventArgs e)
        {
            UpdateRes();
            MessageBox.Show("Resident Data Updated!");
            RefreshRes();
        }
    }
}
