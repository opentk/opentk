// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    class DummyGLControl : IGLControl
    {
        #region IGLControl Members

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new DummyContext();
        }

        public bool IsIdle
        {
            get { return false; }
        }

        public IWindowInfo WindowInfo
        {
            get { return Utilities.CreateDummyWindowInfo(); }
        }

        #endregion

        #region class DummyContext

        class DummyContext : IGraphicsContext, IGraphicsContextInternal
        {
            static int instance_count;

            readonly ContextHandle handle = new ContextHandle(new IntPtr(
                System.Threading.Interlocked.Increment(ref instance_count)));

            IWindowInfo current_window;
            bool is_disposed;
            int swap_interval;

            #region IGraphicsContext Members

            public void SwapBuffers()
            {
            }

            public void MakeCurrent(IWindowInfo window)
            {
                current_window = window;
            }

            public bool IsCurrent
            {
                get { return current_window != null; }
            }

            public bool IsDisposed
            {
                get { return is_disposed; }
            }

            public bool VSync
            {
                get
                {
                    return SwapInterval != 0;
                }
                set
                {
                    SwapInterval = value ? 1 : 0;
                }
            }

            public int SwapInterval
            {
                get
                {
                    return swap_interval;
                }
                set
                {
                    swap_interval = value;
                }
            }

            public void Update(IWindowInfo window)
            {
            }

            public GraphicsMode GraphicsMode
            {
                get { return GraphicsMode.Default; }
            }

            public bool ErrorChecking
            {
                get
                {
                    return false;
                }
                set
                {
                }
            }

            public void LoadAll()
            {
            }

            public void Dispose()
            {
                is_disposed = true;
            }

            #endregion

            #region IGraphicsContextInternal

            public ContextHandle Context
            {
                get { return handle; }
            }

            public IntPtr GetAddress(IntPtr function)
            {
                return IntPtr.Zero;
            }

            public IntPtr GetAddress(string function)
            {
                return IntPtr.Zero;
            }

            public IGraphicsContext Implementation
            {
                get { return this; }
            }

            #endregion
        }

        #endregion
    }
}
