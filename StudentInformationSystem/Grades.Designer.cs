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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            gradetxt = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            refreshbtn = new Button();
            excelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(262, 27);
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
            dataGridView1.Location = new Point(213, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(406, 135);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(313, 114);
            label15.Name = "label15";
            label15.Size = new Size(218, 25);
            label15.TabIndex = 86;
            label15.Text = "Students Average Grade";
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(423, 157);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 87;
            button1.Text = "View Student Grades";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Location = new Point(537, 239);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 35);
            button2.TabIndex = 88;
            button2.Text = "Add Grade";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(213, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 105;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(213, 211);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 23);
            comboBox2.TabIndex = 106;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(423, 211);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 23);
            comboBox3.TabIndex = 107;
            // 
            // gradetxt
            // 
            gradetxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gradetxt.Location = new Point(474, 239);
            gradetxt.Multiline = true;
            gradetxt.Name = "gradetxt";
            gradetxt.Size = new Size(57, 34);
            gradetxt.TabIndex = 108;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 143);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 109;
            label7.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 193);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 110;
            label1.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 193);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 111;
            label2.Text = "Subjects";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 249);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 112;
            label3.Text = "Grade:";
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(213, 245);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 23);
            refreshbtn.TabIndex = 113;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // excelbtn
            // 
            excelbtn.BackColor = Color.Lime;
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excelbtn.ForeColor = SystemColors.ActiveCaptionText;
            excelbtn.Location = new Point(560, 157);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(117, 29);
            excelbtn.TabIndex = 117;
            excelbtn.Text = "Export to Excel";
            excelbtn.UseVisualStyleBackColor = false;
            excelbtn.Click += excelbtn_Click;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(excelbtn);
            Controls.Add(refreshbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(gradetxt);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        public ComboBox comboBox3;
        private TextBox gradetxt;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button refreshbtn;
        private Button excelbtn;
    }
}