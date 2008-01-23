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
    internal static partial class Glx
    {
        internal const string Library = "libGL.so.1";

        // Disable BeforeFieldInit optimization.
        static Glx() { }

        #region internal static void LoadAll

        internal static void LoadAll()
        {
            OpenTK.Platform.Utilities.LoadExtensions(typeof(Glx));
        }

        #endregion

        #region internal static bool SupportsExtension(string p)

        internal static bool SupportsExtension(string p)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal struct Status
    {
    }

    internal struct GLXFBConfig
    {
    }

    internal struct GLXPbuffer
    {
    }

    internal struct GLXContextID
    {
    }

    internal struct GLXHyperpipeNetworkPointer
    {
    }

    internal struct GLXHyperpipeConfig
    {
    }

    internal struct GLXHyperpipeConfigSGIX
    {
    }

    internal struct GLXHyperpipeConfigPointer
    {
    }

    internal struct GLXVideoSourceSGIX
    {
    }

    internal struct GLXFBConfigSGIX
    {
    }

    internal struct GLXPbufferSGIX
    {
    }

    internal struct DMparams
    {
    }

    internal struct DMbuffer
    {
    }
}
