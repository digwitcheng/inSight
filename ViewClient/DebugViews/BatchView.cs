using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient.DebugViews
{
    public partial class BatchView : Form
    {
        Action action;
        MonitorView monitorView;
        public BatchView(MonitorView monitorView, Action action)
        {
            this.monitorView = monitorView;
            this.action = action;
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (action != null)
            {
                action();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitorView != null)
            {
                if (monitorView.IsConnected)
                {
                    bgsjLabel.Text = monitorView.Get("Exposure");
                    zyLabel.Text = monitorView.Get("Gain");
                }
            }
        }

        private void bgsjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bgsjLabel.Text = monitorView.Set("Exposure", bgsjTextBox.Text);
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zyLabel.Text = monitorView.Set("Gain", zyTextBox.Text);
            }
        }
    }
}
