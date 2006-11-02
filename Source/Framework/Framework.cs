#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * Contributions from Erik Ylvisaker
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
    public class Framework : IDisposable
    {
        private Form activeForm;
        private GLContext activeContext;
        private PlatformSpecific platform;

        private OpenGL.ColorDepth _color_depth;
        private int _z_depth;
        private int _stencil_depth;

        private string text = "OpenTK Windows application";

        #region --- Public Properties ---

        public Form ActiveForm
        {
            get { return activeForm; }

        }
        public GLContext ActiveContext
        {
            get { return activeContext; }
            private set { activeContext = value; }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;

                if (activeForm != null)
                    activeForm.Text = value;
            }
        }
        public Size ClientSize
        {
            get { return ActiveForm.ClientSize; }
            set { activeForm.ClientSize = value; }
        }
        public int Width
        {
            get { return ClientSize.Width; }
            set { ClientSize = new Size(value, ClientSize.Height); }
        }
        public int Height
        {
            get { return ClientSize.Height; }
            set { ClientSize = new Size(ClientSize.Width, value); }
        }
        public bool IsFullscreen
        {
            get
            {
                return ActiveContext.IsFullscreen;                
            }
        }

        public OpenGL.ColorDepth ColorDepth
        {
            get { return _color_depth; }
            private set { _color_depth = value; }
        }
        public int ZDepth
        {
            get { return _z_depth; }
            set { _z_depth = value; }
        }
        public int StencilDepth
        {
            get { return _stencil_depth; }
            set { _stencil_depth = value; }
        }

        #endregion

        #region --- Creation and Destruction ---

        /// <summary>
        /// Constructs a Framework object.
        /// </summary>
        public Framework()
            : this(null, 800, 600, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 16, 0, false)
        { }
        public Framework(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, 
            int depth, int stencil, bool fullscreen)
        {
            platform = PlatformSpecific.CreatePlatformMethods();

            Setup(title, width, height, color, depth, stencil, fullscreen);
        }
        
        ~Framework()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            if (activeContext != null)
            {
                activeContext.Dispose();
                activeContext = null;
            }
            if (activeForm != null)
            {
                activeForm.Dispose();
                activeForm = null;
            }
        }

        #endregion

        #region --- Creation and setup of windows ---

        private void Setup(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, 
                           int depth, int stencil, bool fullscreen)
        {
            System.Console.WriteLine("Created Framework.");

            // Initialise components.
            ColorDepth = color;
            ZDepth = depth;
            StencilDepth = stencil;

            if (string.IsNullOrEmpty(title) == false)
                Text = title;

            if (fullscreen)
                CreateFullScreenDisplay(width, height);
            else
                CreateWindowedDisplay(width, height);


            System.Console.WriteLine("Done Initializing.");
        }

        private void CreateWindowedDisplay(int width, int height)
        {
            DisposeForm();

            activeForm = new WindowedForm();
            activeForm.Text = Text;

            activeContext = GLContext.Create(activeForm,
                this.ColorDepth, this.ZDepth, this.StencilDepth);

            AttachEvents(activeForm);

            activeForm.Show();

            activeForm.ClientSize = new Size(width, height);
        }

        private void CreateFullScreenDisplay(int width, int height)
        {
            DisposeForm();

            activeForm = new FullScreenForm();
            activeForm.Text = Text;

            activeContext = GLContext.Create(activeForm,
                this.ColorDepth, this.ZDepth, this.StencilDepth);

            AttachEvents(activeForm);

            activeForm.Show();

            activeForm.ClientSize = new Size(width, height);
            activeForm.Location = Point.Empty;

            activeContext.SetFullScreen(width, height, ColorDepth);

            
        }

        private void AttachEvents(Form frm)
        {
            frm.Load += new EventHandler(OnLoad);
            frm.Resize += new EventHandler(OnResize);
            frm.Paint += new PaintEventHandler(OnPaint);
            frm.KeyDown += new KeyEventHandler(OnKeyDown);
            frm.KeyUp += new KeyEventHandler(OnKeyUp);
            frm.KeyPress += new KeyPressEventHandler(OnKeyPress);
            frm.Click += new EventHandler(OnClick);
            frm.MouseDown += new MouseEventHandler(OnMouseDown);
            frm.MouseEnter += new EventHandler(OnMouseEnter);
            frm.MouseHover += new EventHandler(OnMouseHover);
            frm.MouseLeave += new EventHandler(OnMouseLeave);
            frm.MouseMove += new MouseEventHandler(OnMouseMove);
            frm.MouseUp += new MouseEventHandler(OnMouseUp);
            frm.MouseWheel += new MouseEventHandler(OnMouseWheel);
        }

        #endregion

        #region Events
        
        virtual protected void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (MouseWheel != null)
                MouseWheel(sender, e);
        }
        virtual protected void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (MouseUp != null)
                MouseUp(sender, e);
        }
        virtual protected void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (MouseMove != null)
                MouseMove(sender, e);
        }
        virtual protected void OnMouseLeave(object sender, EventArgs e)
        {
            if (MouseLeave != null)
                MouseLeave(sender, e);
        }
        virtual protected void OnMouseHover(object sender, EventArgs e)
        {
            if (MouseHover != null)
                MouseHover(sender, e);
        }
        virtual protected void OnMouseEnter(object sender, EventArgs e)
        {
            if (MouseEnter != null)
                MouseEnter(sender, e);
        }
        virtual protected void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDown != null)
                MouseDown(sender, e);
        }
        virtual protected void OnClick(object sender, EventArgs e)
        {
            if (Click != null)
                Click(sender, e);
        }
        virtual protected void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPress != null)
                KeyPress(sender, e);
        }
        virtual protected void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (KeyUp != null)
                KeyUp(sender, e);
        }
        virtual protected void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (KeyDown != null)
                KeyDown(sender, e);
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            OnPaint();

            if (Paint != null)
                Paint(sender, e);
        }
        virtual protected void OnPaint()
        {            
        }

        virtual protected void OnResize(object sender, EventArgs e)
        {
            if (Resize != null)
                Resize(sender, e);
        }
        virtual protected void OnLoad(object sender, EventArgs e)
        {
            if (Load != null)
                Load(sender, e);
        }

        public event EventHandler Load;
        public event EventHandler Resize;
        public event PaintEventHandler Paint;

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        public event KeyPressEventHandler KeyPress;

        public event EventHandler Click;
        public event MouseEventHandler MouseDown;
        public event EventHandler MouseEnter;
        public event EventHandler MouseHover;
        public event EventHandler MouseLeave;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseUp;
        public event MouseEventHandler MouseWheel;

        #endregion

        #region Window Management

        private void DisposeForm()
        {
            if (activeContext != null)
                activeContext.Dispose();
            if (activeForm != null)
                activeForm.Dispose();

            activeContext = null;
            activeForm = null;
        }

        public void SetResolution(int width, int height, OpenGL.ColorDepth color, bool fullscreen)
        {
            ColorDepth = color;

            if (fullscreen && IsFullscreen)
            {
                activeForm.ClientSize = new Size(width, height);
                activeContext.SetFullScreen(width, height, color);
            }
            else if (fullscreen && !IsFullscreen)
            {
                CreateFullScreenDisplay(width, height);
            }
            else
            {
                CreateWindowedDisplay(width, height);
            }
        }

        #endregion

        #region Render Loop

        public void Run()
        {
            while (ActiveForm != null && ActiveForm.IsDisposed == false)
            {
                OnPaint(this, null);
                
                if (platform.IsIdle() == false)
                    Application.DoEvents();
            }
        }
        
        #endregion
    }

    /*
    public partial class Framework : Form, IDisposable
    {
        #region Public properties

        #region Context

        private GLContext _context;

        public GLContext Context
        {
            get { return _context; }
            internal set { _context = value; }
        }

        #endregion

        #region Fullscreen property

        private bool _fullscreen;

        public bool Fullscreen
        {
            get { return _fullscreen; }
            internal set { _fullscreen = value; }
        }

        #endregion

        #region ColorDepth property

        private OpenTK.OpenGL.ColorDepth _color_depth;

        public OpenTK.OpenGL.ColorDepth ColorDepth
        {
            get { return _color_depth; }
            internal set { _color_depth = value; }
        }

        #endregion

        #region ZDepth property

        private int _z_depth;

        public int ZDepth
        {
            get { return _z_depth; }
            internal set { _z_depth = value; }
        }

        #endregion

        #region StencilDepth property

        private int _stencil_depth;

        public int StencilDepth
        {
            get { return _stencil_depth; }
            internal set { _stencil_depth = value; }
        }

        #endregion

        #region DesktopResolution property

        private Size _desktop_resolution;

        public Size DesktopResolution
        {
            get { return _desktop_resolution; }
            internal set { _desktop_resolution = value; }
        }

        #endregion

        #region DesktopRefreshRate property

        private float _desktop_refresh_rate;

        public float DesktopRefreshRate
        {
            get { return _desktop_refresh_rate; }
            internal set { _desktop_refresh_rate = value; }
        }

        #endregion

        #region DesktopColorDepth property

        private OpenTK.OpenGL.ColorDepth _desktop_color_depth;

        public OpenTK.OpenGL.ColorDepth DesktopColorDepth
        {
            get { return _desktop_color_depth; }
            internal set { _desktop_color_depth = value; }
        }

        #endregion

        #endregion

        FrameworkImplementation Implementation;

        #region Constructors

        public Framework()
        {
            Setup(null, 800, 600, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 16, 0, false);
        }


        public Framework(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, int depth, int stencil, bool fullscreen)
        {
            Setup(title, width, height, color, depth, stencil, fullscreen);
        }

        #endregion

        #region Setup(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, int depth, int stencil, bool fullscreen)

        private void Setup(string title, int width, int height, OpenTK.OpenGL.ColorDepth color, int depth, int stencil, bool fullscreen)
        {
            System.Console.WriteLine("Created Framework.");

            // Set platform.
            try
            {
                PlatformID platform = Environment.OSVersion.Platform;

                if (platform == PlatformID.Win32NT ||
                    platform == PlatformID.Win32Windows)
                {
                    System.Console.Write("Instantiating Windows Implementation...");
                    Implementation = new WindowsImplementation(this);
                    System.Console.WriteLine("success.");

                }
                else if (platform == PlatformID.Unix ||
                    platform == (PlatformID)128) // older versions of Mono report 128.
                {
                    System.Console.Write("Instantiating X11 Implementation...");
                    Implementation = new X11Implementation(this);
                    System.Console.WriteLine("success.");
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

            // Initialise components.
            ColorDepth = color;
            ZDepth = depth;
            StencilDepth = stencil;

            System.Console.WriteLine("Creating Context.");
            Context = GLContext.Create(this, color, depth, stencil);
            
            // Code taken from NeHe tutorials
            this.CreateParams.Style |= (int)WinApi.WindowClassStyle.HRedraw | (int)WinApi.WindowClassStyle.VRedraw | (int)WinApi.WindowClassStyle.OwnDC;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);            // No Need To Erase Form Background
            this.SetStyle(ControlStyles.Opaque, true);                          // No Need To Draw Form Background
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);           // Buffer Control
            //this.SetStyle(ControlStyles.ResizeRedraw, true);                    // Redraw On Resize
            this.SetStyle(ControlStyles.UserPaint, true);                       // We'll Handle Painting Ourselves

            System.Console.WriteLine("Setting Resolution.");
            Implementation.SetResolution(width, height, color, fullscreen);

            if (string.IsNullOrEmpty(title))
                title = "OpenTK Windows application";
            this.Text = title;

            Application.Idle += new EventHandler(OnIdle);

            System.Console.WriteLine("Done Initializing.");
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Called when all pending messages have been processed, this is where the application 'Main Loop' resides.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        protected internal void OnIdle(object sender, EventArgs args)
        {
            while (Implementation.IsIdle())
            {
                //if (ActiveForm != this)
                //    Thread.Sleep(100);
                OnPaint(null);
            }
        }

        #endregion

        internal new void SetTopLevel(bool topLevel)
        {
            base.SetTopLevel(topLevel);
        }

        #region Public member functions

        /// <summary>
        /// Requests mode change. The parameters are hints for the mode, which may or may not be
        /// possible according to the hardware.
        /// </summary>
        /// <param name="width">The horizontal resolution in pixels.</param>
        /// <param name="height">The vertical resolution in pixels.</param>
        /// <param name="color">The color depth.</param>
        /// <param name="fullscreen">Set to true to set a fullscreen mode or false to set a windowed mode.</param>
        /// <returns>True if the mode set was fullscreen, false otherwise.</returns></returns>
        public void SetResolution(int width, int height, OpenTK.OpenGL.ColorDepth color, bool fullscreen)
        {
            Implementation.SetResolution(width, height, color, fullscreen);
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
     * */
}
