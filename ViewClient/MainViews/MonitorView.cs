using Cognex.InSight;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ViewClient
{
    public partial class MonitorView : Form
    {
        private Cognex.InSight.NativeMode.CvsNativeModeClient oNativeModeClient;
        private readonly CameraConfig config;
        private bool isCameraInited = false;
        private string cameraAddress;
        private bool needStopTimer = false;
        private bool firstLoad;
        public MonitorView(CameraConfig config)
        {
            InitializeComponent();
            this.Text = config.CameraName;
            this.CameraNameLabel.Text = config.CameraName;
            this.config = config;
            this.cameraAddress = config.CameraAddress;
            InitCvsInSight();
        }
        private void MonitorView_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            firstLoad = true;
        }
        public void InitCvsInSight()
        {            
            // cvsInSightDisplay1.LoadStandardTheme();
            cvsInSightDisplay1.ShowImage = true;
            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;

            oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            oNativeModeClient.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(oNativeModeClient_ConnectCompleted);

            ConnectClient();
            ConnectDisplay();
        }
        void ConnectClient()
        {
            try
            {
               
                if (!oNativeModeClient.Connected)
                {
                    oNativeModeClient.ConnectAsynchronous(config.CameraAddress, "admin", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }
        public  void ConnectDisplay()
        {
            try
            {
                if (!(cvsInSightDisplay1.Connected))
                {
                    cvsInSightDisplay1.Connect(config.CameraAddress, "admin", "", false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }


        private void oNativeModeClient_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {

        }


        private void clearCountBtn1_Click(object sender, EventArgs e)
        {
            Set(CommandType.Reset, 1);
            Set(CommandType.Reset, 0);
        }

        private void cameraBtn1_Click(object sender, EventArgs e)
        {

        }
        private void MonitorView_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppForm_Disposed();
        }
        private void AppForm_Disposed()
        {
            if (oNativeModeClient.Connected)
                oNativeModeClient.Disconnect();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oNativeModeClient.Connected&&needStopTimer==false)
            {
                sum.Text = Get(CommandType.Total);
                qualified.Text = Get(CommandType.Pass);
                unqualified.Text = Get(CommandType.Fail);
            }
        }
        private string SendCommand(string message)
        {
            try
            {
                if (oNativeModeClient.Connected)
                {
                    if (message != null && message.Length > 0)
                    {
                        string response = oNativeModeClient.SendCommand(message.Trim());
                    }
                }
                XmlNodeReader nrdr = oNativeModeClient.LastResponseReader;
                if (nrdr != null && nrdr.ReadToFollowing("Status"))
                {
                    if (nrdr.ReadElementContentAsString().Equals("1"))
                    {
                        return nrdr.ReadElementContentAsString();
                    }
                }
                else
                {
                    return "未连接";
                }

            }
            catch (Cognex.InSight.NativeMode.CvsNativeModeResponseException resEx)
            {
                return "输入参数无效";
            }
            catch (Cognex.InSight.NativeMode.CvsNativeModeTimeoutException timEx)
            {
                return "超时";
            }
            catch (CvsNetworkException notConnected)
            {
                return "未连接";
            }
            return "未找到";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cvsInSightDisplay1.Edit.OpenJob.Execute();
        }




        #region 公共方法

        internal void BindOnline(CheckBox chkOnline)
        {
            cvsInSightDisplay1.Edit.SoftOnline.Bind(chkOnline);
        }

        internal void BindLiveMode(CheckBox liveMode)
        {
            cvsInSightDisplay1.Edit.LiveAcquire.Bind(liveMode);
        }

        internal Panel TxtPanel { get { return this.txtPanel; } }

        internal string Get(CommandType position)
        {
            string command = Utils.GetCommandInteger(position.ToString());
            return SendCommand(command);
        }

        internal void SaveJobAs()
        {
            needStopTimer = true;
            cvsInSightDisplay1.Edit.SaveJobAs.Execute();
            needStopTimer = false;
        }
        internal string SetWithString(CommandType type, string value)
        {
            string command = Utils.SetCommandString(type.ToString(), value);
            return SendCommand(command);
        }

        internal string Set(CommandType type, string value)
        {
            string command = Utils.SetCommandInteger(type.ToString(), value);
            return SendCommand(command);
        }

        internal string Set(CommandType type, double value)
        {
            return Set(type, value + "");
        }

        internal bool IsConnected
        {
            get
            {
                if (!(cvsInSightDisplay1 == null))
                    return cvsInSightDisplay1.Connected;
                else
                    return false;
            }
        }

        internal void OpenJob()
        {
            needStopTimer = true;
            cvsInSightDisplay1.Edit.OpenJob.Execute();
            needStopTimer = false;
        }

        internal bool IsCameraInited
        {
            get { return isCameraInited; }
        }

        internal void SetGridView()
        {
            cvsInSightDisplay1.ShowGrid = true;
            cvsInSightDisplay1.ShowCustomView = true;
            cvsInSightDisplay1.ShowScrollBars = true;
        }

        internal void SetImageView()
        {
            cvsInSightDisplay1.ShowGrid = false;
            cvsInSightDisplay1.ShowCustomView = false;
            cvsInSightDisplay1.ShowScrollBars = false;
        }

        internal string CameraAddress { get { return this.cameraAddress; } }

        internal MaterielData Data { get; set; }

        internal void SaveData()
        {
            FileTools.WriteExcelByText(Data);
        }

        internal void LoadData()
        {
            SetWithString(CommandType.MatNo, Data.MatNo);
            SetWithString(CommandType.BarCode, Data.BarCode);
            Set(CommandType.BarCodeHigh, Data.BarCodeHigh);
            Set(CommandType.BarCodeWide, Data.BarCodeWide);
            Set(CommandType.BarCodeX, Data.BarCodeX);
            Set(CommandType.BarCodeY, Data.BarCodeY);
            Set(CommandType.Exposure, Data.Exposure);
            Set(CommandType.FindLindHigh, Data.FindLindHigh);
            Set(CommandType.FindLineEdge, Data.FindLineEdge);
            Set(CommandType.FindLineThreshold, Data.FindLineThreshold);
            Set(CommandType.FindLineWide, Data.FindLineWide);
            Set(CommandType.FindLineX, Data.FindLineX);
            Set(CommandType.FindLineY, Data.FindLineY);
            Set(CommandType.Gain, Data.Gain);

            Set(CommandType.FindLineX_100, Data.FindLineX_100);
            Set(CommandType.FindLineY_100, Data.FindLineY_100);
            Set(CommandType.FindLindHigh_100, Data.FindLindHigh_100);
            Set(CommandType.FindLineWide_100, Data.FindLineWide_100);
            Set(CommandType.FindLineTs_100, Data.FindLineTs_100);
            Set(CommandType.FindLineEdge_100, Data.FindLineEdge_100);
            Set(CommandType.FindLineTs_100L, Data.FindLineTs_100L);
            Set(CommandType.FindLineEdge_100L, Data.FindLineEdge_100L);
            Set(CommandType.Limit, Data.Limit);
            Set(CommandType.LowerLimit, Data.LowerLimit);

        }

        #endregion

        bool isOk = true;
        private void unqualified_TextChanged(object sender, EventArgs e)
        {
            if ((config.CurrentCameraType == CameraType.IsBack || config.CurrentCameraType == CameraType.IsFront )&&firstLoad==false)
            {
                int cur = 0;
                bool res = int.TryParse(unqualified.Text.Trim(), out cur);
                if (res && cur>0 && isOk)// unqualified.Text)
                {
                    isOk = false;
                    DialogResult dr = MessageBox.Show("确认你已拿走了缺标的产品?", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        isOk = true;
                    }
                }
            }
            firstLoad = false;
        }

        private void 重新连接界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDisplay();
        }

        private void 重新连接通信ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectClient();
        }
    }
}
