/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 *
 * Date: 12/8/2007
 * Time: 6:43 ��
 */

using System;
using System.Diagnostics;

namespace OpenTK.Graphics.Wgl
{
    public partial class Wgl
    {
        private static IntPtr[] EntryPoints;
        private static string[] EntryPointNames;

        internal const string Library = "OPENGL32.DLL";

        /// <summary>
        /// Loads all the available bindings for the current context.
        /// </summary>
        /// <param name="context">The context used to query the available bindings.</param>
        /// <remarks>
        /// Loads all available entry points for the current OpenGL context.
        /// </remarks>
        public static void LoadBindings(IBindingsContext context)
        {
            Debug.Print("Loading entry points for {0}", typeof(Wgl).FullName);
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            for (int i = 0; i < EntryPoints.Length; i++)
            {
                EntryPoints[i] = context.GetProcAddress(EntryPointNames[i]);
            }
        }
    }
}
