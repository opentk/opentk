#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.Android;

using Android.Content;
using Android.Util;
using Android.Views;
using Android.Runtime;
using Android.Graphics;

using Java.Util;

using All  = OpenTK.Graphics.ES11.All;
using ES11 = OpenTK.Graphics.ES11;
using ES20 = OpenTK.Graphics.ES20;

namespace OpenTK.Platform.Android
{

	[Register ("opentk/platform/android/AndroidGameView")]
	public partial class AndroidGameView : GameViewBase, ISurfaceHolderCallback
	{
		bool disposed;
		System.Timers.Timer timer;
		Java.Util.Timer j_timer;
		ISurfaceHolder mHolder;
		GLCalls gl;
		AndroidWindow windowInfo;
		Object ticking = new Object ();
		bool hasSurface = false;
		bool createSurface = false;
		bool lostContext = false;
		bool stopped = true;
		bool renderOn = false;
		bool sizeChanged = false;
		bool requestRender = false;
		CancellationTokenSource source;
		Task renderThread;
		ManualResetEvent pauseSignal;
		global::Android.Graphics.Rect surfaceRect;
		Size size;
		System.Diagnostics.Stopwatch stopWatch;
		double tick = 0;

		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public AndroidGameView (Context context) : base (context)
		{
			Init ();
		}

		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public AndroidGameView (Context context, IAttributeSet attrs) : base (context, attrs)
		{
			Init ();
		}

		public AndroidGameView (IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
            : base (handle, transfer)
		{
			Init ();
		}

		private void Init ()
		{
			// default
#if OPENTK_0
			GLContextVersion = GLContextVersion.Gles1_1;
#else
			ContextRenderingApi = GLVersion.ES1;
#endif
			mHolder = Holder;

			// Add callback to get the SurfaceCreated etc events
			mHolder.AddCallback (this);
			mHolder.SetType (SurfaceType.Gpu);

			pauseSignal = new ManualResetEvent (true);
		}

		public void SurfaceCreated (ISurfaceHolder holder)
		{
			log ("SurfaceCreated");

			windowInfo = new AndroidWindow (mHolder);

			hasSurface = true;

			// Surface size or format has changed
			surfaceRect = holder.SurfaceFrame;
			size = new Size (surfaceRect.Right - surfaceRect.Left, surfaceRect.Bottom - surfaceRect.Top);

			LoadInternal (EventArgs.Empty);
		}

		public void SurfaceDestroyed (ISurfaceHolder holder)
		{
			log ("SurfaceDestroyed");

			hasSurface = false;

			UnloadInternal (EventArgs.Empty);
		}

		public void SurfaceChanged (ISurfaceHolder holder, Format format, int w, int h)
		{
			log ("SurfaceChanged");

			Width = w;
			Height = h;

			// Surface size or format has changed
			surfaceRect = holder.SurfaceFrame;
			size = new Size (surfaceRect.Right - surfaceRect.Left, surfaceRect.Bottom - surfaceRect.Top);

			GLCalls.Viewport (0, 0, size.Width, size.Height);
			GLCalls.Scissor (0, 0, size.Width, size.Height);

			GraphicsContext.Update (WindowInfo);

			OnResize (EventArgs.Empty);
		}

		public override void Close ()
		{
			EnsureUndisposed ();
			base.Close ();
		}

		protected override void Dispose (bool disposing)
		{
			if (disposed)
				return;

			// Stop the timer before anything else
			StopThread ();

			if (disposing)
				OnDisposed (EventArgs.Empty);
			disposed = true;

			base.Dispose (disposing);
		}

		protected override void CreateFrameBuffer ()
		{
			CreateContext ();
		}

		protected virtual void DestroyFrameBuffer ()
		{
			DestroyContext ();
		}

		public override void MakeCurrent ()
		{
			EnsureUndisposed ();
			AssertContext ();

			GraphicsContext.MakeCurrent (WindowInfo);
		}

		public override void SwapBuffers ()
		{
			EnsureUndisposed ();
			AssertContext ();

			if (Context != null) {
				if (!Context.Swap ()) {
					CreateFrameBuffer ();
				}
			} else
				GraphicsContext.SwapBuffers ();
		}

		double updates;
		public override void Run ()
		{
			EnsureUndisposed ();
			updates = 0;
#if TIMING
			targetFps = currentFps = 0;
			avgFps = 1;
#endif
			StartThread ();
		}

		public override void Run (double updatesPerSecond)
		{
			EnsureUndisposed ();
#if TIMING
			avgFps = targetFps = currentFps = updatesPerSecond;
#endif
			updates = 1000 / updatesPerSecond;
			StartThread ();
		}

		public void Stop ()
		{
			EnsureUndisposed ();

			StopThread ();
			UnloadInternal (EventArgs.Empty);
		}

		public virtual void Pause ()
		{
			log ("Pause");
			EnsureUndisposed ();
			PauseThread ();
		}

		public virtual void Resume ()
		{
			log ("Resume");
			EnsureUndisposed ();
			ResumeThread ();
		}

#region Private
		void LoadInternal (EventArgs e)
		{
			CreateFrameBuffer ();
			OnLoad (e);
		}

		void UnloadInternal (EventArgs e)
		{
			OnUnload (e);
			DestroyFrameBuffer ();
		}

		void RenderFrameInternal (FrameEventArgs e)
		{
#if TIMING
			Mark ();
#endif
			if (!ReadyToRender)
				return;

			OnRenderFrame (e);
		}

#if TIMING
		int frames = 0;
		double prev = 0;
		double avgFps = 0;
		double currentFps = 0;
		double targetFps = 0;
		void Mark ()
		{
			double cur = stopWatch.Elapsed.TotalMilliseconds;
			if (cur < 2000) {
				return;
			}
			frames ++;

			if (cur - prev >= 995) {
				avgFps = 0.8 * avgFps + 0.2 * frames;

				Log.Verbose ("AndroidGameView", "frames {0} elapsed {1}ms {2:F2} fps",
					frames,
					cur - prev,
					avgFps);

				frames = 0;
				prev = cur;
			}
		}
#endif

		void UpdateFrameInternal (FrameEventArgs e)
		{
			if (!ReadyToRender)
				return;

			OnUpdateFrame (e);
		}

		void EnsureUndisposed ()
		{
			if (disposed)
				throw new ObjectDisposedException ("");
		}

		void AssertContext ()
		{
			if (GraphicsContext == null)
				throw new InvalidOperationException ("Operation requires a GraphicsContext, which hasn't been created yet.");
		}

		void CreateContext ()
		{
			log ("CreateContext");

			GraphicsContext = AndroidGraphicsContext.CreateGraphicsContext (GraphicsMode,
								WindowInfo, GraphicsContext,
#if OPENTK_0
								GLContextVersion,
#else
								ContextRenderingApi,
#endif
								GraphicsContextFlags.Embedded);
		}

		void DestroyContext ()
		{
			if (GraphicsContext != null) {
				GraphicsContext.Dispose ();
				GraphicsContext = null;
				createSurface = false;
				lostContext = true;
			}
		}

		void StartThread ()
		{
			log ("StartThread");

			renderOn = true;
			stopped = false;

			if (source != null)
				return;

			source = new CancellationTokenSource ();

			renderThread = Task.Factory.StartNew ((k) => {
				stopWatch = System.Diagnostics.Stopwatch.StartNew ();
				tick = 0;
				var token = (CancellationToken)k;
				while (true) {
					if (token.IsCancellationRequested)
						return;

					tick = stopWatch.Elapsed.TotalMilliseconds;

					pauseSignal.WaitOne ();

					global::Android.App.Application.SynchronizationContext.Send (_ => {
						RunIteration (token);
					}, null);


					if (updates > 0) {
						var t = updates - (stopWatch.Elapsed.TotalMilliseconds - tick);
						if (t > 0) {
#if TIMING
//						Log.Verbose ("AndroidGameView", "took {0:F2}ms, should take {1:F2}ms, sleeping for {2:F2}", stopWatch.Elapsed.TotalMilliseconds - tick, updates, t);
#endif
							if (token.IsCancellationRequested)
								return;

							pauseSignal.Reset ();
							pauseSignal.WaitOne ((int)t);
							if (renderOn)
								pauseSignal.Set ();
						}
					}
				}
			}, source.Token);
		}

		void StopThread ()
		{
			log ("StopThread");
			if (source == null)
				return;

			stopped = true;
			renderOn = false;

			source.Cancel ();

			// if the render thread is paused, let it run so it exits
			pauseSignal.Set ();
			renderThread.Wait ();
			source = null;
			stopWatch.Stop ();
		}

		void PauseThread ()
		{
			log ("PauseThread");
			if (source == null)
				return;

			pauseSignal.Reset ();
			renderOn = false;
		}

		void ResumeThread ()
		{
			log ("ResumeThread");
			if (source == null)
				return;

			if (!renderOn) {
				tick = 0;
				renderOn = true;
				pauseSignal.Set ();
			}
		}

		bool ReadyToRender {
			get { return hasSurface && renderOn && !stopped; }
		}

		DateTime prevUpdateTime;
		DateTime prevRenderTime;
		DateTime curUpdateTime;
		DateTime curRenderTime;
		FrameEventArgs updateEventArgs;
		FrameEventArgs renderEventArgs;

		// this method is called on the main thread
		void RunIteration (CancellationToken token)
		{
			if (token.IsCancellationRequested)
				return;

			if (!ReadyToRender)
				return;

			updateEventArgs = new FrameEventArgs ();
			curUpdateTime = DateTime.Now;
			if (prevUpdateTime.Ticks != 0) {
				var t = (curUpdateTime - prevUpdateTime).TotalSeconds;
				updateEventArgs.Time = t < 0 ? 0 : t;
			}

			UpdateFrameInternal (updateEventArgs);
			prevUpdateTime = curUpdateTime;

			renderEventArgs = new FrameEventArgs ();
			curRenderTime = DateTime.Now;
			if (prevRenderTime.Ticks == 0) {
				var t = (curRenderTime - prevRenderTime).TotalSeconds;
				renderEventArgs.Time = t < 0 ? 0 : t;
			}

			RenderFrameInternal (renderEventArgs);
			prevRenderTime = curRenderTime;
		}

		partial void log (string msg);

#if LOGGING
		partial void log (string msg)
		{
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("====== " + msg + " ======="));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("tid {0}", Java.Lang.Thread.CurrentThread().Id));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("context {0}", GraphicsContext));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("stopped {0}", stopped));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("hasSurface {0}", hasSurface));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("createSurface {0}", createSurface));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("lostContext {0}", lostContext));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("renderOn {0}", renderOn));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("GraphicsContext? {0}", GraphicsContext != null));
			if (source != null)
				global::Android.Util.Log.Debug ("AndroidGameView", String.Format("IsCancellationRequested {0}", source.IsCancellationRequested));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("width:{0} height:{1} size:{2} surfaceRect:{3}", Width, Height, size, surfaceRect));
		}
#endif
#endregion

#region Properties

		GLCalls GLCalls {
			get {
#if OPENTK_0
				if (gl == null || gl.Version != GLContextVersion)
					gl = GLCalls.GetGLCalls (GLContextVersion);
#else
				if (gl == null || gl.Version != ContextRenderingApi)
					gl = GLCalls.GetGLCalls (ContextRenderingApi);
#endif
				return gl;
			}
		}

		AndroidGraphicsContext Context {
			get { return GraphicsContext as AndroidGraphicsContext; }
		}

		public GraphicsMode GraphicsMode {
			get; set;
		}

#if OPENTK_0
		GLContextVersion api;
		public GLContextVersion GLContextVersion
#else
		GLVersion api;
		public GLVersion ContextRenderingApi
#endif
		{
			get {
				EnsureUndisposed ();
				return api;
			}
			set {
				EnsureUndisposed ();
				if (GraphicsContext != null)
					throw new NotSupportedException ("Can't change RenderingApi after GraphicsContext is constructed.");
				this.api = value;
			}
		}

		/// <summary>The visibility of the window. Always returns true.</summary>
		/// <value></value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public new virtual bool Visible {
			get {
				EnsureUndisposed ();
				return true;
			}
			set {
				EnsureUndisposed ();
			}
		}

		/// <summary>Gets information about the containing window.</summary>
		/// <value>By default, returns an instance of <see cref="F:OpenTK.Platform.Android.AndroidWindow" /></value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public override IWindowInfo WindowInfo {
			get {
				EnsureUndisposed ();
				return windowInfo;
			}
		}

		/// <summary>Always returns <see cref="F:OpenTK.WindowState.Normal" />.</summary>
		/// <value></value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public override WindowState WindowState {
			get {
				EnsureUndisposed ();
				return WindowState.Normal;
			}
			set {}
		}

		/// <summary>Always returns <see cref="F:OpenTK.WindowBorder.Hidden" />.</summary>
		/// <value></value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public override WindowBorder WindowBorder {
			get {
				EnsureUndisposed ();
				return WindowBorder.Hidden;
			}
			set {}
		}

		/// <summary>The size of the current view.</summary>
		/// <value>A <see cref="T:System.Drawing.Size" /> which is the size of the current view.</value>
		/// <exception cref="T:System.ObjectDisposed">The instance has been disposed</exception>
		public override Size Size {
			get {
				EnsureUndisposed ();
				return size;
			}
			set {
				EnsureUndisposed ();
				if (size != value) {
					size = value;
					OnResize (EventArgs.Empty);
				}
			}
		}
#endregion
	}
}
