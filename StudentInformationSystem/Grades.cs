using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentInformationSystem
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            int student = GetSelectedStudent(); // Retrieve the selected student ID from combo box

            if (student == -1)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Call the stored procedure to get student grades
                    string query = "CALL getStudentGrades(@studentId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", student);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            string fullname = "";
                            string message = "";

                            // Table headers with fixed width columns
                            message += string.Format("{0,-20} {1,-10}\n", "Subject", "Grade");
                            message += new string('-', 32) + "\n"; // Separator line

                            while (reader.Read())
                            {
                                if (string.IsNullOrEmpty(fullname))
                                    fullname = reader["Fullname"].ToString();

                                string subject = reader["subject_name"].ToString();
                                string grade = reader["grade"].ToString();

                                // Format each row with spacing
                                message += string.Format("{0,-20} {1,-10}\n", subject, grade);
                            }

                            if (message.Trim().EndsWith("Grade")) // Only header, no data
                            {
                                MessageBox.Show("No grades found for this student.");
                            }
                            else
                            {
                                MessageBox.Show($"Student Name: {fullname}:\n\n{message}");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            int course = GetSelectedCourse(); // Assume this gets selected course_id

            string query = @"SELECT subject_id AS ID, subject_name AS Subjects 
                     FROM subjects 
                     WHERE course_id = @course_id 
                     ORDER BY subject_name";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@course_id", course);

                        using (MySqlDataAdapter comboAdapter2 = new MySqlDataAdapter(cmd))
                        {
                            DataTable subjectsTable = new DataTable();
                            comboAdapter2.Fill(subjectsTable);

                            comboBox3.DataSource = subjectsTable;
                            comboBox3.DisplayMember = "Subjects";
                            comboBox3.ValueMember = "ID";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private int GetSelectedSubject()
        {
            var selectedItem = comboBox3.SelectedItem;
            if (selectedItem != null)
            {
                // Get the selected student's ID using the ValueMember of the ComboBox
                return (int)((DataRowView)selectedItem)["ID"];
            }
            return -1; // Return -1 if no selection is made
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            int student = GetSelectedStudent(); // Retrieve the selected student ID from combo box
            int subject = GetSelectedSubject(); // Retrieve the selected subject ID from combo box
            decimal grade = decimal.TryParse(gradetxt.Text, out grade) ? grade : 0; // Parsing grade
            if (student == -1)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            if (subject == -1)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO grades (student_id, subject_id, grade) VALUES (@student_id, @subject_id, @grade)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", student);
                        cmd.Parameters.AddWithValue("@subject_id", subject);
                        cmd.Parameters.AddWithValue("@grade", grade);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade added successfully!");
                            gradetxt.Clear();
                            comboBox3.SelectedIndex = -1; // Reset the subject selection
                        }
                        else
                        {
                            MessageBox.Show("Failed to add grade.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
