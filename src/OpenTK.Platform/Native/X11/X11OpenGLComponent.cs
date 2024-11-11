using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Platform;
using OpenTK.Core.Utility;
//using static OpenTK.Platform.Native.X11.GLX;
using OpenTK.Graphics.Glx;

namespace OpenTK.Platform.Native.X11
{
    public class X11OpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => "X11OpenGLComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        public Version GLXVersion { get; private set; }
        public HashSet<string> GLXExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXServerExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXClientExtensions { get; } = new HashSet<string>();
        public string GLXServerVendor { get; private set; } = "Unknown Server";
        public string GLXClientVendor { get; private set; } = "Unknown Client";
        public Version? GLXServerVersion { get; private set; }
        public Version? GLXClientVersion { get; private set; }

        internal bool ARB_robustness_isolation { get; set; }
        internal bool ARB_create_context_robustness { get; set; }
        internal bool ARB_create_context_no_error { get; set; }
        internal bool ARB_context_flush_control { get; set; }

        private static Dictionary<GLXContext, XOpenGLContextHandle> contextDict = new Dictionary<GLXContext, XOpenGLContextHandle>();

        private delegate IntPtr glXGetProcAddressProc(string procName);

        private glXGetProcAddressProc s_glXGetProcAddress = null!;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            if (!Glx.QueryExtension(X11.Display, out int errorBase, out int eventBase))
            {
                throw new PalException(this, "This display does not support GLX. Cannot create OpenGL contexts.");
            }

            Glx.QueryVersion(X11.Display, out int major, out int minor);
            GLXVersion = new Version(major, minor);

            if (GLXVersion < new Version(1, 3))
            {
                // I don't know if it is viable or necessary to support versions less than 1.3
                throw new PalException(this, "GLX Versions less than 1.3 are not supported.");
            }

            string extensions = Glx.QueryExtensionsString(X11.Display, X11.DefaultScreen)!;
            foreach (string extension in extensions.Split(' '))
            {
                GLXExtensions.Add(extension);
            }

            Version? version;
            
            GLXServerVendor = Glx.QueryServerString(X11.Display, X11.DefaultScreen, StringName.Vendor)!;
            Version.TryParse(Glx.QueryServerString(X11.Display, X11.DefaultScreen, StringName.Version), out version);
            GLXServerVersion = version;
            string serverExtensions = Glx.QueryServerString(X11.Display, X11.DefaultScreen, StringName.Extensions)!;
            foreach (string extension in serverExtensions.Split(' '))
            {
                GLXServerExtensions.Add(extension);
            }

            GLXClientVendor = Glx.GetClientString(X11.Display, StringName.Vendor)!;
            Version.TryParse(Glx.GetClientString(X11.Display, StringName.Vendor), out version);
            GLXClientVersion = version;

            string clientExtensions = Glx.GetClientString(X11.Display, StringName.Extensions)!;
            foreach (string extension in clientExtensions.Split(' '))
            {
                GLXClientExtensions.Add(extension);
            }

            if (GLXVersion >= new Version(1, 4))
            {
                s_glXGetProcAddress = Glx.GetProcAddress;
            }
            else if (GLXExtensions.Contains("GLX_ARB_get_proc_address"))
            {
                s_glXGetProcAddress = Glx.ARB.GetProcAddressARB;
            }
            else
            {
                throw new PalException(this, "This X server does not support GetProcAddress.");
            }

            if (GLXExtensions.Contains("GLX_ARB_create_context"))
            {
                unsafe
                {
                    GlxPointers._glXCreateContextAttribsARB_fnptr = (delegate* unmanaged<nint, nint, nint, byte, int*, nint>)s_glXGetProcAddress("glXCreateContextAttribsARB");
                }
            }
            else
            {
                throw new PalException(this, "GLX_ARB_create_context is required (for the time being).");
            }

            ARB_create_context_robustness = GLXExtensions.Contains("GLX_ARB_create_context_robustness");
            ARB_robustness_isolation = GLXExtensions.Contains("GLX_ARB_robustness_application_isolation");
            ARB_create_context_no_error = GLXExtensions.Contains("GLX_ARB_create_context_no_error");
            ARB_context_flush_control = GLXExtensions.Contains("GLX_ARB_context_flush_control");

            Logger?.LogInfo(
                $"GLX Version {major}.{minor}\n" +
                $"  Extensions ({GLXExtensions.Count}) {extensions}\n" +
                 "  Client:\n" +
                $"    Version: {GLXClientVersion?.ToString() ?? "???"}\n" +
                $"    Vendor: {GLXClientVendor}\n" +
                $"    Extensions: ({GLXClientExtensions.Count}) {clientExtensions}\n" +
                 "  Server:\n" +
                $"    Versions: {GLXServerVersion?.ToString() ?? "???"}\n" +
                $"    Vendor: {GLXServerVendor}\n" +
                $"    Extensions: ({GLXServerExtensions.Count}) {serverExtensions}"
            );
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
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
            throw new PalNotImplementedException(this);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            XWindowHandle window = handle.As<XWindowHandle>(this);
            OpenGLGraphicsApiHints? hints = window.GraphicsApiHints as OpenGLGraphicsApiHints;
            if (hints == null)
            {
                throw new PalException(this, $"Invalid graphics api hints. Got settings of type: {window.GraphicsApiHints?.GetType().ToString() ?? "null"}");
            }

            List<int> attribs = new List<int>()
            {
                (int)ContextAttribs.ContextMajorVersionArb, hints.Version.Major,
                (int)ContextAttribs.ContextMinorVersionArb, hints.Version.Minor,
            };

            {
                ContextFlags flags = 0;

                if (hints.DebugFlag)
                {
                    flags |= ContextFlags.ContextDebugBitArb;
                }

                if (hints.ForwardCompatibleFlag)
                {
                    flags |= ContextFlags.ContextForwardCompatibleBitArb;
                }

                if (ARB_create_context_robustness && hints.RobustnessFlag)
                {
                    flags |= ContextFlags.ContextRobustAccessBitArb;
                }

                if (ARB_robustness_isolation && hints.ResetIsolationFlag)
                {
                    flags |= ContextFlags.ContextResetIsolationBitArb;
                }

                attribs.Add((int)ContextAttribs.ContextFlagsArb);
                attribs.Add((int)flags);
            }

            if (hints.Profile != OpenGLProfile.None)
            {
                attribs.Add((int)ContextAttribs.ContextProfileMaskArb);
                attribs.Add(hints.Profile switch
                {
                    OpenGLProfile.Compatibility => (int)ContextProfileMask.ContextCompatibilityProfileBitArb,
                    OpenGLProfile.Core => (int)ContextProfileMask.ContextCoreProfileBitArb,
                    _ => throw new Exception() // This exception satisfies the linter.
                });
            }

            if (ARB_create_context_robustness && hints.RobustnessFlag)
            {
                attribs.Add((int)ContextAttribs.ContextResetNotificationStrategyArb);
                switch (hints.ResetNotificationStrategy)
                {
                    case ContextResetNotificationStrategy.NoResetNotification:
                        attribs.Add((int)ResetNotificationStrategy.NoResetNotificationArb);
                        break;
                    case ContextResetNotificationStrategy.LoseContextOnReset:
                        attribs.Add((int)ResetNotificationStrategy.LoseContextOnResetArb);
                        break;
                    default:
                        throw new InvalidEnumArgumentException(nameof(hints.ResetNotificationStrategy), (int)hints.ResetNotificationStrategy, hints.ResetNotificationStrategy.GetType());
                }
            }

            if (ARB_create_context_no_error && hints.NoErrorFlag)
            {
                attribs.Add((int)ContextAttribs.ContextOpenglNoErrorArb);
                attribs.Add(1);
            }

            if (ARB_context_flush_control && hints.UseFlushControl)
            {
                attribs.Add((int)ContextAttribs.ContextReleaseBehaviorArb);
                switch (hints.ReleaseBehaviour)
                {
                    case ContextReleaseBehaviour.None:
                        attribs.Add((int)ContextReleaseBehavior.ContextReleaseBehaviorNoneArb);
                        break;
                    case ContextReleaseBehaviour.Flush:
                        attribs.Add((int)ContextReleaseBehavior.ContextReleaseBehaviorFlushArb);
                        break;
                    default:
                        throw new InvalidEnumArgumentException(nameof(hints.ReleaseBehaviour), (int)hints.ReleaseBehaviour, hints.ReleaseBehaviour.GetType());
                }
            }

            {
                attribs.Add((int)ContextAttribs.RenderType);
                switch (window.PixelFormat)
                {
                    case ContextPixelFormat.RGBAPackedFloat:
                        attribs.Add((int)RenderType.RgbaUnsignedFloatTypeExt);
                        break;
                    case ContextPixelFormat.RGBAFloat:
                        attribs.Add((int)RenderType.RgbaFloatTypeArb);
                        break;
                    case ContextPixelFormat.RGBA:
                        attribs.Add((int)RenderType.RgbaType);
                        break;
                    default:
                        throw new InvalidEnumArgumentException(nameof(window.PixelFormat), (int)window.PixelFormat, window.PixelFormat.GetType());
                }
            }

            // Add the terminating attribute.
            attribs.Add(0);
            attribs.Add(0);

            XOpenGLContextHandle? sharedContext = hints.SharedContext as XOpenGLContextHandle;

            // FIXME: This might not be able to create OpenGL 1.0 contexts...
            // See: https://github.com/glfw/glfw/blob/3eaf1255b29fdf5c2895856c7be7d7185ef2b241/src/glx_context.c#L592-L595
            // - Noggin_bops 2023-08-26
            GLXContext context = Glx.ARB.CreateContextAttribsARB(
                window.Display,
                window.FBConfig!.Value,
                sharedContext?.Context ?? new GLXContext(IntPtr.Zero),
                true,
                ref CollectionsMarshal.AsSpan(attribs)[0]);

            // FIXME: This was added in glX 1.3, earlier versions of glX allowed passing the
            // Window itself instead of making a GLXWindow. Maybe we should do something to
            // check the glX version.
            // - Noggin_bops 2023-08-27
            GLXWindow glxWindow;
            unsafe
            {
                glxWindow = Glx.CreateWindow(X11.Display, window.FBConfig!.Value, window.Window, (int*)null);
            }

            XOpenGLContextHandle contextHandle = new XOpenGLContextHandle(window.Display, context, glxWindow, window.Window, sharedContext);

            contextDict[contextHandle.Context] = contextHandle;

            return contextHandle;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            var xhandle = handle.As<XOpenGLContextHandle>(this);
            // FIXME: Remove the glxWindow from the window handle!
            Glx.DestroyWindow(X11.Display, xhandle.GLXWindow);
            Glx.DestroyContext(X11.Display, xhandle.Context);
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        /// <inheritdoc/>
        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            XOpenGLContextHandle xhandle = handle.As<XOpenGLContextHandle>(this);
            return s_glXGetProcAddress(procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            GLXContext context = Glx.GetCurrentContext();

            return context.Value != IntPtr.Zero ? contextDict[context] : null;
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            XOpenGLContextHandle? xhandle = handle?.As<XOpenGLContextHandle>(this);

            if (xhandle != null)
            {
                return Glx.MakeCurrent(X11.Display, (GLXDrawable)xhandle.GLXWindow, xhandle.Context);
            }
            else
            {
                return Glx.MakeCurrent(X11.Display, GLXDrawable.None, new GLXContext(IntPtr.Zero));
            }
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            return handle.As<XOpenGLContextHandle>(this).SharedContext;
        }

        /// <summary>
        /// Queries EXT_swap_control for the max supported swap interval.
        /// This function returns <c>null</c> if EXT_swap_control is not supported.
        /// </summary>
        public int? EXT_swap_control_GetMaxSwapInterval()
        {
            if (GLXExtensions.Contains("GLX_EXT_swap_control"))
            {
                XOpenGLContextHandle? context = GetCurrentContext() as XOpenGLContextHandle;
                if (context == null)
                {
                    throw new InvalidOperationException("No context bound. Can't set swap interval.");
                }

                Glx.QueryDrawable(X11.Display, (GLXDrawable)context.GLXWindow, DrawableAttrib.MaxSwapIntervalExt, out uint max_interval);

                return (int)max_interval;
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            XOpenGLContextHandle? context = GetCurrentContext() as XOpenGLContextHandle;
            if (context == null)
            {
                throw new InvalidOperationException("No context bound. Can't set swap interval.");
            }

            if (GLXExtensions.Contains("GLX_EXT_swap_control"))
            {
                Glx.QueryDrawable(X11.Display, (GLXDrawable)context.GLXWindow, DrawableAttrib.MaxSwapIntervalExt, out uint max_interval);
                if (interval > max_interval)
                {
                    Logger?.LogWarning($"Specified swap interval '{interval}' is larger than the max supported inverval of '{max_interval}'. Clamping to the maximum swap interval.");
                    interval = (int)max_interval;
                }

                Glx.EXT.SwapIntervalEXT(X11.Display, (GLXDrawable)context.GLXWindow, interval);
            }
            else if (GLXExtensions.Contains("GLX_MESA_swap_control"))
            {
                int status = Glx.MESA.SwapIntervalMESA((uint)interval);
                if (status != 0)
                {
                    Logger?.LogWarning($"glXSwapIntervalMESA failed with: {status}");
                }
            }
            else if (GLXExtensions.Contains("GLX_SGI_swap_control"))
            {
                int status = Glx.SGI.SwapIntervalSGI(interval);
                if (status != 0)
                {
                    Logger?.LogWarning($"glXSwapIntervalSGI failed with: {status}");
                }
                else
                {
                    context.SGISwapInterval = interval;
                }
            }
            else
            {
                Logger?.LogWarning("GLX doesn't support GLX_EXT_swap_control, GLX_MESA_swap_control or GLX_SGI_swap_control. Can't set swap interval.");
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            XOpenGLContextHandle? context = GetCurrentContext() as XOpenGLContextHandle;
            if (context == null)
            {
                throw new InvalidOperationException("No context bound. Can't get swap interval.");
            }

            if (GLXExtensions.Contains("GLX_EXT_swap_control"))
            {
                Glx.QueryDrawable(X11.Display, (GLXDrawable)context.GLXWindow, DrawableAttrib.SwapIntervalExt, out uint interval);
                return (int)interval;
            }
            else if (GLXExtensions.Contains("GLX_MESA_swap_control"))
            {
                int interval = Glx.MESA.GetSwapIntervalMESA();
                return interval;
            }
            else if (GLXExtensions.Contains("GLX_SGI_swap_control"))
            {
                return context.SGISwapInterval;
            }
            else
            {
                Logger?.LogWarning("GLX doesn't support GLX_EXT_swap_control, GLX_MESA_swap_control, or GLX_SGI_swap_control. Can't get swap interval.");
                return 0;
            }
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            XOpenGLContextHandle context = handle.As<XOpenGLContextHandle>(this);
            Glx.SwapBuffers(context.Display, (GLXDrawable)context.GLXWindow);
        }

        /// <summary>
        /// Gets the <c>GLXContext</c> associated with this OpenGL context.
        /// </summary>
        /// <param name="handle">A handle to the OpenGL context to get the <c>GLXContext</c> from.</param>
        /// <returns>The <c>GLXContext</c> associated with the OpenGL context.</returns>
        public IntPtr GetGLXContext(OpenGLContextHandle handle)
        {
            XOpenGLContextHandle xhandle = handle.As<XOpenGLContextHandle>(this);

            return xhandle.Context.Value;
        }

        /// <summary>
        /// Gets the <c>GLXWindow</c> associated with this OpenGL context.
        /// </summary>
        /// <param name="handle">A handle to the OpenGL context to get the <c>GLXWindow</c> from.</param>
        /// <returns>The <c>GLXWindow</c> associated with the OpenGL context.</returns>
        public IntPtr GetGLXWindow(OpenGLContextHandle handle)
        {
            XOpenGLContextHandle xhandle = handle.As<XOpenGLContextHandle>(this);

            return xhandle.GLXWindow.Value;
        }
    }
}
