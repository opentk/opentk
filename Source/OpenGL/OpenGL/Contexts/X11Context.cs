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

namespace OpenTK.OpenGL.Platform
{
    public partial class X11Context : OpenTK.OpenGL.GLContext
    {
        int drawable, context;
        const string _dll_name = "opengl.so";

        public X11Context(Control c, int red, int green, int blue, int alpha, int depth, int stencil)
        {
            drawable = c.Handle.ToInt32();

            throw new Exception("The method or operation is not implemented.");
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
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
