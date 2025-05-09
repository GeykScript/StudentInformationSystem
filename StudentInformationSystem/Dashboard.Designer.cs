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
            gradesBtn = new Button();
            usersbtn = new Button();
            enrollmentsBtn = new Button();
            paymentsBtn = new Button();
            titleName = new Label();
            logoutbtn = new Button();
            courseBtn = new Button();
            dashboardBtn = new Button();
            studentBtn = new Button();
            mainPanel = new Panel();
            panel2 = new Panel();
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
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(gradesBtn);
            panel1.Controls.Add(usersbtn);
            panel1.Controls.Add(enrollmentsBtn);
            panel1.Controls.Add(paymentsBtn);
            panel1.Controls.Add(titleName);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(courseBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(studentBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 661);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // gradesBtn
            // 
            gradesBtn.Location = new Point(43, 297);
            gradesBtn.Margin = new Padding(3, 4, 3, 4);
            gradesBtn.Name = "gradesBtn";
            gradesBtn.Size = new Size(142, 49);
            gradesBtn.TabIndex = 11;
            gradesBtn.Text = "Grades";
            gradesBtn.UseVisualStyleBackColor = true;
            gradesBtn.Click += gradesBtn_Click;
            // 
            // usersbtn
            // 
            usersbtn.Location = new Point(42, 524);
            usersbtn.Margin = new Padding(3, 4, 3, 4);
            usersbtn.Name = "usersbtn";
            usersbtn.Size = new Size(142, 49);
            usersbtn.TabIndex = 10;
            usersbtn.Text = "Users";
            usersbtn.UseVisualStyleBackColor = true;
            usersbtn.Click += usersbtn_Click;
            // 
            // enrollmentsBtn
            // 
            enrollmentsBtn.Location = new Point(43, 467);
            enrollmentsBtn.Margin = new Padding(3, 4, 3, 4);
            enrollmentsBtn.Name = "enrollmentsBtn";
            enrollmentsBtn.Size = new Size(142, 49);
            enrollmentsBtn.TabIndex = 9;
            enrollmentsBtn.Text = "Enrollments";
            enrollmentsBtn.UseVisualStyleBackColor = true;
            enrollmentsBtn.Click += enrollmentsBtn_Click;
            // 
            // paymentsBtn
            // 
            paymentsBtn.Location = new Point(43, 409);
            paymentsBtn.Margin = new Padding(3, 4, 3, 4);
            paymentsBtn.Name = "paymentsBtn";
            paymentsBtn.Size = new Size(142, 49);
            paymentsBtn.TabIndex = 8;
            paymentsBtn.Text = "Payments";
            paymentsBtn.UseVisualStyleBackColor = true;
            paymentsBtn.Click += paymentsBtn_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = Color.LightSkyBlue;
            titleName.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = SystemColors.ButtonHighlight;
            titleName.Location = new Point(27, 59);
            titleName.Name = "titleName";
            titleName.Size = new Size(196, 87);
            titleName.TabIndex = 6;
            titleName.Text = "iSTUD";
            titleName.TextAlign = ContentAlignment.TopCenter;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.SteelBlue;
            logoutbtn.BackgroundImageLayout = ImageLayout.None;
            logoutbtn.ForeColor = SystemColors.ButtonHighlight;
            logoutbtn.Location = new Point(42, 596);
            logoutbtn.Margin = new Padding(3, 4, 3, 4);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(142, 49);
            logoutbtn.TabIndex = 5;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // courseBtn
            // 
            courseBtn.Location = new Point(43, 353);
            courseBtn.Margin = new Padding(3, 4, 3, 4);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(142, 49);
            courseBtn.TabIndex = 3;
            courseBtn.Text = "Courses";
            courseBtn.UseVisualStyleBackColor = true;
            courseBtn.Click += courseBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Location = new Point(42, 183);
            dashboardBtn.Margin = new Padding(3, 4, 3, 4);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(142, 49);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // studentBtn
            // 
            studentBtn.Location = new Point(42, 240);
            studentBtn.Margin = new Padding(3, 4, 3, 4);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(142, 49);
            studentBtn.TabIndex = 2;
            studentBtn.Text = "Students";
            studentBtn.UseVisualStyleBackColor = true;
            studentBtn.Click += studentBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(229, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(928, 661);
            mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
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
            panel2.Location = new Point(21, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 580);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox.BorderStyle = BorderStyle.None;
            dateTimeTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox.Location = new Point(275, 141);
            dateTimeTextBox.Margin = new Padding(3, 4, 3, 4);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(370, 45);
            dateTimeTextBox.TabIndex = 18;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(261, 392);
            refreshbtn.Margin = new Padding(3, 4, 3, 4);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(86, 31);
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
            label10.Location = new Point(216, 37);
            label10.Name = "label10";
            label10.Size = new Size(530, 43);
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
            label9.Location = new Point(30, 17);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
            label9.TabIndex = 7;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(577, 337);
            label8.Name = "label8";
            label8.Size = new Size(158, 32);
            label8.TabIndex = 13;
            label8.Text = "Total 4th Year";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(577, 375);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(121, 56);
            textBox6.TabIndex = 12;
            textBox6.Text = "1000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(434, 337);
            label7.Name = "label7";
            label7.Size = new Size(158, 32);
            label7.TabIndex = 11;
            label7.Text = "Total 3rd Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(577, 219);
            label6.Name = "label6";
            label6.Size = new Size(164, 32);
            label6.TabIndex = 10;
            label6.Text = "Total 2nd Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(431, 219);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 9;
            label5.Text = "Total 1st Year";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(439, 375);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(121, 56);
            textBox5.TabIndex = 8;
            textBox5.Text = "1000";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(577, 260);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(121, 56);
            textBox4.TabIndex = 7;
            textBox4.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(233, 223);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 5;
            label3.Text = "Total Students";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(439, 260);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(121, 56);
            textBox3.TabIndex = 2;
            textBox3.Text = "1000";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // paymentBtn
            // 
            paymentBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentBtn.Location = new Point(243, 260);
            paymentBtn.Margin = new Padding(3, 4, 3, 4);
            paymentBtn.Multiline = true;
            paymentBtn.Name = "paymentBtn";
            paymentBtn.ReadOnly = true;
            paymentBtn.Size = new Size(121, 56);
            paymentBtn.TabIndex = 0;
            paymentBtn.Text = "1000";
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1157, 661);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button paymentsBtn;
        private Button enrollmentsBtn;
        private Button usersbtn;
        private Button gradesBtn;
    }
}