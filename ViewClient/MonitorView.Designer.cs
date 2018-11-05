namespace ViewClient
{
    partial class MonitorView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.Label();
            this.clearCountBtn1 = new System.Windows.Forms.Button();
            this.unqualified1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qualified1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 592);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.80701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.19298F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cvsInSightDisplay1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 425);
            this.panel2.TabIndex = 0;
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(46, 41);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(368, 288);
            this.cvsInSightDisplay1.TabIndex = 0;
            // 
            // txtPanel
            // 
            this.txtPanel.Controls.Add(this.textBox2);
            this.txtPanel.Controls.Add(this.button2);
            this.txtPanel.Controls.Add(this.button1);
            this.txtPanel.Controls.Add(this.textBox1);
            this.txtPanel.Controls.Add(this.txtResponse);
            this.txtPanel.Controls.Add(this.clearCountBtn1);
            this.txtPanel.Controls.Add(this.unqualified1);
            this.txtPanel.Controls.Add(this.label6);
            this.txtPanel.Controls.Add(this.qualified1);
            this.txtPanel.Controls.Add(this.label4);
            this.txtPanel.Controls.Add(this.sum1);
            this.txtPanel.Controls.Add(this.label1);
            this.txtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPanel.Location = new System.Drawing.Point(3, 434);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(455, 155);
            this.txtPanel.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(369, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 21);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 8;
            // 
            // txtResponse
            // 
            this.txtResponse.AutoSize = true;
            this.txtResponse.Location = new System.Drawing.Point(9, 13);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(41, 12);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "label2";
            // 
            // clearCountBtn1
            // 
            this.clearCountBtn1.Location = new System.Drawing.Point(135, 117);
            this.clearCountBtn1.Name = "clearCountBtn1";
            this.clearCountBtn1.Size = new System.Drawing.Size(151, 29);
            this.clearCountBtn1.TabIndex = 6;
            this.clearCountBtn1.Text = "计数清零";
            this.clearCountBtn1.UseVisualStyleBackColor = true;
            this.clearCountBtn1.Click += new System.EventHandler(this.clearCountBtn1_Click);
            // 
            // unqualified1
            // 
            this.unqualified1.AutoSize = true;
            this.unqualified1.Location = new System.Drawing.Point(204, 78);
            this.unqualified1.Name = "unqualified1";
            this.unqualified1.Size = new System.Drawing.Size(41, 12);
            this.unqualified1.TabIndex = 5;
            this.unqualified1.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "不合格数：";
            // 
            // qualified1
            // 
            this.qualified1.AutoSize = true;
            this.qualified1.Location = new System.Drawing.Point(204, 48);
            this.qualified1.Name = "qualified1";
            this.qualified1.Size = new System.Drawing.Size(41, 12);
            this.qualified1.TabIndex = 3;
            this.qualified1.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "合格数：";
            // 
            // sum1
            // 
            this.sum1.AutoSize = true;
            this.sum1.Location = new System.Drawing.Point(204, 13);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(41, 12);
            this.sum1.TabIndex = 1;
            this.sum1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "总数：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MonitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 592);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitorView";
            this.Text = "CameraView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonitorView_FormClosing);
            this.Load += new System.EventHandler(this.MonitorView_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.Button clearCountBtn1;
        private System.Windows.Forms.Label unqualified1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label qualified1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sum1;
        private System.Windows.Forms.Label label1;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private System.Windows.Forms.Label txtResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}