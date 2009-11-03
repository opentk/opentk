#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    partial class Glx : BindingsBase
    {
        const string Library = "libGL.so.1";
        static readonly object sync_root = new object();

        // Disable BeforeFieldInit optimization.
        static Glx() { }

        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        protected override IntPtr GetAddress (string funcname)
        {
            return Glx.GetProcAddress(funcname);
        }

#if false
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
            Delegate d;
            string realName = name.ToLower().StartsWith("glx") ? name.Substring(3) : name;

            if (typeof(Glx).GetMethod(realName,
                BindingFlags.NonPublic | BindingFlags.Static) != null)
                d = GetExtensionDelegate(name, signature) ??
                    Delegate.CreateDelegate(signature, typeof(Glx), realName);
            else
                d = GetExtensionDelegate(name, signature);

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
            IntPtr address = Glx.GetProcAddress(name);

            if (address == IntPtr.Zero ||
                address == new IntPtr(1) ||     // Workaround for buggy nvidia drivers which return
                address == new IntPtr(2))       // 1 or 2 instead of IntPtr.Zero for some extensions.
                return null;
            else
                return Marshal.GetDelegateForFunctionPointer(address, signature);
        }

        #endregion

        #region internal static void LoadAll

        public static void LoadAll()
        {
            OpenTK.Platform.Utilities.LoadExtensions(typeof(Glx));
        }

        #endregion
#endif
    }
}
