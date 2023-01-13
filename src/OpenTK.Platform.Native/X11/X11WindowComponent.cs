using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.GLX;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public class X11WindowComponent : IWindowComponent
    {
        public string Name => nameof(X11WindowComponent);

        public PalComponents Provides => PalComponents.Window;

        public ILogger? Logger { get; set; }

        private unsafe XErrorHandler ErrorHandler;

        private unsafe int XErrorHandler(XDisplayPtr display, XErrorEvent* error_event)
        {
            Console.WriteLine($"{error_event->type} error! S: {error_event->serial} Error code: {error_event->error_code}, Request code: {error_event->request_code}, Minor code: {error_event->minor_code}");

            StringBuilder errorMessage = new StringBuilder(1024);
            XGetErrorText(X11.Display, (int)error_event->error_code, errorMessage, errorMessage.Capacity);

            byte* data = (byte*)error_event;

            Console.WriteLine($"Error: {errorMessage}");

            return (int)error_event->error_code;
        }

        internal static readonly Dictionary<XWindow, XWindowHandle> XWindowDict = new Dictionary<XWindow, XWindowHandle>();

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            // Later on we can replace this with a hint.
            string? displayName = null;
            X11.Display = XOpenDisplay(displayName);

            if (X11.Display.Value == IntPtr.Zero)
            {
                throw new PalException(this, (displayName is null) ? "Could not open default X display." : $"Could not open X display {displayName}.");
            }

            unsafe
            {
                ErrorHandler = XErrorHandler;
                XSetErrorHandler(ErrorHandler);
            }

            X11.DefaultScreen = XDefaultScreen(X11.Display);
            X11.DefaultRootWindow = XDefaultRootWindow(X11.Display);

            X11.Atoms = new XAtomDictionary(X11.Display);

            Logger?.LogInfo($"Known Atoms ({X11.Atoms.Count}) {string.Join(" ", X11.Atoms.Where(kvp => kvp.Value.IsNone == false).Select(kvp => kvp.Key))}");

            // Check if the window manager is freedesktop compliant.
            // https://specifications.freedesktop.org/wm-spec/wm-spec-1.4.html
            // The Window Manager MUST set this property on the root window to be
            // the ID of a child window created by himself, to indicate that a
            // compliant window manager is active. The child window MUST also have
            // the _NET_SUPPORTING_WM_CHECK property set to the ID of the child window.
            // The child window MUST also have the _NET_WM_NAME property set to the
            // name of the Window Manager.

            XWindow wm_window;
            XAtom _net_supported = X11.Atoms![KnownAtoms._NET_SUPPORTED];
            XAtom _net_supporting_wm_check = X11.Atoms[KnownAtoms._NET_SUPPORTING_WM_CHECK];
            XAtom _net_wm_name = X11.Atoms[KnownAtoms._NET_WM_NAME];
            XAtom atom = X11.Atoms[KnownAtoms.ATOM];
            XAtom utf8_string = X11.Atoms[KnownAtoms.UTF8_STRING];
            XAtom window = X11.Atoms[KnownAtoms.WINDOW];
            IntPtr array;
            long count;

            XGetWindowProperty(X11.Display, X11.DefaultRootWindow, _net_supporting_wm_check, 0, 8, false, window, out _, out _, out count, out _, out array);

            if (count > 0)
            {
                wm_window = Marshal.PtrToStructure<XWindow>(array);
                XFree(array);

                XGetWindowProperty(X11.Display, wm_window, _net_supporting_wm_check, 0, 8, false, window, out _, out _, out count, out _, out array);
                if (count > 0 && wm_window.Id == Marshal.PtrToStructure<XWindow>(array).Id)
                {
                    IsWindowManagerFreedesktop = true;
                    XFree(array);
                    XGetWindowProperty(
                        X11.Display,
                        wm_window,
                        _net_wm_name,
                        0,
                        long.MaxValue,   // FIXME: Is this worth two rountrips to measure name size and then read?
                        false,
                        utf8_string,
                        out _,
                        out _,
                        out count,
                        out _,
                        out array);

                    if (count > 0)
                    {
                        FreedesktopWindowManagerName = Marshal.PtrToStringUTF8(array);
                    }

                    XFree(array);
                }
                else
                {
                    XFree(array);
                }
            }
            else
            {
                XFree(array);
            }

            if (IsWindowManagerFreedesktop)
            {
                Logger?.LogInfo($"Found Freedesktop Compliant Window Manager {FreedesktopWindowManagerName}.");

                // Find which window styles and modes are supported.
                HashSet<XAtom> supportedAtoms = new HashSet<XAtom>();

                XGetWindowProperty(X11.Display, X11.DefaultRootWindow, _net_supported, 0, long.MaxValue, false, atom, out _, out _, out count, out _, out array);
                for (int i = 0; i < count; i++)
                {
                    supportedAtoms.Add(Marshal.PtrToStructure<XAtom>(array + Unsafe.SizeOf<XAtom>() * i));
                }

                // TODO: Figure how to extract win32 like window types and modes from the supported atoms list.

                XFree(array);
            }
        }

        public bool CanSetIcon => false;
        public bool CanGetDisplay => false;
        public bool CanSetCursor => false;

        private static List<WindowStyle> s_emptyStyleList = new List<WindowStyle>();
        private static List<WindowMode> s_emptyModeList = new List<WindowMode>();

        public IReadOnlyList<PlatformEventType> SupportedEvents { get => throw new NotImplementedException(); }
        public IReadOnlyList<WindowStyle> SupportedStyles { get; private set; } = s_emptyStyleList;
        public IReadOnlyList<WindowMode> SupportedModes { get; private set; } = s_emptyModeList;

        /// <summary>
        /// When true, indicates the current window manager is Freedesktop compliant.
        /// </summary>
        public bool IsWindowManagerFreedesktop { get; private set; } = false;
        public string? FreedesktopWindowManagerName { get; private set; } = null;

        internal WMState GetNETWMState(XWindow window)
        {
            WMState state = default;

            int result = XGetWindowProperty(
                                    X11.Display,
                                    window,
                                    X11.Atoms[KnownAtoms._NET_WM_STATE],
                                    0, 1024,
                                    false,
                                    X11.Atoms[KnownAtoms.ATOM],
                                    out XAtom actualType,
                                    out int actualFormat,
                                    out long numberOfItems,
                                    out long remainingBytes,
                                    out IntPtr contents);

            if (result == 0)
            {
                unsafe
                {
                    XAtom* atoms = (XAtom*)contents;

                    // The order of these need to correspond to the order in WMState
                    Span<KnownAtoms> stateAtoms = stackalloc KnownAtoms[]
                    {
                        KnownAtoms._NET_WM_STATE_MODAL,
                        KnownAtoms._NET_WM_STATE_STICKY,
                        KnownAtoms._NET_WM_STATE_MAXIMIZED_VERT,
                        KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ,
                        KnownAtoms._NET_WM_STATE_SHADED,
                        KnownAtoms._NET_WM_STATE_SKIP_TASKBAR,
                        KnownAtoms._NET_WM_STATE_SKIP_PAGER,
                        KnownAtoms._NET_WM_STATE_HIDDEN,
                        KnownAtoms._NET_WM_STATE_FULLSCREEN,
                        KnownAtoms._NET_WM_STATE_ABOVE,
                        KnownAtoms._NET_WM_STATE_BELOW,
                        KnownAtoms._NET_WM_STATE_DEMANDS_ATTENTION,
                        KnownAtoms._NET_WM_STATE_FOCUSED,
                    };

                    for (int i = 0; i < numberOfItems; i++)
                    {
                        XAtom atom = atoms[i];
                        for (int j = 0; j < stateAtoms.Length; j++)
                        {
                            if (atom == X11.Atoms[stateAtoms[j]])
                            {
                                state |= (WMState)(1 << j);
                            }
                        }
                    }
                }
            }

            if (contents != IntPtr.Zero)
            {
                XFree(contents);
            }

            return state;
        }

        public void ProcessEvents(bool waitForEvents = false)
        {
            // FIXME: waitForEvents!

            XEvent ea = new XEvent();
            while (XEventsQueued(X11.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
            {
                XNextEvent(X11.Display, out ea);
                //Debug.Print(ea.Type.ToString());

                switch (ea.Type)
                {
                    case XEventType.ClientMessage:
                        {
                            XClientMessageEvent clientMessage = ea.ClientMessage;

                            unsafe
                            {
                                if (clientMessage.Format == 32 && clientMessage.l[0] == (long)X11.Atoms[KnownAtoms.WM_DELETE_WINDOW].Id)
                                {
                                    XWindowHandle xwindow = XWindowDict[clientMessage.Window];

                                    EventQueue.Raise(xwindow, PlatformEventType.Close, new CloseEventArgs(xwindow));
                                }
                            }

                            break;
                        }
                    case XEventType.ButtonPress:
                        {
                            XButtonEvent buttonPressed = ea.ButtonPressed;

                            XWindowHandle xwindow = XWindowDict[buttonPressed.window];

                            // Buttons 4 to 7 are used for scroll.
                            if (buttonPressed.button >= 4 && buttonPressed.button <= 7)
                            {
                                int xdelta = 0;
                                int ydelta = 0;
                                switch (buttonPressed.button)
                                {
                                    case 4: ydelta = 1; break; // up
                                    case 5: ydelta = -1; break; // down
                                    case 6: xdelta = -1; break; // left
                                    case 7: xdelta = 1; break; // right
                                    default: throw new Exception("This should never happen.");
                                }

                                // FIXME: Scrolling distance? Are there scrolling settings on linux/x11?
                                EventQueue.Raise(xwindow, PlatformEventType.Scroll, new ScrollEventArgs((xdelta, ydelta), (xdelta, ydelta)));
                            }
                            else
                            {
                                if (buttonPressed.button == 1 && xwindow.HitTest != null)
                                {
                                    // We do a hit test here to see if we should do something.
                                    HitType type = xwindow.HitTest(xwindow, new Vector2(buttonPressed.x, buttonPressed.y));
                                    if (type != HitType.Default)
                                    {
                                        // FIXME: Handle the hit type!
                                        Logger?.LogWarning("Hit testing is not supported in x11 yet.");
                                        continue;
                                    }
                                }

                                MouseButton button;
                                switch (buttonPressed.button)
                                {
                                    case 1: button = MouseButton.Button1; break; // Left
                                    case 2: button = MouseButton.Button3; break; // Middle
                                    case 3: button = MouseButton.Button2; break; // Right 
                                    case 8: button = MouseButton.Button4; break; // X1 
                                    case 9: button = MouseButton.Button5; break; // X2
                                    default: continue; // Skip this event.
                                }

                                EventQueue.Raise(xwindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(button));
                            }

                            break;
                        }
                    case XEventType.ButtonRelease:
                        {
                            XButtonEvent buttonPressed = ea.ButtonPressed;

                            XWindowHandle xwindow = XWindowDict[buttonPressed.window];

                            // Ignore release for scroll buttons.
                            if (buttonPressed.button >= 4 && buttonPressed.button <= 7)
                            {
                                break;
                            }

                            MouseButton button;
                            switch (buttonPressed.button)
                            {
                                case 1: button = MouseButton.Button1; break; // Left
                                case 2: button = MouseButton.Button3; break; // Middle
                                case 3: button = MouseButton.Button2; break; // Right 
                                case 8: button = MouseButton.Button4; break; // X1 
                                case 9: button = MouseButton.Button5; break; // X2
                                default: continue; // Skip this event.
                            }

                            EventQueue.Raise(xwindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(button));

                            break;
                        }
                    case XEventType.MotionNotify:
                        {
                            XMotionEvent motion = ea.Motion;

                            XWindowHandle xwindow = XWindowDict[motion.window];

                            EventQueue.Raise(xwindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(new Vector2(motion.x, motion.y)));

                            break;
                        }
                    case XEventType.EnterNotify:
                        {
                            XCrossingEvent enter = ea.Enter;

                            XWindowHandle xwindow = XWindowDict[enter.window];

                            EventQueue.Raise(xwindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(true));

                            break;
                        }
                    case XEventType.LeaveNotify:
                        {
                            XCrossingEvent leave = ea.Leave;

                            XWindowHandle xwindow = XWindowDict[leave.window];

                            EventQueue.Raise(xwindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(false));

                            break;
                        }
                    case XEventType.FocusIn:
                        {
                            XFocusChangeEvent focusIn = ea.FocusIn;

                            // Not sure what the different FocusChangeMode and FocusChangeDetail values mean.
                            // I copied what SDL did:
                            // https://github.com/libsdl-org/SDL/blob/e35c3872dc6a8f7741baba8b786b202cef7503ac/src/video/x11/SDL_x11events.c#L975-L990
                            // The documentation for these values is very obtuse:
                            // https://tronche.com/gui/x/xlib/events/input-focus/normal-and-grabbed.html
                            // - Noggin_bops 2023-01-12

                            if (focusIn.mode == FocusChangeMode.NotifyGrab ||
                                focusIn.mode == FocusChangeMode.NotifyUngrab)
                            {
                                Logger?.LogDebug($"FocusIn mode={focusIn.mode}. Ignoring.");
                                break;
                            }

                            if (focusIn.detail == FocusChangeDetail.NotifyInferior ||
                                focusIn.detail == FocusChangeDetail.NotifyPointer)
                            {
                                Logger?.LogDebug($"FocusIn detail={focusIn.detail}. Ignoring.");
                                break;
                            }

                            XWindowHandle xwindow = XWindowDict[focusIn.window];

                            EventQueue.Raise(xwindow, PlatformEventType.Focus, new FocusEventArgs(true));

                            break;
                        }
                    case XEventType.FocusOut:
                        {
                            XFocusChangeEvent focusOut = ea.FocusOut;

                            // Not sure what the different FocusChangeMode and FocusChangeDetail values mean.
                            // I copied what SDL did:
                            // https://github.com/libsdl-org/SDL/blob/e35c3872dc6a8f7741baba8b786b202cef7503ac/src/video/x11/SDL_x11events.c#L975-L990
                            // The documentation for these values is very obtuse:
                            // https://tronche.com/gui/x/xlib/events/input-focus/normal-and-grabbed.html
                            // - Noggin_bops 2023-01-12

                            if (focusOut.mode == FocusChangeMode.NotifyGrab ||
                                focusOut.mode == FocusChangeMode.NotifyUngrab)
                            {
                                Logger?.LogDebug($"FocusOut mode={focusOut.mode}. Ignoring.");
                                break;
                            }

                            if (focusOut.detail == FocusChangeDetail.NotifyInferior ||
                                focusOut.detail == FocusChangeDetail.NotifyPointer)
                            {
                                Logger?.LogDebug($"FocusOut detail={focusOut.detail}. Ignoring.");
                                break;
                            }

                            XWindowHandle xwindow = XWindowDict[focusOut.window];

                            EventQueue.Raise(xwindow, PlatformEventType.Focus, new FocusEventArgs(false));

                            break;
                        }
                    // FIXME: Is this code needed? It seems like it's not doing anything
                    // - Noggin_bops 2023-01-13
                    /*case XEventType.UnmapNotify:
                        unsafe {
                            // If this is followed by a ReparentNotify with the same window and serial
                            // this is part of a reparent operation.
                            if (XCheckIfEvent(X11.Display, out _, IsReparentNotify, new IntPtr(&ea)))
                            {
                                XCheckIfEvent(X11.Display, out _, IsMapNotify, new IntPtr(&ea));
                            }
                            else
                            {
                                XWindowHandle xwindow = XWindowDict[ea.Unmap.window];

                                EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Minimized));
                            }

                            break;

                            static bool IsReparentNotify(XDisplayPtr display, ref XEvent @event, IntPtr arg)
                            {
                                ref XUnmapEvent unmap = ref Unsafe.AsRef<XUnmapEvent>((void*)arg);

                                return @event.Type == XEventType.ReparentNotify &&
                                    @event.Reparent.window == unmap.window &&
                                    @event.Reparent.serial == unmap.serial;
                            }

                            static bool IsMapNotify(XDisplayPtr display, ref XEvent @event, IntPtr arg)
                            {
                                ref XUnmapEvent unmap = ref Unsafe.AsRef<XUnmapEvent>((void*)arg);

                                return @event.Type == XEventType.MapNotify &&
                                    @event.Reparent.window == unmap.window &&
                                    @event.Reparent.serial == unmap.serial;
                            }
                        }*/
                    case XEventType.PropertyNotify:
                        {
                            XPropertyEvent property = ea.Property;

                            /*if (property.atom == X11.Atoms[KnownAtoms.WM_NAME] || 
                                property.atom == X11.Atoms[KnownAtoms._NET_WM_NAME])
                            {
                                continue;
                            }

                            Console.WriteLine("ATOM: " + XGetAtomName(X11.Display, property.atom));
                            */

                            if (property.atom == X11.Atoms[KnownAtoms.WM_STATE])
                            {
                                XWindowHandle xwindow = XWindowDict[property.window];

                                int result = XGetWindowProperty(
                                    X11.Display,
                                    property.window,
                                    X11.Atoms[KnownAtoms.WM_STATE],
                                    0, ~0, false,
                                    new XAtom(0),
                                    out XAtom actualType,
                                    out int actualFormat,
                                    out long numberOfItems,
                                    out long remainingBytes,
                                    out IntPtr contents);

                                if (result == 0)
                                {
                                    unsafe
                                    {
                                        int state = *(int*)contents;
                                        // FIXME: Names for constants 1 and 3.
                                        if (state == 1)
                                        {
                                            EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Normal));
                                        }
                                        else if (state == 3)
                                        {
                                            // When minimizing we remove maximized flags from WM so that we properly detect them when
                                            // going back.
                                            xwindow.WMState &= ~(WMState.MaximizedHorz | WMState.MaximizedVert);
                                            EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Minimized));
                                        }
                                    }
                                }

                                if (contents != IntPtr.Zero)
                                {
                                    XFree(contents);
                                }
                            }
                            else if (property.atom == X11.Atoms[KnownAtoms._NET_WM_STATE])
                            {
                                XWindowHandle xwindow = XWindowDict[property.window];

                                WMState state = GetNETWMState(property.window);
                                WMState changed = xwindow.WMState ^ state;

                                Console.WriteLine($"State: {state}, Changed: {changed}, Before: {xwindow.WMState}");

                                xwindow.WMState = state;

                                if (changed.HasFlag(WMState.Hidden))
                                {
                                    if (state.HasFlag(WMState.Hidden))
                                    {
                                        // FIXME: We want to check if this is actually just us being minimized.
                                        // In that case we don't want to set the mode to hidden.
                                        EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Hidden));
                                    }
                                    else
                                    {
                                        EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Normal));
                                    }
                                }

                                // FIXME: If we are hidden we shouldn't get to these events?
                                if (changed.HasFlag(WMState.MaximizedHorz) || changed.HasFlag(WMState.MaximizedVert))
                                {
                                    if (state.HasFlag(WMState.MaximizedHorz) && state.HasFlag(WMState.MaximizedVert))
                                    {
                                        EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Maximized));
                                    }
                                    else
                                    {
                                        EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Normal));
                                    }
                                }
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
        }

        public WindowHandle Create(GraphicsApiHints hints)
        {
            XWindow window;
            GLXFBConfig? chosenConfig = null;
            XColorMap? map = null;

            if (hints.Api == GraphicsApi.OpenGL || hints.Api == GraphicsApi.OpenGLES)
            {
                // Ignoring ES for now.
                OpenGLGraphicsApiHints glhints = (hints as OpenGLGraphicsApiHints)!;

                byte depthBits;
                switch (glhints.DepthBits)
                {
                    case ContextDepthBits.Depth24: depthBits = 24; break;
                    case ContextDepthBits.Depth32: depthBits = 32; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.DepthBits), (int)glhints.DepthBits, glhints.DepthBits.GetType());
                }

                byte stencilBits;
                switch (glhints.StencilBits)
                {
                    case ContextStencilBits.Stencil1: stencilBits = 1; break;
                    case ContextStencilBits.Stencil8: stencilBits = 8; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.StencilBits), (int)glhints.StencilBits, glhints.StencilBits.GetType());
                }

                Span<int> visualAttribs = stackalloc int[]
                {
                    GLX_X_RENDERABLE, 1,
                    GLX_DRAWABLE_TYPE, GLX_WINDOW_BIT,
                    GLX_RENDER_TYPE, GLX_RGBA_BIT,
                    GLX_X_VISUAL_TYPE, GLX_TRUE_COLOR,
                    GLX_RED_SIZE, glhints.RedColorBits,
                    GLX_GREEN_SIZE, glhints.GreenColorBits,
                    GLX_BLUE_SIZE, glhints.BlueColorBits,
                    GLX_ALPHA_SIZE, glhints.AlphaColorBits,
                    GLX_DEPTH_SIZE, depthBits,
                    GLX_STENCIL_SIZE, stencilBits,
                    GLX_DOUBLEBUFFER, glhints.DoubleBuffer ? 1 : 0,
                    GLX_SAMPLE_BUFFERS, glhints.Multisamples == 0 ? 0 : 1,
                    GLX_SAMPLES, glhints.Multisamples,
                    /* fin */ 0
                };

                int items = visualAttribs.Length;
                unsafe
                {
                    GLXFBConfig *configs = glXChooseFBConfig(X11.Display, X11.DefaultScreen, ref visualAttribs[0], ref items);
                    chosenConfig = *configs;
                    XFree((IntPtr)configs);
                }

                XSetWindowAttributes windowAttributes = new XSetWindowAttributes();
                unsafe
                {
                    XVisualInfo* vi = glXGetVisualFromFBConfig(X11.Display, chosenConfig.Value);
                    map = XCreateColormap(X11.Display, XDefaultRootWindow(X11.Display), ref *vi->VisualPtr, 0);

                    windowAttributes.ColorMap = map.Value;
                    windowAttributes.BackgroundPixmap = XPixmap.None;
                    windowAttributes.BorderPixel = 0;
                    windowAttributes.EventMask = XEventMask.StructureNotify | XEventMask.SubstructureNotify | XEventMask.Exposure | XEventMask.VisibilityChanged;

                    window = XCreateWindow(
                        X11.Display,
                        XDefaultRootWindow(X11.Display),
                        0,
                        0,
                        800, // FIXME: Initial size should be 0, or the win32 backend should have it's defaults modified.
                        600,
                        0,
                        vi->Depth,
                        1,
                        ref *vi->VisualPtr,
                        XWindowAttributeValueMask.BackPixmap | XWindowAttributeValueMask.Colormap | XWindowAttributeValueMask.BorderPixel | XWindowAttributeValueMask.EventMask,
                        ref windowAttributes);

                    XFree((IntPtr)vi);
                }
            }
            else
            {
                XSetWindowAttributes attributes = default;
                attributes.BorderPixel = XBlackPixel(X11.Display, X11.DefaultScreen);
                attributes.BackgroundPixel = XWhitePixel(X11.Display, X11.DefaultScreen);
                attributes.OverrideRedirect = 0;
                attributes.ColorMap = XDefaultColormap(X11.Display, X11.DefaultScreen);
                attributes.EventMask = XEventMask.Exposure;

                window = XCreateWindow(X11.Display, X11.DefaultRootWindow, 0, 0, 600, 800, 0, 0, 1, ref Unsafe.NullRef<XVisual>(),
                    XWindowAttributeValueMask.BackPixel | XWindowAttributeValueMask.Colormap |
                    XWindowAttributeValueMask.BorderPixel | XWindowAttributeValueMask.EventMask, ref attributes);

                throw new PalException(this, "Cannot create a X11 window without a graphics API.");
            }

            XSetStandardProperties(
                X11.Display,
                window,
                "OpenTK Window [Native:X11]",
                "ICO_OPENTK",
                XPixmap.None,
                null,
                0,
                ref Unsafe.NullRef<XSizeHints>());

            // Register to deletion events
            XSetWMProtocols(X11.Display, window, new XAtom[] { X11.Atoms[KnownAtoms.WM_DELETE_WINDOW] }, 1);

            // FIXME: Find a place for this:
            XSelectInput(
                    X11.Display, window,
                    XEventMask.StructureNotify |
                    XEventMask.SubstructureNotify |
                    XEventMask.VisibilityChanged |
                    XEventMask.Exposure |
                    XEventMask.ButtonPress |
                    XEventMask.EnterWindow |
                    XEventMask.LeaveWindow |
                    XEventMask.KeyPress |
                    XEventMask.KeyRelease |
                    XEventMask.FocusChange |
                    XEventMask.PropertyChange
                    );

            XWindowHandle handle = new XWindowHandle(X11.Display, window, hints, chosenConfig, map);

            XWindowDict.Add(handle.Window, handle);

            return handle;
        }

        public void Destroy(WindowHandle handle)
        {
            var xhandle = handle.As<XWindowHandle>(this);

            XWindowDict.Remove(xhandle.Window);

            XDestroyWindow(xhandle.Display, xhandle.Window);

            if (xhandle.ColorMap.HasValue)
            {
                XFreeColormap(xhandle.Display, xhandle.ColorMap.Value);
            }

            xhandle.Destroyed = true;
        }

        public bool IsWindowDestroyed(WindowHandle handle)
        {
            var xhandle = handle.As<XWindowHandle>(this);

            return xhandle.Destroyed;
        }

        public string GetTitle(WindowHandle handle)
        {
            var window = handle.As<XWindowHandle>(this);
            string str;
            IntPtr name;

            // Prefer to fetch the freedesktop name.
            int status = XGetWindowProperty(
                    window.Display,
                    window.Window,
                    X11.Atoms![KnownAtoms._NET_WM_NAME],
                    0,
                    long.MaxValue,
                    false,
                    X11.Atoms![KnownAtoms.UTF8_STRING],
                    out XAtom returnedType,
                    out _,
                    out long count,
                    out _,
                    out name);

            // If the property is empty or does not exist or an error,
            // fetch the classic name.
            if (returnedType.IsNone || status != 0)
            {
                XFetchName(window.Display, window.Window, out name);
            }

            str = Marshal.PtrToStringUTF8(name) ?? string.Empty;
            XFree(name);
            return str;
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            var window = handle.As<XWindowHandle>(this);
            byte[] titleBytes = System.Text.Encoding.UTF8.GetBytes(title);

            XStoreName(window.Display, window.Window, title);   // Set classic name,
            unsafe
            {
                fixed(byte *titlePtr = &titleBytes[0])
                {
                    // Set freedesktop name.
                    XChangeProperty(
                        window.Display,
                        window.Window,
                        X11.Atoms![KnownAtoms._NET_WM_NAME],
                        X11.Atoms![KnownAtoms.UTF8_STRING],
                        8,
                        XPropertyMode.Replace,
                        (IntPtr)titlePtr,
                        titleBytes.Length
                        );
                }
            }
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        private void GetWindowExtents(WindowHandle handle, out int left, out int right, out int top, out int bottom)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowProperty(
                window.Display,
                window.Window,
                X11.Atoms![KnownAtoms._NET_FRAME_EXTENTS],
                0,
                long.MaxValue,
                false,
                X11.Atoms![KnownAtoms.CARDINAL],
                out _,
                out _,
                out long count,
                out _,
                out IntPtr array);

            if (count < 4)
            {
                // FIXME: You need to request frame extents for this to work...
                // This means that you have to wait for the window manager to
                // respond. I don't know if pumping the event loop is the solution here.

                left = right = top = bottom = 0;
            }
            else
            {
                left   = Marshal.PtrToStructure<int>(array);
                right  = Marshal.PtrToStructure<int>(array + 4);
                top    = Marshal.PtrToStructure<int>(array + 8);
                bottom = Marshal.PtrToStructure<int>(array + 12);
            }

            XFree(array);
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            GetClientPosition(handle, out x, out y);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out _, out int top, out _);
                x -= left;
                y -= top;
            }
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XMoveWindow(X11.Display, xwindow.Window, x, y);
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            GetClientSize(handle, out width, out height);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out int right, out int top, out int bottom);
                width += left + right;
                height += top + bottom;
            }
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XResizeWindow(X11.Display, xwindow.Window, width, height);
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);
            XTranslateCoordinates(
                window.Display,
                window.Window,
                X11.DefaultRootWindow,
                attributes.X,
                attributes.Y,
                out x,
                out y,
                out _);
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            var window = handle.As<XWindowHandle>(this);
            XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);
            width = attributes.Width;
            height = attributes.Height;
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            throw new NotImplementedException();
        }

        public unsafe void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();

            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            if ((hints->Flags & XSizeHintFlags.MaxSize) == XSizeHintFlags.MaxSize)
            {
                // FIXME: We have no good way of setting one of these to null if they where set to null.
                width = hints->MaxWidth;
                height = hints->MaxHeight;
            }
            else
            {
                width = null;
                height = null;
            }

            XFree(hints);
        }

        public unsafe void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();

            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            // We default these to max values so that leaving one as null
            // effectively means not having a max.
            hints->MaxWidth = width ?? int.MaxValue;
            hints->MaxHeight = height ?? int.MaxValue;

            // If we have either a max width or max height, we specify it.
            // And if both are null we remove the flag.
            if (width != null || height != null)
                hints->Flags |= XSizeHintFlags.MaxSize;
            else
                hints->Flags &= ~XSizeHintFlags.MaxSize;

            XSetWMNormalHints(X11.Display, xwindow.Window, hints);

            XFree(hints);
        }

        public unsafe void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();

            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            if ((hints->Flags & XSizeHintFlags.MinSize) == XSizeHintFlags.MinSize)
            {
                // FIXME: We have no good way of setting one of these to null if they where set to null.
                width = hints->MinWidth;
                height = hints->MinHeight;
            }
            else
            {
                width = null;
                height = null;
            }

            XFree(hints);
        }

        public unsafe void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();

            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            hints->MinWidth = width ?? 0;
            hints->MinHeight = height ?? 0;

            // If we have either a min width or min height, we specify it.
            // And if both are null we remove the flag.
            if (width != null || height != null)
                hints->Flags |= XSizeHintFlags.MinSize;
            else
                hints->Flags &= ~XSizeHintFlags.MinSize;

            XSetWMNormalHints(X11.Display, xwindow.Window, hints);

            XFree(hints);
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            // FIXME: Read WM_STATE for iconified, read _NET_WM_STATE for the rest.
            throw new NotImplementedException();
        }

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            switch (mode)
            {
                case WindowMode.Normal:
                    {
                        // FIXME! Not Raised, XMapWindow instead!
                        XClearWindow(X11.Display, xwindow.Window);
                        XMapRaised(X11.Display, xwindow.Window);
                        break;
                    }
                case WindowMode.Hidden:
                    {
                        // FIXME: XUnmapWindow();

                        break;
                    }
                case WindowMode.Minimized:
                    {
                        // FIXME: Default screen?
                        int result = XIconifyWindow(X11.Display, xwindow.Window, X11.DefaultScreen);
                        if (result == 0)
                        {
                            Logger?.LogWarning("XIconifyWindow window failed. Can't minimize window.");
                        }
                        break;
                    }
                case WindowMode.Maximized:
                    {
                        // FIXME: Log warning if _NET_WM_STATE is not supported.

                        XEvent e = new XEvent();

                        ref XClientMessageEvent client = ref e.ClientMessage;

                        /* remove/unset property */
                        const long _NET_WM_STATE_REMOVE = 0;
                        /* add/set property */
                        const long _NET_WM_STATE_ADD = 1;
                        /* toggle property  */
                        const long _NET_WM_STATE_TOGGLE = 2;

                        client.Type = XEventType.ClientMessage;
                        client.Serial = 0;
                        client.SendEvent = 1;
                        client.Display = X11.Display;
                        client.Window = xwindow.Window;
                        client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                        client.Format = 32;
                        unsafe
                        {
                            client.l[0] = _NET_WM_STATE_ADD;
                            client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ].Id;
                            client.l[2] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_VERT].Id;
                            client.l[3] = 0;
                            client.l[4] = 0;
                        }

                        int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        XEvent e = new XEvent();

                        ref XClientMessageEvent client = ref e.ClientMessage;

                        /* remove/unset property */
                        const long _NET_WM_STATE_REMOVE = 0;
                        /* add/set property */
                        const long _NET_WM_STATE_ADD = 1;
                        /* toggle property  */
                        const long _NET_WM_STATE_TOGGLE = 2;
                        
                        // FIXME: Remove extents or whatever is causing the window to not become "proper" fullscreen.
                        // FIXME: Make sure that we don't trigger a "maximized" window mode change.

                        client.Type = XEventType.ClientMessage;
                        client.Serial = 0;
                        client.SendEvent = 1;
                        client.Display = X11.Display;
                        client.Window = xwindow.Window;
                        client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                        client.Format = 32;
                        unsafe
                        {
                            client.l[0] = _NET_WM_STATE_ADD;
                            client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_VERT].Id;
                            client.l[2] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ].Id;
                            client.l[3] = 0;
                            client.l[4] = 0;
                        }

                        int status2 = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                        client.Type = XEventType.ClientMessage;
                        client.Serial = 0;
                        client.SendEvent = 1;
                        client.Display = X11.Display;
                        client.Window = xwindow.Window;
                        client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                        client.Format = 32;
                        unsafe
                        {
                            client.l[0] = _NET_WM_STATE_ADD;
                            client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN].Id;
                            client.l[2] = 0;
                            client.l[3] = 0;
                            client.l[4] = 0;
                        }

                        int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                        break;
                    }
                case WindowMode.WindowedFullscreen:
                default:
                    throw new NotImplementedException();
            }
        }

        public WindowStyle GetBorderStyle(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetBorderStyle(WindowHandle handle, WindowStyle style)
        {
            throw new NotImplementedException();

            switch (style)
            {
                case WindowStyle.Borderless:
                {
                    
                    break;
                }
                case WindowStyle.FixedBorder:
                    // Set the max and min height to the same.
                    // FIXME: Figure out if you can still resize the window programatically.
                    // FIXME: Should GetMaxClientSize return the last set value or 
                    // the value that it will have after this.
                    break;
                default:
            }
        }

        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This will not work if this is set before the window is mapped (I think).
            // Is there some way to fix this?
            // - Noggin_bops 2023-01-13

            if (X11.Atoms[KnownAtoms._NET_WM_STATE_ABOVE] == XAtom.None)
            {
                // FIXME: Add a feature bool to IWindowComponent?
                Logger?.LogWarning("Can't make window always on top. The window manager doesn't support _NET_WM_STATE_ABOVE.");
                return;
            }

            XEvent e = new XEvent();

            ref XClientMessageEvent client = ref e.ClientMessage;

            /* remove/unset property */
            const long _NET_WM_STATE_REMOVE = 0;
            /* add/set property */
            const long _NET_WM_STATE_ADD = 1;
            /* toggle property  */
            const long _NET_WM_STATE_TOGGLE = 2;

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = floating ? _NET_WM_STATE_ADD : _NET_WM_STATE_REMOVE;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_ABOVE].Id;
                client.l[2] = 0;
                client.l[3] = 0;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This does not work if it's called directly 
            // after setting the window to always on top.
            // MapWindow, SetALwaysOnTop, IsAlwaysOnTop doesn't work at least.
            // - Noggin_bops 2023-01-13

            if (X11.Atoms[KnownAtoms._NET_WM_STATE_ABOVE] == XAtom.None)
            {
                Logger?.LogWarning("Can't check if window is always on top. The window manager doesn't support _NET_WM_STATE_ABOVE.");
                return false;
            }

            int failed = XGetWindowProperty(
                X11.Display,
                xwindow.Window,
                X11.Atoms[KnownAtoms._NET_WM_STATE],
                0,
                ~0,
                false,
                X11.Atoms[KnownAtoms.ATOM],
                out XAtom actualType,
                out int actualFormat,
                out long numberOfItems,
                out long remainingBytes,
                out IntPtr contents);

            bool above = false;
            unsafe {
                XAtom* atoms = (XAtom*)contents;
                for (int i = 0; i < numberOfItems; i++)
                {
                    if (atoms[i] == X11.Atoms[KnownAtoms._NET_WM_STATE_ABOVE])
                    {
                        above = true;
                    }
                }
            }

            return above;
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            xwindow.HitTest = test;
        }

        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XCursorHandle? xcursor = cursor?.As<XCursorHandle>(this);

            XDefineCursor(X11.Display, xwindow.Window, xcursor?.Cursor ?? XCursor.None);
        }

        public void FocusWindow(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XRaiseWindow(X11.Display, xwindow.Window);
            XSetInputFocus(X11.Display, xwindow.Window, RevertTo.RevertToPointerRoot, XTime.CurrentTime);
        }

        public void RequestAttention(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (X11.Atoms[KnownAtoms._NET_WM_STATE_DEMANDS_ATTENTION] == XAtom.None)
            {
                // FIXME: Add a feature bool to IWindowComponent?
                Logger?.LogWarning("Can't request attention to the window. The window manager doesn't support _NET_WM_STATE_DEMANDS_ATTENTION.");
                return;
            }

            XEvent e = new XEvent();

            ref XClientMessageEvent client = ref e.ClientMessage;

            /* remove/unset property */
            const long _NET_WM_STATE_REMOVE = 0;
            /* add/set property */
            const long _NET_WM_STATE_ADD = 1;
            /* toggle property  */
            const long _NET_WM_STATE_TOGGLE = 2;

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = _NET_WM_STATE_ADD;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_DEMANDS_ATTENTION].Id;
                client.l[2] = 0;
                client.l[3] = 0;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, X11.DefaultRootWindow, xwindow.Window, x, y, out clientX, out clientY, out _);

            // FIXME: Extents?
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, xwindow.Window, X11.DefaultRootWindow, clientX, clientY, out x, out y, out _);

            // FIXME: Extents?
        }

        public void SwapBuffers(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            glXSwapBuffers(xwindow.Display, xwindow.Window);
        }
    }
}
