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

        #region --- Constructors ---

        public X11Input(WindowInfo parent)
        {
            Debug.WriteLine("Initalizing X11 input driver.");
            Debug.Indent();

            Debug.WriteLine("Creating hidden input window.");

            SetWindowAttributes wnd_attributes = new SetWindowAttributes();
            wnd_attributes.background_pixel = 0;
            wnd_attributes.border_pixel = 0;
            wnd_attributes.colormap = IntPtr.Zero;
            wnd_attributes.event_mask = EventMask.KeyPressMask | EventMask.KeyReleaseMask;

            CreateWindowMask cw_mask =
                CreateWindowMask.CWEventMask;

            WindowInfo window = new WindowInfo(parent);

            window.Handle = API.CreateWindow(
                window.Display,
                window.RootWindow,
                0, 0,
                1, 1,
                0,
                //glxVisualInfo.depth,
                //glContext.XVisualInfo.depth,
                0,
                Constants.InputOnly,
                //glxVisualInfo.visual,
                //glContext.XVisualInfo.visual,
                IntPtr.Zero,
                cw_mask,
                wnd_attributes
            );

            if (window.Handle == IntPtr.Zero)
            {
                throw new Exception("Could not create input window.");
            }

            Debug.WriteLine("done! (id: " + window + ")");

            // Select input events to be reported here.
            API.SelectInput(window.Display, window.Handle,
                EventMask.KeyReleaseMask | EventMask.KeyPressMask);

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

        #endregion
    }
}
