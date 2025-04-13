namespace StudentInformationSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupLogin = new GroupBox();
            forgotPass = new Label();
            loginBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            titleName = new Label();
            groupLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupLogin
            // 
            groupLogin.BackColor = Color.LightSkyBlue;
            groupLogin.Controls.Add(forgotPass);
            groupLogin.Controls.Add(loginBtn);
            groupLogin.Controls.Add(label2);
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(password);
            groupLogin.Controls.Add(username);
            groupLogin.Controls.Add(titleName);
            groupLogin.Location = new Point(325, 37);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(400, 357);
            groupLogin.TabIndex = 0;
            groupLogin.TabStop = false;
            groupLogin.Enter += groupLogin_Enter;
            // 
            // forgotPass
            // 
            forgotPass.AutoSize = true;
            forgotPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotPass.ForeColor = SystemColors.InactiveCaptionText;
            forgotPass.Location = new Point(204, 265);
            forgotPass.Name = "forgotPass";
            forgotPass.Size = new Size(104, 15);
            forgotPass.TabIndex = 7;
            forgotPass.Text = "Forgot Password?";
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ControlDarkDark;
            loginBtn.Location = new Point(136, 304);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(129, 34);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 213);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 155);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(95, 231);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(213, 31);
            password.TabIndex = 3;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(95, 173);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(213, 32);
            username.TabIndex = 2;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = Color.LightSkyBlue;
            titleName.Font = new Font("Sitka Banner", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = SystemColors.ButtonHighlight;
            titleName.Location = new Point(63, 19);
            titleName.Name = "titleName";
            titleName.Size = new Size(313, 139);
            titleName.TabIndex = 0;
            titleName.Text = "iSTUD";
            titleName.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1012, 461);
            Controls.Add(groupLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupLogin;
        private Label titleName;
        private TextBox username;
        private TextBox password;
        private Label label2;
        private Label label1;
        private Label forgotPass;
        private Button loginBtn;
    }
}
