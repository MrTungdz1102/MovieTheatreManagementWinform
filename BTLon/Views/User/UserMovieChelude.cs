using BTLon.Controls;
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

namespace BTLon.Views.User
{
    public partial class UserMovieChelude : UserControl
    {
        DataProcess Process;
        Main main;
        UserDetailMovieChelude DetailMovieChelude;
        UserListMovieChelude ListMovieChelude;
        UserRoom userRoom;
        UserDetailRoom DetailRoom;
        UserDetailDay DetailDay;
        UserDay userDay;
        UserDetailHours DetailHour;
        UserHours userHour;
        UserControl userRemove1;
        UserControl userRemove2;
        DataGridView dgvLichChieu;
        public UserMovieChelude()
        {
            InitializeComponent();
            Process = new DataProcess();
            DetailRoom = new UserDetailRoom();
            userRoom = new UserRoom(this.panelDetail, DetailRoom);
            DetailDay = new UserDetailDay();
            userDay = new UserDay(this.panelDetail, DetailDay);
            DetailHour = new UserDetailHours();
            userHour = new UserHours(this.panelDetail, DetailHour);
            ListMovieChelude = new UserListMovieChelude(this.panelDetail, DetailMovieChelude);
            dgvLichChieu = ListMovieChelude.GetGridView();
            DetailMovieChelude = new UserDetailMovieChelude();
            this.main = main;
        }
        // get
        public Panel GetPanel()
        {
            return this.panelDetail;
        }
        //set
        /*public void SetComboBox(ComboBox combo)
        {
            this.cbPC = combo;
        }*/

        private void UserMovieChelude_Load(object sender, EventArgs e)
        {
            setTooltip(toolTipSave, btnSave, "Save");
            setTooltip(toolTipEdit, btnEdit, "Edit");
            setTooltip(toolTipAdd, btnAdd, "Add");
            setTooltip(toolTipDelete, btnDelete, "Delete");
            Models.ModelView.addUserToPanel(this.panelContent, null, ListMovieChelude, DockStyle.Fill);
            userRemove1 = ListMovieChelude;
            setPanelDetail(164, 521);
            panelDetail.Visible = false;
            LoadDataToComBo();
        }
        private void LoadDataToComBo()
        {
            string[] Menu = { "Phòng Chiếu", "Loại Ngày Chiếu", "Loại Giờ Chiếu" };
            foreach (string MenuItem in Menu)
            {
                cbPC.Items.Add(MenuItem);
            }
        }
        private void setPanelDetail(int with, int heigh)
        {
            panelDetail.Width = with;
            panelDetail.Height = heigh;
        }
        private void setTooltip(ToolTip tool, Guna2GradientButton button, string info)
        {
            this.toolTipSave.SetToolTip(button, info);
        }

        private void setEditPanelDetail(bool checkAllow, bool CheckRead)
        {
            dgvLichChieu.AllowUserToAddRows = checkAllow;
            dgvLichChieu.ReadOnly = CheckRead;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbPC.Text.ToString() == "Phòng Chiếu")
            {
                setEditPanelDetail(false, false);
                DetailRoom.setEnable(true);
                panelDetail.Visible = true;
            }
            if (cbPC.Text.ToString() == "Loại Ngày Chiếu")
            {
                setEditPanelDetail(false, false);
                DetailDay.setEnable(true);
                panelDetail.Visible = true;
            }
            if (cbPC.Text.ToString() == "Loại Giờ Chiếu")
            {
                setEditPanelDetail(false, false);
                DetailHour.setEnable(true);
                panelDetail.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListMovieChelude.UpdateData();
            DetailRoom.UpDateDataBase();
            DetailRoom.setEnable(false);
            DetailDay.UpDateDataBase();
            DetailDay.setEnable(false);
            DetailHour.UpDateDataBase();
            DetailHour.setEnable(false);
            setEditPanelDetail(false, false);
        }

        private void txtSeach_Load(object sender, EventArgs e)
        {
            txtSeach.Texts = "";
        }

        private void txtSeach_Leave(object sender, EventArgs e)
        {
            txtSeach.Texts = "Seach...";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEditPanelDetail(true, false);
            panelDetail.Visible = true;
        }

        private void txtSeach__TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ViewLC where MaLichChieu like N'%" + txtSeach.Texts + "%' or MaPhim like N'%" + txtSeach.Texts +
                "%' or MaPC like N'% " + txtSeach.Texts + "%' or LoaiNgay like N'% " + txtSeach.Texts + 
                "%' or LoaiGio like N'% " + txtSeach.Texts + "%'";
            dgvLichChieu.DataSource = Process.DataReader(sql);
        }

        private void cbPC_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbPC.Text.ToString() == "Phòng Chiếu")
            {
                Models.ModelView.addUserToPanel(this.panelContent, userRemove1, userRoom, DockStyle.Fill);
                Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailRoom, DockStyle.Fill);
                setMenuPC(false);
                setPanelDetail(282, 521);
                panelDetail.Visible = false;
            }
            if (cbPC.Text.ToString() == "Loại Ngày Chiếu")
            {
                Models.ModelView.addUserToPanel(this.panelContent, userRemove1, userDay, DockStyle.Fill);
                Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailDay, DockStyle.Fill);
                setMenuPC(false);
                setPanelDetail(282, 521);
                panelDetail.Visible = false;
            }
            if (cbPC.Text.ToString() == "Loại Giờ Chiếu")
            {
                Models.ModelView.addUserToPanel(this.panelContent, userRemove1, userHour, DockStyle.Fill);
                Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailHour, DockStyle.Fill);
                setMenuPC(false);
                setPanelDetail(282, 521);
                panelDetail.Visible = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvLichChieu.SelectedRows)
                {
                    try
                    {
                        string MaLC = row.Cells[0].Value.ToString();
                        string sql = "delete from tblLichChieu where MaLichChieu = N'" + MaLC + "'";
                        Process.DataChange(sql);
                        dgvLichChieu.Rows.Remove(row);
                    }
                    catch (Exception)
                    {
                        dgvLichChieu.AllowUserToAddRows = false;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListMovieChelude.LoadData();
            userRoom.LoadData();
            userDay.LoadData();
            userHour.LoadData();
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }
        private void setMenuPC(bool visit)
        {
            cbPC.Visible = visit;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelContent.Contains(userRoom) && panelDetail.Contains(DetailRoom))
            {
                if (panelDetail.Visible == false)
                {
                    Models.ModelView.addUserToPanel(this.panelContent, userRemove1, ListMovieChelude, DockStyle.Fill);
                    setPanelDetail(164, 521);
                    userRemove1 = ListMovieChelude;
                    Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailMovieChelude, DockStyle.Fill);
                    userRemove2 = DetailMovieChelude;
                    setMenuPC(true);
                }
                else
                {
                    panelDetail.Visible = false;
                }
            }
            else if (panelContent.Contains(ListMovieChelude) && panelDetail.Contains(DetailMovieChelude))
            {
                if (panelDetail.Visible == false)
                {
                    this.Controls.Clear();
                    main.SetPanel();
                }
                else
                {
                    panelDetail.Visible = false;
                }
            }

        }
    }
}
