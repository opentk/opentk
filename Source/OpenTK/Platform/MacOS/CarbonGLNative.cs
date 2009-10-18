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
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Graphics;

    class CarbonGLNative : INativeWindow
    {
        #region Fields

        CarbonWindowInfo window;
        CarbonInput mInputDriver;
        GraphicsContext context;

        static MacOSKeyMap Keymap = new MacOSKeyMap();

        IntPtr uppHandler;

        string title = "OpenTK Window";
        System.Drawing.Rectangle bounds, windowedBounds, clientRectangle;
        bool mIsDisposed = false;

        WindowAttributes mWindowAttrib;
        WindowClass mWindowClass;
        WindowPositionMethod mPositionMethod = WindowPositionMethod.CenterOnMainScreen;
        int mTitlebarHeight;
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private WindowState windowState = WindowState.Normal;

        static Dictionary<IntPtr, WeakReference> mWindows = new Dictionary<IntPtr, WeakReference>();

        #endregion

        #region Constructors

        static CarbonGLNative()
        {
            Application.Initialize();
        }

        CarbonGLNative()
            : this(WindowClass.Document,
            WindowAttributes.StandardDocument |
            WindowAttributes.StandardHandler |
            WindowAttributes.InWindowMenu |
            WindowAttributes.LiveResize)
        { }


        CarbonGLNative(WindowClass @class, WindowAttributes attrib)
        {
            mWindowClass = @class;
            mWindowAttrib = attrib;
        }

        public CarbonGLNative(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            CreateNativeWindow(WindowClass.Document,
                WindowAttributes.StandardDocument | WindowAttributes.StandardHandler |
                WindowAttributes.InWindowMenu | WindowAttributes.LiveResize,
                new Rect((short)x, (short)y, (short)width, (short)height));
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

            mIsDisposed = true;

            if (disposing)
            {
                mWindows.Remove(window.WindowRef);

                window.Dispose();
                window = null;
            }

            DisposeUPP();
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
                //API.RemoveEventHandler(uppHandler);
                //API.DisposeEventHandlerUPP(uppHandler);
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

            Rect titleSize = API.GetWindowBounds(window.WindowRef, WindowRegionCode.TitleBarRegion);
            mTitlebarHeight = titleSize.Height;

            Debug.Print("Titlebar size: {0}", titleSize);

            ConnectEvents();

            System.Diagnostics.Debug.Print("Attached window events.");
        }

        void ConnectEvents()
        {
            mInputDriver = new CarbonInput();

            EventTypeSpec[] eventTypes = new EventTypeSpec[]
            {
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowClose),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowClosed),
                new EventTypeSpec(EventClass.Window, WindowEventKind.WindowBoundsChanged),

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

            API.InstallWindowEventHandler(window.WindowRef, uppHandler, eventTypes, window.WindowRef, IntPtr.Zero);

            Application.WindowEventHandler = this;
        }

        void Activate()
        {
            API.SelectWindow(window.WindowRef);
        }

        void Show()
        {
            IntPtr parent = IntPtr.Zero;

            API.ShowWindow(window.WindowRef);
            API.RepositionWindow(window.WindowRef, parent, WindowPositionMethod);
            API.SelectWindow(window.WindowRef);
        }

        void Hide()
        {
            API.HideWindow(window.WindowRef);
        }

        void SetFullscreen()
        {
            windowedBounds = bounds;

            ((AglContext)(context as IGraphicsContextInternal).Implementation).SetFullScreen(window);

            Debug.Print("Prev Size: {0}, {1}", Width, Height);

            bounds = DisplayDevice.Default.Bounds;

            Debug.Print("New Size: {0}, {1}", Width, Height);
        }

        void UnsetFullscreen()
        {
            ((AglContext)(context as IGraphicsContextInternal).Implementation).UnsetFullScreen(window);
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
            // bail out if the window passed in is not actually our window.
            // I think this happens if using winforms with a GameWindow sometimes.
            if (mWindows.ContainsKey(userData) == false)
                return OSStatus.EventNotHandled;

            WeakReference reference = mWindows[userData];

            // bail out if the CarbonGLNative window has been garbage collected.
            if (reference.IsAlive == false)
            {
                mWindows.Remove(userData);
                return OSStatus.EventNotHandled;
            }

            EventInfo evt = new EventInfo(inEvent);
            CarbonGLNative window = (CarbonGLNative)reference.Target;

            //Debug.Print("Processing {0} event for {1}.", evt, window.window);

            if (window == null)
            {
                Debug.WriteLine("Window for event not found.");
                return OSStatus.EventNotHandled;
            }

            switch (evt.EventClass)
            {
                case EventClass.Window:
                    return window.ProcessWindowEvent(inCaller, inEvent, evt, userData);

                case EventClass.Mouse:
                    return window.ProcessMouseEvent(inCaller, inEvent, evt, userData);

                case EventClass.Keyboard:
                    return window.ProcessKeyboardEvent(inCaller, inEvent, evt, userData);

                default:
                    return OSStatus.EventNotHandled;
            }
        }

        private OSStatus ProcessKeyboardEvent(IntPtr inCaller, IntPtr inEvent, EventInfo evt, IntPtr userData)
        {
            System.Diagnostics.Debug.Assert(evt.EventClass == EventClass.Keyboard);
            MacOSKeyCode code;
            char charCode;

            switch (evt.KeyboardEventKind)
            {
                case KeyboardEventKind.RawKeyRepeat:
                    GetCharCodes(inEvent, out code, out charCode);
                    InputDriver.Keyboard[0].KeyRepeat = true;
                    goto case KeyboardEventKind.RawKeyDown;

                case KeyboardEventKind.RawKeyDown:
                    GetCharCodes(inEvent, out code, out charCode);
                    InputDriver.Keyboard[0][Keymap[code]] = true;
                    return OSStatus.EventNotHandled;

                case KeyboardEventKind.RawKeyUp:
                    GetCharCodes(inEvent, out code, out charCode);
                    InputDriver.Keyboard[0][Keymap[code]] = false;

                    return OSStatus.EventNotHandled;

                case KeyboardEventKind.RawKeyModifiersChanged:
                    ProcessModifierKey(inEvent);
                    return OSStatus.EventNotHandled;

                default:
                    return OSStatus.EventNotHandled;
            }


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
                    OnClosed();

                    return OSStatus.NoError;

                case WindowEventKind.WindowBoundsChanged:
                    int thisWidth = Width;
                    int thisHeight = Height;

                    LoadSize();

                    if (thisWidth != Width || thisHeight != Height)
                        OnResize();

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

            OSStatus err;

            if (this.windowState == WindowState.Fullscreen)
            {
                err = API.GetEventMouseLocation(inEvent, out pt);
            }
            else
            {
                err = API.GetEventWindowMouseLocation(inEvent, out pt);
            }

            if (err != OSStatus.NoError)
            {
                // this error comes up from the application event handler.
                if (err != OSStatus.EventParameterNotFound)
                {
                    throw new MacOSException(err);
                }
            }


            if (this.windowState == WindowState.Fullscreen)
            {
                InputDriver.Mouse[0].Position =
                    new System.Drawing.Point(
                        (int)pt.X,
                        (int)pt.Y);
            }
            else
            {
                // ignore clicks in the title bar
                if (pt.Y < mTitlebarHeight)
                    return OSStatus.EventNotHandled;

                InputDriver.Mouse[0].Position =
                    new System.Drawing.Point(
                        (int)pt.X,
                        (int)(pt.Y - mTitlebarHeight));
            }

            switch (evt.MouseEventKind)
            {
                case MouseEventKind.MouseDown:
                    button = API.GetEventMouseButton(inEvent);

                    switch (button)
                    {
                        case MouseButton.Primary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Left] = true;
                            break;

                        case MouseButton.Secondary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Right] = true;
                            break;

                        case MouseButton.Tertiary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Middle] = true;
                            break;
                    }


                    break;

                case MouseEventKind.MouseUp:
                    switch (button)
                    {
                        case MouseButton.Primary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Left] = false;
                            break;

                        case MouseButton.Secondary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Right] = false;
                            break;

                        case MouseButton.Tertiary:
                            InputDriver.Mouse[0][OpenTK.Input.MouseButton.Middle] = false;
                            break;
                    }

                    button = API.GetEventMouseButton(inEvent);

                    break;

                case MouseEventKind.MouseMoved:
                case MouseEventKind.MouseDragged:

                    //Debug.Print("MouseMoved: {0}", InputDriver.Mouse[0].Position);

                    return OSStatus.EventNotHandled;

                default:
                    Debug.Print("{0}", evt);

                    return OSStatus.EventNotHandled;
            }

            return OSStatus.EventNotHandled;
        }

        private static void GetCharCodes(IntPtr inEvent, out MacOSKeyCode code, out char charCode)
        {
            code = API.GetEventKeyboardKeyCode(inEvent);
            charCode = API.GetEventKeyboardChar(inEvent);
        }
        private void ProcessModifierKey(IntPtr inEvent)
        {
            MacOSKeyModifiers modifiers = API.GetEventKeyModifiers(inEvent);

            bool caps = (modifiers & MacOSKeyModifiers.CapsLock) != 0 ? true : false;
            bool control = (modifiers & MacOSKeyModifiers.Control) != 0 ? true : false;
            bool command = (modifiers & MacOSKeyModifiers.Command) != 0 ? true : false;
            bool option = (modifiers & MacOSKeyModifiers.Option) != 0 ? true : false;
            bool shift = (modifiers & MacOSKeyModifiers.Shift) != 0 ? true : false;

            Debug.Print("Modifiers Changed: {0}", modifiers);

            Input.KeyboardDevice keyboard = InputDriver.Keyboard[0];

            if (keyboard[OpenTK.Input.Key.AltLeft] ^ option)
                keyboard[OpenTK.Input.Key.AltLeft] = option;

            if (keyboard[OpenTK.Input.Key.ShiftLeft] ^ shift)
                keyboard[OpenTK.Input.Key.ShiftLeft] = shift;

            if (keyboard[OpenTK.Input.Key.WinLeft] ^ command)
                keyboard[OpenTK.Input.Key.WinLeft] = command;

            if (keyboard[OpenTK.Input.Key.ControlLeft] ^ control)
                keyboard[OpenTK.Input.Key.ControlLeft] = control;

            if (keyboard[OpenTK.Input.Key.CapsLock] ^ caps)
                keyboard[OpenTK.Input.Key.CapsLock] = caps;

        }

        Rect GetRegion()
        {
            Rect retval = API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);

            return retval;
        }

        void SetLocation(short x, short y)
        {
            if (windowState == WindowState.Fullscreen)
                return;

            API.MoveWindow(window.WindowRef, x, y, false);
        }

        void SetSize(short width, short height)
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            // Todo: why call SizeWindow twice?
            API.SizeWindow(window.WindowRef, width, height, true);
            bounds.Width = (short)width;
            bounds.Height = (short)height;

            Rect contentBounds = API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);

            Rect newSize = new Rect(0, 0,
                (short)(2 * width - contentBounds.Width),
                (short)(2 * height - contentBounds.Height));

            Debug.Print("Content region was: {0}", contentBounds);
            Debug.Print("Resizing window to: {0}", newSize);

            API.SizeWindow(window.WindowRef, newSize.Width, newSize.Height, true);

            contentBounds = API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);
            Debug.Print("New content region size: {0}", contentBounds);
            clientRectangle = contentBounds.ToRectangle();
        }

        protected void OnResize()
        {
            LoadSize();

            if (context != null && this.windowState != WindowState.Fullscreen)
                context.Update(window);

            if (Resize != null)
            {
                Resize(this, EventArgs.Empty);
            }
        }

        private void LoadSize()
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            bounds = GetRegion().ToRectangle();
        }

        protected virtual void OnClosing(CancelEventArgs e)
        {
            if (Closing != null)
                Closing(this, e);
        }

        protected virtual void OnClosed()
        {
            if (Closed != null)
                Closed(this, EventArgs.Empty);
        }

        #endregion

        #region INativeGLWindow Members

        public void CreateWindow(int width, int height, GraphicsMode mode, int major, int minor, GraphicsContextFlags flags, out IGraphicsContext context)
        {
            Rect r = new Rect(0, 0, (short)width, (short)height);
            CreateNativeWindow(mWindowClass, mWindowAttrib, r);

            Show();

            this.context = new GraphicsContext(mode, window, major, minor, flags);
            this.context.MakeCurrent(window);

            context = this.context;
        }

        public void DestroyWindow()
        {
            Dispose();
        }
        public void ProcessEvents()
        {
            Application.ProcessEvents();
        }

        public System.Drawing.Point PointToClient(System.Drawing.Point point)
        {
            IntPtr handle = window.WindowRef;

            Rect r = Carbon.API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);
            Console.WriteLine("Rect: {0}", r);

            return new System.Drawing.Point(point.X - r.X, point.Y - r.Y);
        }
        public System.Drawing.Point PointToScreen(System.Drawing.Point point)
        {
            throw new NotImplementedException();
        }

        public bool Exists
        {
            get { return !mIsDisposed; }
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
            get
            {
                return mInputDriver;
            }
        }

        public bool Fullscreen
        {
            get
            {
                return false;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region INativeWindow Members

        public System.Drawing.Icon Icon
        {
            get { return null; }
            set { }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                API.SetWindowTitle(window.WindowRef, value);
                title = value;
            }
        }

        public bool Visible
        {
            get { return API.IsWindowVisible(window.WindowRef); }
            set
            {
                if (value && Visible == false)
                    Show();
                else
                    Hide();
            }
        }

        public bool Focused
        {
            get { throw new NotImplementedException(); }
        }

        public System.Drawing.Rectangle Bounds
        {
            get
            {
                return bounds;
            }
            set
            {
                Location = value.Location;
                Size = value.Size;
            }
        }

        public System.Drawing.Point Location
        {
            get
            {
                return bounds.Location;
            }
            set
            {
                SetLocation((short)value.X, (short)value.Y);
            }
        }

        public System.Drawing.Size Size
        {
            get
            {
                return bounds.Size;
            }
            set
            {
                SetSize((short)value.Width, (short)value.Height);
            }
        }

        public int Width
        {
            get { return Bounds.Width; }
            set { Size = new System.Drawing.Size(value, Height); }
        }

        public int Height
        {
            get { return Bounds.Height; }
            set { Size = new System.Drawing.Size(Width, value); }
        }

        public int X
        {
            get
            {
                return bounds.X;
            }
            set
            {
                Location = new System.Drawing.Point(value, Y);
            }
        }

        public int Y
        {
            get
            {
                return bounds.Y;
            }
            set
            {
                Location = new System.Drawing.Point(X, value);
            }
        }

        public System.Drawing.Rectangle ClientRectangle
        {
            get
            {
                return clientRectangle;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Drawing.Size ClientSize
        {
            get
            {
                return clientRectangle.Size;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public WindowState WindowState
        {
            get
            {
                if (windowState == WindowState.Fullscreen)
                    return WindowState.Fullscreen;

                if (Carbon.API.IsWindowCollapsed(window.WindowRef))
                    return WindowState.Minimized;


                if (Carbon.API.IsWindowInStandardState(window.WindowRef))
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

                if (WindowState == WindowState.Fullscreen)
                {
                    UnsetFullscreen();
                }
                if (WindowState == WindowState.Minimized)
                {
                    API.CollapseWindow(window.WindowRef, false);
                }
                Point idealSize;

                switch (value)
                {
                    case WindowState.Fullscreen:
                        SetFullscreen();

                        break;

                    case WindowState.Maximized:
                        // hack because mac os has no concept of maximized. Instead windows are "zoomed" 
                        // meaning they are maximized up to their reported ideal size.  So we report a 
                        // large ideal size.
                        idealSize = new Point(9000, 9000);
                        API.ZoomWindowIdeal(window.WindowRef, WindowPartCode.inZoomOut, ref idealSize);
                        break;

                    case WindowState.Normal:
                        if (WindowState == WindowState.Maximized)
                        {
                            idealSize = new Point();
                            API.ZoomWindowIdeal(window.WindowRef, WindowPartCode.inZoomIn, ref idealSize);
                        }
                        break;

                    case WindowState.Minimized:
                        API.CollapseWindow(window.WindowRef, true);

                        break;
                }

                windowState = value;

                if (WindowStateChanged != null)
                    WindowStateChanged(this, EventArgs.Empty);

                OnResize();
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
                if (windowBorder != value)
                {
                    windowBorder = value;

                    if (windowBorder == WindowBorder.Resizable)
                    {
                        API.ChangeWindowAttributes(window.WindowRef, WindowAttributes.Resizable | WindowAttributes.FullZoom,
                                                   WindowAttributes.NoAttributes);
                    }
                    else if (windowBorder == WindowBorder.Fixed)
                    {
                        API.ChangeWindowAttributes(window.WindowRef, WindowAttributes.NoAttributes,
                                                   WindowAttributes.Resizable | WindowAttributes.FullZoom);
                    }

                    if (WindowBorderChanged != null)
                        WindowBorderChanged(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler<EventArgs> Idle;

        public event EventHandler<EventArgs> Load;

        public event EventHandler<EventArgs> Unload;

        public event EventHandler<EventArgs> Move;

        public event EventHandler<EventArgs> Resize;

        public event EventHandler<CancelEventArgs> Closing;

        public event EventHandler<EventArgs> Closed;

        public event EventHandler<EventArgs> Disposed;

        public event EventHandler<EventArgs> IconChanged;

        public event EventHandler<EventArgs> TitleChanged;

        public event EventHandler<EventArgs> ClientSizeChanged;

        public event EventHandler<EventArgs> VisibleChanged;

        public event EventHandler<EventArgs> WindowInfoChanged;

        public event EventHandler<EventArgs> FocusedChanged;

        public event EventHandler<EventArgs> WindowBorderChanged;

        public event EventHandler<EventArgs> WindowStateChanged;

        public event EventHandler<KeyPressEventArgs> KeyPress;

        #endregion
    }
}
