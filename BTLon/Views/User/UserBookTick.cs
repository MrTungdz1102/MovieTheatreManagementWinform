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
    public partial class UserBookTick : UserControl
    {
        DataProcess process = new DataProcess();
        double SumTienGhe = 0;
        public UserBookTick()
        {
            InitializeComponent();
            process = new DataProcess();
        }
        private void UserBookTick_Load(object sender, EventArgs e)
        {
            lblTenRap.Text = " CGV vincom \r\n Center Bà Triệu";
            //lblTenPhim.MaximumSize = grbDetailPhim.Size;
        }
        public void SetLabelPC(string text)
        {
            this.lblPC.Text = text;
        }
        public void SetLabelPhim(string text)
        {
            this.lblTenPhim.Text = text;
        }
        public void SetPictureBox(Image image)
        {
            this.ptbPhim.Image = image;
        }
        public void SetLabelTGC(string text,string tag)
        {
            this.lblThoiGianChieu.Text = text;
            this.lblThoiGianChieu.Tag = tag;
        }
        public void SetLabelNgayChieu(string text)
        {
            this.lblNgayChieu.Text = text;
        }
        //Hàm này để bắt sự kiện người dùng chọn ghế
        private void book_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Brown;
                string TenGhe = button.Tag.ToString();
                //SumTienGhe += process.DataFunction("TienVe", button.Tag.ToString(), lblThoiGianChieu.Tag.ToString());
                SumTienGhe += Double.Parse(process.DataFunction("TienVe", "A1-5", "LC01"));
                this.lblSum.Text +="  " + SumTienGhe.ToString();
            }
            else
            {
                button.BackColor = Color.White;
            }
        }
    }
}
