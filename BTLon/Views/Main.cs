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
using System.Windows.Documents;
using System.Windows.Forms;

namespace BTLon.Views
{
    public partial class Main : Form
    {
        UserEmploy userEmploy;
        UserTicket userTicket;
        UserControl userDetail;
        UserControl userRemove;
        UserControl userAccount;
        UserControl userKhachHang;
        Revenue revenue = new Revenue();
        Rank rank = new Rank();
        Trend trend = new Trend();
        TicketList ticketlist = new TicketList();
        BillList billlist = new BillList();
        FoodandDrink foodandDrink = new FoodandDrink();
        public Main()
        {
            InitializeComponent();
            userEmploy = new UserEmploy(this);
            userTicket = new UserTicket(this);
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
            panelContent.BackgroundImage = Models.ModelView.Images("anhbia.jpg");

            lblTenTK.Text = Login.tk;
            lblTenTK.Tag = Login.manv;
            panelProfile.Visible = false;
            collapseMenu(true);
            panelProfile.Visible = false;
        }
        //Set
        public void SetPanel()
        {
            panelContent.BackgroundImage = Models.ModelView.Images("anhbia.jpg");
            this.panelContent.Controls.Remove(userRemove);
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
             //   btnHome.Text = "";
                btnManage.Text = "";
                btnSales.Text = "";
                //btnImport.Text = "";
                btnExit.Text = "";
                //ptbLogo.Visible = false;
            }
            else
            {
                panelMenu.Width = panelMenu.MaximumSize.Width;
             //   btnHome.Text = btnHome.Tag.ToString();
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
        private void collapseChild(Panel panel, bool check, int height)
        {
            if (check == true)
            {
                if (panel.Visible == false)
                {
                    panel.Visible = true;
                    panel.Height = height;
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
            collapseChild(this.panelManage, false, 84);
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            collapseChild(this.panelManage, true,210);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            collapseChild(this.panelProfile, true,84); 
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            if (userRemove != userEmploy)
            {
                userEmploy = new UserEmploy(this);
                Models.ModelView.addUserToPanel(panelContent, userRemove, userEmploy, DockStyle.Fill);
                userRemove = userEmploy;
            }
            else
            {
                userEmploy = new UserEmploy(this);
                Models.ModelView.addUserToPanel(panelContent, null, userEmploy, DockStyle.Fill);
                userRemove = userEmploy;
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (userRemove != userTicket)
            {
                userTicket = new UserTicket(this);
                Models.ModelView.addUserToPanel(panelContent, userRemove, userTicket, DockStyle.Fill);
                userRemove = userTicket;
            }
            else
            {
                userTicket = new UserTicket(this);
                Models.ModelView.addUserToPanel(panelContent, null, userTicket, DockStyle.Fill);
                userRemove = userTicket;
            }
        }

        
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if(userRemove != userKhachHang)
            {
                userKhachHang = new UserKhachHang();
                ModelView.addUserToPanel(panelContent, userRemove, userKhachHang, DockStyle.Fill);
                userRemove = userKhachHang;
            }
            else
            {
                userKhachHang = new UserKhachHang();
                ModelView.addUserToPanel(panelContent, null, userKhachHang, DockStyle.Fill);
                userRemove = userKhachHang;
            }
        }

        private void btnFD_Click(object sender, EventArgs e)
        {
            if (userRemove != foodandDrink)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, foodandDrink, DockStyle.Fill);
                userRemove = foodandDrink;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, foodandDrink, DockStyle.Fill);
                userRemove = foodandDrink;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogOut)
            {
                Application.Exit();
            }
        }
        bool isLogOut = true;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isLogOut = false;  
            this.Hide();
         //   this.Close();
            Login dangnhap = new Login();
            dangnhap.ShowDialog();
            
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            collapseChild(this.panelStatitis, true, 126);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (userRemove != revenue)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, revenue, DockStyle.Fill);
                userRemove = revenue;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, revenue, DockStyle.Fill);
                userRemove = revenue;
            }
        }

        private void btnXepHang_Click(object sender, EventArgs e)
        {
            if (userRemove != rank)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, rank, DockStyle.Fill);
                userRemove = rank;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, rank, DockStyle.Fill);
                userRemove = rank;
            }
        }

        private void btnXuHuong_Click(object sender, EventArgs e)
        {
            if (userRemove != trend)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, trend, DockStyle.Fill);
                userRemove = trend;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, trend, DockStyle.Fill);
                userRemove = trend;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            collapseChild(this.panelReport, true, 84);
        }

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            if (userRemove != ticketlist)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, ticketlist, DockStyle.Fill);
                userRemove = ticketlist;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, ticketlist, DockStyle.Fill);
                userRemove = ticketlist;
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (userRemove != billlist)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, billlist, DockStyle.Fill);
                userRemove = billlist;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, billlist, DockStyle.Fill);
                userRemove = billlist;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (userRemove != userAccount)
            {
                userAccount = new UserAccount();
                Models.ModelView.addUserToPanel(panelContent, userRemove, userAccount, DockStyle.Fill);
                userRemove = userAccount;
            }
            else
            {
                userAccount = new UserAccount();
                Models.ModelView.addUserToPanel(panelContent, null, userAccount, DockStyle.Fill);
                userRemove = userAccount;
            }
        }

        private void btnDetailProfile_Click(object sender, EventArgs e)
        {
            if (userRemove != userDetail)
            {
                userDetail = new UserDetails();
                Models.ModelView.addUserToPanel(panelContent, userRemove, userDetail, DockStyle.Fill);
                userRemove = userDetail;
            }
            else
            {
                userDetail = new UserDetails();
                Models.ModelView.addUserToPanel(panelContent, null, userDetail, DockStyle.Fill);
                userRemove = userDetail;
            }
        }
    }
}
