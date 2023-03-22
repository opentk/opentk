using System;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// OpenGL 3.1+
    /// </summary>
    public static unsafe partial class GL
    {
        // Right now this is the only method that actually takes a color besides a few FFP methods.
        // So currently its not worth it creating an overloader for these.
        // I also doubt there will ever be created new methods that take in a color.
        // 30-05-2021 FrederikJA
        /// <inheritdoc cref="ClearColor(float, float, float, float)"/>
        public static void ClearColor(Color4<Rgba> clearColor)
        {
            GL.ClearColor(clearColor.X, clearColor.Y, clearColor.Z, clearColor.W);
        }

        /// <inheritdoc cref="ShaderSource(int, int, byte**, in int)"/>
        public static void ShaderSource(int shader, string shaderText)
        {
            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            var length = shaderText.Length;
            GL.ShaderSource(shader, 1, (byte**)&shaderTextPtr, length);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetShaderi(int, ShaderParameterName, ref int)"/> followed by <see cref="GL.GetShaderInfoLog(int, int, ref int, out string)"/>.
        /// </summary>
        public static void GetShaderInfoLog(int shader, out string info)
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

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetProgrami(int, ProgramPropertyARB, ref int)"/> followed by <see cref="GL.GetProgramInfoLog(int, int, ref int, out string)"/>.
        /// </summary>
        public static void GetProgramInfoLog(int program, out string info)
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

        /// <inheritdoc cref="CreateShaderProgramv(ShaderType, int, byte**)"/>
        public static int CreateShaderProgram(ShaderType shaderType, string shaderText)
        {
            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            int program = GL.CreateShaderProgramv(shaderType, 1, (byte**)&shaderTextPtr);
            Marshal.FreeCoTaskMem(shaderTextPtr);
            return program;
        }
    }
}
