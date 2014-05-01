﻿#region License
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
#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
    class CocoaNativeWindow : INativeWindow
    {
        static int UniqueId;

        public event EventHandler<EventArgs> Move = delegate { };
        public event EventHandler<EventArgs> Resize = delegate { };
        public event EventHandler<System.ComponentModel.CancelEventArgs> Closing = delegate { };
        public event EventHandler<EventArgs> Closed = delegate { };
        public event EventHandler<EventArgs> Disposed = delegate { };
        public event EventHandler<EventArgs> IconChanged = delegate { };
        public event EventHandler<EventArgs> TitleChanged = delegate { };
        public event EventHandler<EventArgs> VisibleChanged = delegate { };
        public event EventHandler<EventArgs> FocusedChanged = delegate { };
        public event EventHandler<EventArgs> WindowBorderChanged = delegate { };
        public event EventHandler<EventArgs> WindowStateChanged = delegate { };
        public event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyDown = delegate { };
        public event EventHandler<KeyPressEventArgs> KeyPress = delegate { };
        public event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyUp = delegate { };
        public event EventHandler<EventArgs> MouseLeave = delegate { };
        public event EventHandler<EventArgs> MouseEnter = delegate { };

        static readonly IntPtr selNextEventMatchingMask = Selector.Get("nextEventMatchingMask:untilDate:inMode:dequeue:");
        static readonly IntPtr selSendEvent = Selector.Get("sendEvent:");
        //static readonly IntPtr selUpdateWindows = Selector.Get("updateWindows");
        static readonly IntPtr selConvertRectFromScreen = Selector.Get("convertRectFromScreen:");
        static readonly IntPtr selConvertRectToScreen = Selector.Get("convertRectToScreen:");
        static readonly IntPtr selPerformClose = Selector.Get("performClose:");
        static readonly IntPtr selClose = Selector.Get("close");
        static readonly IntPtr selTitle = Selector.Get("title");
        static readonly IntPtr selSetTitle = Selector.Get("setTitle:");
        static readonly IntPtr selSetApplicationIconImage = Selector.Get("setApplicationIconImage:");
        static readonly IntPtr selIsKeyWindow = Selector.Get("isKeyWindow");
        static readonly IntPtr selIsVisible = Selector.Get("isVisible");
        static readonly IntPtr selSetIsVisible = Selector.Get("setIsVisible:");
        static readonly IntPtr selFrame = Selector.Get("frame");
        static readonly IntPtr selVisibleFrame = Selector.Get("visibleFrame");
        static readonly IntPtr selBounds = Selector.Get("bounds");
        static readonly IntPtr selScreen = Selector.Get("screen");
        static readonly IntPtr selSetFrame = Selector.Get("setFrame:display:");
        static readonly IntPtr selConvertRectToBacking = Selector.Get("convertRectToBacking:");
        static readonly IntPtr selConvertRectFromBacking = Selector.Get("convertRectFromBacking:");
        static readonly IntPtr selFrameRectForContentRect = Selector.Get("frameRectForContentRect:");
        static readonly IntPtr selType = Selector.Get("type");
        static readonly IntPtr selKeyCode = Selector.Get("keyCode");
        static readonly IntPtr selModifierFlags = Selector.Get("modifierFlags");
        static readonly IntPtr selIsARepeat = Selector.Get("isARepeat");
        static readonly IntPtr selCharactersIgnoringModifiers = Selector.Get("charactersIgnoringModifiers");
        static readonly IntPtr selAddTrackingArea = Selector.Get("addTrackingArea:");
        static readonly IntPtr selRemoveTrackingArea = Selector.Get("removeTrackingArea:");
        static readonly IntPtr selTrackingArea = Selector.Get("trackingArea");
        static readonly IntPtr selInitWithSize = Selector.Get("initWithSize:");
        static readonly IntPtr selInitWithRect = Selector.Get("initWithRect:options:owner:userInfo:");
        static readonly IntPtr selOwner = Selector.Get("owner");
        static readonly IntPtr selLocationInWindowOwner = Selector.Get("locationInWindow");
        static readonly IntPtr selHide = Selector.Get("hide");
        static readonly IntPtr selUnhide = Selector.Get("unhide");
        static readonly IntPtr selScrollingDeltaY = Selector.Get("scrollingDeltaY");
        static readonly IntPtr selButtonNumber = Selector.Get("buttonNumber");
        static readonly IntPtr selSetStyleMask = Selector.Get("setStyleMask:");
        static readonly IntPtr selStyleMask = Selector.Get("styleMask");
        static readonly IntPtr selHasPreciseScrollingDeltas = Selector.Get("hasPreciseScrollingDeltas");
        //static readonly IntPtr selIsMiniaturized = Selector.Get("isMiniaturized");
        //static readonly IntPtr selIsZoomed = Selector.Get("isZoomed");
        //static readonly IntPtr selPerformMiniaturize = Selector.Get("performMiniaturize:");
        static readonly IntPtr selMiniaturize = Selector.Get("miniaturize:");
        static readonly IntPtr selDeminiaturize = Selector.Get("deminiaturize:");
        //static readonly IntPtr selPerformZoom = Selector.Get("performZoom:");
        //static readonly IntPtr selZoom = Selector.Get("zoom:");
        static readonly IntPtr selLevel = Selector.Get("level");
        static readonly IntPtr selSetLevel = Selector.Get("setLevel:");
        static readonly IntPtr selPresentationOptions = Selector.Get("presentationOptions");
        static readonly IntPtr selSetPresentationOptions = Selector.Get("setPresentationOptions:");
        //static readonly IntPtr selIsInFullScreenMode = Selector.Get("isInFullScreenMode");
        //static readonly IntPtr selExitFullScreenModeWithOptions = Selector.Get("exitFullScreenModeWithOptions:");
        //static readonly IntPtr selEnterFullScreenModeWithOptions = Selector.Get("enterFullScreenMode:withOptions:");
        static readonly IntPtr selArrowCursor = Selector.Get("arrowCursor");
        static readonly IntPtr selAddCursorRect = Selector.Get("addCursorRect:cursor:");
        static readonly IntPtr selInvalidateCursorRectsForView = Selector.Get("invalidateCursorRectsForView:");
        static readonly IntPtr selInitWithBitmapDataPlanes =
            Selector.Get("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
        static readonly IntPtr selBitmapData = Selector.Get("bitmapData");
        static readonly IntPtr selAddRepresentation = Selector.Get("addRepresentation:");
        static readonly IntPtr selInitWithImageHotSpot = Selector.Get("initWithImage:hotSpot:");

        static readonly IntPtr NSDefaultRunLoopMode;
        static readonly IntPtr NSCursor;
        static readonly IntPtr NSImage;
        static readonly IntPtr NSBitmapImageRep;
        static readonly IntPtr NSDeviceRGBColorSpace = Cocoa.ToNSString("NSDeviceRGBColorSpace");

        static CocoaNativeWindow()
        {
            Cocoa.Initialize();
            NSApplication.Initialize(); // Problem: This does not allow creating a separate app and using CocoaNativeWindow.
            NSDefaultRunLoopMode = Cocoa.GetStringConstant(Cocoa.FoundationLibrary, "NSDefaultRunLoopMode");
            NSCursor = Class.Get("NSCursor");
            NSImage = Class.Get("NSImage");
            NSBitmapImageRep = Class.Get("NSBitmapImageRep");
        }

        private CocoaWindowInfo windowInfo;
        private IntPtr windowClass;
        private IntPtr trackingArea;
        private bool disposed = false;
        private bool exists;
        private bool cursorVisible = true;
        private System.Drawing.Icon icon;
        private LegacyInputDriver inputDriver = new LegacyInputDriver();
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private Nullable<WindowBorder> deferredWindowBorder;
        private Nullable<WindowBorder> previousWindowBorder;
        private WindowState windowState = WindowState.Normal;
        private OpenTK.Input.KeyboardKeyEventArgs keyArgs = new OpenTK.Input.KeyboardKeyEventArgs();
        private KeyPressEventArgs keyPressArgs = new KeyPressEventArgs((char)0);
        private string title;
        private RectangleF previousBounds;
        private int normalLevel;
        private bool shouldClose;
        private int suppressResize;
        private bool cursorInsideWindow = true;
        private MouseCursor selectedCursor = MouseCursor.Default; // user-selected cursor

        private const float scrollFactor = 120.0f;
        private const bool exclusiveFullscreen = false;

        public CocoaNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            // Create the window class
            Interlocked.Increment(ref UniqueId);
            windowClass = Class.AllocateClass("OpenTK_GameWindow" + UniqueId, "NSWindow");
            Class.RegisterMethod(windowClass, new WindowKeyDownDelegate(WindowKeyDown), "keyDown:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidResizeDelegate(WindowDidResize), "windowDidResize:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidMoveDelegate(WindowDidMove), "windowDidMove:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidBecomeKeyDelegate(WindowDidBecomeKey), "windowDidBecomeKey:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidResignKeyDelegate(WindowDidResignKey), "windowDidResignKey:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowWillMiniaturizeDelegate(WindowWillMiniaturize), "windowWillMiniaturize:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidMiniaturizeDelegate(WindowDidMiniaturize), "windowDidMiniaturize:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowDidDeminiaturizeDelegate(WindowDidDeminiaturize), "windowDidDeminiaturize:", "v@:@");
            Class.RegisterMethod(windowClass, new WindowShouldZoomToFrameDelegate(WindowShouldZoomToFrame), "windowShouldZoom:toFrame:", "b@:@{NSRect={NSPoint=ff}{NSSize=ff}}");
            Class.RegisterMethod(windowClass, new WindowShouldCloseDelegate(WindowShouldClose), "windowShouldClose:", "b@:@");
            Class.RegisterMethod(windowClass, new AcceptsFirstResponderDelegate(AcceptsFirstResponder), "acceptsFirstResponder", "b@:");
            Class.RegisterMethod(windowClass, new CanBecomeKeyWindowDelegate(CanBecomeKeyWindow), "canBecomeKeyWindow", "b@:");
            Class.RegisterMethod(windowClass, new CanBecomeMainWindowDelegate(CanBecomeMainWindow), "canBecomeMainWindow", "b@:");
            Class.RegisterClass(windowClass);

            IntPtr viewClass = Class.AllocateClass("OpenTK_NSView" + UniqueId, "NSView");
            Class.RegisterMethod(viewClass, new ResetCursorRectsDelegate(ResetCursorRects), "resetCursorRects", "v@:");
            Class.RegisterClass(viewClass);

            // Create window instance
            var contentRect = new System.Drawing.RectangleF(x, y, width, height);
            var style = GetStyleMask(windowBorder);
            var bufferingType = NSBackingStore.Buffered;

            IntPtr windowPtr;
            windowPtr = Cocoa.SendIntPtr(windowClass, Selector.Alloc);
            windowPtr = Cocoa.SendIntPtr(windowPtr, Selector.Get("initWithContentRect:styleMask:backing:defer:"), contentRect, (int)style, (int)bufferingType, false);

            // Replace view with our custom implementation
            // that overrides resetCursorRects (maybe there is
            // a better way to implement this override?)
            // Existing view:
            IntPtr viewPtr = Cocoa.SendIntPtr(windowPtr, Selector.Get("contentView"));
            // Our custom view with the same bounds:
            viewPtr = Cocoa.SendIntPtr(
                Cocoa.SendIntPtr(viewClass, Selector.Alloc),
                Selector.Get("initWithFrame:"),
                Cocoa.SendRect(viewPtr, selBounds));
            if (viewPtr != IntPtr.Zero)
            {
                Cocoa.SendVoid(windowPtr, Selector.Get("setContentView:"), viewPtr);
            }

            windowInfo = new CocoaWindowInfo(windowPtr);

            // Set up behavior
            Cocoa.SendIntPtr(windowPtr, Selector.Get("setDelegate:"), windowPtr); // The window class acts as its own delegate 
            Cocoa.SendVoid(windowPtr, Selector.Get("cascadeTopLeftFromPoint:"), System.Drawing.PointF.Empty);
            Cocoa.SendVoid(windowPtr, Selector.Get("makeKeyWindow"));
            SetTitle(title, false);

            ResetTrackingArea();

            exists = true;
            NSApplication.Quit += ApplicationQuit;
        }

        delegate void WindowKeyDownDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidResizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidMoveDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidBecomeKeyDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidResignKeyDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowWillMiniaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidMiniaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate void WindowDidDeminiaturizeDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        delegate bool WindowShouldZoomToFrameDelegate(IntPtr self, IntPtr cmd, IntPtr nsWindow, RectangleF toFrame);
        delegate bool WindowShouldCloseDelegate(IntPtr self, IntPtr cmd, IntPtr sender);
        delegate bool AcceptsFirstResponderDelegate(IntPtr self, IntPtr cmd);
        delegate bool CanBecomeKeyWindowDelegate(IntPtr self, IntPtr cmd);
        delegate bool CanBecomeMainWindowDelegate(IntPtr self, IntPtr cmd);
        delegate void ResetCursorRectsDelegate(IntPtr self, IntPtr cmd);

        private void WindowKeyDown(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            // Steal the event to remove the "beep" sound that is normally played for unhandled key events.
        }

        private void WindowDidResize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            OnResize(true);
        }

        private void OnResize(bool resetTracking)
        {
            if (resetTracking)
            {
                ResetTrackingArea();
            }
            GraphicsContext.CurrentContext.Update(windowInfo);

            if (suppressResize == 0)
                Resize(this, EventArgs.Empty);
        }

        private void ApplicationQuit(object sender, CancelEventArgs e)
        {
            bool close = WindowShouldClose(windowInfo.Handle, IntPtr.Zero, IntPtr.Zero);
            e.Cancel |= !close;
        }

        private void WindowDidMove(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            // Problem: Called only when you stop moving for a brief moment,
            // not each frame as it is on PC.
            Move(this, EventArgs.Empty);
        }

        private void WindowDidBecomeKey(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            FocusedChanged(this, EventArgs.Empty);
        }

        private void WindowDidResignKey(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            FocusedChanged(this, EventArgs.Empty);
        }

        private void WindowWillMiniaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            // Can get stuck in weird states if we maximize, then minimize; 
            // restoring to the old state would override the normalBounds.
            // To avoid this without adding complexity, just restore state here.
            RestoreWindowState(); // Avoid getting in weird states
        }

        private void WindowDidMiniaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            windowState = WindowState.Minimized;
            WindowStateChanged(this, EventArgs.Empty);
            OnResize(false); // Don't set tracking area when we minimize
        }

        private void WindowDidDeminiaturize(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            windowState = WindowState.Normal;
            WindowStateChanged(this, EventArgs.Empty);
            OnResize(true);
        }

        private bool WindowShouldZoomToFrame(IntPtr self, IntPtr cmd, IntPtr nsWindow, RectangleF toFrame)
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

                WindowStateChanged(this, EventArgs.Empty);
            }
            return false;
        }

        private bool WindowShouldClose(IntPtr self, IntPtr cmd, IntPtr sender)
        {
            var cancelArgs = new CancelEventArgs();
            Closing(this, cancelArgs);

            if (!cancelArgs.Cancel)
            {
                Closed(this, EventArgs.Empty);
                return true;
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

        public void Close()
        {
            shouldClose = true;
        }

        private KeyModifiers GetModifiers(NSEventModifierMask mask)
        {
            OpenTK.Input.KeyModifiers modifiers = 0;
            if ((mask & NSEventModifierMask.ControlKeyMask) != 0) modifiers |= OpenTK.Input.KeyModifiers.Control;
            if ((mask & NSEventModifierMask.ShiftKeyMask) != 0) modifiers |= OpenTK.Input.KeyModifiers.Shift;
            if ((mask & NSEventModifierMask.AlternateKeyMask) != 0) modifiers |= OpenTK.Input.KeyModifiers.Alt;
            return modifiers;
        }

        private void GetKey(ushort keyCode, NSEventModifierMask modifierFlags, OpenTK.Input.KeyboardKeyEventArgs args)
        {
            args.Key = MacOSKeyMap.GetKey((Carbon.MacOSKeyCode)keyCode);
            args.Modifiers = GetModifiers(modifierFlags);
            args.ScanCode = (uint)keyCode;
        }

        private MouseButton GetMouseButton(int cocoaButtonIndex)
        {
            if (cocoaButtonIndex == 0) return MouseButton.Left;
            if (cocoaButtonIndex == 1) return MouseButton.Right;
            if (cocoaButtonIndex == 2) return MouseButton.Middle;
            if (cocoaButtonIndex >= (int)MouseButton.LastButton)
                return MouseButton.LastButton;

            return (MouseButton)cocoaButtonIndex;
        }

        public void ProcessEvents()
        {
            while (true)
            {
                var e = Cocoa.SendIntPtr(NSApplication.Handle, selNextEventMatchingMask, uint.MaxValue, IntPtr.Zero, NSDefaultRunLoopMode, true);

                if (e == IntPtr.Zero)
                    break;

                var type = (NSEventType)Cocoa.SendInt(e, selType);
                switch (type)
                {
                    case NSEventType.KeyDown:
                        {
                            var keyCode = Cocoa.SendUshort(e, selKeyCode);
                            var modifierFlags = (NSEventModifierMask)Cocoa.SendUint(e, selModifierFlags);
                            var isARepeat = Cocoa.SendBool(e, selIsARepeat);
                            GetKey(keyCode, modifierFlags, keyArgs);
                            InputDriver.Keyboard[0].SetKey(keyArgs.Key, keyArgs.ScanCode, true);

                            if (!isARepeat || InputDriver.Keyboard[0].KeyRepeat)
                            {
                                KeyDown(this, keyArgs);
                            }

                            var s = Cocoa.FromNSString(Cocoa.SendIntPtr(e, selCharactersIgnoringModifiers));
                            foreach (var c in s)
                            {
                                int intVal = (int)c;
                                if (!Char.IsControl(c) && (intVal < 63232 || intVal > 63235))
                                {
                                    // For some reason, arrow keys (mapped 63232-63235) are seen as non-control characters, so get rid of those.

                                    keyPressArgs.KeyChar = c;
                                    KeyPress(this, keyPressArgs);
                                }
                            }
                        }
                        break;

                    case NSEventType.KeyUp:
                        {
                            var keyCode = Cocoa.SendUshort(e, selKeyCode);
                            var modifierFlags = (NSEventModifierMask)Cocoa.SendUint(e, selModifierFlags);

                            GetKey(keyCode, modifierFlags, keyArgs);
                            InputDriver.Keyboard[0].SetKey(keyArgs.Key, keyArgs.ScanCode, false);

                            KeyUp(this, keyArgs);
                        }
                        break;

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

                                cursorInsideWindow = true;
                                MouseEnter(this, EventArgs.Empty);
                            }
                        }
                        break;

                    case NSEventType.MouseExited:
                        {
                            var eventTrackingArea = Cocoa.SendIntPtr(e, selTrackingArea);
                            var trackingAreaOwner = Cocoa.SendIntPtr(eventTrackingArea, selOwner);
                            if (trackingAreaOwner == windowInfo.ViewHandle)
                            {
                                if (selectedCursor != MouseCursor.Default)
                                {
                                    SetCursor(MouseCursor.Default);
                                }

                                cursorInsideWindow = false;
                                MouseLeave(this, EventArgs.Empty);
                            }
                        }
                        break;

                    case NSEventType.LeftMouseDragged:
                    case NSEventType.RightMouseDragged:
                    case NSEventType.OtherMouseDragged:
                    case NSEventType.MouseMoved:
                        {
                            var pf = Cocoa.SendPoint(e, selLocationInWindowOwner);

                            // Convert from points to pixel coordinates
                            var rf = Cocoa.SendRect(windowInfo.Handle, selConvertRectToBacking,
                                new RectangleF(pf.X, pf.Y, 0, 0));

                            // See CocoaDrawingGuide under "Converting from Window to View Coordinates"
                            var p = new Point(
                                MathHelper.Clamp((int)Math.Round(rf.X), 0, Width),
                                MathHelper.Clamp((int)Math.Round(Height - rf.Y), 0, Height));

                            InputDriver.Mouse[0].Position = p;
                        }
                        break;

                    case NSEventType.CursorUpdate:
                        break;

                    case NSEventType.ScrollWheel:
                        {
                            var scrollingDelta = Cocoa.SendFloat(e, selScrollingDeltaY);
                            var factor = 1.0f;

                            if (Cocoa.SendBool(e, selHasPreciseScrollingDeltas))
                            {
                                factor = 1.0f / scrollFactor; // Problem: Don't know what factor to use here, but this seems to work.
                            }

                            InputDriver.Mouse[0].WheelPrecise += scrollingDelta * factor;
                        }
                        break;

                    case NSEventType.LeftMouseDown:
                    case NSEventType.RightMouseDown:
                    case NSEventType.OtherMouseDown:
                        {
                            var buttonNumber = Cocoa.SendInt(e, selButtonNumber);
                            InputDriver.Mouse[0][GetMouseButton(buttonNumber)] = true;
                        }
                        break;

                    case NSEventType.LeftMouseUp:
                    case NSEventType.RightMouseUp:
                    case NSEventType.OtherMouseUp:
                        {
                            var buttonNumber = Cocoa.SendInt(e, selButtonNumber);
                            InputDriver.Mouse[0][GetMouseButton(buttonNumber)] = false;
                        }
                        break;
                }

                Cocoa.SendVoid(NSApplication.Handle, selSendEvent, e);
            }

            // Handle closing
            if (shouldClose)
            {
                shouldClose = false;

                // PerformClose is equivalent to pressing the close-button, which
                // does not work in a borderless window. Handle this special case.
                if (GetStyleMask() == NSWindowStyle.Borderless)
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
        }

        public System.Drawing.Point PointToClient(System.Drawing.Point point)
        {
            var r = Cocoa.SendRect(windowInfo.Handle, selConvertRectFromScreen, new RectangleF(point.X, point.Y, 0, 0));
            return new Point((int)r.X, (int)(GetContentViewFrame().Height - GetCurrentScreenFrame().Height - r.Y));
        }

        public System.Drawing.Point PointToScreen(System.Drawing.Point point)
        {
            var r = Cocoa.SendRect(windowInfo.Handle, selConvertRectToScreen, new RectangleF(point.X, point.Y, 0, 0));
            return new Point((int)r.X, (int)(-GetContentViewFrame().Height + GetCurrentScreenFrame().Height - r.Y));
        }

        public System.Drawing.Icon Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                using (Image img = icon.ToBitmap())
                {
                    IntPtr nsimg = Cocoa.ToNSImage(img);
                    Cocoa.SendVoid(NSApplication.Handle, selSetApplicationIconImage, nsimg);
                }
                IconChanged(this, EventArgs.Empty);
            }
        }

        public string Title
        {
            get
            {
                return Cocoa.FromNSString(Cocoa.SendIntPtr(windowInfo.Handle, selTitle));
            }
            set
            {
                SetTitle(value, true);
            }
        }

        public bool Focused
        {
            get
            {
                return Cocoa.SendBool(windowInfo.Handle, selIsKeyWindow);
            }
        }

        public bool Visible
        {
            get
            {
                return Cocoa.SendBool(windowInfo.Handle, selIsVisible);
            }
            set
            {
                Cocoa.SendVoid(windowInfo.Handle, selSetIsVisible, value);
                VisibleChanged(this, EventArgs.Empty);
            }
        }

        public bool Exists
        {
            get
            {
                return exists;
            }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return windowInfo;
            }
        }

        private void RestoreWindowState()
        {
            suppressResize++;
            if (windowState == WindowState.Fullscreen)
            {
                SetMenuVisible(true);
                if (exclusiveFullscreen)
                {
                    OpenTK.Platform.MacOS.Carbon.CG.DisplayReleaseAll();
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

        public WindowState WindowState
        {
            get
            {
                return windowState;
            }
            set
            {
                var oldState = windowState;
                if (oldState == value)
                    return;

                RestoreWindowState();

                if (value == WindowState.Fullscreen)
                {
                    if (exclusiveFullscreen)
                    {
                        normalLevel = Cocoa.SendInt(windowInfo.Handle, selLevel);
                        var windowLevel = OpenTK.Platform.MacOS.Carbon.CG.ShieldingWindowLevel();

                        OpenTK.Platform.MacOS.Carbon.CG.CaptureAllDisplays();
                        Cocoa.SendVoid(windowInfo.Handle, selSetLevel, windowLevel);
                    }

                    previousBounds = InternalBounds;
                    previousWindowBorder = WindowBorder;

                    SetMenuVisible(false);
                    HideBorder();
                    InternalBounds = GetCurrentScreenFrame();

                    windowState = value;
                    WindowStateChanged(this, EventArgs.Empty);
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
                    WindowStateChanged(this, EventArgs.Empty);
                    Resize(this, EventArgs.Empty);
                }
            }
        }

        public WindowBorder WindowBorder
        {
            get 
            { 
                return windowBorder;
            }
            set
            {
                // Do not allow border changes during fullscreen mode.
                if (windowState == WindowState.Fullscreen || windowState == WindowState.Maximized)
                {
                    deferredWindowBorder = value;
                    return;
                }

                if (windowBorder == value)
                    return;

                SetWindowBorder(value);
                WindowBorderChanged(this, EventArgs.Empty);
            }
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
                case WindowBorder.Resizable: return NSWindowStyle.Closable | NSWindowStyle.Miniaturizable | NSWindowStyle.Titled | NSWindowStyle.Resizable;
                case WindowBorder.Fixed: return NSWindowStyle.Closable | NSWindowStyle.Miniaturizable | NSWindowStyle.Titled;
                case WindowBorder.Hidden: return NSWindowStyle.Borderless;
            }

            return (NSWindowStyle)0;
        }

        public System.Drawing.Rectangle Bounds
        {
            get
            {
                var r = Cocoa.SendRect(windowInfo.Handle, selFrame);
                return new Rectangle((int)r.X, (int)(GetCurrentScreenFrame().Height - r.Y), (int)r.Width, (int)r.Height);
            }
            set
            {
                Cocoa.SendVoid(windowInfo.Handle, selSetFrame, new RectangleF(value.X, GetCurrentScreenFrame().Height - value.Y, value.Width, value.Height), true);
            }
        }

        private System.Drawing.RectangleF InternalBounds
        {
            get
            {
                return Cocoa.SendRect(windowInfo.Handle, selFrame);
            }
            set
            {
                Cocoa.SendVoid(windowInfo.Handle, selSetFrame, value, true);
            }
        }

        public System.Drawing.Point Location
        {
            get 
            { 
                return Bounds.Location;
            }
            set
            {
                var b = Bounds;
                b.Location = value;
                Bounds = b;
            }
        }

        public System.Drawing.Size Size
        {
            get 
            { 
                return Bounds.Size;
            }
            set
            {
                var b = Bounds;
                b.Y -= Bounds.Height;
                b.Y += value.Height;
                b.Size = value;
                Bounds = b;
            }
        }

        public int X
        {
            get 
            {
                return Bounds.X;
            }
            set
            {
                var b = Bounds;
                b.X = value;
                Bounds = b;
            }
        }

        public int Y
        {
            get
            {
                return Bounds.Y;
            }
            set
            {
                var b = Bounds;
                b.Y = value;
                Bounds = b;
            }
        }

        public int Width
        {
            get { return ClientRectangle.Width; }
            set
            {
                var s = ClientSize;
                s.Width = value;
                ClientSize = s;
            }
        }

        public int Height
        {
            get { return ClientRectangle.Height; }
            set
            {
                var s = ClientSize;
                s.Height = value;
                ClientSize = s;
            }
        }

        public System.Drawing.Rectangle ClientRectangle
        {
            get
            {
                var contentViewBounds = Cocoa.SendRect(windowInfo.ViewHandle, selBounds);
                var bounds = Cocoa.SendRect(windowInfo.Handle, selConvertRectToBacking, contentViewBounds);
                return new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height); 
            }
            set 
            {
                ClientSize = value.Size; // Just set size, to be consistent with WinGLNative.
            }
        }

        public System.Drawing.Size ClientSize
        {
            get 
            {
                return ClientRectangle.Size;
            }
            set
            {
                var r_scaled = Cocoa.SendRect(windowInfo.Handle, selConvertRectFromBacking, new RectangleF(PointF.Empty, value));
                var r = Cocoa.SendRect(windowInfo.Handle, selFrameRectForContentRect, r_scaled);
                Size = new Size((int)r.Width, (int)r.Height);
            }
        }

        public OpenTK.Input.IInputDriver InputDriver
        {
            get
            {
                return inputDriver;
            }
        }

        public MouseCursor Cursor
        {
            get
            {
                return selectedCursor;
            }
            set
            {
                selectedCursor = value;
                InvalidateCursorRects();
            }
        }

        static IntPtr ToNSCursor(MouseCursor cursor)
        {
            // We need to allocate a NSBitmapImageRep, fill it with pixels
            // and then convert it to a NSImage.
            // According to the documentation, alpha-enabled formats should
            // premultiply alpha, even though that "generally has negligible
            // effect on output quality."
            IntPtr imgdata =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(
                        Cocoa.SendIntPtr(NSBitmapImageRep, Selector.Alloc),
                        selInitWithBitmapDataPlanes,
                        IntPtr.Zero,
                        cursor.Width,
                        cursor.Height,
                        8,
                        4,
                        1,
                        0,
                        NSDeviceRGBColorSpace,
                        NSBitmapFormat.AlphaFirst,
                        4 * cursor.Width,
                        32),
                    Selector.Autorelease);
            if (imgdata == IntPtr.Zero)
            {
                Debug.Print("Failed to create NSBitmapImageRep with size ({0},{1]})",
                    cursor.Width, cursor.Height);
                return IntPtr.Zero;
            }

            // Copy the cursor data
            int i = 0;
            IntPtr data = Cocoa.SendIntPtr(imgdata, selBitmapData);
            for (int y = 0; y < cursor.Height; y++)
            {
                for (int x = 0; x < cursor.Width; x++)
                {
                    uint argb = unchecked((uint)BitConverter.ToInt32(cursor.Data, i));
                    if (BitConverter.IsLittleEndian)
                    {
                        argb =
                            (argb & 0x000000FFu) << 24 |
                            (argb & 0x0000FF00u) << 8 |
                            (argb & 0x00FF0000u) >> 8 |
                            (argb & 0xFF000000u) >> 24;
                    }
                    Marshal.WriteInt32(data, i, unchecked((int)argb));
                    i += 4;
                }
            }

            // Construct the actual NSImage
            IntPtr img = 
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(
                        Cocoa.SendIntPtr(NSImage, Selector.Alloc),
                        selInitWithSize,
                        new SizeF(cursor.Width, cursor.Height)),
                    Selector.Autorelease);
            if (img == IntPtr.Zero)
            {
                Debug.Print("Failed to construct NSImage from NSBitmapImageRep");
                return IntPtr.Zero;
            }
            Cocoa.SendVoid(img, selAddRepresentation, imgdata);

            // Convert the NSImage to a NSCursor
            IntPtr nscursor =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(
                        Cocoa.SendIntPtr(NSCursor, Selector.Alloc),
                        selInitWithImageHotSpot,
                        img,
                        new PointF(cursor.X, cursor.Y)
                    ),
                    Selector.Autorelease);

            return nscursor;
        }

        void ResetCursorRects(IntPtr sender, IntPtr cmd)
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

        void InvalidateCursorRects()
        {
            Cocoa.SendVoid(windowInfo.Handle, selInvalidateCursorRectsForView, windowInfo.ViewHandle);
        }

        public bool CursorVisible
        {
            get { return cursorVisible; }
            set
            {
                cursorVisible = value;
                if (value)
                {
                    SetCursorVisible(true);
                }
                else
                {
                    SetCursorVisible(false);
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            Debug.Print("Disposing of CocoaNativeWindow.");
            NSApplication.Quit -= ApplicationQuit;

            CursorVisible = true;
            disposed = true;
            exists = false;

            if (disposing)
            {
                if (trackingArea != IntPtr.Zero)
                {
                    Cocoa.SendVoid(windowInfo.ViewHandle, selRemoveTrackingArea, trackingArea);
                    Cocoa.SendVoid(trackingArea, Selector.Release);
                    trackingArea = IntPtr.Zero;
                }

                Cocoa.SendVoid(windowInfo.Handle, Selector.Release);
            }

            Disposed(this, EventArgs.Empty);
        }

        ~CocoaNativeWindow()
        {
            Dispose(false);
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
            Carbon.CG.AssociateMouseAndMouseCursorPosition(visible);
            Cocoa.SendVoid(NSCursor, visible ? selUnhide : selHide);
        }

        private void SetCursor(MouseCursor cursor)
        {
            if (cursor == MouseCursor.Default)
            {
                Cocoa.SendVoid(NSCursor, selUnhide);
            }
            else if (cursor == MouseCursor.Empty)
            {
                Cocoa.SendVoid(NSCursor, selHide);
            }
            else
            {
            }
        }

        private void SetMenuVisible(bool visible)
        {
            var options = (NSApplicationPresentationOptions)Cocoa.SendInt(NSApplication.Handle, selPresentationOptions);
            var changedOptions = NSApplicationPresentationOptions.HideMenuBar | NSApplicationPresentationOptions.HideDock;

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
                TitleChanged(this, EventArgs.Empty);
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
    }
}
