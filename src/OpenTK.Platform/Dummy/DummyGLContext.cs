/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenToolkit Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;
using System.Runtime.InteropServices;
using System.Threading;
using OpenToolkit.Core;
using OpenToolkit.Graphics;

namespace OpenToolkit.Platform.Dummy
{
    /// \internal
    /// <summary>
    ///     An empty IGraphicsContext implementation to be used inside the Visual Studio designer.
    ///     This class supports OpenToolkit, and is not intended for use by OpenToolkit programs.
    /// </summary>
    internal sealed class DummyGLContext : GraphicsContextBase
    {
        private static int handle_count;
        private readonly GraphicsContext.GetAddressDelegate Loader;
        private Thread current_thread;

        public DummyGLContext()
        {
            Handle = new ContextHandle(
                new IntPtr(Interlocked.Increment(
                    ref handle_count)));
        }

        public DummyGLContext(ContextHandle handle, GraphicsContext.GetAddressDelegate loader)
            : this()
        {
            if (handle != ContextHandle.Zero)
            {
                Handle = handle;
            }

            Loader = loader;
            Mode = new GraphicsMode(new IntPtr(2), 32, 16, 0, 0, 0, 2, false);
        }

        public override bool IsCurrent => current_thread != null && current_thread == Thread.CurrentThread;

        public override int SwapInterval { get; set; }

        public override void SwapBuffers()
        {
        }

        public override void MakeCurrent(IWindowInfo info)
        {
            var new_thread = Thread.CurrentThread;
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

        public override IntPtr GetAddress(IntPtr function)
        {
            var str = Marshal.PtrToStringAnsi(function);
            return Loader(str);
        }

        public override void Update(IWindowInfo window)
        {
        }

        public override void LoadAll()
        {
#if OPENGL
            new OpenToolkit.Graphics.OpenGL.GL().LoadEntryPoints();
            new OpenToolkit.Graphics.OpenGL4.GL().LoadEntryPoints();
            #endif
#if OPENGLES
            new OpenToolkit.Graphics.ES20.GL().LoadEntryPoints();
            new OpenToolkit.Graphics.ES30.GL().LoadEntryPoints();
            #endif
        }

        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
        }
    }
}