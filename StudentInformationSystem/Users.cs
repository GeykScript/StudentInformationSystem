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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string username = usernameTxt.Text.Trim();
            string oldPassword = passTxt.Text.Trim();
            string newPassword = newpassTxt.Text.Trim();
            string confirmPassword = confirmpassTxt.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.");
                newpassTxt.Clear();
                confirmpassTxt.Clear();

                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Step 1: Check if the user exists with the current username and password
                    string selectQuery = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@username", username);
                        selectCmd.Parameters.AddWithValue("@password", oldPassword);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close(); // Close before executing an update

                                // Step 2: Update the password
                                string updateQuery = "UPDATE users SET password = @newPassword WHERE username = @username";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                                    updateCmd.Parameters.AddWithValue("@username", username);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Password updated successfully.");
                                        usernameTxt.Clear();
                                        passTxt.Clear();
                                        newpassTxt.Clear();
                                        confirmpassTxt.Clear();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Password update failed.");
                                        usernameTxt.Clear();
                                        passTxt.Clear();
                                        newpassTxt.Clear();
                                        confirmpassTxt.Clear();

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or current password.");
                                usernameTxt.Clear();
                                passTxt.Clear();
                                newpassTxt.Clear();
                                confirmpassTxt.Clear();

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void answertxt_TextChanged(object sender, EventArgs e)
        {

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
        private int GetSelectedUser()
        {
            var selectedItem = comboBox1.SelectedItem;
            if (selectedItem != null)
            {
                // Get the selected student's ID using the ValueMember of the ComboBox
                return (int)((DataRowView)selectedItem)["ID"];
            }
            return -1; // Return -1 if no selection is made
        }


        private void submitbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
           // string username = usernameTxt2.Text.Trim();
            int username = GetSelectedUser(); // Retrieve the selected user ID from combo box
            string question = GetSelectedQuestion();
            string answer = answertxt.Text.Trim();

            if ( username==0 || string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please fill in all fields and select a question.");
                
                answertxt.Clear();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "UPDATE users SET security_question = @question, answer = @answer WHERE id = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@answer", answer);
                        cmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Security question and answer saved successfully.");
                           
                            answertxt.Clear();
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            radioButton3.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Username not found or no changes made.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=admin;database=studentinfodb;";
            string firstname = firstnametxt.Text.Trim();
            string lastname = lastnametxt.Text.Trim();
            string username = usertxt.Text.Trim();
            string password = passwordtxt.Text.Trim();
            string confirmpassword = confirmtxt.Text.Trim();

            if (password != confirmpassword)
            {
                MessageBox.Show("Password and confirmation do not match.");
                passwordtxt.Clear();
                confirmtxt.Clear();
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO users (fname, lastname, username, password, security_question, answer) " +
                                   "VALUES (@firstname, @lastname, @username, @password, NULL, NULL);";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully.");
                            firstnametxt.Clear();
                            lastnametxt.Clear();
                            usertxt.Clear();
                            passwordtxt.Clear();
                            confirmtxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
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
