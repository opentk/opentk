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

	public class AndroidGraphicsContext : IGraphicsContext, IGraphicsContextInternal
	{
		IEGL10 egl;
		EGLDisplay display;
		EGLSurface eglSurface;
		EGLConfig eglConfig;

		public EGLContext EGLContext { get; private set; }

		internal static AndroidGraphicsContext CreateGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, EAGLRenderingAPI glVersion, GraphicsContextFlags flags)
		{
			return new AndroidGraphicsContext(mode, window, sharedContext, glVersion, flags);
		}

		internal static AndroidGraphicsContext CreateGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, int major, int minor, GraphicsContextFlags flags)
		{
			EAGLRenderingAPI glVersion;
			if (major == 1)
				glVersion = EAGLRenderingAPI.OpenGLES1;
			else if (major == 2)
				glVersion = EAGLRenderingAPI.OpenGLES2;
			else
				throw new ArgumentException (string.Format("Unsupported GLES version {0}.{1}.", major, minor));

			return new AndroidGraphicsContext(mode, window, sharedContext, glVersion, flags);
		}

		internal AndroidGraphicsContext(ContextHandle h)
		{
			throw new NotImplementedException ();
		}

		internal AndroidGraphicsContext (GraphicsMode mode, IWindowInfo window,
			IGraphicsContext sharedContext, int major, int minor, GraphicsContextFlags flags) :
			this (mode, window, sharedContext, (EAGLRenderingAPI)Enum.Parse (typeof(EAGLRenderingAPI), major.ToString()), flags)
		{
		}

		internal AndroidGraphicsContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext sharedContext, EAGLRenderingAPI glesVersion, GraphicsContextFlags flags)
		{
			int major = (int)glesVersion;

			AndroidGraphicsContext shared = sharedContext as AndroidGraphicsContext;

			egl = EGLContext.EGL.JavaCast<IEGL10> ();
			display = egl.EglGetDisplay(EGL10Consts.EglDefaultDisplay);
			if (display == null || display == EGL10Consts.EglNoDisplay) {
				throw new EglException ("EglGetDisplay", egl);
			}

			int[] version = new int[2];
			if (!egl.EglInitialize(display, version)) {
				throw new EglException ("EglInitialize", egl);
			}

			//FIXME: Probe and configure the RGB sizes
			int[] configSpec;
			if (major == 1) {
				configSpec = new int[] {
					/*EGL10Consts.EglRedSize, 4,
					EGL10Consts.EglGreenSize, 4,
					EGL10Consts.EglBlueSize, 4,*/
					EGL10Consts.EglDepthSize, 4,
					EGL10Consts.EglNone
				};
			} else {
				int EglOpenGLES2Bit = 4;
				configSpec = new int[] {
					/*EGL10Consts.EglRedSize, 4,
					EGL10Consts.EglGreenSize, 4,
					EGL10Consts.EglBlueSize, 4,*/
					EGL10Consts.EglDepthSize, 4,
					EGL10Consts.EglRenderableType, EglOpenGLES2Bit,
					EGL10Consts.EglNone
				};
			}

			EGLConfig[] configs = new EGLConfig[1];
			int[] num_config = new int[1];
			if (!egl.EglChooseConfig(display, configSpec, configs, 1, num_config) || num_config [0] <= 0)
				throw new EglException ("EglChooseConfig", egl);

			eglConfig = configs[0];

			/*
			 * Create an OpenGL ES context. We want to do this as rarely as possible, an
			 * OpenGL context is a somewhat heavy object.
			 */
			int EglContextClientVersion = 0x3098;
			int[] attrib_list = null;
			if (major == 2)
				attrib_list = new int [] {EglContextClientVersion, 2, EGL10Consts.EglNone };

			EGLContext = egl.EglCreateContext(display,
						eglConfig,
						shared != null && shared.EGLContext != null ? shared.EGLContext : EGL10Consts.EglNoContext,
						attrib_list);

			if (EGLContext == EGL10.EglNoContext) {
				throw new EglException ("EGL", egl);
			}

			CreateSurface (window);
		}

		internal void CreateSurface (IWindowInfo window)
		{
			if (egl == null)
				throw new InvalidOperationException ("egl not initialized");

			if (display == null)
				throw new InvalidOperationException ("display not initialized");

			if (eglConfig == null)
				throw new InvalidOperationException ("config not initialized");

			DestroySurface ();

			/*
			 * Create an EGL surface we can render into.
			 */
			SurfaceWindow sw = window as SurfaceWindow;
			eglSurface = egl.EglCreateWindowSurface(display, eglConfig, ((Java.Lang.Object)sw.Holder), null);
			if (eglSurface == null || eglSurface == EGL10.EglNoSurface) {
				int err = egl.EglGetError();
				if (err == EGL10Consts.EglBadNativeWindow) {
					Console.WriteLine ("createWindowSurface returned EGL_BAD_NATIVE_WINDOW.");
					return;
				}
				throw new EglException ("EglCreateWindowSurface", egl);
			}

			/*
			 * Before we can issue GL commands, we need to make sure
			 * the context is current and bound to a surface.
			 */
			if (!egl.EglMakeCurrent(display, eglSurface, eglSurface, EGLContext))
				throw new EglException ("EglMakeCurrent", egl);

			//FIXME: FIXME:
			//contextHandle = new ContextHandle (egl);
		}


		public bool Swap ()
		{
			bool ret = egl.EglSwapBuffers(display, eglSurface);
			if (!ret) {
				int err = egl.EglGetError();
				switch (err) {
					case EGL11Consts.EglContextLost:
					break;
					case EGL10Consts.EglBadNativeWindow:
						Console.WriteLine ("EglSwapBuffers returned EGL_BAD_NATIVE_WINDOW.");
					break;
					default:
						throw new EglException ("EglSwapBuffers", egl);
				}
			}
			return ret;
		}

		public void SwapBuffers()
		{
			Swap ();
		}

		public void MakeCurrent(IWindowInfo window)
		{
			var surf = eglSurface;
			var ctx = EGLContext;

			//FIXME: this should probably use @window param
			if (window == null) {
				surf = EGL10Consts.EglNoSurface;
				ctx = EGL10Consts.EglNoContext;
			}

			if (!egl.EglMakeCurrent(display, surf, surf, ctx)) {
				int err = egl.EglGetError();
				switch (err) {
					case EGL11Consts.EglContextLost:
					break;
					case EGL10Consts.EglBadNativeWindow:
						Console.WriteLine ("EglSwapBuffers returned EGL_BAD_NATIVE_WINDOW.");
					break;
					default:
						throw new EglException ("MakeCurrent", egl);
				}
			}
		}

		internal void DestroySurface ()
		{
			if (eglSurface != null && eglSurface != EGL10.EglNoSurface) {
				egl.EglMakeCurrent(display, EGL10Consts.EglNoSurface, EGL10Consts.EglNoSurface, EGL10Consts.EglNoContext);
				egl.EglDestroySurface(display, eglSurface);
				eglSurface = null;
			}
		}

		void DestroyContext ()
		{
			if (EGLContext != null) {
				egl.EglDestroyContext(display, EGLContext);
				EGLContext = null;
			}
		}

		void DestroyDisplay ()
		{
			if (display != null) {
				egl.EglTerminate(display);
				display = null;
			}
		}

		class EglException : InvalidOperationException
		{
			public EglException (string msg, IEGL10 egl) : base(String.Format ( "{0} failed with error 0x{1:X}", egl.EglGetError()))
			{
			}
		}

		public void Update(IWindowInfo window)
		{
			throw new NotSupportedException();
		}

		public void LoadAll()
		{
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
			DestroySurface ();
			DestroyContext ();
			DestroyDisplay ();
		}

		~AndroidGraphicsContext()
		{
			Dispose(false);
		}

		public bool IsCurrent {
			get {//FIXME:
				return true;
			}
		}

		public bool IsDisposed {
			get { return EGLContext == null; }
		}

		public bool VSync {
			get { throw new NotSupportedException(); }
			set { throw new NotSupportedException(); }
		}

		public GraphicsMode GraphicsMode {get; private set;}

		public bool ErrorChecking {
			get { return false; }
			set { }
		}

		IGraphicsContext IGraphicsContextInternal.Implementation {
			get { return this; }
		}

		ContextHandle contextHandle;
		ContextHandle IGraphicsContextInternal.Context {
			get { return contextHandle; }
		}

	}

	class SurfaceWindow : IWindowInfo
	{
		public readonly ISurfaceHolder Holder;
		public SurfaceWindow (ISurfaceHolder holder)
		{
			this.Holder = holder;
		}

		public void Dispose ()
		{
		}
	}
}
