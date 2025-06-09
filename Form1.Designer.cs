namespace aiearn
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Label lblStartScore;
        private System.Windows.Forms.Label lblAchieved;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lblStatus = new Label();
            lblClick = new Label();
            lblStartScore = new Label();
            lblAchieved = new Label();
            lblTime = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            panelHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(39, 174, 96);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 132, 73);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(22, 282);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 40);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(231, 76, 60);
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(165, 282);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(110, 40);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(18, 13);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(108, 32);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Đã dừng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClick
            // 
            lblClick.AutoSize = true;
            lblClick.Font = new Font("Segoe UI", 11F);
            lblClick.ForeColor = Color.FromArgb(41, 128, 185);
            lblClick.Location = new Point(37, 343);
            lblClick.Name = "lblClick";
            lblClick.Size = new Size(171, 25);
            lblClick.TabIndex = 3;
            lblClick.Text = "Số khiên đã click: 0";
            // 
            // lblStartScore
            // 
            lblStartScore.AutoSize = true;
            lblStartScore.Font = new Font("Segoe UI", 11F);
            lblStartScore.ForeColor = Color.FromArgb(41, 128, 185);
            lblStartScore.Location = new Point(37, 373);
            lblStartScore.Name = "lblStartScore";
            lblStartScore.Size = new Size(149, 25);
            lblStartScore.TabIndex = 4;
            lblStartScore.Text = "Điểm ban đầu: 0";
            // 
            // lblAchieved
            // 
            lblAchieved.AutoSize = true;
            lblAchieved.Font = new Font("Segoe UI", 11F);
            lblAchieved.ForeColor = Color.FromArgb(41, 128, 185);
            lblAchieved.Location = new Point(37, 403);
            lblAchieved.Name = "lblAchieved";
            lblAchieved.Size = new Size(133, 25);
            lblAchieved.TabIndex = 5;
            lblAchieved.Text = "Điểm đã đạt: 0";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11F);
            lblTime.ForeColor = Color.FromArgb(41, 128, 185);
            lblTime.Location = new Point(37, 471);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(238, 25);
            lblTime.TabIndex = 6;
            lblTime.Text = "Thời gian đã chạy: 00:00:00";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblStatus);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(321, 56);
            panelHeader.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(37, 437);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 8;
            label1.Text = "Điểm sau khi chạy: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(10, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 174);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 82);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 3;
            label5.Text = "max :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 32);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 3;
            label3.Text = "Max :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 30);
            textBox4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 30);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 84);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 1;
            label4.Text = "min :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 1;
            label2.Text = "Min :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(61, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 30);
            textBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(61, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 30);
            textBox5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 134);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 1;
            label6.Text = "min :";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(321, 533);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panelHeader);
            Controls.Add(lblTime);
            Controls.Add(lblAchieved);
            Controls.Add(lblStartScore);
            Controls.Add(lblClick);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "AI Earn";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
    }
}
