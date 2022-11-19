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
    public partial class UserDetailTypeFilm : UserControl
    {
        Models.DataProcess Process;
        public UserDetailTypeFilm()
        {
            InitializeComponent();
        }
        public void setMaLP(string MaLP)
        {
            this.txtMaLP.Text = MaLP;
        }
        public void setTenLP(string TenLP)
        {
            this.txtTenLP.Text = TenLP;
        }
        public void setMoTa(string MoTa)
        {
            this.txtMoTa.Text = MoTa;
        }
        public void setEnable(bool check)
        {
            txtTenLP.Enabled = check;
        }
        public void UpDateDataBase()
        {
            //string update = "update tblLoaiPhim set TenLP = N'" + txtTenLP.Text + "'";
            //update += ",MoTa = N'" + txtMoTa.Text + "'";
            //update += "where MaLP = N'" + txtMaLP.Text + "';";
            //MessageBox.Show("Update successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Process.DataChange(update);
        }

        private void panelDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
