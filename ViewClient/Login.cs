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
            //Form selctJobView = new SelectJob(this);
            //selctJobView.Show();

            MonitorViewTab BatchShoulderView = new MonitorViewTab(CameraType.Front, CameraType.Back);
            BatchShoulderView.Show();

            this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
