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
    public partial class UserManageFilm : UserControl
    {
        DataProcess Process;
        Main main;
        UserDetailManageFilm detailFilm;
        UserManageListFilm listFilm;
        UserDetailTypeFilm detailtypeFilm;
        UserTypeFilm typeFilm;
        UserControl userRemove1;
        UserControl userRemove2;
        DataGridView dgvPhim;
        public UserManageFilm()
        {
            InitializeComponent();
            detailtypeFilm = new UserDetailTypeFilm();
            typeFilm = new UserTypeFilm(this.panelDetail, detailtypeFilm);
            listFilm = new UserManageListFilm(this);
            dgvPhim = listFilm.GetGridView();
            detailFilm = new UserDetailManageFilm(dgvPhim);
            this.main = main;
        }
        public void SetComboBox(ComboBox combo)
        {
            this.cbbLP = combo;
        }
        private void UserManageFilm_Load(object sender, EventArgs e)
        {
            setTooltip(toolTipSave, btnSave, "Save");
            setTooltip(toolTipEdit, btnEdit, "Edit");
            setTooltip(toolTipAdd, btnAdd, "Add");
            setTooltip(toolTipDelete, btnDelete, "Delete");
            Models.ModelView.addUserToPanel(this.panelContent, null, listFilm, DockStyle.Fill);
            Models.ModelView.addUserToPanel(this.panelDetail, null, detailFilm, DockStyle.Fill);
            userRemove1 = listFilm;
            userRemove2 = detailFilm;
            setPanelDetail(164, 521);
            panelDetail.Visible = false;
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
            dgvPhim.AllowUserToAddRows = checkAllow;
            dgvPhim.ReadOnly = CheckRead;
        }
        private void setMenuPB(bool visit)
        {
            cbbLP.Visible = visit;
            btnAddPB.Visible = visit;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listFilm.LoadData();
            typeFilm.LoadData();
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEditPanelDetail(false, false);
            detailtypeFilm.setEnable(true);
            panelDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listFilm.UpdateData();
            detailtypeFilm.UpDateDataBase();
            detailtypeFilm.setEnable(false);
            setEditPanelDetail(false, false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEditPanelDetail(true, false);
            panelDetail.Visible = true;
        }

        private void cbbLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from ViewPhim where MaPB = N'" + cbbLP.Text + "'";
            dgvPhim.DataSource = Process.DataReader(sql);
            dgvPhim.ReadOnly = true;
        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            txtSeach.Texts = "";
        }

        private void txtSeach__TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ViewPhim where TenPhim like N'%" + txtSeach.Texts + "%'";
            dgvPhim.DataSource = Process.DataReader(sql);
        }

        private void txtSeach_Leave(object sender, EventArgs e)
        {
            txtSeach.Texts = "Seach...";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    foreach (DataGridViewRow row in dgvPhim.SelectedRows)
            //    {
            //        try
            //        {
            //            string MaNV = row.Cells[0].Value.ToString();
            //            string sql = "delete from tblPhim where MaPhim = N'" + MaPhim + "'";
            //            Process.DataChange(sql);
            //            dgvPhim.Rows.Remove(row);
            //        }
            //        catch (Exception ex)
            //        {
            //            dgvPhim.AllowUserToAddRows = false;
            //        }
            //    }
            //}
        }

        private void btnAddPB_Click(object sender, EventArgs e)
        {
            Models.ModelView.addUserToPanel(this.panelContent, userRemove1, typeFilm, DockStyle.Fill);
            Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, detailtypeFilm, DockStyle.Fill);
            userRemove1 = typeFilm;
            userRemove2 = detailtypeFilm;
            setMenuPB(false);
            setPanelDetail(282, 521);
            panelDetail.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelContent.Contains(typeFilm) && panelDetail.Contains(detailtypeFilm))
            {
                if (panelDetail.Visible == false)
                {
                    Models.ModelView.addUserToPanel(this.panelContent, userRemove1, listFilm, DockStyle.Fill);
                    setPanelDetail(164, 521);
                    userRemove1 = listFilm;
                    Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, detailFilm, DockStyle.Fill);
                    userRemove2 = detailFilm;
                    setMenuPB(true);
                }
                else
                {
                    panelDetail.Visible = false;
                }
            }
            else if (panelContent.Contains(listFilm) && panelDetail.Contains(detailFilm))
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
