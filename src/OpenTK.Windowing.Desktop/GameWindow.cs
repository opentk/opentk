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

        private readonly Stopwatch _watchRender = new Stopwatch();
        private readonly Stopwatch _watchUpdate = new Stopwatch();

        //private IGraphicsContext glContext; //HIGH: Implement with OpenGL ADL Bindings

        private bool _isRunningSlowly; // true, when UpdatePeriod cannot reach TargetUpdatePeriod

        private double _updateEpsilon; // quantization error for UpdateFrame events

        private double _renderFrequency, _updateFrequency;
        private double _renderTimestamp, _updateTimestamp;

        private Thread _updateThread;

        public bool IsExiting { get; protected set; }

        public bool IsSingleThreaded { get; }

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

        public double RenderTime { get; protected set; }

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

        public double UpdateTime { get; }

        private VSyncMode _vSync;
        
        public VSyncMode VSync
        {
            get => _vSync;
            set
            {
                switch (value)
                {
                    case VSyncMode.On:
                        Glfw.SetSwapInterval(1);
                        break;
                        
                    case VSyncMode.Off:
                        Glfw.SetSwapInterval(0);
                        break;
                        
                    case VSyncMode.Adaptive:
                        Glfw.SetSwapInterval(_isRunningSlowly ? 0 : 1);
                        break;
                    }

                _vSync = value;
            }
        }

        /// <summary>
        /// Constructs a new GameWindow with sensible default attributes.
        /// </summary>
        public GameWindow(IGameWindowProperties gameWindowSettings, INativeWindowProperties nativeWindowSettings)
            : base(nativeWindowSettings)
        {
            IsSingleThreaded = gameWindowSettings.IsSingleThreaded;

            RenderFrequency = gameWindowSettings.RenderFrequency;
            UpdateFrequency = gameWindowSettings.UpdateFrequency;
        }

        public virtual void Run()
        {
            Visible = true; // Make sure the GameWindow is visible.
            OnLoad(this, EventArgs.Empty);
            OnResize(this, new ResizeEventArgs(Width, Height));

            // On some platforms, ProcessEvents() does not return while the user is resizing or moving
            // the window. We can avoid this issue by raising UpdateFrame and RenderFrame events
            // whenever we encounter a size or move event.
            // Note: hack disabled. Threaded rendering provides a better solution to this issue.
            //Move += DispatchUpdateAndRenderFrame;
            //Resize += DispatchUpdateAndRenderFrame;

            Debug.Print("Entering main loop.");
            if (!IsSingleThreaded)
            {
                _updateThread = new Thread(UpdateThread);
                _updateThread.Start();
            }

            _watchRender.Start();
            while (true)
            {
                ProcessEvents();
                    
                if (!Exists || IsExiting) return;
                    
                if (IsSingleThreaded)
                {
                    DispatchUpdateFrame(_watchRender);
                }

                DispatchRenderFrame();
            }
        }

        private void UpdateThread()
        {
            OnUpdateThreadStarted(this, EventArgs.Empty);
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

            var UpdatePeriod = 1 / UpdateFrequency;

            while (elapsed > 0 && elapsed + _updateEpsilon >= UpdatePeriod)
            {
                OnUpdateFrame(this, new FrameEventArgs(elapsed));

                // Calculate difference (positive or negative) between
                // actual elapsed time and target elapsed time. We must
                // compensate for this difference.
                _updateEpsilon += elapsed - UpdatePeriod;

                // Prepare for next loop
                elapsed = MathHelper.Clamp(timestamp - _updateTimestamp, 0.0, 1.0);

                if (UpdateFrequency <= double.Epsilon)
                {
                    // An UpdateFrequency of zero means we will raise
                    // UpdateFrame events as fast as possible (one event
                    // per ProcessEvents() call)
                    break;
                }

                _isRunningSlowly = _updateEpsilon >= UpdatePeriod;
                if (_isRunningSlowly && --isRunningSlowlyRetries == 0)
                {
                    // If UpdateFrame consistently takes longer than TargetUpdateFrame
                    // stop raising events to avoid hanging inside the UpdateFrame loop.
                    break;
                }
            }
            
            // Update VSync if set to adaptive
            if (_vSync == VSyncMode.Adaptive)
            {
                Glfw.SetSwapInterval(_isRunningSlowly ? 0 : 1);
            }
        }

        private void DispatchRenderFrame()
        {
            var timestamp = _watchRender.Elapsed.TotalSeconds;
            var elapsed = MathHelper.Clamp(timestamp - _renderTimestamp, 0.0, 1.0);
            if (elapsed > 0 && elapsed >= (1 / RenderFrequency))
            {
                OnRenderFrame(this, new FrameEventArgs(elapsed));
            }
        }

        public virtual void SwapBuffers()
        {
            unsafe
            {
                Glfw.SwapBuffers(WindowPtr);
            }
        }

        public override void Close()
        {
            OnUnload(this, EventArgs.Empty);
            base.Close();
        }

        #region EventHandlers
        protected virtual void OnUpdateThreadStarted(object sender, EventArgs args)
        {
            UpdateThreadStarted?.Invoke(sender, args);
        }

        protected virtual void OnLoad(object sender, EventArgs args)
        {
            Load?.Invoke(sender, args);
        }

        protected virtual void OnUnload(object sender, EventArgs args)
        {
            Unload?.Invoke(sender, args);
        }

        protected virtual void OnUpdateFrame(object sender, FrameEventArgs args)
        {
            UpdateFrame?.Invoke(sender, args);
        }

        protected virtual void OnRenderFrame(object sender, FrameEventArgs args)
        {
            RenderFrame?.Invoke(sender, args);
        }
        #endregion
    }
}
