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
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.EventingModels;

namespace OpenToolkit.Windowing.Desktop
{
    public class GameWindow: NativeWindow, IGameWindow
    {
        public event EventHandler<EventArgs> Load;
        public event EventHandler<EventArgs> Unload;
        public event EventHandler<FrameEventArgs> UpdateFrame;
        public event EventHandler<EventArgs> UpdateThreadStarted;
        public event EventHandler<FrameEventArgs> RenderFrame;

        private const double MaxFrequency = 500.0; // Frequency cap for Update/RenderFrame events

        private readonly bool _isSingleThreaded;
        private readonly FrameEventArgs _renderArgs = new FrameEventArgs();

        private readonly FrameEventArgs _updateArgs = new FrameEventArgs();

        private readonly Stopwatch _watchRender = new Stopwatch();
        private readonly Stopwatch _watchUpdate = new Stopwatch();

        //private IGraphicsContext glContext; //HIGH: Implement with OpenGL ADL Bindings

        private bool _isRunningSlowly; // true, when UpdatePeriod cannot reach TargetUpdatePeriod

        private bool _isExiting;
        private double _renderTime; // length of last RenderFrame event
        private double _renderTimestamp; // timestamp of last RenderFrame event
        private double _targetUpdatePeriod, _targetRenderPeriod;

        private double _updateEpsilon; // quantization error for UpdateFrame events

        private double _updatePeriod, _renderPeriod;

        private double _updateTime; // length of last UpdateFrame event

        private double _updateTimestamp; // timestamp of last UpdateFrame event
        private Thread _updateThread;

        public bool IsExiting => _isExiting;

        public double RenderFrequency
        {
            get
            {
                if (MathHelper.ApproximatelyEqualEpsilon(_renderPeriod, 0.0, 0.00001))
                {
                    return 1.0;
                }

                return 1.0 / _renderPeriod;
            }
        }
        
        public double RenderPeriod => _renderPeriod;

        public double RenderTime
        {
            get => _renderTime;
            protected set => _renderTime = value;
        }

        public double TargetRenderFrequency
        {
            get
            {
                if (MathHelper.ApproximatelyEqualEpsilon(TargetRenderPeriod, 0.0, 0.00001))
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
            get => _targetRenderPeriod;
            set
            {
                if (value <= 1 / MaxFrequency)
                {
                    _targetRenderPeriod = 0.0;
                }
                else if (value <= 1.0)
                {
                    _targetRenderPeriod = value;
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
            get => _targetUpdatePeriod;
            set
            {
                if (value <= 1 / MaxFrequency)
                {
                    _targetUpdatePeriod = 0.0;
                }
                else if (value <= 1.0)
                {
                    _targetUpdatePeriod = value;
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
                if (MathHelper.ApproximatelyEqualEpsilon(_updatePeriod, 0.0, 0.00001))
                {
                    return 1.0;
                }

                return 1.0 / _updatePeriod;
            }
        }
        public double UpdatePeriod => _updatePeriod;
        public double UpdateTime => _updateTime;
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

        public void Run(double updatesPerSecond, double framesPerSecond)
        {
            if (updatesPerSecond < 0.0)
            {
                throw new ArgumentOutOfRangeException(nameof(updatesPerSecond), updatesPerSecond,
                    "Parameter cannot be negative");
            }

            if (updatesPerSecond > 200.0)
            {
                throw new ArgumentOutOfRangeException(nameof(updatesPerSecond), updatesPerSecond,
                    "Parameter should be inside the range [0.0, 200.0]");
            }

            if (framesPerSecond < 0.0)
            {
                throw new ArgumentOutOfRangeException(nameof(framesPerSecond), framesPerSecond,
                    "Parameter cannot be negative");
            }

            if (framesPerSecond > 200.0)
            {
                throw new ArgumentOutOfRangeException(nameof(framesPerSecond), framesPerSecond,
                    "Parameter should be inside the range [0.0, 200.0]");
            }

            try
            {
                if (!MathHelper.ApproximatelyEqualEpsilon(updatesPerSecond, 0.0, 0.00001))
                {
                    TargetUpdateFrequency = updatesPerSecond;
                }

                if (!MathHelper.ApproximatelyEqualEpsilon(framesPerSecond, 0.0, 0.00001))
                {
                    TargetRenderFrequency = framesPerSecond;
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
                if (!_isSingleThreaded)
                {
                    _updateThread = new Thread(UpdateThread);
                    _updateThread.Start();
                }

                _watchRender.Start();
                while (true)
                {
                    ProcessEvents();
                    if (Exists && !IsExiting)
                    {
                        if (_isSingleThreaded)
                        {
                            DispatchUpdateFrame(_watchRender);
                        }

                        DispatchRenderFrame();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            //TODO: There should be some better error checking here. This just keeps the compiler from complaining.
            catch (Exception e)
            {
                throw;
            }
        }

        private void UpdateThread()
        {
            UpdateThreadStarted?.Invoke(this, new EventArgs());
            _watchUpdate.Start();
            while (Exists && !IsExiting)
            {
                DispatchUpdateFrame(_watchUpdate);
            }
        }

        private void DispatchUpdateFrame(Stopwatch watch)
        {
            var isRunningSlowlyRetries = 4;
            var timestamp = watch.Elapsed.TotalSeconds;
            var elapsed = MathHelper.Clamp(timestamp - _updateTimestamp, 0.0, 1.0);

            while (elapsed > 0 && elapsed + _updateEpsilon >= TargetUpdatePeriod)
            {
                RaiseUpdateFrame(watch, elapsed, ref timestamp);

                // Calculate difference (positive or negative) between
                // actual elapsed time and target elapsed time. We must
                // compensate for this difference.
                _updateEpsilon += elapsed - TargetUpdatePeriod;

                // Prepare for next loop
                elapsed = MathHelper.Clamp(timestamp - _updateTimestamp, 0.0, 1.0);

                if (TargetUpdatePeriod <= double.Epsilon)
                {
                    // According to the TargetUpdatePeriod documentation,
                    // a TargetUpdatePeriod of zero means we will raise
                    // UpdateFrame events as fast as possible (one event
                    // per ProcessEvents() call)
                    break;
                }

                _isRunningSlowly = _updateEpsilon >= TargetUpdatePeriod;
                if (_isRunningSlowly && --isRunningSlowlyRetries == 0)
                {
                    // If UpdateFrame consistently takes longer than TargetUpdateFrame
                    // stop raising events to avoid hanging inside the UpdateFrame loop.
                    break;
                }
            }
        }

        private void DispatchRenderFrame()
        {
            var timestamp = _watchRender.Elapsed.TotalSeconds;
            var elapsed = MathHelper.Clamp(timestamp - _renderTimestamp, 0.0, 1.0);
            if (elapsed > 0 && elapsed >= TargetRenderPeriod)
            {
                RaiseRenderFrame(elapsed, ref timestamp);
            }
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
}
