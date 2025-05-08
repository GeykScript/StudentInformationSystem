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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private string GetSelectedQuestion()
        {
            if (radioButton1.Checked)
                return radioButton1.Text;
            else if (radioButton2.Checked)
                return radioButton2.Text;
            else if (radioButton3.Checked)
                return radioButton3.Text;
            else
                return "";
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string username = usernameTxt2.Text.Trim();
            string question = GetSelectedQuestion();
            string answer = answertxt.Text.Trim();
            string newPassword = newpassTxt.Text.Trim();
            string confirmPassword = confirmpassTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please fill in all fields and select a question.");
                return;
            }

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Step 1: Validate username, question, and answer
                    string checkQuery = "SELECT * FROM users WHERE username = @username AND security_question = @question AND answer = @answer";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@question", question);
                        checkCmd.Parameters.AddWithValue("@answer", answer);

                        using (MySqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close(); // Close before executing UPDATE

                                // Step 2: Update password
                                string updateQuery = "UPDATE users SET password = @newPassword WHERE username = @username";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                                    updateCmd.Parameters.AddWithValue("@username", username);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Password updated successfully.");
                                        usernameTxt2.Clear();
                                        answertxt.Clear();
                                        newpassTxt.Clear();
                                        confirmpassTxt.Clear();
                                        radioButton1.Checked = false;
                                        radioButton2.Checked = false;
                                        radioButton3.Checked = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password update failed.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Security question or answer does not match the username.");
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

        private void loginbtn_Click(object sender, EventArgs e)
        {

            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
