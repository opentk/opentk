using System;

using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    [Flags]
    internal enum WindowClassStyleFlags : UINT
    {
        VREDRAW = 0x0001,
        HREDRAW = 0x0002,
        DBLCLKS = 0x0008,
        OWNDC = 0x0020,
        CLASSDC = 0x0040,
        PARENTDC = 0x0080,
        NOCLOSE = 0x0200,
        SAVEBITS = 0x0800,
        BYTEALIGNTCLIENT = 0x1000,
        BYTEALIGNWINDOW = 0x2000,
        GLOBALCLASS = 0x4000,

        IME = 0x00010000,

        /// <summary>
        /// Only supported on XP and higher.
        /// </summary>
        DROPSHADOW = 0x00020000
    }
}
