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
    public partial class ResDesk : Form
    {
        public ResDesk()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SZName = comboBox1.Text;
            String DayDate = dateTimePicker1.Text;
            String StartTime = comboBox2.Text;
            String EndTime = comboBox3.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into ResDesk (SZName,DayDate,StartTime,EndTime) values ('" + SZName + "','" + DayDate + "','" + StartTime + "','" + EndTime + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!");
        }
    }
}
