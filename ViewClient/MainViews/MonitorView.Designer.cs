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
            this.CameraNameLabel = new System.Windows.Forms.Label();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.clearCountBtn1 = new System.Windows.Forms.Button();
            this.unqualified = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qualified = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重新连接界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新连接通信ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txtPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 608);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CameraNameLabel);
            this.panel2.Controls.Add(this.cvsInSightDisplay1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 436);
            this.panel2.TabIndex = 0;
            // 
            // CameraNameLabel
            // 
            this.CameraNameLabel.AutoSize = true;
            this.CameraNameLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.CameraNameLabel.Location = new System.Drawing.Point(182, 7);
            this.CameraNameLabel.Name = "CameraNameLabel";
            this.CameraNameLabel.Size = new System.Drawing.Size(96, 27);
            this.CameraNameLabel.TabIndex = 1;
            this.CameraNameLabel.Text = "label2";
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(9, 36);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(479, 362);
            this.cvsInSightDisplay1.TabIndex = 0;
            // 
            // txtPanel
            // 
            this.txtPanel.Controls.Add(this.clearCountBtn1);
            this.txtPanel.Controls.Add(this.unqualified);
            this.txtPanel.Controls.Add(this.label6);
            this.txtPanel.Controls.Add(this.qualified);
            this.txtPanel.Controls.Add(this.label4);
            this.txtPanel.Controls.Add(this.sum);
            this.txtPanel.Controls.Add(this.label1);
            this.txtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPanel.Location = new System.Drawing.Point(3, 445);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(508, 160);
            this.txtPanel.TabIndex = 2;
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
            // unqualified
            // 
            this.unqualified.AutoSize = true;
            this.unqualified.Location = new System.Drawing.Point(204, 78);
            this.unqualified.Name = "unqualified";
            this.unqualified.Size = new System.Drawing.Size(41, 12);
            this.unqualified.TabIndex = 5;
            this.unqualified.Text = "label5";
            this.unqualified.TextChanged += new System.EventHandler(this.unqualified_TextChanged);
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
            // qualified
            // 
            this.qualified.AutoSize = true;
            this.qualified.Location = new System.Drawing.Point(204, 48);
            this.qualified.Name = "qualified";
            this.qualified.Size = new System.Drawing.Size(41, 12);
            this.qualified.TabIndex = 3;
            this.qualified.Text = "label3";
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
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(204, 13);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(41, 12);
            this.sum.TabIndex = 1;
            this.sum.Text = "label2";
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
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新连接界面ToolStripMenuItem,
            this.重新连接通信ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 重新连接界面ToolStripMenuItem
            // 
            this.重新连接界面ToolStripMenuItem.Name = "重新连接界面ToolStripMenuItem";
            this.重新连接界面ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重新连接界面ToolStripMenuItem.Text = "重新连接界面";
            this.重新连接界面ToolStripMenuItem.Click += new System.EventHandler(this.重新连接界面ToolStripMenuItem_Click);
            // 
            // 重新连接通信ToolStripMenuItem
            // 
            this.重新连接通信ToolStripMenuItem.Name = "重新连接通信ToolStripMenuItem";
            this.重新连接通信ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重新连接通信ToolStripMenuItem.Text = "重新连接通信";
            this.重新连接通信ToolStripMenuItem.Click += new System.EventHandler(this.重新连接通信ToolStripMenuItem_Click);
            // 
            // MonitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 608);
            this.ContextMenuStrip = this.contextMenuStrip1;
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
            this.panel2.PerformLayout();
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.Button clearCountBtn1;
        private System.Windows.Forms.Label unqualified;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label qualified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label1;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CameraNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重新连接界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新连接通信ToolStripMenuItem;
    }
}