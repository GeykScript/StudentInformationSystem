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
    public partial class Enrollments : Form
    {
        public Enrollments()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void usernameTxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetSelectedStudent()
        {
            var selectedItem = comboBox1.SelectedItem;
            if (selectedItem != null)
            {
                // Get the selected student's ID using the ValueMember of the ComboBox
                return (int)((DataRowView)selectedItem)["ID"];
            }
            return -1; // Return -1 if no selection is made
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Database connection string
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";

            // Get user inputs
            string username = firsttxt.Text.Trim();
            int student = GetSelectedStudent(); // Retrieve the selected student ID from combo box
            int year_lvl = int.Parse(yeartxt.Text);

            decimal first = decimal.TryParse(firsttxt.Text, out first) ? first : 0; // Parsing first semester fee
            decimal second = decimal.TryParse(secondtxt.Text, out second) ? second : 0; // Parsing second semester fee
            decimal miscellaneous = decimal.TryParse(mistxt.Text, out miscellaneous) ? miscellaneous : 0; // Parsing miscellaneous fee

            if (student == -1)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            // SQL query to check if the record exists
            string checkQuery = @"
            SELECT COUNT(*) 
            FROM enrollment_fees 
            WHERE student_id = @student_id";

            string insertQuery = @"
            INSERT INTO enrollment_fees (student_id,year_lvl, first_sem_fee, second_sem_fee, other_fee)
            VALUES (@student_id,@year_lvl, @first_sem_fee, @second_sem_fee, @other_fee)";

            using (var connection = new MySqlConnection(connStr))
            {
                connection.Open();

                // Check if the student record exists
                using (var checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@student_id", student);

                    int recordCount = Convert.ToInt32(checkCmd.ExecuteScalar());


                    {
                        // Insert a new record
                        using (var insertCmd = new MySqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@student_id", student);
                            insertCmd.Parameters.AddWithValue("@year_lvl", year_lvl);

                            insertCmd.Parameters.AddWithValue("@first_sem_fee", first);
                            insertCmd.Parameters.AddWithValue("@second_sem_fee", second);
                            insertCmd.Parameters.AddWithValue("@other_fee", miscellaneous);
                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Enrollment fees inserted successfully.");
                        }
                    }
                }
            }
        }

        private void Enrollments_Load(object sender, EventArgs e)
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string query = @"
            SELECT e.enrollment_id AS ID,
                setStudentFullname(s.first_name, s.last_name) AS Fullname,
                e.year_lvl AS 'Year Level',
                e.first_sem_fee AS '1st Sem Fee',
                e.second_sem_fee AS '2nd Sem Fee',
                e.other_fee AS 'Miscellaneous'
            FROM enrollment_fees e
                JOIN students s ON e.student_id = s.student_id
                ORDER BY Fullname, 'Year Level'";

            string query2 = @"
            SELECT student_id AS ID, 
                setStudentFullname(first_name, last_name) AS Fullname 
            FROM students
                ORDER BY Fullname";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Load enrollment data
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;

                    // Load student list for ComboBox
                    MySqlDataAdapter comboAdapter = new MySqlDataAdapter(query2, conn);
                    DataTable studentTable = new DataTable();
                    comboAdapter.Fill(studentTable);

                    comboBox1.DataSource = studentTable;
                    comboBox1.DisplayMember = "Fullname";
                    comboBox1.ValueMember = "ID";

                    MessageBox.Show("Refreshed successfully!");

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

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string searchText = searchbar.Text;

            string query = @"
            SELECT e.enrollment_id AS ID,
                setStudentFullname(s.first_name, s.last_name) AS Fullname,
                e.year_lvl AS 'Year Level',
                e.first_sem_fee AS '1st Sem Fee',
                e.second_sem_fee AS '2nd Sem Fee',
                e.other_fee AS 'Miscellaneous'
            FROM enrollment_fees e
                JOIN students s ON e.student_id = s.student_id
                WHERE s.last_name LIKE @searchText 
           OR s.first_name LIKE @searchText";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add wildcard and parameter
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
