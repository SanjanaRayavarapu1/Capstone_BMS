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
    public partial class _1 : Form
    {
        public _1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2 fm = new _2();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _3 fm = new _3();
            fm.Show();
        }

        private void _1_Load(object sender, EventArgs e)
        {
            _2 fm = new _2();
            fm.Show();
        }
    }
}
