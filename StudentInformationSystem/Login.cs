
using MySql.Data.MySqlClient;
namespace StudentInformationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!");
                                reader.Close(); // Close the reader before reusing the connection

                                // Now fetch student count
                                string countQuery = "SELECT COUNT(*) FROM students";
                                using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                                {
                                    object result = countCmd.ExecuteScalar();

                                    // Show dashboard
                                    Dashboard dashboardPage = new Dashboard();
                                    dashboardPage.paymentBtn.Text = result.ToString(); // Assuming textBox1 is public
                                    string query2 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 1;";
                                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                                    object result2 = cmd2.ExecuteScalar();
                                    dashboardPage.textBox3.Text = result2.ToString();

                                    // Count Year Level 2
                                    string query3 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 2;";
                                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                                    object result3 = cmd3.ExecuteScalar();
                                    dashboardPage.textBox4.Text = result3.ToString();

                                    // Count Year Level 3
                                    string query4 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 3;";
                                    MySqlCommand cmd4 = new MySqlCommand(query4, conn);
                                    object result4 = cmd4.ExecuteScalar();
                                    dashboardPage.textBox5.Text = result4.ToString();

                                    // Count Year Level 4
                                    string query5 = "SELECT COUNT(*) FROM student_yearlevels WHERE year_level = 4;";
                                    MySqlCommand cmd5 = new MySqlCommand(query5, conn);
                                    object result5 = cmd5.ExecuteScalar();
                                    dashboardPage.textBox6.Text = result5.ToString();

                                    dashboardPage.dateTimeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");


                                    dashboardPage.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
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


        private void groupLogin_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotPass_Click(object sender, EventArgs e)
        {

        }
    }
}
