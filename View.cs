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
    public partial class View : Form
    {
        
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            String email = _4.username;
            String emid = _6.employeeid;
            SqlConnection con = new SqlConnection("data source = USHYDSARAYAVAR2\\MSSQLSERVER01; database = BookMS; integrated security = True");
            SqlDataAdapter DA = new SqlDataAdapter("select * from ResDesk where EmpName='"+email+"' and EmpID='"+emid+"'",con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
