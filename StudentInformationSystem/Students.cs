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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
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
        private int GetSelectedCourse()
        {
            var selectedItem = comboBox2.SelectedItem;
            if (selectedItem != null)
            {
                // Get the selected student's ID using the ValueMember of the ComboBox
                return (int)((DataRowView)selectedItem)["ID"];
            }
            return -1; // Return -1 if no selection is made
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string firstName = firstnametxt.Text.Trim();
            string lastName = lastnametxt.Text.Trim();
            int course = GetSelectedCourse(); // Retrieve the selected course ID from combo box
            int year_lvl = int.Parse(yeartxt.Text);

            string query = "INSERT INTO students (first_name,last_name, course_id, year_level) VALUES (@first_name,@last_name, @course_id, @year_level)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@course_id", course);
                    cmd.Parameters.AddWithValue("@year_level", year_lvl);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Enrollment successful!");
                        // Clear input fields after successful insert
                        firstnametxt.Clear();
                        lastnametxt.Clear();
                        yeartxt.Clear();
                        comboBox2.SelectedIndex = -1; // assuming courseComboBox is the control
                    }
                    else
                    {
                        MessageBox.Show("Enrollment failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editstudent_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            int student = GetSelectedStudent(); // Retrieve the selected student ID from combo box
            int course = GetSelectedCourse(); // Retrieve the selected course ID from combo box
            int year_lvl = int.Parse(yeartxt.Text);

            string query = "UPDATE students SET course_id = @course_id, year_level = @year_level WHERE student_id = @student_id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", student);
                    cmd.Parameters.AddWithValue("@course_id", course);
                    cmd.Parameters.AddWithValue("@year_level", year_lvl);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student information updated successfully!");
                        // Clear input fields after successful update
                        firstnametxt.Clear();
                        lastnametxt.Clear();
                        yeartxt.Clear();
                        comboBox2.SelectedIndex = -1; // assuming courseComboBox is the control
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dateTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeTextBox3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            // Query to fetch all student information VIEW TABLE
            string query = @"
        SELECT * FROM student_informations";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
