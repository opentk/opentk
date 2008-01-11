#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
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
using OpenTK.OpenGL.Enums;

#endregion

[assembly: CLSCompliant(true)]

namespace OpenTK.OpenGL
{
    /// <summary>
    /// OpenGL binding for .NET, implementing OpenGL 2.1, plus extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class contains all OpenGL enums and functions defined in the 2.1 specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para>
    /// A valid OpenGL context must be created before calling any OpenGL function.
    /// </para>
    /// <para>
    /// Use the GL.Load and GL.LoadAll methods to prepare function entry points prior to use. To maintain
    /// cross-platform compatibility, this must be done for both core and extension functions. The GameWindow
    /// and the GLControl class will take care of this automatically.
    /// <para>
    /// You can use the GL.SupportsExtension method to check whether any given category of extension functions
    /// exists in the current OpenGL context. Keep in mind that different OpenGL contexts may support different
    /// extensions, and under different entry points. Always check if all required extensions are still supported
    /// when changing visuals or pixel formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL function using the GL.GetDelegate method.
    /// </para>
    /// <para>
    /// <see href="http://opengl.org/registry/"/>
    /// <seealso cref="GL.SupportsExtension"/>
    /// <seealso cref="GL.GetDelegate"/>
    /// <seealso cref="GL.LoadAll"/>
    /// <seealso cref="GL.Load"/>
    /// </para>
    /// </remarks>
    public static partial class GL
    {
        #region --- Fields ---

        internal const string Library = "opengl32.dll";

        static StringBuilder sb = new StringBuilder();
        static object gl_lock = new object();

        private static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        private static bool rebuildExtensionList;

        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;
        private static FieldInfo[] delegates;

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

        #region --- Methods ---

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

                // Search the cache for the string.
                return AvailableExtensions.ContainsKey(sb.ToString());
            }
        }

        #endregion

        #region public static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        public static Delegate GetDelegate(string name, Type signature)
        {
            MethodInfo m;
            return
                GetExtensionDelegate(name, signature) ??
                /*((m = importsClass.GetMethod(name.Substring(2), BindingFlags.Static | BindingFlags.NonPublic)) != null ?*/
                (Imports.FunctionMap.TryGetValue((name.Substring(2)), out m) ?
                Delegate.CreateDelegate(signature, m) : null);
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
            // Using reflection is more than 3 times faster than directly loading delegates on the first
            // run, probably due to code generation overhead. Subsequent runs are faster with direct loading
            // than with reflection, but the first time is more significant.

            int supported = 0;
            if (delegates == null)
            {
                delegates = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            }

            Trace.Write("GL.LoadAll(): ");

            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Reset();
            time.Start();

            foreach (FieldInfo f in delegates)
            {
                Delegate d = GetDelegate(f.Name, f.FieldType);
                if (d != null)
                {
                    ++supported;
                }

                f.SetValue(null, d);
            }
            
            time.Stop();
            Trace.WriteLine(String.Format("{0} OpenGL extensions loaded in {1} milliseconds.", supported, time.ElapsedMilliseconds));
            time.Reset();

            rebuildExtensionList = true;
        }

        static void set(object d, Delegate value)
        {
            d = value;
        }

        #endregion

        #region public static bool Load(string function)

        /// <summary>
        /// Tries to reload the given OpenGL function (core or extension).
        /// </summary>
        /// <param name="name">The name of the OpenGL function (i.e. glShaderSource)</param>
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
            Delegate @new = GetDelegate(f.Name, f.FieldType);
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                rebuildExtensionList = true;
            }
            return @new != null;
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

        #region public static bool SupportsFunction(Type function)

        /// <summary>
        /// Checks if a given OpenGL function is supported by the current context
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. glShaderSource)</param>
        /// <param name="extension">The name of the extension catagory (e.g. ARB, EXT, ATI, ...)</param>
        /// <returns>True if the function is supported, false otherwise</returns>
        public static bool SupportsFunction(MethodInfo method)
        {
            lock (gl_lock)
            {
                /*
                if (function == null)
                    throw new ArgumentNullException("function");

                sb.Remove(0, sb.Length);
                if (!function.Name.StartsWith("gl"))
                    sb.Append("gl");
                sb.Append(function);
                //if (!function.EndsWith(extension))
                //    sb.Append(extension);

                FieldInfo f = delegatesClass.GetField(sb.ToString(), BindingFlags.Static | BindingFlags.NonPublic);
                if (f == null)
                    return false;

                return f.GetValue(null) != null;
                */
                return false;
            }
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
            // We'll do some trickery to get the second number (2.1), but this may break on
            // some implementations...
            if (version_string.ToLower().Contains("mesa"))
            {
                int index = version_string.IndexOf('(');
                if (index != -1)
                    version = version_string.Substring(index + 1, 3);
                else
                    version = version_string.TrimStart(' ');
            }
            else
                version = version_string.TrimStart(' ');

            Debug.Print(version);

            if (version.StartsWith("1.2"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
            }
            else if (version.StartsWith("1.3"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
                AvailableExtensions.Add("gl_version_1_3", true);
            }
            else if (version.StartsWith("1.4"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
                AvailableExtensions.Add("gl_version_1_3", true);
                AvailableExtensions.Add("gl_version_1_4", true);
            }
            else if (version.StartsWith("1.5"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
                AvailableExtensions.Add("gl_version_1_3", true);
                AvailableExtensions.Add("gl_version_1_4", true);
                AvailableExtensions.Add("gl_version_1_5", true);
            }
            else if (version.StartsWith("2.0"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
                AvailableExtensions.Add("gl_version_1_3", true);
                AvailableExtensions.Add("gl_version_1_4", true);
                AvailableExtensions.Add("gl_version_1_5", true);
                AvailableExtensions.Add("gl_version_2_0", true);
            }
            else if (version.StartsWith("2.1"))
            {
                AvailableExtensions.Add("gl_version_1_1", true);
                AvailableExtensions.Add("gl_version_1_2", true);
                AvailableExtensions.Add("gl_version_1_3", true);
                AvailableExtensions.Add("gl_version_1_4", true);
                AvailableExtensions.Add("gl_version_1_5", true);
                AvailableExtensions.Add("gl_version_2_0", true);
                AvailableExtensions.Add("gl_version_2_1", true);
            }

            string extension_string = GL.GetString(Enums.StringName.Extensions);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ext in extensions)
                AvailableExtensions.Add(ext.ToLower(), true);

            foreach (string s in AvailableExtensions.Keys)
                Debug.Print(s);

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
        /// <param name="name">The function string for the OpenGL function (eg. "glNewList")</param>
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
        /// <see cref="Marshal.GetDelegateForFunctionPointer"/>
        /// <seealso cref="Gl.GetDelegateForExtensionMethod"/>
        /// </remarks>
        private static IntPtr GetAddress(string function)
        {
            if (getProcAddress == null)
            {
                if (System.Environment.OSVersion.Platform == PlatformID.Win32NT ||
                    System.Environment.OSVersion.Platform == PlatformID.Win32S ||
                    System.Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                    System.Environment.OSVersion.Platform == PlatformID.WinCE)
                {
                    getProcAddress = new GetProcAddressWindows();
                }
                else if (System.Environment.OSVersion.Platform == PlatformID.Unix)
                {
                    getProcAddress = new GetProcAddressX11();
                }
                else
                {
                    throw new PlatformNotSupportedException(
                        "Extension loading is only supported under X11 and Windows. We are sorry for the inconvience.");
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
            GL.ClearColor(color.R/255.0f, color.G/255.0f, color.B/255.0f, color.A/255.0f);
        }

        #endregion

        #region overloads using OpenTK.Math classes

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

		public static void MultMatrix(Matrix4 mat)
		{
			MultMatrix(ref mat.Row0.X);
		}

        public static void Materialv(MaterialFace face, MaterialParameter pname, Vector4 @params)
        {
            unsafe
            {
                Materialv(face, pname, &@params.X);
            }
        }

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
                    info = "";
                    return;
                }
                StringBuilder sb = new StringBuilder(length);
                Delegates.glGetShaderInfoLog((UInt32)shader, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #region public static void PointParameter(PointSpriteCoordOriginParameter param)

        /// <summary>
        /// Helper function that defines the coordinate origin of the Point Sprite.
        /// </summary>
        /// <param name="param">
        /// A OpenTK.OpenGL.GL.PointSpriteCoordOriginParameter token,
        /// denoting the origin of the Point Sprite.
        /// </param>
        public static void PointParameter(PointSpriteCoordOriginParameter param)
        {
            GL.PointParameter(PointParameterName.PointSpriteCoordOrigin, (int)param);
        }

        #endregion

        #endregion
    }
}
