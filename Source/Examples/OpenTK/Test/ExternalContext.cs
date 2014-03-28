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
                var window = Sdl2.CreateWindow("Test", 0, 0, 640, 480, WindowFlags.AllowHighDpi | WindowFlags.OpenGL);
                var context = Sdl2.CreateContext(window);
                Sdl2.MakeCurrent(window, context);

                using (var dummy = new GraphicsContext(new ContextHandle(context), OpenTK.Platform.Utilities.CreateDummyWindowInfo()))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Sdl2.PumpEvents();
                        GL.ClearColor(i / 100.0f, i / 100.0f, i / 100.0f, i / 100.0f);
                        GL.Clear(ClearBufferMask.ColorBufferBit);

                        Sdl2.SwapWindow(window);
                    }

                    Sdl2.DestroyWindow(window);
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

    static class Sdl2
    {
        const string lib = "SDL2.dll";

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        public static extern IntPtr CreateWindow(string title, int x, int y, int w, int h, WindowFlags flags);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
        public static extern IntPtr CreateContext(IntPtr window);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        public static extern void DestroyWindow(IntPtr window);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
        public static extern IntPtr GetCurrentContext();

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
        public static extern IntPtr GetAddress(string name);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
        public static extern int MakeCurrent(IntPtr window, IntPtr context);

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        public static extern void PumpEvents();

        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
        public static extern void SwapWindow(IntPtr window);
    }

    #endregion

}
