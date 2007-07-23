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

//using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    sealed class X11GLNative : OpenTK.Platform.INativeWindow, IDisposable
    {
        #region --- Private Fields ---

        private X11GLContext glContext;
        private X11WindowInfo windowInfo = new X11WindowInfo();
        private IntPtr display;
        private int screen;
        private IntPtr rootWindow;
        private IntPtr window;

        private DisplayMode mode = new DisplayMode();

        // Number of pending events.
        private int pending = 0;
        // C# ResizeEventArgs
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        // Low level X11 resize request
        private X11.Event xresize = new Event();
        // This is never written in the code. If at some point it gets != 0,
        // then memory corruption is taking place from the xresize struct.
        // Event used for event loop.
        private Event e = new Event();
        private ConfigureNotifyEvent configure = new ConfigureNotifyEvent();
        private ReparentNotifyEvent reparent = new ReparentNotifyEvent();
        private ExposeEvent expose = new ExposeEvent();
        private CreateWindowEvent createWindow = new CreateWindowEvent();
        private DestroyWindowEvent destroyWindow = new DestroyWindowEvent();
        // This is never written in the code. If at some point it gets != 0,
        // then memory corruption is taking place from the xresize struct.
        int memGuard = 0;

        //private int width, height;

        private bool disposed;

        #endregion

        #region --- Public Constructors ---

        /// <summary>
        /// Constructs a new X11GLNative window, with its associated context.
        /// Safe defaults for visual, colormap, etc.
        /// </summary>
        public X11GLNative()
        {
            Trace.WriteLine("Creating GameWindow (X11GLNative driver)");
            Trace.Indent();

            // Set default (safe) DisplayMode.
            mode.Width = 640;
            mode.Height = 480;
            mode.Color = new ColorDepth(24);
            mode.DepthBits = 16;
            mode.Buffers = 2;

            Trace.WriteLine(String.Format("Display mode: {0}", mode));
        
            windowInfo.Display = display = API.OpenDisplay(null); // null == default display
            if (display == IntPtr.Zero)
            {
                throw new Exception("Could not open connection to X");
            }
            windowInfo.Screen = screen = API.DefaultScreen(display);
            windowInfo.RootWindow = rootWindow = API.RootWindow(display, screen);

            Trace.WriteLine(
                String.Format(
                    "Display: {0}, Screen {1}, Root window: {2}",
                    windowInfo.Display,
                    windowInfo.Screen,
                    windowInfo.RootWindow
                )
            );

            glContext = new X11GLContext(windowInfo, mode);
            glContext.CreateVisual();

            // Create a window on this display using the visual above
            Trace.Write("Creating output window... ");

            SetWindowAttributes wnd_attributes = new SetWindowAttributes();
            wnd_attributes.background_pixel = 0;
            wnd_attributes.border_pixel = 0;
            wnd_attributes.colormap = glContext.XColormap;
                //API.CreateColormap(display, rootWindow, glxVisualInfo.visual, 0/*AllocNone*/);
            wnd_attributes.event_mask =
                EventMask.StructureNotifyMask |
                EventMask.ExposureMask |
                EventMask.KeyPressMask;

            CreateWindowMask cw_mask =
                CreateWindowMask.CWBackPixel |
                CreateWindowMask.CWBorderPixel |
                CreateWindowMask.CWColormap |
                CreateWindowMask.CWEventMask;

            window = API.CreateWindow(
                windowInfo.Display,
                windowInfo.RootWindow,
                0, 0,
                640, 480,
                0,
                //glxVisualInfo.depth,
                glContext.XVisualInfo.depth,
                Constants.InputOutput,
                //glxVisualInfo.visual,
                glContext.XVisualInfo.visual,
                cw_mask,
                wnd_attributes
            );

            if (window == IntPtr.Zero)
            {
                throw new Exception("Could not create window.");
            }

            Trace.WriteLine("done! (id: " + window + ")");
            
            // Set the window hints
            /*
            SizeHints hints = new SizeHints();
            hints.x = 0;
            hints.y = 0;
            hints.width = 640;
            hints.height = 480;
            hints.flags = USSize | USPosition;
            X11Api.SetNormalHints(display, window, hints);
            X11Api.SetStandardProperties(
                display,
                window,
                name,
                name,
                0,  // None
                null,
                0,
                hints
            );
            */

            //glContext.ContainingWindow = windowInfo.Window;
            glContext.windowInfo.Window = window;
            glContext.CreateContext(null, true);

            API.MapRaised(display, window);

            Trace.WriteLine("Mapped window.");

            //glContext.MakeCurrent();

            Trace.WriteLine("Our shiny new context is now current - ready to rock 'n' roll!");
            Trace.Unindent();
        }

        #endregion

        #region --- IGLWindow Members ---

        #region public void ProcessEvents()

        public void ProcessEvents()
        {
            // Process all pending events
            while (true)
            {
                pending = API.Pending(display);

                if (pending == 0)
                    return;
                
                //API.NextEvent(display, e);
                API.PeekEvent(display, e);
                //API.NextEvent(display, eventPtr);
                                
                              
                 Debug.WriteLine(String.Format("Event: {0} ({1} pending)", e.Type, pending));
                //Debug.WriteLine(String.Format("Event: {0} ({1} pending)", eventPtr, pending));

                // Check whether memory was corrupted by the NextEvent call.
                Debug.Assert(memGuard == 0, "memGuard2 tripped", String.Format("Guard: {0}", memGuard));
                memGuard = 0;

                // Respond to the event e
                switch (e.Type)
                {
                    case EventType.ReparentNotify:
                        API.NextEvent(display, reparent);
                        // Do nothing
                        break;

                    case EventType.CreateNotify:
                        API.NextEvent(display, createWindow);
                        
                        // Set window width/height
                        mode.Width = createWindow.width;
                        mode.Height = createWindow.height;
                        this.OnCreate(EventArgs.Empty);
                        Debug.WriteLine(
                            String.Format("OnCreate fired: {0}x{1}", mode.Width, mode.Height)
                        );
                        break;

                    case EventType.DestroyNotify:
                        API.NextEvent(display, destroyWindow);
                        quit = true;
                        Debug.WriteLine("Window destroyed, shutting down.");
                        break;
                        
                     
                    case EventType.ConfigureNotify:
                        API.NextEvent(display, configure);
                        
                        // If the window size changed, raise the C# Resize event.
                        if (configure.width != mode.Width ||
                            configure.height != mode.Height)
                        {
                            Debug.WriteLine(
                                String.Format(
                                    "New res: {0}x{1}",
                                    configure.width,
                                    configure.height
                                )
                            );

                            resizeEventArgs.Width = configure.width;
                            resizeEventArgs.Height = configure.height;
                            this.OnResize(resizeEventArgs);
                        }
                        break;

                    default:
                        API.NextEvent(display, e);
                        Debug.WriteLine(String.Format("{0} event was not handled", e.Type));
                        break;
                }
            }
        }

        #endregion

        #region public event CreateEvent Create;

        public event CreateEvent Create;

        private void OnCreate(EventArgs e)
        {
            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region public bool Quit

        private bool quit;
        public bool Quit
        {
            get { return quit; }
            set
            {
                if (value)
                {
                    /*Event e = new Event();
                    X11Api.SendEvent(
                        display,
                        window,
                        false,
                        0,*/
                    //quit = true;
                }
            }
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
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion

        #region public IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glContext; }
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
                API.DestroyWindow(display, window);
                API.CloseDisplay(display);

                if (manuallyCalled)
                {
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
