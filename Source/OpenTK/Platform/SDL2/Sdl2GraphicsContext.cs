#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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
using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics;

namespace OpenTK.Platform.SDL2
{
    class Sdl2GraphicsContext : DesktopGraphicsContext
    {
        IWindowInfo Window { get; set; }
        ContextHandle SdlContext { get; set; }

        Sdl2GraphicsContext(IWindowInfo window)
        {
            // It is possible to create a GraphicsContext on a window
            // that is not owned by SDL (e.g. a GLControl). In that case,
            // we need to use SDL_CreateWindowFrom in order to
            // convert the foreign window to a SDL window.
            if (window is Sdl2WindowInfo)
            {
                Window = window;
            }
            else
            {
                Window = new Sdl2WindowInfo(
                    SDL.CreateWindowFrom(window.Handle),
                    null);
            }
        }

        public Sdl2GraphicsContext(GraphicsMode mode,
            IWindowInfo win, IGraphicsContext shareContext,
            int major, int minor,
            OpenTK.Graphics.GraphicsContextFlags flags)
            : this(win)
        {
            lock (SDL.Sync)
            {
                bool retry = false;
                do
                {
                    SetGLAttributes(mode, shareContext, major, minor, flags);
                    SdlContext = new ContextHandle(SDL.GL.CreateContext(Window.Handle));

                    // If we failed to create a valid context, relax the GraphicsMode
                    // and try again.
                    retry =
                        SdlContext == ContextHandle.Zero &&
                        Utilities.RelaxGraphicsMode(ref mode);
                }
                while (retry);

                if (SdlContext == ContextHandle.Zero)
                {
                    var error = SDL.GetError();
                    Debug.Print("SDL2 failed to create OpenGL context: {0}", error);
                    throw new GraphicsContextException(error);
                }

                Mode = GetGLAttributes(SdlContext, out flags);
            }
            Handle = GraphicsContext.GetCurrentContext();
            Debug.Print("SDL2 created GraphicsContext (handle: {0})", Handle);
            Debug.Print("    GraphicsMode: {0}", Mode);
            Debug.Print("    GraphicsContextFlags: {0}", flags);
        }

        #region Private Members

        static GraphicsMode GetGLAttributes(ContextHandle sdlContext, out GraphicsContextFlags context_flags)
        {
            context_flags = 0;

            int accum_red, accum_green, accum_blue, accum_alpha;
            SDL.GL.GetAttribute(ContextAttribute.ACCUM_RED_SIZE, out accum_red);
            SDL.GL.GetAttribute(ContextAttribute.ACCUM_GREEN_SIZE, out accum_green);
            SDL.GL.GetAttribute(ContextAttribute.ACCUM_BLUE_SIZE, out accum_blue);
            SDL.GL.GetAttribute(ContextAttribute.ACCUM_ALPHA_SIZE, out accum_alpha);

            int buffers;
            SDL.GL.GetAttribute(ContextAttribute.DOUBLEBUFFER, out buffers);
            // DOUBLEBUFFER return a boolean (0-false, 1-true), so we need
            // to adjust the buffer count (false->1 buffer, true->2 buffers)
            buffers++;

            int red, green, blue, alpha;
            SDL.GL.GetAttribute(ContextAttribute.RED_SIZE, out red);
            SDL.GL.GetAttribute(ContextAttribute.GREEN_SIZE, out green);
            SDL.GL.GetAttribute(ContextAttribute.BLUE_SIZE, out blue);
            SDL.GL.GetAttribute(ContextAttribute.ALPHA_SIZE, out alpha);

            int depth, stencil;
            SDL.GL.GetAttribute(ContextAttribute.DEPTH_SIZE, out depth);
            SDL.GL.GetAttribute(ContextAttribute.STENCIL_SIZE, out stencil);

            int samples;
            SDL.GL.GetAttribute(ContextAttribute.MULTISAMPLESAMPLES, out samples);

            int stereo;
            SDL.GL.GetAttribute(ContextAttribute.STEREO, out stereo);

            int major, minor;
            SDL.GL.GetAttribute(ContextAttribute.CONTEXT_MAJOR_VERSION, out major);
            SDL.GL.GetAttribute(ContextAttribute.CONTEXT_MINOR_VERSION, out minor);

            int flags;
            SDL.GL.GetAttribute(ContextAttribute.CONTEXT_FLAGS, out flags);

            int egl;
            SDL.GL.GetAttribute(ContextAttribute.CONTEXT_EGL, out egl);

            int profile;
            SDL.GL.GetAttribute(ContextAttribute.CONTEXT_PROFILE_MASK, out profile);

            if (egl != 0 && (profile & (int)ContextProfileFlags.ES) != 0)
            {
                context_flags |= GraphicsContextFlags.Embedded;
            }

            if ((flags & (int)ContextFlags.DEBUG) != 0)
            {
                context_flags |= GraphicsContextFlags.Debug;
            }

            if ((profile & (int)ContextProfileFlags.CORE) != 0)
            {
                context_flags |= GraphicsContextFlags.ForwardCompatible;
            }

            return new GraphicsMode(
                new ColorFormat(red, green, blue, alpha),
                depth,
                stencil,
                samples,
                new ColorFormat(accum_red, accum_green, accum_blue, accum_alpha),
                buffers,
                stereo != 0 ? true : false);
        }

        static void ClearGLAttributes()
        {
            SDL.GL.SetAttribute(ContextAttribute.ACCUM_ALPHA_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.ACCUM_RED_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.ACCUM_GREEN_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.ACCUM_BLUE_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.DOUBLEBUFFER, 0);
            SDL.GL.SetAttribute(ContextAttribute.ALPHA_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.RED_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.GREEN_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.BLUE_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.DEPTH_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.MULTISAMPLEBUFFERS, 0);
            SDL.GL.SetAttribute(ContextAttribute.MULTISAMPLESAMPLES, 0);
            SDL.GL.SetAttribute(ContextAttribute.STENCIL_SIZE, 0);
            SDL.GL.SetAttribute(ContextAttribute.STEREO, 0);
            SDL.GL.SetAttribute(ContextAttribute.CONTEXT_MAJOR_VERSION, 1);
            SDL.GL.SetAttribute(ContextAttribute.CONTEXT_MINOR_VERSION, 0);
            SDL.GL.SetAttribute(ContextAttribute.CONTEXT_FLAGS, 0);
            SDL.GL.SetAttribute(ContextAttribute.CONTEXT_EGL, 0);
            SDL.GL.SetAttribute(ContextAttribute.CONTEXT_PROFILE_MASK, 0);
            SDL.GL.SetAttribute(ContextAttribute.SHARE_WITH_CURRENT_CONTEXT, 0);
        }

        static void SetGLAttributes(GraphicsMode mode,
            IGraphicsContext shareContext,
            int major, int minor,
            GraphicsContextFlags flags)
        {
            ContextProfileFlags cpflags = 0;
            ClearGLAttributes();

            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.ACCUM_ALPHA_SIZE, mode.AccumulatorFormat.Alpha);
                SDL.GL.SetAttribute(ContextAttribute.ACCUM_RED_SIZE, mode.AccumulatorFormat.Red);
                SDL.GL.SetAttribute(ContextAttribute.ACCUM_GREEN_SIZE, mode.AccumulatorFormat.Green);
                SDL.GL.SetAttribute(ContextAttribute.ACCUM_BLUE_SIZE, mode.AccumulatorFormat.Blue);
            }

            if (mode.Buffers > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.DOUBLEBUFFER, mode.Buffers > 1 ? 1 : 0);
            }

            if (mode.ColorFormat > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.ALPHA_SIZE, mode.ColorFormat.Alpha);
                SDL.GL.SetAttribute(ContextAttribute.RED_SIZE, mode.ColorFormat.Red);
                SDL.GL.SetAttribute(ContextAttribute.GREEN_SIZE, mode.ColorFormat.Green);
                SDL.GL.SetAttribute(ContextAttribute.BLUE_SIZE, mode.ColorFormat.Blue);
            }

            if (mode.Depth > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.DEPTH_SIZE, mode.Depth);
            }

            if (mode.Samples > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.MULTISAMPLEBUFFERS, 1);
                SDL.GL.SetAttribute(ContextAttribute.MULTISAMPLESAMPLES, mode.Samples);
            }

            if (mode.Stencil > 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.STENCIL_SIZE, mode.Stereo ? 1 : 0);
            }

            if (mode.Stereo)
            {
                SDL.GL.SetAttribute(ContextAttribute.STEREO, 1);
            }

            if (major > 0)
            {
                // Workaround for https://github.com/opentk/opentk/issues/44
                // Mac OS X desktop OpenGL 3.x/4.x contexts require require
                // ContextProfileFlags.Core, otherwise they will fail to construct.
                if (Configuration.RunningOnMacOS && major >= 3 &&
                    (flags & GraphicsContextFlags.Embedded) == 0)
                {
                    cpflags |= ContextProfileFlags.CORE;

                    // According to https://developer.apple.com/graphicsimaging/opengl/capabilities/GLInfo_1075_Core.html
                    // Mac OS X supports 3.2+. Indeed, requesting 3.0 or 3.1 results in failure.
                    if (major == 3 && minor < 2)
                    {
                        minor = 2;
                    }
                }

                SDL.GL.SetAttribute(ContextAttribute.CONTEXT_MAJOR_VERSION, major);
                SDL.GL.SetAttribute(ContextAttribute.CONTEXT_MINOR_VERSION, minor);
            }

            if ((flags & GraphicsContextFlags.Debug) != 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.CONTEXT_FLAGS, ContextFlags.DEBUG);
            }

            /*
            if ((flags & GraphicsContextFlags.Robust) != 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.CONTEXT_FLAGS, ContextFlags.ROBUST_ACCESS_FLAG);
            }

            if ((flags & GraphicsContextFlags.ResetIsolation) != 0)
            {
                SDL.GL.SetAttribute(ContextAttribute.CONTEXT_FLAGS, ContextFlags.RESET_ISOLATION_FLAG);
            }
            */

            {
                if ((flags & GraphicsContextFlags.Embedded) != 0)
                {
                    cpflags |= ContextProfileFlags.ES;
                    SDL.GL.SetAttribute(ContextAttribute.CONTEXT_EGL, 1);
                }

                if ((flags & GraphicsContextFlags.ForwardCompatible) != 0)
                {
                    cpflags |= ContextProfileFlags.CORE;
                }

                if (cpflags != 0)
                {
                    SDL.GL.SetAttribute(ContextAttribute.CONTEXT_PROFILE_MASK, cpflags);
                }
            }

            if (shareContext != null)
            {
                if (shareContext.IsCurrent)
                {
                    SDL.GL.SetAttribute(ContextAttribute.SHARE_WITH_CURRENT_CONTEXT, 1);
                }
                else
                {
                    Trace.WriteLine("Warning: SDL2 requires a shared context to be current before sharing. Sharing failed.");
                }
            }
        }

        #endregion

        #region Public Members

        public static ContextHandle GetCurrentContext()
        {
            return new ContextHandle(SDL.GL.GetCurrentContext());
        }

        #endregion

        #region GraphicsContextBase Members

        public override void SwapBuffers()
        {
            SDL.GL.SwapWindow(Window.Handle);
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            int result = 0;
            if (window != null)
            {
                result = SDL.GL.MakeCurrent(window.Handle, SdlContext.Handle);
            }
            else
            {
                result = SDL.GL.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }

            if (result < 0)
            {
                Debug.Print("SDL2 MakeCurrent failed with: {0}", SDL.GetError());
            }
        }

        public override IntPtr GetAddress(IntPtr function)
        {
            return SDL.GL.GetProcAddress(function);
        }

        public override bool IsCurrent
        {
            get
            {
                return GraphicsContext.GetCurrentContext() == Context;
            }
        }

        public override int SwapInterval
        {
            get
            {
                return SDL.GL.GetSwapInterval();
            }
            set
            {
                if (SDL.GL.SetSwapInterval(value) < 0)
                {
                    Debug.Print("SDL2 failed to set swap interval: {0}", SDL.GetError());
                }
            }
        }

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    Debug.Print("Disposing {0} (handle: {1})", GetType(), Handle);
                    lock (SDL.Sync)
                    {
                        SDL.GL.DeleteContext(SdlContext.Handle);
                    }
                }
                else
                {
                    Debug.Print("Sdl2GraphicsContext (handle: {0}) leaked, did you forget to call Dispose()?",
                        Handle);
                }
                IsDisposed = true;
            }
        }

        #endregion
    }
}

