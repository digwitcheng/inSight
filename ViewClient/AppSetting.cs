using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    class AppSetting
    {
        public static  string  FRONT_CAMERA_ADDRESS = "192.168.0.5";
        public static  string  BACK_CAMERA_ADDRESS = "192.168.0.2";
        public static  string  ISFRONT_CAMERA_ADDRESS = "192.168.0.1";
        public static  string  ISBACK_CAMERA_ADDRESS = "192.168.0.4";
        public static  string  BATCH_CAMERA_ADDRESS = "127.0.0.1";
        public static  string  SHOULDER_CAMERA_ADDRESS = "192.168.0.6";
        public static List<string> MatNoList100ml = new List<string>();
        public static List<User> UserList = new List<User>();

        public const string EXCEL_PATH = "MaterielTable.csv";
        public const string EXCEL_TEMP_PATH = "Temp.csv";
        public const string EXCEL_SETTING_PATH = "Setting.csv";

    }
}
