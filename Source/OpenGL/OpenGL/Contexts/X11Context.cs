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
        int drawable;
        IntPtr context;
        IntPtr display;
        const string _dll_name = "opengl.so";

        public X11Context(Control c, int red, int green, int blue, int alpha, int depth, int stencil)
        {
            //drawable = c.Handle.ToInt32();
            display = Api.OpenDisplay("OpenTK X11 trial");
            Api.VisualInfo visual = Glx.ChooseVisual(display, 0, new int[] { });
            context = Glx.CreateContext(display, visual, IntPtr.Zero, true);
            //Api.Free(new IntPtr(visual));
            drawable = c.Handle.ToInt32();
            Glx.MakeCurrent(drawable, context);
            
            //context = Glx.CreateContext(
                //X11Context

            //throw new Exception("The method or operation is not implemented.");
        }

        public override void SwapBuffers()
        {
            Glx.SwapBuffers(drawable);
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
            Glx.MakeCurrent(drawable, context);
        }

        public override void Dispose()
        {
            //throw new Exception("The method or operation is not implemented.");
            Glx.DestroyContext(context);
            Api.CloseDisplay(display);
        }
    }
}
