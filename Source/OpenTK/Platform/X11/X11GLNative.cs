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
#if !MINIMAL
using System.Drawing;
#endif
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// \internal
    /// <summary>
    /// Drives GameWindow on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLNative : NativeWindowBase
    {
        // TODO: Disable screensaver.
        // TODO: What happens if we can't disable decorations through motif?
        // TODO: Mouse/keyboard grabbing/wrapping.

        #region Fields
        
        const int _min_width = 30, _min_height = 30;

        readonly X11WindowInfo window = new X11WindowInfo();
        readonly X11KeyMap KeyMap;

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

        #pragma warning disable 414 // assigned but never used
        IntPtr _atom_net_wm_allowed_actions;
        IntPtr _atom_net_wm_action_resize;
        IntPtr _atom_net_wm_action_maximize_horizontally;
        IntPtr _atom_net_wm_action_maximize_vertically;
        #pragma warning restore 414

        IntPtr _atom_net_wm_icon;

        IntPtr _atom_net_frame_extents;

        readonly IntPtr _atom_xa_cardinal = new IntPtr(6);

        static readonly IntPtr _atom_remove = (IntPtr)0;
        static readonly IntPtr _atom_add = (IntPtr)1;
        static readonly IntPtr _atom_toggle = (IntPtr)2;

        #pragma warning disable 649 // never assigned, compiler bug in Mono 3.4.0
        Rectangle bounds, client_rectangle;
        #pragma warning restore 649
        int border_left, border_right, border_top, border_bottom;
        Icon icon;
        bool has_focus;
        bool visible;

        // Used for event loop.
        XEvent e = new XEvent();

        bool disposed;
        bool exists;
        bool isExiting;

        bool _decorations_hidden = false;

        // Store previous border and bounds
        // when switching from WindowState.Normal
        // to a different state. When switching
        // back, reset window to these.s
        WindowBorder _previous_window_border;
        Size _previous_window_size;

        MouseCursor cursor = MouseCursor.Default;
        IntPtr cursorHandle;
        bool cursor_visible = true;

         // Keyboard input
        readonly byte[] ascii = new byte[16];
        readonly char[] chars = new char[16];

        readonly IntPtr EmptyCursor;

        #pragma warning disable 414 // Field assigned but never used, we do that on purpose
        readonly bool xi2_supported;
        readonly int xi2_opcode;
        readonly int xi2_version;
        #pragma warning restore 414

        #endregion

        #region Constructors

        public X11GLNative(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
            : this()
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width", "Must be higher than zero.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException("height", "Must be higher than zero.");

            Debug.Indent();

            using (new XLock(window.Display))
            {
                IntPtr visual;
                IntPtr fbconfig;
                window.GraphicsMode = new X11GraphicsMode()
                    .SelectGraphicsMode(mode, out visual, out fbconfig);

                window.Visual = visual;
                window.FBConfig = fbconfig;

                // Create a window on this display using the visual above
                Debug.Write("Opening render window... ");

                XSetWindowAttributes attributes = new XSetWindowAttributes();
                attributes.background_pixel = IntPtr.Zero;
                attributes.border_pixel = IntPtr.Zero;
                attributes.colormap = Functions.XCreateColormap(window.Display, window.RootWindow, window.VisualInfo.Visual, 0/*AllocNone*/);
                window.EventMask = EventMask.StructureNotifyMask /*| EventMask.SubstructureNotifyMask*/ | EventMask.ExposureMask |
                                   EventMask.KeyReleaseMask | EventMask.KeyPressMask | EventMask.KeymapStateMask |
                                   EventMask.PointerMotionMask | EventMask.FocusChangeMask |
                                   EventMask.ButtonPressMask | EventMask.ButtonReleaseMask |
                                   EventMask.EnterWindowMask | EventMask.LeaveWindowMask |
                                   EventMask.PropertyChangeMask;
                attributes.event_mask = (IntPtr)window.EventMask;

                SetWindowValuemask mask =
                    SetWindowValuemask.ColorMap | SetWindowValuemask.EventMask |
                    SetWindowValuemask.BackPixel | SetWindowValuemask.BorderPixel;

                window.Handle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    x, y, width, height, 0, window.VisualInfo.Depth/*(int)CreateWindowArgs.CopyFromParent*/,
                    CreateWindowArgs.InputOutput, window.VisualInfo.Visual, mask, attributes);

                if (window.Handle == IntPtr.Zero)
                    throw new ApplicationException("XCreateWindow call failed (returned 0).");

                if (title != null)
                    Functions.XStoreName(window.Display, window.Handle, title);
            }

            XSizeHints hints = new XSizeHints();
            hints.base_width = width;
            hints.base_height = height;
            hints.flags = (IntPtr)(XSizeHintsFlags.PSize | XSizeHintsFlags.PPosition);

            XClassHint class_hint = new XClassHint();
            class_hint.Name = Assembly.GetEntryAssembly().GetName().Name.ToLower();
            class_hint.Class = Assembly.GetEntryAssembly().GetName().Name;

            using (new XLock(window.Display))
            {
                Functions.XSetWMNormalHints(window.Display, window.Handle, ref hints);

                // Register for window destroy notification
                Functions.XSetWMProtocols(window.Display, window.Handle, new IntPtr[] { _atom_wm_destroy }, 1);

                // Set the window class hints
                Functions.XSetClassHint(window.Display, window.Handle, ref class_hint);
            }

            SetWindowMinMax(_min_width, _min_height, -1, -1);

            // Set the initial window size to ensure X, Y, Width, Height and the rest
            // return the correct values inside the constructor and the Load event.
            XEvent e = new XEvent();
            e.ConfigureEvent.x = x;
            e.ConfigureEvent.y = y;
            e.ConfigureEvent.width = width;
            e.ConfigureEvent.height = height;
            RefreshWindowBounds(ref e);

            EmptyCursor = CreateEmptyCursor(window);

            Debug.WriteLine(String.Format("X11GLNative window created successfully (id: {0}).", Handle));
            Debug.Unindent();

            using (new XLock(window.Display))
            {
                // Request that auto-repeat is only set on devices that support it physically.
                // This typically means that it's turned off for keyboards (which is what we want).
                // We prefer this method over XAutoRepeatOff/On, because the latter needs to
                // be reset before the program exits.
                if (Xkb.IsSupported(window.Display))
                {
                    bool supported;
                    Xkb.SetDetectableAutoRepeat(window.Display, true, out supported);
                }
            }

            // The XInput2 extension makes keyboard and mouse handling much easier.
            // Check whether it is available.
            xi2_supported = XI2MouseKeyboard.IsSupported(window.Display);
            if (xi2_supported)
            {
                xi2_opcode = XI2MouseKeyboard.XIOpCode;
                xi2_version = XI2MouseKeyboard.XIVersion;
            }

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
                window.Display = Functions.XOpenDisplay(IntPtr.Zero);
                //window.Display = API.DefaultDisplay;
                if (window.Display == IntPtr.Zero)
                    throw new Exception("Could not open connection to X");

                using (new XLock(window.Display))
                {
                    window.Screen = Functions.XDefaultScreen(window.Display); //API.DefaultScreen;
                    window.RootWindow = Functions.XRootWindow(window.Display, window.Screen); // API.RootWindow;
                    KeyMap = new X11KeyMap(window.Display);
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
            using (new XLock(window.Display))
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
                    Functions.XInternAtom(window.Display, "_NEW_WM_ICON", false);

                _atom_net_frame_extents =
                    Functions.XInternAtom(window.Display, "_NET_FRAME_EXTENTS", false);

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
        }

        #endregion

        #region SetWindowMinMax
        
        void SetWindowMinMax(int min_width, int min_height, int max_width, int max_height)
        {
            SetWindowMinMax((short)min_width, (short)min_height, (short)max_width, (short)max_height);
        }

        void SetWindowMinMax(short min_width, short min_height, short max_width, short max_height)
        {
            IntPtr dummy;
            XSizeHints hints = new XSizeHints();

            using (new XLock(window.Display))
            {
                Functions.XGetWMNormalHints(window.Display, window.Handle, ref hints, out dummy);
            }

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
                using (new XLock(window.Display))
                {
                    Functions.XSetWMNormalHints(window.Display, window.Handle, ref hints);
                }
            }
        }

        #endregion

        #region IsWindowBorderResizable

        bool IsWindowBorderResizable
        {
            get
            {
                using (new XLock(window.Display))
                {
                    XSizeHints hints = new XSizeHints();
                    IntPtr dummy;
                    if (Functions.XGetWMNormalHints(window.Display, window.Handle, ref hints, out dummy) != 0)
                    {
                        return hints.min_width != hints.max_width || hints.min_height != hints.max_height;
                    }
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
                using (new XLock(window.Display))
                {
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
                    Functions.XGetTransientForHint(window.Display, window.Handle, out transient_for_parent);
                    if (transient_for_parent != IntPtr.Zero)
                        return true;
    
                    return false;
                }
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
            
            using (new XLock(window.Display))
            {
                // Functions.XSetTransientForHint(this.window.Display, this.Handle, this.window.RootWindow);

                // Some WMs remove decorations when this hint is set. Doesn't hurt to try.
                Functions.XSetTransientForHint(this.window.Display, this.Handle, this.window.RootWindow);

                if (_decorations_hidden)
                {
                    Functions.XUnmapWindow(this.window.Display, this.Handle);
                    Functions.XMapWindow(this.window.Display, this.Handle);
                }
            }
        }
        

        #region bool DisableMotifDecorations()

        bool DisableMotifDecorations()
        {
            using (new XLock(window.Display))
            {
                IntPtr atom = Functions.XInternAtom(this.window.Display, MOTIF_WM_ATOM, true);
                if (atom != IntPtr.Zero)
                {
                    //Functions.XGetWindowProperty(window.Display, window.Handle, atom, IntPtr.Zero, IntPtr.Zero, false,
                                                 
                    MotifWmHints hints = new MotifWmHints();
                    hints.flags = (IntPtr)MotifFlags.Decorations;
                    Functions.XChangeProperty(this.window.Display, this.Handle, atom, atom, 32, PropertyMode.Replace,
                                              ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region bool DisableGnomeDecorations()

        bool DisableGnomeDecorations()
        {
            using (new XLock(window.Display))
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

            using (new XLock(window.Display))
            {
                Functions.XSetTransientForHint(this.window.Display, this.Handle, IntPtr.Zero);

                if (!_decorations_hidden)
                {
                    Functions.XUnmapWindow(this.window.Display, this.Handle);
                    Functions.XMapWindow(this.window.Display, this.Handle);
                }
            }
        }

        #region bool EnableMotifDecorations()

        bool EnableMotifDecorations()
        {
            using (new XLock(window.Display))
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
        }

        #endregion

        #region bool EnableGnomeDecorations()

        bool EnableGnomeDecorations()
        {
            using (new XLock(window.Display))
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
        }

        #endregion

        #endregion

        #region DeleteIconPixmaps
        
        static void DeleteIconPixmaps(IntPtr display, IntPtr window)
        {
            using (new XLock(display))
            {
                IntPtr wmHints_ptr = Functions.XGetWMHints(display, window);
    
                if (wmHints_ptr != IntPtr.Zero)
                {
                    XWMHints wmHints = (XWMHints)Marshal.PtrToStructure(wmHints_ptr, typeof(XWMHints));
                    XWMHintsFlags flags = (XWMHintsFlags)wmHints.flags.ToInt32();
    
                    if ((flags & XWMHintsFlags.IconPixmapHint) != 0)
                    {
                        wmHints.flags = new IntPtr((int)(flags & ~XWMHintsFlags.IconPixmapHint));
                        Functions.XFreePixmap(display, wmHints.icon_pixmap);
                    }
    
                    if ((flags & XWMHintsFlags.IconMaskHint) != 0)
                    {
                        wmHints.flags = new IntPtr((int)(flags & ~XWMHintsFlags.IconMaskHint));
                        Functions.XFreePixmap(display, wmHints.icon_mask);
                    }
    
                    Functions.XSetWMHints(display, window, ref wmHints);
                    Functions.XFree(wmHints_ptr);
                }
            }
        }

        #endregion

        bool RefreshWindowBorders()
        {
            bool borders_changed = false;

            if (IsWindowBorderHidden)
            {
                borders_changed =
                    border_left != 0 ||
                    border_right != 0 ||
                    border_top != 0 ||
                    border_bottom != 0;
                
                border_left = 0;
                border_right = 0;
                border_top = 0;
                border_bottom = 0;
            }
            else
            {
                IntPtr atom, nitems, bytes_after, prop = IntPtr.Zero;
                int format;
    
                using (new XLock(window.Display))
                {
                    Functions.XGetWindowProperty(window.Display, window.Handle,
                        _atom_net_frame_extents, IntPtr.Zero, new IntPtr(16), false,
                        (IntPtr)AtomName.XA_CARDINAL, out atom, out format, out nitems, out bytes_after, ref prop);
                }
    
                if ((prop != IntPtr.Zero))
                {
                    if ((long)nitems == 4)
                    {
                        int new_border_left = Marshal.ReadIntPtr(prop, 0).ToInt32();
                        int new_border_right = Marshal.ReadIntPtr(prop, IntPtr.Size).ToInt32();
                        int new_border_top = Marshal.ReadIntPtr(prop, IntPtr.Size * 2).ToInt32();
                        int new_border_bottom = Marshal.ReadIntPtr(prop, IntPtr.Size * 3).ToInt32();
    
                        borders_changed =
                            new_border_left != border_left ||
                            new_border_right != border_right ||
                            new_border_top != border_top ||
                            new_border_bottom != border_bottom;
    
                        border_left = new_border_left;
                        border_right = new_border_right;
                        border_top = new_border_top;
                        border_bottom = new_border_bottom;
    
                        //Debug.WriteLine(border_left);
                        //Debug.WriteLine(border_right);
                        //Debug.WriteLine(border_top);
                        //Debug.WriteLine(border_bottom);
                    }
    
                    using (new XLock(window.Display))
                    {
                        Functions.XFree(prop);
                    }
                }
            }

            return borders_changed;
        }

        void RefreshWindowBounds(ref XEvent e)
        {
            RefreshWindowBorders();

            // For whatever reason, the x/y coordinates
            // of a configure event are global to the
            // root window when it is a send_event but
            // local when it is a regular event.
            // I don't know who designed this, but this is
            // utter nonsense.
            int x, y;
            IntPtr unused;
            if (!e.ConfigureEvent.send_event)
            {
                Functions.XTranslateCoordinates(window.Display,
                    window.Handle, window.RootWindow,
                    0, 0, out x, out y, out unused);
            }
            else
            {
                x = e.ConfigureEvent.x;
                y = e.ConfigureEvent.y;
            }
            
            Point new_location = new Point(
                x - border_left,
                y - border_top);

            if (Location != new_location)
            {
                bounds.Location = new_location;
                OnMove(EventArgs.Empty);
            }

            // Note: width and height denote the internal (client) size.
            // To get the external (window) size, we need to add the border size.
            Size new_size = new Size(
                e.ConfigureEvent.width + border_left + border_right,
                e.ConfigureEvent.height + border_top + border_bottom);
            if (Bounds.Size != new_size)
            {
                bounds.Size = new_size;

                // X11 sets the client width/height to 0
                // when the window is minimized. Many apps
                // do not expect this and crash, so clamp
                // minimum width/height to 1 instead.
                client_rectangle.Size = new Size(
                    Math.Max(e.ConfigureEvent.width, 1),
                    Math.Max(e.ConfigureEvent.height, 1));
                OnResize(EventArgs.Empty);
            }

            //Debug.Print("[X11] Window bounds changed: {0}", bounds);
        }

        static IntPtr CreateEmptyCursor(X11WindowInfo window)
        {
            IntPtr cursor = IntPtr.Zero;
            using (new XLock(window.Display))
            {
                XColor black, dummy;
                IntPtr cmap = Functions.XDefaultColormap(window.Display, window.Screen);
                Functions.XAllocNamedColor(window.Display, cmap, "black", out black, out dummy);
                IntPtr bmp_empty = Functions.XCreateBitmapFromData(window.Display,
                    window.Handle, new byte[,] { { 0 } });
                cursor = Functions.XCreatePixmapCursor(window.Display,
                    bmp_empty, bmp_empty, ref black, ref black, 0, 0);
            }
            return cursor;
        }

        #endregion

        #region INativeWindow Members

        #region ProcessEvents

        public override void ProcessEvents()
        {
            base.ProcessEvents();
            // Process all pending events
            while (Exists && window != null)
            {
                using (new XLock(window.Display))
                {
                    if (!Functions.XCheckWindowEvent(window.Display, window.Handle, window.EventMask, ref e) &&
                        !Functions.XCheckTypedWindowEvent(window.Display, window.Handle, XEventName.ClientMessage, ref e))
                        break;
                }
                
                // Respond to the event e
                switch (e.type)
                {
                    case XEventName.MapNotify:
                        {
                            bool previous_visible = visible;
                            visible = true;
                            if (visible != previous_visible)
                                OnVisibleChanged(EventArgs.Empty);
                        }
                        return;

                    case XEventName.UnmapNotify:
                        {
                            bool previous_visible = visible;
                            visible = false;
                            if (visible != previous_visible)
                                OnVisibleChanged(EventArgs.Empty);
                        }
                        break;

                    case XEventName.CreateNotify:
                        // A child was was created - nothing to do
                        break;

                    case XEventName.ClientMessage:
                        if (!isExiting && e.ClientMessageEvent.ptr1 == _atom_wm_destroy)
                        {
                            Debug.Print("[X11] Exit message received for window {0:X} on display {1:X}", window.Handle, window.Display);
                            CancelEventArgs ce = new CancelEventArgs();
                            OnClosing(ce);

                            if (!ce.Cancel)
                            {
                                isExiting = true;
                                DestroyWindow();
                                OnClosed(EventArgs.Empty);
                                break;
                            }
                        }
                        
                        break;

                    case XEventName.DestroyNotify:
                        Debug.WriteLine("Window destroyed");
                        exists = false;
                        return;

                    case XEventName.ConfigureNotify:
                        RefreshWindowBounds(ref e);
                        break;

                    case XEventName.KeyPress:
                    case XEventName.KeyRelease:
                        bool pressed = e.type == XEventName.KeyPress;
                        Key key;
                        if (KeyMap.TranslateKey(ref e.KeyEvent, out key))
                        {
                            if (pressed)
                            {
                                // Raise KeyDown event
                                bool is_repeat = KeyboardState[key];
                                OnKeyDown(key, is_repeat);
                            }
                            else
                            {
                                // Raise KeyUp event
                                OnKeyUp(key);
                            }

                            if (pressed)
                            {
                                // Translate XKeyPress to characters and
                                // raise KeyPress events
                                int status = 0;
                                status = Functions.XLookupString(
                                    ref e.KeyEvent, ascii, ascii.Length, null, IntPtr.Zero);
                                Encoding.Default.GetChars(ascii, 0, status, chars, 0);
    
                                for (int i = 0; i < status; i++)
                                {
                                    if (!Char.IsControl(chars[i]))
                                    {
                                        OnKeyPress(chars[i]);
                                    }
                                }
                            }
                        }
                        break;

                    case XEventName.MotionNotify:
                    {
                        int x = e.MotionEvent.x;
                        int y = e.MotionEvent.y;

                        if (x != MouseState.X || y != MouseState.Y)
                        {
                            OnMouseMove(
                                MathHelper.Clamp(x, 0, Width),
                                MathHelper.Clamp(y, 0, Height));
                        }
                        break;
                    }

                    case XEventName.ButtonPress:
                        {
                            float dx, dy;
                            MouseButton button = X11KeyMap.TranslateButton(e.ButtonEvent.button, out dx, out dy);

                            if (button != MouseButton.LastButton)
                            {
                                OnMouseDown(button);
                            }

                            if (xi2_version >= 210)
                            {
                                // High resolution scroll events supported.
                                // This code is implemented in XI2Mouse.GetCursorState().
                                // Instead of reimplementing this functionality, just
                                // use the values from there.
                                MouseState state = Mouse.GetCursorState();
                                dx = state.Scroll.X - MouseState.Scroll.X;
                                dy = state.Scroll.Y - MouseState.Scroll.Y;
                            }

                            if (dx != 0 || dy != 0)
                            {
                                // High resolution scroll events not supported
                                // fallback to the old Button4-7 scroll buttons
                                OnMouseWheel(dx, dy);
                            }
                        }
                        break;

                    case XEventName.ButtonRelease:
                        {
                            float dx, dy;
                            MouseButton button = X11KeyMap.TranslateButton(e.ButtonEvent.button, out dx, out dy);
                            if (button != MouseButton.LastButton)
                            {
                                OnMouseUp(button);
                            }
                        }
                        break;

                    case XEventName.FocusIn:
                        {
                            bool previous_focus = has_focus;
                            has_focus = true;
                            if (has_focus != previous_focus)
                                OnFocusedChanged(EventArgs.Empty);

                            if (Focused && !CursorVisible)
                            {
                                GrabMouse();
                            }
                        }
                        break;

                    case XEventName.FocusOut:
                        {
                            bool previous_focus = has_focus;
                            has_focus = false;
                            if (has_focus != previous_focus)
                                OnFocusedChanged(EventArgs.Empty);
                        }
                        break;

                    case XEventName.LeaveNotify:
                        if (CursorVisible)
                        {
                            int x = MathHelper.Clamp(e.CrossingEvent.x, 0, Width);
                            int y = MathHelper.Clamp(e.CrossingEvent.y, 0, Height);
                            if (x != MouseState.X || y != MouseState.Y)
                            {
                                OnMouseMove(x, y);
                            }
                            OnMouseLeave(EventArgs.Empty);
                        }
                        break;

                    case XEventName.EnterNotify:
                        OnMouseEnter(EventArgs.Empty);
                        break;

                    case XEventName.MappingNotify:
                        // 0 == MappingModifier, 1 == MappingKeyboard
                        if (e.MappingEvent.request == 0 || e.MappingEvent.request == 1)
                        {
                            Debug.Print("keybard mapping refreshed");
                            Functions.XRefreshKeyboardMapping(ref e.MappingEvent);
                            KeyMap.RefreshKeycodes(window.Display);
                        }
                        break;

                   case XEventName.PropertyNotify:
                        if (e.PropertyEvent.atom == _atom_net_wm_state)
                        {
                            OnWindowStateChanged(EventArgs.Empty);
                        }

                        //if (e.PropertyEvent.atom == _atom_net_frame_extents)
                        //{
                        //    RefreshWindowBorders();
                        //}
                        break;

                    default:
                        //Debug.WriteLine(String.Format("{0} event was not handled", e.type));
                        break;
                }
            }
        }

        #endregion

        #region Bounds

        public override Rectangle Bounds
        {
            get
            {
                return bounds;
            }
            set
            {
                bool is_location_changed = bounds.Location != value.Location;
                bool is_size_changed = bounds.Size != value.Size;

                int x = value.X;
                int y = value.Y;
                int width = value.Width - border_left - border_right;
                int height = value.Height - border_top - border_bottom;

                if (WindowBorder != WindowBorder.Resizable)
                {
                    SetWindowMinMax(width, height, width, height);
                }

                using (new XLock(window.Display))
                {
                    if (is_location_changed && is_size_changed)
                    {
                        Functions.XMoveResizeWindow(window.Display, window.Handle,
                            x, y, width, height);
                    }
                    else if (is_location_changed)
                    {
                        Functions.XMoveWindow(window.Display, window.Handle,
                            x, y);
                    }
                    else if (is_size_changed)
                    {
                        Functions.XResizeWindow(window.Display, window.Handle,
                            width, height);
                    }
                }

                ProcessEvents();
            }
        }

        #endregion

        #region ClientSize

        public override Size ClientSize
        {
            get
            {
                return client_rectangle.Size;
            }
            set
            {
                using (new XLock(window.Display))
                {
                    Functions.XResizeWindow(window.Display, window.Handle,
                        value.Width, value.Height);
                }
                ProcessEvents();
            }
        }

        #endregion

        #region Icon

        public override Icon Icon
        {
            get
            {
                return icon;
            }
            set
            {
                if (value == icon)
                    return;

                // Note: it seems that Gnome/Metacity does not respect the _NET_WM_ICON hint.
                // For this reason, we'll also set the icon using XSetWMHints.
                if (value == null)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XDeleteProperty(window.Display, window.Handle, _atom_net_wm_icon);
                        DeleteIconPixmaps(window.Display, window.Handle);
                    }
                }
                else
                {
                    // Set _NET_WM_ICON
                    Bitmap bitmap = value.ToBitmap();
                    int size = bitmap.Width * bitmap.Height + 2;
                    IntPtr[] data = new IntPtr[size];
                    int index = 0;
    
                    data[index++] = (IntPtr)bitmap.Width;
                    data[index++] = (IntPtr)bitmap.Height;
    
                    for (int y = 0; y < bitmap.Height; y++)
                        for (int x = 0; x < bitmap.Width; x++)
                            data[index++] = (IntPtr)bitmap.GetPixel(x, y).ToArgb();

                    using (new XLock(window.Display))
                    {
                        Functions.XChangeProperty(window.Display, window.Handle,
                                      _atom_net_wm_icon, _atom_xa_cardinal, 32,
                                      PropertyMode.Replace, data, size);
                    }

                    // Set XWMHints
                    DeleteIconPixmaps(window.Display, window.Handle);
                    using (new XLock(window.Display))
                    {
                        IntPtr wmHints_ptr = Functions.XGetWMHints(window.Display, window.Handle);
    
                        if (wmHints_ptr == IntPtr.Zero)
                            wmHints_ptr = Functions.XAllocWMHints();
    
                        XWMHints wmHints = (XWMHints)Marshal.PtrToStructure(wmHints_ptr, typeof(XWMHints));
    
                        wmHints.flags = new IntPtr(wmHints.flags.ToInt32() | (int)(XWMHintsFlags.IconPixmapHint | XWMHintsFlags.IconMaskHint));
                        wmHints.icon_pixmap = Functions.CreatePixmapFromImage(window.Display, bitmap);
                        wmHints.icon_mask = Functions.CreateMaskFromImage(window.Display, bitmap);
    
                        Functions.XSetWMHints(window.Display, window.Handle, ref wmHints);
                        Functions.XFree (wmHints_ptr);
    
                        Functions.XSync(window.Display, false);
                    }
                }

                icon = value;
                OnIconChanged(EventArgs.Empty);
            }
        }

        #endregion

        #region Focused

        public override bool Focused
        {
            get
            {
                return has_focus;
            }
        }

        #endregion

        #region WindowState

        public override OpenTK.WindowState WindowState
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

                using (new XLock(window.Display))
                {
                    Functions.XGetWindowProperty(window.Display, window.Handle,
                                 _atom_net_wm_state, IntPtr.Zero, new IntPtr(256), false,
                                 new IntPtr(4) /*XA_ATOM*/, out actual_atom, out actual_format,
                                 out nitems, out bytes_after, ref prop);
                }

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
                    using (new XLock(window.Display))
                    {
                        Functions.XFree(prop);
                    }
                }

                if (minimized)
                    return OpenTK.WindowState.Minimized;
                else if (maximized == 2)
                    return OpenTK.WindowState.Maximized;
                else if (fullscreen)
                    return OpenTK.WindowState.Fullscreen;
                /*
                                attributes = new XWindowAttributes();
                                Functions.XGetWindowAttributes(window.Display, window.Handle, ref attributes);
                                if (attributes.map_state == MapState.IsUnmapped)
                                    return (OpenTK.WindowState)(-1);
                */
                return OpenTK.WindowState.Normal;
            }
            set
            {
                OpenTK.WindowState current_state = this.WindowState;

                // When switching away from normal state, store
                // the "normal" border and size. These will be used
                // for restoring to normal state.
                if (current_state == OpenTK.WindowState.Normal)
                {
                    _previous_window_border = WindowBorder;
                    _previous_window_size = ClientSize;
                }

                if (current_state == value)
                    return;

                Debug.Print("GameWindow {0} changing WindowState from {1} to {2}.", window.Handle.ToString(),
                    current_state.ToString(), value.ToString());

                // When minimizing the window, call XIconifyWindow and bail out.
                // For other states, we first need to restore the window, set the
                // new state and reset the window border and bounds.
                if (value != OpenTK.WindowState.Minimized)
                {
                    // Some WMs cannot switch between specific states directly,
                    // Switch back to a regular window first.
                    if (WindowBorder == WindowBorder.Fixed)
                    {
                        ChangeWindowBorder(WindowBorder.Resizable);
                    }

                    ResetWindowState(current_state);
                }

                // Change to the desired WindowState.
                // Note that OnWindowStateChanged is called inside
                // ProcessEvents.
                ChangeWindowState(value);
                ProcessEvents();
            }
        }

        void ResetWindowState(OpenTK.WindowState current_state)
        {
            if (current_state != OpenTK.WindowState.Normal)
            {
                using (new XLock(window.Display))
                {
                    switch (current_state)
                    {
                        case OpenTK.WindowState.Minimized:
                            Functions.XMapWindow(window.Display, window.Handle);
                            break;

                        case OpenTK.WindowState.Fullscreen:
                            Functions.SendNetWMMessage(window,
                                _atom_net_wm_state,
                                _atom_remove,
                                _atom_net_wm_state_fullscreen,
                                IntPtr.Zero);
                            break;

                        case OpenTK.WindowState.Maximized:
                            Functions.SendNetWMMessage(window,
                                _atom_net_wm_state,
                                _atom_toggle,
                                _atom_net_wm_state_maximized_horizontal,
                                _atom_net_wm_state_maximized_vertical);
                            break;
                    }
                }
            }
        }

        void ChangeWindowState(OpenTK.WindowState value)
        {
            using (new XLock(window.Display))
            {
                switch (value)
                {
                    case OpenTK.WindowState.Normal:
                        Functions.XRaiseWindow(window.Display, window.Handle);
                        ChangeWindowBorder(_previous_window_border,
                            _previous_window_size.Width, _previous_window_size.Height);
                        break;

                    case OpenTK.WindowState.Maximized:
                        Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_add,
                            _atom_net_wm_state_maximized_horizontal,
                            _atom_net_wm_state_maximized_vertical);
                        Functions.XRaiseWindow(window.Display, window.Handle);
                        break;

                    case OpenTK.WindowState.Minimized:
                        Functions.XIconifyWindow(window.Display, window.Handle, window.Screen);
                        break;

                    case OpenTK.WindowState.Fullscreen:
                        Functions.SendNetWMMessage(window, _atom_net_wm_state, _atom_add,
                            _atom_net_wm_state_fullscreen, IntPtr.Zero);
                        Functions.XRaiseWindow(window.Display, window.Handle);
                        break;
                }
            }
        }

        #endregion

        #region WindowBorder

        public override OpenTK.WindowBorder WindowBorder
        {
            get
            {
                if (IsWindowBorderHidden || WindowState == OpenTK.WindowState.Fullscreen)
                    return WindowBorder.Hidden;
                else if (!IsWindowBorderResizable)
                    return WindowBorder.Fixed;
                else if (WindowState == OpenTK.WindowState.Maximized)
                    return _previous_window_border;
                else
                    return WindowBorder.Resizable;
            }
            set
            {
                if (WindowBorder == value)
                    return;

                // We cannot change the border of a fullscreen window.
                // Record the new value and set it on the next WindowState
                // change.
                if (WindowState == OpenTK.WindowState.Fullscreen)
                {
                    _previous_window_border = value;
                    return;
                }

                ChangeWindowBorder(value);
                OnWindowBorderChanged(EventArgs.Empty);
            }
        }

        void ChangeWindowBorder(WindowBorder value)
        {
            ChangeWindowBorder(value, Width, Height);
        }

        void ChangeWindowBorder(WindowBorder value, int width, int height)
        {
            if (WindowBorder == WindowBorder.Hidden)
                EnableWindowDecorations();

            switch (value)
            {
                case WindowBorder.Fixed:
                    Debug.Print("Making WindowBorder fixed.");
                    SetWindowMinMax((short)width, (short)height, (short)width, (short)height);
                    break;
                case WindowBorder.Resizable:
                    Debug.Print("Making WindowBorder resizable.");
                    SetWindowMinMax(_min_width, _min_height, -1, -1);
                    break;
                case WindowBorder.Hidden:
                    Debug.Print("Making WindowBorder hidden.");
                    // Make the hidden border resizable, otherwise
                    // we won't be able to maximize the window or
                    // enter fullscreen mode.
                    SetWindowMinMax(_min_width, _min_height, -1, -1);
                    DisableWindowDecorations();
                    break;
            }

            ProcessEvents();
        }

        #endregion

        #region Cursor

        public override MouseCursor Cursor
        {
            get
            {
                return cursor;
            }
            set
            {
                unsafe
                {
                    if (value == cursor)
                        return;

                    using (new XLock(window.Display))
                    {
                        if (value == MouseCursor.Default)
                        {
                            cursorHandle = IntPtr.Zero;
                        }
                        else if (value == MouseCursor.Empty)
                        {
                            cursorHandle = EmptyCursor;
                        }
                        else
                        {
                            fixed(byte* pixels = value.Data)
                            {
                                var xcursorimage = Functions.XcursorImageCreate(value.Width, value.Height);
                                xcursorimage->xhot = (uint)value.X;
                                xcursorimage->yhot = (uint)value.Y;
                                xcursorimage->pixels = (uint*)pixels;
                                xcursorimage->delay = 0;
                                cursorHandle = Functions.XcursorImageLoadCursor(window.Display, xcursorimage);
                                Functions.XcursorImageDestroy(xcursorimage);
                            }
                        }

                        // If the cursor is visible set it now.
                        // Otherwise, it will be set in CursorVisible = true.
                        if (CursorVisible)
                        {
                            Functions.XDefineCursor(window.Display, window.Handle, cursorHandle);
                        }

                        cursor = value;
                    }
                }
            }
        }

        #endregion

        #region CursorVisible

        public override bool CursorVisible
        {
            get { return cursor_visible; }
            set
            {
                if (value)
                {
                    using (new XLock(window.Display))
                    {
                        UngrabMouse();

                        Point p = PointToScreen(new Point(MouseState.X, MouseState.Y));
                        Mouse.SetPosition(p.X, p.Y);

                        // Note: if cursorHandle = IntPtr.Zero, this restores the default cursor
                        // (equivalent to calling XUndefineCursor)
                        Functions.XDefineCursor(window.Display, window.Handle, cursorHandle);
                        cursor_visible = true;
                    }
                }
                else
                {
                    using (new XLock(window.Display))
                    {
                        GrabMouse();
                        cursor_visible = false;
                    }
                }
            }
        }

        void GrabMouse()
        {
            Functions.XGrabPointer(window.Display, window.Handle, false,
                EventMask.PointerMotionMask | EventMask.ButtonPressMask |
                EventMask.ButtonReleaseMask,
                GrabMode.GrabModeAsync, GrabMode.GrabModeAsync,
                window.Handle, EmptyCursor, IntPtr.Zero);
        }

        void UngrabMouse()
        {
            Functions.XUngrabPointer(window.Display, IntPtr.Zero);
        }

        #endregion

        #endregion

        #region --- INativeGLWindow Members ---

        #region public bool Exists

        /// <summary>
        /// Returns true if a render window/context exists.
        /// </summary>
        public override bool Exists
        {
            get { return exists; }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get { throw new Exception("The method or operation is not implemented."); }
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
        public override string Title
        {
            get
            {
                IntPtr name = IntPtr.Zero;
                using (new XLock(window.Display))
                {
                    Functions.XFetchName(window.Display, window.Handle, ref name);
                }
                if (name != IntPtr.Zero)
                    return Marshal.PtrToStringAnsi(name);

                return String.Empty;
            }
            set
            {
                if (value != null && value != Title)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XStoreName(window.Display, window.Handle, value);
                    }
                }

                OnTitleChanged(EventArgs.Empty);
            }
        }

        #endregion

        #region public bool Visible

        public override bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (value && !visible)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XMapWindow(window.Display, window.Handle);
                    }
                }
                else if (!value && visible)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XUnmapWindow(window.Display, window.Handle);
                    }
                }
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public override IWindowInfo WindowInfo
        {
            get { return window; }
        }

        #endregion

        public override void Close() { Exit(); }

        #region public void Exit()

        public void Exit()
        {
            Debug.Print("[X11] Sending exit message window {0:X} on display {1:X}", window.Handle, window.Display);

            XEvent ev = new XEvent();
            ev.type = XEventName.ClientMessage;
            ev.ClientMessageEvent.format = 32;
            ev.ClientMessageEvent.display = window.Display;
            ev.ClientMessageEvent.window = window.Handle;
            ev.ClientMessageEvent.ptr1 = _atom_wm_destroy;
            using (new XLock(window.Display))
            {
                Functions.XSendEvent(window.Display, window.Handle, false,
                    EventMask.NoEventMask, ref ev);
                Functions.XFlush(window.Display);
            }
        }

        #endregion

        #region public void DestroyWindow()

        public void DestroyWindow()
        {
            Debug.Print("[X11] Destroying window {0:X} on display {1:X}", window.Handle, window.Display);

            using (new XLock(window.Display))
            {
                Functions.XUnmapWindow(window.Display, window.Handle);
                Functions.XSync(window.Display, false);
                Functions.XDestroyWindow(window.Display, window.Handle);
                exists = false;
            }
        }

        #endregion

        #region PointToClient

        public override Point PointToClient(Point point)
        {
            int ox, oy;
            IntPtr child;

            using (new XLock(window.Display))
            {
                Functions.XTranslateCoordinates(window.Display, window.RootWindow, window.Handle, point.X, point.Y, out ox, out oy, out child);
            }

            point.X = ox;
            point.Y = oy;

            return point;
        }

        #endregion

        #region PointToScreen

        public override Point PointToScreen(Point point)
        {
            int ox, oy;
            IntPtr child;

            using (new XLock(window.Display))
            {
                Functions.XTranslateCoordinates(window.Display, window.Handle, window.RootWindow, point.X, point.Y, out ox, out oy, out child);
            }

            point.X = ox;
            point.Y = oy;

            return point;
        }

        #endregion

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                if (manuallyCalled)
                {
                    if (window != null && window.Handle != IntPtr.Zero)
                    {
                        Functions.XFreeCursor(window.Display, EmptyCursor);
                        if(cursorHandle != IntPtr.Zero)
                        {
                            Functions.XFreeCursor(window.Display, cursorHandle);
                        }

                        if (Exists)
                        {
                            DestroyWindow();
                        }

                        window.Dispose();
                    }
                }
                else
                {
                    Debug.Print("[Warning] {0} leaked.", this.GetType().Name);
                }
                disposed = true;
            }
        }

        #endregion
    }
}
