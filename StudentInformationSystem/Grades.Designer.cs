namespace StudentInformationSystem
{
    partial class Grades
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
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(248, 23);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 34;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(85, 8);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 33;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(366, 177);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(309, 149);
            label15.Name = "label15";
            label15.Size = new Size(218, 25);
            label15.TabIndex = 86;
            label15.Text = "Students Average Grade";
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Grades";
            Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        public DataGridView dataGridView1;
        private Label label15;
    }
}