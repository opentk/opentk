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
using System.Threading;

using OpenTK.Graphics;

namespace OpenTK.Platform.Dummy
{
    /// \internal
    /// <summary>
    /// An empty IGraphicsContext implementation to be used inside the Visual Studio designer.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class DummyGLContext : DesktopGraphicsContext
    {
        // This mode is not real. To receive a real mode we'd have to create a temporary context, which is not desirable!
        bool vsync;
        static int handle_count;
        Thread current_thread;

        #region --- Constructors ---

        public DummyGLContext()
            : this(new ContextHandle(new IntPtr(++handle_count)))
        {
            Mode = new GraphicsMode(new IntPtr(2), 32, 16, 0, 0, 0, 2, false);
        }
        
        public DummyGLContext(ContextHandle handle)
        {
            Handle = handle;
        }

        #endregion

        #region --- IGraphicsContext Members ---

        public void CreateContext(bool direct, IGraphicsContext source)
        {
            if (Handle == ContextHandle.Zero)
            {
                ++handle_count;
                Handle = new ContextHandle((IntPtr)handle_count);
            }
        }

        public override void SwapBuffers() { }

        public override void MakeCurrent(IWindowInfo info)
        {
            Thread new_thread = Thread.CurrentThread;
            // A context may be current only on one thread at a time.
            if (current_thread != null && new_thread != current_thread)
            {
                throw new GraphicsContextException(
                    "Cannot make context current on two threads at the same time");
            }

            if (info != null)
            {
                current_thread = Thread.CurrentThread;
            }
            else
            {
                current_thread = null;
            }
        }

        public override bool IsCurrent
        {
            get { return current_thread != null && current_thread == Thread.CurrentThread; }
        }

        public override IntPtr GetAddress(string function) { return IntPtr.Zero; }

        public override bool VSync { get { return vsync; } set { vsync = value; } }

        public override void Update(IWindowInfo window)
        { }

        public override void LoadAll()
        { }

        #endregion

        #region --- IDisposable Members ---

        public override void Dispose() { IsDisposed = true; }

        #endregion
    }
}
