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
            LoadSetting();
        }

        private void LoadSetting()
        {
            FileTools.LoadSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            User user = new User(userName, password, AdminRadioBtn.Checked);
            if (AppSetting.UserList.Contains(user))
            {
                this.Visible = false;
                FormInit formInit = new FormInit(AdminRadioBtn.Checked,() => { this.Visible = true; });
                formInit.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
