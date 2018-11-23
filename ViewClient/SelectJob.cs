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
        MonitorViewTab frontBackViewTab;
        MonitorViewTab batchShoulderViewTab;
        MonitorViewTab isFrontIsBackViewTab;
        Action action;
        bool isAdmin;
        MainView mainView;
        public SelectJob(Action action ,bool isAdmin)
        {
            this.action = action;
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Enabled == true)
            {
                MessageBox.Show("请先确定好配方!");
                return;
            }
            List<MaterielData> datas = FileTools.ReadExcelByText(listBox1.SelectedItem.ToString());
            if (datas == null||datas.Count<=0)
            {
                return;
            }
            foreach(MaterielData data in datas)
            {
                LoadInitCameraData(batchShoulderViewTab,data);
                LoadInitCameraData(frontBackViewTab,data);
                LoadInitCameraData(isFrontIsBackViewTab,data);
            }
            if (AppSetting.MatNoList100ml.Contains(listBox1.SelectedItem.ToString().Trim()))
            {
                batchShoulderViewTab.IsMatNo100ml = true;
            }
            if (mainView == null)
            {
                mainView = new MainView(batchShoulderViewTab, frontBackViewTab, isFrontIsBackViewTab);
            }
            mainView.Visible = true;
            mainView.Show();

        }
        void LoadInitCameraData(MonitorViewTab monitorViewTab,MaterielData data)
        {
            if (monitorViewTab.LeftMonitorView.CameraAddress.Equals(data.CameraAddress))
            {
                monitorViewTab.LeftMonitorView.Data = data;
                monitorViewTab.LeftMonitorView.LoadData();
            }
            if (monitorViewTab.RightMonitorView.CameraAddress.Equals(data.CameraAddress))
            {
                monitorViewTab.RightMonitorView.Data = data;
                monitorViewTab.RightMonitorView.LoadData();
            }
        }

        void LoadCameraView()
        {
            if (!isAdmin)
            {
                UserManagerBtn.Visible = false;
            }

            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            batchShoulderViewTab = new MonitorViewTab(Utils.CreateCameraConfig(CameraType.Batch), Utils.CreateCameraConfig( CameraType.Shoulder),isAdmin);
            frontBackViewTab = new MonitorViewTab(Utils.CreateCameraConfig( CameraType.Front), Utils.CreateCameraConfig( CameraType.Back),isAdmin);
            isFrontIsBackViewTab = new MonitorViewTab(Utils.CreateCameraConfig( CameraType.IsFront), Utils.CreateCameraConfig( CameraType.IsBack),isAdmin);

            batchShoulderViewTab.LeftMonitorView.BindOnline(BatchOnline);
            batchShoulderViewTab.RightMonitorView.BindOnline(ShoulderOnline);
            frontBackViewTab.LeftMonitorView.BindOnline(FrontOnline);
            frontBackViewTab.RightMonitorView.BindOnline(BackOnline);
            isFrontIsBackViewTab.LeftMonitorView.BindOnline(IsFrontOnline);
            isFrontIsBackViewTab.RightMonitorView.BindOnline(IsBackOnline);

            this.timer1.Enabled = true;
            this.timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Utils.CheckConnect(batchShoulderViewTab.LeftMonitorView, panel3);
            Utils.CheckConnect(batchShoulderViewTab.RightMonitorView, panel4);

            Utils.CheckConnect(frontBackViewTab.LeftMonitorView, panel5);
            Utils.CheckConnect(frontBackViewTab.RightMonitorView, panel6);

            Utils.CheckConnect(isFrontIsBackViewTab.LeftMonitorView, panel7);
            Utils.CheckConnect(isFrontIsBackViewTab.RightMonitorView, panel8);
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
            if (BatchOnline.Checked)
            {
                MessageBox.Show("请先脱机!");
                return;
            }
            batchShoulderViewTab.LeftMonitorView.OpenJob();
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

        private void ShoulderOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (ShoulderOnline.Checked)
            {
                ShoulderOnline.BackColor = Color.Yellow;
            }
            else
            {
                ShoulderOnline.BackColor = Color.Gainsboro;
            }
        }

        private void FrontOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (FrontOnline.Checked)
            {
                FrontOnline.BackColor = Color.Yellow;
            }
            else
            {
                FrontOnline.BackColor = Color.Gainsboro;
            }
        }

        private void BackOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (BackOnline.Checked)
            {
                BackOnline.BackColor = Color.Yellow;
            }
            else
            {
                BackOnline.BackColor = Color.Gainsboro;
            }
        }

        private void IsFrontOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (IsFrontOnline.Checked)
            {
                IsFrontOnline.BackColor = Color.Yellow;
            }
            else
            {
                IsFrontOnline.BackColor = Color.Gainsboro;
            }
        }

        private void IsBackOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (IsBackOnline.Checked)
            {
                IsBackOnline.BackColor = Color.Yellow;
            }
            else
            {
                IsBackOnline.BackColor = Color.Gainsboro;
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            seletedLabel.Text = "当前选择的配方:" + listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Enabled == false)
            {

                button1.Text = "确定";
                listBox1.Enabled = true;
            }
            else
            {
                button1.Text = "重新选择";
                listBox1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainView != null)
            {
                mainView.Close();
                mainView = null;
            }
            action();
        }

        private void UserManagerBtn_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }
    }
}
