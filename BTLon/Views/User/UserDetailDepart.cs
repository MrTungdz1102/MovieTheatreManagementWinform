using BTLon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserDetailDepart : UserControl
    {
        Models.DataProcess Process;
        public UserDetailDepart()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
        }
        private void UserDetailDepart_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataToComBo(string MaPB)
        {
            string sql = "select MaNV from View1 where MaPB = N'" + MaPB + "'";
            DataTable dt = Process.DataReader(sql);
            cbQuanLy.DataSource = dt;
            cbQuanLy.DisplayMember = "MaNV";
        }
        public void setMaPB(string MaPB)
        {
            this.txtMaPB.Text = MaPB;
        }
        public void setTenPB(string TenPB)
        {
            this.txtTenPB.Text = TenPB;
        }
        public void setQuanLy(string MaNV)
        {
            LoadDataToComBo(txtMaPB.Text);
            this.cbQuanLy.Text = MaNV;
        }
        public void setEnable(bool check)
        {
            txtTenPB.Enabled = check;
            cbQuanLy.Enabled = check;
        }
        public void UpDateDataBase()
        {
            string update = "update tblPhongBan set TenPB = N'" + txtTenPB.Text + "'";
            update += ",QuanLy = N'" + cbQuanLy.Text + "'";
            update += "where MaPB = N'" + txtMaPB.Text + "';";
            MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.DataChange(update);
        }

        private void lbMaPB_Click(object sender, EventArgs e)
        {

        }
    }
}
