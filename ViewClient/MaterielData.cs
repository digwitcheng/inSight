using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    public class MaterielData
    {
        public string MatNo { get; set; }
        public string Info { get; set; }
        public string BarCode { get; set; }
        public string CameraAddress { get; set; }
        public string Exposure { get; set; }
        public string Gain { get; set; }
        public string FindLineX { get; set; }
        public string FindLineY { get; set; }
        public string FindLindHigh { get; set; }
        public string FindLineWide { get; set; }
        public string FindLineEdge { get; set; }
        public string FindLineThreshold { get; set; }
        public string BarCodeX { get; set; }
        public string BarCodeY { get; set; }
        public string BarCodeHigh { get; set; }
        public string BarCodeWide { get; set; }


        public string FindLineX_100 { get; set; }//	100ml找边区域X坐标
        public string FindLineY_100 { get; set; }//	100ml找边区域Y坐标
        public string FindLindHigh_100 { get; set; }//	100ml找边区域高度
        public string FindLineWide_100 { get; set; }//	100ml找边区域宽度
        public string FindLineTs_100 { get; set; }//	100ml找边瓶盖阈值
        public string FindLineEdge_100 { get; set; }//	100ml瓶盖边宽度
        public string FindLineTs_100L { get; set; }//	100ml标签找边阈值
        public string FindLineEdge_100L { get; set; }//	100ml标签边宽度
        public string Limit { get; set; }//	100ml标签上限阈值
        public string LowerLimit { get; set; }//	100ml标签下限阈值

        public MaterielData()
        {
            MatNo = "";
            Info = "";
            BarCode = "";
            CameraAddress = "";
            Exposure = "";
            Gain = "";
            FindLineX = "";
            FindLineY = "";
            FindLindHigh = "";
            FindLineWide = "";
            FindLineEdge = "";
            FindLineThreshold = "";
            BarCodeX = "";
            BarCodeY = "";
            BarCodeHigh = "";
            BarCodeWide = "";

            FindLineX_100 = "";//	100ml找边区域X坐标
            FindLineY_100 = "";//	100ml找边区域Y坐标
            FindLindHigh_100 = "";//	100ml找边区域高度
            FindLineWide_100 = "";//	100ml找边区域宽度
            FindLineTs_100 = "";//	100ml找边瓶盖阈值
            FindLineEdge_100 = "";//	100ml瓶盖边宽度
            FindLineTs_100L = "";//	100ml标签找边阈值
            FindLineEdge_100L = "";//	100ml标签边宽度
            Limit = "";//	100ml标签上限阈值
            LowerLimit = "";//	100ml标签下限阈值
        }


        public void SetValue(CommandType type, string value)
        {
            switch (type)
            {
                case CommandType.MatNo:
                    MatNo = value;
                    break;
                case CommandType.BarCode:
                    BarCode = value;
                    break;
                case CommandType.Exposure:
                    Exposure = value;
                    break;
                case CommandType.Gain:
                    Gain = value;
                    break;
                case CommandType.FindLineX:
                    FindLineX = value;
                    break;
                case CommandType.FindLineY:
                    FindLineY = value;
                    break;
                case CommandType.FindLindHigh:
                    FindLindHigh = value;
                    break;
                case CommandType.FindLineWide:
                    FindLineWide = value;
                    break;
                case CommandType.FindLineEdge:
                    FindLineEdge = value;
                    break;
                case CommandType.FindLineThreshold:
                    FindLineThreshold = value;
                    break;
                case CommandType.BarCodeX:
                    BarCodeX = value;
                    break;
                case CommandType.BarCodeY:
                    BarCodeY = value;
                    break;
                case CommandType.BarCodeHigh:
                    BarCodeHigh = value;
                    break;
                case CommandType.BarCodeWide:
                    BarCodeWide = value;
                    break;
                case CommandType.FindLineX_100: FindLineX_100 = value;
                    break;//	100ml找边区域X坐标
                case CommandType.FindLineY_100: FindLineY_100 = value;
                    break;//	100ml找边区域Y坐标
                case CommandType.FindLindHigh_100: FindLindHigh_100 = value; break;//	100ml找边区域高度
                case CommandType.FindLineWide_100: FindLineWide_100 = value; break;//	100ml找边区域宽度
                case CommandType.FindLineTs_100: FindLineTs_100 = value; break;//	100ml找边瓶盖阈值
                case CommandType.FindLineEdge_100: FindLineEdge_100 = value; break;//	100ml瓶盖边宽度
                case CommandType.FindLineTs_100L: FindLineTs_100L = value; break;//	100ml标签找边阈值
                case CommandType.FindLineEdge_100L: FindLineEdge_100L = value; break;//	100ml标签边宽度
                case CommandType.Limit: Limit = value;
                    break;//	100ml标签上限阈值
                case CommandType.LowerLimit: LowerLimit = value;
                    break;//	100ml标签下限阈值

            }
        }

    }
}
