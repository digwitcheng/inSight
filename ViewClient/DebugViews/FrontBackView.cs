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
    public partial class FrontBackView : Form
    {
        public event EventHandler BackEvent;
        MonitorView monitorView;
        public FrontBackView(MonitorView monitorView)
        {
            this.monitorView = monitorView;
            InitializeComponent();


        }

        private void FrontBackView_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (BackEvent != null)
            {
                BackEvent(sender, e);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitorView != null)
            {
                if (monitorView.IsConnected)
                {
                    bgsjLabel.Text = monitorView.Get("Exposure");
                    zyLabel.Text = monitorView.Get("Gain");
                    ewmLabel.Text = monitorView.Get("BarCode");
                    zbxLabel.Text = monitorView.Get("FindLineX");
                    zbyLabel.Text = monitorView.Get("FindLineY");
                    zbgdLabel.Text = monitorView.Get("FindLindHigh");
                    zbkdLabel.Text = monitorView.Get("FindLineWide");
                    bkdLabel.Text = monitorView.Get("FindLineEdge");
                    zbyzLabel.Text = monitorView.Get("FindLineThreshold");
                    ewmxzLabel.Text = monitorView.Get("BarCodeX");
                    ewmyzLabel.Text = monitorView.Get("BarCodeY");
                    ewmgdLabel.Text = monitorView.Get("BarCodeHigh");
                    ewmkdLabel.Text = monitorView.Get("BarCodeWide");
                }
            }
        }
    }
}
