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
            //String email = _4.username;
            String DayDate = dateTimePicker1.Text;
            String StartTime = comboBox2.Text;
            String EndTime = comboBox3.Text;
            String capacity=comboBox4.Text;
            String email = _4.username;
            if (SZName ==null|| SZName.Length ==0)
            {
                MessageBox.Show("Please slect your space");
                return;
            }
            if(DayDate==null || DayDate.Length ==0)
            {
                MessageBox.Show("Please select the  date");
                return;
            }
            if(StartTime==null || StartTime.Length ==0)
            {
                MessageBox.Show("please select the start time ");
                return;
            }
            if(EndTime==null || EndTime.Length ==0)
            {
                MessageBox.Show("please select the endtime");
                return;
            }
            if(capacity==null || capacity.Length ==0)
            {
                MessageBox.Show("please select the capacity");
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO [dbo].[ResDesk]([SZName],[DayDate],[StartTime],[EndTime],[capacity],[EmpName]) VALUES ('" + SZName + "','" + DayDate + "','" + StartTime + "','" + EndTime + "','" +capacity+ "','"+email+"')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!" + SZName);
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
