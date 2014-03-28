#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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
