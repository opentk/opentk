using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.GLX;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.XI2.XI2;
using OpenTK.Platform.Native.X11.XRandR;
using OpenTK.Platform.Native.X11.XI2;
using OpenTK.Core;

namespace OpenTK.Platform.Native.X11
{
    public class X11WindowComponent : IWindowComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11WindowComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private unsafe XErrorHandler ErrorHandler;

        private unsafe int XErrorHandler(XDisplayPtr display, XErrorEvent* error_event)
        {
            StringBuilder errorMessage = new StringBuilder(1024);
            XGetErrorText(X11.Display, (int)error_event->error_code, errorMessage, errorMessage.Capacity);

            Logger?.LogError($"Error: {errorMessage}, Type: {error_event->type}, S: {error_event->serial}, Error code: {error_event->error_code}, Request code: {error_event->request_code}, Minor code: {error_event->minor_code}");
            
            return (int)error_event->error_code;
        }

        internal static readonly Dictionary<XWindow, XWindowHandle> XWindowDict = new Dictionary<XWindow, XWindowHandle>();

        internal static XWindowHandle? CursorCapturingWindow;

        internal static XWindow HelperWindow { get; private set; }

        internal static XCursor EmptyCursor;
        
        internal static XIM IM { get; set; }

        internal static string ApplicationName;

        internal XAtom OpenTKUserMessageType;

        internal GCHandle ComponentGCHandle;

        internal bool IsOnXWayland = false;


        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            ComponentGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);

            ErrorHandler = XErrorHandler;
            XSetErrorHandler(ErrorHandler);

            // Later on we can replace this with a hint.
            string? displayName = null;
            X11.Display = XOpenDisplay(displayName);
            if (X11.Display.Value == IntPtr.Zero)
            {
                throw new PalException(this, (displayName is null) ? "Could not open default X display." : $"Could not open X display {displayName}.");
            }

            X11.DefaultScreen = XDefaultScreen(X11.Display);
            X11.DefaultRootWindow = XDefaultRootWindow(X11.Display);

            ApplicationName = options.ApplicationName;

            EmptyCursor = X11CursorComponent.CreateEmpty();

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
            
            int result = XGetWindowProperty(
                X11.Display,
                X11.DefaultRootWindow,
                X11.Atoms[KnownAtoms._NET_SUPPORTING_WM_CHECK],
                0, 8,
                false,
                X11.Atoms[KnownAtoms.WINDOW],
                out _,
                out _,
                out long count,
                out _,
                out IntPtr array);

            if (result != Success || count == 0)
            {
                Logger?.LogInfo("Root window did not have the _NET_SUPPORTING_WM_CHECK property. WM is not freedesktop compliant.");
                if (array != IntPtr.Zero)
                {
                    XFree(array);
                }
            }
            else
            {
                unsafe
                {
                    wm_window = *(XWindow*)array;
                    XFree(array);
                }

                result = XGetWindowProperty(
                    X11.Display,
                    wm_window,
                    X11.Atoms[KnownAtoms._NET_SUPPORTING_WM_CHECK], 
                    0, 8,
                    false,
                    X11.Atoms[KnownAtoms.WINDOW],
                    out _,
                    out _,
                    out count,
                    out _,
                    out array);

                if (result != Success || count == 0)
                {
                    Logger?.LogInfo($"Window pointed to by the root windows' _NET_SUPPORTING_WM_CHECK property didn't have a _NET_SUPPORTING_WM_CHECK property. WM is not freedesktop compliant.");
                    if (array != IntPtr.Zero)
                    {
                        XFree(array);
                    }
                }
                else
                {
                    XWindow wm_window2;
                    unsafe
                    {
                        wm_window2 = *(XWindow*)array;
                        XFree(array);
                    }

                    if (wm_window != wm_window2)
                    {
                        Logger?.LogInfo("Window pointed to by the root windows' _NET_SUPPORTING_WM_CHECK property didn't have itself set in it's _NET_SUPPORTING_WM_CHECK property . WM is not freedesktop compliant.");
                    }
                    else
                    {
                        IsWindowManagerFreedesktop = true;

                        result = XGetWindowProperty(
                            X11.Display,
                            wm_window,
                            X11.Atoms[KnownAtoms._NET_WM_NAME],
                            0,
                            long.MaxValue,   // FIXME: Is this worth two rountrips to measure name size and then read?
                            false,
                            X11.Atoms[KnownAtoms.UTF8_STRING],
                            out _,
                            out _,
                            out count,
                            out _,
                            out array);

                        if (result != Success || count == 0)
                        {
                            Logger?.LogWarning("Wasn't able to get _NET_WM_NAME.");
                            if (array != IntPtr.Zero)
                            {
                                XFree(array);
                            }
                        }
                        else
                        {
                            FreedesktopWindowManagerName = Marshal.PtrToStringUTF8(array);
                            XFree(array);
                        }
                    }
                }
            }

            if (IsWindowManagerFreedesktop)
            {
                Logger?.LogInfo($"Found Freedesktop Compliant Window Manager '{FreedesktopWindowManagerName}'.");

                result = XGetWindowProperty(
                    X11.Display, 
                    X11.DefaultRootWindow, 
                    X11.Atoms![KnownAtoms._NET_SUPPORTED], 
                    0, long.MaxValue,
                    false,
                    X11.Atoms[KnownAtoms.ATOM],
                    out _,
                    out _,
                    out count,
                    out _,
                    out array);

                if (result != Success)
                {
                    Logger?.LogWarning("Could not read _NET_SUPPORTED.");
                    if (array != IntPtr.Zero)
                    {
                        XFree(array);
                    }
                }
                else
                {
                    unsafe
                    {
                        Span<XAtom> atoms = new Span<XAtom>((void*)array, (int)count);
                        // TODO: Figure how to extract win32 like window types and modes from the supported atoms list.
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < atoms.Length; i++)
                        {
                            sb.Append(atoms[i]);
                            sb.Append(", ");
                        }
                        sb.Length -= ", ".Length;
                        Logger?.LogInfo($"_NET_SUPPORTED: {sb}");
                        XFree(array);
                    }
                }
            }

            // Create a helper window to help with clipboard stuff.
            // FIXME: Will this only be used for clipboard stuff?
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

            if (XQueryExtension(X11.Display, "XFIXES", out int xfixes_opcode, out int xfixes_event_base, out int xfixes_error_base))
            {
                X11.XFixesAvailable = true;
                X11.XFixesEventBase = xfixes_event_base;
                X11.XFixesErrorBase = xfixes_error_base;

                // Register for clipboard updates.
                XFixes.XFixesSelectSelectionInput(X11.Display, X11.DefaultRootWindow, X11.Atoms[KnownAtoms.CLIPBOARD], XFixes.SelectionEventMask.SetSelectionOwnerNotifyMask);
            }
            else
            {
                Logger?.LogWarning("XFIXES extension not supported. Clipboard update events will not be supported.");
            }

            // See: https://cgit.freedesktop.org/xorg/proto/xorgproto/tree/xwaylandproto.txt?id=ad6412624ef6dc4d7548fe16c254c4166ffa7198
            if (XQueryExtension(X11.Display, "XWAYLAND", out _, out _, out _))
            {
                IsOnXWayland = true;
            }

            {
                // FIXME: Maybe specify res_name and res_class?
                bool success = XRegisterIMInstantiateCallback(X11.Display, new XrmDatabase(0), null, null, IMInstantiatedCallbackInst, (IntPtr)ComponentGCHandle);
                if (success == false) {
                    Logger?.LogWarning("Was not able to register to IM (input method) instatiate callbacks. This means we will not be able to detect a late start of IM servers or dynamically switch IM.");
                }
            }

            string? prevLocale = Libc.setlocale(Libc.LC.LC_ALL, null);
            string? prevModifiers = XSetLocaleModifiers(null);

            Libc.setlocale(Libc.LC.LC_CTYPE, "");
            string? picked = XSetLocaleModifiers("");
            IM = XOpenIM(X11.Display, new XrmDatabase(0), null, null);
            if (IM.Value == 0)
            {
                Logger?.LogDebug("XOpenIM failed, trying with '@im=none'.");
                XSetLocaleModifiers("@im=none");
                IM = XOpenIM(X11.Display, new XrmDatabase(0), null, null);
            }

            Libc.setlocale(Libc.LC.LC_ALL, prevLocale);
            XSetLocaleModifiers(prevModifiers);

            {
                XIMStyles* styles = default;
                ReadOnlySpan<byte> str = Utils.ToSpan(XGetIMValues(IM, Utils.AsPtr(XNQueryInputStyle), (IntPtr)(&styles), 0));
                for (int i = 0; i < styles->count_styles; i++)
                {
                    Logger?.LogDebug($"{i}: {styles->supported_styles[i]}");
                }
                XFree(styles);

                XIMValuesList* values = default;
                XGetIMValues(IM, Utils.AsPtr(XNQueryIMValuesList), (IntPtr)(&values), 0);
                Logger?.LogDebug("IM values:");
                for (int i = 0; i < values->count_values; i++)
                {
                    var span = Utils.ToSpan(values->supported_values[i]);
                    Logger?.LogDebug($"{i}: {Encoding.UTF8.GetString(span)}");
                }
                XFree(values);

                Logger?.LogDebug("");

                values = default;
                XGetIMValues(IM, Utils.AsPtr(XNQueryICValuesList), (IntPtr)(&values), 0);
                Logger?.LogDebug("IC values:");
                for (int i = 0; i < values->count_values; i++)
                {
                    var span = Utils.ToSpan(values->supported_values[i]);
                    Logger?.LogDebug($"{i}: {Encoding.UTF8.GetString(span)}");
                }
                XFree(values);

                XIMCallback destroyCallback = new XIMCallback((IntPtr)ComponentGCHandle, &IMDestroyCallback);
                if (XSetIMValues(IM, Utils.AsPtr(XNDestroyCallback), (IntPtr)(&destroyCallback), 0) != null)
                {
                    Logger?.LogWarning("Failed to set the IM (input method) destroy callback. Will not be able to detect IM destruction.");
                }
            }

            /*
            if (XQueryExtension(X11.Display, "XInputExtension", out int opcode, out int @event, out int error) == false)
            {
                Logger?.LogInfo("XInputExtension is not available.");
                X11.XI2Available = false;
            }
            else
            {
                int major = 2, minor = 0;
                if (XIQueryVersion(X11.Display, ref major, ref minor) == XStatus.Success)
                {
                    X11.XI2Available = true;
                }
                else
                {
                    Logger?.LogInfo($"XI2 not available. Available version: {major}.{minor}.");
                    X11.XI2Available = false;
                }
            }
            */

            OpenTKUserMessageType = XInternAtom(X11.Display, "OPENTK_USER_MESSAGE", false);
        }

        internal IMInstantiateCallback IMInstantiatedCallbackInst = IMInstantiatedCallback;
        static void IMInstantiatedCallback(XDisplayPtr display, IntPtr client_data, IntPtr call_data)
        {
            X11WindowComponent? comp = GCHandle.FromIntPtr(client_data).Target as X11WindowComponent;

            comp?.Logger?.LogInfo("IM instantiate callback!");
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        static void IMDestroyCallback(XIM im, IntPtr client_data, IntPtr call_data)
        {
            X11WindowComponent? comp = GCHandle.FromIntPtr(client_data).Target as X11WindowComponent;

            comp?.Logger?.LogInfo("IM destroyed.");
        }

        /// <inheritdoc/>
        public unsafe void Uninitialize()
        {
            // FIXME: Do something with CursorCapturingWindow?

            foreach (var (_, xwindow) in XWindowDict)
            {
                Logger?.LogWarning($"Window {GetTitle(xwindow)} is still open when uninitializing Toolkit. Please close all windows before uninitializing.");
                Destroy(xwindow);
            }

            XDestroyWindow(X11.Display, HelperWindow);

            bool success = XUnregisterIMInstantiateCallback(X11.Display, new XrmDatabase(0), null, null, IMInstantiatedCallbackInst, (IntPtr)ComponentGCHandle);
            if (success == false)
            {
                Logger?.LogInfo("Was not able to unregister IM instantiate callback.");
            }

            // FIXME: Should we reset the error handler?
            // XSetErrorHandler(null);

            XCloseDisplay(X11.Display);

            ComponentGCHandle.Free();
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => true;

        /// <inheritdoc/>
        public bool CanCaptureCursor => true;

        private static List<WindowBorderStyle> s_emptyStyleList = new List<WindowBorderStyle>();

        private static readonly WindowMode[] _SupportedModes = new[]
        {
            WindowMode.Hidden,
            WindowMode.Normal,
            WindowMode.Minimized,
            WindowMode.Maximized,
            WindowMode.WindowedFullscreen,
            WindowMode.ExclusiveFullscreen,
        };

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents { get => throw new NotImplementedException(); }

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles { get; private set; } = s_emptyStyleList;

        /// <inheritdoc/>
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

            if (result == Success)
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

        /// <inheritdoc/>
        public void ProcessEvents(bool waitForEvents)
        {
            XEvent ea = new XEvent();
            if (waitForEvents)
            {
                // Wait for atleast one event before we continue.
                XNextEvent(X11.Display, out ea);
                XPutBackEvent(X11.Display, in ea);
            }

            while (XEventsQueued(X11.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
            {
                XNextEvent(X11.Display, out ea);
                bool filtered = XFilterEvent(ref ea, XWindow.None);
                if (ea.Type != XEventType.KeyPress && ea.Type != XEventType.KeyRelease)
                {
                    if (filtered)
                        continue;
                }
                
                // Update the current timestamp.
                switch (ea.Type)
                {
                    case XEventType.KeyPress:
                        X11.SetLastTime(ea.KeyPressed.window, ea.KeyPressed.time);
                        break;
                    case XEventType.KeyRelease:
                        X11.SetLastTime(ea.KeyReleased.window, ea.KeyReleased.time);
                        break;
                    case XEventType.ButtonPress:
                        X11.SetLastTime(ea.ButtonPressed.window, ea.ButtonPressed.time);
                        break;
                    case XEventType.ButtonRelease:
                        X11.SetLastTime(ea.ButtonReleased.window, ea.ButtonReleased.time);
                        break;
                    case XEventType.MotionNotify:
                        //X11.SetLastTime(ea.Motion.window, ea.Motion.time);
                        break;
                    case XEventType.EnterNotify:
                        //X11.SetLastTime(ea.Enter.window, ea.Enter.time);
                        break;
                    case XEventType.LeaveNotify:
                        //X11.SetLastTime(ea.Leave.window, ea.Leave.time);
                        break;
                    // FIXME: This causes an infinite loop with _NET_WM_USER_TIME.
                    // Maybe filter out this specific property?
                    //case XEventType.PropertyNotify:
                    //    X11.SetLastTime(ea.Property.window, ea.Property.time);
                    //    break;
                    case XEventType.SelectionNotify:
                        // FIXME: Should we count this time?
                        //X11.SetLastTime(ea.Selection.requestor, ea.Selection.time);
                        break;
                    default:
                        if (ea.Type == (XEventType)(X11.XFixesEventBase + XFixes.SelectionEvent.SetSelectionOwner))
                        {
                            XFixes.XFixesSelectionNotifyEvent selectionNotify = Unsafe.As<XEvent, XFixes.XFixesSelectionNotifyEvent>(ref ea);
                            //X11.SetLastTime(selectionNotify.window, selectionNotify.timestamp);
                        }
                        break;
                }

                if (XWindowDict.TryGetValue(ea.Any.Window, out XWindowHandle? xwindow) == false)
                {
                    // If this was not for one our windows and it was filtered by XIM
                    // we don't process it.
                    if (filtered) continue;

                    if (ea.Any.Window == X11.DefaultRootWindow)
                    {
                        if (ea.Type == (XEventType)(X11.XFixesEventBase + XFixes.SelectionEvent.SetSelectionOwner))
                        {
                            // XFixesSelectionNotify
                            XFixes.XFixesSelectionNotifyEvent selectionNotify = Unsafe.As<XEvent, XFixes.XFixesSelectionNotifyEvent>(ref ea);

                            // Get the format of the selection.
                            if (selectionNotify.selection == X11.Atoms[KnownAtoms.CLIPBOARD])
                            {
                                ClipboardFormat format = X11ClipboardComponent.GetSelectionFormat(X11.Atoms[KnownAtoms.CLIPBOARD], X11ClipboardComponent.OpenTKSelection, Logger);

                                EventQueue.Raise(null, PlatformEventType.ClipboardUpdate, new ClipboardUpdateEventArgs(format));
                            }
                        }
                        else if (ea.Type >= (XEventType)(X11.XRandREventBase) && ea.Type <= (XEventType)(X11.XRandREventBase + RREventType.RRNotify))
                        {
                            X11DisplayComponent.HandleXRREvent(ea, Logger);
                        }
                        else
                        {

                            if (ea.Type == XEventType.PropertyNotify)
                            {

                                Logger?.LogDebug($"Received unhandled PropertyNotify ({ea.Property.atom} {ea.Property.state}) for root window");
                            }
                            else
                            {
                                Logger?.LogDebug($"Received unhandled event {ea.Type} for root window.");
                            }
                        }
                    }
                    else if (ea.Any.Window == HelperWindow)
                    {
                        if (ea.Type == XEventType.ClientMessage &&
                            ea.ClientMessage.MessageType == OpenTKUserMessageType)
                        {
                            unsafe
                            {
                                IntPtr ptr = (IntPtr)(ea.ClientMessage.l[1] << 32 | (ea.ClientMessage.l[0] & 0xFFFFFFFF));
                                GCHandle handle = GCHandle.FromIntPtr(ptr);
                                EventArgs args = (EventArgs)handle.Target!;
                                if (args is WindowEventArgs windowArgs)
                                {
                                    EventQueue.Raise(windowArgs.Window, PlatformEventType.UserMessage, windowArgs);
                                }
                                else
                                {
                                    EventQueue.Raise(null, PlatformEventType.UserMessage, args);
                                }
                                handle.Free();
                            }
                        }
                        else if (ea.Type == XEventType.PropertyNotify &&
                            ea.Property.atom == X11ClipboardComponent.OpenTKSelection)
                        {
                            // If some other window takes ownership of the a selection we expect this.
                        }
                        else if (ea.Type == XEventType.SelectionClear ||
                                 ea.Type == XEventType.SelectionNotify ||
                                 ea.Type == XEventType.SelectionRequest)
                        {
                            X11ClipboardComponent.HandleClipboardEvent(ref ea, Logger);
                        }
                        else
                        {
                            Logger?.LogDebug($"Received unhandled event {ea.Type} for helper window.");
                        }
                    }
                    else
                    {
                        // This event likely for a deleted window.
                        Logger?.LogDebug($"Received event {ea.Type} for an unknown (likely destroyed) window {ea.Any.Window}.");
                    }
                    continue;
                }

                switch (ea.Type)
                {
                    case XEventType.ClientMessage:
                        {
                            XClientMessageEvent clientMessage = ea.ClientMessage;

                            unsafe
                            {
                                // FIXME: Check message_type for WM_PROTOCOLS?

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
                                // FIXME: Should we really check == 32?
                                else if (clientMessage.MessageType == X11.Atoms[KnownAtoms.XdndEnter])
                                {
                                    bool use_list = (clientMessage.l[1] & 1) != 0;

                                    XAtom type;
                                    if (use_list)
                                    {
                                        int result = XGetWindowProperty(
                                            X11.Display,
                                            new XWindow((ulong)clientMessage.l[0]),
                                            X11.Atoms[KnownAtoms.XdndTypeList],
                                            0, long.MaxValue,
                                            false,
                                            X11.Atoms[KnownAtoms.ATOM],
                                            out XAtom actualType,
                                            out int actualFormat,
                                            out long numberOfItems,
                                            out long remainingBytes,
                                            out IntPtr contents);

                                        Span<XAtom> list = new Span<XAtom>((XAtom*)contents, (int)numberOfItems);
                                        type = ChooseType(list);

                                        if (contents != IntPtr.Zero)
                                        {
                                            XFree(contents);
                                        }
                                    }
                                    else
                                    {
                                        Span<XAtom> list = new Span<XAtom>(&clientMessage.l[2], 3);
                                        type = ChooseType(list);
                                    }

                                    // Save this data so that we can respond to the other dnd events
                                    xwindow.XDnDVersion = (int)(clientMessage.l[1] >>> 24);
                                    xwindow.XDnDType = type;
                                    xwindow.XDnDSource = new XAtom((ulong)clientMessage.l[0]);

                                    // FIXME: Send a DropBegin event?

                                    static XAtom ChooseType(Span<XAtom> types)
                                    {
                                        XAtom uriList = XInternAtom(X11.Display, "text/uri-list", false);
                                        XAtom plain = XInternAtom(X11.Display, "text/plain", false);

                                        foreach (XAtom type in types)
                                        {
                                            if (type == uriList || type == plain)
                                            {
                                                return type;
                                            }
                                        }

                                        return XAtom.None;
                                    }
                                }
                                else if (clientMessage.MessageType == X11.Atoms[KnownAtoms.XdndPosition])
                                {
                                    int root_x = (int)(clientMessage.l[2] >> 16);
                                    int root_y = (int)(clientMessage.l[2] & 0xFFFF);
                                    // FIXME: Global or local coordinates?
                                    //EventQueue.Raise(xwindow, PlatformEventType.DropLocation, new DropLocationEventArgs((root_x, root_y)));

                                    XWindow source = new XWindow((ulong)clientMessage.l[0]);

                                    XEvent @event = default;
                                    ref XClientMessageEvent status = ref @event.ClientMessage;
                                    status.Type = XEventType.ClientMessage;
                                    status.Display = clientMessage.Display;
                                    status.Window = source;
                                    status.MessageType = X11.Atoms[KnownAtoms.XdndStatus];
                                    status.Format = 32;
                                    status.l[0] = (long)xwindow.Window.Id;
                                    status.l[1] = (xwindow.XDnDType != XAtom.None) ? 1 : 0;
                                    status.l[2] = 0;
                                    status.l[3] = 0;
                                    // FIXME: Do we want to support other actions?
                                    status.l[4] = (long)X11.Atoms[KnownAtoms.XdndActionCopy].Id;
                                    XSendEvent(X11.Display, source, 0, XEventMask.None, @event);
                                    // FIXME: SDL does XFlush here, do we need that?
                                }
                                else if (clientMessage.MessageType == X11.Atoms[KnownAtoms.XdndLeave])
                                {
                                    // FIXME: Send DropEnd/DropCancelled event?
                                    xwindow.XDnDSource = default;
                                    xwindow.XDnDType = default;
                                    xwindow.XDnDVersion = default;

                                    // FIXME:
                                    //EventQueue.Raise(DropEnd);
                                }
                                else if (clientMessage.MessageType == X11.Atoms[KnownAtoms.XdndDrop])
                                {
                                    if (xwindow.XDnDType != XAtom.None)
                                    {
                                        // FIXME: Possibly unify with the similar clipboard code.
                                        XConvertSelection(
                                            X11.Display,
                                            X11.Atoms[KnownAtoms.XdndSelection],
                                            xwindow.XDnDType,
                                            X11.Atoms[KnownAtoms.PRIMARY],
                                            xwindow.Window,
                                            // FIXME: Maybe return CurrentTime if xdnd version is <1?
                                            new XTime((ulong)clientMessage.l[2]));

                                        XEvent notification;
                                        while (XCheckTypedWindowEvent(X11.Display, xwindow.Window, XEventType.SelectionNotify, out notification) == false)
                                        {
                                            X11.WaitForXEvents();
                                        }

                                        // FIXME: Able to differentiate between different targets
                                        // Find the event and remove it from the queue
                                        XCheckIfEvent(X11.Display, out _, X11.IsSelectionPropertyNewValueNotify, new IntPtr(&notification));

                                        int result = XGetWindowProperty(
                                            X11.Display,
                                            notification.Selection.requestor,
                                            X11.Atoms[KnownAtoms.PRIMARY],
                                            0, long.MaxValue, true,
                                            // FIXME: AnyPropertyType
                                            new XAtom(0),
                                            out XAtom actualType,
                                            out int actualFormat,
                                            out long numberOfItems,
                                            out long remainingBytes,
                                            out IntPtr data);

                                        if (result == Success)
                                        {
                                            if (actualType == X11.Atoms[KnownAtoms.INCR])
                                            {
                                                if (data != IntPtr.Zero)
                                                {
                                                    XFree(data);
                                                }
                                                throw new NotImplementedException("We don't support INCR here yet.");
                                            }
                                            else
                                            {
                                                string fullString = Marshal.PtrToStringUTF8(data)!;

                                                // FIXME: Handle the different formats!
                                                List<string> files = new List<string>();
                                                string[] lines = fullString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                                                for (int i = 0; i < lines.Length; i++)
                                                {
                                                    if (lines[i].StartsWith("#")) continue;
                                                    else if (lines[i].StartsWith("file://"))
                                                        files.Add(lines[i]["file://".Length..]);
                                                    else Logger?.LogDebug($"Got unknown file uri: {lines[i]}");
                                                }

                                                // FIXME: Get the last XdndPosition location!
                                                EventQueue.Raise(xwindow, PlatformEventType.FileDrop, new FileDropEventArgs(xwindow, files, (0, 0)));
                                            }
                                        }
                                        else
                                        {
                                            Logger?.LogWarning($"Could not read XdndDrop file list.");
                                        }

                                        if (data != IntPtr.Zero)
                                        {
                                            XFree(data);
                                        }
                                    }

                                    // End with sending XdndFinish.
                                    XEvent @event = default;
                                    ref XClientMessageEvent finish = ref @event.ClientMessage;
                                    finish.Type = XEventType.ClientMessage;
                                    finish.Display = clientMessage.Display;
                                    finish.Window = clientMessage.Window;
                                    finish.MessageType = X11.Atoms[KnownAtoms.XdndFinished];
                                    finish.Format = 32;
                                    finish.l[0] = (long)xwindow.Window.Id;
                                    finish.l[1] = (xwindow.XDnDType != XAtom.None) ? 1 : 0;
                                    finish.l[2] = (xwindow.XDnDType != XAtom.None) ?
                                                    (long)X11.Atoms[KnownAtoms.XdndActionCopy].Id :
                                                    (long)XAtom.None.Id;
                                    XSendEvent(
                                        X11.Display,
                                        new XWindow((ulong)clientMessage.l[0]),
                                        0,
                                        XEventMask.None,
                                        @event);

                                    xwindow.XDnDSource = default;
                                    xwindow.XDnDType = default;
                                    xwindow.XDnDVersion = default;
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

                                X11MouseComponent.RegisterMouseWheelDelta(xwindow, (xdelta, ydelta));
                                // FIXME: Scrolling distance? Are there scrolling settings on linux/x11?
                                EventQueue.Raise(xwindow, PlatformEventType.Scroll, new ScrollEventArgs(xwindow, (xdelta, ydelta), (xdelta, ydelta)));
                            }
                            else
                            {
                                // FIXME: Maybe we should be able to have hittests for more than button 1?
                                if (buttonPressed.button == 1 && xwindow.HitTest != null)
                                {
                                    // We do a hit test here to see if we should do something.
                                    HitType type = xwindow.HitTest(xwindow, new Vector2(buttonPressed.x, buttonPressed.y));
                                    switch (type)
                                    {
                                        case HitType.Draggable:
                                            {
                                                const long _NET_WM_MOVERESIZE_MOVE = 8;

                                                // FIXME: Do we need to regrab the pointer when the move is done?
                                                XUngrabPointer(X11.Display, XTime.CurrentTime);
                                                XFlush(X11.Display);

                                                XEvent e = new XEvent();
                                                ref XClientMessageEvent client = ref e.ClientMessage;
                                                client.Type = XEventType.ClientMessage;
                                                client.Window = xwindow.Window;
                                                client.MessageType = X11.Atoms[KnownAtoms._NET_WM_MOVERESIZE];
                                                client.Format = 32;
                                                unsafe
                                                {
                                                    client.l[0] = buttonPressed.x_root;
                                                    client.l[1] = buttonPressed.y_root;
                                                    client.l[2] = _NET_WM_MOVERESIZE_MOVE;
                                                    client.l[3] = buttonPressed.button;
                                                    client.l[4] = 0;
                                                }

                                                bool success = XSendEvent(X11.Display, XDefaultRootWindow(X11.Display), 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, in e);
                                                XSync(X11.Display, 0);
                                                continue;
                                            }
                                        case HitType.ResizeBottom:
                                        case HitType.ResizeBottomLeft:
                                        case HitType.ResizeBottomRight:
                                        case HitType.ResizeLeft:
                                        case HitType.ResizeRight:
                                        case HitType.ResizeTop:
                                        case HitType.ResizeTopLeft:
                                        case HitType.ResizeTopRight:
                                            {
                                                const long _NET_WM_MOVERESIZE_SIZE_TOPLEFT = 0;
                                                const long _NET_WM_MOVERESIZE_SIZE_TOP = 1;
                                                const long _NET_WM_MOVERESIZE_SIZE_TOPRIGHT = 2;
                                                const long _NET_WM_MOVERESIZE_SIZE_RIGHT = 3;
                                                const long _NET_WM_MOVERESIZE_SIZE_BOTTOMRIGHT = 4;
                                                const long _NET_WM_MOVERESIZE_SIZE_BOTTOM = 5;
                                                const long _NET_WM_MOVERESIZE_SIZE_BOTTOMLEFT = 6;
                                                const long _NET_WM_MOVERESIZE_SIZE_LEFT = 7;

                                                long direction;
                                                switch (type)
                                                {
                                                    case HitType.ResizeBottom: direction = _NET_WM_MOVERESIZE_SIZE_BOTTOM; break;
                                                    case HitType.ResizeBottomLeft: direction = _NET_WM_MOVERESIZE_SIZE_BOTTOMLEFT; break;
                                                    case HitType.ResizeBottomRight: direction = _NET_WM_MOVERESIZE_SIZE_BOTTOMRIGHT; break;
                                                    case HitType.ResizeLeft: direction = _NET_WM_MOVERESIZE_SIZE_LEFT; break;
                                                    case HitType.ResizeRight: direction = _NET_WM_MOVERESIZE_SIZE_RIGHT; break;
                                                    case HitType.ResizeTop: direction = _NET_WM_MOVERESIZE_SIZE_TOP; break;
                                                    case HitType.ResizeTopLeft: direction = _NET_WM_MOVERESIZE_SIZE_TOPLEFT; break;
                                                    case HitType.ResizeTopRight: direction = _NET_WM_MOVERESIZE_SIZE_TOPRIGHT; break;
                                                    default:
                                                        throw new UnreachableException($"Unknown resize hit type: {type}");
                                                }

                                                // FIXME: Do we need to regrab the pointer when the move is done?
                                                XUngrabPointer(X11.Display, XTime.CurrentTime);
                                                XFlush(X11.Display);

                                                XEvent e = new XEvent();
                                                ref XClientMessageEvent client = ref e.ClientMessage;
                                                client.Type = XEventType.ClientMessage;
                                                client.Window = xwindow.Window;
                                                client.MessageType = X11.Atoms[KnownAtoms._NET_WM_MOVERESIZE];
                                                client.Format = 32;
                                                unsafe
                                                {
                                                    client.l[0] = buttonPressed.x_root;
                                                    client.l[1] = buttonPressed.y_root;
                                                    client.l[2] = direction;
                                                    client.l[3] = buttonPressed.button;
                                                    client.l[4] = 0;
                                                }

                                                bool success = XSendEvent(X11.Display, XDefaultRootWindow(X11.Display), 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, in e);
                                                XSync(X11.Display, 0);

                                                // FIXME: Handle the resize!
                                                Logger?.LogWarning("Hit test resizing is not supported in x11 yet.");
                                                continue;
                                            }
                                        case HitType.Normal:
                                        case HitType.Default:
                                        default:
                                            break;
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

                                KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(buttonPressed.state);

                                X11MouseComponent.RegisterButtonState(xwindow, button, true);
                                EventQueue.Raise(xwindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(xwindow, button, modifiers));
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

                            KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(buttonReleased.state);

                            X11MouseComponent.RegisterButtonState(xwindow, button, false);
                            EventQueue.Raise(xwindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(xwindow, button, modifiers));

                            break;
                        }
                    case XEventType.KeyPress:
                        {
                            XKeyEvent keyPressed = ea.KeyPressed;

                            unsafe
                            {
                                XKeySym keysym = default;
                                const int TEXT_LENGTH = 64;
                                byte* str = stackalloc byte[TEXT_LENGTH];
                                int charsWritten = 0;

                                if (filtered == false)
                                {
                                    if (xwindow.IC.Value == IntPtr.Zero)
                                    {
                                        charsWritten = XLookupString(&keyPressed, str, TEXT_LENGTH, &keysym, null);
                                    }
                                    else
                                    {
                                        XLookupStatus lookupStatus;
                                        charsWritten = Xutf8LookupString(xwindow.IC, &keyPressed, str, TEXT_LENGTH, &keysym, &lookupStatus);
                                        if (lookupStatus == XLookupStatus.XBufferOverflow)
                                        {

                                            Logger?.LogError($"Xutf8LookupString wanted to write more than 64 bytes of text input. If this happens to you please open a issue at https://github.com/opentk/opentk/issues/new.");
                                        }

                                        Logger?.LogDebug($"LookupString: {new string((sbyte*)str, 0, charsWritten)}, {keysym} {lookupStatus}");
                                    }
                                }

                                // Check if the input context wants to handle the key press.

                                Scancode scancode = X11KeyboardComponent.ToScancode(keyPressed.keycode);
                                Key key = X11KeyboardComponent.TranslateKeySym(stackalloc XKeySym[1] { keysym });

                                KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(keyPressed.state);

                                bool changed = X11KeyboardComponent.KeyStateChanged(scancode, true);

                                bool isRepeat = false;
                                if (X11KeyboardComponent.XkbDetectableRepeatEnabled)
                                {
                                    isRepeat = (changed == false);
                                }
                                else
                                {
                                    // FIXME: We could do what glfw does and look for a KeyUp event with
                                    // basically the same timestamp.
                                }

                                {

                                    if (filtered == false)
                                    {
                                        EventQueue.Raise(xwindow, PlatformEventType.KeyDown, new KeyDownEventArgs(xwindow, key, scancode, isRepeat, modifiers));

                                        string? result = null;
                                        if (xwindow.IC.Value == IntPtr.Zero)
                                        {
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
                                            if (isHighLatin1)
                                            {
                                                result = Encoding.Latin1.GetString(str, charsWritten);
                                            }
                                            else
                                            {
                                                result = new string((sbyte*)str, 0, charsWritten);
                                            }
                                        }
                                        else
                                        {
                                            result = new string((sbyte*)str, 0, charsWritten, Encoding.UTF8);
                                        }

                                        EventQueue.Raise(xwindow, PlatformEventType.TextInput, new TextInputEventArgs(xwindow, result));
                                    }
                                }
                            }
                            break;
                        }
                    case XEventType.KeyRelease:
                        {
                            XKeyEvent keyPressed = ea.KeyPressed;

                            if (filtered) continue;

                            unsafe
                            {
                                XKeySym keysym = default;
                                byte* str = stackalloc byte[0];
                                int charsWritten = XLookupString(&keyPressed, str, 0, &keysym, null);

                                Scancode scancode = X11KeyboardComponent.ToScancode(keyPressed.keycode);
                                Key key = X11KeyboardComponent.TranslateKeySym(stackalloc XKeySym[1] { keysym });

                                KeyModifier modifiers = X11KeyboardComponent.ModifiersFromState(keyPressed.state);

                                bool changed = X11KeyboardComponent.KeyStateChanged(scancode, false);

                                EventQueue.Raise(xwindow, PlatformEventType.KeyUp, new KeyUpEventArgs(xwindow, key, scancode, modifiers));
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

                            // If we are supposed to confine the cursor to the window
                            // we reapply the cursor grab here. 
                            // This is necessary for hit tests where we have to intentionally
                            // drop all of our grabs for it to work properly.
                            // But the good thing is we get a EnterNotify after the
                            // drag/resize is complete, so we can reapply the grab here.
                            // - Noggin_bops 2024-09-20
                            if (xwindow.CaptureMode == CursorCaptureMode.Confined)
                            {
                                SetCursorCaptureMode(xwindow, CursorCaptureMode.Confined);
                            }

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

                            // FIXME: Update current keyboard state as it might have
                            // changed since we last had focus..
                            // - Noggin_bops 2024-02-25

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

                            XSetICFocus(xwindow.IC);

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

                            XUnsetICFocus(xwindow.IC);

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

                                if (result == Success)
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
                                Logger?.LogInfo($"State: {state}, Changed: {changed}, Before: {xwindow.WMState}");

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
                                    property.atom != X11.Atoms[KnownAtoms._NET_WM_NAME] &&
                                    property.atom != X11.Atoms[KnownAtoms._GTK_EDGE_CONSTRAINTS] &&
                                    property.atom != X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION])
                                {
                                    Logger?.LogDebug($"PropertyNotify: {XGetAtomName(X11.Display, property.atom)}");
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

                                Vector2i clientSize = (xwindow.Width, xwindow.Height);
                                Vector2i size = clientSize;
                                if (IsWindowManagerFreedesktop)
                                {
                                    GetWindowExtents(xwindow, out int left, out int right, out int top, out int bottom);
                                    size.X += left + right;
                                    size.Y += top + bottom;
                                }

                                EventQueue.Raise(xwindow, PlatformEventType.WindowResize, new WindowResizeEventArgs(xwindow, size, clientSize));

                                EventQueue.Raise(xwindow, PlatformEventType.WindowFramebufferResize, new WindowFramebufferResizeEventArgs(xwindow, clientSize));
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

                            // On Ubuntu 24.04 specifying opaque region values outside of the client
                            // area will cause weird artifacts where the window shadow will not be propertly
                            // transparent. So we are unfortunately forced to keep the opaque region up to
                            // date with the window size in order fix this issue.
                            // - Noggin_bops 2025-02-19
                            Span<long> region = [0, 0, xwindow.Width, xwindow.Height];
                            XChangeProperty<long>(
                                X11.Display,
                                xwindow.Window,
                                X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION],
                                X11.Atoms[KnownAtoms.CARDINAL],
                                32,
                                XPropertyMode.Replace,
                                region,
                                4);

                            break;
                        }
                    default:
                        Logger?.LogDebug($"Unknown event: {ea.Type}");
                        break;
                }
            }

            if (CursorCapturingWindow != null && CursorCapturingWindow.CaptureMode == CursorCaptureMode.Locked)
            {
                GetClientSize(CursorCapturingWindow, out Vector2i clientSize);
                if (CursorCapturingWindow.LastMousePosition != (clientSize / 2))
                {
                    // On XWayland we can only warp the cursor if it's hidden. 
                    // So we just temporarily hide the cursor if we are on XWayland.
                    // See this SDL issue: https://github.com/libsdl-org/SDL/issues/9539
                    // - Noggin_bops 2025-03-13
                    if (IsOnXWayland && CursorCapturingWindow.Cursor != null)
                    {
                        XDefineCursor(X11.Display, CursorCapturingWindow.Window, EmptyCursor);
                    }

                    XWarpPointer(X11.Display, XWindow.None, CursorCapturingWindow.Window, 0, 0, 0, 0, clientSize.X / 2, clientSize.Y / 2);

                    if (IsOnXWayland && CursorCapturingWindow.Cursor != null)
                    {
                        XDefineCursor(X11.Display, CursorCapturingWindow.Window, CursorCapturingWindow.Cursor.Cursor);
                    }

                    // Set the last mouse position to the position we are moving to
                    // to avoid generating a mouse move event.
                    CursorCapturingWindow.LastMousePosition = clientSize / 2;
                }
            }

            // If we are running a Glib GMainLoop we want to pump that now
            // so that we can receive dbus messages like theme changes.
            // - Noggin_bops 2024-07-22
            if (X11ShellComponent.GlibMainLoop != IntPtr.Zero)
            {
                int wasEventsDispatched = LibGio.g_main_context_iteration(LibGio.g_main_context_default(), 0);
            }
        }

        /// <inheritdoc/>
        public unsafe void PostUserEvent(EventArgs @event)
        {
            GCHandle handle = GCHandle.Alloc(@event, GCHandleType.Normal);

            XEvent xevent = default;
            xevent.Type = XEventType.ClientMessage;
            xevent.ClientMessage.Serial = 0;
            xevent.ClientMessage.SendEvent = 1;
            xevent.ClientMessage.Display = X11.Display;
            xevent.ClientMessage.Window = HelperWindow;
            xevent.ClientMessage.MessageType = OpenTKUserMessageType;
            xevent.ClientMessage.Format = 32;
            IntPtr ptr = (nint)handle;
            xevent.ClientMessage.l[0] = (ptr) & 0xFFFFFFFF;
            xevent.ClientMessage.l[1] = (ptr >> 32) & 0xFFFFFFFF;
            xevent.ClientMessage.l[2] = 2;
            xevent.ClientMessage.l[3] = 3;

            bool success = XSendEvent(X11.Display, HelperWindow, 0, XEventMask.None, xevent);
            if (success == false)
            {
                Logger?.LogError($"Unable to post user event of type {@event.GetType()}.");
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            XWindow window;
            GLXFBConfig? chosenConfig = null;
            ContextPixelFormat chosenPixelFormat = ContextPixelFormat.RGBA;
            XColorMap? map = null;

            bool visualSupportsFramebufferTransparency = false;

            if (hints.Api == GraphicsApi.OpenGL || hints.Api == GraphicsApi.OpenGLES)
            {
                // Ignoring ES for now.
                OpenGLGraphicsApiHints glhints = (hints as OpenGLGraphicsApiHints)!;

                byte depthBits;
                switch (glhints.DepthBits)
                {
                    case ContextDepthBits.None:    depthBits = 0;  break;
                    case ContextDepthBits.Depth16: depthBits = 16; break;
                    case ContextDepthBits.Depth24: depthBits = 24; break;
                    case ContextDepthBits.Depth32: depthBits = 32; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.DepthBits), (int)glhints.DepthBits, glhints.DepthBits.GetType());
                }

                byte stencilBits;
                switch (glhints.StencilBits)
                {
                    case ContextStencilBits.None:     stencilBits = 0; break;
                    case ContextStencilBits.Stencil1: stencilBits = 1; break;
                    case ContextStencilBits.Stencil8: stencilBits = 8; break;
                    default: throw new InvalidEnumArgumentException(nameof(glhints.StencilBits), (int)glhints.StencilBits, glhints.StencilBits.GetType());
                }

                ContextValues requested;
                requested.ID = 0;
                requested.RedBits = glhints.RedColorBits;
                requested.GreenBits = glhints.GreenColorBits;
                requested.BlueBits = glhints.BlueColorBits;
                requested.AlphaBits = glhints.AlphaColorBits;
                requested.DepthBits = depthBits;
                requested.StencilBits = stencilBits;
                requested.DoubleBuffered = glhints.DoubleBuffer;
                requested.SRGBFramebuffer = glhints.sRGBFramebuffer;
                requested.PixelFormat = glhints.PixelFormat;
                requested.SwapMethod = glhints.SwapMethod;
                requested.Samples = glhints.Multisamples;
                requested.SupportsFramebufferTransparency = glhints.SupportTransparentFramebufferX11;

                unsafe
                {
                    GLXFBConfig* configsPtr = glXGetFBConfigs(X11.Display, X11.DefaultScreen, out int noConfigs);
                    Span<GLXFBConfig> configs = new Span<GLXFBConfig>(configsPtr, noConfigs);

                    // FIXME: Relying on Toolkit to get the OpenGL component seems like a bad idea.
                    // We are coupling this component to the Toolkit class in an unexpected way?
                    // But maybe it's fine?
                    // - Noggin_bops 2024-06-22
                    // FIXME: This wasn't a great idea as ANGLEOpenGLComponent is a thing which will cause
                    // this to crash. So we need to handle ANGLEOpenGLComponent as well here.
                    // - Noggin_bops 2024-07-22
                    X11OpenGLComponent x11OpenGL = (Toolkit.OpenGL as X11OpenGLComponent) ?? throw new PalException(this, "OpenGL component needs to be initialized. Or you are using ANGLE on linux, this is not supported yet.");
                    // FIXME: Make these properties of the X11OpenGLComponent.
                    bool ARB_framebuffer_sRGB = x11OpenGL.GLXExtensions.Contains("GLX_ARB_framebuffer_sRGB");
                    bool EXT_framebuffer_sRGB = x11OpenGL.GLXExtensions.Contains("GLX_EXT_framebuffer_sRGB");
                    bool ARB_multisample = x11OpenGL.GLXExtensions.Contains("GLX_ARB_multisample");
                    bool ARB_fbconfig_float = x11OpenGL.GLXExtensions.Contains("GLX_ARB_fbconfig_float");
                    bool EXT_fbconfig_packed_float = x11OpenGL.GLXExtensions.Contains("GLX_EXT_fbconfig_packed_float");
                    bool OML_swap_method = x11OpenGL.GLXExtensions.Contains("GLX_OML_swap_method");

                    Version glxVersion = x11OpenGL.GLXVersion;

                    List<ContextValues> options = new List<ContextValues>();
                    for (int i = 0; i < configs.Length; i++)
                    {
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_X_RENDERABLE, out int xRenderable);
                        if (xRenderable == 0)
                        {
                            continue;
                        }
                        XVisualInfo* visual = glXGetVisualFromFBConfig(X11.Display, configsPtr[i]);
                        glXGetConfig(X11.Display, visual, GLX_USE_GL, out int useGL);
                        if (useGL == 0)
                        {
                            continue;
                        }

                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_DRAWABLE_TYPE, out int drawableType);
                        if ((drawableType & GLX_WINDOW_BIT) == 0)
                        {
                            continue;
                        }
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_RENDER_TYPE, out int renderType);
                        // Remove the color index bit.
                        renderType = renderType & ~GLX_COLOR_INDEX_BIT;
                        if (renderType == 0)
                        {
                            // If only get color index bit is set we skip this fbconfig.
                            continue;
                        }
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_DOUBLEBUFFER, out int doubleBuffer);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_RED_SIZE, out int redSize);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_GREEN_SIZE, out int greenSize);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_BLUE_SIZE, out int blueSize);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_ALPHA_SIZE, out int alphaSize);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_DEPTH_SIZE, out int depthSize);
                        glXGetFBConfigAttrib(X11.Display, configs[i], GLX_STENCIL_SIZE, out int stencilSize);

                        bool supportsFramebufferTransparency = false;
                        if (X11.Extensions.Contains("RENDER"))
                        {
                            // FIXME: Do we need to initialize the extension?

                            // FIXME: What if the renderformat is null?
                            XRenderPictFormat* xrenderFormat = LibXRender.XRenderFindVisualFormat(X11.Display, visual->VisualPtr);
                            supportsFramebufferTransparency = xrenderFormat->direct.alphaMask != 0;
                        }

                        int srgbCapable = 0;
                        if ((ARB_framebuffer_sRGB || EXT_framebuffer_sRGB))
                        {
                            glXGetFBConfigAttrib(X11.Display, configs[i], GLX_FRAMEBUFFER_SRGB_CAPABLE_ARB, out srgbCapable);
                        }

                        int sampleBuffers = 0;
                        int samples = 0;
                        
                        // GLX 1.4 or GLX_ARB_multisample
                        if ((glxVersion.Major > 1 || (glxVersion.Major == 1 && glxVersion.Minor >= 4)) || ARB_multisample)
                        {
                            glXGetConfig(X11.Display, visual, GLX_SAMPLE_BUFFERS, out sampleBuffers);
                            glXGetConfig(X11.Display, visual, GLX_SAMPLES, out samples);
                        }

                        ContextSwapMethod swapMethod = ContextSwapMethod.Undefined;
                        if (OML_swap_method)
                        {
                            glXGetFBConfigAttrib(X11.Display, configs[i], GLX_SWAP_METHOD_OML, out int swapMethodOML);
                            switch (swapMethodOML)
                            {
                                case GLX_SWAP_EXCHANGE_OML:
                                    swapMethod = ContextSwapMethod.Exchange;
                                    break;
                                case GLX_SWAP_COPY_OML:
                                    swapMethod = ContextSwapMethod.Copy;
                                    break;
                                case GLX_SWAP_UNDEFINED_OML:
                                    swapMethod = ContextSwapMethod.Undefined;
                                    break;
                                default:
                                    Logger?.LogWarning($"Unknown swap method: {swapMethodOML}. Using undefined.");
                                    swapMethod = ContextSwapMethod.Undefined;
                                    break;
                            }
                        }

                        ContextValues option;
                        option.ID = (ulong)i;
                        option.RedBits = redSize;
                        option.GreenBits = greenSize;
                        option.BlueBits = blueSize;
                        option.AlphaBits = alphaSize;
                        option.DepthBits = depthBits;
                        option.StencilBits = stencilBits;
                        option.DoubleBuffered = doubleBuffer == 1;
                        option.SRGBFramebuffer = srgbCapable == 1;
                        option.Samples = samples;
                        option.SwapMethod = swapMethod;
                        option.SupportsFramebufferTransparency = supportsFramebufferTransparency;

                        if ((renderType & GLX_RGBA_UNSIGNED_FLOAT_BIT_EXT) != 0)
                        {
                            option.PixelFormat = ContextPixelFormat.RGBAPackedFloat;
                            options.Add(option);
                        }

                        if ((renderType & GLX_RGBA_FLOAT_BIT) != 0)
                        {
                            option.PixelFormat = ContextPixelFormat.RGBAFloat;
                            options.Add(option);
                        }

                        if ((renderType & GLX_RGBA_BIT) != 0)
                        {
                            option.PixelFormat = ContextPixelFormat.RGBA;
                            options.Add(option);
                        }

                        if ((renderType & ~(GLX_RGBA_BIT | GLX_RGBA_FLOAT_BIT | GLX_RGBA_UNSIGNED_FLOAT_BIT_EXT)) != 0)
                        {
                            Logger?.LogWarning($"Unknown RenderType bits set for fbconfig {i}. RenderType: {renderType}.");
                        }
                    }
                
                    int selectedIndex = glhints.Selector(options, requested, Logger);
                    if (selectedIndex < 0 || selectedIndex >= options.Count) 
                    {
                        throw new IndexOutOfRangeException($"The selected format index ({selectedIndex}) is outside the range of valid indeces. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
                    }

                    chosenPixelFormat = options[selectedIndex].PixelFormat;
                    visualSupportsFramebufferTransparency = options[selectedIndex].SupportsFramebufferTransparency;
                    chosenConfig = configs[(int)options[selectedIndex].ID];
                    XFree(configsPtr);
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
            else if (hints.Api == GraphicsApi.Vulkan)
            {
                XSetWindowAttributes attributes = default;
                attributes.BorderPixel = XBlackPixel(X11.Display, X11.DefaultScreen);
                attributes.BackgroundPixel = XWhitePixel(X11.Display, X11.DefaultScreen);
                attributes.OverrideRedirect = 0;
                attributes.ColorMap = XDefaultColormap(X11.Display, X11.DefaultScreen);
                attributes.EventMask = XEventMask.StructureNotify | XEventMask.SubstructureNotify | XEventMask.Exposure | XEventMask.VisibilityChanged;

                unsafe
                {
                    XVisual* visual = XDefaultVisual(X11.Display, X11.DefaultScreen);

                    window = XCreateWindow(X11.Display, X11.DefaultRootWindow, 
                        0, 0, 600, 800, 0, 0, 
                        WindowClass.InputOutput,
                        // FIXME: Do we want a visual here?
                        ref Unsafe.AsRef<XVisual>(visual),
                        XWindowAttributeValueMask.BackPixel | XWindowAttributeValueMask.Colormap |
                        XWindowAttributeValueMask.BorderPixel | XWindowAttributeValueMask.EventMask, 
                        ref attributes);
                }
            }
            else
            {
                XSetWindowAttributes attributes = default;
                attributes.BorderPixel = XBlackPixel(X11.Display, X11.DefaultScreen);
                attributes.BackgroundPixel = XWhitePixel(X11.Display, X11.DefaultScreen);
                attributes.OverrideRedirect = 0;
                attributes.ColorMap = XDefaultColormap(X11.Display, X11.DefaultScreen);
                attributes.EventMask = XEventMask.StructureNotify | XEventMask.SubstructureNotify | XEventMask.Exposure | XEventMask.VisibilityChanged;

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
                "OTK Window",
                XPixmap.None,
                null,
                0,
                ref Unsafe.NullRef<XSizeHints>());

            // Register to deletion and ping events
            XSetWMProtocols(X11.Display, window, new XAtom[] { X11.Atoms[KnownAtoms.WM_DELETE_WINDOW], X11.Atoms[KnownAtoms._NET_WM_PING] }, 2);

            unsafe
            {
                XWMHints* wmHints = XAllocWMHints();
                wmHints->flags |= XWMHintsMask.InputHint;
                wmHints->input = 1;

                XSetWMHints(X11.Display, window, wmHints);
                XFree(wmHints);
            }

            unsafe {
                XClassHint* classHints = XAllocClassHint();
                // FIXME: Add a way to select two separate strings for these.
                classHints->res_name = (byte*)Marshal.StringToCoTaskMemUTF8(ApplicationName);
                classHints->res_class = classHints->res_name;
                XSetClassHint(X11.Display, window, classHints);
                Marshal.FreeCoTaskMem((nint)classHints->res_name);
                XFree(classHints);
            }

            if (X11.XI2Available)
            {
                unsafe {
                    XIEventMask eventmask;
                    eventmask.deviceid = (int)DeviceID.XIAllMasterDevices;
                    eventmask.mask_len = XIMaskLen(XI2EventType.LASTEVENT);
                    byte* mask = stackalloc byte[eventmask.mask_len];
                    eventmask.mask = mask;

                    XISetMask(mask, XI2EventType.ButtonPress);
                    XISetMask(mask, XI2EventType.Motion);
                    XISetMask(mask, XI2EventType.KeyPress);

                    XISelectEvents(X11.Display, window, &eventmask, eventmask.mask_len);
                }
            }

            // FIXME: Maybe a way to toggle if we 
            // accept drag and drop operations.
            // Set the supported XDnD version.
            Span<long> dndVersion = [ 5 ];
            XChangeProperty<long>(
                X11.Display,
                window,
                X11.Atoms[KnownAtoms.XdndAware],
                X11.Atoms[KnownAtoms.ATOM],
                32,
                XPropertyMode.Replace,
                dndVersion,
                1);

            // If we have a Visual that supports alpha blending we want make the window
            // opaque by default. This atom lets us tell the compositor that we don't want
            // to be alpha blended.
            // - Noggin_bops 2024-11-08
            // On Ubuntu 24.04 specifying opaque region values outside of the client
            // area will cause weird artifacts where the window shadow will not be propertly
            // transparent. So we are unfortunately forced to keep the opaque region up to
            // date with the window size in order fix this issue.
            // - Noggin_bops 2025-02-19
            Span<long> region = [0, 0, 800, 600];
            XChangeProperty<long>(
                X11.Display,
                window,
                X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION],
                X11.Atoms[KnownAtoms.CARDINAL],
                32,
                XPropertyMode.Replace,
                region,
                4);

            XEventMask filterMask = default;
            XIC ic;
            unsafe {
                XIMCallback start = new XIMCallback((IntPtr)window.Id, &PreeditStartCallback);
                XIMCallback done  = new XIMCallback((IntPtr)window.Id, &PreeditDoneCallback);
                XIMCallback draw  = new XIMCallback((IntPtr)window.Id, &PreeditDrawCallback);
                XIMCallback caret = new XIMCallback((IntPtr)window.Id, &PreeditCaretCallback);

                IntPtr callbacks = XVaCreateNestedList(0,
                    (IntPtr)Utils.AsPtr(XNPreeditStartCallback), (IntPtr)(&start),
                    (IntPtr)Utils.AsPtr(XNPreeditDoneCallback),  (IntPtr)(&done),
                    (IntPtr)Utils.AsPtr(XNPreeditDrawCallback),  (IntPtr)(&draw),
                    (IntPtr)Utils.AsPtr(XNPreeditCaretCallback), (IntPtr)(&caret),
                    IntPtr.Zero);

                // FIXME: Check that PreeditCallbacks is available...?
                // - Noggin_bops 2025-07-09
                ic = XCreateIC(IM,
                    Utils.AsPtr(XNInputStyle), (ulong)(XIMFlags.PreeditCallbacks | XIMFlags.StatusNothing),
                    Utils.AsPtr(XNClientWindow), window.Id,
                    Utils.AsPtr(XNFocusWindow), window.Id,
                    Utils.AsPtr(XNPreeditAttributes), callbacks,
                    null);

                if (ic.Value != 0)
                {
                    XSetICFocus(ic);

                    // Get the event mask the IC needs.
                    XGetICValues(ic, Utils.AsPtr(XNFilterEvents), (IntPtr)(&filterMask), 0);
                }

                XFree(callbacks);
            }

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
                    XEventMask.KeymapState |
                    XEventMask.FocusChange |
                    XEventMask.PropertyChange |
                    filterMask);

            XWindowHandle handle = new XWindowHandle(X11.Display, window, hints, chosenConfig, chosenPixelFormat, visualSupportsFramebufferTransparency, map, ic);

            XWindowDict.Add(handle.Window, handle);

            return handle;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        internal static unsafe int PreeditStartCallback(XIC xic, IntPtr clientData, IntPtr callData)
        {
            return -1;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        internal static unsafe void PreeditDoneCallback(XIC xic, IntPtr clientData, IntPtr callData)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        internal static unsafe void PreeditDrawCallback(XIC xic, IntPtr clientData, IntPtr callData)
        {
            XIMPreeditDrawCallbackStruct* data = (XIMPreeditDrawCallbackStruct*)callData;

            XWindow window = new XWindow((ulong)clientData);
            if (XWindowDict.TryGetValue(window, out XWindowHandle? xwindow))
            {
                // FIXME: Are we talking characters or code points...?
                xwindow.PreeditText.Remove(data->chg_first, data->chg_length);

                if (data->text != null)
                {
                    xwindow.PreeditText.Insert(data->chg_first, Marshal.PtrToStringUTF8((IntPtr)data->text->@string));
                }

                EventQueue.Raise(xwindow, PlatformEventType.TextEditing, new TextEditingEventArgs(xwindow, xwindow.PreeditText.ToString(), data->caret, data->chg_length));

                Toolkit.Window.Logger?.LogDebug($"Text Editing '{xwindow.PreeditText}'");
            }
            else
            {
                // FIXME: Log about not being able to find the window...?
            }
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        internal static unsafe void PreeditCaretCallback(XIC xic, IntPtr clientData, IntPtr callData)
        {
            XWindow window = new XWindow((ulong)clientData);
            if (XWindowDict.TryGetValue(window, out XWindowHandle? xwindow))
            {
                Toolkit.Window.Logger?.LogDebug("Caret callback!");
            }
            else
            {
                // FIXME: Log about not being able to find the window...?
            }
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XWindowDict.Remove(xwindow.Window);

            XDestroyWindow(xwindow.Display, xwindow.Window);

            if (CursorCapturingWindow == xwindow)
            {
                CursorCapturingWindow = null;
            }

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

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            XWindowHandle xhandle = handle.As<XWindowHandle>(this);

            return xhandle.Destroyed;
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            XWindowHandle window = handle.As<XWindowHandle>(this);

            // Prefer to fetch the freedesktop name.
            int result = XGetWindowProperty(
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
            if (result != Success || returnedType.IsNone)
            {
                if (name != IntPtr.Zero)
                {
                    XFree(name);
                }
                XFetchName(window.Display, window.Window, out name);
                string str = Marshal.PtrToStringUTF8(name) ?? string.Empty;
                XFree(name);
                return str;
            }
            else
            {
                string str = Marshal.PtrToStringUTF8(name) ?? string.Empty;
                XFree(name);
                return str;
            }
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            XWindowHandle window = handle.As<XWindowHandle>(this);
            byte[] titleBytes = Encoding.UTF8.GetBytes(title);

            XStoreName(window.Display, window.Window, title);   // Set classic name,
            unsafe
            {
                fixed(byte *titlePtr = titleBytes)
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

        /// <summary>
        /// Gets the iconified title of the window using either <c>_NET_WM_ICON_NAME</c> or <c>WM_ICON_NAME</c>.
        /// </summary>
        /// <param name="handle">A handle to the window to get the iconified title of.</param>
        /// <returns>The title of the window when it's iconified.</returns>
        public unsafe string GetIconifiedTitle(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int result = XGetWindowProperty(
                xwindow.Display,
                xwindow.Window,
                X11.Atoms[KnownAtoms._NET_WM_ICON_NAME],
                0, long.MaxValue,
                false,
                X11.Atoms[KnownAtoms.UTF8_STRING],
                out XAtom returnedType,
                out _,
                out _,
                out _,
                out IntPtr iconName);

            if (result != Success || returnedType.IsNone)
            {
                if (iconName != IntPtr.Zero)
                {
                    XFree(iconName);
                }
                XGetIconName(xwindow.Display, xwindow.Window, out iconName);
                string str = Marshal.PtrToStringUTF8(iconName) ?? string.Empty;
                XFree(iconName);
                return str;    
            }
            else
            {
                string str = Marshal.PtrToStringUTF8(iconName) ?? string.Empty;
                XFree(iconName);
                return str;
            }
        }

        /// <summary>
        /// Sets the iconified title of the window using both <c>_NET_WM_ICON_NAME</c> and <c>WM_ICON_NAME</c>.
        /// </summary>
        /// <param name="handle">A handle to the window to set the iconified title of.</param>
        /// <param name="iconTitle">The new iconified title.</param>
        public void SetIconifiedTitle(WindowHandle handle, string iconTitle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XSetIconName(xwindow.Display, xwindow.Window, iconTitle);

            unsafe {
                byte[] titleBytes = Encoding.UTF8.GetBytes(iconTitle);
                fixed (byte* titleBytesPtr = titleBytes)
                {
                    XChangeProperty(
                        xwindow.Display,
                        xwindow.Window,
                        X11.Atoms[KnownAtoms._NET_WM_ICON_NAME],
                        X11.Atoms[KnownAtoms.UTF8_STRING],
                        8,
                        XPropertyMode.Replace,
                        (IntPtr)titleBytesPtr,
                        titleBytes.Length);
                }
            }
        }

        /// <inheritdoc/>
        public IconHandle? GetIcon(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            return xwindow.Icon;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        private void GetWindowExtents(WindowHandle handle, out int left, out int right, out int top, out int bottom)
        {
            XWindowHandle window = handle.As<XWindowHandle>(this);
            int result = XGetWindowProperty(
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

            if (result != Success || count < 4)
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

            if (array != IntPtr.Zero)
            {
                XFree(array);
            }
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out Vector2i position)
        {
            GetClientPosition(handle, out position);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out _, out int top, out _);
                position.X -= left;
                position.Y -= top;
            }
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, Vector2i newPosition)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out _, out int top, out _);
                newPosition.X -= left;
                newPosition.Y -= top;
            }

            XMoveWindow(X11.Display, xwindow.Window, newPosition.X, newPosition.Y);
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out Vector2i size)
        {
            GetClientSize(handle, out size);

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out int right, out int top, out int bottom);
                size.X += left + right;
                size.Y += top + bottom;
            }
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, Vector2i newSize)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int innerWidth = newSize.X;
            int innerHeight = newSize.Y;

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(xwindow, out int left, out int right, out int top, out int bottom);
                innerWidth = Math.Max(newSize.X - left - right, 0);
                innerHeight = Math.Max(newSize.Y - top - bottom, 0);
            }

            SetClientSize(xwindow, (innerWidth, innerHeight));
        }

        /// <inheritdoc/>
        public void GetBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: Check status?
            int status = XGetWindowAttributes(xwindow.Display, xwindow.Window, out XWindowAttributes attributes);

            x = attributes.X;
            y = attributes.Y;
            width = attributes.Width;
            height = attributes.Height;

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out int right, out int top, out int bottom);
                x -= left;
                y -= top;
                width += left + right;
                height += top + bottom;
            }
        }

        /// <inheritdoc/>
        public void SetBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            uint innerWidth = (uint)width;
            uint innerHeight = (uint)height;

            if (IsWindowManagerFreedesktop)
            {
                GetWindowExtents(handle, out int left, out int right, out int top, out int bottom);
                x -= left;
                y -= top;
                innerWidth = (uint)Math.Max(width - left - right, 0);
                innerHeight = (uint)Math.Max(height - top - bottom, 0);
            }

            XMoveResizeWindow(X11.Display, xwindow.Window, x, y, innerWidth, innerHeight);
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out Vector2i clientPosition)
        {
            XWindowHandle window = handle.As<XWindowHandle>(this);
            XGetWindowAttributes(window.Display, window.Window, out XWindowAttributes attributes);
            XTranslateCoordinates(
                window.Display,
                window.Window,
                X11.DefaultRootWindow,
                attributes.X,
                attributes.Y,
                out clientPosition.X,
                out clientPosition.Y,
                out _);
        }

        /// <inheritdoc/>
        public void SetClientPosition(WindowHandle handle, Vector2i newClientPosition)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XMoveWindow(X11.Display, xwindow.Window, newClientPosition.X, newClientPosition.Y);
        }

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out Vector2i clientSize)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            int status = XGetWindowAttributes(xwindow.Display, xwindow.Window, out XWindowAttributes attributes);

            clientSize.X = attributes.Width;
            clientSize.Y = attributes.Height;
        }

        /// <inheritdoc/>
        public void SetClientSize(WindowHandle handle, Vector2i newClientSize)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XResizeWindow(X11.Display, xwindow.Window, newClientSize.X, newClientSize.Y);

            XFlush(X11.Display);
        }

        /// <inheritdoc/>
        public void GetClientBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: Check status?
            int status = XGetWindowAttributes(xwindow.Display, xwindow.Window, out XWindowAttributes attributes);

            x = attributes.X;
            y = attributes.Y;
            width = attributes.Width;
            height = attributes.Height;
        }

        /// <inheritdoc/>
        public void SetClientBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XMoveResizeWindow(X11.Display, xwindow.Window, x, y, (uint)width, (uint)height);

            XSync(X11.Display, False);
        }

        /// <inheritdoc/>
        public void GetFramebufferSize(WindowHandle handle, out Vector2i framebufferSize)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // The client size on X11 is already in pixels.
            GetClientSize(xwindow, out framebufferSize);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

            GetBounds(xwindow, out int x, out int y, out int width, out int height);
            Box2i bounds = new Box2i(x, y, x + width, y + height);

            DisplayHandle? bestDisp = null;
            int bestArea = 0;
            float bestDistance = float.PositiveInfinity;


            // Get all screens.
            List<X11DisplayComponent.DisplayRect> rects = X11DisplayComponent.GetDisplayRects();
            foreach (X11DisplayComponent.DisplayRect rect in rects)
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

        /// <inheritdoc/>
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

            WindowMode? mode = null;
            if (result == Success && numberOfItems > 0)
            {
                const int WithdrawnState = 0;
                const int NormalState = 1;
                const int IconicState = 3;

                unsafe
                {
                    int state = *(int*)contents;
                    if (state == IconicState)
                    {
                        mode = WindowMode.Minimized;
                    }
                    else if (state == WithdrawnState)
                    {
                        mode = WindowMode.Hidden;
                    }
                    else if (state == NormalState)
                    {
                        mode = WindowMode.Normal;
                    }
                }
            }

            if (contents != IntPtr.Zero)
            {
                XFree(contents);
            }

            if (mode == null)
            {
                XGetWindowAttributes(X11.Display, xwindow.Window, out XWindowAttributes attributes);

                switch (attributes.MapState)
                {
                    case MapState.IsUnmapped:
                    case MapState.IsUnviewable:
                        mode = WindowMode.Hidden;
                        break;
                    case MapState.IsViewable:
                        mode = WindowMode.Normal;
                        break;
                    default:
                        throw new InvalidEnumArgumentException("map state (this is an opentk bug)", (int)attributes.MapState, typeof(MapState));
                }
            }

            if (mode.Value == WindowMode.Normal)
            {
                WMState wmState = GetNETWMState(xwindow.Window);

                if (wmState.HasFlag(WMState.MaximizedHorz | WMState.MaximizedVert))
                {
                    mode = WindowMode.Maximized;
                }
                
                if (wmState.HasFlag(WMState.Hidden))
                {
                    mode = WindowMode.Hidden;
                }
            }

            return mode.Value;
        }

        /// <inheritdoc/>
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

                bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

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
                        XMapWindow(X11.Display, xwindow.Window);
                        XClearWindow(X11.Display, xwindow.Window);

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
                        if (IsMapped(xwindow) == false)
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
                        if (IsMapped(xwindow) == false)
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

                        bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

                        break;
                    }
                case WindowMode.WindowedFullscreen:
                    {
                        if (IsMapped(xwindow) == false)
                        {
                            XMapWindow(X11.Display, xwindow.Window);
                        }

                        SetFullscreenDisplay(handle, null);
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        if (IsMapped(xwindow) == false)
                        {
                            XMapWindow(X11.Display, xwindow.Window);
                        }

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

        /// <inheritdoc/>
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

            bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

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

        /// <inheritdoc/>
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

            bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);

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

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle handle, [NotNullWhen(true)] out DisplayHandle? display)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            display = xwindow.FullscreenDisplay;
            return display != null;
        }

        /// <inheritdoc/>
        /// <remarks>
        /// Calling this in rapid succession after <see cref="SetBorderStyle" /> will likely report the wrong style as the X server hasn't updated the state of the window yet.
        /// We could add a delay where we wait for the server to change the window, but for now we leave it as it is.
        /// </remarks>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // Check for ToolBox
            {
                int result = XGetWindowProperty(
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

                if (result != Success)
                {
                    if (content != IntPtr.Zero)
                    {
                        XFree(content);
                    }
                }
                else
                {
                    // If window type is UTILITY, assume toolbox.
                    unsafe {
                        XAtom windowType = *(XAtom*)content;
                        XFree(content);
                        if (windowType == X11.Atoms[KnownAtoms._NET_WM_WINDOW_TYPE_UTILITY])
                        {
                            return WindowBorderStyle.ToolBox;
                        }
                    }
                }
            }

            // Check for borderless
            {
                int result = XGetWindowProperty(
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

                if (result != Success)
                {
                    if (content != IntPtr.Zero)
                    {
                        XFree(content);
                    }
                }
                else
                {
                    // If decorations are turned off, assume borderless.
                    unsafe {
                        MotifWmHints* motifWmHints = (MotifWmHints*)content;
                        XFree(content);
                        if (motifWmHints->decorations == 0)
                        {
                            return WindowBorderStyle.Borderless;
                        }
                    }
                }
            }

            // If FixedSize is set, assume FixedBorder.
            if (xwindow.FixedSize != (-1, -1)) 
            {
                return WindowBorderStyle.FixedBorder;
            }

            return WindowBorderStyle.ResizableBorder;
        }

        /// <inheritdoc/>
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
                    GetClientSize(xwindow, out Vector2i clientSize);
                    SetFixedSize(xwindow, true, clientSize.X, clientSize.Y);
                    xwindow.FixedSize = clientSize;

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

        /// <inheritdoc/>
        public bool SupportsFramebufferTransparency(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            return xwindow.VisualSupportsFramebufferTransparency;
        }

        /// <inheritdoc/>
        public unsafe void SetTransparencyMode(WindowHandle handle, WindowTransparencyMode transparencyMode, float opacity = 0.5f)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            if (transparencyMode != WindowTransparencyMode.TransparentFramebuffer)
            {
                // Unfortunately we need to match the opaque region size to the
                // actual client area of the window and not just a large area
                // because the Ubuntu 24.04 compositor messes up the drop shadow
                // of the window in that case.
                // - Noggin_bops 2025-02-21
                Span<long> region = [0, 0, xwindow.Width, xwindow.Height];
                XChangeProperty<long>(
                    X11.Display,
                    xwindow.Window,
                    X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION],
                    X11.Atoms[KnownAtoms.CARDINAL],
                    32,
                    XPropertyMode.Replace,
                    region,
                    4);
            }

            if (transparencyMode != WindowTransparencyMode.TransparentWindow)
            {
                XDeleteProperty(X11.Display, xwindow.Window, X11.Atoms[KnownAtoms._NET_WM_WINDOW_OPACITY]);
            }

            switch (transparencyMode)
            {
                case WindowTransparencyMode.Opaque:
                {
                    break;
                }
                case WindowTransparencyMode.TransparentFramebuffer:
                {
                    // FIXME: Log a warning if the visual doesn't have alpha blending support!
                    if (SupportsFramebufferTransparency(xwindow) == false)
                    {
                        Logger?.LogWarning("Trying to enable framebuffer transparency for a window with a Visual that doesn't support transparency.");
                    }

                    Span<long> region = [0, 0, 0, 0];
                    XChangeProperty<long>(
                        X11.Display,
                        xwindow.Window,
                        X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION],
                        X11.Atoms[KnownAtoms.CARDINAL],
                        32,
                        XPropertyMode.Replace,
                        region,
                        4);
                    break;
                }
                case WindowTransparencyMode.TransparentWindow:
                {
                    opacity = float.Clamp(opacity, 0, 1);
                    // We cast to double here as double can exactly represent
                    // all integers in the uint range.
                    // (uint)(0xffffffffu * 1.0f) becomes zero.
                    // - Noggin_bops 2024-11-01
                    uint transparency = (uint)(0xffffffffu * (double)opacity);
                    XChangeProperty(
                        X11.Display, 
                        xwindow.Window, 
                        X11.Atoms[KnownAtoms._NET_WM_WINDOW_OPACITY], 
                        X11.Atoms[KnownAtoms.CARDINAL],
                        32,
                        XPropertyMode.Replace,
                        (IntPtr)(&transparency),
                        1);
                    break;
                }
            }
        }

        /// <inheritdoc/>
        public unsafe WindowTransparencyMode GetTransparencyMode(WindowHandle handle, out float opacity)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int result = XGetWindowProperty(
                X11.Display,
                xwindow.Window,
                X11.Atoms[KnownAtoms._NET_WM_WINDOW_OPACITY],
                0, long.MaxValue, false,
                X11.Atoms[KnownAtoms.CARDINAL],
                out XAtom actualType,
                out int actualFormat,
                out long numberOfItems,
                out long remainingBytes,
                out IntPtr contents);
            if (result != Success || numberOfItems == 0)
            {
                if (result != Success)
                {
                    Logger?.LogDebug("Couldn't get _NET_WM_WINDOW_OPACITY. Assuming no transparency.");
                }
            }
            else
            {
                opacity = (float)(*(uint*)contents / (double)0xffffffffu);
                XFree(contents);
                return WindowTransparencyMode.TransparentWindow;
            }

            if (contents != IntPtr.Zero)
            {
                XFree(contents);
            }

            opacity = 0;

            result = XGetWindowProperty(
                X11.Display,
                xwindow.Window,
                X11.Atoms[KnownAtoms._NET_WM_OPAQUE_REGION],
                0, long.MaxValue, false,
                X11.Atoms[KnownAtoms.CARDINAL],
                out actualType,
                out actualFormat,
                out numberOfItems,
                out remainingBytes,
                out contents);
            if (result != Success || numberOfItems == 0)
            {
                return WindowTransparencyMode.Opaque;
            }
            else
            {
                Debug.Assert(actualFormat == 32);
                Debug.Assert(actualType == X11.Atoms[KnownAtoms.CARDINAL]);

                long* region = (long*)contents;
                long x = region[0];
                long y = region[1];
                long w = region[2];
                long h = region[3];

                bool isOpaque = (x == 0 && y == 0 && w > 0 && h > 0);

                XFree(contents);

                return isOpaque ? WindowTransparencyMode.Opaque : WindowTransparencyMode.TransparentFramebuffer;
            }
        }

        /// <inheritdoc/>
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

            bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        /// <inheritdoc/>
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

            int result = XGetWindowProperty(
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

            if (result != Success)
            {
                Logger?.LogWarning("Couldn't get _NET_WM_STATE. Can't check always on top status.");
                if (contents != IntPtr.Zero)
                {
                    XFree(contents);
                }
                return false;
            }
            else
            {
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
                XFree(contents);
                return above;
            }
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            xwindow.HitTest = test;
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);
            XCursorHandle? xcursor = cursor?.As<XCursorHandle>(this);

            XDefineCursor(X11.Display, xwindow.Window, xcursor?.Cursor ?? EmptyCursor);
            xwindow.Cursor = xcursor;
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            return xwindow.CaptureMode;
        }

        /// <inheritdoc/>
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

                        xwindow.CaptureMode = CursorCaptureMode.Normal;

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

                        xwindow.CaptureMode = CursorCaptureMode.Confined;

                        break;
                    }
                case CursorCaptureMode.Locked:
                    {
                        CursorCapturingWindow = xwindow;

                        xwindow.CaptureMode = CursorCaptureMode.Locked;

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(CursorCaptureMode));
            }
        }

        /// <inheritdoc/>
        public bool IsFocused(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XGetInputFocus(X11.Display, out XWindow focus, out _);

            return xwindow.Window == focus;
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            XRaiseWindow(X11.Display, xwindow.Window);
            // FIXME: Set _NET_ACTIVE_WINDOW?
            XSetInputFocus(X11.Display, xwindow.Window, RevertTo.RevertToPointerRoot, XTime.CurrentTime);
        }

        /// <inheritdoc/>
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

            bool success = XSendEvent(X11.Display, X11.DefaultRootWindow, 0, XEventMask.SubstructureRedirect | XEventMask.SubstructureNotify, e);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, Vector2 screen, out Vector2 client)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int x = (int)screen.X;
            int y = (int)screen.Y;

            // FIXME: Extents?

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, X11.DefaultRootWindow, xwindow.Window, x, y, out int clientX, out int clientY, out _);

            client = (clientX, clientY);
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, Vector2 client, out Vector2 screen)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            int clientX = (int)client.X;
            int clientY = (int)client.Y;

            // FIXME: Extents?

            // FIXME: This will not work if the coordinates are on another screen.
            // FIXME: Get the root window that the window is in?
            XTranslateCoordinates(X11.Display, xwindow.Window, X11.DefaultRootWindow, clientX, clientY, out int x, out int y, out _);

            screen = (x, y);
        }

        /// <inheritdoc/>
        public void ClientToFramebuffer(WindowHandle handle, Vector2 client, out Vector2 framebuffer)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            framebuffer = client;
        }

        /// <inheritdoc/>
        public void FramebufferToClient(WindowHandle handle, Vector2 framebuffer, out Vector2 client)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            client = framebuffer;
        }

        private static bool hasReportedScaleFactorWarning = false;

        /// <inheritdoc/>
        public void GetScaleFactor(WindowHandle handle, out float scaleX, out float scaleY)
        {
            if (hasReportedScaleFactorWarning == false) {
                Logger?.LogWarning("Scale factor is always 1 on X11 atm.");
                hasReportedScaleFactorWarning = true;
            }

            scaleX = 1;
            scaleY = 1;
        }

        /// <summary>
        /// Returns the X11 <c>Display</c> used by OpenTK.
        /// </summary>
        /// <returns>The X11 <c>Display</c> handle.</returns>
        public IntPtr GetX11Display()
        {
            return X11.Display.Value;
        }

        /// <summary>
        /// Returns the X11 <c>Window</c> handle associated with this window.
        /// </summary>
        /// <param name="handle">The window handle to get the associated X11 <c>Window</c> from.</param>
        /// <returns>The X11 <c>Window</c> associated with the window handle.</returns>
        public IntPtr GetX11Window(WindowHandle handle)
        {
            XWindowHandle xwindow = handle.As<XWindowHandle>(this);

            // FIXME: XID is an `unsigned long int` which is IntPtr but
            // currently we have it as ulong.
            // - Noggin_bops 2024-03-06
            return (IntPtr)xwindow.Window.Id;
        }
    }
}
