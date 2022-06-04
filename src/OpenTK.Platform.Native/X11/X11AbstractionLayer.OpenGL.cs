using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using static OpenTK.Platform.Native.X11.GLX;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IOpenGLComponent
    {
        public bool CanShareContexts => false;
        public bool CanCreateFromWindow => true;
        public bool CanCreateFromSurface => false;

        public Version GLXVersion { get; private set; }
        public HashSet<string> GLXExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXServerExtensions { get; } = new HashSet<string>();
        public HashSet<string> GLXClientExtensions { get; } = new HashSet<string>();
        public string GLXServerVendor { get; private set; } = "Unknown Server";
        public string GLXClientVendor { get; private set; } = "Unknown Client";
        public Version? GLXServerVersion { get; private set; }
        public Version? GLXClientVersion { get; private set; }

        public OpenGLContextHandle CreateFromSurface()
        {
            throw new PalNotImplementedException(this);
        }

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            var window = handle.As<XWindowHandle>(this);
            OpenGLGraphicsApiHints hints = window.GraphicsApiHints as OpenGLGraphicsApiHints;

            List<int> attribs = new List<int>()
            {
                GLX_CONTEXT_MAJOR_VERSION_ARB, hints.Version.Major,
                GLX_CONTEXT_MINOR_VERSION_ARB, hints.Version.Minor,

                GLX_CONTEXT_FLAGS_ARB, (hints.DebugFlag ? GLX_CONTEXT_DEBUG_BIT_ARB : 0) |
                                       (hints.ForwardCompatible ? GLX_CONTEXT_FORWARD_COMPATIBLE_BIT : 0)
            };

            if (hints.Profile != OpenGLProfile.None)
            {
                attribs.Add(GLX_CONTEXT_PROFILE_MASK_ARB);
                attribs.Add(hints.Profile switch
                {
                    OpenGLProfile.Compatibility => GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB,
                    OpenGLProfile.Core => GLX_CONTEXT_CORE_PROFILE_BIT_ARB
                });
            }
            attribs.Add(0);

            int[] attribsArray = attribs.ToArray();

            GLXContext context = s_glXCreateContextAttribARB(
                window.Display,
                window.FBConfig!.Value,
                s_sharedContext?.Context ?? new GLXContext(IntPtr.Zero),
                true,
                ref attribsArray[0]);

            return new XOpenGLContextHandle(window.Display, context, window.Window, s_sharedContext);
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            var xhandle = handle.As<XOpenGLContextHandle>(this);
            glXDestroyContext(xhandle.Display, xhandle.Context);
        }

        public OpenGLContextHandle GetCurrentContext()
        {
            GLXContext context = glXGetCurrentContext();

            return context.Value != IntPtr.Zero ? s_handles[context] : null;
        }

        public IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            var xhandle = handle.As<XOpenGLContextHandle>(this);
            SetCurrentContext(xhandle);
            return s_glXGetProcAddress(procedureName);
        }

        public OpenGLContextHandle GetSharedContext()
        {
            return s_sharedContext;
        }

        public OpenGLContextHandle GetSharedContext(OpenGLContextHandle handle)
        {
            return handle.As<XOpenGLContextHandle>(this).SharedContext;
        }

        public bool SetCurrentContext(OpenGLContextHandle handle)
        {
            var xhandle = handle.As<XOpenGLContextHandle>(this);
            return glXMakeCurrent(xhandle.Display, xhandle.Drawable, xhandle.Context);
        }

        public void SetSharedContext(OpenGLContextHandle handle)
        {
            s_sharedContext = handle.As<XOpenGLContextHandle>(this);
        }

        [ThreadStatic]
        private static XOpenGLContextHandle? s_sharedContext;

        private static ConcurrentDictionary<GLXContext, XOpenGLContextHandle> s_handles =
            new ConcurrentDictionary<GLXContext, XOpenGLContextHandle>();

        private delegate IntPtr glXGetProcAddressProc(string procName);

        private glXGetProcAddressProc s_glXGetProcAddress = null;
        private glXCreateContextAttribARBProc s_glXCreateContextAttribARB = null;

        private void InitializeGL()
        {
            if (!glXQueryExtension(Display, out int errorBase, out int eventBase))
            {
                throw new PalException(this, "This display does not support GLX. Cannot create OpenGL contexts.");
            }

            glXQueryVersion(Display, out int major, out int minor);
            GLXVersion = new Version(major, minor);

            if (GLXVersion < new Version(1, 3))
            {
                // I don't know if it is viable or necessary to support versions less than 1.3
                throw new PalException(this, "GLX Versions less than 1.3 are not supported.");
            }

            string extensions = Marshal.PtrToStringUTF8(glXQueryExtensionsString(Display, DefaultScreen));
            foreach (string extension in extensions.Split(' '))
            {
                GLXExtensions.Add(extension);
            }

            Version? version;
            GLXServerVendor = Marshal.PtrToStringUTF8(glXQueryServerString(Display, DefaultScreen, GLX_VENDOR));
            Version.TryParse(
                Marshal.PtrToStringUTF8(glXQueryServerString(Display, DefaultScreen, GLX_VERSION)),
                out version);
            GLXServerVersion = version;
            string serverExtensions =
                Marshal.PtrToStringUTF8(glXQueryServerString(Display, DefaultScreen, GLX_EXTENSIONS));
            foreach (string extension in serverExtensions.Split(' '))
            {
                GLXServerExtensions.Add(extension);
            }

            GLXClientVendor = Marshal.PtrToStringUTF8(glXGetClientString(Display, GLX_VENDOR));
            Version.TryParse(Marshal.PtrToStringUTF8(glXGetClientString(Display, GLX_VERSION)), out version);
            GLXClientVersion = version;

            string clientExtensions = Marshal.PtrToStringUTF8(glXGetClientString(Display, GLX_EXTENSIONS));
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

            Debug.WriteLine(
                $"GLX Version {major}.{minor}\n" +
                $"  Extensions ({GLXExtensions.Count}) {extensions}\n" +
                 "  Client:\n" +
                $"    Version: {GLXClientVersion?.ToString() ?? "???"}\n" +
                $"    Vendor: {GLXClientVendor}\n" +
                $"    Extensions: ({GLXClientExtensions.Count}) {clientExtensions}\n" +
                 "  Server:\n" +
                $"    Versions: {GLXServerVersion?.ToString() ?? "???"}\n" +
                $"    Vendor: {GLXServerVendor}\n" +
                $"    Extensions: ({GLXServerExtensions.Count}) {serverExtensions}",
                "PAL-2.0/X11"
            );
        }
    }
}
