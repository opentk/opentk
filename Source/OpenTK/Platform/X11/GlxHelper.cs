#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

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

    public struct Status
    {
    }

    public struct GLXFBConfig
    {
    }

    public struct GLXPbuffer
    {
    }

    public struct GLXContextID
    {
    }

    public struct GLXHyperpipeNetworkPointer
    {
    }

    public struct GLXHyperpipeConfig
    {
    }

    public struct GLXHyperpipeConfigSGIX
    {
    }

    public struct GLXHyperpipeConfigPointer
    {
    }

    public struct GLXVideoSourceSGIX
    {
    }

    public struct GLXFBConfigSGIX
    {
    }

    public struct GLXPbufferSGIX
    {
    }

    public struct DMparams
    {
    }

    public struct DMbuffer
    {
    }
}
