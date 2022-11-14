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
        Main main;
        UserDetailEmploy DetailEmploy;
        userListEmploy ListEmploy;
        UserDetailDepart DetailDepart;
        UserDepart userDepart;
        UserControl userRemove1;
        UserControl userRemove2;
        DataGridView dgvNhanVien;
        public UserEmploy(Main main)
        {
            InitializeComponent();
            Process = new DataProcess();
            DetailDepart = new UserDetailDepart();
            userDepart = new UserDepart(this.panelDetail, DetailDepart);
            ListEmploy = new userListEmploy(this);
            dgvNhanVien = ListEmploy.GetGridView();
            DetailEmploy = new UserDetailEmploy(dgvNhanVien);
            this.main = main;
        }
        //Get
        public Panel GetPanel()
        {
            return this.panelDetail;
        }
        //set
        public void SetComboBox(ComboBox combo)
        {
            this.cbPB = combo;
        }
        //code
        private void UserEmploy_Load(object sender, EventArgs e)
        {
            setTooltip(toolTipSave, btnSave, "Save");
            setTooltip(toolTipEdit, btnEdit, "Edit");
            setTooltip(toolTipAdd, btnAdd, "Add");
            setTooltip(toolTipDelete,btnDelete, "Delete");
            Models.ModelView.addUserToPanel(this.panelContent, null, ListEmploy, DockStyle.Fill);
            Models.ModelView.addUserToPanel(this.panelDetail,null, DetailEmploy, DockStyle.Fill);
            userRemove1 = ListEmploy;
            userRemove2 = DetailEmploy;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEditPanelDetail(false, false);
            DetailDepart.setEnable(true);
            panelDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListEmploy.UpdateData();   
            DetailDepart.UpDateDataBase();
            DetailDepart.setEnable(false);
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListEmploy.LoadData();
            userDepart.LoadData();
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }
        private void setMenuPB(bool visit)
        {
            cbPB.Visible = visit;
            btnAddPB.Visible = visit;
        }
        private void btnAddPB_Click(object sender, EventArgs e)
        {
            Models.ModelView.addUserToPanel(this.panelContent,userRemove1,userDepart, DockStyle.Fill);
            Models.ModelView.addUserToPanel(this.panelDetail,userRemove2, DetailDepart, DockStyle.Fill);
            userRemove1 = userDepart;
            userRemove2 = DetailDepart;
            setMenuPB(false);
            setPanelDetail(282, 521);
            panelDetail.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelContent.Contains(userDepart) && panelDetail.Contains(DetailDepart))
            {
                if (panelDetail.Visible == false)
                {
                    Models.ModelView.addUserToPanel(this.panelContent, userRemove1, ListEmploy, DockStyle.Fill);
                    setPanelDetail(164, 521);
                    userRemove1 = ListEmploy;
                    Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailEmploy, DockStyle.Fill);
                    userRemove2 = DetailEmploy;
                    setMenuPB(true);
                }
                else
                {
                    panelDetail.Visible = false;
                }
            }else if(panelContent.Contains(ListEmploy) && panelDetail.Contains(DetailEmploy))
            {
                if(panelDetail.Visible == false)
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
