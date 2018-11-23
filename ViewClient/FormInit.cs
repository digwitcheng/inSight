using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ViewClient.Properties;

namespace ViewClient
{
    public partial class FormInit : Form
    {
        Action action;
        bool isAdmin;
        public FormInit(bool isAdmin,Action action)
        {
            this.action = action;
            this.isAdmin = isAdmin;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormInit_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FormInit_Shown(object sender, EventArgs e)
        {

        }

        private void FormInit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {           
            Form selctJobView = new SelectJob(action, isAdmin);
            selctJobView.Show();
            timer1.Stop();
            this.Close();
        }
    }
}
