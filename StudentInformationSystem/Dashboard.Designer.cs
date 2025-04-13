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
            logoutbtn = new Button();
            courseBtn = new Button();
            logsBtn = new Button();
            dashboardBtn = new Button();
            studentBtn = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(courseBtn);
            panel1.Controls.Add(logsBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(studentBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = SystemColors.ScrollBar;
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
            // logsBtn
            // 
            logsBtn.Location = new Point(37, 266);
            logsBtn.Name = "logsBtn";
            logsBtn.Size = new Size(124, 37);
            logsBtn.TabIndex = 4;
            logsBtn.Text = "Logs";
            logsBtn.UseVisualStyleBackColor = true;
            logsBtn.Click += logsBtn_Click;
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
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(812, 461);
            mainPanel.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button dashboardBtn;
        private Button studentBtn;
        private Button courseBtn;
        private Button logsBtn;
        private Button logoutbtn;
        private Panel mainPanel;
    }
}