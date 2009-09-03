#region License
/*
MIT License
Copyright ©2003-2007 Tao Framework Team
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.Reflection.Emit;
using System.IO;

#endregion

namespace Tao.OpenGl
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
    /// We rely on static initialization to obtain the entry points for OpenGL functions.
    /// Please ensure that a valid OpenGL context has been made current in the pertinent thread <b>before</b>
    /// any OpenGL functions are called (toolkits like GLUT, SDL or GLFW will automatically take care of
    /// the context initialization process). Without a valid OpenGL context, we will only be able
    /// to retrieve statically exported entry points (typically corresponding to OpenGL version 1.1 under Windows,
    /// 1.3 under Linux and 1.4 under Windows Vista), and extension methods will need to be loaded manually.
    /// </para>
    /// <para>
    /// If you prefer to have more control on extension loading, you can use the
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
    /// You may retrieve the entry point for an OpenGL function using the Gl.GetDelegate method.
    /// </para>
    /// <para>
    /// <see href="http://opengl.org/registry/"/>
    /// <seealso cref="Gl.IsExtensionSupported"/>
    /// <seealso cref="Gl.GetDelegate"/>
    /// <seealso cref="Gl.ReloadFunctions"/>
    /// </para>
    /// </remarks>
    [Obsolete("Use OpenTK.Graphics.OpenGL instead.")]
    public static partial class Gl
    {
        #region --- Fields ---

        static StringBuilder sb = new StringBuilder();
        static object gl_lock = new object();

        internal const string Library = "opengl32.dll";

        //private static Dictionary<string, bool> AvailableExtensions = new Dictionary<string, bool>();
        private static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        private static bool rebuildExtensionList;

        private static Type glClass;
        private static Type delegatesClass;
        private static Type importsClass;
        private static FieldInfo[] delegates;

        #endregion

        #region --- Static Constructor ---

        static Gl()
        {
            glClass = typeof(Gl);
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
            // 'Touch' Imports class to force initialization. We don't want anything yet, just to have
            // this class ready.
            if (Imports.FunctionMap != null) { }
            ReloadFunctions();
        }

        #endregion

        #region --- Methods ---

        #region internal static partial class Imports

        /// <summary>
        /// Contains DllImports for the core OpenGL functions.
        /// </summary>
        internal static partial class Imports
        {
            /// <summary>
            ///  Build a string->MethodInfo map to speed up extension loading.
            /// </summary>
            internal static SortedList<string, MethodInfo> FunctionMap;  // This is faster than either Dictionary or SortedDictionary
            static Imports()
            {
                MethodInfo[] methods = importsClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
                FunctionMap = new SortedList<string, MethodInfo>(methods.Length);
                foreach (MethodInfo m in methods)
                    FunctionMap.Add(m.Name, m);
            }
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
            return GetExtensionDelegate(name, signature) ??
                  (Imports.FunctionMap.TryGetValue((name.Substring(2)), out m) ?
                   Delegate.CreateDelegate(signature, m) : null);
        }

        #endregion

        #region public static void ReloadFunctions()

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
        public static void ReloadFunctions()
        {
            // Using reflection is more than 3 times faster than directly loading delegates on the first
            // run, probably due to code generation overhead. Subsequent runs are faster with direct loading
            // than with reflection, but the first time is more significant.

            if (delegates == null)
                delegates = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);

            foreach (FieldInfo f in delegates)
                f.SetValue(null, GetDelegate(f.Name, f.FieldType));

            rebuildExtensionList = true;
        }

        static void set(object d, Delegate value)
        {
            d = value;
        }

        #endregion

        #region public static bool ReloadFunction(string function)

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
            Delegate @new = GetDelegate(f.Name, f.FieldType);
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                rebuildExtensionList = true;
            }
            return @new != null;
        }

        #endregion

        #region private static void BuildExtensionList()

        /// <summary>
        /// Builds a cache of all supported extensions.
        /// </summary>
        private static void BuildExtensionList()
        {
            // Assumes there is an opengl context current.
            AvailableExtensions.Clear();
            string version_string = Gl.glGetString(Gl.GL_VERSION);
            if (String.IsNullOrEmpty(version_string))
                throw new ApplicationException("Failed to retrieve OpenGL version. Is there an opengl context current?");

            string version;

            // Most drivers return the version in the 3 first characters of the version string,
            // (e.g. on Ati X1950 with Catalyst 7.10 -> "2.0.6956 Release"). However, Mesa seems
            // to do something strange: "1.4 (2.1 Mesa 7.0.1).".
            // We'll do some trickery to get the second version number (2.1), but this may break on
            // some implementations...
            // This works on Ati, Mesa, Nvidia, but I'd like someone to test on Intel, too.
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

            // Ugh, this look ugly.
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

            string extension_string = Gl.glGetString(Gl.GL_EXTENSIONS);
            if (String.IsNullOrEmpty(extension_string))
                return;               // no extensions are available

            string[] extensions = extension_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ext in extensions)
                AvailableExtensions.Add(ext.ToLower(), true);

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
        /// <see cref="Marshal.GetDelegateForFunctionPointer"/>
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
                else if (System.Environment.OSVersion.Platform == PlatformID.Unix ||
                         System.Environment.OSVersion.Platform == (PlatformID)4)
                {
                    // Distinguish between Unix and Mac OS X kernels.
                    switch (DetectUnixKernel())
                    {
                        case "Unix":
                        case "Linux":
                            getProcAddress = new GetProcAddressX11();
                            break;

                        case "Darwin":
                            getProcAddress = new GetProcAddressOSX();
                            break;

                        default:
                            throw new PlatformNotSupportedException(
                                DetectUnixKernel() + ": Unknown Unix platform - cannot load extensions. Please report a bug at http://taoframework.com");
                    }
                }
                else
                {
                    throw new PlatformNotSupportedException(
                        "Extension loading is only supported under Mac OS X, Unix/X11 and Windows. We are sorry for the inconvience.");
                }
            }

            return getProcAddress.GetProcAddress(function);
        }

        #endregion

        #region private static string DetectUnixKernel()

        /// <summary>
        /// Executes "uname" which returns a string representing the name of the
        /// underlying Unix kernel.
        /// </summary>
        /// <returns>"Unix", "Linux", "Darwin" or null.</returns>
        /// <remarks>Source code from "Mono: A Developer's Notebook"</remarks>
        private static string DetectUnixKernel()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.Arguments = "-s";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            foreach (string unameprog in new string[] { "/usr/bin/uname", "/bin/uname", "uname" })
            {
                try
                {
                    startInfo.FileName = unameprog;
                    Process uname = Process.Start(startInfo);
                    StreamReader stdout = uname.StandardOutput;
                    return stdout.ReadLine().Trim();
                }
                catch (System.IO.FileNotFoundException)
                {
                    // The requested executable doesn't exist, try next one.
                    continue;
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    continue;
                }
            }
            return null;
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
    }
}
