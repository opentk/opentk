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

// Created by Erik Ylvisaker on 3/17/08.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Graphics;

    using AGLRendererInfo = IntPtr;
    using AGLPixelFormat = IntPtr;
    using AGLContext = IntPtr;
    using AGLPbuffer = IntPtr;

    /// <summary>
    /// AGL context implementation for WinForms compatibility.
    /// </summary>
    internal class AglContext : IGraphicsContext, IGraphicsContextInternal
    {
        private IWindowInfo carbonWindow;
        private IGraphicsContext dummyContext; // for extension loading

        private readonly GetInt XOffset;
        private readonly GetInt YOffset;

        public AglContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext,
            GetInt xoffset, GetInt yoffset)
        {
            Debug.Print("Share context: {0}", shareContext);
            Debug.Print("Window info: {0}", window);
            IntPtr shareContextRef = IntPtr.Zero;

            XOffset = xoffset;
            YOffset = yoffset;

            carbonWindow = window;

            if (shareContext is AglContext)
            {
                shareContextRef = ((AglContext)shareContext).Context.Handle;
            }
            else if (shareContext is GraphicsContext)
            {
                ContextHandle shareHandle = shareContext != null ? (shareContext as IGraphicsContextInternal).Context : (ContextHandle)IntPtr.Zero;
                shareContextRef = shareHandle.Handle;
            }

            if (shareContextRef == IntPtr.Zero)
            {
                Debug.Print("No context sharing will take place.");
            }

            CreateContext(mode, carbonWindow, shareContextRef, true);
        }

        private void AddPixelAttrib(List<int> aglAttributes, Agl.PixelFormatAttribute pixelFormatAttribute)
        {
            Debug.Print(pixelFormatAttribute.ToString());

            aglAttributes.Add((int)pixelFormatAttribute);
        }

        private void AddPixelAttrib(List<int> aglAttributes, Agl.PixelFormatAttribute pixelFormatAttribute, int value)
        {
            Debug.Print("{0} : {1}", pixelFormatAttribute, value);

            aglAttributes.Add((int)pixelFormatAttribute);
            aglAttributes.Add(value);
        }

        private void CreateContext(GraphicsMode mode, IWindowInfo carbonWindow, IntPtr shareContextRef, bool fullscreen)
        {
            Debug.Print("AGL pixel format attributes:");


            // Choose a pixel format with the attributes we specified.
            AGLPixelFormat pixelformat;
            AglGraphicsMode selector = new AglGraphicsMode();
            Mode = selector.SelectGraphicsMode(
                mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples,
                mode.AccumulatorFormat, mode.Buffers, mode.Stereo,
                out pixelformat);
            MyAGLReportError("aglChoosePixelFormat");

            Debug.Print("Creating AGL context.  Sharing with {0}", shareContextRef);
            // create the context and share it with the share reference.
            Context = new ContextHandle(Agl.aglCreateContext(pixelformat, shareContextRef));
            MyAGLReportError("aglCreateContext");

            // Free the pixel format from memory.
            Agl.aglDestroyPixelFormat(pixelformat);
            MyAGLReportError("aglDestroyPixelFormat");

            SetDrawable(carbonWindow);
            SetBufferRect(carbonWindow);
            Update(carbonWindow);

            MakeCurrent(carbonWindow);
            Debug.Print("context: {0}", Context.Handle);

            dummyContext = new GraphicsContext(Context,
                GetAddress,
                delegate
                {
                    return new ContextHandle(Agl.aglGetCurrentContext());
                });
        }

        private void SetBufferRect(IWindowInfo carbonWindow)
        {
            Rect rect = API.GetControlBounds(carbonWindow.Handle);

            Debug.Print("Setting buffer_rect for control.");
            Debug.Print("MacOS Coordinate Rect:   {0}", rect);
            int[] glrect = new int[4];

            if (XOffset != null)
            {
                glrect[0] = rect.X + XOffset();
            }
            else
            {
                glrect[0] = rect.X;
            }
            if (YOffset != null)
            {
                glrect[1] = rect.Y + YOffset();
            }
            else
            {
                glrect[1] = rect.Y;
            }
            glrect[2] = rect.Width;
            glrect[3] = rect.Height;

            Agl.aglSetInteger(Context.Handle, Agl.ParameterNames.AGL_BUFFER_RECT, glrect);
            MyAGLReportError("aglSetInteger");

            Agl.aglEnable(Context.Handle, Agl.ParameterNames.AGL_BUFFER_RECT);
            MyAGLReportError("aglEnable");
        }

        private void SetDrawable(IWindowInfo carbonWindow)
        {
            IntPtr windowPort = GetWindowPortForWindowInfo(carbonWindow);
            //Debug.Print("Setting drawable for context {0} to window port: {1}", Handle.Handle, windowPort);
            Agl.aglSetDrawable(Context.Handle, windowPort);
            MyAGLReportError("aglSetDrawable");
        }

        private static IntPtr GetWindowPortForWindowInfo(IWindowInfo carbonWindow)
        {
            IntPtr windowPort;
            IntPtr controlOwner = API.GetControlOwner(carbonWindow.Handle);
            windowPort = API.GetWindowPort(controlOwner);

            return windowPort;
        }

        public void Update(IWindowInfo window)
        {
            SetDrawable(window);
            SetBufferRect(window);

            Agl.aglUpdateContext(Context.Handle);
        }

        private void MyAGLReportError(string function)
        {
            Agl.AglError err = Agl.GetError();

            if (err != Agl.AglError.NoError)
            {
                throw new Exception(String.Format(
                    "AGL Error from function {0}: {1}  {2}",
                    function, err, Agl.ErrorString(err)));
            }
        }

        private bool firstSwap = true;
        public void SwapBuffers()
        {
            // this is part of the hack to avoid dropping the first frame when
            // using multiple GLControls.
            if (firstSwap)
            {
                Debug.WriteLine("--> Resetting drawable. <--");
                firstSwap = false;
                SetDrawable(carbonWindow);
                Update(carbonWindow);
            }

            Agl.aglSwapBuffers(Context.Handle);
            MyAGLReportError("aglSwapBuffers");
        }

        public void MakeCurrent(IWindowInfo window)
        {
            if (Agl.aglSetCurrentContext(Context.Handle) == false)
            {
                MyAGLReportError("aglSetCurrentContext");
            }
        }

        public bool IsCurrent
        {
            get { return (Context.Handle == Agl.aglGetCurrentContext()); }
        }

        public int SwapInterval
        {
            get
            {
                int swap_interval = 0;
                if (Agl.aglGetInteger(Context.Handle, Agl.ParameterNames.AGL_SWAP_INTERVAL, out swap_interval))
                {
                    return swap_interval;
                }
                else
                {
                    MyAGLReportError("aglGetInteger");
                    return 0;
                }
            }
            set
            {
                if (!Agl.aglSetInteger(Context.Handle, Agl.ParameterNames.AGL_SWAP_INTERVAL, ref value))
                {
                    MyAGLReportError("aglSetInteger");
                }
            }
        }

        public GraphicsMode Mode { get; set; }

        public void LoadAll()
        {
            dummyContext.LoadAll();
        }

        public bool IsDisposed { get; private set; }

        public bool VSync
        {
            get
            {
                return SwapInterval != 0;
            }
            set
            {
                SwapInterval = value ? 1 : 0;
            }
        }

        public GraphicsMode GraphicsMode
        {
            get
            {
                return Mode;
            }
        }

        public bool ErrorChecking { get; set; }

        ~AglContext()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (IsDisposed || Context.Handle == IntPtr.Zero)
            {
                return;
            }

            Debug.Print("Disposing of AGL context.");
            Agl.aglSetCurrentContext(IntPtr.Zero);

            //Debug.Print("Setting drawable to null for context {0}.", Handle.Handle);
            //Agl.aglSetDrawable(Handle.Handle, IntPtr.Zero);

            // I do not know MacOS allows us to destroy a context from a separate thread,
            // like the finalizer thread.  It's untested, but worst case is probably
            // an exception on application exit, which would be logged to the console.

            // Actually, it seems to crash the mono runtime. -AMK 2013

            Debug.Print("Destroying context");
            if (Agl.aglDestroyContext(Context.Handle) == true)
            {
                Debug.Print("Context destruction completed successfully.");
                Context = ContextHandle.Zero;
                return;
            }

            // failed to destroy context.
            Debug.WriteLine("Failed to destroy context.");
            Debug.WriteLine(Agl.ErrorString(Agl.GetError()));

            // don't throw an exception from the finalizer thread.
            if (disposing)
            {
                throw new Exception(Agl.ErrorString(Agl.GetError()));
            }

            IsDisposed = true;
        }

        public IntPtr GetAddress(string function)
        {
            return NS.GetAddress(function);
        }

        public IntPtr GetAddress(IntPtr function)
        {
            return NS.GetAddress(function);
        }

        public IGraphicsContext Implementation
        {
            get
            {
                return this;
            }
        }

        public ContextHandle Context { get; private set; }
    }
}
