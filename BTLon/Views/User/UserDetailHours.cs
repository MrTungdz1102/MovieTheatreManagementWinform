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
    public partial class UserDetailHours : UserControl
    {
        Models.DataProcess Process;
        public UserDetailHours()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
        }

        public void LoadData()
        {
            string sql = "select * from tblGiaTheoGio";
            DataTable dt = Process.DataReader(sql);
        }

        private void UserDetailHours_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void setCbLoaiGio(string LoaiGio)
        {
            this.txtLoaiGio.Text = LoaiGio;
        }
        public void setGiaGio(string GiaGio)
        {
            this.txtGiaGio.Text = GiaGio;
        }
        public void setMoTa(string MoTa)
        {
            this.txtMoTa.Text = MoTa;
        }
        public void setEnable(bool check)
        {
            txtGiaGio.Enabled = check;
            txtMoTa.Enabled = check;
        }
        public void UpDateDataBase()
        {
            string update = "update tblGiaTheoGio set GiaGio = N'" + txtGiaGio.Text + "'";
            update += ",MoTa = N'" + txtMoTa.Text + "'";
            update += "where LoaiGio = N'" + txtLoaiGio.Text + "';";
            MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.DataChange(update);
        }
    }
}
