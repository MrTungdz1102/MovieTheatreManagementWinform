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
    public partial class Trend : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        public Trend()
        {
            InitializeComponent();
        }
        private void Trend_Load(object sender, EventArgs e)
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
            //Phim
            dgvPhim.DataSource = data.DataReader("select * from Top5PhimThang(2021,10)");
            chartPhim.DataSource = data.DataReader("select * from Top5PhimThang(2021,10)");
            chartPhim.ChartAreas["ChartArea1"].AxisX.Title = "Phim";
            chartPhim.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chartPhim.Series["DoanhThu"].Points.Clear();
            chartPhim.Series["DoanhThu"].XValueMember = "MaPhim";
            chartPhim.Series["DoanhThu"].YValueMembers = "DoanhThu";
            //SP
            dgvSP.DataSource = data.DataReader("select * from Top5DoAnThang(2021,10)");
            chartSP.DataSource = data.DataReader("select * from Top5DoAnThang(2021,10)");
            chartSP.ChartAreas["ChartArea1"].AxisX.Title = "Sản phẩm";
            chartSP.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chartSP.Series["DoanhThu"].Points.Clear();
            chartSP.Series["DoanhThu"].XValueMember = "TenSP";
            chartSP.Series["DoanhThu"].YValueMembers = "DoanhThu";

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
                //Phim
                dgvPhim.DataSource = data.DataReader("select * from Top5PhimNam(" + cbbNam.Text.Substring(4) + ")");
                chartPhim.DataSource = data.DataReader("select * from Top5PhimNam(" + cbbNam.Text.Substring(4) + ")");
                chartPhim.ChartAreas["ChartArea1"].AxisX.Title = "Phim";
                chartPhim.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartPhim.Series["DoanhThu"].Points.Clear();
                chartPhim.Series["DoanhThu"].XValueMember = "MaPhim";
                chartPhim.Series["DoanhThu"].YValueMembers = "DoanhThu";
                //SP
                dgvSP.DataSource = data.DataReader("select * from Top5DoAnNam(" + cbbNam.Text.Substring(4) + ")");
                chartSP.DataSource = data.DataReader("select * from Top5DoAnNam(" + cbbNam.Text.Substring(4) + ")");
                chartSP.ChartAreas["ChartArea1"].AxisX.Title = "Sản phẩm";
                chartSP.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartSP.Series["DoanhThu"].Points.Clear();
                chartSP.Series["DoanhThu"].XValueMember = "TenSP";
                chartSP.Series["DoanhThu"].YValueMembers = "DoanhThu";

            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo tháng")
            {
                //Phim
                dgvPhim.DataSource = data.DataReader("select * from Top5PhimThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartPhim.DataSource = data.DataReader("select * from Top5PhimThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartPhim.ChartAreas["ChartArea1"].AxisX.Title = "Phim";
                chartPhim.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartPhim.Series["DoanhThu"].Points.Clear();
                chartPhim.Series["DoanhThu"].XValueMember = "MaPhim";
                chartPhim.Series["DoanhThu"].YValueMembers = "DoanhThu";
                //SP
                dgvSP.DataSource = data.DataReader("select * from Top5DoAnThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartSP.DataSource = data.DataReader("select * from Top5DoAnThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                chartSP.ChartAreas["ChartArea1"].AxisX.Title = "Sản phẩm";
                chartSP.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartSP.Series["DoanhThu"].Points.Clear();
                chartSP.Series["DoanhThu"].XValueMember = "TenSP";
                chartSP.Series["DoanhThu"].YValueMembers = "DoanhThu";
            }
        }
    }
}
