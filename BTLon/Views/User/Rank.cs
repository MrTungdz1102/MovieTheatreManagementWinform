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
    public partial class Rank : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        public Rank()
        {
            InitializeComponent();
        }
        private void Rank_Load(object sender, EventArgs e)
        {
            cbbThongKe.Items.Add("Theo tháng");
            cbbThongKe.Items.Add("Theo năm");
            cbbNam.Items.Add("Năm 2021");
            cbbNam.Items.Add("Năm 2022");
            cbbThang.Items.Add("Tháng 1");
            cbbThang.Items.Add("Tháng 2");
            cbbThang.Items.Add("Tháng 3");
            cbbThang.Items.Add("Tháng 4");
            cbbThang.Items.Add("Tháng 5");
            cbbThang.Items.Add("Tháng 6");
            cbbThang.Items.Add("Tháng 7");
            cbbThang.Items.Add("Tháng 8");
            cbbThang.Items.Add("Tháng 9");
            cbbThang.Items.Add("Tháng 10");
            cbbThang.Items.Add("Tháng 11");
            cbbThang.Items.Add("Tháng 12");
            //KH
            dgvKH.DataSource = data.DataReader("select * from Top5KHThang(2021,10)");
            chartRank.DataSource = data.DataReader("select MaKH, ChiTieu from Top5KHThang(2021,10)");
            chartRank.Series["ChiTieu"].Points.Clear();
            chartRank.Series["ChiTieu"].XValueMember = "MaKH";
            chartRank.Series["ChiTieu"].YValueMembers = "ChiTieu";
            refresh();
            //Ten + chi tiêu top 1
            DataTable dttk = data.DataReader("select * from Top1KHThang(2021,10)");
            for (int i = 0; i < dttk.Rows.Count; i++)
            {
                lblTenKH.Text = dttk.Rows[i]["TenKH"].ToString();
                lblChiTieuKH.Text = dttk.Rows[i]["ChiTieu"].ToString();
            }
            dgvNV.DataSource = data.DataReader("select * from Top5NVThang(2021,10)");
            chartRank2.DataSource = data.DataReader("select MaNV, DoanhSo from Top5NVThang(2021,10)");
            chartRank2.Series["DoanhSo"].Points.Clear();
            chartRank2.Series["DoanhSo"].XValueMember = "MaNV";
            chartRank2.Series["DoanhSo"].YValueMembers = "DoanhSo";
            //Ten + doanh so top 1
            DataTable dttk2 = data.DataReader("select * from Top1NVThang(2021,10)");
            for (int i = 0; i < dttk2.Rows.Count; i++)
            {
                lblTenNV.Text = dttk2.Rows[i]["TenNV"].ToString();
                lblDoanhSoNV.Text = dttk2.Rows[i]["DoanhSo"].ToString();
            }
        }
        void refresh()
        {
            lblTenKH.Text = "";
            lblChiTieuKH.Text = "";
            lblTenNV.Text = "";
            lblDoanhSoNV.Text = "";
        }
        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo năm")
            {
                cbbThang.Visible = false;
            }
            if (cbbThongKe.Text == "Theo tháng")
            {
                cbbThang.Visible = true;
            }
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo năm")
            {
                //KH
                dgvKH.DataSource = data.DataReader("select * from Top5KHNam(" + cbbNam.Text.Substring(4) + ")");
                chartRank.DataSource = data.DataReader("select MaKH, ChiTieu from Top5KHNam(" + cbbNam.Text.Substring(4) + ")");
                chartRank.Series["ChiTieu"].Points.Clear();
                chartRank.Series["ChiTieu"].XValueMember = "MaKH";
                chartRank.Series["ChiTieu"].YValueMembers = "ChiTieu";
                refresh();
                //Ten + chi tiêu top 1
                DataTable dttk = data.DataReader("select * from Top1KHNam(" + cbbNam.Text.Substring(4) + ")");
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    lblTenKH.Text = dttk.Rows[i]["TenKH"].ToString();
                    lblChiTieuKH.Text = dttk.Rows[i]["ChiTieu"].ToString();
                }
                //NV
                dgvNV.DataSource = data.DataReader("select * from Top5NVNam(" + cbbNam.Text.Substring(4) + ")");
                chartRank2.DataSource = data.DataReader("select MaNV, DoanhSo from Top5NVNam(" + cbbNam.Text.Substring(4) + ")");
                chartRank2.Series["DoanhSo"].Points.Clear();
                chartRank2.Series["DoanhSo"].XValueMember = "MaNV";
                chartRank2.Series["DoanhSo"].YValueMembers = "DoanhSo";
                //Ten + doanh số top 1
                DataTable dttk2 = data.DataReader("select * from Top1NVNam(" + cbbNam.Text.Substring(4) + ")");
                for (int i = 0; i < dttk2.Rows.Count; i++)
                {
                    lblTenNV.Text = dttk2.Rows[i]["TenNV"].ToString();
                    lblDoanhSoNV.Text = dttk2.Rows[i]["DoanhSo"].ToString();
                }
            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo tháng")
            {
                //KH
                dgvKH.DataSource = data.DataReader("select * from Top5KHThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartRank.DataSource = data.DataReader("select MaKH, ChiTieu from Top5KHThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartRank.Series["ChiTieu"].Points.Clear();
                chartRank.Series["ChiTieu"].XValueMember = "MaKH";
                chartRank.Series["ChiTieu"].YValueMembers = "ChiTieu";
                refresh();
                //Ten + chi tiêu top 1
                DataTable dttk = data.DataReader("select * from Top1KHThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    lblTenKH.Text = dttk.Rows[i]["TenKH"].ToString();
                    lblChiTieuKH.Text = dttk.Rows[i]["ChiTieu"].ToString();
                }
                dgvNV.DataSource = data.DataReader("select * from Top5NVThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartRank2.DataSource = data.DataReader("select MaNV, DoanhSo from Top5NVThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartRank2.Series["DoanhSo"].Points.Clear();
                chartRank2.Series["DoanhSo"].XValueMember = "MaNV";
                chartRank2.Series["DoanhSo"].YValueMembers = "DoanhSo";
                //Ten + doanh so top 1
                DataTable dttk2 = data.DataReader("select * from Top1NVThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                for (int i = 0; i < dttk2.Rows.Count; i++)
                {
                    lblTenNV.Text = dttk2.Rows[i]["TenNV"].ToString();
                    lblDoanhSoNV.Text = dttk2.Rows[i]["DoanhSo"].ToString();
                }
            }
        }
    }
}
