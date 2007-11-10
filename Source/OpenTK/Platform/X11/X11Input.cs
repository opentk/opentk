#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;
using System.Diagnostics;
using System.Threading;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives the InputDriver on X11.
    /// This class supports OpenTK, and is not intended for users of OpenTK.
    /// </summary>
    internal sealed class X11Input : IInputDriver
    {
        X11Keyboard keyboardDriver;
        X11Mouse mouseDriver;
        X11.WindowInfo window;

        //XEvent e = new XEvent();

        Thread pollingThread = null;

        bool disposed;

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new X11Input driver. Creates a hidden InputOnly window, child to
        /// the main application window, which selects input events and routes them to 
        /// the device specific drivers (Keyboard, Mouse, Hid).
        /// </summary>
        /// <param name="attach">The window which the InputDriver will attach itself on.</param>
        public X11Input(IWindowInfo attach)
        {
            Debug.WriteLine("Initalizing X11 input driver.");
            Debug.Indent();

            if (attach == null)
                throw new ArgumentException("A valid parent window must be defined, in order to create an X11Input driver.");

            window = new X11.WindowInfo(attach);
            /*
            window = new WindowInfo();
            window.Parent = attach;

            Debug.Print("Creating hidden input window.");

            XSetWindowAttributes wnd_attr = new XSetWindowAttributes();
            wnd_attr.background_pixel = IntPtr.Zero;
            wnd_attr.border_pixel = IntPtr.Zero;
            //wnd_attr.colormap = IntPtr.Zero;
            wnd_attr.event_mask = (IntPtr)
                (EventMask.StructureNotifyMask |
                EventMask.PointerMotionMask | EventMask.PointerMotionHintMask |
                EventMask.ButtonPressMask | EventMask.ButtonReleaseMask |
                EventMask.KeyPressMask | EventMask.KeyReleaseMask);
            uint cw = 
                (uint)SetWindowValuemask.ColorMap | (uint)SetWindowValuemask.EventMask |
                (uint)SetWindowValuemask.BackPixel | (uint)SetWindowValuemask.BorderPixel;

            window.Handle = Functions.XCreateWindow(window.Display, window.Parent.Handle,
                0, 0, 30, 30, 0, Constants.CopyFromParent, Constants.InputOutput,
                IntPtr.Zero, (UIntPtr)cw, ref wnd_attr);
            
            if (window.Handle == IntPtr.Zero)
                throw new ApplicationException("Could not create hidden input window.");

            Functions.XMapWindow(window.Display, window.Handle);
            */
            //window = attach;
            keyboardDriver = new X11Keyboard(window);
            mouseDriver = new X11Mouse(window);

            //pollingThread = new Thread(InternalPoll);
            //pollingThread.Priority = ThreadPriority.BelowNormal;
            //pollingThread.IsBackground = true;
            //pollingThread.Start();
            
            Debug.Unindent();
        }

        #endregion

        #region private void InternalPoll()
#if false
        private void InternalPoll()
        {
            X11.XEvent e = new XEvent();
            try
            {
                while (!disposed)
                {
                    Functions.XMaskEvent(window.Display,
                        EventMask.PointerMotionMask | EventMask.PointerMotionHintMask |
                        EventMask.ButtonPressMask | EventMask.ButtonReleaseMask |
                        EventMask.KeyPressMask | EventMask.KeyReleaseMask |
                        EventMask.StructureNotifyMask, ref e);

                    if (disposed)
                        return;

                    switch (e.type)
                    {
                        case XEventName.KeyPress:
                        case XEventName.KeyRelease:
                            keyboardDriver.ProcessKeyboardEvent(ref e.KeyEvent);
                            break;

                        case XEventName.ButtonPress:
                        case XEventName.ButtonRelease:
                            mouseDriver.ProcessButton(ref e.ButtonEvent);
                            break;

                        case XEventName.MotionNotify:
                            mouseDriver.ProcessMotion(ref e.MotionEvent);
                            break;

                        case XEventName.DestroyNotify:
                            Functions.XPutBackEvent(window.Display, ref e);
                            //pollingThread.Abort();
                            return;
                    }
                }
            }
            catch (ThreadAbortException expt)
            {
                Functions.XUnmapWindow(window.Display, window.Handle);
                Functions.XDestroyWindow(window.Display, window.Handle);
                return;
            }
        }
#endif
        #endregion

        #region internal void ProcessEvent(ref XEvent e)

        internal void ProcessEvent(ref XEvent e)
        {
            switch (e.type)
            {
                case XEventName.KeyPress:
                case XEventName.KeyRelease:
                    //Debug.Print("Keyboard press");
                    keyboardDriver.ProcessKeyboardEvent(ref e.KeyEvent);
                    break;
                    /* See MouseDriver.Poll() instead.
                case XEventName.ButtonPress:
                case XEventName.ButtonRelease:
                    //Debug.Print("Button");
                    mouseDriver.ProcessButton(ref e.ButtonEvent);
                    break;

                case XEventName.MotionNotify:
                    //Debug.Print("Mouse move");
                    mouseDriver.ProcessMotion(ref e.MotionEvent);
                    break;
                    */
            }
        }

        #endregion

        #region --- IInputDriver Members ---

        #region public IList<IInputDevice> InputDevices

        public IList<IInputDevice> InputDevices
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region public IList<Keyboard> Keyboard

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboardDriver.Keyboard; }
        }

        #endregion

        #region public IList<Mouse> Mouse

        public IList<MouseDevice> Mouse
        {
            get { return mouseDriver.Mouse; }
        }

        #endregion

        #region public void Poll()

        /// <summary>
        /// Polls and updates state of all keyboard, mouse and joystick devices.
        /// </summary>
        public void Poll()
        {
            mouseDriver.Poll();

        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                //disposing = true;
                if (pollingThread != null && pollingThread.IsAlive)
                    pollingThread.Abort();

                if (manual)
                {
                }

                disposed = true;
            }
        }

        ~X11Input()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
