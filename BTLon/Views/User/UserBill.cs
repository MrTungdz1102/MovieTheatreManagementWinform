using BTLon.Controls;
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
    public partial class UserBill : UserControl
    {
        UserBookTick userBook;
        bool checkOnline;
        DataProcess Process;
        public UserBill(UserBookTick userBook)
        {
            InitializeComponent();
            this.userBook = userBook;
            Process = new DataProcess();
        }

        private void UserBill_Load(object sender, EventArgs e)
        {
            lblKH.Text = "bạn là khách hàng mới \r\n       hay cũ?";
            SetAll(false);
        }
        private void SetAll(bool check)
        {
            txtHoTen.Visible = check;
            txtSDT.Visible = check;
            lblDate.Visible = check;
            dtpDate.Visible = check;
            btnConfirm.Visible = check;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            SetAll(true);
            btnOld.Visible = false;
            checkOnline = false;
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            setTextBoxAndButton(false);
            checkOnline = true;
            txtSDT.Visible = true;
            btnConfirm.Visible = true;
            btnDestroy.Visible = true;
            this.txtSDT.Location = new Point(22, 78);
            this.btnConfirm.Location = new Point(118, 120);
            this.btnDestroy.Location = new Point(16, 120);
        }
        private void setTextBoxAndButton(bool check)
        {
            txtHoTen.Visible = check;
            lblDate.Visible = check;
            dtpDate.Visible = check;
            btnNew.Visible = check;
        }
        private void txtHoTen_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Texts == "Họ Và Tên:")
            {
                txtHoTen.Texts = "";
            }
        }
        private void txtSDT_Click(object sender, EventArgs e)
        {
                if (txtSDT.Texts == "Số Điện Thoại:")
                {
                    txtSDT.Texts = "";
                }
        }
        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Texts == "")
            {
                txtHoTen.Texts = "Họ Và Tên:";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Texts == "")
            {
                txtSDT.Texts = "Số Điện Thoại:";
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            userBook.SetConTrolsInPanelKH();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSDT.Texts);
            }
            catch (Exception)
            {
                MessageBox.Show("Notify!", "Chưa nhập SĐT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string MaKH = null;
            string TenKH = null;
            string NgaySinh = null;
            string SDT = null;
            if (checkOnline == true)
            {
                string sql = "select MaKH,TenKH,SDT, NgaySinh from tblKhachHang where SDT like '%" + txtSDT.Texts + "%'";
                DataTable dt = Process.DataReader(sql);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Notify!", "Không tìm thấy số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MaKH = dt.Rows[0][0].ToString();
                TenKH = dt.Rows[0][1].ToString();
                SDT = dt.Rows[0][2].ToString();
                NgaySinh = dt.Rows[0][3].ToString();
            }
            else 
            {
                DateTime date = dtpDate.Value;
                MaKH = ModelView.InsertData3("KH",txtHoTen.Texts, date,txtSDT.Texts);
            }
            ModelView.InsertData("V", MaKH, "NV01", userBook.GetTagPC(), userBook.SoGheDaChon);
            if (userBook.foodSelecteds.Count > 0)
            {
                Decimal TongTien = Decimal.Parse(userBook.GetPriceFood());
                Models.ModelView.InsertData2("HD", "NV01", MaKH, TongTien, userBook.foodSelecteds);
                MessageBox.Show("Thêm thành công!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TenKH = txtHoTen.Texts;
            printBill printBill = new printBill(userBook,  TenKH);
            printBill.ShowDialog();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = true;
                errtxt.SetError(txtSDT, "Không được nhập chữ!");
            }
            else
            {
                e.Handled = false;
                errtxt.Clear();
            }
        }
    }
}
