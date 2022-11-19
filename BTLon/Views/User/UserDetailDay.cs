using BTLon.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserDetailDay : UserControl
    {
        Models.DataProcess Process;
        public UserDetailDay()
        {
            InitializeComponent();
            Process = new Models.DataProcess(); 
        }
        public void LoadData()
        {
            string sql = "select * from tblGiaTheoNgay";
            DataTable dt = Process.DataReader(sql);
        }

        private void UserDetailDay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void setCbLoaiNgay(string LoaiNgay)
        {
            this.txtLoaiNgay.Text = LoaiNgay;
        }
        public void setGiaNgay(string GiaNgay)
        {
            this.txtGiaNgay .Text = GiaNgay;
        }
        public void setMoTa(string MoTa)
        {
            this.txtMoTa.Text = MoTa;
        }
        public void setEnable(bool check)
        {
            txtGiaNgay.Enabled = check;
            txtMoTa.Enabled = check;
        }
        public void UpDateDataBase()
        {
            string update = "update tblGiaTheoNgay set GiaNgay = N'" + txtGiaNgay.Text + "'";
            update += ",MoTa = N'" + txtMoTa.Text + "'";
            update += "where LoaiNgay = N'" + txtLoaiNgay.Text + "';";
            MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.DataChange(update);
        }
    }
}
