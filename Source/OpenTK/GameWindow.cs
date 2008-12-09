#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

using OpenTK.Platform;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.OpenGL.Enums;
using OpenTK.Graphics;

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
    public class GameWindow : IDisposable/* : IGameWindow*/
    {
        #region --- Fields ---

        INativeGLWindow glWindow;
        //DisplayMode mode;

        ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        bool isExiting = false;
        bool hasMainLoop;
        bool disposed;

        double update_period, render_period;
        double target_update_period, target_render_period, target_render_period_doubled;
        // TODO: Implement these:
        double update_time, render_time;//, event_time;
        //bool allow_sleep = true;    // If true, GameWindow will call Timer.Sleep() if there is enough time.
        int width, height;
        VSyncMode vsync;

        //InputDriver input_driver;

        IGraphicsContext glContext;

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
        {
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (mode == null)
                mode = GraphicsMode.Default;
            if (device == null)
                device = DisplayDevice.Default;

            if (Configuration.RunningOnWindows)
                glWindow = new OpenTK.Platform.Windows.WinGLNative();
            else if (Configuration.RunningOnX11)
                glWindow = new OpenTK.Platform.X11.X11GLNative();
            else
                throw new PlatformNotSupportedException(
                    "Your platform is not supported currently. Please, refer to http://www.opentk.com for more information.");

            glWindow.Destroy += glWindow_Destroy;

            try
            {
                glWindow.CreateWindow(width, height, mode, out glContext);
                glContext.MakeCurrent(this.WindowInfo);
                (glContext as IGraphicsContextInternal).LoadAll();
            }
            //catch (GraphicsContextException e)
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                glWindow.DestroyWindow();
                throw;
            }
            
            this.Title = title;
            
            if ((options & GameWindowFlags.Fullscreen) != 0)
            {
                device.ChangeResolution(width, height, mode.ColorFormat.BitsPerPixel, 0);
                //this.Fullscreen = true;
                throw new NotImplementedException();
            }
            
            this.VSync = VSyncMode.On; //VSyncMode.Adaptive;

        }

        #endregion

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

        #region --- Private Methods ---

        #region void glWindow_Destroy(object sender, EventArgs e)

        void glWindow_Destroy(object sender, EventArgs e)
        {
            glWindow.Destroy -= glWindow_Destroy;
            this.Exit();
        }

        #endregion

        #region void ExitInternal()

        /// <internal />
        /// <summary>Stops the main loop.</summary>
        void ExitInternal()
        {
            //Debug.Print("Firing GameWindowExitException");  
            throw new GameWindowExitException();
        }

        void CallExitInternal(GameWindow sender, UpdateFrameEventArgs e)
        {
            UpdateFrame -= CallExitInternal;
            sender.ExitInternal();
        }

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

        #endregion

        #region --- Public Members ---

        #region public virtual void Exit()

        /// <summary>
        /// Gracefully exits the GameWindow. May only be called from the thread where the GameWindow was created.
        /// </summary>
        /// <remarks>
        /// <para>Override if you want to provide yor own exit sequence.</para>
        /// <para>If you override this method, place a call to base.Exit(), to ensure
        /// proper OpenTK shutdown.</para>
        /// </remarks>
        public virtual void Exit()
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
            //glWindow.DestroyWindow();
            //while (glWindow.Exists)
            //    glWindow.ProcessEvents();
            if (HasMainLoop)
                ExitAsync();
            else
                ExitInternal();
            //isExiting = true;
            //UpdateFrame += CallExitInternal;
        }

        #endregion

        #region public virtual void ExitAsync()

        /// <summary>
        /// Gracefully exits the GameWindow. May be called from any thread.
        /// </summary>
        /// <remarks>
        /// <para>Override if you want to provide yor own exit sequence.</para>
        /// <para>If you override this method, place a call to base.ExitAsync(), to ensure
        /// proper OpenTK shutdown.</para>
        /// </remarks>
        public virtual void ExitAsync()
        {
            //isExiting = true;
            if (disposed) throw new ObjectDisposedException("GameWindow");
            UpdateFrame += CallExitInternal;
        }

        #endregion

        #region public bool IsIdle

        /// <summary>
        /// Gets a value indicating whether the current GameWindow is idle.
        /// If true, the OnUpdateFrame and OnRenderFrame functions should be called.
        /// </summary>
        public bool IsIdle
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return glWindow.IsIdle; }
        }

        #endregion

        #region public bool Fullscreen

        /// <summary>
        /// TODO: This property is not implemented.
        /// Gets or sets a value indicating whether the GameWindow is in fullscrren mode.
        /// </summary>
        //public bool Fullscreen
        //{
        //    get { if (disposed) throw new ObjectDisposedException("GameWindow"); return glWindow.Fullscreen; }
        //    set { if (disposed) throw new ObjectDisposedException("GameWindow"); glWindow.Fullscreen = value; }
        //}

        #endregion

        #region public IGraphicsContext Context

        /// <summary>
        /// Returns the opengl IGraphicsContext associated with the current GameWindow.
        /// </summary>
        public IGraphicsContext Context
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
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
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return glWindow.Title;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
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

#if false

        #region public IInputDriver InputDriver

        /// <summary>
        /// Gets an interface to the InputDriver used to obtain Keyboard, Mouse and Joystick input.
        /// </summary>
        public IInputDriver InputDriver
        {
            get
            {
                return null;
            }
        }

        #endregion

#endif

        #region public void Run()

        /// <summary>
        /// Enters the game loop of the GameWindow updating and rendering at the maximum possible frequency.
        /// </summary>
        /// <see cref="public virtual void Run(double update_frequency, double render_frequency)"/>
        public void Run()
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
            Run(0.0, 0.0);
        }

        #endregion

        #region public void Run(double updateFrequency)

        /// <summary>
        /// Enters the game loop of the GameWindow updating the specified update frequency, while maintaining the
        /// maximum possible render frequency.
        /// </summary>
        /// <see cref="public virtual void Run(double updateFrequency, double renderFrequency)"/>
        public void Run(double updateFrequency)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
            Run(updateFrequency, 0.0);
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
            if (disposed) throw new ObjectDisposedException("GameWindow");
            try
            {
                if (updates_per_second < 0.0 || updates_per_second > 200.0)
                    throw new ArgumentOutOfRangeException("updates_per_second", updates_per_second, "Parameter should be inside the range [0.0, 200.0]");
                if (frames_per_second < 0.0 || frames_per_second > 200.0)
                    throw new ArgumentOutOfRangeException("frames_per_second", frames_per_second, "Parameter should be inside the range [0.0, 200.0]");

                TargetUpdateFrequency = updates_per_second;
                TargetRenderFrequency = frames_per_second;

                Stopwatch update_watch = new Stopwatch(), render_watch = new Stopwatch();
                double time, next_render = 0.0, next_update = 0.0, update_time_counter = 0.0;
                int num_updates = 0;
                UpdateFrameEventArgs update_args = new UpdateFrameEventArgs();
                RenderFrameEventArgs render_args = new RenderFrameEventArgs();

                update_watch.Reset();
                render_watch.Reset();

                //double sleep_granularity;      // In seconds.

                //GC.Collect(2);
                //GC.WaitForPendingFinalizers();
                //GC.Collect(2);

                // Find the minimum granularity of the Thread.Sleep() function.
                // TODO: Disabled - see comment on Thread.Sleep() problems below.
                //update_watch.Start();
                //const int test_times = 5;
                //for (int i = test_times; --i > 0; )
                //    Thread.Sleep(1);
                //update_watch.Stop();
                //sleep_granularity = System.Math.Round(1000.0 * update_watch.Elapsed.TotalSeconds / test_times, MidpointRounding.AwayFromZero) / 1000.0;
                //update_watch.Reset();       // We don't want to affect the first UpdateFrame!

                try
                {
                    OnLoadInternal(EventArgs.Empty);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(String.Format("OnLoad failed: {0}", e.ToString()));
                    return;
                }

                //Debug.Print("Elevating priority.");
                //Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;

                Debug.Print("Entering main loop.");
                hasMainLoop = true;
                while (!isExiting)
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

                        update_args.Time = time;
                        OnUpdateFrameInternal(update_args);
                        update_time = update_watch.Elapsed.TotalSeconds;

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

                        render_period = render_args.Time = time;
                        render_args.ScaleFactor = RenderPeriod / UpdatePeriod;
                        OnRenderFrameInternal(render_args);
                        render_time = render_watch.Elapsed.TotalSeconds;
                    }

                    // Yield CPU time, if the Thread.Sleep() granularity allows it.
                    // TODO: Disabled because it does not work reliably enough on all systems.
                    // Enable vsync as a workaround.
                    //if (AllowSleep && next_render > sleep_granularity && next_update > sleep_granularity)
                    //{
                    //    Thread.Sleep((int)(1000.0 * System.Math.Min(next_render - sleep_granularity, next_update - sleep_granularity)));
                    //}
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
                    glWindow.DestroyWindow();
                }
                while (this.Exists)
                    this.ProcessEvents();
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
            if (disposed) throw new ObjectDisposedException("GameWindow");
            if (!isExiting)
                glWindow.InputDriver.Poll();
            glWindow.ProcessEvents();

            if (MustResize)
            {
                resizeEventArgs.Width = glWindow.Width;
                resizeEventArgs.Height = glWindow.Height;
                OnResizeInternal(resizeEventArgs);
            }
        }

        #endregion

        #region OnRenderFrame(RenderFrameEventArgs e)

        /// <summary>
        /// Raises the RenderFrame event, and calls the public function.
        /// </summary>
        /// <param name="e"></param>
        private void OnRenderFrameInternal(RenderFrameEventArgs e)
        {
            if (RenderFrame != null)
                RenderFrame(this, e);

            // Call the user's override.
            OnRenderFrame(e);
        }

        /// <summary>
        /// Override in derived classes to render a frame.
        /// </summary>
        /// <param name="e">Contains information necessary for frame rendering.</param>
        /// <remarks>
        /// The base implementation (base.OnRenderFrame) is empty, there is no need to call it.
        /// </remarks>
        public virtual void OnRenderFrame(RenderFrameEventArgs e)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
        }

        /// <summary>
        /// Occurs when it is time to render the next frame.
        /// </summary>
        public event RenderFrameEvent RenderFrame;

        #endregion

        #region OnUpdateFrame(UpdateFrameEventArgs e)

        private void OnUpdateFrameInternal(UpdateFrameEventArgs e)
        {
            if (!this.Exists && !this.IsExiting)
            {
                //Debug.Print("WARNING: UpdateFrame event raised without a valid render window. This may indicate a programming error. Creating render window.");
                //mode = new DisplayMode(640, 480);
                //this.CreateWindow(mode);
                throw new InvalidOperationException("Cannot enter game loop without a render window");
            }

            if (UpdateFrame != null)
            {
                UpdateFrame(this, e);
            }

            OnUpdateFrame(e);
        }

        /// <summary>
        /// Override in derived classes to update a frame.
        /// </summary>
        /// <param name="e">Contains information necessary for frame updating.</param>
        /// <remarks>
        /// The base implementation (base.OnUpdateFrame) is empty, there is no need to call it.
        /// </remarks>
        public virtual void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
        }

        /// <summary>
        /// Occurs when it is time to update the next frame.
        /// </summary>
        public event UpdateFrameEvent UpdateFrame;

        #endregion

        #region OnLoad(EventArgs e)

        /// <summary>
        /// Occurs after establishing an OpenGL context, but before entering the main loop.
        /// </summary>
        public event LoadEvent Load;

        /// <summary>
        /// Raises the Load event, and calls the user's OnLoad override.
        /// </summary>
        /// <param name="e"></param>
        private void OnLoadInternal(EventArgs e)
        {
            Debug.Print("Firing internal load event.");
            if (MustResize)
            {
                resizeEventArgs.Width = glWindow.Width;
                resizeEventArgs.Height = glWindow.Height;
                OnResizeInternal(resizeEventArgs);
            }

            Debug.WriteLine(String.Format("OpenGL driver information: {0}, {1}, {2}",
                GL.GetString(StringName.Renderer),
                GL.GetString(StringName.Vendor),
                GL.GetString(StringName.Version)));

            if (this.Load != null)
            {
                this.Load(this, e);
            }

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

        #region OnUnload(EventArgs e)

        /// <summary>
        /// Occurs after after calling GameWindow.Exit, but before destroying the OpenGL context.
        /// </summary>
        public event UnloadEvent Unload;

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
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return isExiting; }
        }

        #endregion

        #region public Keyboard Keyboard

        /// <summary>
        /// Gets the primary Keyboard device, or null if no Keyboard exists.
        /// </summary>
        public KeyboardDevice Keyboard
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                //if (input_driver.Keyboard.Count > 0)
                //    return input_driver.Keyboard[0];
                //else
                //    return null;
                
                if (glWindow.InputDriver.Keyboard.Count > 0)
                    return glWindow.InputDriver.Keyboard[0];
                else
                    return null;
            }
        }

        #endregion

        #region public Mouse Mouse

        /// <summary>
        /// Gets the primary Mouse device, or null if no Mouse exists.
        /// </summary>
        public MouseDevice Mouse
        {
            get
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                //if (input_driver.Mouse.Count > 0)
                //    return input_driver.Mouse[0];
                //else
                //    return null;

                if (glWindow.InputDriver.Mouse.Count > 0)
                    return glWindow.InputDriver.Mouse[0];
                else
                    return null;
            }
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
                if (disposed) throw new ObjectDisposedException("GameWindow");
                return vsync;
            }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value == VSyncMode.Off)
                    Context.VSync = false;
                else
                    Context.VSync = true;

                vsync = value;
            }
        }

        #endregion

        #region public void SwapBuffers()

        /// <summary>
        /// Swaps the front and back buffer, presenting the rendered scene to the user.
        /// Only useful in double- or triple-buffered formats.
        /// </summary>
        /// <remarks>Calling this function is equivalent to calling Context.SwapBuffers()</remarks>
        public void SwapBuffers()
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
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
                    target_render_period = target_render_period_doubled = 0.0;
                }
                else if (value <= 1.0)
                {
                    target_render_period = value;
                    target_render_period_doubled = 2.0 * target_render_period;
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

        #region --- IResizable Members ---

        #region public int Width, Height

        /// <summary>
        /// Gets or sets the Width of the GameWindow's rendering area, in pixels.
        /// </summary>
        public int Width
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return width; }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value == this.Width)
                {
                    return;
                }
                else if (value > 0)
                {
                    glWindow.Width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Width",
                        value,
                        "Width must be greater than 0"
                    );
                }
            }
        }

        /// <summary>
        /// Gets or sets the Height of the GameWindow's rendering area, in pixels.
        /// </summary>
        public int Height
        {
            get { if (disposed) throw new ObjectDisposedException("GameWindow"); return height; }
            set
            {
                if (disposed) throw new ObjectDisposedException("GameWindow");
                if (value == this.Height)
                {
                    return;
                }
                else if (value > 0)
                {
                    glWindow.Height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Height",
                        value,
                        "Height must be greater than 0"
                    );
                }
            }
        }

        #endregion

        #region public event ResizeEvent Resize;

        /// <summary>
        /// Occurs when the GameWindow is resized. Derived classes should override the OnResize method for better performance.
        /// </summary>
        public event ResizeEvent Resize
        {
            add { if (disposed) throw new ObjectDisposedException("GameWindow"); glWindow.Resize += value; }
            remove { if (disposed) throw new ObjectDisposedException("GameWindow"); glWindow.Resize -= value; }
        }

        /// <summary>
        /// Raises the Resize event.
        /// </summary>
        /// <param name="e">Contains information about the Resize event.</param>
        private void OnResizeInternal(ResizeEventArgs e)
        {
            Debug.Print("Firing internal resize event: {0}.", e.ToString());

            this.width = e.Width;
            this.height = e.Height;

            //if (this.Resize != null)
            //    this.Resize(this, e);

            OnResize(e);
        }

        /// <summary>
        /// Override in derived classes to respond to the Resize events.
        /// </summary>
        /// <param name="e">Contains information about the Resize event.</param>
        protected virtual void OnResize(ResizeEventArgs e)
        {
            if (disposed) throw new ObjectDisposedException("GameWindow");
        }

        #endregion

        /*
        /// <summary>
        /// Gets the Top coordinate of the GameWindow's rendering area, in pixel coordinates relative to the GameWindow's top left point.
        /// </summary>
        public int Top
        {
            get { return glWindow.Top; }
        }

        /// <summary>
        /// /// Gets the Bottom coordinate of the GameWindow's rendering area, in pixel coordinates relative to the GameWindow's top left point.
        /// </summary>
        public int Bottom
        {
            get { return glWindow.Bottom; }
        }

        /// <summary>
        /// Gets the Left coordinate of the GameWindow's rendering area, in pixel coordinates relative to the GameWindow's top left point.
        /// </summary>
        public int Left
        {
            get { return glWindow.Left; }
        }

        /// <summary>
        /// Gets the Right coordinate of the GameWindow's rendering area, in pixel coordinates relative to the GameWindow's top left point.
        /// </summary>
        public int Right
        {
            get { return glWindow.Right; }
        }
        */
        #endregion
#if false       // TODO: 0.9.2 (Linux support missing)
        #region PointToClient

        /// <summary>
        /// Converts the screen coordinates of a specified point on the screen to client-area coordinates.
        /// </summary>
        /// <param name="p">A System.Drawing.Point structure that specifies the screen coordinates to be converted</param>
        /// <returns>The client-area coordinates of the point. The new coordinates are relative to the upper-left corner of the GameWindow's client area.</returns>
        public System.Drawing.Point PointToClient(System.Drawing.Point p)
        {
            glWindow.PointToClient(ref p);
            return p;
        }

        #endregion

        #region PointToScreen

        /// <summary>
        /// Converts the client-area coordinates of a specified point to screen coordinates.
        /// </summary>
        /// <param name="p">A System.Drawing.Point structure that specifies the client-area coordinates to be converted</param>
        /// <returns>The screen coordinates of the point, relative to the upper-left corner of the screen. Note, a screen-coordinate point that is above the window's client area has a negative y-coordinate. Similarly, a screen coordinate to the left of a client area has a negative x-coordinate.</returns>
        public System.Drawing.Point PointToScreen(System.Drawing.Point p)
        {
            glWindow.PointToScreen(ref p);
            return p;
        }

        #endregion
#endif
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
