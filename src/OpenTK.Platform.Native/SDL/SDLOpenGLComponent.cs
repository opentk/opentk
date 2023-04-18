using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLOpenGLComponent : IOpenGLComponent
    {
        internal static readonly Dictionary<SDL_GLContext, SDLOpenGLContext> ContextDict = new Dictionary<SDL_GLContext, SDLOpenGLContext>();

        /// <inheritdoc/>
        public string Name => nameof(SDLOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.OpenGL)
            {
                throw new PalException(this, "SDLOpenGLComponent can only initialize the OpenGL component.");
            }

            int result = SDL_GL_LoadLibrary(null);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL Failed to initialize OpenGL: {error}");
            }
        }

        /// <inheritdoc/>
        public bool CanShareContexts => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool CanCreateFromWindow => true;

        /// <inheritdoc/>
        public bool CanCreateFromSurface => throw new NotImplementedException();

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GLContext context = SDL_GL_CreateContext(window.Window);

            SDLOpenGLContext? sharedContext = (window.GraphicsApiHints as OpenGLGraphicsApiHints)?.SharedContext as SDLOpenGLContext;

            SDLOpenGLContext sdlContext = new SDLOpenGLContext(context, window, sharedContext);

            ContextDict.Add(context, sdlContext);

            return sdlContext;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            SDLOpenGLContext context = handle.As<SDLOpenGLContext>(this);

            ContextDict.Remove(context.Context);

            SDL_GL_DeleteContext(context.Context);
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        /// <inheritdoc/>
        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            SDLOpenGLContext sdlContext = handle.As<SDLOpenGLContext>(this);

            return SDL_GL_GetProcAddress(procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            SDL_GLContext context = SDL_GL_GetCurrentContext();
            if (context == SDL_GLContext.Null)
            {
                return null;
            }
            else
            {
                return ContextDict[context];
            }
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            SDLOpenGLContext context = handle.As<SDLOpenGLContext>(this);

            int result = SDL_GL_MakeCurrent(context.Window.Window, context.Context);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL failed to make context current: {error}");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            SDLOpenGLContext context = handle.As<SDLOpenGLContext>(this);

            return context.SharedContext;
        }

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            SDL_GL_SetSwapInterval(interval);
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            return SDL_GL_GetSwapInterval();
        }
    }
}
