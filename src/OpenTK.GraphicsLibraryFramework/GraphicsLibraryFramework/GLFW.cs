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
using OpenToolkit.GraphicsLibraryFramework;

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
        public abstract unsafe int GetWindowAttrib(Window* window, int attribute);

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
        public abstract unsafe void SetCursorPosCallback(Window* window, Action<Window, int, int> callback);

        /// <inheritdoc />
        public abstract unsafe void SetDropCallback(Window* window, Action<Window, int, string> callback);

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
        public abstract unsafe void SetWindowShouldClose(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPos(Window* window, int x, int y);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPosCallback(Window* window, Action<Window, int, int> callback);

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
