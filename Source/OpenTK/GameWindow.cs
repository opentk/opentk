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

namespace OpenTK
{
    public class GameWindow : OpenTK.Platform.IGameWindow
    {
        private INativeWindow glWindow;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        private DisplayMode mode;

        private InputDevices inputDevices;
        public IList<Input.Keyboard> Keyboard { get { return Input.Keyboards; } }
        public InputDevices Input
        { 
            get
            {
                if (inputDevices == null)
                    inputDevices = new InputDevices(this.Handle);
                return inputDevices;
            }
        }

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
        /// </summary>
        public GameWindow()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                // Create a new Windows native window. We want to be notified when it's ready,
                // in order to do some preparatory work.
                glWindow = new OpenTK.Platform.Windows.WinGLNative();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                glWindow = new OpenTK.Platform.X11.X11GLNative();
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }

            glWindow.Resize += new ResizeEvent(glWindow_Resize);
            glWindow.Create += new CreateEvent(glWindow_Create);
        }

        void glWindow_Create(object sender, EventArgs e)
        {
            //glWindow.Context.MakeCurrent();
            inputDevices = new InputDevices(this.Handle); 

            this.OnCreate(e);
        }

        void glWindow_Resize(object sender, ResizeEventArgs e)
        {
            this.OnResize(e);
        }

        #endregion

        #region --- INativeWindow Members ---

        #region public void CreateWindow(DisplayMode mode)

        /// <summary>
        /// Creates a new render window.
        /// </summary>
        /// <param name="mode">The DisplayMode of the render window.</param>
        /// <exception cref="ApplicationException">Occurs when a render window already exists.</exception>
        public void CreateWindow(DisplayMode mode)
        {
            if (!Created)
            {
                glWindow.CreateWindow(mode);
            }
            else
            {
                throw new ApplicationException("A render window already exists");
            }
        }

        #endregion

        #region public IntPtr Handle

        /// <summary>
        /// Gets the handle of the current GameWindow.
        /// </summary>
        public IntPtr Handle
        {
            get { return glWindow.Handle; }
        }

        #endregion

        #region public void Exit()

        /// <summary>
        /// Gracefully exits the current GameWindow.
        /// </summary>
        public void Exit()
        {
            glWindow.Exit();
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

        #region public bool Quit

        /// <summary>
        /// Gets a value indicating whether the current GameWindow is quitting.
        /// </summary>
        /// <remarks>
        /// You should not call OnRenderFrame, Resize, and other GameWindow related function
        /// when the quit sequence has been initiated, as indicated by the Quitting property.
        /// NullReference- or ApplicationExceptions may occur otherwise.
        /// </remarks>
        public bool Quit
        {
            get { return glWindow.Quit; }
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
                if (!glWindow.Created)
                {
                    mode = new DisplayMode(640, 480);
                    this.CreateWindow(mode);
                }
                return glWindow.Context;
            }
        }

        #endregion

        #region public bool Created

        /// <summary>
        /// Gets a value indicating whether a render window has been created.
        /// </summary>
        public bool Created
        {
            get { return glWindow.Created; }
        }

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
            while (!this.Quit)
            {
                this.ProcessEvents();
                this.OnUpdateFrame();
                this.OnRenderFrame();
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
            glWindow.ProcessEvents();
        }

        #endregion

        #region public event CreateEvent Create;

        public event CreateEvent Create;

        private void OnCreate(EventArgs e)
        {
            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region public virtual void OnRenderFrame()

        /// <summary>
        /// Raises the RenderFrame event. Override in derived classes to render a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnRenderFrame() function should be called, to ensure
        /// listeners are notified of RenderFrame events.
        /// </remarks>
        public virtual void OnRenderFrame()
        {
            if (!this.Created)
            {
                Debug.Print("WARNING: RenderFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }
            if (RenderFrame != null)
                RenderFrame(EventArgs.Empty);
        }

        #endregion

        #region public virtual void OnUpdateFrame()

        /// <summary>
        /// Raises the UpdateFrame event. Override in derived classes to update a frame.
        /// </summary>
        /// <remarks>
        /// If overriden, the base.OnUpdateFrame() function should be called, to ensure
        /// listeners are notified of UpdateFrame events.
        /// </remarks>
        public virtual void OnUpdateFrame()
        {
            if (!this.Created)
            {
                Debug.Print("WARNING: UpdateFrame event raised, without a valid render window. This may indicate a programming error. Creating render window.");
                mode = new DisplayMode(640, 480);
                this.CreateWindow(mode);
            }
            if (UpdateFrame != null)
                UpdateFrame(EventArgs.Empty);
        }

        #endregion

        /// <summary>
        /// Occurs when it is time to update the next frame.
        /// </summary>
        public event UpdateFrameEvent UpdateFrame;

        /// <summary>
        /// Occurs when it is time to render the next frame.
        /// </summary>
        public event RenderFrameEvent RenderFrame;

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
            if (this.Resize != null)
                this.Resize(this, e);
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            glWindow.Dispose();
            glWindow = null;
        }

        #endregion
    }
}
