#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OpenTK.Platform.X;

namespace OpenTK.OpenGL.Platform
{
    public partial class X11Context : OpenTK.OpenGL.GLContext
    {
        //private IntPtr drawable;
        private IntPtr Handle;
        private IntPtr GLXVisualInfo;
        private IntPtr context;
        private IntPtr display;
        const string _dll_name = "libGL.so.1";

        public X11Context(Control c, ColorDepth color, int depth, int stencil)
        {
            Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui != null)
            {
                IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                IntPtr RootWindow = (IntPtr)xplatui.GetField("RootWindow", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                int ScreenNo = (int)xplatui.GetField("ScreenNo", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                
                Handle = c.Handle;
                
                int[] dblBuf = new int[]
                { 
                    5, 
                    (int)Glx.Enums.GLXAttribute.RGBA,
                    (int)Glx.Enums.GLXAttribute.RED_SIZE, 1,
                    (int)Glx.Enums.GLXAttribute.GREEN_SIZE, 1,
                    (int)Glx.Enums.GLXAttribute.BLUE_SIZE, 1,
                    (int)Glx.Enums.GLXAttribute.DEPTH_SIZE, 1,
                    0
                };
                GLXVisualInfo = Glx.ChooseVisual(display, ScreenNo, dblBuf);

                Api.VisualInfo xVisualInfo = (Api.VisualInfo)Marshal.PtrToStructure(GLXVisualInfo, typeof(Api.VisualInfo));
                IntPtr visual = xVisualInfo.visual;
                IntPtr colormap = Api.CreateColormap(display, RootWindow, visual, 0/*AllocNone*/);

                xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, visual);
                xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, colormap);
                
                context = Glx.CreateContext(display, GLXVisualInfo, IntPtr.Zero, true);
                
                MakeCurrent();

                //GL.Init();
                //new GL();
            }
        }

        public override void SwapBuffers()
        {
            Glx.SwapBuffers(display, Handle);
        }

        public override Delegate GetAddress(string function_string, Type function_type)
        {
            IntPtr address = Glx.GetProcAddress(function_string);
            if (address == IntPtr.Zero)
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, function_type);
        }

        public override void MakeCurrent()
        {
            Glx.MakeCurrent(display, Handle, context);
        }

        public override void Dispose()
        {
            //throw new Exception("The method or operation is not implemented.");
            Glx.DestroyContext(context);
            Api.CloseDisplay(display);
        }
    }
}
