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
        public SelectJob(Form form,string userName,string password)
        {
            this.loginForm = form;
            this.userName = userName;
            this.password = password;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frontBackView.Show();
            batchShoulderView.Show();
           // isFrontIsBackView.Show();
        }
        void LoadCameraView()
        {
            frontBackView = new MonitorViewTab(Tools.CreateCameraConfig(userName,password,CameraType.Front), Tools.CreateCameraConfig(userName, password, CameraType.Back));
            batchShoulderView = new MonitorViewTab(Tools.CreateCameraConfig(userName, password, CameraType.Batch), Tools.CreateCameraConfig(userName, password, CameraType.Shoulder));
            // isFrontIsBackView = new MonitorViewTab(CameraType.IsFront, CameraType.IsBack);
            this.timer1.Enabled = true;
            this.timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Tools.CheckConnect(frontBackView.LeftMonitorView, panel5, frontBtn);
            Tools.CheckConnect(frontBackView.RightMonitorView, panel6, backBtn);
        }
       

        private void SelectJob_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            LoadCameraView();
            //MonitorView view = new MonitorView("test");
            //view.Show();
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
            //CvsInSightDisplay1.Edit.SoftOnline.Activated
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

        }

    }
}
