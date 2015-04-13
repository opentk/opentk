using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    /// <summary>
    ///     Sets up OpenTK for offscreen rendering using an Angle backend.
    /// </summary>
    public interface IAngleOffscreenRendering : IDisposable
    {
        /// <summary>
        ///     The OpenTK Graphics Context.
        /// </summary>
        IGraphicsContext Context { get; }

        /// <summary>
        ///     The offscreen 'window' info.
        /// </summary>
        IWindowInfo WindowInfo { get; }

        /// <summary>
        ///     Get a pointer to the backend texture used by Angle.
        ///     At the moment, this is only supported for the Direct3D configurations.
        /// </summary>
        /// <returns>A Direct3D SharedHandle to the underlying texture.</returns>
        IntPtr QuerySurfacePointer();

        /// <summary>
        ///     MakeCurrent the default offscreen surface.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        ///     Resize the default offscreen surface.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void Resize(int width, int height);
    }

    /// <summary>
    /// Additional functionality for using multiple surfaces for offscreen rendering.
    /// The client is responsible for making sure that all created surfaces are destroyed.
    /// </summary>
    public interface IAngleMultiSurfaceOffscreenRendering : IAngleOffscreenRendering
    {
        /// <summary>
        ///     Create an additional offscreen surface for rendering.
        /// </summary>
        /// <returns></returns>
        IntPtr CreateSurface(int width, int height);

        /// <summary>
        ///     Destroy an surface that was created with CreateSurface.
        /// </summary>
        void DestroySurface(ref IntPtr surface);

        /// <summary>
        ///     Make current an additional surface created with CreateSurface.
        /// </summary>
        void MakeCurrent(IntPtr surface);

        /// <summary>
        ///     Get a pointer to the backend texture used by Angle.
        ///     At the moment, this is only supported for the Direct3D configurations.
        /// </summary>
        /// <returns>A Direct3D SharedHandle to the underlying texture.</returns>
        IntPtr QuerySurfacePointer(IntPtr surface);
    }

    /// <summary>
    ///     Sets up OpenTK for offscreen rendering using an Angle backend.
    /// </summary>
    public class AngleOffscreenRendering : IAngleMultiSurfaceOffscreenRendering
    {
        private readonly IGraphicsContext _context;
        private readonly bool _d3d_backend;
        private readonly IAngleOffscreenWindowInfo _window_info;
        private bool _disposed;

        /// <summary>
        ///     Simple constructor that will choose the backend based on 
        ///     minimal requirements for the OpenGL|ES version.
        /// </summary>
        /// <param name="major">OpenGL|ES version, should be 2 or 3</param>
        public AngleOffscreenRendering(int major)
            : this(new GraphicsMode(32, 24), 
            major, 0, 
            major == 2
                ? GraphicsContextFlags.AngleD3D9
                : GraphicsContextFlags.AngleD3D11)
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="mode">An OpenTK GraphicsMode</param>
        /// <param name="major">OpenGL|ES major version, must be 2 or 3</param>
        /// <param name="minor">OpenGL|ES minor version, should be 0</param>
        /// <param name="flags">
        ///     GraphicsContextFlags allow a user to configure Direct3D9 or Direct3D11-based rendering, defaults to
        ///     D3D9 for OpenGL|ES 2 and D3D11 for OpenGL|ES 3.
        /// </param>
        public AngleOffscreenRendering(GraphicsMode mode, int major, int minor,
            GraphicsContextFlags flags)
        {
            flags |= GraphicsContextFlags.Embedded
                     | GraphicsContextFlags.Offscreen
                     | GraphicsContextFlags.Angle;
            _window_info = new AngleOffscreenWindowInfo();
            _context = new GraphicsContext(mode, _window_info, major, minor, flags);
            _context.LoadAll();
            _d3d_backend = UseDirect3DBackend(flags);
        }

        private EglWindowInfo EglWindowInfo
        {
            get { return _window_info.EglWindowInfo; }
        }

        private EglContext EglContext
        {
            get { return _window_info.EglContext; }
        }

        IGraphicsContext IAngleOffscreenRendering.Context
        {
            get { return _context; }
        }

        IWindowInfo IAngleOffscreenRendering.WindowInfo
        {
            get { return _window_info; }
        }

        void IAngleOffscreenRendering.MakeCurrent()
        {
            _context.MakeCurrent(EglWindowInfo);
        }

        void IAngleOffscreenRendering.Resize(int width, int height)
        {
            var config = _context.GraphicsMode.Index.Value;
            EglWindowInfo.CreatePbufferSurface(config, width, height);
        }

        /// <summary>
        /// Dispose this offscreen rendering instance, its WindowInfo and GraphicsContext.
        /// </summary>
        public void Dispose()
        {
            Dispose(false);
        }

        IntPtr IAngleMultiSurfaceOffscreenRendering.CreateSurface(int width, int height)
        {
            IntPtr surface;
            EglWindowInfo.CreatePbufferSurface(_context.GraphicsMode.Index.Value,
                width, height, out surface);
            return surface;
        }

        void IAngleMultiSurfaceOffscreenRendering.DestroySurface(ref IntPtr surface)
        {
            EglWindowInfo.DestroySurface(ref surface);
        }

        void IAngleMultiSurfaceOffscreenRendering.MakeCurrent(IntPtr surface)
        {
            Egl.MakeCurrent(EglWindowInfo.Display, surface, surface, EglContext.HandleAsEGLContext);
        }

        IntPtr IAngleOffscreenRendering.QuerySurfacePointer()
        {
            return GetSurfacePointerAngle(EglWindowInfo.Surface);
        }

        IntPtr IAngleMultiSurfaceOffscreenRendering.QuerySurfacePointer(IntPtr surface)
        {
            return GetSurfacePointerAngle(surface);
        }

        private IntPtr GetSurfacePointerAngle(IntPtr surface)
        {
            IntPtr ptr;
            if (_d3d_backend &&
                Egl.QuerySurfacePointerANGLE(EglWindowInfo.Display, surface,
                    Egl.EGL_D3D_TEXTURE_2D_SHARE_HANDLE_ANGLE, out ptr))
            {
                return ptr;
            }
            return IntPtr.Zero;
        }

        /// <summary>
        ///     Finalizer
        /// </summary>
        ~AngleOffscreenRendering()
        {
            Dispose(true);
        }

        private void Dispose(bool called_from_finalizer)
        {
            if (_disposed)
                return;

            if (!called_from_finalizer)
            {
                _window_info.Dispose();
                _context.Dispose();
            }

            GC.SuppressFinalize(this);
            _disposed = true;
        }

        private bool UseDirect3DBackend(GraphicsContextFlags flags)
        {
            return (flags & GraphicsContextFlags.AngleOpenGL) == 0;
        }
    }
}