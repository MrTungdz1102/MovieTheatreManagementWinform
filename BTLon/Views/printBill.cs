using BTLon.Controls;
using BTLon.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views
{
    public partial class printBill : Form
    {
        UserBookTick userBookTick;
        string TenKH;
        public printBill(UserBookTick bookTick, string TenKH)
        {
            InitializeComponent();
            this.userBookTick = bookTick;
            this.TenKH = TenKH;
        }
        private void printPanel(Panel panel)
        {
            PrinterSettings settings = new PrinterSettings();
            getPrintArea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rectangle = e.PageBounds;
            e.Graphics.DrawImage(Bitmap, (rectangle.Width / 2) - (this.panelBillAndTick.Width / 2), this.panelTick.Location.Y);
        }
        private Bitmap Bitmap;
        private void getPrintArea(Panel flpanel)
        {
            Bitmap = new Bitmap(flpanel.Width, flpanel.Height);
            flpanel.DrawToBitmap(Bitmap, new Rectangle(0, 0, flpanel.Width, flpanel.Height));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printPanel(this.panelBillAndTick);
        }
        private void setDetailToPrint()
        {
            setDetailToPrintTick();
            setDetailToPrintBill();
        }
        private void setDetailToPrintTick()
        {
            List<DetailTicket> detailTickets = userBookTick.SoGheDaChon;
            int i = 0;
            this.lblKH.Text = TenKH;
            this.lblTenPhim.Text = userBookTick.GetTenPhim();
            this.lblNgayBanTick.Text = DateTime.Now.ToString("dd/MM/yyyy HH':'mm':'ss 'GMT'");
            this.lblNgayChieu.Text = userBookTick.GetNC();
            this.lblGioChieu.Text = userBookTick.GetTGC();
            this.lblPhongChieu.Text = userBookTick.GetPC();
            this.lblTongTien.Text = userBookTick.GetTongTienVe();
            lblGhe.Text = "";
            foreach (DetailTicket detail in detailTickets)
            {
                if (i == 0 || i == detailTickets.Count)
                {
                    lblGhe.Text += detail.MaGhe;
                }
                else
                {
                    lblGhe.Text += ", " + detail.MaGhe;
                }
                i++;
            }
        }
        private void setDetailToPrintBill()
        {
            List<DetailFoodSelected> detailFoodSelecteds = userBookTick.foodSelecteds;
            this.lblKhachHang.Text = TenKH;
            this.lblNgayBanBill.Text = DateTime.Now.ToString("dd/MM/yyyy HH':'mm':'ss 'GMT'");
            lblDetail.Text = "";
            foreach (DetailFoodSelected foodSelected in detailFoodSelecteds)
            {
                lblDetail.Text += foodSelected.NameFood +" | " + foodSelected.size.ToString() +"\r\n";
            }
            lblTong.Text = userBookTick.GetPriceFood();
        }
        private void printBill_Load(object sender, EventArgs e)
        {
            setDetailToPrint();
        }
    }
}
