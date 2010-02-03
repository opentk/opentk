#region --- License ---
/* Copyright (c) 2006-2008 the OpenTK team.
 * See license.txt for license info
 * 
 * Contributions by Andy Gill.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
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

        static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        static readonly object sync_root = new object();

        #endregion

        #region --- Constructor ---

        static GL()
        {
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

        public static void Color3(System.Drawing.Color color)
        {
            GL.Color3(color.R, color.G, color.B);
        }

        public static void Color4(System.Drawing.Color color)
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

        public static void ClearColor(System.Drawing.Color color)
        {
            GL.ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            GL.ClearColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region public static void BlendColor() overloads

        public static void BlendColor(System.Drawing.Color color)
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

        #region --- Overloads for OpenTK.Math ---

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

        #endregion

        #endregion

        #region Shaders

        #region GetActiveAttrib

        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveAttributeMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveAttrib(program, index, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniform

        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformMaxLength, out length);

            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length);
            GetActiveUniform(program, uniformIndex, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformName

        public static string GetActiveUniformName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveUniformName(program, uniformIndex, sb.Capacity, out length, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformBlockName

        public static string GetActiveUniformBlockName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformBlockMaxNameLength, out length);
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
                GL.GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.InfoLogLength, out length); if (length == 0)
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

        #region public static void VertexAttrib2(Int32 index, ref Vector2 v)

        [CLSCompliant(false)]
        public static void VertexAttrib2(Int32 index, ref Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        #endregion

        #region public static void VertexAttrib3(Int32 index, ref Vector3 v)

        [CLSCompliant(false)]
        public static void VertexAttrib3(Int32 index, ref Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        #endregion

        #region public static void VertexAttrib4(Int32 index, ref Vector4 v)

        [CLSCompliant(false)]
        public static void VertexAttrib4(Int32 index, ref Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        #endregion

        #region public static void VertexAttrib2(Int32 index, Vector2 v)

        public static void VertexAttrib2(Int32 index, Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        #endregion

        #region public static void VertexAttrib3(Int32 index, Vector3 v)

        public static void VertexAttrib3(Int32 index, Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        #endregion

        #region public static void VertexAttrib4(Int32 index, Vector4 v)

        public static void VertexAttrib4(Int32 index, Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        #endregion

        #region public static void MultiTexCoord2(TextureUnit target, ref Vector2 v)

        public static void MultiTexCoord2(TextureUnit target, ref Vector2 v)
        {
            GL.MultiTexCoord2(target, v.X, v.Y);
        }

        #endregion

        #region public static void MultiTexCoord3(TextureUnit target, ref Vector3 v)

        public static void MultiTexCoord3(TextureUnit target, ref Vector3 v)
        {
            GL.MultiTexCoord3(target, v.X, v.Y, v.Z);
        }

        #endregion

        #region public static void MultiTexCoord4(TextureUnit target, ref Vector4 v)

        public static void MultiTexCoord4(TextureUnit target, ref Vector4 v)
        {
            GL.MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
        }

        #endregion

        #region public static void Rect(System.Drawing.RectangleF rect)

        public static void Rect(System.Drawing.RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        #endregion

        #region public static void Rect(ref System.Drawing.RectangleF rect)

        [CLSCompliant(false)]
        public static void Rect(ref System.Drawing.RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        #endregion

        #region public static void Rect(System.Drawing.Rectangle rect)

        public static void Rect(System.Drawing.Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        #endregion

        #region public static void Rect(ref System.Drawing.Rectangle rect)

        [CLSCompliant(false)]
        public static void Rect(ref System.Drawing.Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        #endregion

        #region public static int GenTexture()

        public static int GenTexture()
        {
            int id;
            GenTextures(1, out id);
            return id;
        }

        #endregion

        #region public static void DeleteTexture(int id)

        public static void DeleteTexture(int id)
        {
            DeleteTextures(1, ref id);
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

        #region DrawElements

        public static void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
        {
            DrawElements(mode, count, type, new IntPtr(offset));
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

        public static void Viewport(System.Drawing.Size size)
        {
            GL.Viewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(System.Drawing.Point location, System.Drawing.Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(System.Drawing.Rectangle rectangle)
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

        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, System.Drawing.Color color)
        {
            Color4 c = new Color4(color);
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

        [AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glDisableClientState")]
        [Obsolete("Use DisableClientState(ArrayCap) instead.")]
        public static void DisableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
        {
            DisableClientState((ArrayCap)array);
        }

        [AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glEnableClientState")]
        [Obsolete("Use EnableClientState(ArrayCap) instead.")]
        public static void EnableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
        {
            EnableClientState((ArrayCap)array);
        }

        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(Int32 program, Int32 uniformCount, Int32[] uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32[] @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(Int32 program, Int32 uniformCount, ref Int32 uniformIndices, ArbUniformBufferObject pname, [OutAttribute] out Int32 @params)
        {
            GetActiveUniforms(program, uniformCount, ref uniformIndices, (ActiveUniformParameter)pname, out @params);
        }

        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static unsafe void GetActiveUniforms(Int32 program, Int32 uniformCount, Int32* uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32* @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(UInt32 program, Int32 uniformCount, UInt32[] uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32[] @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static void GetActiveUniforms(UInt32 program, Int32 uniformCount, ref UInt32 uniformIndices, ArbUniformBufferObject pname, [OutAttribute] out Int32 @params)
        {
            GetActiveUniforms(program, uniformCount, ref uniformIndices, (ActiveUniformParameter)pname, out @params);
        }

        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "ArbUniformBufferObject", Version = "2.0", EntryPoint = "glGetActiveUniformsiv")]
        [Obsolete("Use GetActiveUniforms(..., ActiveUniformParameter, ...) instead.")]
        public static unsafe void GetActiveUniforms(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, ArbUniformBufferObject pname, [OutAttribute] Int32* @params)
        {
            GetActiveUniforms(program, uniformCount, uniformIndices, (ActiveUniformParameter)pname, @params);
        }

        #endregion

#pragma warning restore 3019
#pragma warning restore 1591
#pragma warning restore 1572
#pragma warning restore 1573

        #endregion
    }
}
