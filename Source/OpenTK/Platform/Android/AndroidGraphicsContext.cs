#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;

using Android.Util;
using Android.Views;
using Android.Runtime;
using Javax.Microedition.Khronos.Egl;

using OpenTK.Platform;
using OpenTK.Graphics;
using OpenTK.Graphics.ES11;

using GL11 = OpenTK.Graphics.ES11.GL;
using GL20 = OpenTK.Graphics.ES20.GL;

namespace OpenTK.Platform.Android {

	public class AndroidGraphicsContext : IGraphicsContext, IGraphicsContextInternal, IDisposable
	{
        readonly IntPtr ES1 = OpenTK.Platform.X11.DL.Open("libGLESv1_CM", X11.DLOpenFlags.Lazy);
        readonly IntPtr ES2 = OpenTK.Platform.X11.DL.Open("libGLESv2", X11.DLOpenFlags.Lazy);
        readonly int Major;

		IEGL10 egl;
		AndroidWindow window;
		bool disposed;

		public EGLContext EGLContext { get; private set; }

		public EGLConfig EGLConfig {
			get {
				if (Mode != null)
					return Mode.Config;
				return null;
			}
		}

#if OPENTK_0
		internal static AndroidGraphicsContext CreateGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, GLContextVersion glVersion, GraphicsContextFlags flags)
#else
		internal static AndroidGraphicsContext CreateGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, GLVersion glVersion, GraphicsContextFlags flags)
#endif
		{
			return new AndroidGraphicsContext(mode, window, sharedContext, glVersion, flags);
		}

		internal static AndroidGraphicsContext CreateGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, int major, int minor, GraphicsContextFlags flags)
		{
			if (major < 1 || major > 3)
				throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

			return new AndroidGraphicsContext(mode, window, sharedContext, major, minor, flags);
		}

		internal AndroidGraphicsContext(ContextHandle h)
		{
			throw new NotImplementedException ();
		}

		public AndroidGraphicsContext (GraphicsMode mode, IWindowInfo window, IGraphicsContext sharedContext,
										int major, int minor, GraphicsContextFlags flags)
		{
			if (major < 1 || major > 3)
				throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

            Major = major;
			Init (mode, window, sharedContext, major, flags);
		}

#if OPENTK_0
		public AndroidGraphicsContext (GraphicsMode mode, IWindowInfo window, IGraphicsContext sharedContext,
								GLContextVersion glesVersion, GraphicsContextFlags flags)
#else
		public AndroidGraphicsContext (GraphicsMode mode, IWindowInfo window, IGraphicsContext sharedContext,
								GLVersion glesVersion, GraphicsContextFlags flags)
#endif
		{
			int major = (int)glesVersion;
#if OPENTK_0
			major--;
#endif
			Init (mode, window, sharedContext, major, flags);
		}

		void Init (GraphicsMode mode, IWindowInfo win, IGraphicsContext sharedContext,
										int major, GraphicsContextFlags flags)
		{
			window = win as AndroidWindow;
			if (window == null)
				throw new ArgumentException ("win");

			AndroidGraphicsContext shared = sharedContext as AndroidGraphicsContext;

			egl = EGLContext.EGL.JavaCast<IEGL10> ();

			window.InitializeDisplay ();

			if (mode == null)
				mode = new GraphicsMode ();

			if (mode is AndroidGraphicsMode) {
				GraphicsMode = mode;
			} else {
				GraphicsMode = new AndroidGraphicsMode (window.Display, major, mode);
			}

			if (Mode.Config == null)
				Mode.Initialize (window.Display, major);

			/*
			 * Create an OpenGL ES context. We want to do this as rarely as possible, an
			 * OpenGL context is a somewhat heavy object.
			 */
			int EglContextClientVersion = 0x3098;
			int[] attrib_list = null;
			if (major >= 2)
				attrib_list = new int [] {EglContextClientVersion, major, EGL10.EglNone };

			EGLContext = egl.EglCreateContext (window.Display,
						EGLConfig,
						shared != null && shared.EGLContext != null ? shared.EGLContext : EGL10.EglNoContext,
						attrib_list);

			if (EGLContext == EGL10.EglNoContext)
				throw EglException.GenerateException ("EglCreateContext == EGL10.EglNoContext", egl, null);

		}

		public bool Swap ()
		{
			bool ret = egl.EglSwapBuffers (window.Display, window.Surface);
			if (!ret) {
				int err = egl.EglGetError();
				switch (err) {
					case EGL11.EglContextLost:
						throw EglContextLostException.GenerateException ("EglSwapBuffers", egl, err);
					case EGL11.EglBadAlloc:
						throw EglBadAllocException.GenerateException ("EglSwapBuffers", egl, err);
					default:
						throw EglException.GenerateException ("EglSwapBuffers", egl, err);
				}
			}
			return ret;
		}

		public void SwapBuffers()
		{
			Swap ();
		}

		int IGraphicsContext.SwapInterval {
			get {throw new NotSupportedException();}
			set {throw new NotSupportedException();}
		}

        public void MakeCurrent (IWindowInfo win)
		{
			var w = win as AndroidWindow;
			if (w == null)
				w = window;
			var surf = w.Surface;
			var ctx = EGLContext;

			if (win == null) {
				surf = EGL10.EglNoSurface;
				ctx = EGL10.EglNoContext;
			}

			if (!egl.EglMakeCurrent (window.Display, surf, surf, ctx)) {
				int err = egl.EglGetError();
				switch (err) {
					case EGL11.EglContextLost:
						throw EglContextLostException.GenerateException ("MakeCurrent", egl, err);
					case EGL11.EglBadAlloc :
						throw EglBadAllocException.GenerateException ("MakeCurrent", egl, err);
					default:
						throw EglException.GenerateException ("MakeCurrent", egl, err);
				}
			}
		}

		void DestroyContext ()
		{
			if (EGLContext != null) {
				egl.EglMakeCurrent (window.Display, EGL10.EglNoSurface, EGL10.EglNoSurface, EGL10.EglNoContext);
				egl.EglDestroyContext (window.Display, EGLContext);
				EGLContext = null;
			}
		}

		public void Update(IWindowInfo window)
		{
			MakeCurrent (null);
			MakeCurrent (window);
		}

		public void LoadAll()
		{
            #if LOGGING
            var sw = System.Diagnostics.Stopwatch.StartNew();
            #endif
            new OpenTK.Graphics.ES11.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES20.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES30.GL().LoadEntryPoints();
            #if LOGGING
            Trace.WriteLine(String.Format("[OpenTK] ES Bindings loaded in {0} ms", sw.Elapsed.TotalMilliseconds));
            #endif
		}

		IntPtr IGraphicsContextInternal.GetAddress(string function)
		{
            throw new NotSupportedException();
		}

        IntPtr GetStaticAddress(IntPtr function)
        {
            if (Major == 1 && ES1 != IntPtr.Zero)
            {
                return X11.DL.Symbol(ES1, function);
            }
            else if (Major >= 2 && ES2 != IntPtr.Zero)
            {
                return X11.DL.Symbol(ES2, function);
            }
            return IntPtr.Zero;
        }

        IntPtr IGraphicsContextInternal.GetAddress(IntPtr function)
        {
            IntPtr address = GetStaticAddress(function);
            if (address == IntPtr.Zero)
                address = Egl.Egl.GetProcAddress(function);
            return address;
        }

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing) {
					DestroyContext ();
					window = null;
					disposed = true;

                    if (ES1 != IntPtr.Zero)
                    {
                        X11.DL.Close(ES1);
                    }
                    if (ES2 != IntPtr.Zero)
                    {
                        X11.DL.Close(ES2);
                    }
				}
			}
		}

		~AndroidGraphicsContext()
		{
			Dispose(false);
		}

		public bool IsCurrent {
			get {
				return egl.EglGetCurrentContext () == EGLContext;
			}
		}

		public bool IsDisposed {
			get { return disposed; }
		}

		public bool VSync {
			get { return false; }
			set { }
		}

		public GraphicsMode GraphicsMode {
			get; private set;
		}

		AndroidGraphicsMode Mode {
			get { return GraphicsMode as AndroidGraphicsMode; }
		}

		public bool ErrorChecking {
			get { return false; }
			set { }
		}

		IGraphicsContext IGraphicsContextInternal.Implementation {
			get { return this; }
		}

		ContextHandle IGraphicsContextInternal.Context {
            get { return new ContextHandle (new IntPtr(EGLContext.GetHashCode())); }
		}
	}

	class EglException : InvalidOperationException
	{
		public static EglException GenerateException (string msg, IEGL10 egl, int? error)
		{
			if (egl == null)
				return new EglException (msg);
			error = error ?? egl.EglGetError ();
			if (error == EGL10.EglSuccess)
				return new EglException (msg);
			return new EglException (String.Format ("{0} failed with error {1} (0x{1:x})", msg, error.Value));
		}

		public EglException (string msg) : base (msg)
		{
		}
	}

	class EglContextLostException : EglException
	{
		public EglContextLostException (string msg) : base (msg)	{
		}
	}

	class EglBadAllocException : EglException
	{
		public EglBadAllocException (string msg) : base (msg) {
		}
	}

	public class AndroidWindow : IWindowInfo, IDisposable
	{
		bool disposed;
		WeakReference refHolder;

		public ISurfaceHolder Holder {
			get {
				return refHolder.Target as ISurfaceHolder;
			}
		}

		EGLDisplay eglDisplay;
		public EGLDisplay Display {
			get { return eglDisplay; }
			set {
				if (value == null && eglDisplay != null)
					TerminateDisplay ();
				eglDisplay = value;
			}
		}

		EGLSurface eglSurface;
		public EGLSurface Surface {
			get { return eglSurface; }
		}

		public AndroidWindow (ISurfaceHolder holder)
		{
			refHolder = new WeakReference (holder);
		}

		public void InitializeDisplay ()
		{
			IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();

			if (eglDisplay == null)
				eglDisplay = egl.EglGetDisplay (EGL10.EglDefaultDisplay);

			if (eglDisplay == EGL10.EglNoDisplay)
				throw EglException.GenerateException ("EglGetDisplay == EGL10.EglNoDisplay", egl, null);

			int[] version = new int[2];
			if (!egl.EglInitialize (eglDisplay, version)) {
				throw EglException.GenerateException ("EglInitialize", egl, null);
			}
		}

		public void CreateSurface (EGLConfig config)
		{
			if (refHolder == null) {
				CreatePBufferSurface (config);
				return;
			}

			IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();
			eglSurface = egl.EglCreateWindowSurface (eglDisplay, config, ((Java.Lang.Object)Holder), null);
			if (eglSurface == null || eglSurface == EGL10.EglNoSurface)
				throw EglException.GenerateException ("EglCreateWindowSurface", egl, null);
		}

		public void CreatePBufferSurface (EGLConfig config)
		{
			IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();
			eglSurface = egl.EglCreatePbufferSurface (eglDisplay, config, null);
			if (eglSurface == null || eglSurface == EGL10.EglNoSurface)
				throw EglException.GenerateException ("EglCreatePBufferSurface", egl, null);
		}

/*
		public void CreatePixmapSurface (EGLConfig config)
		{
			Surface = egl.EglCreatePixmapSurface (Display, config, null ,null);
			if (Surface == null || Surface == EGL10.EglNoSurface)
				throw EglException.GenerateException ("EglCreatePixmapSurface", egl, null);
		}
*/
		public void DestroySurface ()
		{
			if (eglSurface != EGL10.EglNoSurface) {
				IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();
				try	{
					egl.EglMakeCurrent (eglDisplay, EGL10.EglNoSurface, EGL10.EglNoSurface, EGL10.EglNoContext);
					if (!egl.EglDestroySurface (eglDisplay, eglSurface))
						Log.Warn ("AndroidWindow", "Failed to destroy surface {0}.", eglSurface);
				}
				catch (Java.Lang.IllegalArgumentException)	{
					Log.Warn ("AndroidWindow", "Failed to destroy surface {0}. Illegal Argument", eglSurface);
				}
				eglSurface = null;
			}
		}

		public void TerminateDisplay ()
		{
			if (eglDisplay != null) {
				IEGL10 egl = EGLContext.EGL.JavaCast<IEGL10> ();
				if (!egl.EglTerminate (eglDisplay))
					Log.Warn ("AndroidWindow", "Failed to terminate display {0}.", eglDisplay);
				eglDisplay = null;
			}
		}

        public IntPtr Handle
        {
            get
            {
                return Surface.Handle;
            }
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
