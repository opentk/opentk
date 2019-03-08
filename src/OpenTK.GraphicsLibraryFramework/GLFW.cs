//
// GLFW.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Provides access to the GLFW API.
    /// </summary>
    public abstract class GLFW : NativeLibraryBase, IGLFW
    {
        public static Action<int, string> errorCallback = (errorCode, description) => { throw new GLFWException(description) { ErrorCode = errorCode }; };

        /// <inheritdoc cref="NativeLibraryBase"/>
        protected GLFW(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract bool Init();

        /// <inheritdoc />
        public abstract void Terminate();

        /// <inheritdoc />
        public abstract void InitHint(InitHint hint, int value);

        /// <inheritdoc />
        public abstract void GetVersion(out int major, out int minor, out int revision);

        /// <inheritdoc />
        public abstract string GetVersionString();

        /// <inheritdoc />
        public abstract unsafe int GetError(char** description);
        
        /// <inheritdoc />
        public abstract unsafe Monitor** GetMonitors(out int count);
        
        /// <inheritdoc />
        public abstract unsafe void GetMonitorPos(Monitor* monitor, out int x, out int y);

        /// <inheritdoc />
        public abstract unsafe void GetMonitorPhysicalSize(Monitor* monitor, out int width, out int height);
        
        /// <inheritdoc />
        public abstract unsafe void GetMonitorContentScale(Monitor* monitor, out float xscale, out float yscale);
        
        /// <inheritdoc />
        public abstract unsafe string GetMonitorName(Monitor* monitor);
        
        /// <inheritdoc />
        public abstract unsafe void SetMonitorUserPointer(Monitor* monitor, IntPtr pointer);

        /// <inheritdoc />
        public abstract unsafe IntPtr GetMonitorUserPointer(Monitor* monitor);
        
        /// <inheritdoc />
        public abstract unsafe VideoMode* GetVideoModes(Monitor* monitor, out int count);
        
        /// <inheritdoc />
        public abstract unsafe void SetGamma(Monitor* monitor, float gamma);
        
        /// <inheritdoc />
        public abstract unsafe GammaRamp* GetGammaRamp(Monitor* monitor);
        
        /// <inheritdoc />
        public abstract unsafe void SetGammaRamp(Monitor* monitor, GammaRamp* ramp);

        /// <inheritdoc />
        public abstract void DefaultWindowHints();

        /// <inheritdoc />
        public abstract void WindowHintString(int hint, string value);
        
        /// <inheritdoc />
        public abstract unsafe void SetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth, int maxheight);

        /// <inheritdoc />
        public abstract unsafe void SetWindowAspectRatio(Window* window, int numer, int denom);
        
        /// <inheritdoc />
        public abstract unsafe void GetWindowFrameSize(Window* window, out int left, out int top, out int right, out int bottom);
        
        /// <inheritdoc />
        public abstract unsafe float GetWindowOpacity(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowOpacity(Window* window, float opacity);
        
        /// <inheritdoc />
        public abstract unsafe void RequestWindowAttention(Window* window);
        
        /// <inheritdoc />
        public abstract unsafe void SetWindowAttrib(Window* window, WindowAttribute attrib, int value);

        /// <inheritdoc />
        public abstract bool RawMouseMotionSupported();

        /// <inheritdoc />
        public abstract string GetKeyName(int key, int scancode);

        /// <inheritdoc />
        public abstract int GetKeyScancode(int key);
        
        /// <inheritdoc />
        public abstract unsafe int GetKey(Window* window, int key);
        
        /// <inheritdoc />
        public abstract unsafe int GetMouseButton(Window* window, int button);
        
        /// <inheritdoc />
        public abstract unsafe void GetCursorPos(Window* window, out double xpos, out double ypos);

        /// <inheritdoc />
        public abstract unsafe void SetCursorPos(Window* window, double xpos, double ypos);
        
        /// <inheritdoc />
        public abstract unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);

        /// <inheritdoc />
        public abstract unsafe Cursor* CreateStandardCursor(CursorShape shape);

        /// <inheritdoc />
        public abstract unsafe void DestroyCursor(Cursor* cursor);

        /// <inheritdoc />
        public abstract unsafe void SetCursor(Window* window, Cursor* cursor);
        
        /// <inheritdoc />
        public abstract int JoystickPresent(int jid);

        /// <inheritdoc />
        public abstract unsafe float* GetJoystickAxes(int jid, out int count);

        /// <inheritdoc />
        public abstract unsafe byte* GetJoystickButtons(int jid, out int count);

        /// <inheritdoc />
        public abstract unsafe byte* GetJoystickHats(int jid, out int count);
        
        /// <inheritdoc />
        public abstract string GetJoystickName(int jid);
        
        /// <inheritdoc />
        public abstract string GetJoystickGUID(int jid);

        /// <inheritdoc />
        public abstract void SetJoystickUserPointer(int jid, IntPtr ptr);

        /// <inheritdoc />
        public abstract IntPtr GetJoystickUserPointer(int jid);

        /// <inheritdoc />
        public abstract bool JoystickIsGamepad(int jid);

        /// <inheritdoc />
        public abstract bool UpdateGamepadMappings(string newMapping);

        /// <inheritdoc />
        public abstract string GetJoystickname(int jid);
        
        /// <inheritdoc />
        public abstract bool GetGamepadState(int jid, out GamepadState state);

        /// <inheritdoc />
        public abstract double GetTime();

        /// <inheritdoc />
        public abstract void SetTime(double time);
        
        /// <inheritdoc />
        public abstract long GetTimerValue();
        
        /// <inheritdoc />
        public abstract long GetTimerFrequency();
        
        /// <inheritdoc />
        public abstract unsafe Window* GetCurrentContext();
        
        /// <inheritdoc />
        public abstract unsafe void SwapBuffers(Window* window);
        
        /// <inheritdoc />
        public abstract bool ExtensionSupported(string extensionName);

        /// <inheritdoc />
        public abstract bool VulkanSupported();

        public abstract unsafe char** GetRequiredInstanceExtensions(out int count);

        /// <inheritdoc />
        public abstract unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetPrimaryMonitor();

        /// <inheritdoc />
        public abstract unsafe void DestroyWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void FocusWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void GetFramebufferSize(Window* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe InputModeValue GetInputMode(Window* window, InputMode mode);

        /// <inheritdoc />
        public abstract unsafe void RestoreWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe VideoMode* GetVideoMode(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe int GetWindowAttrib(Window* window, WindowAttribute attribute);

        /// <inheritdoc />
        public abstract unsafe void GetWindowSize(Window* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe void GetWindowPos(Window* window, out int x, out int y);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetWindowMonitor(Window* window);

        /// <inheritdoc />
        public abstract unsafe void HideWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void IconifyWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void MakeContextCurrent(Window* window);

        /// <inheritdoc />
        public abstract unsafe void MaximizeWindow(Window* window);

        /// <inheritdoc />
        public abstract void PollEvents();

        /// <inheritdoc />
        public abstract void PostEmptyEvent();

        /// <inheritdoc />
        public abstract void WindowHint(WindowHint hint, int value);

        /// <inheritdoc />
        public abstract unsafe bool WindowShouldClose(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetCharCallback(Window* window, Action<Window, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetCharModsCallback(Window* window, Action<Window, int, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetCursorEnterCallback(Window* window, Action<Window, bool> callback);

        /// <inheritdoc />
        public abstract unsafe void SetCursorPosCallback(Window* window, Action<Window, double, double> callback);

        /// <inheritdoc />
        public abstract unsafe void SetDropCallback(Window* window, Action<Window, int, IntPtr> callback);

        /// <inheritdoc />
        public abstract unsafe void SetErrorCallback(Action<int, string> callback);

        /// <inheritdoc />
        public abstract unsafe void SetInputMode(Window* window, InputMode mode, InputModeValue value);

        /// <inheritdoc />
        public abstract unsafe void SetJoystickCallback(Action<int, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetKeyCallback(Window* window, Action<Window, int, int, InputAction, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetScrollCallback(Window* window, Action<Window, int, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetMonitorCallback(Action<Monitor, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetMouseButtonCallback(Window* window, Action<Window, int, InputAction, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowCloseCallback(Window* window, Action<Window> callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowFocusCallback(Window* window, Action<Window, bool> callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowIcon(Window* window, int count, Image* images);

        /// <inheritdoc />
        public abstract unsafe void SetWindowIconifyCallback(Window* window, Action<Window, bool> callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowTitle(Window* window, string title);

        /// <inheritdoc />
        public abstract unsafe void ShowWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowSize(Window* window, int width, int height);

        /// <inheritdoc />
        public abstract unsafe void SetWindowSizeCallback(Window* window, Action<int, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowShouldClose(Window* window, int value);

        /// <inheritdoc />
        public abstract unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPos(Window* window, int x, int y);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPosCallback(Window* window, Action<Window, int, int> callback);
        
        /// <inheritdoc />
        public abstract void SetSwapInterval(int interval);

        /// <inheritdoc />
        public abstract void WaitEvents();

        /// <inheritdoc />
        public abstract void WaitEventsTimeout(double timeout);
        
        /// <inheritdoc />
        public abstract unsafe string GetClipboardString(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetClipboardString(Window* window, string data);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static GLFW GetAPI()
        {
            return APILoader.Load<GLFW, GLFWLibraryNameContainer>();
        }
    }
}
