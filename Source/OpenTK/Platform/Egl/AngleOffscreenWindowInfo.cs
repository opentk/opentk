using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    internal interface IAngleOffscreenWindowInfo : IWindowInfo
    {
        IntPtr Display { get; }
        IntPtr Surface { get; }

        EglContext EglContext { get; }
        EglWindowInfo EglWindowInfo { get; }
    }

    internal sealed class AngleOffscreenWindowInfo : IAngleOffscreenWindowInfo
    {
        private bool _disposed;
        private EglContext _context;

        internal void SetContext(EglContext context)
        {
            _context = context;
        }

        public EglContext EglContext { get { return _context; } }
        public EglWindowInfo EglWindowInfo { get; set; }

        public IntPtr Display
        {
            get { return EglWindowInfo.Display; }
        }

        public IntPtr Surface
        {
            get { return EglWindowInfo.Surface; }
        }

        public IWindowInfo WindowInfo
        {
            get { return EglWindowInfo; }
        }

        public void Dispose()
        {
            Dispose(false);
        }

        ~AngleOffscreenWindowInfo()
        {
            Dispose(true);
        }

        private void Dispose(bool called_from_finalizer)
        {
            if (_disposed)
            {
                return;
            }
            if (!called_from_finalizer)
            {
                // dispose managed
            }
            // dispose unmanaged

            _disposed = true;
            GC.SuppressFinalize(this);
        }

        public IntPtr Handle
        {
            get { return IntPtr.Zero; }
        }
    }
}