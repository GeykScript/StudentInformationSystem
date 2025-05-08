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
            titleName = new Label();
            username = new TextBox();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            groupLogin = new GroupBox();
            forgotbtn = new Button();
            groupLogin.SuspendLayout();
            SuspendLayout();
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
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(95, 173);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(213, 32);
            username.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(95, 231);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(213, 31);
            passwordTxt.TabIndex = 3;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Location = new Point(92, 173);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(213, 32);
            usernameTxt.TabIndex = 2;
            usernameTxt.TextChanged += textBox1_TextChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Username:";
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
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ControlDarkDark;
            loginBtn.Location = new Point(140, 320);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(129, 34);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // groupLogin
            // 
            groupLogin.BackColor = Color.LightSkyBlue;
            groupLogin.Controls.Add(forgotbtn);
            groupLogin.Controls.Add(loginBtn);
            groupLogin.Controls.Add(label2);
            groupLogin.Controls.Add(label3);
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(usernameTxt);
            groupLogin.Controls.Add(passwordTxt);
            groupLogin.Controls.Add(username);
            groupLogin.Controls.Add(titleName);
            groupLogin.Location = new Point(325, 37);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(400, 378);
            groupLogin.TabIndex = 0;
            groupLogin.TabStop = false;
            groupLogin.Enter += groupLogin_Enter;
            // 
            // forgotbtn
            // 
            forgotbtn.BackColor = Color.Transparent;
            forgotbtn.BackgroundImageLayout = ImageLayout.None;
            forgotbtn.Cursor = Cursors.Hand;
            forgotbtn.FlatAppearance.BorderColor = Color.LightSkyBlue;
            forgotbtn.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            forgotbtn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            forgotbtn.FlatStyle = FlatStyle.Flat;
            forgotbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotbtn.ForeColor = Color.SteelBlue;
            forgotbtn.Location = new Point(186, 264);
            forgotbtn.Name = "forgotbtn";
            forgotbtn.Size = new Size(136, 34);
            forgotbtn.TabIndex = 7;
            forgotbtn.Text = "Forgot Password?";
            forgotbtn.UseVisualStyleBackColor = false;
            forgotbtn.Click += forgotbtn_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleName;
        private TextBox username;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button loginBtn;
        private GroupBox groupLogin;
        private Button forgotbtn;
    }
}
