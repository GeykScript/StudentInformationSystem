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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("1", "Doe", "John", "3rd Year", "IT Dept", "IT");
            dataGridView1.Rows.Add("2", "Smith", "Jane", "2nd Year", "CS Dept", "CS");
            dataGridView1.Rows.Add("3", "Brown", "Emily", "4th Year", "SE Dept", "SE");
            dataGridView1.Rows.Add("4", "Johnson", "Michael", "1st Year", "CE Dept", "CE");
            dataGridView1.Rows.Add("5", "Williams", "Sarah", "3rd Year", "IT Dept", "IT");
            dataGridView1.Rows.Add("6", "Jones", "David", "2nd Year", "CS Dept", "CS");
            dataGridView1.Rows.Add("7", "Garcia", "Sophia", "4th Year", "SE Dept", "SE");
            dataGridView1.Rows.Add("8", "Martinez", "Daniel", "1st Year", "CE Dept", "CE");
            dataGridView1.Rows.Add("9", "Hernandez", "Olivia", "3rd Year", "IT Dept", "IT");
            dataGridView1.Rows.Add("10", "Lopez", "James", "2nd Year", "CS Dept", "CS");
        }
    }
}
