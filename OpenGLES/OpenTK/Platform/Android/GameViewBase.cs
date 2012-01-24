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

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.Android;

using Android.Content;
using Android.Util;
using Android.Views;
using Android.Runtime;

using Java.Util;

using All  = OpenTK.Graphics.ES11.All;
using ES11 = OpenTK.Graphics.ES11;
using ES20 = OpenTK.Graphics.ES20;

namespace OpenTK
{
	public abstract class GameViewBase : SurfaceView, IGameWindow
	{
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GameViewBase (Context context) : base (context)
		{
		}

		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public GameViewBase (Context context, IAttributeSet attrs) : base (context, attrs)
		{
		}

		public GameViewBase (IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
            : base (handle, transfer)
		{
		}

		/// <summary>
		///   Gets the <see cref="T:OpenTK.Graphics.IGraphicsContext" /> instance
		///   bound to this
		///   <see cref="T:OpenTK.Platform.Android.AndroidGameView" /> instance.
		/// </summary>
		/// <value>
		///   A <see cref="T:OpenTK.Graphics.IGraphicsContext" /> instance bound
		///   to this <see cref="T:OpenTK.Platform.Android.AndroidGameView" />
		///   instance.
		/// </value>
		/// <remarks>
		///   <para>
		///     Unless manually set, <c>GraphicsContext</c> will be
		///     <see langword="null" /> until
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.CreateFrameBuffer" />
		///     has been invoked.
		///   </para>
		/// </remarks>
		IGraphicsContext ctx;
		public IGraphicsContext GraphicsContext {
			get {
				return ctx;
			}
			set {
				ctx = value;
			}
		}

		/// <summary>
		///   Controls whether the graphics context is recreated when the display
		///   size changes.
		/// </summary>
		/// <value>
		///   A <see cref="T:System.Boolean" /> which controls whether the
		///   graphics context is recreated when the view's
		///   <see cref="P:MonoTouch.UIKit.UIView.Bounds" /> changes.
		/// </value>
		/// <remarks>
		/// </remarks>
		public bool AutoResize { get; set; }


		/// <summary>
		///   Creates the framebuffer so that OpenGL operations can be performed.
		/// </summary>
		/// <remarks>
		///   <para>
		///     This method is invoked to create an
		///     <see cref="T:OpenTK.Graphics.IGraphicsContext" />
		///     implementation, create a
		///     <see cref="T:MonoTouch.OpenGLES.EAGLContext" />, and initialize
		///     the GL context so that a framebuffer and renderbuffer exist for
		///     future GL calls.
		///   </para>
		///   <para>
		///     This method is invoked by:
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.LayoutSubviews" />,
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" />,
		///     and
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run(System.Double)" />.
		///   </para>
		///   <block subset="none" type="behaviors">
		///     This method performs the following operations:
		///     <list type="number"><item><term>
		///         The
		///         <see cref="P:OpenTK.Platform.Android.AndroidGameView.GraphicsContext" />
		///         is created, wihch in turns creates an <see cref="T:MonoTouch.OpenGLES.EAGLContext" />.
		///         The <c>EAGLContext</c> can be retrieved through the
		///         <see cref="P:OpenTK.Platform.Android.AndroidGameView.EAGLContext" />
		///         property.
		///       </term></item><item><term>
		///         A renderbuffer is created and bound to the GL context as the
		///         <c>RenderbufferOes</c> property.  The renderbuffer is
		///         accessible via
		///         via <see cref="P:OpenTK.Platform.Android.AndroidGameView.Renderbuffer" />.
		///       </term></item><item><term><see cref="M:MonoTouch.OpenGLES.EAGLContext.RenderBufferStorage(System.UInt32,MonoTouch.CoreAnimation.CAEAGLLayer)" />
		///         is invoked to bind the above renderbuffer to
		///         <c>EAGLContext</c>.
		///       </term></item><item><term>
		///         A framebuffer is created and bound to the GL context as the
		///         <c>FramebufferOes</c> property.  The framebuffer is accessible
		///         via <see cref="P:OpenTK.Platform.Android.AndroidGameView.Framebuffer" />.
		///       </term></item><item><term>
		///         The framebuffer and renderbuffer are bound together:
		///         <c>GL.Oes.FramebufferRenderbuffer (All.FramebufferOes, All.ColorAttachment0Oes, All.RenderbufferOes, renderbuffer);</c></term></item><item><term><see cref="P:OpenTK.Platform.Android.AndroidGameView.Size" />
		///         is initialized based on the current
		///         value.
		///       </term></item><item><term><c>GL.Viewport(0, 0, Size.Width, Size.Height)</c> is invoked.
		///       </term></item><item><term><c>GL.Scissor(0, 0, Size.Width, Size.Height)</c> is invoked.
		///       </term></item></list></block>
		///   <block subset="none" type="overrides">
		///     <para>
		///       Inheritors can override either
		///       <see cref="M:OpenTK.Platform.Android.AndroidGameView.ConfigureLayer(MonoTouch.CoreAnimation.CAEAGLLayer)" />,
		///       or this method to add additional construction logic (e.g. to add
		///       a depth buffer).  If only the layer needs to be configured, then
		///       override <c>ConfigureLayer</c>; otherwise, override this method
		///       and call this implementation to create the framebuffer and
		///       renderbuffer.
		///     </para>
		///   </block>
		/// </remarks>
		/// <exception cref="T:System.ArgumentException">
		///   <para>
		///     <see cref="P:OpenTK.Platform.Android.AndroidGameView.GLContextVersion" />
		///     hasn't been initialized.
		///   </para>
		/// </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <para>
		///     <see cref="P:OpenTK.Platform.Android.AndroidGameView.LayerColorFormat" />
		///     hasn't been initialized.
		///   </para>
		/// </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		protected abstract void CreateFrameBuffer ();

		Point INativeWindow.PointToClient (Point point)
		{
			return point;
		}

		Point INativeWindow.PointToScreen (Point point)
		{
			return point;
		}

		#region IGameWindow implementation

		/// <summary>
		///   Occurs before the run loop starts.
		/// </summary>
		/// <remarks>
		///   <para>
		///     When using the run-loop processing architecture, events happen in
		///     the following order:
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///         <c>Load</c>
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///       </term>
		///     </item>
		///   </list>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" /> and
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run(System.Double)" />,
		///     invoke
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     before starting the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop which is invoked for every rendered frame.
		///   </para>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Stop" />
		///     ends the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop processing, then invokes the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///     event.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> Load;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///   event.
		/// </summary>
		protected virtual void OnLoad (EventArgs e)
		{
			if (Load != null) Load(this, e);
		}

		/// <summary>
		///   Occurs when the run-loop is terminated.
		/// </summary>
		/// <remarks>
		///   <para>
		///     When using the run-loop processing architecture, events happen in
		///     the following order:
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <c>Unload</c>
		///       </term>
		///     </item>
		///   </list>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" /> and
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run(System.Double)" />,
		///     invoke
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     before starting the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop which is invoked for every rendered frame.
		///   </para>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Stop" />
		///     ends the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop processing, then invokes the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///     event.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> Unload;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnUnload</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnUnload</c> in a derived class, be sure to
		///     call the base class's <c>OnUnload</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnUnload (EventArgs e)
		{
			if (Unload != null) Unload(this, e);
		}

		/// <summary>
		///   Occurs part of run-loop processing when a frame should be updated prior to rendering.
		/// </summary>
		/// <remarks>
		///   <para>
		///     When using the run-loop processing architecture, events happen in
		///     the following order:
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <c>UpdateFrame</c>
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///       </term>
		///     </item>
		///   </list>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" /> and
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run(System.Double)" />,
		///     invoke
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     before starting the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop which is invoked for every rendered frame.
		///   </para>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Stop" />
		///     ends the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop processing, then invokes the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///     event.
		///   </para>
		/// </remarks>
		public event EventHandler<FrameEventArgs> UpdateFrame;

		/// <param name="e">
		///   An <see cref="T:OpenTK.FrameEventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnUpdateFrame</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnUpdateFrame</c> in a derived class, be sure to
		///     call the base class's <c>OnUpdateFrame</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnUpdateFrame (FrameEventArgs e)
		{
			if (UpdateFrame != null) UpdateFrame(this, e);
		}

		/// <summary>
		///   Occurs part of run-loop processing when a frame should be rendered.
		/// </summary>
		/// <remarks>
		///   <para>
		///     When using the run-loop processing architecture, events happen in
		///     the following order:
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <c>RenderFrame</c>
		///       </term>
		///     </item>
		///     <item>
		///       <term>
		///         <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///       </term>
		///     </item>
		///   </list>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" /> and
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run(System.Double)" />,
		///     invoke
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     before starting the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop which is invoked for every rendered frame.
		///   </para>
		///   <para>
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Stop" />
		///     ends the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />/<see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     loop processing, then invokes the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Unload" />
		///     event.
		///   </para>
		/// </remarks>
		public event EventHandler<FrameEventArgs> RenderFrame;

		/// <param name="e">
		///   An <see cref="T:OpenTK.FrameEventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnRenderFrame</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnRenderFrame</c> in a derived class, be sure to
		///     call the base class's <c>OnRenderFrame</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnRenderFrame (FrameEventArgs e)
		{
			if (RenderFrame != null) RenderFrame(this, e);
		}

		/// <summary>
		///   Starts as-fast-as-possible run-loop processing.
		/// </summary>
		/// <remarks>
		///   <para>
		///     Invokes
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.CreateFrameBuffer" />,
		///     raises the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     event, then begins run-loop processing.  Run-loop processing
		///     consists of the following step (which happens for each frame):
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///       The <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///       event is raised.
		///     </term>
		///     </item>
		///     <item>
		///       <term>
		///       The OpenGL frame buffer is re-bound to
		///       <see cref="P:OpenTK.Platform.Android.AndroidGameView.Framebuffer" />.
		///     </term>
		///     </item>
		///     <item>
		///       <term>
		///       The <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///       event is raised.
		///     </term>
		///     </item>
		///   </list>
		///   <para>
		///     Run-loop processing should not be used if a persistant layer is
		///     used (i.e.
		///     <see cref="P:OpenTK.Platform.Android.AndroidGameView.LayerRetainsBacking" />
		///     is <see langword="false" />); the entire view should need to be
		///     re-rendered on every frame.
		///   </para>
		///   <para>
		///     In this <c>Run</c> overload, there is no delay between raising of the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///     event and the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///     of the following frame; everything is executed as quickly as
		///     possible.  This may not be desirable.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public abstract void Run ();

		/// <param name="updatesPerSecond">
		///   A <see cref="T:System.Double" /> containing the number of frames per
		///   second that should be updated and rendered.
		/// </param>
		/// <summary>
		///   Starts run-loop processing at a rate of <paramref name="updatesPerSecond" />
		///   frames per second.
		/// </summary>
		/// <remarks>
		///   <para>
		///     If <paramref name="updatesPerSecond" /> is <c>0.0</c>, then
		///     <see cref="M:OpenTK.Platform.Android.AndroidGameView.Run" /> is
		///     invoked and the method exits.
		///   </para>
		///   <para>
		///     Invokes
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.CreateFrameBuffer" />,
		///     raises the
		///     <see cref="E:OpenTK.Platform.Android.AndroidGameView.Load" />
		///     event, then begins run-loop processing.  Run-loop processing
		///     consists of the following step (which happens for each frame):
		///   </para>
		///   <list type="number">
		///     <item>
		///       <term>
		///       The <see cref="E:OpenTK.Platform.Android.AndroidGameView.UpdateFrame" />
		///       event is raised.
		///     </term>
		///     </item>
		///     <item>
		///       <term>
		///       The OpenGL frame buffer is re-bound to
		///       <see cref="P:OpenTK.Platform.Android.AndroidGameView.Framebuffer" />.
		///     </term>
		///     </item>
		///     <item>
		///       <term>
		///       The <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderFrame" />
		///       event is raised.
		///     </term>
		///     </item>
		///   </list>
		///   <para>
		///     Run-loop processing should not be used if a persistant layer is
		///     used (i.e.
		///     <see cref="P:OpenTK.Platform.Android.AndroidGameView.LayerRetainsBacking" />
		///     is <see langword="false" />); the entire view should need to be
		///     re-rendered on every frame.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public abstract void Run (double updateRate);

		/// <summary>
		///   Makes the
		///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.GraphicsContext" />
		///   current on the calling thread.
		/// </summary>
		/// <remarks>
		///   <para>
		///     This method is equivalent to calling:
		///     <c>GraphicsContext.MakeCurrent(WindowInfo)</c>.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public abstract void MakeCurrent ();

		/// <summary>
		///   Swaps the front and back buffers of the current GraphicsContext,
		///   presenting the rendered scene to the user.
		/// </summary>
		/// <remarks>
		///   <para>
		///     This method rebinds
		///     <see cref="P:OpenTK.Platform.Android.AndroidGameView.Renderbuffer" />
		///     to the OpenGL context's <c>RenderbufferOes</c> property, then
		///     invokes <see cref="M:OpenTK.Graphics.IGraphicsContext.SwapBuffers" />.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public abstract void SwapBuffers ();
		#endregion

		#region INativeWindow implementation

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> Move;

		/// <summary>
		///   Occurs when the view's
		///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.Size" />
		///   changes.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> Resize;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Resize" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnResize</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnResize</c> in a derived class, be sure to
		///     call the base class's <c>OnResize</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnResize (EventArgs e)
		{
			if (Resize != null)
				Resize (this, e);
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<CancelEventArgs> Closing;

		/// <summary>
		///   Occurs when the view has been closed.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> Closed;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Closed" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnClosed</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnClosed</c> in a derived class, be sure to
		///     call the base class's <c>OnClosed</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnClosed (EventArgs e)
		{
			if (Closed != null)
				Closed (this, e);
		}

		/// <summary>
		///   Occurs when the view is disposed by a call to the
		///   <see cref="M:MonoTouch.Foundation.NSObject.Dispose" /> method.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> Disposed;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Disposed" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnDisposed</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnDisposed</c> in a derived class, be sure to
		///     call the base class's <c>OnDisposed</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks
		protected virtual void OnDisposed (EventArgs e)
		{
			if (Disposed != null)
				Disposed (this, e);
		}

		/// <summary>
		///   Occurs when the value of
		///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.Title" />
		///   changes.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> TitleChanged;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.TitleChanged" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnTitleChanged</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnTitleChanged</c> in a derived class, be sure to
		///     call the base class's <c>OnTitleChanged</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnTitleChanged (EventArgs e)
		{
			if (TitleChanged != null)
				TitleChanged (this, EventArgs.Empty);
		}

		/// <summary>
		///   Occurs when the value of
		///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.Visible" />
		///   changes.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> VisibleChanged;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.VisibleChanged" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnVisibleChanged</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnVisibleChanged</c> in a derived class, be sure to
		///     call the base class's <c>OnVisibleChanged</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnVisibleChanged (EventArgs e)
		{
			if (VisibleChanged != null)
				VisibleChanged (this, EventArgs.Empty);
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> FocusedChanged;

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> WindowBorderChanged;

		/// <summary>
		///   Occurs when the value of
		///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.WindowState" />
		///   changes.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public event EventHandler<EventArgs> WindowStateChanged;

		/// <param name="e">
		///   An <see cref="T:System.EventArgs" /> that contains the event data.
		/// </param>
		/// <summary>
		///   Raises the
		///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.WindowStateChanged" />
		///   event.
		/// </summary>
		/// <remarks>
		///   <para>
		///     The <c>OnWindowStateChanged</c> method also allows derived classes to handle
		///     the event without attaching a delegate.  This is the preferred
		///     technique for handling the event in a derived class.
		///   </para>
		///   <block subset="none" type="overrides">
		///     When overriding <c>OnWindowStateChanged</c> in a derived class, be sure to
		///     call the base class's <c>OnWindowStateChanged</c> method so that registered
		///     delegates receive the event.
		///   </block>
		/// </remarks>
		protected virtual void OnWindowStateChanged (EventArgs e)
		{
			if (WindowStateChanged != null)
				WindowStateChanged (this, EventArgs.Empty);
		}

		/// <summary>This member is not supported.</summary>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		event EventHandler<KeyPressEventArgs> INativeWindow.KeyPress {
			add { throw new NotSupportedException ();}
			remove { throw new NotSupportedException ();}
		}

		public int Width {
			get; set;
		}

		public int Height {
			get;
			set;
		}

		/// <summary>This member is not supported.</summary>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> MouseEnter {
			add { throw new NotSupportedException (); }
			remove { throw new NotSupportedException (); }
		}

		/// <summary>This member is not supported.</summary>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public event EventHandler<EventArgs> MouseLeave {
			add { throw new NotSupportedException (); }
			remove { throw new NotSupportedException (); }
		}

		/// <summary>This member is not supported.</summary>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		event EventHandler<EventArgs> INativeWindow.IconChanged {
			add { throw new NotSupportedException (); }
			remove { throw new NotSupportedException (); }
		}
		/// <summary>
		///   Invokes the
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.OnClosed(System.EventArgs)" />
		///   event.
		/// </summary>
		/// <remarks>
		///   This method only invokes the
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.OnClosed(System.EventArgs)" />
		///   method.
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public void Close ()
		{
			throw new NotImplementedException ();
		}

		/// <summary>This member is not supported.</summary>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public void ProcessEvents ()
		{
			throw new NotImplementedException ();
		}

		public Point PointToClient (Point point)
		{
			throw new NotImplementedException ();
		}

		public Point PointToScreen (Point point)
		{
			throw new NotImplementedException ();
		}

		public string Title {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public bool Focused {
			get {
				throw new NotSupportedException ();
			}
		}

		/// <summary>
		///   Gets or sets a value specifying whether the view is visible.
		/// </summary>
		/// <value>
		///   A <see cref="T:System.Boolean" /> specifying whether the view is
		///   visible.
		/// </value>
		/// <remarks>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public bool Visible {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotImplementedException" />.
		///   </para>
		/// </remarks>
		public bool Exists {
			get {
				throw new NotImplementedException ();
			}
		}

		/// <summary>
		///   Gets information about the containing window.
		/// </summary>
		/// <value>
		///   A <see cref="T:OpenTK.Platform.IWindowInfo" /> which provides
		///   information about the containing window.
		/// </value>
		/// <remarks>
		///   <para>
		///     Always returns <see langword="null" />.
		///   </para>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public IWindowInfo WindowInfo {
			get {
				throw new NotImplementedException ();
			}
		}

		/// <summary>
		///   Gets or states the state of the view.
		/// </summary>
		/// <value>
		///   A <see cref="T:OpenTK.WindowState" /> value specifying the state of
		///   the window.
		/// </value>
		/// <remarks>
		///   <para>
		///     <see cref="F:OpenTK.WindowState.Normal" /> is always returned.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public WindowState WindowState {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>
		///   Always returns <see cref="F:OpenTK.WindowBorder.Hidden" />.
		/// </summary>
		/// <value>
		///   A <see cref="T:OpenTK.WindowBorder" /> value controlling the border
		///   of the view.
		/// </value>
		/// <remarks>
		///   <para>
		///     Always returns <see cref="F:OpenTK.WindowBorder.Hidden" />.
		///   </para>
		///   <para>
		///     The setter is ignored.
		///   </para>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public WindowBorder WindowBorder {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public Rectangle Bounds {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public Point Location {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>
		///   The size of the current view.
		/// </summary>
		/// <value>
		///   A <see cref="T:System.Drawing.Size" /> which is the size of the
		///   current view.
		/// </value>
		/// <remarks>
		/// </remarks>
		/// <exception cref="T:System.ObjectDisposedException">
		///   The instance has had
		///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
		///   invoked on it.
		/// </exception>
		public Size Size {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public int X {
			get {
				throw new NotSupportedException ();
			}
			set {
				throw new NotSupportedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public int Y {
			get {
				throw new NotSupportedException ();
			}
			set {
				throw new NotSupportedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public Rectangle ClientRectangle {
			get {
				throw new NotSupportedException ();
			}
			set {
				throw new NotSupportedException ();
			}
		}

		/// <summary>This member is not supported.</summary>
		/// <value>To be added.</value>
		/// <remarks>
		///   <para>
		///     Throws a <see cref="T:System.NotSupportedException" />.
		///   </para>
		/// </remarks>
		public Size ClientSize {
			get {
				throw new NotSupportedException ();
			}
			set {
				throw new NotSupportedException ();
			}
		}

		public OpenTK.Input.IInputDriver InputDriver {
			get {
				throw new NotSupportedException ();
			}
		}
		#endregion
	}
}
