using BTLon.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserAccount : UserControl
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCanCelA_Click(object sender, EventArgs e)
        {
            txtMaNVA.Text = "";
            txtPassWordA.Text = "";
            txtUserNameA.Text = "";
            txtQuyenTCA.Text = "";
            btnDeleteA.Enabled = false;
            btnExitA.Enabled = false;

        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            if (Login.quyen == 1)
            {
                btnAddA.Enabled = true;
                btnCanCelA.Enabled = true;
                btnDeleteA.Enabled = false;
                btnExitA.Enabled = false;
                btnSearchA.Enabled = true;
                txtMaNVA.Enabled = true;
                txtPassWordA.Enabled = true;
                txtQuyenTCA.Enabled = true;
                txtUserNameA.Enabled = true;
            }
            else
            {
                btnAddA.Enabled = false;
                btnCanCelA.Enabled = false;
                btnDeleteA.Enabled = false;
                btnExitA.Enabled = false;
                btnSearchA.Enabled = false;
                txtUserNameA.Enabled = false;
                txtQuyenTCA.Enabled = false;
                txtPassWordA.Enabled = false;
                txtMaNVA.Enabled = false;
            }
            imgAcc.Image = Models.ModelView.Images("acc.png");
        }
        string[] acc = new string[4];
        private void btnSearchA_Click(object sender, EventArgs e)
        {
            //txtMaNVA.Text = "";
            //txtPassWordA.Text = "";
            //txtUserNameA.Text = "";
            //txtQuyenTCA.Text = "";
            //txtUserNameA.Enabled = false;
            //txtQuyenTCA.Enabled = false;
            //txtPassWordA.Enabled = false;
            //txtMaNVA.Enabled = true;

            if (txtMaNVA.Text != "")
            {
                try
                {
                    DataProcess chitiet = new DataProcess();
                    string sqlchitet = "select * from tblDangNhap where MaNV = '" + txtMaNVA.Text + "'";
                    DataTable ct = new DataTable();
                    ct = chitiet.DataReader(sqlchitet);
                    for (int i = 0; i < 4; i++)
                    {
                        acc[i] = ct.Rows[0][i].ToString();
                    }
                    txtUserNameA.Text = acc[0];
                    txtPassWordA.Text = acc[1];
                    txtMaNVA.Text = acc[2];
                    txtQuyenTCA.Text = acc[3];
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtQuyenTCA.Text == "True")
                {
                    return;
                }
                else
                {
                    btnExitA.Enabled = true;
                    btnDeleteA.Enabled = true;
                }
            }

        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            DataProcess a = new DataProcess();
            DataProcess c = new DataProcess();
            DataProcess b = new DataProcess();
            DataTable dtb = new DataTable();
            DataTable dt = new DataTable();
            string sql;
            string check1 = "select TenDangNhap from tblDangNhap where TenDangNhap = '" + txtUserNameA.Text + "'";
            string check2 = "select MaNV from tblDangNhap where MaNV = '" + txtMaNVA.Text + "'";
            dtb = b.DataReader(check1);
            dt = c.DataReader(check2);
            if(dt.Rows.Count>0)
            {
                txtMaNVA.Text = "";
                txtPassWordA.Text = "";
                txtUserNameA.Text = "";
                txtQuyenTCA.Text = "";
                MessageBox.Show("Nhân viên này đã có tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dtb.Rows.Count > 0)
            {
                txtMaNVA.Text = "";
                txtPassWordA.Text = "";
                txtUserNameA.Text = "";
                txtQuyenTCA.Text = "";
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (txtQuyenTCA.Text == "True")
                    {
                        sql = "insert into tblDangNhap values( '" + txtUserNameA.Text + "', '" + txtPassWordA.Text + "', '" + txtMaNVA.Text + "','" + 1 + "')";
                        a.DataChange(sql);
                        txtMaNVA.Text = "";
                        txtPassWordA.Text = "";
                        txtUserNameA.Text = "";
                        txtQuyenTCA.Text = "";
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (txtQuyenTCA.Text == "False")
                    {
                        sql = "insert into tblDangNhap values( '" + txtUserNameA.Text + "', '" + txtPassWordA.Text + "', '" + txtMaNVA.Text + "','" + 0 + "')";
                        a.DataChange(sql);
                        txtMaNVA.Text = "";
                        txtPassWordA.Text = "";
                        txtUserNameA.Text = "";
                        txtQuyenTCA.Text = "";
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch
                {
                    MessageBox.Show("Vui lòng thêm thông tin nhân viên trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExitA_Click(object sender, EventArgs e)
        {
            string sqlupdate;
            string[] txt = new string[] { "txtUserNameA", "txtPassWordA", "txtMaNVA" , "txtQuyenTCA"};
            for (int i = 0; i < 4; i++)
            {

                if (txt[i] != acc[i])
                {
                    DataProcess c = new DataProcess();
                    DataTable dt = new DataTable();
                    string check2 = "select MaNV from tblDangNhap where MaNV = '" + txtMaNVA.Text + "'";
                    dt = c.DataReader(check2);
                    if (dt.Rows.Count > 0)
                    {
                        txtMaNVA.Text = "";
                        txtPassWordA.Text = "";
                        txtUserNameA.Text = "";
                        txtQuyenTCA.Text = "";
                        MessageBox.Show("Nhân viên này đã có tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DataProcess update = new DataProcess();
                        if (txtQuyenTCA.Text == "True")
                        {
                            sqlupdate = "update tblDangNhap set TenDangNhap = N'" + txtUserNameA.Text + "', MatKhau = N'" + txtPassWordA.Text + "', MaNV = N'" + txtMaNVA.Text + "', QuyenTc = " + 1 + " where MaNV = '" + acc[2] + "'";
                            update.DataChange(sqlupdate);
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (txtQuyenTCA.Text == "False")
                        {
                            sqlupdate = "update tblDangNhap set TenDangNhap = N'" + txtUserNameA.Text + "', MatKhau = N'" + txtPassWordA.Text + "', MaNV = N'" + txtMaNVA.Text + "', QuyenTc = " + 0 + " where MaNV = '" + acc[2] + "'";

                            update.DataChange(sqlupdate);
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                    break;
                }

            }
        }

        private void btnDeleteA_Click(object sender, EventArgs e)
        {
            string delete = "delete from tblDangNhap where MaNV = '" + txtMaNVA.Text + "'";
            DataProcess dl = new DataProcess();
            try
            {
                dl.DataChange(delete);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tài Khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
