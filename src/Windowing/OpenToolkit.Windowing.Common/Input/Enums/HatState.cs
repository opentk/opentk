using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// The available states of a joystick hat.
    /// </summary>
    public enum HatState
    {
        /// <summary>
        /// The centered state of a hat.
        /// </summary>
        Centered = 0,

        /// <summary>
        /// The up state of a hat.
        /// </summary>
        Up = 1,

        /// <summary>
        /// The right state of a hat.
        /// </summary>
        Right = 2,

        /// <summary>
        /// The down state of a hat.
        /// </summary>
        Down = 4,

        /// <summary>
        /// The left state of a hat.
        /// </summary>
        Left = 8,

        /// <summary>
        /// The right-up state of a hat (equivalant to "Right | Up").
        /// </summary>
        RightUp = Right | Up,

        /// <summary>
        /// The right-down state of a hat (equivalant to "Right | Down").
        /// </summary>
        RightDown = Right | Down,

        /// <summary>
        /// The left-up state of a hat (equivalant to "Left | Up").
        /// </summary>
        LeftUp = Left | Up,

        /// <summary>
        /// The left-down state of a hat (equivalant to "Left | Down").
        /// </summary>
        LeftDown = Left | Down
    }
}
