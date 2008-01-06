#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 μμ
 */
#endregion

using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace OpenTK.Platform.Windows
{
	/// <summary>
	/// 
	/// </summary>
	internal partial class Wgl
    {
        #region --- Constructors ---

        static Wgl()
        {
            assembly = Assembly.GetExecutingAssembly();
            wglClass = assembly.GetType("OpenTK.Platform.Windows.Wgl");
            delegatesClass = wglClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = wglClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);

            //LoadAll();
        }

        #endregion

        #region --- Fields ---

        internal const string Library = "OPENGL32.DLL";

        private static Assembly assembly;
        private static Type wglClass;
        private static Type delegatesClass;
        private static Type importsClass;

        private static bool reload_ext_extension_strings = true;
        private static bool reload_arb_extension_strings = true;

        #endregion

        #region public static Delegate GetDelegate(string name, Type signature)

        /// <summary>
        /// Creates a System.Delegate that can be used to call an OpenGL function, core or extension.
        /// </summary>
        /// <param name="name">The name of the Wgl function (eg. "wglNewList")</param>
        /// <param name="signature">The signature of the OpenGL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenGL function, or null if the specified
        /// function name did not correspond to an OpenGL function.
        /// </returns>
        public static Delegate GetDelegate(string name, Type signature)
        {
            Delegate d;
            string realName = name.StartsWith("wgl") ? name.Substring(3) : name;

            if (importsClass.GetMethod(realName,
                BindingFlags.NonPublic | BindingFlags.Static) != null)
            {
                d = GetExtensionDelegate(name, signature) ??
                    Delegate.CreateDelegate(signature, typeof(Imports), realName);
            }
            else
            {
                d = GetExtensionDelegate(name, signature);
            }

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
            IntPtr address = Imports.GetProcAddress(name);

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
            FieldInfo[] v = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in v)
            {
                f.SetValue(null, GetDelegate(f.Name, f.FieldType));
            }
            reload_ext_extension_strings = true;
            reload_arb_extension_strings = true;
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
            FieldInfo f = delegatesClass.GetField(function, BindingFlags.Static | BindingFlags.NonPublic);
            if (f == null)
                return false;

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = GetDelegate(f.Name, f.FieldType);

            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
                if (function.EndsWith("EXT"))
                    reload_ext_extension_strings = true; 
                else if (function.EndsWith("ARB"))
                    reload_arb_extension_strings = true; 
            }
            return @new != null;
        }

        #endregion

        #region public static partial class Ext
#if false
        public static partial class Ext
        {
            private static string[] extensions;

            /// <summary>
            /// Checks if an "ARB" extension is supported by the given context.
            /// </summary>
            /// <param name="deviceContext">The device context.</param>
            /// <param name="ext">The extension to check.</param>
            /// <returns>True if the extension is supported by the given context, false otherwise</returns>
            public static bool SupportsExtension(IntPtr deviceContext, string ext)
            {
                if (Wgl.Delegates.wglGetExtensionsStringEXT != null)
                {
                    if (extensions == null || reload_arb_extension_strings)
                    {
                        // Defined wrong in wglext.spec...
                        extensions = Wgl.Ext.GetExtensionsString(deviceContext).Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        Array.Sort(extensions);
                        reload_arb_extension_strings = false;
                    }

                    return Array.BinarySearch(extensions, ext) != -1;
                }
                return false;
            }
        }
#endif
        #endregion

        internal static partial class Arb
        {
            private static string[] extensions;
            /// <summary>
            /// Checks if a Wgl extension is supported by the given context.
            /// </summary>
            /// <param name="deviceContext">The device context.</param>
            /// <param name="ext">The extension to check.</param>
            /// <returns>True if the extension is supported by the given context, false otherwise</returns>
            public static bool SupportsExtension(IntPtr deviceContext, string ext)
            {
                if (Wgl.Delegates.wglGetExtensionsStringARB != null)
                {
                    if (extensions == null || reload_arb_extension_strings)
                    {
                        extensions = Wgl.Arb.GetExtensionsString(deviceContext).Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        Array.Sort(extensions);
                        reload_arb_extension_strings = false;
                    }

                    return Array.BinarySearch(extensions, ext) != -1;
                }
                return false;
            }
        }
    }
}
