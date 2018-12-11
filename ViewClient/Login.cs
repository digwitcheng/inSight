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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = AppSetting.APP_NAME;
            this.Icon = Resources.Logo;            
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
            User user = new User(userName, password);
            if (AppSetting.UserList.Contains(user))
            {
                int index= AppSetting.UserList.IndexOf(user);
                this.Visible = false;
                FormInit formInit = new FormInit(AppSetting.UserList[index].IsAdmin,() => { this.Visible = true; });
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

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(2019, 3, 15, 1, 1, 1);
            if (DateTime.Now > dateTime)
            {
                MessageBox.Show("版本已到期，联系我们！邮箱:1046541763@qq.com!");
                this.Close();
            }
        }
    }
}
