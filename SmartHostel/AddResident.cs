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
    public partial class AddResident : Form
    {
        private DataAccesss Da { get; set; }
        public AddResident()
        {
            InitializeComponent();
    }

        public AddResident(Form f)
        {
            InitializeComponent();
            this.Da = new DataAccesss();
        }

        private string AutoId()
        {
            string newId = "";
            var sql = "select * from ResidentInfo order by Id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            if(dt.Rows.Count == 0)
            {
                newId = "R-" + (1).ToString("d4") + "-22";
                return newId;
            }

            string lastId = dt.Rows[0][0].ToString();
            string[] temp = lastId.Split('-');
            int no = Convert.ToInt32(temp[1]);
            newId = "R-" + (++no).ToString("d4") + "-22";
            return newId;
        }

        private void btnResidentSave_Click(object sender, EventArgs e)
        {
            string newId = AutoId();
            string sql = "insert into ResidentInfo values('"+newId+"','"+this.txtResidentNameAdd.Text+"','"+this.txtResidentFatherNameAdd.Text+"','"+this.txtResidentMotherNameAdd.Text+"','"+this.txtResidentEmailAdd.Text+"','"+this.txtResidentPhoneAdd.Text+"','"+this.txtResidentOccupationAdd.Text+"','"+this.txtResidentNIDAdd.Text+"');";
            var rowCount = this.Da.ExecuteDMLQuery(sql);

            if (rowCount == 1)
            {
                MessageBox.Show("Employee Added.");
            }
            else
            {
                MessageBox.Show("Employee Add Failed.");
            }

        }

        private void AddResident_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnResidentClear_Click(object sender, EventArgs e)
        {
            this.txtResidentNIDAdd.Clear();
            this.txtResidentOccupationAdd.Clear();
            this.txtResidentNameAdd.Clear();
            this.txtResidentMotherNameAdd.Clear();
            this.txtResidentFatherNameAdd.Clear();
            this.txtResidentEmailAdd.Clear();
            this.txtResidentPhoneAdd.Clear();
        }
    }
}
