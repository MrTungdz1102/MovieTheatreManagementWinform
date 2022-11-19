using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace BTLon.Views.User
{
    public partial class BillList : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        public BillList()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            if (cbbTK.Text == "Tất cả")
            {
                reset();
                System.Data.DataTable data1 = data.DataReader("Select * from tblHoaDon");
                dgvHoaDon.DataSource = data1;
                TongSoLuong();
                TongTien();
            }

            if (cbbTK.Text == "Tùy chọn")
            {
                reset();
                System.Data.DataTable dt = data.DataReader("select * from tblHoaDon where NgayBanHD between '" + dtpBD.Value.ToString("yyyy/MM/dd") + "' and '" + dtpKT.Value.ToString("yyyy/MM/dd") + "'");
                dgvHoaDon.DataSource = dt;
                TongSoLuong();
                TongTien();
            }
        }

        private void BillList_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = data.DataReader("Select * from tblHoaDon");
            cbbTK.Items.Add("Tất cả");
            cbbTK.Items.Add("Tùy chọn");
            Hidedtp();
            TongTien();
            TongSoLuong();
        }
        void Hidedtp()
        {
            if (cbbTK.Text == "Tất cả")
            {
                dtpBD.Visible = false;
                dtpKT.Visible = false;
                lblTu.Visible = false;
                lblDen.Visible = false;
            }
            else
            {
                dtpBD.Visible = true;
                dtpKT.Visible = true;
                lblTu.Visible = true;
                lblDen.Visible = true;
            }
        }
        void reset()
        {
            lblSL.Text = "";
            lblTien.Text = "";
        }

        private void cbbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hidedtp();
        }
        private void TongSoLuong()
        {
            int sl = dgvHoaDon.Rows.Count;
            lblSL.Text = sl.ToString();
        }
        private void TongTien()
        {
            int tien = dgvHoaDon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dgvHoaDon.Rows[i].Cells["txtTongTien"].Value.ToString());
            }
            lblTien.Text = thanhtien.ToString();
        }
        void hide()
        {
            label2.Visible = false;
            label4.Visible = false;
        }

        private void txtSeach__TextChanged(object sender, EventArgs e)
        {
            hide();
            reset();
            if (cbbTK.Text == "Tất cả")
            {
                string sql = "select * from tblHoaDon where MaHD like N'%" + txtSeach.Texts + "%' or NgayBanHD like N'%" + txtSeach.Texts + "%'";
                dgvHoaDon.DataSource = data.DataReader(sql);
            }
            if (cbbTK.Text == "Tùy chọn")
            {
                string sql = "select * from tblHoaDon where MaHD like N'%" + txtSeach.Texts + "%' or NgayBanHD like N'%" + txtSeach.Texts + "%' and NgayBanHD between '" + dtpBD.Value.ToString("yyyy/MM/dd") + "' and '" + dtpKT.Value.ToString("yyyy/MM/dd") + "' ";
                dgvHoaDon.DataSource = data.DataReader(sql);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Worksheet)exBook.Worksheets[1];
            //Thong tin ve
            exSheet.Range["C1"].Value = "THÔNG TIN HÓA ĐƠN";
            exSheet.Range["C1"].Font.Bold = true;
            exSheet.Range["C1"].Font.Size = 20;
            //Tieu de
            exSheet.Range["A3:F3"].Font.Size = 12;
            exSheet.Range["A3:F3"].Font.Bold = true;
            exSheet.Range["B3"].ColumnWidth = 13;
            exSheet.Range["C3"].ColumnWidth = 15;
            exSheet.Range["D3"].ColumnWidth = 10;
            exSheet.Range["E3"].ColumnWidth = 14;
            exSheet.Range["F3"].ColumnWidth = 15;


            exSheet.Range["A3"].Value = "STT";
            exSheet.Range["B3"].Value = "Mã hóa đơn";
            exSheet.Range["C3"].Value = "Ngày bán hóa đơn";
            exSheet.Range["D3"].Value = "Tổng tiền";
            exSheet.Range["E3"].Value = "Mã nhân viên";
            exSheet.Range["F3"].Value = "Mã khách hàng";
            //In danh sách
            int dong = 4;
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
            }
            dong = dong + dgvHoaDon.Rows.Count;
            exSheet.Range["E" + dong.ToString()].Value = "Tổng số lượng: " + lblSL.Text;
            exSheet.Range["E" + (dong + 1).ToString()].Value = "Tổng tiền: " + lblTien.Text;

            exBook.Activate();
            //Lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();
        }
    }
}
