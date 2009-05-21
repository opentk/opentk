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

using OpenTK.Math;

#endregion

// Add a dummy namespace to keep old code compiling.
namespace OpenTK.Graphics.OpenGL.Enums
{
    internal static class Dummy { }
}

namespace OpenTK.Graphics
{
    /// <summary>
    /// OpenGL bindings for .NET, implementing OpenGL 3.1, plus extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class contains all OpenGL enums and functions defined in the 3.1 specification.
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
    /// <seealso cref="GL.SupportsExtension"/>
    /// <seealso cref="GL.GetDelegate(string)"/>
    /// <seealso cref="GL.LoadAll"/>
    /// <seealso cref="GL.Load"/>
    public static partial class GL
    {
        delegate void VoidGLDelegate(object @class, object[] parameters);
        delegate object ObjectGLDelegate(object @class, object[] parameters);

        #region --- Fields ---

        internal const string Library = "opengl32.dll";

        static StringBuilder sb = new StringBuilder();
        static object gl_lock = new object();

        private static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        private static bool rebuildExtensionList;

        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;

        #endregion

        #region --- Constructor ---

        static GL()
        {
            glClass = typeof(GL);
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
        }

        #endregion

        #region --- Imports ---

        internal static partial class Imports
        {
            internal static SortedList<string, MethodInfo> FunctionMap;  // This is faster than either Dictionary or SortedDictionary
            static Imports()
            {
                MethodInfo[] methods = importsClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
                FunctionMap = new SortedList<string, MethodInfo>(methods.Length);
                foreach (MethodInfo m in methods)
                {
                    FunctionMap.Add(m.Name, m);
                }
            }
        }

        #endregion

        #region --- Public Members ---

        #region public static bool SupportsExtension(string name)

        /// <summary>
        /// Determines whether the specified OpenGL extension category is available in
        /// the current OpenGL context. Equivalent to IsExtensionSupported(name, true)
        /// </summary>
        /// <param name="name">The string for the OpenGL extension category (eg. "GL_ARB_multitexture")</param>
        /// <returns>True if the specified extension is available, false otherwise.</returns>
        public static bool SupportsExtension(string name)
        {
            if (rebuildExtensionList)
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

        #region public static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Returns a System.Delegate wrapping an OpenGL function.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        [Obsolete("Use GetDelegate(string name) instead.")]
        public static Delegate GetDelegate(string name, Type signature)
        {
            return LoadDelegate(name, signature);
        }

        #endregion

        #region public static void LoadAll()

        /// <summary>
        /// Loads all OpenGL functions (core and extensions).
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function will be automatically called the first time you use any opengl function. There is 
        /// </para>
        /// <para>
        /// Call this function manually whenever you need to update OpenGL entry points.
        /// This need may arise if you change the pixelformat/visual, or in case you cannot
        /// (or do not want) to use the automatic initialization of the GL class.
        /// </para>
        /// </remarks>
        public static void LoadAll()
        {
            //TODO: Route GameWindow context creation through GraphicsContext.
            //if (GraphicsContext.CurrentContext == null)
            //    throw new InvalidOperationException("You must create an OpenGL context before using the GL class.");
            if (GraphicsContext.CurrentContext != null)
                OpenTK.Platform.Utilities.LoadExtensions(glClass);
            else
                throw new InvalidOperationException("No GraphicsContext available in the calling thread.");
        }

        #endregion

        #region public static bool Load(string function)

        /// <summary>
        /// Tries to reload the given OpenGL function (core or extension).
        /// </summary>
        /// <param name="function">The name of the OpenGL function (i.e. glShaderSource)</param>
        /// <returns>True if the function was found and reloaded, false otherwise.</returns>
        /// <remarks>
        /// <para>
        /// Use this function if you require greater granularity when loading OpenGL entry points.
        /// </para>
        /// <para>
        /// While the automatic initialisation will load all OpenGL entry points, in some cases
        /// the initialisation can take place before an OpenGL Context has been established.
        /// In this case, use this function to load the entry points for the OpenGL functions
        /// you will need, or use ReloadFunctions() to load all available entry points.
        /// </para>
        /// <para>
        /// This function returns true if the given OpenGL function is supported, false otherwise.
        /// </para>
        /// <para>
        /// To query for supported extensions use the IsExtensionSupported() function instead.
        /// </para>
        /// </remarks>
        public static bool Load(string function)
        {
            FieldInfo f = delegatesClass.GetField(function, BindingFlags.Static | BindingFlags.NonPublic);
            if (f == null)
                return false;

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = LoadDelegate(f.Name, f.FieldType);
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                rebuildExtensionList = true;
            }
            return @new != null;
        }

        #endregion

        #region static Delegate LoadDelegate(string name, Type signature)

        /// <private />
        /// <summary>
        /// Loads an OpenGL function into a type-safe System.Delegate.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        static Delegate LoadDelegate(string name, Type signature)
        {
            MethodInfo m;
            return
                GetExtensionDelegate(name, signature) ??
                (Imports.FunctionMap.TryGetValue((name.Substring(2)), out m) ?
                Delegate.CreateDelegate(signature, m) : null);
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
                FieldInfo f = delegatesClass.GetField(sb.ToString(), BindingFlags.Static | BindingFlags.NonPublic);
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

            string extension_string = GL.GetString(StringName.Extensions);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ext in extensions)
                AvailableExtensions.Add(ext.Replace("_", String.Empty).ToLower(), true);

            rebuildExtensionList = false;
        }

        #endregion

        #endregion

        #region --- GetProcAddress ---

        private static IGetProcAddress getProcAddress;

        internal interface IGetProcAddress
        {
            IntPtr GetProcAddress(string function);
        }

        internal class GetProcAddressWindows : IGetProcAddress
        {
            [System.Runtime.InteropServices.DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true)]
            private static extern IntPtr wglGetProcAddress(String lpszProc);

            public IntPtr GetProcAddress(string function)
            {
                return wglGetProcAddress(function);
            }
        }

        internal class GetProcAddressX11 : IGetProcAddress
        {
            [DllImport(Library, EntryPoint = "glXGetProcAddress")]
            private static extern IntPtr glxGetProcAddress([MarshalAs(UnmanagedType.LPTStr)] string procName);

            public IntPtr GetProcAddress(string function)
            {
                return glxGetProcAddress(function);
            }
        }

        internal class GetProcAddressOSX : IGetProcAddress
        {
            private const string Library = "libdl.dylib";

            [DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
            private static extern bool NSIsSymbolNameDefined(string s);
            [DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
            private static extern IntPtr NSLookupAndBindSymbol(string s);
            [DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
            private static extern IntPtr NSAddressOfSymbol(IntPtr symbol);

            public IntPtr GetProcAddress(string function)
            {
                string fname = "_" + function;
                if (!NSIsSymbolNameDefined(fname))
                    return IntPtr.Zero;

                IntPtr symbol = NSLookupAndBindSymbol(fname);
                if (symbol != IntPtr.Zero)
                    symbol = NSAddressOfSymbol(symbol);

                return symbol;
            }
        }

        #region private static IntPtr GetAddress(string function)

        /// <summary>
        /// Retrieves the entry point for a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="function">The function string for the OpenGL function (eg. "glNewList")</param>
        /// <returns>
        /// An IntPtr contaning the address for the entry point, or IntPtr.Zero if the specified
        /// OpenGL function is not dynamically exported.
        /// </returns>
        /// <remarks>
        /// <para>
        /// The Marshal.GetDelegateForFunctionPointer method can be used to turn the return value
        /// into a call-able delegate.
        /// </para>
        /// <para>
        /// This function is cross-platform. It determines the underlying platform and uses the
        /// correct wgl, glx or agl GetAddress function to retrieve the function pointer.
        /// </para>
        /// </remarks>
        private static IntPtr GetAddress(string function)
        {
            if (getProcAddress == null)
            {
                if (Configuration.RunningOnWindows)
                {
                    getProcAddress = new GetProcAddressWindows();
                }
                else if (Configuration.RunningOnMacOS)
                {
                    getProcAddress = new GetProcAddressOSX();
                }
                else if (Configuration.RunningOnX11)
                {
                    getProcAddress = new GetProcAddressX11();
                }
                else
                {
                    throw new PlatformNotSupportedException(
                        "Extension loading is only supported under Mac OS X, X11 and Windows. We are sorry for the inconvience.");
                }
            }

            return getProcAddress.GetProcAddress(function);
        }

        #endregion

        #region internal static Delegate GetExtensionDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function or null
        /// if the function is not available in the current OpenGL context.
        /// </returns>
        internal static Delegate GetExtensionDelegate(string name, Type signature)
        {
            IntPtr address = GetAddress(name);

            if (address == IntPtr.Zero ||
                address == new IntPtr(1) ||     // Workaround for buggy nvidia drivers which return
                address == new IntPtr(2))       // 1 or 2 instead of IntPtr.Zero for some extensions.
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, signature);
            }
        }

        #endregion

        #endregion

        #region --- GL Overloads ---

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
            Delegates.glNormal3f(normal.X, normal.Y, normal.Z);
        }

        public static void RasterPos2(Vector2 pos)
        {
            Delegates.glRasterPos2f(pos.X, pos.Y);
        }

        public static void RasterPos3(Vector3 pos)
        {
            Delegates.glRasterPos3f(pos.X, pos.Y, pos.Z);
        }

        public static void RasterPos4(Vector4 pos)
        {
            Delegates.glRasterPos4f(pos.X, pos.Y, pos.Z, pos.W);
        }

        public static void Vertex2(Vector2 v)
        {
            Delegates.glVertex2f(v.X, v.Y);
        }

        public static void Vertex3(Vector3 v)
        {
            Delegates.glVertex3f(v.X, v.Y, v.Z);
        }

        public static void Vertex4(Vector4 v)
        {
            Delegates.glVertex4f(v.X, v.Y, v.Z, v.W);
        }

        public static void TexCoord2(Vector2 v)
        {
            Delegates.glTexCoord2f(v.X, v.Y);
        }

        public static void TexCoord3(Vector3 v)
        {
            Delegates.glTexCoord3f(v.X, v.Y, v.Z);
        }

        public static void TexCoord4(Vector4 v)
        {
            Delegates.glTexCoord4f(v.X, v.Y, v.Z, v.W);
        }

        public static void Rotate(Single angle, Vector3 axis)
        {
            Delegates.glRotatef((Single)angle, axis.X, axis.Y, axis.Z);
        }

        public static void Scale(Vector3 scale)
        {
            Delegates.glScalef(scale.X, scale.Y, scale.Z);
        }

        public static void Translate(Vector3 trans)
        {
            Delegates.glTranslatef(trans.X, trans.Y, trans.Z);
        }

        public static void MultMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    Delegates.glMultMatrixf((Single*)m_ptr);
                }
            }
        }

        public static void LoadMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    Delegates.glLoadMatrixf((Single*)m_ptr);
                }
            }
        }

        public static void LoadTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    Delegates.glLoadTransposeMatrixf((Single*)m_ptr);
                }
            }
        }

        public static void MultTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    Delegates.glMultTransposeMatrixf((Single*)m_ptr);
                }
            }
        }

        public static void MultMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    Delegates.glMultMatrixd((Double*)m_ptr);
                }
            }
        }

        public static void LoadMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    Delegates.glLoadMatrixd((Double*)m_ptr);
                }
            }
        }

        public static void LoadTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    Delegates.glLoadTransposeMatrixd((Double*)m_ptr);
                }
            }
        }

        public static void MultTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    Delegates.glMultTransposeMatrixd((Double*)m_ptr);
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

        #endregion

        #endregion

        #region public static void ShaderSource(Int32 shader, System.String @string)

        public static void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                Delegates.glShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
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
                StringBuilder sb = new StringBuilder(length);
                Delegates.glGetShaderInfoLog((UInt32)shader, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #region public static void GetProgramInfoLog(Int32 program, out string info)

        public static void GetProgramInfoLog(Int32 program, out string info)
        {
            unsafe
            {
                int length;
                GL.GetProgram(program, ProgramParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length);
                Delegates.glGetProgramInfoLog((UInt32)program, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

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

        #endregion
    }
}
