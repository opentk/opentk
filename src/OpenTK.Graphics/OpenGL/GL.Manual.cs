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
            GetShader(shader, ShaderParameterName.InfoLogLength, ref length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GetShaderInfoLog(shader, length, ref length, out info);
            }
        }

        /// <summary>
        /// Create a stand-alone program from an array of null-terminated source code strings
        /// </summary>
        /// <param name="shaderType">Specifies the type of shader to create</param>
        /// <param name="count">Specifies the number of source code strings in the array strings</param>
        /// <param name="shaderText"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void CreateShaderProgramv(ShaderType shaderType, int count, string shaderText)
        {
            if (string.IsNullOrEmpty(shaderText))
            {
                throw new ArgumentNullException(nameof(shaderText))
            }

            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            CreateShaderProgramv_(shaderType, count, (byte**)shaderTextPtr);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }
    }
}
