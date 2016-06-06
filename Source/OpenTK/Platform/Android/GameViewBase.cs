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
using OpenTK.Input;

namespace OpenTK
{
    [Register ("opentk_1_1/GameViewBase")]
    public abstract class GameViewBase : SurfaceView, IGameWindow
    {
        private IGraphicsContext graphicsContext;

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
        public IGraphicsContext GraphicsContext {
            get {
                return graphicsContext;
            }
            protected set {
                graphicsContext = value;
                OnContextSet (null);
            }
        }

        /// <summary>
        ///   Controls whether the graphics context is recreated when the display
        ///   size changes.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool AutoResize { get; set; }

        protected virtual void CreateFrameBuffer ()
        {
        }

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
            if (Load != null)
                Load (this, e);
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
            if (Unload != null)
                Unload (this, e);
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
            if (UpdateFrame != null)
                UpdateFrame (this, e);
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
            if (RenderFrame != null)
                RenderFrame (this, e);
        }

        /// <summary>
        ///   Starts as-fast-as-possible run-loop processing.
        /// </summary>
        /// <remarks>
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

        /// <param name="updateRate">
        ///   A <see cref="T:System.Double" /> containing the number of frames per
        ///   second that should be updated and rendered.
        /// </param>
        /// <summary>
        ///   Starts run-loop processing at a rate of <paramref name="updateRate" />
        ///   frames per second.
        /// </summary>
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
        ///   Occurs when the view is disposed
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event EventHandler<EventArgs> Disposed;

        /// <summary>
        ///   Raises the
        ///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.Disposed" />
        ///   event.
        /// </summary>
        /// <param name="e">
        ///   An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
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
        /// </remarks>
        protected virtual void OnDisposed (EventArgs e)
        {
            if (Disposed != null)
                Disposed (this, e);
        }

        /// <summary>
        ///   Occurs when the
        ///   <see cref="T:OpenTK.Platform.Android.AndroidGameView" />
        ///   detects that the <see cref="P:OpenTK.Platform.Android.AndroidGameView.GraphicsContext"> was lost.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event EventHandler<EventArgs> ContextLost;

        /// <param name="e">
        ///   An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <summary>
        ///   Raises the
        ///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.ContextLost" />
        ///   event.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     The <c>OnContextLost</c> method also allows derived classes to handle
        ///     the event without attaching a delegate.  This is the preferred
        ///     technique for handling the event in a derived class.
        ///   </para>
        ///   <block subset="none" type="overrides">
        ///     When overriding <c>OnContextLost</c> in a derived class, be sure to
        ///     call the base class's <c>OnContextLost</c> method so that registered
        ///     delegates receive the event.
        ///   </block>
        /// </remarks>
        protected virtual void OnContextLost (EventArgs e)
        {
            if (ContextLost != null)
                ContextLost (this, e);
        }

        /// <summary>
        ///   Occurs when the
        ///   <see cref="P:OpenTK.Platform.Android.AndroidGameView.GraphicsContext" />
        ///   is created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event EventHandler<EventArgs> ContextSet;

        /// <param name="e">
        ///   An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <summary>
        ///   Raises the
        ///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.ContextSet" />
        ///   event.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     The <c>OnContextSet</c> method also allows derived classes to handle
        ///     the event without attaching a delegate.  This is the preferred
        ///     technique for handling the event in a derived class.
        ///   </para>
        ///   <block subset="none" type="overrides">
        ///     When overriding <c>OnContextSet</c> in a derived class, be sure to
        ///     call the base class's <c>OnContextSet</c> method so that registered
        ///     delegates receive the event.
        ///   </block>
        ///   <block>
        ///   It is convenient place to create context related data, ie. load textures.
        ///   </block>
        /// </remarks>
        protected virtual void OnContextSet (EventArgs e)
        {
            if (ContextSet != null)
                ContextSet (this, e);
        }

        /// <summary>
        ///   Occurs when the separate rendering thread exits without cancelation request.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event EventHandler<EventArgs> RenderThreadExited;

        /// <param name="e">
        ///   An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <summary>
        ///   Raises the
        ///   <see cref="E:OpenTK.Platform.Android.AndroidGameView.RenderThreadExited" />
        ///   event.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     The <c>OnRenderThreadExited</c> method also allows derived classes to handle
        ///     the event without attaching a delegate.  This is the preferred
        ///     technique for handling the event in a derived class.
        ///   </para>
        ///   <block subset="none" type="overrides">
        ///     When overriding <c>OnRenderThreadExited</c> in a derived class, be sure to
        ///     call the base class's <c>OnRenderThreadExited</c> method so that registered
        ///     delegates receive the event.
        ///   </block>
        ///   <block>
        ///   It is convenient place to handle errors.
        ///   </block>
        /// </remarks>
        protected virtual void OnRenderThreadExited (EventArgs e)
        {
            if (RenderThreadExited != null)
                RenderThreadExited (this, e);
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
        public virtual void Close ()
        {
            OnClosed (EventArgs.Empty);
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

        public virtual int Width {
            get; set;
        }

        public virtual int Height {
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
        /// <exception cref="T:System.ObjectDisposedException">
        ///   The instance has had
        ///   <see cref="M:OpenTK.Platform.Android.AndroidGameView.Dispose" />
        ///   invoked on it.
        /// </exception>
        public virtual IWindowInfo WindowInfo {
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
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public virtual WindowState WindowState {
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
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public virtual WindowBorder WindowBorder {
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
        public virtual Rectangle Bounds {
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
        public virtual Point Location {
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
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public virtual Size Size {
            get {
                throw new NotImplementedException ();
            }
            set {
                throw new NotImplementedException ();
            }
        }

        /// <summary>This member is not supported.</summary>
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

        MouseCursor INativeWindow.Cursor
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        bool INativeWindow.CursorVisible
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        Icon INativeWindow.Icon
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        event EventHandler<EventArgs> INativeWindow.IconChanged
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<KeyboardKeyEventArgs> INativeWindow.KeyDown
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<KeyboardKeyEventArgs> INativeWindow.KeyUp
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<MouseButtonEventArgs> INativeWindow.MouseDown
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<MouseMoveEventArgs> INativeWindow.MouseMove
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<MouseButtonEventArgs> INativeWindow.MouseUp
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        event EventHandler<MouseWheelEventArgs> INativeWindow.MouseWheel
        {
            add { throw new NotSupportedException(); }
            remove { throw new NotSupportedException(); }
        }

        #endregion
    }
}
