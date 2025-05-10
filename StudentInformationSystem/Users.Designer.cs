namespace StudentInformationSystem
{
    partial class Users
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
            label15 = new Label();
            usernameTxt = new TextBox();
            passTxt = new TextBox();
            newpassTxt = new TextBox();
            confirmpassTxt = new TextBox();
            label1 = new Label();
            saveBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            submitbtn = new Button();
            answertxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            firstnametxt = new TextBox();
            lastnametxt = new TextBox();
            usertxt = new TextBox();
            passwordtxt = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            confirmtxt = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(239, 23);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 34;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(62, 10);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 33;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(315, 115);
            label15.Name = "label15";
            label15.Size = new Size(158, 25);
            label15.TabIndex = 82;
            label15.Text = "Update Password";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Location = new Point(319, 173);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(196, 32);
            usernameTxt.TabIndex = 83;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passTxt.Location = new Point(319, 233);
            passTxt.Multiline = true;
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(196, 32);
            passTxt.TabIndex = 84;
            // 
            // newpassTxt
            // 
            newpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpassTxt.Location = new Point(319, 286);
            newpassTxt.Multiline = true;
            newpassTxt.Name = "newpassTxt";
            newpassTxt.PasswordChar = '*';
            newpassTxt.Size = new Size(196, 32);
            newpassTxt.TabIndex = 85;
            // 
            // confirmpassTxt
            // 
            confirmpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpassTxt.Location = new Point(319, 339);
            confirmpassTxt.Multiline = true;
            confirmpassTxt.Name = "confirmpassTxt";
            confirmpassTxt.PasswordChar = '*';
            confirmpassTxt.Size = new Size(196, 32);
            confirmpassTxt.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(564, 119);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 87;
            label1.Text = "Security Questions";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(319, 377);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(196, 33);
            saveBtn.TabIndex = 88;
            saveBtn.Text = "Save Changes";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 155);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 89;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 215);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 90;
            label3.Text = "Current Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 268);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 91;
            label4.Text = "New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 321);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 92;
            label5.Text = "Confirm New Password";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(562, 218);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 19);
            radioButton1.TabIndex = 93;
            radioButton1.TabStop = true;
            radioButton1.Text = "What is your Favorite Food?";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(562, 243);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(151, 19);
            radioButton2.TabIndex = 94;
            radioButton2.TabStop = true;
            radioButton2.Text = "What is your Pet Name?";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(562, 268);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(173, 19);
            radioButton3.TabIndex = 95;
            radioButton3.TabStop = true;
            radioButton3.Text = "What is your Favorite Color?";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 298);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 96;
            label6.Text = "Answer:";
            label6.Click += label6_Click;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(584, 362);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(151, 31);
            submitbtn.TabIndex = 97;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // answertxt
            // 
            answertxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answertxt.Location = new Point(562, 325);
            answertxt.Multiline = true;
            answertxt.Name = "answertxt";
            answertxt.Size = new Size(189, 32);
            answertxt.TabIndex = 98;
            answertxt.TextChanged += answertxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(560, 155);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 100;
            label7.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(124, 113);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 101;
            label8.Text = "Add User";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(113, 377);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 103;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstnametxt
            // 
            firstnametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnametxt.Location = new Point(44, 173);
            firstnametxt.Multiline = true;
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(116, 32);
            firstnametxt.TabIndex = 104;
            firstnametxt.TextChanged += textBox1_TextChanged;
            // 
            // lastnametxt
            // 
            lastnametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnametxt.Location = new Point(166, 173);
            lastnametxt.Multiline = true;
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(116, 32);
            lastnametxt.TabIndex = 105;
            // 
            // usertxt
            // 
            usertxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertxt.Location = new Point(44, 233);
            usertxt.Multiline = true;
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(238, 32);
            usertxt.TabIndex = 106;
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.Location = new Point(44, 284);
            passwordtxt.Multiline = true;
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(238, 32);
            passwordtxt.TabIndex = 107;
            passwordtxt.TextChanged += textBox4_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 155);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 108;
            label11.Text = "First Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(166, 155);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 109;
            label12.Text = "Last Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 214);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 110;
            label13.Text = "Username";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 268);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 111;
            label14.Text = "Password";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(44, 323);
            label16.Name = "label16";
            label16.Size = new Size(104, 15);
            label16.TabIndex = 113;
            label16.Text = "Confirm Password";
            // 
            // confirmtxt
            // 
            confirmtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmtxt.Location = new Point(44, 339);
            confirmtxt.Multiline = true;
            confirmtxt.Name = "confirmtxt";
            confirmtxt.PasswordChar = '*';
            confirmtxt.Size = new Size(238, 32);
            confirmtxt.TabIndex = 112;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(564, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 114;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label16);
            Controls.Add(confirmtxt);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(passwordtxt);
            Controls.Add(usertxt);
            Controls.Add(lastnametxt);
            Controls.Add(firstnametxt);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(answertxt);
            Controls.Add(submitbtn);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            Controls.Add(confirmpassTxt);
            Controls.Add(newpassTxt);
            Controls.Add(passTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label15;
        private TextBox usernameTxt;
        private TextBox passTxt;
        private TextBox newpassTxt;
        private TextBox confirmpassTxt;
        private Label label1;
        private Button saveBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private Button submitbtn;
        private TextBox answertxt;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox firstnametxt;
        private TextBox lastnametxt;
        private TextBox usertxt;
        private TextBox passwordtxt;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private TextBox confirmtxt;
       public ComboBox comboBox1;
    }
}