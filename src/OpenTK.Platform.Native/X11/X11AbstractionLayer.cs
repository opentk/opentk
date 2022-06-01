using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IPalComponent
    {
        public string Name => "X11";
        public PalComponents Provides => PalComponents.OpenGL | PalComponents.Window;

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            if ((which & PalComponents.Window) != 0)
            {
                InitializeWindow();
            }
        }
    }
}
