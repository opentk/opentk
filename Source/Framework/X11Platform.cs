using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Platform.X;

namespace OpenTK
{
    class X11Platform : PlatformSpecific 
    {
        IntPtr display;

        public X11Platform()
        {
            Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui != null)
            {
                Console.WriteLine("Got XplatUIX11 type.");

                display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);
            }
        }

        public override bool IsIdle()
        {
            return (X11Api.Pending(display) == 0) ? true : false;
        }
    }
}
