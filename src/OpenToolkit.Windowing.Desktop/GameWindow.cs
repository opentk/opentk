//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics;
using System.Threading;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.GraphicsLibraryFramework;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// The <see cref="GameWindow"/> class contains cross-platform methods to create and render on an OpenGL
    /// window, handle input and load resources.
    /// </summary>
    /// <remarks>
    /// <see cref="GameWindow"/> contains several events you can hook or override to add your custom logic:
    /// <list>
    /// <item>
    /// <see cref="OnLoad"/>: Occurs after creating the OpenGL context, but before entering the main loop.
    /// Override to load resources.
    /// </item>
    /// <item>
    /// <see cref="OnUnload"/>: Occurs after exiting the main loop, but before deleting the OpenGL context.
    /// Override to unload resources.
    /// </item>
    /// <item>
    /// <see cref="NativeWindow.OnResize"/>: Occurs whenever GameWindow is resized. You should update the OpenGL Viewport
    /// and Projection Matrix here.
    /// </item>
    /// <item>
    /// <see cref="OnUpdateFrame"/>: Occurs at the specified logic update rate. Override to add your game
    /// logic.
    /// </item>
    /// <item>
    /// <see cref="OnRenderFrame"/>: Occurs at the specified frame render rate. Override to add your
    /// rendering code.
    /// </item>
    /// </list>
    /// </remarks>
    public class GameWindow : NativeWindow, IGameWindow
    {
        /// <inheritdoc/>
        public event Action Load;

        /// <inheritdoc/>
        public event Action Unload;

        /// <inheritdoc/>
        public event Action<FrameEventArgs> UpdateFrame;

        /// <inheritdoc/>
        public event Action RenderThreadStarted;

        /// <inheritdoc/>
        public event Action<FrameEventArgs> RenderFrame;

        /// <summary>
        /// Frequency cap for Update/RenderFrame events.
        /// </summary>
        private const double MaxFrequency = 500.0;

        private readonly Stopwatch _watchRender = new Stopwatch();
        private readonly Stopwatch _watchUpdate = new Stopwatch();

        // private IGraphicsContext glContext; //HIGH: Implement with OpenGL ADL Bindings

        /// <summary>
        /// Gets a value indicating whether or not UpdatePeriod has consistently failed to reach TargetUpdatePeriod.
        /// This can be used to do things such as decreasing visual quality if the user's computer isn't powerful enough
        /// to handle the application.
        /// </summary>
        protected bool IsRunningSlowly { get; private set; }

        private double _updateEpsilon; // quantization error for UpdateFrame events

        private double _renderFrequency;
        private double _updateFrequency;

        private Thread _renderThread;

        /// <inheritdoc/>
        public bool IsMultiThreaded { get; }

        /// <inheritdoc />
        public double RenderFrequency
        {
            get => _renderFrequency;

            set
            {
                if (value <= 1.0)
                {
                    _renderFrequency = 0.0;
                }
                else if (value <= MaxFrequency)
                {
                    _renderFrequency = value;
                }
                else
                {
                    Debug.Print("Target render frequency clamped to {0}Hz.", MaxFrequency);
                    _renderFrequency = MaxFrequency;
                }
            }
        }

        /// <inheritdoc />
        public double RenderTime { get; protected set; }

        /// <inheritdoc />
        public double UpdateFrequency
        {
            get => _updateFrequency;

            set
            {
                if (value < 1.0)
                {
                    _updateFrequency = 0.0;
                }
                else if (value <= MaxFrequency)
                {
                    _updateFrequency = value;
                }
                else
                {
                    Debug.Print("Target render frequency clamped to {0}Hz.", MaxFrequency);
                    _updateFrequency = MaxFrequency;
                }
            }
        }

        private VSyncMode _vSync;

        /// <inheritdoc />
        public VSyncMode VSync
        {
            get => _vSync;
            set
            {
                switch (value)
                {
                    case VSyncMode.On:
                        GLFW.SwapInterval(1);
                        break;

                    case VSyncMode.Off:
                        GLFW.SwapInterval(0);
                        break;

                    case VSyncMode.Adaptive:
                        GLFW.SwapInterval(IsRunningSlowly ? 0 : 1);
                        break;
                    }

                _vSync = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameWindow"/> class with sensible default attributes.
        /// </summary>
        /// <param name="gameWindowSettings">The <see cref="GameWindow"/> related settings.</param>
        /// <param name="nativeWindowSettings">The <see cref="NativeWindow"/> related settings.</param>
        /// <remarks>
        /// <para>
        /// Use GameWindowSettings.Default and NativeWindowSettings.Default to get some sensible default attributes.
        /// </para>
        /// </remarks>
        public GameWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(nativeWindowSettings)
        {
            IsMultiThreaded = gameWindowSettings.IsMultiThreaded;

            RenderFrequency = gameWindowSettings.RenderFrequency;
            UpdateFrequency = gameWindowSettings.UpdateFrequency;
        }

        /// <inheritdoc />
        public virtual void Run()
        {
            // Make sure the GameWindow is visible when it first runs.
            IsVisible = true;

            // Send the OnLoad event, to load all user code.
            OnLoad();

            // Send a redundant OnResize event, to make sure all user code has the correct values.
            OnResize(new ResizeEventArgs(Size));

            Debug.Print("Entering main loop.");
            if (IsMultiThreaded)
            {
                _renderThread = new Thread(StartRenderThread);
                _renderThread.Start();
            }

            _watchRender.Start();
            _watchUpdate.Start();
            while (true)
            {
                ProcessEvents();

                if (!Exists || IsExiting)
                {
                    return;
                }

                DispatchUpdateFrame();

                if (!IsMultiThreaded)
                {
                    DispatchRenderFrame();
                }
            }
        }

        private void StartRenderThread()
        {
            OnRenderThreadStarted();
            _watchRender.Start();
            while (Exists && !IsExiting)
            {
                DispatchRenderFrame();
            }
        }

        private void DispatchUpdateFrame()
        {
            var isRunningSlowlyRetries = 4;
            var elapsed = _watchUpdate.Elapsed.TotalSeconds;

            var updatePeriod = UpdateFrequency == 0 ? 0 : 1 / UpdateFrequency;

            while (elapsed > 0 && elapsed + _updateEpsilon >= updatePeriod)
            {
                _watchUpdate.Restart();
                OnUpdateFrame(new FrameEventArgs(elapsed));

                // Calculate difference (positive or negative) between
                // actual elapsed time and target elapsed time. We must
                // compensate for this difference.
                _updateEpsilon += elapsed - updatePeriod;

                if (UpdateFrequency <= double.Epsilon)
                {
                    // An UpdateFrequency of zero means we will raise
                    // UpdateFrame events as fast as possible (one event
                    // per ProcessEvents() call)
                    break;
                }

                IsRunningSlowly = _updateEpsilon >= updatePeriod;
                if (IsRunningSlowly && --isRunningSlowlyRetries == 0)
                {
                    // If UpdateFrame consistently takes longer than TargetUpdateFrame
                    // stop raising events to avoid hanging inside the UpdateFrame loop.
                    break;
                }

                elapsed = _watchUpdate.Elapsed.TotalSeconds;
            }

            // Update VSync if set to adaptive
            if (_vSync == VSyncMode.Adaptive)
            {
                GLFW.SwapInterval(IsRunningSlowly ? 0 : 1);
            }
        }

        private void DispatchRenderFrame()
        {
            var elapsed = _watchRender.Elapsed.TotalSeconds;
            var renderPeriod = RenderFrequency == 0 ? 0 : 1 / RenderFrequency;
            if (elapsed > 0 && elapsed >= renderPeriod)
            {
                _watchRender.Restart();
                OnRenderFrame(new FrameEventArgs(elapsed));
            }
        }

        /// <inheritdoc />
        public virtual void SwapBuffers()
        {
            unsafe
            {
                GLFW.SwapBuffers(WindowPtr);
            }
        }

        /// <inheritdoc />
        public override void Close()
        {
            OnUnload();
            base.Close();
        }

        /// <summary>
        /// Run when the update thread is started. This will never run if you set IsSingleThreaded to true.
        /// </summary>
        protected virtual void OnRenderThreadStarted()
        {
            RenderThreadStarted?.Invoke();
        }

        /// <summary>
        /// Run immediately after Run() is called.
        /// </summary>
        protected virtual void OnLoad()
        {
            Load?.Invoke();
        }

        /// <summary>
        /// Run when the window is about to close.
        /// </summary>
        protected virtual void OnUnload()
        {
            Unload?.Invoke();
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnUpdateFrame(FrameEventArgs args)
        {
            UpdateFrame?.Invoke(args);
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnRenderFrame(FrameEventArgs args)
        {
            RenderFrame?.Invoke(args);
        }
    }
}
