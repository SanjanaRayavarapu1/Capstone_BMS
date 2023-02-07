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
    public partial class ResTable : Form
    {
        public ResTable()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SZName = comboBox1.Text;
            String Capacity = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                Capacity = radioButton1.Text;
            }
            else
            {
                Capacity = radioButton2.Text;
            }
            String DayDate = dateTimePicker1.Text;
            String StartTime = comboBox3.Text;
            String EndTime = comboBox4.Text;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
