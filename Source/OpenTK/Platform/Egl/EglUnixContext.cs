#region License
//
// EglUnixContext.cs
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
using System.Diagnostics;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    class EglUnixContext : EglContext
    {
        IntPtr ES1 = OpenTK.Platform.X11.DL.Open("libGLESv1_CM", X11.DLOpenFlags.Lazy);
        IntPtr ES2 = OpenTK.Platform.X11.DL.Open("libGLESv2", X11.DLOpenFlags.Lazy);
        IntPtr GL = OpenTK.Platform.X11.DL.Open("libGL", X11.DLOpenFlags.Lazy);

        public EglUnixContext(GraphicsMode mode, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(mode, window, sharedContext, major, minor, flags)
        {
        }

        public EglUnixContext(ContextHandle handle, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(handle, window, sharedContext, major, minor, flags)
        {
        }

        protected override IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable)
        {
            if ((renderable & RenderableFlags.ES) != 0 && ES1 != IntPtr.Zero)
            {
                return X11.DL.Symbol(ES1, function);
            }
            else if ((renderable & RenderableFlags.ES2) != 0 && ES2 != IntPtr.Zero)
            {
                return X11.DL.Symbol(ES2, function);
            }
            else if ((renderable & RenderableFlags.GL) != 0 && GL != IntPtr.Zero)
            {
                return X11.DL.Symbol(GL, function);
            }
            return IntPtr.Zero;
        }

        protected override void Dispose(bool manual)
        {
            if (ES1 != IntPtr.Zero)
            {
                X11.DL.Close(ES1);
            }
            if (ES2 != IntPtr.Zero)
            {
                X11.DL.Close(ES2);
            }
            if (GL != IntPtr.Zero)
            {
                X11.DL.Close(GL);
            }

            GL = ES1 = ES2 = IntPtr.Zero;

            base.Dispose(manual);
        }

        public override void LoadAll()
        {
            // Modern unices can use EGL to create
            // both GL and ES contexts, so we need
            // to load all entry points. This is
            // especially true on KMS, Wayland and Mir.

            Stopwatch time = Stopwatch.StartNew();

            new OpenTK.Graphics.OpenGL.GL().LoadEntryPoints();
            new OpenTK.Graphics.OpenGL4.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES11.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES20.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES30.GL().LoadEntryPoints();

            Debug.Print("Bindings loaded in {0} ms.", time.Elapsed.TotalMilliseconds);
        }
    }
}
