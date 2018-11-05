using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    public enum CameraType
    {
        Batch,   //批号相机
        Shoulder,//肩标相机
        Front,   //前标相机
        Back,    //背标相机
        IsFront, //正标有无相机
        IsBack   //背标有无相机
    }
}
