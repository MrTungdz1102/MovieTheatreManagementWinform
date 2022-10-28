using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string path(string name)
        {
            string path = Path.GetFullPath("Picture\\" + name);
            return path;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Image = Image.FromFile(path("iconRestore.png"));
                btnMax.ImageSize = new Size(15,15);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Image = Image.FromFile(path("iconMax.png"));
                btnMax.ImageSize = new Size(25, 25);
            }
        }
    }
}
