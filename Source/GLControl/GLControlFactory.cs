// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;

namespace OpenTK
{
    // Constructs GLControls.
    class GLControlFactory
    {
        public IGLControl CreateGLControl(GraphicsMode mode, Control control)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (control == null)
                throw new ArgumentNullException("control");

            if (Configuration.RunningOnSdl2) return new Sdl2GLControl(mode, control);
            else if (Configuration.RunningOnWindows) return new WinGLControl(mode, control);
            else if (Configuration.RunningOnMacOS) return new CarbonGLControl(mode, control);
            else if (Configuration.RunningOnX11) return new X11GLControl(mode, control);
            else throw new PlatformNotSupportedException();
        }
    }
}
