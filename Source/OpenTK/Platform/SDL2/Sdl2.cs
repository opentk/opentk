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
using System.Security;
using System.Runtime.InteropServices;

#pragma warning disable 0169

namespace OpenTK.Platform.SDL2
{
    using Surface = IntPtr;
    using Cursor = IntPtr;

    partial class SDL
    {
        #if ANDROID
        const string lib = "libSDL2.so";
        #elif IPHONE
        const string lib = "__Internal";
        #else
        const string lib = "SDL2.dll";
        #endif

        public readonly static object Sync = new object();
        static Nullable<Version> version;
        public static Version Version
        {
            get
            {
                try
                {
                    if (!version.HasValue)
                    {
                        version = GetVersion();
                    }
                    return version.Value;
                }
                catch
                {
                    // nom nom
                    Debug.Print("[SDL2] Failed to retrieve version");
                    return new Version();
                }
            }
        }

        #region Functions

        static string IntPtrToString(IntPtr ptr)
        {
            return Marshal.PtrToStringAnsi(ptr);
            //int strlen = 0;
            //while (Marshal.ReadByte(ptr) != 0)
            //    strlen++;
        }

        #region Cursor

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
        public static extern Cursor CreateColorCursor(Surface surface, int hot_x, int hot_y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeCursor", ExactSpelling = true)]
        public static extern void FreeCursor(Cursor cursor);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
        public static extern IntPtr GetDefaultCursor();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
        public static extern void SetCursor(Cursor cursor);

        #endregion

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
        public static extern void AddEventWatch(EventFilter filter, IntPtr userdata);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
        public static extern void AddEventWatch(IntPtr filter, IntPtr userdata);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRGBSurfaceFrom", ExactSpelling = true)]
        public static extern IntPtr CreateRGBSurfaceFrom(IntPtr pixels,
            int width, int height, int depth, int pitch,
            uint Rmask, uint Gmask, uint Bmask, uint Amask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        public static extern IntPtr CreateWindow(string title, int x, int y, int w, int h, WindowFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowFrom", ExactSpelling = true)]
        public static extern IntPtr CreateWindowFrom(IntPtr data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelEventWatch", ExactSpelling = true)]
        public static extern void DelEventWatch(EventFilter filter, IntPtr userdata);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelEventWatch", ExactSpelling = true)]
        public static extern void DelEventWatch(IntPtr filter, IntPtr userdata);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        public static extern void DestroyWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeSurface", ExactSpelling = true)]
        public static extern void FreeSurface(IntPtr surface);

        #region GameContoller

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerEventState", ExactSpelling = true)]
        public static extern EventState GameControllerEventState(EventState state);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAxis", ExactSpelling = true)]
        public static extern short GameControllerGetAxis(IntPtr gamecontroller, GameControllerAxis axis);

        /// <summary>
        /// Gets the SDL joystick layer binding for the specified game controller axis
        /// </summary>
        /// <param name="gamecontroller">Pointer to a game controller instance returned by <c>GameControllerOpen</c>.</param>
        /// <param name="axis">A value from the <c>GameControllerAxis</c> enumeration</param>
        /// <returns>A GameControllerButtonBind instance describing the specified binding</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetBindForAxis", ExactSpelling = true)]
        public static extern GameControllerButtonBind GameControllerGetBindForAxis(IntPtr gamecontroller, GameControllerAxis axis);

        /// <summary>
        /// Gets the SDL joystick layer binding for the specified game controller button
        /// </summary>
        /// <param name="gamecontroller">Pointer to a game controller instance returned by <c>GameControllerOpen</c>.</param>
        /// <param name="button">A value from the <c>GameControllerButton</c> enumeration</param>
        /// <returns>A GameControllerButtonBind instance describing the specified binding</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetBindForButton", ExactSpelling = true)]
        public static extern GameControllerButtonBind GameControllerGetBindForButton(
            IntPtr gamecontroller, GameControllerButton button);

        /// <summary>
        /// Gets the current state of a button on a game controller.
        /// </summary>
        /// <param name="gamecontroller">A game controller handle previously opened with <c>GameControllerOpen</c>.</param>
        /// <param name="button">A zero-based <c>GameControllerButton</c> value.</param>
        /// <returns><c>true</c> if the specified button is pressed; <c>false</c> otherwise.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetButton", ExactSpelling = true)]
        public static extern bool GameControllerGetButton(IntPtr gamecontroller, GameControllerButton button);

        /// <summary>
        /// Retrieve the joystick handle that corresponds to the specified game controller.
        /// </summary>
        /// <param name="gamecontroller">A game controller handle previously opened with <c>GameControllerOpen</c>.</param>
        /// <returns>A handle to a joystick, or IntPtr.Zero in case of error. The pointer is owned by the callee. Use <c>SDL.GetError</c> to retrieve error information</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetJoystick", ExactSpelling = true)]
        public static extern IntPtr GameControllerGetJoystick(IntPtr gamecontroller);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
        public static extern int GetCurrentDisplayMode(int displayIndex, out DisplayMode mode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerName", ExactSpelling = true)]
        static extern IntPtr GameControllerNameInternal(IntPtr gamecontroller);

        /// <summary>
        /// Return the name for an openend game controller instance.
        /// </summary>
        /// <returns>The name of the game controller name.</returns>
        /// <param name="gamecontroller">Pointer to a game controller instance returned by <c>GameControllerOpen</c>.</param>
        public static string GameControllerName(IntPtr gamecontroller)
        {
            unsafe
            {
                return new string((sbyte*)GameControllerNameInternal(gamecontroller));
            }
        }

        /// <summary>
        /// Opens a game controller for use.
        /// </summary>
        /// <param name="joystick_index">
        /// A zero-based index for the game controller.
        /// This index is the value which will identify this controller in future controller events.
        /// </param>
        /// <returns>A handle to the game controller instance, or IntPtr.Zero in case of error.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerOpen", ExactSpelling = true)]
        public static extern IntPtr GameControllerOpen(int joystick_index);

        #endregion

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
        public static extern int GetDisplayBounds(int displayIndex, out Rect rect);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayMode", ExactSpelling = true)]
        public static extern int GetDisplayMode(int displayIndex, int modeIndex, out DisplayMode mode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
        static extern IntPtr GetErrorInternal();
        public static string GetError()
        {
            return IntPtrToString(GetErrorInternal());
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
        public static extern Keymod GetModState();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
        public static extern ButtonFlags GetMouseState(out int hx, out int hy);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumDisplayModes", ExactSpelling = true)]
        public static extern int GetNumDisplayModes(int displayIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDisplays", ExactSpelling = true)]
        public static extern int GetNumVideoDisplays();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
        public static extern Scancode GetScancodeFromKey(Keycode key);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
        public static extern void GetVersion(out Version version);
        public static Version GetVersion()
        {
            Version v;
            GetVersion(out v);
            return v;
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
        public static extern uint GetWindowID(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
        public static extern void GetWindowPosition(IntPtr window, out int x, out int y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
        public static extern void GetWindowSize(IntPtr window, out int w, out int h);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
        static extern IntPtr GetWindowTitlePrivate(IntPtr window);
        public static string GetWindowTitle(IntPtr window)
        {
            return Marshal.PtrToStringAnsi(GetWindowTitlePrivate(window));
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
        public static extern void HideWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
        public static extern int Init(SystemFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        public static extern int InitSubSystem(SystemFlags flags);

        /// <summary>
        /// Determines if the specified joystick is supported by the GameController API.
        /// </summary>
        /// <returns><c>true</c> if joystick_index is supported by the GameController API; <c>false</c> otherwise.</returns>
        /// <param name="joystick_index">The index of the joystick to check.</param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGameController", ExactSpelling = true)]
        public static extern bool IsGameController(int joystick_index);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickClose", ExactSpelling = true)]
        public static extern void JoystickClose(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventState", ExactSpelling = true)]
        public static extern EventState JoystickEventState(EventState enabled);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetAxis", ExactSpelling = true)]
        public static extern short JoystickGetAxis(IntPtr joystick, int axis);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetButton", ExactSpelling = true)]
        public static extern byte JoystickGetButton(IntPtr joystick, int button);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetGUID", ExactSpelling = true)]
        public static extern JoystickGuid JoystickGetGUID(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickName", ExactSpelling = true)]
        static extern IntPtr JoystickNameInternal(IntPtr joystick);
        public static string JoystickName(IntPtr joystick)
        {
            unsafe
            {
                return new string((sbyte*)JoystickNameInternal(joystick));
            }
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumAxes", ExactSpelling = true)]
        public static extern int JoystickNumAxes(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumBalls", ExactSpelling = true)]
        public static extern int JoystickNumBalls(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumButtons", ExactSpelling = true)]
        public static extern int JoystickNumButtons(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumHats", ExactSpelling = true)]
        public static extern int JoystickNumHats(IntPtr joystick);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickOpen", ExactSpelling = true)]
        public static extern IntPtr JoystickOpen(int device_index);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickUpdate", ExactSpelling = true)]
        public static extern void JoystickUpdate();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
        public static extern void MaximizeWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
        public static extern void MinimizeWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_NumJoysticks", ExactSpelling = true)]
        public static extern int NumJoysticks();

        public static int PeepEvents(ref Event e, EventAction action, EventType min, EventType max)
        {
            unsafe
            {
                fixed (Event* pe = &e)
                {
                    return PeepEvents(pe, 1, action, min, max);
                }
            }
        }

        public static int PeepEvents(Event[] e, int count, EventAction action, EventType min, EventType max)
        {
            if (e == null)
                throw new ArgumentNullException();
            if (count <= 0 || count > e.Length)
                throw new ArgumentOutOfRangeException();

            unsafe
            {
                fixed (Event *pe = e)
                {
                    return PeepEvents(pe, count, action, min, max);
                }
            }
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
        unsafe static extern int PeepEvents(Event* e, int count, EventAction action, EventType min, EventType max);


        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PixelFormatEnumToMasks", ExactSpelling = true)]
        public static extern bool PixelFormatEnumToMasks(uint format, out int bpp, 
            out uint rmask, out uint gmask, out uint bmask, out uint amask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
        public static extern int PollEvent(out Event e);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        public static extern void PumpEvents();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
        public static extern int PushEvent(ref Event @event);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
        public static extern void RaiseWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
        public static extern void RestoreWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRelativeMouseMode", ExactSpelling = true)]
        public static extern int SetRelativeMouseMode(bool enabled);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
        public static extern void SetWindowBordered(IntPtr window, bool bordered);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
        public static extern int SetWindowFullscreen(IntPtr window, uint flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowGrab", ExactSpelling = true)]
        public static extern void SetWindowGrab(IntPtr window, bool grabbed);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
        public static extern void SetWindowIcon(IntPtr window, IntPtr icon);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
        public static extern void SetWindowPosition(IntPtr window, int x, int y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
        public static extern void SetWindowSize(IntPtr window, int x, int y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
        public static extern void SetWindowTitle(IntPtr window, string title);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
        public static extern int ShowCursor(bool toggle);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
        public static extern void ShowWindow(IntPtr window);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        public static extern bool WasInit(SystemFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
        public static extern void WarpMouseInWindow(IntPtr window, int x, int y);

        #region SysWM

        /// <summary>
        /// Retrieves driver-dependent window information.
        /// </summary>
        /// <param name="window">
        /// The window about which information is being requested.
        /// </param>
        /// <param name="info">
        /// Returns driver-dependent information about the specified window.
        /// </param>
        /// <returns>
        /// True, if the function is implemented and the version number of the info struct is valid;
        /// false, otherwise.
        /// </returns>
        public static bool GetWindowWMInfo(IntPtr window, out SysWMInfo info)
        {
            info = new SysWMInfo();
            info.Version = GetVersion();
            return GetWindowWMInfoInternal(window, ref info);
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowWMInfo", ExactSpelling = true)]
        static extern bool GetWindowWMInfoInternal(IntPtr window, ref SysWMInfo info);

        #endregion

        public partial class GL
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
            public static extern IntPtr CreateContext(IntPtr window);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DeleteContext", ExactSpelling = true)]
            public static extern void DeleteContext(IntPtr context);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
            public static extern int GetAttribute(ContextAttribute attr, out int value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
            public static extern IntPtr GetCurrentContext();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetDrawableSize", ExactSpelling = true)]
            public static extern void GetDrawableSize(IntPtr window, out int w, out int h);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
            public static extern IntPtr GetProcAddress(IntPtr proc);
            public static IntPtr GetProcAddress(string proc)
            {
                IntPtr p = Marshal.StringToHGlobalAnsi(proc);
                try
                {
                    return GetProcAddress(p);
                }
                finally
                {
                    Marshal.FreeHGlobal(p);
                }
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
            public static extern int GetSwapInterval();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
            public static extern int MakeCurrent(IntPtr window, IntPtr context);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
            public static extern int SetAttribute(ContextAttribute attr, int value);
            public static int SetAttribute(ContextAttribute attr, ContextFlags value)
            {
                return SetAttribute(attr, (int)value);
            }
            public static int SetAttribute(ContextAttribute attr, ContextProfileFlags value)
            {
                return SetAttribute(attr, (int)value);
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
            public static extern int SetSwapInterval(int interval);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(lib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
            public static extern void SwapWindow(IntPtr window);
        }

        #endregion
    }

    #region Delegates

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int EventFilter(IntPtr userdata, IntPtr @event);

    #endregion

    #region Enums

    enum Button : byte
    {
        Left = 1,
        Middle,
        Right,
        X1,
        X2
    }

    [Flags]
    enum ButtonFlags
    {
        Left = 1 << (Button.Left - 1),
        Middle = 1 << (Button.Middle - 1),
        Right = 1 << (Button.Right - 1),
        X1 = 1 << (Button.X1 - 1),
        X2 = 1 << (Button.X2 - 1),
    }

    enum ContextAttribute
    {
        RED_SIZE,
        GREEN_SIZE,
        BLUE_SIZE,
        ALPHA_SIZE,
        BUFFER_SIZE,
        DOUBLEBUFFER,
        DEPTH_SIZE,
        STENCIL_SIZE,
        ACCUM_RED_SIZE,
        ACCUM_GREEN_SIZE,
        ACCUM_BLUE_SIZE,
        ACCUM_ALPHA_SIZE,
        STEREO,
        MULTISAMPLEBUFFERS,
        MULTISAMPLESAMPLES,
        ACCELERATED_VISUAL,
        RETAINED_BACKING,
        CONTEXT_MAJOR_VERSION,
        CONTEXT_MINOR_VERSION,
        CONTEXT_EGL,
        CONTEXT_FLAGS,
        CONTEXT_PROFILE_MASK,
        SHARE_WITH_CURRENT_CONTEXT
    }

    [Flags]
    enum ContextFlags
    {
        DEBUG = 0x0001,
        FORWARD_COMPATIBLE = 0x0002,
        ROBUST_ACCESS = 0x0004,
        RESET_ISOLATION = 0x0008
    }

    [Flags]
    enum ContextProfileFlags
    {
        CORE = 0x0001,
        COMPATIBILITY = 0x0002,
        ES = 0x0004
    }

    enum EventAction
    {
        Add,
        Peek,
        Get
    }

    enum EventState
    {
        Query = -1,
        Ignore = 0,
        Enable = 1
    }

    enum EventType
    {
        FIRSTEVENT = 0,
        QUIT = 0x100,
        WINDOWEVENT = 0x200,
        SYSWMEVENT,
        KEYDOWN = 0x300,
        KEYUP,
        TEXTEDITING,
        TEXTINPUT,
        MOUSEMOTION = 0x400,
        MOUSEBUTTONDOWN,
        MOUSEBUTTONUP,
        MOUSEWHEEL,
        JOYAXISMOTION = 0x600,
        JOYBALLMOTION,
        JOYHATMOTION,
        JOYBUTTONDOWN,
        JOYBUTTONUP,
        JOYDEVICEADDED,
        JOYDEVICEREMOVED,
        CONTROLLERAXISMOTION = 0x650,
        CONTROLLERBUTTONDOWN,
        CONTROLLERBUTTONUP,
        CONTROLLERDEVICEADDED,
        CONTROLLERDEVICEREMOVED,
        CONTROLLERDEVICEREMAPPED,
        FINGERDOWN = 0x700,
        FINGERUP,
        FINGERMOTION,
        DOLLARGESTURE = 0x800,
        DOLLARRECORD,
        MULTIGESTURE,
        CLIPBOARDUPDATE = 0x900,
        DROPFILE = 0x1000,
        USEREVENT = 0x8000,
        LASTEVENT = 0xFFFF
    }

    enum GameControllerAxis : byte
    {
        Invalid = 0xff,
        LeftX = 0,
        LeftY,
        RightX,
        RightY,
        TriggerLeft,
        TriggerRight,
        Max
    }

    enum GameControllerButton : byte
    {
        INVALID = 0xff,
        A = 0,
        B,
        X,
        Y,
        BACK,
        GUIDE,
        START,
        LEFTSTICK,
        RIGHTSTICK,
        LEFTSHOULDER,
        RIGHTSHOULDER,
        DPAD_UP,
        DPAD_DOWN,
        DPAD_LEFT,
        DPAD_RIGHT,
        Max
    }

    enum GameControllerBindType : byte
    {
        None = 0,
        Button,
        Axis,
        Hat
    }

    [Flags]
    enum HatPosition : byte
    {
        Centered = 0x00,
        Up = 0x01,
        Right = 0x02,
        Down = 0x03,
        Left = 0x04,
        RightUp = Right | Up,
        RightDown = Right | Down,
        LeftUp = Left | Up,
        LeftDown = Left | Down
    }

    enum Keycode
    {
        UNKNOWN = 0,
        RETURN = '\r',
        ESCAPE = 27, // '\033' octal
        BACKSPACE = '\b',
        TAB = '\t',
        SPACE = ' ',
        EXCLAIM = '!',
        QUOTEDBL = '"',
        HASH = '#',
        PERCENT = '%',
        DOLLAR = '$',
        AMPERSAND = '&',
        QUOTE = '\'',
        LEFTPAREN = '(',
        RIGHTPAREN = ')',
        ASTERISK = '*',
        PLUS = '+',
        COMMA = ',',
        MINUS = '-',
        PERIOD = '.',
        SLASH = '/',
        Num0 = '0',
        Num1 = '1',
        Num2 = '2',
        Num3 = '3',
        Num4 = '4',
        Num5 = '5',
        Num6 = '6',
        Num7 = '7',
        Num8 = '8',
        Num9 = '9',
        COLON = ':',
        SEMICOLON = ';',
        LESS = '<',
        EQUALS = '=',
        GREATER = '>',
        QUESTION = '?',
        AT = '@',
        LEFTBRACKET = '[',
        BACKSLASH = '\\',
        RIGHTBRACKET = ']',
        CARET = '^',
        UNDERSCORE = '_',
        BACKQUOTE = '`',
        a = 'a',
        b = 'b',
        c = 'c',
        d = 'd',
        e = 'e',
        f = 'f',
        g = 'g',
        h = 'h',
        i = 'i',
        j = 'j',
        k = 'k',
        l = 'l',
        m = 'm',
        n = 'n',
        o = 'o',
        p = 'p',
        q = 'q',
        r = 'r',
        s = 's',
        t = 't',
        u = 'u',
        v = 'v',
        w = 'w',
        x = 'x',
        y = 'y',
        z = 'z',
        CAPSLOCK = (1 << 30) | (int)Scancode.CAPSLOCK,
        F1 = (1 << 30) | (int)Scancode.F1,
        F2 = (1 << 30) | (int)Scancode.F2,
        F3 = (1 << 30) | (int)Scancode.F3,
        F4 = (1 << 30) | (int)Scancode.F4,
        F5 = (1 << 30) | (int)Scancode.F5,
        F6 = (1 << 30) | (int)Scancode.F6,
        F7 = (1 << 30) | (int)Scancode.F7,
        F8 = (1 << 30) | (int)Scancode.F8,
        F9 = (1 << 30) | (int)Scancode.F9,
        F10 = (1 << 30) | (int)Scancode.F10,
        F11 = (1 << 30) | (int)Scancode.F11,
        F12 = (1 << 30) | (int)Scancode.F12,
        PRINTSCREEN = (1 << 30) | (int)Scancode.PRINTSCREEN,
        SCROLLLOCK = (1 << 30) | (int)Scancode.SCROLLLOCK,
        PAUSE = (1 << 30) | (int)Scancode.PAUSE,
        INSERT = (1 << 30) | (int)Scancode.INSERT,
        HOME = (1 << 30) | (int)Scancode.HOME,
        PAGEUP = (1 << 30) | (int)Scancode.PAGEUP,
        DELETE = 127, // '\177' octal
        END = (1 << 30) | (int)Scancode.END,
        PAGEDOWN = (1 << 30) | (int)Scancode.PAGEDOWN,
        RIGHT = (1 << 30) | (int)Scancode.RIGHT,
        LEFT = (1 << 30) | (int)Scancode.LEFT,
        DOWN = (1 << 30) | (int)Scancode.DOWN,
        UP = (1 << 30) | (int)Scancode.UP,
        NUMLOCKCLEAR = (1 << 30) | (int)Scancode.NUMLOCKCLEAR,
        KP_DIVIDE = (1 << 30) | (int)Scancode.KP_DIVIDE,
        KP_MULTIPLY = (1 << 30) | (int)Scancode.KP_MULTIPLY,
        KP_MINUS = (1 << 30) | (int)Scancode.KP_MINUS,
        KP_PLUS = (1 << 30) | (int)Scancode.KP_PLUS,
        KP_ENTER = (1 << 30) | (int)Scancode.KP_ENTER,
        KP_1 = (1 << 30) | (int)Scancode.KP_1,
        KP_2 = (1 << 30) | (int)Scancode.KP_2,
        KP_3 = (1 << 30) | (int)Scancode.KP_3,
        KP_4 = (1 << 30) | (int)Scancode.KP_4,
        KP_5 = (1 << 30) | (int)Scancode.KP_5,
        KP_6 = (1 << 30) | (int)Scancode.KP_6,
        KP_7 = (1 << 30) | (int)Scancode.KP_7,
        KP_8 = (1 << 30) | (int)Scancode.KP_8,
        KP_9 = (1 << 30) | (int)Scancode.KP_9,
        KP_0 = (1 << 30) | (int)Scancode.KP_0,
        KP_PERIOD = (1 << 30) | (int)Scancode.KP_PERIOD,
        APPLICATION = (1 << 30) | (int)Scancode.APPLICATION,
        POWER = (1 << 30) | (int)Scancode.POWER,
        KP_EQUALS = (1 << 30) | (int)Scancode.KP_EQUALS,
        F13 = (1 << 30) | (int)Scancode.F13,
        F14 = (1 << 30) | (int)Scancode.F14,
        F15 = (1 << 30) | (int)Scancode.F15,
        F16 = (1 << 30) | (int)Scancode.F16,
        F17 = (1 << 30) | (int)Scancode.F17,
        F18 = (1 << 30) | (int)Scancode.F18,
        F19 = (1 << 30) | (int)Scancode.F19,
        F20 = (1 << 30) | (int)Scancode.F20,
        F21 = (1 << 30) | (int)Scancode.F21,
        F22 = (1 << 30) | (int)Scancode.F22,
        F23 = (1 << 30) | (int)Scancode.F23,
        F24 = (1 << 30) | (int)Scancode.F24,
        EXECUTE = (1 << 30) | (int)Scancode.EXECUTE,
        HELP = (1 << 30) | (int)Scancode.HELP,
        MENU = (1 << 30) | (int)Scancode.MENU,
        SELECT = (1 << 30) | (int)Scancode.SELECT,
        STOP = (1 << 30) | (int)Scancode.STOP,
        AGAIN = (1 << 30) | (int)Scancode.AGAIN,
        UNDO = (1 << 30) | (int)Scancode.UNDO,
        CUT = (1 << 30) | (int)Scancode.CUT,
        COPY = (1 << 30) | (int)Scancode.COPY,
        PASTE = (1 << 30) | (int)Scancode.PASTE,
        FIND = (1 << 30) | (int)Scancode.FIND,
        MUTE = (1 << 30) | (int)Scancode.MUTE,
        VOLUMEUP = (1 << 30) | (int)Scancode.VOLUMEUP,
        VOLUMEDOWN = (1 << 30) | (int)Scancode.VOLUMEDOWN,
        KP_COMMA = (1 << 30) | (int)Scancode.KP_COMMA,
        KP_EQUALSAS400 = (1 << 30) | (int)Scancode.KP_EQUALSAS400,
        ALTERASE = (1 << 30) | (int)Scancode.ALTERASE,
        SYSREQ = (1 << 30) | (int)Scancode.SYSREQ,
        CANCEL = (1 << 30) | (int)Scancode.CANCEL,
        CLEAR = (1 << 30) | (int)Scancode.CLEAR,
        PRIOR = (1 << 30) | (int)Scancode.PRIOR,
        RETURN2 = (1 << 30) | (int)Scancode.RETURN2,
        SEPARATOR = (1 << 30) | (int)Scancode.SEPARATOR,
        OUT = (1 << 30) | (int)Scancode.OUT,
        OPER = (1 << 30) | (int)Scancode.OPER,
        CLEARAGAIN = (1 << 30) | (int)Scancode.CLEARAGAIN,
        CRSEL = (1 << 30) | (int)Scancode.CRSEL,
        EXSEL = (1 << 30) | (int)Scancode.EXSEL,
        KP_00 = (1 << 30) | (int)Scancode.KP_00,
        KP_000 = (1 << 30) | (int)Scancode.KP_000,
        THOUSANDSSEPARATOR = (1 << 30) | (int)Scancode.THOUSANDSSEPARATOR,
        DECIMALSEPARATOR = (1 << 30) | (int)Scancode.DECIMALSEPARATOR,
        CURRENCYUNIT = (1 << 30) | (int)Scancode.CURRENCYUNIT,
        CURRENCYSUBUNIT = (1 << 30) | (int)Scancode.CURRENCYSUBUNIT,
        KP_LEFTPAREN = (1 << 30) | (int)Scancode.KP_LEFTPAREN,
        KP_RIGHTPAREN = (1 << 30) | (int)Scancode.KP_RIGHTPAREN,
        KP_LEFTBRACE = (1 << 30) | (int)Scancode.KP_LEFTBRACE,
        KP_RIGHTBRACE = (1 << 30) | (int)Scancode.KP_RIGHTBRACE,
        KP_TAB = (1 << 30) | (int)Scancode.KP_TAB,
        KP_BACKSPACE = (1 << 30) | (int)Scancode.KP_BACKSPACE,
        KP_A = (1 << 30) | (int)Scancode.KP_A,
        KP_B = (1 << 30) | (int)Scancode.KP_B,
        KP_C = (1 << 30) | (int)Scancode.KP_C,
        KP_D = (1 << 30) | (int)Scancode.KP_D,
        KP_E = (1 << 30) | (int)Scancode.KP_E,
        KP_F = (1 << 30) | (int)Scancode.KP_F,
        KP_XOR = (1 << 30) | (int)Scancode.KP_XOR,
        KP_POWER = (1 << 30) | (int)Scancode.KP_POWER,
        KP_PERCENT = (1 << 30) | (int)Scancode.KP_PERCENT,
        KP_LESS = (1 << 30) | (int)Scancode.KP_LESS,
        KP_GREATER = (1 << 30) | (int)Scancode.KP_GREATER,
        KP_AMPERSAND = (1 << 30) | (int)Scancode.KP_AMPERSAND,
        KP_DBLAMPERSAND = (1 << 30) | (int)Scancode.KP_DBLAMPERSAND,
        KP_VERTICALBAR = (1 << 30) | (int)Scancode.KP_VERTICALBAR,
        KP_DBLVERTICALBAR = (1 << 30) | (int)Scancode.KP_DBLVERTICALBAR,
        KP_COLON = (1 << 30) | (int)Scancode.KP_COLON,
        KP_HASH = (1 << 30) | (int)Scancode.KP_HASH,
        KP_SPACE = (1 << 30) | (int)Scancode.KP_SPACE,
        KP_AT = (1 << 30) | (int)Scancode.KP_AT,
        KP_EXCLAM = (1 << 30) | (int)Scancode.KP_EXCLAM,
        KP_MEMSTORE = (1 << 30) | (int)Scancode.KP_MEMSTORE,
        KP_MEMRECALL = (1 << 30) | (int)Scancode.KP_MEMRECALL,
        KP_MEMCLEAR = (1 << 30) | (int)Scancode.KP_MEMCLEAR,
        KP_MEMADD = (1 << 30) | (int)Scancode.KP_MEMADD,
        KP_MEMSUBTRACT = (1 << 30) | (int)Scancode.KP_MEMSUBTRACT,
        KP_MEMMULTIPLY = (1 << 30) | (int)Scancode.KP_MEMMULTIPLY,
        KP_MEMDIVIDE = (1 << 30) | (int)Scancode.KP_MEMDIVIDE,
        KP_PLUSMINUS = (1 << 30) | (int)Scancode.KP_PLUSMINUS,
        KP_CLEAR = (1 << 30) | (int)Scancode.KP_CLEAR,
        KP_CLEARENTRY = (1 << 30) | (int)Scancode.KP_CLEARENTRY,
        KP_BINARY = (1 << 30) | (int)Scancode.KP_BINARY,
        KP_OCTAL = (1 << 30) | (int)Scancode.KP_OCTAL,
        KP_DECIMAL = (1 << 30) | (int)Scancode.KP_DECIMAL,
        KP_HEXADECIMAL = (1 << 30) | (int)Scancode.KP_HEXADECIMAL,
        LCTRL = (1 << 30) | (int)Scancode.LCTRL,
        LSHIFT = (1 << 30) | (int)Scancode.LSHIFT,
        LALT = (1 << 30) | (int)Scancode.LALT,
        LGUI = (1 << 30) | (int)Scancode.LGUI,
        RCTRL = (1 << 30) | (int)Scancode.RCTRL,
        RSHIFT = (1 << 30) | (int)Scancode.RSHIFT,
        RALT = (1 << 30) | (int)Scancode.RALT,
        RGUI = (1 << 30) | (int)Scancode.RGUI,
        MODE = (1 << 30) | (int)Scancode.MODE,
        AUDIONEXT = (1 << 30) | (int)Scancode.AUDIONEXT,
        AUDIOPREV = (1 << 30) | (int)Scancode.AUDIOPREV,
        AUDIOSTOP = (1 << 30) | (int)Scancode.AUDIOSTOP,
        AUDIOPLAY = (1 << 30) | (int)Scancode.AUDIOPLAY,
        AUDIOMUTE = (1 << 30) | (int)Scancode.AUDIOMUTE,
        MEDIASELECT = (1 << 30) | (int)Scancode.MEDIASELECT,
        WWW = (1 << 30) | (int)Scancode.WWW,
        MAIL = (1 << 30) | (int)Scancode.MAIL,
        CALCULATOR = (1 << 30) | (int)Scancode.CALCULATOR,
        COMPUTER = (1 << 30) | (int)Scancode.COMPUTER,
        AC_SEARCH = (1 << 30) | (int)Scancode.AC_SEARCH,
        AC_HOME = (1 << 30) | (int)Scancode.AC_HOME,
        AC_BACK = (1 << 30) | (int)Scancode.AC_BACK,
        AC_FORWARD = (1 << 30) | (int)Scancode.AC_FORWARD,
        AC_STOP = (1 << 30) | (int)Scancode.AC_STOP,
        AC_REFRESH = (1 << 30) | (int)Scancode.AC_REFRESH,
        AC_BOOKMARKS = (1 << 30) | (int)Scancode.AC_BOOKMARKS,
        BRIGHTNESSDOWN = (1 << 30) | (int)Scancode.BRIGHTNESSDOWN,
        BRIGHTNESSUP = (1 << 30) | (int)Scancode.BRIGHTNESSUP,
        DISPLAYSWITCH = (1 << 30) | (int)Scancode.DISPLAYSWITCH,
        KBDILLUMTOGGLE = (1 << 30) | (int)Scancode.KBDILLUMTOGGLE,
        KBDILLUMDOWN = (1 << 30) | (int)Scancode.KBDILLUMDOWN,
        KBDILLUMUP = (1 << 30) | (int)Scancode.KBDILLUMUP,
        EJECT = (1 << 30) | (int)Scancode.EJECT,
        SLEEP = (1 << 30) | (int)Scancode.SLEEP
    }

    [Flags]
    enum Keymod : ushort
    {
        NONE = 0x0000,
        LSHIFT = 0x0001,
        RSHIFT = 0x0002,
        LCTRL = 0x0040,
        RCTRL = 0x0080,
        LALT = 0x0100,
        RALT = 0x0200,
        LGUI = 0x0400,
        RGUI = 0x0800,
        NUM = 0x1000,
        CAPS = 0x2000,
        MODE = 0x4000,
        RESERVED = 0x8000,
        CTRL = (LCTRL | RCTRL),
        SHIFT = (LSHIFT | RSHIFT),
        ALT = (LALT | RALT),
        GUI = (LGUI | RGUI)
    }

    enum Scancode
    {
        UNKNOWN = 0,
        A = 4,
        B = 5,
        C = 6,
        D = 7,
        E = 8,
        F = 9,
        G = 10,
        H = 11,
        I = 12,
        J = 13,
        K = 14,
        L = 15,
        M = 16,
        N = 17,
        O = 18,
        P = 19,
        Q = 20,
        R = 21,
        S = 22,
        T = 23,
        U = 24,
        V = 25,
        W = 26,
        X = 27,
        Y = 28,
        Z = 29,
        Num1 = 30,
        Num2 = 31,
        Num3 = 32,
        Num4 = 33,
        Num5 = 34,
        Num6 = 35,
        Num7 = 36,
        Num8 = 37,
        Num9 = 38,
        Num0 = 39,
        RETURN = 40,
        ESCAPE = 41,
        BACKSPACE = 42,
        TAB = 43,
        SPACE = 44,
        MINUS = 45,
        EQUALS = 46,
        LEFTBRACKET = 47,
        RIGHTBRACKET = 48,
        BACKSLASH = 49,
        NONUSHASH = 50,
        SEMICOLON = 51,
        APOSTROPHE = 52,
        GRAVE = 53,
        COMMA = 54,
        PERIOD = 55,
        SLASH = 56,
        CAPSLOCK = 57,
        F1 = 58,
        F2 = 59,
        F3 = 60,
        F4 = 61,
        F5 = 62,
        F6 = 63,
        F7 = 64,
        F8 = 65,
        F9 = 66,
        F10 = 67,
        F11 = 68,
        F12 = 69,
        PRINTSCREEN = 70,
        SCROLLLOCK = 71,
        PAUSE = 72,
        INSERT = 73,
        HOME = 74,
        PAGEUP = 75,
        DELETE = 76,
        END = 77,
        PAGEDOWN = 78,
        RIGHT = 79,
        LEFT = 80,
        DOWN = 81,
        UP = 82,
        NUMLOCKCLEAR = 83,
        KP_DIVIDE = 84,
        KP_MULTIPLY = 85,
        KP_MINUS = 86,
        KP_PLUS = 87,
        KP_ENTER = 88,
        KP_1 = 89,
        KP_2 = 90,
        KP_3 = 91,
        KP_4 = 92,
        KP_5 = 93,
        KP_6 = 94,
        KP_7 = 95,
        KP_8 = 96,
        KP_9 = 97,
        KP_0 = 98,
        KP_PERIOD = 99,
        NONUSBACKSLASH = 100,
        APPLICATION = 101,
        POWER = 102,
        KP_EQUALS = 103,
        F13 = 104,
        F14 = 105,
        F15 = 106,
        F16 = 107,
        F17 = 108,
        F18 = 109,
        F19 = 110,
        F20 = 111,
        F21 = 112,
        F22 = 113,
        F23 = 114,
        F24 = 115,
        EXECUTE = 116,
        HELP = 117,
        MENU = 118,
        SELECT = 119,
        STOP = 120,
        AGAIN = 121,
        UNDO = 122,
        CUT = 123,
        COPY = 124,
        PASTE = 125,
        FIND = 126,
        MUTE = 127,
        VOLUMEUP = 128,
        VOLUMEDOWN = 129,
        // not sure whether there's a reason to enable these
        //  LOCKINGCAPSLOCK = 130,
        //  LOCKINGNUMLOCK = 131,
        //  LOCKINGSCROLLLOCK = 132,
        KP_COMMA = 133,
        KP_EQUALSAS400 = 134,
        INTERNATIONAL1 = 135,
        INTERNATIONAL2 = 136,
        INTERNATIONAL3 = 137,
        INTERNATIONAL4 = 138,
        INTERNATIONAL5 = 139,
        INTERNATIONAL6 = 140,
        INTERNATIONAL7 = 141,
        INTERNATIONAL8 = 142,
        INTERNATIONAL9 = 143,
        LANG1 = 144,
        LANG2 = 145,
        LANG3 = 146,
        LANG4 = 147,
        LANG5 = 148,
        LANG6 = 149,
        LANG7 = 150,
        LANG8 = 151,
        LANG9 = 152,
        ALTERASE = 153,
        SYSREQ = 154,
        CANCEL = 155,
        CLEAR = 156,
        PRIOR = 157,
        RETURN2 = 158,
        SEPARATOR = 159,
        OUT = 160,
        OPER = 161,
        CLEARAGAIN = 162,
        CRSEL = 163,
        EXSEL = 164,
        KP_00 = 176,
        KP_000 = 177,
        THOUSANDSSEPARATOR = 178,
        DECIMALSEPARATOR = 179,
        CURRENCYUNIT = 180,
        CURRENCYSUBUNIT = 181,
        KP_LEFTPAREN = 182,
        KP_RIGHTPAREN = 183,
        KP_LEFTBRACE = 184,
        KP_RIGHTBRACE = 185,
        KP_TAB = 186,
        KP_BACKSPACE = 187,
        KP_A = 188,
        KP_B = 189,
        KP_C = 190,
        KP_D = 191,
        KP_E = 192,
        KP_F = 193,
        KP_XOR = 194,
        KP_POWER = 195,
        KP_PERCENT = 196,
        KP_LESS = 197,
        KP_GREATER = 198,
        KP_AMPERSAND = 199,
        KP_DBLAMPERSAND = 200,
        KP_VERTICALBAR = 201,
        KP_DBLVERTICALBAR = 202,
        KP_COLON = 203,
        KP_HASH = 204,
        KP_SPACE = 205,
        KP_AT = 206,
        KP_EXCLAM = 207,
        KP_MEMSTORE = 208,
        KP_MEMRECALL = 209,
        KP_MEMCLEAR = 210,
        KP_MEMADD = 211,
        KP_MEMSUBTRACT = 212,
        KP_MEMMULTIPLY = 213,
        KP_MEMDIVIDE = 214,
        KP_PLUSMINUS = 215,
        KP_CLEAR = 216,
        KP_CLEARENTRY = 217,
        KP_BINARY = 218,
        KP_OCTAL = 219,
        KP_DECIMAL = 220,
        KP_HEXADECIMAL = 221,
        LCTRL = 224,
        LSHIFT = 225,
        LALT = 226,
        LGUI = 227,
        RCTRL = 228,
        RSHIFT = 229,
        RALT = 230,
        RGUI = 231,
        MODE = 257,
        // These come from the USB consumer page (0x0C)
        AUDIONEXT = 258,
        AUDIOPREV = 259,
        AUDIOSTOP = 260,
        AUDIOPLAY = 261,
        AUDIOMUTE = 262,
        MEDIASELECT = 263,
        WWW = 264,
        MAIL = 265,
        CALCULATOR = 266,
        COMPUTER = 267,
        AC_SEARCH = 268,
        AC_HOME = 269,
        AC_BACK = 270,
        AC_FORWARD = 271,
        AC_STOP = 272,
        AC_REFRESH = 273,
        AC_BOOKMARKS = 274,
        // These come from other sources, and are mostly mac related
        BRIGHTNESSDOWN = 275,
        BRIGHTNESSUP = 276,
        DISPLAYSWITCH = 277,
        KBDILLUMTOGGLE = 278,
        KBDILLUMDOWN = 279,
        KBDILLUMUP = 280,
        EJECT = 281,
        SLEEP = 282,
        APP1 = 283,
        APP2 = 284,
        // This is not a key, simply marks the number of scancodes
        // so that you know how big to make your arrays.
        SDL_NUM_SCANCODES = 512
    }

    enum State : byte
    {
        Released = 0,
        Pressed = 1
    }

    [Flags]
    enum SystemFlags : uint
    {
        Default = 0,
        TIMER = 0x00000001,
        AUDIO = 0x00000010,
        VIDEO = 0x00000020,
        JOYSTICK = 0x00000200,
        HAPTIC = 0x00001000,
        GAMECONTROLLER = 0x00002000,
        NOPARACHUTE = 0x00100000,
        EVERYTHING = TIMER | AUDIO | VIDEO |
            JOYSTICK | HAPTIC | GAMECONTROLLER
    }

    enum SysWMType
    {
        Unknown = 0,
        Windows,
        X11,
        Wayland,
        DirectFB,
        Cocoa,
        UIKit,
    }

    enum WindowEventID : byte
    {
        NONE,
        SHOWN,
        HIDDEN,
        EXPOSED,
        MOVED,
        RESIZED,
        SIZE_CHANGED,
        MINIMIZED,
        MAXIMIZED,
        RESTORED,
        ENTER,
        LEAVE,
        FOCUS_GAINED,
        FOCUS_LOST,
        CLOSE,
    }

    enum WindowFlags
    {
        Default = 0,
        FULLSCREEN = 0x00000001,
        OPENGL = 0x00000002,
        SHOWN = 0x00000004,
        HIDDEN = 0x00000008,
        BORDERLESS = 0x00000010,
        RESIZABLE = 0x00000020,
        MINIMIZED = 0x00000040,
        MAXIMIZED = 0x00000080,
        INPUT_GRABBED = 0x00000100,
        INPUT_FOCUS = 0x00000200,
        MOUSE_FOCUS = 0x00000400,
        FULLSCREEN_DESKTOP = (FULLSCREEN | 0x00001000),
        FOREIGN = 0x00000800,
        ALLOW_HIGHDPI = 0x00002000,
    }

    #endregion

    #region Structs

    struct ControllerAxisEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
        public GameControllerAxis Axis;
        byte padding1;
        byte padding2;
        byte padding3;
        public short Value;
        ushort padding4;
    }

    struct ControllerButtonEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
        public GameControllerButton Button;
        public State State;
        byte padding1;
        byte padding2;
    }

    struct ControllerDeviceEvent
    {
        public EventType Type;
        public uint Timestamp;

        /// <summary>
        /// The joystick device index for the ADDED event, instance id for the REMOVED or REMAPPED event
        /// </summary>
        public int Which;
    }

    struct DisplayMode
    {
        public uint Format;
        public int Width;
        public int Height;
        public int RefreshRate;
        public IntPtr DriverData;
    }

    [StructLayout(LayoutKind.Explicit)]
    struct Event
    {
        [FieldOffset(0)]
        public EventType Type;
        [FieldOffset(0)]
        public WindowEvent Window;
        [FieldOffset(0)]
        public KeyboardEvent Key;
        [FieldOffset(0)]
        public TextEditingEvent Edit;
        [FieldOffset(0)]
        public TextInputEvent Text;
        [FieldOffset(0)]
        public MouseMotionEvent Motion;
        [FieldOffset(0)]
        public MouseButtonEvent Button;
        [FieldOffset(0)]
        public MouseWheelEvent Wheel;
        [FieldOffset(0)]
        public JoyAxisEvent JoyAxis;
        [FieldOffset(0)]
        public JoyBallEvent JoyBall;
        [FieldOffset(0)]
        public JoyHatEvent JoyHat;
        [FieldOffset(0)]
        public JoyButtonEvent JoyButton;
        [FieldOffset(0)]
        public JoyDeviceEvent JoyDevice;
        [FieldOffset(0)]
        public ControllerAxisEvent ControllerAxis;
        [FieldOffset(0)]
        public ControllerButtonEvent ControllerButton;
        [FieldOffset(0)]
        public ControllerDeviceEvent ControllerDevice;
#if false
        [FieldOffset(0)]
        public QuitEvent quit;
        [FieldOffset(0)]
        public UserEvent user;
        [FieldOffset(0)]
        public SysWMEvent syswm;
        [FieldOffset(0)]
        public TouchFingerEvent tfinger;
        [FieldOffset(0)]
        public MultiGestureEvent mgesture;
        [FieldOffset(0)]
        public DollarGestureEvent dgesture;
        [FieldOffset(0)]
        public DropEvent drop;
#endif

        // Ensure the structure is big enough
        // This hack is necessary to ensure compatibility
        // with different SDL versions, which might have
        // different sizeof(SDL_Event).
        [FieldOffset(0)]
        private unsafe fixed byte reserved[128];
    }

    [StructLayout(LayoutKind.Explicit)]
    struct GameControllerButtonBind
    {
        [FieldOffset(0)]
        public GameControllerBindType BindType;
        [FieldOffset(4)]
        public Button Button;
        [FieldOffset(4)]
        public GameControllerAxis Axis;
        [FieldOffset(4)]
        public int Hat;
        [FieldOffset(8)]
        public int HatMask;
    }

    struct JoyAxisEvent
    {
        public EventType Type;
        public UInt32 Timestamp;
        public Int32 Which; // SDL_JoystickID
        public byte Axis;
        byte padding1;
        byte padding2;
        byte padding3;
        public Int16 Value;
        UInt16 padding4;
    }

    struct JoyBallEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
        public byte Ball;
        byte padding1;
        byte padding2;
        byte padding3;
        public short Xrel;
        public short Yrel;
    }

    struct JoyButtonEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
        public byte Button;
        public State State;
        byte padding1;
        byte padding2;
    }

    struct JoyDeviceEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
    }

    struct JoyHatEvent
    {
        public EventType Type;
        public uint Timestamp;
        public int Which;
        public byte Hat;
        public HatPosition Value;
        byte padding1;
        byte padding2;
    }

    struct JoystickGuid
    {
        unsafe fixed byte data[16];

        public Guid ToGuid()
        {
            byte[] bytes = new byte[16];

            unsafe
            {
                fixed (byte* pdata = data)
                {
                    Marshal.Copy(new IntPtr(pdata), bytes, 0, bytes.Length); 
                }
            }

            return new Guid(bytes);
        }
    }

    struct KeyboardEvent
    {
        public EventType Type;
        public uint Timestamp;
        public uint WindowID;
        public State State;
        public byte Repeat;
        byte padding2;
        byte padding3;
        public Keysym Keysym;
    }

    struct Keysym
    {
        public Scancode Scancode;
        public Keycode Sym;
        public Keymod Mod;
        [Obsolete]
        public uint Unicode;
    }

    struct MouseButtonEvent
    {
        public EventType Type;
        public UInt32 Timestamp;
        public UInt32 WindowID;
        public UInt32 Which;
        public Button Button;
        public State State;
        public byte Clicks;
        byte padding1;
        public Int32 X;
        public Int32 Y;
    }

    struct MouseMotionEvent
    {
        public EventType Type;
        public uint Timestamp;
        public uint WindowID;
        public uint Which;
        public ButtonFlags State;
        public Int32 X;
        public Int32 Y;
        public Int32 Xrel;
        public Int32 Yrel;
    }

    struct MouseWheelEvent
    {
        public EventType Type;
        public uint Timestamp;
        public uint WindowID;
        public uint Which;
        public int X;
        public int Y;

        public enum EventType : uint
        {
            /* Touch events */
            FingerDown      = 0x700,
            FingerUp,
            FingerMotion,

            /* Gesture events */
            DollarGesture   = 0x800,
            DollarRecord,
            MultiGesture,
        }

        public const uint TouchMouseID = 0xffffffff;
    }

    struct Rect
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
    }

    struct SysWMInfo
    {
        public Version Version;
        public SysWMType Subsystem;
        public SysInfo Info;

        [StructLayout(LayoutKind.Explicit)]
        public struct SysInfo
        {
            [FieldOffset(0)]
            public WindowsInfo Windows;
            [FieldOffset(0)]
            public X11Info X11;
            [FieldOffset(0)]
            public WaylandInfo Wayland;
            [FieldOffset(0)]
            public DirectFBInfo DirectFB;
            [FieldOffset(0)]
            public CocoaInfo Cocoa;
            [FieldOffset(0)]
            public UIKitInfo UIKit;

            public struct WindowsInfo
            {
                public IntPtr Window;
            }

            public struct X11Info
            {
                public IntPtr Display;
                public IntPtr Window;
            }

            public struct WaylandInfo
            {
                public IntPtr Display;
                public IntPtr Surface;
                public IntPtr ShellSurface;
            }

            public struct DirectFBInfo
            {
                public IntPtr Dfb;
                public IntPtr Window;
                public IntPtr Surface;
            }

            public struct CocoaInfo
            {
                public IntPtr Window;
            }

            public struct UIKitInfo
            {
                public IntPtr Window;
            }
        }
    }

    struct TextEditingEvent
    {
        public const int TextSize = 32;

        public EventType Type;
        public UInt32 Timestamp;
        public UInt32 WindowID;
        public unsafe fixed byte Text[TextSize];
        public Int32 Start;
        public Int32 Length;
    }

    struct TextInputEvent
    {
        public const int TextSize = 32;

        public EventType Type;
        public UInt32 Timestamp;
        public UInt32 WindowID;
        public unsafe fixed byte Text[TextSize];
    }

    struct Version
    {
        public byte Major;
        public byte Minor;
        public byte Patch;

        public int Number
        {
            get { return 1000 * Major + 100 * Minor + Patch; }
        }
    }

    struct WindowEvent
    {
        public EventType Type;
        public UInt32 Timestamp;
        public UInt32 WindowID;
        public WindowEventID Event;
        byte padding1;
        byte padding2;
        byte padding3;
        public Int32 Data1;
        public Int32 Data2;
    }

    #endregion
}

