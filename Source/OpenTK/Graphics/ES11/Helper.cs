using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>
    public sealed partial class GL : GraphicsBindingsBase
    {
        const string Library = "libGLES.dll";
    }
}
