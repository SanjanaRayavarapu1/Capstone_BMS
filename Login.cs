﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "admin" && txtBoxPassword.Text == "admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
