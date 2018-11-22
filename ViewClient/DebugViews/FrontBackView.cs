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
        bool isChanged = false;
        public FrontBackView(MonitorView monitorView, Action action)
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
            if (isChanged)
            {
                monitorView.SaveData();
                isChanged = false;
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
                bgsjLabel.Text  = Changed(CommandType.Exposure,bgsjTextBox.Text);
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zyLabel.Text  = Changed(CommandType.Gain, zyTextBox.Text);
            }
        }

        private void ewmTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmLabel.Text  = Changed(CommandType.BarCode, ewmTextBox.Text);
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbxLabel.Text  = Changed(CommandType.FindLineX, zbxTextBox.Text);
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyLabel.Text  = Changed(CommandType.FindLineY, zbyTextBox.Text);
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbgdLabel.Text  = Changed(CommandType.FindLindHigh, zbgdTextBox.Text);
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbkdLabel.Text  = Changed(CommandType.FindLineWide, zbkdTextBox.Text);
            }
        }

        private void bkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                bkdLabel.Text  = Changed(CommandType.FindLineEdge, bkdTextBox.Text);
            }
        }

        private void zbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                zbyzLabel.Text  = Changed(CommandType.FindLineThreshold, zbyzTextBox.Text);
            }
        }

        private void ewmxzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmxzLabel.Text  = Changed(CommandType.BarCodeX, ewmxzTextBox.Text);
            }
        }

        private void ewmyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmyzLabel.Text  = Changed(CommandType.BarCodeY, ewmyzTextBox.Text);
            }
        }

        private void ewmgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmgdLabel.Text  = Changed(CommandType.BarCodeHigh, ewmgdTextBox.Text);
            }
        }

        private void ewmkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ewmkdLabel.Text  = Changed(CommandType.BarCodeWide, ewmkdTextBox.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitorView == null) return;
            if (monitorView.IsConnected)
            {
                bgsjLabel.Text = monitorView.Get(CommandType.Exposure);
                zyLabel.Text = monitorView.Get(CommandType.Gain);
                ewmLabel.Text = monitorView.Get(CommandType.BarCode);
                zbxLabel.Text = monitorView.Get(CommandType.FindLineX);
                zbyLabel.Text = monitorView.Get(CommandType.FindLineY);
                zbgdLabel.Text = monitorView.Get(CommandType.FindLindHigh);
                zbkdLabel.Text = monitorView.Get(CommandType.FindLineWide);
                bkdLabel.Text = monitorView.Get(CommandType.FindLineEdge);
                zbyzLabel.Text = monitorView.Get(CommandType.FindLineThreshold);
                ewmxzLabel.Text = monitorView.Get(CommandType.BarCodeX);
                ewmyzLabel.Text = monitorView.Get(CommandType.BarCodeY);
                ewmgdLabel.Text = monitorView.Get(CommandType.BarCodeHigh);
                ewmkdLabel.Text = monitorView.Get(CommandType.BarCodeWide);
            }
        }
    }
}
