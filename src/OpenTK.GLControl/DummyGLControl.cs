﻿//
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

using System;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    internal class DummyGLControl : IGLControl
    {
        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new DummyContext();
        }

        public bool IsIdle => false;

        public IWindowInfo WindowInfo => Utilities.CreateDummyWindowInfo();

        private class DummyContext : IGraphicsContext, IGraphicsContextInternal
        {
            private static int instance_count;

            private IWindowInfo current_window;

            public void SwapBuffers()
            {
            }

            public void MakeCurrent(IWindowInfo window)
            {
                current_window = window;
            }

            public bool IsCurrent => current_window != null;

            public bool IsDisposed { get; private set; }

            public bool VSync
            {
                get => SwapInterval != 0;
                set => SwapInterval = value ? 1 : 0;
            }

            public int SwapInterval { get; set; }

            public void Update(IWindowInfo window)
            {
            }

            public GraphicsMode GraphicsMode => GraphicsMode.Default;

            public bool ErrorChecking
            {
                get => false;
                set
                {
                }
            }

            public void LoadAll()
            {
            }

            public void Dispose() => IsDisposed = true;

            public ContextHandle Context { get; } = new ContextHandle(new IntPtr(
                System.Threading.Interlocked.Increment(ref instance_count)));

            public IntPtr GetAddress(IntPtr function) => IntPtr.Zero;

            public IntPtr GetAddress(string function) => IntPtr.Zero;

            public IGraphicsContext Implementation => this;
        }
    }
}
