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
    public partial class _6 : Form
    {
        //public static string employeename;
        //public String EmployeeID { get; set; }
        public _6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String EName = textBox1.Text;
            String EmpID = textBox2.Text;
            String RoleID= textBox5.Text;
            String EmID = textBox3.Text;
            String Pass = textBox4.Text;
            //EmployeeID= textBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True";
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandText = "insert into EmpSignUp (EName,EmpID,RoleID,EmID,Pass) values ('" + EName + "','" + EmpID + "','" + RoleID + "','" + EmID + "','" + Pass + "')"
            };
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!");
            _4 fp= new _4();
            fp.Show();
            MessageBox.Show("Signed Up Successfully");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
