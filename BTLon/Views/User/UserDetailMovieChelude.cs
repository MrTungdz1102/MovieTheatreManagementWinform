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
    public partial class UserDetailMovieChelude : UserControl
    {
        Models.DataProcess Process;
        public UserDetailMovieChelude()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
        }

        public void LoadData()
        {
            string sql = "select * from VìewLC";
            DataTable dt = Process.DataReader(sql);
        }
        private void UserDetailMovieChelude_Load(object sender, EventArgs e)
        {
            LoadData();
    /*
            cbMaPC.DisplayMember = "MaPC";
            cbMaPC.DataSource = Process.DataReader("select MaPC from tblPhongChieu");

            cbLoaiNgay.DisplayMember = "LoaiNgay";
            cbLoaiNgay.DataSource = Process.DataReader("select LoaiNgay from tblGiaTheoNgay");

            cbLoaiGio.DisplayMember = "LoaiGio";
            cbLoaiGio.DataSource = Process.DataReader("select LoaiGio from tblGiaTheoGio");*/

        }
        public void setMaLichChieu(string MaLichChieu)
        {
            this.txtMaLichChieu.Text = MaLichChieu;
        }
        public void setMaPhim(string MaPhim)
        {
            this.txtMaPhim.Text = MaPhim;
        }
   
        public void setMaPC(string MaPC)
        {
            this.cbMaPC.Text = MaPC;
        }
        public void setNgayChieu(string NgayChieu)
        {
            this.txtNgayChieu.Text = NgayChieu;
        }
        public void setGioBD(string GioBD)
        {
            this.txtGioBD.Text = GioBD;
        }
        public void setLoaiNgay (string LoaiNgay)
        {
            this.cbLoaiNgay.Text = LoaiNgay;
        }
        public void setLoaiGio(string LoaiGio)
        {
            this.cbLoaiGio.Text = LoaiGio;
        }
        public void setGiaLC(string GiaLC)
        {
            this.txtGiaLC.Text = GiaLC;
        }
        public void setEnable(bool check)
        {
            txtMaPhim.Enabled = check;
            cbMaPC.Enabled = check;
            txtNgayChieu.Enabled = check;
            txtGioBD.Enabled = check;
            cbLoaiNgay.Enabled = check;
            cbLoaiGio.Enabled = check;
            txtGiaLC.Enabled = check;

        }
        public void UpDateDataBase()
        {
            string update = "update tblLichChieu set MaPhim = N'" + txtMaPhim.Text + "'";
            update += ",MaPC = N'" + cbMaPC.Text + "'";
            update += ",NgayChieu = N'" + txtNgayChieu.Text + "'";
            update += ",GioBD = N'" + txtGioBD.Text + "'";
            update += ",LoaiNgay = N'" + cbLoaiNgay.Text + "'";
            update += ",LoaiGio = N'" + cbLoaiGio.Text + "'";
            update += ",GiaLC = N'" + txtGiaLC.Text + "'";
            update += "where MaLichChieu = N'" + txtMaLichChieu.Text + "';";
            MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.DataChange(update);
        }
    }
}
