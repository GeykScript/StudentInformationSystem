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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginPage = new Login();
                loginPage.Show();
                this.Hide();
            }

        }
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            if (form is Form fh)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(fh);
                this.mainPanel.Tag = fh;
                fh.Show();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard1());
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string query = @"
        SELECT 
s.student_id AS ID,
s.last_name AS `Last Name`, 
s.first_name AS `First Name`, 
c.course_name AS Course,
sy.year_level AS `Year Level`,
d.department_name AS DEPARTMENT

        FROM 
            students s
        JOIN 
            courses c ON s.course_id = c.course_id
        JOIN 
            departments d ON c.department_id = d.department_id
        JOIN 
            student_yearlevels sy ON s.student_id = sy.student_id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Instantiate the Students form
                    Students studentsForm = new Students();
                    studentsForm.dataGridView1.DataSource = dt;
                    studentsForm.dateTimeTextBox3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

                    // Show the form or load it in a panel/container
                    loadform(studentsForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void courseBtn_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.dateTimeTextBox2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
    SELECT course_id, COUNT(*) as student_count 
    FROM students 
    WHERE course_id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10) 
    GROUP BY course_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, int> courseCounts = new Dictionary<int, int>();

                    while (reader.Read())
                    {
                        int courseId = reader.GetInt32("course_id");
                        int count = reader.GetInt32("student_count");
                        courseCounts[courseId] = count;
                    }

                    conn.Close();

                    // Assign the values to the appropriate text boxes
                    courses.bsitTxt.Text = courseCounts.ContainsKey(1) ? courseCounts[1].ToString() : "0";
                    courses.sportTxt.Text = courseCounts.ContainsKey(2) ? courseCounts[2].ToString() : "0";
                    courses.cengTxt.Text = courseCounts.ContainsKey(3) ? courseCounts[3].ToString() : "0";
                    courses.bioTxt.Text = courseCounts.ContainsKey(4) ? courseCounts[4].ToString() : "0";
                    courses.chemTxt.Text = courseCounts.ContainsKey(5) ? courseCounts[5].ToString() : "0";
                    courses.csTxt.Text = courseCounts.ContainsKey(6) ? courseCounts[6].ToString() : "0";
                    courses.ecoTxt.Text = courseCounts.ContainsKey(7) ? courseCounts[7].ToString() : "0";
                    courses.psychoTxt.Text = courseCounts.ContainsKey(8) ? courseCounts[8].ToString() : "0";
                    courses.nursingTxt.Text = courseCounts.ContainsKey(9) ? courseCounts[9].ToString() : "0";
                    courses.litTxt.Text = courseCounts.ContainsKey(10) ? courseCounts[10].ToString() : "0";



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            loadform(courses);
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Logs());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query1 = "SELECT COUNT(*) FROM students";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    object result1 = cmd1.ExecuteScalar();

                    textBox1.Text = result1.ToString();


                    string query2 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 1;";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    object result2 = cmd2.ExecuteScalar();

                    textBox3.Text = result2.ToString();


                    string query3 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 2;";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    object result3 = cmd3.ExecuteScalar();

                    textBox4.Text = result3.ToString();


                    string query4 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 3;";
                    MySqlCommand cmd4 = new MySqlCommand(query4, conn);
                    object result4 = cmd4.ExecuteScalar();

                    textBox5.Text = result4.ToString();

                    string query5 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 4;";
                    MySqlCommand cmd5 = new MySqlCommand(query5, conn);
                    object result5 = cmd5.ExecuteScalar();

                    textBox6.Text = result5.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

        }
    }
}
