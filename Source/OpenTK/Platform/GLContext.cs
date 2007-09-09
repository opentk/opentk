using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    public class GLContext : IGLContext
    {
        private IGLContext implementation;

        public GLContext(DisplayMode mode, IWindowInfo window)
        {

        }

        #region --- IGLContext Members ---

        public IntPtr Context
        {
            get { return implementation.Context; }
        }

        public IWindowInfo Info
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public DisplayMode Mode
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public void CreateContext()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void CreateContext(bool direct)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void CreateContext(bool direct, IGLContext source)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SwapBuffers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void MakeCurrent()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public IntPtr GetAddress(string function)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
