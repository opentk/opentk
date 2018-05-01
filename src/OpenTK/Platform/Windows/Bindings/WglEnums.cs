namespace OpenTK.Platform.Windows
{
#pragma warning disable 3019
#pragma warning disable 1591

    public enum ArbCreateContext
    {
        CoreProfileBit = 0x0001,
        CompatibilityProfileBit = 0x0002,
        DebugBit = 0x0001,
        ForwardCompatibleBit = 0x0002,
        MajorVersion = 0x2091,
        MinorVersion = 0x2092,
        LayerPlane = 0x2093,
        ContextFlags = 0x2094,
        ErrorInvalidVersion = 0x2095,
        ProfileMask = 0x9126
    }

    public enum WGL_ARB_buffer_region
    {
        BackColorBufferBitArb = 0x00000002,
        StencilBufferBitArb = 0x00000008,
        FrontColorBufferBitArb = 0x00000001,
        DepthBufferBitArb = 0x00000004
    }

    public enum WGL_EXT_pixel_format
    {
        SupportGdiExt = 0x200f,
        TypeColorindexExt = 0x202c,
        AccelerationExt = 0x2003,
        GreenBitsExt = 0x2017,
        DrawToWindowExt = 0x2001,
        SwapCopyExt = 0x2029,
        DrawToBitmapExt = 0x2002,
        TransparentExt = 0x200a,
        SwapMethodExt = 0x2007,
        SwapLayerBuffersExt = 0x2006,
        PixelTypeExt = 0x2013,
        AlphaShiftExt = 0x201c,
        AccumRedBitsExt = 0x201e,
        FullAccelerationExt = 0x2027,
        SupportOpenglExt = 0x2010,
        BlueShiftExt = 0x201a,
        RedBitsExt = 0x2015,
        NoAccelerationExt = 0x2025,
        StereoExt = 0x2012,
        GreenShiftExt = 0x2018,
        BlueBitsExt = 0x2019,
        AlphaBitsExt = 0x201b,
        RedShiftExt = 0x2016,
        DepthBitsExt = 0x2022,
        TypeRgbaExt = 0x202b,
        GenericAccelerationExt = 0x2026,
        AccumAlphaBitsExt = 0x2021,
        AccumGreenBitsExt = 0x201f,
        TransparentValueExt = 0x200b,
        AccumBlueBitsExt = 0x2020,
        ShareDepthExt = 0x200c,
        ShareAccumExt = 0x200e,
        SwapExchangeExt = 0x2028,
        AccumBitsExt = 0x201d,
        NumberUnderlaysExt = 0x2009,
        StencilBitsExt = 0x2023,
        DoubleBufferExt = 0x2011,
        NeedPaletteExt = 0x2004,
        ColorBitsExt = 0x2014,
        SwapUndefinedExt = 0x202a,
        NeedSystemPaletteExt = 0x2005,
        NumberOverlaysExt = 0x2008,
        AuxBuffersExt = 0x2024,
        NumberPixelFormatsExt = 0x2000,
        ShareStencilExt = 0x200d
    }

    public enum WGL_ARB_pixel_format
    {
        ShareStencilArb = 0x200d,
        AccumBitsArb = 0x201d,
        NumberUnderlaysArb = 0x2009,
        StereoArb = 0x2012,
        MaxPbufferHeightArb = 0x2030,
        TypeRgbaArb = 0x202b,
        SupportGdiArb = 0x200f,
        NeedSystemPaletteArb = 0x2005,
        AlphaBitsArb = 0x201b,
        ShareDepthArb = 0x200c,
        SupportOpenglArb = 0x2010,
        ColorBitsArb = 0x2014,
        AccumRedBitsArb = 0x201e,
        MaxPbufferWidthArb = 0x202f,
        NumberOverlaysArb = 0x2008,
        MaxPbufferPixelsArb = 0x202e,
        NeedPaletteArb = 0x2004,
        RedShiftArb = 0x2016,
        AccelerationArb = 0x2003,
        GreenBitsArb = 0x2017,
        TransparentGreenValueArb = 0x2038,
        PixelTypeArb = 0x2013,
        AuxBuffersArb = 0x2024,
        DrawToWindowArb = 0x2001,
        RedBitsArb = 0x2015,
        NumberPixelFormatsArb = 0x2000,
        GenericAccelerationArb = 0x2026,
        BlueBitsArb = 0x2019,
        PbufferLargestArb = 0x2033,
        AccumAlphaBitsArb = 0x2021,
        TransparentArb = 0x200a,
        FullAccelerationArb = 0x2027,
        ShareAccumArb = 0x200e,
        SwapExchangeArb = 0x2028,
        SwapUndefinedArb = 0x202a,
        TransparentAlphaValueArb = 0x203a,
        PbufferHeightArb = 0x2035,
        TransparentBlueValueArb = 0x2039,
        SwapMethodArb = 0x2007,
        StencilBitsArb = 0x2023,
        DepthBitsArb = 0x2022,
        GreenShiftArb = 0x2018,
        TransparentRedValueArb = 0x2037,
        DoubleBufferArb = 0x2011,
        NoAccelerationArb = 0x2025,
        TypeColorindexArb = 0x202c,
        SwapLayerBuffersArb = 0x2006,
        AccumBlueBitsArb = 0x2020,
        DrawToPbufferArb = 0x202d,
        AccumGreenBitsArb = 0x201f,
        PbufferWidthArb = 0x2034,
        TransparentIndexValueArb = 0x203b,
        AlphaShiftArb = 0x201c,
        DrawToBitmapArb = 0x2002,
        BlueShiftArb = 0x201a,
        SwapCopyArb = 0x2029
    }

    public enum WGL_EXT_pbuffer
    {
        DrawToPbufferExt = 0x202d,
        PbufferLargestExt = 0x2033,
        OptimalPbufferWidthExt = 0x2031,
        MaxPbufferPixelsExt = 0x202e,
        MaxPbufferHeightExt = 0x2030,
        PbufferWidthExt = 0x2034,
        MaxPbufferWidthExt = 0x202f,
        OptimalPbufferHeightExt = 0x2032,
        PbufferHeightExt = 0x2035
    }

    public enum WGL_ARB_pbuffer
    {
        PbufferWidthArb = 0x2034,
        TransparentGreenValueArb = 0x2038,
        PbufferHeightArb = 0x2035,
        PbufferLostArb = 0x2036,
        DrawToPbufferArb = 0x202d,
        TransparentIndexValueArb = 0x203b,
        TransparentRedValueArb = 0x2037,
        MaxPbufferPixelsArb = 0x202e,
        TransparentAlphaValueArb = 0x203a,
        MaxPbufferWidthArb = 0x202f,
        MaxPbufferHeightArb = 0x2030,
        TransparentBlueValueArb = 0x2039,
        PbufferLargestArb = 0x2033
    }

    public enum WGL_EXT_depth_float
    {
        DepthFloatExt = 0x2040
    }

    public enum WGL_EXT_multisample
    {
        SampleBuffersExt = 0x2041,
        SamplesExt = 0x2042
    }

    public enum WGL_ARB_multisample
    {
        SampleBuffersArb = 0x2041,
        SamplesArb = 0x2042
    }

    public enum WGL_EXT_make_current_read
    {
        ErrorInvalidPixelTypeExt = 0x2043
    }

    public enum WGL_ARB_make_current_read
    {
        ErrorInvalidPixelTypeArb = 0x2043,
        ErrorIncompatibleDeviceContextsArb = 0x2054
    }

    public enum WGL_I3D_genlock
    {
        GenlockSourceMultiviewI3d = 0x2044,
        GenlockSourceEdgeBothI3d = 0x204c,
        GenlockSourceEdgeRisingI3d = 0x204b,
        GenlockSourceDigitalSyncI3d = 0x2048,
        GenlockSourceExtenalFieldI3d = 0x2046,
        GenlockSourceDigitalFieldI3d = 0x2049,
        GenlockSourceExtenalSyncI3d = 0x2045,
        GenlockSourceEdgeFallingI3d = 0x204a,
        GenlockSourceExtenalTtlI3d = 0x2047
    }

    public enum WGL_I3D_gamma
    {
        GammaExcludeDesktopI3d = 0x204f,
        GammaTableSizeI3d = 0x204e
    }

    public enum WGL_I3D_digital_video_control
    {
        DigitalVideoCursorAlphaFramebufferI3d = 0x2050,
        DigitalVideoGammaCorrectedI3d = 0x2053,
        DigitalVideoCursorAlphaValueI3d = 0x2051,
        DigitalVideoCursorIncludedI3d = 0x2052
    }

    public enum WGL_3DFX_multisample
    {
        SampleBuffers3dfx = 0x2060,
        Samples3dfx = 0x2061
    }

    public enum WGL_ARB_render_texture
    {
        TextureCubeMapPositiveXArb = 0x207d,
        TextureCubeMapPositiveYArb = 0x207f,
        Aux0Arb = 0x2087,
        Texture1dArb = 0x2079,
        Aux6Arb = 0x208d,
        TextureCubeMapArb = 0x2078,
        TextureFormatArb = 0x2072,
        BackRightArb = 0x2086,
        BindToTextureRgbArb = 0x2070,
        MipmapLevelArb = 0x207b,
        CubeMapFaceArb = 0x207c,
        TextureCubeMapNegativeXArb = 0x207e,
        Aux7Arb = 0x208e,
        Aux8Arb = 0x208f,
        MipmapTextureArb = 0x2074,
        NoTextureArb = 0x2077,
        Aux3Arb = 0x208a,
        Texture2DArb = 0x207a,
        Aux1Arb = 0x2088,
        TextureCubeMapPositiveZArb = 0x2081,
        BindToTextureRgbaArb = 0x2071,
        TextureCubeMapNegativeYArb = 0x2080,
        TextureRgbaArb = 0x2076,
        FrontRightArb = 0x2084,
        Aux5Arb = 0x208c,
        Aux4Arb = 0x208b,
        TextureTargetArb = 0x2073,
        FrontLeftArb = 0x2083,
        Aux9Arb = 0x2090,
        TextureRgbArb = 0x2075,
        BackLeftArb = 0x2085,
        TextureCubeMapNegativeZArb = 0x2082,
        Aux2Arb = 0x2089
    }

    public enum WGL_NV_render_texture_rectangle
    {
        BindToTextureRectangleRgbNv = 0x20a0,
        BindToTextureRectangleRgbaNv = 0x20a1,
        TextureRectangleNv = 0x20a2
    }

    public enum WGL_NV_render_depth_texture
    {
        DepthTextureFormatNv = 0x20a5,
        TextureDepthComponentNv = 0x20a6,
        BindToTextureDepthNv = 0x20a3,
        DepthComponentNv = 0x20a7,
        BindToTextureRectangleDepthNv = 0x20a4
    }

    public enum WGL_NV_float_buffer
    {
        BindToTextureRectangleFloatRNv = 0x20b1,
        TextureFloatRNv = 0x20b5,
        TextureFloatRgbNv = 0x20b7,
        TextureFloatRgNv = 0x20b6,
        TextureFloatRgbaNv = 0x20b8,
        BindToTextureRectangleFloatRgbaNv = 0x20b4,
        FloatComponentsNv = 0x20b0,
        BindToTextureRectangleFloatRgNv = 0x20b2,
        BindToTextureRectangleFloatRgbNv = 0x20b3
    }

    public enum WGL_ARB_pixel_format_float
    {
        TypeRgbaFloatArb = 0x21a0
    }

    public enum WGL_ATI_pixel_format_float
    {
        TypeRgbaFloatAti = 0x21a0
    }

    public enum WGL_font_type
    {
        FontLines = 0
    }

    public enum All
    {
        SwapCopyExt = 0x2029,
        BackColorBufferBitArb = 0x00000002,
        FullAccelerationArb = 0x2027,
        AccelerationExt = 0x2003,
        GenlockSourceMultiviewI3d = 0x2044,
        Aux3Arb = 0x208a,
        TextureCubeMapNegativeYArb = 0x2080,
        DoubleBufferArb = 0x2011,
        SwapUndefinedExt = 0x202a,
        SupportGdiArb = 0x200f,
        Aux2Arb = 0x2089,
        TextureCubeMapArb = 0x2078,
        SwapLayerBuffersExt = 0x2006,
        SwapCopyArb = 0x2029,
        ErrorIncompatibleDeviceContextsArb = 0x2054,
        TypeColorindexArb = 0x202c,
        DigitalVideoCursorIncludedI3d = 0x2052,
        NeedPaletteExt = 0x2004,
        RedBitsArb = 0x2015,
        TextureCubeMapNegativeXArb = 0x207e,
        SampleBuffersExt = 0x2041,
        GenericAccelerationExt = 0x2026,
        BindToTextureRectangleRgbaNv = 0x20a1,
        NoTextureArb = 0x2077,
        FrontColorBufferBitArb = 0x00000001,
        TransparentValueExt = 0x200b,
        AlphaBitsArb = 0x201b,
        RedBitsExt = 0x2015,
        PbufferHeightArb = 0x2035,
        BindToTextureRectangleFloatRgbaNv = 0x20b4,
        SampleBuffersArb = 0x2041,
        MipmapLevelArb = 0x207b,
        NeedSystemPaletteExt = 0x2005,
        Aux4Arb = 0x208b,
        TextureFormatArb = 0x2072,
        AccumBitsExt = 0x201d,
        AccumBlueBitsExt = 0x2020,
        BackLeftArb = 0x2085,
        AlphaBitsExt = 0x201b,
        StencilBitsArb = 0x2023,
        DrawToPbufferExt = 0x202d,
        FullAccelerationExt = 0x2027,
        ColorBitsExt = 0x2014,
        BindToTextureRectangleFloatRgNv = 0x20b2,
        DepthBufferBitArb = 0x00000004,
        BindToTextureRgbaArb = 0x2071,
        AccumGreenBitsArb = 0x201f,
        AccumBitsArb = 0x201d,
        TypeRgbaFloatArb = 0x21a0,
        NeedPaletteArb = 0x2004,
        ShareAccumArb = 0x200e,
        TransparentArb = 0x200a,
        ShareStencilArb = 0x200d,
        Aux5Arb = 0x208c,
        ImageBufferLockI3d = 0x00000002,
        TextureFloatRNv = 0x20b5,
        DepthComponentNv = 0x20a7,
        FloatComponentsNv = 0x20b0,
        TransparentGreenValueArb = 0x2038,
        GenlockSourceExtenalTtlI3d = 0x2047,
        NeedSystemPaletteArb = 0x2005,
        BlueBitsExt = 0x2019,
        GreenShiftExt = 0x2018,
        OptimalPbufferWidthExt = 0x2031,
        AuxBuffersExt = 0x2024,
        TypeRgbaFloatAti = 0x21a0,
        FrontRightArb = 0x2084,
        DepthBitsExt = 0x2022,
        GammaTableSizeI3d = 0x204e,
        AccumAlphaBitsArb = 0x2021,
        Aux0Arb = 0x2087,
        TransparentIndexValueArb = 0x203b,
        AccumGreenBitsExt = 0x201f,
        TransparentBlueValueArb = 0x2039,
        NoAccelerationArb = 0x2025,
        MaxPbufferPixelsArb = 0x202e,
        GammaExcludeDesktopI3d = 0x204f,
        MaxPbufferPixelsExt = 0x202e,
        AccumBlueBitsArb = 0x2020,
        SwapUndefinedArb = 0x202a,
        ShareDepthExt = 0x200c,
        GenlockSourceEdgeBothI3d = 0x204c,
        Samples3dfx = 0x2061,
        DoubleBufferExt = 0x2011,
        BindToTextureRectangleFloatRgbNv = 0x20b3,
        SwapMethodExt = 0x2007,
        ErrorInvalidPixelTypeArb = 0x2043,
        GreenShiftArb = 0x2018,
        TextureFloatRgbaNv = 0x20b8,
        Aux1Arb = 0x2088,
        GreenBitsArb = 0x2017,
        NumberPixelFormatsExt = 0x2000,
        NumberOverlaysExt = 0x2008,
        PixelTypeArb = 0x2013,
        SwapLayerBuffersArb = 0x2006,
        DrawToBitmapArb = 0x2002,
        NumberPixelFormatsArb = 0x2000,
        PbufferLostArb = 0x2036,
        Aux9Arb = 0x2090,
        TextureCubeMapPositiveZArb = 0x2081,
        MaxPbufferHeightArb = 0x2030,
        TransparentExt = 0x200a,
        PbufferLargestArb = 0x2033,
        SwapMethodArb = 0x2007,
        TextureRgbaArb = 0x2076,
        PbufferWidthExt = 0x2034,
        OptimalPbufferHeightExt = 0x2032,
        StencilBitsExt = 0x2023,
        ShareStencilExt = 0x200d,
        DepthFloatExt = 0x2040,
        BindToTextureRgbArb = 0x2070,
        BindToTextureRectangleRgbNv = 0x20a0,
        GenlockSourceDigitalSyncI3d = 0x2048,
        AccumAlphaBitsExt = 0x2021,
        GenlockSourceExtenalSyncI3d = 0x2045,
        RedShiftExt = 0x2016,
        GenlockSourceDigitalFieldI3d = 0x2049,
        FrontLeftArb = 0x2083,
        BlueShiftArb = 0x201a,
        PbufferWidthArb = 0x2034,
        CubeMapFaceArb = 0x207c,
        StencilBufferBitArb = 0x00000008,
        NumberOverlaysArb = 0x2008,
        SwapExchangeExt = 0x2028,
        BackRightArb = 0x2086,
        DepthTextureFormatNv = 0x20a5,
        TextureFloatRgNv = 0x20b6,
        Texture1dArb = 0x2079,
        DepthBitsArb = 0x2022,
        BindToTextureDepthNv = 0x20a3,
        DrawToWindowArb = 0x2001,
        TypeRgbaExt = 0x202b,
        DigitalVideoCursorAlphaValueI3d = 0x2051,
        ErrorInvalidPixelTypeExt = 0x2043,
        AccumRedBitsExt = 0x201e,
        GreenBitsExt = 0x2017,
        TypeRgbaArb = 0x202b,
        DigitalVideoCursorAlphaFramebufferI3d = 0x2050,
        AuxBuffersArb = 0x2024,
        AccumRedBitsArb = 0x201e,
        TextureFloatRgbNv = 0x20b7,
        TypeColorindexExt = 0x202c,
        TransparentAlphaValueArb = 0x203a,
        BlueShiftExt = 0x201a,
        RedShiftArb = 0x2016,
        PbufferHeightExt = 0x2035,
        GenlockSourceEdgeRisingI3d = 0x204b,
        Texture2DArb = 0x207a,
        NumberUnderlaysArb = 0x2009,
        NumberUnderlaysExt = 0x2009,
        DrawToBitmapExt = 0x2002,
        ShareDepthArb = 0x200c,
        TextureDepthComponentNv = 0x20a6,
        NoAccelerationExt = 0x2025,
        PixelTypeExt = 0x2013,
        SupportOpenglArb = 0x2010,
        TextureCubeMapPositiveYArb = 0x207f,
        DrawToWindowExt = 0x2001,
        PbufferLargestExt = 0x2033,
        DrawToPbufferArb = 0x202d,
        SupportOpenglExt = 0x2010,
        SampleBuffers3dfx = 0x2060,
        GenlockSourceExtenalFieldI3d = 0x2046,
        MaxPbufferHeightExt = 0x2030,
        SupportGdiExt = 0x200f,
        Aux7Arb = 0x208e,
        DigitalVideoGammaCorrectedI3d = 0x2053,
        ColorBitsArb = 0x2014,
        Aux6Arb = 0x208d,
        ShareAccumExt = 0x200e,
        StereoArb = 0x2012,
        TextureRgbArb = 0x2075,
        AccelerationArb = 0x2003,
        TextureCubeMapPositiveXArb = 0x207d,
        TransparentRedValueArb = 0x2037,
        BlueBitsArb = 0x2019,
        SwapExchangeArb = 0x2028,
        SamplesExt = 0x2042,
        AlphaShiftExt = 0x201c,
        SamplesArb = 0x2042,
        TextureTargetArb = 0x2073,
        BindToTextureRectangleDepthNv = 0x20a4,
        AlphaShiftArb = 0x201c,
        Aux8Arb = 0x208f,
        MaxPbufferWidthExt = 0x202f,
        GenlockSourceEdgeFallingI3d = 0x204a,
        StereoExt = 0x2012,
        MaxPbufferWidthArb = 0x202f,
        TextureRectangleNv = 0x20a2,
        ImageBufferMinAccessI3d = 0x00000001,
        TextureCubeMapNegativeZArb = 0x2082,
        MipmapTextureArb = 0x2074,
        GenericAccelerationArb = 0x2026,
        BindToTextureRectangleFloatRNv = 0x20b1,
        FontLines = 0
    }

    public enum WGL_ARB_extensions_string
    {
    }

    public enum WGL_I3D_image_buffer
    {
        ImageBufferMinAccessI3d = 0x00000001,
        ImageBufferLockI3d = 0x00000002
    }

    public enum WGL_I3D_swap_frame_lock
    {
    }
}