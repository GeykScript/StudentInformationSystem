using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
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
            loadform(new Students());
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            loadform(new Courses());
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
    }
}
