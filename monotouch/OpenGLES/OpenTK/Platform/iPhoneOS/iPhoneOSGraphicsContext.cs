#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2009 Novell, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.OpenGLES;

using OpenTK.Graphics;
using OpenTK.Graphics.ES11;

using GL11 = OpenTK.Graphics.ES11.GL;
using GL20 = OpenTK.Graphics.ES20.GL;

namespace OpenTK.Platform.iPhoneOS {

    public class iPhoneOSGraphicsContext : IGraphicsContext, IGraphicsContextInternal {

        public EAGLContext EAGLContext {get; private set;}

        internal iPhoneOSGraphicsContext(ContextHandle h)
        {
            EAGLContext = (EAGLContext) Runtime.GetNSObject(h.Handle);
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
            else
                throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            EAGLContext = shared != null && shared.EAGLContext != null
                ? new EAGLContext(version, shared.EAGLContext.ShareGroup)
                : new EAGLContext(version);
            contextHandle = new ContextHandle(EAGLContext.Handle);
        }

        public void SwapBuffers()
        {
            throw new NotSupportedException();
        }

        public void MakeCurrent(IWindowInfo window)
        {
            if (!EAGLContext.SetCurrentContext(EAGLContext))
                throw new InvalidOperationException("Unable to change current EAGLContext.");
        }

        public bool IsCurrent {
            get {return EAGLContext.CurrentContext == EAGLContext;}
        }

        public bool VSync {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        public void Update(IWindowInfo window)
        {
            throw new NotSupportedException();
        }

        public GraphicsMode GraphicsMode {get; private set;}

        public bool ErrorChecking {
            get {return false;}
            set {}
        }

        IGraphicsContext IGraphicsContextInternal.Implementation {
            get {return this;}
        }

        void IGraphicsContextInternal.LoadAll()
        {
            new GL11().LoadAll();
            new GL20().LoadAll();
        }

        ContextHandle contextHandle;
        ContextHandle IGraphicsContextInternal.Context {
            get {return contextHandle;}
        }

        IntPtr IGraphicsContextInternal.GetAddress(string function)
        {
            return IntPtr.Zero;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (EAGLContext != null)
                EAGLContext.Dispose();
            EAGLContext = null;
        }

        ~iPhoneOSGraphicsContext()
        {
            Dispose(false);
        }
    }
}

