#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using OpenTK.Platform.X;
using System.Runtime.InteropServices;
using OpenTK.OpenGL.Platform;
using OpenTK.OpenGL;

namespace OpenTK.Frameworks
{
    public partial class Framework
    {
        internal class X11Implementation : FrameworkImplementation
        {
            private IntPtr display;
            public GLContext Context;

            public override void OnHandleCreated(object sender, EventArgs args)
            {

            }

            public override bool IsIdle()
            {
                return Api.Pending(display) == 0 ? true : false;
            }

            public override void Setup()
            {
                //    			Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
                //    			if (xplatui != null)
                //    			{
                //                    display = (IntPtr)xplatui.GetField("DisplayHandle",
                //                                                       System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                //              }
            }

            public override bool SetResolution(int width, int height, OpenTK.OpenGL.ColorDepth color, bool fullscreen)
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }
    }
}
