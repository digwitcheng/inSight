using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class MainView : Form
    {
        private MonitorViewTab batchShoulderView;
        private MonitorViewTab frontBackView;
        private MonitorViewTab isFrontIsBackView;

        public MainView(MonitorViewTab batchShoulderView, MonitorViewTab frontBackView, MonitorViewTab isFrontIsBackView)
        {
            this.batchShoulderView = batchShoulderView;
            this.frontBackView = frontBackView;
            this.isFrontIsBackView = isFrontIsBackView;
            this.Text = "相机调试界面";

            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            try
            {
                AddMonitorView(batchShoulderView, tabPage1);
                AddMonitorView(frontBackView, tabPage2);
                AddMonitorView(isFrontIsBackView, tabPage3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddMonitorView(MonitorViewTab monitorViewTab, TabPage page)
        {
            monitorViewTab.TopLevel = false;
            monitorViewTab.Dock = DockStyle.Fill;
            monitorViewTab.FormBorderStyle = FormBorderStyle.None;
            page.Controls.Add(monitorViewTab);
            page.Text = monitorViewTab.Text;
            monitorViewTab.Show();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
