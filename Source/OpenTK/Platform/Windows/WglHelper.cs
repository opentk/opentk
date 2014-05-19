#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 ��
 */
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;
using OpenTK.Graphics;

namespace OpenTK.Platform.Windows
{
    internal partial class Wgl
    {
        static IntPtr[] EntryPoints;
        static string[] EntryPointNames;

        internal const string Library = "OPENGL32.DLL";

        readonly static Dictionary<string, bool> extensions =
            new Dictionary<string, bool>();

        static readonly object sync = new object();

        public Wgl()
        {
        }

        #region Public Members

        public static bool SupportsExtension(string name)
        {
            return SupportsExtension(Wgl.GetCurrentDC(), name);
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
                    bool get_arb = SupportsFunction("wglGetExtensionsStringARB");
                    bool get_ext = SupportsFunction("wglGetExtensionsStringEXT");
                    string str =
                        get_arb ? Arb.GetExtensionsString(dc) :
                        get_ext ? Ext.GetExtensionsString() :
                        String.Empty;

                    if (!String.IsNullOrEmpty(str))
                    {
                        foreach (string ext in str.Split(' '))
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
            int index = Array.IndexOf(EntryPointNames, name);
            if (index >= 0)
            {
                return EntryPoints[index] != IntPtr.Zero;
            }
            return false;
        }

        #endregion

        #region Protected Members

        object SyncRoot
        {
            get { return sync; }
        }

        IntPtr GetAddress(string function_string)
        {
            IntPtr address = Wgl.GetProcAddress(function_string);
            if (!IsValid(address))
            {
                address = Functions.GetProcAddress(WinFactory.OpenGLHandle, function_string);
            }
            return address;
        }

        #endregion

        #region Private Members

        static bool IsValid(IntPtr address)
        {
            // See https://www.opengl.org/wiki/Load_OpenGL_Functions
            long a = address.ToInt64();
            bool is_valid = (a < -1) || (a > 3);
            return is_valid;
        }

        #endregion

        #region Internal Members

        internal void LoadEntryPoints()
        {
            lock (SyncRoot)
            {
                if (Wgl.GetCurrentContext() != IntPtr.Zero)
                {
                    for (int i = 0; i < EntryPointNames.Length; i++)
                    {
                        EntryPoints[i] = GetAddress(EntryPointNames[i]);
                    }
                    extensions.Clear();
                }
            }
        }

        #endregion
    }
}
