namespace StudentInformationSystem
{
    partial class Dashboard
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
            panel1 = new Panel();
            logout = new FontAwesome.Sharp.IconButton();
            userbtn = new FontAwesome.Sharp.IconButton();
            enrollment_fees = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            course = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            Students = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            titleName = new Label();
            mainPanel = new Panel();
            panel2 = new Panel();
            grades = new Label();
            label15 = new Label();
            dateTimeTextBox = new TextBox();
            refreshbtn = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            paymentBtn = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            timer1 = new System.Windows.Forms.Timer(components);
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(logout);
            panel1.Controls.Add(userbtn);
            panel1.Controls.Add(enrollment_fees);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(course);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(Students);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(titleName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 496);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // logout
            // 
            logout.BackColor = Color.SteelBlue;
            logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = SystemColors.ControlLightLight;
            logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logout.IconColor = Color.White;
            logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logout.IconSize = 20;
            logout.Location = new Point(39, 447);
            logout.Name = "logout";
            logout.Size = new Size(122, 37);
            logout.TabIndex = 19;
            logout.Text = "Logout";
            logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // userbtn
            // 
            userbtn.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            userbtn.IconColor = Color.Black;
            userbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userbtn.IconSize = 20;
            userbtn.Location = new Point(39, 388);
            userbtn.Name = "userbtn";
            userbtn.Size = new Size(122, 37);
            userbtn.TabIndex = 18;
            userbtn.Text = "Users";
            userbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userbtn.UseVisualStyleBackColor = true;
            userbtn.Click += userbtn_Click;
            // 
            // enrollment_fees
            // 
            enrollment_fees.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enrollment_fees.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            enrollment_fees.IconColor = Color.Black;
            enrollment_fees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            enrollment_fees.IconSize = 20;
            enrollment_fees.Location = new Point(40, 345);
            enrollment_fees.Name = "enrollment_fees";
            enrollment_fees.Size = new Size(121, 37);
            enrollment_fees.TabIndex = 17;
            enrollment_fees.Text = "Enrollment Fee";
            enrollment_fees.TextImageRelation = TextImageRelation.ImageBeforeText;
            enrollment_fees.UseVisualStyleBackColor = true;
            enrollment_fees.Click += enrollment_fees_Click;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.Location = new Point(40, 302);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(121, 37);
            iconButton3.TabIndex = 16;
            iconButton3.Text = "Payments";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // course
            // 
            course.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            course.IconColor = Color.Black;
            course.IconFont = FontAwesome.Sharp.IconFont.Auto;
            course.IconSize = 20;
            course.Location = new Point(40, 259);
            course.Name = "course";
            course.Size = new Size(121, 37);
            course.TabIndex = 15;
            course.Text = "Course";
            course.TextAlign = ContentAlignment.MiddleLeft;
            course.TextImageRelation = TextImageRelation.ImageBeforeText;
            course.UseVisualStyleBackColor = true;
            course.Click += course_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(40, 216);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(121, 37);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Grades";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // Students
            // 
            Students.IconChar = FontAwesome.Sharp.IconChar.Users;
            Students.IconColor = Color.Black;
            Students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Students.IconSize = 20;
            Students.Location = new Point(40, 175);
            Students.Name = "Students";
            Students.Size = new Size(121, 37);
            Students.TabIndex = 13;
            Students.Text = "Students";
            Students.TextImageRelation = TextImageRelation.ImageBeforeText;
            Students.UseVisualStyleBackColor = true;
            Students.Click += Students_Click;
            // 
            // iconButton1
            // 
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(40, 131);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(121, 37);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Dashboard";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = Color.LightSkyBlue;
            titleName.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = SystemColors.ButtonHighlight;
            titleName.Location = new Point(26, 25);
            titleName.Name = "titleName";
            titleName.Size = new Size(157, 69);
            titleName.TabIndex = 6;
            titleName.Text = "iSTUD";
            titleName.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(812, 496);
            mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(grades);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(dateTimeTextBox);
            panel2.Controls.Add(refreshbtn);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(paymentBtn);
            panel2.Location = new Point(18, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 435);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // grades
            // 
            grades.AutoSize = true;
            grades.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grades.Location = new Point(185, 171);
            grades.Name = "grades";
            grades.Size = new Size(0, 25);
            grades.TabIndex = 84;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(347, 148);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 83;
            label15.Text = "Dashboard";
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox.BorderStyle = BorderStyle.None;
            dateTimeTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox.Location = new Point(108, 98);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(324, 36);
            dateTimeTextBox.TabIndex = 18;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(217, 324);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 36);
            refreshbtn.TabIndex = 17;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(189, 28);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 14;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(26, 13);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 7;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(496, 290);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 13;
            label8.Text = "Total 4th Year";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSkyBlue;
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(496, 318);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(106, 43);
            textBox6.TabIndex = 12;
            textBox6.Text = "1000";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(371, 290);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 11;
            label7.Text = "Total 3rd Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(496, 201);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 10;
            label6.Text = "Total 2nd Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(368, 201);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 9;
            label5.Text = "Total 1st Year";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Turquoise;
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(375, 318);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(106, 43);
            textBox5.TabIndex = 8;
            textBox5.Text = "1000";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Chartreuse;
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(496, 232);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(106, 43);
            textBox4.TabIndex = 7;
            textBox4.Text = "1000";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(195, 204);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 5;
            label3.Text = "Total Students";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gold;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(375, 232);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(106, 43);
            textBox3.TabIndex = 2;
            textBox3.Text = "1000";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // paymentBtn
            // 
            paymentBtn.BackColor = Color.Tomato;
            paymentBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentBtn.Location = new Point(204, 232);
            paymentBtn.Multiline = true;
            paymentBtn.Name = "paymentBtn";
            paymentBtn.ReadOnly = true;
            paymentBtn.Size = new Size(106, 43);
            paymentBtn.TabIndex = 0;
            paymentBtn.Text = "1000";
            paymentBtn.TextAlign = HorizontalAlignment.Center;
            paymentBtn.TextChanged += textBox1_TextChanged;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Window;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 45;
            iconPictureBox1.Location = new Point(56, 98);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(46, 45);
            iconPictureBox1.TabIndex = 85;
            iconPictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1012, 496);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button dashboardBtn;
        private Panel mainPanel;
        private Label titleName;
        private Panel panel2;
        public TextBox paymentBtn;
        public TextBox textBox3;
        private Label label5;
        public TextBox textBox5;
        public TextBox textBox4;
        private Label label3;
        private Label label8;
        public TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private FileSystemWatcher fileSystemWatcher1;
        private Button refreshbtn;
        private System.Windows.Forms.Timer timer1;
        public TextBox dateTimeTextBox;
        private Label grades;
        private Label label15;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton course;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton enrollment_fees;
        private FontAwesome.Sharp.IconButton userbtn;
        private FontAwesome.Sharp.IconButton logout;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}