using System;
using System.Collections.Generic;
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

        internal static SEL selType = sel_registerName("type"u8);
        internal static SEL selSendEvent = sel_registerName("sendEvent:"u8);
        internal static SEL selNextEventMatchingMask = sel_registerName("nextEventMatchingMask:untilDate:inMode:dequeue:"u8);

        internal static SEL selFrame = sel_registerName("frame"u8);
        internal static SEL selSetFrameTopLeftPoint = sel_registerName("setFrameTopLeftPoint:"u8);

        internal static SEL selMakeKeyAndOrderFront = sel_registerName("makeKeyAndOrderFront:"u8);

        internal static SEL selRequestUserAttention = sel_registerName("requestUserAttention"u8);

        internal static IntPtr NSDefaultRunLoop = GetStringConstant(FoundationLibrary, "NSDefaultRunLoopMode"u8);

        internal static ObjCClass NSOpenTKWindowClass;
        internal static ObjCClass NSOpenTKViewClass;

        internal static readonly Dictionary<IntPtr, NSWindowHandle> NSWindowDict = new Dictionary<nint, NSWindowHandle>();

        public string Name => nameof(MacOSWindowComponent);

        public PalComponents Provides => PalComponents.Window;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "MacOSWindowComponent can only initialize the Window component.");
            }

            SEL selQuit = sel_registerName("quit"u8);

            ObjCClass nsapp = objc_getClass("NSApplication"u8);
            class_addMethod(nsapp, selQuit, OnQuitHandler, "v@:"u8);

            SEL selSharedApplication = sel_registerName("sharedApplication"u8);
            nsApplication = objc_msgSend_IntPtr((IntPtr)nsapp, selSharedApplication);

            objc_msgSend_bool(nsApplication, sel_registerName("setActivationPolicy:"u8), (long)NSApplicationActivationpolicy.Regular);
            objc_msgSend(nsApplication, sel_registerName("discardEventsMatchingMask:beforeEvent:"u8), (ulong)NSEventMask.Any, IntPtr.Zero);

            IntPtr mainMenu = objc_msgSend_IntPtr(nsApplication, sel_registerName("mainMenu"u8));
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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate void KeyDownDelegate(IntPtr @this, SEL sel, IntPtr /* NSEvent */ @event);
        internal static void keyDown(IntPtr @this, SEL sel, IntPtr /* NSEvent */ @event)
        {
            Console.WriteLine("Key down!");
        }

        public bool CanSetIcon => throw new NotImplementedException();

        public bool CanGetDisplay => throw new NotImplementedException();

        public bool CanSetCursor => throw new NotImplementedException();

        public bool CanCaptureCursor => throw new NotImplementedException();

        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        public IReadOnlyList<WindowBorderStyle> SupportedStyles => throw new NotImplementedException();

        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();


        public void ProcessEvents(bool waitForEvents = false)
        {
            // FIXME: Make this a loop!
            IntPtr @event = objc_msgSend_IntPtr(nsApplication, selNextEventMatchingMask, NSEventMask.Any, IntPtr.Zero, NSDefaultRunLoop, true);
            if (@event == IntPtr.Zero)
            {
                return;
            }

            NSEventType type = (NSEventType)objc_msgSend_ulong(@event, selType);
            
            IntPtr windowPtr = objc_msgSend_IntPtr(@event, sel_registerName("window"u8));
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
                        ulong button = objc_msgSend_ulong(@event, sel_registerName("buttonNumber"u8));
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
                        ulong button = objc_msgSend_ulong(@event, sel_registerName("buttonNumber"u8));
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

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.MouseEntered:
                    {
                        Console.WriteLine($"Window: {windowPtr}");
                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.MouseExited:
                    {
                        Console.WriteLine($"Window: {windowPtr}");
                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.MouseMoved:
                    {
                        CGPoint point = objc_msgSend_CGPoint(@event, sel_registerName("locationInWindow"u8));

                        CGRect pointRect = objc_msgSend_CGRect(nswindow.Window, sel_registerName("convertRectToBacking:"u8), new CGRect(point, CGPoint.Zero));

                        CGRect backing = objc_msgSend_CGRect(
                            nswindow.Window,
                            sel_registerName("convertRectToBacking:"u8),
                            objc_msgSend_CGRect(nswindow.View, sel_registerName("bounds"u8)));

                        Vector2 pos = new Vector2((float)pointRect.origin.x, (float)(backing.size.y - pointRect.origin.y));
                        
                        EventQueue.Raise(nswindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(nswindow, pos));

                        objc_msgSend(nsApplication, selSendEvent, @event);
                        break;
                    }
                case NSEventType.ScrollWheel:
                    {
                        float scrollX = objc_msgSend_float(@event, sel_registerName("scrollingDeltaX"u8));
                        float scrollY = objc_msgSend_float(@event, sel_registerName("scrollingDeltaY"u8));
                        Console.WriteLine($"scroll: ({scrollX}, {scrollY})");

                        bool preciseScrollingDeltas = objc_msgSend_bool(@event, sel_registerName("hasPreciseScrollingDeltas"u8));

                        // FIXME: We might need to flip the horizontal direction?
                        // FIXME: Consider precise deltas...
                        Vector2 delta = new Vector2(scrollX, scrollY);
                        Vector2 distance = new Vector2(scrollX, scrollY);

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

        public WindowHandle Create(GraphicsApiHints hints)
        {
            // FIXME: Better default placement of window?
            CGRect windowRect = new CGRect(500, 500, 500, 500);
            NSWindowStyleMask style = NSWindowStyleMask.Closable | NSWindowStyleMask.Miniaturizable | NSWindowStyleMask.Titled | NSWindowStyleMask.Resizable;

            IntPtr windowPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKWindowClass, Alloc),
                sel_registerName("initWithContentRect:styleMask:backing:defer:"u8),
                windowRect, style, NSBackingStoreType.Buffered, false);

            IntPtr viewPtr = objc_msgSend_IntPtr(windowPtr, sel_registerName("contentView"u8));
            // FIXME: Error checking!

            // Replace the view!
            viewPtr = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSOpenTKViewClass, Alloc),
                sel_registerName("initWithFrame:"u8),
                objc_msgSend_CGRect(viewPtr, sel_registerName("bounds"u8)));

            objc_msgSend(windowPtr, sel_registerName("setContentView:"u8), viewPtr);

            NSWindowHandle nswindow = new NSWindowHandle(windowPtr, viewPtr, hints);

            NSWindowDict.Add(windowPtr, nswindow);


            // FIXME: Move this somewhere?
            objc_msgSend(windowPtr, sel_registerName("setDelegate:"u8), windowPtr);
            objc_msgSend(windowPtr, sel_registerName("makeKeyWindow"u8));
            objc_msgSend(windowPtr, sel_registerName("center"u8));
            objc_msgSend(windowPtr, selMakeKeyAndOrderFront, windowPtr);

            return nswindow;
        }

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

        public bool IsWindowDestroyed(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            return nswindow.Destroyed;
        }

        public string GetTitle(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            IntPtr nsStringTitle = objc_msgSend_IntPtr(nswindow.Window, sel_registerName("title"u8));
            string title = FromNSString(nsStringTitle);
            return title;
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, sel_registerName("setTitle:"u8), ToNSString(title));
        }

        public IconHandle? GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect rect = objc_msgSend_CGRect(nswindow.Window, selFrame);

            // FIXME: Invert the Y coordinate.

            // FIXME: Convert screen coordinates to pixel coordinates.
            x = (int)rect.origin.x;
            // Add the height of the window to get the top left location.
            y = (int)(rect.origin.y + rect.size.y);
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Invert the Y coordinate.
            // FIXME: Convert pixel coordinates to macos screen coordinates...
            objc_msgSend(nswindow.Window, selSetFrameTopLeftPoint, new CGPoint(x, y));
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            CGRect rect = objc_msgSend_CGRect(nswindow.Window, selFrame);

            // FIXME: Convert screen coordinates to pixel coordinates.
            width = (int)rect.size.x;
            height = (int)rect.size.y;
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            // FIXME: setFrame:display:

            throw new NotImplementedException();
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        // FIXME: Separate the window size from the framebuffer size?

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);
            IntPtr screen = objc_msgSend_IntPtr(nswindow.Window, sel_registerName("screen"u8));

            CGRect rect = objc_msgSend_CGRect(nswindow.View, sel_registerName("frame"u8));

            CGRect backingRect = objc_msgSend_CGRect(screen, sel_registerName("convertRectToBacking:"u8), rect);

            width = (int)backingRect.size.x;
            height = (int)backingRect.size.y;
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            // FIXME:
            //throw new NotImplementedException();


        }

        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            throw new NotImplementedException();
        }

        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            throw new NotImplementedException();
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            // FIXME:
            //throw new NotImplementedException();
        }

        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            throw new NotImplementedException();
        }

        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            throw new NotImplementedException();
        }

        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            throw new NotImplementedException();
        }

        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            throw new NotImplementedException();
        }

        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            throw new NotImplementedException();
        }

        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            throw new NotImplementedException();
        }

        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            throw new NotImplementedException();
        }

        public void FocusWindow(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            objc_msgSend(nswindow.Window, selMakeKeyAndOrderFront, nswindow.Window);
        }

        public void RequestAttention(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // FIXME: Maybe store the requestID so we can cancel the request?
            ulong requestID = objc_msgSend_ulong(nsApplication, selRequestUserAttention, (ulong)NSRequestUserAttentionType.CriticalRequest);
        }

        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void SwapBuffers(WindowHandle handle)
        {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            if (nswindow.Context != null)
            {
                objc_msgSend(nswindow.Context.Context, MacOSOpenGLComponent.selFlushBuffer);
            }
            else
            {
                throw new InvalidOperationException("Cannot swap the buffer of a window without an OpenGL context.");
            }
        }
    }
}

