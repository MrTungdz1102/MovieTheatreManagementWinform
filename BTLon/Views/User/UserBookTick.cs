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
    public partial class UserBookTick : UserControl
    {
        public UserBookTick()
        {
            InitializeComponent();
        }

        private void book_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.BackColor == Color.White) 
            {
                button.BackColor = Color.Brown;
            }
            else
            {
                button.BackColor = Color.White;
            }
        }
    }
}
