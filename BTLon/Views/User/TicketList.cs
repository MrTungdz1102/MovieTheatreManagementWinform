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
    public partial class TicketList : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        public TicketList()
        {
            InitializeComponent();
        }

        private void TicketList_Load(object sender, EventArgs e)
        {
            dgvVe.DataSource = data.DataReader("Select * from tblVe");
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
        private void TongSoLuong()
        {
            int sl = dgvVe.Rows.Count;
            lblSL.Text = sl.ToString();
        }
        private void TongTien()
        {
            int tien = dgvVe.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dgvVe.Rows[i].Cells["GiaVe"].Value.ToString());
            }
            lblTien.Text = thanhtien.ToString();
        }

        private void cbbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hidedtp();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text == "Tất cả")
            {
                reset();
                System.Data.DataTable data1 = data.DataReader("Select * from tblVe");
                dgvVe.DataSource = data1;
                TongSoLuong();
                TongTien();
            }

            if (cbbTK.Text == "Tùy chọn")
            {
                reset();
                System.Data.DataTable dt = data.DataReader("select * from tblVe where NgayBan between '" + dtpBD.Value.ToString("yyyy/MM/dd") + "' and '" + dtpKT.Value.ToString("yyyy/MM/dd") + "'");
                dgvVe.DataSource = dt;
                TongSoLuong();
                TongTien();
            }
            void hide()
            {
                label2.Visible = false;
                label4.Visible = false;
            }
        }
        void hide()
        {
            label2.Visible = false;
            label4.Visible = false;
        }
        private void txtSeach__TextChanged(object sender, EventArgs e)
        {
            reset();
            hide();
            if (cbbTK.Text == "Tất cả")
            {
                string sql = "select * from tblVe where MaVe like N'%" + txtSeach.Texts + "%' or NgayBan like N'%" + txtSeach.Texts + "%' ";
                dgvVe.DataSource = data.DataReader(sql);
            }
            if (cbbTK.Text == "Tùy chọn")
            {
                string sql = "select * from tblVe where MaVe like N'%" + txtSeach.Texts + "%' or NgayBan like N'%" + txtSeach.Texts + "%' and NgayBan between '" + dtpBD.Value.ToString("yyyy/MM/dd") + "' and '" + dtpKT.Value.ToString("yyyy/MM/dd") + "' ";
                dgvVe.DataSource = data.DataReader(sql);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Worksheet)exBook.Worksheets[1];
            //Thong tin ve
            exSheet.Range["C1"].Value = "THÔNG TIN VÉ";
            exSheet.Range["C1"].Font.Bold = true;
            exSheet.Range["C1"].Font.Size = 20;
            //Tieu de
            exSheet.Range["A3:H3"].Font.Size = 12;
            exSheet.Range["A3:H3"].Font.Bold = true;
            exSheet.Range["B3"].ColumnWidth = 10;
            exSheet.Range["C3"].ColumnWidth = 15;
            exSheet.Range["E3"].ColumnWidth = 10;
            exSheet.Range["F3"].ColumnWidth = 16;
            exSheet.Range["G3"].ColumnWidth = 15;
            exSheet.Range["H3"].ColumnWidth = 13;


            exSheet.Range["A3"].Value = "STT";
            exSheet.Range["B3"].Value = "Mã vé";
            exSheet.Range["C3"].Value = "Mã lịch chiếu";
            exSheet.Range["D3"].Value = "Mã ghế";
            exSheet.Range["E3"].Value = "Giá vé";
            exSheet.Range["F3"].Value = "Ngày bán";
            exSheet.Range["G3"].Value = "Mã khách hàng";
            exSheet.Range["H3"].Value = "Mã nhân viên";
            //In danh sách
            int dong = 4;
            for (int i = 0; i < dgvVe.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[5].Value.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvVe.Rows[i].Cells[6].Value.ToString();
            }
            dong = dong + dgvVe.Rows.Count;
            exSheet.Range["G" + dong.ToString()].Value = "Tổng số lượng: " + lblSL.Text;
            exSheet.Range["G" + (dong + 1).ToString()].Value = "Tổng tiền: " + lblTien.Text;

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
