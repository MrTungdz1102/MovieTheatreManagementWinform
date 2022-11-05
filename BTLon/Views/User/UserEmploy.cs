﻿using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public UserEmploy()
        {
            InitializeComponent();
            Process = new DataProcess();
        }

        private void UserEmploy_Load(object sender, EventArgs e)
        {
            setTooltip(toolTipSave, btnSave, "Save");
            setTooltip(toolTipEdit, btnEdit, "Edit");
            setTooltip(toolTipAdd, btnAdd, "Add");
            setTooltip(toolTipDelete,btnDelete, "Delete");
            LoadData();
            panelDetail.Visible = false;
        }

        private void setTooltip(ToolTip tool,Guna2GradientButton button, string info)
        {
            this.toolTipSave.SetToolTip(button, info);
        }

        private void LoadData()
        {
            string sql = "select * from View1";
            cbMaPB.DataSource = Process.DataReader("select MaPB from tblPhongBan");
            cbMaPB.DisplayMember = "MaPB";
            cbPB.DataSource = Process.DataReader("select MaPB from tblPhongBan");
            cbPB.DisplayMember = "MaPB";
            cbPB.Text = "Chọn phòng ban";
            dgvNhanVien.DataSource = Process.DataReader(sql);
            dgvNhanVien.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvNhanVien.ReadOnly = false;
            dgvNhanVien.AllowUserToAddRows = false;
            panelDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.AllowUserToAddRows = false;
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
            dgvNhanVien.AllowUserToAddRows = true;
            dgvNhanVien.ReadOnly = false;
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
                    string MaNV = row.Cells[0].Value.ToString();
                    string sql = "delete from tblNhanVien where MaNV = N'" + MaNV + "'";
                    Process.DataChange(sql);
                    dgvNhanVien.Rows.Remove(row);
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(openImage.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                string MaNV = row.Cells[0].Value.ToString();
                ptbAvt.Image = Image.FromFile(openImage.FileName);
                Process.InsertImage(MaNV, ptbAvt.Image);
                MessageBox.Show("upload successfully","Notify", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDetail.Visible = true;
            try { 
                string MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                string sql = "select Anh from tblNhanVien where MaNV = N'" +MaNV + "'";
                DataTable dt = Process.DataReader(sql);
                object oj = dt.Rows[0][0];
                byte[] img = oj as byte[];
                ptbAvt.Image = ModelView.ByteArrayToImage(img);
            }catch(Exception ex)
            {
                if(dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    ptbAvt.Image = ModelView.Images("avt.jpg");
                }
                else
                {
                    ptbAvt.Image = ModelView.Images("avtNu.jpg");
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
            panelDetail.Visible = false;
            txtSeach.Texts = "Seach...";
        }

        private void btnAddPB_Click(object sender, EventArgs e)
        {
            UserDepart userDepart = new UserDepart();
            userDepart.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(userDepart);
            cbPB.Visible = false;
        }
    }
}
