using System;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.Graphics.OpenGL.Compatibility
{
#if !TYPESAFE_HANDLES
    using ShaderHandle = System.Int32;
    using ProgramHandle = System.Int32;
#endif

    public static unsafe partial class GL
    {
        // FIXME: Remove this when it's fixed
        // This is here because there in the gl.xml
        // one of the paramteres for "glSampleMaskIndexedNV"
        // is marked with a group named this, but this group is never referenced
        // anywhere else in the file.
        public enum SampleMaskNV
        { }

        // Right now this is the only method that actually takes a color besides a few FFP methods.
        // So currently its not worth it creating an overloader for these.
        // I also doubt there will ever be created new methods that take in a color.
        // 30-05-2021 FrederikJA
        public static void ClearColor(Color4<Rgba> clearColor)
        {
            GL.ClearColor(clearColor.X, clearColor.Y, clearColor.Z, clearColor.W);
        }

        public static void ShaderSource(ShaderHandle shader, string str)
        {
            IntPtr str_iptr = Marshal.StringToCoTaskMemAnsi(str);
            int length = str.Length;
            GL.ShaderSource(shader, 1, (byte**)&str_iptr, length);
            Marshal.FreeCoTaskMem(str_iptr);
        }

        public static void GetShaderInfoLog(ShaderHandle shader, out string info)
        {
            int length = default;
            GL.GetShaderi(shader, ShaderParameterName.InfoLogLength, ref length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GL.GetShaderInfoLog(shader, length, ref length, out info);
            }
        }

        public static void GetProgramInfoLog(ProgramHandle program, out string info)
        {
            int length = default;
            GL.GetProgrami(program, ProgramPropertyARB.InfoLogLength, ref length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GL.GetProgramInfoLog(program, length, ref length, out info);
            }
        }
    }
}
