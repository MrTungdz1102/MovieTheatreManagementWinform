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
        public UserBill(UserBookTick userBook)
        {
            InitializeComponent();
            this.userBook = userBook;
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
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            setTextBoxAndButton(false);
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
            string TenKH = txtHoTen.Texts;
            printBill printBill = new printBill(userBook,  TenKH);
            printBill.ShowDialog();
        }
    }
}
