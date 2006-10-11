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

namespace OpenTK
{
    public class Framework : Form, IDisposable
    {
        #region Context
        private GLContext _context;

        public GLContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
        #endregion

        delegate bool IsIdleDelegate();
        IsIdleDelegate IsIdle;

        #region Constructors

        public Framework()
        {
            Open(null, 640, 480, 8, 8, 8, 8, 16, 0, false);
        }

        public Framework(string title, int width, int height, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
        {
            Open(title, width, height, red, green, blue, alpha, depth, stencil, fullscreen);
        }

        #endregion

        public void Open(string title, int width, int height, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
        {
            Application.Idle += new EventHandler(OnIdle);

            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                    Environment.OSVersion.Platform == PlatformID.Win32Windows)
                {
                    IsIdle = new IsIdleDelegate(WindowsIsIdle);
                    WindowsOpen(title, width, height, red, green, blue, alpha, depth, stencil, fullscreen);
                }
                else if (Environment.OSVersion.Platform == PlatformID.Unix)
                {
                    IsIdle = new IsIdleDelegate(XIsIdle);
                }
                else
                {
                    throw new PlatformNotSupportedException("The platform on which you are trying to run this program is not currently supported. Sorry for the inconvenience.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void WindowsOpen(string title, int width, int height, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
        {
            // Hack! Should add more constructors to the GLContext class.
            Context = GLContext.Create(this, 8, 8, 8, 8, 16, 0);

            // Todo: Why doesn't this work?
            if (title == null)
                title = "OpenTK application";
            this.Text = title;

            // Code taken from NeHe tutorials
            this.CreateParams.Style |= (int)Api.WindowClassStyle.HRedraw | (int)Api.WindowClassStyle.VRedraw | (int)Api.WindowClassStyle.OwnDC;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);            // No Need To Erase Form Background
            this.SetStyle(ControlStyles.Opaque, true);                          // No Need To Draw Form Background
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);           // Buffer Control
            //this.SetStyle(ControlStyles.ResizeRedraw, true);                  // Redraw On Resize
            this.SetStyle(ControlStyles.UserPaint, true);                       // We'll Handle Painting Ourselves

            if (fullscreen)
            {
                Api.DeviceMode ScreenSettings = new Api.DeviceMode();       // Device Mode
                ScreenSettings.Size = (short)Marshal.SizeOf(ScreenSettings);    // Size Of The Devmode Structure
                ScreenSettings.PelsWidth = width;                           // Selected Screen Width
                ScreenSettings.PelsHeight = height;                         // Selected Screen Height
                ScreenSettings.BitsPerPel = red + green + blue + alpha;     // Selected Bits Per Pixel
                ScreenSettings.Fields = Api.Constants.DM_BITSPERPEL | Api.Constants.DM_PELSWIDTH | Api.Constants.DM_PELSHEIGHT;

                // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
                if (Api.ChangeDisplaySettings(ref ScreenSettings, Api.Constants.CDS_FULLSCREEN) == Api.Constants.DISP_CHANGE_SUCCESSFUL)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new System.Drawing.Point(0, 0);
                    this.Region = new Region(new Rectangle(0, 0, width, height));
                    this.Capture = true;
                    this.SetTopLevel(true);
                    Cursor.Hide();
                }
                else
                {
                    // Handle failure.
                }
            }

            this.Size = new Size(width, height);

            // Cross-platformness?

        }

        //override protected void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    //OnPaint(null);
        //}

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Application.Idle -= OnIdle;
        }

        #endregion


        #region Event Handlers

        /// <summary>
        /// Called when all pending messages have been processed, this is where the application 'Main Loop' resides.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        private void OnIdle(object sender, EventArgs e)
        {
            while (IsIdle())
            {
                if (ActiveForm != this)
                    Thread.Sleep(100);
                OnPaint(null);
            }
        }

        /// <summary>
        /// Checks if there all pending messages have been processed.
        /// </summary>
        /// <returns>Returns true if there are no messages left, false otherwise.</returns>
        private bool WindowsIsIdle()
        {
            Api.Message msg;
            return !OpenTK.Platform.Windows.Api.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
        }

        private bool XIsIdle()
        {
            throw new NotImplementedException("IsIdle handler not implemented yet!");
        }

        #endregion
    }
}
