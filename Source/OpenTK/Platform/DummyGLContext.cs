using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// A dummy GLContext to be used inside the Visual Studio designer.
    /// </summary>
    internal class DummyGLContext : IGLContext
    {
        #region --- IGLContext Members ---

        public void SwapBuffers()
        {
        }

        public void MakeCurrent()
        {
        }

        public IntPtr GetAddress(string function)
        {
            return IntPtr.Zero;
        }

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
        }

        #endregion
    }
}
