using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSWindowComponent : IWindowComponent
    {
        internal static IntPtr nsApplication;

        internal static readonly SEL selQuit = sel_registerName("quit"u8);
        internal static SEL selSharedApplication = sel_registerName("sharedApplication"u8);
        internal static SEL selSetActivationPolicy = sel_registerName("setActivationPolicy:"u8);
        internal static SEL selDiscardEventsMatchingMask_beforeEvent = sel_registerName("discardEventsMatchingMask:beforeEvent:"u8);
        internal static SEL selMainMenu = sel_registerName("mainMenu"u8);

        internal static SEL selType = sel_registerName("type"u8);
        internal static SEL selSendEvent = sel_registerName("sendEvent:"u8);
        internal static SEL selNextEventMatchingMask_untilDate_inMode_dequeue = sel_registerName("nextEventMatchingMask:untilDate:inMode:dequeue:"u8);
        internal static SEL selWindow = sel_registerName("window"u8);
        internal static SEL selButtonNumber = sel_registerName("buttonNumber"u8);
        internal static SEL selLocationInWindow = sel_registerName("locationInWindow"u8);
        internal static SEL selMouseLocation = sel_registerName("mouseLocation"u8);
        internal static SEL selScrollingDeltaX = sel_registerName("scrollingDeltaX"u8);
        internal static SEL selScrollingDeltaY = sel_registerName("scrollingDeltaY"u8);
        internal static SEL selHasPreciseScrollingDeltas = sel_registerName("hasPreciseScrollingDeltas"u8);
        internal static SEL selTrackingNumber = sel_registerName("trackingNumber"u8);

        internal static SEL selInitWithContentRect_styleMask_backing_defer = sel_registerName("initWithContentRect:styleMask:backing:defer:"u8);
        internal static SEL selInitWithFrame = sel_registerName("initWithFrame:"u8);

        internal static SEL selAddTrackingRect_owner_userData_assumeInside = sel_registerName("addTrackingRect:owner:userData:assumeInside:"u8);

        internal static SEL selScreen = sel_registerName("screen"u8);
        internal static SEL selFrame = sel_registerName("frame"u8);
        internal static SEL selBounds = sel_registerName("bounds"u8);
        internal static SEL selSetFrameTopLeftPoint = sel_registerName("setFrameTopLeftPoint:"u8);
        internal static SEL selContentView = sel_registerName("contentView"u8);
        internal static SEL selSetContentView = sel_registerName("setContentView:"u8);

        internal static SEL selMakeKeyAndOrderFront = sel_registerName("makeKeyAndOrderFront:"u8);

        internal static SEL selRequestUserAttention = sel_registerName("requestUserAttention"u8);

        internal static SEL selConvertRectToBacking = sel_registerName("convertRectToBacking:"u8);
        internal static SEL selConvertRectToScreen = sel_registerName("convertRectToScreen:"u8);

        internal static SEL selIsMiniaturized = sel_registerName("isMiniaturized"u8);
        internal static SEL selMiniaturize = sel_registerName("miniaturize:"u8);
        internal static SEL selDeminiaturize = sel_registerName("deminiaturize:"u8);
        internal static SEL selIsZoomed = sel_registerName("isZoomed"u8);
        internal static SEL selZoom = sel_registerName("zoom:"u8);
        internal static SEL selIsVisible = sel_registerName("isVisible"u8);
        internal static SEL selOrderFront = sel_registerName("orderFront:"u8);
        internal static SEL selOrderOut = sel_registerName("orderOut:"u8);

        internal static SEL selStyleMask = sel_registerName("styleMask"u8);
        internal static SEL selSetStyleMask = sel_registerName("setStyleMask:"u8);

        internal static SEL selLevel = sel_registerName("level"u8);
        internal static SEL selSetLevel = sel_registerName("setLevel:"u8);


        internal static IntPtr NSDefaultRunLoop = GetStringConstant(FoundationLibrary, "NSDefaultRunLoopMode"u8);

        internal static readonly ObjCClass NSEventClass = objc_getClass("NSEvent"u8);

        internal static ObjCClass NSOpenTKWindowClass;
        internal static ObjCClass NSOpenTKViewClass;

        internal static readonly Dictionary<IntPtr, NSWindowHandle> NSWindowDict = new Dictionary<nint, NSWindowHandle>();

        /// <inheritdoc/>
        public string Name => nameof(MacOSWindowComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "MacOSWindowComponent can only initialize the Window component.");
            }

            ObjCClass nsapp = objc_getClass("NSApplication"u8);
            class_addMethod(nsapp, selQuit, OnQuitHandler, "v@:"u8);

            nsApplication = objc_msgSend_IntPtr((IntPtr)nsapp, selSharedApplication);

            objc_msgSend_bool(nsApplication, selSetActivationPolicy, (long)NSApplicationActivationpolicy.Regular);
            objc_msgSend(nsApplication, selDiscardEventsMatchingMask_beforeEvent, (ulong)NSEventMask.Any, IntPtr.Zero);

            IntPtr mainMenu = objc_msgSend_IntPtr(nsApplication, selMainMenu);
            if (mainMenu == IntPtr.Zero)
            {
                IntPtr menubar = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenu"u8), Alloc);
                IntPtr menuItem = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenuItem"u8), Alloc);

                objc_msgSend(menubar, sel_registerName("addItem:"u8), menuItem);
                objc_msgSend(nsApplication, sel_registerName("setMainMenu:"u8), menubar);

                IntPtr appMenu = objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenu"u8), Alloc);
                IntPtr quitMenuItem = objc_msgSend_IntPtr(
                        objc_msgSend_IntPtr((IntPtr)objc_getClass("NSMenuItem"u8), Alloc),
                        sel_registerName("initWithTitle:action:keyEquivalent:"u8),
                        ToNSString("Quit"u8),
                        selQuit,
                        ToNSString("q"u8));

                objc_msgSend(appMenu, sel_registerName("addItem:"u8), quitMenuItem);
                objc_msgSend(menuItem, sel_registerName("setSubmenu:"u8), appMenu);

                objc_msgSend(nsApplication, sel_registerName("finishLaunching"u8));
            }

            // FIXME: OpenTK 3 creates a new window and view class for every window, with a unique name.

            // Allocate a window class
            NSOpenTKWindowClass = objc_allocateClassPair(objc_getClass("NSWindow"), "NSOpenTKWindow"u8, 0);
            // FIXME: Store delegate to prevent GC.. or use unmanagedcallersonly.
            class_addMethod(NSOpenTKWindowClass, sel_registerName("windowShouldClose:"u8), ShouldWindowCloseHandler, "b@:@"u8);
            //class_addMethod(opentkWindowClass, sel_registerName("keyDown:"u8), (KeyDownDelegate)keyDown, "v@:@"u8);
            objc_registerClassPair(NSOpenTKWindowClass);

            NSOpenTKViewClass = objc_allocateClassPair(objc_getClass("NSView"), "NSOpenTKView"u8, 0);
            //class_addMethod(opentkViewClass, sel_registerName("resetCursorRects"u8), OnResetCursorRect, "v@:"u8);
            class_addMethod<MouseEnteredDelegate>(NSOpenTKViewClass, sel_registerName("mouseEntered:"u8), NSOtkView_MouseEntered, "v@:@"u8);
            class_addMethod<MouseExitedDelegate>(NSOpenTKViewClass, sel_registerName("mouseExited:"u8), NSOtkView_MouseExited, "v@:@"u8);
            objc_registerClassPair(NSOpenTKViewClass);
        }

        delegate void OnQuitDelegate(IntPtr self, SEL cmd);
        private static readonly OnQuitDelegate OnQuitHandler = OnQuit;

        private static void OnQuit(IntPtr self, SEL cmd)
        {
            Console.WriteLine("On quit!");

            // Actually quit.
            objc_msgSend(nsApplication, sel_registerName("terminate:"u8), nsApplication);
        }

        delegate bool ShouldWindowCloseDelegate(IntPtr windowPtr, SEL selector, IntPtr sender);
        static ShouldWindowCloseDelegate ShouldWindowCloseHandler = ShouldWindowClose;
        static bool ShouldWindowClose(IntPtr window, SEL selector, IntPtr sender)
        {
            // FIXME:
            // Send event and return false?
            // Or should we override performClose instead?
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow))
            {
                EventQueue.Raise(nswindow, PlatformEventType.Close, new CloseEventArgs(nswindow));

                // FIXME: Don't destroy the window by default.
                nswindow.Destroyed = true;
            }

            return true;
        }

        delegate void ResetCursorRectDelegate(IntPtr self, SEL cmd);
        private static readonly ResetCursorRectDelegate OnResetCursorRect = ResetCursorRects;
        internal static void ResetCursorRects(IntPtr self, SEL cmd)
        {
            // FIXME: addCursorRect
        }


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void MouseEnteredDelegate(IntPtr view, SEL selector, IntPtr @event);
        static MouseEnteredDelegate OnMouseEnter = NSOtkView_MouseEntered;
        static void NSOtkView_MouseEntered(IntPtr view, SEL selector, IntPtr @event)
        {
            Console.WriteLine("Enter");
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) != false)
            {
                // FIXME: How do we get the logger here?
                //Logger?.LogWarning($"Received MouseEntered event with unknown window: {window}");
                Console.WriteLine($"Received MouseEntered event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, true));
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void MouseExitedDelegate(IntPtr view, SEL selector, IntPtr @event);
        static MouseExitedDelegate OnMouseExited = NSOtkView_MouseExited;
        static void NSOtkView_MouseExited(IntPtr view, SEL selector, IntPtr @event)
        {
            Console.WriteLine("Exit");
            IntPtr window = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(window, out NSWindowHandle? nswindow) != false)
            {
                // FIXME: How do we get the logger here?
                //Logger?.LogWarning($"Received MouseEntered event with unknown window: {window}");
                Console.WriteLine($"Received MouseExited event with unknown window: {window}");
                return;
            }

            EventQueue.Raise(nswindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(nswindow, false));
        }

        /// <inheritdoc/>
        public bool CanSetIcon => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanGetDisplay => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanSetCursor => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanCaptureCursor => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();


        /// <inheritdoc/>
        public void ProcessEvents(bool waitForEvents = false)
        {
            // FIXME: Make this a loop!
            IntPtr @event = objc_msgSend_IntPtr(nsApplication, selNextEventMatchingMask_untilDate_inMode_dequeue, NSEventMask.Any, IntPtr.Zero, NSDefaultRunLoop, true);
            if (@event == IntPtr.Zero)
            {
                return;
            }

            NSEventType type = (NSEventType)objc_msgSend_ulong(@event, selType);
            
            IntPtr windowPtr = objc_msgSend_IntPtr(@event, selWindow);
            if (NSWindowDict.TryGetValue(windowPtr, out NSWindowHandle? nswindow) == false)
            {
                Console.WriteLine($"Event for non opentk window: {type}");
                objc_msgSend(nsApplication, selSendEvent, @event);
                // FIXME: Change this to continue.
                return;
            }

            switch (type)
            {
                case NSEventType.LeftMouseDown:
                case NSEventType.RightMouseDown:
                case NSEventType.OtherMouseDown:
                    {
                        // FIXME: This should be a long, not ulong
                        ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                        MouseButton mouseButton;
                        switch (button)
                        {
                            case 0: mouseButton = MouseButton.Button1; break;
                            case 1: mouseButton = MouseButton.Button2; break;
                            case 2: mouseButton = MouseButton.Button3; break;
                            case 3: mouseButton = MouseButton.Button4; break;
                            case 4: mouseButton = MouseButton.Button5; break;
                            case 5: mouseButton = MouseButton.Button6; break;
                            case 6: mouseButton = MouseButton.Button7; break;
                            case 7: mouseButton = MouseButton.Button8; break;
                            default: throw new PalException(this, $"Unknown mouse button: {button}");
                        }

                        EventQueue.Raise(nswindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(nswindow, mouseButton));

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.LeftMouseUp:
                case NSEventType.RightMouseUp:
                case NSEventType.OtherMouseUp:
                    {
                        // FIXME: This should be a long, not ulong
                        ulong button = objc_msgSend_ulong(@event, selButtonNumber);
                        MouseButton mouseButton;
                        switch (button)
                        {
                            case 0: mouseButton = MouseButton.Button1; break;
                            case 1: mouseButton = MouseButton.Button2; break;
                            case 2: mouseButton = MouseButton.Button3; break;
                            case 3: mouseButton = MouseButton.Button4; break;
                            case 4: mouseButton = MouseButton.Button5; break;
                            case 5: mouseButton = MouseButton.Button6; break;
                            case 6: mouseButton = MouseButton.Button7; break;
                            case 7: mouseButton = MouseButton.Button8; break;
                            default: throw new PalException(this, $"Unknown mouse button: {button}");
                        }

                        EventQueue.Raise(nswindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(nswindow, mouseButton));

                        // FIXME: If the mouse is outside of the window after a drag we want to send a mouse exit event here

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.MouseMoved:
                    {
                        CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);

                        CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, new CGRect(point, CGPoint.Zero));

                        CGRect backing = objc_msgSend_CGRect(
                            nswindow.Window,
                            selConvertRectToBacking,
                            objc_msgSend_CGRect(nswindow.View, selBounds));


                        // FIXME: Coordinate space
                        Vector2 pos = new Vector2((float)pointRect.origin.x, (float)(backing.size.y - pointRect.origin.y));
                        
                        EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, pos));

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.LeftMouseDragged:
                case NSEventType.RightMouseDragged:
                case NSEventType.OtherMouseDragged:
                    {
                        CGPoint point = objc_msgSend_CGPoint(@event, selLocationInWindow);

                        CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, new CGRect(point, CGPoint.Zero));

                        CGRect backing = objc_msgSend_CGRect(
                            nswindow.Window,
                            selConvertRectToBacking,
                            objc_msgSend_CGRect(nswindow.View, selBounds));

                        // FIXME: Coordinate space
                        Vector2 pos = new Vector2((float)pointRect.origin.x, (float)(backing.size.y - pointRect.origin.y));

                        EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, pos));

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.ScrollWheel:
                    {
                        float scrollX = objc_msgSend_float(@event, selScrollingDeltaX);
                        float scrollY = objc_msgSend_float(@event, selScrollingDeltaY);

                        bool preciseScrollingDeltas = objc_msgSend_bool(@event, selHasPreciseScrollingDeltas);

                        // FIXME: We might need to flip the horizontal direction?
                        // FIXME: Consider precise deltas...
                        Vector2 delta = new Vector2(scrollX, scrollY);
                        Vector2 distance = new Vector2(scrollX, scrollY);

                        if (preciseScrollingDeltas)
                        {
                            // FIXME: This is an ok hack for now but we want to do this
                            // "properly" in the future.
                            delta *= 0.1f;
                        }

                        MacOSMouseComponent.RegisterMouseWheelDelta(delta);
                        EventQueue.Raise(nswindow, PlatformEventType.Scroll, new ScrollEventArgs(nswindow, delta, distance));

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.KeyDown:
                    {
                        // Steal the keyDown event to avoid the beep.
                        break;
                    }
                case NSEventType.KeyUp:
                    {
                        break;
                    }
                default:
                    //Console.WriteLine($"Event type: {type}");
                    objc_msgSend(nsApplication, selSendEvent, @event);
                    break;
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            // FIXME: Better default placement of window?
            CGRect windowRect = new CGRect(500, 500, 500, 500);
            NSWindowStyleMask style = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

            IntPtr windowPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKWindowClass, Alloc),
                selInitWithContentRect_styleMask_backing_defer,
                windowRect, style, NSBackingStoreType.Buffered, false);

            IntPtr viewPtr = objc_msgSend_IntPtr(windowPtr, selContentView);
            // FIXME: Error checking!

            // Replace the view!
            viewPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKViewClass, Alloc),
                selInitWithFrame,
                objc_msgSend_CGRect(viewPtr, selBounds));

            objc_msgSend(windowPtr, selSetContentView, viewPtr);

            NSWindowHandle nswindow = new NSWindowHandle(windowPtr, viewPtr, hints);

            NSWindowDict.Add(windowPtr, nswindow);


            // FIXME: Move this somewhere?
            objc_msgSend(windowPtr, sel_registerName("setDelegate:"u8), windowPtr);
            objc_msgSend(windowPtr, sel_registerName("makeKeyWindow"u8));
            objc_msgSend(windowPtr, sel_registerName("center"u8));
            objc_msgSend(windowPtr, selMakeKeyAndOrderFront, windowPtr);

            // Register the view for mouse enter/exit notifications.
            objc_msgSend_IntPtr(viewPtr, selAddTrackingRect_owner_userData_assumeInside,
                objc_msgSend_CGRect(viewPtr, selBounds),
                viewPtr,
                IntPtr.Zero,
                false);

            return nswindow;
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowDict.Remove(nswindow.Window);

            // This also releases the window if the releaseWhenClosed property is true
            // This is the default.
            objc_msgSend(nswindow.Window, sel_registerName("close"u8));

            // Maybe make sure that there are no references to the window?

            nswindow.Destroyed = true;
        }

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Destroyed;
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr nsStringTitle = objc_msgSend_IntPtr(nswindow.Window, sel_registerName("title"u8));
            string title = FromNSString(nsStringTitle);
            return title;
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, sel_registerName("setTitle:"u8), ToNSString(title));
        }

        /// <inheritdoc/>
        public IconHandle? GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr screen = objc_msgSend_IntPtr(nswindow.Window, selScreen);
            CGRect screenBackingRect = objc_msgSend_CGRect(screen, selConvertRectToBacking, objc_msgSend_CGRect(screen, selFrame));

            CGRect frame = objc_msgSend_CGRect(nswindow.Window, selFrame);

            CGRect backingRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, frame);

            x = (int)backingRect.origin.x;
            y = (int)(screenBackingRect.size.y - (backingRect.origin.y + backingRect.size.y));
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Invert the Y coordinate.
            // FIXME: Convert pixel coordinates to macos screen coordinates...
            objc_msgSend(nswindow.Window, selSetFrameTopLeftPoint, new CGPoint(x, y));
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect rect = objc_msgSend_CGRect(nswindow.Window, selFrame);

            CGRect backingRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, rect);

            // FIXME: Convert screen coordinates to pixel coordinates.
            width = (int)backingRect.size.x;
            height = (int)backingRect.size.y;
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, int width, int height)
        {
            // FIXME: setFrame:display:

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            IntPtr screen = objc_msgSend_IntPtr(nswindow.Window, selScreen);
            CGRect screenBackingRect = objc_msgSend_CGRect(screen, selConvertRectToBacking, objc_msgSend_CGRect(screen, selFrame));

            CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);

            CGRect windowBounds = objc_msgSend_CGRect(nswindow.View, sel_registerName("convertRect:toView:"u8), bounds, IntPtr.Zero);

            CGRect screenRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, windowBounds);
            CGRect backingRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToBacking, screenRect);

            x = (int)backingRect.origin.x;
            y = (int)(screenBackingRect.size.y - (backingRect.origin.y + backingRect.size.y));
        }

        /// <inheritdoc/>
        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        // FIXME: Separate the window size from the framebuffer size?

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            IntPtr screen = objc_msgSend_IntPtr(nswindow.Window, selScreen);

            CGRect bounds = objc_msgSend_CGRect(nswindow.View, selBounds);

            CGRect windowBounds = objc_msgSend_CGRect(nswindow.View, sel_registerName("convertRect:toView:"u8), bounds, IntPtr.Zero);

            // FIXME: send to nswindow and not screen?
            CGRect screenRect = objc_msgSend_CGRect(nswindow.Window, selConvertRectToScreen, windowBounds);
            CGRect backingRect = objc_msgSend_CGRect(screen, selConvertRectToBacking, screenRect);

            width = (int)backingRect.size.x;
            height = (int)backingRect.size.y;
        }

        /// <inheritdoc/>
        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            // FIXME:
            //throw new NotImplementedException();


        }

        /// <inheritdoc/>
        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public WindowMode GetMode(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized, nswindow.Window))
            {
                return WindowMode.Minimized;
            }

            // FIXME: Should we change to fullscreen instead?
            if (objc_msgSend_bool(nswindow.Window, selIsZoomed, nswindow.Window))
            {
                return WindowMode.Maximized;
            }

            // FIXME: check for fullscreen!

            if (objc_msgSend_bool(nswindow.Window, selIsVisible, nswindow.Window) == false)
            {
                return WindowMode.Hidden;
            }
            else
            {
                return WindowMode.Normal;
            }
        }

        /// <inheritdoc/>
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            switch (mode)
            {
                case WindowMode.Hidden:
                    {
                        objc_msgSend(nswindow.Window, selOrderOut, nswindow.Window);

                        break;
                    }
                case WindowMode.Minimized:
                    {
                        objc_msgSend(nswindow.Window, selMiniaturize, nswindow.Window);
                        break;
                    }
                case WindowMode.Normal:
                    {
                        // FIXME: Is this everything we need to do?

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsZoomed))
                        {
                            objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        break;
                    }
                case WindowMode.Maximized:
                    {
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsMiniaturized))
                        {
                            objc_msgSend(nswindow.Window, selDeminiaturize, nswindow.Window);
                        }

                        // If the window was hidden, show it.
                        // FIXME: Return is BOOL
                        if (objc_msgSend_bool(nswindow.Window, selIsVisible) == false)
                        {
                            objc_msgSend(nswindow.Window, selOrderFront, nswindow.Window);
                        }

                        // FIXME: Should we be calling "zoom:" or "toggleFullscreen:" here?
                        // What is the "expected" behaviour.

                        // macos calls maximizing "zoom".
                        objc_msgSend(nswindow.Window, selZoom, nswindow.Window);
                        break;
                    }
                case WindowMode.WindowedFullscreen:
                    {
                        throw new NotImplementedException();
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        throw new NotImplementedException();
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowStyleMask style = (NSWindowStyleMask)objc_msgSend_IntPtr(nswindow.Window, selStyleMask);

            // If the style mask is 0 it's the same as Borderless, it's not a flag.
            if (style == NSWindowStyleMask.Borderless)
            {
                return WindowBorderStyle.Borderless;
            }

            if (style.HasFlag(NSWindowStyleMask.UtilityWindow))
            {
                return WindowBorderStyle.ToolBox;
            }

            if (style.HasFlag(NSWindowStyleMask.Resizable))
            {
                return WindowBorderStyle.ResizableBorder;
            }

            return WindowBorderStyle.FixedBorder;
        }

        /// <inheritdoc/>
        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            switch (style)
            {
                case WindowBorderStyle.Borderless:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Borderless;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.FixedBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ResizableBorder:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        break;
                    }
                case WindowBorderStyle.ToolBox:
                    {
                        NSWindowStyleMask nsstyle = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable | NSWindowStyleMask.UtilityWindow;

                        objc_msgSend(nswindow.Window, selSetStyleMask, (IntPtr)nsstyle);

                        // FIXME: We can only set the utility flag on a NSPanel and not NSWindow...
                        // We might need to recreate the window as a panel, alternatively maybe it's
                        // possible to change the window to be an NSPanel after it's been instantiated?

                        Logger?.LogError("WindowBorderStyle.ToolBox currently doesn't work on macos.");

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, style.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (floating)
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Floating);
            }
            else
            {
                objc_msgSend(nswindow.Window, selSetLevel, (IntPtr)NSWindowLevel.Normal);
            }
        }

        /// <inheritdoc/>
        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            NSWindowLevel level = (NSWindowLevel)objc_msgSend_IntPtr(nswindow.Window, selLevel);
            if (level == NSWindowLevel.Floating)
            {
                return true;
            }
            else
            {
                // FIXME: Maybe log if level isn't `NSWindowLevel.Normal`?
                return false;
            }
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, selMakeKeyAndOrderFront, nswindow.Window);
        }

        /// <inheritdoc/>
        public void RequestAttention(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Maybe store the requestID so we can cancel the request?
            ulong requestID = objc_msgSend_ulong(nsApplication, selRequestUserAttention, (ulong)NSRequestUserAttentionType.CriticalRequest);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }
    }
}
