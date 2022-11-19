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
    public partial class UserDay : UserControl
    {
        Models.DataProcess Process;
        Panel panelDetail;
        UserDetailDay day;
        public UserDay(Panel panelDetaiil, UserDetailDay day)
        {
            InitializeComponent();
            Process = new Models.DataProcess();
            this.panelDetail = panelDetaiil;
            this.day = day;

        }
        public DataGridView GetDataGridView()
        {
            return this.dgvLoaiNgay;
        }

        public void LoadData()
        {
            string sql = "Select * From tblGiaTheoNgay";
            dgvLoaiNgay.DataSource = Process.DataReader(sql);
            dgvLoaiNgay.ReadOnly = true;
        }

        private void UserDay_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void UpdateData()
        {
            try
            {
                Process.DataSetChange("tblGiaTheoNgay");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvLoaiNgay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDetail.Visible = true;
            string LoaiNgay = dgvLoaiNgay.CurrentRow.Cells[0].Value.ToString();
            string GiaNgay = dgvLoaiNgay.CurrentRow.Cells[1].Value.ToString();
            string MoTa = dgvLoaiNgay.CurrentRow.Cells[2].Value.ToString();
            day.setCbLoaiNgay(LoaiNgay);
            day.setGiaNgay(GiaNgay);
            day.setMoTa(MoTa);
        }
    }
}
