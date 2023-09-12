using System;
namespace OpenTK.Platform.Native.macOS
{
    internal enum NSOpenGLPixelFormatAttribute : uint
    {
        AllRenderers =  1,
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
}

