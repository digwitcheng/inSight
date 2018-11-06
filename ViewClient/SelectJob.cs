using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class SelectJob : Form
    {
        Form loginForm;
        MonitorViewTab frontBackView;
        MonitorViewTab batchShoulderView;
        MonitorViewTab isFrontIsBackView;
        string userName;
        string password;
        MainView mainView;
        public SelectJob(Form form,string userName,string password)
        {
            this.loginForm = form;
            this.userName = userName;
            this.password = password;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //frontBackView.Show();
            //batchShoulderView.Show();
            //isFrontIsBackView.Show();
            if(mainView==null)
              mainView = new MainView(batchShoulderView, frontBackView, isFrontIsBackView);
            mainView.Visible = true;
            mainView.Show();

        }
        void LoadCameraView()
        {
            batchShoulderView = new MonitorViewTab(Tools.CreateCameraConfig(userName, password, CameraType.Batch), Tools.CreateCameraConfig(userName, password, CameraType.Shoulder));
            frontBackView = new MonitorViewTab(Tools.CreateCameraConfig(userName,password,CameraType.Front), Tools.CreateCameraConfig(userName, password, CameraType.Back));
             isFrontIsBackView = new MonitorViewTab(Tools.CreateCameraConfig(userName, password, CameraType.IsFront), Tools.CreateCameraConfig(userName, password, CameraType.IsBack));
            this.timer1.Enabled = true;
            this.timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Tools.CheckConnect(frontBackView.LeftMonitorView, panel5, frontBtn);
            Tools.CheckConnect(frontBackView.RightMonitorView, panel6, backBtn);

            Tools.CheckConnect(batchShoulderView.LeftMonitorView, panel3, batchBtn);
            Tools.CheckConnect(batchShoulderView.RightMonitorView, panel4, shouderBtn);

            Tools.CheckConnect(isFrontIsBackView.LeftMonitorView, panel7, IsFrontBtn);
            Tools.CheckConnect(isFrontIsBackView.RightMonitorView, panel8, IsBackBtn);
        }
       

        private void SelectJob_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            LoadCameraView();
        }

        private void SelectJobBtn_Click(object sender, EventArgs e)
        {
            frontBackView.LeftMonitorView.OpenJob();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm.Visible=true;
            this.Close(); 
        }

        private void batchBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(batchShoulderView.LeftMonitorView, batchBtn);
        }

        private void frontBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(frontBackView.LeftMonitorView, frontBtn);           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(frontBackView.RightMonitorView, backBtn);
        }

        private void IsFrontBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(isFrontIsBackView.LeftMonitorView, IsFrontBtn);
        }

        private void shouderBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(batchShoulderView.RightMonitorView, shouderBtn);
        }

        private void IsBackBtn_Click(object sender, EventArgs e)
        {
            Tools.ClickCameraBtn(isFrontIsBackView.RightMonitorView, IsBackBtn);
        }
    }
}
