#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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

// Created by Erik Ylvisaker on 3/17/08.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
#if ANDROID || IPHONE || MINIMAL
    using Minimal;
    using Graphics = OpenTK.Minimal.Graphics;
#else
    using Graphics = System.Drawing.Graphics;
#endif

    class CarbonGLNative : INativeWindow
    {
        #region Fields

        CarbonWindowInfo window;
        CarbonInput mInputDriver;

        static MacOSKeyMap Keymap = new MacOSKeyMap();

        IntPtr uppHandler;

        string title = "OpenTK Window";
        Rectangle bounds, clientRectangle;
        Rectangle windowedBounds;
        bool mIsDisposed = false;
        bool mExists = true;
        DisplayDevice mDisplayDevice;

        WindowPositionMethod mPositionMethod = WindowPositionMethod.CenterOnMainScreen;
        int mTitlebarHeight;
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private WindowState windowState = WindowState.Normal;

        static Dictionary<IntPtr, WeakReference> mWindows =
            new Dictionary<IntPtr, WeakReference>(new IntPtrEqualityComparer());

        KeyPressEventArgs mKeyPressArgs = new KeyPressEventArgs((char)0);
        OpenTK.Input.KeyboardKeyEventArgs mKeyDownArgs = new OpenTK.Input.KeyboardKeyEventArgs();
        OpenTK.Input.KeyboardKeyEventArgs mKeyUpArgs = new OpenTK.Input.KeyboardKeyEventArgs();

        bool mMouseIn = false;
        bool mIsActive = false;

        Icon mIcon;

        // Used to accumulate mouse motion when the cursor is hidden.
        float mouse_rel_x;
        float mouse_rel_y;

        #endregion

        #region AGL Device Hack

        static internal Dictionary<IntPtr, WeakReference> WindowRefMap
        {
            get { return mWindows; }
        }
        internal DisplayDevice TargetDisplayDevice
        {
            get { return mDisplayDevice; }
        }

        #endregion

        #region Constructors

        static CarbonGLNative()
        {
            Application.Initialize();
        }

        public CarbonGLNative(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            CreateNativeWindow(WindowClass.Document,
                WindowAttributes.StandardDocument | WindowAttributes.StandardHandler |
                WindowAttributes.InWindowMenu | WindowAttributes.LiveResize,
                new Rect((short)x, (short)y, (short)width, (short)height));

            mDisplayDevice = device;
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (mIsDisposed)
                return;

            Debug.Print("Disposing of CarbonGLNative window.");

            CursorVisible = true;
            API.DisposeWindow(window.Handle);
            mIsDisposed = true;
            mExists = false;

            CG.SetLocalEventsSuppressionInterval(0.25);

            if (disposing)
            {
                mWindows.Remove(window.Handle);
                
                window.Dispose();
                window = null;
            }

            DisposeUPP();

            Disposed(this, EventArgs.Empty);
        }

        ~CarbonGLNative()
        {
            Dispose(false);
        }

        #endregion

        #region Private Members

        void DisposeUPP()
        {
            if (uppHandler != IntPtr.Zero)
            {
                API.RemoveEventHandler(uppHandler);
                API.DisposeEventHandlerUPP(uppHandler);
            }
            
            uppHandler = IntPtr.Zero;
        }

        void CreateNativeWindow(WindowClass @class, WindowAttributes attrib, Rect r)
        {
            Debug.Print("Creating window...");
            Debug.Indent();
            
            IntPtr windowRef = API.CreateNewWindow(@class, attrib, r);
            API.SetWindowTitle(windowRef, title);
            
            window = new CarbonWindowInfo(windowRef, true, false);
            
            SetLocation(r.X, r.Y);
            SetSize(r.Width, r.Height);
            
            Debug.Unindent();
            Debug.Print("Created window.");
            
            mWindows.Add(windowRef, new WeakReference(this));
            
            LoadSize();
            
            Rect titleSize = API.GetWindowBounds(window.Handle, WindowRegionCode.TitleBarRegion);
            mTitlebarHeight = titleSize.Height;
            
            Debug.Print("Titlebar size: {0}", titleSize);
            
            ConnectEvents();
            
            System.Diagnostics.Debug.WriteLine("Attached window events.");
        }

        void ConnectEvents()
        {
            mInputDriver = new CarbonInput();

            EventTypeSpec[] eventTypes = new EventTypeSpec[]
            {
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowClose),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowClosed),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowBoundsChanged),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowActivate),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowDeactivate),

                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDown),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseUp),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseMoved),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDragged),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseEntered),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseExited),
                //new EventTypeSpec(EventClass.Mouse, MouseEventKind.WheelMoved),

                //new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyDown),
                //new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyRepeat),
                //new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyUp),
                //new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyModifiersChanged),
            };
            
            MacOSEventHandler handler = EventHandler;
            uppHandler = API.NewEventHandlerUPP(handler);
            
            API.InstallWindowEventHandler(window.Handle, uppHandler, eventTypes,
                window.Handle, IntPtr.Zero);
            
            Application.WindowEventHandler = this;
        }

        void Activate()
        {
            API.SelectWindow(window.Handle);
        }

        void Show()
        {
            IntPtr parent = IntPtr.Zero;
            
            API.ShowWindow(window.Handle);
            API.RepositionWindow(window.Handle, parent, WindowPositionMethod);
            API.SelectWindow(window.Handle);
        }

        void Hide()
        {
            API.HideWindow(window.Handle);
        }

        internal void SetFullscreen(AglContext context)
        {
            windowedBounds = bounds;
            
            int width, height;
            
            context.SetFullScreen(window, out width, out height);
            
            Debug.Print("Prev Size: {0}, {1}", Width, Height);
            clientRectangle.Size = new Size(width, height);
            Debug.Print("New Size: {0}, {1}", Width, Height);
            
            // TODO: if we go full screen we need to make this use the device specified.
            bounds = mDisplayDevice.Bounds;
            
            
            windowState = WindowState.Fullscreen;
        }

        internal void UnsetFullscreen(AglContext context)
        {
            context.UnsetFullScreen(window);
            
            Debug.Print("Telling Carbon to reset window state to " + windowState.ToString());
            SetCarbonWindowState();
            
            SetSize((short)windowedBounds.Width, (short)windowedBounds.Height);
        }

        bool IsDisposed
        {
            get { return mIsDisposed; }
        }

        WindowPositionMethod WindowPositionMethod
        {
            get { return mPositionMethod; }
            set { mPositionMethod = value; }
        }

        internal OSStatus DispatchEvent(IntPtr inCaller, IntPtr inEvent, EventInfo evt, IntPtr userData)
        {
            switch (evt.EventClass)
            {
                case EventClass.Window:
                    return ProcessWindowEvent(inCaller, inEvent, evt, userData);

                case EventClass.Mouse:
                    return ProcessMouseEvent(inCaller, inEvent, evt, userData);

                case EventClass.Keyboard:
                    return ProcessKeyboardEvent(inCaller, inEvent, evt, userData);

                default:
                    return OSStatus.EventNotHandled;
            }
        }

        protected static OSStatus EventHandler(IntPtr inCaller, IntPtr inEvent, IntPtr userData)
        {
            if (mWindows.ContainsKey(userData) == false)
            {
                // Bail out if the window passed in is not actually our window.
                // I think this happens if using winforms with a GameWindow sometimes.
                return OSStatus.EventNotHandled;
            }

            WeakReference reference = mWindows[userData];
            if (reference.IsAlive == false)
            {
                // Bail out if the CarbonGLNative window has been garbage collected.
                mWindows.Remove(userData);
                return OSStatus.EventNotHandled;
            }

            CarbonGLNative window = (CarbonGLNative)reference.Target;
            if (window == null)
            {
                Debug.WriteLine("Window for event not found.");
                return OSStatus.EventNotHandled;
            }

            EventInfo evt = new EventInfo(inEvent);
            return window.DispatchEvent(inCaller, inEvent, evt, userData);
        }

        private OSStatus ProcessKeyboardEvent(IntPtr inCaller, IntPtr inEvent, EventInfo evt, IntPtr userData)
        {
            System.Diagnostics.Debug.Assert(evt.EventClass == EventClass.Keyboard);
            MacOSKeyCode code = (MacOSKeyCode)0;
            char charCode = '\0';

            switch (evt.KeyboardEventKind)
            {
                case KeyboardEventKind.RawKeyDown:
                case KeyboardEventKind.RawKeyRepeat:
                case KeyboardEventKind.RawKeyUp:
                    GetCharCodes(inEvent, out code, out charCode);
                    mKeyPressArgs.KeyChar = charCode;
                    break;
            }

            Key key;
            switch (evt.KeyboardEventKind)
            {
                case KeyboardEventKind.RawKeyRepeat:
                    if (InputDriver.Keyboard[0].KeyRepeat)
                        goto case KeyboardEventKind.RawKeyDown;
                    break;

                case KeyboardEventKind.RawKeyDown:
                    ProcessKeyDown(code);
                    return OSStatus.NoError;

                case KeyboardEventKind.RawKeyUp:
                    ProcessKeyUp(code);
                    return OSStatus.NoError;

                case KeyboardEventKind.RawKeyModifiersChanged:
                    ProcessModifierKey(inEvent);
                    return OSStatus.NoError;
            }

            return OSStatus.EventNotHandled;
        }

        private OSStatus ProcessWindowEvent(IntPtr inCaller, IntPtr inEvent, EventInfo evt, IntPtr userData)
        {
            System.Diagnostics.Debug.Assert(evt.EventClass == EventClass.Window);
            
            switch (evt.WindowEventKind)
            {
            case WindowEventKind.WindowClose:
                CancelEventArgs cancel = new CancelEventArgs();
                OnClosing(cancel);
                
                if (cancel.Cancel)
                    return OSStatus.NoError;
                else
                    return OSStatus.EventNotHandled;
            
            case WindowEventKind.WindowClosed:
                mExists = false;
                OnClosed();
                
                return OSStatus.NoError;
            
            case WindowEventKind.WindowBoundsChanged:
                int thisWidth = Width;
                int thisHeight = Height;
                int thisX = X;
                int thisY = Y;
                
                LoadSize();
                
                if (thisX != X || thisY != Y)
                    Move(this, EventArgs.Empty);
                
                if (thisWidth != Width || thisHeight != Height)
                    Resize(this, EventArgs.Empty);
                
                return OSStatus.EventNotHandled;
            
            case WindowEventKind.WindowActivate:
                OnActivate();
                return OSStatus.EventNotHandled;
            
            case WindowEventKind.WindowDeactivate:
                OnDeactivate();
                return OSStatus.EventNotHandled;
            default:
                
                Debug.Print("{0}", evt);
                
                return OSStatus.EventNotHandled;
            }
        }

        protected OSStatus ProcessMouseEvent(IntPtr inCaller, IntPtr inEvent, EventInfo evt, IntPtr userData)
        {
            System.Diagnostics.Debug.Assert(evt.EventClass == EventClass.Mouse);
            MouseButton button = MouseButton.Primary;
            HIPoint pt = new HIPoint();
            HIPoint screenLoc = new HIPoint();

            IntPtr thisEventWindow;
            API.GetEventWindowRef(inEvent, out thisEventWindow);

            OSStatus err = API.GetEventMouseLocation(inEvent, out screenLoc);
            if (this.windowState == WindowState.Fullscreen)
            {
                pt = screenLoc;
            }
            else if (CursorVisible)
            {
                err = API.GetEventWindowMouseLocation(inEvent, out pt);
                pt.Y -= mTitlebarHeight;
            }
            else
            {
                err = API.GetEventMouseDelta(inEvent, out pt);
                pt.X += mouse_rel_x;
                pt.Y += mouse_rel_y;
                pt = ConfineMouseToWindow(thisEventWindow, pt);
                ResetMouseToWindowCenter();
                mouse_rel_x = pt.X;
                mouse_rel_y = pt.Y;
            }
            
            if (err != OSStatus.NoError && err != OSStatus.EventParameterNotFound)
            {
                // this error comes up from the application event handler.
                throw new MacOSException(err);
            }
            
            Point mousePosInClient = new Point((int)pt.X, (int)pt.Y);
            CheckEnterLeaveEvents(thisEventWindow, mousePosInClient);
            
            switch (evt.MouseEventKind)
            {
                case MouseEventKind.MouseDown:
                case MouseEventKind.MouseUp:
                    button = API.GetEventMouseButton(inEvent);
                    bool pressed = evt.MouseEventKind == MouseEventKind.MouseDown;

                    switch (button)
                    {
                        case MouseButton.Primary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Left] = pressed;
                            break;

                        case MouseButton.Secondary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Right] = pressed;
                            break;

                        case MouseButton.Tertiary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Middle] = pressed;
                            break;
                    }
                    return OSStatus.NoError;

                case MouseEventKind.WheelMoved:    // older, integer resolution only
                    {
                        // this is really an int, we use a float to avoid clipping the wheel value
                        float delta = API.GetEventMouseWheelDelta (inEvent);
                        InputDriver.Mouse[0].WheelPrecise += delta;
                    }
                    return OSStatus.NoError;

                case MouseEventKind.WheelScroll:   // newer, more precise X and Y scroll
                    {
                        API.ScrollDelta delta = API.GetEventWheelScroll(inEvent);
                        InputDriver.Mouse[0].WheelPrecise += delta.deltaY;
                    }
                    return OSStatus.NoError;

                case MouseEventKind.MouseMoved:
                case MouseEventKind.MouseDragged:
                    if (this.windowState == WindowState.Fullscreen)
                    {
                        if (mousePosInClient.X != InputDriver.Mouse[0].X || mousePosInClient.Y != InputDriver.Mouse[0].Y)
                        {
                            InputDriver.Mouse[0].Position = mousePosInClient;
                        }
                    }
                    else
                    {
                        // ignore clicks in the title bar
                        if (pt.Y < 0)
                            return OSStatus.EventNotHandled;

                        if (mousePosInClient.X != InputDriver.Mouse[0].X || mousePosInClient.Y != InputDriver.Mouse[0].Y)
                        {
                            InputDriver.Mouse[0].Position = mousePosInClient;
                        }
                    }
                    return OSStatus.EventNotHandled;

                default:
                    Debug.Print("{0}", evt);
                    return OSStatus.EventNotHandled;
            }
        }

        void ResetMouseToWindowCenter()
        {
            OpenTK.Input.Mouse.SetPosition(
                (Bounds.Left + Bounds.Right) / 2,
                (Bounds.Top + Bounds.Bottom) / 2);
        }

        private void CheckEnterLeaveEvents(IntPtr eventWindowRef, Point pt)
        {
            if (window == null)
                return;

            bool thisIn = eventWindowRef == window.Handle;

            if (pt.Y < 0)
                thisIn = false;

            if (thisIn != mMouseIn)
            {
                mMouseIn = thisIn;

                if (mMouseIn)
                    OnMouseEnter();
                else
                    OnMouseLeave();
            }
        }

        // Point in client (window) coordinates
        private HIPoint ConfineMouseToWindow(IntPtr window, HIPoint client)
        {
            if (client.X < 0)
                client.X = 0;
            if (client.X >= Width)
                client.X = Width - 1;
            if (client.Y < 0)
                client.Y = 0;
            if (client.Y >= Height)
                client.Y = Height - 1;

            return client;
        }

        private static void GetCharCodes(IntPtr inEvent, out MacOSKeyCode code, out char charCode)
        {
            code = API.GetEventKeyboardKeyCode(inEvent);
            charCode = API.GetEventKeyboardChar(inEvent);
        }

        void ProcessKeyDown(MacOSKeyCode code)
        {
            Key key;
            Keymap.TryGetValue(code, out key);

            // Legacy keyboard API
            KeyboardDevice keyboard = InputDriver.Keyboard[0];
            keyboard.SetKey(key, (uint)code, true);

            // Raise KeyDown for new keyboard API
            mKeyDownArgs.Key = key;
            mKeyDownArgs.Modifiers = keyboard.GetModifiers();

            KeyDown(this, mKeyDownArgs);

            // Raise KeyPress for new keyboard API
            if (!Char.IsControl(mKeyPressArgs.KeyChar))
            {
                OnKeyPress(mKeyPressArgs);
            }
        }

        void ProcessKeyUp(MacOSKeyCode code)
        {
            Key key;
            Keymap.TryGetValue(code, out key);

            // Legacy keyboard API
            KeyboardDevice keyboard = InputDriver.Keyboard[0];
            keyboard.SetKey(key, (uint)code, false);

            // Raise KeyUp for new keyboard API
            mKeyUpArgs.Key = key;
            mKeyDownArgs.Modifiers = keyboard.GetModifiers();

            KeyUp(this, mKeyUpArgs);
        }

        void ProcessKey(MacOSKeyCode code, bool pressed)
        {
            if (pressed)
            {
                ProcessKeyDown(code);
            }
            else
            {
                ProcessKeyUp(code);
            }
        }

        private void ProcessModifierKey(IntPtr inEvent)
        {
            MacOSKeyModifiers modifiers = API.GetEventKeyModifiers(inEvent);
            
            bool caps = (modifiers & MacOSKeyModifiers.CapsLock) != 0 ? true : false;
            bool control = (modifiers & MacOSKeyModifiers.Control) != 0 ? true : false;
            bool command = (modifiers & MacOSKeyModifiers.Command) != 0 ? true : false;
            bool option = (modifiers & MacOSKeyModifiers.Option) != 0 ? true : false;
            bool shift = (modifiers & MacOSKeyModifiers.Shift) != 0 ? true : false;
            
            Input.KeyboardDevice keyboard = InputDriver.Keyboard[0];

            if (keyboard[OpenTK.Input.Key.AltLeft] ^ option)
            {
                ProcessKey(MacOSKeyCode.OptionAlt, option);
            }
            
            if (keyboard[OpenTK.Input.Key.ShiftLeft] ^ shift)
            {
                ProcessKey(MacOSKeyCode.Shift, shift);
            }

            if (keyboard[OpenTK.Input.Key.WinLeft] ^ command)
            {
                ProcessKey(MacOSKeyCode.Command, command);
            }

            if (keyboard[OpenTK.Input.Key.ControlLeft] ^ control)
            {
                ProcessKey(MacOSKeyCode.Control, control);
            }
            
            if (keyboard[OpenTK.Input.Key.CapsLock] ^ caps)
            {
                ProcessKey(MacOSKeyCode.CapsLock, caps);
            }
        }

        Rect GetClientSize()
        {
            Rect retval = API.GetWindowBounds(window.Handle, WindowRegionCode.ContentRegion);
            return retval;
        }

        void SetClientSize(short width, short height)
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            Rect new_bounds = new Rect(Bounds.X, Bounds.Y, width, height);
            API.SetWindowBounds(window.Handle, WindowRegionCode.ContentRegion, ref new_bounds);
            LoadSize();
        }

        void SetLocation(short x, short y)
        {
            if (windowState == WindowState.Fullscreen)
                return;

            Rect new_bounds = new Rect(x, y, Bounds.Width, Bounds.Height);
            API.SetWindowBounds(window.Handle, WindowRegionCode.StructureRegion, ref new_bounds);
            LoadSize();
        }

        void SetSize(short width, short height)
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            Rect new_bounds = new Rect(Bounds.X, Bounds.Y, width, height);
            API.SetWindowBounds(window.Handle, WindowRegionCode.StructureRegion, ref new_bounds);
            LoadSize();
        }

        private void LoadSize()
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            Rect r = API.GetWindowBounds(window.Handle, WindowRegionCode.StructureRegion);
            bounds = new Rectangle(r.X, r.Y, r.Width, r.Height);

            r = API.GetWindowBounds(window.Handle, WindowRegionCode.ContentRegion);
            clientRectangle = new Rectangle(0, 0, r.Width, r.Height);
        }

        #endregion

        #region INativeWindow Members

        public void ProcessEvents()
        {
            Application.ProcessEvents();
        }

        public Point PointToClient(Point point)
        {
            Rect r = Carbon.API.GetWindowBounds(window.Handle, WindowRegionCode.ContentRegion);
            return new Point(point.X - r.X, point.Y - r.Y);
        }

        public Point PointToScreen(Point point)
        {
            Rect r = Carbon.API.GetWindowBounds(window.Handle, WindowRegionCode.ContentRegion);
            return new Point(point.X + r.X, point.Y + r.Y);
        }

        public bool Exists
        {
            get { return mExists; }
        }

        public IWindowInfo WindowInfo
        {
            get { return window; }
        }

        public bool IsIdle
        {
            get { return true; }
        }

        public OpenTK.Input.IInputDriver InputDriver
        {
            get { return mInputDriver; }
        }

        public Icon Icon
        {
            get { return mIcon; }
            set
            {
                if (value != Icon)
                {
                    SetIcon(value);
                    mIcon = value;
                    IconChanged(this, EventArgs.Empty);
                }
            }
        }

        private void SetIcon(Icon icon)
        {
            // The code for this function was adapted from Mono's 
            // XplatUICarbon implementation, written by Geoff Norton
            // http://anonsvn.mono-project.com/viewvc/trunk/mcs/class/Managed.Windows.Forms/System.Windows.Forms/XplatUICarbon.cs?view=markup&pathrev=136932
            if (icon == null)
            {
                API.RestoreApplicationDockTileImage();
            }

            else
            {
                Bitmap bitmap;
                int size;
                IntPtr[] data;
                int index;
                
                bitmap = new Bitmap(128, 128);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(icon.ToBitmap(), 0, 0, 128, 128);
                }
                index = 0;
                size = bitmap.Width * bitmap.Height;
                data = new IntPtr[size];
                
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        int pixel = bitmap.GetPixel(x, y).ToArgb();
                        if (BitConverter.IsLittleEndian)
                        {
                            byte a = (byte)((pixel >> 24) & 0xFF);
                            byte r = (byte)((pixel >> 16) & 0xFF);
                            byte g = (byte)((pixel >> 8) & 0xFF);
                            byte b = (byte)(pixel & 0xFF);
                            data[index++] = (IntPtr)(a + (r << 8) + (g << 16) + (b << 24));
                        }

                        else
                        {
                            data[index++] = (IntPtr)pixel;
                        }
                    }
                }
                
                IntPtr provider = API.CGDataProviderCreateWithData(IntPtr.Zero, data, size * 4, IntPtr.Zero);
                IntPtr image = API.CGImageCreate(128, 128, 8, 32, 4 * 128, API.CGColorSpaceCreateDeviceRGB(), 4, provider, IntPtr.Zero, 0,
                0);
                API.SetApplicationDockTileImage(image);
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value != Title)
                {
                    API.SetWindowTitle(window.Handle, value);
                    title = value;
                    TitleChanged(this, EventArgs.Empty);
                }
            }
        }

        public bool Visible
        {
            get { return API.IsWindowVisible(window.Handle); }
            set
            {
                if (value != Visible)
                {
                    if (value)
                        Show();
                    else
                        Hide();
                    
                    VisibleChanged(this, EventArgs.Empty);
                }
            }
        }

        public bool Focused
        {
            get { return this.mIsActive; }
        }

        public Rectangle Bounds
        {

            get { return bounds; }
            set
            {
                Location = value.Location;
                Size = value.Size;
            }
        }

        public Point Location
        {
            get { return Bounds.Location; }
            set { SetLocation((short)value.X, (short)value.Y); }
        }

        public Size Size
        {
            get { return bounds.Size; }
            set { SetSize((short)value.Width, (short)value.Height); }
        }

        public int Width
        {
            get { return ClientRectangle.Width; }
            set { SetClientSize((short)value, (short)Height); }
        }

        public int Height
        {
            get { return ClientRectangle.Height; }
            set { SetClientSize((short)Width, (short)value); }
        }

        public int X
        {
            get { return Bounds.X; }
            set { Location = new Point(value, Y); }
        }

        public int Y
        {
            get { return Bounds.Y; }
            set { Location = new Point(X, value); }
        }

        public Rectangle ClientRectangle
        {
            get { return clientRectangle; }
// just set the size, and ignore the location value.
// this is the behavior of the Windows WinGLNative.
            set { ClientSize = value.Size; }
        }

        public Size ClientSize
        {
            get { return clientRectangle.Size; }
            set
            {
                API.SizeWindow(window.Handle, (short)value.Width, (short)value.Height, true);
                LoadSize();
                Resize(this, EventArgs.Empty);
            }
        }

        public bool CursorVisible
        {
            get { return CG.CursorIsVisible(); }
            set
            {
                if (value)
                {
                    CG.DisplayShowCursor(IntPtr.Zero);
                    CG.AssociateMouseAndMouseCursorPosition(true);
                }
                else
                {
                    CG.DisplayHideCursor(IntPtr.Zero);
                    ResetMouseToWindowCenter();
                    CG.AssociateMouseAndMouseCursorPosition(false);
                }
            }
        }

        public void Close()
        {
            CancelEventArgs e = new CancelEventArgs();
            OnClosing(e);
            
            if (e.Cancel)
                return;
            
            OnClosed();
        }

        public WindowState WindowState
        {
            get
            {
                if (windowState == WindowState.Fullscreen)
                    return WindowState.Fullscreen;
                
                if (Carbon.API.IsWindowCollapsed(window.Handle))
                    return WindowState.Minimized;
                
                if (Carbon.API.IsWindowInStandardState(window.Handle))
                {
                    return WindowState.Maximized;
                }
                
                return WindowState.Normal;
            }
            set
            {
                if (value == WindowState)
                    return;
                
                Debug.Print("Switching window state from {0} to {1}", WindowState, value);
                WindowState oldState = WindowState;
                
                windowState = value;
                
                if (oldState == WindowState.Fullscreen)
                {
                    window.GoWindowedHack = true;
                    
                    // when returning from full screen, wait until the context is updated
                    // to actually do the work.
                    return;
                }
                
                if (oldState == WindowState.Minimized)
                {
                    API.CollapseWindow(window.Handle, false);
                }
                
                SetCarbonWindowState();
            }
        }

        private void SetCarbonWindowState()
        {
            CarbonPoint idealSize;
            
            switch (windowState)
            {
            case WindowState.Fullscreen:
                window.GoFullScreenHack = true;
                
                break;
            
            case WindowState.Maximized:
                // hack because mac os has no concept of maximized. Instead windows are "zoomed" 
                // meaning they are maximized up to their reported ideal size.  So we report a 
                // large ideal size.
                idealSize = new CarbonPoint(9000, 9000);
                API.ZoomWindowIdeal(window.Handle, WindowPartCode.inZoomOut, ref idealSize);
                break;
            
            case WindowState.Normal:
                if (WindowState == WindowState.Maximized)
                {
                    idealSize = new CarbonPoint();
                    API.ZoomWindowIdeal(window.Handle, WindowPartCode.inZoomIn, ref idealSize);
                }

                break;
            
            case WindowState.Minimized:
                API.CollapseWindow(window.Handle, true);
                
                break;
            }
            
            
            WindowStateChanged(this, EventArgs.Empty);
            LoadSize();
            Resize(this, EventArgs.Empty);
        }

        public WindowBorder WindowBorder
        {
            get { return windowBorder; }
            set
            {
                if (windowBorder == value)
                    return;
                
                windowBorder = value;
                
                if (windowBorder == WindowBorder.Resizable)
                {
                    API.ChangeWindowAttributes(window.Handle, WindowAttributes.Resizable | WindowAttributes.FullZoom, WindowAttributes.NoAttributes);
                }

                else if (windowBorder == WindowBorder.Fixed)
                {
                    API.ChangeWindowAttributes(window.Handle, WindowAttributes.NoAttributes, WindowAttributes.Resizable | WindowAttributes.FullZoom);
                }
                
                WindowBorderChanged(this, EventArgs.Empty);
            }
        }

        #region --- Event wrappers ---

        private void OnKeyPress(KeyPressEventArgs keyPressArgs)
        {
            KeyPress(this, keyPressArgs);
        }


        private void OnWindowStateChanged()
        {
            WindowStateChanged(this, EventArgs.Empty);
        }

        protected virtual void OnClosing(CancelEventArgs e)
        {
            Closing(this, e);
        }

        protected virtual void OnClosed()
        {
            Closed(this, EventArgs.Empty);
        }


        private void OnMouseLeave()
        {
            MouseLeave(this, EventArgs.Empty);
        }

        private void OnMouseEnter()
        {
            MouseEnter(this, EventArgs.Empty);
        }

        private void OnActivate()
        {
            mIsActive = true;
            FocusedChanged(this, EventArgs.Empty);
        }
        private void OnDeactivate()
        {
            mIsActive = false;
            FocusedChanged(this, EventArgs.Empty);
        }

        #endregion

        public event EventHandler<EventArgs> Move = delegate { };
        public event EventHandler<EventArgs> Resize = delegate { };
        public event EventHandler<CancelEventArgs> Closing = delegate { };
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
        public event EventHandler<EventArgs> MouseEnter = delegate { };
        public event EventHandler<EventArgs> MouseLeave = delegate { };
        
        #endregion
    }
}
