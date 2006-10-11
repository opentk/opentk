#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenTK.OpenGL.Platform;

namespace OpenTK.OpenGL
{
    public abstract partial class GLContext : IDisposable
    {
        #region Created property
        private bool _created = false;

        public bool Created
        {
            get { return _created; }
            set { _created = value; }
        }
        #endregion

        public abstract void SwapBuffers();
        public abstract System.Delegate GetAddress(string function_string, Type function_type);
        public abstract void MakeCurrent();

        public abstract void Dispose();

        public static GLContext Create(Control c, int red, int green, int blue, int alpha, int depth, int stencil)
        {
            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT || Environment.OSVersion.Platform == PlatformID.Win32Windows)
                {
                    return new WindowsContext(c, red, green, blue, alpha, depth, stencil);
                }
                else if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
                {
                    return new WindowsVistaContext(c, red, green, blue, alpha, depth, stencil);
                }
                else if (Environment.OSVersion.Platform == PlatformID.Unix)
                {
                    return new X11Context(c, red, green, blue, alpha, depth, stencil);
                }
                else
                {
                    throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
    }
}
