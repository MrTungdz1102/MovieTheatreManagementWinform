using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BTLon.Views.User
{
    public partial class UserEmploy : UserControl
    {
        DataProcess Process;
        UserDetailEmploy employ;
        UserDetailDepart depart;
        UserDepart userDepart;
        public UserEmploy()
        {
            InitializeComponent();
            Process = new DataProcess();
            employ = new UserDetailEmploy(this.dgvNhanVien);
            depart = new UserDetailDepart();
            userDepart = new UserDepart(this.panelDetail,depart);
        }
        public Panel GetPanel()
        {
            return this.panelDetail;
        }
        private void UserEmploy_Load(object sender, EventArgs e)
        {
            setTooltip(toolTipSave, btnSave, "Save");
            setTooltip(toolTipEdit, btnEdit, "Edit");
            setTooltip(toolTipAdd, btnAdd, "Add");
            setTooltip(toolTipDelete,btnDelete, "Delete");
            LoadData();
            setUser();
            addUserToPanelDetail(employ);
            setPanelDetail(164, 521);
            panelDetail.Visible = false;
        }
        private void setPanelDetail(int with,int heigh)
        {
            panelDetail.Width = with;
            panelDetail.Height = heigh;
        }
        private void setTooltip(ToolTip tool,Guna2GradientButton button, string info)
        {
            this.toolTipSave.SetToolTip(button, info);
        }

        private void setEditPanelDetail(bool checkAllow, bool CheckRead)
        {
            dgvNhanVien.AllowUserToAddRows = checkAllow;
            dgvNhanVien.ReadOnly = CheckRead;
        }
        private void LoadData()
        {
            string sql = "select * from View1";
            cbMaPB.DataSource = Process.DataReader("select MaPB from tblPhongBan");
            cbMaPB.DisplayMember = "MaPB";
            cbPB.DataSource = Process.DataReader("select MaPB from tblPhongBan");
            cbPB.DisplayMember = "MaPB";
            cbPB.Text = "Chọn phòng ban";
            dgvNhanVien.DataSource = Process.DataSetReader(sql,"tblNhanVien").Tables[0];
            dgvNhanVien.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEditPanelDetail(false, false);
            depart.setEnable(true);
            panelDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Process.DataSetChange("tblNhanVien");
            depart.UpDateDataBase();
            depart.setEnable(false);
            setEditPanelDetail(false, false);
        }

        private void txtSeach_Click(object sender, EventArgs e)
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
            string sql = "select * from View1 where DiaChi like N'%" + txtSeach.Texts + "%'";
            dgvNhanVien.DataSource = Process.DataReader(sql);
        }
        private void cbPB_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from View1 where MaPB = N'" + cbPB.Text + "'";
            dgvNhanVien.DataSource = Process.DataReader(sql);
            dgvNhanVien.ReadOnly = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
                {
                    try
                    {
                        string MaNV = row.Cells[0].Value.ToString();
                        string sql = "delete from tblNhanVien where MaNV = N'" + MaNV + "'";
                        Process.DataChange(sql);
                        dgvNhanVien.Rows.Remove(row);
                    }
                    catch (Exception ex)
                    {
                        dgvNhanVien.AllowUserToAddRows = false;
                    }
                }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Image image = null;
            try { 
                string MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                string sql = "select Anh from tblNhanVien where MaNV = N'" +MaNV + "'";
                DataTable dt = Process.DataReader(sql);
                object oj = dt.Rows[0][0];
                byte[] img = oj as byte[];
                image = ModelView.ByteArrayToImage(img);
                employ.setPictureBox(image);
            }catch(Exception ex)
            {
                if(dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    image = ModelView.Images("avt.jpg");
                    employ.setPictureBox(image);
                }
                else
                {
                    image = ModelView.Images("avtNu.jpg");
                    employ.setPictureBox(image);
                }
            }
        }

        private void btnDeleImg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                string MaNV = row.Cells[0].Value.ToString();
                string sql = "Update tblNhanVien set Anh = null where MaNV = N'" + MaNV + "'";
                Process.DataChange(sql);
                MessageBox.Show("upload successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            userDepart.LoadData();
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }
        private void addUserToPanelDetail(UserControl user)
        {
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(user);
        }
        private void setMenuPB(bool visit)
        {
            cbPB.Visible = visit;
            btnAddPB.Visible = visit;
        }
        private void setUser()
        {
           userDepart.Dock = DockStyle.Fill;
           employ.Dock = DockStyle.Fill;
           depart.Dock = DockStyle.Fill;
        }
        private void btnAddPB_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(userDepart);
            addUserToPanelDetail(depart);
            setMenuPB(false);
            setPanelDetail(282, 521);
            panelDetail.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dgvNhanVien);
            setPanelDetail(164, 521);
            addUserToPanelDetail(employ);
            setMenuPB(true);
            panelDetail.Visible = false;
        }
    }
}
