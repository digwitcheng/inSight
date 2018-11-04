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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadCameraView();
        }
        void LoadCameraView()
        {
            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            Form BatchShoulderView = new MonitorView("批号相机", "肩标相机");
            //Form FrontBackView = new MonitorView("前标相机", "背标相机");
            //Form IsFrontIsBackView = new MonitorView("正标有无相机", "背标有无相机");

            BatchShoulderView.Show();
            //FrontBackView.Show();
            // IsFrontIsBackView.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
