using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer
    {
        public string Name => "X11";
        public PalComponents Provides => PalComponents.OpenGL | PalComponents.Window;

        public void Initialize(PalComponents which)
        {
            throw new NotImplementedException();
        }
    }
}
