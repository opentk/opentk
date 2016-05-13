﻿#region License
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
using System.Text;
using System.Diagnostics;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    // Holds information about an EGL window.
    class EglWindowInfo : IWindowInfo
    {
        #region Fields

        IntPtr handle;
        IntPtr display;
        IntPtr surface;
        bool disposed;

        #endregion

        #region Constructors

        public EglWindowInfo(IntPtr handle, IntPtr display)
            : this(handle, display, IntPtr.Zero)
        {
        }

        public EglWindowInfo(IntPtr handle, IntPtr display, IntPtr surface)
        {
            Handle = handle;
            Surface = surface;

            if (display == IntPtr.Zero)
            {
                display = Egl.GetDisplay(IntPtr.Zero);
            }

            Display = display;

            int dummy_major, dummy_minor;
            if (!Egl.Initialize(Display, out dummy_major, out dummy_minor))
            {
                throw new GraphicsContextException(String.Format("Failed to initialize EGL, error {0}.", Egl.GetError()));
            }
        }

        #endregion

        #region Public Members

        public IntPtr Handle { get { return handle; } set { handle = value; } }

        public IntPtr Display { get { return display; } private set { display = value; } }

        public IntPtr Surface { get { return surface; } private set { surface = value; } }

        public void CreateWindowSurface(IntPtr config)
        {
            Surface = Egl.CreateWindowSurface(Display, config, Handle, IntPtr.Zero);
			if (Surface==IntPtr.Zero)
			{
                throw new GraphicsContextException(String.Format(
                    "[EGL] Failed to create window surface, error {0}.", Egl.GetError()));
			}
        }

        //public void CreatePixmapSurface(EGLConfig config)
        //{
        //    Surface = Egl.CreatePixmapSurface(Display, config, Handle, null);
        //}

        public void CreatePbufferSurface(IntPtr config)
        {
            int[] attribs = new int[]{Egl.NONE};
            Surface = Egl.CreatePbufferSurface(Display, config, attribs);
            if (Surface == IntPtr.Zero)
            {
                throw new GraphicsContextException(String.Format(
                    "[EGL] Failed to create pbuffer surface, error {0}.", Egl.GetError()));
            }
        }

        public void CreatePbufferSurface(IntPtr config, int width, int height)
        {
            if (surface != IntPtr.Zero)
            {
                DestroySurface();
            }
            CreatePbufferSurface(config, width, height, out surface); 
        }

        public void CreatePbufferSurface(IntPtr config, int width, int height, out IntPtr surface_)
        {
            int[] attribs = new int[]
            {
                Egl.WIDTH, width,
                Egl.HEIGHT, height,
                Egl.TEXTURE_TARGET, Egl.TEXTURE_2D,
                Egl.TEXTURE_FORMAT, Egl.TEXTURE_RGBA,
                Egl.NONE
            };
            surface_ = Egl.CreatePbufferSurface(Display, config, attribs);
            if (surface_ == IntPtr.Zero)
            {
                throw new GraphicsContextException(String.Format(
                    "[EGL] Failed to create pbuffer surface, error {0}.", Egl.GetError()));
            }

        }

        public void DestroySurface()
        {
            DestroySurface(ref surface);
        }

        public void DestroySurface(ref IntPtr surface_)
        {
            if (surface_ == IntPtr.Zero)
            {
                return;
            }

            if (Egl.DestroySurface(Display, surface_))
            {
                surface_ = IntPtr.Zero;
                return;
            }
            Debug.Print("[Warning] Failed to destroy {0}:{1}.", Surface.GetType().Name, Surface);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    DestroySurface();
                    disposed = true;
                }
                else
                {
                    Debug.Print("[Warning] Failed to destroy {0}:{1}.", this.GetType().Name, Handle);
                }
            }
        }

        ~EglWindowInfo()
        {
            Dispose(false);
        }

        #endregion
    }
}
