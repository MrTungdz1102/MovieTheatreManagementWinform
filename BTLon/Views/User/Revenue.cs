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
    public partial class Revenue : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
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
            DataTable dttk = data.DataReader("select * from DoanhThuThang(2021,10)");
            chartRevenue.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartRevenue.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chartRevenue.Series["Ngày"].Points.Clear();
            for (int i = 0; i < dttk.Rows.Count; i++)
            {
                chartRevenue.Series["Ngày"].Points.AddXY(dttk.Rows[i]["Ngay"], dttk.Rows[i]["DoanhThu"]);

            }
            chartRevenue.Visible = true;
            chartRevenue1.Visible = false;

            lblChuKy.Text = "Theo tháng";
            lblTG.Text = cbbThang.Text;
            //So luong ve + Tong tien ve
            DataTable dttk1 = data.DataReader("select * from DoanhThuBanVeThang(2021,10)");
            for (int i = 0; i < dttk1.Rows.Count; i++)
            {
                lblSLVe.Text = dttk1.Rows[i]["SoVeDaBan"].ToString();
                lblDoanhThuVe.Text = dttk1.Rows[i]["DoanhThuBanVe"].ToString();
            }
            //So luong SP + Tong tien SP
            DataTable dttk2 = data.DataReader("Select * from DoanhThuHoaDonThang (2021,10)");
            for (int i = 0; i < dttk1.Rows.Count; i++)
            {
                lblSLSP.Text = dttk2.Rows[i]["SoHDDaBan"].ToString();
                lblDoanhThuSP.Text = dttk2.Rows[i]["DoanhThuHoaDon"].ToString();
            }
            lblTongDoanhThu.Text = "";
            //Tong doanh thu
            DataTable dttk3 = data.DataReader("Select * from DoanhThu1Thang(2021,10)");
            for (int i = 0; i < dttk3.Rows.Count; i++)
            {
                lblTongDoanhThu.Text = dttk3.Rows[i]["DoanhThu"].ToString();
            }

            //mmmmm
        }


        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo tháng")
            {
                DataTable dttk = data.DataReader("select * from DoanhThuThang("+ cbbNam.Text.Substring(4) + ","+ cbbThang.Text.Substring(6) + ")");
                chartRevenue.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chartRevenue.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartRevenue.Series["Ngày"].Points.Clear();
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    chartRevenue.Series["Ngày"].Label = dttk.Rows[i]["Ngay"].ToString();
                    chartRevenue.Series["Ngày"].Points.AddXY(dttk.Rows[i]["Ngay"], dttk.Rows[i]["DoanhThu"]);
                    
                }
                chartRevenue.Visible = true;
                chartRevenue1.Visible = false;

                lblChuKy.Text = "Theo tháng";
                lblTG.Text = cbbThang.Text;
                //So luong ve + Tong tien ve
                DataTable dttk1 = data.DataReader("select * from DoanhThuBanVeThang(" + cbbNam.Text.Substring(4) + "," + cbbThang.Text.Substring(6) + ")");
                for(int i =0; i< dttk1.Rows.Count; i++)
                {
                    lblSLVe.Text = dttk1.Rows[i]["SoVeDaBan"].ToString();
                    lblDoanhThuVe.Text = dttk1.Rows[i]["DoanhThuBanVe"].ToString();
                }
                //So luong SP + Tong tien SP
                DataTable dttk2 = data.DataReader("Select * from DoanhThuHoaDonThang (" + cbbNam.Text.Substring(4) + ", " + cbbThang.Text.Substring(6) + ")");
                for (int i = 0; i < dttk1.Rows.Count; i++)
                {
                    lblSLSP.Text = dttk2.Rows[i]["SoHDDaBan"].ToString();
                    lblDoanhThuSP.Text = dttk2.Rows[i]["DoanhThuHoaDon"].ToString();
                }
                lblTongDoanhThu.Text = "";
                //Tong doanh thu
                DataTable dttk3 = data.DataReader("Select * from DoanhThu1Thang(" + cbbNam.Text.Substring(4) + ", " + cbbThang.Text.Substring(6) + ")");
                for(int i = 0; i < dttk3.Rows.Count; i++)
                {
                    lblTongDoanhThu.Text = dttk3.Rows[i]["DoanhThu"].ToString();
                }
            }
           

           
        }
        //abc
        //xyz
        //aaa
        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.Text == "Theo năm")
            {
                cbbThang.Visible = true;
                DataTable dttk = data.DataReader("select * from DoanhThuNam(" + cbbNam.Text.Substring(4) + ")");
                chartRevenue1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chartRevenue1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";

                chartRevenue1.Series["Tháng"].Points.Clear();
                for (int i = 0; i < dttk.Rows.Count; i++)
                {
                    chartRevenue1.Series["Tháng"].Points.AddXY(dttk.Rows[i]["Thang"], dttk.Rows[i]["DoanhThu"]);
                }
                chartRevenue.Visible = false;
                chartRevenue1.Visible = true;
                cbbThang.Visible = false;
                lblChuKy.Text = "Theo năm";
                lblTG.Text = cbbThang.Text;
                //So luong ve + Tong tien ve
                DataTable dttk1 = data.DataReader("select * from DoanhThuBanVeNam(" + cbbNam.Text.Substring(4) + ")");
                for (int i = 0; i < dttk1.Rows.Count; i++)
                {
                    lblSLVe.Text = dttk1.Rows[i]["SoVeDaBan"].ToString();
                    lblDoanhThuVe.Text = dttk1.Rows[i]["DoanhThuBanVe"].ToString();
                }
                //So luong SP + Tong tien SP
                DataTable dttk2 = data.DataReader("Select * from DoanhThuHoaDonNam(" + cbbNam.Text.Substring(4) + ")");
                for (int i = 0; i < dttk1.Rows.Count; i++)
                {
                    lblSLSP.Text = dttk2.Rows[i]["SoHDDaBan"].ToString();
                    lblDoanhThuSP.Text = dttk2.Rows[i]["DoanhThuHoaDon"].ToString();
                }
                //Tong doanh thu
                DataTable dttk3 = data.DataReader("Select * from DoanhThu1Nam(" + cbbNam.Text.Substring(4) + ")");
                for (int i = 0; i < dttk3.Rows.Count; i++)
                {
                    lblTongDoanhThu.Text = dttk3.Rows[i]["DoanhThu"].ToString();
                }
            }
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThongKe.Text == "Theo năm")
            {
                cbbThang.Visible = false;
            }
            if(cbbThongKe.Text == "Theo tháng")
            {
                cbbThang.Visible = true;
            }
        }
    }
}
