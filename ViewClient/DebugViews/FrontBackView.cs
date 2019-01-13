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
            monitorView.BindOnline(this.BatchOnline);
            monitorView.BindLiveMode(this.LiveModeCheckBox);
            Fresh();
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
       
        void Changed(CommandType type, string value,Label showLabel)
        {
            isChanged = true;
            if (monitorView.Data == null)
            {
                MessageBox.Show("相机未连接！或当前连接的相机ip不在当前选择的物料编号之中");
                showLabel.Text= "未连接";
            }
            monitorView.Data.SetValue(type, value);
            string res = "";
            if (type == CommandType.MatNo || type == CommandType.BarCode)
            {
                res = monitorView.SetWithString(type, value);
            }
            else
            {
                res= monitorView.Set(type, value);
            }
            if (res.Equals("1"))
            {
                showLabel.Text = monitorView.Get(type);
            }
        }
        private void bgsjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.Exposure,bgsjTextBox.Text,bgsjLabel);
            }
        }
        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
               Changed(CommandType.Gain, zyTextBox.Text,zyLabel);
            }
        }

        private void ewmTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.BarCode, ewmTextBox.Text,ewmLabel);
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineX, zbxTextBox.Text,zbxLabel);
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineY, zbyTextBox.Text,zbyLabel);
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLindHigh, zbgdTextBox.Text,zbgdLabel);
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineWide, zbkdTextBox.Text,zbkdLabel);
            }
        }

        private void bkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineEdge, bkdTextBox.Text,bkdLabel);
            }
        }

        private void zbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                 Changed(CommandType.FindLineThreshold, zbyzTextBox.Text,zbyzLabel);
            }
        }

        private void ewmxzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                 Changed(CommandType.BarCodeX, ewmxzTextBox.Text,ewmxzLabel);
            }
        }

        private void ewmyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.BarCodeY, ewmyzTextBox.Text,ewmyzLabel);
            }
        }

        private void ewmgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.BarCodeHigh, ewmgdTextBox.Text,ewmgdLabel);
            }
        }

        private void ewmkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.BarCodeWide, ewmkdTextBox.Text,ewmkdLabel);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fresh()
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

        private void BatchOnline_CheckStateChanged(object sender, EventArgs e)
        {
            if (BatchOnline.Checked)
            {
                BatchOnline.BackColor = Color.Yellow;
            }
            else
            {
                BatchOnline.BackColor = Color.Gainsboro;
            }
        }

        private void LiveModeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (LiveModeCheckBox.Checked)
            {
                LiveModeCheckBox.BackColor = Color.Yellow;
            }
            else
            {
                LiveModeCheckBox.BackColor = Color.Gainsboro;
            }
        }
    }
}
