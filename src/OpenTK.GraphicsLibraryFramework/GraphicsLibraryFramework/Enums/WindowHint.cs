//
// WindowHint.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

// TODO: Need to create WindowAttrib enum and see if any need duplicate/moved to that one since there is a syntactic difference
namespace OpenToolkit.GraphicsLibraryFramework
{
    public enum WindowHint
    {
        Focused = 0x00020001,
        Iconified = 0x00020002,
        Resizable = 0x00020003,
        Visible = 0x00020004,
        Decorated = 0x00020005,
        AutoIconify = 0x00020006,
        Floating = 0x00020007,
        Maximized = 0x00020008,

        RedBits = 0x00021001,
        GreenBits = 0x00021002,
        BlueBits = 0x00021003,
        AlphaBits = 0x00021004,
        DepthBits = 0x00021005,
        StencilBits = 0x00021006,
        AccumRedBits = 0x00021007,
        AccumGreenBits = 0x00021008,
        AccumBlueBits = 0x00021009,
        AccumAlphaBits = 0x0002100A,
        AuxBuffers = 0x0002100B,
        Stereo = 0x0002100C,
        Samples = 0x0002100D,
        SrgbCapable = 0x0002100E,
        RefreshRate = 0x0002100F,
        DoubleBuffer = 0x00021010,

        ClientApi = 0x00022001,
        ContextVersionMajor = 0x00022002,
        ContextVersionMinor = 0x00022003,
        ContextRevision = 0x00022004,
        ContextRobustness = 0x00022005,
        OpenGLForwardCompat = 0x00022006,
        OpenGLDebugContext = 0x00022007,
        OpenGLProfile = 0x00022008,
        ContextReleaseBehavior = 0x00022009,
        ContextNoError = 0x0002200A,
        ContextCreationApi = 0x0002200B
    }
}