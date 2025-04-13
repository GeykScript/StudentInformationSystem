namespace StudentInformationSystem
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label12 = new Label();
            addstudent = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Fname = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            dept = new DataGridViewTextBoxColumn();
            editstudent = new Button();
            btnPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(193, 48);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 51;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(30, 33);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 43;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(645, 58);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 40;
            label2.Text = "8:36 PM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(645, 33);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 39;
            label12.Text = "April 13, 2025";
            // 
            // addstudent
            // 
            addstudent.BackColor = Color.LightSkyBlue;
            addstudent.Location = new Point(3, 3);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(116, 41);
            addstudent.TabIndex = 53;
            addstudent.Text = "Add Student";
            addstudent.UseVisualStyleBackColor = false;
            addstudent.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, LastName, Fname, course, year, dept });
            dataGridView1.Location = new Point(68, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 235);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Fname
            // 
            Fname.HeaderText = "First Name";
            Fname.Name = "Fname";
            Fname.ReadOnly = true;
            // 
            // course
            // 
            course.HeaderText = "Course ";
            course.Name = "course";
            course.ReadOnly = true;
            // 
            // year
            // 
            year.HeaderText = "Year Level";
            year.Name = "year";
            year.ReadOnly = true;
            // 
            // dept
            // 
            dept.HeaderText = "Department";
            dept.Name = "dept";
            dept.ReadOnly = true;
            // 
            // editstudent
            // 
            editstudent.BackColor = Color.LightYellow;
            editstudent.Location = new Point(125, 3);
            editstudent.Name = "editstudent";
            editstudent.Size = new Size(86, 41);
            editstudent.TabIndex = 55;
            editstudent.Text = "Edit ";
            editstudent.UseVisualStyleBackColor = false;
            editstudent.Click += editstudent_Click;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(addstudent);
            btnPanel.Controls.Add(editstudent);
            btnPanel.Location = new Point(496, 113);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(214, 50);
            btnPanel.TabIndex = 56;
            btnPanel.Paint += btnPanel_Paint;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPanel);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label2;
        private Label label12;
        private Button addstudent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Fname;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn dept;
        private Button editstudent;
        private Panel btnPanel;
    }
}