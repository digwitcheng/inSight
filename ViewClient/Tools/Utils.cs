using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient
{
    class Utils
    {
        internal static CameraConfig CreateCameraConfig(CameraType type)
        {
            CameraConfig config = new CameraConfig();
            config.CurrentCameraType = type;
            switch (type)
            {
                case CameraType.Batch:
                    config.CameraName = "批号相机";
                    config.CameraAddress = AppSetting.BATCH_CAMERA_ADDRESS;
                    break;
                case CameraType.Shoulder:
                    config.CameraName = "肩标相机";
                    config.CameraAddress = AppSetting.SHOULDER_CAMERA_ADDRESS;
                    break;
                case CameraType.Front:
                    config.CameraName = "前标相机";
                    config.CameraAddress = AppSetting.FRONT_CAMERA_ADDRESS;
                    break;
                case CameraType.Back:
                    config.CameraName = "背标相机";
                    config.CameraAddress = AppSetting.BACK_CAMERA_ADDRESS;
                    break;
                case CameraType.IsFront:
                    config.CameraName = "正标有无相机";
                    config.CameraAddress = AppSetting.ISFRONT_CAMERA_ADDRESS;
                    break;
                case CameraType.IsBack:
                    config.CameraName = "背标有无相机";
                    config.CameraAddress = AppSetting.ISBACK_CAMERA_ADDRESS;
                    break;
                default:
                    config.CameraName = "未知";
                    break;
            }            
            return config;
        }

        internal static Color MyYellow
        {
            get
            {
                return Color.FromArgb(255, 255, 192);
            }
        }
        internal static Color MyBlue
        {
            get
            {
                return Color.FromArgb(86, 167, 190);
            }
        }

        internal static void CheckConnect(MonitorView monitorView, Panel panel)
        {
            if (monitorView.IsConnected)
            {
                panel.BackColor = Color.Aqua;
                panel.Enabled = true;
                panel.BorderStyle = BorderStyle.Fixed3D;
                //button.Enabled = true;
                //button.Text = "联机/脱机";
            }
            else
            {
                panel.BackColor = Color.LightGray;
                panel.Enabled = false;
                panel.BorderStyle = BorderStyle.None;
                //button.Enabled = false;
                //button.Text = "无相机";

            }
        }

        internal static string GetCommandInteger(string position)
        {
            return string.Format("EV GetCellValue(\"{0}\")", position);
        }

        internal static string SetCommandInteger(string position,string value)
        {
            return string.Format("EV SetCellValue(\"{0}\",{1})", position, value);
        }

        internal static string SetCommandString(string position, string value)
        {
            return string.Format("EV SetCellValue(\"{0}\",\"{1}\")", position, value);
        }
    }
}
