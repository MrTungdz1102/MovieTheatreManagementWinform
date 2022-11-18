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
        public UserTypeFilm()
        {
            InitializeComponent();
            //Process = new Models.DataProcess();
            //this.panelDetail = panelDetail;
            //this.detailTypeFilm = depart;
        }

        private void dgvLoaiPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
