using Cognex.InSight;
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
        private Cognex.InSight.CvsInSight m_oInSight;
        private Cognex.InSight.NativeMode.CvsNativeModeClient oNativeModeClient;
        string cameraName1;
        string cameraName2;
        public MonitorView(string cameraName1,string cameraName2)
        {
            this.cameraName1 = cameraName1;
            this.cameraName2 = cameraName2;          
            InitializeComponent();

            InitCvsInSightDisplay();
            ChangeCameraBtnName();

        }
        public delegate void MyDel();

        private void InitCvsInSightDisplay()
        {
            
            cvsInSightDisplay1.LoadStandardTheme();
            cvsInSightDisplay2.LoadStandardTheme();

            oNativeModeClient = new Cognex.InSight.NativeMode.CvsNativeModeClient();
            oNativeModeClient.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(oNativeModeClient_ConnectCompleted);
            txtResponse.Text = oNativeModeClient.WelcomeBanner;

            ConnetServer();
        }
        void oNativeModeClient_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            const int ExtLen = 3;
            string response, fList;
            int dotLoc = 0;

            oNativeModeClient.SendCommand("get filelist");
            System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            response = oNativeModeClient.LastResponseString;
            xDoc.LoadXml(@"<?xml version=""1.0""?>" + response);
            // misc1.jobmisc2.jobproc.setmisc3.job
            fList = xDoc.DocumentElement.InnerText.Substring(2);
            // Parse file strings
            while (fList.Length > ExtLen)
            {
                dotLoc = fList.IndexOf('.');
                fList = fList.Substring(dotLoc + ExtLen + 1);
            }

            txtResponse.Text =oNativeModeClient.WelcomeBanner;

        }        
        /// <summary>
        /// Send the specified string to the In-Sight sensor as a native mode 
        ///  command and waits for a response. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendCommand(string message)
        {
            try
            {
                if (oNativeModeClient.Connected)
                {
                    if (message != null && message.Length > 0)
                    {
                        txtResponse.Text = oNativeModeClient.SendCommand(message.Trim());
                    }
                }
                XmlNodeReader nrdr = oNativeModeClient.LastResponseReader;
                MessageBox.Show(nrdr.Value);
                nrdr.MoveToElement();
                nrdr.Read();
                nrdr.Read();

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCommand(textBox1.Text.ToString().Trim());
        }

        private void ConnetServer()
        {
            string addr = "192.168.0.1";
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

        private void ChangeCameraBtnName()
        {

            this.Text = cameraName1 + "和" + cameraName2;
            cameraBtn1.Text = cameraName1;
            cameraBtn1.Name = cameraName1;
            cameraBtn2.Text = cameraName2;
            cameraBtn2.Name = cameraName2;
        }

        private void clearCountBtn1_Click(object sender, EventArgs e)
        {

        }

        private void clearCountBtn2_Click(object sender, EventArgs e)
        {

        }

        private void cameraBtn1_Click(object sender, EventArgs e)
        {

        }

        private void cameraBtn1_Click_1(object sender, EventArgs e)
        {

        }

        private void cameraBtn2_Click(object sender, EventArgs e)
        {

        }

        private void cvsInSightDisplay1_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            cvsInSightDisplay1.ShowImage=true;
            cvsInSightDisplay1.ShowGraphics = true;
            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;

            cvsInSightDisplay2.ShowImage = true;
            cvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;
            
        }

        private void cvsInSightDisplay1_ConnectedChanged(object sender, EventArgs e)
        {

        }

        private void cvsInSightDisplay1_StateChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            cvsInSightDisplay1.Edit.SaveJobAs.Execute();
        }
    }
}
