using BTLon.Models;
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
    public partial class UserManageListFilm : UserControl
    {
        Models.DataProcess Process;
        UserDetailManageFilm DetailManageFilm;
        UserManageFilm userManageFilm;

        public UserManageListFilm(UserManageFilm userManageFilm)
        {
            InitializeComponent();
            Process = new DataProcess();
            DetailManageFilm = new UserDetailManageFilm();
            this.userManageFilm = userManageFilm;
        }
       
        private void userListManageFilm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Get
        public DataGridView GetGridView()
        {
            return this.dgvPhim;
        }
        //Set
        public void SetGridView(DataGridView data)
        {
            this.dgvPhim = data;
        }
        //Code
        public void LoadData()
        {
            try
            {
                string sql = "select * from ViewFilm";
               
                ComboBox combo = new ComboBox();
                combo.Text = "Chọn loại phim";
                combo.DisplayMember = "MaLP";
                combo.DataSource = Process.DataReader("select MaLP from tblLoaiPhim");
                //userManageFilm.SetCombo(combo);
                dgvPhim.DataSource = Process.DataSetReader(sql, "tblPhim").Tables[0];
                dgvPhim.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblPhim");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Image image = null;
                string MaPhim = dgvPhim.CurrentRow.Cells[0].Value.ToString();
                string sql = "select Anh from tblPhim where MaPhim = N'" + MaPhim + "'";
                DataTable dt = Process.DataReader(sql);
                object oj = dt.Rows[0][0];
                byte[] img = oj as byte[];
                image = ModelView.ByteArrayToImage(img);
                PictureBox pictureBox = new PictureBox();
                MessageBox.Show(dt.Rows.Count.ToString());
                DetailManageFilm.setPictureBox(image);
            }
            catch (Exception)
            {
                
            }
        }

    }
}
