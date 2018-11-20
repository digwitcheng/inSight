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
        bool isChanged = false;
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
                    bgsjLabel.Text = monitorView.Get(CommandType.Exposure);
                    zyLabel.Text = monitorView.Get(CommandType.Gain);
                    zbxLabel.Text = monitorView.Get(CommandType.FindLineX_100);
                    zbyLabel.Text = monitorView.Get(CommandType.FindLineY_100);
                    zbgdLabel.Text = monitorView.Get(CommandType.FindLindHigh_100);
                    zbkdLabel.Text = monitorView.Get(CommandType.FindLineWide_100);
                    pgzbyzLabel.Text = monitorView.Get(CommandType.FindLineTs_100);
                    pgbkdLabel.Text = monitorView.Get(CommandType.FindLineEdge_100);
                    bqbyzLabel.Text = monitorView.Get(CommandType.FindLineTs_100L);
                    bqbkdLabel.Text = monitorView.Get(CommandType.FindLineEdge_100L);
                    bqsxyzLabel.Text = monitorView.Get(CommandType.Limit);
                    bqxxyzLabel.Text = monitorView.Get(CommandType.LowerLimit);
                }
            }
        }
        string Changed(CommandType type, string value)
        {
            isChanged = true;
            if (monitorView.Data == null)
            {
                MessageBox.Show("相机未连接！或当前连接的相机ip不在当前选择的物料编号之中");
                return "未连接";
            }
            monitorView.Data.SetValue(type, value);
            return monitorView.Set(type, value);
        }
        private void bgsjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bgsjLabel.Text = Changed(CommandType.Exposure, bgsjTextBox.Text);
                
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (action != null)
            {
                action();
            }
            if (isChanged)
            {
                monitorView.SaveData();
                isChanged = false;
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zyLabel.Text = Changed(CommandType.Gain, zyTextBox.Text);
                
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbxLabel.Text = Changed(CommandType.FindLineX_100, zbxTextBox.Text);
                
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyLabel.Text = Changed(CommandType.FindLineY_100, zbyTextBox.Text);
                
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbgdLabel.Text = Changed(CommandType.FindLindHigh_100, zbgdTextBox.Text);
                
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbkdLabel.Text = Changed(CommandType.FindLineWide_100, zbkdTextBox.Text);
                
            }
        }

        private void pgbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                pgbkdLabel.Text = Changed(CommandType.FindLineEdge_100, pgbkdTextBox.Text);
                
            }
        }

        private void pgzbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                pgzbyzLabel.Text = Changed(CommandType.FindLineTs_100, pgzbyzTextBox.Text);
                
            }
        }

        private void bqbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqbyzLabel.Text = Changed(CommandType.FindLineTs_100L, bqbyzTextBox.Text);
                
            }
        }

        private void bqbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqbkdLabel.Text = Changed(CommandType.FindLineEdge_100L, bqbkdTextBox.Text);
                
            }
        }

        private void bqsxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqsxyzLabel.Text = Changed(CommandType.Limit, bqsxyzTextBox.Text);
                
            }
        }

        private void bqxxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bqxxyzLabel.Text = Changed(CommandType.LowerLimit, bqxxyzTextBox.Text);
                
            }
        }
    }
}
