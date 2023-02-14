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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Capstone_BMS
{
    public partial class _5 : Form
    {
        public _5()
        {
            InitializeComponent();
        }

        private void _5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            SqlConnection conn = new SqlConnection("data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True");

            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM EmpSignUp WHERE EmpID='2' AND EmID= '" + textBox1.Text + "'AND Pass= '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form2 fm = new Form2();
                fm.Show();
            }
            else { MessageBox.Show("Invalid"); }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
