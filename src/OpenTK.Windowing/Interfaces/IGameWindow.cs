//
// IGameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//


namespace OpenToolkit.Windowing.Interfaces
{
    /// <summary>
    /// Defines the interface for a GameWindow.
    /// </summary>
    public interface IGameWindow: INativeWindow
    {
        /// <summary>
        /// Closes this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Processes pending window events.
        /// </summary>
        void ProcessEvents();

        /// <summary>
        /// Enters the game loop of the GameWindow using the maximum update rate.
        /// </summary>
        /// <seealso cref="Run(double)" />
        void Run();

        /// <summary>
        /// Enters the game loop of the GameWindow using the specified update rate.
        /// </summary>
        void Run(double updateRate);

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();
    }
}
