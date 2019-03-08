//
// MonitorEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.GraphicsLibraryFramework;

namespace OpenToolkit.Windowing.Desktop
{
    public class MonitorEventArgs : EventArgs
    {
        public MonitorEventArgs()
        {
            
        }

        public MonitorEventArgs(Monitor monitor, bool isConnected)
        {
            this.monitor = monitor;
            this.isConnected = isConnected;
        }

        public MonitorEventArgs(MonitorEventArgs other)
        {
            this.monitor = other.monitor;
            this.isConnected = other.isConnected;
        }

        public Monitor monitor;
        public bool isConnected;
    }
}