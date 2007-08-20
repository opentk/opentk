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

        #endregion

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
        /// </summary>
        public GameWindow()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glWindow = new OpenTK.Platform.Windows.WinGLNative();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                glWindow = new OpenTK.Platform.X11.X11GLNative();
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your platform is not currently supported. Refer to http://opentk.sourceforge.net for more information."
                );
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
            this.Dispose();
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
                glWindow.CreateWindow(mode);
                OpenTK.OpenGL.GL.LoadAll();
            }
            else
            {
                throw new ApplicationException("A render window already exists");
            }
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        /// <summary>
        /// Raises the Create event. Override in derived classes to initialize resources.
        /// </summary>
        /// <param name="e"></param>
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
        /// Runs the default game loop on GameWindow (process event->update frame->render frame).
        /// </summary>
        /// <remarks>
        /// <para>
        /// A default game loop consists of three parts: Event processing,
        /// a frame update and a frame render.
        /// </para>
        /// <para>
        /// Override this function if you want to change the behaviour of the
        /// default game loop. If you override this function, you must place
        /// a call to the ProcessEvents function, to ensure window will respond
        /// to Operating System events.
        /// </para>
        /// </remarks>
        public virtual void Run()
        {
            this.OnLoad(EventArgs.Empty);
            resizeEventArgs.Width = this.Width;
            resizeEventArgs.Height = this.Height;
            this.OnResize(resizeEventArgs);

            Debug.Print("Entering main loop");

            while (this.Exists && !IsExiting)
            {
                this.ProcessEvents();
                if (!IsExiting)
                {
                    this.OnUpdateFrame(EventArgs.Empty);
                    this.OnRenderFrame(EventArgs.Empty);
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
                driver.ProcessEvents();
            glWindow.ProcessEvents();
        }

        #endregion

        #region public virtual void OnRenderFrame(EventArgs e)

        /// <summary>
        /// Raises the RenderFrame event. Override in derived classes to render a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnRenderFrame() function should be called, to ensure
        /// listeners are notified of RenderFrame events.
        /// </remarks>
        public virtual void OnRenderFrame(EventArgs e)
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

        #region public virtual void OnUpdateFrame(EventArgs e)

        /// <summary>
        /// Raises the UpdateFrame event. Override in derived classes to update a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnUpdateFrame() function should be called, to ensure
        /// listeners are notified of UpdateFrame events.
        /// </remarks>
        public virtual void OnUpdateFrame(EventArgs e)
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

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                // Is this safe? Maybe 'Debug' has been disposed, too...
                Debug.Print("{0} disposing GameWindow.", manual ? "Manually" : "Automatically");

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
            Dispose(false);
        }

        #endregion
    }
}
