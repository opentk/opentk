/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenTK.OpenGL.Platform;

namespace OpenTK.OpenGL
{
    public abstract partial class Context : IDisposable
    {
        public bool CoreLoaded = false;
        public bool ExtensionsLoaded = false;

        public abstract void SwapBuffers();
        public abstract System.Delegate GetAddress(string function_string, Type function_type);
        public abstract void MakeCurrent();

        public abstract void Load();
        public abstract void LoadExtensions();

        public abstract void Dispose();

        public static Context Create(Control c, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major < 6 ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                return new WindowsContext(c, red, green, blue, alpha, depth, stencil, fullscreen);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
            {
                return new WindowsVistaContext(c, red, green, blue, alpha, depth, stencil, fullscreen);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                return new X11Context(c, red, green, blue, alpha, depth, stencil, fullscreen);
            }
            else
            {
                throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
            }
        }
    }
}
