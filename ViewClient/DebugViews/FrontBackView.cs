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
        Action action;
        MonitorView monitorView;
        public FrontBackView(MonitorView monitorView,Action action)
        {
            this.monitorView = monitorView;
            this.action = action;
            InitializeComponent();
        }

        private void FrontBackView_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (action != null)
            {
                action();
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

        private void bgsjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bgsjLabel.Text = monitorView.Set("Exposure",bgsjTextBox.Text);
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zyLabel.Text = monitorView.Set("Gain", zyTextBox.Text);
            }
        }

        private void ewmTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmLabel.Text = monitorView.Set("BarCode", ewmTextBox.Text);
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbxLabel.Text = monitorView.Set("FindLineX", zbxTextBox.Text);
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyLabel.Text = monitorView.Set("FindLineY", zbyTextBox.Text);
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbgdLabel.Text = monitorView.Set("FindLindHigh", zbgdTextBox.Text);
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbkdLabel.Text = monitorView.Set("FindLineWide", zbkdTextBox.Text);
            }
        }

        private void bkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bkdLabel.Text = monitorView.Set("FindLineEdge", bkdTextBox.Text);
            }
        }

        private void zbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyzLabel.Text = monitorView.Set("FindLineThreshold", zbyzTextBox.Text);
            }
        }

        private void ewmxzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmxzLabel.Text = monitorView.Set("BarCodeX", ewmxzTextBox.Text);
            }
        }

        private void ewmyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmyzLabel.Text = monitorView.Set("BarCodeY", ewmyzTextBox.Text);
            }
        }

        private void ewmgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmgdLabel.Text = monitorView.Set("BarCodeHigh", ewmgdTextBox.Text);
            }
        }

        private void ewmkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmkdLabel.Text = monitorView.Set("BarCodeWide", ewmkdTextBox.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
