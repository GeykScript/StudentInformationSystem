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
            excelbtn = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            searchbar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(267, 24);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
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
            label9.Location = new Point(90, 10);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 35;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 263);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(726, 141);
            dataGridView1.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(291, 86);
            label8.Name = "label8";
            label8.Size = new Size(295, 25);
            label8.TabIndex = 102;
            label8.Text = "Students Enrollment Transactions";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(574, 169);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(155, 40);
            button1.TabIndex = 103;
            button1.Text = "Add New Transaction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Refreshbtn
            // 
            Refreshbtn.Location = new Point(44, 237);
            Refreshbtn.Margin = new Padding(3, 2, 3, 2);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(64, 22);
            Refreshbtn.TabIndex = 104;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = true;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 108;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // firsttxt
            // 
            firsttxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firsttxt.Location = new Point(291, 186);
            firsttxt.Multiline = true;
            firsttxt.Name = "firsttxt";
            firsttxt.Size = new Size(88, 23);
            firsttxt.TabIndex = 109;
            firsttxt.TextChanged += usernameTxt2_TextChanged;
            // 
            // secondtxt
            // 
            secondtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondtxt.Location = new Point(385, 186);
            secondtxt.Multiline = true;
            secondtxt.Name = "secondtxt";
            secondtxt.Size = new Size(88, 23);
            secondtxt.TabIndex = 110;
            secondtxt.TextChanged += textBox1_TextChanged;
            // 
            // mistxt
            // 
            mistxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mistxt.Location = new Point(479, 186);
            mistxt.Multiline = true;
            mistxt.Name = "mistxt";
            mistxt.Size = new Size(88, 23);
            mistxt.TabIndex = 111;
            mistxt.TextChanged += textBox2_TextChanged;
            // 
            // yeartxt
            // 
            yeartxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeartxt.Location = new Point(197, 186);
            yeartxt.Multiline = true;
            yeartxt.Name = "yeartxt";
            yeartxt.Size = new Size(88, 23);
            yeartxt.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 121);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 113;
            label7.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 168);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 114;
            label1.Text = "Year Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 168);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 115;
            label2.Text = "1st Sem Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 168);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 116;
            label3.Text = "2nd Sem Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 168);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 117;
            label4.Text = "Miscelleneous";
            // 
            // excelbtn
            // 
            excelbtn.BackColor = Color.Lime;
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excelbtn.ForeColor = SystemColors.ActiveCaptionText;
            excelbtn.Location = new Point(575, 134);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(117, 32);
            excelbtn.TabIndex = 118;
            excelbtn.Text = "Export to Excel";
            excelbtn.UseVisualStyleBackColor = false;
            excelbtn.Click += excelbtn_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Window;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 20;
            iconPictureBox2.Location = new Point(282, 236);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(21, 20);
            iconPictureBox2.TabIndex = 122;
            iconPictureBox2.TabStop = false;
            // 
            // searchbar
            // 
            searchbar.Location = new Point(114, 236);
            searchbar.Margin = new Padding(3, 2, 3, 2);
            searchbar.Name = "searchbar";
            searchbar.Size = new Size(171, 23);
            searchbar.TabIndex = 121;
            searchbar.TextChanged += searchbar_TextChanged;
            // 
            // Enrollments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(784, 415);
            Controls.Add(iconPictureBox2);
            Controls.Add(searchbar);
            Controls.Add(excelbtn);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Enrollments";
            Text = "Enrollments";
            Load += Enrollments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
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
        private Button excelbtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox searchbar;
    }
}