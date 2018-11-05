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
        public SelectJob(Form form)
        {
            loginForm = form;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frontBackView.Show();
            //FrontBackView.Show();
            //IsFrontIsBackView.Show();
        }
        void LoadCameraView()
        {
            frontBackView = new MonitorViewTab(CameraType.Front, CameraType.Back);
            // BatchShoulderView = new MonitorViewTab(CameraType.Batch,CameraType.Shoulder);
            //Form IsFrontIsBackView = new MonitorViewTab("正标有无相机", "背标有无相机");
            this.timer1.Enabled = true;
            this.timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (frontBackView.LeftMonitorView.IsConnected)
            {
                panel5.BackColor = Color.LightBlue;
                frontBtn.Enabled = true;
                frontBtn.Text = "联机/脱机";
            }
            else
            {
                panel5.BackColor = Color.FromArgb(86, 167, 190);
                frontBtn.Enabled = false;
                frontBtn.Text = "无相机";
            }
            if (frontBackView.RightMonitorView.IsConnected)
            {
                panel6.BackColor = Color.LightBlue;
                backBtn.Enabled = true;
                backBtn.Text = "联机/脱机";
            }
            else
            {
                panel6.BackColor =Color.FromArgb(86, 167, 190);
                backBtn.Enabled = false;
                backBtn.Text = "无相机";
            }
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
    }
}
