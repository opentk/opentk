﻿//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
#if !MINIMAL
using System.Drawing;

#endif

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Provides access to OpenGL 4.x methods for the core profile.
    /// </summary>
    public sealed partial class GL : GraphicsBindingsBase
    {
        private const string Library = "opengl32.dll";
        private static readonly object Sync_root = new object();

        private static readonly IntPtr[] EntryPoints;
        private static readonly byte[] EntryPointNames;
        private static readonly int[] EntryPointNameOffsets;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot => Sync_root;

        // Note: Mono 1.9.1 truncates StringBuilder results (for 'out string' parameters).
        // We work around this issue by doubling the StringBuilder capacity.

        public static void ClearColor(Color color)
        {
            ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            ClearColor(color.R, color.G, color.B, color.A);
        }

        public static void BlendColor(Color color)
        {
            BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            BlendColor(color.R, color.G, color.B, color.A);
        }

        public static void Uniform2(int location, ref Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        public static void Uniform3(int location, ref Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public static void Uniform4(int location, ref Vector4 vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform2(int location, Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        public static void Uniform3(int location, Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public static void Uniform4(int location, Vector4 vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform4(int location, Color4 color)
        {
            Uniform4(location, color.R, color.G, color.B, color.A);
        }

        public static void Uniform4(int location, Quaternion quaternion)
        {
            Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public static void UniformMatrix2(int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    UniformMatrix2(location, 1, transpose, matrixPtr);
                }
            }
        }

        public static void UniformMatrix3(int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    UniformMatrix3(location, 1, transpose, matrixPtr);
                }
            }
        }

        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    UniformMatrix4(location, 1, transpose, matrixPtr);
                }
            }
        }

        public static void ProgramUniform2(uint program, int location, ref Vector2 vector)
        {
            ProgramUniform2(program, location, vector.X, vector.Y);
        }

        public static void ProgramUniform3(uint program, int location, ref Vector3 vector)
        {
            ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        public static void ProgramUniform4(uint program, int location, ref Vector4 vector)
        {
            ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void ProgramUniform2(uint program, int location, Vector2 vector)
        {
            ProgramUniform2(program, location, vector.X, vector.Y);
        }

        public static void ProgramUniform3(uint program, int location, Vector3 vector)
        {
            ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        public static void ProgramUniform4(uint program, int location, Vector4 vector)
        {
            ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void ProgramUniform4(uint program, int location, Color4 color)
        {
            ProgramUniform4(program, location, color.R, color.G, color.B, color.A);
        }

        public static void ProgramUniform4(uint program, int location, Quaternion quaternion)
        {
            ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public static void ProgramUniformMatrix2(uint program, int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    ProgramUniformMatrix2(program, location, 1, transpose, matrixPtr);
                }
            }
        }

        public static void ProgramUniformMatrix3(uint program, int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    ProgramUniformMatrix3(program, location, 1, transpose, matrixPtr);
                }
            }
        }

        public static void ProgramUniformMatrix4(uint program, int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrixPtr = &matrix.Row0.X)
                {
                    ProgramUniformMatrix4(program, location, 1, transpose, matrixPtr);
                }
            }
        }

        public static string GetActiveAttrib(uint program, uint index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, GetProgramParameterName.ActiveAttributeMaxLength, out length);
            string str;

            GetActiveAttrib(program, index, length == 0 ? 1 : length * 2, out length, out size, out type, out str);
            return str;
        }

        public static string GetActiveUniform(uint program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, GetProgramParameterName.ActiveUniformMaxLength, out length);

            string str;
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out str);
            return str;
        }

        public static void ShaderSource(int shader, string @string)
        {
            unsafe
            {
                var length = @string.Length;
                ShaderSource((uint)shader, 1, new[] { @string }, &length);
            }
        }

        public static string GetShaderInfoLog(int shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public static void GetShaderInfoLog(int shader, out string info)
        {
            unsafe
            {
                int length;
                GetShader(shader, ShaderParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }

                GetShaderInfoLog((uint)shader, length * 2, &length, out info);
            }
        }

        public static string GetProgramInfoLog(uint program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public static void GetProgramInfoLog(uint program, out string info)
        {
            unsafe
            {
                int length;
                GetProgram(program, GetProgramParameterName.InfoLogLength, out length);
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }

                GetProgramInfoLog(program, length * 2, &length, out info);
            }
        }

        public static void VertexAttrib2(uint index, ref Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        public static void VertexAttrib3(uint index, ref Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(uint index, ref Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public static void VertexAttrib2(uint index, Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        public static void VertexAttrib3(uint index, Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(uint index, Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        public static void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
        {
            DrawElements((PrimitiveType)mode, count, type, new IntPtr(offset));
        }

        public static void GetFloat(GetPName pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public static void GetFloat(GetPName pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public static void GetFloat(GetPName pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public static void GetFloat(GetPName pname, out Matrix4 matrix)
        {
            unsafe
            {
                fixed (Matrix4* ptr = &matrix)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public static void Viewport(Size size)
        {
            Viewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(Point location, Size size)
        {
            Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }

    /// <summary>
    /// Defines the signature of a debug callback for
    ///  <see cref="GL.Arb.DebugMessageCallback" />.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource" /> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType" /> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity" /> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcArb
    (
        DebugSource source,
        DebugType type,
        int id,
        DebugSeverity severity,
        int length,
        IntPtr message,
        IntPtr userParam
    );

    /// <summary>
    /// Defines the signature of a debug callback for
    ///  <see cref="GL.DebugMessageCallback" />.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource" /> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType" /> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity" /> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProc
    (
        DebugSource source,
        DebugType type,
        int id,
        DebugSeverity severity,
        int length,
        IntPtr message,
        IntPtr userParam
    );

    /// <summary>
    /// Defines the signature of a debug callback for
    ///  <see cref="GL.Khr.DebugMessageCallback" />.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource" /> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType" /> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity" /> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcKhr
    (
        DebugSource source,
        DebugType type,
        int id,
        DebugSeverity severity,
        int length,
        IntPtr message,
        IntPtr userParam
    );
}
