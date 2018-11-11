using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string userName = userTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            FormInit formInit = new FormInit(() => { this.Visible = true; }, userName, password);
            formInit.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
