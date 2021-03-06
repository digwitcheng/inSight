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
        public MonitorView monitorView;
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
                string res = Changed(CommandType.Exposure, bgsjTextBox.Text);
                if (res.Equals("1"))
                {
                    bgsjLabel.Text = monitorView.Get(CommandType.Exposure);
                }
            }
        }

        private void zyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                isChanged = true;
                string res = Changed(CommandType.Gain, zyTextBox.Text);
                if (res.Equals("1"))
                {
                    zyLabel.Text = monitorView.Get(CommandType.Gain);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BatchOnline.Checked)
            {
                MessageBox.Show("请先脱机!");
                return;
            }
            monitorView.SaveJobAs();
        }

        private void BatchView_Load(object sender, EventArgs e)
        {
            monitorView.BindOnline(this.BatchOnline);
            monitorView.BindLiveMode(this.LiveModeCheckBox);
            if (monitorView == null) return;
            if (monitorView.IsDisplayConnected)
            {
                bgsjLabel.Text = monitorView.Get(CommandType.Exposure);
                zyLabel.Text = monitorView.Get(CommandType.Gain);
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
