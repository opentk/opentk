//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.ComponentModel;
using System.Drawing;
using OpenToolkit.Windowing.EventingModels;
using OpenToolkit.Windowing.GraphicsLibraryFramework;
using OpenToolkit.Windowing.Input;
using OpenToolkit.Windowing.Interfaces;

namespace OpenToolkit.Windowing
{
    public class NativeWindow : INativeWindow
    {
        private static GLFW glfw = null;
        private readonly unsafe Window* windowPtr = null;

        public string Title
        {
            get
            {
                unsafe
                {
                    return glfw.GetWindowTitle(windowPtr);
                }
            }
            set
            {
                unsafe
                {
                    glfw.SetWindowTitle(windowPtr, value);
                }
            }
        }

        public bool Focused
        {
            get
            {
                unsafe
                {
                    return glfw.GetWindowAttrib(windowPtr, (int)WindowHint.GLFW_FOCUSED) != 0;
                }
            }
            set
            {
                unsafe
                {
                    if (value)
                    {
                        glfw.FocusWindow(windowPtr);
                    }
                }
            }
        }

        public bool Visible
        {
            get
            {
                unsafe
                {
                    return glfw.GetWindowAttrib(windowPtr, (int)WindowHint.GLFW_VISIBLE) != 0;
                }
            }
            set
            {
                if (value)
                {
                    unsafe
                    {
                        glfw.ShowWindow(windowPtr);
                    }
                }
                else
                {
                    unsafe
                    {
                        glfw.HideWindow(windowPtr);
                    }
                }
            }
        }

        public bool Exists
        {
            get
            {
                unsafe { return windowPtr != null; }
            }
        }

        public IWindowInfo WindowInfo => throw new NotImplementedException();

        public WindowState WindowState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WindowBorder WindowBorder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Rectangle Bounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Rectangle ClientRectangle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Size ClientSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MouseCursor Cursor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CursorVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CursorGrabbed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public NativeWindow(int width = 640, int height = 480, string title = "", bool windowedFullscreen = false)
        {
            if (glfw == null)
            {
                glfw = GLFW.GetAPI();
                glfw.Init();
            }


            unsafe
            {
                var monitor = glfw.GetPrimaryMonitor();
                if (windowedFullscreen)
                {
                    var modePtr = glfw.GetVideoMode(monitor);
                    glfw.WindowHint(WindowHint.GLFW_RED_BITS, modePtr->redBits);
                    glfw.WindowHint(WindowHint.GLFW_GREEN_BITS, modePtr->greenBits);
                    glfw.WindowHint(WindowHint.GLFW_BLUE_BITS, modePtr->blueBits);
                    glfw.WindowHint(WindowHint.GLFW_REFRESH_RATE, modePtr->refreshRate);
                    windowPtr = glfw.CreateWindow(modePtr->width, modePtr->height, title, monitor, null);
                }
                else
                {
                    windowPtr = glfw.CreateWindow(width, height, title, null, null);
                }
            }
        }

        public Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        public Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }

        #region Events
        public event EventHandler<EventArgs> Move;
        public event EventHandler<EventArgs> Resize;
        public event EventHandler<CancelEventArgs> Closing;
        public event EventHandler<EventArgs> Closed;
        public event EventHandler<EventArgs> Disposed;
        public event EventHandler<EventArgs> IconChanged;
        public event EventHandler<EventArgs> TitleChanged;
        public event EventHandler<EventArgs> VisibleChanged;
        public event EventHandler<EventArgs> FocusedChanged;
        public event EventHandler<EventArgs> WindowBorderChanged;
        public event EventHandler<EventArgs> WindowStateChanged;
        public event EventHandler<KeyboardKeyEventArgs> KeyDown;
        public event EventHandler<KeyPressEventArgs> KeyPress;
        public event EventHandler<KeyboardKeyEventArgs> KeyUp;
        public event EventHandler<EventArgs> MouseLeave;
        public event EventHandler<EventArgs> MouseEnter;
        public event EventHandler<MouseButtonEventArgs> MouseDown;
        public event EventHandler<MouseButtonEventArgs> MouseUp;
        public event EventHandler<MouseMoveEventArgs> MouseMove;
        public event EventHandler<MouseWheelEventArgs> MouseWheel;
        public event EventHandler<FileDropEventArgs> FileDrop;
        public event EventHandler<EventArgs> Load;
        public event EventHandler<EventArgs> Unload;
        public event EventHandler<FrameEventArgs> UpdateFrame;
        public event EventHandler<FrameEventArgs> RenderFrame;
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Free managed resources
                }

                // Free unmanaged resources
                unsafe
                {
                    if (windowPtr != null)
                    {
                        glfw.DestroyWindow(windowPtr);
                    }
                }
                glfw.Terminate();

                disposedValue = true;
            }
        }

        ~NativeWindow()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
