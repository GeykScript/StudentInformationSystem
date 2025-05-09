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
            components = new System.ComponentModel.Container();
            label10 = new Label();
            label9 = new Label();
            addstudent = new Button();
            editstudent = new Button();
            btnPanel = new Panel();
            dateTimeTextBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            refreshbtn = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            comboBox1 = new ComboBox();
            usernameTxt2 = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnPanel.Location = new Point(559, 174);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(214, 47);
            btnPanel.TabIndex = 56;
            btnPanel.Paint += btnPanel_Paint;
            // 
            // dateTimeTextBox3
            // 
            dateTimeTextBox3.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox3.BorderStyle = BorderStyle.None;
            dateTimeTextBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox3.Location = new Point(414, 86);
            dateTimeTextBox3.Name = "dateTimeTextBox3";
            dateTimeTextBox3.ReadOnly = true;
            dateTimeTextBox3.Size = new Size(324, 28);
            dateTimeTextBox3.TabIndex = 57;
            dateTimeTextBox3.TextChanged += dateTimeTextBox_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(53, 222);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 23);
            refreshbtn.TabIndex = 58;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(53, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(657, 150);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(312, 128);
            label8.Name = "label8";
            label8.Size = new Size(194, 25);
            label8.TabIndex = 103;
            label8.Text = "Students Information";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 104;
            // 
            // usernameTxt2
            // 
            usernameTxt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt2.Location = new Point(481, 182);
            usernameTxt2.Multiline = true;
            usernameTxt2.Name = "usernameTxt2";
            usernameTxt2.Size = new Size(50, 28);
            usernameTxt2.TabIndex = 107;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(245, 184);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 23);
            comboBox2.TabIndex = 108;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 166);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 109;
            label7.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 166);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 110;
            label1.Text = "Course Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 164);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 111;
            label2.Text = "Yr. Level";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(usernameTxt2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(refreshbtn);
            Controls.Add(dateTimeTextBox3);
            Controls.Add(btnPanel);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Button addstudent;
        private Button editstudent;
        private Panel btnPanel;
        public TextBox dateTimeTextBox;
        private System.Windows.Forms.Timer timer1;
        public TextBox dateTimeTextBox3;
        private Button refreshbtn;
        public DataGridView dataGridView1;
        private Label label8;
        public ComboBox comboBox1;
        private TextBox usernameTxt2;
        public ComboBox comboBox2;
        private Label label7;
        private Label label1;
        private Label label2;
    }
}