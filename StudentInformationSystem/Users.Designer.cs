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
            usernameTxt2 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(225, 23);
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
            label15.Location = new Point(390, 118);
            label15.Name = "label15";
            label15.Size = new Size(158, 25);
            label15.TabIndex = 82;
            label15.Text = "Update Password";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Location = new Point(395, 176);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(153, 32);
            usernameTxt.TabIndex = 83;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passTxt.Location = new Point(395, 236);
            passTxt.Multiline = true;
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(153, 32);
            passTxt.TabIndex = 84;
            // 
            // newpassTxt
            // 
            newpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpassTxt.Location = new Point(395, 289);
            newpassTxt.Multiline = true;
            newpassTxt.Name = "newpassTxt";
            newpassTxt.PasswordChar = '*';
            newpassTxt.Size = new Size(153, 32);
            newpassTxt.TabIndex = 85;
            // 
            // confirmpassTxt
            // 
            confirmpassTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpassTxt.Location = new Point(395, 342);
            confirmpassTxt.Multiline = true;
            confirmpassTxt.Name = "confirmpassTxt";
            confirmpassTxt.PasswordChar = '*';
            confirmpassTxt.Size = new Size(153, 32);
            confirmpassTxt.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 116);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 87;
            label1.Text = "Security Questions";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(395, 380);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 33);
            saveBtn.TabIndex = 88;
            saveBtn.Text = "Save Changes";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 158);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 89;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 218);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 90;
            label3.Text = "Current Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 271);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 91;
            label4.Text = "New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 324);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 92;
            label5.Text = "Confirm New Password";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(596, 215);
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
            radioButton2.Location = new Point(596, 240);
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
            radioButton3.Location = new Point(596, 265);
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
            label6.Location = new Point(596, 295);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 96;
            label6.Text = "Answer:";
            label6.Click += label6_Click;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(631, 360);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(116, 31);
            submitbtn.TabIndex = 97;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // answertxt
            // 
            answertxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answertxt.Location = new Point(596, 322);
            answertxt.Multiline = true;
            answertxt.Name = "answertxt";
            answertxt.Size = new Size(173, 32);
            answertxt.TabIndex = 98;
            answertxt.TextChanged += answertxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 152);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 100;
            label7.Text = "Username";
            // 
            // usernameTxt2
            // 
            usernameTxt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt2.Location = new Point(596, 170);
            usernameTxt2.Multiline = true;
            usernameTxt2.Name = "usernameTxt2";
            usernameTxt2.Size = new Size(170, 32);
            usernameTxt2.TabIndex = 99;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(154, 118);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 101;
            label8.Text = "Users Lists";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 150);
            dataGridView1.TabIndex = 102;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(usernameTxt2);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox usernameTxt2;
        private Label label8;
        public DataGridView dataGridView1;
    }
}