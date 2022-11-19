using BTLon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserListMovieChelude : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailMovieChelude movieChelude;
        public UserListMovieChelude(Panel panelDetail, UserDetailMovieChelude movieChelude)
        {
            InitializeComponent();
            Process = new DataProcess();
            this.panelDetail = panelDetail;
            this.movieChelude = movieChelude;
        }
   
        public void LoadData()
        {
            try
            {
                string sql = "select * from ViewLC";
                dgvLichChieu.DataSource = Process.DataReader(sql);
                dgvLichChieu.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserListMovieChelude_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Get
        public DataGridView GetGridView()
        {
            return this.dgvLichChieu;
        }
        //Set
         public void SetGridView(DataGridView data)
        {
            this.dgvLichChieu = data;
        }
        //Code

        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblLichChieu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           panelDetail.Visible = true;
            string MaLichChieu = dgvLichChieu.CurrentRow.Cells[0].Value.ToString();
            string MaPhim = dgvLichChieu.CurrentRow.Cells[1].Value.ToString();
            string MaPC = dgvLichChieu.CurrentRow.Cells[2].Value.ToString();
            string NgayChieu = dgvLichChieu.CurrentRow.Cells[3].Value.ToString();
            string GioBD = dgvLichChieu.CurrentRow.Cells[4].Value.ToString();
            string LoaiNgay = dgvLichChieu.CurrentRow.Cells[5].Value.ToString();
            string LoaiGio = dgvLichChieu.CurrentRow.Cells[6].Value.ToString();
            string GiaLC = dgvLichChieu.CurrentRow.Cells[7].Value.ToString();

            /*movieChelude.setMaLichChieu(MaLichChieu);
            movieChelude.setMaPhim(MaPhim);
            movieChelude.setMaPC(MaPC);
            movieChelude.setNgayChieu(NgayChieu);
            movieChelude.setGioBD(GioBD);
            movieChelude.setLoaiNgay(LoaiNgay);
            movieChelude.setLoaiGio(LoaiGio);
            movieChelude.setGiaLC(GiaLC);*/
        }
    }
}
