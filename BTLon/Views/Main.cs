using BTLon.Models;
using BTLon.Views.User;
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
        private void Main_Load(object sender, EventArgs e)
        {
            panelProfile.Visible = false;
            collapseMenu(true);
            UserEmploy userEmploy = new UserEmploy();
            userEmploy.Dock = DockStyle.Fill;
            panelContent.Controls.Add(userEmploy);
            panelProfile.Visible = false;
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
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMax.Image = ModelView.Images("iconRestore.png");
                this.WindowState = FormWindowState.Maximized;
                btnMax.ImageSize = new Size(15,15);
            }
            else
            {
                btnMax.Image = ModelView.Images("iconMax.png");
                this.WindowState = FormWindowState.Normal;
                btnMax.ImageSize = new Size(25, 25);
            }
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        private void setMenu(bool check)
        {
            if (check == true)
            {
                panelMenu.Width = panelMenu.MinimumSize.Width;
                btnHome.Text = "";
                btnManage.Text = "";
                //btnSales.Text = "";
                //btnImport.Text = "";
                btnExit.Text = "";
                //ptbLogo.Visible = false;
            }
            else
            {
                panelMenu.Width = panelMenu.MaximumSize.Width;
                btnHome.Text = btnHome.Tag.ToString();
                btnManage.Text = btnManage.Tag.ToString();
                //btnSales.Text = btnSales.Tag.ToString();
                //btnImport.Text = btnImport.Tag.ToString();
                btnExit.Text = btnExit.Tag.ToString();
                //ptbLogo.Visible = true;
            }
        }
        private void collapseMenu(bool check)
        {
            if (check == true)
            {
                if (this.panelMenu.Width > 100)
                {
                    setMenu(true);
                }
                else
                {
                    setMenu(false);
                }
            }
            else
            {
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    setMenu(false);
                }
            }
        }
        private void collapseChild(Panel panel, bool check)
        {
            if (check == true)
            {
                if (panel.Visible == false)
                {
                    panel.Visible = true;
                    panel.Height = 84;
                }
                else
                {
                    panel.Visible = false;
                }
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu(true);
            collapseChild(this.panelManage, false);
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            collapseChild(this.panelManage, true);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            collapseChild(this.panelProfile, true); 
        }
    }
}
