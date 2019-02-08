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
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.EventingModels;
using OpenToolkit.Windowing.Interfaces;

namespace OpenToolkit.Windowing
{
    public class GameWindow: NativeWindow, IGameWindow
    {
        public event EventHandler<EventArgs> Load;
        public event EventHandler<EventArgs> Unload;
        public event EventHandler<FrameEventArgs> UpdateFrame;
        public event EventHandler<EventArgs> UpdateThreadStarted;
        public event EventHandler<FrameEventArgs> RenderFrame;

        private const double MaxFrequency = 500.0; // Frequency cap for Update/RenderFrame events

        private readonly bool isSingleThreaded;
        private readonly FrameEventArgs render_args = new FrameEventArgs();

        private readonly FrameEventArgs update_args = new FrameEventArgs();

        private readonly Stopwatch watchRender = new Stopwatch();
        private readonly Stopwatch watchUpdate = new Stopwatch();

        //private IGraphicsContext glContext; //HIGH: Implement with OpenGL ADL Bindings

        private bool is_running_slowly; // true, when UpdatePeriod cannot reach TargetUpdatePeriod

        private bool isExiting;
        private double render_time; // length of last RenderFrame event
        private double render_timestamp; // timestamp of last RenderFrame event
        private double target_update_period, target_render_period;

        private double update_epsilon; // quantization error for UpdateFrame events

        private double update_period, render_period;

        private double update_time; // length of last UpdateFrame event

        private double update_timestamp; // timestamp of last UpdateFrame event
        private Thread updateThread;

        public bool IsExiting => isExiting;

        public double RenderFrequency
        {
            get
            {
                if (render_period == 0.0)
                {
                    return 1.0;
                }

                return 1.0 / render_period;
            }
        }
        
        public double RenderPeriod => render_period;

        public double RenderTime
        {
            get => render_time;
            protected set => render_time = value;
        }

        public double TargetRenderFrequency
        {
            get
            {
                if (TargetRenderPeriod == 0.0)
                {
                    return 0.0;
                }

                return 1.0 / TargetRenderPeriod;
            }
            set
            {
                if (value < 1.0)
                {
                    TargetRenderPeriod = 0.0;
                }
                else if (value <= MaxFrequency)
                {
                    TargetRenderPeriod = 1.0 / value;
                }
                else
                {
                    Debug.Print("Target render frequency clamped to {0}Hz.", MaxFrequency);
                }
            }
        }
        
        public double TargetRenderPeriod
        {
            get => target_render_period;
            set
            {
                if (value <= 1 / MaxFrequency)
                {
                    target_render_period = 0.0;
                }
                else if (value <= 1.0)
                {
                    target_render_period = value;
                }
                else
                {
                    Debug.Print("Target render period clamped to 1.0 seconds.");
                }
            }
        }

        public double TargetUpdateFrequency
        {
            get
            {
                if (MathHelper.ApproximatelyEqualEpsilon(TargetUpdatePeriod, 0.0, 0.00001))
                {
                    return 0.0;
                }
                return 1.0 / TargetUpdatePeriod;
            }
            set
            {
                if (value < 1.0)
                {
                    TargetUpdatePeriod = 0.0;
                }
                else if (value <= MaxFrequency)
                {
                    TargetUpdatePeriod = 1.0 / value;
                }
                else
                {
                    Debug.Print("Target render frequency clamped to {0}Hz.", MaxFrequency);
                }
            }
        }

        public double TargetUpdatePeriod
        {
            get => target_update_period;
            set
            {
                if (value <= 1 / MaxFrequency)
                {
                    target_update_period = 0.0;
                }
                else if (value <= 1.0)
                {
                    target_update_period = value;
                }
                else
                {
                    Debug.Print("Target update period clamped to 1.0 seconds.");
                }
            }
        }

        public double UpdateFrequency
        {
            get
            {
                if (update_period == 0.0)
                {
                    return 1.0;
                }

                return 1.0 / update_period;
            }
        }
        public double UpdatePeriod => update_period;
        public double UpdateTime => update_time;
        public VSyncMode VSync
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Constructs a new GameWindow with sensible default attributes.
        /// </summary>
        public GameWindow()
            : base(640, 480, "OpenTK Game Window", false)
        {
            Load?.Invoke(this, EventArgs.Empty);
        }

        public virtual void Run()
        {
            Run(0.0, 0.0);
        }

        public virtual void Run(double updateRate)
        {
            Run(updateRate, 0.0);
        }

        public void Run(double updates_per_second, double frames_per_second)
        {
            try
            {
                if (updates_per_second < 0.0 || updates_per_second > 200.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(updates_per_second), updates_per_second,
                        "Parameter should be inside the range [0.0, 200.0]");
                }

                if (frames_per_second < 0.0 || frames_per_second > 200.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(frames_per_second), frames_per_second,
                        "Parameter should be inside the range [0.0, 200.0]");
                }

                if (updates_per_second != 0)
                {
                    TargetUpdateFrequency = updates_per_second;
                }

                if (frames_per_second != 0)
                {
                    TargetRenderFrequency = frames_per_second;
                }

                Visible = true; // Make sure the GameWindow is visible.
                Load?.Invoke(this, EventArgs.Empty);
                Resize?.Invoke(this, EventArgs.Empty);

                // On some platforms, ProcessEvents() does not return while the user is resizing or moving
                // the window. We can avoid this issue by raising UpdateFrame and RenderFrame events
                // whenever we encounter a size or move event.
                // Note: hack disabled. Threaded rendering provides a better solution to this issue.
                //Move += DispatchUpdateAndRenderFrame;
                //Resize += DispatchUpdateAndRenderFrame;

                Debug.Print("Entering main loop.");
                if (!isSingleThreaded)
                {
                    updateThread = new Thread(UpdateThread);
                    updateThread.Start();
                }

                watchRender.Start();
                while (true)
                {
                    ProcessEvents();
                    if (Exists && !IsExiting)
                    {
                        if (isSingleThreaded)
                        {
                            DispatchUpdateFrame(watchRender);
                        }

                        DispatchRenderFrame();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void UpdateThread()
        {
            UpdateThreadStarted?.Invoke(this, new EventArgs());
            watchUpdate.Start();
            while (Exists && !IsExiting)
            {
                DispatchUpdateFrame(watchUpdate);
            }
        }

        private void DispatchUpdateFrame(Stopwatch watch)
        {
            var is_running_slowly_retries = 4;
            var timestamp = watch.Elapsed.TotalSeconds;
            var elapsed = ClampElapsed(timestamp - update_timestamp);

            while (elapsed > 0 && elapsed + update_epsilon >= TargetUpdatePeriod)
            {
                RaiseUpdateFrame(watch, elapsed, ref timestamp);

                // Calculate difference (positive or negative) between
                // actual elapsed time and target elapsed time. We must
                // compensate for this difference.
                update_epsilon += elapsed - TargetUpdatePeriod;

                // Prepare for next loop
                elapsed = ClampElapsed(timestamp - update_timestamp);

                if (TargetUpdatePeriod <= double.Epsilon)
                {
                    // According to the TargetUpdatePeriod documentation,
                    // a TargetUpdatePeriod of zero means we will raise
                    // UpdateFrame events as fast as possible (one event
                    // per ProcessEvents() call)
                    break;
                }

                is_running_slowly = update_epsilon >= TargetUpdatePeriod;
                if (is_running_slowly && --is_running_slowly_retries == 0)
                {
                    // If UpdateFrame consistently takes longer than TargetUpdateFrame
                    // stop raising events to avoid hanging inside the UpdateFrame loop.
                    break;
                }
            }
        }

        private void DispatchRenderFrame()
        {
            var timestamp = watchRender.Elapsed.TotalSeconds;
            var elapsed = ClampElapsed(timestamp - render_timestamp);
            if (elapsed > 0 && elapsed >= TargetRenderPeriod)
            {
                RaiseRenderFrame(elapsed, ref timestamp);
            }
        }

        private double ClampElapsed(double elapsed)
        {
            return MathHelper.Clamp(elapsed, 0.0, 1.0);
        }

        public virtual void SwapBuffers()
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            Unload?.Invoke(this, EventArgs.Empty);
            base.Close();
        }

        #region EventHandlers
        public virtual void OnUpdateThreadStarted()
        {

        }

        public virtual void OnLoad()
        {

        }

        public virtual void OnUnload()
        {

        }

        public virtual void OnUpdateFrame()
        {

        }

        public virtual void OnRenderFrame()
        {

        }
        #endregion
    }

    /// <summary>
    /// Enumerates available VSync modes.
    /// </summary>
    public enum VSyncMode
    {
        /// <summary>
        /// Vsync disabled.
        /// </summary>
        Off = 0,

        /// <summary>
        /// VSync enabled.
        /// </summary>
        On,

        /// <summary>
        /// VSync enabled, unless framerate falls below one half of target framerate.
        /// If no target framerate is specified, this behaves exactly like <see cref="VSyncMode.On" />.
        /// </summary>
        Adaptive
    }
}
