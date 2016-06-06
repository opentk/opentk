#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Runtime.InteropServices;
using Android.Util;
using Android.Views;
using Android.Runtime;
using Javax.Microedition.Khronos.Egl;

using OpenTK.Graphics;
using OpenTK.Platform.Egl;

namespace OpenTK.Platform.Android {

    class AndroidGraphicsContext : EglContext
    {
        public AndroidGraphicsContext(GraphicsMode mode, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(mode, window, sharedContext, major, minor, flags)
        {
        }

        public AndroidGraphicsContext(ContextHandle handle, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(handle, window, sharedContext, major, minor, flags)
        {
        }

        protected override IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable)
        {
            return IntPtr.Zero;
        }
    }

    public class AndroidWindow : IWindowInfo, IDisposable
    {
        bool disposed;
        WeakReference refHolder;
        private EglWindowInfo eglWindowInfo;

        // Get native window from surface
        [DllImport("android")]
        private static extern IntPtr ANativeWindow_fromSurface(IntPtr jni, IntPtr surface);

        // Get native window from surface
        [DllImport("android")]
        private static extern void ANativeWindow_release(IntPtr surface);

        public IntPtr Handle { get { return eglWindowInfo != null ? eglWindowInfo.Handle : IntPtr.Zero; } }

        public bool HasSurface
        {
            get { return eglWindowInfo.Surface != IntPtr.Zero; }
        }

        public ISurfaceHolder Holder {
            get {
                return refHolder.Target as ISurfaceHolder;
            }
        }
        public AndroidWindow (ISurfaceHolder holder)
        {
            refHolder = new WeakReference (holder);
        }

        internal EglWindowInfo CreateEglWindowInfo()
        {
            UpdateEglWindowInfo();
            return eglWindowInfo;
        }

        public void CreateSurface(IntPtr config)
        {
            UpdateEglWindowInfo();

            if (refHolder.Target == null) {
                eglWindowInfo.CreatePbufferSurface(config);
                return;
            }

            eglWindowInfo.CreateWindowSurface(config);
        }

        private void UpdateEglWindowInfo()
        {
            if (eglWindowInfo == null)
                eglWindowInfo = new EglWindowInfo(IntPtr.Zero, IntPtr.Zero);

            var newHandle = IntPtr.Zero;
            var holder = Holder;
            if (holder != null && holder.Surface != null)
            {
                newHandle = ANativeWindow_fromSurface(JNIEnv.Handle, holder.Surface.Handle);
            }

            // Do we need to recreate eglWindowInfo?
            if (eglWindowInfo != null && eglWindowInfo.Handle == newHandle)
            {
                // Same, we can release this reference
                if (newHandle != IntPtr.Zero)
                    ANativeWindow_release(newHandle);
            }
            else
            {
                DestroySurface();

                eglWindowInfo.Handle = newHandle;
            }
        }

        public void DestroySurface ()
        {
            eglWindowInfo.DestroySurface();

            // Release window handle
            if (eglWindowInfo.Handle != IntPtr.Zero)
            {
                ANativeWindow_release(eglWindowInfo.Handle);
                eglWindowInfo.Handle = IntPtr.Zero;
            }
        }

        public void TerminateDisplay ()
        {
            eglWindowInfo.TerminateDisplay();
        }

#region IDisposable Members

        public void Dispose ()
        {
            Dispose (true);
            GC.SuppressFinalize (this);
        }

        void Dispose (bool disposing)
        {
            if (!disposed)
            {
                if (disposing) {
                    DestroySurface ();
                    TerminateDisplay ();
                    refHolder = null;
                    disposed = true;
                }
            }
        }

        ~AndroidWindow ()
        {
            Dispose (false);
        }

#endregion
    }
}
