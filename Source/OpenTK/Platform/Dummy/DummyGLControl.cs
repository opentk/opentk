using OpenTK.Graphics;

namespace OpenTK.Platform.Dummy
{
    class DummyGLControl : IGLControl
    {
        #region IGLControl Members

        public OpenTK.Graphics.GraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new GraphicsContext(null, null);
        }

        public bool IsIdle
        {
            get { return false; }
        }

        public IWindowInfo WindowInfo
        {
            get { return new DummyWindowInfo(); }
        }

        #endregion
    }
}
