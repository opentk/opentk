/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.OpenGL.Platform
{
    public partial class X11Context : OpenTK.OpenGL.Context
    {
        public X11Context(Control c, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void SwapBuffers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override Delegate GetAddress(string function_string, Type function_type)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void MakeCurrent()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        const string _dll_name = "opengl.so";

        public override void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
