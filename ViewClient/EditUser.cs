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
    public partial class EditUser : Form
    {
        List<User> users;
        int editIndex;
        User editUser;
        public EditUser(List<User> users,User user)
        {           
            InitializeComponent();
            this.users = users;
            this.editUser = user;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = AppSetting.APP_NAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = userTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            if (userName.Length < 1 || password.Length < 1)
            {
                MessageBox.Show("用户名和密码都不能为空");
                return;
            }
            if (userName.Length > 8 )
            {
                MessageBox.Show("用户名不能超过8个字符");
                return;
            }
            if (password.Length > 12)
            {
                MessageBox.Show("密码都不能超过12个字符");
                return;
            }
            User user = new User(userName, password, AdminRadioBtn.Checked);
            if (users.Contains(user))
            {
                MessageBox.Show("该用户已存在！");
                return;
            }
            if (editUser != null)
            {
                users.Remove(editUser);
            }
            users.Insert(editIndex,user);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            if (editUser != null)
            {
                userTextBox.Text = editUser.UserName;
                passwordTextBox.Text = editUser.Password;
                if (editUser.IsAdmin)
                {
                    AdminRadioBtn.Checked = true;
                }
                else
                {
                    workRadioBtn.Checked = true;
                }
                editIndex = users.IndexOf(editUser);
            }
            else
            {
                editIndex = users.Count;
            }
        }
    }
}
