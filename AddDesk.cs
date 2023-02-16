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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capstone_BMS
{
    public partial class AddDesk : Form
    {
        public AddDesk()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USHYDSARAYAVAR2\\MSSQLSERVER01;Initial Catalog=BookMS;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("INSERT INTO [dbo].[Desk](Sname,capacity,DeskNo)VALUES('"+comboBox1.SelectedItem.ToString()+"','"+comboBox2.SelectedItem.ToString()+"','"+textBox1.Text+"')", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            MessageBox.Show("Desk added successfully");
            this.Close();
        }
    }
}
