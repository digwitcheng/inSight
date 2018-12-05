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
        private Form frontView;
        private Form backView;
        bool isClickLeft = true;
        public bool IsMatNo100ml = false;
        bool isAdmin;
        public MonitorViewTab(CameraConfig leftConfig, CameraConfig rightConfig,bool isAdmin)
        {
            InitializeComponent();
            this.leftType = leftConfig.CurrentCameraType;
            this.rightType = rightConfig.CurrentCameraType;
            this.isAdmin = isAdmin;
            string leftName = leftConfig.CameraName;
            string rightName = rightConfig.CameraName;
            this.Text = leftName + "和" + rightName;
            leftBtn.Text = leftName + "调试界面";
            rightBtn.Text = rightName + "调试界面";
            leftMonitorView = new MonitorView(leftConfig);
            rightMonitorView = new MonitorView(rightConfig);

        }

        private void MonitorViewTab_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isAdmin)
                {
                    this.panel2.Visible = false;
                    this.panel3.Visible = false;
                }
                AddMonitorView(leftMonitorView, leftPanel);
                AddMonitorView(rightMonitorView, rightPanel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddMonitorView(Form monitorView, Panel panel)
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
            rightMonitorView.Visible = false;
            this.Text = leftMonitorView.Text + "调试界面";
            leftMonitorView.TxtPanel.Visible = false;

           
                backView =  MonitorViewFactory.Create(leftMonitorView, leftType, OnCallBack, IsMatNo100ml);
                backView.TopLevel = false;
                backView.Dock = DockStyle.Fill;
           
            rightPanel.Controls.Remove(rightMonitorView);
            rightPanel.Controls.Add(backView);
            backView.Show();

            if (leftType == CameraType.Batch || leftType == CameraType.IsBack)
            {
                leftMonitorView.SetGridView();
            }
        }


        private void rightBtn_Click(object sender, EventArgs e)
        {
            isClickLeft = false;
            SetVisible(false);
            leftMonitorView.Visible = false;
            this.Text = rightMonitorView.Text + "调试界面";
            rightMonitorView.TxtPanel.Visible = false;

            
                frontView = MonitorViewFactory.Create(rightMonitorView, rightType, OnCallBack, IsMatNo100ml);
                frontView.TopLevel = false;
                frontView.Dock = DockStyle.Fill;
            
            leftPanel.Controls.Remove(leftMonitorView);
            leftPanel.Controls.Add(frontView);
            frontView.Show();

            if (rightType == CameraType.IsBack)
            {
                rightMonitorView.SetGridView();
            }


        }
        void SetVisible(bool visible)
        {
            leftBtn.Visible = visible;
            rightBtn.Visible = visible;
        }
        void OnCallBack()
        {
            SetVisible(true);
            if (isClickLeft)
            {
                rightPanel.Controls.Remove(backView);
                rightPanel.Controls.Add(rightMonitorView);
                leftMonitorView.TxtPanel.Visible = true;
                rightMonitorView.Visible = true;
            }
            else
            {
                leftPanel.Controls.Remove(frontView);
                leftPanel.Controls.Add(leftMonitorView);
                rightMonitorView.TxtPanel.Visible = true;
                leftMonitorView.Visible = true;
            }
            ShowImage();
            this.Text = leftMonitorView.Text + "和" + rightMonitorView.Text;
        }
        void ShowImage()
        {
            if (isClickLeft)
            {
                leftMonitorView.SetImageView();
            }
            else
            {
                rightMonitorView.SetImageView();
            }
        }
    }
}
