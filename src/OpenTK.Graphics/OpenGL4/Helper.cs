//
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
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Provides access to OpenGL 4.x methods for the core profile.
    /// </summary>
    public sealed partial class GL : BindingsBase
    {
        private const string Library = "opengl32.dll";

        private static readonly IntPtr[] EntryPoints;
        private static readonly string[] EntryPointNames;

        /// <summary>
        /// Loads all the available bindings for the current context.
        /// </summary>
        /// <param name="context">The context used to query the available bindings.</param>
        /// <remarks>
        /// Loads all available entry points for the current OpenGL context.
        /// </remarks>
        public static void LoadBindings(IBindingsContext context)
        {
            Debug.Print("Loading entry points for {0}", typeof(GL).FullName);

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            for (int i = 0; i < EntryPoints.Length; i++)
            {
                EntryPoints[i] = context.GetProcAddress(EntryPointNames[i]);
            }
        }

#pragma warning disable 3019
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

        public static void ClearColor(Color color)
        {
            GL.ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            GL.ClearColor(color.R, color.G, color.B, color.A);
        }

        public static void BlendColor(Color color)
        {
            GL.BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            GL.BlendColor(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform2(int location, ref Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform3(int location, ref Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, ref Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform2(int location, Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform3(int location, Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform2(int location, ref Vector2i vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform3(int location, ref Vector3i vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, ref Vector4i vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform2(int location, Vector2i vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform3(int location, Vector3i vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Vector4i vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="OpenTK.Mathematics.Color4"/> uniform variable for the current program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="color">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Color4 color)
        {
            GL.Uniform4(location, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Quaternion"/> uniform variable for the current program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Quaternion quaternion)
        {
            GL.Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2(int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2(int location, bool transpose, ref Matrix2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix2x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x3(int location, bool transpose, ref Matrix2x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x3(int location, bool transpose, ref Matrix2x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix2x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x4(int location, bool transpose, ref Matrix2x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x4(int location, bool transpose, ref Matrix2x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix3x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x2(int location, bool transpose, ref Matrix3x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x2(int location, bool transpose, ref Matrix3x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3(int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3(int location, bool transpose, ref Matrix3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x4(int location, bool transpose, ref Matrix3x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x4(int location, bool transpose, ref Matrix3x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix4x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x2(int location, bool transpose, ref Matrix4x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x2(int location, bool transpose, ref Matrix4x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix4x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x3(int location, bool transpose, ref Matrix4x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x3(int location, bool transpose, ref Matrix4x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4(int location, bool transpose, ref Matrix4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform2(int program, int location, ref Vector2 vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform3(int program, int location, ref Vector3 vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, ref Vector4 vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform2(int program, int location, Vector2 vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform3(int program, int location, Vector3 vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Vector4 vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform2(int program, int location, ref Vector2i vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform3(int program, int location, ref Vector3i vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, ref Vector4i vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform2(int program, int location, Vector2i vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform3(int program, int location, Vector3i vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Vector4i vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="OpenTK.Mathematics.Color4"/> uniform variable for the specified program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="color">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Color4 color)
        {
            GL.ProgramUniform4(program, location, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Quaternion"/> uniform variable for the specified program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Quaternion quaternion)
        {
            GL.ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2(int program, int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2(int program, int location, bool transpose, ref Matrix2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x3(int program, int location, bool transpose, ref Matrix2x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x3(int program, int location, bool transpose, ref Matrix2x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x4(int program, int location, bool transpose, ref Matrix2x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x4(int program, int location, bool transpose, ref Matrix2x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x2(int program, int location, bool transpose, ref Matrix3x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x2(int program, int location, bool transpose, ref Matrix3x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3(int program, int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3(int program, int location, bool transpose, ref Matrix3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x4(int program, int location, bool transpose, ref Matrix3x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x4(int program, int location, bool transpose, ref Matrix3x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x2(int program, int location, bool transpose, ref Matrix4x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x2(int program, int location, bool transpose, ref Matrix4x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x3(int program, int location, bool transpose, ref Matrix4x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x3(int program, int location, bool transpose, ref Matrix4x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4(int program, int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4(int program, int location, bool transpose, ref Matrix4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, OpenGL4.GetProgramParameterName.ActiveAttributeMaxLength, out length);
            string str;

            GetActiveAttrib(program, index, length == 0 ? 1 : length * 2, out length, out size, out type, out str);
            return str;
        }

        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenGL4.GetProgramParameterName.ActiveUniformMaxLength, out length);

            string str;
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out str);
            return str;
        }

        public static void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                GL.ShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
        }

        public static string GetShaderInfoLog(Int32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public static void GetShaderInfoLog(Int32 shader, out string info)
        {
            unsafe
            {
                int length;
                GL.GetShader(shader, ShaderParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GL.GetShaderInfoLog((UInt32)shader, length * 2, &length, out info);
            }
        }

        public static string GetProgramInfoLog(Int32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public static void GetProgramInfoLog(Int32 program, out string info)
        {
            unsafe
            {
                int length;
                GL.GetProgram(program, OpenGL4.GetProgramParameterName.InfoLogLength, out length); if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GL.GetProgramInfoLog((UInt32)program, length * 2, &length, out info);
            }
        }

        public static void VertexAttrib2(Int32 index, ref Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        public static void VertexAttrib3(Int32 index, ref Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(Int32 index, ref Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public static void VertexAttrib2(Int32 index, Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        public static void VertexAttrib3(Int32 index, Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(Int32 index, Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
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
            GL.Viewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(Point location, Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public static void Viewport(Box2i box)
        {
            GL.Viewport(box.Min.X, box.Min.Y, box.Size.X, box.Size.Y);
        }

#if MINIMAL
        public static void Viewport(OpenTK.Point location, OpenTK.Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(OpenTK.Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#endif

#pragma warning restore 3019
#pragma warning restore 1591
#pragma warning restore 1572
#pragma warning restore 1573
    }

    #pragma warning disable 1574 // XML comment cref attribute could not be resolved, compiler bug in Mono 3.4.0

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Arb.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcArb(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProc(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Khr.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcKhr(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    #pragma warning restore 1574 // XML comment cref attribute could not be resolved, compiler bug in Mono 3.4.0
}
