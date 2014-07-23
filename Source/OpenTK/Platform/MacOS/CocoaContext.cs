#region License
//
// CocoaContext.cs
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
        static readonly IntPtr opengl = NS.AddImage(
            "/System/Library/Frameworks/OpenGL.framework/OpenGL",
            AddImageFlags.ReturnOnError);
        static readonly IntPtr opengles = NS.AddImage(
            "/System/Library/Frameworks/OpenGL.framework/OpenGLES",
            AddImageFlags.ReturnOnError);

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
            IntPtr pixelFormat = SelectPixelFormat(mode, majorVersion, minorVersion);
            if (pixelFormat == IntPtr.Zero)
            {
                throw new GraphicsException(String.Format(
                    "Failed to contruct NSOpenGLPixelFormat for GraphicsMode '{0}'",
                    mode));
            }

            // Create context
            var context = Cocoa.SendIntPtr(NSOpenGLContext, Selector.Alloc);
            context = Cocoa.SendIntPtr(context, Selector.Get("initWithFormat:shareContext:"), pixelFormat, shareContextRef);
            if (context == IntPtr.Zero)
            {
                throw new GraphicsException(String.Format(
                    "Failed to construct NSOpenGLContext",
                    mode));
            }

            // Release pixel format
            Cocoa.SendVoid(pixelFormat, Selector.Release);
            pixelFormat = IntPtr.Zero;

            // Attach the view
            Cocoa.SendVoid(context, Selector.Get("setView:"), cocoaWindow.ViewHandle);
            Cocoa.SendVoid(cocoaWindow.ViewHandle, Selector.Get("setWantsBestResolutionOpenGLSurface:"), true);

            // Finalize
            Handle = new ContextHandle(context);
            Mode = GetGraphicsMode(context);

            Update(cocoaWindow);
            MakeCurrent(cocoaWindow);
        }

        private IntPtr SelectPixelFormat(GraphicsMode mode, int majorVersion, int minorVersion)
        {
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

            if (mode.ColorFormat.BitsPerPixel > 0)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.ColorSize, mode.ColorFormat.BitsPerPixel);
            }

            if (mode.Depth > 0)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.DepthSize, mode.Depth);
            }

            if (mode.Stencil > 0)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.StencilSize, mode.Stencil);
            }

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.AccumSize, mode.AccumulatorFormat.BitsPerPixel);
            }

            if (mode.Samples > 1)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.SampleBuffers, 1);
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.Samples, mode.Samples);
            }

            if (mode.Buffers > 1)
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.DoubleBuffer);
            }

            // If at least a single accelerated pixel format is available,
            // then use that. If no accelerated formats are available, fall
            // back to software rendering.
            if (IsAccelerationSupported())
            {
                AddPixelAttrib(attributes, NSOpenGLPixelFormatAttribute.Accelerated);
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

            return pixelFormat;
        }

        bool IsAccelerationSupported()
        {
            IntPtr pf = IntPtr.Zero;
            int count = 0;
            Cgl.ChoosePixelFormat(new int[] { (int)Cgl.PixelFormatBool.Accelerated, 0 },
                ref pf, ref count);

            if (pf != IntPtr.Zero)
            {
                Cgl.DestroyPixelFormat(pf);
            }

            return pf != IntPtr.Zero;
        }

        private GraphicsMode GetGraphicsMode(IntPtr context)
        {
            IntPtr cgl_context = Cocoa.SendIntPtr(context, Selector.Get("CGLContextObj"));
            IntPtr cgl_format = Cgl.GetPixelFormat(cgl_context);

            int id = 0; // CGL does not support the concept of a pixel format id
            int color, depth, stencil, samples, accum;
            bool doublebuffer, stereo;
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatInt.ColorSize, out color);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatInt.DepthSize, out depth);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatInt.StencilSize, out stencil);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatInt.Samples, out samples);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatInt.AccumSize, out accum);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatBool.Doublebuffer, out doublebuffer);
            Cgl.DescribePixelFormat(cgl_format, 0, Cgl.PixelFormatBool.Stereo, out stereo);

            return new GraphicsMode((IntPtr)id, color, depth, stencil, samples, accum, doublebuffer ? 2 : 1, stereo);
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
                if (value < 0)
                {
                    // NSOpenGL does not offer EXT_swap_control_tear yet
                    value = 1;
                }
                SetContextValue(value, NSOpenGLContextParameter.SwapInterval);
            }
        }

        public override void Update(IWindowInfo window)
        {
            Cocoa.SendVoid(Handle.Handle, selUpdate);
        }

        #region IDisposable Members

        protected override void Dispose(bool disposing)
        {
            if (IsDisposed || Handle.Handle == IntPtr.Zero)
                return;

            Debug.Print("Disposing of Cocoa context.");

            if (!NSApplication.IsUIThread)
                return;

            Cocoa.SendVoid(NSOpenGLContext, Selector.Get("clearCurrentContext"));
            Cocoa.SendVoid(Handle.Handle, Selector.Get("clearDrawable"));
            Cocoa.SendVoid(Handle.Handle, Selector.Get("release"));

            Handle = ContextHandle.Zero;

            IsDisposed = true;
        }

        #endregion

        #region IGraphicsContextInternal Members

        public override IntPtr GetAddress(IntPtr function)
        {
            unsafe
            {
                // Add a leading underscore to the function name
                // As of OpenGL 4.4, all functions are < 64 bytes
                // in length. Double that just to be sure.
                const int max = 128;
                byte* fun = stackalloc byte[max];
                byte* ptr = fun;
                byte* cur = (byte*)function.ToPointer();
                int i = 0;

                *ptr++ = (byte)'_';
                while (*cur != 0 && ++i < max)
                {
                    *ptr++ = *cur++;
                }

                if (i >= max - 1)
                {
                    Debug.Print("Function {0} too long. Loading will fail.",
                        Marshal.PtrToStringAnsi(function));
                }

                IntPtr address = IntPtr.Zero;
                IntPtr symbol = IntPtr.Zero;
                if (opengl != IntPtr.Zero)
                {
                    symbol = NS.LookupSymbolInImage(opengl, new IntPtr(fun),
                        SymbolLookupFlags.Bind | SymbolLookupFlags.ReturnOnError);
                }
                if (symbol == IntPtr.Zero && opengles != IntPtr.Zero)
                {
                    symbol = NS.LookupSymbolInImage(opengles, new IntPtr(fun),
                        SymbolLookupFlags.Bind | SymbolLookupFlags.ReturnOnError);
                }
                if (symbol != IntPtr.Zero)
                {
                    address = NS.AddressOfSymbol(symbol);
                }
                return address;
            }
        }

        #endregion
    }
}

