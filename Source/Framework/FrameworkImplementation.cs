#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Frameworks
{
    public partial class Framework
    {
        internal abstract class FrameworkImplementation
        {
            public abstract void OnHandleCreated(object sender, EventArgs args);
            public abstract bool IsIdle();
            public abstract void Setup();
            //abstract public void CloseWindow();
            public abstract bool SetResolution(int width, int height, OpenTK.OpenGL.ColorDepth color, bool fullscreen);
            public abstract bool SetResolution(bool fullscreen);
        }
    }
}
