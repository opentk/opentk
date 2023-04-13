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

        // FIXME: The calling convention is likely wrong!

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

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GL_SetSwapInterval(int interval);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GL_GetSwapInterval();

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowGrab(SDL_WindowPtr window, int grabbed);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetWindowGrab(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_ShowCursor(int toggle);

        internal struct SDL_Point
        {
            public int x;
            public int y;
        }

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        internal delegate SDL_HitTestResult SDL_HitTest(SDL_WindowPtr win, in SDL_Point area, IntPtr data);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_SetWindowHitTest(SDL_WindowPtr window, SDL_HitTest? callback, IntPtr callback_data);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowBordered(SDL_WindowPtr window, int bordered);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_SetWindowResizable(SDL_WindowPtr window, int resizable);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetNumVideoDisplays();

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetNumDisplayModes(int displayIndex);

        internal unsafe struct SDL_DisplayMode
        {
            /**< pixel format */
            public uint format;
            /**< width, in screen coordinates */
            public int w;
            /**< height, in screen coordinates */
            public int h;
            /**< refresh rate (or zero for unspecified) */
            public int refresh_rate;
            /**< driver-specific data, initialize to 0 */
            public void* driverdata;
        }

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetDisplayMode(int displayIndex, int modeIndex, out SDL_DisplayMode mode);

        [DllImport(SDLLib, EntryPoint = "SDL_GetDisplayName", CallingConvention = CallingConvention.StdCall)]
        private static unsafe extern char* SDL_GetDisplayName_internal(int displayIndex);

        internal static unsafe string? SDL_GetDisplayName(int displayIndex)
        {
            char* ptr = SDL_GetDisplayName_internal(displayIndex);
            return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetCurrentDisplayMode(int displayIndex, out SDL_DisplayMode mode);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static unsafe extern int SDL_GetDisplayDPI(int displayIndex, out float ddpi, out float hdpi, out float vdpi);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_GL_GetDrawableSize(SDL_WindowPtr window, out int w, out int h);

        internal struct SDL_Rect
        {
            public int x, y;
            public int w, h;
        }

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetDisplayBounds(int displayIndex, out SDL_Rect rect);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetDisplayUsableBounds(int displayIndex, out SDL_Rect rect);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_GetWindowDisplayIndex(SDL_WindowPtr window);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern uint SDL_GetMouseState(out int x, out int y);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern void SDL_WarpMouseInWindow(SDL_WindowPtr window, int x, int y);

        [DllImport(SDLLib, CallingConvention = CallingConvention.Winapi)]
        internal static extern int SDL_WarpMouseGlobal(int x, int y);
    }
}
