using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_BMS
{
    public partial class _2 : Form
    {
        public _2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _4 fm = new _4();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _5 fm = new _5();
            fm.Show();
        }

        private void _2_Load(object sender, EventArgs e)
        {

        }
    }
}
