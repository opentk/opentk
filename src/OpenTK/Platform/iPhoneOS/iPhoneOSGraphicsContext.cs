#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2009 Novell, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

using ObjCRuntime;
using OpenGLES;

using OpenTK.Graphics;

namespace OpenTK.Platform.iPhoneOS {

    class iPhoneOSGraphicsContext : EmbeddedGraphicsContext
    {
        public EAGLContext EAGLContext {get; private set;}

        internal iPhoneOSGraphicsContext(ContextHandle h)
        {
            EAGLContext = (EAGLContext) Runtime.GetNSObject(h.Handle);
        }

        internal iPhoneOSGraphicsContext(ContextHandle handle, IWindowInfo window, IGraphicsContext sharedContext, int major, int minor, GraphicsContextFlags flags)
        {
            // ignore mode, window

            iPhoneOSGraphicsContext shared = sharedContext as iPhoneOSGraphicsContext;

            EAGLRenderingAPI version = 0;
            if (major == 1 && minor == 1)
                version = EAGLRenderingAPI.OpenGLES1;
            else if (major == 2 && minor == 0)
                version = EAGLRenderingAPI.OpenGLES2;
            else if (major == 3 && minor == 0)
                version = EAGLRenderingAPI.OpenGLES3;
            else
                throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            if (handle.Handle == IntPtr.Zero) {
                EAGLContext = shared != null && shared.EAGLContext != null
                    ? new EAGLContext(version, shared.EAGLContext.ShareGroup)
                    : new EAGLContext(version);
                Handle = new ContextHandle(EAGLContext.Handle);
            } else {
                EAGLContext = (EAGLContext) Runtime.GetNSObject (handle.Handle);
                Handle = handle;
            }
        }

        internal iPhoneOSGraphicsContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext sharedContext, int major, int minor, GraphicsContextFlags flags)
        {
            // ignore mode, window

            iPhoneOSGraphicsContext shared = sharedContext as iPhoneOSGraphicsContext;

            EAGLRenderingAPI version = 0;
            if (major == 1 && minor == 1)
                version = EAGLRenderingAPI.OpenGLES1;
            else if (major == 2 && minor == 0)
                version = EAGLRenderingAPI.OpenGLES2;
            else if (major == 3 && minor == 0)
                version = EAGLRenderingAPI.OpenGLES3;
            else
                throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            EAGLContext = shared != null && shared.EAGLContext != null
                ? new EAGLContext(version, shared.EAGLContext.ShareGroup)
                : new EAGLContext(version);
            Handle = new ContextHandle(EAGLContext.Handle);
        }

        public override void SwapBuffers()
        {
            if (!EAGLContext.PresentRenderBuffer((uint) OpenTK.Graphics.ES11.All.RenderbufferOes))
                throw new InvalidOperationException ("EAGLContext.PresentRenderbuffer failed.");
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            if (!EAGLContext.SetCurrentContext(window != null ? EAGLContext : null))
                throw new InvalidOperationException("Unable to change current EAGLContext.");
        }

        public override bool IsCurrent
        {
            get {return EAGLContext.CurrentContext == EAGLContext;}
        }

        public override int SwapInterval
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public override IntPtr GetAddress(IntPtr function)
        {
            return IntPtr.Zero;
        }

        public GraphicsMode GraphicsMode {get; private set;}

        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    if (EAGLContext != null)
                        EAGLContext.Dispose();
                    EAGLContext = null;
                }
                IsDisposed = true;
            }
        }

        ~iPhoneOSGraphicsContext()
        {
            Dispose(false);
        }
    }
}

