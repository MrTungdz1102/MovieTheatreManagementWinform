using BTLon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserDetails : UserControl
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        string[] arrct = new string[9];
        private void UserDetails_Load(object sender, EventArgs e)
        {

            if(Login.quyen == 1)
            {
                cicrleAvatarP.Image = Models.ModelView.Images("nam.jpg");
            }
            else
            {
                cicrleAvatarP.Image = Models.ModelView.Images("nu.jpg");
            }
            DataProcess chitiet = new DataProcess();
            string sqlchitet = "select * from tblNhanVien where MaNV = '" + Login.manv + "'";
            DataTable ct = new DataTable();
            ct = chitiet.DataReader(sqlchitet);
            for(int i =0; i < 9;i++)
            {
                arrct[i] = ct.Rows[0][i].ToString();
            }
            txtUserP.Text = arrct[0];
            txtRoomP.Text = arrct[1];
            txtNameP.Text = arrct[2];
            txtDateP.Text = arrct[4];
            txtPlaceP.Text = arrct[5];
            txtNumberP.Text = arrct[6];
            DataProcess ht = new DataProcess();
            string hoten = "select TenNV from tblNhanVien where MaNV = '" + Login.manv + "'";
            DataTable hten = new DataTable();
            hten = ht.DataReader(hoten);
            lblHoTen.Text = (string)hten.Rows[0][0];
            if (Login.quyen == 1) {
                
                btnExitP.Enabled = true;
                btnCancelP.Enabled = true;
               

            }
            a = txtUserP.Text;
            b = txtNameP.Text;
            c = txtDateP.Text;
            d = txtNumberP.Text;
            g = txtPlaceP.Text;
            f = txtRoomP.Text;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitPro_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btnSaveP_Click(object sender, EventArgs e)
        {
           // Console.OutputEncoding = Encoding.UTF8;
            //string[] txt = new string[] {"txtUserP.Text", "txtRoomP.Text", "txtNameP.Text", "txtDateP.Text", "txtPlaceP.Text", "txtNumberP.Text" };
            //for (int i =0; i < 6; i++)
            //{
            //   if(i ==4)
            //    {
            //        continue;
            //    }
            //   else
            //    {
            //        if (txt[i] != arrct[i])
            //        {
            //            DataProcess update = new DataProcess();
            //            string sqlupdate = "update tblNhanVien set MaNV = N'" + txtUserP.Text + "', MaPB = N'" + txtRoomP.Text + "', TenNV = N'" + txtNameP.Text + "', NgaySinh = N'" + txtDateP.Text + "', DiaChi = N'" + txtPlaceP.Text + "', SDT = N'" + txtNumberP.Text + "' where MaNV = '" + a + "'";
            //            update.DataChange(sqlupdate);
            //            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            break;
            //        }
            //    }
            //}
            DataProcess mk = new DataProcess();
            string sqlpass = "select MatKhau from tblDangNhap where MatKhau = '" + txtOldPass.Text + "'and TenDangNhap = '" + Login.tk + "'";
            DataTable doimk = new DataTable();
            doimk = mk.DataReader(sqlpass);

            if (doimk.Rows.Count == 1)
            {
                if (txtNewPass.Text == txtReNewPass.Text)
                {
                    DataProcess remk = new DataProcess();
                    string sqldoimk = "update tblDangNhap set MatKhau = '" + txtNewPass.Text + "' where TenDangNhap = '" + Login.tk + "'";
                    remk.DataChange(sqldoimk);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtOldPass.Text = "";
                    txtNewPass.Text = "";
                    txtReNewPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                    txtOldPass.Text = "";
                    txtNewPass.Text = "";
                    txtReNewPass.Text = "";
                }
            }
            if (txtOldPass.Text == "" && txtNewPass.Text == "" && txtReNewPass.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                txtOldPass.Text = "";
                txtNewPass.Text ="";
                txtReNewPass.Text ="";
            }
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
        string a, b, c, d, f, g;

        private void circlePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnSearchP_Click(object sender, EventArgs e)
        {
            txtRoomP.Enabled = false;
            txtReNewPass.Enabled = false;
            txtNewPass.Enabled = false;
            txtDateP.Enabled = false;
            txtNameP.Enabled = false;
            txtPlaceP.Enabled = false;
            txtNumberP.Enabled = false;
            txtOldPass.Enabled = false;
            txtUserP.Enabled = true;
            txtUserP.Text = "";
            txtDateP.Text = "";
            txtNameP.Text = "";
            txtNewPass.Text = "";
            txtNumberP.Text = "";
            txtOldPass.Text = "";
            txtPlaceP.Text = "";
            txtReNewPass.Text = "";
            txtRoomP.Text = "";
            txtUserP.Focus();
            if(txtPlaceP.Enabled == false)
            {
                try
                {
                    DataProcess ht = new DataProcess();
                    string hoten = "select TenNV from tblNhanVien where MaNV = '" + txtUserP.Text + "'";
                    DataTable hten = new DataTable();
                    hten = ht.DataReader(hoten);
                    lblHoTen.Text = (string)hten.Rows[0][0];
                    //
                    DataProcess chitiet = new DataProcess();
                    string sqlchitet = "select * from tblNhanVien where MaNV = '" + txtUserP.Text + "'";
                    DataTable ct = new DataTable();
                    ct = chitiet.DataReader(sqlchitet);
                    for (int i = 0; i < 9; i++)
                    {
                        arrct[i] = ct.Rows[0][i].ToString();
                    }
                    txtUserP.Text = arrct[0];
                    txtRoomP.Text = arrct[1];
                    txtNameP.Text = arrct[2];
                    txtDateP.Text = arrct[4];
                    txtPlaceP.Text = arrct[5];
                    txtNumberP.Text = arrct[6];
                }
                catch
                {
                    MessageBox.Show("sai ma nv");
                }
            }
        }

        private void btnExitP_Click(object sender, EventArgs e)
        {
            txtDateP.Enabled = true;
            txtNameP.Enabled = true;
            txtNumberP.Enabled = true;
            txtPlaceP.Enabled = true;
            txtRoomP.Enabled = true;
            txtUserP.Enabled = true;
           
            
        }

        private void btnCancelP_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = "";
            txtReNewPass.Text = "";
            txtNewPass.Text = "";
            txtDateP.Enabled = false;
            txtNameP.Enabled = false;
            txtNumberP.Enabled = false;
            txtPlaceP.Enabled = false;
            txtRoomP.Enabled = false;
            txtUserP.Enabled = false;
            txtUserP.Text = a;
            txtNameP.Text = b;
            txtDateP.Text = c;
            txtNumberP.Text = d;
            txtPlaceP.Text = g;
            txtRoomP.Text = f;
            txtNewPass.Enabled = true;
            txtReNewPass.Enabled = true;
            txtOldPass.Enabled = true;
            // DataProcess ht = new DataProcess();
            //string hoten = "select TenNV from tblNhanVien where MaNV = '" + Login.manv + "'";
            //DataTable hten = new DataTable();
            //hten = ht.DataReader(hoten);
            //lblHoTen.Text = (string)hten.Rows[0][0];
        }
    }
}
