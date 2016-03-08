// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.MacOS;

namespace OpenTK
{
    class CarbonGLControl : IGLControl 
    {
        GraphicsMode mode;
        Control control;
        IWindowInfo window_info;

        internal CarbonGLControl(GraphicsMode mode, Control owner)
        {
            this.mode = mode;
            this.control = owner;

            window_info = Utilities.CreateMacOSCarbonWindowInfo(control.Handle, false, true);
        }

        private int GetXOffset()
        {
            return control.Location.X;
        }

        private int GetYOffset()
        {
            if (control.TopLevelControl != null) 
            {
                System.Drawing.Point offset = control.PointToScreen (control.Location);
                System.Drawing.Point windowOffset = control.TopLevelControl.PointToScreen (System.Drawing.Point.Empty);
                int relativeY = offset.Y - windowOffset.Y; //control.TopLevelControl.Location.Y is not the same as windowOffset.Y for some reason.
                return control.TopLevelControl.ClientSize.Height - control.Bottom - relativeY;
            }
            return control.Location.Y;
        }

        #region IGLControl Members

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            // AGL does not support OpenGL profiles
            return new AglContext(mode, WindowInfo, GraphicsContext.CurrentContext, GetXOffset, GetYOffset);
        }

        // TODO: Fix this
        bool lastIsIdle = false;
        public bool IsIdle
        {
            get 
            { 
                lastIsIdle = !lastIsIdle;
                return lastIsIdle;
            }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return window_info;
            }
        }

        #endregion
    }
}
