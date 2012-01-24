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
	public class AndroidGameView : GameViewBase, ISurfaceHolderCallback
	{
		bool disposed;
		System.Timers.Timer timer;
		Java.Util.Timer j_timer;
		ISurfaceHolder mHolder;
		GLCalls gl;
		IWindowInfo windowInfo;
		Object ticking = new Object ();
		bool hasSurface = false;
		bool lostContext = false;
		bool stopped = true;
		bool renderOn = false;
		bool sizeChanged = false;
		bool requestRender = false;
		CancellationTokenSource source;
		Task renderThread;
		ManualResetEvent pauseSignal;
		global::Android.Graphics.Rect surfaceRect;

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
			GLContextVersion = EAGLRenderingAPI.OpenGLES1;
			mHolder = Holder;

			// Add callback to get the SurfaceCreated etc events
			mHolder.AddCallback (this);
			mHolder.SetType (SurfaceType.Gpu);

			pauseSignal = new ManualResetEvent (true);
		}

		public void SurfaceCreated (ISurfaceHolder holder)
		{
			log ("SurfaceCreated");

			lock (ticking) {
				hasSurface = true;
			}

			// Surface size or format has changed
			surfaceRect = holder.SurfaceFrame;
			size = new Size (surfaceRect.Right - surfaceRect.Left, surfaceRect.Bottom - surfaceRect.Top);

			CreateFrameBuffer ();
			LoadInternal (EventArgs.Empty);
		}

		public void SurfaceDestroyed (ISurfaceHolder holder)
		{
			log ("SurfaceDestroyed");

			lock (ticking) {
				hasSurface = false;
			}
			StopThread ();
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

			// NEW
			if (gl != null) {
				gl.Viewport (0, 0, size.Width, size.Height);
				gl.Scissor (0, 0, size.Width, size.Height);
			}

			ClearBuffers ();
			OnResize (EventArgs.Empty);
		}
		public virtual void Close ()
		{
			EnsureUndisposed ();
			OnClosed (EventArgs.Empty);
		}

		protected override void Dispose (bool disposing)
		{
			if (disposed)
				return;

			// Stop the timer before anything else
			StopThread ();
			renderThread.Wait ();

			if (disposing)
				OnDisposed (EventArgs.Empty);
			disposed = true;
		}

		void Recycle ()
		{
			DestroySurface ();
			DestroyContext ();

			CreateContext ();
			CreateSurface ();
		}

		protected override void CreateFrameBuffer ()
		{
			EnsureUndisposed ();

			log ("begin CreateFrameBuffer");

			CreateContext ();
			CreateSurface ();

			gl.Viewport (0, 0, size.Width, size.Height);
			gl.Scissor (0, 0, size.Width, size.Height);
		}

		protected virtual void DestroyFrameBuffer ()
		{
			EnsureUndisposed ();
			source.Cancel ();
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

			if (!Context.Swap ())
				lostContext = true;
		}

		double updates;
		public override void Run ()
		{
			EnsureUndisposed ();
			updates = 0;
			lock (ticking) {
				renderOn = true;
			}
			StartThread ();
		}

		public override void Run (double updatesPerSecond)
		{
			EnsureUndisposed ();
			updates = 1000 / updatesPerSecond;
			lock (ticking) {
				renderOn = true;
			}
			StartThread ();
		}

		public void Stop ()
		{
			EnsureUndisposed ();

			PauseThread ();
			OnUnload (EventArgs.Empty);
		}

		public virtual void Pause ()
		{
			EnsureUndisposed ();
			PauseThread ();
		}

		public virtual void Resume ()
		{
			EnsureUndisposed ();
			ResumeThread ();
		}

#region Private
		void LoadInternal (EventArgs e)
		{
			OnLoad (e);
		}

		void UnloadInternal (EventArgs e)
		{
			OnUnload (e);
		}

		void RenderFrameInternal (FrameEventArgs e)
		{
			OnRenderFrame (e);
		}

		void UpdateFrameInternal (FrameEventArgs e)
		{
			OnUpdateFrame (e);
		}

		void EnsureUndisposed ()
		{
			if (disposed)
				throw new ObjectDisposedException ("");
		}

		void AssertContext ()
		{
			log ("AssertContext");
			if (GraphicsContext == null)
				throw new InvalidOperationException ("Operation requires a GraphicsContext, which hasn't been created yet.");
		}

		void CreateContext ()
		{
			log ("begin CreateContext");

			windowInfo = new SurfaceWindow (mHolder);

			GraphicsContext = AndroidGraphicsContext.CreateGraphicsContext (new GraphicsMode (), windowInfo, GraphicsContext, GLContextVersion, GraphicsContextFlags.Embedded);
			if (gl == null)
				gl = GLCalls.GetGLCalls (GLContextVersion);

			log ("end CreateContext");
		}

		void CreateSurface ()
		{
			log ("CreateSurface");

			if (Context != null) {
				Context.CreateSurface (WindowInfo);
			}
		}

		void DestroySurface ()
		{
			if (GraphicsContext != null) {
				Context.DestroySurface ();
			}
		}

		void DestroyContext ()
		{
			if (GraphicsContext != null) {
				GraphicsContext.Dispose ();
				GraphicsContext = null;
			}
		}

		void ClearBuffers ()
		{
			GraphicsContext.MakeCurrent (null);
			GraphicsContext.MakeCurrent (WindowInfo);
		}

		void StartThread ()
		{
			log ("StartThread");

			source = new CancellationTokenSource ();

			renderThread = Task.Factory.StartNew (() => {
				while (true) {
					pauseSignal.WaitOne ();

					if (source.IsCancellationRequested)
						return;

					RunIteration ();
					if (updates > 0) {
						var t = updates - (curUpdateTime - prevRenderTime).TotalMilliseconds;
						if (t > 0)
							Thread.Sleep ((int)t);
					}
				}
			}, source.Token);

			source.Token.Register (() => {
				DestroySurface ();
				DestroyContext ();
				source = null;
			}, true);
		}

		void StopThread ()
		{
			stopped = true;
			source.Cancel ();

			// if the render thread is paused, let it run so it exits
			pauseSignal.Set ();
		}

		void PauseThread ()
		{
			pauseSignal.Reset ();
			lock (ticking) {
				stopped = true;
			}
		}

		void ResumeThread ()
		{
			lock (ticking) {
				stopped = false;
			}
			pauseSignal.Set ();
		}

		bool ReadyToRender {
			get { return hasSurface && renderOn; }
		}

		DateTime prevUpdateTime;
		DateTime prevRenderTime;
		DateTime curUpdateTime;
		FrameEventArgs updateEventArgs = new FrameEventArgs ();
		FrameEventArgs renderEventArgs = new FrameEventArgs ();
		//void RunIteration(object source, ElapsedEventArgs e)

		void RunIteration ()
		{
			log ("RUN ITERATION");

			bool render = false;
			bool changeSize = false;
			int w = 0;
			int h = 0;

			lock (ticking) {

				if (!hasSurface) {
					return;
				}

				render = ReadyToRender;
			}

			if (render) {
				curUpdateTime = DateTime.Now;
				if (prevUpdateTime.Ticks != 0) {
					var t = (curUpdateTime - prevUpdateTime).TotalSeconds;
					updateEventArgs.Time = t;
				}
				global::Android.App.Application.SynchronizationContext.Send (_ => {
					UpdateFrameInternal (updateEventArgs);
				}, null);
				prevUpdateTime = curUpdateTime;

				var curRenderTime = DateTime.Now;
				if (prevRenderTime.Ticks == 0) {
					var t = (curRenderTime - prevRenderTime).TotalSeconds;
					renderEventArgs.Time = t;
				}

				global::Android.App.Application.SynchronizationContext.Send (_ => {
					RenderFrameInternal (renderEventArgs);
				}, null);
				prevRenderTime = curRenderTime;
			}

		}

		void log (string msg)
		{
/*
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("====== " + msg + " ======="));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("tid {0}", Java.Lang.Thread.CurrentThread().Id));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("context {0}", GraphicsContext));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("stopped {0}", stopped));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("hasSurface {0}", hasSurface));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("lostContext {0}", lostContext));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("renderOn {0}", renderOn));
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("GraphicsContext? {0}", GraphicsContext != null));
			if (source != null)
			global::Android.Util.Log.Debug ("AndroidGameView", String.Format("IsCancellationRequested {0}", source.IsCancellationRequested));
*/
		}

#endregion

#region Properties

		AndroidGraphicsContext Context {
			get { return GraphicsContext as AndroidGraphicsContext; }
		}

		EAGLRenderingAPI api;
		public EAGLRenderingAPI GLContextVersion {
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

		public new virtual bool Visible {
			get {
				EnsureUndisposed ();
				return true;
			}
			set {
				EnsureUndisposed ();
			}
		}

		public virtual IWindowInfo WindowInfo {
			get {
				EnsureUndisposed ();
				return windowInfo;
			}
		}

		public virtual WindowState WindowState {
			get {
				EnsureUndisposed ();
				return WindowState.Normal;
			}
			set {
				EnsureUndisposed ();
			}
		}

		public virtual WindowBorder WindowBorder {
			get {
				EnsureUndisposed ();
				return WindowBorder.Hidden;
			}
			set {}
		}

		Size size;
		public Size Size {
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

	delegate void TaskDelegate ();

	[Register ("opentk/platform/android/RepeatTimerTask")]
	class RepeatTimerTask : TimerTask
	{
		TaskDelegate task;

		public RepeatTimerTask ()
		{
		}

		public RepeatTimerTask (TaskDelegate task)
		{
			this.task = task;
		}

		public override void Run ()
		{
			task ();
		}
	}

	class RenderThread
	{
		public void Run ()
		{
			while (true) {

			}
		}
	}
}
