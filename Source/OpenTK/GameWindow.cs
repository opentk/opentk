#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using OpenTK.Platform;
using OpenTK.Input;
using System.Threading;
using OpenTK.OpenGL;

namespace OpenTK
{
    /// <summary>
    /// The GameWindow class contains cross-platform methods to create and render on an OpenGL window, handle input and load resources.
    /// </summary>
    /// <remarks>
    /// GameWindow contains several events you can hook or override to add your custom logic:
    /// <list>
    /// <item>OnLoad: Occurs after creating the OpenGL context, but before entering the main loop. Override to load resources.</item>
    /// <item>OnResize: Occurs whenever GameWindow is resized. You should update the OpenGL Viewport and Projection Matrix here.</item>
    /// <item>OnUpdateFrame: Occurs at the specified logic update rate. Override to add your game logic.</item>
    /// <item>OnRenderFrame: Occurs at the specified frame render rate. Override to add your rendering code.</item>
    /// </list>
    /// Call the Run() method to start the application's main loop. Run(double, double) takes two parameters that
    /// specify the logic update rate, and the render update rate.
    /// </remarks>
    public class GameWindow : OpenTK.Platform.IGameWindow
    {
        #region --- Fields ---

        INativeGLWindow glWindow;
        DisplayMode mode;

        ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        bool isExiting;
        bool disposed;

        double updateTime, renderTime, eventTime, frameTime;

        int width, height;

        #endregion

        #region --- Internal Fields ---

        bool MustResize
        {
            get { return glWindow.Width != this.Width || glWindow.Height != this.Height; }
        }

        #endregion

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow. Call CreateWindow() to open a render window.
        /// </summary>
        public GameWindow()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    glWindow = new OpenTK.Platform.Windows.WinGLNative();
                    break;
            
                case PlatformID.Unix:
                case (PlatformID)128:
                    glWindow = new OpenTK.Platform.X11.X11GLNative();
                    break;
                
                default:
                    throw new PlatformNotSupportedException("Your platform is not supported currently. Please, refer to http://opentk.sourceforge.net for more information.");
            }

            //glWindow.Resize += new ResizeEvent(glWindow_Resize);
            glWindow.Destroy += new DestroyEvent(glWindow_Destroy);
        }

        /// <summary>
        /// Constructs a new GameWindow, and opens a render window with the specified DisplayMode.
        /// </summary>
        /// <param name="mode">The DisplayMode of the GameWindow.</param>
        public GameWindow(DisplayMode mode)
            : this()
        {
            CreateWindow(mode);
        }

        /// <summary>
        /// Constructs a new GameWindow with the specified title, and opens a render window with the specified DisplayMode.
        /// </summary>
        /// <param name="mode">The DisplayMode of the GameWindow.</param>
        /// <param name="title">The Title of the GameWindow.</param>
        public GameWindow(DisplayMode mode, string title)
            : this()
        {
            CreateWindow(mode, title);
        }

        void glWindow_Destroy(object sender, EventArgs e)
        {
            Debug.Print("GameWindow destruction imminent.");
            this.isExiting = true;
            this.OnDestroy(EventArgs.Empty);
            glWindow.Destroy -= glWindow_Destroy;
            //this.Dispose();
        }

        void glWindow_Resize(object sender, ResizeEventArgs e)
        {
            this.OnResizeInternal(e);
        }

        #endregion

        #region --- Functions ---

        #region public void CreateWindow(DisplayMode mode, string title)

        /// <summary>
        /// Creates a render window for the calling GameWindow, with the specified DisplayMode and Title.
        /// </summary>
        /// <param name="mode">The DisplayMode of the render window.</param>
        /// <param name="title">The Title of the render window.</param>
        /// <remarks>
        /// It is an error to call this function when a render window already exists.
        /// <para>Call DestroyWindow to close the render window.</para>
        /// </remarks>
        /// <exception cref="ApplicationException">Occurs when a render window already exists.</exception>
        public void CreateWindow(DisplayMode mode, string title)
        {
            if (!Exists)
            {
                try
                {
                    glWindow.CreateWindow(mode);
                    this.Title = title;
                }
                catch (ApplicationException expt)
                {
                    Debug.Print(expt.ToString());
                    throw;
                }
            }
            else
            {
                throw new ApplicationException("A render window already exists for this GameWindow.");
            }
        }

        #endregion

        #endregion

        #region --- INativeGLWindow Members ---

        #region public void Exit()

        /// <summary>
        /// Gracefully exits the current GameWindow.
        /// Override if you want to provide yor own exit sequence.
        /// If you override this method, place a call to base.Exit(), to ensure
        /// proper OpenTK shutdown.
        /// </summary>
        public virtual void Exit()
        {
            isExiting = true;
            //glWindow.Exit();
            //this.Dispose();
        }

        #endregion

        #region public bool IsIdle

        /// <summary>
        /// Gets a value indicating whether the current GameWindow is idle.
        /// If true, the OnUpdateFrame and OnRenderFrame functions should be called.
        /// </summary>
        public bool IsIdle
        {
            get { return glWindow.IsIdle; }
        }

        #endregion

        #region public bool Fullscreen

        /// <summary>
        /// TODO: This property is not implemented.
        /// Gets or sets a value indicating whether the GameWindow is in fullscrren mode.
        /// </summary>
        public bool Fullscreen
        {
            get { return glWindow.Fullscreen; }
            set { glWindow.Fullscreen = value; }
        }

        #endregion

        #region public IGLContext Context

        /// <summary>
        /// Returns the opengl IGLontext associated with the current GameWindow.
        /// Forces window creation.
        /// </summary>
        public IGLContext Context
        {
            get
            {
				if (!this.Exists && !this.IsExiting)
				{
				    Debug.WriteLine("WARNING: OpenGL Context accessed before creating a render window. This may indicate a programming error. Force-creating a render window.");
				    mode = new DisplayMode(640, 480);
				    this.CreateWindow(mode);
				}
				return glWindow.Context;
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
                return glWindow.Title;
            }
            set
            {
                glWindow.Title = value;
            }
        }

        #endregion

        #region public bool Visible

        /// <summary>
        /// TODO: This property is not implemented
        /// Gets or sets a value indicating whether the GameWindow is visible.
        /// </summary>
        public bool Visible
        {
            get
            {
                throw new NotImplementedException();
                return glWindow.Visible;
            }
            set
            {
                throw new NotImplementedException();
                glWindow.Visible = value;
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return glWindow.WindowInfo; }
        }

        #endregion

        #region public IInputDriver InputDriver

        /// <summary>
        /// Gets an interface to the InputDriver used to obtain Keyboard, Mouse and Joystick input.
        /// </summary>
        public IInputDriver InputDriver
        {
            get
            {
                return glWindow.InputDriver;
            }
        }

        #endregion

        #region public void CreateWindow(DisplayMode mode)

        /// <summary>
        /// Creates a render window for the calling GameWindow.
        /// </summary>
        /// <param name="mode">The DisplayMode of the render window.</param>
        /// <remarks>
        /// It is an error to call this function when a render window already exists.
        /// <para>Call DestroyWindow to close the render window.</para>
        /// </remarks>
        /// <exception cref="ApplicationException">Occurs when a render window already exists.</exception>
        public void CreateWindow(DisplayMode mode)
        {
            if (!Exists)
            {
                try
                {
                    glWindow.CreateWindow(mode);
                }
                catch (ApplicationException expt)
                {
                    Debug.Print(expt.ToString());
                    throw;
                }
            }
            else
            {
                throw new ApplicationException("A render window already exists for this GameWindow.");
            }
        }

        #endregion

        #region OnCreate

        [Obsolete("The Create event is obsolete and will be removed on later versions. Use the Load event instead.")]
        public event CreateEvent Create;

        /// <summary>
        /// Raises the Create event. Override in derived classes to initialize resources.
        /// </summary>
        /// <param name="e"></param>
        [Obsolete("The OnCreate method is obsolete and will be removed on later versions. Use the OnLoad method instead.")]
        public virtual void OnCreate(EventArgs e)
        {
            Debug.WriteLine("Firing GameWindow.Create event");
            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region public void DestroyWindow()

        /// <summary>
        /// Destroys the GameWindow. The Destroy event is raised before destruction commences
        /// (while the opengl context still exists), to allow resource cleanup.
        /// </summary>
        public void DestroyWindow()
        {
            if (Exists)
            {
                glWindow.DestroyWindow();
            }
            else
            {
                throw new ApplicationException("Tried to destroy inexistent window.");
            }
        }

        #endregion

        #region OnDestroy

        /// <summary>
        /// Raises the Destroy event. Override in derived classes, to modify the shutdown
        /// sequence (e.g. to release resources before shutdown).
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnDestroy(EventArgs e)
        {
            Debug.WriteLine("Firing GameWindow.Destroy event");
            if (this.Destroy != null)
            {
                this.Destroy(this, e);
            }
        }

        public event DestroyEvent Destroy;

        #endregion

        #endregion

        #region --- IGameWindow Members ---

        #region public virtual void Run()

        /// <summary>
        /// Enters the game loop of GameWindow, updating and rendering at the maximum possible frequency.
        /// </summary>
        /// <see cref="public virtual void Run(float update_frequency, float render_frequency)"/>
        public void Run()
        {
            Run(0.0, 0.0);
        }

        /// <summary>
        /// Runs the default game loop on GameWindow at the specified update frequency, maintaining the
        /// maximum possible render frequency.
        /// </summary>
        /// <see cref="public virtual void Run(double updateFrequency, double renderFrequency)"/>
        public void Run(double updateFrequency)
        {
            Run(updateFrequency, 0.0);
        }

        /// <summary>
        /// Runs the default game loop on GameWindow at the specified update and render frequency.
        /// </summary>
        /// <param name="updateFrequency">If greater than zero, indicates how many times UpdateFrame will be called per second. If less than or equal to zero, UpdateFrame is raised at maximum possible frequency.</param>
        /// <param name="renderFrequency">If greater than zero, indicates how many times RenderFrame will be called per second. If less than or equal to zero, RenderFrame is raised at maximum possible frequency.</param>
        /// <remarks>
        /// <para>
        /// A default game loop consists of three parts: Event processing, frame updating and a frame rendering.
        /// This function will try to maintain the requested updateFrequency at all costs, dropping the renderFrequency if
        /// there is not enough CPU time.
        /// </para>
        /// <para>
        /// It is recommended that you specify a target for update- and renderFrequency.
        /// Doing so, will yield unused CPU time to other processes, dropping power consumption
        /// and maximizing batter life. If either frequency is left unspecified, the GameWindow
        /// will consume all available CPU time (only useful for benchmarks and stress tests).
        /// </para>
        /// <para>
        /// Override this function if you want to change the behaviour of the
        /// default game loop. If you override this function, you must place
        /// a call to the ProcessEvents function, to ensure window will respond
        /// to Operating System events.
        /// </para>
        /// </remarks>
        public virtual void Run(double updateFrequency, double renderFrequency)
        {
            this.OnLoad(EventArgs.Empty);

            Debug.Print("Entering main loop");

            //resizeEventArgs.Width = this.Width;
            //resizeEventArgs.Height = this.Height;
            //this.OnResize(resizeEventArgs);

            Stopwatch watch = new Stopwatch();
            UpdateFrameEventArgs updateArgs = new UpdateFrameEventArgs();
            RenderFrameEventArgs renderArgs = new RenderFrameEventArgs();

            double update_target = 0.0, render_target = 0.0, next_update = 0.0, next_render = 0.0;
            double time, total_time;

            if (updateFrequency > 0.0)
            {
                next_update = update_target = 1.0 / updateFrequency;
            }
            if (renderFrequency > 0.0)
            {
                next_render = render_target = 1.0 / renderFrequency;
            }

            while (this.Exists && !IsExiting)
            {
                total_time = frameTime = watch.Elapsed.TotalSeconds;
                if (total_time > 0.1)
                    total_time = 0.1;
                updateArgs.Time = renderArgs.Time = total_time;

                watch.Reset();
                watch.Start();

                time = watch.Elapsed.TotalSeconds;
                this.ProcessEvents();
                eventTime = watch.Elapsed.TotalSeconds - time;

                if (!IsExiting)
                {
                    time = watch.Elapsed.TotalSeconds;
                    next_update -= (total_time + time);
                    while (next_update <= 0.0)
                    {
                        updateArgs.Time += watch.Elapsed.TotalSeconds;
                        this.OnUpdateFrameInternal(updateArgs);
                        if (update_target == 0.0)
                            break;
                        next_update += update_target;
                    }
                    updateTime = watch.Elapsed.TotalSeconds - time;

                    time = watch.Elapsed.TotalSeconds;
                    next_render -= (total_time + time);
                    if (next_render <= 0.0)
                    {
                        renderArgs.Time += time;
                        this.OnRenderFrameInternal(renderArgs);
                        next_render += render_target;
                    }
                    renderTime = watch.Elapsed.TotalSeconds - time;

                    if (renderTime < render_target && updateTime < update_target)
                    {
                        Thread.Sleep((int)(1000.0 * System.Math.Min(
                            render_target - renderTime, update_target - updateTime)));
                    }
                }
            }

            if (this.Exists)
            {
                glWindow.DestroyWindow();
                while (this.Exists)
                {
                    this.ProcessEvents();
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
            if (!isExiting)
                InputDriver.Poll();
            glWindow.ProcessEvents();
        }

        #endregion

        #region OnRenderFrame(RenderFrameEventArgs e)

        /// <summary>
        /// Raises the RenderFrame event, and calls the public function.
        /// </summary>
        /// <param name="e"></param>
        private void OnRenderFrameInternal(RenderFrameEventArgs e)
        {
            if (!this.Exists && !this.IsExiting)
            {
                Debug.Print("WARNING: RenderFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }
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
                Debug.Print("WARNING: UpdateFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }

            if (MustResize)
            {
                resizeEventArgs.Width = glWindow.Width;
                resizeEventArgs.Height = glWindow.Height;
                OnResizeInternal(resizeEventArgs);
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
            Context.SwapBuffers();
        }
        
        #endregion

        #region public bool IsExiting

        /// <summary>
        /// Gets a value indicating whether the shutdown sequence has been initiated
        /// for this window, by calling GameWindow.Exit() or hitting the 'close' button.
        /// If this property is true, it is no longer safe to use any OpenTK.Input or
        /// OpenTK.OpenGL functions or properties.
        /// </summary>
        public bool IsExiting
        {
            get { return isExiting; }
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

        #endregion

        #region --- IResizable Members ---

        #region public int Width, Height

        /// <summary>
        /// Gets or sets the Width of the GameWindow's rendering area, in pixels.
        /// </summary>
        public int Width
        {
            get { return width; }
            set
            {
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
            get { return height; }
            set
            {
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
        public event ResizeEvent Resize;

        /// <summary>
        /// Raises the Resize event.
        /// </summary>
        /// <param name="e">Contains information about the Resize event.</param>
        private void OnResizeInternal(ResizeEventArgs e)
        {
            Debug.Print("Firing GameWindow.Resize event: {0}.", e.ToString());

            this.width = e.Width;
            this.height = e.Height;
            
            if (this.Resize != null)
                this.Resize(this, e);

            OnResize(e);
        }

        /// <summary>
        /// Override in derived classes to respond to the Resize events.
        /// </summary>
        /// <param name="e">Contains information about the Resize event.</param>
        protected virtual void OnResize(ResizeEventArgs e)
        {
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

        #region --- IDisposable Members ---

        /// <summary>
        /// Disposes of the GameWindow, releasing all resources consumed by it.
        /// </summary>
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                // Is this safe? Maybe 'Debug' has been disposed, too...
                //Debug.Print("{0} disposing GameWindow.", manual ? "Manually" : "Automatically");

                if (manual)
                {
                    if (glWindow != null)
                    {
                        glWindow.Dispose();
                        glWindow = null;
                    }
                }
                disposed = true;
            }
        }

        ~GameWindow()
        {
            this.Dispose(false);
        }

        #endregion
    }

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

        /// <summary>
        /// Gets the Time elapsed between frame updates, in seconds.
        /// </summary>
        public double Time
        {
            get { return time; }
            internal set { time = value; }
        }
    }
}
