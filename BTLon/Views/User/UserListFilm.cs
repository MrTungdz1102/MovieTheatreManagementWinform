using BTLon.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BTLon.Views.User
{
    public partial class UserListFilm : UserControl
    {
        public UserListFilm()
        {
            InitializeComponent();
        }
        public FlowLayoutPanel getflPanel()
        {
            return this.PanelListFilm;
        }
        public void SetPanel(int with)
        {
            this.PanelListFilm.Width = with;
        }
        public void SetLabel(string text)
        {
            this.lblPhim.Text = text;
        }
    }
}
