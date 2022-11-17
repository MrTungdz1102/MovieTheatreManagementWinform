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
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        private void printPanel(FlowLayoutPanel flpanel)
        {
            PrinterSettings settings = new PrinterSettings();
            this.flPanelTicket = flpanel;
            getPrintArea(flpanel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.HasMorePages = true;
            Rectangle rectangle = e.PageBounds;
            e.Graphics.DrawImage(Bitmap, (rectangle.Width/100) - (this.flPanelTicket.Width/80), this.flPanelTicket.Location.Y);
        }
        private Bitmap Bitmap;
        private void getPrintArea(FlowLayoutPanel flpanel)
        {
            Bitmap = new Bitmap(flpanel.Width, flpanel.Height);
            flpanel.DrawToBitmap(Bitmap, new Rectangle(0, 0, flpanel.Width, flpanel.Height));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printPanel(this.flPanelTicket);
        }
    }
}
