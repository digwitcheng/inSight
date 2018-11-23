using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
   public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public User(string userName,string password,bool isAdmin)
        {
            this.UserName = userName;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            User user = (User)obj;
            if (!user.UserName.Equals(this.UserName)) return false;
            if (!user.Password.Equals(this.Password)) return false;
            if (!(user.IsAdmin==this.IsAdmin))return false;
            return true;
        }
        public override int GetHashCode()
        {
            return UserName.GetHashCode()&Password.GetHashCode()&IsAdmin.GetHashCode();
        }
    }
}
