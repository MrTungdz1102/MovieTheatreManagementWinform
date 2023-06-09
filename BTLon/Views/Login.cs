﻿using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static string tk = "";
        public static string mk = "";
        public static int quyen = 0;
        public static string manv = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from tblDangNhap where TenDangNhap = @user and MatKhau = @pass";
            string sqlRole = "select QuyenTC from tblDangNhap where TenDangNhap = @user and MatKhau = @pass";
            string sqlnv = "select MaNV from tblDangNhap where TenDangNhap = @user and MatKhau = @pass";
            //   string sql = " select * from tbltaikhoan where taikhoan = '" + txtTaiKhoan.Text + "' and matkhau = '" + txtMatKhau.Text + "'";
            tk = txtUserName.Texts;
            mk = txtPassWord.Texts;
          //  dt = dtb.DataReader(sql);
            try
            {
                if (txtUserName.Texts.Trim() == "" && txtPassWord.Texts.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu ");
                    txtUserName.Texts = "";
                    txtPassWord.Texts = "";
                    return;
                }
                if (txtUserName.Texts.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập ");
                    txtUserName.Texts = "";
                    txtPassWord.Texts = "";
                    return;
                }
                if (txtPassWord.Texts.Trim() == "")
                {
                    MessageBox.Show(" Vui lòng nhập mật khẩu");
                    txtUserName.Texts = "";
                    txtPassWord.Texts = "";
                    return;
                }
                DataProcess dtb = new DataProcess(); 
                DataTable dt = new DataTable();
                DataTable d = new DataTable();
                DataTable nv = new DataTable();
                dt = dtb.ReadDataSQL(query);

                if (dt.Rows.Count > 0)
                {
                    //  MessageBox.Show("Đăng nhập thành công");
                    d = dtb.ReadDataSQL(sqlRole);
                    nv = dtb.ReadDataSQL(sqlnv);
                    manv = (string)nv.Rows[0][0];
                    quyen = Convert.ToInt32(d.Rows[0][0]);
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng nhập lại");
                    txtUserName.Texts = "";
                    txtPassWord.Texts = "";
                    txtUserName.Focus();
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }
    }
}
