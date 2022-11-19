using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserShowTimes : UserControl
    {
        DataProcess Process;
        string MaPhim = null;
        string calendar = null;
        UserBookTick BookTick;
        UserTicket ticket;
        public UserShowTimes()
        {
            InitializeComponent();
            Process = new DataProcess();
            BookTick = new UserBookTick();
        }

        private void UserShowTimes_Load(object sender, EventArgs e)
        {
            setCalendar();
        }
        //Set
        private void setCalendar()
        {
            DateTime min = DateTime.Today;
            Calendar.MinDate = min;
            DateTime max = DateTime.Today.AddDays(30);
            Calendar.MaxDate = max;
        }
        public void SetMaPhim(string MaPhim)
        {
            this.MaPhim = MaPhim;
        }
        public void SetPanelListButton()
        {
            panelListButton.Controls.Clear();
        }
        public void setUserTicket(UserTicket userTicket)
        {
            this.ticket = userTicket;
        }
        public void setUserBookTick(UserBookTick bookTick)
        {
            this.BookTick = bookTick;
        }
        public void setLabelTGC(string text)
        {
            this.lblThoiGianChieu.Text = text;
        }
        //Code
        private void addListButton(FlowLayoutPanel panelButton, DataTable table) //add thời gian chiếu vào panel
        {
            panelButton.Controls.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Guna2GradientButton button = new Guna2GradientButton();
                string GioChieu = table.Rows[i][0].ToString();
                button = Models.ModelView.GetButton(DockStyle.None, 5, Color.White, GioChieu);
                button.BorderThickness = 1;
                button.BorderColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
                button.Size = new Size(95, 35);
                button.ForeColor = SystemColors.ControlText;
                if (table.Rows.Count == 1)
                {
                    button.Margin = new Padding(360, 3, 3, 3);
                }
                else
                {
                    button.Margin = new Padding(200, 3, 3, 3);
                }
                button.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                button.Click += btnTimes_Click;
                panelButton.Controls.Add(button);
            }
        }
        private void btnTimes_Click(object sender, EventArgs e) // sự kiện người dùng click vào thời gian chiếu để hiện ra phần book ticket
        {
            Guna2GradientButton button = (Guna2GradientButton)sender;
            BookTick.SetButton();
            BookTick.SetLabelTGC(button.Text);
            DataTable data = getPhongChieu(button.Text);
            BookTick.SetLabelPC(data.Rows[0][0].ToString(), data.Rows[0][1].ToString()); //Set tên phòng chiếu và mã lịch chiếu
            BookTick.GetAndSetControls();
            Models.ModelView.addUserToPanel(ticket.GetPanelContent(), this, BookTick, DockStyle.Fill);
            ticket.setUserRemove(BookTick);
        }
        private DataTable GetDataTable(string calendar) //Lấy những giờ có trong ngày chiếu mà người dùng chọn
        {
            string sql = "select * from dbo.ThongTinLC(N'" + MaPhim + "',N'" + calendar + "')";
            DataTable dt = new DataTable();
            dt = Process.DataReader(sql);
            return dt;
        }
        private DataTable getPhongChieu(string ThoiGianChieu) //Hàm này để lấy tên phòng chiếu
        {
            //Check thông tin bán vé: nếu vé đã từng có lịch chiếu mình vừa chọn thì sẽ check thông tin ghế trống
            try
            {
                string sql = "select * from dbo.ThongTinPC_2(N'" + MaPhim + "',N'" + calendar + "')";
                DataTable data = Process.DataReader(sql);
                BookTick.MaLC = data.Rows[0][1].ToString();
                return data;
            }
            //nếu không có vé nào chứa lịch chiếu đó thì tức là phòng đó đang trống
            catch (Exception)
            {
                string sql = "select * from dbo.ThongTinPC(N'" + MaPhim + "',N'" + calendar + "',N'" + ThoiGianChieu + "')";
                DataTable data = Process.DataReader(sql);
                return data;
            }
        }
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)// chiếu ra những giờ chiếu trong ngày mà người dùng chọn lên panel
        {
            calendar = Calendar.SelectionEnd.ToString("yyyy/MM/dd");
            BookTick.SetLabelNgayChieu(calendar);
            DataTable detailPhim = GetDataTable(calendar);
            if (detailPhim.Rows.Count > 0)
            {
                lblThoiGianChieu.Text = "Chọn thời gian chiếu";
                addListButton(this.panelListButton, detailPhim);
            }
            else
            {
                panelListButton.Controls.Clear();
                lblThoiGianChieu.Text = "Không có lịch chiếu";
            }
        }
    }
}
