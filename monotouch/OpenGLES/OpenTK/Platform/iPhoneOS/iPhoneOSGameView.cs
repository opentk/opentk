#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2009 Novell, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;

using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.OpenGLES;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES11;
using OpenTK.Platform;
using OpenTK.Platform.iPhoneOS;

namespace OpenTK.Platform.iPhoneOS
{
    public class iPhoneOSGameView : UIView, IGameWindow
    {
        bool disposed;
        bool hasBeenCurrent;

        int framebuffer, renderbuffer;

        [Export("initWithCoder:")]
        public iPhoneOSGameView(NSCoder coder)
            : base(coder)
        {
        }

        [Export("initWithFrame:")]
        public iPhoneOSGameView(RectangleF frame)
            : base(frame)
        {
        }

        [Export ("layerClass")]
        public static Class GetLayerClass ()
        {
            return new Class (typeof (CAEAGLLayer));
        }

        void AssertValid()
        {
            if (disposed)
                throw new ObjectDisposedException("");
        }
        EAGLRenderingAPI api;
        public EAGLRenderingAPI ContextRenderingApi {
            get {
                AssertValid();
                return api;
            }
            set {
                AssertValid();
                if (GraphicsContext != null)
                    throw new NotSupportedException("Can't change RenderingApi after GraphicsContext is constructed.");
                this.api = value;
            }
        }

        public IGraphicsContext GraphicsContext {get; set;}
        public EAGLContext EAGLContext {
            get {
                AssertValid();
                if (GraphicsContext != null) {
                    iPhoneOSGraphicsContext c = GraphicsContext as iPhoneOSGraphicsContext;
                    if (c != null)
                        return c.EAGLContext;
                    var i = GraphicsContext as IGraphicsContextInternal;
                    IGraphicsContext ic = i == null ? null : i.Implementation;
                    c = ic as iPhoneOSGraphicsContext;
                    if (c != null)
                        return c.EAGLContext;
                }
                return null;
            }
        }

        bool retainedBacking;
        public bool LayerRetainsBacking {
            get {
                AssertValid();
                return retainedBacking;
            }
            set {
                AssertValid();
                if (GraphicsContext != null)
                    throw new NotSupportedException("Can't change LayerRetainsBacking after GraphicsContext is constructed.");
                retainedBacking = value;
            }
        }

        NSString colorFormat;
        public NSString LayerColorFormat {
            get {
                AssertValid();
                return colorFormat;
            }
            set {
                AssertValid();
                if (GraphicsContext != null)
                    throw new NotSupportedException("Can't change LayerColorFormat after GraphicsContext is constructed.");
                colorFormat = value;
            }
        }

        public int Framebuffer {
            get {return framebuffer;}
        }

        public int Renderbuffer {
            get {return renderbuffer;}
        }

        public bool AutoResize {get; set;}

        UIViewController GetViewController()
        {
            UIResponder r = this;
            while (r != null) {
                var c = r as UIViewController;
                if (c != null)
                    return c;
                r = r.NextResponder;
            }
            return null;
        }

        public virtual string Title {
            get {
                AssertValid();
                var c = GetViewController();
                if (c != null)
                    return c.Title;
                throw new NotSupportedException();
            }
            set {
                AssertValid();
                var c = GetViewController();
                if (c != null) {
                    if (c.Title != value) {
                        c.Title = value;
                        OnTitleChanged(EventArgs.Empty);
                    }
                }
                else
                    throw new NotSupportedException();
            }
        }

        protected virtual void OnTitleChanged(EventArgs e)
        {
            var h = TitleChanged;
            if (h != null)
                h (this, EventArgs.Empty);
        }

        bool INativeWindow.Focused {
            get {throw new NotImplementedException();}
        }

        public virtual bool Visible {
            get {
                AssertValid();
                return !base.Hidden;
            }
            set {
                AssertValid();
                if (base.Hidden != !value) {
                    base.Hidden = !value;
                    OnVisibleChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnVisibleChanged(EventArgs e)
        {
            var h = VisibleChanged;
            if (h != null)
                h (this, EventArgs.Empty);
        }

        bool INativeWindow.Exists {
            get {throw new NotImplementedException();}
        }

        public virtual IWindowInfo WindowInfo {
            get {
                AssertValid();
                return null;
            }
        }

        public virtual WindowState WindowState {
            get {
                AssertValid();
                var c = GetViewController();
                if (c != null && c.WantsFullScreenLayout)
                    return WindowState.Fullscreen;
                return WindowState.Normal;
            }
            set {
                AssertValid();
                var c = GetViewController();
                if (c != null) {
                    if (c.WantsFullScreenLayout == (value == WindowState.Fullscreen)) {
                        c.WantsFullScreenLayout = value == WindowState.Fullscreen;
                        OnWindowStateChanged(EventArgs.Empty);
                    }
                }
            }
        }

        protected virtual void OnWindowStateChanged(EventArgs e)
        {
            var h = WindowStateChanged;
            if (h != null)
                h (this, EventArgs.Empty);
        }

        public virtual WindowBorder WindowBorder {
            get {
                AssertValid();
                return WindowBorder.Hidden;
            }
            set {}
        }

        Rectangle INativeWindow.Bounds {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        Point INativeWindow.Location {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        Size size;
        public Size Size {
            get {
                AssertValid();
                return size;
            }
            set {
                AssertValid();
                if (size != value) {
                    size = value;
                    OnResize(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnResize(EventArgs e)
        {
            var h = Resize;
            if (h != null)
                h (this, e);
        }

        int INativeWindow.X {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        int INativeWindow.Y {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        int INativeWindow.Width {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        int INativeWindow.Height {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        Rectangle INativeWindow.ClientRectangle {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        Size INativeWindow.ClientSize {
            get {throw new NotSupportedException();}
            set {throw new NotSupportedException();}
        }

        protected virtual void CreateFrameBuffer()
        {
            AssertValid();
            if (LayerColorFormat == null)
                throw new InvalidOperationException("Set the LayerColorFormat property to an EAGLColorFormat value before calling Run().");

            CAEAGLLayer eaglLayer = (CAEAGLLayer) Layer;
            eaglLayer.DrawableProperties = NSDictionary.FromObjectsAndKeys (
                    new NSObject [] {NSNumber.FromBoolean(LayerRetainsBacking), LayerColorFormat},
                    new NSObject [] {EAGLDrawableProperty.RetainedBacking,      EAGLDrawableProperty.ColorFormat}
            );
            ConfigureLayer(eaglLayer);

            GraphicsContext = Utilities.CreateGraphicsContext(ContextRenderingApi);

            int oldFramebuffer = 0, oldRenderbuffer = 0;
            GL.GetInteger(All.FramebufferBindingOes, ref oldFramebuffer);
            GL.GetInteger(All.RenderbufferBindingOes, ref oldRenderbuffer);

            GL.Oes.GenRenderbuffers(1, ref renderbuffer);
            GL.Oes.BindRenderbuffer(All.RenderbufferOes, renderbuffer);

            if (!EAGLContext.RenderBufferStorage((uint) All.RenderbufferOes, eaglLayer)) {
                GL.Oes.DeleteRenderbuffers(1, ref renderbuffer);
                renderbuffer = 0;
                GL.Oes.BindRenderbuffer(All.RenderbufferBindingOes, oldRenderbuffer);
                throw new InvalidOperationException("Error with EAGLContext.RenderBufferStorage!");
            }

            GL.Oes.GenFramebuffers (1, ref framebuffer);
            GL.Oes.BindFramebuffer (All.FramebufferOes, framebuffer);
            GL.Oes.FramebufferRenderbuffer (All.FramebufferOes, All.ColorAttachment0Oes, All.RenderbufferOes, renderbuffer);

            Size newSize = new Size(
                    (int) Math.Round(eaglLayer.Bounds.Size.Width), 
                    (int) Math.Round(eaglLayer.Bounds.Size.Height));
            Size = newSize;

            if (!hasBeenCurrent) {
                GL.Viewport(0, 0, newSize.Width, newSize.Height);
                GL.Scissor(0, 0, newSize.Width, newSize.Height);
                hasBeenCurrent = true;
            }
            else
                GL.Oes.BindFramebuffer(All.FramebufferOes, oldFramebuffer);
        }

        protected virtual void ConfigureLayer(CAEAGLLayer eaglLayer)
        {
        }

        protected virtual void DestroyFrameBuffer()
        {
            AssertValid();
            EAGLContext oldContext = EAGLContext.CurrentContext;
            if (!GraphicsContext.IsCurrent)
                MakeCurrent();

            GL.Oes.DeleteFramebuffers (1, ref framebuffer);
            GL.Oes.DeleteRenderbuffers (1, ref renderbuffer);
            framebuffer = renderbuffer = 0;

            if (oldContext != EAGLContext)
                EAGLContext.SetCurrentContext(oldContext);
            else
                EAGLContext.SetCurrentContext(null);

            EAGLContext.Dispose();
            GraphicsContext = null;
        }

        public virtual void Close()
        {
            AssertValid();
            OnClosed(EventArgs.Empty);
        }

        protected virtual void OnClosed(EventArgs e)
        {
            var h = Closed;
            if (h != null)
                h (this, e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing) {
                DestroyFrameBuffer();
            }
            base.Dispose (disposing);
            disposed = true;
            if (disposing)
                OnDisposed(EventArgs.Empty);
        }

        protected virtual void OnDisposed(EventArgs e)
        {
            var h = Disposed;
            if (h != null)
                h (this, e);
        }

        void INativeWindow.ProcessEvents()
        {
            throw new NotSupportedException();
        }

        Point INativeWindow.PointToClient(Point point)
        {
            return point;
        }

        Point INativeWindow.PointToScreen(Point point)
        {
            return point;
        }

        public override void LayoutSubviews()
        {
            if (GraphicsContext == null)
                return;

            var bounds = Bounds;
            if (AutoResize && (Math.Round(bounds.Width) != Size.Width ||
                        Math.Round(bounds.Height) != Size.Height)) {
                DestroyFrameBuffer();
                CreateFrameBuffer();
            }
        }

        public virtual void MakeCurrent()
        {
            AssertValid();
            GraphicsContext.MakeCurrent(WindowInfo);
        }

        public virtual void SwapBuffers()
        {
            AssertValid();
            GL.Oes.BindRenderbuffer(All.RenderbufferOes, renderbuffer);
            GraphicsContext.SwapBuffers();
        }

        NSTimer timer;

        public void Run()
        {
            AssertValid();
            CreateFrameBuffer();
            OnLoad(EventArgs.Empty);
            NSAction action = null;
            action = () => {
                RunIteration();
                timer = NSTimer.CreateTimer(TimeSpan.FromSeconds(0), action);
            };
            timer = NSTimer.CreateTimer(TimeSpan.FromSeconds(0), action);
        }

        public void Run(double updatesPerSecond)
        {
            AssertValid();
            if (updatesPerSecond == 0.0) {
                Run();
                return;
            }
            CreateFrameBuffer();
            OnLoad(EventArgs.Empty);
            timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(1 / updatesPerSecond), RunIteration);
        }

        public void Stop()
        {
            AssertValid();
            if (timer != null)
                timer.Invalidate();
            timer = null;
            OnUnload(EventArgs.Empty);
        }

        public override void WillMoveToWindow(UIWindow window)
        {
            if (timer != null && window == null)
                Stop();
        }

        DateTime prevUpdateTime;
        DateTime prevRenderTime;

        FrameEventArgs updateEventArgs = new FrameEventArgs();
        FrameEventArgs renderEventArgs = new FrameEventArgs();

        void RunIteration()
        {
            var curUpdateTime = DateTime.Now;
            if (prevUpdateTime.Ticks == 0)
                prevUpdateTime = curUpdateTime;
            updateEventArgs.Time = (curUpdateTime - prevUpdateTime).TotalSeconds;
            OnUpdateFrame(updateEventArgs);
            prevUpdateTime = curUpdateTime;

            GL.Oes.BindFramebuffer(All.FramebufferOes, framebuffer);

            var curRenderTime = DateTime.Now;
            if (prevRenderTime.Ticks == 0)
                prevRenderTime = curRenderTime;
            renderEventArgs.Time = (curRenderTime - prevRenderTime).TotalSeconds;
            OnRenderFrame(renderEventArgs);
            prevRenderTime = curRenderTime;
        }

        protected virtual void OnLoad(EventArgs e)
        {
            var h = Load;
            if (h != null)
                h (this, e);
        }

        protected virtual void OnUnload(EventArgs e)
        {
            var h = Unload;
            DestroyFrameBuffer();
            if (h != null)
                h (this, e);
        }

        protected virtual void OnUpdateFrame(FrameEventArgs e)
        {
            var h = UpdateFrame;
            if (h != null)
                h (this, e);
        }

        protected virtual void OnRenderFrame(FrameEventArgs e)
        {
            var h = RenderFrame;
            if (h != null)
                h (this, e);
        }

        event EventHandler<EventArgs> INativeWindow.Move {
            add {throw new NotSupportedException();}
            remove {throw new NotSupportedException();}
        }
        public event EventHandler<EventArgs> Resize;
        event EventHandler<CancelEventArgs> INativeWindow.Closing {
            add {throw new NotSupportedException();}
            remove {throw new NotSupportedException();}
        }
        public event EventHandler<EventArgs> Closed;
        public event EventHandler<EventArgs> Disposed;
        public event EventHandler<EventArgs> TitleChanged;
        public event EventHandler<EventArgs> VisibleChanged;
        event EventHandler<EventArgs> INativeWindow.FocusedChanged {
            add {throw new NotSupportedException();}
            remove {throw new NotSupportedException();}
        }
        event EventHandler<EventArgs> INativeWindow.WindowBorderChanged {
            add {throw new NotSupportedException();}
            remove {throw new NotSupportedException();}
        }
        public event EventHandler<EventArgs> WindowStateChanged;
        event EventHandler<KeyPressEventArgs> INativeWindow.KeyPress {
            add {throw new NotSupportedException();}
            remove {throw new NotSupportedException();}
        }

        public event EventHandler<EventArgs> Load;
        public event EventHandler<EventArgs> Unload;
        public event EventHandler<FrameEventArgs> UpdateFrame;
        public event EventHandler<FrameEventArgs> RenderFrame;
    }
}

// vim: et ts=4 sw=4
