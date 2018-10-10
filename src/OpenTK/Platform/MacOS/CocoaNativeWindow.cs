//
// CocoaNativeWindow.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Mathematics;
using OpenTK.Core.Platform;
#if !MINIMAL
using System.Drawing;

#endif

namespace OpenTK.Platform.MacOS
{
    internal class CocoaNativeWindow : NativeWindowBase
    {
        private static int UniqueId;

        private static readonly IntPtr selNextEventMatchingMask =
            Selector.Get("nextEventMatchingMask:untilDate:inMode:dequeue:");

        private static readonly IntPtr selSendEvent = Selector.Get("sendEvent:");

        //static readonly IntPtr selUpdateWindows = Selector.Get("updateWindows");
        private static readonly IntPtr selContentView = Selector.Get("contentView");

        private static readonly IntPtr selConvertRectFromScreen = Selector.Get("convertRectFromScreen:");
        private static readonly IntPtr selConvertRectToScreen = Selector.Get("convertRectToScreen:");
        private static readonly IntPtr selPerformClose = Selector.Get("performClose:");
        private static readonly IntPtr selClose = Selector.Get("close");
        private static readonly IntPtr selTitle = Selector.Get("title");
        private static readonly IntPtr selSetTitle = Selector.Get("setTitle:");
        private static readonly IntPtr selSetApplicationIconImage = Selector.Get("setApplicationIconImage:");
        private static readonly IntPtr selIsKeyWindow = Selector.Get("isKeyWindow");
        private static readonly IntPtr selIsVisible = Selector.Get("isVisible");
        private static readonly IntPtr selSetIsVisible = Selector.Get("setIsVisible:");
        private static readonly IntPtr selFrame = Selector.Get("frame");
        private static readonly IntPtr selVisibleFrame = Selector.Get("visibleFrame");
        private static readonly IntPtr selBounds = Selector.Get("bounds");
        private static readonly IntPtr selScreen = Selector.Get("screen");
        private static readonly IntPtr selSetFrame = Selector.Get("setFrame:display:");
        private static readonly IntPtr selConvertRectToBacking = Selector.Get("convertRectToBacking:");
        private static readonly IntPtr selConvertRectFromBacking = Selector.Get("convertRectFromBacking:");
        private static readonly IntPtr selFrameRectForContentRect = Selector.Get("frameRectForContentRect:");
        private static readonly IntPtr selType = Selector.Get("type");
        private static readonly IntPtr selKeyCode = Selector.Get("keyCode");
        private static readonly IntPtr selModifierFlags = Selector.Get("modifierFlags");
        private static readonly IntPtr selIsARepeat = Selector.Get("isARepeat");
        private static readonly IntPtr selCharactersIgnoringModifiers = Selector.Get("charactersIgnoringModifiers");
        private static readonly IntPtr selAddTrackingArea = Selector.Get("addTrackingArea:");
        private static readonly IntPtr selRemoveTrackingArea = Selector.Get("removeTrackingArea:");
        private static readonly IntPtr selTrackingArea = Selector.Get("trackingArea");
        private static readonly IntPtr selInitWithSize = Selector.Get("initWithSize:");
        private static readonly IntPtr selInitWithRect = Selector.Get("initWithRect:options:owner:userInfo:");
        private static readonly IntPtr selOwner = Selector.Get("owner");
        private static readonly IntPtr selLocationInWindowOwner = Selector.Get("locationInWindow");
        private static readonly IntPtr selHide = Selector.Get("hide");
        private static readonly IntPtr selUnhide = Selector.Get("unhide");
        private static readonly IntPtr selScrollingDeltaX = Selector.Get("scrollingDeltaX");
        private static readonly IntPtr selScrollingDeltaY = Selector.Get("scrollingDeltaY");
        private static readonly IntPtr selDeltaX = Selector.Get("deltaX");
        private static readonly IntPtr selDeltaY = Selector.Get("deltaY");
        private static readonly IntPtr selButtonNumber = Selector.Get("buttonNumber");
        private static readonly IntPtr selSetStyleMask = Selector.Get("setStyleMask:");
        private static readonly IntPtr selStyleMask = Selector.Get("styleMask");

        private static readonly IntPtr selHasPreciseScrollingDeltas = Selector.Get("hasPreciseScrollingDeltas");

        //static readonly IntPtr selIsMiniaturized = Selector.Get("isMiniaturized");
        //static readonly IntPtr selIsZoomed = Selector.Get("isZoomed");
        //static readonly IntPtr selPerformMiniaturize = Selector.Get("performMiniaturize:");
        private static readonly IntPtr selMiniaturize = Selector.Get("miniaturize:");

        private static readonly IntPtr selDeminiaturize = Selector.Get("deminiaturize:");

        //static readonly IntPtr selPerformZoom = Selector.Get("performZoom:");
        //static readonly IntPtr selZoom = Selector.Get("zoom:");
        private static readonly IntPtr selLevel = Selector.Get("level");

        private static readonly IntPtr selSetLevel = Selector.Get("setLevel:");
        private static readonly IntPtr selPresentationOptions = Selector.Get("presentationOptions");

        private static readonly IntPtr selSetPresentationOptions = Selector.Get("setPresentationOptions:");

        //static readonly IntPtr selIsInFullScreenMode = Selector.Get("isInFullScreenMode");
        //static readonly IntPtr selExitFullScreenModeWithOptions = Selector.Get("exitFullScreenModeWithOptions:");
        //static readonly IntPtr selEnterFullScreenModeWithOptions = Selector.Get("enterFullScreenMode:withOptions:");
        private static readonly IntPtr selArrowCursor = Selector.Get("arrowCursor");

        private static readonly IntPtr selAddCursorRect = Selector.Get("addCursorRect:cursor:");
        private static readonly IntPtr selInvalidateCursorRectsForView = Selector.Get("invalidateCursorRectsForView:");

        private static readonly IntPtr selInitWithBitmapDataPlanes =
            Selector.Get(
                "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");

        private static readonly IntPtr selBitmapData = Selector.Get("bitmapData");
        private static readonly IntPtr selAddRepresentation = Selector.Get("addRepresentation:");
        private static readonly IntPtr selInitWithImageHotSpot = Selector.Get("initWithImage:hotSpot:");

        private static readonly IntPtr NSDefaultRunLoopMode;
        private static readonly IntPtr NSCursor;
        private static readonly IntPtr NSImage;
        private static readonly IntPtr NSBitmapImageRep;
        private static readonly IntPtr NSDeviceRGBColorSpace = Cocoa.ToNSString("NSDeviceRGBColorSpace");
        private static readonly IntPtr NSFilenamesPboardType;
        private readonly AcceptsFirstResponderDelegate AcceptsFirstResponderHandler;
        private readonly CanBecomeKeyWindowDelegate CanBecomeKeyWindowHandler;
        private readonly CanBecomeMainWindowDelegate CanBecomeMainWindowHandler;
        private readonly DraggingEnteredDelegate DraggingEnteredHandler;
        private readonly PerformDragOperationDelegate PerformDragOperationHandler;
        private readonly ResetCursorRectsDelegate ResetCursorRectsHandler;

        private readonly IntPtr windowClass;
        private readonly WindowDidBecomeKeyDelegate WindowDidBecomeKeyHandler;
        private readonly WindowDidDeminiaturizeDelegate WindowDidDeminiaturizeHandler;
        private readonly WindowDidMiniaturizeDelegate WindowDidMiniaturizeHandler;
        private readonly WindowDidMoveDelegate WindowDidMoveHandler;
        private readonly WindowDidResignKeyDelegate WindowDidResignKeyHandler;
        private readonly WindowDidResizeDelegate WindowDidResizeHandler;

        private readonly CocoaWindowInfo windowInfo;

        private readonly WindowKeyDownDelegate WindowKeyDownHandler;
        private readonly WindowShouldCloseDelegate WindowShouldCloseHandler;
        private readonly WindowShouldZoomToFrameDelegate WindowShouldZoomToFrameHandler;
        private readonly WindowWillMiniaturizeDelegate WindowWillMiniaturizeHandler;
        private IntPtr current_icon_handle;
        private bool cursorVisible = true;
        private WindowBorder? deferredWindowBorder;
        private bool disposed;
        private bool exists;
        private Icon icon;
        private int normalLevel;
        private RectangleF previousBounds;
        private WindowBorder? previousWindowBorder;
        private MouseCursor selectedCursor = MouseCursor.Default; // user-selected cursor
        private bool shouldClose;
        private int suppressResize;
        private string title;
        private IntPtr trackingArea;
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private WindowState windowState = WindowState.Normal;

        static CocoaNativeWindow()
        {
            Cocoa.Initialize();
            NSApplication
                .Initialize(); // Problem: This does not allow creating a separate app and using CocoaNativeWindow.
            NSDefaultRunLoopMode = Cocoa.GetStringConstant(Cocoa.FoundationLibrary, "NSDefaultRunLoopMode");
            NSCursor = Class.Get("NSCursor");
            NSImage = Class.Get("NSImage");
            NSBitmapImageRep = Class.Get("NSBitmapImageRep");
            NSFilenamesPboardType = Cocoa.GetStringConstant(Cocoa.AppKitLibrary, "NSFilenamesPboardType");
        }

        public CocoaNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode,
            GameWindowFlags options, DisplayDevice device)
        {
            // Create callback methods. We need to store those,
            // otherwise the GC may collect them while they are
            // still active.
            WindowKeyDownHandler = WindowKeyDown;
            WindowDidResizeHandler = WindowDidResize;
            WindowDidMoveHandler = WindowDidMove;
            WindowDidBecomeKeyHandler = WindowDidBecomeKey;
            WindowDidResignKeyHandler = WindowDidResignKey;
            WindowWillMiniaturizeHandler = WindowWillMiniaturize;
            WindowDidMiniaturizeHandler = WindowDidMiniaturize;
            WindowDidDeminiaturizeHandler = WindowDidDeminiaturize;
            WindowShouldZoomToFrameHandler = WindowShouldZoomToFrame;
            WindowShouldCloseHandler = WindowShouldClose;
            AcceptsFirstResponderHandler = AcceptsFirstResponder;
            CanBecomeKeyWindowHandler = CanBecomeKeyWindow;
            CanBecomeMainWindowHandler = CanBecomeMainWindow;
            ResetCursorRectsHandler = ResetCursorRects;
            PerformDragOperationHandler = PerformDragOperation;
            DraggingEnteredHandler = DraggingEntered;

            // Create the window class
            var unique_id = Interlocked.Increment(ref UniqueId);
            windowClass = Class.AllocateClass("OpenTK_GameWindow" + unique_id, "NSWindow");
            Class.RegisterMethod(windowClass, WindowKeyDownHandler, "keyDown:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidResizeHandler, "windowDidResize:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidMoveHandler, "windowDidMove:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidBecomeKeyHandler, "windowDidBecomeKey:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidResignKeyHandler, "windowDidResignKey:", "v@:@");
            Class.RegisterMethod(windowClass, WindowWillMiniaturizeHandler, "windowWillMiniaturize:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidMiniaturizeHandler, "windowDidMiniaturize:", "v@:@");
            Class.RegisterMethod(windowClass, WindowDidDeminiaturizeHandler, "windowDidDeminiaturize:", "v@:@");
            Class.RegisterMethod(windowClass, WindowShouldZoomToFrameHandler, "windowShouldZoom:toFrame:",
                "b@:@{NSRect={NSPoint=ff}{NSSize=ff}}");
            Class.RegisterMethod(windowClass, WindowShouldCloseHandler, "windowShouldClose:", "b@:@");
            Class.RegisterMethod(windowClass, AcceptsFirstResponderHandler, "acceptsFirstResponder", "b@:");
            Class.RegisterMethod(windowClass, CanBecomeKeyWindowHandler, "canBecomeKeyWindow", "b@:");
            Class.RegisterMethod(windowClass, CanBecomeMainWindowHandler, "canBecomeMainWindow", "b@:");
            Class.RegisterMethod(windowClass, DraggingEnteredHandler, "draggingEntered:", "@@:@");
            Class.RegisterMethod(windowClass, PerformDragOperationHandler, "performDragOperation:", "b@:@");

            Class.RegisterClass(windowClass);

            var viewClass = Class.AllocateClass("OpenTK_NSView" + unique_id, "NSView");
            Class.RegisterMethod(viewClass, ResetCursorRectsHandler, "resetCursorRects", "v@:");
            Class.RegisterClass(viewClass);

            // Create window instance
            // Note: The coordinate system of Cocoa places (0,0) at the bottom left.
            // We need to get the height of the main screen and flip that in order
            // to place the window at the correct position.
            // Note: NSWindows are laid out relative to the main screen.
            var screenRect =
                Cocoa.SendRect(
                    Cocoa.SendIntPtr(
                        Cocoa.SendIntPtr(Class.Get("NSScreen"), Selector.Get("screens")),
                        Selector.Get("objectAtIndex:"), 0),
                    Selector.Get("frame"));
            var contentRect = new RectangleF(x, screenRect.Height - height - y, width, height);
            var style = GetStyleMask(windowBorder);
            var bufferingType = NSBackingStore.Buffered;

            IntPtr classPtr;
            classPtr = Cocoa.SendIntPtr(windowClass, Selector.Alloc);
            if (classPtr == IntPtr.Zero)
            {
                Debug.Print("[Error] Failed to allocate window class.");
                throw new PlatformException();
            }

            var defer = false;
            var windowPtr = Cocoa.SendIntPtr(classPtr, Selector.Get("initWithContentRect:styleMask:backing:defer:"),
                contentRect, (int)style, (int)bufferingType, defer);
            if (windowPtr == IntPtr.Zero)
            {
                Debug.Print("[Error] Failed to initialize window with ({0}, {1}, {2}, {3}).",
                    contentRect, style, bufferingType, defer);
                throw new PlatformException();
            }

            // Replace view with our custom implementation
            // that overrides resetCursorRects (maybe there is
            // a better way to implement this override?)
            // Existing view:
            var viewPtr = Cocoa.SendIntPtr(windowPtr, Selector.Get("contentView"));
            if (viewPtr == IntPtr.Zero)
            {
                Debug.Print("[Error] Failed to retrieve content view for window {0}.", windowPtr);
                throw new PlatformException();
            }

            // Our custom view with the same bounds:
            viewPtr = Cocoa.SendIntPtr(
                Cocoa.SendIntPtr(viewClass, Selector.Alloc),
                Selector.Get("initWithFrame:"),
                Cocoa.SendRect(viewPtr, selBounds));
            if (viewPtr != IntPtr.Zero)
            {
                Cocoa.SendVoid(windowPtr, Selector.Get("setContentView:"), viewPtr);
            }
            else
            {
                Debug.Print("[Error] Failed to initialize content view with frame {0}.", selBounds);
                throw new PlatformException();
            }

            windowInfo = new CocoaWindowInfo(windowPtr);

            // Set up behavior
            Cocoa.SendIntPtr(windowPtr, Selector.Get("setDelegate:"),
                windowPtr); // The window class acts as its own delegate
            Cocoa.SendVoid(windowPtr, Selector.Get("makeKeyWindow"));
            SetTitle(title, false);

            ResetTrackingArea();

            exists = true;
            NSApplication.Quit += ApplicationQuit;

            // Enable drag and drop
            Cocoa.SendIntPtr(
                windowPtr,
                Selector.Get("registerForDraggedTypes:"),
                Cocoa.SendIntPtr(
                    Class.Get("NSArray"),
                    Selector.Get("arrayWithObjects:"),
                    NSFilenamesPboardType,
                    IntPtr.Zero));
        }

        public override Icon Icon
        {
            get => icon;
            set
            {
                if (value != null && value != icon)
                {
                    // Create and set new icon
                    var nsimg = IntPtr.Zero;
                    using (Image img = value.ToBitmap())
                    {
                        nsimg = Cocoa.ToNSImage(img);
                        if (nsimg != IntPtr.Zero)
                        {
                            Cocoa.SendVoid(NSApplication.Handle, selSetApplicationIconImage, nsimg);
                        }
                        else
                        {
                            Debug.Print("[Mac] Failed to create NSImage for {0}", value);
                            return;
                        }
                    }

                    // Release previous icon
                    if (current_icon_handle != IntPtr.Zero)
                    {
                        Cocoa.SendVoid(current_icon_handle, Selector.Release);
                    }

                    // Raise IconChanged event
                    current_icon_handle = nsimg;
                    icon = value;
                    OnIconChanged(EventArgs.Empty);
                }
            }
        }

        public override string Title
        {
            get => Cocoa.FromNSString(Cocoa.SendIntPtr(windowInfo.Handle, selTitle));
            set => SetTitle(value, true);
        }

        public override bool Focused => Cocoa.SendBool(windowInfo.Handle, selIsKeyWindow);

        public override bool Visible
        {
            get => Cocoa.SendBool(windowInfo.Handle, selIsVisible);
            set
            {
                Cocoa.SendVoid(windowInfo.Handle, selSetIsVisible, value);
                OnVisibleChanged(EventArgs.Empty);
            }
        }

        public override bool Exists => exists;

        public override IWindowInfo WindowInfo => windowInfo;

        public override WindowState WindowState
        {
            get => windowState;
            set
            {
                var oldState = windowState;
                if (oldState == value)
                {
                    return;
                }

                RestoreWindowState();

                if (value == WindowState.Fullscreen)
                {
                    if (MacOSFactory.ExclusiveFullscreen)
                    {
                        normalLevel = Cocoa.SendInt(windowInfo.Handle, selLevel);
                        var windowLevel = CG.ShieldingWindowLevel();

                        CG.CaptureAllDisplays();
                        Cocoa.SendVoid(windowInfo.Handle, selSetLevel, windowLevel);
                    }

                    previousBounds = InternalBounds;
                    previousWindowBorder = WindowBorder;

                    SetMenuVisible(false);
                    HideBorder();
                    InternalBounds = GetCurrentScreenFrame();

                    windowState = value;
                    OnWindowStateChanged(EventArgs.Empty);
                }
                else if (value == WindowState.Maximized)
                {
                    WindowShouldZoomToFrame(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, GetCurrentScreenVisibleFrame());
                }
                else if (value == WindowState.Minimized)
                {
                    Cocoa.SendVoid(windowInfo.Handle, selMiniaturize, windowInfo.Handle);
                }
                else if (value == WindowState.Normal)
                {
                    windowState = value;
                    OnWindowStateChanged(EventArgs.Empty);
                    OnResize(EventArgs.Empty);
                }
            }
        }

        public override WindowBorder WindowBorder
        {
            get => windowBorder;
            set
            {
                // Do not allow border changes during fullscreen mode.
                if (windowState == WindowState.Fullscreen || windowState == WindowState.Maximized)
                {
                    deferredWindowBorder = value;
                    return;
                }

                if (windowBorder == value)
                {
                    return;
                }

                SetWindowBorder(value);
                OnWindowBorderChanged(EventArgs.Empty);
            }
        }

        public override Rectangle Bounds
        {
            get
            {
                var r = Cocoa.SendRect(windowInfo.Handle, selFrame);
                return new Rectangle(
                    (int)r.X,
                    (int)(GetCurrentScreenFrame().Height - r.Y - r.Height),
                    (int)r.Width,
                    (int)r.Height);
            }
            set => Cocoa.SendVoid(windowInfo.Handle, selSetFrame,
                new RectangleF(
                    value.X,
                    GetCurrentScreenFrame().Height - value.Y - value.Height,
                    value.Width,
                    value.Height),
                true);
        }

        private RectangleF InternalBounds
        {
            get => Cocoa.SendRect(windowInfo.Handle, selFrame);
            set => Cocoa.SendVoid(windowInfo.Handle, selSetFrame, value, true);
        }

        public override Size ClientSize
        {
            get
            {
                var contentViewBounds = Cocoa.SendRect(windowInfo.ViewHandle, selBounds);
                var bounds = Cocoa.SendRect(windowInfo.Handle, selConvertRectToBacking, contentViewBounds);
                return new Size((int)bounds.Width, (int)bounds.Height);
            }
            set
            {
                var r_scaled = Cocoa.SendRect(windowInfo.Handle, selConvertRectFromBacking,
                    new RectangleF(PointF.Empty, new SizeF(value.Width, value.Height)));
                var r = Cocoa.SendRect(windowInfo.Handle, selFrameRectForContentRect, r_scaled);
                Size = new Size((int)r.Width, (int)r.Height);
            }
        }

        public override MouseCursor Cursor
        {
            get => selectedCursor;
            set
            {
                selectedCursor = value;
                InvalidateCursorRects();
            }
        }

        public override bool CursorVisible
        {
            get => cursorVisible;
            set
            {
                if (value != cursorVisible)
                {
                    SetCursorVisible(value);
                    cursorVisible = value;
                }
            }
        }

        private IntPtr DraggingEntered(IntPtr self, IntPtr cmd, IntPtr sender)
        {
            var mask = Cocoa.SendInt(sender, Selector.Get("draggingSourceOperationMask"));

            if ((mask & (int)NSDragOperation.Generic) == (int)NSDragOperation.Generic)
            {
                return new IntPtr((int)NSDragOperation.Generic);
            }

            return new IntPtr((int)NSDragOperation.None);
        }

        private bool PerformDragOperation(IntPtr self, IntPtr cmd, IntPtr sender)
        {
            var pboard = Cocoa.SendIntPtr(sender, Selector.Get("draggingPasteboard"));

            var files = Cocoa.SendIntPtr(pboard, Selector.Get("propertyListForType:"), NSFilenamesPboardType);

            var count = Cocoa.SendInt(files, Selector.Get("count"));
            for (var i = 0; i < count; ++i)
            {
                var obj = Cocoa.SendIntPtr(files, Selector.Get("objectAtIndex:"), new IntPtr(i));
                var str = Cocoa.SendIntPtr(obj, Selector.Get("cStringUsingEncoding:"), new IntPtr(1));
                OnFileDrop(Marshal.PtrToStringAuto(str));
            }

            return true;
        }

        private void WindowKeyDown(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            // Steal the event to remove the "beep" sound that is normally played for unhandled key events.
        }

        private void WindowDidResize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                OnResize(true);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void OnResize(bool resetTracking)
        {
            if (resetTracking)
            {
                ResetTrackingArea();
            }

            var context = GraphicsContext.CurrentContext;
            if (context != null)
            {
                context.Update(windowInfo);
            }

            if (suppressResize == 0)
            {
                OnResize(EventArgs.Empty);
            }
        }

        private void ApplicationQuit(object sender, CancelEventArgs e)
        {
            try
            {
                var close = WindowShouldClose(windowInfo.Handle, IntPtr.Zero, IntPtr.Zero);
                e.Cancel |= !close;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void WindowDidMove(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                // Problem: Called only when you stop moving for a brief moment,
                // not each frame as it is on PC.
                OnMove(EventArgs.Empty);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void WindowDidBecomeKey(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                OnFocusedChanged(EventArgs.Empty);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void WindowDidResignKey(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                OnFocusedChanged(EventArgs.Empty);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void WindowWillMiniaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                // Can get stuck in weird states if we maximize, then minimize;
                // restoring to the old state would override the normalBounds.
                // To avoid this without adding complexity, just restore state here.
                RestoreWindowState(); // Avoid getting in weird states
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void WindowDidMiniaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                windowState = WindowState.Minimized;
                OnWindowStateChanged(EventArgs.Empty);
                OnResize(false); // Don't set tracking area when we minimize
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private void WindowDidDeminiaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            try
            {
                windowState = WindowState.Normal;
                OnWindowStateChanged(EventArgs.Empty);
                OnResize(true);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        private bool WindowShouldZoomToFrame(IntPtr self, IntPtr cmd, IntPtr nsWindow, RectangleF toFrame)
        {
            try
            {
                if (windowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
                else
                {
                    previousBounds = InternalBounds;
                    previousWindowBorder = WindowBorder;

                    InternalBounds = toFrame;
                    windowState = WindowState.Maximized;

                    OnWindowStateChanged(EventArgs.Empty);
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }

            return false;
        }

        private bool WindowShouldClose(IntPtr self, IntPtr cmd, IntPtr sender)
        {
            try
            {
                var cancelArgs = new CancelEventArgs();
                OnClosing(cancelArgs);

                if (!cancelArgs.Cancel)
                {
                    OnClosed(EventArgs.Empty);
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }

            return false;
        }

        private bool AcceptsFirstResponder(IntPtr self, IntPtr cmd)
        {
            return true;
        }

        private bool CanBecomeKeyWindow(IntPtr self, IntPtr cmd)
        {
            return true;
        }

        private bool CanBecomeMainWindow(IntPtr self, IntPtr cmd)
        {
            return true;
        }

        private void ResetTrackingArea()
        {
            try
            {
                var owner = windowInfo.ViewHandle;
                if (trackingArea != IntPtr.Zero)
                {
                    Cocoa.SendVoid(owner, selRemoveTrackingArea, trackingArea);
                    Cocoa.SendVoid(trackingArea, Selector.Release);
                }

                var ownerBounds = Cocoa.SendRect(owner, selBounds);
                var options = (int)(
                    NSTrackingAreaOptions.MouseEnteredAndExited |
                    NSTrackingAreaOptions.ActiveInKeyWindow |
                    NSTrackingAreaOptions.MouseMoved |
                    NSTrackingAreaOptions.CursorUpdate);

                trackingArea = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSTrackingArea"), Selector.Alloc),
                    selInitWithRect, ownerBounds, options, owner, IntPtr.Zero);

                Cocoa.SendVoid(owner, selAddTrackingArea, trackingArea);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        public override void Close()
        {
            shouldClose = true;
        }

        private KeyModifiers GetModifiers(NSEventModifierMask mask)
        {
            KeyModifiers modifiers = 0;
            if ((mask & NSEventModifierMask.ControlKeyMask) != 0)
            {
                modifiers |= KeyModifiers.Control;
            }

            if ((mask & NSEventModifierMask.ShiftKeyMask) != 0)
            {
                modifiers |= KeyModifiers.Shift;
            }

            if ((mask & NSEventModifierMask.AlternateKeyMask) != 0)
            {
                modifiers |= KeyModifiers.Alt;
            }

            if ((mask & NSEventModifierMask.CommandKeyMask) != 0)
            {
                modifiers |= OpenTK.Input.KeyModifiers.Command;
            }

            return modifiers;
        }

        private MouseButton GetMouseButton(int cocoaButtonIndex)
        {
            if (cocoaButtonIndex == 0)
            {
                return MouseButton.Left;
            }

            if (cocoaButtonIndex == 1)
            {
                return MouseButton.Right;
            }

            if (cocoaButtonIndex == 2)
            {
                return MouseButton.Middle;
            }

            if (cocoaButtonIndex >= (int)MouseButton.LastButton)
            {
                return MouseButton.LastButton;
            }

            return (MouseButton)cocoaButtonIndex;
        }

        public override void ProcessEvents()
        {
            base.ProcessEvents();

            while (true)
            {
                var e = Cocoa.SendIntPtr(NSApplication.Handle, selNextEventMatchingMask, uint.MaxValue, IntPtr.Zero,
                    NSDefaultRunLoopMode, true);

                if (e == IntPtr.Zero)
                {
                    break;
                }

                var type = (NSEventType)Cocoa.SendInt(e, selType);
                switch (type)
                {
                    case NSEventType.KeyDown:
                    {
                        var keyCode = (MacOSKeyCode)Cocoa.SendUshort(e, selKeyCode);
                        var isARepeat = Cocoa.SendBool(e, selIsARepeat);
                        var key = MacOSKeyMap.GetKey(keyCode);

                        OnKeyDown(key, isARepeat);

                        var s = Cocoa.FromNSString(Cocoa.SendIntPtr(e, selCharactersIgnoringModifiers));
                        foreach (var c in s)
                        {
                            var intVal = (int)c;
                            if (!char.IsControl(c) && (intVal < 63232 || intVal > 63235))
                            {
                                // For some reason, arrow keys (mapped 63232-63235)
                                // are seen as non-control characters, so get rid of those.
                                OnKeyPress(c);
                            }
                        }

                        break;
                    }
                    case NSEventType.KeyUp:
                    {
                        var keyCode = (MacOSKeyCode)Cocoa.SendUshort(e, selKeyCode);
                        var key = MacOSKeyMap.GetKey(keyCode);
                        OnKeyUp(key);
                        break;
                    }
                    case NSEventType.FlagsChanged:
                    {
                        var modifierFlags = (NSEventModifierMask)Cocoa.SendUint(e, selModifierFlags);
                        UpdateModifierFlags(GetModifiers(modifierFlags));
                        break;
                    }
                    case NSEventType.MouseEntered:
                    {
                        var eventTrackingArea = Cocoa.SendIntPtr(e, selTrackingArea);
                        var trackingAreaOwner = Cocoa.SendIntPtr(eventTrackingArea, selOwner);
                        if (trackingAreaOwner == windowInfo.ViewHandle)
                        {
                            if (selectedCursor != MouseCursor.Default)
                            {
                                //SetCursor(selectedCursor);
                            }

                            OnMouseEnter(EventArgs.Empty);
                        }

                        break;
                    }
                    case NSEventType.MouseExited:
                    {
                        var eventTrackingArea = Cocoa.SendIntPtr(e, selTrackingArea);
                        var trackingAreaOwner = Cocoa.SendIntPtr(eventTrackingArea, selOwner);
                        if (trackingAreaOwner == windowInfo.ViewHandle)
                        {
                            if (selectedCursor != MouseCursor.Default)
                            {
                                //SetCursor(MouseCursor.Default);
                            }

                            OnMouseLeave(EventArgs.Empty);
                        }

                        break;
                    }
                    case NSEventType.LeftMouseDragged:
                    case NSEventType.RightMouseDragged:
                    case NSEventType.OtherMouseDragged:
                    case NSEventType.MouseMoved:
                    {
                        var p = new Point(MouseState.X, MouseState.Y);
                        if (CursorVisible)
                        {
                            // Use absolute coordinates
                            var pf = Cocoa.SendPoint(e, selLocationInWindowOwner);

                            // Convert from points to pixel coordinates
                            var rf = Cocoa.SendRect(windowInfo.Handle, selConvertRectToBacking,
                                new RectangleF(pf.X, pf.Y, 0, 0));

                            // See CocoaDrawingGuide under "Converting from Window to View Coordinates"
                            p = new Point(
                                MathHelper.Clamp((int)Math.Round(rf.X), 0, Width),
                                MathHelper.Clamp((int)Math.Round(Height - rf.Y), 0, Height));
                        }
                        else
                        {
                            // Mouse has been disassociated,
                            // use relative coordinates
                            var dx = Cocoa.SendFloat(e, selDeltaX);
                            var dy = Cocoa.SendFloat(e, selDeltaY);

                            p = new Point(
                                MathHelper.Clamp((int)Math.Round(p.X + dx), 0, Width),
                                MathHelper.Clamp((int)Math.Round(p.Y + dy), 0, Height));
                        }

                        // Only raise events when the mouse has actually moved
                        if (MouseState.X != p.X || MouseState.Y != p.Y)
                        {
                            OnMouseMove(p.X, p.Y);
                        }

                        break;
                    }
                    case NSEventType.CursorUpdate:
                    {
                        break;
                    }
                    case NSEventType.ScrollWheel:
                    {
                        float dx, dy;
                        if (Cocoa.SendBool(e, selHasPreciseScrollingDeltas))
                        {
                            dx = Cocoa.SendFloat(e, selScrollingDeltaX) * MacOSFactory.ScrollFactor;
                            dy = Cocoa.SendFloat(e, selScrollingDeltaY) * MacOSFactory.ScrollFactor;
                        }
                        else
                        {
                            dx = Cocoa.SendFloat(e, selDeltaX);
                            dy = Cocoa.SendFloat(e, selDeltaY);
                        }

                        // Only raise wheel events when the user has actually scrolled
                        if (dx != 0 || dy != 0)
                        {
                            // Note: OpenTK follows the win32 convention, where
                            // (+h, +v) = (right, up). MacOS reports (+h, +v) = (left, up)
                            // so we need to flip the horizontal scroll direction.
                            OnMouseWheel(-dx, dy);
                        }

                        break;
                    }
                    case NSEventType.LeftMouseDown:
                    case NSEventType.RightMouseDown:
                    case NSEventType.OtherMouseDown:
                    {
                        var buttonNumber = Cocoa.SendInt(e, selButtonNumber);
                        OnMouseDown(GetMouseButton(buttonNumber));
                        break;
                    }
                    case NSEventType.LeftMouseUp:
                    case NSEventType.RightMouseUp:
                    case NSEventType.OtherMouseUp:
                    {
                        var buttonNumber = Cocoa.SendInt(e, selButtonNumber);
                        OnMouseUp(GetMouseButton(buttonNumber));
                        break;
                    }
                }

                Cocoa.SendVoid(NSApplication.Handle, selSendEvent, e);
            }

            // Handle closing
            if (shouldClose)
            {
                shouldClose = false;
                CloseWindow(false);
            }
        }

        public override Point PointToClient(Point point)
        {
            var r =
                Cocoa.SendRect(windowInfo.ViewHandle, selConvertRectToBacking,
                    Cocoa.SendRect(windowInfo.Handle, selConvertRectFromScreen,
                        new RectangleF(point.X, GetCurrentScreenFrame().Height - point.Y, 0, 0)));
            return new Point((int)r.X, (int)(Height - r.Y));
        }

        public override Point PointToScreen(Point point)
        {
            var r =
                Cocoa.SendRect(windowInfo.Handle, selConvertRectToScreen,
                    Cocoa.SendRect(windowInfo.ViewHandle, selConvertRectFromBacking,
                        new RectangleF(point.X, Height - point.Y, 0, 0)));
            return new Point((int)r.X, (int)(GetCurrentScreenFrame().Height - r.Y));
        }

        private void RestoreWindowState()
        {
            suppressResize++;
            if (windowState == WindowState.Fullscreen)
            {
                SetMenuVisible(true);
                if (MacOSFactory.ExclusiveFullscreen)
                {
                    CG.DisplayReleaseAll();
                    Cocoa.SendVoid(windowInfo.Handle, selSetLevel, normalLevel);
                }

                RestoreBorder();
                InternalBounds = previousBounds;
            }
            else if (windowState == WindowState.Maximized)
            {
                RestoreBorder();
                InternalBounds = previousBounds;
            }
            else if (windowState == WindowState.Minimized)
            {
                Cocoa.SendVoid(windowInfo.Handle, selDeminiaturize, windowInfo.Handle);
            }

            windowState = WindowState.Normal;
            suppressResize--;
        }

        private void HideBorder()
        {
            suppressResize++;
            SetWindowBorder(WindowBorder.Hidden);
            ProcessEvents();
            suppressResize--;
        }

        private void RestoreBorder()
        {
            suppressResize++;
            SetWindowBorder(
                deferredWindowBorder.HasValue ? deferredWindowBorder.Value :
                previousWindowBorder.HasValue ? previousWindowBorder.Value :
                windowBorder);

            ProcessEvents();
            suppressResize--;
            deferredWindowBorder = null;
            previousWindowBorder = null;
        }

        private void SetWindowBorder(WindowBorder windowBorder)
        {
            this.windowBorder = windowBorder;
            UpdateWindowBorder();
        }

        private static NSWindowStyle GetStyleMask(WindowBorder windowBorder)
        {
            switch (windowBorder)
            {
                case WindowBorder.Resizable:
                    return NSWindowStyle.Closable | NSWindowStyle.Miniaturizable | NSWindowStyle.Titled |
                           NSWindowStyle.Resizable;
                case WindowBorder.Fixed:
                    return NSWindowStyle.Closable | NSWindowStyle.Miniaturizable | NSWindowStyle.Titled;
                case WindowBorder.Hidden: return NSWindowStyle.Borderless;
            }

            return 0;
        }

        private static IntPtr ToNSCursor(MouseCursor cursor)
        {
            // We need to allocate a NSBitmapImageRep, fill it with pixels
            // and then convert it to a NSImage.
            // According to the documentation, alpha-enabled formats should
            // premultiply alpha, even though that "generally has negligible
            // effect on output quality."
            var imgdata =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(NSBitmapImageRep, Selector.Alloc),
                    selInitWithBitmapDataPlanes,
                    IntPtr.Zero,
                    cursor.Width,
                    cursor.Height,
                    8,
                    4,
                    true,
                    false,
                    NSDeviceRGBColorSpace,
                    NSBitmapFormat.AlphaFirst,
                    4 * cursor.Width,
                    32);
            if (imgdata == IntPtr.Zero)
            {
                Debug.Print("Failed to create NSBitmapImageRep with size ({0},{1})",
                    cursor.Width, cursor.Height);
                return IntPtr.Zero;
            }

            // Copy the cursor data
            var i = 0;
            var data = Cocoa.SendIntPtr(imgdata, selBitmapData);
            for (var y = 0; y < cursor.Height; y++)
            {
                for (var x = 0; x < cursor.Width; x++)
                {
                    var argb = unchecked((uint)BitConverter.ToInt32(cursor.Data, i));
                    if (BitConverter.IsLittleEndian)
                    {
                        argb =
                            ((argb & 0x000000FFu) << 24) |
                            ((argb & 0x0000FF00u) << 8) |
                            ((argb & 0x00FF0000u) >> 8) |
                            ((argb & 0xFF000000u) >> 24);
                    }

                    Marshal.WriteInt32(data, i, unchecked((int)argb));
                    i += 4;
                }
            }

            // Construct the actual NSImage
            var img =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(NSImage, Selector.Alloc),
                    selInitWithSize,
                    new SizeF(cursor.Width, cursor.Height));
            if (img == IntPtr.Zero)
            {
                Debug.Print("Failed to construct NSImage from NSBitmapImageRep");
                Cocoa.SendVoid(imgdata, Selector.Release);
                return IntPtr.Zero;
            }

            Cocoa.SendVoid(img, selAddRepresentation, imgdata);

            // Convert the NSImage to a NSCursor
            var nscursor =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(NSCursor, Selector.Alloc),
                    selInitWithImageHotSpot,
                    img,
                    new PointF(cursor.X, cursor.Y));

            Cocoa.SendVoid(imgdata, Selector.Release);
            Cocoa.SendVoid(img, Selector.Release);
            return nscursor;
        }

        private void ResetCursorRects(IntPtr sender, IntPtr cmd)
        {
            // We will add a new cursor rectangle that covers the complete view
            var rect = Cocoa.SendRect(windowInfo.ViewHandle, selBounds);

            // Inside this rectangle, the following NSCursor will be used
            var cursor = IntPtr.Zero;
            if (selectedCursor == MouseCursor.Default)
            {
                cursor = Cocoa.SendIntPtr(NSCursor, selArrowCursor);
            }
            else
            {
                cursor = ToNSCursor(selectedCursor);
            }

            // Setup the cursor rectangle
            if (cursor != IntPtr.Zero)
            {
                Cocoa.SendVoid(sender, selAddCursorRect, rect, cursor);
            }
        }

        private void InvalidateCursorRects()
        {
            Cocoa.SendVoid(windowInfo.Handle, selInvalidateCursorRectsForView, windowInfo.ViewHandle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            Debug.Print("Disposing of CocoaNativeWindow (disposing={0}).", disposing);

            if (!NSApplication.IsUIThread)
            {
                return;
            }

            NSApplication.Quit -= ApplicationQuit;

            if (disposing)
            {
                CursorVisible = true;
                if (exists)
                {
                    CloseWindow(true);
                }

                if (trackingArea != IntPtr.Zero)
                {
                    Cocoa.SendVoid(windowInfo.ViewHandle, selRemoveTrackingArea, trackingArea);
                    Cocoa.SendVoid(trackingArea, Selector.Release);
                    trackingArea = IntPtr.Zero;
                }

                Debug.Print("[Mac] Disposing {0}", windowInfo);
                windowInfo.Dispose();
            }
            else
            {
                Debug.Print("{0} leaked, did you forget to call Dispose()?", GetType().FullName);
            }

            disposed = true;
            OnDisposed(EventArgs.Empty);
        }

        public static IntPtr GetView(IntPtr windowHandle)
        {
            return Cocoa.SendIntPtr(windowHandle, selContentView);
        }

        private RectangleF GetContentViewFrame()
        {
            return Cocoa.SendRect(windowInfo.ViewHandle, selFrame);
        }

        private IntPtr GetCurrentScreen()
        {
            return Cocoa.SendIntPtr(windowInfo.Handle, selScreen);
        }

        private RectangleF GetCurrentScreenFrame()
        {
            return Cocoa.SendRect(GetCurrentScreen(), selFrame);
        }

        private RectangleF GetCurrentScreenVisibleFrame()
        {
            return Cocoa.SendRect(GetCurrentScreen(), selVisibleFrame);
        }

        private void SetCursorVisible(bool visible)
        {
            // If the mouse is outside the window and we want to hide it,
            // move it inside the window first.
            // Otherwise, if we are making the cursor visible again,
            // we place it in the same spot as reported in the current
            // MouseState to avoid sudden jumps.
            if (!visible && !Bounds.Contains(new Point(MouseState.X, MouseState.Y)))
            {
                Mouse.SetPosition(
                    (Bounds.Left + Bounds.Right) / 2,
                    (Bounds.Top + Bounds.Bottom) / 2);
            }
            else if (visible)
            {
                var p = PointToScreen(new Point(MouseState.X, MouseState.Y));
                Mouse.SetPosition(p.X, p.Y);
            }

            CG.AssociateMouseAndMouseCursorPosition(visible);
            Cocoa.SendVoid(NSCursor, visible ? selUnhide : selHide);
        }

        private void SetMenuVisible(bool visible)
        {
            var options =
                (NSApplicationPresentationOptions)Cocoa.SendInt(NSApplication.Handle, selPresentationOptions);
            var changedOptions =
                NSApplicationPresentationOptions.HideMenuBar | NSApplicationPresentationOptions.HideDock;

            if (!visible)
            {
                options |= changedOptions;
            }
            else
            {
                options &= ~changedOptions;
            }

            Cocoa.SendVoid(NSApplication.Handle, selSetPresentationOptions, (int)options);
        }

        private void SetTitle(string newTitle, bool callEvent)
        {
            title = newTitle ?? "";

            Cocoa.SendIntPtr(windowInfo.Handle, selSetTitle, Cocoa.ToNSString(title));
            if (callEvent)
            {
                OnTitleChanged(EventArgs.Empty);
            }
        }

        private void UpdateWindowBorder()
        {
            Cocoa.SendVoid(windowInfo.Handle, selSetStyleMask, (uint)GetStyleMask(windowBorder));
            SetTitle(title, false); // Title gets lost after going borderless
        }

        private NSWindowStyle GetStyleMask()
        {
            return (NSWindowStyle)Cocoa.SendUint(windowInfo.Handle, selStyleMask);
        }

        private void CloseWindow(bool shutdown)
        {
            if (!Exists)
            {
                return;
            }

            exists = false;

            // PerformClose is equivalent to pressing the close-button, which
            // does not work in a borderless window. Handle this special case.
            if (GetStyleMask() == NSWindowStyle.Borderless || shutdown)
            {
                if (WindowShouldClose(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
                {
                    Cocoa.SendVoid(windowInfo.Handle, selClose);
                }
            }
            else
            {
                Cocoa.SendVoid(windowInfo.Handle, selPerformClose, windowInfo.Handle);
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowKeyDownDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidResizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidMoveDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidBecomeKeyDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidResignKeyDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowWillMiniaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidMiniaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void WindowDidDeminiaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool WindowShouldZoomToFrameDelegate(IntPtr self, IntPtr cmd, IntPtr nsWindow,
            RectangleF toFrame);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool WindowShouldCloseDelegate(IntPtr self, IntPtr cmd, IntPtr sender);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool AcceptsFirstResponderDelegate(IntPtr self, IntPtr cmd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool CanBecomeKeyWindowDelegate(IntPtr self, IntPtr cmd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool CanBecomeMainWindowDelegate(IntPtr self, IntPtr cmd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate void ResetCursorRectsDelegate(IntPtr self, IntPtr cmd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate IntPtr DraggingEnteredDelegate(IntPtr self, IntPtr cmd, IntPtr sender);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate bool PerformDragOperationDelegate(IntPtr self, IntPtr cmd, IntPtr sender);
    }
}