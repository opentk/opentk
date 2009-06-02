#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives GameWindow on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLNative : INativeWindow, IDisposable
    {
        // TODO: Disable screensaver.
        // TODO: What happens if we can't disable decorations through motif?
        // TODO: Mouse/keyboard grabbing/wrapping.

        #region Fields
        
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
        const string ICON_NET_ATOM = "_NET_WM_ICON";

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

        IntPtr _atom_net_wm_icon;

        readonly IntPtr _atom_xa_cardinal = new IntPtr(6);
        
        //IntPtr _atom_motif_wm_hints;
        //IntPtr _atom_kde_wm_hints;
        //IntPtr _atom_kde_net_wm_hints;
        
        static readonly IntPtr _atom_remove = (IntPtr)0;
        static readonly IntPtr _atom_add = (IntPtr)1;
        static readonly IntPtr _atom_toggle = (IntPtr)2;
        
        Rectangle bounds, client_rectangle;
        int border_width;
        Icon icon;
        bool has_focus;
        bool visible;

        // Used for event loop.
        XEvent e = new XEvent();

        bool disposed;
        bool exists;
        bool isExiting;

        bool _decorations_hidden = false;        
        
        #endregion

        #region Constructors

        public X11GLNative(int x, int y, int width, int height, string title,
            GraphicsMode mode,GameWindowFlags options, DisplayDevice device)
            : this()
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width", "Must be higher than zero.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException("height", "Must be higher than zero.");

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
                                   EventMask.PointerMotionMask | EventMask.FocusChangeMask |
                                   EventMask.ButtonPressMask | EventMask.ButtonReleaseMask;
                attributes.event_mask = (IntPtr)window.EventMask;

                uint mask = (uint)SetWindowValuemask.ColorMap | (uint)SetWindowValuemask.EventMask |
                    (uint)SetWindowValuemask.BackPixel | (uint)SetWindowValuemask.BorderPixel;

                window.WindowHandle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    x, y, width, height, 0, window.VisualInfo.depth/*(int)CreateWindowArgs.CopyFromParent*/,
                    (int)CreateWindowArgs.InputOutput, window.VisualInfo.visual, (UIntPtr)mask, ref attributes);

                if (window.WindowHandle == IntPtr.Zero)
                    throw new ApplicationException("XCreateWindow call failed (returned 0).");
            }

            // Set the window hints
            SetWindowMinMax(_min_width, _min_height, -1, -1);            
            
            XSizeHints hints = new XSizeHints();
            hints.base_width = width;
            hints.base_height = height;
            hints.flags = (IntPtr)(XSizeHintsFlags.PSize | XSizeHintsFlags.PPosition);
            lock (API.Lock)
            {
                Functions.XSetWMNormalHints(window.Display, window.WindowHandle, ref hints);

                // Register for window destroy notification
                Functions.XSetWMProtocols(window.Display, window.WindowHandle, new IntPtr[] { _atom_wm_destroy }, 1);

                API.MapRaised(window.Display, window.WindowHandle);
            }

            driver = new X11Input(window);
            
            Debug.WriteLine(String.Format("X11GLNative window created successfully (id: {0}).", Handle));
            Debug.Unindent();

            exists = true;
        }

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

        #region Private Members
        
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

            _atom_net_wm_icon =
                Functions.XInternAtom(window.Display,"_NEW_WM_ICON", false);
            
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

        #region SetWindowMinMax

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

        #endregion

        #region IsWindowBorderResizable

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

        #endregion
                
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

        #region INativeWindow Members

                #region ProcessEvents

        public void ProcessEvents()
        {
            // Process all pending events
            if (!exists || window == null)
                return;
            
            while (Functions.XCheckWindowEvent(window.Display, window.WindowHandle, window.EventMask, ref e) ||
                   Functions.XCheckTypedWindowEvent(window.Display, window.WindowHandle, XEventName.ClientMessage, ref e))
            {
                // Respond to the event e
                switch (e.type)
                {
                    case XEventName.MapNotify:
                        {
                            bool previous_visible = visible;
                            visible = true;
                            if (visible != previous_visible)
                                if (VisibleChanged != null)
                                    VisibleChanged(this, EventArgs.Empty);
                        }
                        return;

                    case XEventName.UnmapNotify:
                        {
                            bool previous_visible = visible;
                            visible = false;
                            if (visible != previous_visible)
                                if (VisibleChanged != null)
                                    VisibleChanged(this, EventArgs.Empty);
                        }
                        break;

                    case XEventName.CreateNotify:
                        // A child was was created - nothing to do
                        break;

                    case XEventName.ClientMessage:
                        if (e.ClientMessageEvent.ptr1 == _atom_wm_destroy)
                        {
                            CancelEventArgs ce = new CancelEventArgs();
                            if (Closing != null)
                                Closing(this, ce);

                            if (!ce.Cancel)
                            {
                                isExiting = true;
                                
                                if (Unload != null)
                                    Unload(this, EventArgs.Empty);
        
                                Functions.XDestroyWindow(window.Display, window.WindowHandle);
                                break;
                            }
                        }
                        
                        break;

                    case XEventName.DestroyNotify:
                        exists = false;

                        if (Closed != null)
                            Closed(this, EventArgs.Empty);
                        
                        break;

                    case XEventName.ConfigureNotify:
                        border_width = e.ConfigureEvent.border_width;
                        
                        Point new_location = new Point(e.ConfigureEvent.x, e.ConfigureEvent.y);
                        if (Location != new_location)
                        {
                            bounds.Location = new_location;
                            if (Move != null)
                                Move(this, EventArgs.Empty);
                        }

                        // Note: width and height denote the internal (client) size.
                        // To get the external (window) size, we need to add the border size.
                        Size new_size = new Size(e.ConfigureEvent.width, e.ConfigureEvent.height);
                        if (ClientSize != new_size)
                        {
                            bounds.Size = new_size;
                            bounds.Width += e.ConfigureEvent.border_width;
                            bounds.Height += e.ConfigureEvent.border_width;

                            // Todo: Get the real client rectangle.
                            client_rectangle.Size = new_size;
                        
                            if (this.Resize != null)
                                Resize(this, EventArgs.Empty);
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

                    case XEventName.FocusIn:
                        {
                            bool previous_focus = has_focus;
                            has_focus = true;
                            if (has_focus != previous_focus)
                                if (FocusedChanged != null)
                                    FocusedChanged(this, EventArgs.Empty);
                        }
                        break;

                    case XEventName.FocusOut:
                        {
                            bool previous_focus = has_focus;
                            has_focus = false;
                            if (has_focus != previous_focus)
                                if (FocusedChanged != null)
                                    FocusedChanged(this, EventArgs.Empty);
                        }
                        break;
                       
                    default:
                        //Debug.WriteLine(String.Format("{0} event was not handled", e.type));
                        break;
                }
            }
        }

        #endregion

        #region Bounds

        public System.Drawing.Rectangle Bounds
        {
            get { return bounds; }
            set
            {
                Functions.XMoveResizeWindow(window.Display, window.WindowHandle,
                    value.X, value.Y, value.Width - border_width, value.Height - border_width);
            }
        }

        #endregion

        #region Location

        public Point Location
        {
            get { return Bounds.Location; }
            set
            {
                Functions.XMoveWindow(window.Display, window.WindowHandle, value.X, value.Y);
            }
        }

        #endregion

        #region Size

        public Size Size
        {
            get { return Bounds.Size; }
            set
            {
                int width = value.Width - border_width;
                int height = value.Height - border_width;
                width = width < 0 ? 1 : width;
                height = height < 0 ? 1 : height;
                
                Functions.XResizeWindow(window.Display, window.WindowHandle, width, height);
            }
        }

        #endregion

        #region ClientRectangle

        public System.Drawing.Rectangle ClientRectangle
        {
            get
            {
                if (client_rectangle.Width == 0)
                    client_rectangle.Width = 1;
                if (client_rectangle.Height == 0)
                    client_rectangle.Height = 1;
                return client_rectangle;
            }
            set
            {
                Functions.XResizeWindow(window.Display, window.WindowHandle,
                    value.Width, value.Height);
            }
        }

        #endregion

        #region ClientSize

        public Size ClientSize
        {
            get
            {
                return ClientRectangle.Size;
            }
            set
            {
                ClientRectangle = new Rectangle(Point.Empty, value);
            }
        }

        #endregion

        #region Width

        public int Width
        {
            get { return Bounds.Width; }
            set { Size = new Size(value, Height); }
        }

        #endregion

        #region Height

        public int Height
        {
            get { return Bounds.Height; }
            set { Size = new Size(Width, value); }
        }

        #endregion

        #region X

        public int X
        {
            get { return Bounds.X; }
            set { Location = new Point(value, Y); }
        }

        #endregion

        #region Y

        public int Y
        {
            get { return Bounds.Y; }
            set { Location = new Point(X, value); }
        }

        #endregion

        #region Icon

        public Icon Icon
        {
            get
            {
                return icon;
            }
            set
            {
                if (value == null)
                {
                    Functions.XDeleteProperty(window.Display, window.WindowHandle, _atom_net_wm_icon);
                }
                else
                {
                    Bitmap bitmap;
                    int size;
                    IntPtr[] data;
                    int index;
    
                    bitmap = icon.ToBitmap();
                    index = 0;
                    size = bitmap.Width * bitmap.Height + 2;
                    data = new IntPtr[size];
    
                    data[index++] = (IntPtr)bitmap.Width;
                    data[index++] = (IntPtr)bitmap.Height;
    
                    for (int y = 0; y < bitmap.Height; y++)
                        for (int x = 0; x < bitmap.Width; x++)
                            data[index++] = (IntPtr)bitmap.GetPixel(x, y).ToArgb();
    
                    Functions.XChangeProperty(window.Display, window.WindowHandle,
                                  _atom_net_wm_icon, _atom_xa_cardinal, 32,
                                  PropertyMode.Replace, data, size);
                }

                icon = value;
            }
        }

        #endregion

        #region Focused

        public bool Focused
        {
            get
            {
                return has_focus;
            }
        }

        #endregion

        #region Events

        public event EventHandler<EventArgs> Load;

        public event EventHandler<EventArgs> Unload;

        public event EventHandler<EventArgs> Move;

        public event EventHandler<EventArgs> Resize;

        public event EventHandler<System.ComponentModel.CancelEventArgs> Closing;

        public event EventHandler<EventArgs> Closed;

        public event EventHandler<EventArgs> Disposed;

        public event EventHandler<EventArgs> IconChanged;

        public event EventHandler<EventArgs> TitleChanged;

        public event EventHandler<EventArgs> VisibleChanged;

        public event EventHandler<EventArgs> FocusedChanged;

        #endregion

        #endregion

        #region --- INativeGLWindow Members ---

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

        #region public bool IsExiting

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
                if (value != null)
                    Functions.XStoreName(window.Display, window.WindowHandle, value);
            }
        }

        #endregion

        #region public bool Visible

        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (value && !visible)
                {
                    Functions.XMapWindow(window.Display, window.WindowHandle);
                }
                else if (!value && visible)
                {
                    Functions.XUnmapWindow(window.Display, window.WindowHandle);
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

        public void Close() { Exit(); }

        #region public void Exit()

        public void Exit()
        {
            XEvent ev = new XEvent();
            ev.ClientMessageEvent.ptr1 = _atom_wm_destroy;
            Functions.XSendEvent(window.Display, window.WindowHandle, false,
                new IntPtr((int)EventMask.NoEventMask), ref ev);
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

        public Point PointToScreen(Point point)
        {
            int ox, oy;
            IntPtr child;

            Functions.XTranslateCoordinates(window.Display, window.WindowHandle, window.RootWindow, point.X, point.Y, out ox, out oy, out child);

            point.X = ox;
            point.Y = oy;

            return point;
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
                        // Todo: multiscreen support
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

        #region IDisposable Members

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
    
                        while (Exists)
                            ProcessEvents();

                        if (GraphicsContext.CurrentContext != null)
                            GraphicsContext.CurrentContext.MakeCurrent(null);
                        
                        window.Dispose();
                        window = null;
                    }
                }
                else
                {
                    Debug.Print("[Warning] {0} leaked.", this.GetType().Name);
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
