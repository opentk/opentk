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

namespace OpenTK.OpenGL
{
    public class GLForm : Form, IDisposable
    {
        #region Context
        private GLContext _context;

        public GLContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
        #endregion

        #region Constructors
        public GLForm()
        {
            Open(null, 640, 480, 8, 8, 8, 8, 16, 0, false);
        }
        #endregion

        public void Open(string title, int width, int height, int red, int green, int blue, int alpha, int depth, int stencil, bool fullscreen)
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
            Application.Idle += new EventHandler(OnApplicationIdle);
        }

        #region Application main loop
        /// <summary>
        /// Called when all pending messages have been processed, this is where the application 'Main Loop' resides.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">Not used.</param>
        void OnApplicationIdle(object sender, EventArgs e)
        {
            // Check if any new messages have popped up. If not, then run the logic at full speed.
            //while (IsApplicationIdle())
            ////while (idle)
            //{
            //    // We'd like to play nice with the scheduler. If the window is not in focus,
            //    // we give back some thread-time to the OS, to allow other apps to function full-speed.
            //    // However, if the window _is_ in focus we grab all processor resources.
            //    // Hack! Should allow the user to set a sleep interval.
            //    if (ActiveForm != this)
            //        Thread.Sleep(100);
            //    OnPaint(null);
            //}
        }

        /// <summary>
        /// Checks if there all pending messages have been processed.
        /// </summary>
        /// <returns>Returns true if there are no messages left, false otherwise.</returns>
        static public bool IsApplicationIdle()
        {
            //Message msg = Message.Create(this.Handle, A
            
            //try
            //{
                //Message msg;
                Api.Message msg;
                return !OpenTK.Platform.Windows.Api.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            //}
            //catch (Exception e)
            //{
            //    //MessageBox.Show(e.ToString());
            //    return false;
            //}
            //WndProc(ref msg);

            //if (msg.
            //return false;

            //Message msg = Message.Create(IntPtr.Zero, Api.Constants.WM_ENTERIDLE, IntPtr.Zero, IntPtr.Zero);

            //return !Api.PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0);
        }
        #endregion

        bool idle;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            //OnPaint(null);
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Application.Idle -= OnApplicationIdle;
        }

        #endregion
    }
}
