// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.Tests
{
    [Example("External Context Test", ExampleCategory.OpenTK, "OpenGL")]
    class ExternalContext
    {
        public static void Main()
        {
            using (Toolkit.Init(new ToolkitOptions { Backend = PlatformBackend.PreferNative }))
            {
                // Create a window and context using a third-party toolkit
                // (in this case SDL2)
                var window = SDL.CreateWindow("Test", 0, 0, 640, 480,
                    WindowFlags.AllowHighDpi | WindowFlags.OpenGL);
                var context = SDL.GL.CreateContext(window);

                // The external context must be made current,
                // in order to correctly initialize OpenTK.Graphics
                SDL.GL.MakeCurrent(window, context);

                // Now we need to initialize OpenTK.Graphics using
                // the external context. This can be achieved in
                // two ways:
                //
                // var dummy = new GraphicsContext(ContextHandle.Zero, null);
                // -- or --
                // var dummy = new GraphicsContext(
                //     new ContextHandle(context),
                //     (name) => SDL.GL.GetAddress(name),
                //     () => new ContextHandle(SDL.GL.GetCurrentContext()));
                //
                // The first approach works only on Windows, Mac and Linux/X11.
                // 
                // The second approach will work on all platforms supported
                // by the external toolkit. This means that you can use
                // OpenTK.Graphics everywhere, even on platforms not directly
                // supported by OpenTK.

                using (var dummy = new GraphicsContext(
                    new ContextHandle(context),
                    SDL.GL.GetAddress,
                    () => new ContextHandle(SDL.GL.GetCurrentContext())))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        SDL.PumpEvents();
                        GL.ClearColor(i / 100.0f, i / 100.0f, i / 100.0f, i / 100.0f);
                        GL.Clear(ClearBufferMask.ColorBufferBit);

                        SDL.GL.SwapWindow(window);
                    }

                    SDL.DestroyWindow(window);
                }
            }
        }
    }

    #region SDL2 bindings

    public enum WindowFlags
    {
        Default = 0,
        OpenGL = 0x00000002,
        AllowHighDpi = 0x00002000,
    }

    static class SDL
    {
        const string lib = "SDL2.dll";

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        public static extern IntPtr CreateWindow(string title, int x, int y, int w, int h, WindowFlags flags);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        public static extern void DestroyWindow(IntPtr window);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        public static extern void PumpEvents();

        public static class GL
        {
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
            public static extern IntPtr CreateContext(IntPtr window);

            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
            public static extern IntPtr GetCurrentContext();

            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
            public static extern IntPtr GetAddress(string name);

            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
            public static extern int MakeCurrent(IntPtr window, IntPtr context);

            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
            public static extern void SwapWindow(IntPtr window);
        }
    }

    #endregion

}
