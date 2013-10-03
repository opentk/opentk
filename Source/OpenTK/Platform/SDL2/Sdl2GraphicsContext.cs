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
                    SDL.SDL_CreateWindowFrom(window.Handle),
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
                SetGLAttributes(mode, shareContext, major, minor, flags);
                SdlContext = new ContextHandle(SDL.SDL_GL_CreateContext(Window.Handle));
            }
            if (SdlContext == ContextHandle.Zero)
            {
                var error = SDL.SDL_GetError();
                Debug.Print("SDL2 failed to create OpenGL context: {0}", error);
                throw new GraphicsContextException(error);
            }
            Handle = GraphicsContext.GetCurrentContext();
        }

        #region Private Members

        void SetGLAttributes(GraphicsMode mode,
            IGraphicsContext shareContext,
            int major, int minor,
            GraphicsContextFlags flags)
        {
            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_ACCUM_ALPHA_SIZE, mode.AccumulatorFormat.Alpha);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_ACCUM_RED_SIZE, mode.AccumulatorFormat.Red);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_ACCUM_GREEN_SIZE, mode.AccumulatorFormat.Green);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_ACCUM_BLUE_SIZE, mode.AccumulatorFormat.Blue);
            }

            if (mode.Buffers > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_DOUBLEBUFFER, mode.Buffers > 1 ? 1 : 0);
            }

            if (mode.ColorFormat > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_ALPHA_SIZE, mode.ColorFormat.Alpha);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_RED_SIZE, mode.ColorFormat.Red);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_GREEN_SIZE, mode.ColorFormat.Green);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_BLUE_SIZE, mode.ColorFormat.Blue);
            }

            if (mode.Depth > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_DEPTH_SIZE, mode.Depth);
            }

            if (mode.Samples > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_MULTISAMPLEBUFFERS, 1);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_MULTISAMPLESAMPLES, mode.Samples);
            }

            if (mode.Stencil > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_STENCIL_SIZE, mode.Stereo ? 1 : 0);
            }

            if (mode.Stereo)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_STEREO, 1);
            }

            if (major > 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, major);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, minor);
            }

            if ((flags & GraphicsContextFlags.Debug) != 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)SDL.SDL_GLcontext.SDL_GL_CONTEXT_DEBUG_FLAG);
            }

            if ((flags & GraphicsContextFlags.Embedded) != 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_EGL, 1);
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_PROFILE_MASK, (int)SDL.SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_ES);
            }

            if ((flags & GraphicsContextFlags.ForwardCompatible) != 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_PROFILE_MASK, (int)SDL.SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_CORE);
            }

            /*
            if ((flags & GraphicsContextFlags.Robust) != 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)SDL.SDL_GLcontext.SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG);
            }

            if ((flags & GraphicsContextFlags.ResetIsolation) != 0)
            {
                SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)SDL.SDL_GLcontext.SDL_GL_CONTEXT_RESET_ISOLATION_FLAG);
            }
            */

            if (shareContext != null)
            {
                if (shareContext.IsCurrent)
                {
                    SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_SHARE_WITH_CURRENT_CONTEXT, 1);
                }
                else
                {
                    Trace.WriteLine("Warning: SDL2 requires a shared context to be current before sharing. Sharing failed.");
                }
            }
        }

        #endregion

        #region GraphicsContextBase Members

        public override void SwapBuffers()
        {
            SDL.SDL_GL_SwapWindow(Window.Handle);
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            int result = 0;
            if (window != null)
            {
                result = SDL.SDL_GL_MakeCurrent(window.Handle, SdlContext.Handle);
            }
            else
            {
                result = SDL.SDL_GL_MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }

            if (result < 0)
            {
                Debug.Print("SDL2 MakeCurrent failed with: {0}", SDL.SDL_GetError());
            }
        }

        public override IntPtr GetAddress(string function)
        {
            return SDL.SDL_GL_GetProcAddress(function);
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
                return SDL.SDL_GL_GetSwapInterval();
            }
            set
            {
                if (SDL.SDL_GL_SetSwapInterval(value) < 0)
                {
                    Debug.Print("SDL2 failed to set swap interval: {0}", SDL.SDL_GetError());
                }
            }
        }

        #endregion

        #region IDisposable Members

        void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    Debug.Print("Disposing {0}", GetType());
                    lock (SDL.Sync)
                    {
                        SDL.SDL_GL_DeleteContext(SdlContext.Handle);
                    }
                }
                else
                {
                    Debug.WriteLine("Sdl2GraphicsContext leaked, did you forget to call Dispose()?");
                }
                IsDisposed = true;
            }
        }

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Sdl2GraphicsContext()
        {
            Dispose(false);
        }

        #endregion
    }
}

