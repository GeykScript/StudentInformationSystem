namespace StudentInformationSystem
{
    partial class Students
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
            addstudent = new Button();
            editstudent = new Button();
            btnPanel = new Panel();
            dateTimeTextBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            refreshbtn = new Button();
            dataGridView1 = new DataGridView();
            btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSkyBlue;
            label10.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(221, 64);
            label10.Name = "label10";
            label10.Size = new Size(530, 43);
            label10.TabIndex = 51;
            label10.Text = "Student Information Management System";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSkyBlue;
            label9.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(34, 44);
            label9.Name = "label9";
            label9.Size = new Size(196, 87);
            label9.TabIndex = 43;
            label9.Text = "iSTUD";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // addstudent
            // 
            addstudent.BackColor = Color.LightSkyBlue;
            addstudent.Location = new Point(3, 4);
            addstudent.Margin = new Padding(3, 4, 3, 4);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(133, 55);
            addstudent.TabIndex = 53;
            addstudent.Text = "Add Student";
            addstudent.UseVisualStyleBackColor = false;
            addstudent.Click += button1_Click;
            // 
            // editstudent
            // 
            editstudent.BackColor = Color.LightYellow;
            editstudent.Location = new Point(143, 4);
            editstudent.Margin = new Padding(3, 4, 3, 4);
            editstudent.Name = "editstudent";
            editstudent.Size = new Size(98, 55);
            editstudent.TabIndex = 55;
            editstudent.Text = "Edit ";
            editstudent.UseVisualStyleBackColor = false;
            editstudent.Click += editstudent_Click;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(addstudent);
            btnPanel.Controls.Add(editstudent);
            btnPanel.Location = new Point(570, 277);
            btnPanel.Margin = new Padding(3, 4, 3, 4);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(245, 67);
            btnPanel.TabIndex = 56;
            btnPanel.Paint += btnPanel_Paint;
            // 
            // dateTimeTextBox3
            // 
            dateTimeTextBox3.BackColor = SystemColors.ButtonHighlight;
            dateTimeTextBox3.BorderStyle = BorderStyle.None;
            dateTimeTextBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox3.Location = new Point(87, 189);
            dateTimeTextBox3.Margin = new Padding(3, 4, 3, 4);
            dateTimeTextBox3.Name = "dateTimeTextBox3";
            dateTimeTextBox3.ReadOnly = true;
            dateTimeTextBox3.Size = new Size(370, 45);
            dateTimeTextBox3.TabIndex = 57;
            dateTimeTextBox3.TextChanged += dateTimeTextBox_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(87, 305);
            refreshbtn.Margin = new Padding(3, 4, 3, 4);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(86, 31);
            refreshbtn.TabIndex = 58;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(61, 352);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 200);
            dataGridView1.TabIndex = 59;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(refreshbtn);
            Controls.Add(dateTimeTextBox3);
            Controls.Add(btnPanel);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Button addstudent;
        private Button editstudent;
        private Panel btnPanel;
        public TextBox dateTimeTextBox;
        private System.Windows.Forms.Timer timer1;
        public TextBox dateTimeTextBox3;
        private Button refreshbtn;
        public DataGridView dataGridView1;
    }
}