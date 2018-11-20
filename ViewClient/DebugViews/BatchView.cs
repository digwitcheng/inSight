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
    public partial class BatchView : Form
    {
        Action action;
        MonitorView monitorView;
        bool isChanged = false;
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
            if (isChanged)
            {
                monitorView.SaveData();
                isChanged = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitorView != null)
            {
                if (monitorView.IsConnected)
                {
                    bgsjLabel.Text = monitorView.Get(CommandType.Exposure);
                    zyLabel.Text = monitorView.Get(CommandType.Gain);
                }
            }
        }
        string Changed(CommandType type,string value)
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

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                isChanged = true;
                zyLabel.Text = Changed(CommandType.Gain, zyTextBox.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            monitorView.SetGridView();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            monitorView.SetImageView();
        }
    }
}
