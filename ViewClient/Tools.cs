using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    class Tools
    {
        public static string GetCameraName(CameraType type)
        {
            switch (type)
            {
                case CameraType.Batch:
                    return "批号相机";
                case CameraType.Shoulder:
                    return "肩标相机";
                case CameraType.Front:
                    return "前标相机";
                case CameraType.Back:
                    return "背标相机";
                case CameraType.IsFront:
                    return "正标有无相机";
                case CameraType.IsBack:
                    return "背标有无相机";
                default:
                    return "未知";
            }
        }
    }
}
