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
    public partial class UserTicket : UserControl
    {
        Models.DataProcess Process = new Models.DataProcess();
        public UserTicket()
        {
            InitializeComponent();
        }

        private void UserTicket_Load(object sender, EventArgs e)
        {
            DataTable dt = Process.DataReader("select Anh from tblPhim");
            Models.ModelView.addListPicture(this.PanelListFilm, dt);
        }
    }
}
