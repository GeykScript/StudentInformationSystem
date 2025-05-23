﻿namespace StudentInformationSystem
{
    partial class Payment
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
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimeTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            label15 = new Label();
            refreshbtn = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            excelbtn = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            searchbar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(206, 53);
            label10.Name = "label10";
            label10.Size = new Size(426, 35);
            label10.TabIndex = 53;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(43, 38);
            label9.Name = "label9";
            label9.Size = new Size(157, 69);
            label9.TabIndex = 52;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox.BorderStyle = BorderStyle.None;
            dateTimeTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox.Location = new Point(235, 133);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(324, 36);
            dateTimeTextBox.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(182, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(513, 141);
            dataGridView1.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(317, 205);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(212, 25);
            label15.TabIndex = 82;
            label15.Text = "Student Total Payments";
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(184, 259);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(63, 23);
            refreshbtn.TabIndex = 83;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Window;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 45;
            iconPictureBox1.Location = new Point(182, 133);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(46, 45);
            iconPictureBox1.TabIndex = 86;
            iconPictureBox1.TabStop = false;
            // 
            // excelbtn
            // 
            excelbtn.BackColor = Color.Lime;
            excelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excelbtn.ForeColor = SystemColors.ActiveCaptionText;
            excelbtn.Location = new Point(578, 249);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(117, 32);
            excelbtn.TabIndex = 117;
            excelbtn.Text = "Export to Excel";
            excelbtn.UseVisualStyleBackColor = false;
            excelbtn.Click += excelbtn_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Window;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 20;
            iconPictureBox2.Location = new Point(421, 259);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(21, 20);
            iconPictureBox2.TabIndex = 122;
            iconPictureBox2.TabStop = false;
            // 
            // searchbar
            // 
            searchbar.Location = new Point(253, 259);
            searchbar.Margin = new Padding(3, 2, 3, 2);
            searchbar.Name = "searchbar";
            searchbar.Size = new Size(171, 23);
            searchbar.TabIndex = 121;
            searchbar.TextChanged += searchbar_TextChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(iconPictureBox2);
            Controls.Add(searchbar);
            Controls.Add(excelbtn);
            Controls.Add(iconPictureBox1);
            Controls.Add(refreshbtn);
            Controls.Add(label15);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimeTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        public TextBox dateTimeTextBox;
        public DataGridView dataGridView1;
        private Label label15;
        private Button refreshbtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button excelbtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox searchbar;
    }
}