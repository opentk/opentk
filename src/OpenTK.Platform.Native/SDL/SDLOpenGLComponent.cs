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
        public void Initialize(ToolkitOptions options)
        {
            int result = SDL_GL_LoadLibrary(null);
            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL Failed to initialize OpenGL: {error}");
            }
        }

        /// <inheritdoc/>
        public bool CanShareContexts => true;

        /// <inheritdoc/>
        public bool CanCreateFromWindow => true;

        /// <inheritdoc/>
        public bool CanCreateFromSurface => false;

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            OpenGLGraphicsApiHints settings = (OpenGLGraphicsApiHints)window.GraphicsApiHints;

            SDLOpenGLContext? sharedContext = settings.SharedContext?.As<SDLOpenGLContext>(this);

            // FIXME: Set all GL settings attriutes! See SDLWindowComponent.Create for details.

            // On Windows, macos, and linux the SDL_GL_SHARE_WITH_CURRENT_CONTEXT attribute is only read
            // during SDL_GL_CreateContext so it is important we set it here.
            // - 2023-06-29 Noggin_bops
            SDL_GLContext prevContext = SDL_GL_GetCurrentContext();
            SDL_WindowPtr prevWindow = SDL_GL_GetCurrentWindow();
            if (sharedContext != null)
            {
                SDL_GL_MakeCurrent(sharedContext.Window.Window, sharedContext.Context);
                SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_SHARE_WITH_CURRENT_CONTEXT, 1);
            }

            SDL_GLContext context = SDL_GL_CreateContext(window.Window);

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_SHARE_WITH_CURRENT_CONTEXT, 0);
            if (prevContext != SDL_GLContext.Null)
            {
                SDL_GL_MakeCurrent(prevWindow, prevContext);
            }

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
            return GetCurrentContextInternal();
        }

        internal static OpenGLContextHandle? GetCurrentContextInternal()
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
            SDLOpenGLContext? context = handle?.As<SDLOpenGLContext>(this);

            int result = SDL_GL_MakeCurrent(context?.Window.Window ?? SDL_WindowPtr.Null, context?.Context ?? SDL_GLContext.Null);
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

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            SDLOpenGLContext context = handle.As<SDLOpenGLContext>(this);

            SDL_GL_SwapWindow(context.Window.Window);
        }
    }
}
