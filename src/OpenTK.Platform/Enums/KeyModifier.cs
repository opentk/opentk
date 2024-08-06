using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Flags indicating keyboard modifiers.
    /// </summary>
    [Flags]
    // FIXME: Should we add a AltGr modifier as a separate thing?
    public enum KeyModifier
    {
        /// <summary>
        /// If no modifiers or locks are active.
        /// </summary>
        None = 0,

        /// <summary>
        /// If <see cref="Key.LeftShift"/> is down.
        /// </summary>
        LeftShift = 1 << 0,

        /// <summary>
        /// If <see cref="Key.RightShift"/> is down.
        /// </summary>
        RightShift = 1 << 1,

        /// <summary>
        /// If <see cref="Key.LeftControl"/> is down.
        /// </summary>
        LeftControl = 1 << 2,

        /// <summary>
        /// If <see cref="Key.RightControl"/> is down.
        /// </summary>
        RightControl = 1 << 3,

        /// <summary>
        /// If <see cref="Key.LeftAlt"/> is down.
        /// </summary>
        LeftAlt = 1 << 4,

        /// <summary>
        /// If <see cref="Key.RightAlt"/> is down.
        /// </summary>
        RightAlt = 1 << 5,

        /// <summary>
        /// If <see cref="Key.LeftGUI"/> is down.
        /// </summary>
        LeftGUI = 1 << 6,

        /// <summary>
        /// If <see cref="Key.RightGUI"/> is down.
        /// </summary>
        RightGUI = 1 << 7,

        /// <summary>
        /// If any of <see cref="Key.LeftShift"/> or <see cref="Key.RightShift"/> are down.
        /// </summary>
        Shift = 1 << 8,

        /// <summary>
        /// If any of <see cref="Key.LeftControl"/> or <see cref="Key.RightControl"/> are down.
        /// </summary>
        Control = 1 << 9,

        /// <summary>
        /// If any of <see cref="Key.LeftAlt"/> or <see cref="Key.RightAlt"/> are down.
        /// </summary>
        Alt = 1 << 10,

        /// <summary>
        /// If any of <see cref="Key.LeftGUI"/> or <see cref="Key.RightGUI"/> are down.
        /// </summary>
        GUI = 1 << 11,

        /// <summary>
        /// If <see cref="Key.NumLock"/> is toggled on.
        /// </summary>
        NumLock = 1 << 20,

        /// <summary>
        /// If <see cref="Key.CapsLock"/> is toggled on.
        /// </summary>
        CapsLock = 1 << 21,

        /// <summary>
        /// Is <see cref="Key.ScrollLock"/> is toggled on.
        /// </summary>
        ScrollLock = 1 << 22,
    }
}
