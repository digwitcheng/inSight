using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    class MaterielData
    {
        public string MaterielId { get; set; }
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
        public string Limit { get; set; }
        public string LowerLimit { get; set; }


        public void SetValue(CommandType type, string value)
        {
            switch (type)
            {
                case CommandType.BarCode: BarCode = value;
                    break;
                case CommandType.Exposure: Exposure = value;
                    break;
                case CommandType.Gain: Gain = value;
                    break;
                case CommandType.FindLineX: FindLineX = value;
                    break;
                case CommandType.FindLineY: FindLineY = value;
                    break;
                case CommandType.FindLindHigh: FindLindHigh = value;
                    break;
                case CommandType.FindLineWide: FindLineWide = value;
                    break;
                case CommandType.FindLineEdge: FindLineEdge = value;
                    break;
                case CommandType.FindLineThreshold: FindLineThreshold = value;
                    break;
                case CommandType.BarCodeX: BarCodeX = value;
                    break;
                case CommandType.BarCodeY: BarCodeY = value;
                    break;
                case CommandType.BarCodeHigh: BarCodeHigh = value;
                    break;
                case CommandType.BarCodeWide: BarCodeWide = value;
                    break;
                case CommandType.Limit: Limit = value;
                    break;
                case CommandType.LowerLimit: LowerLimit = value;
                    break;
            }
        }

    }
}
