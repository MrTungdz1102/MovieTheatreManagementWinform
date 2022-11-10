using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace BTLon.Views.User
{
    public partial class UserTicket : UserControl
    {
        Models.DataProcess Process = new Models.DataProcess();
        public UserTicket()
        {
            InitializeComponent();
        }
        private void UserTicket_Load(object sender, EventArgs e)
        {
            DataTable dt = Process.DataReader("select Anh from tblPhim");
            addListPicture(this.PanelListFilm, dt);
        }
        private void addListPicture(FlowLayoutPanel panelPicture, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Panel pan = new Panel();
                PictureBox picture = new PictureBox();
                Panel panel1 = new Panel();
                Panel panel2 = new Panel();
                Panel panel3 = new Panel();
                panel3.Dock = DockStyle.Fill;
                Guna2GradientButton button = new Guna2GradientButton();               
                pan = Models.ModelView.GetPanel(168, 274, Color.White, DockStyle.None, 10, BorderStyle.FixedSingle);
                object oj = table.Rows[i][0];
                byte[] img = oj as byte[];
                Image image = ModelView.ByteArrayToImage(img);
                picture = Models.ModelView.GetPictureBox(168, 244, DockStyle.Top, PictureBoxSizeMode.StretchImage, image);
                button = Models.ModelView.GetButton(DockStyle.Fill, 5, Color.Red);
                button.Click += BtnTicketClick;
                panel1 = Models.ModelView.GetPanel(10, 26, Color.White, DockStyle.Right,3, BorderStyle.None); 
                panel2 = Models.ModelView.GetPanel(63, 26, Color.White, DockStyle.Right,3, BorderStyle.None);
                pan.Controls.Add(panel3);
                pan.Controls.Add(picture);
                panel3.Controls.Add(panel2);
                panel3.Controls.Add(panel1);
                panel2.Controls.Add(button);
                panelPicture.Controls.Add(pan);
            }
        }
        private void BtnTicketClick(object sender, EventArgs e)
        {
            Guna2GradientButton button = (Guna2GradientButton)sender;
            UserBookTick bookTick = new UserBookTick();
            bookTick.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(bookTick);

        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Models.ModelView.collapseChild(this.panelPhim, true, 56);
        }
    }
}
