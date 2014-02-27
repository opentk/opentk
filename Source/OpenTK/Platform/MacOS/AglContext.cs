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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Graphics;

    using AGLRendererInfo = IntPtr;
    using AGLPixelFormat = IntPtr;
    using AGLContext = IntPtr;
    using AGLPbuffer = IntPtr;

    class AglContext : DesktopGraphicsContext
    {
        // Todo: keep track of which display adapter was specified when the context was created.
        // IntPtr displayID;

        CarbonWindowInfo carbonWindow;
        IntPtr shareContextRef;
        DisplayDevice device;
        bool mIsFullscreen = false;

        public AglContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext)
        {
            Debug.Print("Context Type: {0}", shareContext);
            Debug.Print("Window info: {0}", window);

            this.carbonWindow = (CarbonWindowInfo)window;
            
            if (shareContext is AglContext)
                shareContextRef = ((AglContext)shareContext).Handle.Handle;
            if (shareContext is GraphicsContext)
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

        public AglContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentException("handle");
            if (window == null)
                throw new ArgumentNullException("window");
            
            Handle = handle;
            carbonWindow = (CarbonWindowInfo)window;
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

        void CreateContext(GraphicsMode mode, CarbonWindowInfo carbonWindow, IntPtr shareContextRef, bool fullscreen)
        {
            Debug.Print("AGL pixel format attributes:");
            
            AGLPixelFormat myAGLPixelFormat;
            
            // Choose a pixel format with the attributes we specified.
            IntPtr gdevice;
            IntPtr cgdevice = GetQuartzDevice(carbonWindow);
                
            if (cgdevice == IntPtr.Zero)
                cgdevice = (IntPtr)DisplayDevice.Default.Id;
                
            OSStatus status = Carbon.API.DMGetGDeviceByDisplayID(cgdevice, out gdevice, false);
                
            if (status != OSStatus.NoError)
                throw new MacOSException(status, "DMGetGDeviceByDisplayID failed.");

            IGraphicsMode selector = new MacOSGraphicsMode(gdevice);
            Mode = selector.SelectGraphicsMode(
                mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples,
                mode.AccumulatorFormat, mode.Buffers, mode.Stereo);
            MyAGLReportError("aglChoosePixelFormat");

            Debug.Print("Creating AGL context.  Sharing with {0}", shareContextRef);
            myAGLPixelFormat = Mode.Index.Value;

            // create the context and share it with the share reference.
            Handle = new ContextHandle(Agl.aglCreateContext(myAGLPixelFormat, shareContextRef));
            MyAGLReportError("aglCreateContext");

            // Free the pixel format from memory.
            Agl.aglDestroyPixelFormat(myAGLPixelFormat);
            MyAGLReportError("aglDestroyPixelFormat");
            
            Debug.Print("IsControl: {0}", carbonWindow.IsControl);
            
            SetDrawable(carbonWindow);
            SetBufferRect(carbonWindow);
            Update(carbonWindow);
            
            MakeCurrent(carbonWindow);
            Debug.Print("context: {0}", Handle.Handle);
        }

        private IntPtr GetQuartzDevice(CarbonWindowInfo carbonWindow)
        {
            IntPtr windowRef = carbonWindow.Handle;
            
            if (CarbonGLNative.WindowRefMap.ContainsKey(windowRef) == false)
                return IntPtr.Zero;
            
            WeakReference nativeRef = CarbonGLNative.WindowRefMap[windowRef];
            if (nativeRef.IsAlive == false)
                return IntPtr.Zero;
            
            CarbonGLNative window = nativeRef.Target as CarbonGLNative;
            
            if (window == null)
                return IntPtr.Zero;
            
            return QuartzDisplayDeviceDriver.HandleTo(window.TargetDisplayDevice);
            
        }

        void SetBufferRect(CarbonWindowInfo carbonWindow)
        {
            if (carbonWindow.IsControl == false)
                return;

            Rect rect = API.GetControlBounds(carbonWindow.WindowHandle);
            
            Debug.Print("Setting buffer_rect for control.");
            Debug.Print("MacOS Coordinate Rect:   {0}", rect);
            int[] glrect = new int[4];

            if (carbonWindow.XOffset != null)
                glrect[0] = rect.X + carbonWindow.XOffset();
            else
                glrect[0] = rect.X;
            if (carbonWindow.YOffset != null)
                glrect[1] = rect.Y + carbonWindow.YOffset();
            else
                glrect[1] = rect.Y;
            glrect[2] = rect.Width;
            glrect[3] = rect.Height;
            
            Agl.aglSetInteger(Handle.Handle, Agl.ParameterNames.AGL_BUFFER_RECT, glrect);
            MyAGLReportError("aglSetInteger");
            
            Agl.aglEnable(Handle.Handle, Agl.ParameterNames.AGL_BUFFER_RECT);
            MyAGLReportError("aglEnable");
        }
        void SetDrawable(CarbonWindowInfo carbonWindow)
        {
            IntPtr windowPort = GetWindowPortForWindowInfo(carbonWindow);
            //Debug.Print("Setting drawable for context {0} to window port: {1}", Handle.Handle, windowPort);
            
            Agl.aglSetDrawable(Handle.Handle, windowPort);
            
            MyAGLReportError("aglSetDrawable");
            
        }

        private static IntPtr GetWindowPortForWindowInfo(CarbonWindowInfo carbonWindow)
        {
            IntPtr windowPort;
            if (carbonWindow.IsControl)
            {
                IntPtr controlOwner = API.GetControlOwner(carbonWindow.Handle);
                
                windowPort = API.GetWindowPort(controlOwner);
            }
            else
            {
                windowPort = API.GetWindowPort(carbonWindow.Handle);
            }

            return windowPort;
        }
        public override void Update(IWindowInfo window)
        {
            CarbonWindowInfo carbonWindow = (CarbonWindowInfo)window;
            
            if (carbonWindow.GoFullScreenHack)
            {
                carbonWindow.GoFullScreenHack = false;
                CarbonGLNative wind = GetCarbonWindow(carbonWindow);
                
                if (wind != null)
                    wind.SetFullscreen(this);
                else
                    Debug.Print("Could not find window!");
                
                return;
            }

            else if (carbonWindow.GoWindowedHack)
            {
                carbonWindow.GoWindowedHack = false;
                CarbonGLNative wind = GetCarbonWindow(carbonWindow);
                
                if (wind != null)
                    wind.UnsetFullscreen(this);
                else
                    Debug.Print("Could not find window!");
                
            }
            
            if (mIsFullscreen)
                return;
            
            SetDrawable(carbonWindow);
            SetBufferRect(carbonWindow);
            
            Agl.aglUpdateContext(Handle.Handle);
        }

        private CarbonGLNative GetCarbonWindow(CarbonWindowInfo carbonWindow)
        {
            WeakReference r = CarbonGLNative.WindowRefMap[carbonWindow.Handle];
            
            if (r.IsAlive)
            {
                return (CarbonGLNative)r.Target;
            }

            else
                return null;
        }

        void MyAGLReportError(string function)
        {
            Agl.AglError err = Agl.GetError();
            
            if (err != Agl.AglError.NoError)
                throw new MacOSException((OSStatus)err, string.Format("AGL Error from function {0}: {1}  {2}", function, err, Agl.ErrorString(err)));
        }

        bool firstFullScreen = false;

        internal void SetFullScreen(CarbonWindowInfo info, out int width, out int height)
        {
            CarbonGLNative wind = GetCarbonWindow(info);
            
            Debug.Print("Switching to full screen {0}x{1} on context {2}", wind.TargetDisplayDevice.Width, wind.TargetDisplayDevice.Height, Handle.Handle);
            
            CG.DisplayCapture(GetQuartzDevice(info));
            Agl.aglSetFullScreen(Handle.Handle, wind.TargetDisplayDevice.Width, wind.TargetDisplayDevice.Height, 0, 0);
            MakeCurrent(info);
            
            width = wind.TargetDisplayDevice.Width;
            height = wind.TargetDisplayDevice.Height;
            
            // This is a weird hack to workaround a bug where the first time a context
            // is made fullscreen, we just end up with a blank screen.  So we undo it as fullscreen
            // and redo it as fullscreen.  
            if (firstFullScreen == false)
            {
                firstFullScreen = true;
                UnsetFullScreen(info);
                SetFullScreen(info, out width, out height);
            }
            
            mIsFullscreen = true;
        }
        internal void UnsetFullScreen(CarbonWindowInfo windowInfo)
        {
            Debug.Print("Unsetting AGL fullscreen.");
            Agl.aglSetDrawable(Handle.Handle, IntPtr.Zero);
            Agl.aglUpdateContext(Handle.Handle);
            
            CG.DisplayRelease(GetQuartzDevice(windowInfo));
            Debug.Print("Resetting drawable.");
            SetDrawable(windowInfo);
            
            mIsFullscreen = false;
        }


        #region IGraphicsContext Members

        bool firstSwap = false;
        public override void SwapBuffers()
        {
            // this is part of the hack to avoid dropping the first frame when
            // using multiple GLControls.
            if (firstSwap == false && carbonWindow.IsControl)
            {
                Debug.WriteLine("--> Resetting drawable. <--");
                firstSwap = true;
                SetDrawable(carbonWindow);
                Update(carbonWindow);
            }
            
            Agl.aglSwapBuffers(Handle.Handle);
            MyAGLReportError("aglSwapBuffers");
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            if (Agl.aglSetCurrentContext(Handle.Handle) == false)
                MyAGLReportError("aglSetCurrentContext");
        }

        public override bool IsCurrent
        {
            get { return (Handle.Handle == Agl.aglGetCurrentContext()); }
        }

        public override int SwapInterval
        {
            get {
                int swap_interval = 0;
                if (Agl.aglGetInteger(Handle.Handle, Agl.ParameterNames.AGL_SWAP_INTERVAL, out swap_interval))
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
                if (!Agl.aglSetInteger(Handle.Handle, Agl.ParameterNames.AGL_SWAP_INTERVAL, ref value))
                    MyAGLReportError("aglSetInteger");
            }
        }

        #endregion

        #region IDisposable Members

        ~AglContext()
        {
            Dispose(false);
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        void Dispose(bool disposing)
        {
            if (IsDisposed || Handle.Handle == IntPtr.Zero)
                return;
            
            Debug.Print("Disposing of AGL context.");
            Agl.aglSetCurrentContext(IntPtr.Zero);
            
            //Debug.Print("Setting drawable to null for context {0}.", Handle.Handle);
            //Agl.aglSetDrawable(Handle.Handle, IntPtr.Zero);
            
            // I do not know MacOS allows us to destroy a context from a separate thread,
            // like the finalizer thread.  It's untested, but worst case is probably
            // an exception on application exit, which would be logged to the console.

            // Actually, it seems to crash the mono runtime. -AMK 2013

            Debug.Print("Destroying context");
            if (Agl.aglDestroyContext(Handle.Handle) == true)
            {
                Debug.Print("Context destruction completed successfully.");
                Handle = ContextHandle.Zero;
                return;
            }
            
            // failed to destroy context.
            Debug.WriteLine("Failed to destroy context.");
            Debug.WriteLine(Agl.ErrorString(Agl.GetError()));
            
            // don't throw an exception from the finalizer thread.
            if (disposing)
            {
                throw new MacOSException((OSStatus)Agl.GetError(), Agl.ErrorString(Agl.GetError()));
            }
            
            IsDisposed = true;
        }

        #endregion

        #region IGraphicsContextInternal Members

        public override IntPtr GetAddress(string function)
        {
            return NS.GetAddress(function);
        }

        public override IntPtr GetAddress(IntPtr function)
        {
            return NS.GetAddress(function);
        }

        #endregion
    }
}
