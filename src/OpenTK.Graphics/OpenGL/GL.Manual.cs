using System;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// OpenGL 3.1+
    /// </summary>
    public static unsafe partial class GL
    {
        /// <inheritdoc cref="ClearColor(float, float, float, float)"/>
        public static void ClearColor(Color4<Rgba> clearColor)
        {
            GL.ClearColor(clearColor.X, clearColor.Y, clearColor.Z, clearColor.W);
        }

        /// <inheritdoc cref="ShaderSource(int, int, byte**, int*)"/>
        public static void ShaderSource(int shader, string shaderText)
        {
            var shaderTextPtr = Marshal.StringToCoTaskMemAnsi(shaderText);
            var length = shaderText.Length;
            GL.ShaderSource(shader, 1, (byte**)&shaderTextPtr, &length);
            Marshal.FreeCoTaskMem(shaderTextPtr);
        }

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetShaderi(int, ShaderParameterName, out int)"/> followed by <see cref="GL.GetShaderInfoLog(int, int, out int, out string)"/>.
        /// </summary>
        public static void GetShaderInfoLog(int shader, out string info)
        {
            GL.GetShaderi(shader, ShaderParameterName.InfoLogLength, out int length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GL.GetShaderInfoLog(shader, length, out length, out info);
            }
        }

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetShaderi(int, ShaderParameterName, out int)"/> followed by <see cref="GL.GetShaderInfoLog(int, int, out int, out string)"/>.
        /// </summary>
        public static string GetShaderInfoLog(int shader)
        {
            GetShaderInfoLog(shader, out string info);
            return info;
        }

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetProgrami(int, ProgramProperty, out int)"/> followed by <see cref="GL.GetProgramInfoLog(int, int, out int, out string)"/>.
        /// </summary>
        public static void GetProgramInfoLog(int program, out string info)
        {
            GL.GetProgrami(program, ProgramProperty.InfoLogLength, out int length);
            if (length == 0)
            {
                info = string.Empty;
            }
            else
            {
                GL.GetProgramInfoLog(program, length, out length, out info);
            }
        }

        /// <summary>
        /// This is a convenience function that calls <see cref="GL.GetProgrami(int, ProgramProperty, out int)"/> followed by <see cref="GL.GetProgramInfoLog(int, int, out int, out string)"/>.
        /// </summary>
        public static string GetProgramInfoLog(int program)
        {
            GetProgramInfoLog(program, out string info);
            return info;
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
