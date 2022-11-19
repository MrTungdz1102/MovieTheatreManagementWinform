using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime min = DateTime.Today;
            Calendar.MinDate = min;
            DateTime max = DateTime.Today.AddDays(30);
            Calendar.MaxDate = max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calendar.SelectionEnd.ToShortDateString();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = Calendar.SelectionEnd.ToShortDateString();
        }
    }
}
