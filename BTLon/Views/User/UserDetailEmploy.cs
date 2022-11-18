using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserDetailEmploy : UserControl
    {
        DataGridView dgvNhanVien;
        Models.DataProcess Process;
        public UserDetailEmploy(DataGridView dgvNhanVien)
        {
            InitializeComponent();
            this.dgvNhanVien = dgvNhanVien;
            Process = new Models.DataProcess();
        }
        //Set
        public void setPictureBox(Image image)
        {
            ptbAvt.Image = image;
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                string MaNV = row.Cells[0].Value.ToString();
                ptbAvt.Image = Image.FromFile(openImage.FileName);
                Process.InsertImage(MaNV, ptbAvt.Image);
                MessageBox.Show("upload successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.ReadOnly = true;
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                string MaNV = row.Cells[0].Value.ToString();
                string sql = "Update tblNhanVien set Anh = null where MaNV = N'" + MaNV + "'";
                Process.DataChange(sql);
                MessageBox.Show("Delete successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
