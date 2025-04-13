namespace StudentInformationSystem
{
    partial class Logs
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
            dataGridView1 = new DataGridView();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label12 = new Label();
            label15 = new Label();
            ID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Activiy = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, LastName, FirstName, Activiy, Date });
            dataGridView1.Location = new Point(99, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 235);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(193, 55);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 59;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(30, 40);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 58;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(645, 65);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 57;
            label2.Text = "8:36 PM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(645, 40);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 56;
            label12.Text = "April 13, 2025";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(376, 137);
            label15.Name = "label15";
            label15.Size = new Size(57, 25);
            label15.TabIndex = 82;
            label15.Text = "LOGS";
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
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Activiy
            // 
            Activiy.HeaderText = "Activiy";
            Activiy.Name = "Activiy";
            Activiy.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Logs";
            Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label10;
        private Label label9;
        private Label label2;
        private Label label12;
        private Label label15;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Activiy;
        private DataGridViewTextBoxColumn Date;
    }
}