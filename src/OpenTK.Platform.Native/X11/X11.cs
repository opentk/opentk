using System;
using OpenTK.Core.Platform;
using System.Diagnostics;
using System.Collections.Generic;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Static X11 values.
    /// </summary>
    internal static class X11
    {
        // FIXME: Maybe merge this with LibX11?

        public const int Success = 0;

        public static XDisplayPtr Display { get; set; }

        public static int DefaultScreen { get; set; }

        public static XWindow DefaultRootWindow { get; set; }

        public static XAtomDictionary Atoms { get; set; }

        public static HashSet<string> Extensions { get; set; }


        public static int XRandREventBase { get; set; }

        public static int XRandRErrorBase { get; set; }


        /// <summary>
        /// remove/unset property
        /// </summary>
        public const long _NET_WM_STATE_REMOVE = 0;

        /// <summary>
        /// add/set property
        /// </summary>
        public const long _NET_WM_STATE_ADD = 1;

        /// <summary>
        /// toggle property
        /// </summary>
        public const long _NET_WM_STATE_TOGGLE = 2;

    }
}
