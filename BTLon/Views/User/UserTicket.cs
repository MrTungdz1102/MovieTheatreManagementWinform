using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace BTLon.Views.User
{
    public partial class UserTicket : UserControl
    {
        Models.DataProcess Process;
        UserListFilm film;
        UserBookTick bookTick;
        UserControl userRemove;
        List<PictureBox> pictureBoxes;
        public UserTicket()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            film = new UserListFilm();
            bookTick = new UserBookTick();
            pictureBoxes = new List<PictureBox>();
        }
        private void UserTicket_Load(object sender, EventArgs e)
        {
            string sql = "select * from Phim_PC_Hot";
            loadUser(sql);
        }
        private void loadUser(string sql)
        {
            DataTable dt = Process.DataReader(sql);
            addListPicture(film.getflPanel(), dt);
            Models.ModelView.addUserToPanel(panelContent,null,film, DockStyle.Fill);
            userRemove = film;
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
                object oj = table.Rows[i][6]; //Lấy byte của ảnh
                byte[] img = oj as byte[];
                Image image = ModelView.ByteArrayToImage(img);
                picture = Models.ModelView.GetPictureBox(168, 244, DockStyle.Top, PictureBoxSizeMode.StretchImage, image);
                picture.Tag = table.Rows[i][0].ToString(); //Lấy mã phim
                pictureBoxes.Add(picture);
                button = Models.ModelView.GetButton(DockStyle.Fill, 5, Color.Red);
                button.Tag = table.Rows[i][0].ToString() + "," + table.Rows[i][1].ToString() + "," + table.Rows[i][2].ToString();
                button.Tag +=","+ table.Rows[i][3].ToString() + "," + table.Rows[i][4].ToString() + "," + table.Rows[i][5].ToString();
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
        //Click để đặt vé
        private void BtnTicketClick(object sender, EventArgs e)
        {
            Guna2GradientButton button = (Guna2GradientButton)sender;
            Models.ModelView.addUserToPanel(panelContent, userRemove, bookTick, DockStyle.Fill);
            userRemove = bookTick;
            string []TenPC;
            TenPC = button.Tag.ToString().Split(',');
            bookTick.SetLabelPhim(TenPC[1]); // Lấy tên phim
            bookTick.SetLabelPC(TenPC[2]); // Lấy tên phòng chiếu
            bookTick.SetLabelTGC(TenPC[4],TenPC[3]); // Lấy thời gian chiếu và mã lịch chiếu
            bookTick.SetLabelNgayChieu(TenPC[5]); // Lấy ngày chiếu
            foreach(PictureBox picture in pictureBoxes)
            {
                if(picture.Tag.ToString() == TenPC[0])
                {
                    bookTick.SetPictureBox(picture.Image);
                }
            }
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Models.ModelView.collapseChild(this.panelPhim, true, 84);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelContent.Contains(bookTick))
            {
                Models.ModelView.addUserToPanel(this.panelContent,userRemove,film,DockStyle.Fill);
                userRemove = film;
            }
        }
        private void btnShowing_Click(object sender, EventArgs e)
        {
            string sql = "select * from Phim_PC";
            film.SetPanel(701);
            film.SetLabel("Phim đang chiếu");
            loadUser(sql);
        }
    }
}
