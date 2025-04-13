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
            panel1 = new Panel();
            logsBtn = new Button();
            titleName = new Label();
            logoutbtn = new Button();
            courseBtn = new Button();
            dashboardBtn = new Button();
            studentBtn = new Button();
            mainPanel = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(logsBtn);
            panel1.Controls.Add(titleName);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(courseBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(studentBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // logsBtn
            // 
            logsBtn.Location = new Point(37, 266);
            logsBtn.Name = "logsBtn";
            logsBtn.Size = new Size(124, 37);
            logsBtn.TabIndex = 7;
            logsBtn.Text = "Logs";
            logsBtn.UseVisualStyleBackColor = true;
            logsBtn.Click += logsBtn_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = Color.LightSkyBlue;
            titleName.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = SystemColors.ButtonHighlight;
            titleName.Location = new Point(24, 44);
            titleName.Name = "titleName";
            titleName.Size = new Size(157, 69);
            titleName.TabIndex = 6;
            titleName.Text = "iSTUD";
            titleName.TextAlign = ContentAlignment.TopCenter;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.SteelBlue;
            logoutbtn.BackgroundImageLayout = ImageLayout.None;
            logoutbtn.ForeColor = SystemColors.ButtonHighlight;
            logoutbtn.Location = new Point(37, 393);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(124, 37);
            logoutbtn.TabIndex = 5;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // courseBtn
            // 
            courseBtn.Location = new Point(37, 223);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(124, 37);
            courseBtn.TabIndex = 3;
            courseBtn.Text = "Courses";
            courseBtn.UseVisualStyleBackColor = true;
            courseBtn.Click += courseBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Location = new Point(37, 137);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(124, 37);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // studentBtn
            // 
            studentBtn.Location = new Point(37, 180);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(124, 37);
            studentBtn.TabIndex = 2;
            studentBtn.Text = "Students";
            studentBtn.UseVisualStyleBackColor = true;
            studentBtn.Click += studentBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(812, 461);
            mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(18, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 435);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(248, 326);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(234, 25);
            label11.TabIndex = 16;
            label11.Text = "Total Graduating  Students";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(310, 354);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(106, 43);
            textBox7.TabIndex = 15;
            textBox7.Text = "1000";
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
            label8.Location = new Point(575, 226);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 13;
            label8.Text = "Total 4th Year";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(575, 254);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(106, 43);
            textBox6.TabIndex = 12;
            textBox6.Text = "1000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(450, 226);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 11;
            label7.Text = "Total 3rd Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(575, 137);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 10;
            label6.Text = "Total 2nd Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(454, 137);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 9;
            label5.Text = "Total 1st Year";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(454, 254);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(106, 43);
            textBox5.TabIndex = 8;
            textBox5.Text = "1000";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(575, 168);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(106, 43);
            textBox4.TabIndex = 7;
            textBox4.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 226);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 6;
            label4.Text = "Total Passed Students";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 140);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 5;
            label3.Text = "Total Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(641, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "8:36 PM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 3;
            label1.Text = "April 13, 2025";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(454, 168);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(106, 43);
            textBox3.TabIndex = 2;
            textBox3.Text = "1000";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(109, 254);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(106, 43);
            textBox2.TabIndex = 1;
            textBox2.Text = "1000";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(109, 168);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(106, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "1000";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1012, 461);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button dashboardBtn;
        private Button studentBtn;
        private Button courseBtn;
        private Button logoutbtn;
        private Panel mainPanel;
        private Label titleName;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox7;
        private Button logsBtn;
        private FileSystemWatcher fileSystemWatcher1;
    }
}