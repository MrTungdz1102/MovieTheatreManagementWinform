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
    public partial class FoodandDrink : UserControl
    {
        Models.DataProcess data = new Models.DataProcess();
        public FoodandDrink()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            DataTable dtSP = data.DataReader("select * from tblDoAn_NuocUong");
            dgvFD.DataSource = dtSP;
        }

        private void FoodandDrink_Load(object sender, EventArgs e)
        {
            panelDetail.Visible = false;
            LoadData();
            ShowDetail(false);
        }
        bool check = true;
        private void CheckNull()
        {
            if (txtMaSP.Text.Trim() == "")
            {
                errorDetail.SetError(txtMaSP, "Bạn không được để trống mã sản phẩm!");
                check = false;
                return;
            }
            else
            {
                errorDetail.Clear();
            }
            if (txtTenSP.Text.Trim() == "")
            {
                errorDetail.SetError(txtTenSP, "Bạn không được để trống tên sản phẩm!");
                check = false;
                return;
            }
            else
            {
                errorDetail.Clear();
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                errorDetail.SetError(txtSoLuong, "Bạn không được để trống số lượng");
                check = false;
                return;
            }
            else
            {
                errorDetail.Clear();
            }
            if (txtGia.Text.Trim() == "")
            {
                errorDetail.SetError(txtGia, "Bạn không để trống đơn giá nhập!");
                check = false;
                return;
            }
            else
            {
                errorDetail.Clear();
            }
        }
        private void duplicateCheck()
        {
            DataTable dtCheckHang = data.DataReader("Select * from tblDoAn_NuocUong where MaSP = '" + txtMaSP.Text + "'");
            if (dtCheckHang.Rows.Count > 0)
            {
                MessageBox.Show("Mã sản phẩm đã có, mời bạn nhập mã khác");
                txtMaSP.Focus();
                return;
            }
            else
            {
                errorDetail.Clear();
            }
        }
        void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtMaSP.Focus();
            btnSave.Enabled = true;
            
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorDetail.SetError(txt, "Chỉ được nhập số");
            }
            else
                errorDetail.Clear();

        }
        public void ShowDetail(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            txtSoLuong.Enabled = hien;
            txtGia.Enabled = hien;
            btnSave.Enabled = hien;
            btnCancel.Enabled = hien;
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = true;
            ResetValue();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            ShowDetail(true);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            ShowDetail(true);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã sản phẩm "+txtMaSP.Text+" không","Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DataChange("Delete from tblDoAn_NuocUong where MaSP = N'" + txtMaSP.Text + "'");
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                ShowDetail(true);
                LoadData(); 
                
            }
        }

        private void txtSeach__TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from tblDoAn_NuocUong where TenSP like N'%" + txtSeach.Texts + "%'";
            dgvFD.DataSource = data.DataReader(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckNull();
            string sql = "";
            if(btnAdd.Enabled == true)
            {
                duplicateCheck();
                sql = @"Insert into tblDoAn_NuocUong values(N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "'," + int.Parse(txtSoLuong.Text) + "," + float.Parse(txtGia.Text) + ")";
                
            }
            if(btnEdit.Enabled == true)
            {
                sql = "update tblDoAn_NuocUong set MaSP = N'" + txtMaSP.Text + "',TenSP = N'" + txtTenSP.Text + "', SoLuong=" + int.Parse(txtSoLuong.Text) + ", Gia=" + float.Parse(txtGia.Text) + " where MaSP = '" + txtMaSP.Text + "'";
                
            }
            data.DataChange(sql);
            LoadData();
            ShowDetail(false);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            ShowDetail(false);
            ResetValue();

        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            txtSeach.Texts = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }

        private void dgvFD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvFD.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvFD.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvFD.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dgvFD.CurrentRow.Cells[3].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }
    }
}
