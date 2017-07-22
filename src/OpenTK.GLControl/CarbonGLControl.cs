//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System.Windows.Forms;

using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.MacOS;

namespace OpenTK
{
    internal class CarbonGLControl : IGLControl
    {
        private GraphicsMode mode;
        private Control control;

        internal CarbonGLControl(GraphicsMode mode, Control owner)
        {
            this.mode = mode;
            this.control = owner;

            WindowInfo = Utilities.CreateMacOSCarbonWindowInfo(control.Handle, false, true);
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

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            // AGL does not support OpenGL profiles
            return new AglContext(mode, WindowInfo, GraphicsContext.CurrentContext, GetXOffset, GetYOffset);
        }

        // TODO: Fix this
        private bool lastIsIdle = false;
        public bool IsIdle
        {
            get
            {
                lastIsIdle = !lastIsIdle;
                return lastIsIdle;
            }
        }

        public IWindowInfo WindowInfo { get; }
    }
}
