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
    public partial class UserDepart : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailDepart depart;
        public UserDepart(Panel panelDetail,UserDetailDepart depart)
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            this.panelDetail = panelDetail;
            this.depart = depart;
        }
        public DataGridView GetDataGridView()
        {
            return this.dgvPhongBan;
        }
        private void UserDepart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string sql = "select * from tblPhongBan";
            dgvPhongBan.DataSource = Process.DataReader(sql);
            dgvPhongBan.ReadOnly = true;
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDetail.Visible = true;
            string MaPB = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            string TenPB = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            string QuanLy = dgvPhongBan.CurrentRow.Cells[2].Value.ToString();
            depart.setMaPB(MaPB);
            depart.setTenPB(TenPB);
            depart.setQuanLy(QuanLy);
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
