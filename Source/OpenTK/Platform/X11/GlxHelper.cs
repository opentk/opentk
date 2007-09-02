using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    public static partial class Glx
    {
        internal const string Library = "libGL.so.1";

        // Disable BeforeFieldInit optimization.
        static Glx() { }
    }

    public struct GLXDrawable
    {
    }

    public struct GLXContext
    {
    }

    public struct GLXHyperpipeNetworkPointer
    {
    }

    public struct GLXHyperpipeConfig
    {
    }

    public struct GLXHyperpipeConfigPointer
    {
    }
}
