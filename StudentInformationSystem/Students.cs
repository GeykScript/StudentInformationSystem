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

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentInformation addStudentForm = new AddStudentInformation();
            addStudentForm.Show();
        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editstudent_Click(object sender, EventArgs e)
        {
            Edit editstudent = new Edit();
            editstudent.Show();

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
    }
}
