using BTLon.Models;
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
    public partial class userListEmploy : UserControl
    {
        Models.DataProcess Process;
        UserDetailEmploy DetailEmploy;
        UserEmploy userEmploy;
        public userListEmploy(UserEmploy userEmploy)
        {
            InitializeComponent();
            Process = new DataProcess();
            DetailEmploy = new UserDetailEmploy(dgvNhanVien);
            this.userEmploy = userEmploy;
        }
        private void userListEmploy_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Get
        public DataGridView GetGridView()
        {
            return this.dgvNhanVien;
        }
        //Set
        public void SetGridView(DataGridView data)
        {
            this.dgvNhanVien = data;
        }
        //Code
        public void LoadData()
        {
            try
            {
                string sql = "select * from View1";
                cbMaPB.DataSource = Process.DataReader("select MaPB from tblPhongBan");
                cbMaPB.DisplayMember = "MaPB";
                ComboBox combo = new ComboBox();
                combo.DisplayMember = "MaPB";
                combo.Text = "Chọn phòng ban";
                combo.DataSource = Process.DataReader("select MaPB from tblPhongBan");
                userEmploy.SetComboBox(combo);
                dgvNhanVien.DataSource = Process.DataSetReader(sql, "tblNhanVien").Tables[0];
                dgvNhanVien.ReadOnly = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Error!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblNhanVien");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Image image = null;
                string MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                string sql = "select Anh from tblNhanVien where MaNV = N'" + MaNV + "'";
                DataTable dt = Process.DataReader(sql);
                object oj = dt.Rows[0][0];
                byte[] img = oj as byte[];
                image = ModelView.ByteArrayToImage(img);
                PictureBox pictureBox = new PictureBox();
                MessageBox.Show(dt.Rows.Count.ToString());
                DetailEmploy.setPictureBox(image);
            }
            catch (Exception)
            {
                Image image = null;
                string MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "False")
                {
                    image = ModelView.Images("avt.jpg");
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    DetailEmploy.setPictureBox(image);
                }
                else
                {
                    image = ModelView.Images("avtNu.jpg");
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    DetailEmploy.setPictureBox(image);
                }
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
