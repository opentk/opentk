using OpenTK.Platform.Native.Windows;
using OpenTK.Platform.Native.X11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.SDL
{
    internal static class SDL
    {
        // FIXME: Make cross-platform and cross architecture.
        // FIXME: Make a nuget package for this.
        const string SDLLib = "SDL2-x64";

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_Init(SDL_INIT flags);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_Quit();

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.LPUTF8Str)]
        internal static extern string SDL_GetError();

        internal unsafe struct SDL_WindowPtr : IEquatable<SDL_WindowPtr>
        {
            public static SDL_WindowPtr Null => new SDL_WindowPtr(null);

            public nuint Window;

            public SDL_WindowPtr(void* window)
            {
                Window = (nuint)window;
            }

            public override bool Equals(object? obj)
            {
                return obj is SDL_WindowPtr ptr && Equals(ptr);
            }

            public bool Equals(SDL_WindowPtr other)
            {
                return Window.Equals(other.Window);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Window);
            }

            public static bool operator ==(SDL_WindowPtr left, SDL_WindowPtr right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(SDL_WindowPtr left, SDL_WindowPtr right)
            {
                return !(left == right);
            }
        }

        internal unsafe struct SDL_GLContext : IEquatable<SDL_GLContext>
        {
            public static SDL_GLContext Null => new SDL_GLContext(null);

            public nuint Ptr;

            public SDL_GLContext(void* ptr)
            {
                Ptr = (nuint)ptr;
            }

            public override bool Equals(object? obj)
            {
                return obj is SDL_GLContext context && Equals(context);
            }

            public bool Equals(SDL_GLContext other)
            {
                return Ptr.Equals(other.Ptr);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Ptr);
            }

            public static bool operator ==(SDL_GLContext left, SDL_GLContext right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(SDL_GLContext left, SDL_GLContext right)
            {
                return !(left == right);
            }
        }

        internal const int SDL_WINDOWPOS_UNDEFINED = 0x1FFF0000 | 0;

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern SDL_WindowPtr SDL_CreateWindow([MarshalAs(UnmanagedType.LPUTF8Str)] string title, int x, int y, int w, int h, SDL_WindowFlags flags);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern uint SDL_GetWindowID(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern SDL_WindowPtr SDL_GetWindowFromID(uint id);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_DestroyWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static unsafe extern int SDL_PollEvent(SDLEvent* @event);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_SetWindowTitle(SDL_WindowPtr window, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.LPUTF8Str)]
        internal static extern string SDL_GetWindowTitle(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowPosition(SDL_WindowPtr window, int x, int y);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GetWindowPosition(SDL_WindowPtr window, out int x, out int y);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowSize(SDL_WindowPtr window, int w, int h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GetWindowSize(SDL_WindowPtr window, out int w, out int h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowMaximumSize(SDL_WindowPtr window, int max_w, int max_h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GetWindowMaximumSize(SDL_WindowPtr window, out int w, out int h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowMinimumSize(SDL_WindowPtr window, int min_w, int min_h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GetWindowMinimumSize(SDL_WindowPtr window, out int w, out int h);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_HideWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_ShowWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_RestoreWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_MinimizeWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_MaximizeWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowAlwaysOnTop(SDL_WindowPtr window, int on_top);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern SDL_WindowFlags SDL_GetWindowFlags(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_RaiseWindow(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_FlashWindow(SDL_WindowPtr window, SDL_FlashOperation operation);

        // FIXME: The encoding of this string is important!
        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GL_LoadLibrary(string? path);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr SDL_GL_GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string proc);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GL_SetAttribute(SDL_GLattr attr, int value);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern SDL_GLContext SDL_GL_CreateContext(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GL_DeleteContext(SDL_GLContext context);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GL_MakeCurrent(SDL_WindowPtr window, SDL_GLContext context);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern SDL_GLContext SDL_GL_GetCurrentContext();

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GL_SwapWindow(SDL_WindowPtr window);
    }
}
