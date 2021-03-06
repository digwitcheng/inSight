﻿using System;
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
        void Changed(CommandType type, string value, Label showLabel)
        {
            isChanged = true;
            if (monitorView.Data == null)
            {
                MessageBox.Show("相机未连接！或当前连接的相机ip不在当前选择的物料编号之中");
                showLabel.Text = "未连接";
            }
            monitorView.Data.SetValue(type, value);
            string res = "";
            res = monitorView.Set(type, value);            
            if (res.Equals("1"))
            {
                showLabel.Text = monitorView.Get(type);
            }
        }
        private void bgsjTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.Exposure, bgsjTextBox.Text,bgsjLabel);                
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
                Changed(CommandType.Gain, zyTextBox.Text,zyLabel);                
            }
        }

        private void zbxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineX_100, zbx100TextBox.Text,zbxLabel);
                
            }
        }

        private void zbyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineY_100, zby100TextBox.Text,zbyLabel);
                
            }
        }

        private void zbgdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
               Changed(CommandType.FindLindHigh_100, zbgd100TextBox.Text,zbgdLabel);
                
            }
        }

        private void zbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineWide_100, zbkd100TextBox.Text,zbkdLabel);
                
            }
        }

        private void pgbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineEdge_100, pgbkd100TextBox.Text,pgbkdLabel);
                
            }
        }

        private void pgzbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineTs_100, pgzbyz100TextBox.Text,pgzbyzLabel);
                
            }
        }

        private void bqbyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineTs_100L, bqbyz100TextBox.Text,bqbyzLabel);
                
            }
        }

        private void bqbkdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.FindLineEdge_100L, bqbkd100TextBox.Text,bqbkdLabel);
                
            }
        }

        private void bqsxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.Limit, bqsxyzTextBox.Text,bqsxyzLabel);
                
            }
        }

        private void bqxxyzTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Changed(CommandType.LowerLimit, bqxxyzTextBox.Text,bqxxyzLabel);
                
            }
        }

        private void ShoulderView100_Load(object sender, EventArgs e)
        {
            monitorView.BindOnline(this.BatchOnline);
            monitorView.BindLiveMode(this.LiveModeCheckBox);
            Fresh();
        }

        private void Fresh()
        {
            if (monitorView == null) return;
            if (monitorView.IsDisplayConnected)
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
