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

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives the InputDriver on X11.
    /// This class supports OpenTK, and is not intended for users of OpenTK.
    /// </summary>
    internal sealed class X11Input : IInputDriver
    {
        private X11Keyboard keyboardDriver;
        private WindowInfo window;

        XEvent e = new XEvent();

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new X11Input driver. Creates a hidden InputOnly window, child to
        /// the main application window, which selects input events and routes them to 
        /// the device specific drivers (Keyboard, Mouse, Hid).
        /// </summary>
        /// <param name="parent"></param>
        public X11Input(WindowInfo parent)
        {
            Debug.WriteLine("Initalizing X11 input driver.");
            Debug.Indent();

            if (parent == null)
            {
                throw new ArgumentException("A valid parent window must be defined, in order to create an X11Input driver.");
            }
            /*
            Debug.WriteLine("Creating hidden input window.");

            SetWindowAttributes wnd_attributes = new SetWindowAttributes();
            wnd_attributes.background_pixel = 0;
            wnd_attributes.border_pixel = 0;
            wnd_attributes.colormap = IntPtr.Zero;
            wnd_attributes.event_mask = EventMask.KeyPressMask | EventMask.KeyReleaseMask |
                EventMask.FocusChangeMask;

            CreateWindowMask cw_mask =
                CreateWindowMask.CWEventMask;

            window = new WindowInfo(parent);

            window.Handle = API.CreateWindow(
                window.Display,
                window.Parent.Handle,
                0, 0,
                1, 1,
                0, 0,
                Constants.InputOnly,
                //window.VisualInfo.visual,
                (IntPtr)0,
                cw_mask,
                wnd_attributes
            );

            if (window.Handle == IntPtr.Zero)
            {
                throw new Exception("Could not create input window.");
            }

            API.MapWindow(window.Display, window.Handle);
            API.GrabKeyboard(window.Display, window.Handle, false, GrabMode.GrabModeAsync, GrabMode.GrabModeAsync, 0);

            Debug.WriteLine("done! (id: " + window + ")");
             
            keyboardDriver = new X11Keyboard(window);
            */

            window = new WindowInfo(parent);
            keyboardDriver = new X11Keyboard(parent);
            // Todo: donparent's mask is now specified by hand, hard to keep in sync.
            API.SelectInput(parent.Display, parent.Handle, EventMask.StructureNotifyMask |
                EventMask.SubstructureNotifyMask | EventMask.ExposureMask |
                EventMask.KeyReleaseMask | EventMask.KeyPressMask);

            Debug.Unindent();
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

        public IList<Keyboard> Keyboard
        {
            get { return keyboardDriver.Keyboard; }
        }

        #endregion

        #region public IList<Mouse> Mouse

        public IList<Mouse> Mouse
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        /// <summary>
        /// Consumes to keyboard, mouse, etc events, routing them to their
        /// respective drivers.
        /// </summary>
        public void ProcessEvents()
        {
            while (API.CheckMaskEvent(window.Display, EventMask.KeyReleaseMask | EventMask.KeyPressMask, ref e))
            {
                keyboardDriver.ProcessKeyboardEvent(e.KeyEvent);
            }
            /*
            if (API.Pending(window.Display) > 0)
            {
                Functions.XPeekEvent(window.Display, ref e);
                if (e.type == XEventName.KeyRelease || e.type == XEventName.KeyPress)
                {
                    keyboardDriver.ProcessKeyboardEvent(e.KeyEvent);
                }
            }
            */
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
