using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL.Compatibility
{
    public static unsafe partial class GL
    {
        public static void ShaderSource(uint shader, string str)
        {
            IntPtr str_iptr = Marshal.StringToCoTaskMemAnsi(str);
            int length = str.Length;
            GL.ShaderSource(shader, 1, (byte**)&str_iptr, ref length);
            Marshal.FreeCoTaskMem(str_iptr);
        }
    }
}
