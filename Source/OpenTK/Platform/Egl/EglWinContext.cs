// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    class EglWinContext : EglContext
    {
        IntPtr ES1 = OpenTK.Platform.Windows.Functions.LoadLibrary("libGLESv1_CM");
        IntPtr ES2 = OpenTK.Platform.Windows.Functions.LoadLibrary("libGLESv2");

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
            if ((renderable & (RenderableFlags.ES2 | RenderableFlags.ES3)) != 0 && ES2 != IntPtr.Zero)
            {
                return Windows.Functions.GetProcAddress(ES2, function);
            }
            else if ((renderable & RenderableFlags.ES) != 0 && ES1 != IntPtr.Zero)
            {
                return Windows.Functions.GetProcAddress(ES1, function);
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

            ES1 = ES2 = IntPtr.Zero;

            base.Dispose(manual);
        }

        #endregion
    }
}