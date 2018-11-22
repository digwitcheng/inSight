namespace ViewClient.DebugViews
{
    partial class BatchView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BatchOnline = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.zyTextBox = new System.Windows.Forms.TextBox();
            this.zyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgsjTextBox = new System.Windows.Forms.TextBox();
            this.bgsjLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.BatchOnline);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.zyTextBox);
            this.panel1.Controls.Add(this.zyLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bgsjTextBox);
            this.panel1.Controls.Add(this.bgsjLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 756);
            this.panel1.TabIndex = 1;
            // 
            // BatchOnline
            // 
            this.BatchOnline.AutoSize = true;
            this.BatchOnline.BackColor = System.Drawing.Color.Gainsboro;
            this.BatchOnline.Font = new System.Drawing.Font("宋体", 15F);
            this.BatchOnline.ForeColor = System.Drawing.Color.Black;
            this.BatchOnline.Location = new System.Drawing.Point(71, 352);
            this.BatchOnline.Name = "BatchOnline";
            this.BatchOnline.Size = new System.Drawing.Size(109, 29);
            this.BatchOnline.TabIndex = 44;
            this.BatchOnline.Text = "Online";
            this.BatchOnline.UseVisualStyleBackColor = false;
            this.BatchOnline.CheckStateChanged += new System.EventHandler(this.BatchOnline_CheckStateChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 55);
            this.button1.TabIndex = 42;
            this.button1.Text = "保存Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(64, 201);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 122);
            this.panel2.TabIndex = 41;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 28);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "显示表格";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 70);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "显示图像";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(71, 640);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(132, 54);
            this.backBtn.TabIndex = 39;
            this.backBtn.Text = "保存并返回";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // zyTextBox
            // 
            this.zyTextBox.Location = new System.Drawing.Point(236, 115);
            this.zyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.zyTextBox.Name = "zyTextBox";
            this.zyTextBox.Size = new System.Drawing.Size(111, 25);
            this.zyTextBox.TabIndex = 5;
            this.zyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zyTextBox_KeyDown);
            // 
            // zyLabel
            // 
            this.zyLabel.AutoSize = true;
            this.zyLabel.Location = new System.Drawing.Point(148, 119);
            this.zyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zyLabel.Name = "zyLabel";
            this.zyLabel.Size = new System.Drawing.Size(55, 15);
            this.zyLabel.TabIndex = 4;
            this.zyLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "增益值:";
            // 
            // bgsjTextBox
            // 
            this.bgsjTextBox.Location = new System.Drawing.Point(236, 75);
            this.bgsjTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bgsjTextBox.Name = "bgsjTextBox";
            this.bgsjTextBox.Size = new System.Drawing.Size(111, 25);
            this.bgsjTextBox.TabIndex = 2;
            this.bgsjTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bgsjTextBox_KeyDown);
            // 
            // bgsjLabel
            // 
            this.bgsjLabel.AutoSize = true;
            this.bgsjLabel.Location = new System.Drawing.Point(148, 79);
            this.bgsjLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bgsjLabel.Name = "bgsjLabel";
            this.bgsjLabel.Size = new System.Drawing.Size(55, 15);
            this.bgsjLabel.TabIndex = 1;
            this.bgsjLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "曝光时间:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // BatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 756);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BatchView";
            this.Text = "BatchView";
            this.Load += new System.EventHandler(this.BatchView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox zyTextBox;
        private System.Windows.Forms.Label zyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bgsjTextBox;
        private System.Windows.Forms.Label bgsjLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox BatchOnline;
        private System.Windows.Forms.Timer timer1;
    }
}