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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addDesksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDesk nm = new AddDesk();
            nm.Show();
        }

        private void deleteDesksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDesk nm = new DeleteDesk();
            nm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout! Confirm?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //this.Close();
               // Login lg = new Login();
                //lg.Show();
                _2 lg= new _2();
                lg.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application. Confirm?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void approvalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDesk nm = new AddDesk();
            nm.Show();
        }

        private void deleteDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDesk nm = new DeleteDesk();
            nm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Approve pm = new Approve();
            pm.Show();
        }
    }
}
