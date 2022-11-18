using BTLon.Models;
using BTLon.Views.User;
using Guna.UI2.WinForms;
using Microsoft.Win32;
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
        UserEmploy userEmploy;
        UserTicket userTicket;
        UserControl userRemove;
        UserDetails userDetails;
        public Main()
        {
            InitializeComponent();
            userEmploy = new UserEmploy(this);
            userTicket = new UserTicket();
          
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (Login.quyen == 1)
            {
                ptbAvt.Image = Models.ModelView.Images("nam.jpg");
            }
            else
            {
                ptbAvt.Image = Models.ModelView.Images("nu.jpg");
            }
            panelProfile.Visible = false;
            collapseMenu(true);
            panelProfile.Visible = false;
            Models.ModelView.addUserToPanel(panelContent, null, userTicket, DockStyle.Fill);
            userRemove = userTicket;
            lblTenTK.Text =  Login.tk;
        }
        //Set
        public void SetPanel()
        {
            this.panelContent.Controls.Clear();
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
        private void LoadUserControl(UserControl us)
        {
            us.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(us);
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
                btnSales.Text = "";
                //btnImport.Text = "";
                btnExit.Text = "";
                //ptbLogo.Visible = false;
            }
            else
            {
                panelMenu.Width = panelMenu.MaximumSize.Width;
                btnHome.Text = btnHome.Tag.ToString();
                btnManage.Text = btnManage.Tag.ToString();
                btnSales.Text = btnSales.Tag.ToString();
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
            collapseChild(this.panelSales, false);
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

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            if (userRemove != userEmploy)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, userEmploy, DockStyle.Fill);
                userRemove = userEmploy;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, userEmploy, DockStyle.Fill);
                userRemove = userEmploy;
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            collapseChild(this.panelSales, true);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            //UserTicket userTicket = new UserTicket();
            //LoadUserControl(userTicket);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }
        bool isLogOut = true;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            isLogOut = false;
            this.Close();
            Login dangnhap = new Login();
            dangnhap.Show();
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isLogOut)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
              LoadUserControl(new UserDetails());
                //Models.ModelView.addUserToPanel(panelContent, userRemove, userDetails, DockStyle.Fill);
                //userRemove = userDetails;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
         //  LoadUserControl(new UserAccount());
        }

        private void lblTenTK_Click(object sender, EventArgs e)
        {

        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {

        }
    }
}
