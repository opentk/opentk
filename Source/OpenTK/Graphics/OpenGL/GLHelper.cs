#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
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
#endregion


#region --- Using Directives ---

using System;
using System.Collections.Generic;
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.Reflection.Emit;


#endregion

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// OpenGL bindings for .NET, implementing the full OpenGL API, including extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class contains all OpenGL enums and functions defined in the latest OpenGL specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para> A valid OpenGL context must be created before calling any OpenGL function.</para>
    /// <para>
    /// Use the GL.Load and GL.LoadAll methods to prepare function entry points prior to use. To maintain
    /// cross-platform compatibility, this must be done for both core and extension functions. The GameWindow
    /// and the GLControl class will take care of this automatically.
    /// </para>
    /// <para>
    /// You can use the GL.SupportsExtension method to check whether any given category of extension functions
    /// exists in the current OpenGL context. Keep in mind that different OpenGL contexts may support different
    /// extensions, and under different entry points. Always check if all required extensions are still supported
    /// when changing visuals or pixel formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL function using the GL.GetDelegate method.
    /// </para>
    /// </remarks>
    /// <see href="http://opengl.org/registry/"/>
    public sealed partial class GL : GraphicsBindingsBase
    {
        #region --- Fields ---

        internal const string Library = "opengl32.dll";

        static readonly object sync_root = new object();

        static IntPtr[] EntryPoints;
        static byte[] EntryPointNames;
        static int[] EntryPointNameOffsets;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        #endregion

        #region --- Public Members ---

        /// <summary>
        /// Loads all OpenGL entry points (core and extension).
        /// This method is provided for compatibility purposes with older OpenTK versions.
        /// </summary>
        [Obsolete("If you are using a context constructed outside of OpenTK, create a new GraphicsContext and pass your context handle to it. Otherwise, there is no need to call this method.")]
        public static void LoadAll()
        {
            new GL().LoadEntryPoints();
        }

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        #endregion

        #region --- GL Overloads ---

#pragma warning disable 3019
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

        // Note: Mono 1.9.1 truncates StringBuilder results (for 'out string' parameters).
        // We work around this issue by doubling the StringBuilder capacity.

        #region public static void Color[34]() overloads

        public static void Color3(Color color)
        {
			GL.Color3(color.R, color.G, color.B);
        }

        public static void Color4(Color color)
        {
            GL.Color4(color.R, color.G, color.B, color.A);
        }

        public static void Color3(Vector3 color)
        {
            GL.Color3(color.X, color.Y, color.Z);
        }

        public static void Color4(Vector4 color)
        {
            GL.Color4(color.X, color.Y, color.Z, color.W);
        }

        public static void Color4(Color4 color)
        {
            GL.Color4(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region public static void ClearColor() overloads

        public static void ClearColor(Color color)
        {
            GL.ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            GL.ClearColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region public static void BlendColor() overloads

        public static void BlendColor(Color color)
        {
            GL.BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            GL.BlendColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region public static void Material() overloads

        public static void Material(MaterialFace face, MaterialParameter pname, Vector4 @params)
        {
            unsafe { Material(face, pname, (float*)&@params.X); }
        }

        public static void Material(MaterialFace face, MaterialParameter pname, Color4 @params)
        {
            unsafe { GL.Material(face, pname, (float*)&@params); }
        }

        #endregion

        #region public static void Light() overloads

        public static void Light(LightName name, LightParameter pname, Vector4 @params)
        {
            unsafe { GL.Light(name, pname, (float*)&@params.X); }
        }

        public static void Light(LightName name, LightParameter pname, Color4 @params)
        {
            unsafe { GL.Light(name, pname, (float*)&@params); }
        }

        #endregion

        #region Normal|RasterPos|Vertex|TexCoord|Rotate|Scale|Translate|*Matrix

        public static void Normal3(Vector3 normal)
        {
            GL.Normal3(normal.X, normal.Y, normal.Z);
        }

        public static void RasterPos2(Vector2 pos)
        {
            GL.RasterPos2(pos.X, pos.Y);
        }

        public static void RasterPos3(Vector3 pos)
        {
            GL.RasterPos3(pos.X, pos.Y, pos.Z);
        }

        public static void RasterPos4(Vector4 pos)
        {
            GL.RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
        }

        public static void Vertex2(Vector2 v)
        {
            GL.Vertex2(v.X, v.Y);
        }

        public static void Vertex3(Vector3 v)
        {
            GL.Vertex3(v.X, v.Y, v.Z);
        }

        public static void Vertex4(Vector4 v)
        {
            GL.Vertex4(v.X, v.Y, v.Z, v.W);
        }

        public static void TexCoord2(Vector2 v)
        {
            GL.TexCoord2(v.X, v.Y);
        }

        public static void TexCoord3(Vector3 v)
        {
            GL.TexCoord3(v.X, v.Y, v.Z);
        }

        public static void TexCoord4(Vector4 v)
        {
            GL.TexCoord4(v.X, v.Y, v.Z, v.W);
        }

        public static void Rotate(Single angle, Vector3 axis)
        {
            GL.Rotate((Single)angle, axis.X, axis.Y, axis.Z);
        }

        public static void Scale(Vector3 scale)
        {
            GL.Scale(scale.X, scale.Y, scale.Z);
        }

        public static void Translate(Vector3 trans)
        {
            GL.Translate(trans.X, trans.Y, trans.Z);
        }

        public static void MultMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.MultMatrix((Single*)m_ptr);
                }
            }
        }

        public static void LoadMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.LoadMatrix((Single*)m_ptr);
                }
            }
        }

        public static void LoadTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.LoadTransposeMatrix((Single*)m_ptr);
                }
            }
        }

        public static void MultTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.MultTransposeMatrix((Single*)m_ptr);
                }
            }
        }

        public static void Normal3(Vector3d normal)
        {
            GL.Normal3(normal.X, normal.Y, normal.Z);
        }

        public static void RasterPos2(Vector2d pos)
        {
            GL.RasterPos2(pos.X, pos.Y);
        }

        public static void RasterPos3(Vector3d pos)
        {
            GL.RasterPos3(pos.X, pos.Y, pos.Z);
        }

        public static void RasterPos4(Vector4d pos)
        {
            GL.RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
        }

        public static void Vertex2(Vector2d v)
        {
            GL.Vertex2(v.X, v.Y);
        }

        public static void Vertex3(Vector3d v)
        {
            GL.Vertex3(v.X, v.Y, v.Z);
        }

        public static void Vertex4(Vector4d v)
        {
            GL.Vertex4(v.X, v.Y, v.Z, v.W);
        }

        public static void TexCoord2(Vector2d v)
        {
            GL.TexCoord2(v.X, v.Y);
        }

        public static void TexCoord3(Vector3d v)
        {
            GL.TexCoord3(v.X, v.Y, v.Z);
        }

        public static void TexCoord4(Vector4d v)
        {
            GL.TexCoord4(v.X, v.Y, v.Z, v.W);
        }

        public static void Rotate(double angle, Vector3d axis)
        {
            GL.Rotate((double)angle, axis.X, axis.Y, axis.Z);
        }

        public static void Scale(Vector3d scale)
        {
            GL.Scale(scale.X, scale.Y, scale.Z);
        }

        public static void Translate(Vector3d trans)
        {
            GL.Translate(trans.X, trans.Y, trans.Z);
        }

        public static void MultMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.MultMatrix((Double*)m_ptr);
                }
            }
        }

        public static void LoadMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.LoadMatrix((Double*)m_ptr);
                }
            }
        }

        public static void LoadTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.LoadTransposeMatrix((Double*)m_ptr);
                }
            }
        }

        public static void MultTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.MultTransposeMatrix((Double*)m_ptr);
                }
            }
        }

        #endregion

        #region Uniform

        [CLSCompliant(false)]
        public static void Uniform2(int location, ref Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        [CLSCompliant(false)]
        public static void Uniform3(int location, ref Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        [CLSCompliant(false)]
        public static void Uniform4(int location, ref Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform2(int location, Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        public static void Uniform3(int location, Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public static void Uniform4(int location, Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform4(int location, Color4 color)
        {
            GL.Uniform4(location, color.R, color.G, color.B, color.A);
        }

        public static void Uniform4(int location, Quaternion quaternion)
        {
            GL.Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

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

        #endregion

        #region Shaders

        #region GetActiveAttrib

        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveAttributeMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveAttrib(program, index, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniform

        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformMaxLength, out length);

            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length);
            GetActiveUniform(program, uniformIndex, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformName

        public static string GetActiveUniformName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveUniformName(program, uniformIndex, sb.Capacity, out length, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformBlockName

        public static string GetActiveUniformBlockName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformBlockMaxNameLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveUniformBlockName(program, uniformIndex, sb.Capacity, out length, sb);
            return sb.ToString();
        }

        #endregion

        #region public static void ShaderSource(Int32 shader, System.String @string)

        public static void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                GL.ShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
        }

        #endregion

        #region public static string GetShaderInfoLog(Int32 shader)

        public static string GetShaderInfoLog(Int32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        #endregion

        #region public static void GetShaderInfoLog(Int32 shader, out string info)

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
                StringBuilder sb = new StringBuilder(length * 2);
                GL.GetShaderInfoLog((UInt32)shader, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #region public static string GetProgramInfoLog(Int32 program)

        public static string GetProgramInfoLog(Int32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        #endregion

        #region public static void GetProgramInfoLog(Int32 program, out string info)

        public static void GetProgramInfoLog(Int32 program, out string info)
        {
            unsafe
            {
                int length;
                GL.GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.InfoLogLength, out length); if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length * 2);
                GL.GetProgramInfoLog((UInt32)program, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #endregion

        #region public static void PointParameter(PointSpriteCoordOriginParameter param)

        /// <summary>
        /// Helper function that defines the coordinate origin of the Point Sprite.
        /// </summary>
        /// <param name="param">
        /// A OpenTK.Graphics.OpenGL.GL.PointSpriteCoordOriginParameter token,
        /// denoting the origin of the Point Sprite.
        /// </param>
        public static void PointParameter(PointSpriteCoordOriginParameter param)
        {
            GL.PointParameter(PointParameterName.PointSpriteCoordOrigin, (int)param);
        }

        #endregion

        #region VertexAttrib|MultiTexCoord

        [CLSCompliant(false)]
        public static void VertexAttrib2(Int32 index, ref Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        [CLSCompliant(false)]
        public static void VertexAttrib3(Int32 index, ref Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        [CLSCompliant(false)]
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

        public static void MultiTexCoord2(TextureUnit target, ref Vector2 v)
        {
            GL.MultiTexCoord2(target, v.X, v.Y);
        }

        public static void MultiTexCoord3(TextureUnit target, ref Vector3 v)
        {
            GL.MultiTexCoord3(target, v.X, v.Y, v.Z);
        }

        public static void MultiTexCoord4(TextureUnit target, ref Vector4 v)
        {
            GL.MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
        }

        [CLSCompliant(false)]
        public static void VertexAttrib2(Int32 index, ref Vector2d v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        [CLSCompliant(false)]
        public static void VertexAttrib3(Int32 index, ref Vector3d v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        [CLSCompliant(false)]
        public static void VertexAttrib4(Int32 index, ref Vector4d v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public static void VertexAttrib2(Int32 index, Vector2d v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        public static void VertexAttrib3(Int32 index, Vector3d v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(Int32 index, Vector4d v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public static void MultiTexCoord2(TextureUnit target, ref Vector2d v)
        {
            GL.MultiTexCoord2(target, v.X, v.Y);
        }

        public static void MultiTexCoord3(TextureUnit target, ref Vector3d v)
        {
            GL.MultiTexCoord3(target, v.X, v.Y, v.Z);
        }

        public static void MultiTexCoord4(TextureUnit target, ref Vector4d v)
        {
            GL.MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
        }

        #endregion

        #region Rect

        [CLSCompliant(false)]
        public static void Rect(RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        [CLSCompliant(false)]
        public static void Rect(Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        [CLSCompliant(false)]
        public static void Rect(ref RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        [CLSCompliant(false)]
        public static void Rect(ref Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        #endregion

        #region [Vertex|Normal|Index|Color|FogCoord|VertexAttrib]Pointer

        public static void VertexPointer(int size, VertexPointerType type, int stride, int offset)
        {
            VertexPointer(size, type, stride, (IntPtr)offset);
        }

        public static void NormalPointer(NormalPointerType type, int stride, int offset)
        {
            NormalPointer(type, stride, (IntPtr)offset);
        }

        public static void IndexPointer(IndexPointerType type, int stride, int offset)
        {
            IndexPointer(type, stride, (IntPtr)offset);
        }

        public static void ColorPointer(int size, ColorPointerType type, int stride, int offset)
        {
            ColorPointer(size, type, stride, (IntPtr)offset);
        }

        public static void FogCoordPointer(FogPointerType type, int stride, int offset)
        {
            FogCoordPointer(type, stride, (IntPtr)offset);
        }

        public static void EdgeFlagPointer(int stride, int offset)
        {
            EdgeFlagPointer(stride, (IntPtr)offset);
        }

        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, int offset)
        {
            TexCoordPointer(size, type, stride, (IntPtr)offset);
        }

        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        #endregion

        #region Get[Float|Double]

        public static void GetFloat(GetPName pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Matrix4 matrix)
        {
            unsafe
            {
                fixed (Matrix4* ptr = &matrix)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector2d vector)
        {
            unsafe
            {
                fixed (Vector2d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector3d vector)
        {
            unsafe
            {
                fixed (Vector3d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector4d vector)
        {
            unsafe
            {
                fixed (Vector4d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Matrix4d matrix)
        {
            unsafe
            {
                fixed (Matrix4d* ptr = &matrix)
                    GetDouble(pname, (double*)ptr);
            }
        }

        #endregion

        #region Viewport

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
#if NO_SYSDRAWING
        public static void Viewport(OpenTK.Point location, OpenTK.Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(OpenTK.Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#endif
        #endregion

        #region TexEnv

        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color color)
        {
            Color4 c = new Color4(color.R, color.G, color.B, color.A);
            unsafe
            {
                TexEnv(target, pname, &c.R);
            }
        }

        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color4 color)
        {
            unsafe
            {
                TexEnv(target, pname, &color.R);
            }
        }

        #endregion

        #region Obsolete

        [Obsolete("Use DisableClientState(ArrayCap) instead")]
        public static void DisableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
        {
            DisableClientState((ArrayCap)array);
        }

        [Obsolete("Use EnableClientState(ArrayCap) instead.")]
        public static void EnableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
        {
            EnableClientState((ArrayCap)array);
        }

        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(Int32 program, Int32 uniformCount, Int32[] uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32[] @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(Int32 program, Int32 uniformCount, ref Int32 uniformIndices, ArbUniformBufferObject pname, [OutAttribute] out Int32 @params)
        {
            GetActiveUniforms(program, uniformCount, ref uniformIndices, (ActiveUniformParameter)pname, out @params);
        }

        [System.CLSCompliant(false)]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static unsafe void GetActiveUniforms(Int32 program, Int32 uniformCount, Int32* uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32* @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [System.CLSCompliant(false)]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(UInt32 program, Int32 uniformCount, UInt32[] uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32[] @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [System.CLSCompliant(false)]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(UInt32 program, Int32 uniformCount, ref UInt32 uniformIndices, ArbUniformBufferObject pname, [OutAttribute] out Int32 @params)
        {
            GetActiveUniforms(program, uniformCount, ref uniformIndices, (ActiveUniformParameter)pname, out @params);
        }

        [System.CLSCompliant(false)]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static unsafe void GetActiveUniforms(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32* @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [Obsolete("Use strongly-typed overload instead")]
		public static void GetBufferParameteri64(Version32 target, Version32 pname, [OutAttribute] Int64[] @params)
        {
            GL.GetBufferParameter((BufferTarget)target, (BufferParameterName)pname, @params);
        }

        [Obsolete("Use strongly-typed overload instead")]
		public static void GetBufferParameteri64(Version32 target, Version32 pname, out Int64 @params)
        {
            GL.GetBufferParameter((BufferTarget)target, (BufferParameterName)pname, out @params);
        }

        [Obsolete("Use strongly-typed overload instead")]
		[CLSCompliant(false)]
		public static unsafe void GetBufferParameteri64(Version32 target, Version32 pname, [OutAttribute] Int64* @params)
        {
            GL.GetBufferParameter((BufferTarget)target, (BufferParameterName)pname, @params);
        }

        [Obsolete("Use GL.Arb.FramebufferTextureFace instead (OpenGL spec bug)")]
		public static void FramebufferTextureFace(Version32 target, Version32 attachment,
            int texture, int level, Version32 face)
        {
            Arb.FramebufferTextureFace((FramebufferTarget)target,
                (FramebufferAttachment)attachment, texture, level, (TextureTarget)face);
        }

        [Obsolete("Use GL.Arb.FramebufferTextureFace instead (OpenGL spec bug)")]
		[CLSCompliant(false)]
		public static void FramebufferTextureFace(Version32 target, Version32 attachment,
			uint texture, int level, Version32 face)
        {
            Arb.FramebufferTextureFace((FramebufferTarget)target,
                (FramebufferAttachment)attachment, texture, level, (TextureTarget)face);
        }


        public static partial class Arb
        {
            [Obsolete("Use ProgramParameter(..., AssemblyProgramParameterArb, ...) instead.")]
            public static void ProgramParameter(Int32 program, ArbGeometryShader4 pname, Int32 value)
            {
                ProgramParameter(program, (AssemblyProgramParameterArb)pname, value);
            }

            [Obsolete("Use ProgramParameter(..., AssemblyProgramParameterArb, ...) instead.")]
            [CLSCompliant(false)]
            public static void ProgramParameter(UInt32 program, ArbGeometryShader4 pname, Int32 value)
            {
                ProgramParameter(program, (AssemblyProgramParameterArb)pname, value);
            }
        }

        public static partial class Ext
        {
            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            public static void ClearNamedBufferSubData(Int32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, IntPtr data)
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(Int32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(Int32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[,] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(Int32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[,,] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(Int32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T6 data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, ref data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, IntPtr data)
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[,] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T6[,,] data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
            }

            /// <summary>[requires: EXT_direct_state_access]</summary>
            [Obsolete("Use ClearNamedBufferSubData(..., format, type, data) instead.")]
            [CLSCompliant(false)]
            public static void ClearNamedBufferSubData<T6>(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T6 data)
                where T6 : struct
            {
                ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, ref data);
            }

            [Obsolete("Use ProgramParameter(..., AssemblyProgramParameterArb, ...) instead.")]
            public static void ProgramParameter(Int32 program, ExtGeometryShader4 pname, Int32 value)
            {
                ProgramParameter(program, (AssemblyProgramParameterArb)pname, value);
            }

            [Obsolete("Use ProgramParameter(..., AssemblyProgramParameterArb, ...) instead.")]
            [CLSCompliant(false)]
            public static void ProgramParameter(UInt32 program, ExtGeometryShader4 pname, Int32 value)
            {
                ProgramParameter(program, (AssemblyProgramParameterArb)pname, value);
            }
        }

        #endregion

#pragma warning restore 3019
#pragma warning restore 1591
#pragma warning restore 1572
#pragma warning restore 1573

        #endregion
    }

    #pragma warning disable 1574 // XML comment cref attribute could not be resolved, compiler bug in Mono 3.4.0

    /// <summary>
    /// Defines the signature of a debug callback for 
    /// <see cref="GL.Amd.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="category">The <see cref="AmdDebugOutput"/> category for this debug message.</param>
    /// <param name="severity">The <see cref="AmdDebugOutput"/> severity for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcAmd(int id,
        AmdDebugOutput category, AmdDebugOutput severity,
        int length, IntPtr message, IntPtr userParam);

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
