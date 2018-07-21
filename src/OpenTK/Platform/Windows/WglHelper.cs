/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 ��
 */

using OpenTK.NT.Native;
using System;
using System.Collections.Generic;

namespace OpenTK.Platform.Windows
{
    internal partial class Wgl
    {
        internal const string Library = "OPENGL32.DLL";
        private static readonly IntPtr[] EntryPoints;
        private static readonly string[] EntryPointNames;

        private static readonly Dictionary<string, bool> extensions =
            new Dictionary<string, bool>();

        private static readonly object sync = new object();

        private object SyncRoot => sync;

        public static bool SupportsExtension(string name)
        {
            return SupportsExtension(GetCurrentDC(), name);
        }

        /// <summary>
        /// Checks if a Wgl extension is supported by the given context.
        /// </summary>
        /// <param name="dc">The device context.</param>
        /// <param name="name">The extension to check.</param>
        /// <returns>True if the extension is supported by the given context, false otherwise</returns>
        public static bool SupportsExtension(IntPtr dc, string name)
        {
            lock (sync)
            {
                if (extensions.Count == 0)
                {
                    // We cache this locally, as another thread might create a context which doesn't support  this method.
                    // The design is far from ideal, but there's no good solution to this issue as long as we are using
                    // static WGL/GL classes. Fortunately, this issue is extremely unlikely to arise in practice, as you'd
                    // have to create one accelerated and one non-accelerated context in the same application, with the
                    // non-accelerated context coming second.
                    var get_arb = SupportsFunction("wglGetExtensionsStringARB");
                    var get_ext = SupportsFunction("wglGetExtensionsStringEXT");
                    var str =
                        get_arb ? Arb.GetExtensionsString(dc) :
                        get_ext ? Ext.GetExtensionsString() :
                        string.Empty;

                    if (!string.IsNullOrEmpty(str))
                    {
                        foreach (var ext in str.Split(' '))
                        {
                            extensions.Add(ext, true);
                        }
                    }
                }
            }

            if (extensions.Count > 0)
            {
                return extensions.ContainsKey(name);
            }

            return false;
        }

        /// <summary>
        /// Checks whether an extension function is supported.
        /// Do not use with core WGL functions, as this function
        /// will incorrectly return false.
        /// </summary>
        /// <param name="name">The extension function to check (e.g. "wglGetExtensionsStringARB"</param>
        /// <returns>True if the extension function is supported; otherwise, false.</returns>
        public static bool SupportsFunction(string name)
        {
            var index = Array.IndexOf(EntryPointNames, name);
            if (index >= 0)
            {
                return EntryPoints[index] != IntPtr.Zero;
            }

            return false;
        }

        internal static IntPtr GetAddress(string function_string)
        {
            var address = GetProcAddress(function_string);
            if (!IsValid(address))
            {
                address = Kernel32.GetProcAddress(WinFactory.OpenGLHandle, function_string);
            }

            return address;
        }

        private static bool IsValid(IntPtr address)
        {
            // See https://www.opengl.org/wiki/Load_OpenGL_Functions
            var a = address.ToInt64();
            var is_valid = a < -1 || a > 3;
            return is_valid;
        }

        internal void LoadEntryPoints()
        {
            lock (SyncRoot)
            {
                if (GetCurrentContext() != IntPtr.Zero)
                {
                    for (var i = 0; i < EntryPointNames.Length; i++)
                    {
                        EntryPoints[i] = GetAddress(EntryPointNames[i]);
                    }

                    extensions.Clear();
                }
            }
        }
    }
}
