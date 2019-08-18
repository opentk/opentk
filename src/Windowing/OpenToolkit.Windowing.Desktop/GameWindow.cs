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
        public event EventHandler<EventArgs> Load;

        /// <inheritdoc/>
        public event EventHandler<EventArgs> Unload;

        /// <inheritdoc/>
        public event EventHandler<FrameEventArgs> UpdateFrame;

        /// <inheritdoc/>
        public event EventHandler<EventArgs> RenderThreadStarted;

        /// <inheritdoc/>
        public event EventHandler<FrameEventArgs> RenderFrame;

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
        public bool IsSingleThreaded { get; }

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
                        Glfw.SwapInterval(1);
                        break;

                    case VSyncMode.Off:
                        Glfw.SwapInterval(0);
                        break;

                    case VSyncMode.Adaptive:
                        Glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
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
        public GameWindow(IGameWindowProperties gameWindowSettings, INativeWindowProperties nativeWindowSettings)
            : base(nativeWindowSettings)
        {
            IsSingleThreaded = gameWindowSettings.IsSingleThreaded;

            RenderFrequency = gameWindowSettings.RenderFrequency;
            UpdateFrequency = gameWindowSettings.UpdateFrequency;
        }

        /// <inheritdoc />
        public virtual void Run()
        {
            // Make sure the GameWindow is visible when it first runs.
            IsVisible = true;

            // Send the OnLoad event, to load all user code.
            OnLoad(this, EventArgs.Empty);

            // Send a redundant OnResize event, to make sure all user code has the correct values.
            OnResize(this, new ResizeEventArgs(Width, Height));

            Debug.Print("Entering main loop.");
            if (!IsSingleThreaded)
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

                if (IsSingleThreaded)
                {
                    DispatchRenderFrame();
                }
            }
        }

        private void StartRenderThread()
        {
            OnRenderThreadStarted(this, EventArgs.Empty);
            _watchRender.Start();
            while (Exists && !IsExiting)
            {
                DispatchRenderFrame();
            }
        }

        private void DispatchUpdateFrame()
        {
            var isRunningSlowlyRetries = 4;
            var elapsed = _watchUpdate.Elapsed.TotalMilliseconds;

            var updatePeriod = UpdateFrequency == 0 ? 0 : 1 / UpdateFrequency;

            while (elapsed > 0 && elapsed + _updateEpsilon >= updatePeriod)
            {
                OnUpdateFrame(this, new FrameEventArgs(elapsed));

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
            }

            // Update VSync if set to adaptive
            if (_vSync == VSyncMode.Adaptive)
            {
                Glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
            }

            _watchUpdate.Restart();
        }

        private void DispatchRenderFrame()
        {
            var timestamp = _watchRender.Elapsed.TotalMilliseconds;
            OnRenderFrame(this, new FrameEventArgs(timestamp));
            _watchRender.Restart();
        }

        /// <inheritdoc />
        public virtual void SwapBuffers()
        {
            unsafe
            {
                Glfw.SwapBuffers(WindowPtr);
            }
        }

        /// <inheritdoc />
        public override void Close()
        {
            OnUnload(this, EventArgs.Empty);
            base.Close();
        }

        /// <summary>
        /// Run when the update thread is started. This will never run if you set IsSingleThreaded to true.
        /// </summary>
        /// <param name="sender">A reference to the window that ran the function.</param>
        /// <param name="args">The event arguments. Always empty for this function.</param>
        protected virtual void OnRenderThreadStarted(object sender, EventArgs args)
        {
            RenderThreadStarted?.Invoke(sender, args);
        }

        /// <summary>
        /// Run immediately after Run() is called.
        /// </summary>
        /// <param name="sender">A reference to the window that ran the function.</param>
        /// <param name="args">The event arguments. Always empty for this function.</param>
        protected virtual void OnLoad(object sender, EventArgs args)
        {
            Load?.Invoke(sender, args);
        }

        /// <summary>
        /// Run when the window is about to close.
        /// </summary>
        /// <param name="sender">A reference to the window that ran the function.</param>
        /// <param name="args">The event arguments. Always empty for this function.</param>
        protected virtual void OnUnload(object sender, EventArgs args)
        {
            Unload?.Invoke(sender, args);
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="sender">A reference to the window that ran the function.</param>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnUpdateFrame(object sender, FrameEventArgs args)
        {
            UpdateFrame?.Invoke(sender, args);
        }

        /// <summary>
        /// Run when the window is ready to update.
        /// </summary>
        /// <param name="sender">A reference to the window that ran the function.</param>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnRenderFrame(object sender, FrameEventArgs args)
        {
            RenderFrame?.Invoke(sender, args);
        }
    }
}
