using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Call the stored procedure
                    string procedureQuery = "CALL updatePayments();";
                    MySqlCommand cmd = new MySqlCommand(procedureQuery, conn);
                    cmd.ExecuteNonQuery();

                    //  SELECT query to fetch updated payment data
                    string selectQuery = @"
                SELECT ID, first_name, last_name, total_payment
                FROM student_totalpayments sp
                JOIN students s ON sp.student_id = s.student_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Load data into the current form
                    dataGridView1.DataSource = dt;
                    dateTimeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

                    MessageBox.Show("Payments updated and loaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



    }
}
