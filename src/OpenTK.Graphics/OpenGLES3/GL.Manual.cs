using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGLES3
{
    // FIXME: Remove this when it's fixed
    // This is here because there in the gl.xml
    // one of the paramteres for "glSampleMaskIndexedNV"
    // is marked with a group named this, but this group is never referenced
    // anywhere else in the file.
    public enum SampleMaskNV
    { }

    public static unsafe partial class GL
    {
        public static void ShaderSource(uint shader, string str)
        {
            IntPtr str_iptr = Marshal.StringToCoTaskMemAnsi(str);
            int length = str.Length;
            OpenGL.GL.ShaderSource(shader, 1, (byte**)&str_iptr, ref length);
            Marshal.FreeCoTaskMem(str_iptr);
        }
    }
}
