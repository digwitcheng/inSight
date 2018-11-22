using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient.DebugViews
{
    class MonitorViewFactory
    {
        internal static Form Create(MonitorView monitorView,CameraType type,Action action,bool IsMatNo100ml)
        {
            switch (type)
            {
                
                case CameraType.Batch:
                case CameraType.IsFront:
                case CameraType.IsBack:
                    return new BatchView(monitorView, action); ;
                case CameraType.Front:
                case CameraType.Back:
                    return new FrontBackView(monitorView, action);
                case CameraType.Shoulder:
                    if (IsMatNo100ml)
                    {
                        return new ShoulderView100(monitorView, action);
                    }
                    else
                    {
                       return new FrontBackView(monitorView, action);
                    }
                default:
                    return null;
            }
        }
    }
}
