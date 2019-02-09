//
// IGameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Drawing;


namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a NativeWindow
    /// </summary>
    public interface INativeWindow : IWindowProperties, IWindowEvents, IWindowInput, IDisposable
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
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Transforms the specified point from screen to client coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        Point PointToClient(Point point);

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        Point PointToScreen(Point point);
    }
}
