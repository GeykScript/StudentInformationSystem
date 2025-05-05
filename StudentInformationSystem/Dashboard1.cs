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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {

            InitializeComponent();
            load_datas(); // Call your method on form creation

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void load_datas()
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
                    dateTimeTextBox2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
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
                    dateTimeTextBox2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeTextBox2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

        }
    }
}
