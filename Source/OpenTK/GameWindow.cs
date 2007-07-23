#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Platform;
using System.Diagnostics;

namespace OpenTK
{
    public class GameWindow : OpenTK.Platform.IGLControl, OpenTK.Platform.IGameWindow
    {
        INativeWindow glWindow;

        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
        /// </summary>
        public GameWindow()
        {
            System.Diagnostics.Debug.Listeners.Clear();
            System.Diagnostics.Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            System.Diagnostics.Debug.AutoFlush = true;
            System.Diagnostics.Trace.Listeners.Clear();
            System.Diagnostics.Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            System.Diagnostics.Trace.AutoFlush = true;

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

            glWindow.Context.MakeCurrent();

            // When the glWindow construction is complete, hook the resize events.
            resizeEventArgs.Width = this.Width;
            resizeEventArgs.Height = this.Height;
            glWindow.Resize += new ResizeEvent(glWindow_Resize);
            glWindow.Create += new CreateEvent(glWindow_Create);
        }

        void glWindow_Create(object sender, EventArgs e)
        {
            this.OnCreate(e);
        }

        void glWindow_Resize(object sender, ResizeEventArgs e)
        {
            this.OnResize(e);
        }

        #endregion

        #region --- IGLWindow Members ---

        #region public bool IsIdle

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

        #region public OpenTK.Platform.IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glWindow.Context; }
        }

        #endregion

        #region public bool Quit

        public bool Quit
        {
            get { return glWindow.Quit; }
            set { glWindow.Quit = value; }
        }

        #endregion

        #endregion

        #region --- IGameWindow Members ---

        /// <summary>
        /// Runs a default game loop on the GameWindow.
        /// </summary>
        /// <remarks>
        /// <para>
        /// A default game loop consists of three parts: Event processing,
        /// a frame update and a frame render.
        /// </para>
        /// <para>
        /// Override this function if you want to change the behaviour of the
        /// default game loop. If you override this function, you must place
        /// a call to the ProcessEvents function, so that your window will respond
        /// to Operating System events.
        /// </para>
        /// </remarks>
        public virtual void Run()
        {
            while (!this.Quit)
            {
                this.ProcessEvents();
                this.UpdateFrame();
                this.RenderFrame();
            }
        }

        public void ProcessEvents()
        {
            glWindow.ProcessEvents();
        }

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

        public virtual void RenderFrame()
        {
            if (RenderFrameNotify != null)
                RenderFrameNotify(EventArgs.Empty);
        }

        public virtual void UpdateFrame()
        {
            if (UpdateFrameNotify != null)
                UpdateFrameNotify(EventArgs.Empty);
        }

        public event UpdateFrameEvent UpdateFrameNotify;
        public event RenderFrameEvent RenderFrameNotify;

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
