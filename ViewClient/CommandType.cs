using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewClient
{
    public  enum CommandType
    {
        Exposure,//	曝光时间
        Gain,//	增益值
        BarCode,//	二维码内容
        MatNo,//	物料编号
        Total,//	总数
        Pass,//	合格数
        Fail,//	不合格数
        Reset,//	计数清零
        FindLineX,//	找边区域X坐标
        FindLineY,//	找边区域Y坐标
        FindLindHigh,//	找边区域高度
        FindLineWide,//	找边区域宽度
        FindLineThreshold,//	找边阈值
        FindLineEdge,//	边宽度
        BarCodeX,//	二维码检测区域X坐标
        BarCodeY,//	二维码检测区域Y坐标
        BarCodeHigh,//	二维码检测区域高度
        BarCodeWide,//	二维码检测区域宽度

        FindLineX_100,//	100ml找边区域X坐标
        FindLineY_100,//	100ml找边区域Y坐标
        FindLindHigh_100,//	100ml找边区域高度
        FindLineWide_100,//	100ml找边区域宽度
        FindLineTs_100,//	100ml找边瓶盖阈值
        FindLineEdge_100,//	100ml瓶盖边宽度
        FindLineTs_100L,//	100ml标签找边阈值
        FindLineEdge_100L,//	100ml标签边宽度
        Limit,//	100ml标签上限阈值
        LowerLimit,//	100ml标签下限阈值

    }
}
