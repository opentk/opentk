//
//  
//  xCSCarbon
//
//  Created by Erik Ylvisaker on 3/17/08.
//  Copyright 2008 __MyCompanyName__. All rights reserved.
//
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Graphics;

    class CarbonGLNative : INativeGLWindow
    {
        CarbonWindowInfo window;
        CarbonInput mInputDriver;
        GraphicsContext context;

        static MacOSKeyMap Keymap = new MacOSKeyMap();

        IntPtr uppHandler;

        string title = "OpenTK Window";
        short mWidth, mHeight;
        short mWindowedWidth, mWindowedHeight;
        bool mIsDisposed = false;

        WindowAttributes mWindowAttrib;
        WindowClass mWindowClass;
        WindowPositionMethod mPositionMethod = WindowPositionMethod.CenterOnMainScreen;
        int mTitlebarHeight;
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private WindowState windowState = WindowState.Normal;

        static Dictionary<IntPtr, WeakReference> mWindows = new Dictionary<IntPtr, WeakReference>();

        static CarbonGLNative()
        {
            Application.Initialize();
        }
        public CarbonGLNative()
            : this(WindowClass.Document,
            WindowAttributes.StandardDocument |
            WindowAttributes.StandardHandler |
            WindowAttributes.InWindowMenu |
            WindowAttributes.LiveResize)
        {

        }
        private CarbonGLNative(WindowClass @class, WindowAttributes attrib)
        {
            mWindowClass = @class;
            mWindowAttrib = attrib;


        }
        ~CarbonGLNative()
        {
            Dispose(false);
        }

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

        private void DisposeUPP()
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

        public void Activate()
        {
            API.SelectWindow(window.WindowRef);
        }
        public void Show()
        {
            IntPtr parent = IntPtr.Zero;

            API.ShowWindow(window.WindowRef);
            API.RepositionWindow(window.WindowRef, parent, WindowPositionMethod);
            API.SelectWindow(window.WindowRef);
        }
        public void Hide()
        {
            API.HideWindow(window.WindowRef);
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
        public bool IsDisposed
        {
            get { return mIsDisposed; }
        }

        public WindowPositionMethod WindowPositionMethod
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
                    OnQueryWindowClose(cancel);

                    if (cancel.Cancel)
                        return OSStatus.NoError;
                    else
                        return OSStatus.EventNotHandled;

                case WindowEventKind.WindowClosed:
                    OnWindowClosed();

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

            OSStatus err ;

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

        public int Width
        {
            get { return mWidth; }
            set { SetSize(value, mHeight); }
        }
        public int Height
        {
            get { return mHeight; }
            set { SetSize(mWidth, value); }
        }
        public void SetSize(int width, int height)
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            mWidth = (short)width;
            mHeight = (short)height;

            API.SizeWindow(window.WindowRef, mWidth, mHeight, true);

            Rect contentBounds = API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);

            Rect newSize = new Rect(0, 0,
                (short)(2 * mWidth - contentBounds.Width),
                (short)(2 * mHeight - contentBounds.Height));

            Debug.Print("Content region was: {0}", contentBounds);
            Debug.Print("Resizing window to: {0}", newSize);

            API.SizeWindow(window.WindowRef, newSize.Width, newSize.Height, true);

            contentBounds = API.GetWindowBounds(window.WindowRef, WindowRegionCode.ContentRegion);
            Debug.Print("New content region size: {0}", contentBounds);
        }

        protected void OnResize()
        {
            LoadSize();

            if (context != null && this.windowState != WindowState.Fullscreen)
                context.Update(window);

            if (Resize != null)
            {
                Resize(this, new ResizeEventArgs(Width, Height));
            }
        }

        private void LoadSize()
        {
            if (WindowState == WindowState.Fullscreen)
                return;

            Rect region = GetRegion();

            mWidth = (short)(region.Width);
            mHeight = (short)(region.Height);
        }

        protected virtual void OnQueryWindowClose(CancelEventArgs e)
        {
            if (QueryWindowClose != null)
                QueryWindowClose(this, e);
        }
        protected virtual void OnWindowClosed()
        {
            if (Destroy != null)
                Destroy(this, EventArgs.Empty);

        }

        public event CancelEventHandler QueryWindowClose;


        #region INativeGLWindow Members

        public void CreateWindow(int width, int height, OpenTK.Graphics.GraphicsMode mode, int major, int minor, GraphicsContextFlags flags, out OpenTK.Graphics.IGraphicsContext context)
        {
            Rect r = new Rect(0, 0, (short)width, (short)height);
            CreateNativeWindow(mWindowClass, mWindowAttrib, r);

            Show();

            this.context = new Graphics.GraphicsContext(mode, window, major, minor, flags);
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

        public event CreateEvent Create = delegate(object sender, EventArgs e) { };
        public event DestroyEvent Destroy = delegate(object sender, EventArgs e) { };

        #endregion

        #region IResizable Members

        public event ResizeEvent Resize;

        #endregion

        #region INativeGLWindow Members

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

                OnResize();
            }
        }


        private void SetFullscreen()
        {
            ((AglContext)(context as IGraphicsContextInternal).Implementation).SetFullScreen(window);

            mWindowedWidth = mWidth;
            mWindowedHeight = mHeight;

            Debug.Print("Prev Size: {0}, {1}", Width, Height);

            mWidth = (short)DisplayDevice.Default.Width;
            mHeight = (short)DisplayDevice.Default.Height;

            Debug.Print("New Size: {0}, {1}", Width, Height);

        }
        private void UnsetFullscreen()
        {
            ((AglContext)(context as IGraphicsContextInternal).Implementation).UnsetFullScreen(window);
            SetSize(mWindowedWidth, mWindowedHeight);
        }

        public WindowBorder WindowBorder
        {
            get
            {
                return windowBorder;
            }
            set
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
            }
        }

        #endregion

    }
}
