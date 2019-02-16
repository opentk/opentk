//
// IGameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//


using System;
using OpenToolkit.Windowing.EventingModels;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a GameWindow.
    /// </summary>
    public interface IGameWindow: INativeWindow, IGameWindowProperties
    {
        /// <summary>
        /// Enters the game loop of the GameWindow.
        /// </summary>
        void Run();

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Gets a value indicating whether the shutdown sequence has been initiated
        /// for this window, by calling GameWindow.Exit() or hitting the 'close' button.
        /// If this property is true, it is no longer safe to use any OpenTK.Input or
        /// OpenTK.Graphics.OpenGL functions or properties.
        /// </summary>
        bool IsExiting { get; }

        /// <summary>
        /// Gets a double representing the time spent in the RenderFrame function, in seconds.
        /// </summary>
        double RenderTime { get; }

        /// <summary>
        /// Gets a double representing the time spent in the UpdateFrame function, in seconds.
        /// </summary>
        double UpdateTime { get; }

        /// <summary>
        /// Gets or sets the VSyncMode.
        /// </summary>
        VSyncMode VSync { get; set; }

        /// <summary>
        /// If game window is configured to run with a dedicated update thread (by passing isSingleThreaded = false in the
        /// constructor),
        /// occurs when the update thread has started. This would be a good place to initialize thread specific stuff (like
        /// setting a synchronization context).
        /// </summary>
        event EventHandler<EventArgs> UpdateThreadStarted;

        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        event EventHandler<EventArgs> Load;

        /// <summary>
        /// Occurs before the window is destroyed.
        /// </summary>
        event EventHandler<EventArgs> Unload;

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        event EventHandler<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        event EventHandler<FrameEventArgs> RenderFrame;
    }
}
