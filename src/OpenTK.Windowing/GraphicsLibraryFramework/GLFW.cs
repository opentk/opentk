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
using OpenToolkit.Windowing.GraphicsLibraryFramework.Interfaces;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 API.
    /// </summary>
    public abstract class GLFW : NativeLibraryBase, IGLFW
    {
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
        public abstract unsafe VideoMode* GetVideoMode(Monitor* monitor);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHint hint, int value);

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
