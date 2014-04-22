using System;
using OpenTK.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.MacOS;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenTK
{
    class CocoaContext : DesktopGraphicsContext
    {
        private CocoaWindowInfo cocoaWindow;
        private IntPtr shareContextRef;

        static readonly IntPtr NSOpenGLContext = Class.Get("NSOpenGLContext");
        static readonly IntPtr selCurrentContext = Selector.Get("currentContext");
        static readonly IntPtr selFlushBuffer = Selector.Get("flushBuffer");
        static readonly IntPtr selMakeCurrentContext = Selector.Get("makeCurrentContext");
        static readonly IntPtr selUpdate = Selector.Get("update");

        static CocoaContext()
        {
            Cocoa.Initialize();
        }

        public CocoaContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, int majorVersion, int minorVersion)
        {
            Debug.Print("Context Type: {0}", shareContext);
            Debug.Print("Window info: {0}", window);
            
            cocoaWindow = (CocoaWindowInfo)window;
            
            if (shareContext is CocoaContext)
                shareContextRef = ((CocoaContext)shareContext).Handle.Handle;

            if (shareContext is GraphicsContext)
            {
                ContextHandle shareHandle = shareContext != null ? (shareContext as IGraphicsContextInternal).Context : (ContextHandle)IntPtr.Zero;
                shareContextRef = shareHandle.Handle;
            }

            if (shareContextRef == IntPtr.Zero)
            {
                Debug.Print("No context sharing will take place.");
            }
            
            CreateContext(mode, cocoaWindow, shareContextRef, majorVersion, minorVersion, true);
        }
        
        public CocoaContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, int majorVersion, int minorVersion)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentException("handle");
            if (window == null)
                throw new ArgumentNullException("window");
            
            Handle = handle;
            cocoaWindow = (CocoaWindowInfo)window;
        }

        private void AddPixelAttrib(List<NSOpenGLPixelFormatAttribute> attributes, NSOpenGLPixelFormatAttribute attribute)
        {
            Debug.Print(attribute.ToString());
            
            attributes.Add(attribute);
        }

        private void AddPixelAttrib(List<NSOpenGLPixelFormatAttribute> attributes, NSOpenGLPixelFormatAttribute attribute, int value)
        {
            Debug.Print("{0} : {1}", attribute, value);
            
            attributes.Add(attribute);
            attributes.Add((NSOpenGLPixelFormatAttribute)value);
        }

        private void CreateContext(GraphicsMode mode, CocoaWindowInfo cocoaWindow, IntPtr shareContextRef, int majorVersion, int minorVersion, bool fullscreen)
        {
            // Prepare attributes
            List<NSOpenGLPixelFormatAttribute> attributes = new List<NSOpenGLPixelFormatAttribute>();

            var profile = NSOpenGLProfile.VersionLegacy;
            if (majorVersion > 3 || (majorVersion == 3 && minorVersion >= 2))
            {
                profile = NSOpenGLProfile.Version3_2Core;
                Debug.Print("Running the OpenGL core profile.");
            }
            else
            {
                Debug.Print("Running the legacy OpenGL profile. Start with version major=3, minor=2 or later for the 3.2 profile.");
            }

            Debug.Print("NSGL pixel format attributes:");
            Debug.Indent();

            AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.OpenGLProfile, (int)profile);
            AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.DoubleBuffer);
            AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.Accelerated);
            AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.ColorSize, mode.ColorFormat.BitsPerPixel);

            if (mode.Depth > 0)
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.DepthSize, mode.Depth);
            
            if (mode.Stencil > 0)
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.StencilSize, mode.Stencil);

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.AccumSize, mode.AccumulatorFormat.BitsPerPixel);
            }
            
            if (mode.Samples > 1)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.SampleBuffers, 1);
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.Samples, mode.Samples);
            }

            AddPixelAttrib(attributes, (NSOpenGLPixelFormatAttribute)0);
            
            Debug.Unindent();
            
            Debug.Write("Attribute array:  ");
            for (int i = 0; i < attributes.Count; i++)
                Debug.Write(attributes[i].ToString() + "  ");
            Debug.WriteLine("");

            // Create pixel format
            var pixelFormat = Cocoa.SendIntPtr(Class.Get("NSOpenGLPixelFormat"), Selector.Alloc);

            unsafe 
            {
                fixed (NSOpenGLPixelFormatAttribute* ptr = attributes.ToArray())
                {
                    pixelFormat = Cocoa.SendIntPtr(pixelFormat, Selector.Get("initWithAttributes:"), (IntPtr)ptr);
                }
            }

            // Create context
            var context = Cocoa.SendIntPtr(NSOpenGLContext, Selector.Alloc);
            context = Cocoa.SendIntPtr(context, Selector.Get("initWithFormat:shareContext:"), pixelFormat, shareContextRef);

            // Release pixel format
            Cocoa.SendVoid(pixelFormat, Selector.Release);
            pixelFormat = IntPtr.Zero;

            // Attach the view
            Cocoa.SendVoid(context, Selector.Get("setView:"), cocoaWindow.ViewHandle);
            Cocoa.SendVoid(cocoaWindow.ViewHandle, Selector.Get("setWantsBestResolutionOpenGLSurface:"), true);

            // Finalize
            Handle = new ContextHandle(context);
            Mode = mode;
            Update(cocoaWindow);
            MakeCurrent(cocoaWindow);
        }

        public override void SwapBuffers()
        {
            Cocoa.SendVoid(Handle.Handle, selFlushBuffer);
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            Cocoa.SendVoid(Handle.Handle, selMakeCurrentContext);
        }

        public override bool IsCurrent
        { 
            get
            {
                return Handle.Handle == CurrentContext;
            }
        }

        public static IntPtr CurrentContext
        {
            get
            {
                return Cocoa.SendIntPtr(NSOpenGLContext, selCurrentContext);
            }
        }

        private unsafe void SetContextValue (int val, NSOpenGLContextParameter par)
        {
            int* p = &val;
            Cocoa.SendVoid(Handle.Handle, Selector.Get("setValues:forParameter:"), (IntPtr)p, (int)par);
        }

        private unsafe int GetContextValue (NSOpenGLContextParameter par)
        {
            int ret;
            int* p = &ret;
            Cocoa.SendVoid(Handle.Handle, Selector.Get("getValues:forParameter:"), (IntPtr)p, (int)par);
            return ret;
        }

        public override int SwapInterval
        { 
            get
            {
                return GetContextValue(NSOpenGLContextParameter.SwapInterval);
            }
            set
            {
                SetContextValue(value, NSOpenGLContextParameter.SwapInterval);
            }
        }

        public override void Update(IWindowInfo window)
        {
            Cocoa.SendVoid(Handle.Handle, selUpdate);
        }

        #region IDisposable Members

        ~CocoaContext()
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

            Debug.Print("Disposing of Cocoa context.");

            Cocoa.SendVoid(NSOpenGLContext, Selector.Get("clearCurrentContext"));
            Cocoa.SendVoid(Handle.Handle, Selector.Get("clearDrawable"));
            Cocoa.SendVoid(Handle.Handle, Selector.Get("release"));

            Handle = ContextHandle.Zero;

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

