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
    public partial class UserRoom : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailRoom room;
        public UserRoom(Panel panelDetail, UserDetailRoom room)
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            this.panelDetail = panelDetail;
            this.room = room;
        }
       /* public DataGridView GetDataGridView()
        {
            return this.dgvPhongChieu;
        }*/
        
        public void LoadData()
        {
            string sql = "Select * From tblPhongChieu";
            dgvPhongChieu.DataSource = Process.DataReader(sql);
            dgvPhongChieu.ReadOnly = true;
        }
        private void UserRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblPhongChieu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDetail.Visible = true;
            string MaPC = dgvPhongChieu.CurrentRow.Cells[0].Value.ToString();
            string TenPC = dgvPhongChieu.CurrentRow.Cells[1].Value.ToString();
            string SoLuongGhe = dgvPhongChieu.CurrentRow.Cells[2].Value.ToString();
            room.setMaPC(MaPC);
            room.setTenPC(TenPC);
            room.setSoLuongGhe(SoLuongGhe);
        }
    }
}
