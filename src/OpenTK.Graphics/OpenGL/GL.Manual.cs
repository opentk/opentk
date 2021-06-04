using System;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

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
        public static void ShaderSource(Shader shader, string shaderText)
        {
            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            var length = shaderText.Length;
            GL.ShaderSource(shader, 1, (byte**)&shaderTextPtr, length);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }

        public static void GetShaderInfoLog(Shader shader, out string info)
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

        public static void GetProgramInfoLog(uint program, out string info)
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

        /// <summary>
        /// Create a stand-alone program from an array of null-terminated source code strings
        /// </summary>
        /// <param name="shaderType">Specifies the type of shader to create</param>
        /// <param name="shaderText"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void CreateShaderProgram(ShaderType shaderType, string shaderText)
        {
            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            GL.CreateShaderProgramv(shaderType, 1, (byte**)&shaderTextPtr);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }
    }
}
