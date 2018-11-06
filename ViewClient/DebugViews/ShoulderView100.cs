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
    public partial class ShoulderView100 : Form
    {
        Action action;
        MonitorView monitorView;
        public ShoulderView100(MonitorView monitorView, Action action)
        {
            this.monitorView = monitorView;
            this.action = action;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitorView != null)
            {
                if (monitorView.IsConnected)
                {
                    bgsjLabel.Text = monitorView.Get("Exposure");
                    zyLabel.Text = monitorView.Get("Gain");
                    zbxLabel.Text = monitorView.Get("FindLineX_100");
                    zbyLabel.Text = monitorView.Get("FindLineY_100");
                    zbgdLabel.Text = monitorView.Get("FindLindHigh_100");
                    zbkdLabel.Text = monitorView.Get("FindLineWide_100");
                    pgzbyzLabel.Text = monitorView.Get("FindLineTs_100");
                    pgbkdLabel.Text = monitorView.Get("FindLineEdge_100");
                    bqbyzLabel.Text = monitorView.Get("FindLineTs_100L");
                    bqbkdLabel.Text = monitorView.Get("FindLineEdge_100L");
                    bqsxyzLabel.Text = monitorView.Get("Limit");
                    bqxxyzLabel.Text = monitorView.Get("LowerLimit");
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (action != null)
            {
                action();
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zyLabel.Text = monitorView.Set("Gain", zyTextBox.Text);
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbxLabel.Text = monitorView.Set("FindLineX_100", zbxTextBox.Text);
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyLabel.Text = monitorView.Set("FindLineY_100", zbyTextBox.Text);
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbgdLabel.Text = monitorView.Set("FindLindHigh_100", zbgdTextBox.Text);
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbkdLabel.Text = monitorView.Set("FindLineWide_100", zbkdTextBox.Text);
            }
        }

        private void pgbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                pgbkdLabel.Text = monitorView.Set("FindLineEdge_100", pgbkdTextBox.Text);
            }
        }

        private void pgzbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                pgzbyzLabel.Text = monitorView.Set("FindLineTs_100", pgzbyzTextBox.Text);
            }
        }

        private void bqbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqbyzLabel.Text = monitorView.Set("FindLineTs_100L", bqbyzTextBox.Text);
            }
        }

        private void bqbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqbkdLabel.Text = monitorView.Set("FindLineEdge_100L", bqbkdTextBox.Text);
            }
        }

        private void bqsxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqsxyzLabel.Text = monitorView.Set("Limit", bqsxyzTextBox.Text);
            }
        }

        private void bqxxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqxxyzLabel.Text = monitorView.Set("LowerLimit", bqxxyzTextBox.Text);
            }
        }
    }
}
