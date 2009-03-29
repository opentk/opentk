#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;

namespace OpenTK.Platform.Dummy
{
    /// <summary>
    /// An empty IGraphicsContext implementation to be used inside the Visual Studio designer.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class DummyGLContext : IGraphicsContext, IGraphicsContextInternal
    {
        GraphicsMode format;
        bool vsync;
        ContextHandle handle;
        static int handle_count;

        #region --- Constructors ---

        public DummyGLContext(GraphicsMode format) { this.format = format; }

        #endregion

        #region --- IGraphicsContext Members ---

        public IntPtr Context { get { return (IntPtr)handle_count; } }
        public GraphicsMode GraphicsMode { get { return format; } }

        public void CreateContext(bool direct, IGraphicsContext source)
        {
            if (handle == ContextHandle.Zero)
            {
                ++handle_count;
                handle = new ContextHandle((IntPtr)handle_count);
            }
        }

        public void SwapBuffers() { }
        public void MakeCurrent(IWindowInfo info) { }
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
        //public IEnumerable<DisplayMode> GetDisplayModes() { return null; }

        public bool VSync { get { return vsync; } set { vsync = value; } }

        public void Update(IWindowInfo window)
        {
        }

        public bool ErrorChecking
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose() { }

        #endregion

        #region IGraphicsContextInternal Members

        IGraphicsContext IGraphicsContextInternal.Implementation
        {
            get { return this; }
        }

        void IGraphicsContextInternal.LoadAll()
        {
        }

        ContextHandle IGraphicsContextInternal.Context
        {
            get { return handle; }
        }

        #endregion
    }
}
