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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cvsInSightDisplay2 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cameraBtn1 = new System.Windows.Forms.Button();
            this.clearCountBtn1 = new System.Windows.Forms.Button();
            this.unqualified1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qualified1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cameraBtn2 = new System.Windows.Forms.Button();
            this.clearCountBtn2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.unqualified2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sum2 = new System.Windows.Forms.Label();
            this.qualified2 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 570);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.80701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.19298F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cvsInSightDisplay1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 409);
            this.panel2.TabIndex = 0;
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(24, 40);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(368, 288);
            this.cvsInSightDisplay1.TabIndex = 0;
            this.cvsInSightDisplay1.ConnectedChanged += new System.EventHandler(this.cvsInSightDisplay1_ConnectedChanged);
            this.cvsInSightDisplay1.StateChanged += new System.EventHandler(this.cvsInSightDisplay1_StateChanged);
            this.cvsInSightDisplay1.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(this.cvsInSightDisplay1_ConnectCompleted);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cvsInSightDisplay2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(443, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 409);
            this.panel3.TabIndex = 1;
            // 
            // cvsInSightDisplay2
            // 
            this.cvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay2.DialogIcon = null;
            this.cvsInSightDisplay2.Location = new System.Drawing.Point(16, 40);
            this.cvsInSightDisplay2.Name = "cvsInSightDisplay2";
            this.cvsInSightDisplay2.Size = new System.Drawing.Size(368, 288);
            this.cvsInSightDisplay2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txtResponse);
            this.panel4.Controls.Add(this.cameraBtn1);
            this.panel4.Controls.Add(this.clearCountBtn1);
            this.panel4.Controls.Add(this.unqualified1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.qualified1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.sum1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 149);
            this.panel4.TabIndex = 2;
            // 
            // cameraBtn1
            // 
            this.cameraBtn1.Location = new System.Drawing.Point(206, 103);
            this.cameraBtn1.Name = "cameraBtn1";
            this.cameraBtn1.Size = new System.Drawing.Size(151, 28);
            this.cameraBtn1.TabIndex = 7;
            this.cameraBtn1.Text = "button1";
            this.cameraBtn1.UseVisualStyleBackColor = true;
            this.cameraBtn1.Click += new System.EventHandler(this.cameraBtn1_Click_1);
            // 
            // clearCountBtn1
            // 
            this.clearCountBtn1.Location = new System.Drawing.Point(36, 102);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.cameraBtn2);
            this.panel5.Controls.Add(this.clearCountBtn2);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.unqualified2);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.sum2);
            this.panel5.Controls.Add(this.qualified2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(443, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 149);
            this.panel5.TabIndex = 3;
            // 
            // cameraBtn2
            // 
            this.cameraBtn2.Location = new System.Drawing.Point(233, 100);
            this.cameraBtn2.Name = "cameraBtn2";
            this.cameraBtn2.Size = new System.Drawing.Size(151, 28);
            this.cameraBtn2.TabIndex = 8;
            this.cameraBtn2.Text = "button2";
            this.cameraBtn2.UseVisualStyleBackColor = true;
            this.cameraBtn2.Click += new System.EventHandler(this.cameraBtn2_Click);
            // 
            // clearCountBtn2
            // 
            this.clearCountBtn2.Location = new System.Drawing.Point(60, 100);
            this.clearCountBtn2.Name = "clearCountBtn2";
            this.clearCountBtn2.Size = new System.Drawing.Size(155, 29);
            this.clearCountBtn2.TabIndex = 13;
            this.clearCountBtn2.Text = "计数清零";
            this.clearCountBtn2.UseVisualStyleBackColor = true;
            this.clearCountBtn2.Click += new System.EventHandler(this.clearCountBtn2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "合格数：";
            // 
            // unqualified2
            // 
            this.unqualified2.AutoSize = true;
            this.unqualified2.Location = new System.Drawing.Point(221, 75);
            this.unqualified2.Name = "unqualified2";
            this.unqualified2.Size = new System.Drawing.Size(41, 12);
            this.unqualified2.TabIndex = 12;
            this.unqualified2.Text = "label7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "总数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "不合格数：";
            // 
            // sum2
            // 
            this.sum2.AutoSize = true;
            this.sum2.Location = new System.Drawing.Point(221, 10);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(47, 12);
            this.sum2.TabIndex = 8;
            this.sum2.Text = "label11";
            // 
            // qualified2
            // 
            this.qualified2.AutoSize = true;
            this.qualified2.Location = new System.Drawing.Point(221, 45);
            this.qualified2.Name = "qualified2";
            this.qualified2.Size = new System.Drawing.Size(41, 12);
            this.qualified2.TabIndex = 10;
            this.qualified2.Text = "label9";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MonitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 570);
            this.Controls.Add(this.panel1);
            this.Name = "MonitorView";
            this.Text = "CameraView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonitorView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button clearCountBtn1;
        private System.Windows.Forms.Label unqualified1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label qualified1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay2;
        private System.Windows.Forms.Button clearCountBtn2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label unqualified2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sum2;
        private System.Windows.Forms.Label qualified2;
        private System.Windows.Forms.Button cameraBtn1;
        private System.Windows.Forms.Button cameraBtn2;
        private System.Windows.Forms.Label txtResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}