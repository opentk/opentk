using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Core;
using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.GLX;
using static OpenTK.Platform.Native.X11.LibX11;
using OpenTK.Platform.Native.X11.XRandR;

namespace OpenTK.Platform.Native.X11
{
    public class X11WindowComponent : IWindowComponent
    {
        /// <inheritdoc />
        public string Name => nameof(X11WindowComponent);

        /// <inheritdoc />
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc />
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

        internal static XWindowHandle? CursorCapturingWindow;

        internal static XWindow HelperWindow { get; private set; }

        /// <inheritdoc />
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

            string[] extensions = XListExtensions(X11.Display, out _);
            X11.Extensions = new HashSet<string>(extensions);

            Logger?.LogInfo($"X11 Extensions: {string.Join(", ", extensions)}");

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

            XGetWindowProperty(
                X11.Display,
                X11.DefaultRootWindow,
                _net_supporting_wm_check,
                0, 8,
                false,
                window,
                out _,
                out _,
                out long count,
                out _,
                out IntPtr array);

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

            // Create a helper window to help with clipboard stuff.
            // FIXME: Will this only be used for clipboard stuff?
            unsafe
            {
                XSetWindowAttributes wa = default;
                wa.EventMask = XEventMask.PropertyChange;
                HelperWindow = XCreateWindow(X11.Display, X11.DefaultRootWindow,
                    0, 0, 1, 1, 0, 0,
                    WindowClass.InputOnly,
                    ref Unsafe.AsRef<XVisual>(XDefaultVisual(X11.Display, X11.DefaultScreen)),
                    XWindowAttributeValueMask.EventMask,
                    ref wa);
            }
        }

        /// <inheritdoc />
        public bool CanSetIcon => true;

        /// <inheritdoc />
        public bool CanGetDisplay => false;

        /// <inheritdoc />
        public bool CanSetCursor => true;

        /// <inheritdoc />
        public bool CanCaptureCursor => true;

        private static List<WindowBorderStyle> s_emptyStyleList = new List<WindowBorderStyle>();

        private static readonly WindowMode[] _SupportedModes = new[]
        {
            WindowMode.Hidden,
            WindowMode.Normal,
            WindowMode.Minimized,
            WindowMode.Maximized,
            WindowMode.ExclusiveFullscreen,
        };

        /// <inheritdoc />
        public IReadOnlyList<PlatformEventType> SupportedEvents { get => throw new NotImplementedException(); }

        /// <inheritdoc />
        public IReadOnlyList<WindowBorderStyle> SupportedStyles { get; private set; } = s_emptyStyleList;

        /// <inheritdoc />
        public IReadOnlyList<WindowMode> SupportedModes { get; private set; } = _SupportedModes;

        /// <summary>
        /// When true, indicates the current window manager is Freedesktop compliant.
        /// </summary>
        public bool IsWindowManagerFreedesktop { get; private set; } = false;

        /// <summary>
        /// The name of the Freedesktop manager.
        /// </summary>
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

        internal bool IsMapped(XWindowHandle xwindow)
        {
            XGetWindowAttributes(X11.Display, xwindow.Window, out XWindowAttributes attributes);
            return attributes.MapState != MapState.IsUnmapped;
        }

        /// <inheritdoc />
        public void ProcessEvents(bool waitForEvents = false)
        {
            // FIXME: waitForEvents!

            XEvent ea = new XEvent();
            while (XEventsQueued(X11.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
            {
                XNextEvent(X11.Display, out ea);

                if (XWindowDict.TryGetValue(ea.Any.Window, out XWindowHandle? xwindow) == false)
                {
                    // This event likely for a deleted window.
                    Logger?.LogDebug($"Received event {ea.Type} for an unknown (likely destroyed) window {ea.Any.Window}.");
                    continue;
                }

                switch (ea.Type)
                {
                    case XEventType.ClientMessage:
                        {
                            XClientMessageEvent clientMessage = ea.ClientMessage;

                            unsafe
                            {
                                if (clientMessage.Format == 32 && clientMessage.l[0] == (long)X11.Atoms[KnownAtoms.WM_DELETE_WINDOW].Id)
                                {
                                    EventQueue.Raise(xwindow, PlatformEventType.Close, new CloseEventArgs(xwindow));
                                }
                                else if (clientMessage.Format == 32 && clientMessage.l[0] == (long)X11.Atoms[KnownAtoms._NET_WM_PING].Id)
                                {
                                    // Ping events to know that we are still responsive.
                                    XEvent reply = ea;
                                    reply.ClientMessage.Window = X11.DefaultRootWindow;

                                    XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureNotify | XEventMask.SubstructureRedirect, reply);
                                }
                            }

                            break;
                        }
                    case XEventType.ButtonPress:
                        {
                            XButtonEvent buttonPressed = ea.ButtonPressed;

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
                                EventQueue.Raise(xwindow, PlatformEventType.Scroll, new ScrollEventArgs(xwindow, (xdelta, ydelta), (xdelta, ydelta)));
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

                                EventQueue.Raise(xwindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(xwindow, button));
                            }

                            break;
                        }
                    case XEventType.ButtonRelease:
                        {
                            XButtonEvent buttonReleased = ea.ButtonReleased;

                            // Ignore release for scroll buttons.
                            if (buttonReleased.button >= 4 && buttonReleased.button <= 7)
                            {
                                break;
                            }

                            MouseButton button;
                            switch (buttonReleased.button)
                            {
                                case 1: button = MouseButton.Button1; break; // Left
                                case 2: button = MouseButton.Button3; break; // Middle
                                case 3: button = MouseButton.Button2; break; // Right
                                case 8: button = MouseButton.Button4; break; // X1
                                case 9: button = MouseButton.Button5; break; // X2
                                default: continue; // Skip this event.
                            }

                            EventQueue.Raise(xwindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(xwindow, button));

                            break;
                        }
                    case XEventType.KeyPress:
                        {
                            XKeyEvent keyPressed = ea.KeyPressed;

                            // FIXME: Handle repeats

                            unsafe {
                                XKeySym keysym = default;
                                const int TEXT_LENGTH = 32;
                                byte* str = stackalloc byte[TEXT_LENGTH];
                                int charsWritten = XLookupString(&keyPressed, str, TEXT_LENGTH, &keysym, null);

                                // FIXME: Convert keycode into scancode and then key.
                                // XDisplayKeycodes -> XGetKeyboardMapping -> "normal" keysym translations..

                                // FIXME: Backspace hack!
                                if (keysym.Id == 65288)
                                {
                                    EventQueue.Raise(xwindow, PlatformEventType.KeyDown, new KeyDownEventArgs(xwindow, Key.Backspace, Scancode.Backspace, false));
                                }

                                bool isHighLatin1 = false;
                                for (int i = 0; i < TEXT_LENGTH; i++)
                                {
                                    if (str[i] >= 0x80)
                                    {
                                        isHighLatin1 = true;
                                        break;
                                    }
                                }

                                // FIXME: Figure out when this Latin1 stuff is needed.
                                // On Ubuntu 22.04 we can just do the "new string()" method
                                // in all cases, even for characters like åäö.
                                // - Noggin_bops 2023-08-26
                                string? result = null;
                                if (isHighLatin1)
                                {
                                    result = Encoding.Latin1.GetString(str, charsWritten);
                                }
                                else
                                {
                                    result = new string((sbyte*)str, 0, charsWritten);
                                }

                                EventQueue.Raise(xwindow, PlatformEventType.TextInput, new TextInputEventArgs(xwindow, result));
                            }
                            break;
                        }
                    case XEventType.KeyRelease:
                        {
                            XKeyEvent keyPressed = ea.KeyPressed;

                            unsafe {
                                XKeySym keysym = default;
                                const int TEXT_LENGTH = 32;
                                byte* str = stackalloc byte[TEXT_LENGTH];
                                int charsWritten = XLookupString(&keyPressed, str, TEXT_LENGTH, &keysym, null);

                                // FIXME: Backspace hack!
                                if (keysym.Id == 65288)
                                {
                                    EventQueue.Raise(xwindow, PlatformEventType.KeyUp, new KeyUpEventArgs(xwindow, Key.Backspace, Scancode.Backspace));
                                }
                            }

                            break;
                        }
                    case XEventType.MotionNotify:
                        {
                            XMotionEvent motion = ea.Motion;

                            if (CursorCapturingWindow == xwindow && xwindow.CaptureMode == CursorCaptureMode.Locked)
                            {
                                Vector2 delta = (motion.x, motion.y) - xwindow.LastMousePosition;

                                if (delta != (0, 0))
                                {
                                    xwindow.VirtualCursorPosition += delta;
                                    EventQueue.Raise(xwindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(xwindow, xwindow.VirtualCursorPosition));
                                }
                            }
                            else
                            {
                                EventQueue.Raise(xwindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(xwindow, new Vector2(motion.x, motion.y)));
                            }

                            xwindow.LastMousePosition = (motion.x, motion.y);

                            break;
                        }
                    case XEventType.EnterNotify:
                        {
                            XCrossingEvent enter = ea.Enter;

                            EventQueue.Raise(xwindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(xwindow, true));

                            break;
                        }
                    case XEventType.LeaveNotify:
                        {
                            XCrossingEvent leave = ea.Leave;

                            EventQueue.Raise(xwindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(xwindow, false));

                            break;
                        }
                    case XEventType.FocusIn:
                        {
                            XFocusChangeEvent focusIn = ea.FocusIn;

                            // Not sure what the different FocusChangeMode and FocusChangeDetail values mean.
                            // I copied what SDLLib did:
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

                            EventQueue.Raise(xwindow, PlatformEventType.Focus, new FocusEventArgs(xwindow, true));

                            break;
                        }
                    case XEventType.FocusOut:
                        {
                            XFocusChangeEvent focusOut = ea.FocusOut;

                            // Not sure what the different FocusChangeMode and FocusChangeDetail values mean.
                            // I copied what SDLLib did:
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

                            EventQueue.Raise(xwindow, PlatformEventType.Focus, new FocusEventArgs(xwindow, false));

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
                                    const int WithdrawnState = 0;
                                    const int NormalState = 1;
                                    const int IconicState = 3;

                                    unsafe
                                    {
                                        int state = *(int*)contents;
                                        if (state == NormalState)
                                        {
                                            EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.Normal));
                                        }
                                        else if (state == IconicState)
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
                                WMState state = GetNETWMState(property.window);
                                WMState changed = xwindow.WMState ^ state;

                                // FIXME: Remove or make debug print.
                                Console.WriteLine($"State: {state}, Changed: {changed}, Before: {xwindow.WMState}");

                                xwindow.WMState = state;

                                // Check if we've gone fullscreen.
                                if (changed.HasFlag(WMState.Fullscreen))
                                {
                                    if (state.HasFlag(WMState.Fullscreen))
                                    {
                                        // FIXME: Differentiate exclusive fullscreen from windowed fullscreen?
                                        EventQueue.Raise(xwindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(xwindow, WindowMode.ExclusiveFullscreen));
                                        break;
                                    }
                                }

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
                            else
                            {
                                if (property.atom != X11.Atoms[KnownAtoms.WM_NAME] &&
                                    property.atom != X11.Atoms[KnownAtoms._NET_WM_NAME])
                                {
                                    Console.WriteLine($"PropertyNotify: {XGetAtomName(X11.Display, property.atom)}");
                                }
                            }
                            break;
                        }
                    case XEventType.ConfigureNotify:
                        {
                            XConfigureEvent configure = ea.Configure;

                            if (configure.width != xwindow.Width ||
                                configure.height != xwindow.Height)
                            {
                                xwindow.Width = configure.width;
                                xwindow.Height = configure.height;

                                EventQueue.Raise(xwindow, PlatformEventType.WindowResize, new WindowResizeEventArgs(xwindow, (xwindow.Width, xwindow.Height)));
                            }

                            if (configure.x != xwindow.X ||
                                configure.y != xwindow.Y)
                            {
                                xwindow.X = configure.x;
                                xwindow.Y = configure.y;

                                // FIXME: The coordinates from the event are relative to the parent window. So if we are reparented this will report wrong coordinates.

                                // FIXME: Calculate the proper window location, the coordinates reported are for the client area of the window.
                                EventQueue.Raise(xwindow, PlatformEventType.WindowMove, new WindowMoveEventArgs(xwindow, (xwindow.X, xwindow.Y), (xwindow.X, xwindow.Y)));
                            }

                            break;
                        }
                    default:
                    {
                        if (ea.Type == (XEventType)(X11.XRandREventBase + RREventType.RRNotify))
                        {
                            X11DisplayComponent.HandleXRREvent(ea);
                        }
                        break;
                    }
                }
            }

            if (CursorCapturingWindow != null && CursorCapturingWindow.CaptureMode == CursorCaptureMode.Locked)
            {
                GetClientSize(CursorCapturingWindow, out int width, out int height);
                if (CursorCapturingWindow.LastMousePosition != (width / 2, height / 2))
                {
                    XWarpPointer(X11.Display, XWindow.None, CursorCapturingWindow.Window, 0, 0, 0, 0, width / 2, height / 2);

                    // Set the last mouse position to the position we are moving to
                    // to avoid generating a mouse move event.
                    CursorCapturingWindow.LastMousePosition = (width / 2, height / 2);
                }
            }
        }

        /// <inheritdoc />
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
                        WindowClass.InputOutput,
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

                window = XCreateWindow(X11.Display, X11.DefaultRootWindow,
                    0, 0, 600, 800, 0, 0,
                    WindowClass.InputOutput,
                    ref Unsafe.NullRef<XVisual>(),
                    XWindowAttributeValueMask.BackPixel | XWindowAttributeValueMask.Colormap |
                    XWindowAttributeValueMask.BorderPixel | XWindowAttributeValueMask.EventMask,
                    ref attributes);

                // FIXME: How do we handle vulkan windows?
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

            // Register to deletion and ping events
            XSetWMProtocols(X11.Display, window, new XAtom[] { X11.Atoms[KnownAtoms.WM_DELETE_WINDOW], X11.Atoms[KnownAtoms._NET_WM_PING] }, 2);

            // FIXME: Find a place for this:
            XSelectInput(
                    X11.Display, window,
                    XEventMask.StructureNotify |
                    XEventMask.SubstructureNotify |
                    XEventMask.VisibilityChanged |
                    XEventMask.Exposure |
                    XEventMask.ButtonPress |
                    XEventMask.ButtonRelease |
                    XEventMask.PointerMotion |
                    XEventMask.EnterWindow |
                    XEventMask.LeaveWindow |
                    XEventMask.KeyPress |
                    XEventMask.KeyRelease |
                    XEventMask.FocusChange |
                    XEventMask.PropertyChange);

            unsafe {
                XWMHints* wmHints = XAllocWMHints();
                wmHints->flags |= XWMHintsMask.InputHint;
                wmHints->input = 1;

                XSetWMHints(X11.Display, window, wmHints);
            }

            XWindowHandle handle = new XWindowHandle(X11.Display, window, hints, chosenConfig, map);

            XWindowDict.Add(handle.Window, handle);

            return handle;
        }

        /// <inheritdoc />
        public void Destroy(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XWindowDict.Remove(xwindow.Window);

            XDestroyWindow(xwindow.Display, xwindow.Window);

            // If this window was fullscreen we want to restore the video mode.
            if (xwindow.FullscreenDisplay != null)
            {
                X11DisplayComponent.RestoreVideoMode(this, xwindow.FullscreenDisplay);
            }

            if (xwindow.ColorMap.HasValue)
            {
                XFreeColormap(xwindow.Display, xwindow.ColorMap.Value);
            }

            xwindow.Destroyed = true;
        }

        /// <inheritdoc />
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            var xhandle = handle.As<XWindowHandle>(this);

            return xhandle.Destroyed;
        }

        /// <inheritdoc />
        public string GetTitle(WindowHandle handle)
        {
            var window = handle.As<XWindowHandle>(this);

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
                    out _,
                    out _,
                    out IntPtr name);

            // If the property is empty or does not exist or an error,
            // fetch the classic name.
            if (returnedType.IsNone || status != 0)
            {
                XFetchName(window.Display, window.Window, out name);
            }

            string str = Marshal.PtrToStringUTF8(name) ?? string.Empty;
            XFree(name);
            return str;
        }

        /// <inheritdoc />
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

            // FIXME: Seems like on some machines we need to call XFlush to get the changes to be made.
            XFlush(X11.Display);
        }

        /// <inheritdoc />
        public IconHandle? GetIcon(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            return xwindow.Icon;
        }

        /// <inheritdoc />
        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XIconHandle xicon = icon.As<XIconHandle>(this);

            X11IconComponent.IconImage[]? images = xicon.Images;
            if (images == null)
            {
                Logger?.LogError($"Icon didn't include any images.");
                return;
            }

            int longCount = 0;
            for (int i = 0; i < images.Length; i++)
            {
                longCount += 2 + (images[i].Width * images[i].Height);
            }

            // FIXME: Fill this array without unsafe?
            long[] data = new long[longCount];
            unsafe {
                fixed (long* dataPtr = data)
                {
                    long* target = dataPtr;
                    for (int i = 0; i < images.Length; i++)
                    {
                        *target++ = images[i].Width;
                        *target++ = images[i].Height;

                        for (int j = 0; j < images[i].Width * images[i].Height; j++)
                        {
                            // FIXME: Is this the correct color format?
                            *target++ = ((long)images[i].Data[j * 4 + 0] << 16) |
                                        ((long)images[i].Data[j * 4 + 1] <<  8) |
                                        ((long)images[i].Data[j * 4 + 2] <<  0) |
                                        ((long)images[i].Data[j * 4 + 3] <<  24);
                        }
                    }
                }
            }

            XChangeProperty(
                X11.Display,
                xwindow.Window,
                X11.Atoms[KnownAtoms._NET_WM_ICON],
                X11.Atoms[KnownAtoms.CARDINAL], 32,
                XPropertyMode.Replace,
                data,
                longCount);

            xwindow.Icon = xicon;
        }

        /// <inheritdoc />
        private void GetWindowExtents(WindowHandle handle, out int left, out int right, out int top, out int bottom)
        {
            var window = handle.As<XWindowHandle>(this);
            int status = XGetWindowProperty(
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
                left   = (int)Marshal.PtrToStructure<long>(array);
                right  = (int)Marshal.PtrToStructure<long>(array + 8);
                top    = (int)Marshal.PtrToStructure<long>(array + 16);
                bottom = (int)Marshal.PtrToStructure<long>(array + 24);
            }

            XFree(array);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out _, out int top, out _);
                x -= left;
                y -= top;
            }

            XMoveWindow(X11.Display, xwindow.Window, x, y);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void SetSize(WindowHandle handle, int width, int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int innerWidth = width;
            int innerHeight = height;

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(xwindow, out int left, out int right, out int top, out int bottom);
                innerWidth -= left + right;
                innerHeight -= top + bottom;
            }

            SetClientSize(xwindow, innerWidth, innerHeight);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XMoveWindow(X11.Display, xwindow.Window, x, y);
        }

        /// <inheritdoc />
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            var window = handle.As<XWindowHandle>(this);
            int status = XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);

            width = attributes.Width;
            height = attributes.Height;
        }

        /// <inheritdoc />
        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XResizeWindow(X11.Display, xwindow.Window, width, height);

            XFlush(X11.Display);
        }

        /// <inheritdoc />
        public unsafe void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();
            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            if ((hints->Flags & XSizeHintFlags.MaxSize) == XSizeHintFlags.MaxSize)
            {
                if (hints->MaxWidth == xwindow.FixedSize.X &&
                    hints->MaxHeight == xwindow.FixedSize.Y)
                {
                    // To make the window non resizable we set the min and max size to the same value.
                    // This makes the min and max values from x11 not reliable, so we check if the max
                    // size is the same as what we set when making the windows non resizable.
                    // - 2023-02-08 NogginBops
                    width = xwindow.MaxSize.Width;
                    height = xwindow.MaxSize.Height;
                }
                else
                {
                    // FIXME: We have no good way of setting one of these to null if they where set to null.
                    width = hints->MaxWidth;
                    height = hints->MaxHeight;
                }
            }
            else
            {
                width = null;
                height = null;
            }

            XFree(hints);
        }

        /// <inheritdoc />
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

            xwindow.MaxSize = (width, height);

            XFree(hints);
        }

        /// <inheritdoc />
        public unsafe void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSizeHints* hints = XAllocSizeHints();

            XSizeHintFlags supplied;
            XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

            if ((hints->Flags & XSizeHintFlags.MinSize) == XSizeHintFlags.MinSize)
            {
                if (hints->MinWidth == xwindow.FixedSize.X &&
                    hints->MinHeight == xwindow.FixedSize.Y)
                {
                    // To make the window non resizable we set the min and max size to the same value.
                    // This makes the min and max values from x11 not reliable, so we check if the max
                    // size is the same as what we set when making the windows non resizable.
                    // - 2023-02-08 NogginBops
                    width = xwindow.MinSize.Width;
                    height = xwindow.MinSize.Height;
                }
                else
                {
                    // FIXME: We have no good way of setting one of these to null if they where set to null.
                    width = hints->MinWidth;
                    height = hints->MinHeight;
                }
            }
            else
            {
                width = null;
                height = null;
            }

            XFree(hints);
        }

        /// <inheritdoc />
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

            xwindow.MinSize = (width, height);

            XFree(hints);
        }

        /// <inheritdoc />
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: Is there anything we can do about this function?
            // It would be nice to be able to reduce the amount of work done
            // so that this query can be done relatively often.
            // Currently it involves getting all of the crtcs from
            // xrandr, creating a list of display handles with their bounds,
            // and then doing this loop...
            //
            // Ideally xrandr or x11 would expose something that tells
            // us what window the window is considered "on".
            //
            // On ubuntu 22.04 this function does not always return the display
            // that the window would be maximized on when double clicking it's title.
            // We would ideally match that behaviour.
            // - Noggin_bops 2023-10-05

            // FIXME: GetBounds function
            GetPosition(xwindow, out int x, out int y);
            GetSize(xwindow, out int width, out int height);

            Box2i bounds = new Box2i(x, y, x + width, y + height);

            DisplayHandle? bestDisp = null;
            int bestArea = 0;
            float bestDistance = float.PositiveInfinity;


            // Get all screens.
            var rects = X11DisplayComponent.GetDisplayRects();
            foreach (var rect in rects)
            {
                Box2i overlap = bounds.Intersected(rect.Bounds);

                if (overlap.SizeX * overlap.SizeY > bestArea)
                {
                    bestArea = overlap.SizeX * overlap.SizeY;
                    bestDisp = rect.Handle;
                }
                else if (bestArea <= 0)
                {
                    // If there is no overlap we are looking for the display which is closest.
                    float dist = Distance(bounds, rect.Bounds);
                    if (dist < bestDistance)
                    {
                        bestDistance = dist;
                        if (bestArea < 0)
                        {
                            bestDisp = rect.Handle;
                        }
                    }
                }
            }

            // FIXME: Maybe throw here?
            Debug.Assert(bestDisp != null);

            return bestDisp;

            // FIXME: Add a function like this to all Box types.
            static float Distance(Box2i a, Box2i b)
            {
                return Math.Min(
                    Math.Min(
                        a.DistanceToNearestEdge(b.Min),
                        a.DistanceToNearestEdge(b.Max)),
                    Math.Min(
                        a.DistanceToNearestEdge((b.Min.X, b.Max.Y)),
                        a.DistanceToNearestEdge((b.Min.Y, b.Max.X))));
            }
        }

        /// <inheritdoc />
        /// <remarks>
        /// Calling this in rapid succession after <see cref="SetMode" /> will likely report the wrong mode as the X server hasn't updated the state of the window yet.
        /// We could add a delay where we wait for the server to change the window, but for now we leave it as it is.
        /// </remarks>
        public WindowMode GetMode(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (xwindow.FullscreenDisplay != null)
            {
                if (xwindow.IsExclusiveFullscreen)
                {
                    return WindowMode.ExclusiveFullscreen;
                }
                else
                {
                    return WindowMode.WindowedFullscreen;
                }
            }

            XSync(X11.Display, False);

            int result = XGetWindowProperty(
                X11.Display,
                xwindow.Window,
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
                const int WithdrawnState = 0;
                const int NormalState = 1;
                const int IconicState = 3;

                unsafe
                {
                    int state = *(int*)contents;
                    if (state == IconicState)
                    {
                        return WindowMode.Minimized;
                    }
                    else if (state == WithdrawnState)
                    {
                        return WindowMode.Hidden;
                    }
                }
            }

            if (contents != IntPtr.Zero)
            {
                XFree(contents);
            }

            WMState wmState = GetNETWMState(xwindow.Window);

            if (wmState.HasFlag(WMState.MaximizedHorz | WMState.MaximizedVert))
            {
                return WindowMode.Maximized;
            }

            if (wmState.HasFlag(WMState.Hidden))
            {
                return WindowMode.Hidden;
            }

            return WindowMode.Normal;
        }

        /// <inheritdoc />
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (xwindow.FullscreenDisplay != null && mode != WindowMode.WindowedFullscreen && mode != WindowMode.ExclusiveFullscreen)
            {
                // Go out of fullscreen!

                if (xwindow.IsExclusiveFullscreen)
                {
                    X11DisplayComponent.RestoreVideoMode(this, xwindow.FullscreenDisplay);
                }

                // FIXME: Do we need to check these?
                if (X11.Atoms[KnownAtoms._NET_WM_STATE] == XAtom.None)
                {
                    Logger?.LogWarning("Can't exit fullscreen. The window manager doesn't support _NET_WM_STATE. This should never happen.");
                    return;
                }

                if (X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN] == XAtom.None)
                {
                    Logger?.LogWarning("Can't exit fullscreen. The window manager doesn't support _NET_WM_STATE_FULLSCREEN.");
                    return;
                }

                XEvent e = new XEvent();
                ref XClientMessageEvent client = ref e.ClientMessage;

                client.Type = XEventType.ClientMessage;
                client.Serial = 0;
                client.SendEvent = 1;
                client.Display = X11.Display;
                client.Window = xwindow.Window;
                client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                client.Format = 32;
                unsafe
                {
                    client.l[0] = X11._NET_WM_STATE_REMOVE;
                    client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN].Id;
                    client.l[2] = 0;
                    client.l[3] = 1;
                    client.l[4] = 0;
                }

                int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                // Re-set the min and max limits that we removed when we went fullscreen.
                unsafe
                {
                    XSizeHints* hints = XAllocSizeHints();
                    XSizeHintFlags supplied;
                    XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

                    hints->MinWidth = xwindow.MinSize.Width ?? 0;
                    hints->MinHeight = xwindow.MinSize.Height ?? 0;
                    if (xwindow.MinSize.Width != null || xwindow.MinSize.Height != null)
                        hints->Flags |= XSizeHintFlags.MinSize;

                    hints->MaxWidth = xwindow.MaxSize.Width ?? 0;
                    hints->MaxHeight = xwindow.MaxSize.Height ?? 0;
                    if (xwindow.MaxSize.Width != null || xwindow.MaxSize.Height != null)
                        hints->Flags |= XSizeHintFlags.MaxSize;

                    XSetWMNormalHints(X11.Display, xwindow.Window, hints);
                    XFree(hints);
                }

                xwindow.FullscreenDisplay = null;
                xwindow.IsExclusiveFullscreen = false;
            }

            switch (mode)
            {
                case WindowMode.Normal:
                    {
                        // FIXME: There seems to be an issue where the window
                        // doesn't appear in the correct position after being unmapped.
                        XClearWindow(X11.Display, xwindow.Window);
                        XMapWindow(X11.Display, xwindow.Window);

                        // FIXME: We might need to do something if NET_WM is defined
                        // See: https://github.com/libsdl-org/SDL/blob/c5c94a6be6bfaccec9c41f6326bd4be6b2db8aea/src/video/x11/SDL_x11window.c#L1161
                        break;
                    }
                case WindowMode.Hidden:
                    {
                        // FIXME: Figure out what we really need to do here.

                        //GetClientPosition(xwindow, out int x, out int y);

                        XWithdrawWindow(X11.Display, xwindow.Window, X11.DefaultScreen);
                        XFlush(X11.Display);
                        //XUnmapWindow(X11.Display, xwindow.Window);

                        //XWindowChanges changes = default;
                        //changes.X = x;
                        //changes.Y = y;

                        // We do this so that the window gets re-mapped to the correct location
                        //XConfigureWindow(X11.Display, xwindow.Window, XWindowChangesMask.CWX | XWindowChangesMask.CWY, ref changes);
                        break;
                    }
                case WindowMode.Minimized:
                    {
                        if (IsMapped(xwindow))
                        {
                            XMapWindow(X11.Display, xwindow.Window);
                        }

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
                        if (IsMapped(xwindow))
                        {
                            XMapWindow(X11.Display, xwindow.Window);
                        }

                        if (X11.Atoms[KnownAtoms._NET_WM_STATE] == XAtom.None)
                        {
                            Logger?.LogWarning("Can't make window maximized. The window manager doesn't support _NET_WM_STATE.");
                            return;
                        }

                        if (X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ] == XAtom.None)
                        {
                            Logger?.LogWarning("Can't make window maximized. The window manager doesn't support _NET_WM_STATE_MAXIMIZED_HORZ.");
                            return;
                        }

                        if (X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ] == XAtom.None)
                        {
                            Logger?.LogWarning("Can't make window maximized. The window manager doesn't support _NET_WM_STATE_MAXIMIZED_HORZ.");
                            return;
                        }

                        XEvent e = new XEvent();

                        ref XClientMessageEvent client = ref e.ClientMessage;

                        client.Type = XEventType.ClientMessage;
                        client.Serial = 0;
                        client.SendEvent = 1;
                        client.Display = X11.Display;
                        client.Window = xwindow.Window;
                        client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
                        client.Format = 32;
                        unsafe
                        {
                            client.l[0] = X11._NET_WM_STATE_ADD;
                            client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_HORZ].Id;
                            client.l[2] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_MAXIMIZED_VERT].Id;
                            client.l[3] = 0;
                            client.l[4] = 0;
                        }

                        int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                        break;
                    }
                case WindowMode.WindowedFullscreen:
                    {
                        SetFullscreenDisplay(handle, null);
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        XDisplayHandle xdisplay = (XDisplayHandle)GetDisplay(handle);
                        X11DisplayComponent.GetVideoMode(this, xdisplay, out VideoMode videoMode);
                        SetFullscreenDisplay(handle, xdisplay, videoMode);
                        break;
                    }
                default:
                    break;
            }

            XFlush(X11.Display);
            XSync(X11.Display, False);
        }

        /// <inheritdoc />
        public void SetFullscreenDisplay(WindowHandle handle, DisplayHandle? display)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XDisplayHandle? xdisplay = display?.As<XDisplayHandle>(this);

            // FIXME: Save window position and size so we can restore later.

            if (xdisplay == null)
            {
                xdisplay = (XDisplayHandle)GetDisplay(xwindow);
            }

            if (X11.Atoms[KnownAtoms._NET_WM_STATE] == XAtom.None)
            {
                Logger?.LogWarning("Can't make window have exclusive fullscreen. The window manager doesn't support _NET_WM_STATE.");
                return;
            }

            if (X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN] == XAtom.None)
            {
                Logger?.LogWarning("Can't make window have exclusive fullscreen. The window manager doesn't support _NET_WM_STATE_FULLSCREEN.");
                return;
            }

            if (IsMapped(xwindow) == false)
            {
                XMapWindow(X11.Display, xwindow.Window);
            }

            XEvent e = new XEvent();
            ref XClientMessageEvent client = ref e.ClientMessage;

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = X11._NET_WM_STATE_ADD;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN].Id;
                client.l[2] = 0;
                client.l[3] = 1;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

            // FIXME: Disable compositor for this window?

            xwindow.FullscreenDisplay = xdisplay;
            xwindow.IsExclusiveFullscreen = false;

            // Set the window size to be the full size of the monitor.
            // Remove the max and min size from WM_NORMAL_HINTS.

            unsafe
            {
                XSizeHints* hints = XAllocSizeHints();
                XSizeHintFlags supplied;
                XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);
                hints->Flags &= ~XSizeHintFlags.MaxSize;
                hints->Flags &= ~XSizeHintFlags.MinSize;
                XSetWMNormalHints(X11.Display, xwindow.Window, hints);
                XFree(hints);
            }

            // FIXME: Do we need to do this?
            Box2i bounds = X11DisplayComponent.GetBounds(xdisplay);
            XMoveResizeWindow(X11.Display, xwindow.Window, bounds.X, bounds.Y, (uint)bounds.Width, (uint)bounds.Height);
        }

        /// <inheritdoc />
        public void SetFullscreenDisplay(WindowHandle handle, DisplayHandle display, VideoMode videoMode)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XDisplayHandle xdisplay = display.As<XDisplayHandle>(this);

            // FIXME: Save window position and size so we can restore later.

            if (X11.Atoms[KnownAtoms._NET_WM_STATE] == XAtom.None)
            {
                Logger?.LogWarning("Can't make window have exclusive fullscreen. The window manager doesn't support _NET_WM_STATE.");
                return;
            }

            if (X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN] == XAtom.None)
            {
                Logger?.LogWarning("Can't make window have exclusive fullscreen. The window manager doesn't support _NET_WM_STATE_FULLSCREEN.");
                return;
            }

            if (IsMapped(xwindow) == false)
            {
                XMapWindow(X11.Display, xwindow.Window);
            }

            // FIXME: Some way to restore the video mode after the change?
            // Set the display to use the video mode.
            X11DisplayComponent.SetVideoMode(this, xdisplay, videoMode);

            XEvent e = new XEvent();
            ref XClientMessageEvent client = ref e.ClientMessage;

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = X11._NET_WM_STATE_ADD;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_FULLSCREEN].Id;
                client.l[2] = 0;
                client.l[3] = 1;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

            // FIXME: Disable compositor for this window?

            xwindow.FullscreenDisplay = xdisplay;
            xwindow.IsExclusiveFullscreen = true;

            // Set the window size to be the full size of the monitor.
            // Remove the max and min size from WM_NORMAL_HINTS.

            unsafe
            {
                XSizeHints* hints = XAllocSizeHints();
                XSizeHintFlags supplied;
                XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);
                hints->Flags &= ~XSizeHintFlags.MaxSize;
                hints->Flags &= ~XSizeHintFlags.MinSize;
                XSetWMNormalHints(X11.Display, xwindow.Window, hints);
                XFree(hints);
            }

            // FIXME: Do we need to do this?
            Box2i bounds = X11DisplayComponent.GetBounds(xdisplay);
            XMoveResizeWindow(X11.Display, xwindow.Window, bounds.X, bounds.Y, (uint)bounds.Width, (uint)bounds.Height);
        }

        /// <inheritdoc />
        public bool GetFullscreenDisplay(WindowHandle handle, [NotNullWhen(true)] out DisplayHandle? display)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            display = xwindow.FullscreenDisplay;
            return display != null;
        }

        /// <inheritdoc />
        /// <remarks>
        /// Calling this in rapid succession after <see cref="SetBorderStyle" /> will likely report the wrong style as the X server hasn't updated the state of the window yet.
        /// We could add a delay where we wait for the server to change the window, but for now we leave it as it is.
        /// </remarks>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // Check for ToolBox
            {
                XGetWindowProperty(
                    X11.Display,
                    xwindow.Window,
                    X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE],
                    0, 1, false,
                    X11.Atoms[KnownAtoms.ATOM],
                    out _,
                    out _,
                    out _,
                    out _,
                    out IntPtr content);

                // If window type is UTILITY, assume toolbox.
                unsafe {
                    XAtom windowType = *(XAtom*)content;
                    if (windowType == X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_UTILITY])
                    {
                        return WindowBorderStyle.ToolBox;
                    }
                }

                XFree(content);
            }

            // Check for borderless
            {
                XGetWindowProperty(
                    X11.Display,
                    xwindow.Window,
                    X11.Atoms[KnownAtoms._MOTIF_WM_HINTS],
                    0, long.MaxValue, false,
                    X11.Atoms[KnownAtoms._MOTIF_WM_HINTS],
                    out _,
                    out _,
                    out _,
                    out _,
                    out IntPtr content);

                // If decorations are turned off, assume borderless.
                unsafe {
                    MotifWmHints* motifWmHints = (MotifWmHints*)content;
                    if (motifWmHints->decorations == 0)
                    {
                        return WindowBorderStyle.Borderless;
                    }
                }

                XFree(content);
            }

            // If FixedSize is set, assume FixedBorder.
            if (xwindow.FixedSize != (-1, -1))
            {
                return WindowBorderStyle.FixedBorder;
            }

            return WindowBorderStyle.ResizableBorder;
        }

        /// <inheritdoc />
        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            switch (style)
            {
                case WindowBorderStyle.ResizableBorder:
                unsafe {
                    SetNetWMWindowType(xwindow.Window, X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_NORMAL]);

                    SetDecorations(xwindow, true);

                    SetFixedSize(xwindow, false, -1, -1);
                    xwindow.FixedSize = (-1, -1);
                    break;
                }
                case WindowBorderStyle.Borderless:
                unsafe {
                    // FIXME: Should the client size and location be retained when going borderless?
                    SetNetWMWindowType(xwindow.Window, X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_NORMAL]);

                    SetDecorations(xwindow, false);

                    SetFixedSize(xwindow, false, -1, -1);
                    xwindow.FixedSize = (-1, -1);
                    break;
                }
                case WindowBorderStyle.FixedBorder:
                unsafe {
                    SetNetWMWindowType(xwindow.Window, X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_NORMAL]);
                    // FIXME: Figure out if you can still resize the window programatically.
                    SetDecorations(xwindow, true);

                    // Set the max and min height to the same.
                    GetClientSize(xwindow, out int width, out int height);
                    SetFixedSize(xwindow, true, width, height);
                    xwindow.FixedSize = (width, height);

                    break;
                }
                case WindowBorderStyle.ToolBox:
                {
                    // FIXME: Check that the window type atoms are available?
                    SetNetWMWindowType(xwindow.Window, X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_UTILITY]);

                    SetDecorations(xwindow, true);

                    SetFixedSize(xwindow, false, -1, -1);
                    xwindow.FixedSize = (-1, -1);
                    break;
                }
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, typeof(WindowBorderStyle));
            }

            static unsafe void SetFixedSize(XWindowHandle xwindow, bool fixSize, int fixedWidth, int fixedHeight)
            {
                XSizeHints* hints = XAllocSizeHints();
                XSizeHintFlags supplied;
                XGetWMNormalHints(X11.Display, xwindow.Window, hints, &supplied);

                if (fixSize == false)
                {
                    // We default these to max values so that leaving one as null
                    // effectively means not having a max.
                    hints->MaxWidth = xwindow.MaxSize.Width ?? int.MaxValue;
                    hints->MaxHeight = xwindow.MaxSize.Height ?? int.MaxValue;

                    hints->MinWidth = xwindow.MinSize.Width ?? 0;
                    hints->MinHeight = xwindow.MinSize.Height ?? 0;

                    // If we have either a max width or max height, we specify it.
                    // And if both are null we remove the flag.
                    if (xwindow.MaxSize.Width != null || xwindow.MaxSize.Height != null)
                        hints->Flags |= XSizeHintFlags.MaxSize;
                    else
                        hints->Flags &= ~XSizeHintFlags.MaxSize;

                    if (xwindow.MinSize.Width != null || xwindow.MinSize.Height != null)
                        hints->Flags |= XSizeHintFlags.MinSize;
                    else
                        hints->Flags &= ~XSizeHintFlags.MinSize;
                }
                else
                {
                    hints->MinWidth = fixedWidth;
                    hints->MaxWidth = fixedWidth;

                    hints->MinHeight = fixedHeight;
                    hints->MaxHeight = fixedHeight;

                    hints->Flags |= XSizeHintFlags.MinSize | XSizeHintFlags.MaxSize;
                }

                XSetWMNormalHints(X11.Display, xwindow.Window, hints);

                XFree(hints);
            }

            static unsafe void SetDecorations(XWindowHandle xwindow, bool enable)
            {
                // We use
                const int MWM_HINTS_DECORATIONS = 1 << 1;

                const int MWM_DECOR_ALL = 1 << 0;

                MotifWmHints hints = default;
                hints.flags = MWM_HINTS_DECORATIONS;
                hints.decorations = enable ? MWM_DECOR_ALL : 0;

                XChangeProperty(X11.Display,
                        xwindow.Window,
                        X11.Atoms[KnownAtoms._MOTIF_WM_HINTS],
                        X11.Atoms[KnownAtoms._MOTIF_WM_HINTS],
                        32,
                        XPropertyMode.Replace,
                        (IntPtr)(void*)&hints,
                        sizeof(MotifWmHints) / sizeof(long));
            }

            static unsafe int SetNetWMWindowType(XWindow window, XAtom type)
            {
                return XChangeProperty(
                        X11.Display,
                        window,
                        X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE],
                        X11.Atoms[KnownAtoms.ATOM], 32,
                        XPropertyMode.Replace,
                        (IntPtr)(void*)&type,
                        1);
            }
        }

        /// <inheritdoc />
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

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = floating ? X11._NET_WM_STATE_ADD : X11._NET_WM_STATE_REMOVE;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_ABOVE].Id;
                client.l[2] = 0;
                client.l[3] = 0;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            xwindow.HitTest = test;
        }

        /// <inheritdoc />
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XCursorHandle? xcursor = cursor?.As<XCursorHandle>(this);

            XDefineCursor(X11.Display, xwindow.Window, xcursor?.Cursor ?? XCursor.None);
        }

        /// <inheritdoc />
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            return xwindow.CaptureMode;
        }

        /// <inheritdoc />
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            switch (mode)
            {
                case CursorCaptureMode.Normal:
                    {
                        if (CursorCapturingWindow == xwindow)
                        {
                            CursorCapturingWindow = null;

                            XUngrabPointer(X11.Display, XTime.CurrentTime);
                        }

                        break;
                    }
                case CursorCaptureMode.Confined:
                    {
                        CursorCapturingWindow = xwindow;

                        GrabResult result = XGrabPointer(X11.Display, xwindow.Window,
                            true, // FIXME: What does this mean?
                            XEventMask.ButtonPress | XEventMask.ButtonRelease | XEventMask.PointerMotion,
                            GrabMode.GrabModeAsync, GrabMode.GrabModeAsync,
                            xwindow.Window,
                            XCursor.None,
                            XTime.CurrentTime);

                        if (result != GrabResult.GrabSuccess)
                        {
                            Logger?.LogWarning($"Could not capture cursor. Reason: {result}");
                        }

                        break;
                    }
                case CursorCaptureMode.Locked:
                    {
                        CursorCapturingWindow = xwindow;

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(CursorCaptureMode));
            }
        }

        /// <inheritdoc />
        public void FocusWindow(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XRaiseWindow(X11.Display, xwindow.Window);
            XSetInputFocus(X11.Display, xwindow.Window, RevertTo.RevertToPointerRoot, XTime.CurrentTime);
        }

        /// <inheritdoc />
        public void RequestAttention(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            unsafe
            {
                XWMHints* hints = XGetWMHints(X11.Display, xwindow.Window);
                if (hints == null)
                {
                    Logger?.LogWarning("Could not request attentiion. XGetWMHints failed.");
                    return;
                }

                hints->flags |= XWMHintsMask.UrgencyHint;

                XSetWMHints(X11.Display, xwindow.Window, hints);

                XFree(hints);
            }
        }

        /// <summary>
        /// Indicates that this window demands immediate attention.
        /// On Ubuntu, this means a popup indicating that the application is ready.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        public void DemandAttention(WindowHandle handle)
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

            client.Type = XEventType.ClientMessage;
            client.Serial = 0;
            client.SendEvent = 1;
            client.Display = X11.Display;
            client.Window = xwindow.Window;
            client.MessageType = X11.Atoms[KnownAtoms._NET_WM_STATE];
            client.Format = 32;
            unsafe
            {
                client.l[0] = X11._NET_WM_STATE_ADD;
                client.l[1] = (long)X11.Atoms[KnownAtoms._NET_WM_STATE_DEMANDS_ATTENTION].Id;
                client.l[2] = 0;
                client.l[3] = 0;
                client.l[4] = 0;
            }

            int status = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        /// <inheritdoc />
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, X11.DefaultRootWindow, xwindow.Window, x, y, out clientX, out clientY, out _);

            // FIXME: Extents?
        }

        /// <inheritdoc />
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, xwindow.Window, X11.DefaultRootWindow, clientX, clientY, out x, out y, out _);

            // FIXME: Extents?
        }
    }
}
