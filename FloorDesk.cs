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
    public partial class FloorDesk : Form
    {
        public FloorDesk()
        {
            InitializeComponent();
        }

        private void FloorDesk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SZName = comboBox1.Text;
            String DayDate = dateTimePicker1.Text;
            String StartTime = comboBox2.Text;
            String EndTime = comboBox3.Text;
            String capacity = comboBox4.Text;
            if (SZName == null || SZName.Length == 0)
            {
                MessageBox.Show("Please slect your space");
                return;
            }
            if (DayDate == null || DayDate.Length == 0)
            {
                MessageBox.Show("Please select the  date");
                return;
            }
            if (StartTime == null || StartTime.Length == 0)
            {
                MessageBox.Show("please select the start time ");
                return;
            }
            if (EndTime == null || EndTime.Length == 0)
            {
                MessageBox.Show("please select the endtime");
                return;
            }
            if (capacity == null || capacity.Length == 0)
            {
                MessageBox.Show("please select the capacity");
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into FloorDesk (SZName,DayDate,StartTime,EndTime,capacity) values ('" + SZName + "','" + DayDate + "','" + StartTime + "','" + EndTime + "','" + capacity + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!" + SZName);
            this.Close();
        }
    }
}
