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
    public partial class UserTypeFilm : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailTypeFilm detailTypeFilm;
        public UserTypeFilm(Panel panelDetail, UserDetailTypeFilm detailTypeFilm)
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            this.panelDetail = panelDetail;
            this.detailTypeFilm = detailTypeFilm;
        }

        private void dgvLoaiPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDetail.Visible = true;
            string MaLP = dgvLoaiPhim .CurrentRow.Cells[0].Value.ToString();
            string TenLP = dgvLoaiPhim .CurrentRow.Cells[1].Value.ToString();
            string MoTa = dgvLoaiPhim .CurrentRow.Cells[2].Value.ToString();
            detailTypeFilm.setMaLP(MaLP);
            detailTypeFilm.setTenLP(TenLP);
            detailTypeFilm.setMoTa(MoTa);
        }

        public void LoadData()
        {
            string sql = "select * from tblLoaiPhim";
            dgvLoaiPhim.DataSource = Process.DataReader(sql);
            dgvLoaiPhim.ReadOnly = true;
        }
        private void UserTypeFilm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
