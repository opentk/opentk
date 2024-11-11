using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Egl;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OpenTK.Platform.Native.ANGLE
{
    public class ANGLEOpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(ANGLEOpenGLComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal string[] Extensions;

        internal EGLDisplay eglDisplay;
        internal Version eglVersion;

        internal static readonly Dictionary<EGLContext, ANGLEOpenGLContextHandle> ContextDict = new Dictionary<EGLContext, ANGLEOpenGLContextHandle>();

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            string extensionsStr = Egl.QueryString(EGLDisplay.NoDisplay, StringName.Extensions)!;
            Extensions = extensionsStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Logger?.LogDebug($"EGL extensions: {string.Join(", ", Extensions)}");

            // FIXME: Investigate if this component could be modified to handle normal EGL too.
            // - Noggin_bops 2024-03-07
            if (Extensions.Contains("EGL_ANGLE_platform_angle") == false)
            {
                throw new PalException(this, "To create an ANGLE context 'EGL_ANGLE_platform_angle' extension must be supported.");
            }

            // FIXME: What should we really set here?
            int[] attribs = new int[] { (int)ConfigAttribute.RenderableType, (int)RenderableTypeMask.OpenglEs3Bit, (int)ConfigAttribute.None };
            eglDisplay = Egl.EXT.GetPlatformDisplayEXT(Graphics.Egl.Platform.PlatformAngleAngle, (nint)All.DefaultDisplay, attribs);

            bool success = Egl.Initialize(eglDisplay, out int major, out int minor);
            if (success == false)
            {
                ErrorCode error = Egl.GetError();
                throw new PalException(this, $"EGL couldn't initialize successfully. {error}");
            }

            eglVersion = new Version(major, minor);

            // FIXME: This is a per-thread setting, so if the user swtiches threads this is not going to work...
            // - Noggin_bops 2024-11-11
            Egl.BindAPI(RenderApi.OpenglEsApi);
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
        public unsafe OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            // We have to send a Window* to egl, so we need a local variable we can store the Window in
            // so we can take the pointer to this variable.
            // - Noggin_bops 2024-03-07
            IntPtr xwin = ((IntPtr?)(handle as X11.XWindowHandle)?.Window.Id) ?? 0;

            // FIXME: Can we use an SDL window to create an ANGLE context?
            IntPtr windowHandle = handle switch
            {
                Windows.HWND hwnd => hwnd.HWnd,
                X11.XWindowHandle => (IntPtr)(&xwin),
                macOS.NSWindowHandle nswindow => nswindow.Window,

                _ => throw new PlatformNotSupportedException($"OpenTK doesn't support creating an ANGLE context using {handle.GetType()}.")
            };

            // FIXME: OpenGL ES settings? ANGLE specific settings?
            OpenGLGraphicsApiHints? settings = handle.GraphicsApiHints as OpenGLGraphicsApiHints;
            if (settings == null)
            {
                // FIXME: Exception message
                throw new PalException(this, "Window has no graphics settings.");
            }

            bool success = Egl.GetConfig(eglDisplay, null, 0, out int numConfigs);
            EGLConfig[] availableConfigs = new EGLConfig[numConfigs];
            // FIXME: Fix the generator so that it doesn't remove the s...
            success = Egl.GetConfig(eglDisplay, availableConfigs, numConfigs, out numConfigs);

            List<ContextValues> possibleContextValues = new List<ContextValues>();
            for (int i = 0; i < numConfigs; i++)
            {
                EGLConfig config = availableConfigs[i];

                // We only want configs that can render to a window.
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.SurfaceType, out int configSupportedSurfaceTypes);
                if (((SurfaceTypeMask)configSupportedSurfaceTypes & SurfaceTypeMask.WindowBit) == 0)
                    continue;

                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.RenderableType, out int renderableType);
                if (((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEsBit) == 0 &&
                    ((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEs2Bit) == 0 &&
                    ((RenderableTypeMask)renderableType & RenderableTypeMask.OpenglEs3Bit) == 0)
                {
                    continue;
                }

                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.RedSize, out int configRedBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.GreenSize, out int configGreenBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.BlueSize, out int configBlueBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.AlphaSize, out int configAlphaBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.DepthSize, out int configDepthBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.StencilSize, out int configStencilBits);
                Egl.GetConfigAttrib(eglDisplay, config, ConfigAttribute.Samples, out int configSamples);

                ContextValues values;
                values.ID = (ulong)(nint)config;
                values.RedBits = configRedBits;
                values.GreenBits = configGreenBits;
                values.BlueBits = configBlueBits;
                values.AlphaBits = configAlphaBits;
                values.DepthBits = configDepthBits;
                values.StencilBits = configStencilBits;
                // FIXME: Add two values one with double buffering, and one without.
                // We don't seem to be able to guarantee double buffering when using EGL.
                // - Noggin_bops 2024-07-21
                values.DoubleBuffered = true;
                // FIXME: This is something we can only set for the surface attributes
                // so we can't really know this property either...
                // - Noggin_bops 2024-07-21
                values.SRGBFramebuffer = false;
                // FIXME: Potentially use EGL_KHR_gl_colorspace with EGL_EXT_gl_colorspace_bt2020_linear
                // to query this. But these extensions are currently not supported on ANGLE so it's
                // not that important.
                // - Noggin_bops 2024-07-21
                values.PixelFormat = ContextPixelFormat.RGBA;
                // With eglSurfaceAttrib it's possible for us to set the swap method of the
                // surface, but this would have to be done after we've created the surface
                // so we couldn't really guarantee it's available. For now we just say undefined.
                // - Noggin_bops 2024-07-22
                values.SwapMethod = ContextSwapMethod.Undefined;
                values.Samples = configSamples;

                possibleContextValues.Add(values);
            }

            int depthBits;
            switch (settings.DepthBits)
            {
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            int stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            ContextValues requested = new ContextValues();
            requested.RedBits = settings.RedColorBits;
            requested.GreenBits = settings.GreenColorBits;
            requested.BlueBits = settings.BlueColorBits;
            requested.AlphaBits = settings.AlphaColorBits;
            requested.DepthBits = depthBits;
            requested.StencilBits = stencilBits;
            requested.DoubleBuffered = settings.DoubleBuffer;
            requested.SRGBFramebuffer = settings.sRGBFramebuffer;
            requested.PixelFormat = settings.PixelFormat;
            requested.SwapMethod = settings.SwapMethod;
            requested.Samples = settings.Multisamples;

            int selectedFormatIndex = settings.Selector(possibleContextValues, requested, Logger);
            if (selectedFormatIndex < 0 || selectedFormatIndex >= possibleContextValues.Count)
            {
                throw new IndexOutOfRangeException($"The selected format index ({selectedFormatIndex}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
            }

            EGLConfig selectedConfig = new EGLConfig((nint)possibleContextValues[selectedFormatIndex].ID);

            List<int> surface_attribs = new List<int>();
            surface_attribs.Add((int)SurfaceCreateAttribute.RenderBuffer);
            surface_attribs.Add(settings.DoubleBuffer ? (int)RenderBuffer.BackBuffer : (int)RenderBuffer.SingleBuffer);
            // FIXME: We'd like to set this, but it's not supported by angle...
            // - Noggin_bops 2024-07-22
            //surface_attribs.Add(Egl.COLORSPACE);
            //surface_attribs.Add(settings.sRGBFramebuffer ? Egl.COLORSPACE_sRGB : Egl.COLORSPACE_LINEAR);
            surface_attribs.Add((int)SurfaceAttribute.None);

            EGLSurface eglSurface = Egl.EXT.CreatePlatformWindowSurfaceEXT(eglDisplay, selectedConfig, windowHandle, surface_attribs.ToArray());
            if (eglSurface == EGLSurface.NoSurface)
            {
                throw new PalException(this, $"Was not able to create egl surface. {Egl.GetError()}");
            }

            // FIXME: Share context
            List<int> context_attribs = new List<int>() { (int)ContextAttribute.ContextMajorVersion, settings.Version.Major, (int)ContextAttribute.ContextMinorVersion, settings.Version.Minor };
            if (settings.DebugFlag)
            {
                context_attribs.Add((int)ContextAttribute.ContextOpenglDebug);
                context_attribs.Add(1);
            }
            
            context_attribs.Add((int)ContextAttribute.None);

            ANGLEOpenGLContextHandle? shared = settings.SharedContext?.As<ANGLEOpenGLContextHandle>(this);
            EGLContext shareContext = shared?.EglContext ?? EGLContext.NoContext;

            EGLContext contextPtr = Egl.CreateContext(eglDisplay, selectedConfig, shareContext, context_attribs.ToArray());

            ANGLEOpenGLContextHandle context = new ANGLEOpenGLContextHandle(eglSurface, contextPtr, shared);

            ContextDict.Add(contextPtr, context);

            return context;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

            ContextDict.Remove(context.EglContext);

            bool success = Egl.DestroyContext(eglDisplay, context.EglContext);
            if (success == false)
            {
                Logger?.LogError($"Failed to destroy egl context: {Egl.GetError()}");
            }

            success = Egl.DestroySurface(eglDisplay, context.EglSurface);
            if (success == false)
            {
                Logger?.LogError($"Failed to destroy egl surface: {Egl.GetError()}");
            }
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this); 
            return new Pal2BindingsContext(this, context);
        }

        /// <inheritdoc/>
        public nint GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            return Egl.GetProcAddress(procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            EGLContext ptr = Egl.GetCurrentContext();
            if (ptr == EGLContext.NoContext)
            {
                return null;
            }
            else
            {
                return ContextDict[ptr];
            }
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            ANGLEOpenGLContextHandle? context = handle?.As<ANGLEOpenGLContextHandle>(this);
            if (context != null)
            {
                return Egl.MakeCurrent(eglDisplay, context.EglSurface, context.EglSurface, context.EglContext);
            }
            else
            {
                return Egl.MakeCurrent(eglDisplay, EGLSurface.NoSurface, EGLSurface.NoSurface, EGLContext.NoContext);
            }
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
            return context.SharedContext;
        }

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            ANGLEOpenGLContextHandle? context = GetCurrentContext()?.As<ANGLEOpenGLContextHandle>(this);
            if (context != null)
            {
                Egl.SwapInterval(eglDisplay, interval);
                context.SwapInterval = interval;
            }
            else
            {
                Logger?.LogWarning("No context current on the calling thread, can't set swap interval.");
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            ANGLEOpenGLContextHandle? context = GetCurrentContext()?.As<ANGLEOpenGLContextHandle>(this);
            return context?.SwapInterval ?? -1;
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);
            bool success = Egl.SwapBuffers(eglDisplay, context.EglSurface);
            if (success == false)
            {
                Logger?.LogWarning($"Unable to swap buffers: {Egl.GetError()}");
            }
        }

        /// <summary>
        /// Returns the <c>EGLDisplay</c> used by OpenTK.
        /// </summary>
        /// <returns>The <c>EGLDisplay</c> used by OpenTK.</returns>
        public EGLDisplay GetEglDisplay()
        {
            return eglDisplay;
        }

        /// <summary>
        /// Returns the <c>EGLContext</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLContext</c> from.</param>
        /// <returns>The <c>EGLContext</c> associated with the context handle.</returns>
        public EGLContext GetEglContext(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

            return context.EglContext;
        }

        /// <summary>
        /// Returns the <c>EGLSurface</c> associated with the specified context handle.
        /// </summary>
        /// <param name="handle">A handle to an OpenGL context to get the associated <c>EGLSurface</c> from.</param>
        /// <returns>The <c>EGLSurface</c> associated with the context handle.</returns>
        public EGLSurface GetEglSurface(OpenGLContextHandle handle)
        {
            ANGLEOpenGLContextHandle context = handle.As<ANGLEOpenGLContextHandle>(this);

            return context.EglSurface;
        }
    }
}
