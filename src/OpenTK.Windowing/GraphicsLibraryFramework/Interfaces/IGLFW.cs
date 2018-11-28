//
// IGLFW.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework.Interfaces
{
    /// <summary>
    /// Defines the public interface of the GLFW 3.2 library
    /// </summary>
    [NativeSymbols(Prefix = "glfw")]
    internal interface IGLFW
    {
        bool Init();
        void Terminate();
        unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor, Window* share);
        unsafe Monitor* GetPrimaryMonitor();
        unsafe void DestroyWindow(Window* window);
        unsafe VideoMode* GetVideoMode(Monitor* monitor);
        void WindowHint(WindowHint hint, int value);
        unsafe int WindowShouldClose(Window* window);
        unsafe void SetWindowShouldClose(Window* window);
        unsafe void SetWindowTitle(Window* window);
        unsafe void SetWindowIcon(Window* window, int count, Image* images);
    }
}
