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
            this.LiveModeCheckBox = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.LiveModeCheckBox);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 605);
            this.panel1.TabIndex = 1;
            // 
            // LiveModeCheckBox
            // 
            this.LiveModeCheckBox.AutoSize = true;
            this.LiveModeCheckBox.BackColor = System.Drawing.Color.Gainsboro;
            this.LiveModeCheckBox.Font = new System.Drawing.Font("宋体", 13F);
            this.LiveModeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LiveModeCheckBox.Location = new System.Drawing.Point(147, 287);
            this.LiveModeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.LiveModeCheckBox.Name = "LiveModeCheckBox";
            this.LiveModeCheckBox.Size = new System.Drawing.Size(99, 22);
            this.LiveModeCheckBox.TabIndex = 45;
            this.LiveModeCheckBox.Text = "实况视频";
            this.LiveModeCheckBox.UseVisualStyleBackColor = false;
            this.LiveModeCheckBox.CheckStateChanged += new System.EventHandler(this.LiveModeCheckBox_CheckStateChanged);
            // 
            // BatchOnline
            // 
            this.BatchOnline.AutoSize = true;
            this.BatchOnline.BackColor = System.Drawing.Color.Gainsboro;
            this.BatchOnline.Font = new System.Drawing.Font("宋体", 13F);
            this.BatchOnline.ForeColor = System.Drawing.Color.Black;
            this.BatchOnline.Location = new System.Drawing.Point(53, 287);
            this.BatchOnline.Margin = new System.Windows.Forms.Padding(2);
            this.BatchOnline.Name = "BatchOnline";
            this.BatchOnline.Size = new System.Drawing.Size(81, 22);
            this.BatchOnline.TabIndex = 44;
            this.BatchOnline.Text = "Online";
            this.BatchOnline.UseVisualStyleBackColor = false;
            this.BatchOnline.CheckStateChanged += new System.EventHandler(this.BatchOnline_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "保存Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(48, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 98);
            this.panel2.TabIndex = 41;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "显示表格";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "显示图像";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(53, 512);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 43);
            this.backBtn.TabIndex = 39;
            this.backBtn.Text = "保存并返回";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // zyTextBox
            // 
            this.zyTextBox.Location = new System.Drawing.Point(177, 92);
            this.zyTextBox.Name = "zyTextBox";
            this.zyTextBox.Size = new System.Drawing.Size(84, 21);
            this.zyTextBox.TabIndex = 5;
            this.zyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zyTextBox_KeyDown);
            // 
            // zyLabel
            // 
            this.zyLabel.AutoSize = true;
            this.zyLabel.Location = new System.Drawing.Point(111, 95);
            this.zyLabel.Name = "zyLabel";
            this.zyLabel.Size = new System.Drawing.Size(41, 12);
            this.zyLabel.TabIndex = 4;
            this.zyLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "增益值:";
            // 
            // bgsjTextBox
            // 
            this.bgsjTextBox.Location = new System.Drawing.Point(177, 60);
            this.bgsjTextBox.Name = "bgsjTextBox";
            this.bgsjTextBox.Size = new System.Drawing.Size(84, 21);
            this.bgsjTextBox.TabIndex = 2;
            this.bgsjTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bgsjTextBox_KeyDown);
            // 
            // bgsjLabel
            // 
            this.bgsjLabel.AutoSize = true;
            this.bgsjLabel.Location = new System.Drawing.Point(111, 63);
            this.bgsjLabel.Name = "bgsjLabel";
            this.bgsjLabel.Size = new System.Drawing.Size(41, 12);
            this.bgsjLabel.TabIndex = 1;
            this.bgsjLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 605);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.CheckBox LiveModeCheckBox;
    }
}