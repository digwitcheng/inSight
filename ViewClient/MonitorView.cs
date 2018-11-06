using Cognex.InSight;
using Cognex.InSight.Cell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ViewClient
{
    public partial class MonitorView : Form
    {
        private Cognex.InSight.NativeMode.CvsNativeModeClient oNativeModeClient;
        private CameraConfig config;
        public Panel TxtPanel { get { return this.txtPanel; } }
        public MonitorView(CameraConfig config)
        {
            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            InitializeComponent();
            this.Text = config.CameraName;
            this.config = config;
            InitCvsInSightDisplay();
        }
        private void MonitorView_Load(object sender, EventArgs e)
        {


        }
        private void InitCvsInSightDisplay()
        {
            cvsInSightDisplay1.LoadStandardTheme();
            cvsInSightDisplay1.ShowImage = true;
            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;

            oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            oNativeModeClient.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(oNativeModeClient_ConnectCompleted);

            ConnetServer();
            //Thread thread = new Thread(ConnetServer);
            //thread.Start();
        }
        void oNativeModeClient_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            //const int ExtLen = 3;
            //string response, fList;
            //int dotLoc = 0;

            //oNativeModeClient.SendCommand("get filelist");
            //System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            //response = oNativeModeClient.LastResponseString;
            //xDoc.LoadXml(@"<?xml version=""1.0""?>" + response);
            //// misc1.jobmisc2.jobproc.setmisc3.job
            //fList = xDoc.DocumentElement.InnerText.Substring(2);
            //// Parse file strings
            //while (fList.Length > ExtLen)
            //{
            //    dotLoc = fList.IndexOf('.');
            //    fList = fList.Substring(dotLoc + ExtLen + 1);
            //}

            //txtResponse.Text =oNativeModeClient.WelcomeBanner;

        }
        public bool IsConnected
        {
            get
            {
                if (!(cvsInSightDisplay1 == null))
                    return cvsInSightDisplay1.Connected;
                else
                    return false;
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
                if (nrdr.ReadToFollowing("Status"))
                {
                    if (nrdr.ReadElementContentAsString().Equals("1"))
                    {
                        return nrdr.ReadElementContentAsString();
                    }
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
        public string Get(string position)
        {
            string command = Tools.GetCommandString(position);
            return SendCommand(command);
        }
        public string Set(string position, string value)
        {
            string command = Tools.SetCommandString(position, value);
            return SendCommand(command);
        }
        public string Set(string position, double value)
        {
            return Set(position, value + "");
        }
        public void ConnetServer()
        {
            try
            {
                if (!(cvsInSightDisplay1.Connected))
                {
                    cvsInSightDisplay1.Connect(config.CameraAddress, config.UserName, config.Password, false);
                }
                if (!oNativeModeClient.Connected)
                {
                    oNativeModeClient.ConnectAsynchronous(config.CameraAddress, config.UserName, config.Password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }

        private void clearCountBtn1_Click(object sender, EventArgs e)
        {
            Set(ConstDefine.RESET, 1);
        }

        private void cameraBtn1_Click(object sender, EventArgs e)
        {

        }

        private void MonitorView_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppForm_Disposed();
        }
        void AppForm_Disposed()
        {
            if (oNativeModeClient.Connected)
                oNativeModeClient.Disconnect();
        }
        public void OpenJob()
        {
            cvsInSightDisplay1.Edit.OpenJob.Execute();
        }
        public bool IsOnline()
        {
            if (cvsInSightDisplay1 != null && IsConnected)
            {
                return cvsInSightDisplay1.Edit.SoftOnline.Activated;
            }
            return false;
        }
        public void SetOnline()
        {
            cvsInSightDisplay1.Edit.SoftOnline.Activated = true;
        }
        public void SetOffline()
        {
            cvsInSightDisplay1.Edit.SoftOnline.Activated = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                sum.Text = Get(ConstDefine.TOTAL);
                qualified.Text = Get(ConstDefine.PASS_COUNT);
                unqualified.Text = Get(ConstDefine.FAIL_COUNT);
            }

        }
    }
}
