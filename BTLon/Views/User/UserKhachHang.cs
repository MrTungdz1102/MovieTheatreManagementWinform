using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTLon.Models;

namespace BTLon.Views.User
{
    public partial class UserKhachHang : UserControl
    {
        public UserKhachHang()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (panelContent.Contains(userDepart) && panelDetail.Contains(DetailDepart))
            //{
            //    if (panelDetail.Visible == false)
            //    {
            //        Models.ModelView.addUserToPanel(this.panelContent, userRemove1, ListEmploy, DockStyle.Fill);
            //        setPanelDetail(164, 521);
            //        userRemove1 = ListEmploy;
            //        Models.ModelView.addUserToPanel(this.panelDetail, userRemove2, DetailEmploy, DockStyle.Fill);
            //        userRemove2 = DetailEmploy;
            //        setMenuPB(true);
            //    }
            //    else
            //    {
            //        panelDetail.Visible = false;
            //    }
            //}
            //else if (panelContent.Contains(ListEmploy) && panelDetail.Contains(DetailEmploy))
            //{
            //    if (panelDetail.Visible == false)
            //    {
            //        this.Controls.Clear();
            //        main.SetPanel();
            //    }
            //    else
            //    {
            //        panelDetail.Visible = false;
            //    }
            //}
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserKhachHang_Load(object sender, EventArgs e)
        {
            DataProcess data = new DataProcess();
            DataTable dt = new DataTable();
            string sql = "select * from tblKhachHang";
            dt = data.DataReader(sql);
            dataKH.DataSource = dt;
        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            DataProcess data = new DataProcess();
            DataTable dt = new DataTable();
            string sql = "select * from tblKhachHang where TenKH like N'%" + txtSearchKH.Texts + "%'";
            dt = data.DataReader(sql);
            dataKH.DataSource = dt;
        }

        private void btnCancelKH_Click(object sender, EventArgs e)
        {
            DataProcess data = new DataProcess();
            DataTable dt = new DataTable();
            string sql = "select * from tblKhachHang";
            dt = data.DataReader(sql);
            dataKH.DataSource = dt;
        }
        
        private void btnExitKH_Click(object sender, EventArgs e)
        {
            DataProcess dat = new DataProcess();
            DataTable d = new DataTable();
            int j = 0;
            //string sql = "select * from tblKhachHang";
            //dt = data.DataReader(sql);
            //dataKH.DataSource = dt;
            string check = "select MaKH from tblKhachHang where MaKH = '" + dataKH.CurrentRow.Cells[j].Value.ToString() + "'";
            d= dat.DataReader(check);
            //if (dataKH.CurrentRow.Cells[j].Value.ToString() == d.Rows[0][0].ToString())
            //{
                if (dataKH.CurrentRow.Cells[j + 2].Value.ToString() == "True")
                {

                    string sqlupdate = "update tblKhachHang set TenKH = N'" + dataKH.CurrentRow.Cells[j + 1].Value.ToString() + "', GioiTinh = N'" + 1 + "', NgaySinh = '" + dataKH.CurrentRow.Cells[j + 3].Value.ToString() + "', SDT = '" + dataKH.CurrentRow.Cells[j + 4].Value.ToString() + "', Email = '" + dataKH.CurrentRow.Cells[j + 5].Value.ToString() + "' where MaKH = '" + d.Rows[0][0].ToString() + "'";
                    dat.DataChange(sqlupdate);
                    //   dataKH.DataSource = dt;
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {

                    string sqlupdate = "update tblKhachHang set TenKH = N'" + dataKH.CurrentRow.Cells[j + 1].Value.ToString() + "', GioiTinh = N'" + 0 + "', NgaySinh = '" + dataKH.CurrentRow.Cells[j + 3].Value.ToString() + "', SDT = '" + dataKH.CurrentRow.Cells[j + 4].Value.ToString() + "', Email = '" + dataKH.CurrentRow.Cells[j + 5].Value.ToString() + "' where MaKH = '" + d.Rows[0][0].ToString() + "'";
                    dat.DataChange(sqlupdate);
                    // dataKH.DataSource = dt;
                    MessageBox.Show("Cập nhật thành công");
                }
         







        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {

        }
    }
}
