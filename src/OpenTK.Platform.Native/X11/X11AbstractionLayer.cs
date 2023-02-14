using System;
using OpenTK.Core.Platform;
using System.Diagnostics;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Static X11 values.
    /// </summary>
    public static class X11
    {
        public static XDisplayPtr Display { get; set; }

        public static int DefaultScreen { get; set; }

        public static XWindow DefaultRootWindow { get; set; }

        public static XAtomDictionary Atoms { get; set; }
    }
}
