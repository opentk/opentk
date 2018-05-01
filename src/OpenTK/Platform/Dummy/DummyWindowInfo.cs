using System;

namespace OpenTK.Platform.Dummy
{
    internal class DummyWindowInfo : IWindowInfo
    {
        public void Dispose()
        {
        }

        public IntPtr Handle => IntPtr.Zero;
    }
}