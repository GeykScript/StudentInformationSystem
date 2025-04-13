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
            dashboardgroup = new GroupBox();
            Logout = new Button();
            titleName = new Label();
            studentsbtn = new Button();
            gradeBtn = new Button();
            courseBtn = new Button();
            logBtn = new Button();
            dashboardgroup.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardgroup
            // 
            dashboardgroup.BackColor = SystemColors.ButtonFace;
            dashboardgroup.Controls.Add(logBtn);
            dashboardgroup.Controls.Add(courseBtn);
            dashboardgroup.Controls.Add(gradeBtn);
            dashboardgroup.Controls.Add(studentsbtn);
            dashboardgroup.Controls.Add(Logout);
            dashboardgroup.Controls.Add(titleName);
            dashboardgroup.Location = new Point(0, -11);
            dashboardgroup.Name = "dashboardgroup";
            dashboardgroup.Size = new Size(192, 473);
            dashboardgroup.TabIndex = 0;
            dashboardgroup.TabStop = false;
            // 
            // Logout
            // 
            Logout.Location = new Point(21, 428);
            Logout.Name = "Logout";
            Logout.Size = new Size(152, 32);
            Logout.TabIndex = 2;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = SystemColors.ButtonFace;
            titleName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = SystemColors.ButtonShadow;
            titleName.Location = new Point(12, 45);
            titleName.Name = "titleName";
            titleName.Size = new Size(167, 65);
            titleName.TabIndex = 1;
            titleName.Text = "iSTUD";
            titleName.TextAlign = ContentAlignment.TopCenter;
            titleName.Click += titleName_Click;
            // 
            // studentsbtn
            // 
            studentsbtn.Location = new Point(19, 148);
            studentsbtn.Name = "studentsbtn";
            studentsbtn.Size = new Size(152, 32);
            studentsbtn.TabIndex = 3;
            studentsbtn.Text = "Students";
            studentsbtn.UseVisualStyleBackColor = true;
            // 
            // gradeBtn
            // 
            gradeBtn.Location = new Point(19, 186);
            gradeBtn.Name = "gradeBtn";
            gradeBtn.Size = new Size(152, 32);
            gradeBtn.TabIndex = 4;
            gradeBtn.Text = "Grades";
            gradeBtn.UseVisualStyleBackColor = true;
            // 
            // courseBtn
            // 
            courseBtn.Location = new Point(19, 224);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(152, 32);
            courseBtn.TabIndex = 5;
            courseBtn.Text = "Courses";
            courseBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            logBtn.Location = new Point(19, 262);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(152, 32);
            logBtn.TabIndex = 6;
            logBtn.Text = "Logs";
            logBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1012, 461);
            Controls.Add(dashboardgroup);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            dashboardgroup.ResumeLayout(false);
            dashboardgroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dashboardgroup;
        private Button Logout;
        private Label titleName;
        private Button logBtn;
        private Button courseBtn;
        private Button gradeBtn;
        private Button studentsbtn;
    }
}