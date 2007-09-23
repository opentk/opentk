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
    public class GameWindow : OpenTK.Platform.IGameWindow
    {
        #region --- Fields ---

        private INativeGLWindow glWindow;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        private DisplayMode mode;

        private InputDriver driver;

        private bool isExiting;
        private bool disposed;

        private double updateTime, renderTime, eventTime, frameTime;

        #endregion

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
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

            glWindow.Resize += new ResizeEvent(glWindow_Resize);
            glWindow.Create += new CreateEvent(glWindow_CreateInputDriver);
            glWindow.Destroy += new DestroyEvent(glWindow_Destroy);
        }

        void glWindow_Destroy(object sender, EventArgs e)
        {
            Debug.Print("GameWindow destruction imminent.");
            this.isExiting = true;
            this.OnDestroy(EventArgs.Empty);
            glWindow.Destroy -= glWindow_Destroy;
            //this.Dispose();
        }

        void glWindow_CreateInputDriver(object sender, EventArgs e)
        {
            //glWindow.Context.MakeCurrent();

            if (driver == null)
                driver = new InputDriver(this.WindowInfo);
            glWindow.Create -= glWindow_CreateInputDriver;

            this.OnCreate(e);
        }

        void glWindow_Resize(object sender, ResizeEventArgs e)
        {
            this.OnResize(e);
        }

        #endregion

        #region --- Internal Properties ---

        #region public IList<OpenTK.Input.IInputDevice> Input

        internal InputDriver InputDriver
        {
            get
            {
                if (driver == null && !this.IsExiting)
                {
                    Debug.WriteLine("WARNING: Accessed null InputDriver - creating new. This may indicate a prorgamming error.");
                    driver = new InputDriver(this.WindowInfo);
                }
                return driver;
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
        /// Gets a value indicating whether a render window has been exists.
        /// </summary>
        public bool Exists
        {
            get { return glWindow == null ? false : glWindow.Exists; }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return glWindow.WindowInfo; }
        }

        #endregion

        #region public void CreateWindow(DisplayMode mode)

        /// <summary>
        /// Creates a new render window. The Create event is raised after the window creation
        /// is complete, to allow resource initalisation.
        /// </summary>
        /// <param name="mode">The DisplayMode of the render window.</param>
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
                //OpenTK.OpenGL.GL.LoadAll();
            }
            else
            {
                throw new ApplicationException("A render window already exists");
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
            resizeEventArgs.Width = this.Width;
            resizeEventArgs.Height = this.Height;
            this.OnResize(resizeEventArgs);

            Debug.Print("Entering main loop");

            Stopwatch watch = new Stopwatch();
            UpdateFrameEventArgs updateArgs = new UpdateFrameEventArgs();
            RenderFrameEventArgs renderArgs = new RenderFrameEventArgs();

            double update_target = 0.0, render_target = 0.0, next_update = 0.0, next_render = 0.0;
            double time, total_time;

            if (update_frequency > 0.0)
            {
                next_update = update_target = 1.0 / update_frequency;
            }
            if (render_frequency > 0.0)
            {
                next_render = render_target = 1.0 / render_frequency;
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
                        this.OnUpdateFrame(updateArgs);
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
                        this.OnRenderFrame(renderArgs);
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
            if (driver != null)
                driver.Poll();
            glWindow.ProcessEvents();
        }

        #endregion

        #region public virtual void OnRenderFrame(RenderFrameEventArgs e)

        /// <summary>
        /// Raises the RenderFrame event. Override in derived classes to render a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnRenderFrame() function should be called, to ensure
        /// listeners are notified of RenderFrame events.
        /// </remarks>
        public virtual void OnRenderFrame(RenderFrameEventArgs e)
        {
            if (!this.Exists && !this.IsExiting)
            {
                Debug.Print("WARNING: RenderFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }
            if (RenderFrame != null)
                RenderFrame(this, e);
        }

        /// <summary>
        /// Occurs when it is time to render the next frame.
        /// </summary>
        public event RenderFrameEvent RenderFrame;

        #endregion

        #region public virtual void OnUpdateFrame(UpdateFrameEventArgs e)

        /// <summary>
        /// Raises the UpdateFrame event. Override in derived classes to update a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnUpdateFrame() function should be called, to ensure
        /// listeners are notified of UpdateFrame events.
        /// </remarks>
        public virtual void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (!this.Exists && !this.IsExiting)
            {
                Debug.Print("WARNING: UpdateFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }
            if (UpdateFrame != null)
                UpdateFrame(this, e);
        }

        /// <summary>
        /// Occurs when it is time to update the next frame.
        /// </summary>
        public event UpdateFrameEvent UpdateFrame;

        #endregion

        #region public virtual void OnLoad(EventArgs e)

        /// <summary>
        /// Raises the Load event. Override to load resources that should
        /// be maintained for the lifetime of the application.
        /// </summary>
        public virtual void OnLoad(EventArgs e)
        {
            Debug.Print("Firing GameWindow.Load event.");
            if (this.Load != null)
            {
                this.Load(this, e);
            }
        }

        /// <summary>
        /// Occurs after the GameWindow has been created, but before
        /// entering the main loop.
        /// </summary>
        public event LoadEvent Load;

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

        #region public IList<Keyboard> Keyboard

        /// <summary>
        /// Gets the list of available Keyboard devices.
        /// </summary>
        public IList<Keyboard> Keyboard
        {
            get
            {
                return InputDriver.Keyboard;
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
            get { return glWindow.Width; }
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
            get { return glWindow.Height; }
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

        public event ResizeEvent Resize;

        /// <summary>
        /// Raises the Resize event.
        /// </summary>
        /// <param name="e">Contains the new Width and Height of the window.</param>
        protected virtual void OnResize(ResizeEventArgs e)
        {
            Debug.Print("Firing GameWindow.Resize event: {0}.", e.ToString());
            if (this.Resize != null)
                this.Resize(this, e);
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

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                // Is this safe? Maybe 'Debug' has been disposed, too...
                //Debug.Print("{0} disposing GameWindow.", manual ? "Manually" : "Automatically");

                if (manual)
                {
                    if (driver != null)
                    {
                        driver.Dispose();
                        driver = null;
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
