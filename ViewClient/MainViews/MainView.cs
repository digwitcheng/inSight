using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewClient.Properties;

namespace ViewClient
{
    public partial class MainView : Form
    {
        private MonitorViewTab batchShoulderViewTab;
        private MonitorViewTab frontBackViewTab;
        private MonitorViewTab isFrontIsBackViewTab;

        public MainView(MonitorViewTab batchShoulderView, MonitorViewTab frontBackView, MonitorViewTab isFrontIsBackView)
        {
            InitializeComponent();
            this.batchShoulderViewTab = batchShoulderView;
            this.frontBackViewTab = frontBackView;
            this.isFrontIsBackViewTab = isFrontIsBackView;
            this.Text = AppSetting.APP_NAME;
            this.Icon = Resources.Logo;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            try
            {
                AddMonitorView(batchShoulderViewTab, tabPage1);
                AddMonitorView(frontBackViewTab, tabPage2);
                AddMonitorView(isFrontIsBackViewTab, tabPage3);
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
