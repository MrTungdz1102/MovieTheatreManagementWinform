using BTLon.Models;
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
    public partial class UserManageFilm : UserControl
    {
        DataProcess Process;
        Main main;
        UserDetailManageFilm DetailManageFilm;
        UserManageListFilm ManageListFilm;
        UserDetailTypeFilm DetaiTypeFilm;
        UserDepart userDepart;
        UserControl userRemove1;
        UserControl userRemove2;
        DataGridView dgvNhanVien;
        public UserManageFilm()
        {
            InitializeComponent();
        }

        private void UserManageFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
