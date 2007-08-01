#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion


#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;

#endregion

[assembly: CLSCompliant(true)]

namespace OpenTK.OpenGL
{
    /// <summary>
    /// OpenGL binding for .NET, implementing OpenGL 2.1, plus extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// OpenTK.OpenGL.GL contains all OpenGL enums and functions defined in the 2.1 specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para>
    /// OpenTK.OpenGL.GL relies on static initialization to obtain the entry points for OpenGL functions.
    /// Please ensure that a valid OpenGL context has been made current in the pertinent thread <b>before</b>
    /// any OpenGL functions are called (toolkits like GLUT, SDL or GLFW will automatically take care of
    /// the context initialization process). Without a valid OpenGL context, OpenTK.OpenGL.GL will only be able
    /// to retrieve statically exported entry points (typically corresponding to OpenGL version 1.1 under Windows,
    /// 1.3 under Linux and 1.4 under Windows Vista), and extension methods will need to be loaded manually.
    /// </para>
    /// <para>
    /// If you prefer not to rely on static initialisation for the Gl class, you can use the
    /// ReloadFunctions or ReloadFunction methods to manually force the initialisation of OpenGL entry points.
    /// The ReloadFunctions method should be called whenever you change an existing visual or pixelformat. This
    /// generally happens when you change the color/stencil/depth buffer associated with a window (but probably
    /// not the resolution). This may or may not be necessary under Linux/MacOS, but is generally required for
    /// Windows.
    /// </para>
    /// <para>
    /// You can use the Gl.IsExtensionSupported method to check whether any given category of extension functions
    /// exists in the current OpenGL context. The results can be cached to speed up future searches.
    /// Keep in mind that different OpenGL contexts may support different extensions, and under different entry
    /// points. Always check if all required extensions are still supported when changing visuals or pixel
    /// formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL extension using the Gl.GetDelegateForExtensionMethod
    /// and Gl.GetFunctionPointerForExtensionMethod methods. You may retrieve the entry point for an OpenGL
    /// function using the Gl.GetDelegateForMethod method. All three methods are cross-platform.
    /// </para>
    /// <para>
    /// <see href="http://opengl.org/registry/"/>
    /// <seealso cref="Gl.IsExtensionSupported(string, bool)"/>
    /// <seealso cref="Gl.GetDelegateForExtensionMethod"/>
    /// <seealso cref="Gl.GetFunctionPointerForExtensionMethod"/>
    /// <seealso cref="Gl.GetDelegateForMethod"/>
    /// <seealso cref="Gl.ReloadFunctions"/>
    /// <seealso cref="Gl.ReloadFunction"/>
    /// </para>
    /// </remarks>
    public static partial class GL
    {
        #region internal string Library

        internal const string Library = "opengl32.dll";
        
        #endregion

        #region private enum Platform

        /// <summary>
        /// Enumerates the platforms OpenTK can run on.
        /// </summary>
        private enum Platform
        {
            Unknown,
            Windows,
            X11,
            X11_ARB,
            OSX
        };

        #endregion private enum Platform

        private static Platform platform = Platform.Unknown;
        private static System.Collections.Generic.Dictionary<string, bool> AvailableExtensions;

        #region internal static extern IntPtr glxGetProcAddressARB(string s);
        // also linux, for our ARB-y friends
        [DllImport(Library, EntryPoint = "glXGetProcAddressARB")]
        internal static extern IntPtr glxGetProcAddressARB(string s);
        #endregion

        #region internal static IntPtr aglGetProcAddress(string s)
        // osx gets complicated
        [DllImport("libdl.dylib", EntryPoint = "NSIsSymbolNameDefined")]
        internal static extern bool NSIsSymbolNameDefined(string s);
        [DllImport("libdl.dylib", EntryPoint = "NSLookupAndBindSymbol")]
        internal static extern IntPtr NSLookupAndBindSymbol(string s);
        [DllImport("libdl.dylib", EntryPoint = "NSAddressOfSymbol")]
        internal static extern IntPtr NSAddressOfSymbol(IntPtr symbol);

        internal static IntPtr aglGetProcAddress(string s)
        {
            string fname = "_" + s;
            if (!NSIsSymbolNameDefined(fname))
                return IntPtr.Zero;

            IntPtr symbol = NSLookupAndBindSymbol(fname);
            if (symbol != IntPtr.Zero)
                symbol = NSAddressOfSymbol(symbol);

            return symbol;
        }
        #endregion

        #region public static IntPtr GetFunctionPointerForExtensionMethod(string name)
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
        public static IntPtr GetFunctionPointerForExtensionMethod(string name)
        {
            IntPtr result = IntPtr.Zero;

            switch (platform)
            {
                case Platform.Unknown:
                    // WGL?
                    try
                    {
                        result = OpenTK.Platform.Windows.Wgl.GetProcAddress(name);
                        platform = Platform.Windows;
                        return result;
                    }
                    catch (Exception)
                    { }

                    // AGL? (before X11, since GLX might exist on OSX)
                    try
                    {
                        result = aglGetProcAddress(name);
                        platform = Platform.OSX;
                        return result;
                    }
                    catch (Exception)
                    { }

                    // X11?
                    try
                    {
                        result = OpenTK.Platform.X11.Glx.GetProcAddress(name);
                        platform = Platform.X11;
                        return result;
                    }
                    catch (Exception)
                    { }

                    // X11 ARB?
                    try
                    {
                        result = glxGetProcAddressARB(name);
                        platform = Platform.X11_ARB;
                        return result;
                    }
                    catch (Exception)
                    { }

                    // Ack!
                    throw new NotSupportedException(
@"Could not find out how to retrive function pointers for this platform.
Did you remember to copy OpenTK.OpenGL.dll.config to your binary's folder?
");

                case Platform.Windows:
                    return OpenTK.Platform.Windows.Wgl.GetProcAddress(name);

                case Platform.OSX:
                    return aglGetProcAddress(name);

                case Platform.X11:
                    return OpenTK.Platform.X11.Glx.GetProcAddress(name);

                case Platform.X11_ARB:
                    return glxGetProcAddressARB(name);
            }

            throw new NotSupportedException("Internal error - please report.");
        }
        #endregion public static IntPtr GetFunctionPointerForExtensionMethod(string s)

        #region public static Delegate GetDelegateForExtensionMethod(string name, Type signature)
        /// <summary>
        /// Creates a System.Delegate that can be used to call a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function or null
        /// if the function is not available in the current OpenGL context.
        /// </returns>
        public static Delegate GetDelegateForExtensionMethod(string name, Type signature)
        {
            IntPtr address = GetFunctionPointerForExtensionMethod(name);

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
        #endregion public static Delegate GetAddress(string name, Type signature)

        #region public static Delegate GetDelegateForMethod(string name, Type signature)
        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        public static Delegate GetDelegateForMethod(string name, Type signature)
        {
            Delegate d;

            if (Assembly.GetExecutingAssembly()
                .GetType("OpenTK.OpenGL.Imports")
                .GetMethod(name.Substring(2), BindingFlags.NonPublic | BindingFlags.Static) != null)
            {
                d = GetDelegateForExtensionMethod(name, signature) ??
                    Delegate.CreateDelegate(signature, typeof(Imports), name.Substring(2));
            }
            else
            {
                d = GetDelegateForExtensionMethod(name, signature);
            }

            return d;
        }
        #endregion

        #region public static bool IsExtensionSupported(string name)
        /// <summary>
        /// Determines whether the specified OpenGL extension category is available in
        /// the current OpenGL context. Equivalent to IsExtensionSupported(name, true)
        /// </summary>
        /// <param name="name">The string for the OpenGL extension category (eg. "GL_ARB_multitexture")</param>
        /// <returns>True if the specified extension is available, false otherwise.</returns>
        public static bool IsExtensionSupported(string name)
        {
            return IsExtensionSupported(name, true);
        }
        #endregion

        #region public static bool IsExtensionSupported(string name, bool useCache)
        /// <summary>
        /// Determines whether the specified OpenGL extension category is available in
        /// the current OpenGL context.
        /// </summary>
        /// <param name="name">The string for the OpenGL extension category (eg. "GL_ARB_multitexture")</param>
        /// <param name="useCache">If true, the results will be cached to speed up future results.</param>
        /// <returns>True if the specified extension is available, false otherwise.</returns>
        public static bool IsExtensionSupported(string name, bool useCache)
        {
            // Use cached results
            if (useCache)
            {
                // Build cache if it is not available
                if (AvailableExtensions == null)
                {
                    ParseAvailableExtensions();
                }

                // Search the cache for the string. Note that the cache substitutes
                // strings "1.0" to "2.1" with "GL_VERSION_1_0" to "GL_VERSION_2_1"
                if (AvailableExtensions.ContainsKey(name))
                    return AvailableExtensions[name];
                else
                    return false;
            }

            // Do not use cached results
            string extension_string = GL.GetString(GL.Enums.StringName.EXTENSIONS);
            if (String.IsNullOrEmpty(extension_string))
                return false;               // no extensions are available

            // Check if the user searches for GL_VERSION_X_X and search glGetString(GL_VERSION) instead.
            if (name.Contains("GL_VERSION_"))
            {
                return GL.GetString(OpenTK.OpenGL.GL.Enums.StringName.VERSION).Trim().StartsWith(name.Replace("GL_VERSION_", String.Empty).Replace('_', '.'));
            }

            // Search for the string given.
            string[] extensions = extension_string.Split(' ');
            foreach (string s in extensions)
            {
                if (name == s)
                    return true;
            }

            return false;
        }
        #endregion

        #region private static void ParseAvailableExtensions()
        /// <summary>
        /// Builds a cache of the supported extensions to speed up searches.
        /// </summary>
        private static void ParseAvailableExtensions()
        {
            // Assumes there is a current context.

            AvailableExtensions = new Dictionary<string, bool>();

            string version_string = GL.GetString(OpenTK.OpenGL.GL.Enums.StringName.VERSION);
            if (String.IsNullOrEmpty(version_string))
                return;               // this shoudn't happen

            string version = version_string.Trim(' ');

            if (version.StartsWith("1.2"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
            }
            else if (version.StartsWith("1.3"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
                AvailableExtensions.Add("GL_VERSION_1_3", true);
            }
            else if (version.StartsWith("1.4"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
                AvailableExtensions.Add("GL_VERSION_1_3", true);
                AvailableExtensions.Add("GL_VERSION_1_4", true);
            }
            else if (version.StartsWith("1.5"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
                AvailableExtensions.Add("GL_VERSION_1_3", true);
                AvailableExtensions.Add("GL_VERSION_1_4", true);
                AvailableExtensions.Add("GL_VERSION_1_5", true);
            }
            else if (version.StartsWith("2.0"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
                AvailableExtensions.Add("GL_VERSION_1_3", true);
                AvailableExtensions.Add("GL_VERSION_1_4", true);
                AvailableExtensions.Add("GL_VERSION_1_5", true);
                AvailableExtensions.Add("GL_VERSION_2_0", true);
            }
            else if (version.StartsWith("2.1"))
            {
                AvailableExtensions.Add("GL_VERSION_1_2", true);
                AvailableExtensions.Add("GL_VERSION_1_3", true);
                AvailableExtensions.Add("GL_VERSION_1_4", true);
                AvailableExtensions.Add("GL_VERSION_1_5", true);
                AvailableExtensions.Add("GL_VERSION_2_0", true);
                AvailableExtensions.Add("GL_VERSION_2_1", true);
            }

            string extension_string = GL.GetString(OpenTK.OpenGL.GL.Enums.StringName.EXTENSIONS);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(' ');
            foreach (string ext in extensions)
            {
                AvailableExtensions.Add(ext, true);
            }
        }
        #endregion

        #region public static void ReloadFunctions()
        /// <summary>
        /// Reloads all OpenGL functions (core and extensions).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Call this function to reload all OpenGL entry points. This should be done 
        /// whenever you change the pixelformat/visual, or in the case you cannot (or do not want)
        /// to use the automatic initialisation.
        /// </para>
        /// <para>
        /// Calling this function before the automatic initialisation has taken place will result
        /// in the Gl class being initialised twice. This is harmless, but given the automatic
        /// initialisation should be preferred.
        /// </para>
        /// </remarks>
        public static void ReloadFunctions()
        {
            Assembly asm = Assembly.GetExecutingAssembly();//Assembly.Load("OpenTK.OpenGL");
            Type delegates_class = asm.GetType("OpenTK.OpenGL.Delegates");
            Type imports_class = asm.GetType("OpenTK.OpenGL.Imports");

            FieldInfo[] v = delegates_class.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in v)
            {
                f.SetValue(null, GetDelegateForMethod(f.Name, f.FieldType));
            }

            ParseAvailableExtensions();
        }
        #endregion

        #region public static bool ReloadFunction(string name)
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
        /// This function will return true if the given OpenGL function exists, false otherwise.
        /// A return value of "true" does not mean that any specific OpenGL function is supported;
        /// rather it means that the string passed to this function denotes a known OpenGL function.
        /// </para>
        /// <para>
        /// To query supported extensions use the IsExtensionSupported() function instead.
        /// </para>
        /// </remarks>
        public static bool ReloadFunction(string name)
        {
            Assembly asm = Assembly.Load("OpenTK.OpenGL");
            Type delegates_class = asm.GetType("OpenTK.OpenGL.Delegates");
            Type imports_class = asm.GetType("OpenTK.OpenGL.Imports");

            FieldInfo f = delegates_class.GetField(name);
            if (f == null)
                return false;

            f.SetValue(null, GetDelegateForMethod(f.Name, f.FieldType));

            return true;
        }
        #endregion
    }
}
