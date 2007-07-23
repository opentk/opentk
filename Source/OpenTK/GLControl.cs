#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using OpenTK.Platform;

#endregion

namespace OpenTK
{
    // TODO: Document the GLControl class.

    /// <summary>
    /// 
    /// </summary>
    public partial class GLControl : UserControl, IGLControl
    {
        #region --- Private Fields ---

        private bool fullscreen;
        private IGLControl glControl;

        #endregion

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GLControl.
        /// </summary>
        public GLControl()
            :this(new DisplayMode())
        {
        }

        public GLControl(DisplayMode mode)
        {
            InitializeComponent();

            System.Diagnostics.Debug.Listeners.Clear();
            System.Diagnostics.Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            System.Diagnostics.Debug.AutoFlush = true;
            System.Diagnostics.Trace.Listeners.Clear();
            System.Diagnostics.Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            System.Diagnostics.Trace.AutoFlush = true;
            Trace.AutoFlush = true;

            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glControl = new OpenTK.Platform.Windows.WinGLControl(this, Width, Height, false);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                     Environment.OSVersion.Platform == (PlatformID)128)
                    // some older versions of Mono reported 128.
            {
                glControl =  new OpenTK.Platform.X11.X11GLControl(this, Width, Height, false);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }

            glControl.Context.MakeCurrent();
            /*
            Context.MakeCurrent();

            //GL.ReloadFunctions();

            if (width > 0)
                this.Width = width;
            if (height > 0)
                this.Height = height;
            */
            if (fullscreen)
                this.Fullscreen = true;
            
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region --- Public Methods ---

        /// <summary>
        /// Swaps the front and back buffers, and presents the rendered scene to the screen.
        /// </summary>
        public void SwapBuffers()
        {
            Context.SwapBuffers();
        }

        /// <summary>
        /// Makes the underlying GLContext of this GLControl current. All OpenGL commands issued
        /// from this point are interpreted by this GLContext.
        /// </summary>
        public void MakeCurrent()
        {
            Context.MakeCurrent();
        }

        #endregion

        #region --- Public Properties ---

        /// <summary>
        /// Gets the AspectRatio of the control this GLContext object
        /// renders to. This is usually used in a call to Glu.Perspective.
        /// </summary>
        public double AspectRatio
        {
            get
            {
                return this.Width / (double)this.Height;
            }
        }

        /// <summary>
        /// Gets or sets the display mode of the control.
        /// </summary>
        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                if (!fullscreen && value)
                {
                    //fullscreen = this.SetFullscreenResolution(this.Width, this.Height);
                }
                else if (fullscreen && !value)
                {
                }
            }
        }

        #endregion

        #region --- IGLControl Members ---

        public event CreateEvent Create;

        #region public bool IsIdle

        /// <summary>
        /// Gets the idle status of the control.
        /// </summary>
        public bool IsIdle
        {
            get { return glControl.IsIdle; }
        }

        #endregion

        #region public IGLContext Context

        /// <summary>
        /// Gets the opengl context associated with this control.
        /// </summary>
        public IGLContext Context
        {
            get { return glControl.Context; }
        }

        #endregion

        #region DisplayMode changes

        /// <summary>
        /// Selects the fullscreen DisplayMode closest to the DisplayMode requested.
        /// </summary>
        /// <param name="mode">
        /// The fullscreen DisplayMode to match, or null to get the current screen DisplayMode.
        /// </param>
        /// <returns>The DisplayMode closest to the requested one, or null if no DisplayModes are available.</returns>
        /// <remarks>
        /// <see cref="SetDisplayMode">SetDisplayMode</see>
        /// </remarks>
        public DisplayMode SelectDisplayMode(DisplayMode mode)
        {
            throw new NotImplementedException();
            //return glWindow.SelectDisplayMode(mode);
        }

        /// <summary>
        /// Selects the fullscreen DisplayMode closest to the DisplayMode requested, accoriding to the specified
        /// parameters.
        /// </summary>
        /// <param name="mode">
        /// The fullscreen DisplayMode to match, or null to get the current screen DisplayMode.
        /// </param>
        /// <param name="options">
        /// The DisplayModeMatchOptions flags that indicate how to search for the requested DisplayMode.
        /// </param>
        /// <returns>
        /// The DisplayMode closest to the requested one, or null if no DisplayModes are available or
        /// DisplayModeMatchOptions.ExactMatch was passed.
        /// </returns>
        /// <remarks>
        /// <see cref="SetDisplayMode">SetDisplayMode</see>
        /// </remarks>
        public DisplayMode SelectDisplayMode(DisplayMode mode, DisplayModeMatchOptions options)
        {
            throw new NotImplementedException();
            //return glWindow.SelectDisplayMode(mode, options);
        }

        /// <summary>
        /// Sets the requested DisplayMode.
        /// </summary>
        /// <param name="mode">
        /// The fulscreen DisplayMode to set. Passing null will return the application to windowed
        ///  mode.
        /// </param>
        /// <remarks>
        /// Use SelectDisplayMode to select one of the available fullscreen modes.
        /// <para>
        /// If the mode requested is not available, this function will throw a
        ///  <exception cref="DisplayModeNotAvailable">DisplayModeNotAvailable</exception> exception.
        /// </para>
        /// <para>
        /// Pass null to return to windowed mode. The previous desktop DisplayMode will be automatically reset by this
        /// function. This function cannot be used to permanently change the user's desktop DisplayMode.
        /// </para>
        /// <see cref="SelectDisplayMode(DisplayMode mode)">SelectDisplayMode</see>
        /// <seealso cref="DisplayModeNotAvailable">DisplayModeNotAvailable exception</seealso>
        /// </remarks>
        public void SetDisplayMode(DisplayMode mode)
        {
            throw new NotImplementedException();
            //glWindow.SetDisplayMode(mode);
        }

        #endregion

        public void ProcessEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region --- IResizable Members ---

        public new event ResizeEvent Resize;

        #endregion

        #region --- IDisposable Members ---

        protected override void DestroyHandle()
        {
            base.DestroyHandle();

            glControl.Dispose();
        }

        /*
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (manuallyCalled)
            {
                glWindow.Dispose();
            }
        }

        ~GLControl()
        {
            this.Dispose(false);
        }
        */
        #endregion
    }
}
