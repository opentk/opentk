#region License
//
// EglWinContext.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    class EglWinContext : EglContext
    {
        readonly IntPtr ES1 = OpenTK.Platform.Windows.Functions.LoadLibrary("libGLESv1_CM");
        readonly IntPtr ES2 = OpenTK.Platform.Windows.Functions.LoadLibrary("libGLESv2");

        public EglWinContext(GraphicsMode mode, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(mode, window, sharedContext, major, minor, flags)
        {
        }

        public EglWinContext(ContextHandle handle, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(handle, window, sharedContext, major, minor, flags)
        {
        }

        #region Protected Members

        protected override IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable)
        {
            if ((renderable & RenderableFlags.ES) != 0 && ES1 != IntPtr.Zero)
            {
                return Windows.Functions.GetProcAddress(ES1, function);
            }
            else if ((renderable & RenderableFlags.ES2) != 0 && ES2 != IntPtr.Zero)
            {
                return Windows.Functions.GetProcAddress(ES2, function);
            }
            return IntPtr.Zero;
        }

        protected override void Dispose(bool manual)
        {
            if (ES1 != IntPtr.Zero)
            {
                Windows.Functions.FreeLibrary(ES1);
            }
            if (ES2 != IntPtr.Zero)
            {
                Windows.Functions.FreeLibrary(ES2);
            }

            base.Dispose(manual);
        }

        #endregion
    }
}