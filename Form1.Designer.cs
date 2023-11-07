namespace WaWSpoofer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            gameStatusLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            enableOnlineToggle = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            dvarToggle = new CheckBox();
            dvarTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // gameStatusLabel
            // 
            gameStatusLabel.AutoSize = true;
            gameStatusLabel.Location = new Point(87, 161);
            gameStatusLabel.Name = "gameStatusLabel";
            gameStatusLabel.Size = new Size(61, 15);
            gameStatusLabel.TabIndex = 0;
            gameStatusLabel.Text = "NotFound";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // enableOnlineToggle
            // 
            enableOnlineToggle.AutoSize = true;
            enableOnlineToggle.Location = new Point(239, 9);
            enableOnlineToggle.Name = "enableOnlineToggle";
            enableOnlineToggle.Size = new Size(107, 19);
            enableOnlineToggle.TabIndex = 1;
            enableOnlineToggle.Text = "Cracked Online";
            enableOnlineToggle.UseVisualStyleBackColor = true;
            enableOnlineToggle.CheckedChanged += enableOnlineToggle_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(198, 37);
            button1.Name = "button1";
            button1.Size = new Size(67, 23);
            button1.TabIndex = 2;
            button1.Text = "New Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Current Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "           ";
            // 
            // button2
            // 
            button2.Location = new Point(271, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 63);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "           ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Current Name:";
            // 
            // button3
            // 
            button3.Location = new Point(271, 83);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 83);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "Name";
            // 
            // button4
            // 
            button4.Location = new Point(183, 83);
            button4.Name = "button4";
            button4.Size = new Size(82, 23);
            button4.TabIndex = 11;
            button4.Text = "New Name";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 161);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 12;
            label5.Text = "GameStatus:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 146);
            label6.Name = "label6";
            label6.Size = new Size(115, 30);
            label6.TabIndex = 13;
            label6.Text = "By Seppuku404,\r\nThanks to @GRIIMtB";
            // 
            // dvarToggle
            // 
            dvarToggle.AutoSize = true;
            dvarToggle.Location = new Point(239, 112);
            dvarToggle.Name = "dvarToggle";
            dvarToggle.Size = new Size(92, 19);
            dvarToggle.TabIndex = 14;
            dvarToggle.Text = "UnlockDvars";
            dvarToggle.UseVisualStyleBackColor = true;
            dvarToggle.CheckedChanged += dvarToggle_CheckedChanged;
            // 
            // dvarTimer
            // 
            dvarTimer.Tick += dvarTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 185);
            Controls.Add(dvarToggle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(enableOnlineToggle);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(gameStatusLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "W@W Spoofer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox enableOnlineToggle;
        private Button button1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Label label5;
        private Label label6;
        private CheckBox dvarToggle;
        private System.Windows.Forms.Timer dvarTimer;
    }
}