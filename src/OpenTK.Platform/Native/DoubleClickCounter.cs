using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Mathematics;

namespace OpenTK.Platform.Native
{
    internal class DoubleClickCounter
    {
        /// <summary>
        /// The parameters for detecting a double-click. Interval and spatial constraints.
        /// </summary>
        public DoubleClickInfo DoubleClickInfo;

        internal MouseButton LastButton;
        internal ulong LastTime;
        internal Vector2 LastPosition;
        internal int Count;

        /// <summary>
        /// Counts the click and
        /// </summary>
        /// <param name="time">The timestamp in milliseconds of the mouse button press.</param>
        /// <param name="position">The position of the mouse in client coordinates.</param>
        /// <param name="button">The button that was pressed.</param>
        /// <returns></returns>
        public int CountClicks(ulong time, Vector2 position, MouseButton button)
        {
            if (LastButton != button)
            {
                Count = 0;
            }

            Vector2 diff = Vector2.Abs(position - LastPosition);
            if (diff.X > DoubleClickInfo.Distance.X || diff.Y > DoubleClickInfo.Distance.Y)
            {
                Count = 0;
            }

            if (time > (LastTime + DoubleClickInfo.Interval))
            {
                Count = 0;
            }

            LastButton = button;
            LastTime = time;
            LastPosition = position;
            Count++;

            return Count;
        }

        public override string ToString()
        {
            return $"{DoubleClickInfo}, Button: {LastButton}, Last time: {LastTime}, Pos: {LastPosition}, Count: {Count}";
        }
    }
}
