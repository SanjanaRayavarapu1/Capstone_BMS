using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Capstone_BMS
{
    public partial class Approve : Form
    {
        string connectionstring = @"Data Source=USHYDSARAYAVAR2\MSSQLSERVER01;Initial Catalog=BookMS;Integrated Security=True";
        public Approve()
        {
            InitializeComponent();
        }

        private void Approve_Load(object sender, EventArgs e)
        {
            GetDataFromDatabase();
        }
        private void GetDataFromDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string query = "SELECT * FROM ResDesk";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Accept")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MeetingID"].Value);
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();             // Update the status of the booking
                string query = "UPDATE ResDesk SET Status = 'Approved' WHERE MID = @bookingId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookingId", id);
                int rowsAffected = command.ExecuteNonQuery();             // Close the connection to the database
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking Approved");
                }
                else
                {
                    MessageBox.Show("Failed to Approve Booking");
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Reject")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MeetingID"].Value);
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();             // Update the status of the booking
                string query = "UPDATE ResDesk SET Status = 'Rejected' WHERE MID = @bookingId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookingId", id);
                int rowsAffected = command.ExecuteNonQuery();             // Close the connection to the database
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking Rejected");
                }
                else
                {
                    MessageBox.Show("Failed to Approve Booking");
                }
            }


        }

        private void Approve_Activated(object sender, EventArgs e)
        {
            GetDataFromDatabase();
        }
    }
}
