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
            comboBox1 = new ComboBox();
            firsttxt = new TextBox();
            secondtxt = new TextBox();
            mistxt = new TextBox();
            yeartxt = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            label9.Location = new Point(103, 13);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
            label9.TabIndex = 35;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(830, 188);
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
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(657, 248);
            button1.Name = "button1";
            button1.Size = new Size(177, 53);
            button1.TabIndex = 103;
            button1.Text = "Add New Transaction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Refreshbtn
            // 
            Refreshbtn.Location = new Point(103, 271);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(94, 29);
            Refreshbtn.TabIndex = 104;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = true;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 211);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 108;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // firsttxt
            // 
            firsttxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firsttxt.Location = new Point(334, 271);
            firsttxt.Margin = new Padding(3, 4, 3, 4);
            firsttxt.Multiline = true;
            firsttxt.Name = "firsttxt";
            firsttxt.Size = new Size(100, 29);
            firsttxt.TabIndex = 109;
            firsttxt.TextChanged += usernameTxt2_TextChanged;
            // 
            // secondtxt
            // 
            secondtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondtxt.Location = new Point(441, 271);
            secondtxt.Margin = new Padding(3, 4, 3, 4);
            secondtxt.Multiline = true;
            secondtxt.Name = "secondtxt";
            secondtxt.Size = new Size(100, 29);
            secondtxt.TabIndex = 110;
            secondtxt.TextChanged += textBox1_TextChanged;
            // 
            // mistxt
            // 
            mistxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mistxt.Location = new Point(549, 271);
            mistxt.Margin = new Padding(3, 4, 3, 4);
            mistxt.Multiline = true;
            mistxt.Name = "mistxt";
            mistxt.Size = new Size(100, 29);
            mistxt.TabIndex = 111;
            mistxt.TextChanged += textBox2_TextChanged;
            // 
            // yeartxt
            // 
            yeartxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeartxt.Location = new Point(226, 271);
            yeartxt.Margin = new Padding(3, 4, 3, 4);
            yeartxt.Multiline = true;
            yeartxt.Name = "yeartxt";
            yeartxt.Size = new Size(100, 29);
            yeartxt.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 184);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 113;
            label7.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 247);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 114;
            label1.Text = "Year Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 247);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 115;
            label2.Text = "1st Sem Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 247);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 116;
            label3.Text = "2nd Sem Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 247);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 117;
            label4.Text = "Miscelleneous";
            // 
            // Enrollments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(896, 553);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(yeartxt);
            Controls.Add(mistxt);
            Controls.Add(secondtxt);
            Controls.Add(firsttxt);
            Controls.Add(comboBox1);
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
            Load += Enrollments_Load;
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
        public ComboBox comboBox1;
        private TextBox firsttxt;
        private TextBox secondtxt;
        private TextBox mistxt;
        private TextBox yeartxt;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}