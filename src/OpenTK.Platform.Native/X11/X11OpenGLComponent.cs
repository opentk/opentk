using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.X11.GLX;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11OpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc />
        public string Name => "X11OpenGLComponent";

        /// <inheritdoc />
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc />
        public ILogger? Logger { get; set; }

        /// <inheritdoc />
        public void Initialize(PalComponents which)
        {
            if (!glXQueryExtension(X11.Display, out int errorBase, out int eventBase))
            {
                throw new PalException(this, "This display does not support GLX. Cannot create OpenGL contexts.");
            }

            glXQueryVersion(X11.Display, out int major, out int minor);
            GLXVersion = new Version(major, minor);

            if (GLXVersion < new Version(1, 3))
            {
                // I don't know if it is viable or necessary to support versions less than 1.3
                throw new PalException(this, "GLX Versions less than 1.3 are not supported.");
            }

            string extensions = glXQueryExtensionsString(X11.Display, X11.DefaultScreen);
            foreach (string extension in extensions.Split(' '))
            {
                GLXExtensions.Add(extension);
            }

            Version? version;
            GLXServerVendor = glXQueryServerString(X11.Display, X11.DefaultScreen, GLX_VENDOR);
            Version.TryParse(glXQueryServerString(X11.Display, X11.DefaultScreen, GLX_VERSION), out version);
            GLXServerVersion = version;
            string serverExtensions = glXQueryServerString(X11.Display, X11.DefaultScreen, GLX_EXTENSIONS);
            foreach (string extension in serverExtensions.Split(' '))
            {
                GLXServerExtensions.Add(extension);
            }

            GLXClientVendor = glXGetClientString(X11.Display, GLX_VENDOR);
            Version.TryParse(glXGetClientString(X11.Display, GLX_VERSION), out version);
            GLXClientVersion = version;

            string clientExtensions = glXGetClientString(X11.Display, GLX_EXTENSIONS);
            foreach (string extension in clientExtensions.Split(' '))
            {
                GLXClientExtensions.Add(extension);
            }

            if (GLXVersion >= new Version(1, 4))
            {
                s_glXGetProcAddress = glXGetProcAddress;
            }
            else if (GLXExtensions.Contains("GLX_ARB_get_proc_address"))
            {
                s_glXGetProcAddress = glXGetProcAddressARB;
            }
            else
            {
                throw new PalException(this, "This X server does not support GetProcAddress.");
            }

            if (GLXExtensions.Contains("GLX_ARB_create_context"))
            {
                s_glXCreateContextAttribARB = Marshal.GetDelegateForFunctionPointer<glXCreateContextAttribARBProc>(
                        s_glXGetProcAddress("glXCreateContextAttribsARB"));
            }
            else
            {
                throw new PalException(this, "GLX_ARB_create_context is required (for the time being).");
            }

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

        /// <inheritdoc />
        public bool CanShareContexts => false;

        /// <inheritdoc />
        public bool CanCreateFromWindow => true;

        /// <inheritdoc />
        public bool CanCreateFromSurface => false;

        public Version GLXVersion { get; private set; }
        public HashSet<string> GLXExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXServerExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXClientExtensions { get; } = new HashSet<string>();
        public string GLXServerVendor { get; private set; } = "Unknown Server";
        public string GLXClientVendor { get; private set; } = "Unknown Client";
        public Version? GLXServerVersion { get; private set; }
        public Version? GLXClientVersion { get; private set; }

        private static Dictionary<GLXContext, XOpenGLContextHandle> contextDict = new Dictionary<GLXContext, XOpenGLContextHandle>();

        private delegate IntPtr glXGetProcAddressProc(string procName);

        private glXGetProcAddressProc s_glXGetProcAddress = null;
        private glXCreateContextAttribARBProc s_glXCreateContextAttribARB = null;

        /// <inheritdoc />
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new PalNotImplementedException(this);
        }

        /// <inheritdoc />
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
                GLX_CONTEXT_MAJOR_VERSION_ARB, hints.Version.Major,
                GLX_CONTEXT_MINOR_VERSION_ARB, hints.Version.Minor,

                GLX_CONTEXT_FLAGS_ARB, (hints.DebugFlag ? GLX_CONTEXT_DEBUG_BIT_ARB : 0) |
                                       (hints.ForwardCompatibleFlag ? GLX_CONTEXT_FORWARD_COMPATIBLE_BIT : 0)
            };

            if (hints.Profile != OpenGLProfile.None)
            {
                attribs.Add(GLX_CONTEXT_PROFILE_MASK_ARB);
                attribs.Add(hints.Profile switch
                {
                    OpenGLProfile.Compatibility => GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB,
                    OpenGLProfile.Core => GLX_CONTEXT_CORE_PROFILE_BIT_ARB,
                    _ => throw new Exception() // This exception satisfies the linter.
                });
            }

            XOpenGLContextHandle? sharedContext = hints.SharedContext as XOpenGLContextHandle;

            GLXContext context = s_glXCreateContextAttribARB(
                window.Display,
                window.FBConfig!.Value,
                sharedContext?.Context ?? new GLXContext(IntPtr.Zero),
                true,
                ref CollectionsMarshal.AsSpan(attribs)[0]);

            XOpenGLContextHandle contextHandle = new XOpenGLContextHandle(window.Display, context, window.Window, sharedContext);

            contextDict[contextHandle.Context] = contextHandle;

            return contextHandle;
        }

        /// <inheritdoc />
        public void DestroyContext(OpenGLContextHandle handle)
        {
            var xhandle = handle.As<XOpenGLContextHandle>(this);
            glXDestroyContext(xhandle.Display, xhandle.Context);
        }

        /// <inheritdoc />
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        /// <inheritdoc />
        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            XOpenGLContextHandle xhandle = handle.As<XOpenGLContextHandle>(this);
            SetCurrentContext(xhandle);
            return s_glXGetProcAddress(procedureName);
        }

        /// <inheritdoc />
        public OpenGLContextHandle? GetCurrentContext()
        {
            GLXContext context = glXGetCurrentContext();

            return context.Value != IntPtr.Zero ? contextDict[context] : null;
        }

        /// <inheritdoc />
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            XOpenGLContextHandle? xhandle = handle?.As<XOpenGLContextHandle>(this);

            if (xhandle != null)
            {
                return glXMakeCurrent(X11.Display, xhandle.Drawable, xhandle.Context);
            }
            else
            {
                return glXMakeCurrent(X11.Display, XDrawable.None, new GLXContext(IntPtr.Zero));
            }
        }

        /// <inheritdoc />
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

                glXQueryDrawable(X11.Display, context.Drawable, GLX_MAX_SWAP_INTERVAL_EXT, out uint max_interval);

                return (int)max_interval;
            }
            else
            {
                return null;
            }
        }

        /// <inheritdoc />
        public void SetSwapInterval(int interval)
        {
            XOpenGLContextHandle? context = GetCurrentContext() as XOpenGLContextHandle;
            if (context == null)
            {
                throw new InvalidOperationException("No context bound. Can't set swap interval.");
            }

            if (GLXExtensions.Contains("GLX_EXT_swap_control"))
            {
                glXQueryDrawable(X11.Display, context.Drawable, GLX_MAX_SWAP_INTERVAL_EXT, out uint max_interval);
                if (interval > max_interval)
                {
                    Logger?.LogWarning($"Specified swap interval '{interval}' is larger than the max supported inverval of '{max_interval}'. Clamping to the maximum swap interval.");
                    interval = (int)max_interval;
                }

                glXSwapIntervalEXT(X11.Display, context.Drawable, interval);
            }
            else if (GLXExtensions.Contains("GLX_MESA_swap_control"))
            {
                int status = glXSwapIntervalMESA((uint)interval);
                if (status != 0)
                {
                    Logger?.LogWarning($"glXSwapIntervalMESA failed with: {status}");
                }
            }
            else if (GLXExtensions.Contains("GLX_SGI_swap_control"))
            {
                int status = glXSwapIntervalSGI(interval);
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

        /// <inheritdoc />
        public int GetSwapInterval()
        {
            XOpenGLContextHandle? context = GetCurrentContext() as XOpenGLContextHandle;
            if (context == null)
            {
                throw new InvalidOperationException("No context bound. Can't get swap interval.");
            }

            if (GLXExtensions.Contains("GLX_EXT_swap_control"))
            {
                glXQueryDrawable(X11.Display, context.Drawable, GLX_SWAP_INTERVAL_EXT, out uint interval);
                return (int)interval;
            }
            else if (GLXExtensions.Contains("GLX_MESA_swap_control"))
            {
                int interval = glXGetSwapIntervalMESA();
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
    }
}
