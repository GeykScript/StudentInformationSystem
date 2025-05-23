﻿namespace StudentInformationSystem
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
            dateTimeTextBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            refreshbtn = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            comboBox1 = new ComboBox();
            yeartxt = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            firstnametxt = new TextBox();
            lastnametxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            excelbtn = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            searchbar = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(221, 64);
            label10.Name = "label10";
            label10.Size = new Size(530, 43);
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
            label9.Location = new Point(34, 44);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
            label9.TabIndex = 43;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // addstudent
            // 
            addstudent.BackColor = Color.Tomato;
            addstudent.Location = new Point(711, 252);
            addstudent.Margin = new Padding(3, 4, 3, 4);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(133, 44);
            addstudent.TabIndex = 53;
            addstudent.Text = "Add Student";
            addstudent.UseVisualStyleBackColor = false;
            addstudent.Click += button1_Click;
            // 
            // editstudent
            // 
            editstudent.BackColor = Color.SkyBlue;
            editstudent.Location = new Point(711, 304);
            editstudent.Margin = new Padding(3, 4, 3, 4);
            editstudent.Name = "editstudent";
            editstudent.Size = new Size(133, 44);
            editstudent.TabIndex = 55;
            editstudent.Text = "Edit Student";
            editstudent.UseVisualStyleBackColor = false;
            editstudent.Click += editstudent_Click;
            // 
            // dateTimeTextBox3
            // 
            dateTimeTextBox3.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox3.BorderStyle = BorderStyle.None;
            dateTimeTextBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox3.Location = new Point(473, 115);
            dateTimeTextBox3.Margin = new Padding(3, 4, 3, 4);
            dateTimeTextBox3.Name = "dateTimeTextBox3";
            dateTimeTextBox3.ReadOnly = true;
            dateTimeTextBox3.Size = new Size(370, 35);
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
            refreshbtn.Location = new Point(32, 364);
            refreshbtn.Margin = new Padding(3, 4, 3, 4);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(86, 31);
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
            dataGridView1.Location = new Point(34, 411);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 176);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 171);
            label8.Name = "label8";
            label8.Size = new Size(245, 32);
            label8.TabIndex = 103;
            label8.Text = "Students Information";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(357, 317);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 28);
            comboBox1.TabIndex = 104;
            // 
            // yeartxt
            // 
            yeartxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeartxt.Location = new Point(626, 272);
            yeartxt.Margin = new Padding(3, 4, 3, 4);
            yeartxt.Multiline = true;
            yeartxt.Name = "yeartxt";
            yeartxt.Size = new Size(57, 36);
            yeartxt.TabIndex = 107;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(357, 279);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(252, 28);
            comboBox2.TabIndex = 108;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 321);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 109;
            label7.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 255);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 110;
            label1.Text = "Course Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 252);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 111;
            label2.Text = "Yr. Level";
            // 
            // firstnametxt
            // 
            firstnametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnametxt.Location = new Point(34, 279);
            firstnametxt.Margin = new Padding(3, 4, 3, 4);
            firstnametxt.Multiline = true;
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(151, 29);
            firstnametxt.TabIndex = 112;
            firstnametxt.TextChanged += textBox1_TextChanged;
            // 
            // lastnametxt
            // 
            lastnametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnametxt.Location = new Point(193, 279);
            lastnametxt.Margin = new Padding(3, 4, 3, 4);
            lastnametxt.Multiline = true;
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(143, 29);
            lastnametxt.TabIndex = 113;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 252);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 114;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 252);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 115;
            label4.Text = "Last Name";
            // 
            // excelbtn
            // 
            excelbtn.BackColor = Color.Lime;
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excelbtn.ForeColor = SystemColors.ActiveCaptionText;
            excelbtn.Location = new Point(38, 183);
            excelbtn.Margin = new Padding(3, 4, 3, 4);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(134, 43);
            excelbtn.TabIndex = 116;
            excelbtn.Text = "Export to Excel";
            excelbtn.UseVisualStyleBackColor = false;
            excelbtn.Click += excelbtn_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Window;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(425, 115);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(41, 52);
            iconPictureBox1.TabIndex = 117;
            iconPictureBox1.TabStop = false;
            // 
            // searchbar
            // 
            searchbar.Location = new Point(617, 368);
            searchbar.Name = "searchbar";
            searchbar.Size = new Size(195, 27);
            searchbar.TabIndex = 118;
            searchbar.TextChanged += searchbar_TextChanged;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Window;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 24;
            iconPictureBox2.Location = new Point(809, 368);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(24, 27);
            iconPictureBox2.TabIndex = 119;
            iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 345);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 120;
            label5.Text = "Search";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(iconPictureBox2);
            Controls.Add(searchbar);
            Controls.Add(iconPictureBox1);
            Controls.Add(excelbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lastnametxt);
            Controls.Add(firstnametxt);
            Controls.Add(addstudent);
            Controls.Add(label2);
            Controls.Add(editstudent);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(yeartxt);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(refreshbtn);
            Controls.Add(dateTimeTextBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Button addstudent;
        private Button editstudent;
        public TextBox dateTimeTextBox;
        private System.Windows.Forms.Timer timer1;
        public TextBox dateTimeTextBox3;
        private Button refreshbtn;
        public DataGridView dataGridView1;
        private Label label8;
        public ComboBox comboBox1;
        private TextBox yeartxt;
        public ComboBox comboBox2;
        private Label label7;
        private Label label1;
        private Label label2;
        private TextBox firstnametxt;
        private TextBox lastnametxt;
        private Label label3;
        private Label label4;
        private Button excelbtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox searchbar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label5;
    }
}