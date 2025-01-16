using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    namespace OpenGL
    {
        public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, byte* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGL.Compatibility
    {
        public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES1
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES2
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace Glx
    {
        /// <summary>
        /// Opaque struct pointer for X11 <c>Display*</c>.
        /// </summary>
        public struct DisplayPtr
        {
            /// <summary>
            /// The underlying pointer value.
            /// </summary>
            public IntPtr Value;

            /// <summary>
            /// Constructs a new <c>Display*</c> wrapper struct from a <c>Display</c> pointer.
            /// </summary>
            /// <param name="value">The display pointer.</param>
            public DisplayPtr(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator IntPtr(DisplayPtr handle) => handle.Value;
            public static explicit operator DisplayPtr(IntPtr ptr) => new DisplayPtr(ptr);
        }

        /// <summary>
        /// Opaque struct pointer for X11 <c>Screen*</c>.
        /// </summary>
        public struct ScreenPtr
        {
            /// <summary>
            /// The underlying pointer value.
            /// </summary>
            public IntPtr Value;

            /// <summary>
            /// Constructs a new <c>Screen*</c> wrapper struct from a <c>Screen</c> pointer.
            /// </summary>
            /// <param name="value">The screen pointer.</param>
            public ScreenPtr(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator IntPtr(ScreenPtr handle) => handle.Value;
            public static explicit operator ScreenPtr(IntPtr ptr) => new ScreenPtr(ptr);
        }

        /// <summary>
        /// An X11 window handle.
        /// </summary>
        public struct Window
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new Window wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the window.</param>
            public Window(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(Window handle) => handle.XID;
            public static explicit operator Window(nuint xid) => new Window(xid);
        }

        /// <summary>
        /// An X11 font handle.
        /// </summary>
        public struct Font
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new Font wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the window.</param>
            public Font(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(Font handle) => handle.XID;
            public static explicit operator Font(nuint xid) => new Font(xid);
        }

        /// <summary>
        /// An X11 pixmap handle.
        /// </summary>
        public struct Pixmap
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new pixmap wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the Pixmap.</param>
            public Pixmap(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(Pixmap handle) => handle.XID;
            public static explicit operator Pixmap(nuint xid) => new Pixmap(xid);
        }

        /// <summary>
        /// An X11 Colormap handle.
        /// </summary>
        public struct Colormap
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new Colormap wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the Colormap.</param>
            public Colormap(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(Colormap handle) => handle.XID;
            public static explicit operator Colormap(nuint xid) => new Colormap(xid);
        }

        /// <summary>
        /// Opaque struct pointer for X11 <c>XVisualInfo*</c>.
        /// </summary>
        public struct XVisualInfoPtr
        {
            /// <summary>
            /// The underlying pointer value.
            /// </summary>
            public IntPtr Value;

            /// <summary>
            /// Constructs a new <c>XVisualInfo*</c> wrapper struct from a <c>XVisualInfo</c> pointer.
            /// </summary>
            /// <param name="value">The screen pointer.</param>
            public XVisualInfoPtr(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator IntPtr(XVisualInfoPtr handle) => handle.Value;
            public static explicit operator XVisualInfoPtr(IntPtr ptr) => new XVisualInfoPtr(ptr);
        }

        /// <summary>
        /// A GLX GLXFBConfigID handle.
        /// </summary>
        public struct GLXFBConfigID
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXFBConfigID wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXFBConfigID.</param>
            public GLXFBConfigID(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXFBConfigID handle) => handle.XID;
            public static explicit operator GLXFBConfigID(nuint xid) => new GLXFBConfigID(xid);
        }

        /// <summary>
        /// A struct wrapper for GLXFBConfig.
        /// </summary>
        public struct GLXFBConfig
        {
            public IntPtr Value;

            public GLXFBConfig(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator GLXFBConfig(IntPtr val) => new GLXFBConfig(val);
            public static explicit operator IntPtr(GLXFBConfig val) => val.Value;
        }

        /// <summary>
        /// An GLX GLXContextID handle.
        /// </summary>
        public struct GLXContextID
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXContextID wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXContextID.</param>
            public GLXContextID(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXContextID handle) => handle.XID;
            public static explicit operator GLXContextID(nuint xid) => new GLXContextID(xid);
        }

        /// <summary>
        /// A struct wrapper for GLXContext.
        /// </summary>
        public struct GLXContext
        {
            public IntPtr Value;

            public GLXContext(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator GLXContext(IntPtr val) => new GLXContext(val);
            public static explicit operator IntPtr(GLXContext val) => val.Value;
        }

        /// <summary>
        /// A GLX GLXPixmap handle.
        /// </summary>
        public struct GLXPixmap
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXPixmap wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXPixmap.</param>
            public GLXPixmap(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXPixmap handle) => handle.XID;
            public static explicit operator GLXPixmap(nuint xid) => new GLXPixmap(xid);
        }

        /// <summary>
        /// A GLX GLXDrawable handle.
        /// </summary>
        public struct GLXDrawable
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXDrawable wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXDrawable.</param>
            public GLXDrawable(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXDrawable handle) => handle.XID;
            public static explicit operator GLXDrawable(nuint xid) => new GLXDrawable(xid);
        }

        /// <summary>
        /// A GLX GLXWindow handle.
        /// </summary>
        public struct GLXWindow
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXWindow wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXWindow.</param>
            public GLXWindow(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXWindow handle) => handle.XID;
            public static explicit operator GLXWindow(nuint xid) => new GLXWindow(xid);
        }

        /// <summary>
        /// A GLX GLXPbuffer handle.
        /// </summary>
        public struct GLXPbuffer
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXPbuffer wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXPbuffer.</param>
            public GLXPbuffer(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXPbuffer handle) => handle.XID;
            public static explicit operator GLXPbuffer(nuint xid) => new GLXPbuffer(xid);
        }

        /// <summary>
        /// A GLX GLXVideoCaptureDeviceNV handle.
        /// </summary>
        public struct GLXVideoCaptureDeviceNV
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXVideoCaptureDeviceNV wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXVideoCaptureDeviceNV.</param>
            public GLXVideoCaptureDeviceNV(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXVideoCaptureDeviceNV handle) => handle.XID;
            public static explicit operator GLXVideoCaptureDeviceNV(nuint xid) => new GLXVideoCaptureDeviceNV(xid);
        }

        /// <summary>
        /// A GLX GLXVideoSourceSGIX handle.
        /// </summary>
        public struct GLXVideoSourceSGIX
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXVideoSourceSGIX wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXVideoSourceSGIX.</param>
            public GLXVideoSourceSGIX(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXVideoSourceSGIX handle) => handle.XID;
            public static explicit operator GLXVideoSourceSGIX(nuint xid) => new GLXVideoSourceSGIX(xid);
        }

        /// <summary>
        /// A GLX GLXFBConfigIDSGIX handle.
        /// </summary>
        public struct GLXFBConfigIDSGIX
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXFBConfigIDSGIX wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXFBConfigIDSGIX.</param>
            public GLXFBConfigIDSGIX(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXFBConfigIDSGIX handle) => handle.XID;
            public static explicit operator GLXFBConfigIDSGIX(nuint xid) => new GLXFBConfigIDSGIX(xid);
        }

        /// <summary>
        /// An struct wrapper for GLXFBConfigSGIX.
        /// </summary>
        public struct GLXFBConfigSGIX
        {
            public IntPtr Value;

            public GLXFBConfigSGIX(IntPtr value)
            {
                Value = value;
            }

            public static explicit operator GLXFBConfigSGIX(IntPtr val) => new GLXFBConfigSGIX(val);
            public static explicit operator IntPtr(GLXFBConfigSGIX val) => val.Value;
        }

        /// <summary>
        /// A GLX GLXPbufferSGIX handle.
        /// </summary>
        public struct GLXPbufferSGIX
        {
            /// <summary>
            /// The underlying XID.
            /// </summary>
            public nuint XID;

            /// <summary>
            /// Constructs a new GLXPbufferSGIX wrapper struct from an XID.
            /// </summary>
            /// <param name="xid">The XID of the GLXPbufferSGIX.</param>
            public GLXPbufferSGIX(nuint xid)
            {
                XID = xid;
            }

            public static explicit operator nuint(GLXPbufferSGIX handle) => handle.XID;
            public static explicit operator GLXPbufferSGIX(nuint xid) => new GLXPbufferSGIX(xid);
        }

        /// <summary>
        /// A GLXVideoDeviceNV handle.
        /// </summary>
        public struct GLXVideoDeviceNV
        {
            /// <summary>
            /// The underlying uint value.
            /// </summary>
            public uint VideoDevice;

            /// <summary>
            /// Constructs a new GLXVideoDeviceNV wrapper struct from a uint.
            /// </summary>
            /// <param name="videoDevice">A uint representing a video device.</param>
            public GLXVideoDeviceNV(uint videoDevice)
            {
                VideoDevice = videoDevice;
            }

            public static explicit operator uint(GLXVideoDeviceNV handle) => handle.VideoDevice;
            public static explicit operator GLXVideoDeviceNV(uint videoDevice) => new GLXVideoDeviceNV(videoDevice);
        }


        public unsafe struct GLXHyperpipeConfigSGIX
        {
            public fixed byte PipeName[80]; /* Should be [GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX] */
            public int Channel;
            public uint ParticipationType;
            public int TimeSlice;
        }

        public unsafe struct GLXHyperpipeNetworkSGIX
        {
            public fixed byte PipeName[80]; /* Should be [GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX] */
            public int NetworkId;
        }
    }

    namespace Wgl
    {

        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public struct ColorRef
        {
            [FieldOffset(0)]
            public byte Red;
            [FieldOffset(1)]
            public byte Green;
            [FieldOffset(2)]
            public byte Blue;
        }

        public struct LayerPlaneDescriptor
        {
            public ushort nSize;
            public ushort nVersion;
            public uint dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerPlane;
            public byte bReserved;
            public ColorRef crTransparent;
        }

        public struct PixelFormatDescriptor
        {
            public ushort nSize;
            public ushort nVersion;
            public uint dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public uint dwLayerMask;
            public uint dwVisibleMask;
            public uint dwDamageMask;
        }

        public unsafe struct _GPU_DEVICE
        {
            public uint cb;
            public fixed byte DeviceName[32];
            public fixed byte DeviceString[128];
            public uint Flags; // FIXME: Enum
            public Rect rcVirtualScreen;
        }
    }

    namespace Egl
    {
        public unsafe delegate void EGLDebugProcKHR(All error, byte* command, int messageType, EGLLabelKHR threadLabel, EGLLabelKHR objectLabel, byte* message);

        public unsafe delegate void EGLSetBlobFuncANDROID(void* key, nint keySize, void* value, nint valueSize);
        public unsafe delegate nint EGLGetBlobFuncANDROID(void* key, nint keySize, void* value, nint valueSize);

        public struct EGLClientBuffer
        {
            public nint Value;

            public EGLClientBuffer(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLClientBuffer handle) => handle.Value;
            public static explicit operator EGLClientBuffer(nint value) => new EGLClientBuffer(value);
        }

        public struct EGLConfig
        {
            public nint Value;

            public EGLConfig(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLConfig handle) => handle.Value;
            public static explicit operator EGLConfig(nint value) => new EGLConfig(value);
        }

        public struct EGLContext : IEquatable<EGLContext>
        {
            public static EGLContext NoContext => new EGLContext(0);

            public nint Value;

            public EGLContext(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLContext handle) => handle.Value;
            public static explicit operator EGLContext(nint value) => new EGLContext(value);

            public static bool operator ==(EGLContext left, EGLContext right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EGLContext left, EGLContext right)
            {
                return !(left == right);
            }

            public override readonly bool Equals(object? obj)
            {
                return obj is EGLContext context && Equals(context);
            }

            public readonly bool Equals(EGLContext other)
            {
                return Value.Equals(other.Value);
            }

            public override readonly int GetHashCode()
            {
                return HashCode.Combine(Value);
            }
        }

        public struct EGLDeviceEXT
        {
            public nint Value;

            public EGLDeviceEXT(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLDeviceEXT handle) => handle.Value;
            public static explicit operator EGLDeviceEXT(nint value) => new EGLDeviceEXT(value);
        }

        public struct EGLDisplay
        {
            public static EGLDisplay NoDisplay => new EGLDisplay(0);

            public nint Value;

            public EGLDisplay(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLDisplay handle) => handle.Value;
            public static explicit operator EGLDisplay(nint value) => new EGLDisplay(value);
        }

        public struct EGLImage
        {
            public nint Value;

            public EGLImage(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLImage handle) => handle.Value;
            public static explicit operator EGLImage(nint value) => new EGLImage(value);
        }

        public struct EGLImageKHR
        {
            public nint Value;

            public EGLImageKHR(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLImageKHR handle) => handle.Value;
            public static explicit operator EGLImageKHR(nint value) => new EGLImageKHR(value);
        }

        public struct EGLLabelKHR
        {
            public nint Value;

            public EGLLabelKHR(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLLabelKHR handle) => handle.Value;
            public static explicit operator EGLLabelKHR(nint value) => new EGLLabelKHR(value);
        }

        public struct EGLObjectKHR
        {
            public nint Value;

            public EGLObjectKHR(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLObjectKHR handle) => handle.Value;
            public static explicit operator EGLObjectKHR(nint value) => new EGLObjectKHR(value);
        }

        public struct EGLOutputLayerEXT
        {
            public nint Value;

            public EGLOutputLayerEXT(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLOutputLayerEXT handle) => handle.Value;
            public static explicit operator EGLOutputLayerEXT(nint value) => new EGLOutputLayerEXT(value);
        }

        public struct EGLOutputPortEXT
        {
            public nint Value;

            public EGLOutputPortEXT(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLOutputPortEXT handle) => handle.Value;
            public static explicit operator EGLOutputPortEXT(nint value) => new EGLOutputPortEXT(value);
        }

        public struct EGLStreamKHR
        {
            public nint Value;

            public EGLStreamKHR(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLStreamKHR handle) => handle.Value;
            public static explicit operator EGLStreamKHR(nint value) => new EGLStreamKHR(value);
        }

        public struct EGLSurface : IEquatable<EGLSurface>
        {
            public static EGLSurface NoSurface => new EGLSurface(0);

            public nint Value;

            public EGLSurface(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLSurface handle) => handle.Value;
            public static explicit operator EGLSurface(nint value) => new EGLSurface(value);

            public static bool operator ==(EGLSurface left, EGLSurface right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(EGLSurface left, EGLSurface right)
            {
                return !(left == right);
            }

            public override readonly bool Equals(object? obj)
            {
                return obj is EGLSurface surface && Equals(surface);
            }

            public readonly bool Equals(EGLSurface other)
            {
                return Value.Equals(other.Value);
            }

            public override readonly int GetHashCode()
            {
                return HashCode.Combine(Value);
            }
        }

        public struct EGLSync
        {
            public nint Value;

            public EGLSync(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLSync handle) => handle.Value;
            public static explicit operator EGLSync(nint value) => new EGLSync(value);
        }

        public struct EGLSyncKHR
        {
            public nint Value;

            public EGLSyncKHR(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLSyncKHR handle) => handle.Value;
            public static explicit operator EGLSyncKHR(nint value) => new EGLSyncKHR(value);
        }

        public struct EGLSyncNV
        {
            public nint Value;

            public EGLSyncNV(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(EGLSyncNV handle) => handle.Value;
            public static explicit operator EGLSyncNV(nint value) => new EGLSyncNV(value);
        }

        public struct AHardwareBuffer
        {
            public nint Value;

            public AHardwareBuffer(nint value)
            {
                Value = value;
            }

            public static explicit operator nint(AHardwareBuffer handle) => handle.Value;
            public static explicit operator AHardwareBuffer(nint value) => new AHardwareBuffer(value);
        }


        public struct EGLClientPixmapHI
        {
            public IntPtr pData;
            public int iWidth;
            public int iHeight;
            public int iStride;
        }
    }

    /// <summary>
    /// A collection of named "special" numbers in OpenGL.
    /// </summary>
    public static class SpecialNumbers
    {
        public const int False = 0;
        public const int NoError = 0;
        public const int Zero = 0;
        public const int None = 0;
        public const int NoneOES = 0;
        public const int True = 1;
        public const int One = 1;
        public const uint InvalidIndex = 0xFFFFFFFF;
        public const int AllPixelsAMD = unchecked((int)0xFFFFFFFF);
        public const ulong TimeoutIgnored = 0xFFFFFFFFFFFFFFFF;
        public const ulong TimeoutIgnoredAPPLE = 0xFFFFFFFFFFFFFFFF;
        // These are used for #ifdefs in the c headers, so we don't need to include them in the output bindings.
        // They are just written here for completeness.
        //  - 2021-07-05
        // public const int VersionESCL10 = 1;
        // public const int VersionESCM11 = 1;
        // public const int VersionESCL11 = 1;
        public const int UUIDSizeEXT = 16;
        public const int LUIDSizeEXT = 8;
    }

    public struct CLContext : IEquatable<CLContext>
    {
        public IntPtr Value;

        public CLContext(IntPtr value)
        {
            Value = value;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is CLContext context && Equals(context);
        }

        public readonly bool Equals(CLContext other)
        {
            return Value.Equals(other.Value);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(CLContext left, CLContext right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLContext left, CLContext right)
        {
            return !(left == right);
        }

        public static explicit operator CLContext(IntPtr val) => new CLContext(val);
        public static explicit operator IntPtr(CLContext val) => val.Value;
    }

    public struct CLEvent : IEquatable<CLEvent>
    {
        public IntPtr Value;

        public CLEvent(IntPtr value)
        {
            Value = value;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is CLEvent @event && Equals(@event);
        }

        public readonly bool Equals(CLEvent other)
        {
            return Value.Equals(other.Value);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(CLEvent left, CLEvent right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLEvent left, CLEvent right)
        {
            return !(left == right);
        }

        public static explicit operator CLEvent(IntPtr val) => new CLEvent(val);
        public static explicit operator IntPtr(CLEvent val) => val.Value;
    }

    public struct GLSync : IEquatable<GLSync>
    {
        public IntPtr Value;

        public GLSync(IntPtr value)
        {
            Value = value;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is GLSync sync && Equals(sync);
        }

        public readonly bool Equals(GLSync other)
        {
            return Value.Equals(other.Value);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(GLSync left, GLSync right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLSync left, GLSync right)
        {
            return !(left == right);
        }

        public static explicit operator GLSync(IntPtr val) => new GLSync(val);
        public static explicit operator IntPtr(GLSync val) => val.Value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GLHandleARB : IEquatable<GLHandleARB>
    {
        [FieldOffset(0)] private readonly uint _value1;
        [FieldOffset(0)] private readonly IntPtr _value2;

        public GLHandleARB(uint val)
        {
            _value2 = IntPtr.Zero;
            _value1 = val;
        }

        public GLHandleARB(IntPtr val)
        {
            _value1 = 0;
            _value2 = val;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is GLHandleARB aRB && Equals(aRB);
        }

        public readonly bool Equals(GLHandleARB other)
        {
            return _value2.Equals(other._value2);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(_value2);
        }

        public static bool operator ==(GLHandleARB left, GLHandleARB right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLHandleARB left, GLHandleARB right)
        {
            return !(left == right);
        }

        public static explicit operator GLHandleARB(uint val) => new GLHandleARB(val);
        public static explicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
        public static explicit operator uint(GLHandleARB val) => val._value1;
        public static explicit operator IntPtr(GLHandleARB val) => val._value2;
    }

    public struct ProgramHandle : IEquatable<ProgramHandle>
    {
        public static readonly ProgramHandle Zero = new ProgramHandle(0);

        public int Handle;

        public ProgramHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is ProgramHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] ProgramHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ProgramHandle left, ProgramHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ProgramHandle left, ProgramHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ProgramHandle(int Program1) => new ProgramHandle(Program1);
        public static explicit operator int(ProgramHandle programHandle) => programHandle.Handle;
    }

    public struct ProgramPipelineHandle : IEquatable<ProgramPipelineHandle>
    {
        public static readonly ProgramPipelineHandle Zero = new ProgramPipelineHandle(0);

        public int Handle;

        public ProgramPipelineHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is ProgramPipelineHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] ProgramPipelineHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ProgramPipelineHandle left, ProgramPipelineHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ProgramPipelineHandle left, ProgramPipelineHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ProgramPipelineHandle(int ProgramPipeline) => new ProgramPipelineHandle(ProgramPipeline);
        public static explicit operator int(ProgramPipelineHandle programPipelineHandle) => programPipelineHandle.Handle;
    }

    public struct TextureHandle : IEquatable<TextureHandle>
    {
        public static readonly TextureHandle Zero = new TextureHandle(0);

        public int Handle;

        public TextureHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is TextureHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] TextureHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(TextureHandle left, TextureHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TextureHandle left, TextureHandle right)
        {
            return !(left == right);
        }

        public static explicit operator TextureHandle(int Texture) => new TextureHandle(Texture);
        public static explicit operator int(TextureHandle textureHandle) => textureHandle.Handle;
    }

    public struct BufferHandle : IEquatable<BufferHandle>
    {
        public static readonly BufferHandle Zero = new BufferHandle(0);

        public int Handle;

        public BufferHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is BufferHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] BufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(BufferHandle left, BufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BufferHandle left, BufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator BufferHandle(int Buffer1) => new BufferHandle(Buffer1);
        public static explicit operator int(BufferHandle bufferHandle) => bufferHandle.Handle;
    }

    public struct ShaderHandle : IEquatable<ShaderHandle>
    {
        public static readonly ShaderHandle Zero = new ShaderHandle(0);

        public int Handle;

        public ShaderHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is ShaderHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] ShaderHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ShaderHandle left, ShaderHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ShaderHandle left, ShaderHandle right)
        {
            return !(left == right);
        }

        public static explicit operator ShaderHandle(int shader) => new ShaderHandle(shader);
        public static explicit operator int(ShaderHandle shaderHandle) => shaderHandle.Handle;
    }

    public struct QueryHandle : IEquatable<QueryHandle>
    {
        public static readonly QueryHandle Zero = new QueryHandle(0);

        public int Handle;

        public QueryHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is QueryHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] QueryHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(QueryHandle left, QueryHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(QueryHandle left, QueryHandle right)
        {
            return !(left == right);
        }

        public static explicit operator QueryHandle(int Query) => new QueryHandle(Query);
        public static explicit operator int(QueryHandle queryHandle) => queryHandle.Handle;
    }

    public struct FramebufferHandle : IEquatable<FramebufferHandle>
    {
        public static readonly FramebufferHandle Zero = new FramebufferHandle(0);

        public int Handle;

        public FramebufferHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is FramebufferHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] FramebufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(FramebufferHandle left, FramebufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(FramebufferHandle left, FramebufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator FramebufferHandle(int Framebuffer) => new FramebufferHandle(Framebuffer);
        public static explicit operator int(FramebufferHandle framebufferHandle) => framebufferHandle.Handle;
    }

    public struct RenderbufferHandle : IEquatable<RenderbufferHandle>
    {
        public static readonly RenderbufferHandle Zero = new RenderbufferHandle(0);

        public int Handle;

        public RenderbufferHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is RenderbufferHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] RenderbufferHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(RenderbufferHandle left, RenderbufferHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RenderbufferHandle left, RenderbufferHandle right)
        {
            return !(left == right);
        }

        public static explicit operator RenderbufferHandle(int Renderbuffer) => new RenderbufferHandle(Renderbuffer);
        public static explicit operator int(RenderbufferHandle renderbufferHandle) => renderbufferHandle.Handle;
    }

    public struct SamplerHandle : IEquatable<SamplerHandle>
    {
        public static readonly SamplerHandle Zero = new SamplerHandle(0);

        public int Handle;

        public SamplerHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is SamplerHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] SamplerHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(SamplerHandle left, SamplerHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SamplerHandle left, SamplerHandle right)
        {
            return !(left == right);
        }

        public static explicit operator SamplerHandle(int Sampler) => new SamplerHandle(Sampler);
        public static explicit operator int(SamplerHandle samplerHandle) => samplerHandle.Handle;
    }

    public struct TransformFeedbackHandle : IEquatable<TransformFeedbackHandle>
    {
        public static readonly TransformFeedbackHandle Zero = new TransformFeedbackHandle(0);

        public int Handle;

        public TransformFeedbackHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is TransformFeedbackHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] TransformFeedbackHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(TransformFeedbackHandle left, TransformFeedbackHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TransformFeedbackHandle left, TransformFeedbackHandle right)
        {
            return !(left == right);
        }

        public static explicit operator TransformFeedbackHandle(int TransformFeedback) => new TransformFeedbackHandle(TransformFeedback);
        public static explicit operator int(TransformFeedbackHandle transformFeedbackHandle) => transformFeedbackHandle.Handle;
    }

    public struct VertexArrayHandle : IEquatable<VertexArrayHandle>
    {
        public static readonly VertexArrayHandle Zero = new VertexArrayHandle(0);

        public int Handle;

        public VertexArrayHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is VertexArrayHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] VertexArrayHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(VertexArrayHandle left, VertexArrayHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VertexArrayHandle left, VertexArrayHandle right)
        {
            return !(left == right);
        }

        public static explicit operator VertexArrayHandle(int VertexArray) => new VertexArrayHandle(VertexArray);
        public static explicit operator int(VertexArrayHandle vertexArrayHandle) => vertexArrayHandle.Handle;
    }

    public struct DisplayListHandle : IEquatable<DisplayListHandle>
    {
        public static readonly DisplayListHandle Zero = new DisplayListHandle(0);

        public int Handle;

        public DisplayListHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is DisplayListHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] DisplayListHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(DisplayListHandle left, DisplayListHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DisplayListHandle left, DisplayListHandle right)
        {
            return !(left == right);
        }

        public static explicit operator DisplayListHandle(int DisplayList) => new DisplayListHandle(DisplayList);
        public static explicit operator int(DisplayListHandle displayListHandle) => displayListHandle.Handle;
    }

    public struct PerfQueryHandle : IEquatable<PerfQueryHandle>
    {
        public static readonly PerfQueryHandle Zero = new PerfQueryHandle(0);

        public int Handle;

        public PerfQueryHandle(int handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is PerfQueryHandle device && Equals(device);
        }

        public readonly bool Equals([AllowNull] PerfQueryHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(PerfQueryHandle left, PerfQueryHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PerfQueryHandle left, PerfQueryHandle right)
        {
            return !(left == right);
        }

        public static explicit operator PerfQueryHandle(int perfQuery) => new PerfQueryHandle(perfQuery);
        public static explicit operator int(PerfQueryHandle perfQueryHandle) => perfQueryHandle.Handle;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
