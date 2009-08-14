using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    // Provides the foundation for all desktop IGraphicsContext implementations.
    abstract class DesktopGraphicsContext : IGraphicsContext
    {
        #region IGraphicsContext Members

        public abstract void SwapBuffers();

        public abstract void MakeCurrent(IWindowInfo window);

        public abstract bool IsCurrent { get; }

        public abstract event DestroyEvent<IGraphicsContext> Destroy;

        public abstract bool VSync { get; set; }

        public abstract void Update(IWindowInfo window);

        public abstract GraphicsMode GraphicsMode { get; }

        public abstract bool ErrorChecking { get; set; }

        #endregion

        #region IDisposable Members

        public abstract void Dispose();

        #endregion
    }
}
