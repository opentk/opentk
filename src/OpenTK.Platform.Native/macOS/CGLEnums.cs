using System;
namespace OpenTK.Platform.Native.macOS
{
    internal enum NSOpenGLPixelFormatAttribute : uint
    {
        AllRenderers = 1,
        TripleBuffer = 3,
        DoubleBuffer = 5,
        Stereo = 6,
        AuxBuffers = 7,
        ColorSize = 8,
        AlphaSize = 11,
        DepthSize = 12,
        StencilSize = 13,
        AccumSize = 14,
        MinimumPolicy = 51,
        MaximumPolicy = 52,
        OffScreen = 53,
        Fullscreen = 54,
        SampleBuffers = 55,
        Samples = 56,
        AuxDepthStencil = 57,
        ColorFloat = 58,
        Multisample = 59,
        Supersample = 60,
        SampleAlpha = 61,
        RendererID = 70,
        SingleRenderer = 71,
        NoRecovery = 72,
        Accelerated = 73,
        ClosestPolicy = 74,
        Robust = 75,
        BackingStore = 76,
        MPSafe = 78,
        Window = 80,
        MultiScreen = 81,
        Compliant = 83,
        ScreenMask = 84,
        PixelBuffer = 90,
        RemotePixelBuffer = 91,
        AllowOfflineRenderers = 96,
        AcceleratedCompiute = 97,
        OpenGLProfile = 99,
        VirtualScreenCount = 128,
    }

    internal enum NSOpenGLProfileVersion
    {
        Legacy = 0x1000,
        Version3_2Core = 0x3200,
        Version4_1Core = 0x4100,
    }

    internal enum NSOpenGLContextParameter : long
    {
        SwapInterval = 222,
        SurfaceOrder = 235,
        SurfaceOpacity = 236,
        SurfaceBackingSize = 304,
        ReclaimResources = 308,
        CurrentRendererID = 309,
        GPUVertexProcessing = 310,
        GPUFragmentProcessing = 311,
        HasDrawable = 314,
        MPSwapsInFlight = 315,
        SwapRectangle = 200,
        SwapRectangleEnable = 201,
        RasterizationEnable = 221,
        StateValidation = 301,
        SurfaceSurfaceVolatile = 306,
    }

    internal enum CGLError
    {
        /// <summary>
        /// no error
        /// </summary>
        kCGLNoError = 0,
        /// <summary>
        /// invalid pixel format attribute
        /// </summary>
        kCGLBadAttribute = 10000,
        /// <summary>
        /// invalid renderer property
        /// </summary>
        kCGLBadProperty = 10001,
        /// <summary>
        /// invalid pixel format
        /// </summary>
        kCGLBadPixelFormat = 10002,
        /// <summary>
        /// invalid renderer info
        /// </summary>
        kCGLBadRendererInfo = 10003,
        /// <summary>
        /// invalid context
        /// </summary>
        kCGLBadContext = 10004,
        /// <summary>
        /// invalid drawable
        /// </summary>
        kCGLBadDrawable = 10005,
        /// <summary>
        /// invalid graphics device
        /// </summary>
        kCGLBadDisplay = 10006,
        /// <summary>
        /// invalid context state
        /// </summary>
        kCGLBadState = 10007,
        /// <summary>
        /// invalid numerical value
        /// </summary>
        kCGLBadValue = 10008,
        /// <summary>
        /// invalid share context
        /// </summary>
        kCGLBadMatch = 10009,
        /// <summary>
        /// invalid enumerant
        /// </summary>
        kCGLBadEnumeration = 10010,
        /// <summary>
        /// invalid offscreen drawable
        /// </summary>
        kCGLBadOffScreen = 10011,
        /// <summary>
        /// invalid offscreen drawable
        /// </summary>
        kCGLBadFullScreen = 10012,
        /// <summary>
        /// invalid window
        /// </summary>
        kCGLBadWindow = 10013,
        /// <summary>
        /// invalid pointer
        /// </summary>
        kCGLBadAddress = 10014,
        /// <summary>
        /// invalid code module
        /// </summary>
        kCGLBadCodeModule = 10015,
        /// <summary>
        /// invalid memory allocation
        /// </summary>
        kCGLBadAlloc = 10016,
        /// <summary>
        /// invalid CoreGraphics connection
        /// </summary>
        kCGLBadConnection = 10017,
    }

    internal enum CGLPixelFormatAttribute
    {
        /// <summary>
        /// choose from all available renderers
        /// </summary>
        kCGLPFAAllRenderers = 1,
        /// <summary>
        /// choose a double buffered pixel format
        /// </summary>
        kCGLPFADoubleBuffer = 5,
        /// <summary>
        /// stereo buffering supported
        /// </summary>
        kCGLPFAStereo = 6,
        /// <summary>
        /// number of aux buffers
        /// </summary>
        kCGLPFAAuxBuffers = 7,
        /// <summary>
        /// number of color buffer bits
        /// </summary>
        kCGLPFAColorSize = 8,
        /// <summary>
        /// number of alpha component bits
        /// </summary>
        kCGLPFAAlphaSize = 11,
        /// <summary>
        /// number of depth buffer bits
        /// </summary>
        kCGLPFADepthSize = 12,
        /// <summary>
        /// number of stencil buffer bits
        /// </summary>
        kCGLPFAStencilSize = 13,
        /// <summary>
        /// number of accum buffer bits
        /// </summary>
        kCGLPFAAccumSize = 14,
        /// <summary>
        /// never choose smaller buffers than requested
        /// </summary>
        kCGLPFAMinimumPolicy = 51,
        /// <summary>
        /// choose largest buffers of type requested
        /// </summary>
        kCGLPFAMaximumPolicy = 52,
        /// <summary>
        /// choose an off-screen capable renderer
        /// </summary>
        kCGLPFAOffScreen = 53,
        /// <summary>
        /// choose a full-screen capable renderer
        /// </summary>
        kCGLPFAFullScreen = 54,
        /// <summary>
        /// number of multi sample buffers
        /// </summary>
        kCGLPFASampleBuffers = 55,
        /// <summary>
        /// number of samples per multi sample buffer
        /// </summary>
        kCGLPFASamples = 56,
        /// <summary>
        /// each aux buffer has its own depth stencil
        /// </summary>
        kCGLPFAAuxDepthStencil = 57,
        /// <summary>
        /// color buffers store floating point pixels
        /// </summary>
        kCGLPFAColorFloat = 58,
        /// <summary>
        /// choose multisampling
        /// </summary>
        kCGLPFAMultisample = 59,
        /// <summary>
        /// choose supersampling
        /// </summary>
        kCGLPFASupersample = 60,
        /// <summary>
        /// request alpha filtering
        /// </summary>
        kCGLPFASampleAlpha = 61,

        /// <summary>
        /// request renderer by ID
        /// </summary>
        kCGLPFARendererID = 70,
        /// <summary>
        /// choose a single renderer for all screens
        /// </summary>
        kCGLPFASingleRenderer = 71,
        /// <summary>
        /// disable all failure recovery systems
        /// </summary>
        kCGLPFANoRecovery = 72,
        /// <summary>
        /// choose a hardware accelerated renderer
        /// </summary>
        kCGLPFAAccelerated = 73,
        /// <summary>
        /// choose the closest color buffer to request
        /// </summary>
        kCGLPFAClosestPolicy = 74,
        /// <summary>
        /// back buffer contents are valid after swap
        /// </summary>
        kCGLPFABackingStore = 76,
        /// <summary>
        /// can be used to render to an onscreen window
        /// </summary>
        kCGLPFAWindow = 80,
        /// <summary>
        /// renderer is opengl compliant
        /// </summary>
        kCGLPFACompliant = 83,
        /// <summary>
        /// mask limiting supported displays
        /// </summary>
        kCGLPFADisplayMask = 84,
        /// <summary>
        /// can be used to render to a pbuffer
        /// </summary>
        kCGLPFAPBuffer = 90,
        /// <summary>
        /// can be used to render offline to a pbuffer
        /// </summary>
        kCGLPFARemotePBuffer = 91,
        /// <summary>
        /// show offline renderers in pixel formats
        /// </summary>
        kCGLPFAAllowOfflineRenderers = 96,
        /// <summary>
        /// choose a hardware accelerated compute device
        /// </summary>
        kCGLPFAAcceleratedCompute = 97,
        /// <summary>
        /// number of virtual screens in this format
        /// </summary>
        kCGLPFAVirtualScreenCount = 128,

        /*
            Note: 
                kCGLPFARobust, kCGLPFAMPSafe and kCGLPFAMultiScreen attributes will be deprecated in 10.5
                Applications with these attributes will continue to work but these are being
                deprecated for new applications.
        */
        /// <summary>
        /// renderer does not need failure recovery
        /// </summary>
        [Obsolete]
        kCGLPFARobust = 75,
        /// <summary>
        /// renderer is multi-processor safe
        /// </summary>
        [Obsolete]
        kCGLPFAMPSafe = 78,
        /// <summary>
        /// single window can span multiple screens
        /// </summary>
        [Obsolete]
        kCGLPFAMultiScreen = 81,

        kCGLPFAOpenGLProfile = 99,
    }

    enum CGLRendererProperty
    {
        kCGLRPOffScreen = 53,
        kCGLRPFullScreen = 54,
        kCGLRPRendererID = 70,
        kCGLRPAccelerated = 73,
        kCGLRPRobust = 75,
        kCGLRPBackingStore = 76,
        kCGLRPMPSafe = 78,
        kCGLRPWindow = 80,
        kCGLRPMultiScreen = 81,
        kCGLRPCompliant = 83,
        kCGLRPDisplayMask = 84,
        kCGLRPBufferModes = 100,    /* a bitfield of supported buffer modes          */
        kCGLRPColorModes = 103, /* a bitfield of supported color buffer formats  */
        kCGLRPAccumModes = 104, /* a bitfield of supported accum buffer formats  */
        kCGLRPDepthModes = 105, /* a bitfield of supported depth buffer depths   */
        kCGLRPStencilModes = 106,   /* a bitfield of supported stencil buffer depths */
        kCGLRPMaxAuxBuffers = 107,  /* maximum number of auxilliary buffers          */
        kCGLRPMaxSampleBuffers = 108,   /* maximum number of sample buffers              */
        kCGLRPMaxSamples = 109, /* maximum number of samples                     */
        kCGLRPSampleModes = 110,    /* a bitfield of supported sample modes          */
        kCGLRPSampleAlpha = 111,    /* support for alpha sampling                    */
        kCGLRPVideoMemory = 120,    /* total video memory                            */
        kCGLRPTextureMemory = 121,  /* video memory useable for texture storage      */
        kCGLRPGPUVertProcCapable = 122, /* renderer capable of GPU vertex processing     */
        kCGLRPGPUFragProcCapable = 123, /* renderer capable of GPU fragment processing   */
        kCGLRPRendererCount = 128,  /* the number of renderers in this renderer info */
        kCGLRPOnline = 129, /* a boolean stating if renderer is on/offline   */
        kCGLRPAcceleratedCompute = 130  /* hardware accelerated compute device           */
    }


    /* 
    ** Buffer modes
    */
    [Flags]
    internal enum CGLBufferModes
    {
        kCGLMonoscopicBit = 0x00000001,
        kCGLStereoscopicBit = 0x00000002,
        kCGLSingleBufferBit = 0x00000004,
        kCGLDoubleBufferBit = 0x00000008,
        kCGLTripleBufferBit = 0x00000010,
    }

    /*
    ** Depth and stencil buffer depths
    */
    [Flags]
    internal enum CGLDepthStencilModes
    {
        kCGL0Bit = 0x00000001,
        kCGL1Bit = 0x00000002,
        kCGL2Bit = 0x00000004,
        kCGL3Bit = 0x00000008,
        kCGL4Bit = 0x00000010,
        kCGL5Bit = 0x00000020,
        kCGL6Bit = 0x00000040,
        kCGL8Bit = 0x00000080,
        kCGL10Bit = 0x00000100,
        kCGL12Bit = 0x00000200,
        kCGL16Bit = 0x00000400,
        kCGL24Bit = 0x00000800,
        kCGL32Bit = 0x00001000,
        kCGL48Bit = 0x00002000,
        kCGL64Bit = 0x00004000,
        kCGL96Bit = 0x00008000,
        kCGL128Bit = 0x00010000,
    }


    /*
    ** Color and accumulation buffer formats.
    */
    [Flags]
    internal enum CGLColorBufferFormats
    {
        kCGLRGB444Bit = 0x00000040,  /* 16 rgb bit/pixel,    R=11:8, G=7:4, B=3:0              */
        kCGLARGB4444Bit = 0x00000080,  /* 16 argb bit/pixel,   A=15:12, R=11:8, G=7:4, B=3:0     */
        kCGLRGB444A8Bit = 0x00000100,  /* 8-16 argb bit/pixel, A=7:0, R=11:8, G=7:4, B=3:0       */
        kCGLRGB555Bit = 0x00000200,  /* 16 rgb bit/pixel,    R=14:10, G=9:5, B=4:0             */
        kCGLARGB1555Bit = 0x00000400,  /* 16 argb bit/pixel,   A=15, R=14:10, G=9:5, B=4:0       */
        kCGLRGB555A8Bit = 0x00000800,  /* 8-16 argb bit/pixel, A=7:0, R=14:10, G=9:5, B=4:0      */
        kCGLRGB565Bit = 0x00001000,  /* 16 rgb bit/pixel,    R=15:11, G=10:5, B=4:0            */
        kCGLRGB565A8Bit = 0x00002000,  /* 8-16 argb bit/pixel, A=7:0, R=15:11, G=10:5, B=4:0     */
        kCGLRGB888Bit = 0x00004000,  /* 32 rgb bit/pixel,    R=23:16, G=15:8, B=7:0            */
        kCGLARGB8888Bit = 0x00008000,  /* 32 argb bit/pixel,   A=31:24, R=23:16, G=15:8, B=7:0   */
        kCGLRGB888A8Bit = 0x00010000,  /* 8-32 argb bit/pixel, A=7:0, R=23:16, G=15:8, B=7:0     */
        kCGLRGB101010Bit = 0x00020000,  /* 32 rgb bit/pixel,    R=29:20, G=19:10, B=9:0           */
        kCGLARGB2101010Bit = 0x00040000,  /* 32 argb bit/pixel,   A=31:30  R=29:20, G=19:10, B=9:0  */
        kCGLRGB101010_A8Bit = 0x00080000,  /* 8-32 argb bit/pixel, A=7:0  R=29:20, G=19:10, B=9:0    */
        kCGLRGB121212Bit = 0x00100000,  /* 48 rgb bit/pixel,    R=35:24, G=23:12, B=11:0          */
        kCGLARGB12121212Bit = 0x00200000,  /* 48 argb bit/pixel,   A=47:36, R=35:24, G=23:12, B=11:0 */
        kCGLRGB161616Bit = 0x00400000,  /* 64 rgb bit/pixel,    R=63:48, G=47:32, B=31:16         */
        kCGLRGBA16161616Bit = 0x00800000,  /* 64 argb bit/pixel,   R=63:48, G=47:32, B=31:16, A=15:0 */
        kCGLRGBFloat64Bit = 0x01000000,  /* 64 rgb bit/pixel,    half float                        */
        kCGLRGBAFloat64Bit = 0x02000000,  /* 64 argb bit/pixel,   half float                        */
        kCGLRGBFloat128Bit = 0x04000000,  /* 128 rgb bit/pixel,   ieee float                        */
        kCGLRGBAFloat128Bit = 0x08000000,  /* 128 argb bit/pixel,  ieee float                        */
        kCGLRGBFloat256Bit = 0x10000000,  /* 256 rgb bit/pixel,   ieee double                       */
        kCGLRGBAFloat256Bit = 0x20000000,  /* 256 argb bit/pixel,  ieee double                       */
    }


    /*
    ** Sampling modes
    */
    [Flags]
    internal enum CGLSamplingModes
    {
        kCGLSupersampleBit = 0x00000001,
        kCGLMultisampleBit = 0x00000002,
    }

    internal enum CGLOpenGLProfile
    {
        kCGLOGLPVersion_Legacy = 0x1000, /* choose a renderer compatible with GL1.0       */
        kCGLOGLPVersion_3_2_Core = 0x3200, /* choose a renderer capable of GL3.2 or later   */
        kCGLOGLPVersion_GL3_Core = 0x3200, /* choose a renderer capable of GL3.2 or later   */
        kCGLOGLPVersion_GL4_Core = 0x4100, /* choose a renderer capable of GL4.1 or later   */
    }
}

