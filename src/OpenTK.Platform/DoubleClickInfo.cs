using System;
using OpenTK.Mathematics;

namespace OpenTK.Platform
{
    /// <summary>
    /// A struct describing the time and spatial conditions for double-clicks.
    /// </summary>
    public struct DoubleClickInfo
    {
        /// <summary>
        /// The maximum time between clicks for them to be considered a double-click.
        /// </summary>
        public ulong Interval = 500;
        /// <summary>
        /// The maximum distance in x and y that the mouse can move in a double-click operation, in screen coordinates.
        /// </summary>
        public Vector2 Distance = (4, 4);

        public DoubleClickInfo()
        {
            
        }

        public override string ToString()
        {
            return $"Interval: {Interval}ms, Distance: {Distance}";
        }

    }
}

