using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    // FIXME: Remove this when it's fixed
    // This is here because there in the gl.xml
    // one of the parameters for "glSampleMaskIndexedNV"
    // is marked with a group named this, but this group is never referenced
    // anywhere else in the file.
    public enum SampleMaskNV
    { }

    public static unsafe partial class GL
    {
        public static void ShaderSource(uint shader, string shaderText)
        {
            if (string.IsNullOrEmpty(shaderText))
            {
                throw new ArgumentNullException(nameof(shaderText));
            }

            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            var length = shaderText.Length;
            ShaderSource(shader, 1, (byte**)&shaderTextPtr, length);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }

        public static void GetShaderInfoLog(uint shader, out string info)
        {
            int length = default;
            GL.GetShader(shader, ShaderParameterName.InfoLogLength, ref length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GL.GetShaderInfoLog(shader, length, ref length, out info);
            }
        }
    }
}
