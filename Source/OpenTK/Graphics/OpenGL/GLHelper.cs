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

        private static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();

        #endregion

        #region --- Constructor ---

        static GL()
        {
        }

        #endregion

        #region --- Public Members ---
#if false
        #region public static bool SupportsExtension(string name)

        /// <summary>
        /// Determines whether the specified OpenGL extension category is available in
        /// the current OpenGL context. Equivalent to IsExtensionSupported(name, true)
        /// </summary>
        /// <param name="name">The string for the OpenGL extension category (eg. "GL_ARB_multitexture")</param>
        /// <returns>True if the specified extension is available, false otherwise.</returns>
        public static bool SupportsExtension(string name)
        {
            if (RebuildExtensionList)
                BuildExtensionList();

            lock (gl_lock)
            {
                sb.Remove(0, sb.Length);
                if (!name.StartsWith("GL_"))
                    sb.Append("gl_");
                sb.Append(name.ToLower());
                sb.Replace("_", String.Empty);

                // Search the cache for the string.
                return AvailableExtensions.ContainsKey(sb.ToString());
            }
        }

        #endregion

        #region public static Delegate GetDelegate(string name)

        /// <summary>
        /// Returns a System.Delegate wrapping the specified OpenGL function. You must use the
        /// base OpenGL name of the function (e.g. "glVertex3fv" instead of "Vertex3").
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function or null, if the specified
        /// function name does not correspond to an OpenGL function or if the function is not
        /// supported by the video drivers.
        /// </returns>
        public static Delegate GetDelegate(string name)
        {
            FieldInfo info = typeof(Delegates).GetField(name, BindingFlags.Static | BindingFlags.NonPublic);
            if (info == null)
                return null;
            return (Delegate)info.GetValue(null);
        }

        #endregion

        #region public static bool SupportsFunction(string function)

        /// <summary>
        /// Checks if a given OpenGL function is supported by the current context
        /// </summary>
        /// <param name="function">The name of the OpenGL function (i.e. glShaderSource)</param>
        /// <returns>True if the function is supported, false otherwise</returns>
        public static bool SupportsFunction(string function)
        {
            lock (gl_lock)
            {
                if (function == null)
                    throw new ArgumentNullException("function");

                sb.Remove(0, sb.Length);
                if (!function.StartsWith("gl"))
                    sb.Append("gl");
                sb.Append(function);
                FieldInfo f = DelegatesClass.GetField(sb.ToString(), BindingFlags.Static | BindingFlags.NonPublic);
                if (f == null)
                    return false;

                return f.GetValue(null) != null;
            }
        }

        #endregion

        #region public static bool SupportsFunction(string function, string extension)

        /// <summary>
        /// Checks if a given OpenGL function is supported by the current context
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. glShaderSource)</param>
        /// <param name="extension">The name of the extension catagory (e.g. ARB, EXT, ATI, ...)</param>
        /// <returns>True if the function is supported, false otherwise</returns>
        public static bool SupportsFunction(string function, string extension)
        {
            lock (gl_lock)
            {
                if (function == null)
                    throw new ArgumentNullException("function");
                if (extension == null)
                    throw new ArgumentNullException("extension");

                sb.Remove(0, sb.Length);
                if (!function.StartsWith("gl"))
                    sb.Append("gl");
                sb.Append(function);
                if (!function.EndsWith(extension))
                    sb.Append(extension);

                FieldInfo f = delegatesClass.GetField(sb.ToString(), BindingFlags.Static | BindingFlags.NonPublic);
                if (f == null)
                    return false;

                return f.GetValue(null) != null;
            }
        }

        #endregion

        #region static bool SupportsFunction(MethodInfo function)

        /// <summary>
        /// Checks if a given OpenGL function is supported by the current context.
        /// </summary>
        /// <param name="function">The System.Reflection.MethodInfo for the OpenGL function.</param>
        /// <returns>True if the function is supported, false otherwise.</returns>
        static bool SupportsFunction(MethodInfo function)
        {
            if (function == null)
                throw new ArgumentNullException("function");

            AutoGeneratedAttribute[] attr = (AutoGeneratedAttribute[])
                function.GetCustomAttributes(typeof(AutoGeneratedAttribute), false);
            if (attr.Length == 0)
                return false;

            return SupportsFunction(attr[0].EntryPoint);
        }

        #endregion

        #region private static void BuildExtensionList()

        /// <summary>
        /// Builds a cache of the supported extensions to speed up searches.
        /// </summary>
        private static void BuildExtensionList()
        {
            // Assumes there is an opengl context current.
            AvailableExtensions.Clear();
            string version_string = GL.GetString(StringName.Version);
            if (String.IsNullOrEmpty(version_string))
            {
                throw new ApplicationException("Failed to build extension list. Is there an opengl context current?");
            }

            string version;

            // Most drivers return the version in the 3 first characters of the version string,
            // (e.g. on Ati X1950 with Catalyst 7.10 -> "2.0.6956 Release"). However, Mesa seems
            // to do something strange: "1.4 (2.1 Mesa 7.0.1).".
            // Update: this seems to occur with indirect rendering. E.g. Ati 8.2: 1.4 (2.1.7281 ...)
            // We'll do some trickery to get the second number (2.1), but this may break on
            // some implementations...
            //if (version_string.ToLower().Contains("mesa"))
            {
                int index = version_string.IndexOf('(');
                if (index != -1)
                    version = version_string.Substring(index + 1, 3);
                else
                    version = version_string.TrimStart(' ');
            }
            //else
            //    version = version_string.TrimStart(' ');

            if (version.StartsWith("1.1"))
            {
                AvailableExtensions.Add("glversion11", true);
            }
            else if (version.StartsWith("1.2"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
            }
            else if (version.StartsWith("1.3"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
            }
            else if (version.StartsWith("1.4"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
            }
            else if (version.StartsWith("1.5"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
            }
            else if (version.StartsWith("2.0"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
                AvailableExtensions.Add("glversion20", true);
            }
            else if (version.StartsWith("2.1"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
                AvailableExtensions.Add("glversion20", true);
                AvailableExtensions.Add("glversion21", true);
            }
            else if (version.StartsWith("3.0"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
                AvailableExtensions.Add("glversion20", true);
                AvailableExtensions.Add("glversion21", true);
                AvailableExtensions.Add("glversion30", true);
            }
            else if (version.StartsWith("3.1"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
                AvailableExtensions.Add("glversion20", true);
                AvailableExtensions.Add("glversion21", true);
                AvailableExtensions.Add("glversion30", true);
                AvailableExtensions.Add("glversion31", true);
            }
            else if (version.StartsWith("3.2"))
            {
                AvailableExtensions.Add("glversion11", true);
                AvailableExtensions.Add("glversion12", true);
                AvailableExtensions.Add("glversion13", true);
                AvailableExtensions.Add("glversion14", true);
                AvailableExtensions.Add("glversion15", true);
                AvailableExtensions.Add("glversion20", true);
                AvailableExtensions.Add("glversion21", true);
                AvailableExtensions.Add("glversion30", true);
                AvailableExtensions.Add("glversion31", true);
                AvailableExtensions.Add("glversion32", true);
            }

            string extension_string = GL.GetString(StringName.Extensions);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ext in extensions)
                AvailableExtensions.Add(ext.Replace("_", String.Empty).ToLower(), true);

            //rebuildExtensionList = false;
        }

        #endregion
#endif
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

        public static void VertexPointer(int size, VertexPointerType type, int stride, int pointer)
        {
            VertexPointer(size, type, stride, (IntPtr)pointer);
        }

        public static void NormalPointer(int size, NormalPointerType type, int stride, int pointer)
        {
            NormalPointer(type, stride, (IntPtr)pointer);
        }

        public static void IndexPointer(IndexPointerType type, int stride, int pointer)
        {
            IndexPointer(type, stride, (IntPtr)pointer);
        }

        public static void ColorPointer(int size, ColorPointerType type, int stride, int pointer)
        {
            ColorPointer(size, type, stride, (IntPtr)pointer);
        }

        public static void FogCoordPointer(int size, FogPointerType type, int stride, int pointer)
        {
            FogCoordPointer(type, stride, (IntPtr)pointer);
        }

        public static void EdgeFlagPointer(int stride, int pointer)
        {
            EdgeFlagPointer(stride, (IntPtr)pointer);
        }

        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int pointer)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)pointer);
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

#pragma warning restore 3019
#pragma warning restore 1591
#pragma warning restore 1572
#pragma warning restore 1573

        #endregion
    }
}
