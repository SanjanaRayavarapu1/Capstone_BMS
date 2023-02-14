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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reserveDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SearchDesk rd = new SearchDesk();
            rd.Show();
        }

        private void availabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResDesk nm = new ResDesk();
            nm.Show();
        }

        private void workstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResDesk nm = new ResDesk();
            nm.Show();
        }

        //private void meetingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        //{
          //  ResTable nm = new ResTable();
            //nm.Show();  
        //}

        private void searchDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View sm = new View();   
            sm.Show();
        }

        private void deleteDeskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDesk dm = new DeleteDesk();   
            dm.Show();  
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close your application. Confirm?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void deleteDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Logout! Confirm?","Logout",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                //Login lg = new Login();
                //lg.Show();
            }
        }
    }
}
