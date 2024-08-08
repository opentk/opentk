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
using System.Runtime.InteropServices;
using System.Threading;
using OpenTK.Core;
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
        /// Occurs when it is time to update a frame. This is invoked before <see cref="RenderFrame"/>.
        /// </summary>
        public event Action<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// If game window is configured to run with a dedicated update thread (by passing isSingleThreaded = false in the
        /// constructor),
        /// occurs when the update thread has started. This would be a good place to initialize thread specific stuff (like
        /// setting a synchronization context).
        /// </summary>
        [Obsolete("There is no longer a separate render thread.")]
        public event Action RenderThreadStarted;

        /// <summary>
        /// Occurs when it is time to render a frame. This is invoked after <see cref="UpdateFrequency"/>.
        /// </summary>
        public event Action<FrameEventArgs> RenderFrame;

        /// <summary>
        /// Frequency cap for Update/RenderFrame events.
        /// </summary>
        private const double MaxFrequency = 500.0;

        private readonly Stopwatch _watchUpdate = new Stopwatch();

        /// <summary>
        /// Gets a value indicating whether or not UpdatePeriod has consistently failed to reach TargetUpdatePeriod.
        /// This can be used to do things such as decreasing visual quality if the user's computer isn't powerful enough
        /// to handle the application.
        /// </summary>
        protected bool IsRunningSlowly { get; private set; }

        private double _updateFrequency;

        /// <summary>
        /// Gets a value indicating whether or not the GameWindow should use a separate thread for rendering.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     If this is true, render frames will be processed in a separate thread.
        ///     Do not enable this unless your code is thread safe.
        ///   </para>
        /// </remarks>
        [Obsolete("There is not one size fits all multithreading solution, especially for OpenGL. This feature has been removed and will not work.", true)]
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
        [Obsolete("Use UpdateFrequency instead. We no longer separate UpdateFrame and RenderFrame.", true)]
        public double RenderFrequency
        {
            get => throw new Exception($"This property is obsolete. Use UpdateFrame instead.");
            set => throw new Exception($"This property is obsolete. Use UpdateFrame instead.");
        }

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        [Obsolete("Use UpdateTime instead. We no longer separate UpdateFrame and RenderFrame.", true)]
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
        /// <para>
        /// The expected scheduler period in milliseconds. Used to provide accurate sleep timings.
        /// </para>
        /// <para>
        /// On Windows the scheduler period can be set using <c>timeBeginPeriod()</c>, OpenTK sets this value to 8ms by default.
        /// See <see cref="Run()"/> for more details.<br/>
        /// On Linux we set this to 1 as it seems like <see cref="Thread.Sleep(int)"/> is able to accurately sleep 1ms.<br/>
        /// On macos we set this to 1 aswell as tests imply <see cref="Thread.Sleep(int)"/> can accurately sleep 1ms.
        /// </para>
        /// </summary>
        public int ExpectedSchedulerPeriod { get; set; } = 16;

        private readonly bool _win32SuspendTimerOnDrag;

        private Win32WindowProc _win32WndProc = null;

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
            UpdateFrequency = gameWindowSettings.UpdateFrequency;
            _win32SuspendTimerOnDrag = gameWindowSettings.Win32SuspendTimerOnDrag;
        }

        #region Win32 Function for timing

        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr SetThreadAffinityMask(IntPtr hThread, IntPtr dwThreadAffinityMask);

        [DllImport("kernel32")]
        private static extern IntPtr GetCurrentThread();

        [DllImport("winmm")]
        private static extern uint timeBeginPeriod(uint uPeriod);

        [DllImport("winmm")]
        private static extern uint timeEndPeriod(uint uPeriod);

        #endregion

        /// <summary>Counter for how many updates in Run() where slow.</summary>
        private int _slowUpdates = 0;

        /// <summary>
        /// Initialize the update thread (if using a multi-threaded context, and enter the game loop of the GameWindow).
        /// </summary>
        /// <remarks>
        /// <para>On windows this function sets the thread affinity mask to 0x0001 to avoid the thread from changing cores.</para>
        /// <para>
        /// On windows this function calls <c>timeBeginPeriod(8)</c> to get better sleep timings, which can increase power usage.
        /// This can be undone by calling <c>timeEndPeriod(8)</c> in <see cref="OnLoad"/> and <c>timeBeginPeriod(8)</c> in <see cref="OnUnload"/>.
        /// If the expected scheduler time is changed set <see cref="ExpectedSchedulerPeriod"/> to the appropriate value to keep the accuracy of the update loop.
        /// </para>
        /// </remarks>
        public virtual unsafe void Run()
        {
            // 8 is a good compromise between accuracy and power consumption
            // according to: https://chromium-review.googlesource.com/c/chromium/src/+/2265402
            const int TIME_PERIOD = 8;

            // We do this before OnLoad so that users have some way to affect these settings in OnLoad if they need to.
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Make this thread only run on one core, avoiding timing issues with context switching
                SetThreadAffinityMask(GetCurrentThread(), new IntPtr(1));

                // Make Thread.Sleep more accurate.
                // FIXME: We probably only care about this if we are not event driven.
                timeBeginPeriod(TIME_PERIOD);
                ExpectedSchedulerPeriod = TIME_PERIOD;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                    // FIXME: We assume FreeBSD is able to do 1ms sleeps as well.
                    RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                // Seems like `Thread.Sleep` can accurately sleep for 1ms on Ubuntu 20.04
                // - 2023-07-13 Noggin_bops
                ExpectedSchedulerPeriod = 1;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Seems like `Thread.Slepp` can accurately sleep for 1ms on a 2018 Macbook Air running macos 12.3.1.
                // - 2023-07-13 Noggin_bops
                ExpectedSchedulerPeriod = 1;
            }

            // Make sure that the gl contexts is current for OnLoad and the initial OnResize
            Context?.MakeCurrent();

            // Hook the Win32 window message handler and wire up related events
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && _win32SuspendTimerOnDrag)
            {
                _win32WndProc = new Win32WindowProc(WindowPtr);
                _win32WndProc.OnModalSizeMoveBegin += Win32_OnModalSizeMoveBegin;
                _win32WndProc.OnModalSizeMoveEnd += Win32_OnModalSizeMoveEnd;
            }

            // Send the OnLoad event, to load all user code.
            OnLoad();

            // Send a dummy OnResize event, to make sure any listening user code has the correct values.
            OnResize(new ResizeEventArgs(ClientSize));

            Debug.Print("Entering main loop.");

            _watchUpdate.Start();
            while (GLFW.WindowShouldClose(WindowPtr) == false)
            {
                double updatePeriod = UpdateFrequency == 0 ? 0 : 1 / UpdateFrequency;

                double elapsed = _watchUpdate.Elapsed.TotalSeconds;
                if (elapsed > updatePeriod)
                {
                    _watchUpdate.Restart();

                    // Update input state for next frame
                    NewInputFrame();

                    // Handle events for this frame
                    ProcessWindowEvents(IsEventDriven);

                    UpdateTime = elapsed;
                    OnUpdateFrame(new FrameEventArgs(elapsed));
                    OnRenderFrame(new FrameEventArgs(elapsed));

                    const int MaxSlowUpdates = 80;
                    const int SlowUpdatesThreshold = 45;

                    double time = _watchUpdate.Elapsed.TotalSeconds;
                    if (updatePeriod < time)
                    {
                        _slowUpdates++;
                        if (_slowUpdates > MaxSlowUpdates)
                        {
                            _slowUpdates = MaxSlowUpdates;
                        }
                    }
                    else
                    {
                        _slowUpdates--;
                        if (_slowUpdates < 0)
                        {
                            _slowUpdates = 0;
                        }
                    }

                    IsRunningSlowly = _slowUpdates > SlowUpdatesThreshold;

                    if (API != ContextAPI.NoAPI)
                    {
                        if (VSync == VSyncMode.Adaptive)
                        {
                            GLFW.SwapInterval(IsRunningSlowly ? 0 : 1);
                        }
                    }
                }

                // The time we have left to the next update.
                double timeToNextUpdate = updatePeriod - _watchUpdate.Elapsed.TotalSeconds;

                if (timeToNextUpdate > 0)
                {
                    Utils.AccurateSleep(timeToNextUpdate, ExpectedSchedulerPeriod);
                }
            }

            OnUnload();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                timeEndPeriod(TIME_PERIOD);
            }
        }

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        public virtual void SwapBuffers()
        {
            if (Context == null)
            {
                throw new InvalidOperationException("Cannot use SwapBuffers when running with ContextAPI.NoAPI.");
            }

            Context.SwapBuffers();
        }

        /// <inheritdoc />
        public override void Close()
        {
            base.Close();
        }

        /// <summary>
        /// Run when the update thread is started. This will never run if you set <see cref="IsMultiThreaded"/> to false.
        /// </summary>
        [Obsolete("There is no longer a separate render thread.")]
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
        /// Run when the window is ready to update. This is called before <see cref="OnRenderFrame(FrameEventArgs)"/>.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnUpdateFrame(FrameEventArgs args)
        {
            UpdateFrame?.Invoke(args);
        }

        /// <summary>
        /// Run when the window is ready to render. This is called after <see cref="OnUpdateFrame(FrameEventArgs)"/>.
        /// </summary>
        /// <param name="args">The event arguments for this frame.</param>
        protected virtual void OnRenderFrame(FrameEventArgs args)
        {
            RenderFrame?.Invoke(args);
        }

        /// <summary>
        /// The current time since the last update.
        /// This function is useful when implementing updates on resize using windows.
        /// </summary>
        /// <returns>The time since the last update.</returns>
        /// <remarks>
        /// Don't use this in <see cref="OnUpdateFrame(FrameEventArgs)"/> or <see cref="OnRenderFrame(FrameEventArgs)"/>, instead use <see cref="FrameEventArgs.Time"/>.
        /// </remarks>
        public double TimeSinceLastUpdate()
        {
            return (float)_watchUpdate.Elapsed.TotalSeconds;
        }

        /// <summary>
        /// Resets the time since the last update.
        /// This function is useful when implementing updates on resize using windows.
        /// </summary>
        public void ResetTimeSinceLastUpdate()
        {
            _watchUpdate.Restart();
        }

        // Only fired when GameWindowSettings.Win32SuspendTimerOnDrag is enabled
        private void Win32_OnModalSizeMoveBegin()
        {
            _watchUpdate.Stop();
        }

        // Only fired when GameWindowSettings.Win32SuspendTimerOnDrag is enabled
        private void Win32_OnModalSizeMoveEnd()
        {
            _watchUpdate.Restart();
        }

        private bool _isDisposed = false;

        /// <inheritdoc />
        public override void Dispose()
        {
            base.Dispose();

            if (_isDisposed)
            {
                return;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && _win32WndProc != null)
            {
                _win32WndProc.OnModalSizeMoveBegin -= Win32_OnModalSizeMoveBegin;
                _win32WndProc.OnModalSizeMoveEnd -= Win32_OnModalSizeMoveEnd;
                _win32WndProc.Dispose();
                _win32WndProc = null;
            }

            GC.SuppressFinalize(this);
            _isDisposed = true;
        }
    }
}
