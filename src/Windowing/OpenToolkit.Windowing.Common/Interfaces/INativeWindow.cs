//
// INativeWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a NativeWindow.
    /// </summary>
    public interface INativeWindow : INativeWindowProperties, IWindowEvents, IWindowInput, IDisposable
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
        /// A <see cref="OpenToolkit.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        Vector2i PointToClient(Vector2i point);

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="OpenToolkit.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        Vector2i PointToScreen(Vector2i point);

        /// <summary>
        /// Gets the current monitor's pixel-per-inch count.
        /// </summary>
        /// <value>The current monitor ppi.</value>
        /// <remarks>
        /// This function will return -1 when:
        /// * The CurrentMonitor is null.
        /// * The VideoMode of CurrentMonitor is null.
        /// * The reported size in any dimension is non-positive.
        /// * The reported resolution in any dimension is non-positive.
        /// </remarks>
        int CurrentMonitorPpi { get; }
    }
}
