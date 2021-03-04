using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGLES3
{
    public static unsafe partial class GL
    {
        public static unsafe void ShaderSource(uint shader, string str)
        {
            IntPtr str_iptr = Marshal.StringToCoTaskMemAnsi(str);
            int length = str.Length;
            GL.ShaderSource(shader, 1, (byte**)&str_iptr, ref length);
            Marshal.FreeCoTaskMem(str_iptr);
        }
    }
}
