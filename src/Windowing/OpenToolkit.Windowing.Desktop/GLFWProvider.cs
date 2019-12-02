﻿//
// GLFWProvider.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Threading;
using OpenToolkit.GraphicsLibraryFramework;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    internal static class GLFWProvider
    {
        // NOTE: This assumption about "main thread" is flat wrong.
        // We literally can't tell whether this is actually the main thread.
        private static Thread _mainThread;

        private static GLFWCallbacks.ErrorCallback ErrorCallback { get; } =
            (errorCode, description) => throw new GLFWException(description, errorCode);

        private static GLFW CreateGlfw()
        {
            var mainThread = Interlocked.CompareExchange(ref _mainThread, Thread.CurrentThread, null);
            if (mainThread != null && mainThread == Thread.CurrentThread)
            {
                throw new GLFWException("Initialization on wrong thread(should never happen).");
            }
            var glfw = GraphicsLibraryFramework.GLFW.GetAPI();
            glfw.Init();
            glfw.SetErrorCallback(ErrorCallback);
            return glfw;
        }

        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<GLFW> GLFW { get; private set; } = new Lazy<GLFW>(CreateGlfw);

        /// <summary>
        /// Gets a value indicating whether the <see cref="Thread.CurrentThread"/> is the same as the GLFW main thread.
        /// </summary>
        public static bool IsOnMainThread => GLFW.Value != null && _mainThread == Thread.CurrentThread;

        /// <summary>
        /// Unloads the loaded <see cref="GLFW"/> interface implementation.
        /// </summary>
        public static void Unload()
        {
            var mainThread = Interlocked.CompareExchange(ref _mainThread, null, Thread.CurrentThread);
            if (mainThread != Thread.CurrentThread)
            {
                throw new GLFWException("Glfw termination only possible from glfw main thread.");
            }
            GLFW.Value.Terminate();
            GLFW = new Lazy<GLFW>(CreateGlfw);
        }
    }
}
