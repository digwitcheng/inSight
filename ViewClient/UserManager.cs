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
    public partial class UserManager : Form
    {
        List<User> users;
        public UserManager()
        {
            InitializeComponent();
            users = AppSetting.UserList;
            LoadData();
        }
        private void LoadData()
        {
            listBox1.Items.Clear();
            label2.Text= String.Format("{0,-10}  {1,-10}  {2,2} ", "用户类型", "用户名","密码" );
            if (users != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    string userType = users[i].IsAdmin == true ? "管理员" : "工作员";
                    string item1= String.Format("{0,-10}  {1,-10}  {2,6} ", userType, users[i].UserName, users[i].Password);
                        
                    listBox1.Items.Add(item1);
                }
            }
        } 
        

        private void UserManager_Load(object sender, EventArgs e)
        {
            label1.Text = "提示：\r\n在选中条上双击修改";
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("请先选中要修改的用户");
                return;
            }
            string selectedItem = (string)listBox1.SelectedItem;            
            string []items = selectedItem.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            User user = new User(items[1], items[2],items[0].Equals("管理员"));
            EditUser editUser = new EditUser(users, user);
            editUser.ShowDialog();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(users, null);
            editUser.ShowDialog();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool res = FileTools.SaveUserSetting(users);
            if (res)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("请先选中要删除的用户");
                return;
            }
            string selectedItem = (string)listBox1.SelectedItem;
            string[] items = selectedItem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            User user = new User(items[1], items[2], items[0].Equals("管理员"));
            users.Remove(user);
            LoadData();
        }
    }
}
