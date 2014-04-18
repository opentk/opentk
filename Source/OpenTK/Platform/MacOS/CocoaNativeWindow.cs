using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.MacOS
{
    class CocoaNativeWindow : INativeWindow
    {
        public event System.EventHandler<System.EventArgs> Move;
        public event System.EventHandler<System.EventArgs> Resize;
        public event System.EventHandler<System.ComponentModel.CancelEventArgs> Closing;
        public event System.EventHandler<System.EventArgs> Closed;
        public event System.EventHandler<System.EventArgs> Disposed;
        public event System.EventHandler<System.EventArgs> IconChanged;
        public event System.EventHandler<System.EventArgs> TitleChanged;
        public event System.EventHandler<System.EventArgs> VisibleChanged;
        public event System.EventHandler<System.EventArgs> FocusedChanged;
        public event System.EventHandler<System.EventArgs> WindowBorderChanged;
        public event System.EventHandler<System.EventArgs> WindowStateChanged;
        public event System.EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyDown;
        public event System.EventHandler<KeyPressEventArgs> KeyPress;
        public event System.EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyUp;
        public event System.EventHandler<System.EventArgs> MouseLeave;
        public event System.EventHandler<System.EventArgs> MouseEnter;

        private CocoaWindowInfo windowInfo;

        static readonly IntPtr nextEventMatchingMask = Selector.Get("nextEventMatchingMask:untilDate:inMode:dequeue:");
        static readonly IntPtr sendEvent = Selector.Get("sendEvent:");
        static readonly IntPtr updateWindows = Selector.Get("updateWindows");
        static readonly IntPtr contentView = Selector.Get("contentView");
        static readonly IntPtr NSDefaultRunLoopMode;

        static CocoaNativeWindow()
        {
            Cocoa.Initialize();
            NSDefaultRunLoopMode = Cocoa.GetStringConstant(Cocoa.FoundationLibrary, "NSDefaultRunLoopMode");
        }

        public CocoaNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            var contentRect = new System.Drawing.RectangleF(x, y, width, height);
            var style = NSWindowStyle.Titled | NSWindowStyle.Resizable;
            var bufferingType = NSBackingStore.Buffered;

            IntPtr windowPtr;
            windowPtr = Cocoa.SendIntPtr(Class.Get("NSWindow"), Selector.Alloc);
            windowPtr = Cocoa.SendIntPtr(windowPtr, Selector.Get("initWithContentRect:styleMask:backing:defer:"), contentRect, (int)style, (int)bufferingType, false);
            windowPtr = Cocoa.SendIntPtr(windowPtr, Selector.Autorelease);

            Cocoa.SendVoid(windowPtr, Selector.Get("cascadeTopLeftFromPoint:"), new System.Drawing.PointF(20, 20));
            Cocoa.SendVoid(windowPtr, Selector.Get("setTitle:"), Cocoa.ToNative(title));
            Cocoa.SendVoid(windowPtr, Selector.Get("makeKeyAndOrderFront:"), IntPtr.Zero);

            windowInfo = new CocoaWindowInfo(windowPtr);
        }

        public static IntPtr GetView(IntPtr windowHandle)
        {
            return Cocoa.SendIntPtr(windowHandle, contentView);
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void ProcessEvents()
        {
            var e = Cocoa.SendIntPtr(NSApplication.Handle, nextEventMatchingMask, uint.MaxValue, IntPtr.Zero, NSDefaultRunLoopMode, true);

            if (e == IntPtr.Zero)
                return;

            Cocoa.SendVoid(NSApplication.Handle, sendEvent, e);
            Cocoa.SendVoid(NSApplication.Handle, updateWindows);
        }

        public System.Drawing.Point PointToClient(System.Drawing.Point point)
        {
            throw new System.NotImplementedException();
        }

        public System.Drawing.Point PointToScreen(System.Drawing.Point point)
        {
            throw new System.NotImplementedException();
        }

        public System.Drawing.Icon Icon
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public bool Focused
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public bool Visible
        {
            get
            {
                //throw new System.NotImplementedException();
                return true;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }

        public bool Exists
        {
            get
            {
                return true;
            }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return windowInfo;
            }
        }

        public WindowState WindowState
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public WindowBorder WindowBorder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.Drawing.Rectangle Bounds
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.Drawing.Point Location
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.Drawing.Size Size
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int X
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int Y
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int Width
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int Height
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.Drawing.Rectangle ClientRectangle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public System.Drawing.Size ClientSize
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public OpenTK.Input.IInputDriver InputDriver
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public bool CursorVisible
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Dispose()
        {

        }
    }
}
