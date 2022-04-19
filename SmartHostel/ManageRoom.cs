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
    public partial class ManageRoom : Form
    {
        private DataAccesss Da { get; set; }
        public Form F { get; set; }
        public ManageRoom()
        {
            InitializeComponent();
        }

        public ManageRoom(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
            this.F = f;
        }

        private void LoadData()
        {
            string sql = "select * from ResidentInfo where Id = '"+this.txtManageRoomId.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            this.lblManageRoomShowName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            this.lblManageRoomShowPhone.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
            this.txtManageRoomId.ReadOnly = true;
        }

        private void btnManageRoomSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ResidentInfo where Id = '"+this.txtManageRoomId.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows.Count == 1)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Invalid Id");
            }
        }

        private void Refresh()
        {
            this.txtManageRoomId.Clear();
            this.txtManageRoomId.ReadOnly = false;
            this.lblManageRoomShowName.Text = "........";
            this.lblManageRoomShowPhone.Text = "..........";
        }

        private void btnManageRoomSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from RoomType where RoomType = '"+this.cmbRoomType.Text+"';";
            var ds = Da.ExecuteQuery(sql);
            string temp = ds.Tables[0].Rows[0]["Expense"].ToString();
            int expense = int.Parse(temp);
            sql = "update ResidentRoomInfo set RoomType = '"+this.cmbRoomType.Text+"', Expense = "+expense+" where Id = '"+this.txtManageRoomId.Text+"';";
            var da = Da.ExecuteDMLQuery(sql);
            MessageBox.Show("Room Alloted for "+ this.txtManageRoomId.Text);
            Refresh();
        }

        private void btnManageRoomBack_Click(object sender, EventArgs e)
        {
            F.Visible = true;
            this.Visible = false;
        }

        private void ManageRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
