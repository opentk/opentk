﻿//
// GLFWProvider.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class GLFWProvider
    {
        // This will throw "through" native frames, which doesn't work anywhere other than windows.
        private static void DefaultErrorCallback(ErrorCode errorCode, string description)
        {
            throw new GLFWException(description, errorCode);
        }

        // FIXME: This will throw "through" native frames, which doesn't work anywhere other than windows.
        private static GLFWCallbacks.ErrorCallback ErrorCallback = DefaultErrorCallback;

        /// <summary>
        /// Sets the error handler callback that GLFW errors get reported to.
        /// </summary>
        /// <param name="errorCallback">The error callback delegate to set as the error callback.</param>
        public static void SetErrorCallback(GLFWCallbacks.ErrorCallback errorCallback)
        {
            // Take a reference to this delegate to keep it from being garbage collected.
            ErrorCallback = errorCallback;
            GLFW.SetErrorCallback(ErrorCallback);
        }

        // NOTE: This assumption about "main thread" is flat wrong.
        // We literally can't tell whether this is actually the main thread.
        // We keep it around as a tiny safe guard in case the first window IS done correctly and further ones aren't.
        private static Thread _mainThread;

        /// <summary>
        /// Gets a value indicating whether the <see cref="Thread.CurrentThread"/> is the same as the GLFW main thread.
        /// If <see cref="CheckForMainThread"/> is false this function will always return true.
        /// </summary>
        public static bool IsOnMainThread => CheckForMainThread == false || _mainThread == Thread.CurrentThread;

        /// <summary>
        /// Whether or not to check that GLFW is initialzed on the main thread.
        /// </summary>
        public static bool CheckForMainThread { get; set; } = true;

        private static bool Initialized = false;

        /// <summary>
        /// Makes sure GLFW is intialized.
        /// </summary>
        /// <exception cref="GLFWException">If this function is not called from the main thread and <see cref="CheckForMainThread"/> is true.</exception>
        public static void EnsureInitialized()
        {
            if (CheckForMainThread)
            {
                if (_mainThread == null)
                {
                    if (Thread.CurrentThread.IsBackground == false &&
                        Thread.CurrentThread.IsThreadPoolThread == false &&
                        Thread.CurrentThread.IsAlive)
                    {
                        MethodInfo correctEntryMethod = Assembly.GetEntryAssembly().EntryPoint;
                        StackTrace trace = new StackTrace();
                        StackFrame[] frames = trace.GetFrames();
                        for (int i = frames.Length - 1; i >= 0; i--)
                        {
                            MethodBase method = frames[i].GetMethod();
                            if (correctEntryMethod == method)
                            {
                                _mainThread = Thread.CurrentThread;
                                break;
                            }
                        }
                    }
                }

                if (_mainThread?.ManagedThreadId != Thread.CurrentThread.ManagedThreadId)
                {
                    throw new GLFWException("GLFW can only be called from the main thread!");
                }
            }

            if (Initialized == false)
            {
                GLFW.SetErrorCallback(ErrorCallback);
                GLFW.Init();
                Initialized = true;
            }
        }
    }
}
