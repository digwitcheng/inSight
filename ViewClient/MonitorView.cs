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
        // private Cognex.InSight.CvsInSight m_oInSight;
        private Cognex.InSight.NativeMode.CvsNativeModeClient oNativeModeClient;
        public CameraType CurrentCameraType { get; set; }
        public Panel TxtPanel { get { return this.txtPanel; } }
        public MonitorView(CameraType type)
        {
            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            InitializeComponent();
            this.Text = Tools.GetCameraName(type);
            this.CurrentCameraType = type;
            InitCvsInSightDisplay();
        }
        private void MonitorView_Load(object sender, EventArgs e)
        {
           
            
        }
        private void InitCvsInSightDisplay()
        {

            
            //cvsInSightDisplay1.GridOpacity = .7;
            //cvsInSightDisplay1.ImageScale = 1;
            // cvsInSightDisplay1.StatusInformationChanged += new EventHandler(OnStatusInformationChanged);
            // this.m_oInSight.StateChanged += new Cognex.InSight.CvsStateChangedEventHandler(m_oInSight_StateChanged);
            cvsInSightDisplay1.LoadStandardTheme();
            cvsInSightDisplay1.ShowImage = true;
            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;

            oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            oNativeModeClient.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(oNativeModeClient_ConnectCompleted);
            txtResponse.Text = oNativeModeClient.WelcomeBanner;
            ConnetServer();
           // m_oInSight = cvsInSightDisplay1.InSight;
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

        /// <summary>
        /// Send the specified string to the In-Sight sensor as a native mode 
        ///  command and waits for a response. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private string SendCommand(string message)
        {
            try
            {
                if (oNativeModeClient.Connected)
                {
                    if (message != null && message.Length > 0)
                    {
                        string response = oNativeModeClient.SendCommand(message.Trim());
                        txtResponse.Text = response;
                    }
                }
                XmlNodeReader nrdr = oNativeModeClient.LastResponseReader;
                if (nrdr.ReadToFollowing("Status"))
                {
                    nrdr.ReadElementContentAsString();
                    return nrdr.ReadElementContentAsString();
                }

            }
            catch (Cognex.InSight.NativeMode.CvsNativeModeResponseException resEx)
            {
                // The exception that is thrown when a Native Mode status is received that 
                //  indicates the command returned an error response.
                txtResponse.Text = resEx.Message;
            }
            catch (Cognex.InSight.NativeMode.CvsNativeModeTimeoutException timEx)
            {
                // The exception that is thrown when a Native Mode timeout occurs.
                txtResponse.Text = timEx.Message;
            }
            return "未找到";
        }
        public string Get(string position)
        {
            string command = string.Format("EV GetCellValue(\"{0}\")", position); 
            return SendCommand(command);
        }
        public string Set(string position,string value)
        {
            string command = string.Format("EV SetCellValue(\"{0}\",{1})", position, value);
            return SendCommand(command);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string position = textBox1.Text.ToString().Trim();
            string command = string.Format("EV GetCellValue(\"{0}\")", position); ;
            //"EV GetCellValue(\"" + position +"\")";
            SendCommand(command);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string position = textBox1.Text.ToString().Trim();
            string value = textBox2.Text.ToString().Trim();
            string command = string.Format("EV SetCellValue(\"{0}\",{1})", position,value);
            //"EV SetCellValue(\"" +position+ "\"," + value + ")";
            SendCommand(command);
        }

        public void ConnetServer()
        {
            string addr = "192.168.0.1";
            //string addr = "127.0.0.1";
            string username = "admin";
            string password = "";
           
            try
            {
                if (!(cvsInSightDisplay1.Connected))
                {
                    cvsInSightDisplay1.Connect(addr, username, password, false);
                }
                if (!oNativeModeClient.Connected)
                {
                    oNativeModeClient.ConnectAsynchronous(addr, username, password);
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
            // If the Client is still connected, disconnect it.
            if (oNativeModeClient.Connected)
                oNativeModeClient.Disconnect();
        }
        public void OpenJob()
        {
            cvsInSightDisplay1.Edit.OpenJob.Execute();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
