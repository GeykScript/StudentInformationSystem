namespace StudentInformationSystem
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(235, 71);
            label10.Name = "label10";
            label10.Size = new Size(530, 43);
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
            label9.Location = new Point(49, 51);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
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
            dateTimeTextBox.Location = new Point(269, 177);
            dateTimeTextBox.Margin = new Padding(3, 4, 3, 4);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(370, 45);
            dateTimeTextBox.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 333);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(586, 188);
            dataGridView1.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(329, 271);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(271, 32);
            label15.TabIndex = 82;
            label15.Text = "Student Total Payments";
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(208, 272);
            refreshbtn.Margin = new Padding(3, 4, 3, 4);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(114, 37);
            refreshbtn.TabIndex = 83;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 600);
            Controls.Add(refreshbtn);
            Controls.Add(label15);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimeTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}