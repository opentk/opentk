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

        // Using a dictionary as a hacky set, values always null.
        static readonly Dictionary<string, object> CoreFunctions = 
            new Dictionary<string, object>();
        
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
            if (IsGL11(function_string))
            {
                return Functions.GetProcAddress(WinFactory.OpenGLHandle, function_string);
            }
            else
            {
                return Wgl.GetProcAddress(function_string);
            }
        }

        #endregion

        #region Private Members

        static bool IsGL11(string function_string)
        {
            // This method previously used the code at
            // https://www.opengl.org/wiki/Load_OpenGL_Functions
            // But see https://github.com/opentk/opentk/issues/282, users were
            // having inconsistant results, where some wgl implementations would
            // return "valid" pointers for 1.1 functions but which wouldn't work.
            // So instead we now check to see if the method is GL 1.1 based on
            // name, and use WIN32 GetProcAddress for those that pass the check.
            if (CoreFunctions.Count == 0)
            {
                CoreFunctions.Add("glCullFace", null);
                CoreFunctions.Add("glFrontFace", null);
                CoreFunctions.Add("glHint", null);
                CoreFunctions.Add("glLineWidth", null);
                CoreFunctions.Add("glPointSize", null);
                CoreFunctions.Add("glPolygonMode", null);
                CoreFunctions.Add("glScissor", null);
                CoreFunctions.Add("glTexParameterf", null);
                CoreFunctions.Add("glTexParameterfv", null);
                CoreFunctions.Add("glTexParameteri", null);
                CoreFunctions.Add("glTexParameteriv", null);
                CoreFunctions.Add("glTexImage1D", null);
                CoreFunctions.Add("glTexImage2D", null);
                CoreFunctions.Add("glDrawBuffer", null);
                CoreFunctions.Add("glClear", null);
                CoreFunctions.Add("glClearColor", null);
                CoreFunctions.Add("glClearStencil", null);
                CoreFunctions.Add("glClearDepth", null);
                CoreFunctions.Add("glStencilMask", null);
                CoreFunctions.Add("glColorMask", null);
                CoreFunctions.Add("glDepthMask", null);
                CoreFunctions.Add("glDisable", null);
                CoreFunctions.Add("glEnable", null);
                CoreFunctions.Add("glFinish", null);
                CoreFunctions.Add("glFlush", null);
                CoreFunctions.Add("glBlendFunc", null);
                CoreFunctions.Add("glLogicOp", null);
                CoreFunctions.Add("glStencilFunc", null);
                CoreFunctions.Add("glStencilOp", null);
                CoreFunctions.Add("glDepthFunc", null);
                CoreFunctions.Add("glPixelStoref", null);
                CoreFunctions.Add("glPixelStorei", null);
                CoreFunctions.Add("glReadBuffer", null);
                CoreFunctions.Add("glReadPixels", null);
                CoreFunctions.Add("glGetBooleanv", null);
                CoreFunctions.Add("glGetDoublev", null);
                CoreFunctions.Add("glGetError", null);
                CoreFunctions.Add("glGetFloatv", null);
                CoreFunctions.Add("glGetIntegerv", null);
                CoreFunctions.Add("glGetString", null);
                CoreFunctions.Add("glGetTexImage", null);
                CoreFunctions.Add("glGetTexParameterfv", null);
                CoreFunctions.Add("glGetTexParameteriv", null);
                CoreFunctions.Add("glGetTexLevelParameterfv", null);
                CoreFunctions.Add("glGetTexLevelParameteriv", null);
                CoreFunctions.Add("glIsEnabled", null);
                CoreFunctions.Add("glDepthRange", null);
                CoreFunctions.Add("glViewport", null);
                CoreFunctions.Add("glDrawArrays", null);
                CoreFunctions.Add("glDrawElements", null);
                CoreFunctions.Add("glGetPointerv", null);
                CoreFunctions.Add("glPolygonOffset", null);
                CoreFunctions.Add("glCopyTexImage1D", null);
                CoreFunctions.Add("glCopyTexImage2D", null);
                CoreFunctions.Add("glCopyTexSubImage1D", null);
                CoreFunctions.Add("glCopyTexSubImage2D", null);
                CoreFunctions.Add("glTexSubImage1D", null);
                CoreFunctions.Add("glTexSubImage2D", null);
                CoreFunctions.Add("glBindTexture", null);
                CoreFunctions.Add("glDeleteTextures", null);
                CoreFunctions.Add("glGenTextures", null);
                CoreFunctions.Add("glIsTexture", null);
            }
            return CoreFunctions.ContainsKey(function_string);
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
