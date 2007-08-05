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

        Event e = new Event();
        KeyEvent keyEvent = new KeyEvent();
        int pending;

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

            Debug.WriteLine("Creating hidden input window.");

            SetWindowAttributes wnd_attributes = new SetWindowAttributes();
            wnd_attributes.background_pixel = 0;
            wnd_attributes.border_pixel = 0;
            wnd_attributes.colormap = IntPtr.Zero;
            wnd_attributes.event_mask = EventMask.KeyPressMask | EventMask.KeyReleaseMask;

            CreateWindowMask cw_mask =
                CreateWindowMask.CWEventMask;

            window = new WindowInfo(parent);

            window.Handle = API.CreateWindow(
                window.Display,
                window.Parent.Handle,
                0, 0,
                0, 0,
                0, 0,
                Constants.InputOnly,
                window.VisualInfo.visual,
                cw_mask,
                wnd_attributes
            );

            if (window.Handle == IntPtr.Zero)
            {
                throw new Exception("Could not create input window.");
            }

            API.MapWindow(window.Display, window.Handle);

            Debug.WriteLine("done! (id: " + window + ")");

            // Select input events to be reported here.
            //API.SelectInput(window.Display, window.Handle,
            //    EventMask.KeyReleaseMask | EventMask.KeyPressMask);

            keyboardDriver = new X11Keyboard(window);

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
            pending = API.Pending(window.Display);

            if (pending == 0)
                return;

            API.PeekEvent(window.Display, e);
            Debug.Write(String.Format("Input window received {0} event... ", e.Type.ToString()));

            switch (e.Type)
            {
                case EventType.KeyPress:
                case EventType.KeyRelease:
                    API.NextEvent(window.Display, keyEvent);
                    Debug.WriteLine(" consumed!");
                    keyboardDriver.ProcessKeyboardEvent(keyEvent);
                    break;

                default:
                    API.NextEvent(window.Display, e);
                    Debug.WriteLine(" not consumed.");
                    break;
            }
        }

        #endregion
    }
}
