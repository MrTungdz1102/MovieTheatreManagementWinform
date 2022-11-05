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
        public UserDepart()
        {
            InitializeComponent();
            Process = new Models.DataProcess();
        }

        private void UserDepart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from tblPhongBan";
            dgvPhongBan.DataSource = Process.DataReader(sql);
            dgvPhongBan.ReadOnly = true;
        }
    }
}
