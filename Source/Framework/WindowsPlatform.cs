using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Platform.Windows;

namespace OpenTK
{
    class WindowsPlatform : PlatformSpecific 
    {
        public override bool IsIdle()
        {
            WinApi.Message msg;
            return !WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
        }

        public override bool ProcessEvents()
        {

            
            return base.ProcessEvents();
        }
    }
}
