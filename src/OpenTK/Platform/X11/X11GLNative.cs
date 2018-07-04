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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Mathematics;
#if !MINIMAL
using System.Drawing;

#endif

namespace OpenTK.Platform.X11
{
    /// \internal
    /// <summary>
    /// Drives GameWindow on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLNative : NativeWindowBase
    {
        private const int _min_width = 30, _min_height = 30;
        private const string MOTIF_WM_ATOM = "_MOTIF_WM_HINTS";
        private const string KDE_WM_ATOM = "KWM_WIN_DECORATION";
        private const string KDE_NET_WM_ATOM = "_KDE_NET_WM_WINDOW_TYPE";
        private const string ICCM_WM_ATOM = "_NET_WM_WINDOW_TYPE";
        private const string ICON_NET_ATOM = "_NET_WM_ICON";
        private readonly X11KeyMap KeyMap;
        private readonly X11WindowInfo window = new X11WindowInfo();
        private IntPtr _atom_net_wm_state;
        private IntPtr _atom_net_wm_state_fullscreen;
        private IntPtr _atom_net_wm_state_maximized_horizontal;
        private IntPtr _atom_net_wm_state_maximized_vertical;
        private IntPtr _atom_net_wm_state_minimized;
        private IntPtr _atom_wm_destroy;
        private IntPtr _atom_xdnd_action_copy;
        private IntPtr _atom_xdnd_drop;
        private IntPtr _atom_xdnd_enter;
        private IntPtr _atom_xdnd_finished;
        private IntPtr _atom_xdnd_leave;
        private IntPtr _atom_xdnd_position;
        private IntPtr _atom_xdnd_primary;
        private IntPtr _atom_xdnd_selection;
        private IntPtr _atom_xdnd_status;
        private IntPtr _atom_xdnd_type_list;
        private IntPtr sourceHandler;
        private long sourceXdndVersion;

        private IntPtr xdndFormat;
        // TODO: Disable screensaver.
        // TODO: What happens if we can't disable decorations through motif?
        // TODO: Mouse/keyboard grabbing/wrapping.

        // Window manager hints for fullscreen windows.
        // Not used right now (the code is written, but is not 64bit-correct), but could be useful for older WMs which
        // are not ICCM compliant, but may support MOTIF hints.

        // The Atom class from Mono might be useful to avoid calling XInternAtom by hand (somewhat error prone).

        // Xdnd atoms
#pragma warning disable 414 // assigned but never used
        private IntPtr _atom_net_wm_allowed_actions;
        private IntPtr _atom_net_wm_action_resize;
        private IntPtr _atom_net_wm_action_maximize_horizontally;
        private IntPtr _atom_net_wm_action_maximize_vertically;
#pragma warning restore 414

        private IntPtr _atom_net_wm_icon;

        private IntPtr _atom_net_frame_extents;

        private readonly IntPtr _atom_xa_cardinal = new IntPtr(6);

        private static readonly IntPtr _atom_remove = (IntPtr)0;
        private static readonly IntPtr _atom_add = (IntPtr)1;
        private static readonly IntPtr _atom_toggle = (IntPtr)2;

#pragma warning disable 649 // never assigned, compiler bug in Mono 3.4.0
        private Rectangle bounds;
        private Size client_size;
#pragma warning restore 649
        private int border_left, border_right, border_top, border_bottom;
        private Icon icon;
        private bool has_focus;
        private bool visible;

        // Used for event loop.
        private XEvent e;

        private bool disposed;
        private bool exists;
        private bool isExiting;

        private bool _decorations_hidden;

        // Store previous border and bounds
        // when switching from WindowState.Normal
        // to a different state. When switching
        // back, reset window to these.s
        private WindowBorder _previous_window_border;

        private Size _previous_window_size;
        private OpenTK.WindowState _previous_window_state = OpenTK.WindowState.Normal;

        private MouseCursor cursor = MouseCursor.Default;
        private IntPtr cursorHandle;
        private bool cursor_visible = true;

        // Keyboard input
        private readonly byte[] ascii = new byte[16];

        private readonly char[] chars = new char[16];

        private readonly IntPtr EmptyCursor;

#pragma warning disable 414 // Field assigned but never used, we do that on purpose
        private readonly bool xi2_supported;
        private readonly int xi2_opcode;
        private readonly int xi2_version;
#pragma warning restore 414

        // Used to wait for a specific type of event in ProcessEvents.
        // Currently this is just used by ClientSize to wait for a
        // ConfigureNotify event to ensure our size change has actually taken
        // effect, see issue #259.
        private XEventName _waitForEvent = 0;

        public X11GLNative(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
            : this()
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width), "Must be higher than zero.");
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Must be higher than zero.");
            }

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

                var attributes = new XSetWindowAttributes();
                attributes.background_pixel = IntPtr.Zero;
                attributes.border_pixel = IntPtr.Zero;
                attributes.colormap = Functions.XCreateColormap(window.Display, window.RootWindow,
                    window.VisualInfo.Visual, 0 /*AllocNone*/);
                window.EventMask = EventMask.StructureNotifyMask /*| EventMask.SubstructureNotifyMask*/ |
                                   EventMask.ExposureMask |
                                   EventMask.KeyReleaseMask | EventMask.KeyPressMask | EventMask.KeymapStateMask |
                                   EventMask.PointerMotionMask | EventMask.FocusChangeMask |
                                   EventMask.ButtonPressMask | EventMask.ButtonReleaseMask |
                                   EventMask.EnterWindowMask | EventMask.LeaveWindowMask |
                                   EventMask.PropertyChangeMask;
                attributes.event_mask = (IntPtr)window.EventMask;

                var mask =
                    SetWindowValuemask.ColorMap | SetWindowValuemask.EventMask |
                    SetWindowValuemask.BackPixel | SetWindowValuemask.BorderPixel;

                window.Handle = Functions.XCreateWindow(window.Display, window.RootWindow,
                    x, y, width, height, 0, window.VisualInfo.Depth /*(int)CreateWindowArgs.CopyFromParent*/,
                    CreateWindowArgs.InputOutput, window.VisualInfo.Visual, mask, attributes);

                if (window.Handle == IntPtr.Zero)
                {
                    throw new ApplicationException("XCreateWindow call failed (returned 0).");
                }

                if (title != null)
                {
                    Functions.XStoreName(window.Display, window.Handle, title);
                }
            }

            var hints = new XSizeHints();
            hints.base_width = width;
            hints.base_height = height;
            hints.flags = (IntPtr)(XSizeHintsFlags.PSize | XSizeHintsFlags.PPosition);

            var class_hint = new XClassHint();
            var entry_assembly = Assembly.GetEntryAssembly();
            // May not have an entry assembly, try to find a "matching" assembly in the AppDomain
            if (entry_assembly == null)
            {
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly.ManifestModule.Name.Contains(AppDomain.CurrentDomain.FriendlyName))
                    {
                        if (entry_assembly == null || assembly.ManifestModule.Name.Length >
                            entry_assembly.ManifestModule.Name.Length)
                        {
                            entry_assembly = assembly;
                        }
                    }
                }
            }

            var name = "null";
            if (entry_assembly != null)
            {
                name = entry_assembly.GetName().Name;
            }

            class_hint.Class = name;
            class_hint.Name = name.ToLower();

            using (new XLock(window.Display))
            {
                Functions.XSetWMNormalHints(window.Display, window.Handle, ref hints);

                // Register for window destroy notification
                Functions.XSetWMProtocols(window.Display, window.Handle, new[] { _atom_wm_destroy }, 1);

                // Set the window class hints
                Functions.XSetClassHint(window.Display, window.Handle, ref class_hint);
            }

            SetWindowMinMax(_min_width, _min_height, -1, -1);

            // Set the initial window size to ensure X, Y, Width, Height and the rest
            // return the correct values inside the constructor and the Load event.
            var e = new XEvent();
            e.ConfigureEvent.x = x;
            e.ConfigureEvent.y = y;
            e.ConfigureEvent.width = width;
            e.ConfigureEvent.height = height;
            RefreshWindowBounds(ref e);

            EmptyCursor = CreateEmptyCursor(window);

            Debug.WriteLine($"X11GLNative window created successfully (id: {Handle}).");
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

            // Alow window recive Xdnd Events
            var xdndAware = Functions.XInternAtom(window.Display, "XdndAware", false);
            var xdndProtocol = new IntPtr(5);
            using (new XLock(window.Display))
            {
                Functions.XChangeProperty(window.Display, Handle, xdndAware, (IntPtr)AtomName.XA_ATOM, 32,
                    PropertyMode.Replace, ref xdndProtocol, 1);
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
                {
                    throw new Exception("Could not open connection to X");
                }

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

        private void ReadProperty(IntPtr window, IntPtr property, IntPtr type, ref IntPtr data, ref IntPtr itemsCount)
        {
            int format;
            var length = new IntPtr(int.MaxValue);
            IntPtr actualType;
            IntPtr bytesLeft;

            Functions.XGetWindowProperty(this.window.Display, window, property, IntPtr.Zero,
                length, false, type,
                out actualType, out format, out itemsCount, out bytesLeft, ref data);
        }

        private string[] parseUriList(string rawString)
        {
            var separator = new[] { "\r", "\n" };
            var splitted = rawString.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var fileNames = new string[splitted.Length];
            for (var i = 0; i < splitted.Length; i++)
            {
                // Delete starting file://, filename data is URI-encoded
                fileNames[i] = Uri.UnescapeDataString(splitted[i].Substring(7));
            }

            return fileNames;
        }

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
                _atom_net_wm_state_fullscreen =
                    Functions.XInternAtom(window.Display, "_NET_WM_STATE_FULLSCREEN", false);
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

                // Some Xdnd atoms
                _atom_xdnd_enter = Functions.XInternAtom(window.Display, "XdndEnter", false);
                _atom_xdnd_position = Functions.XInternAtom(window.Display, "XdndPosition", false);
                _atom_xdnd_status = Functions.XInternAtom(window.Display, "XdndStatus", false);
                _atom_xdnd_type_list = Functions.XInternAtom(window.Display, "XdndTypeList", false);
                _atom_xdnd_action_copy = Functions.XInternAtom(window.Display, "XdndActionCopy", false);
                _atom_xdnd_drop = Functions.XInternAtom(window.Display, "XdndDrop", false);
                _atom_xdnd_finished = Functions.XInternAtom(window.Display, "XdndFinished", false);
                _atom_xdnd_selection = Functions.XInternAtom(window.Display, "XdndSelection", false);
                _atom_xdnd_leave = Functions.XInternAtom(window.Display, "XdndLeave", false);

                // Selection atoms
                _atom_xdnd_primary = Functions.XInternAtom(window.Display, "PRIMARY", false);
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

        private void SetWindowMinMax(int min_width, int min_height, int max_width, int max_height)
        {
            SetWindowMinMax((short)min_width, (short)min_height, (short)max_width, (short)max_height);
        }

        private void SetWindowMinMax(short min_width, short min_height, short max_width, short max_height)
        {
            IntPtr dummy;
            var hints = new XSizeHints();

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
            {
                hints.flags = (IntPtr)((int)hints.flags & ~(int)XSizeHintsFlags.PMinSize);
            }

            if (max_width > 0 || max_height > 0)
            {
                hints.flags = (IntPtr)((int)hints.flags | (int)XSizeHintsFlags.PMaxSize);
                hints.max_width = max_width;
                hints.max_height = max_height;
            }
            else
            {
                hints.flags = (IntPtr)((int)hints.flags & ~(int)XSizeHintsFlags.PMaxSize);
            }

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

        private bool IsWindowBorderResizable
        {
            get
            {
                using (new XLock(window.Display))
                {
                    var hints = new XSizeHints();
                    IntPtr dummy;
                    if (Functions.XGetWMNormalHints(window.Display, window.Handle, ref hints, out dummy) != 0)
                    {
                        return hints.min_width != hints.max_width || hints.min_height != hints.max_height;
                    }
                }

                return false;
            }
        }


        private bool IsWindowBorderHidden
        {
            get
            {
                using (new XLock(window.Display))
                {
                    // Test if decorations have been disabled through Motif.
                    var motif_hints_atom = Functions.XInternAtom(window.Display, MOTIF_WM_ATOM, true);
                    if (motif_hints_atom != IntPtr.Zero)
                    {
                        // TODO: How to check if MotifWMHints decorations have been really disabled?
                        if (_decorations_hidden)
                        {
                            return true;
                        }
                    }

                    // Some WMs remove decorations when the transient_for hint is set. Most new ones do not (but those
                    // should obey the Motif hint). Anyway, if this hint is set, we say the decorations have been remove
                    // although there is a slight chance this is not the case.
                    IntPtr transient_for_parent;
                    Functions.XGetTransientForHint(window.Display, window.Handle, out transient_for_parent);
                    if (transient_for_parent != IntPtr.Zero)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }


        private void DisableWindowDecorations()
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
                Functions.XSetTransientForHint(window.Display, Handle, window.RootWindow);

                if (_decorations_hidden)
                {
                    Functions.XUnmapWindow(window.Display, Handle);
                    Functions.XMapWindow(window.Display, Handle);
                }
            }
        }


        private bool DisableMotifDecorations()
        {
            using (new XLock(window.Display))
            {
                var atom = Functions.XInternAtom(window.Display, MOTIF_WM_ATOM, true);
                if (atom != IntPtr.Zero)
                {
                    //Functions.XGetWindowProperty(window.Display, window.Handle, atom, IntPtr.Zero, IntPtr.Zero, false,

                    var hints = new MotifWmHints();
                    hints.flags = (IntPtr)MotifFlags.Decorations;
                    Functions.XChangeProperty(window.Display, Handle, atom, atom, 32, PropertyMode.Replace,
                        ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                    return true;
                }

                return false;
            }
        }

        private bool DisableGnomeDecorations()
        {
            using (new XLock(window.Display))
            {
                var atom = Functions.XInternAtom(window.Display, Constants.XA_WIN_HINTS, true);
                if (atom != IntPtr.Zero)
                {
                    var hints = IntPtr.Zero;
                    Functions.XChangeProperty(window.Display, Handle, atom, atom, 32, PropertyMode.Replace,
                        ref hints, Marshal.SizeOf(hints) / IntPtr.Size);
                    return true;
                }

                return false;
            }
        }

        private void EnableWindowDecorations()
        {
            if (EnableMotifDecorations())
            {
                Debug.Print("Activated decorations through motif.");
                _decorations_hidden = false;
            }

            //if (EnableGnomeDecorations()) { Debug.Print("Activated decorations through gnome."); activated = true; }

            using (new XLock(window.Display))
            {
                Functions.XSetTransientForHint(window.Display, Handle, IntPtr.Zero);

                if (!_decorations_hidden)
                {
                    Functions.XUnmapWindow(window.Display, Handle);
                    Functions.XMapWindow(window.Display, Handle);
                }
            }
        }

        private bool EnableMotifDecorations()
        {
            using (new XLock(window.Display))
            {
                var atom = Functions.XInternAtom(window.Display, MOTIF_WM_ATOM, true);
                if (atom != IntPtr.Zero)
                {
                    //Functions.XDeleteProperty(this.window.Display, this.Handle, atom);
                    var hints = new MotifWmHints();
                    hints.flags = (IntPtr)MotifFlags.Decorations;
                    hints.decorations = (IntPtr)MotifDecorations.All;
                    Functions.XChangeProperty(window.Display, Handle, atom, atom, 32, PropertyMode.Replace,
                        ref hints, Marshal.SizeOf(hints) / IntPtr.Size);

                    return true;
                }

                return false;
            }
        }

        private bool EnableGnomeDecorations()
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

                var atom = Functions.XInternAtom(window.Display, Constants.XA_WIN_HINTS, true);
                if (atom != IntPtr.Zero)
                {
                    Functions.XDeleteProperty(window.Display, Handle, atom);
                    return true;
                }

                return false;
            }
        }

        private static void DeleteIconPixmaps(IntPtr display, IntPtr window)
        {
            using (new XLock(display))
            {
                var wmHints_ptr = Functions.XGetWMHints(display, window);

                if (wmHints_ptr != IntPtr.Zero)
                {
                    var wmHints = (XWMHints)Marshal.PtrToStructure(wmHints_ptr, typeof(XWMHints));
                    var flags = (XWMHintsFlags)wmHints.flags.ToInt32();

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

        private bool RefreshWindowBorders()
        {
            var borders_changed = false;

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

                if (prop != IntPtr.Zero)
                {
                    if ((long)nitems == 4)
                    {
                        var new_border_left = Marshal.ReadIntPtr(prop, 0).ToInt32();
                        var new_border_right = Marshal.ReadIntPtr(prop, IntPtr.Size).ToInt32();
                        var new_border_top = Marshal.ReadIntPtr(prop, IntPtr.Size * 2).ToInt32();
                        var new_border_bottom = Marshal.ReadIntPtr(prop, IntPtr.Size * 3).ToInt32();

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

        private void RefreshWindowBounds(ref XEvent e)
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

            var new_location = new Point(
                x - border_left,
                y - border_top);

            if (Location != new_location)
            {
                bounds.Location = new_location;
                OnMove(EventArgs.Empty);
            }

            // Note: width and height denote the internal (client) size.
            // To get the external (window) size, we need to add the border size.
            var new_size = new Size(
                e.ConfigureEvent.width + border_left + border_right,
                e.ConfigureEvent.height + border_top + border_bottom);
            if (Bounds.Size != new_size)
            {
                bounds.Size = new_size;

                // X11 sets the client width/height to 0
                // when the window is minimized. Many apps
                // do not expect this and crash, so clamp
                // minimum width/height to 1 instead.
                client_size = new Size(
                    Math.Max(e.ConfigureEvent.width, 1),
                    Math.Max(e.ConfigureEvent.height, 1));
                OnResize(EventArgs.Empty);
            }

            //Debug.Print("[X11] Window bounds changed: {0}", bounds);
        }

        private static IntPtr CreateEmptyCursor(X11WindowInfo window)
        {
            var cursor = IntPtr.Zero;
            using (new XLock(window.Display))
            {
                XColor black, dummy;
                var cmap = Functions.XDefaultColormap(window.Display, window.Screen);
                Functions.XAllocNamedColor(window.Display, cmap, "black", out black, out dummy);
                var bmp_empty = Functions.XCreateBitmapFromData(window.Display,
                    window.Handle, new byte[,] { { 0 } });
                cursor = Functions.XCreatePixmapCursor(window.Display,
                    bmp_empty, bmp_empty, ref black, ref black, 0, 0);
            }

            return cursor;
        }

        public override void ProcessEvents()
        {
            base.ProcessEvents();
            // Process all pending events
            while (Exists && window != null)
            {
                using (new XLock(window.Display))
                {
                    if (!Functions.XCheckWindowEvent(window.Display, window.Handle, window.EventMask, ref e) &&
                        !Functions.XCheckTypedWindowEvent(window.Display, window.Handle, XEventName.ClientMessage,
                            ref e) &&
                        !Functions.XCheckTypedWindowEvent(window.Display, window.Handle, XEventName.SelectionNotify,
                            ref e))
                    {
                        if (_waitForEvent != 0)
                        {
                            continue;
                        }

                        break;
                    }
                }

                if (_waitForEvent == e.type)
                {
                    _waitForEvent = 0;
                }

                // Respond to the event e
                switch (e.type)
                {
                    case XEventName.MapNotify:
                    {
                        var previous_visible = visible;
                        visible = true;
                        if (visible != previous_visible)
                        {
                            OnVisibleChanged(EventArgs.Empty);
                        }

                        return;
                    }
                    case XEventName.UnmapNotify:
                    {
                        var previous_visible = visible;
                        visible = false;
                        if (visible != previous_visible)
                        {
                            OnVisibleChanged(EventArgs.Empty);
                        }

                        break;
                    }
                    case XEventName.CreateNotify:
                    {
                        // A child was was created - nothing to do
                        break;
                    }
                    case XEventName.ClientMessage:
                    {
                        if (!isExiting && e.ClientMessageEvent.ptr1 == _atom_wm_destroy)
                        {
                            Debug.Print("[X11] Exit message received for window {0:X} on display {1:X}", window.Handle,
                                window.Display);
                            var ce = new CancelEventArgs();
                            OnClosing(ce);

                            if (!ce.Cancel)
                            {
                                isExiting = true;
                                DestroyWindow();
                                OnClosed(EventArgs.Empty);
                            }
                        }
                        // For X11 drag and drop handling use https://freedesktop.org/wiki/Specifications/XDND/#index9h2
                        else if (e.ClientMessageEvent.message_type == _atom_xdnd_enter)
                        {
                            // Xdnd started
                            // ptr1 -> source window handler
                            // ptr2 bit 0 -> set to 1 if source support more than three data formats
                            // ptr2 third byte contains Xdnd version that source supports
                            var useList = (e.ClientMessageEvent.ptr2.ToInt64() & 1) == 1;
                            sourceHandler = e.ClientMessageEvent.ptr1;
                            sourceXdndVersion = e.ClientMessageEvent.ptr2.ToInt64() >> 24;

                            var formats = IntPtr.Zero;
                            int formatCount;
                            if (useList)
                            {
                                var count = IntPtr.Zero;
                                ReadProperty(sourceHandler, _atom_xdnd_type_list, (IntPtr)AtomName.XA_ATOM,
                                    ref formats, ref count);
                                formatCount = count.ToInt32();
                            }
                            else
                            {
                                formats = Marshal.AllocHGlobal(3 * IntPtr.Size);
                                Marshal.WriteIntPtr(formats, IntPtr.Size * 0, e.ClientMessageEvent.ptr3);
                                Marshal.WriteIntPtr(formats, IntPtr.Size * 1, e.ClientMessageEvent.ptr4);
                                Marshal.WriteIntPtr(formats, IntPtr.Size * 2, e.ClientMessageEvent.ptr5);
                                formatCount = 3;
                            }

                            xdndFormat = Consts.None;
                            for (var i = 0; i < formatCount && xdndFormat == Consts.None; ++i)
                            {
                                var tempAtom = Marshal.ReadIntPtr(formats, IntPtr.Size * i);
                                var atomName = Functions.XGetAtomName(window.Display, tempAtom);

                                var str = Marshal.PtrToStringAnsi(atomName);
                                if (str == "text/uri-list")
                                {
                                    xdndFormat = tempAtom;
                                }

                                Functions.XFree(atomName);
                            }

                            if (useList && formats != IntPtr.Zero)
                            {
                                Functions.XFree(formats);
                            }
                            else
                            {
                                Marshal.FreeHGlobal(formats);
                            }
                        }
                        else if (e.ClientMessageEvent.message_type == _atom_xdnd_position)
                        {
                            var reply = new XEvent();

                            reply.ClientMessageEvent.type = XEventName.ClientMessage;
                            reply.ClientMessageEvent.display = window.Display;
                            reply.ClientMessageEvent.window = sourceHandler;
                            reply.ClientMessageEvent.message_type = _atom_xdnd_status;
                            reply.ClientMessageEvent.format = 32;
                            reply.ClientMessageEvent.ptr1 = window.Handle;
                            if (xdndFormat != Consts.None)
                            {
                                reply.ClientMessageEvent.ptr2 = (IntPtr)1;
                            }
                            else
                            {
                                reply.ClientMessageEvent.ptr2 = (IntPtr)0;
                            }

                            reply.ClientMessageEvent.ptr3 = (IntPtr)0;
                            reply.ClientMessageEvent.ptr4 = (IntPtr)0;
                            reply.ClientMessageEvent.ptr5 = _atom_xdnd_action_copy;

                            Functions.XSendEvent(window.Display, sourceHandler, false, (IntPtr)EventMask.NoEventMask,
                                ref reply);
                            Functions.XFlush(window.Display);
                        }
                        else if (e.ClientMessageEvent.message_type == _atom_xdnd_drop)
                        {
                            if (xdndFormat == Consts.None)
                            {
                                var reply = new XEvent();

                                reply.ClientMessageEvent.type = XEventName.ClientMessage;
                                reply.ClientMessageEvent.display = window.Display;
                                reply.ClientMessageEvent.window = sourceHandler;
                                reply.ClientMessageEvent.message_type = _atom_xdnd_finished;
                                reply.ClientMessageEvent.format = 32;
                                reply.ClientMessageEvent.ptr1 = window.Handle;
                                reply.ClientMessageEvent.ptr2 = (IntPtr)0;
                                reply.ClientMessageEvent.ptr3 = Consts.None;

                                Functions.XSendEvent(window.Display, sourceHandler, false,
                                    (IntPtr)EventMask.NoEventMask, ref reply);
                                Functions.XFlush(window.Display);
                            }
                            else
                            {
                                if (sourceXdndVersion >= 1)
                                {
                                    Functions.XConvertSelection(window.Display, _atom_xdnd_selection, xdndFormat,
                                        _atom_xdnd_primary, window.Handle, e.ClientMessageEvent.ptr3);
                                }
                                else
                                {
                                    Functions.XConvertSelection(window.Display, _atom_xdnd_selection, xdndFormat,
                                        _atom_xdnd_primary, window.Handle, Consts.CurrentTime);
                                }
                            }
                        }
                        else if (e.ClientMessageEvent.message_type == _atom_xdnd_leave)
                        {
                        }

                        break;
                    }
                    case XEventName.DestroyNotify:
                    {
                        Debug.WriteLine("Window destroyed");
                        exists = false;
                        return;
                    }
                    case XEventName.ConfigureNotify:
                    {
                        RefreshWindowBounds(ref e);
                        break;
                    }
                    case XEventName.KeyPress:
                    case XEventName.KeyRelease:
                    {
                        var pressed = e.type == XEventName.KeyPress;
                        Key key;
                        if (KeyMap.TranslateKey(ref e.KeyEvent, out key))
                        {
                            if (pressed)
                            {
                                // Raise KeyDown event
                                var is_repeat = KeyboardState[key];
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
                                var status = 0;
                                status = Functions.XLookupString(
                                    ref e.KeyEvent, ascii, ascii.Length, null, IntPtr.Zero);
                                Encoding.Default.GetChars(ascii, 0, status, chars, 0);

                                for (var i = 0; i < status; i++)
                                {
                                    if (!char.IsControl(chars[i]))
                                    {
                                        OnKeyPress(chars[i]);
                                    }
                                }
                            }
                        }

                        break;
                    }
                    case XEventName.MotionNotify:
                    {
                        var x = e.MotionEvent.x;
                        var y = e.MotionEvent.y;

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
                        var button = X11KeyMap.TranslateButton(e.ButtonEvent.button, out dx, out dy);

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
                            var state = Mouse.GetCursorState();
                            dx = state.Scroll.X - MouseState.Scroll.X;
                            dy = state.Scroll.Y - MouseState.Scroll.Y;
                        }

                        if (dx != 0 || dy != 0)
                        {
                            // High resolution scroll events not supported
                            // fallback to the old Button4-7 scroll buttons
                            OnMouseWheel(dx, dy);
                        }

                        break;
                    }
                    case XEventName.ButtonRelease:
                    {
                        float dx, dy;
                        var button = X11KeyMap.TranslateButton(e.ButtonEvent.button, out dx, out dy);
                        if (button != MouseButton.LastButton)
                        {
                            OnMouseUp(button);
                        }

                        break;
                    }
                    case XEventName.FocusIn:
                    {
                        var previous_focus = has_focus;
                        has_focus = true;
                        if (has_focus != previous_focus)
                        {
                            OnFocusedChanged(EventArgs.Empty);
                        }

                        if (Focused && !CursorVisible)
                        {
                            GrabMouse();
                        }

                        break;
                    }
                    case XEventName.FocusOut:
                    {
                        var previous_focus = has_focus;
                        has_focus = false;
                        if (has_focus != previous_focus)
                        {
                            OnFocusedChanged(EventArgs.Empty);
                        }

                        break;
                    }
                    case XEventName.LeaveNotify:
                    {
                        if (CursorVisible)
                        {
                            var x = MathHelper.Clamp(e.CrossingEvent.x, 0, Width);
                            var y = MathHelper.Clamp(e.CrossingEvent.y, 0, Height);
                            if (x != MouseState.X || y != MouseState.Y)
                            {
                                OnMouseMove(x, y);
                            }

                            OnMouseLeave(EventArgs.Empty);
                        }

                        break;
                    }
                    case XEventName.EnterNotify:
                    {
                        OnMouseEnter(EventArgs.Empty);
                        break;
                    }
                    case XEventName.MappingNotify:
                    {
                        // 0 == MappingModifier, 1 == MappingKeyboard
                        if (e.MappingEvent.request == 0 || e.MappingEvent.request == 1)
                        {
                            Debug.Print("keybard mapping refreshed");
                            Functions.XRefreshKeyboardMapping(ref e.MappingEvent);
                            KeyMap.RefreshKeycodes(window.Display);
                        }

                        break;
                    }
                    case XEventName.PropertyNotify:
                    {
                        if (e.PropertyEvent.atom == _atom_net_wm_state)
                        {
                            OnWindowStateChanged(EventArgs.Empty);
                        }

                        //if (e.PropertyEvent.atom == _atom_net_frame_extents)
                        //{
                        //    RefreshWindowBorders();
                        //}
                        break;
                    }
                    case XEventName.SelectionNotify:
                    {
                        if (e.SelectionEvent.property == _atom_xdnd_primary)
                        {
                            var data = IntPtr.Zero;
                            var count = IntPtr.Zero;
                            ReadProperty(e.SelectionEvent.requestor, e.SelectionEvent.property, e.SelectionEvent.target,
                                ref data, ref count);

                            var rawString = Marshal.PtrToStringAnsi(data);
                            Functions.XFree(data);
                            var fileNames = parseUriList(rawString);

                            for (var i = 0; i < fileNames.Length; i++)
                            {
                                OnFileDrop(fileNames[i]);
                            }

                            var reply = new XEvent();

                            reply.ClientMessageEvent.type = XEventName.ClientMessage;
                            reply.ClientMessageEvent.display = window.Display;
                            reply.ClientMessageEvent.window = sourceHandler;
                            reply.ClientMessageEvent.message_type = _atom_xdnd_finished;
                            reply.ClientMessageEvent.format = 32;
                            reply.ClientMessageEvent.ptr1 = window.Handle;
                            reply.ClientMessageEvent.ptr2 = (IntPtr)1;
                            reply.ClientMessageEvent.ptr3 = _atom_xdnd_action_copy;

                            Functions.XSendEvent(window.Display, e.ClientMessageEvent.ptr1, false,
                                (IntPtr)EventMask.NoEventMask, ref reply);
                        }

                        break;
                    }
                }
            }
        }

        public override Rectangle Bounds
        {
            get => bounds;
            set
            {
                var is_location_changed = bounds.Location != value.Location;
                var is_size_changed = bounds.Size != value.Size;

                var x = value.X;
                var y = value.Y;
                var width = value.Width - border_left - border_right;
                var height = value.Height - border_top - border_bottom;

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

                _waitForEvent = XEventName.ConfigureNotify;
                ProcessEvents();
            }
        }

        public override Size ClientSize
        {
            get => client_size;
            set
            {
                var is_size_changed = client_size != value;
                if (is_size_changed)
                {
                    var width = value.Width;
                    var height = value.Height;

                    if (WindowBorder != WindowBorder.Resizable)
                    {
                        SetWindowMinMax(width, height, width, height);
                    }

                    using (new XLock(window.Display))
                    {
                        Functions.XResizeWindow(window.Display, window.Handle,
                            width, height);
                    }

                    _waitForEvent = XEventName.ConfigureNotify;
                    ProcessEvents();
                }
            }
        }

        public override Icon Icon
        {
            get => icon;
            set
            {
                if (value == icon)
                {
                    return;
                }

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
                    var bitmap = value.ToBitmap();
                    var size = bitmap.Width * bitmap.Height + 2;
                    var data = new IntPtr[size];
                    var index = 0;

                    data[index++] = (IntPtr)bitmap.Width;
                    data[index++] = (IntPtr)bitmap.Height;

                    for (var y = 0; y < bitmap.Height; y++)
                    for (var x = 0; x < bitmap.Width; x++)
                    {
                        data[index++] = (IntPtr)bitmap.GetPixel(x, y).ToArgb();
                    }

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
                        var wmHints_ptr = Functions.XGetWMHints(window.Display, window.Handle);

                        if (wmHints_ptr == IntPtr.Zero)
                        {
                            wmHints_ptr = Functions.XAllocWMHints();
                        }

                        var wmHints = (XWMHints)Marshal.PtrToStructure(wmHints_ptr, typeof(XWMHints));

                        wmHints.flags = new IntPtr(wmHints.flags.ToInt32() |
                                                   (int)(XWMHintsFlags.IconPixmapHint | XWMHintsFlags.IconMaskHint));
                        wmHints.icon_pixmap = Functions.CreatePixmapFromImage(window.Display, bitmap);
                        wmHints.icon_mask = Functions.CreateMaskFromImage(window.Display, bitmap);

                        Functions.XSetWMHints(window.Display, window.Handle, ref wmHints);
                        Functions.XFree(wmHints_ptr);

                        Functions.XSync(window.Display, false);
                    }
                }

                icon = value;
                OnIconChanged(EventArgs.Empty);
            }
        }

        public override bool Focused => has_focus;

        public override OpenTK.WindowState WindowState
        {
            get
            {
                IntPtr actual_atom;
                int actual_format;
                IntPtr nitems;
                IntPtr bytes_after;
                var prop = IntPtr.Zero;
                IntPtr atom;
                //XWindowAttributes attributes;
                var fullscreen = false;
                var maximized = 0;
                var minimized = false;

                using (new XLock(window.Display))
                {
                    Functions.XGetWindowProperty(window.Display, window.Handle,
                        _atom_net_wm_state, IntPtr.Zero, new IntPtr(256), false,
                        new IntPtr(4) /*XA_ATOM*/, out actual_atom, out actual_format,
                        out nitems, out bytes_after, ref prop);
                }

                if ((long)nitems > 0 && prop != IntPtr.Zero)
                {
                    for (var i = 0; i < (long)nitems; i++)
                    {
                        atom = Marshal.ReadIntPtr(prop, i * IntPtr.Size);

                        if (atom == _atom_net_wm_state_maximized_horizontal ||
                            atom == _atom_net_wm_state_maximized_vertical)
                        {
                            maximized++;
                        }
                        else if (atom == _atom_net_wm_state_minimized)
                        {
                            minimized = true;
                        }
                        else if (atom == _atom_net_wm_state_fullscreen)
                        {
                            fullscreen = true;
                        }
                    }

                    using (new XLock(window.Display))
                    {
                        Functions.XFree(prop);
                    }
                }

                if (minimized)
                {
                    return OpenTK.WindowState.Minimized;
                }

                if (maximized == 2)
                {
                    return OpenTK.WindowState.Maximized;
                }

                if (fullscreen)
                {
                    return OpenTK.WindowState.Fullscreen;
                }

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
                var current_state = WindowState;

                // When switching away from normal state, store
                // the "normal" border and size. These will be used
                // for restoring to normal state.
                if (current_state == OpenTK.WindowState.Normal)
                {
                    _previous_window_border = WindowBorder;
                    _previous_window_size = ClientSize;
                }

                if (current_state == value)
                {
                    return;
                }

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

                _previous_window_state = value == OpenTK.WindowState.Fullscreen
                    ? OpenTK.WindowState.Fullscreen
                    : OpenTK.WindowState.Normal;
            }
        }

        private void ResetWindowState(OpenTK.WindowState current_state)
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

        private void ChangeWindowState(OpenTK.WindowState value)
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

        public override WindowBorder WindowBorder
        {
            get
            {
                if (IsWindowBorderHidden || WindowState == OpenTK.WindowState.Fullscreen)
                {
                    return WindowBorder.Hidden;
                }

                if (!IsWindowBorderResizable)
                {
                    return WindowBorder.Fixed;
                }

                if (WindowState == OpenTK.WindowState.Maximized)
                {
                    return _previous_window_border;
                }

                return WindowBorder.Resizable;
            }
            set
            {
                if (WindowBorder == value)
                {
                    return;
                }

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

        private void ChangeWindowBorder(WindowBorder value)
        {
            ChangeWindowBorder(value, Width, Height);
        }

        private void ChangeWindowBorder(WindowBorder value, int width, int height)
        {
            if (WindowBorder == WindowBorder.Hidden)
            {
                EnableWindowDecorations();
            }

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

        public override MouseCursor Cursor
        {
            get => cursor;
            set
            {
                unsafe
                {
                    if (value == cursor)
                    {
                        return;
                    }

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
                            fixed (byte* pixels = value.Data)
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

        public override bool CursorVisible
        {
            get => cursor_visible;
            set
            {
                if (value == cursor_visible)
                {
                    return;
                }

                using (new XLock(window.Display))
                {
                    if (value)
                    {
                        UngrabMouse();

                        var p = PointToScreen(new Point(MouseState.X, MouseState.Y));
                        Mouse.SetPosition(p.X, p.Y);

                        // Note: if cursorHandle = IntPtr.Zero, this restores the default cursor
                        // (equivalent to calling XUndefineCursor)
                        Functions.XDefineCursor(window.Display, window.Handle, cursorHandle);
                    }
                    else
                    {
                        GrabMouse();
                    }

                    cursor_visible = value;
                }
            }
        }

        private void GrabMouse()
        {
            Functions.XGrabPointer(window.Display, window.Handle, false,
                EventMask.PointerMotionMask | EventMask.ButtonPressMask |
                EventMask.ButtonReleaseMask,
                GrabMode.GrabModeAsync, GrabMode.GrabModeAsync,
                window.Handle, EmptyCursor, IntPtr.Zero);
        }

        private void UngrabMouse()
        {
            Functions.XUngrabPointer(window.Display, IntPtr.Zero);
        }

        /// <summary>
        /// Returns true if a render window/context exists.
        /// </summary>
        public override bool Exists => exists;

        public bool IsIdle => throw new Exception("The method or operation is not implemented.");

        /// <summary>
        /// Gets the current window handle.
        /// </summary>
        public IntPtr Handle => window.Handle;

        /// <summary>
        /// TODO: Use atoms for this property.
        /// Gets or sets the GameWindow title.
        /// </summary>
        public override string Title
        {
            get
            {
                var name = IntPtr.Zero;
                using (new XLock(window.Display))
                {
                    Functions.XFetchName(window.Display, window.Handle, ref name);
                }

                if (name != IntPtr.Zero)
                {
                    return Marshal.PtrToStringAnsi(name);
                }

                return string.Empty;
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

        public override bool Visible
        {
            get => visible;
            set
            {
                if (value && !visible)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XMapWindow(window.Display, window.Handle);
                    }

                    WindowState = _previous_window_state;
                }
                else if (!value && visible)
                {
                    using (new XLock(window.Display))
                    {
                        Functions.XUnmapWindow(window.Display, window.Handle);
                    }

                    _previous_window_state = WindowState == OpenTK.WindowState.Fullscreen
                        ? OpenTK.WindowState.Fullscreen
                        : OpenTK.WindowState.Normal;
                }
            }
        }

        public override IWindowInfo WindowInfo => window;

        public override void Close()
        {
            Exit();
        }

        public void Exit()
        {
            Debug.Print("[X11] Sending exit message window {0:X} on display {1:X}", window.Handle, window.Display);

            var ev = new XEvent();
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

        public override Point PointToClient(Point point)
        {
            int ox, oy;
            IntPtr child;

            using (new XLock(window.Display))
            {
                Functions.XTranslateCoordinates(window.Display, window.RootWindow, window.Handle, point.X, point.Y,
                    out ox, out oy, out child);
            }

            point.X = ox;
            point.Y = oy;

            return point;
        }

        public override Point PointToScreen(Point point)
        {
            int ox, oy;
            IntPtr child;

            using (new XLock(window.Display))
            {
                Functions.XTranslateCoordinates(window.Display, window.Handle, window.RootWindow, point.X, point.Y,
                    out ox, out oy, out child);
            }

            point.X = ox;
            point.Y = oy;

            return point;
        }

        protected override void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                if (manuallyCalled)
                {
                    if (window != null && window.Handle != IntPtr.Zero)
                    {
                        Functions.XFreeCursor(window.Display, EmptyCursor);
                        if (cursorHandle != IntPtr.Zero)
                        {
                            Functions.XFreeCursor(window.Display, cursorHandle);
                        }

                        if (Exists)
                        {
                            DestroyWindow();
                        }

                        if (window.Display != IntPtr.Zero)
                        {
                            Functions.XCloseDisplay(window.Display);
                        }

                        window.Dispose();
                    }
                }
                else
                {
                    Debug.Print("[Warning] {0} leaked.", GetType().Name);
                }

                disposed = true;
            }
        }
    }
}
