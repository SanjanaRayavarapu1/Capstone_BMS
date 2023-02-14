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
    public partial class _3 : Form
    {
        public _3()
        {
            InitializeComponent();
        }

        private void _3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _6 fm = new _6();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _7 fm = new _7();
            fm.Show();
        }
    }
}
