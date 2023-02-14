using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Enum for keeping track of _NET_WM_STATE
    /// </summary>
    [Flags]
    internal enum WMState
    {
        None = 0,
        Modal = 1 << 0,
        Sticky = 1 << 1,
        MaximizedVert = 1 << 2,
        MaximizedHorz = 1 << 3,
        Shaded = 1 << 4,
        SkipTaskbar = 1 << 5,
        SkipPager = 1 << 6,
        Hidden = 1 << 7,
        Fullscreen = 1 << 8,
        Above = 1 << 9,
        Below = 1 << 10,
        DemandsAttention = 1 << 11,
        Focused = 1 << 12,
    }
}
