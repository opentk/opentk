using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform.MacOS
{
    using Graphics;

    class CarbonGLControl : IGLControl 
    {
        GraphicsMode mode;
        Control control;

        internal CarbonGLControl(GraphicsMode mode, Control owner)
        {
            this.mode = mode;
            this.control = owner;
        }

        #region IGLControl Members

        public OpenTK.Graphics.GraphicsContext CreateContext()
        {
            return new GraphicsContext(mode, WindowInfo);
        }

        public bool IsIdle
        {
            get { return true; }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                control.CreateControl(); 
                return new CarbonWindowInfo(control.Handle, false, true);
            }
        }

        #endregion
    }
}
