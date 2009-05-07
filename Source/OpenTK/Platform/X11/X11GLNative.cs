#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform.Windows;
using OpenTK.Graphics;
using System.Drawing;

//using OpenTK.Graphics.OpenGL;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives GameWindow on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLNative : INativeGLWindow, IDisposable
    {
        // TODO: Disable screensaver.
        // TODO: What happens if we can't disable decorations through motif?
        // TODO: Mouse/keyboard grabbing/wrapping.
        // TODO: PointToWindow, PointToScreen

        #region --- Fields ---
        
        const int _min_width = 30, _min_height = 30;

        X11WindowInfo window = new X11WindowInfo();
        X11Input driver;

        // Window manager hints for fullscreen windows.
        // Not used right now (the code is written, but is not 64bit-correct), but could be useful for older WMs which
        // are not ICCM compliant, but may support MOTIF hints.
        const string MOTIF_WM_ATOM = "_MOTIF_WM_HINTS";
        const string KDE_WM_ATOM = "KWM_WIN_DECORATION";
        const string KDE_NET_WM_ATOM = "_KDE_NET_WM_WINDOW_TYPE";
        const string ICCM_WM_ATOM = "_NET_WM_WINDOW_TYPE";

        // The Atom class from Mono might be useful to avoid calling XInternAtom by hand (somewhat error prone). 
        IntPtr _atom_wm_destroy;        
        
        IntPtr _atom_net_wm_state;
        IntPtr _atom_net_wm_state_minimized;
        IntPtr _atom_net_wm_state_fullscreen;
        IntPtr _atom_net_wm_state_maximized_horizontal;
        IntPtr _atom_net_wm_state_maximized_vertical;
        
        IntPtr _atom_net_wm_allowed_actions;
        IntPtr _atom_net_wm_action_resize;
        IntPtr _atom_net_wm_action_maximize_horizontally;
        IntPtr _atom_net_wm_action_maximize_vertically;
        
        //IntPtr _atom_motif_wm_hints;
        //IntPtr _atom_kde_wm_hints;
        //IntPtr _atom_kde_net_wm_hints;
        
        static readonly IntPtr _atom_remove = (IntPtr)0;
        static readonly IntPtr _atom_add = (IntPtr)1;
        static readonly IntPtr _atom_toggle = (IntPtr)2;
        
        // Number of pending events.
        //int pending = 0;

        int width, height;
        int top, bottom, left, right;

        // C# ResizeEventArgs
        ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        // Used for event loop.
        XEvent e = new XEvent();

        bool disposed;
        bool exists;
        bool isExiting;

        // XAtoms for window properties
        //static IntPtr WMTitle;      // The title of the GameWindow.
        //static IntPtr UTF8String;   // No idea.

        // Fields used for fullscreen mode changes.
        //int pre_fullscreen_width, pre_fullscreen_height;
        //bool fullscreen = false;

        bool _decorations_hidden = false;        
        
        //OpenTK.WindowState _window_state, _previous_window_state;
        //OpenTK.WindowBorder _window_border, _previous_window_border;

        #endregion

        #region --- Constructors ---

        /// <summary>
        /// Constructs and initializes a new X11GLNative window.
        /// Call CreateWindow to create the actual render window.
        /// </summary>
        public X11GLNative()
        {
            try
            {
                Debug.Print("Creating X11GLNative window.");
                Debug.Indent();

                //Utilities.ThrowOnX11Error = true; // Not very reliable

                // We *cannot* reuse the display connection of System.Windows.Forms (Windows.Forms eat our events).
                // TODO: Multiple screens.
                //Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
                //window.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                //    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                //window.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                //    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                //window.Screen = (int)xplatui.GetField("ScreenNo",
                //    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                // Open a display connection to the X server, and obtain the screen and root window.
                window.Display = API.DefaultDisplay;
                if (window.Display == IntPtr.Zero)
                    throw new Exception("Could not open connection to X");

                try
                {
                    Functions.XLockDisplay(window.Display);
                    window.Screen = Functions.XDefaultScreen(window.Display); //API.DefaultScreen;
                    window.RootWindow = Functions.XRootWindow(window.Display, window.Screen); // API.RootWindow;
                }
                finally
                {
                    Functions.XUnlockDisplay(window.Display);
                }
                
                Debug.Print("Display: {0}, Screen {1}, Root window: {2}", window.Display, window.Screen,
                            window.RootWindow);
                
                RegisterAtoms(window);
            }
            finally
            {
                Debug.Unindent();
            }
        }

        #endregion

        #region private void RegisterAtoms()

        /// <summary>
        /// Not used yet.
        /// Registers the necessary atoms for GameWindow.
        /// </summary>
        private void RegisterAtoms(X11WindowInfo window)
        {
            Debug.WriteLine("Registering atoms.");   
            _atom_wm_destroy = Functions.XInternAtom(window.Display, "WM_DELETE_WINDOW", true);
            
            _atom_net_wm_state = Functions.XInternAtom(window.Display, "_NET_WM_STATE", false);
            _atom_net_wm_state_minimized = Functions.XInternAtom(window.Display, "_NET_WM_STATE_MINIMIZED", false);
            _atom_net_wm_state_fullscreen = Functions.XInternAtom(window.Display, "_NET_WM_STATE_FULLSCREEN", false);
            _atom_net_wm_state_maximized_horizontal =
                Functions.XInternAtom(window.Display, "_NET_WM_STATE_MAXIMIZED_HORZ", false);
            _atom_net_wm_state_maximized_vertical =
                Functions.XInternAtom(window.Display, "_NET_WM_STATE_MAXIMIZED_VERT", false);
            
            _atom_net_wm_allowed_actions =
                Functions.XInternAtom(window.Display, "_NET_WM_ALLOWED_ACTIONS", false);
            _atom_net_wm_action_resize =
                Functions.XInternAtom(window.Display, "_NET_WM_ACTION_RESIZE", false);
            _atom_net_wm_action_maximize_horizontally =
                Functions.XInternAtom(window.Display, "_NET_WM_ACTION_MAXIMIZE_HORZ", false);
            _atom_net_wm_action_maximize_vertically =
                Functions.XInternAtom(window.Display, "_NET_WM_ACTION_MAXIMIZE_VERT", false);
            
//            string[] atom_names = new string[]
//            {
//                //"WM_TITLE",
//                //"UTF8_STRING"
//            };
//            IntPtr[] atoms = new IntPtr[atom_names.Length];
//            //Functions.XInternAtoms(window.Display, atom_names, atom_names.Length, false, atoms);
//
//            int offset = 0;
//            //WMTitle = atoms[offset++];
//            //UTF8String = atoms[offset++];
        }

        #endregion

        #region --- INativeGLWindow Members ---

        #region CreateWindow

        public void CreateWindow(int width, int height, GraphicsMode mode, int major, int minor, GraphicsContextFlags flags, out IGraphicsContext context)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "Must be higher than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException("height", "Must be higher than zero.");
            if (exists) throw new InvalidOperationException("A render window already exists.");

            XVisualInfo info = new XVisualInfo();

            Debug.Indent();
            
            lock (API.Lock)
            {
                info.visualid = mode.Index;
                int dummy;
                window.VisualInfo = (XVisualInfo)Marshal.PtrToStructure(
                    Functions.XGetVisualInfo(window.Display, XVisualInfoMask.ID, ref info, out dummy), typeof(XVisualInfo));

                // Create a window on this display using the visual above
                Debug.Write("Opening render window... ");

                XSetWindowAttributes attributes = new XSetWindowAttributes();
                attributes.background_pixel = IntPtr.Zero;
                attributes.border_pixel = IntPtr.Zero;
                attributes.colormap = Functions.XCreateColormap(window.Display, window.RootWindow, window.VisualInfo.visual, 0/*AllocNone*/);
                window.EventMask = EventMask.StructureNotifyMask | EventMask.SubstructureNotifyMask | EventMask.ExposureMask |
                                   EventMask.KeyReleaseMask | EventMask.KeyPressMask |
                                   EventMask.PointerMotionMask | // Bad! EventMask.PointerMotionHintMask |
                                   EventMask.ButtonPressMask | EventMask.ButtonReleaseMask;
                attributes.event_mask = (IntPtr)window.EventMask;

                uint mask = (uint)SetWindowValuemask.ColorMap | (uint)SetWindowValuemask.EventMask |
                    (uint)SetWindowValuemask.BackPixel | (uint)SetWindowValuemask.BorderPixel;

                window.WindowHandle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    0, 0, width, height, 0, window.VisualInfo.depth/*(int)CreateWindowArgs.CopyFromParent*/,
                    (int)CreateWindowArgs.InputOutput, window.VisualInfo.visual, (UIntPtr)mask, ref attributes);

                if (window.WindowHandle == IntPtr.Zero)
                    throw new ApplicationException("XCreateWindow call failed (returned 0).");

                //XVisualInfo vis = window.VisualInfo;
                //Glx.CreateContext(window.Display, ref vis, IntPtr.Zero, true);
            }
            context = new GraphicsContext(mode, window, major, minor, flags);

            // Set the window hints
            SetWindowMinMax(_min_width, _min_height, -1, -1);            
            
            XSizeHints hints = new XSizeHints();
            hints.x = 0;
            hints.y = 0;
            hints.width = width;
            hints.height = height;
            hints.flags = (IntPtr)(XSizeHintsFlags.USSize);// | XSizeHintsFlags.USPosition);
            lock (API.Lock)
            {
                Functions.XSetWMNormalHints(window.Display, window.WindowHandle, ref hints);

                // Register for window destroy notification
                Functions.XSetWMProtocols(window.Display, window.WindowHandle, new IntPtr[] { _atom_wm_destroy }, 1);
            }
            Top = Left = 0;
            Right = Width;
            Bottom = Height;

            //XTextProperty text = new XTextProperty();
            //text.value = "OpenTK Game Window";
            //text.format = 8;
            //Functions.XSetWMName(window.Display, window.Handle, ref text);
            //Functions.XSetWMProperties(display, window, name, name, 0,  /*None*/ null, 0, hints);

            lock (API.Lock)
            {
                API.MapRaised(window.Display, window.WindowHandle);
            }
            mapped = true;

            driver = new X11Input(window);
            
            Debug.WriteLine(String.Format("X11GLNative window created successfully (id: {0}).", Handle));
            Debug.Unindent();

            this.width = width;
            this.height = height;
            
            exists = true;
        }

        #endregion

        #region public void ProcessEvents()

        public void ProcessEvents()
        {
            // Process all pending events
            //while (true)
            while (Functions.XCheckWindowEvent(window.Display, window.WindowHandle, window.EventMask, ref e) ||
                   Functions.XCheckTypedWindowEvent(window.Display, window.WindowHandle, XEventName.ClientMessage, ref e))
            {
                //pending = Functions.XPending(window.Display);
                //pending = API.Pending(window.Display);

                //if (pending == 0)
                //    return;

                //Functions.XNextEvent(window.Display, ref e);

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
                        if (e.ClientMessageEvent.ptr1 == _atom_wm_destroy)
                            this.OnDestroy(EventArgs.Empty);
                        else
                            Debug.Print("Niar");
                        
                        
                        break;

                    case XEventName.DestroyNotify:
                        exists = false;
                        isExiting = true;
                        Debug.Print("X11 window {0} destroyed.", e.DestroyWindowEvent.window);
                        window.WindowHandle = IntPtr.Zero;
                        return;

                    case XEventName.ConfigureNotify:
                        // If the window size changed, raise the C# Resize event.
                        if (e.ConfigureEvent.width != width || e.ConfigureEvent.height != height)
                        {
                            Debug.WriteLine(String.Format("ConfigureNotify: {0}x{1}", e.ConfigureEvent.width, e.ConfigureEvent.height));

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
                //return fullscreen;
            }
            set
            {
//                if (value && !fullscreen)
//                {
//                    Debug.Print("Going fullscreen");
//                    Debug.Indent();
//                    DisableWindowDecorations(); 
//                    pre_fullscreen_height = this.Height;
//                    pre_fullscreen_width = this.Width;
//                    //Functions.XRaiseWindow(this.window.Display, this.Handle);
//                    Functions.XMoveResizeWindow(this.window.Display, this.Handle, 0, 0, 
//                        DisplayDevice.Default.Width, DisplayDevice.Default.Height);
//                    Debug.Unindent();
//                    fullscreen = true;
//                }
//                else if (!value && fullscreen)
//                {
//                    Debug.Print("Going windowed");
//                    Debug.Indent();
//                    Functions.XMoveResizeWindow(this.window.Display, this.Handle, 0, 0,
//                        pre_fullscreen_width, pre_fullscreen_height);
//                    pre_fullscreen_height = pre_fullscreen_width = 0;
//                    EnableWindowDecorations();
//                    Debug.Unindent();
//                    fullscreen = false;
//                }
                /*
                Debug.Print(value ? "Going fullscreen" : "Going windowed");
                IntPtr state_atom = Functions.XInternAtom(this.window.Display, "_NET_WM_STATE", false);
                IntPtr fullscreen_atom = Functions.XInternAtom(this.window.Display, "_NET_WM_STATE_FULLSCREEN", false);
                XEvent xev = new XEvent();
                xev.ClientMessageEvent.type = XEventName.ClientMessage;
                xev.ClientMessageEvent.serial = IntPtr.Zero;
                xev.ClientMessageEvent.send_event = true;
                xev.ClientMessageEvent.window = this.Handle;
                xev.ClientMessageEvent.message_type = state_atom;
                xev.ClientMessageEvent.format = 32;
                xev.ClientMessageEvent.ptr1 = (IntPtr)(value ? NetWindowManagerState.Add : NetWindowManagerState.Remove);
                xev.ClientMessageEvent.ptr2 = (IntPtr)(value ? 1 : 0);
                xev.ClientMessageEvent.ptr3 = IntPtr.Zero;
                Functions.XSendEvent(this.window.Display, API.RootWindow, false,
                    (IntPtr)(EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask), ref xev);

                fullscreen = !fullscreen;
                */
            }
        }

        #endregion

        #region public IntPtr Handle

        /// <summary>
        /// Gets the current window handle.
        /// </summary>
        public IntPtr Handle
        {
            get { return this.window.WindowHandle; }
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
                Functions.XFetchName(window.Display, window.WindowHandle, ref name);
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
                    Functions.XStoreName(window.Display, window.WindowHandle, value);
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
                    Functions.XMapWindow(window.Display, window.WindowHandle);
                    mapped = true;
                }
                else if (!value && mapped)
                {
                    Functions.XUnmapWindow(window.Display, window.WindowHandle);
                    mapped = false;
                }
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
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
            Functions.XDestroyWindow(window.Display, window.WindowHandle);
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

        public Point PointToClient(Point point)
        {
            int ox, oy;
            IntPtr child;

            Functions.XTranslateCoordinates(window.Display, window.RootWindow, window.WindowHandle, point.X, point.Y, out ox, out oy, out child);

            point.X = ox;
            point.Y = oy;

            return point;
        }

        #endregion

        #region PointToScreen

        public Point PointToScreen(Point p)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region publicOpenTK.WindowState WindowState

        public OpenTK.WindowState WindowState
        {
            get
            {
    			IntPtr actual_atom;
    			int actual_format;
    			IntPtr nitems;
    			IntPtr bytes_after;
    			IntPtr prop = IntPtr.Zero;
    			IntPtr atom;
    			//XWindowAttributes attributes;
                bool fullscreen = false;
    			int maximized = 0;
                bool minimized = false;
                
    			Functions.XGetWindowProperty(window.Display, window.WindowHandle,
    						 _atom_net_wm_state, IntPtr.Zero, new IntPtr (256), false,
    						 IntPtr.Zero, out actual_atom, out actual_format, out nitems, out bytes_after, ref prop);

    			if ((long)nitems > 0 && prop != IntPtr.Zero)
                {
    				for (int i = 0; i < (long)nitems; i++)
                    {
                        atom = (IntPtr)Marshal.ReadIntPtr(prop, i * IntPtr.Size);
    					
                        if (atom == _atom_net_wm_state_maximized_horizontal ||
                            atom == _atom_net_wm_state_maximized_vertical)
    						maximized++;
    					else if (atom == _atom_net_wm_state_minimized)
    						minimized = true;
                        else if (atom == _atom_net_wm_state_fullscreen)
                            fullscreen = true;
    				}
    				Functions.XFree(prop);
    			}

    			if (minimized)
    				return OpenTK.WindowState.Minimized;
    			else if (maximized == 2)
    				return OpenTK.WindowState.Maximized;
                else if (fullscreen)
                    return OpenTK.WindowState.Fullscreen;
/*
    			attributes = new XWindowAttributes();
    			Functions.XGetWindowAttributes(window.Display, window.WindowHandle, ref attributes);
    			if (attributes.map_state == MapState.IsUnmapped)
    				return (OpenTK.WindowState)(-1);
*/
    			return OpenTK.WindowState.Normal; 
            }
            set
            {
                OpenTK.WindowState current_state = this.WindowState;
                
                if (current_state == value)
                    return;
                
                Debug.Print("GameWindow {0} changing WindowState from {1} to {2}.", window.WindowHandle.ToString(),
                            current_state.ToString(), value.ToString());
                
                if (current_state == OpenTK.WindowState.Minimized)
                    Functions.XMapWindow(window.Display, window.WindowHandle);
                else if (current_state == OpenTK.WindowState.Fullscreen)
                    Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_remove,
							                  _atom_net_wm_state_fullscreen,
                                               IntPtr.Zero);
                else if (current_state == OpenTK.WindowState.Maximized)
                    Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_toggle,
							                  _atom_net_wm_state_maximized_horizontal,
                                              _atom_net_wm_state_maximized_vertical);
                
                Functions.XSync(window.Display, false);                
                
                // We can't resize the window if its border is fixed, so make it resizable first.
                bool temporary_resizable = false;
                WindowBorder previous_state = WindowBorder;
                if (WindowBorder != WindowBorder.Resizable)
                {
                    temporary_resizable = true;
                    WindowBorder = WindowBorder.Resizable;
                }

                switch (value)
                {
                    case OpenTK.WindowState.Normal:
                        Functions.XRaiseWindow(window.Display, window.WindowHandle);
                        
                        break;
                        
                    case OpenTK.WindowState.Maximized:
                        Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_add,
								                  _atom_net_wm_state_maximized_horizontal,
                                                  _atom_net_wm_state_maximized_vertical);
                        Functions.XRaiseWindow(window.Display, window.WindowHandle);

                        break;

                    case OpenTK.WindowState.Minimized:
        				// FIXME multiscreen support
        				Functions.XIconifyWindow(window.Display, window.WindowHandle, window.Screen);
                        
        				break;

                    case OpenTK.WindowState.Fullscreen:
                        //_previous_window_border = this.WindowBorder;
                        //this.WindowBorder = WindowBorder.Hidden;
     					Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_add,
		                                          _atom_net_wm_state_fullscreen, IntPtr.Zero);
                        Functions.XRaiseWindow(window.Display, window.WindowHandle);
                        
                        break;
                }
                
                if (temporary_resizable)
                    WindowBorder = previous_state;
            }
        }

        #endregion

        #region public OpenTK.WindowBorder WindowBorder

        public OpenTK.WindowBorder WindowBorder
        {
            get
            {
                if (IsWindowBorderHidden)
                    return WindowBorder.Hidden;
                
                if (IsWindowBorderResizable)
                    return WindowBorder.Resizable;
                else
                    return WindowBorder.Fixed;
            }
            set
            {
                if (WindowBorder == value)
                    return;
                
                if (WindowBorder == WindowBorder.Hidden)
                    EnableWindowDecorations();
                
                switch (value)
                {
                    case WindowBorder.Fixed:
                        Debug.Print("Making WindowBorder fixed.");
                    	SetWindowMinMax((short)Width, (short)Height, (short)Width, (short)Height);

                        break;
                        
                    case WindowBorder.Resizable:
                        Debug.Print("Making WindowBorder resizable.");
                        SetWindowMinMax(_min_width, _min_height, -1, -1);
                        
                        break;
                        
                    case WindowBorder.Hidden:
                        Debug.Print("Making WindowBorder hidden.");
                        DisableWindowDecorations();

                        break;
                }
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
                return width;
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
                return height;
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
            width = e.Width;
            height = e.Height;
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
                if (window != null && window.WindowHandle != IntPtr.Zero)
                {
                    try
                    {
                        Functions.XLockDisplay(window.Display);
                        Functions.XDestroyWindow(window.Display, window.WindowHandle);
                    }
                    finally
                    {
                        Functions.XUnlockDisplay(window.Display);
                    }

                    window = null;
                }

                if (manuallyCalled)
                {
                }
                disposed = true;
            }
        }

        ~X11GLNative()
        {
            this.Dispose(false);
        }

        #endregion

        #region --- Private Methods ---

        void SetWindowMinMax(short min_width, short min_height, short max_width, short max_height)
        {
            IntPtr dummy;
            XSizeHints hints = new XSizeHints();

            Functions.XGetWMNormalHints(window.Display, window.WindowHandle, ref hints, out dummy);

            if (min_width > 0 || min_height > 0)
            {
                hints.flags = (IntPtr)((int)hints.flags | (int)XSizeHintsFlags.PMinSize);
                hints.min_width = min_width;
                hints.min_height = min_height;
            }
            else
                hints.flags = (IntPtr)((int)hints.flags & ~(int)XSizeHintsFlags.PMinSize);

            if (max_width > 0 || max_height > 0)
            {
                hints.flags = (IntPtr)((int)hints.flags | (int)XSizeHintsFlags.PMaxSize);
                hints.max_width = max_width;
                hints.max_height = max_height;
            }
            else
                hints.flags = (IntPtr)((int)hints.flags & ~(int)XSizeHintsFlags.PMaxSize);


            if (hints.flags != IntPtr.Zero)
            {
                // The Metacity team has decided that they won't care about this when clicking the maximize
                // icon, will maximize the window to fill the screen/parent no matter what.
                // http://bugzilla.ximian.com/show_bug.cgi?id=80021
                Functions.XSetWMNormalHints(window.Display, window.WindowHandle, ref hints);
            }
        }

        bool IsWindowBorderResizable
        {
            get
            {
    			IntPtr actual_atom;
    			int actual_format;
    			IntPtr nitems;
    			IntPtr bytes_after;
    			IntPtr prop = IntPtr.Zero;
    			IntPtr atom;
    			//XWindowAttributes attributes;                
                
    			Functions.XGetWindowProperty(window.Display, window.WindowHandle,
                    						 _atom_net_wm_allowed_actions, IntPtr.Zero, new IntPtr(256), false,
                    						 IntPtr.Zero, out actual_atom, out actual_format, out nitems,
                                             out bytes_after, ref prop);
    			if ((long)nitems > 0 && prop != IntPtr.Zero)
                {
    				for (int i = 0; i < (long)nitems; i++)
                    {
                        atom = (IntPtr)Marshal.ReadIntPtr(prop, i * IntPtr.Size);
                        
                        if (atom == _atom_net_wm_action_resize)
                            return true;
    				}
    				Functions.XFree(prop);
    			}
                    
                return false;
            }
        }
                
        #region bool IsWindowBorderHidden
                
        bool IsWindowBorderHidden
        {
            get
            {                
                //IntPtr actual_atom;
                //int actual_format;
                //IntPtr nitems;
                //IntPtr bytes_after;
    			IntPtr prop = IntPtr.Zero;
                //IntPtr atom;
                //XWindowAttributes attributes;

                // Test if decorations have been disabled through Motif.
                IntPtr motif_hints_atom = Functions.XInternAtom(this.window.Display, MOTIF_WM_ATOM, true);
                if (motif_hints_atom != IntPtr.Zero)
                {
                    // TODO: How to check if MotifWMHints decorations have been really disabled?
                    if (_decorations_hidden)
                        return true;
                }

                // Some WMs remove decorations when the transient_for hint is set. Most new ones do not (but those
                // should obey the Motif hint). Anyway, if this hint is set, we say the decorations have been remove
                // although there is a slight chance this is not the case.
                IntPtr transient_for_parent;                
                Functions.XGetTransientForHint(window.Display, window.WindowHandle, out transient_for_parent);
                if (transient_for_parent != IntPtr.Zero)
                    return true;
                
                return false;
            }
        }
                
        #endregion

        #region void DisableWindowDecorations()

        void DisableWindowDecorations()
        {
            if (DisableMotifDecorations())
            {
                Debug.Print("Removed decorations through motif.");
                _decorations_hidden = true;
            }

            // Functions.XSetTransientForHint(this.window.Display, this.Handle, this.window.RootWindow);
            
            // Some WMs remove decorations when this hint is set. Doesn't hurt to try.
            Functions.XSetTransientForHint(this.window.Display, this.Handle, this.window.RootWindow);

            if (_decorations_hidden)
            {
                Functions.XUnmapWindow(this.window.Display, this.Handle);
                Functions.XMapWindow(this.window.Display, this.Handle);
            }
        }

        #region bool DisableMotifDecorations()

        bool DisableMotifDecorations()
        {
            IntPtr atom = Functions.XInternAtom(this.window.Display, MOTIF_WM_ATOM, true);
            if (atom != IntPtr.Zero)
            {
                //Functions.XGetWindowProperty(window.Display, window.WindowHandle, atom, IntPtr.Zero, IntPtr.Zero, false,
                                             
                MotifWmHints hints = new MotifWmHints();
                hints.flags = (IntPtr)MotifFlags.Decorations;
                Functions.XChangeProperty(this.window.Display, this.Handle, atom, atom, 32, PropertyMode.Replace,
                                          ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                return true;
            }
            return false;
        }

        #endregion

        #region bool DisableGnomeDecorations()

        bool DisableGnomeDecorations()
        {
            IntPtr atom = Functions.XInternAtom(this.window.Display, Constants.XA_WIN_HINTS, true);
            if (atom != IntPtr.Zero)
            {
                IntPtr hints = IntPtr.Zero;
                Functions.XChangeProperty(this.window.Display, this.Handle, atom, atom, 32, PropertyMode.Replace,
                                          ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                return true;
            }

            return false;
        }

        #endregion

        #endregion

        #region void EnableWindowDecorations()

        void EnableWindowDecorations()
        {
            if (EnableMotifDecorations())
            {
                Debug.Print("Activated decorations through motif.");
                _decorations_hidden = false;
            }

            //if (EnableGnomeDecorations()) { Debug.Print("Activated decorations through gnome."); activated = true; }

            Functions.XSetTransientForHint(this.window.Display, this.Handle, IntPtr.Zero);

            if (!_decorations_hidden)
            {
                Functions.XUnmapWindow(this.window.Display, this.Handle);
                Functions.XMapWindow(this.window.Display, this.Handle);
            }
        }

        #region bool EnableMotifDecorations()

        bool EnableMotifDecorations()
        {
            IntPtr atom = Functions.XInternAtom(this.window.Display, MOTIF_WM_ATOM, true);
            if (atom != IntPtr.Zero)
            {
                //Functions.XDeleteProperty(this.window.Display, this.Handle, atom);
                MotifWmHints hints = new MotifWmHints();
                hints.flags = (IntPtr)MotifFlags.Decorations;
                hints.decorations = (IntPtr)MotifDecorations.All;
                Functions.XChangeProperty(this.window.Display, this.Handle, atom, atom, 32, PropertyMode.Replace,
                                          ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                
                return true;
            }
            return false;
        }

        #endregion

        #region bool EnableGnomeDecorations()

        bool EnableGnomeDecorations()
        {
            // Restore window layer.
            //XEvent xev = new XEvent();
            //xev.ClientMessageEvent.window = this.window.Handle;
            //xev.ClientMessageEvent.type = XEventName.ClientMessage;
            //xev.ClientMessageEvent.message_type = Functions.XInternAtom(this.window.Display, Constants.XA_WIN_LAYER, false);
            //xev.ClientMessageEvent.format = 32;
            //xev.ClientMessageEvent.ptr1 = (IntPtr)WindowLayer.AboveDock;
            //Functions.XSendEvent(this.window.Display, this.window.RootWindow, false, (IntPtr)EventMask.SubstructureNotifyMask, ref xev);
            
            IntPtr atom = Functions.XInternAtom(this.window.Display, Constants.XA_WIN_HINTS, true);
            if (atom != IntPtr.Zero)
            {
                Functions.XDeleteProperty(this.window.Display, this.Handle, atom);
                return true;
            }

            return false;
        }

        #endregion

        #endregion

        #endregion
    }
}
