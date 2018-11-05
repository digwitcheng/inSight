using Cognex.InSight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewClient.DebugViews;

namespace ViewClient
{
    public partial class MonitorViewTab : Form
    {
        private MonitorView leftMonitorView;
        private MonitorView rightMonitorView;
        CameraType leftType;
        CameraType rightType;
        Form removeView;
        Form addView;
        bool isClickLeft = true;
        public MonitorViewTab(CameraType leftType,CameraType rightType)
        {
            InitializeComponent();
            this.leftType = leftType;
            this.rightType = rightType;
            string leftName = Tools.GetCameraName(leftType);
            string rightName = Tools.GetCameraName(rightType);
            this.Text = leftName+ "和" + rightName;
            leftBtn.Text = leftName+"调试界面";
            rightBtn.Text = rightName+"调试界面";
            leftMonitorView = new MonitorView(leftType);
            rightMonitorView = new MonitorView(rightType);
        }

        private void MonitorViewTab_Load(object sender, EventArgs e)
        {
            try
            {
                AddMonitorView(leftMonitorView,leftPanel);
                AddMonitorView(rightMonitorView,rightPanel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddMonitorView(MonitorView monitorView,Panel panel)
        {            
            monitorView.TopLevel = false;
            monitorView.Dock = DockStyle.Fill;
            panel.Controls.Add(monitorView);
            monitorView.Show();
        }

        public MonitorView LeftMonitorView { get { return leftMonitorView; } }
        public MonitorView RightMonitorView { get { return rightMonitorView; } }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            isClickLeft = true;
            SetVisible(false);            
            switch (rightType)
            {
                case CameraType.Back:
                    rightMonitorView.Visible = false;
                    FrontBackView backView = new FrontBackView(leftMonitorView);
                    backView.BackEvent += OnBackButtonClick;
                    this.Text = leftMonitorView.Text+"调试界面";
                    leftMonitorView.TxtPanel.Visible = false;
                    addView = backView;
                    removeView = rightMonitorView;

                    addView.TopLevel = false;
                    addView.Dock = DockStyle.Fill;
                    rightPanel.Controls.Remove(removeView);
                    rightPanel.Controls.Add(addView);
                    addView.Show();
                    break;
            }
        }


        private void rightBtn_Click(object sender, EventArgs e)
        {
            isClickLeft = false;
            SetVisible(false);
            switch (leftType)
            {
                case CameraType.Front:
                    leftMonitorView.Visible = false;
                    FrontBackView frontView = new FrontBackView(rightMonitorView);
                    frontView.BackEvent += OnBackButtonClick;
                    this.Text = rightMonitorView.Text + "调试界面";
                    rightMonitorView.TxtPanel.Visible = false;
                    addView = frontView;
                    removeView = leftMonitorView;

                    addView.TopLevel = false;
                    addView.Dock = DockStyle.Fill;
                    leftPanel.Controls.Remove(removeView);
                    leftPanel.Controls.Add(addView);
                    addView.Show();
                    break;
            }

        }
        void SetVisible(bool visible)
        {
            leftBtn.Visible = visible;
            rightBtn.Visible = visible;            
        }

        private void OnBackButtonClick(object sender, EventArgs e)
        {
            SetVisible(true);
            if (isClickLeft)
            {
                rightPanel.Controls.Remove(addView);
                rightPanel.Controls.Add(removeView);
                leftMonitorView.TxtPanel.Visible = true;
                rightMonitorView.Visible = true;
            }
            else
            {
                leftPanel.Controls.Remove(addView);
                leftPanel.Controls.Add(removeView);
                rightMonitorView.TxtPanel.Visible = true;
                leftMonitorView.Visible = true;
            }

            this.Text = leftMonitorView.Text+"和" + rightMonitorView.Text ;
            //removeView.Show();
        }
    }
}
