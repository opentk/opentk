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
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
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
    public class GameWindow : NativeWindow
    {
        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        public event Action Load;

        /// <summary>
        /// Occurs before the window is destroyed.
        /// </summary>
        public event Action Unload;

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        public event Action<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// If game window is configured to run with a dedicated update thread (by passing isSingleThreaded = false in the
        /// constructor),
        /// occurs when the update thread has started. This would be a good place to initialize thread specific stuff (like
        /// setting a synchronization context).
        /// </summary>
        public event Action RenderThreadStarted;

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        public event Action<FrameEventArgs> RenderFrame;

        /// <summary>
        /// Frequency cap for Update/RenderFrame events.
        /// </summary>
        private const double MaxFrequency = 500.0;

        private readonly Stopwatch _watchRender = new Stopwatch();
        private readonly Stopwatch _watchUpdate = new Stopwatch();

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

        /// <summary>
        /// Gets a value indicating whether or not the GameWindow should use a separate thread for rendering.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     If this is true, render frames will be processed in a separate thread.
        ///     Do not enable this unless your code is thread safe.
        ///   </para>
        /// </remarks>
        public bool IsMultiThreaded { get; }

        /// <summary>
        /// Gets or sets a double representing the render frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
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

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        public double RenderTime { get; protected set; }

        /// <summary>
        /// Gets a double representing the time spent in the UpdateFrame function, in seconds.
        /// </summary>
        public double UpdateTime { get; protected set; }

        /// <summary>
        /// Gets or sets a double representing the update frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
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

        /// <summary>
        /// Initialize the update thread (if using a multi-threaded context, and enter the game loop of the GameWindow).
        /// </summary>
        public virtual unsafe void Run()
        {
            // Make sure that the gl contexts is current for OnLoad and the initial OnResize
            Context.MakeCurrent();

            // Send the OnLoad event, to load all user code.
            OnLoad();

            // Send a dummy OnResize event, to make sure any listening user code has the correct values.
            OnResize(new ResizeEventArgs(Size));

            Debug.Print("Entering main loop.");
            if (IsMultiThreaded)
            {
                // We want to move the context to the render thread so make sure it's no longer current
                Context.MakeNoneCurrent();

                _renderThread = new Thread(StartRenderThread);
                _renderThread.Start();
            }

            _watchRender.Start();
            _watchUpdate.Start();
            while (GLFW.WindowShouldClose(WindowPtr) == false)
            {
                ProcessEvents();
                DispatchUpdateFrame();

                if (!IsMultiThreaded)
                {
                    DispatchRenderFrame();
                }
            }
        }

        private unsafe void StartRenderThread()
        {
            // If we are starting a render thread we want the context to be current there.
            // So when creating the render thread the graphics context needs to be made not current on the thread creating the render thread.
            Context.MakeCurrent();

            OnRenderThreadStarted();
            _watchRender.Start();
            while (GLFW.WindowShouldClose(WindowPtr) == false)
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
                UpdateTime = elapsed;
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
        }

        private void DispatchRenderFrame()
        {
            var elapsed = _watchRender.Elapsed.TotalSeconds;
            var renderPeriod = RenderFrequency == 0 ? 0 : 1 / RenderFrequency;
            if (elapsed > 0 && elapsed >= renderPeriod)
            {
                _watchRender.Restart();
                RenderTime = elapsed;
                OnRenderFrame(new FrameEventArgs(elapsed));

                // Update VSync if set to adaptive
                if (VSync == VSyncMode.Adaptive)
                {
                    GLFW.SwapInterval(IsRunningSlowly ? 0 : 1);
                }
            }
        }

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        public virtual void SwapBuffers()
        {
            Context.SwapBuffers();
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
