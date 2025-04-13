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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("1", "Doe", "John", "Login", "2023-10-01 10:00:00");
            dataGridView1.Rows.Add("2", "Smith", "Jane", "Logout", "2023-10-01 11:00:00");
            dataGridView1.Rows.Add("3", "Brown", "Emily", "Login", "2023-10-01 12:00:00");
            dataGridView1.Rows.Add("4", "Johnson", "Michael", "Logout", "2023-10-01 13:00:00");
            dataGridView1.Rows.Add("5", "Williams", "Sarah", "Login", "2023-10-01 14:00:00");
            dataGridView1.Rows.Add("6", "Jones", "David", "Logout", "2023-10-01 15:00:00");
            dataGridView1.Rows.Add("7", "Garcia", "Sophia", "Login", "2023-10-01 16:00:00");
            dataGridView1.Rows.Add("8", "Martinez", "Daniel", "Logout", "2023-10-01 17:00:00");
            dataGridView1.Rows.Add("9", "Hernandez", "Olivia", "Login", "2023-10-01 18:00:00");
            dataGridView1.Rows.Add("10", "Lopez", "James", "Logout", "2023-10-01 19:00:00");
        }
    }
}
