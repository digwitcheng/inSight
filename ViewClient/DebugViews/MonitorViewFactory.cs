﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient.DebugViews
{
    class MonitorViewFactory
    {
        internal static Form Create(MonitorView monitorView,CameraType type,Action action)
        {
            switch (type)
            {
                case CameraType.Front:
                case CameraType.Back:
                    return new FrontBackView(monitorView,action);
                case CameraType.Batch:
                case CameraType.Shoulder:
                    return new FrontBackView(monitorView, action);
                default:
                    return null;
            }
        }
    }
}