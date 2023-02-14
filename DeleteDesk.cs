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
    public partial class DeleteDesk : Form
    {
        public DeleteDesk()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data, Confirm?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("data source = USHYDSARAYAVAR2\\MSSQLSERVER01;database = BookMS; integrated security=True");
                //con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01;database = BookMS; integrated security=True";
                //SqlDataAdapter DA = new SqlDataAdapter("delete from Desk where DeskNo = " + textBox1.Text + "",con);
                SqlCommand cmd = new SqlCommand("delete from Desk where DeskNo = '" + textBox1.Text + "'", con);
                //cmd.Connection = con;
                //cmd.CommandText = "delete from Desk where DeskNo = " + textBox1.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                   
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection("data source = USHYDSARAYAVAR2\\MSSQLSERVER01;database = BookMS; integrated security=True");
                SqlDataAdapter DA = new SqlDataAdapter("select * from Desk",con);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void DeleteDesk_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USHYDSARAYAVAR2\\MSSQLSERVER01;database = BookMS; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Desk";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
