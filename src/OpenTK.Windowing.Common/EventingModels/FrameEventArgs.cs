//
// FrameEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the arguments for frame events.
    /// </summary>
    /// <remarks>
    /// A FrameEventArgs instance is only valid for the duration of the relevant event;
    /// do not store references to FrameEventArgs outside this event.
    /// </remarks>
    public class FrameEventArgs : EventArgs
    {
        private double _elapsed;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameEventArgs"/> class.
        /// </summary>
        public FrameEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameEventArgs"/> class.
        /// </summary>
        /// <param name="elapsed">The amount of time that has elapsed since the previous event, in seconds.</param>
        public FrameEventArgs(double elapsed)
        {
            Time = elapsed;
        }

        /// <summary>
        /// Gets a <see cref="double" /> that indicates how many seconds of time elapsed since the previous event.
        /// </summary>
        public double Time
        {
            get => _elapsed;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _elapsed = value;
            }
        }
    }
}
