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
    /// An empty IGraphicsContext implementation to be used inside the Visual Studio designer.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class DummyGLContext : IGraphicsContext
    {
        WindowInfo info = new WindowInfo();
        DisplayMode mode;
        bool vsync;

        #region --- Constructors ---

        public DummyGLContext(DisplayMode m) { mode = m; }

        #endregion

        #region --- IGraphicsContext Members ---

        public IntPtr Context { get { return IntPtr.Zero; } }
        public IWindowInfo Info { get { return info; } }
        public DisplayMode Mode { get { return mode; } }

        public void CreateContext() { }
        public void CreateContext(bool direct) { }
        public void CreateContext(bool direct, IGraphicsContext source) { }

        public void SwapBuffers() { }
        public void MakeCurrent() { }
        public bool IsCurrent { get { return true; } set { } }
        public IntPtr GetCurrentContext() { return IntPtr.Zero; }

        public event DestroyEvent<IGraphicsContext> Destroy;
        void OnDestroy() { if (Destroy != null) Destroy(this, EventArgs.Empty); }

        public void RegisterForDisposal(IDisposable resource)
        {
            throw new NotImplementedException("Use the general GraphicsContext class instead.");
        }

        public void DisposeResources()
        {
            throw new NotImplementedException("Use the general GraphicsContext class instead.");
        }

        public IntPtr GetAddress(string function) { return IntPtr.Zero; }
        public IEnumerable<DisplayMode> GetDisplayModes() { return null; }

        public bool VSync { get { return vsync; } set { vsync = value; } }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose() { }

        #endregion
    }
}
