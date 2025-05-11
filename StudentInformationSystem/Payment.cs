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

        private void excelbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application MExcel = new Microsoft.Office.Interop.Excel.Application();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set column headers
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Populate Excel with DataGridView data
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        var cellValue = dataGridView1.Rows[i].Cells[j].Value;

                        // Check if cell value is null
                        MExcel.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
                    }
                }

                // Format Excel sheet
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
