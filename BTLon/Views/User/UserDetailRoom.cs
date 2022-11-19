using BTLon.Controls;
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
    public partial class UserDetailRoom : UserControl
    {
        Models.DataProcess Process;
        public UserDetailRoom()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
        }
        private void UserDetailRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string sql = "select * from tblPhongChieu";
            DataTable dt = Process.DataReader(sql);   
        }
        public void setMaPC(string MaPC)
        {
            this.txtMaPC.Text = MaPC;
        }
        public void setTenPC(string TenPC)
        {
            this.txtTenPC.Text = TenPC;
        }
        public void setSoLuongGhe(string SLGhe)
        {
            this.txtSLGhe.Text = SLGhe;
        }
        public void setEnable(bool check)
        {
            txtTenPC.Enabled = check;
            txtSLGhe.Enabled = check;
        }
        public void UpDateDataBase()
        {
            string update = "update tblPhongChieu set TenPC = N'" + txtTenPC.Text + "'";
            update += ",SoLuongGhe = N'" + txtSLGhe.Text + "'";
            update += "where MaPC = N'" + txtMaPC.Text + "';";
            MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.DataChange(update);
        }
    }
}
