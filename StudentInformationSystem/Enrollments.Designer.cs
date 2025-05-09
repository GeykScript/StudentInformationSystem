namespace StudentInformationSystem
{
    partial class Enrollments
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
            dataGridView1 = new DataGridView();
            label8 = new Label();
            button1 = new Button();
            Refreshbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(305, 32);
            label10.Name = "label10";
            label10.Size = new Size(530, 43);
            label10.TabIndex = 36;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(103, 14);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
            label9.TabIndex = 35;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(732, 188);
            dataGridView1.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(334, 137);
            label8.Name = "label8";
            label8.Size = new Size(375, 32);
            label8.TabIndex = 102;
            label8.Text = "Students Enrollment Transactions";
            // 
            // button1
            // 
            button1.Location = new Point(508, 213);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 103;
            button1.Text = "Add New Transaction";
            button1.UseVisualStyleBackColor = true;
            // 
            // Refreshbtn
            // 
            Refreshbtn.Location = new Point(728, 213);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(94, 29);
            Refreshbtn.TabIndex = 104;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = true;
            // 
            // Enrollments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(896, 553);
            Controls.Add(Refreshbtn);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "Enrollments";
            Text = "Enrollments";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        public DataGridView dataGridView1;
        private Label label8;
        private Button button1;
        private Button Refreshbtn;
    }
}