namespace StudentInformationSystem
{
    partial class Dashboard1
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
            label10 = new Label();
            label9 = new Label();
            dateTimeTextBox2 = new TextBox();
            refreshbtn = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label15 = new Label();
            SuspendLayout();
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
            label10.TabIndex = 32;
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
            label9.TabIndex = 24;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimeTextBox2
            // 
            dateTimeTextBox2.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox2.BorderStyle = BorderStyle.None;
            dateTimeTextBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox2.Location = new Point(26, 106);
            dateTimeTextBox2.Name = "dateTimeTextBox2";
            dateTimeTextBox2.ReadOnly = true;
            dateTimeTextBox2.ScrollBars = ScrollBars.Vertical;
            dateTimeTextBox2.Size = new Size(324, 36);
            dateTimeTextBox2.TabIndex = 44;
            dateTimeTextBox2.TextChanged += dateTimeTextBox_TextChanged;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(209, 322);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 36);
            refreshbtn.TabIndex = 43;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(486, 294);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 42;
            label8.Text = "Total 4th Year";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSkyBlue;
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(486, 322);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(106, 43);
            textBox6.TabIndex = 41;
            textBox6.Text = "1000";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(361, 294);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 40;
            label7.Text = "Total 3rd Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(486, 205);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 39;
            label6.Text = "Total 2nd Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(358, 205);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 38;
            label5.Text = "Total 1st Year";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Turquoise;
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(365, 322);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(106, 43);
            textBox5.TabIndex = 37;
            textBox5.Text = "1000";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Chartreuse;
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(486, 236);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(106, 43);
            textBox4.TabIndex = 36;
            textBox4.Text = "1000";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 208);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 35;
            label3.Text = "Total Students";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gold;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(365, 236);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(106, 43);
            textBox3.TabIndex = 34;
            textBox3.Text = "1000";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tomato;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(194, 236);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(106, 43);
            textBox1.TabIndex = 33;
            textBox1.Text = "1000";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(358, 158);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 84;
            label15.Text = "Dashboard";
            // 
            // Dashboard1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(dateTimeTextBox2);
            Controls.Add(refreshbtn);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard1";
            Text = "Dashboard1";
            Load += Dashboard1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label9;
        public TextBox dateTimeTextBox2;
        private Button refreshbtn;
        private Label label8;
        public TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label5;
        public TextBox textBox5;
        public TextBox textBox4;
        private Label label3;
        public TextBox textBox3;
        public TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label15;
    }
}