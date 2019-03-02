//
// IGLFW.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;

namespace OpenToolkit.GraphicsLibraryFramework
{
    //TODO: Enums for GLFW keys/mouse buttons
    
    /// <summary>
    ///     Defines the public interface of the GLFW 3.2 library
    /// </summary>
    [NativeSymbols(Prefix = "glfw")]
    internal interface IGLFW
    {
        bool Init();
        void Terminate();
        
        void InitHint(InitHint hint, int value);
        void GetVersion(out int major, out int minor, out int revision);
        unsafe char* GetVersionString();
        unsafe int GetError(char** description);
        unsafe Monitor** GetMonitors(out int count);
        unsafe void GetMonitorPos(Monitor* monitor, out int x, out int y);
        unsafe void GetMonitorPhysicalSize(Monitor* monitor, out int width, out int height);
        unsafe void GetMonitorContentScale(Monitor* monitor, out float xscale, out float yscale);
        unsafe char* GetMonitorName(Monitor* monitor);
        unsafe void SetMonitorUserPointer(Monitor* monitor, IntPtr pointer);
        unsafe IntPtr GetMonitorUserPointer(Monitor* monitor);
        unsafe VideoMode* GetVideoModes(Monitor* monitor, out int count);
        unsafe void SetGamma(Monitor* monitor, float gamma);
        unsafe GammaRamp* GetGammaRamp(Monitor* monitor);
        unsafe void SetGammaRamp(Monitor* monitor, GammaRamp* ramp);
        void DefaultWindowHints();
        void WindowHintString(int hint, string value);
        unsafe void SetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth, int maxheight);
        unsafe void SetWindowAspectRatio(Window* window, int numer, int denom);
        unsafe void GetWindowFrameSize(Window* window, out int left, out int top, out int right, out int bottom);
        unsafe float GetWindowOpacity(Window* window);
        unsafe void SetWindowOpacity(Window* window, float opacity);
        unsafe void RequestWindowAttention(Window* window);
        unsafe void SetWindowAttrib(Window* window, WindowAttribute attribute, int value);
        bool RawMouseMotionSupported();
        unsafe char* GetKeyName(int key, int scancode);
        int GetKeyScancode(int key);
        unsafe int GetKey(Window* window, int key);
        unsafe int GetMouseButton(Window* window, int button);
        unsafe void GetCursorPos(Window* window, out double xpos, out double ypos);
        unsafe void SetCursorPos(Window* window, double xpos, double ypos);
        unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);
        unsafe Cursor* CreateStandardCursor(CursorShape shape);
        unsafe void DestroyCursor(Cursor* cursor);
        unsafe void SetCursor(Window* window, Cursor* cursor);
        int JoystickPresent(int jid);
        unsafe float* GetJoystickAxes(int jid, out int count);
        
        unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share);
        unsafe void DestroyWindow(Window* window);
        unsafe void FocusWindow(Window* window);
        unsafe string GetClipboardString(Window* window);
        unsafe void GetFramebufferSize(Window* window, out int width, out int height);
        unsafe InputModeValue GetInputMode(Window* window, InputMode mode);
        unsafe Monitor* GetPrimaryMonitor();
        unsafe VideoMode* GetVideoMode(Monitor* monitor);
        unsafe int GetWindowAttrib(Window* window, WindowAttribute attribute);
        unsafe void GetWindowSize(Window* window, out int width, out int height);
        unsafe void GetWindowPos(Window* window, out int x, out int y);
        unsafe Monitor* GetWindowMonitor(Window* window);
        unsafe void HideWindow(Window* window);
        unsafe void IconifyWindow(Window* window);
        unsafe void MakeContextCurrent(Window* window);
        unsafe void MaximizeWindow(Window* window);
        void PollEvents();
        void PostEmptyEvent();
        unsafe void RestoreWindow(Window* window);
        unsafe void SetCharCallback(Window* window, Action<Window, int> callback); //TODO: Make enum for int param in callback
        unsafe void SetCharModsCallback(Window* window, Action<Window, int, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetClipboardString(Window* window, string data);
        unsafe void SetCursorEnterCallback(Window* window, Action<Window, bool> callback);
        unsafe void SetCursorPosCallback(Window* window, Action<Window, int, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetDropCallback(Window* window, Action<Window, int, string> callback); //TODO: Make enum for int param in callback
        unsafe void SetErrorCallback(Action<int, string> callback); //TODO: Make enum for int param in callback
        unsafe void SetInputMode(Window* window, InputMode mode, InputModeValue value);
        unsafe void SetJoystickCallback(Action<int, int> callback);
        unsafe void SetKeyCallback(Window* window, Action<Window, int, int, InputAction, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetScrollCallback(Window* window, Action<Window, int, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetMonitorCallback(Action<Monitor, int> callback); //TODO: Make enum for int param in callback
        unsafe void SetMouseButtonCallback(Window* window, Action<Window, int, InputAction, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetWindowCloseCallback(Window* window, Action<Window> callback);
        unsafe void SetWindowFocusCallback(Window* window, Action<Window, bool> callback);
        unsafe void SetWindowIcon(Window* window, int count, Image* images);
        unsafe void SetWindowIconifyCallback(Window* window, Action<Window, bool> callback);
        unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);
        unsafe void SetWindowPos(Window* window, int x, int y);
        unsafe void SetWindowPosCallback(Window* window, Action<Window, int, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetWindowSize(Window* window, int width, int height);
        unsafe void SetWindowSizeCallback(Window* window, Action<int, int> callback); //TODO: Make enums for int params in callback
        unsafe void SetWindowShouldClose(Window* window, int value);
        unsafe void SetWindowTitle(Window* window, string title);
        unsafe void ShowWindow(Window* window);
        void SetSwapInterval(int interval);
        void WaitEvents();
        void WaitEventsTimeout(double timeout);
        void WindowHint(WindowHint hint, int value);
        unsafe bool WindowShouldClose(Window* window);
    }
}