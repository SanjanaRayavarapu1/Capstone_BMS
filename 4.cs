using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_BMS
{
    
    public partial class _4 : Form
    {
        public static string username; 

        public _4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=USHYDSARAYAVAR2\\MSSQLSERVER01;Initial Catalog=BookMS;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM EmpSignUp WHERE RoleID='1' AND EName= '" +textBox1.Text +"' AND Pass= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = textBox1.Text;
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();
                MessageBox.Show("Logged in as Successfully");
            }
            else { MessageBox.Show("Invalid"); }
        }
    }
}
