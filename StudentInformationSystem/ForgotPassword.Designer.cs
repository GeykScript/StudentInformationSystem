namespace StudentInformationSystem
{
    partial class ForgotPassword
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
            label15 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            usernameTxt2 = new TextBox();
            answertxt = new TextBox();
            label6 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            confirmpassTxt = new TextBox();
            newpassTxt = new TextBox();
            submitbtn = new Button();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(350, 105);
            label15.Name = "label15";
            label15.Size = new Size(153, 25);
            label15.TabIndex = 85;
            label15.Text = "Forgot Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(253, 29);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 84;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(90, 16);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 83;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 152);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 107;
            label7.Text = "Username";
            // 
            // usernameTxt2
            // 
            usernameTxt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt2.Location = new Point(148, 170);
            usernameTxt2.Multiline = true;
            usernameTxt2.Name = "usernameTxt2";
            usernameTxt2.Size = new Size(213, 32);
            usernameTxt2.TabIndex = 106;
            // 
            // answertxt
            // 
            answertxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answertxt.Location = new Point(160, 322);
            answertxt.Multiline = true;
            answertxt.Name = "answertxt";
            answertxt.Size = new Size(213, 32);
            answertxt.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 295);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 104;
            label6.Text = "Answer:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(160, 265);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(173, 19);
            radioButton3.TabIndex = 103;
            radioButton3.TabStop = true;
            radioButton3.Text = "What is your Favorite Color?";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(160, 240);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(151, 19);
            radioButton2.TabIndex = 102;
            radioButton2.TabStop = true;
            radioButton2.Text = "What is your Pet Name?";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(160, 215);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 19);
            radioButton1.TabIndex = 101;
            radioButton1.TabStop = true;
            radioButton1.Text = "What is your Favorite Food?";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 262);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 112;
            label5.Text = "Confirm New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 197);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 111;
            label4.Text = "New Password";
            // 
            // confirmpassTxt
            // 
            confirmpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpassTxt.Location = new Point(437, 280);
            confirmpassTxt.Multiline = true;
            confirmpassTxt.Name = "confirmpassTxt";
            confirmpassTxt.PasswordChar = '*';
            confirmpassTxt.Size = new Size(213, 32);
            confirmpassTxt.TabIndex = 109;
            // 
            // newpassTxt
            // 
            newpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpassTxt.Location = new Point(437, 215);
            newpassTxt.Multiline = true;
            newpassTxt.Name = "newpassTxt";
            newpassTxt.PasswordChar = '*';
            newpassTxt.Size = new Size(213, 32);
            newpassTxt.TabIndex = 108;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Chartreuse;
            submitbtn.Location = new Point(493, 323);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(116, 31);
            submitbtn.TabIndex = 113;
            submitbtn.Text = "Save Changes";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.LightSkyBlue;
            loginbtn.Location = new Point(363, 392);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(122, 35);
            loginbtn.TabIndex = 114;
            loginbtn.Text = "Return to Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(loginbtn);
            Controls.Add(submitbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(confirmpassTxt);
            Controls.Add(newpassTxt);
            Controls.Add(label7);
            Controls.Add(usernameTxt2);
            Controls.Add(answertxt);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox usernameTxt2;
        private TextBox answertxt;
        private Label label6;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Label label4;
        private TextBox confirmpassTxt;
        private TextBox newpassTxt;
        private Button submitbtn;
        private Button loginbtn;
    }
}