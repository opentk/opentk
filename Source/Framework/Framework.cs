#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using OpenTK.Platform.Windows;
using System.Runtime.InteropServices;
using OpenTK.OpenGL.Platform;
using OpenTK.OpenGL;

namespace OpenTK.Frameworks
{
    public partial class Framework : Form, IDisposable
    {
        #region Public properties

        #region Context

        private GLContext _context;

        public GLContext Context
        {
            get { return _context; }
            protected set { _context = value; }
        }

        #endregion

        #region Fullscreen property

        private bool _fullscreen;

        public bool Fullscreen
        {
            get { return _fullscreen; }
            private set { _fullscreen = value; }
        }

        #endregion

        #region ColorDepth property

        private OpenTK.OpenGL.ColorDepth _color_depth;

        public OpenTK.OpenGL.ColorDepth ColorDepth
        {
            get { return _color_depth; }
            set { _color_depth = value; }
        }

        #endregion

        #region ZDepth property

        private int _z_depth;

        public int ZDepth
        {
            get { return _z_depth; }
            set { _z_depth = value; }
        }

        #endregion

        #region StencilDepth property

        private int _stencil_depth;

        public int StencilDepth
        {
            get { return _stencil_depth; }
            set { _stencil_depth = value; }
        }

        #endregion

        #region DesktopResolution property

        private Size _desktop_resolution;

        public Size DesktopResolution
        {
            get { return _desktop_resolution; }
            protected set { _desktop_resolution = value; }
        }

        #endregion

        #region DesktopRefreshRate property

        private float _desktop_refresh_rate;

        public float DesktopRefreshRate
        {
            get { return _desktop_refresh_rate; }
            protected set { _desktop_refresh_rate = value; }
        }

        #endregion

        #endregion

        FrameworkImplementation Implementation;

        #region Constructors

        public Framework()
        {
            Setup(null, 640, 480, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 16, 0, false);
        }


        public Framework(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, int depth, int stencil, bool fullscreen)
        {
            Setup(title, width, height, color, depth, stencil, fullscreen);
        }

        #endregion

        public void Setup(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, int depth, int stencil, bool fullscreen)
        {
            // Initialise components.
            ColorDepth = color;
            ZDepth = depth;
            StencilDepth = stencil;
            
            // Set platform.
            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT || Environment.OSVersion.Platform == PlatformID.Win32Windows)
                {
                    Implementation = new WindowsImplementation(this);
                }
                else if (Environment.OSVersion.Platform == PlatformID.Unix)
                {
                    Implementation = new X11Implementation();
                }
                else
                {
                    throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw e;
            }

            this.HandleCreated += new EventHandler(Implementation.OnHandleCreated);
            
            //Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            //if (xplatui != null)
            //{
            //    Context = GLContext.Create(this, 8, 8, 8, 8, 16, 0);
            //    //Context.MakeCurrent();
            //}

            Context = GLContext.Create(this, color, depth, stencil);
            
            // Code taken from NeHe tutorials
            this.CreateParams.Style |= (int)Api.WindowClassStyle.HRedraw | (int)Api.WindowClassStyle.VRedraw | (int)Api.WindowClassStyle.OwnDC;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);            // No Need To Erase Form Background
            this.SetStyle(ControlStyles.Opaque, true);                          // No Need To Draw Form Background
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);           // Buffer Control
            //this.SetStyle(ControlStyles.ResizeRedraw, true);                    // Redraw On Resize
            this.SetStyle(ControlStyles.UserPaint, true);                       // We'll Handle Painting Ourselves

            this.Size = new Size(width, height);
            Fullscreen = Implementation.SetResolution(fullscreen);
            this.Size = new Size(width, height);    // Force the window to change to the requested resolution.

            if (title == null)
                title = "OpenTK Windows application";
            this.Text = title;

            Application.Idle += new EventHandler(OnIdle);
        }

        #region Event Handlers

        /// <summary>
        /// Called when all pending messages have been processed, this is where the application 'Main Loop' resides.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        protected void OnIdle(object sender, EventArgs args)
        {
            while (Implementation.IsIdle())
            {
                if (ActiveForm != this)
                    Thread.Sleep(100);
                OnPaint(null);
            }
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            //GC.SuppressFinalize(true);
            Application.Idle -= OnIdle;
        }

        #endregion
    }
}
