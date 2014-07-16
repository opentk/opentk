#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2009 Novell, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

#if XAMCORE_2_0
using ObjCRuntime;
using OpenGLES;
#else
using MonoTouch.ObjCRuntime;
using MonoTouch.OpenGLES;
#endif

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
                version = (EAGLRenderingAPI)3; //EAGLRenderingAPI.OpenGLES3;
            else
                throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            if (handle.Handle == IntPtr.Zero) {
                EAGLContext = shared != null && shared.EAGLContext != null
                    ? new EAGLContext(version, shared.EAGLContext.ShareGroup)
                    : new EAGLContext(version);
                contextHandle = new ContextHandle(EAGLContext.Handle);
            } else {
                EAGLContext = (EAGLContext) Runtime.GetNSObject (handle.Handle);
                contextHandle = handle;
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
                version = (EAGLRenderingAPI)3; //EAGLRenderingAPI.OpenGLES3;
            else
                throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            EAGLContext = shared != null && shared.EAGLContext != null
                ? new EAGLContext(version, shared.EAGLContext.ShareGroup)
                : new EAGLContext(version);
            contextHandle = new ContextHandle(EAGLContext.Handle);
        }

        public void SwapBuffers()
        {
            if (!EAGLContext.PresentRenderBuffer((uint) All.RenderbufferOes))
                throw new InvalidOperationException ("EAGLContext.PresentRenderbuffer failed.");
        }

        public void MakeCurrent(IWindowInfo window)
        {
            if (!EAGLContext.SetCurrentContext(EAGLContext))
                throw new InvalidOperationException("Unable to change current EAGLContext.");
        }

        public bool IsCurrent {
            get {return EAGLContext.CurrentContext == EAGLContext;}
        }

        public bool IsDisposed {
            get {return EAGLContext == null;}
        }

        public bool VSync {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        int IGraphicsContext.SwapInterval {
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
            new Graphics.ES11.GL().LoadEntryPoints();
            new Graphics.ES20.GL().LoadEntryPoints();
            new Graphics.ES30.GL().LoadEntryPoints();
        }

        void IGraphicsContext.LoadAll ()
        {
            (this as IGraphicsContextInternal).LoadAll();
        }

        ContextHandle contextHandle;
        ContextHandle IGraphicsContextInternal.Context {
            get {return contextHandle;}
        }

        IntPtr IGraphicsContextInternal.GetAddress(string function)
        {
            throw new NotSupportedException();
        }

        IntPtr IGraphicsContextInternal.GetAddress(IntPtr function)
        {
            return MacOS.NS.GetSymbol(MacOS.NS.RuntimeLoadDefault, function);
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

