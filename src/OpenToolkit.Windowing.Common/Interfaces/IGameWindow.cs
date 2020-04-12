//
// IGameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a GameWindow.
    /// </summary>
    public interface IGameWindow : INativeWindow
    {
        /// <summary>
        /// Initialize the update thread (if using a multi-threaded contex, and enter the game loop of the GameWindow.
        /// </summary>
        void Run();

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        double RenderTime { get; }

        /// <summary>
        /// Gets or sets the VSyncMode.
        /// </summary>
        VSyncMode VSync { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the GameWindow should use a separate thread for rendering.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///     If this is true, render frames will be processed in a separate thread.
        ///     Do not enable this unless your code is thread safe.
        ///   </para>
        /// </remarks>
        bool IsMultiThreaded { get; }

        /// <summary>
        /// Gets or sets a double representing the render frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 200.0Hz.</para>
        /// </remarks>
        double RenderFrequency { get; set; }

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
        double UpdateFrequency { get; set; }

        /// <summary>
        /// If game window is configured to run with a dedicated update thread (by passing isSingleThreaded = false in the
        /// constructor),
        /// occurs when the update thread has started. This would be a good place to initialize thread specific stuff (like
        /// setting a synchronization context).
        /// </summary>
        event Action RenderThreadStarted;

        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        event Action Load;

        /// <summary>
        /// Occurs before the window is destroyed.
        /// </summary>
        event Action Unload;

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        event Action<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        event Action<FrameEventArgs> RenderFrame;
    }
}
