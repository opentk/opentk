using System;
using OpenTK.Graphics;
using OpenTK.Platform.Windows;

namespace OpenTK.Platform.Egl
{
    using EGLSurface = IntPtr;
    /// <summary>
    /// A window info for angle. 
    /// </summary>
    public interface IAngleWindowInfo : IWindowInfo
    {
        /// <summary>
        /// Query the underlying platform pointer / handle for this window's 
        /// default surface or IntPtr.Zero
        /// </summary>
        IntPtr QuerySurfacePointer();
        /// <summary>
        /// Create an additional rendering surface that shares the display
        /// of this window.
        /// </summary>
        /// <param name="width">width in pixels</param>
        /// <param name="height">height in pixels</param>
        /// <returns>A reference to the new surface</returns>
        EGLSurface CreateSurface(int width, int height);
        /// <summary>
        /// Destroy a surface created with CreateSurface and clears the passed reference.
        /// </summary>
        /// <param name="surface">Reference to the surface.</param>
        void DestroySurface(ref EGLSurface surface);
        /// <summary>
        /// MakeCurrent the custom surface created with CreateSurface.
        /// </summary>
        /// <param name="surface">Reference to the surface.</param>
        void MakeCurrent(EGLSurface surface);
        /// <summary>
        /// Query the underlying platform pointer / handle for an EGLSurface 
        /// created with CreateSurface.
        /// </summary>
        /// <param name="surface"></param>
        IntPtr QuerySurfacePointer(EGLSurface surface);
    }

    internal interface IAngleWindowInfoInternal : IAngleWindowInfo
    {
        IWindowInfo PlatformWindow { get; }
        IntPtr Display { get; }
        IntPtr Surface { get; }
        EglContext EglContext { get; set; }
        EglWindowInfo EglWindowInfo { get; set; }
        IntPtr DeviceContext { get; }
    }

    internal class AngleWindowInfo : IAngleWindowInfoInternal
    {
        private bool _disposed;

        public AngleWindowInfo(IWindowInfo platform_window)
        {
            PlatformWindow = platform_window;
        }

        public IWindowInfo PlatformWindow { get; }

        public IWindowInfo WindowInfo
        {
            get { return EglWindowInfo; }
        }

        public IntPtr DeviceContext
        {
            get
            {
                var win_win = PlatformWindow as WinWindowInfo;
                if (win_win != null)
                {
                    return win_win.DeviceContext;
                }
                return IntPtr.Zero;
            }
        }

        public EglContext EglContext { get; set; }
        public EglWindowInfo EglWindowInfo { get; set; }

        public IntPtr Display
        {
            get { return EglWindowInfo.Display; }
        }

        public IntPtr Surface
        {
            get { return EglWindowInfo.Surface; }
        }

        public void Dispose()
        {
            Dispose(false);
        }

        public IntPtr Handle
        {
            get { return PlatformWindow.Handle; }
        }

        ~AngleWindowInfo()
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
                PlatformWindow.Dispose();
            }
            // dispose unmanaged

            _disposed = true;
            GC.SuppressFinalize(this);
        }

        public IntPtr QuerySurfacePointer()
        {
            return QuerySurfacePointer(Surface);
        }

        public EGLSurface CreateSurface(int width, int height)
        {
            IntPtr surface;
            EglWindowInfo.CreatePbufferSurface(
                EglContext.GraphicsMode.Index.Value,
                width, height, 
                out surface);
            return surface;
        }

        public void DestroySurface(ref EGLSurface surface)
        {
            EglWindowInfo.DestroySurface(ref surface);
        }

        public void MakeCurrent(EGLSurface surface)
        {
            Egl.MakeCurrent(Display, surface, surface, EglContext.HandleAsEGLContext);
        }

        public IntPtr QuerySurfacePointer(IntPtr surface)
        {
            if (UsesDirect3DBackend())
            {
                return QuerySurfacePointer(surface, 
                    Egl.EGL_D3D_TEXTURE_2D_SHARE_HANDLE_ANGLE);
            }
            return IntPtr.Zero;
        }

        private IntPtr QuerySurfacePointer(IntPtr surface, int attrib)
        {
            IntPtr surface_pointer;
            if (Egl.QuerySurfacePointerANGLE(
                Display, surface, attrib, out surface_pointer))
            {
                return surface_pointer;
            }
            return IntPtr.Zero;
        }

        private bool UsesDirect3DBackend()
        {
            var d3d_flags = GraphicsContextFlags.AngleD3D9 | GraphicsContextFlags.AngleD3D11;
            return ((EglContext.GraphicsContextFlags & d3d_flags) != 0);
        }
    }
}