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

namespace OpenToolkit.Windowing.GraphicsLibraryFramework.Interfaces
{
    /// <summary>
    ///     Defines the public interface of the GLFW 3.2 library
    /// </summary>
    [NativeSymbols(Prefix = "glfw")]
    internal interface IGLFW
    {
        bool Init();
        void Terminate();
        unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share);
        unsafe void DestroyWindow(Window* window);
        unsafe void FocusWindow(Window* window);
        unsafe void GetFramebufferSize(Window* window, out int width, out int height);
        unsafe InputModeValue GetInputMode(Window* window, InputMode mode);
        unsafe Monitor* GetPrimaryMonitor();
        unsafe VideoMode* GetVideoMode(Monitor* monitor);
        unsafe int GetWindowAttrib(Window* window, int attribute);
        unsafe void GetWindowSize(Window* window, out int width, out int height);
        unsafe void GetWindowPos(Window* window, out int x, out int y);
        unsafe Monitor* GetWindowMonitor(Window* window);
        unsafe void HideWindow(Window* window);
        unsafe void IconifyWindow(Window* window);
        unsafe void MakeContextCurrent(Window* window);
        unsafe void MaximizeWindow(Window* window);
        unsafe void RestoreWindow(Window* window);
        unsafe void SetErrorCallback(Action<int, string> callback);
        unsafe void SetInputMode(Window* window, InputMode mode, InputModeValue value);
        unsafe void SetWindowIcon(Window* window, int count, Image* images);
        unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width, int height, int refreshRate);
        unsafe void SetWindowPos(Window* window, int x, int y);
        unsafe void SetWindowSize(Window* window, int width, int height);
        unsafe void SetWindowShouldClose(Window* window);
        unsafe void SetWindowTitle(Window* window, string title);
        unsafe void ShowWindow(Window* window);
        void WindowHint(WindowHint hint, int value);
        unsafe int WindowShouldClose(Window* window);
    }
}