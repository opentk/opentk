#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using OpenTK.OpenGL;
using OpenTK.Input;

//using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives GameWindow on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLNative : INativeGLWindow, IDisposable
    {
        #region --- Fields ---

        private WindowInfo window = new WindowInfo();
        private DisplayMode mode = new DisplayMode();
        private X11Input driver;

        // Number of pending events.
        private int pending = 0;

        private int top, bottom, left, right;

        // C# ResizeEventArgs
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        // Used for event loop.
        private XEvent e = new XEvent();

        private bool disposed;
        private bool exists;
        private bool isExiting;

        // XAtoms for window properties
        private static IntPtr WMTitle;      // The title of the GameWindow.
        private static IntPtr UTF8String;   // No idea.

        #endregion

        #region --- Public Constructors ---

        /// <summary>
        /// Constructs and initializes a new X11GLNative window.
        /// Call CreateWindow to create the actual render window.
        /// </summary>
        public X11GLNative()
        {
            Debug.Print("Native window driver: {0}", this.ToString());

            //Utilities.ThrowOnX11Error = true; // Not very reliable

            // Open the display to the X server, and obtain the screen and root window.
            window.Display = API.OpenDisplay(null); // null == default display
            if (window.Display == IntPtr.Zero)
                throw new Exception("Could not open connection to X");

            window.Screen = API.DefaultScreen(window.Display);
            window.RootWindow = API.RootWindow(window.Display, window.Screen);

            Debug.Print("Display: {0}, Screen {1}, Root window: {2}",
                window.Display, window.Screen, window.RootWindow);

            RegisterAtoms(window);
        }

        #endregion

        #region private static void RegisterAtoms()

        /// <summary>
        /// Not used yet.
        /// Registers the necessary atoms for GameWindow.
        /// </summary>
        private static void RegisterAtoms(WindowInfo window)
        {
            string[] atom_names = new string[] 
            {
                "WM_TITLE",
                "UTF8_STRING"
            };
            IntPtr[] atoms = new IntPtr[atom_names.Length];
            //Functions.XInternAtoms(window.Display, atom_names, atom_names.Length, false, atoms);

            int offset = 0;
            WMTitle = atoms[offset++];
            UTF8String = atoms[offset++];
        }

        #endregion

        #region --- INativeGLWindow Members ---

        #region public void ProcessEvents()

        public void ProcessEvents()
        {
            // Process all pending events
            while (true)
            {
                //pending = Functions.XPending(window.Display);
                pending = API.Pending(window.Display);

                if (pending == 0)
                    return;

                Functions.XNextEvent(window.Display, ref e);

                //Debug.Print("Event: {0} ({1} pending)", e.type, pending);

                // Respond to the event e
                switch (e.type)
                {
                    case XEventName.MapNotify:
                        Debug.WriteLine("Window mapped.");
                        return;

                    case XEventName.CreateNotify:
                        // A child was was created - nothing to do
                        break;

                    case XEventName.ClientMessage:
                        this.OnDestroy(EventArgs.Empty);
                        break;

                    case XEventName.DestroyNotify:
                        exists = false;
                        isExiting = true;
                        Debug.Print("X11 window {0} destroyed.", e.DestroyWindowEvent.window);
                        return;

                    case XEventName.ConfigureNotify:
                        // If the window size changed, raise the C# Resize event.
                        if (e.ConfigureEvent.width != mode.Width ||
                            e.ConfigureEvent.height != mode.Height)
                        {
                            Debug.WriteLine(
                                String.Format(
                                    "New res: {0}x{1}",
                                    e.ConfigureEvent.width,
                                    e.ConfigureEvent.height
                                )
                            );

                            resizeEventArgs.Width = e.ConfigureEvent.width;
                            resizeEventArgs.Height = e.ConfigureEvent.height;
                            this.OnResize(resizeEventArgs);
                        }
                        break;

                    case XEventName.KeyPress:
                    case XEventName.KeyRelease:
                    case XEventName.MotionNotify:
                    case XEventName.ButtonPress:
                    case XEventName.ButtonRelease:
                        //Functions.XPutBackEvent(window.Display, ref e);
                        driver.ProcessEvent(ref e);
                        break;

                    default:
                        Debug.WriteLine(String.Format("{0} event was not handled", e.type));
                        break;
                }
            }
        }

        #endregion

        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get
            {
                return driver;
            }
        }

        #endregion 

        #region public bool Exists

        /// <summary>
        /// Returns true if a render window/context exists.
        /// </summary>
        public bool Exists
        {
            get { return exists; }
        }

        #endregion

        #region public bool Quit

        public bool IsExiting
        {
            get { return isExiting; }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get
            {
                return false;
                //throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                
                //throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion

        #region public IntPtr Handle

        /// <summary>
        /// Gets the current window handle.
        /// </summary>
        public IntPtr Handle
        {
            get { return this.window.Handle; }
        }

        #endregion

        #region public string Title

        /// <summary>
        /// TODO: Use atoms for this property.
        /// Gets or sets the GameWindow title.
        /// </summary>
        public string Title
        {
            get
            {
                IntPtr name = IntPtr.Zero;
                Functions.XFetchName(window.Display, window.Handle, ref name);
                if (name != IntPtr.Zero)
                    return Marshal.PtrToStringAnsi(name);

                return String.Empty;
            }
            set
            {
                /*
                XTextProperty name = new XTextProperty();
                name.format = 8; //STRING
                if (value == null)
                    name.value = String.Empty;
                else
                    name.value = value;

                Functions.XSetWMName(window.Display, window.Handle, ref name);
                */
                if (value != null)
                    Functions.XStoreName(window.Display, window.Handle, value);
            }
        }

        #endregion

        #region public bool Visible

        bool mapped;
        public bool Visible
        {
            get
            {
                //return true;
                return mapped;
            }
            set
            {
                if (value && !mapped)
                {
                    Functions.XMapWindow(window.Display, window.Handle);
                    mapped = true;
                }
                else if (!value && mapped)
                {
                    Functions.XUnmapWindow(window.Display, window.Handle);
                    mapped = false;
                }
            }
        }

        #endregion
/*
        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get
            {
                return driver;
            }
        }

        #endregion
*/
        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
        }

        #endregion

        #region public void CreateWindow(DisplayMode mode, GLContext glContext)

        /// <summary>
        /// Opens a new render window with the given DisplayMode.
        /// </summary>
        /// <param name="mode">The DisplayMode of the render window.</param>
        /// <remarks>
        /// Creates the window visual and colormap. Associates the colormap/visual
        /// with the window and raises the window on top of the window stack.
        /// <para>
        /// Colormap creation is currently disabled.
        /// </para>
        /// </remarks>
        public void CreateWindow(DisplayMode mode, GLContext glContext)
        {
            if (exists)
                throw new ApplicationException("Render window already exists!");

            Debug.Print("Creating GameWindow with mode: {0}", mode != null ? mode.ToString() : "default");
            Debug.Indent();

            //glContext = new X11GLContext(mode, window);
            //glContext.PrepareContext(window);
            window.VisualInfo = ((glContext as IGLContextInternal).Info as X11.WindowInfo).VisualInfo;
            //window.VisualInfo = Marshal.PtrToStructure(Glx.ChooseVisual(window.Display, window.Screen, 

            // Create a window on this display using the visual above
            Debug.Write("Opening render window... ");

            XSetWindowAttributes attributes = new XSetWindowAttributes();
            attributes.background_pixel = IntPtr.Zero;
            attributes.border_pixel = IntPtr.Zero;
            attributes.colormap =
                API.CreateColormap(window.Display, window.RootWindow, window.VisualInfo.visual, 0/*AllocNone*/);
            window.EventMask =
                EventMask.StructureNotifyMask | EventMask.SubstructureNotifyMask | EventMask.ExposureMask |
                EventMask.KeyReleaseMask | EventMask.KeyPressMask;/* |
                    EventMask.PointerMotionMask | /* Bad! EventMask.PointerMotionHintMask | 
                    EventMask.ButtonPressMask | EventMask.ButtonReleaseMask;*/
            attributes.event_mask = (IntPtr)window.EventMask;

            uint mask = (uint)SetWindowValuemask.ColorMap | (uint)SetWindowValuemask.EventMask |
                (uint)SetWindowValuemask.BackPixel | (uint)SetWindowValuemask.BorderPixel;

            window.Handle = Functions.XCreateWindow(window.Display, window.RootWindow,
                0, 0, mode.Width, mode.Height, 0, window.VisualInfo.depth/*(int)CreateWindowArgs.CopyFromParent*/,
                (int)CreateWindowArgs.InputOutput, window.VisualInfo.visual, (UIntPtr)mask, ref attributes);

            if (window.Handle == IntPtr.Zero)
                throw new ApplicationException("XCreateWindow call failed (returned 0).");

            // Set the window hints
            XSizeHints hints = new XSizeHints();
            hints.x = 0;
            hints.y = 0;
            hints.width = mode.Width;
            hints.height = mode.Height;
            hints.flags = (IntPtr)(XSizeHintsFlags.USSize | XSizeHintsFlags.USPosition);
            Functions.XSetWMNormalHints(window.Display, window.Handle, ref hints);

            // Register for window destroy notification
            IntPtr wm_destroy_atom = Functions.XInternAtom(window.Display,
                "WM_DELETE_WINDOW", true);
            XWMHints hint = new XWMHints();
            Functions.XSetWMProtocols(window.Display, window.Handle, new IntPtr[] { wm_destroy_atom }, 1);

            Top = Left = 0;
            Right = Width;
            Bottom = Height;

            //XTextProperty text = new XTextProperty();
            //text.value = "OpenTK Game Window";
            //text.format = 8;
            //Functions.XSetWMName(window.Display, window.Handle, ref text);
            //Functions.XSetWMProperties(display, window, name, name, 0,  /*None*/ null, 0, hints);

            Debug.Print("done! (id: {0})", window.Handle);

            //(glContext.Info as X11.WindowInfo).Handle = window.Handle;
            //glContext.CreateContext(true, null);
            //glContext.MakeCurrent();

            API.MapRaised(window.Display, window.Handle);
            mapped = true;

            driver = new X11Input(window);

            //GL.LoadAll();
            //Glu.LoadAll();

            Debug.Unindent();
            Debug.WriteLine("GameWindow creation completed successfully!");
            exists = true;
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        private void OnCreate(EventArgs e)
        {
            if (this.Create != null)
            {
                Debug.Print("Create event fired from window: {0}", window.ToString());
                this.Create(this, e);
            }
        }

        #endregion

        #region public void Exit()

        public void Exit()
        {
            this.DestroyWindow();
        }

        #endregion

        #region public void DestroyWindow()

        public void DestroyWindow()
        {
            Debug.WriteLine("X11GLNative shutdown sequence initiated.");
            Functions.XDestroyWindow(window.Display, window.Handle);
        }

        #endregion

        #region OnDestroy

        public event DestroyEvent Destroy;

        private void OnDestroy(EventArgs e)
        {
            Debug.Print("Destroy event fired from window: {0}", window.ToString());
            if (this.Destroy != null)
                this.Destroy(this, e);
        }

        #endregion

        #region PointToClient

        public void PointToClient(ref System.Drawing.Point p)
        {
            /*
            if (!Functions.ScreenToClient(this.Handle, p))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from client to screen coordinates. Windows error: {1}",
                    p.ToString(), Marshal.GetLastWin32Error()));
            */
        }

        #endregion

        #region PointToScreen

        public void PointToScreen(ref System.Drawing.Point p)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        public int Width
        {
            get
            {
                return mode.Width;
            }
            set
            {/*
                // Clear event struct
                //Array.Clear(xresize.pad, 0, xresize.pad.Length);
                // Set requested parameters
                xresize.ResizeRequest.type = EventType.ResizeRequest;
                xresize.ResizeRequest.display = this.display;
                xresize.ResizeRequest.width = value;
                xresize.ResizeRequest.height = mode.Width;
                API.SendEvent(
                    this.display,
                    this.window,
                    false,
                    EventMask.StructureNotifyMask,
                    ref xresize
                );*/
            }
        }

        #endregion

        #region public int Height

        public int Height
        {
            get
            {
                return mode.Height;
            }
            set
            {/*
                // Clear event struct
                //Array.Clear(xresize.pad, 0, xresize.pad.Length);
                // Set requested parameters
                xresize.ResizeRequest.type = EventType.ResizeRequest;
                xresize.ResizeRequest.display = this.display;
                xresize.ResizeRequest.width = mode.Width;
                xresize.ResizeRequest.height = value;
                API.SendEvent(
                    this.display,
                    this.window,
                    false,
                    EventMask.StructureNotifyMask,
                    ref xresize
                );*/
            }
        }

        #endregion

        #region public event ResizeEvent Resize

        public event ResizeEvent Resize;

        private void OnResize(ResizeEventArgs e)
        {
            mode.Width = e.Width;
            mode.Height = e.Height;
            if (this.Resize != null)
            {
                this.Resize(this, e);
            }
        }

        #endregion

        public int Top
        {
            get { return top; }
            private set { top = value; }
        }

        public int Bottom
        {
            get { return bottom; }
            private set { bottom = value; }
        }

        public int Left
        {
            get { return left; }
            private set { left = value; }
        }

        public int Right
        {
            get { return right; }
            private set { right = value; }
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                if (manuallyCalled)
                {
                    //if (glContext != null)
                    //    glContext.Dispose();

                    // Kills connection to the X-Server. We don't want that,
                    // 'cause it kills the ExampleLauncher too.
                    //Functions.XCloseDisplay(window.Display);
                }

                Functions.XUnmapWindow(window.Display, window.Handle);
                Functions.XDestroyWindow(window.Display, window.Handle);

                disposed = true;
            }
        }

        ~X11GLNative()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
