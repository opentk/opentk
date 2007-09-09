#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// An empty IGLContext implementation to be used inside the Visual Studio designer.
    /// </summary>
    internal sealed class DummyGLContext : IGLContext
    {
        WindowInfo info = new WindowInfo();
        DisplayMode mode = new DisplayMode();

        #region --- IGLContext Members ---

        public IntPtr Context { get { return IntPtr.Zero; } }
        public IWindowInfo Info { get { return info; } }
        public DisplayMode Mode { get { return mode; } }

        public void CreateContext() { }
        public void CreateContext(bool direct) { }
        public void CreateContext(bool direct, IGLContext source) { }

        public void SwapBuffers() { }
        public void MakeCurrent() { }

        public IntPtr GetAddress(string function) { return IntPtr.Zero; }
        public IEnumerable<DisplayMode> GetDisplayModes() { return null; }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose() { }

        #endregion
    }
}
