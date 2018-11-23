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
    /// A FrameEventArgs instance is only valid for the duration of the relevant event;
    /// do not store references to FrameEventArgs outside this event.
    /// </summary>
    public class FrameEventArgs : EventArgs
    {
        private double elapsed;

        /// <summary>
        /// Constructs a new FrameEventArgs instance.
        /// </summary>
        public FrameEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new FrameEventArgs instance.
        /// </summary>
        /// <param name="elapsed">The amount of time that has elapsed since the previous event, in seconds.</param>
        public FrameEventArgs(double elapsed)
        {
            Time = elapsed;
        }

        /// <summary>
        /// Gets a <see cref="System.Double" /> that indicates how many seconds of time elapsed since the previous event.
        /// </summary>
        public double Time
        {
            get => elapsed;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                elapsed = value;
            }
        }
    }
}
