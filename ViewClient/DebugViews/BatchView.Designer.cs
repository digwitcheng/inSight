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
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.zyTextBox = new System.Windows.Forms.TextBox();
            this.zyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgsjTextBox = new System.Windows.Forms.TextBox();
            this.bgsjLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.saveBtn);
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
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(162, 522);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 50);
            this.saveBtn.TabIndex = 40;
            this.saveBtn.Text = "参数保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(38, 522);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 50);
            this.backBtn.TabIndex = 39;
            this.backBtn.Text = "返回";
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox zyTextBox;
        private System.Windows.Forms.Label zyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bgsjTextBox;
        private System.Windows.Forms.Label bgsjLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}