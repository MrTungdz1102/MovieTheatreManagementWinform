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
    public partial class UserBookTick : UserControl
    {
        DataProcess process = new DataProcess();
        decimal SumTienGhe = 0;
        List<DetailTicket> SoGheDaChon = new List<DetailTicket>();
        public UserBookTick()
        {
            InitializeComponent();
            process = new DataProcess();
        }
        private void UserBookTick_Load(object sender, EventArgs e)
        {
            lblTenRap.Text = " CGV vincom \r\n Center Bà Triệu";
        }
        public void SetLabelPC(string text,string tag)
        {
            this.lblPC.Text = text;
            this.lblPC.Tag = tag;
        }
        public void SetLabelPhim(string text)
        {
            this.lblTenPhim.Text = text;
        }
        public void SetPictureBox(Image image)
        {
            this.ptbPhim.Image = image;
        }
        public void SetLabelTGC(string text)
        {
            this.lblThoiGianChieu.Text = text;
        }
        public void SetLabelNgayChieu(string text)
        {
            this.lblNgayChieu.Text = text;
        }
        //Hàm này để bắt sự kiện người dùng chọn ghế
        private void book_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string[] soPC = lblPC.Text.ToString().Split(' ');
            string SoGhe = button.Tag.ToString() + soPC[2] + "-" + button.Text;
            if (button.BackColor == Color.White)
            {
                DetailTicket detail = new DetailTicket();
                button.BackColor = Color.Brown;
                detail.MaGhe1 = SoGhe;
                detail.GiaTien1 = process.DataFunction(SoGhe, lblPC.Tag.ToString());
                SumTienGhe += process.DataFunction(SoGhe, lblPC.Tag.ToString());
                this.lblSum.Text = SumTienGhe.ToString();
                SoGheDaChon.Add(detail);
            }
            else
            {
                button.BackColor = Color.White;
                SumTienGhe -= process.DataFunction(SoGhe, lblPC.Tag.ToString());
                if (SumTienGhe == 0)
                {
                    this.lblSum.Text = "";
                }
                else
                {
                    this.lblSum.Text = SumTienGhe.ToString();
                }
                foreach(DetailTicket detail in SoGheDaChon)
                {
                    if(detail.MaGhe1 == SoGhe)
                    {
                        SoGheDaChon.Remove(detail);
                        break;
                    }
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            ModelView.InsertData("V", SoGheDaChon, lblPC.Tag.ToString());
            //DataTable data = process.DataReader("select count(MaVe) from tblVe");
            //int i = int.Parse(data.Rows[0][0].ToString());
            //DateTime dateTime = DateTime.Now;
            //string NgayBan = dateTime.ToString("yyyy/MM/dd") + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString();
            //MessageBox.Show("V" + data.Rows[0][0].ToString() + "," + SoGheDaChon.Count.ToString() + "," + NgayBan + "," + i.ToString() +"," + lblPC.Tag.ToString());
            //foreach(DetailTicket detail in SoGheDaChon)
            //{
            //    i++;
            //    MessageBox.Show(detail.MaGhe1+","+detail.GiaTien1.ToString()+","+i.ToString());
            //}
        }
    }
}
