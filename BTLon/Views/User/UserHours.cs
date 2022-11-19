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
    public partial class UserHours : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailHours hours;
        public UserHours(Panel panelDetail, UserDetailHours hours)
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            this.panelDetail = panelDetail;
            this.hours = hours;
        }
        public DataGridView GetDataGridView()
        {
            return this.dgvLoaiGio;
        }
        public void LoadData()
        {
            string sql = "Select * From tblGiaTheoGio";
            dgvLoaiGio.DataSource = Process.DataReader(sql);
            dgvLoaiGio.ReadOnly = true;
        }

        private void UserHours_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblGiaTheoGio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvLoaiGio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panelDetail.Visible = true;
            string LoaiGio = dgvLoaiGio.CurrentRow.Cells[0].Value.ToString();
            string GiaGio = dgvLoaiGio.CurrentRow.Cells[1].Value.ToString();
            string MoTa = dgvLoaiGio.CurrentRow.Cells[2].Value.ToString();
            hours.setCbLoaiGio(LoaiGio);
            hours.setGiaGio(GiaGio);
            hours.setMoTa(MoTa);
        }
    }
}
