#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 ��
 */
#endregion

using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace OpenTK.Platform.Windows
{
    internal partial class Wgl
    {
        #region --- Constructors ---

        static Wgl()
        {
            assembly = Assembly.GetExecutingAssembly();
            wglClass = assembly.GetType("OpenTK.Platform.Windows.Wgl");
            delegatesClass = wglClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);

            //// Ensure core entry points are ready prior to accessing any method.
            //// Resolves bug [#993]: "Possible bug in GraphicsContext.CreateDummyContext()" 
            //LoadAll();
        }

        #endregion

        #region --- Fields ---

        internal const string Library = "OPENGL32.DLL";

        private static Assembly assembly;
        private static Type wglClass;
        private static Type delegatesClass;

        private static bool rebuildExtensionList = true;

        static readonly object SyncRoot = new object();

        #endregion

        #region static Delegate LoadDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the Wgl function (eg. "wglNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        static Delegate LoadDelegate(string name, Type signature)
        {
            Delegate d = GetExtensionDelegate(name, signature);
            return d;
        }

        #endregion

        #region private static Delegate GetExtensionDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call a dynamically exported OpenGL function.
        /// </summary>
        /// <param name="name">The name of the OpenGL function (eg. "glNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function or null
        /// if the function is not available in the current OpenGL context.
        /// </returns>
        private static Delegate GetExtensionDelegate(string name, Type signature)
        {
            IntPtr address = GetProcAddress(name);

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

        #region public static void LoadAll()

        /// <summary>
        /// Loads all Wgl entry points, core and extensions.
        /// </summary>
        public static void LoadAll()
        {
            lock (SyncRoot)
            {
                OpenTK.Platform.Utilities.LoadExtensions(typeof(Wgl));
            }
        }

        #endregion

        #region public static bool Load(string function)

        /// <summary>
        /// Loads the given Wgl entry point.
        /// </summary>
        /// <param name="function">The name of the function to load.</param>
        /// <returns></returns>
        public static bool Load(string function)
        {
            return OpenTK.Platform.Utilities.TryLoadExtension(typeof(Wgl), function);
        }

        #endregion

        #region public static partial class Arb

        /// <summary>Contains ARB extensions for WGL.</summary>
        public static partial class Arb
        {
            /// <summary>
            /// Checks if a Wgl extension is supported by the given context.
            /// </summary>
            /// <param name="context">The device context.</param>
            /// <param name="ext">The extension to check.</param>
            /// <returns>True if the extension is supported by the given context, false otherwise</returns>
            public static bool SupportsExtension(WinGLContext context, string ext)
            {
                // We cache this locally, as another thread might create a context which doesn't support  this method.
                // The design is far from ideal, but there's no good solution to this issue as long as we are using
                // static WGL/GL classes. Fortunately, this issue is extremely unlikely to arise in practice, as you'd
                // have to create one accelerated and one non-accelerated context in the same application, with the
                // non-accelerated context coming second.
                Wgl.Delegates.GetExtensionsStringARB get = Wgl.Delegates.wglGetExtensionsStringARB;

                if (get != null)
                {
                    string[] extensions = null;
                    unsafe
                    {
                        extensions = new string((sbyte*)get(context.DeviceContext))
                            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    }
                    if (extensions == null || extensions.Length == 0)
                        return false;

                    foreach (string s in extensions)
                        if (s == ext)
                            return true;
                }
                return false;
            }
        }

        #endregion 

        #region public static partial class Ext

        /// <summary>Contains EXT extensions for WGL.</summary>
        public static partial class Ext
        {
            private static string[] extensions;
            /// <summary>
            /// Checks if a Wgl extension is supported by the given context.
            /// </summary>
            /// <param name="ext">The extension to check.</param>
            /// <returns>True if the extension is supported by the given context, false otherwise</returns>
            public static bool SupportsExtension(string ext)
            {
                if (Wgl.Delegates.wglGetExtensionsStringEXT != null)
                {
                    if (extensions == null || rebuildExtensionList)
                    {
                        extensions = Wgl.Ext.GetExtensionsString().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        Array.Sort(extensions);
                        rebuildExtensionList = false;
                    }

                    return Array.BinarySearch(extensions, ext) != -1;
                }
                return false;
            }
        }

        #endregion
    }
}
