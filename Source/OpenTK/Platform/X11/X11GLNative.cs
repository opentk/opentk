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

        private X11GLContext glContext;
        private WindowInfo window = new WindowInfo();
        private DisplayMode mode = new DisplayMode();

        // Number of pending events.
        private int pending = 0;

        private int top, bottom, left, right;

        // C# ResizeEventArgs
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        // Low level X11 resize request
        // Event used for event loop.
        private XEvent e = new XEvent();

        private bool disposed;
        private bool exists;
        private bool isExiting;

        #endregion

        #region --- Public Constructors ---

        /// <summary>
        /// Constructs and initializes a new X11GLNative window.
        /// Call CreateWindow to create the actual render window.
        /// </summary>
        public X11GLNative()
        {
            Debug.Print("Native window driver: {0}", this.ToString());
            window = new WindowInfo();

            //Utilities.ThrowOnX11Error = true;
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
                {
                    //Debug.Print("No events pending on display {0}", window.Display);
                    return;
                }

                Functions.XNextEvent(window.Display, ref e);

                Debug.Print("Event: {0} ({1} pending)", e.type, pending);

                // Respond to the event e
                switch (e.type)
                {
                    case XEventName.ReparentNotify:
                        // TODO: Is there a more suitable place to raise the Create event?
                        // ReparentNotify seems to be the first event raised on window creation.
                        this.OnCreate(EventArgs.Empty);
                        break;


                    case XEventName.MapNotify:
                        Debug.WriteLine("Window mapped.");
                        return;

                    case XEventName.CreateNotify:
                        // A child was was created - nothing to do
                        break;

                    case XEventName.DestroyNotify:
                        this.exists = false;
                        this.OnDestroy(EventArgs.Empty);
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
                        return;

                    default:
                        Debug.WriteLine(String.Format("{0} event was not handled", e.type));
                        break;
                }
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

        #region public IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glContext; }
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

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
        }

        #endregion

        #region public void CreateWindow(DisplayMode mode)

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
        public void CreateWindow(DisplayMode mode)
        {
            if (exists)
            {
                throw new ApplicationException("Render window already exists!");
            }
            else
            {
                Debug.Print("Creating GameWindow with mode: {0}", mode.ToString());
                Debug.Indent();

                window.Display = API.OpenDisplay(null); // null == default display
                if (window.Display == IntPtr.Zero)
                {
                    throw new Exception("Could not open connection to X");
                }
                window.Screen = API.DefaultScreen(window.Display);
                window.RootWindow = API.RootWindow(window.Display, window.Screen);

                Debug.Print("Display: {0}, Screen {1}, Root window: {2}",
                    window.Display, window.Screen, window.RootWindow);

                glContext = new X11GLContext(mode);
                glContext.PrepareContext(window);
                window.VisualInfo = glContext.windowInfo.VisualInfo;

                // Create a window on this display using the visual above
                Debug.Write("Opening render window... ");
                
                XSetWindowAttributes attributes = new XSetWindowAttributes();
                attributes.background_pixel = IntPtr.Zero;
                attributes.border_pixel = IntPtr.Zero;
                attributes.colormap =
                    API.CreateColormap(window.Display, window.RootWindow, window.VisualInfo.visual, 0/*AllocNone*/);
                attributes.event_mask =
                    (IntPtr)(EventMask.StructureNotifyMask | EventMask.SubstructureNotifyMask | EventMask.ExposureMask);

                uint mask = (uint)SetWindowValuemask.ColorMap | (uint)SetWindowValuemask.EventMask |
                    (uint)SetWindowValuemask.BackPixel | (uint)SetWindowValuemask.BorderPixel;

                window.Handle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    0, 0, mode.Width, mode.Height, 0, window.VisualInfo.depth/*(int)CreateWindowArgs.CopyFromParent*/,
                    (int)CreateWindowArgs.InputOutput, window.VisualInfo.visual, (UIntPtr)mask, ref attributes);

                if (window.Handle == IntPtr.Zero)
                {
                    throw new ApplicationException("XCreateWindow call failed (returned 0).");
                }
                
                // Set the window hints
                XSizeHints hints = new XSizeHints();
                hints.x = 0;
                hints.y = 0;
                hints.width = mode.Width;
                hints.height = mode.Height;
                hints.flags = (IntPtr)(XSizeHintsFlags.USSize | XSizeHintsFlags.USPosition);
                Functions.XSetWMNormalHints(window.Display, window.Handle, ref hints);

                Top = Left = 0;
                Right = Width;
                Bottom = Height;

                //XTextProperty text = new XTextProperty();
                //text.value = "OpenTK Game Window";
                //text.format = 8;
                //Functions.XSetWMName(window.Display, window.Handle, ref text);
                //Functions.XSetWMProperties(display, window, name, name, 0,  /*None*/ null, 0, hints);

                Debug.Print("done! (id: {0})", window.Handle);

                glContext.windowInfo.Handle = window.Handle;
                glContext.CreateContext(null, true);

                glContext.MakeCurrent();

                API.MapRaised(window.Display, window.Handle);

                OpenTK.OpenGL.GL.LoadAll();

                Debug.Unindent();
                Debug.WriteLine("GameWindow creation completed successfully!");
                exists = true;
            }
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
//            Functions.XUnmapWindow(window.Display, window.Handle);
            Functions.XDestroyWindow(window.Display, window.Handle);
        }

        #endregion

        #region OnDestroy

        public event DestroyEvent Destroy;

        private void OnDestroy(EventArgs e)
        {
            Debug.Print("Destroy event fired from window: {0}", window.ToString());
            if (this.Destroy != null)
            {
                this.Destroy(this, e);
            }
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
                if (Exists)
                    Functions.XDestroyWindow(window.Display, window.Handle);
                // Kills connection to the X-Server. We don't want that,
                // 'cause it kills the ExampleLauncher too.
                //API.CloseDisplay(display);

                if (manuallyCalled)
                {
                    if (glContext != null)
                        glContext.Dispose();
                }
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
