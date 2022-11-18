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
        UserEmploy userEmploy;
        UserTicket userTicket;
        UserControl userRemove;
        FoodandDrink foodanddrink;
        Revenue revenue;
        Rank rank;
        Trend trend;
        UserTicketList ticketList;
        UserBillList userBilllist;
        public Main()
        {
            InitializeComponent();
            userEmploy = new UserEmploy(this);
            userTicket = new UserTicket();
            foodanddrink = new FoodandDrink();
            revenue = new Revenue();
            rank = new Rank();
            trend = new Trend();
            ticketList = new UserTicketList();
            userBilllist = new UserBillList();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            panelProfile.Visible = false;
            collapseMenu(true);
            panelProfile.Visible = false;
            
            //userRemove = userTicket;

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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu(true);
            ModelView.collapseChild(this.panelManage, false,84);
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            ModelView.collapseChild(this.panelManage, true, 210);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ModelView.collapseChild(this.panelProfile, true,84); 
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
            if (userRemove != userTicket)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, userTicket, DockStyle.Fill);
                userRemove = userTicket;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, userTicket, DockStyle.Fill);
                userRemove = userTicket;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnFD_Click(object sender, EventArgs e)
        {
            if (userRemove != foodanddrink)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, foodanddrink, DockStyle.Fill);
                userRemove = foodanddrink;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, foodanddrink, DockStyle.Fill);
                userRemove = foodanddrink;
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
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
        private void btnRank_Click(object sender, EventArgs e)
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

        private void btnTrend_Click(object sender, EventArgs e)
        {
            if (userRemove != trend)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove,trend, DockStyle.Fill);
                userRemove = trend;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, trend, DockStyle.Fill);
                userRemove = trend;
            }
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            ModelView.collapseChild(this.panelStatistical, true, 126);
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            //collapseMenu(false);
            //ModelView.collapseChild(this.panelStatistical, true, 126);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            collapseMenu(false);
            ModelView.collapseChild(this.panelReport, true, 84);
        }

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            if (userRemove != ticketList)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove, ticketList, DockStyle.Fill);
                userRemove = ticketList;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, ticketList, DockStyle.Fill);
                userRemove = ticketList;
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (userRemove != userBilllist)
            {
                Models.ModelView.addUserToPanel(panelContent, userRemove,userBilllist , DockStyle.Fill);
                userRemove = userBilllist;
            }
            else
            {
                Models.ModelView.addUserToPanel(panelContent, null, userBilllist, DockStyle.Fill);
                userRemove = userBilllist;
            }
        }
    }
}
