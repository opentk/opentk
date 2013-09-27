using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    using CGLContextObj = IntPtr;

    static class Cgl
    {
        const string lib = "/System/Library/Frameworks/OpenGL.framework/Versions/Current/OpenGL";

        [DllImport(lib, EntryPoint = "CGLGetCurrentContext")]
        public static extern CGLContextObj GetCurrentContext();
    }
}

