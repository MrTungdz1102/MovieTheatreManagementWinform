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
    public partial class UserDetailManageFilm : UserControl
    {
        DataGridView dgvPhim;
        Models.DataProcess Process;
        public UserDetailManageFilm(DataGridView dgvPhim)
        {
            InitializeComponent();
            this.dgvPhim = dgvPhim;
            Process = new Models.DataProcess();

        }
        //Set
        public void setPictureBox(Image image)
        {
            ptbAnh.Image = null;
            ptbAnh.Image = image;
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = dgvPhim.CurrentRow;
                string MaPhim = row.Cells[0].Value.ToString();
                ptbAnh.Image = Image.FromFile(openImage.FileName);
                Process.InsertImage(MaPhim, ptbAnh.Image);
                MessageBox.Show("upload successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhim.ReadOnly = true;
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = dgvPhim.CurrentRow;
                string MaPhim = row.Cells[0].Value.ToString();
                string sql = "Update tblPhim set Anh = null where MaPhim = N'" + MaPhim + "'";
                Process.DataChange(sql);
                MessageBox.Show("Delete successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {

        }
    }
}
