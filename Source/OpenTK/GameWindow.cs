#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Platform;
using System.Drawing;

namespace OpenTK
{
    /// <summary>
    /// The GameWindow class contains cross-platform methods to create and render on an OpenGL
    /// window, handle input and load resources.
    /// </summary>
    /// <remarks>
    /// GameWindow contains several events you can hook or override to add your custom logic:
    /// <list>
    /// <item>
    /// OnLoad: Occurs after creating the OpenGL context, but before entering the main loop.
    /// Override to load resources.
    /// </item>
    /// <item>
    /// OnUnload: Occurs after exiting the main loop, but before deleting the OpenGL context.
    /// Override to unload resources.
    /// </item>
    /// <item>
    /// OnResize: Occurs whenever GameWindow is resized. You should update the OpenGL Viewport
    /// and Projection Matrix here.
    /// </item>
    /// <item>
    /// OnUpdateFrame: Occurs at the specified logic update rate. Override to add your game
    /// logic.
    /// </item>
    /// <item>
    /// OnRenderFrame: Occurs at the specified frame render rate. Override to add your
    /// rendering code.
    /// </item>
    /// </list>
    /// Call the Run() method to start the application's main loop. Run(double, double) takes two
    /// parameters that
    /// specify the logic update rate, and the render update rate.
    /// </remarks>
    public class GameWindow : IGameWindow
    {
        #region --- Fields ---

        INativeWindow glWindow;
        //DisplayMode mode;

        bool isExiting = false;
        bool hasMainLoop;
        bool disposed;

        double update_period, render_period;
        double target_update_period, target_render_period;
        // TODO: Implement these:
        double update_time, render_time;//, event_time;
        //bool allow_sleep = true;    // If true, GameWindow will call Timer.Sleep() if there is enough time.
        VSyncMode vsync;

        //InputDriver input_driver;

        IGraphicsContext glContext;

        int main_loop_thread_id;
        object exit_lock = new object();

        #endregion

        #region --- Contructors ---

        #region public GameWindow()

        /// <summary>Constructs a new GameWindow with sensible default attributes..</summary>
        public GameWindow()
            : this(640, 480, GraphicsMode.Default, "OpenTK Game Window", 0, DisplayDevice.Default) { }

        #endregion

        #region public GameWindow(int width, int height)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        public GameWindow(int width, int height)
            : this(width, height, GraphicsMode.Default, "OpenTK Game Window", 0, DisplayDevice.Default) { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        public GameWindow(int width, int height, GraphicsMode mode)
            : this(width, height, mode, "OpenTK Game Window", 0, DisplayDevice.Default) { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode, string title)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        /// <param name="title">The title of the GameWindow.</param>
        public GameWindow(int width, int height, GraphicsMode mode, string title)
            : this(width, height, mode, title, 0, DisplayDevice.Default) { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        /// <param name="title">The title of the GameWindow.</param>
        /// <param name="options">GameWindow options regarding window appearance and behavior.</param>
        public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options)
            : this(width, height, mode, title, options, DisplayDevice.Default) { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        /// <param name="title">The title of the GameWindow.</param>
        /// <param name="options">GameWindow options regarding window appearance and behavior.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the GameWindow in.</param>
        public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device)
            : this(width, height, mode, title, options, device, 1, 0, GraphicsContextFlags.Default)
        { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags)

                /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        /// <param name="title">The title of the GameWindow.</param>
        /// <param name="options">GameWindow options regarding window appearance and behavior.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the GameWindow in.</param>
        /// <param name="major">The major version for the OpenGL GraphicsContext.</param>
        /// <param name="minor">The minor version for the OpenGL GraphicsContext.</param>
        /// <param name="flags">The GraphicsContextFlags version for the OpenGL GraphicsContext.</param>
        public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device,
            int major, int minor, GraphicsContextFlags flags)
            : this(width, height, mode, title, options, device, major, minor, flags, null)
        { }

        #endregion

        #region public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags, IGraphicsContext sharedContext)

        /// <summary>Constructs a new GameWindow with the specified attributes.</summary>
        /// <param name="width">The width of the GameWindow in pixels.</param>
        /// <param name="height">The height of the GameWindow in pixels.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GameWindow.</param>
        /// <param name="title">The title of the GameWindow.</param>
        /// <param name="options">GameWindow options regarding window appearance and behavior.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the GameWindow in.</param>
        /// <param name="major">The major version for the OpenGL GraphicsContext.</param>
        /// <param name="minor">The minor version for the OpenGL GraphicsContext.</param>
        /// <param name="flags">The GraphicsContextFlags version for the OpenGL GraphicsContext.</param>
        /// <param name="sharedContext">An IGraphicsContext to share resources with.</param>
        public GameWindow(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device,
            int major, int minor, GraphicsContextFlags flags, IGraphicsContext sharedContext)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException("height", "Must be greater than zero.");
            if (mode == null)
                mode = GraphicsMode.Default;
            if (device == null)
                device = DisplayDevice.Default;

            try
            {
                Rectangle window_bounds = new Rectangle();
                window_bounds.X = device.Bounds.Left + (device.Bounds.Width - width) / 2;
                window_bounds.Y = device.Bounds.Top + (device.Bounds.Height - height) / 2;
                window_bounds.Width = width;
                window_bounds.Height = height;
                glWindow = Platform.Factory.Default.CreateNativeWindow(
                    window_bounds.X, window_bounds.Y,
                    window_bounds.Width, window_bounds.Height,
                    title, mode, options, device);

                glContext = new GraphicsContext(mode, glWindow.WindowInfo, major, minor, flags);
                glContext.MakeCurrent(this.WindowInfo);
                (glContext as IGraphicsContextInternal).LoadAll();

                if ((options & GameWindowFlags.Fullscreen) != 0)
                {
                    device.ChangeResolution(width, height, mode.ColorFormat.BitsPerPixel, 0);
                    this.WindowState = WindowState.Fullscreen;
                }

                this.VSync = VSyncMode.On;
                
                glWindow.Move += delegate(object sender, EventArgs e) { OnMoveInternal(e); };
                glWindow.Resize += delegate(object sender, EventArgs e) { OnResizeInternal(e); };
                glWindow.Closing += delegate(object sender, CancelEventArgs e) { OnClosingInternal(e); };
                glWindow.Closed += delegate(object sender, EventArgs e) { OnClosedInternal(e); };
                //glWindow.WindowInfoChanged += delegate(object sender, EventArgs e) { OnWindowInfoChangedInternal(e); };
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                if (glWindow != null)
                    glWindow.Dispose();
                throw;
            }
        }

        #endregion
 
        #region Obsolete

        /// <summary>
        /// Constructs a new GameWindow, and opens a render window with the specified DisplayMode.
        /// </summary>
        /// <param name="mode">The DisplayMode of the GameWindow.</param>
        [Obsolete]
        public GameWindow(DisplayMode mode)
            : this(mode.Width, mode.Height, mode.ToGraphicsMode(), "OpenTK Game Window", mode.Fullscreen ? GameWindowFlags.Fullscreen : 0) { }

        /// <summary>
        /// Constructs a new GameWindow with the specified title, and opens a render window with the
        /// specified DisplayMode.
        /// </summary>
        /// <param name="mode">The DisplayMode of the GameWindow.</param>
        /// <param name="title">The Title of the GameWindow.</param>
        [Obsolete]
        public GameWindow(DisplayMode mode, string title)
            : this(mode.Width, mode.Height, mode.ToGraphicsMode(), title, mode.Fullscreen ? GameWindowFlags.Fullscreen : 0) { }

        #endregion

        #endregion

        #region --- Private Methods ---

        #region void ExitInternal()

        // Stops the main loop, if one exists.
        void ExitInternal()
        {
            if (HasMainLoop)
            {
                throw new GameWindowExitException();
            }
        }

        #region void ExitAsync()

        // Gracefully exits the GameWindow. May be called from any thread.
        void ExitAsync()
        {
            HasMainLoop = false;
            isExiting = true;
            //UpdateFrame += delegate
            //{
            //    ExitInternal();
            //};
        }

        #endregion

        #endregion

        #region bool MustResize

        bool MustResize
        {
            get { return glWindow.Width != this.Width || glWindow.Height != this.Height; }
        }

        #endregion

        #region bool HasMainLoop

        bool HasMainLoop
        {
            get { return hasMainLoop; }
            set { hasMainLoop = value; }
        }

        #endregion

        #region OnMoveInternal

        // Calls OnMove and raises the Move event.
        void OnMoveInternal(EventArgs e)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            if (!this.Exists || this.IsExiting)
                return;

            OnMove(e);

            if (Move != null)
                Move(this, e);
        }
        
        #endregion

        #region OnResizeInternal

        // Calls OnResize and raises the Resize event.
        void OnResizeInternal(EventArgs e)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            if (!this.Exists || this.IsExiting)
                return;

            OnResize(e);

            if (Resize != null)
                Resize(this, e);
        }

        #endregion

        #region OnClosingInternal

        void OnClosingInternal(CancelEventArgs e)
        {
            OnClosing(e);

            if (Closing != null)
                Closing(this, e);

            if (!e.Cancel)
                ExitAsync();
        }

        #endregion

        #region OnClosedInternal

        void OnClosedInternal(EventArgs e)
        {
            OnClosed(e);

            if (Closed != null)
                Closed(this, e);
        }

        #endregion

        #region OnWindowInfoChangedInternal

        void OnWindowInfoChangedInternal(EventArgs e)
        {
            glContext.MakeCurrent(WindowInfo);

            OnWindowInfoChanged(e);
        }

        #endregion

        #region OnUpdateFrameInternal

        private void OnUpdateFrameInternal(FrameEventArgs e)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            if (!this.Exists || this.IsExiting)
                return;

            if (UpdateFrame != null)
                UpdateFrame(this, e);

            OnUpdateFrame(e);
        }

        #endregion

        #region OnRenderFrameInternal

        private void OnRenderFrameInternal(FrameEventArgs e)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            if (!this.Exists || this.IsExiting)
                return;

            if (RenderFrame != null)
                RenderFrame(this, e);

            OnRenderFrame(e);
        }

        #endregion

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Called when the GameWindow is moved.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnMove(EventArgs e)
        { }
        
        /// <summary>
        /// Called when the GameWindow is resized.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnResize(EventArgs e)
        { }

        /// <summary>
        /// Called when the GameWindow is about to close.
        /// </summary>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.CancelEventArgs" /> for this event.
        /// Set e.Cancel to true in order to stop the GameWindow from closing.</param>
        protected virtual void OnClosing(CancelEventArgs e)
        { }

        /// <summary>
        /// Called when the GameWindow has closed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnClosed(EventArgs e)
        { }

        /// <summary>
        /// Called when the WindowInfo for this GameWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnWindowInfoChanged(EventArgs e)
        { }

        #endregion

        #region --- Public Members ---

        #region public virtual void Exit()

        /// <summary>
        /// Gracefully exits the GameWindow. May be called from any thread.
        /// </summary>
        /// <remarks>
        /// <para>Override if you are not using <see cref="GameWindow.Run()"/>.</para>
        /// <para>If you override this method, place a call to base.Exit(), to ensure proper OpenTK shutdown.</para>
        /// </remarks>
        public virtual void Exit()
        {
            lock (exit_lock)
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                if (!IsExiting && Exists)
                {
                    CancelEventArgs e = new CancelEventArgs();
                    OnClosingInternal(e);
                    if (e.Cancel)
                        return;

                    isExiting = true;
                    
                    if (HasMainLoop)
                    {
                        if (main_loop_thread_id == Thread.CurrentThread.ManagedThreadId)
                            ExitInternal();
                        else
                            ExitAsync();
                    }
                }
            }
        }

        #endregion

        #region public IGraphicsContext Context

        /// <summary>
        /// Returns the opengl IGraphicsContext associated with the current GameWindow.
        /// </summary>
        public IGraphicsContext Context
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);
                return glContext;
            }
        }

        #endregion

        #region public bool Exists

        /// <summary>
        /// Gets a value indicating whether a render window exists.
        /// </summary>
        public bool Exists
        {
            get { return glWindow == null ? false : glWindow.Exists; }
        }

        #endregion

        #region public string Text

        /// <summary>
        /// Gets or sets the GameWindow title.
        /// </summary>
        public string Title
        {
            get
            {
                if (disposed) throw new ObjectDisposedException(this.GetType().Name);
                return glWindow.Title;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException(this.GetType().Name);
                glWindow.Title = value;
            }
        }

        #endregion

        #region public bool Visible
#if false
        /// <summary>
        /// TODO: This property is not implemented
        /// Gets or sets a value indicating whether the GameWindow is visible.
        /// </summary>
        public bool Visible
        {
            get
            {
                throw new NotImplementedException();
                //return glWindow.Visible;
            }
            set
            {
                throw new NotImplementedException();
                //glWindow.Visible = value;
            }
        }
#endif
        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return glWindow.WindowInfo; }
        }

        #endregion

        #region public void Run()

        /// <summary>
        /// Enters the game loop of the GameWindow using the maximum update rate.
        /// </summary>
        /// <seealso cref="Run(double)"/>
        public void Run()
        {
            if (disposed) throw new ObjectDisposedException(this.GetType().Name);
            Run(0.0, 0.0);
        }

        #endregion

        #region public void Run(double updateFrequency)

        /// <summary>
        /// Enters the game loop of the GameWindow using the specified update rate.
        /// maximum possible render frequency.
        /// </summary>
        public void Run(double updateRate)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);
            
            Run(updateRate, 0.0);
        }

        #endregion

        #region public void Run(double updates_per_second, double frames_per_second)

        /// <summary>
        /// Enters the game loop of the GameWindow updating and rendering at the specified frequency.
        /// </summary>
        /// <param name="updates_per_second">The frequency of UpdateFrame events.</param>
        /// <param name="frames_per_second">The frequency of RenderFrame events.</param>
        public void Run(double updates_per_second, double frames_per_second)
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            try
            {
                // Necessary to be here, otherwise Exit() wouldn't work correctly when called inside OnLoad().
                hasMainLoop = true;
                main_loop_thread_id = Thread.CurrentThread.ManagedThreadId;
                
                if (updates_per_second < 0.0 || updates_per_second > 200.0)
                    throw new ArgumentOutOfRangeException("updates_per_second", updates_per_second,
                                                          "Parameter should be inside the range [0.0, 200.0]");
                if (frames_per_second < 0.0 || frames_per_second > 200.0)
                    throw new ArgumentOutOfRangeException("frames_per_second", frames_per_second,
                                                          "Parameter should be inside the range [0.0, 200.0]");

                TargetUpdateFrequency = updates_per_second;
                TargetRenderFrequency = frames_per_second;

                Stopwatch update_watch = new Stopwatch(), render_watch = new Stopwatch();
                double time, next_render = 0.0, next_update = 0.0, update_time_counter = 0.0;
                int num_updates = 0;
                FrameEventArgs update_args = new FrameEventArgs();
                FrameEventArgs render_args = new FrameEventArgs();

                update_watch.Reset();
                render_watch.Reset();

                OnLoadInternal(EventArgs.Empty);
                OnResizeInternal(EventArgs.Empty);

                Debug.Print("Entering main loop.");
                while (!IsExiting && HasMainLoop)
                {
                    ProcessEvents();

                    // Raise UpdateFrame events
                    time = update_watch.Elapsed.TotalSeconds;
                    if (time > 1.0)
                        time = 1.0;
                    while (next_update - time <= 0.0)
                    {
                        next_update = next_update - time + TargetUpdatePeriod;
                        if (next_update < -1.0)       // Cap the maximum time drift, to avoid lengthy catch-up games.
                            next_update = -1.0;

                        update_time_counter += time;
                        ++num_updates;

                        update_watch.Reset();
                        update_watch.Start();

                        if (time > 0)
                        {
                            update_args.Time = time;
                            OnUpdateFrameInternal(update_args);
                            update_time = update_watch.Elapsed.TotalSeconds;
                        }
                        if (TargetUpdateFrequency == 0.0)
                            break;

                        time = update_watch.Elapsed.TotalSeconds;
                        next_update -= time;
                        update_time_counter += time;

                        // Allow up to 10 frames to be dropped. Prevents the application from hanging
                        // with very high update frequencies.
                        if (num_updates >= 10)
                            break;
                    }
                    if (num_updates > 0)
                    {
                        update_period = update_time_counter / (double)num_updates;
                        num_updates = 0;
                        update_time_counter = 0.0;
                    }

                    // Raise RenderFrame event
                    time = render_watch.Elapsed.TotalSeconds;
                    if (time > 1.0)
                        time = 1.0;
                    double time_left = next_render - time;
                    if (VSync == VSyncMode.Adaptive)
                    {
                        // Check if we have enough time for a vsync
                        if (TargetRenderPeriod != 0 && RenderTime > 2.0 * TargetRenderPeriod)
                            Context.VSync = false;
                        else
                            Context.VSync = true;
                    }

                    if (time_left <= 0.0)
                    {
                        next_render = time_left + TargetRenderPeriod;
                        if (next_render < -1.0)       // Cap the maximum time drift, to avoid lengthy catch-up games.
                            next_render = -1.0;

                        render_watch.Reset();
                        render_watch.Start();

                        if (time > 0)
                        {
                            render_period = render_args.Time = time;
                            OnRenderFrameInternal(render_args);
                            render_time = render_watch.Elapsed.TotalSeconds;
                        }
                    }
                }
            }
            catch (GameWindowExitException)
            {
                Debug.WriteLine("GameWindowExitException caught - exiting main loop.");
            }
            finally
            {
                Debug.Print("Restoring priority.");
                Thread.CurrentThread.Priority = ThreadPriority.Normal;

                OnUnloadInternal(EventArgs.Empty);

                if (Exists)
                {
                    glContext.Dispose();
                    glContext = null;
                    
                    glWindow.Dispose();
                    while (this.Exists)
                        this.ProcessEvents();
                    glWindow = null;
                }
            }
        }

        #endregion

        #region public void ProcessEvents()

        /// <summary>
        /// Processes operating system events until the GameWindow becomes idle.
        /// </summary>
        /// <remarks>
        /// When overriding the default GameWindow game loop (provided by the Run() function)
        /// you should call ProcessEvents() to ensure that your GameWindow responds to
        /// operating system events.
        /// <para>
        /// Once ProcessEvents() returns, it is time to call update and render the next frame.
        /// </para>
        /// </remarks>
        public void ProcessEvents()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);
            
            glWindow.ProcessEvents();
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Override in derived classes to render a frame.
        /// </summary>
        /// <param name="e">Contains information necessary for frame rendering.</param>
        /// <remarks>
        /// The base implementation (base.OnRenderFrame) is empty, there is no need to call it.
        /// </remarks>
        protected virtual void OnRenderFrame(FrameEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        public event EventHandler<FrameEventArgs> RenderFrame;

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Override in derived classes to update a frame.
        /// </summary>
        /// <param name="e">Contains information necessary for frame updating.</param>
        /// <remarks>
        /// The base implementation (base.OnUpdateFrame) is empty, there is no need to call it.
        /// </remarks>
        protected virtual void OnUpdateFrame(FrameEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        public event EventHandler<FrameEventArgs> UpdateFrame;

        #endregion

        #region OnLoad

        /// <summary>
        /// Raises the Load event, and calls the user's OnLoad override.
        /// </summary>
        /// <param name="e"></param>
        private void OnLoadInternal(EventArgs e)
        {
            Debug.Print("{0}.Load", this.GetType().Name);
            Debug.WriteLine(String.Format("OpenGL driver information: {0}, {1}, {2}",
                GL.GetString(StringName.Renderer),
                GL.GetString(StringName.Vendor),
                GL.GetString(StringName.Version)));

            OnResizeInternal(EventArgs.Empty);
            Load(this, e);
            OnLoad(e);
        }

        /// <summary>
        /// Occurs after establishing an OpenGL context, but before entering the main loop.
        /// Override to load resources that should be maintained for the lifetime of the application.
        /// </summary>
        /// <param name="e">Not used.</param>
        public virtual void OnLoad(EventArgs e)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
        }

        #endregion

        #region OnUnload

        /// <summary>
        /// Raises the Unload event, and calls the user's OnUnload override.
        /// </summary>
        /// <param name="e"></param>
        private void OnUnloadInternal(EventArgs e)
        {
            if (this.Unload != null)
            {
                this.Unload(this, e);
            }

            OnUnload(e);
        }

        /// <summary>
        /// Occurs after after calling GameWindow.Exit, but before destroying the OpenGL context.
        /// Override to unload application resources.
        /// </summary>
        /// <param name="e">Not used.</param>
        public virtual void OnUnload(EventArgs e)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
        }

        #endregion

        #region public bool IsExiting

        /// <summary>
        /// Gets a value indicating whether the shutdown sequence has been initiated
        /// for this window, by calling GameWindow.Exit() or hitting the 'close' button.
        /// If this property is true, it is no longer safe to use any OpenTK.Input or
        /// OpenTK.Graphics.OpenGL functions or properties.
        /// </summary>
        public bool IsExiting
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);
                return isExiting;
            }
        }

        #endregion

        #region public Keyboard Keyboard

        /// <summary>
        /// Gets the primary Keyboard device, or null if no Keyboard exists.
        /// </summary>
        [Obsolete]
        public KeyboardDevice Keyboard
        {
            get
            {
                if (InputDriver.Keyboard.Count > 0)
                    return InputDriver.Keyboard[0];
                else
                    return null;
            }
        }

        #endregion

        #region public Mouse Mouse

        /// <summary>
        /// Gets the primary Mouse device, or null if no Mouse exists.
        /// </summary>
        [Obsolete]
        public MouseDevice Mouse
        {
            get
            {
                if (InputDriver.Mouse.Count > 0)
                    return InputDriver.Mouse[0];
                else
                    return null;
            }
        }

        #endregion

        #region public IList<JoystickDevice> Joysticks

        /// <summary>
        /// Gets a readonly IList containing all available OpenTK.Input.JoystickDevices.
        /// </summary>
        [Obsolete]
        public IList<JoystickDevice> Joysticks
        {
            get { return InputDriver.Joysticks; }
        }

        #endregion

        #region public VSyncMode VSync

        /// <summary>
        /// Gets or sets the VSyncMode.
        /// </summary>
        public VSyncMode VSync
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException("GameWindow");
                
                GraphicsContext.Assert();

                return vsync;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException("GameWindow");
                
                GraphicsContext.Assert();
                
                if (value == VSyncMode.Off)
                    Context.VSync = false;
                else
                    Context.VSync = true;

                vsync = value;
            }
        }

        #endregion

        #region MakeCurrent

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        public void MakeCurrent()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            Context.MakeCurrent(WindowInfo);
        }
        
        #endregion

        #region public void SwapBuffers()

        /// <summary>
        /// Swaps the front and back buffer, presenting the rendered scene to the user.
        /// </summary>
        public void SwapBuffers()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            this.Context.SwapBuffers();
        }

        #endregion

        #region public WindowState WindowState

        /// <summary>
        /// Gets or states the state of the GameWindow.
        /// </summary>
        public WindowState WindowState
        {
            get
            {
                return glWindow.WindowState;
            }
            set
            {
                glWindow.WindowState = value;
            }
        }

        #endregion

        #region public WindowBorder WindowBorder

        /// <summary>
        /// Gets or states the border of the GameWindow.
        /// </summary>
        public WindowBorder WindowBorder
        {
            get
            {
                return glWindow.WindowBorder;
            }
            set
            {
                glWindow.WindowBorder = value;
            }
        }

        #endregion

        #endregion

        #region --- INativeWindow Members ---

        #region Icon

        /// <summary>
        /// Gets or sets the System.Drawing.Icon for this GameWindow.
        /// </summary>
        public Icon Icon
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Icon;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Icon = value;
            }
        }

        #endregion

        #region Focused

        /// <summary>
        /// Gets a System.Boolean that indicates whether this GameWindow has input focus.
        /// </summary>
        public bool Focused
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Focused;
            }
        }

        #endregion

        #region Visible

        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether this GameWindow is visible.
        /// </summary>
        public bool Visible
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Visible;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Visible = value;
            }
        }

        #endregion

        #region Bounds

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure the contains the external bounds of this window, in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        public Rectangle Bounds
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Bounds;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Bounds = value;
            }
        }

        #endregion

        #region Location
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Point"> structure that contains the location of this window on the desktop.
        /// </summary>
        public Point Location
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Location;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Location = value;
            }
        }

        #endregion

        #region Size
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"> structure that contains the external size of this window.
        /// </summary>
        public Size Size
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Size;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Size = value;
            }
        }

        #endregion

        #region X

        /// <summary>
        /// Gets or sets the horizontal location of this window on the desktop.
        /// </summary>
        public int X
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.X;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.X = value;
            }
        }

        #endregion

        #region Y

        /// <summary>
        /// Gets or sets the vertical location of this window on the desktop.
        /// </summary>
        public int Y
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Y;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Y = value;
            }
        }

        #endregion

        #region Width

        /// <summary>
        /// Gets or sets the external width of this window.
        /// </summary>
        public int Width
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Width;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Width = value;
            }
        }

        #endregion

        #region Height

        /// <summary>
        /// Gets or sets the external height of this window.
        /// </summary>
        public int Height
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.Height;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.Height = value;
            }
        }

        #endregion

        #region ClientRectangle

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure that contains the internal bounds of this window, in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
        /// </summary>
        public Rectangle ClientRectangle
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.ClientRectangle;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.ClientRectangle = value;
            }
        }

        #endregion

        #region ClientSize
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the internal size this window.
        /// </summary>
        public Size ClientSize
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name); 
                
                return glWindow.ClientSize;
            }
            set
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                glWindow.ClientSize = value;
            }
        }

        #endregion

        #region InputDriver

        [Obsolete]
        public IInputDriver InputDriver
        {
            get
            {
                if (disposed)
                    throw new ObjectDisposedException(this.GetType().Name);

                return glWindow.InputDriver;
            }
        }

        #endregion

        #region Close

        public void Close()
        {
            Exit();
        }

        #endregion

        #region PointToClient

        /// <summary>
        /// Transforms the specified point from screen to client coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        public System.Drawing.Point PointToClient(System.Drawing.Point point)
        {
            return glWindow.PointToClient(point);
        }

        #endregion

        #region PointToScreen

        /// <summary>
        /// Transforms the specified point from client to screen coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        public System.Drawing.Point PointToScreen(System.Drawing.Point p)
        {
            // Here we use the fact that PointToClient just translates the point, and PointToScreen
            // should perform the inverse operation.
            System.Drawing.Point trans = PointToClient(System.Drawing.Point.Empty);
            p.X -= trans.X;
            p.Y -= trans.Y;
            return p;
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        public event EventHandler<EventArgs> Load = delegate { };

        /// <summary>
        /// Occurs before the window is destroyed. 
        /// </summary>
        public event EventHandler<EventArgs> Unload = delegate { };

        /// <summary>
        /// Occurs whenever the window is moved. 
        /// </summary>
        public event EventHandler<EventArgs> Move = delegate { };

        /// <summary>
        /// Occurs whenever the window is resized. 
        /// </summary>
        public event EventHandler<EventArgs> Resize = delegate { };

       /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        public event EventHandler<CancelEventArgs> Closing = delegate { };

        /// <summary>
        /// Occurs after the window has closed. 
        /// </summary>
        public event EventHandler<EventArgs> Closed = delegate { };

        /// <summary>
        /// Occurs when the window is disposed. 
        /// </summary>
        public event EventHandler<EventArgs> Disposed = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Icon"/> property of the window changes. 
        /// </summary>
        public event EventHandler<EventArgs> IconChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Title"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> TitleChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Visible"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> VisibleChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Focused"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> FocusedChanged = delegate { };

        #endregion

        #endregion

        #region --- GameWindow Timing ---

        // TODO: Disabled because it is not reliable enough. Use vsync as a workaround.

        //#region public bool AllowSleep

        //public bool AllowSleep
        //{
        //    get { return allow_sleep; }
        //    set { allow_sleep = value; }
        //}

        //#endregion

        #region public double TargetRenderPeriod

        /// <summary>
        /// Gets or sets a double representing the target render period, in seconds.
        /// </summary>
        /// <remarks>
        /// <para>A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only limited by the hardware's capabilities).</para>
        /// <para>Values lower than 0.005 seconds (200Hz) are clamped to 0.0. Values higher than 1.0 seconds (1Hz) are clamped to 1.0.</para>
        /// </remarks>
        public double TargetRenderPeriod
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return target_render_period;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value <= 0.005)
                {
                    target_render_period = 0.0;
                }
                else if (value <= 1.0)
                {
                    target_render_period = value;
                }
                else Debug.Print("Target render period clamped to 1.0 seconds.");
            }
        }

        #endregion

        #region public double TargetRenderFrequency

        /// <summary>
        /// Gets or sets a double representing the target render frequency, in Herz.
        /// </summary>
        /// <remarks>
        /// <para>A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only limited by the hardware's capabilities).</para>
        /// <para>Values lower than 1.0Hz are clamped to 1.0Hz. Values higher than 200.0Hz are clamped to 200.0Hz.</para>
        /// </remarks>
        public double TargetRenderFrequency
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (TargetRenderPeriod == 0.0)
                    return 0.0;
                return 1.0 / TargetRenderPeriod;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value < 1.0)
                {
                    TargetRenderPeriod = 0.0;
                }
                else if (value <= 200.0)
                {
                    TargetRenderPeriod = 1.0 / value;
                }
                else Debug.Print("Target render frequency clamped to 200.0Hz.");
            }
        }

        #endregion

        #region public double TargetUpdatePeriod

        /// <summary>
        /// Gets or sets a double representing the target update period, in seconds.
        /// </summary>
        /// <remarks>
        /// <para>A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only limited by the hardware's capabilities).</para>
        /// <para>Values lower than 0.005 seconds (200Hz) are clamped to 0.0. Values higher than 1.0 seconds (1Hz) are clamped to 1.0.</para>
        /// </remarks>
        public double TargetUpdatePeriod
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return target_update_period;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value <= 0.005)
                {
                    target_update_period = 0.0;
                }
                else if (value <= 1.0)
                {
                    target_update_period = value;
                }
                else Debug.Print("Target update period clamped to 1.0 seconds.");
            }
        }

        #endregion

        #region public double TargetUpdateFrequency

        /// <summary>
        /// Gets or sets a double representing the target update frequency, in Herz.
        /// </summary>
        /// <remarks>
        /// <para>A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only limited by the hardware's capabilities).</para>
        /// <para>Values lower than 1.0Hz are clamped to 1.0Hz. Values higher than 200.0Hz are clamped to 200.0Hz.</para>
        /// </remarks>
        public double TargetUpdateFrequency
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (TargetUpdatePeriod == 0.0)
                    return 0.0;
                return 1.0 / TargetUpdatePeriod;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value < 1.0)
                {
                    TargetUpdatePeriod = 0.0;
                }
                else if (value <= 200.0)
                {
                    TargetUpdatePeriod = 1.0 / value;
                }
                else Debug.Print("Target update frequency clamped to 200.0Hz.");
            }
        }

        #endregion

        #region public double RenderFrequency

        /// <summary>
        /// Gets a double representing the actual frequency of RenderFrame events, in Herz (i.e. FPS or Frames Per Second).
        /// </summary>
        public double RenderFrequency
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (render_period == 0.0)
                    return 1.0;
                return 1.0 / render_period;
            }
        }

        #endregion

        #region public double RenderPeriod

        /// <summary>
        /// Gets a double representing the period of RenderFrame events, in seconds.
        /// </summary>
        public double RenderPeriod
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return render_period;
            }
        }

        #endregion

        #region public double UpdateFrequency

        /// <summary>
        /// Gets a double representing the frequency of UpdateFrame events, in Herz.
        /// </summary>
        public double UpdateFrequency
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (update_period == 0.0)
                    return 1.0;
                return 1.0 / update_period;
            }
        }

        #endregion

        #region public double UpdatePeriod

        /// <summary>
        /// Gets a double representing the period of UpdateFrame events, in seconds.
        /// </summary>
        public double UpdatePeriod
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return update_period;
            }
        }

        #endregion

        #region public double RenderTime

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        public double RenderTime
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return render_time; }
            protected set { if (disposed) throw new ObjectDisposedException("GameWindow"); render_time = value; }
        }

        #endregion

        #region public double RenderTime

        /// <summary>
        /// Gets a double representing the time spent in the UpdateFrame function, in seconds.
        /// </summary>
        public double UpdateTime
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return update_time; }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        /// <summary>
        /// Disposes of the GameWindow, releasing all resources consumed by it.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Dispose(true);
            }
            finally
            {
                DisposeInternal(true);
            }
            GC.SuppressFinalize(this);
        }

        private void DisposeInternal(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    if (glContext != null)
                    {
                        glContext.Dispose();
                        glContext = null;
                    }

                    if (glWindow != null)
                    {
                        glWindow.Dispose();
                        glWindow = null;
                    }
                }
                disposed = true;
            }
        }

        /// <summary>
        /// Override to add custom cleanup logic.
        /// </summary>
        /// <param name="manual">True, if this method was called by the application; false if this was called by the finalizer thread.</param>
        protected virtual void Dispose(bool manual)
        {
        }

        ///// <summary>Finalizes unmanaged resources consumed by the GameWindow.</summary>
        //~GameWindow()
        //{
        //    Dispose(false);
        //    DisposeInternal(false);
        //}

        #endregion
    }

    #region public enum VSyncMode

    /// <summary>
    /// Enumerates available VSync modes.
    /// </summary>
    public enum VSyncMode
    {
        /// <summary>
        /// Vsync disabled.
        /// </summary>
        Off = 0,
        /// <summary>
        /// VSync enabled.
        /// </summary>
        On,
        /// <summary>
        /// VSync enabled, but automatically disabled if framerate falls below a specified limit.
        /// </summary>
        Adaptive,
    }

    #endregion

    #region --- GameWindow Events ---

    public delegate void UpdateFrameEvent(GameWindow sender, UpdateFrameEventArgs e);
    public delegate void RenderFrameEvent(GameWindow sender, RenderFrameEventArgs e);
    public delegate void LoadEvent(GameWindow sender, EventArgs e);
    public delegate void UnloadEvent(GameWindow sender, EventArgs e);

    public class UpdateFrameEventArgs : EventArgs
    {
        private double time;

        /// <summary>
        /// Gets the Time elapsed between frame updates, in seconds.
        /// </summary>
        public double Time
        {
            get { return time; }
            internal set { time = value; }
        }
    }

    public class RenderFrameEventArgs : EventArgs
    {
        private double time;
        private double scale_factor;

        /// <summary>
        /// Gets the Time elapsed between frame updates, in seconds.
        /// </summary>
        public double Time
        {
            get { return time; }
            internal set { time = value; }
        }

        public double ScaleFactor
        {
            get
            {
                return scale_factor;
            }
            internal set
            {
                if (value != 0.0 && !Double.IsNaN(value))
                    scale_factor = value;
                else
                    scale_factor = 1.0;
            }
        }
    }

    #endregion

    #region --- GameWindow Exceptions ---

    [DebuggerNonUserCode]
    class GameWindowExitException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return
@"This exception is a normal part of the GameWindow shutdown process and is completely harmless. While this warning will never be seen by end-users, Visual Studio reminds you that an exception is leaving your code unhandled, which can sometimes be a security breach.
You can disable this warning for this specific exception: select Debug->Exceptions from the menu bar and click ""Add"". Choose ""Common Language Runtime Exceptions"", type ""OpenTK.GameWindowExitException"" in the box below and click ""Ok"". Deselecting the ""User-unhandled"" checkbox from the newly created exception will disable this warning.
Alternatively, you can disable the ""Just my code"" debugging mode (""Tools->Options->Debugging->General"" and untick ""Enable Just my code (Managed only)"". This has the sideffect that it will allow you to step into OpenTK code if an error happens. Please, do this only if you are confident in your debugging skills.";
            }
        }
    }

    #endregion

    #region public enum GameWindowFlags

    /// <summary>Enumerates available GameWindow construction options.</summary>
    [Flags]
    public enum GameWindowFlags
    {
        /// <summary>Indicates that the GameWindow should cover the whole screen.</summary>
        Fullscreen = 1,
    }

    #endregion
}
