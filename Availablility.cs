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
using System.Xml.Linq;

namespace Capstone_BMS
{
    public partial class Availablility : Form
    {
        public Availablility()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String DeskNo = textBox1.Text;
            String FloorNo = textBox2.Text;
            String TowerNo = textBox3.Text;
            String NoSeat = textBox4.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Availabiliti (DeskNo,FloorNo,TowerNo,NoSeat) values ('" + DeskNo + "','" + FloorNo + "','" + TowerNo + "','" + NoSeat + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View ve = new View();
            ve.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
