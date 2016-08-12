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
        BackColorBufferBitArb = ((int)0x00000002),
        StencilBufferBitArb = ((int)0x00000008),
        FrontColorBufferBitArb = ((int)0x00000001),
        DepthBufferBitArb = ((int)0x00000004),
    }

    public enum WGL_EXT_pixel_format
    {
        SupportGdiExt = ((int)0x200f),
        TypeColorindexExt = ((int)0x202c),
        AccelerationExt = ((int)0x2003),
        GreenBitsExt = ((int)0x2017),
        DrawToWindowExt = ((int)0x2001),
        SwapCopyExt = ((int)0x2029),
        DrawToBitmapExt = ((int)0x2002),
        TransparentExt = ((int)0x200a),
        SwapMethodExt = ((int)0x2007),
        SwapLayerBuffersExt = ((int)0x2006),
        PixelTypeExt = ((int)0x2013),
        AlphaShiftExt = ((int)0x201c),
        AccumRedBitsExt = ((int)0x201e),
        FullAccelerationExt = ((int)0x2027),
        SupportOpenglExt = ((int)0x2010),
        BlueShiftExt = ((int)0x201a),
        RedBitsExt = ((int)0x2015),
        NoAccelerationExt = ((int)0x2025),
        StereoExt = ((int)0x2012),
        GreenShiftExt = ((int)0x2018),
        BlueBitsExt = ((int)0x2019),
        AlphaBitsExt = ((int)0x201b),
        RedShiftExt = ((int)0x2016),
        DepthBitsExt = ((int)0x2022),
        TypeRgbaExt = ((int)0x202b),
        GenericAccelerationExt = ((int)0x2026),
        AccumAlphaBitsExt = ((int)0x2021),
        AccumGreenBitsExt = ((int)0x201f),
        TransparentValueExt = ((int)0x200b),
        AccumBlueBitsExt = ((int)0x2020),
        ShareDepthExt = ((int)0x200c),
        ShareAccumExt = ((int)0x200e),
        SwapExchangeExt = ((int)0x2028),
        AccumBitsExt = ((int)0x201d),
        NumberUnderlaysExt = ((int)0x2009),
        StencilBitsExt = ((int)0x2023),
        DoubleBufferExt = ((int)0x2011),
        NeedPaletteExt = ((int)0x2004),
        ColorBitsExt = ((int)0x2014),
        SwapUndefinedExt = ((int)0x202a),
        NeedSystemPaletteExt = ((int)0x2005),
        NumberOverlaysExt = ((int)0x2008),
        AuxBuffersExt = ((int)0x2024),
        NumberPixelFormatsExt = ((int)0x2000),
        ShareStencilExt = ((int)0x200d),
    }

    public enum WGL_ARB_pixel_format
    {
        ShareStencilArb = ((int)0x200d),
        AccumBitsArb = ((int)0x201d),
        NumberUnderlaysArb = ((int)0x2009),
        StereoArb = ((int)0x2012),
        MaxPbufferHeightArb = ((int)0x2030),
        TypeRgbaArb = ((int)0x202b),
        SupportGdiArb = ((int)0x200f),
        NeedSystemPaletteArb = ((int)0x2005),
        AlphaBitsArb = ((int)0x201b),
        ShareDepthArb = ((int)0x200c),
        SupportOpenglArb = ((int)0x2010),
        ColorBitsArb = ((int)0x2014),
        AccumRedBitsArb = ((int)0x201e),
        MaxPbufferWidthArb = ((int)0x202f),
        NumberOverlaysArb = ((int)0x2008),
        MaxPbufferPixelsArb = ((int)0x202e),
        NeedPaletteArb = ((int)0x2004),
        RedShiftArb = ((int)0x2016),
        AccelerationArb = ((int)0x2003),
        GreenBitsArb = ((int)0x2017),
        TransparentGreenValueArb = ((int)0x2038),
        PixelTypeArb = ((int)0x2013),
        AuxBuffersArb = ((int)0x2024),
        DrawToWindowArb = ((int)0x2001),
        RedBitsArb = ((int)0x2015),
        NumberPixelFormatsArb = ((int)0x2000),
        GenericAccelerationArb = ((int)0x2026),
        BlueBitsArb = ((int)0x2019),
        PbufferLargestArb = ((int)0x2033),
        AccumAlphaBitsArb = ((int)0x2021),
        TransparentArb = ((int)0x200a),
        FullAccelerationArb = ((int)0x2027),
        ShareAccumArb = ((int)0x200e),
        SwapExchangeArb = ((int)0x2028),
        SwapUndefinedArb = ((int)0x202a),
        TransparentAlphaValueArb = ((int)0x203a),
        PbufferHeightArb = ((int)0x2035),
        TransparentBlueValueArb = ((int)0x2039),
        SwapMethodArb = ((int)0x2007),
        StencilBitsArb = ((int)0x2023),
        DepthBitsArb = ((int)0x2022),
        GreenShiftArb = ((int)0x2018),
        TransparentRedValueArb = ((int)0x2037),
        DoubleBufferArb = ((int)0x2011),
        NoAccelerationArb = ((int)0x2025),
        TypeColorindexArb = ((int)0x202c),
        SwapLayerBuffersArb = ((int)0x2006),
        AccumBlueBitsArb = ((int)0x2020),
        DrawToPbufferArb = ((int)0x202d),
        AccumGreenBitsArb = ((int)0x201f),
        PbufferWidthArb = ((int)0x2034),
        TransparentIndexValueArb = ((int)0x203b),
        AlphaShiftArb = ((int)0x201c),
        DrawToBitmapArb = ((int)0x2002),
        BlueShiftArb = ((int)0x201a),
        SwapCopyArb = ((int)0x2029),
    }

    public enum WGL_EXT_pbuffer
    {
        DrawToPbufferExt = ((int)0x202d),
        PbufferLargestExt = ((int)0x2033),
        OptimalPbufferWidthExt = ((int)0x2031),
        MaxPbufferPixelsExt = ((int)0x202e),
        MaxPbufferHeightExt = ((int)0x2030),
        PbufferWidthExt = ((int)0x2034),
        MaxPbufferWidthExt = ((int)0x202f),
        OptimalPbufferHeightExt = ((int)0x2032),
        PbufferHeightExt = ((int)0x2035),
    }

    public enum WGL_ARB_pbuffer
    {
        PbufferWidthArb = ((int)0x2034),
        TransparentGreenValueArb = ((int)0x2038),
        PbufferHeightArb = ((int)0x2035),
        PbufferLostArb = ((int)0x2036),
        DrawToPbufferArb = ((int)0x202d),
        TransparentIndexValueArb = ((int)0x203b),
        TransparentRedValueArb = ((int)0x2037),
        MaxPbufferPixelsArb = ((int)0x202e),
        TransparentAlphaValueArb = ((int)0x203a),
        MaxPbufferWidthArb = ((int)0x202f),
        MaxPbufferHeightArb = ((int)0x2030),
        TransparentBlueValueArb = ((int)0x2039),
        PbufferLargestArb = ((int)0x2033),
    }

    public enum WGL_EXT_depth_float
    {
        DepthFloatExt = ((int)0x2040),
    }

    public enum WGL_EXT_multisample
    {
        SampleBuffersExt = ((int)0x2041),
        SamplesExt = ((int)0x2042),
    }

    public enum WGL_ARB_multisample
    {
        SampleBuffersArb = ((int)0x2041),
        SamplesArb = ((int)0x2042),
    }

    public enum WGL_EXT_make_current_read
    {
        ErrorInvalidPixelTypeExt = ((int)0x2043),
    }

    public enum WGL_ARB_make_current_read
    {
        ErrorInvalidPixelTypeArb = ((int)0x2043),
        ErrorIncompatibleDeviceContextsArb = ((int)0x2054),
    }

    public enum WGL_I3D_genlock
    {
        GenlockSourceMultiviewI3d = ((int)0x2044),
        GenlockSourceEdgeBothI3d = ((int)0x204c),
        GenlockSourceEdgeRisingI3d = ((int)0x204b),
        GenlockSourceDigitalSyncI3d = ((int)0x2048),
        GenlockSourceExtenalFieldI3d = ((int)0x2046),
        GenlockSourceDigitalFieldI3d = ((int)0x2049),
        GenlockSourceExtenalSyncI3d = ((int)0x2045),
        GenlockSourceEdgeFallingI3d = ((int)0x204a),
        GenlockSourceExtenalTtlI3d = ((int)0x2047),
    }

    public enum WGL_I3D_gamma
    {
        GammaExcludeDesktopI3d = ((int)0x204f),
        GammaTableSizeI3d = ((int)0x204e),
    }

    public enum WGL_I3D_digital_video_control
    {
        DigitalVideoCursorAlphaFramebufferI3d = ((int)0x2050),
        DigitalVideoGammaCorrectedI3d = ((int)0x2053),
        DigitalVideoCursorAlphaValueI3d = ((int)0x2051),
        DigitalVideoCursorIncludedI3d = ((int)0x2052),
    }

    public enum WGL_3DFX_multisample
    {
        SampleBuffers3dfx = ((int)0x2060),
        Samples3dfx = ((int)0x2061),
    }

    public enum WGL_ARB_render_texture
    {
        TextureCubeMapPositiveXArb = ((int)0x207d),
        TextureCubeMapPositiveYArb = ((int)0x207f),
        Aux0Arb = ((int)0x2087),
        Texture1dArb = ((int)0x2079),
        Aux6Arb = ((int)0x208d),
        TextureCubeMapArb = ((int)0x2078),
        TextureFormatArb = ((int)0x2072),
        BackRightArb = ((int)0x2086),
        BindToTextureRgbArb = ((int)0x2070),
        MipmapLevelArb = ((int)0x207b),
        CubeMapFaceArb = ((int)0x207c),
        TextureCubeMapNegativeXArb = ((int)0x207e),
        Aux7Arb = ((int)0x208e),
        Aux8Arb = ((int)0x208f),
        MipmapTextureArb = ((int)0x2074),
        NoTextureArb = ((int)0x2077),
        Aux3Arb = ((int)0x208a),
        Texture2DArb = ((int)0x207a),
        Aux1Arb = ((int)0x2088),
        TextureCubeMapPositiveZArb = ((int)0x2081),
        BindToTextureRgbaArb = ((int)0x2071),
        TextureCubeMapNegativeYArb = ((int)0x2080),
        TextureRgbaArb = ((int)0x2076),
        FrontRightArb = ((int)0x2084),
        Aux5Arb = ((int)0x208c),
        Aux4Arb = ((int)0x208b),
        TextureTargetArb = ((int)0x2073),
        FrontLeftArb = ((int)0x2083),
        Aux9Arb = ((int)0x2090),
        TextureRgbArb = ((int)0x2075),
        BackLeftArb = ((int)0x2085),
        TextureCubeMapNegativeZArb = ((int)0x2082),
        Aux2Arb = ((int)0x2089),
    }

    public enum WGL_NV_render_texture_rectangle
    {
        BindToTextureRectangleRgbNv = ((int)0x20a0),
        BindToTextureRectangleRgbaNv = ((int)0x20a1),
        TextureRectangleNv = ((int)0x20a2),
    }

    public enum WGL_NV_render_depth_texture
    {
        DepthTextureFormatNv = ((int)0x20a5),
        TextureDepthComponentNv = ((int)0x20a6),
        BindToTextureDepthNv = ((int)0x20a3),
        DepthComponentNv = ((int)0x20a7),
        BindToTextureRectangleDepthNv = ((int)0x20a4),
    }

    public enum WGL_NV_float_buffer
    {
        BindToTextureRectangleFloatRNv = ((int)0x20b1),
        TextureFloatRNv = ((int)0x20b5),
        TextureFloatRgbNv = ((int)0x20b7),
        TextureFloatRgNv = ((int)0x20b6),
        TextureFloatRgbaNv = ((int)0x20b8),
        BindToTextureRectangleFloatRgbaNv = ((int)0x20b4),
        FloatComponentsNv = ((int)0x20b0),
        BindToTextureRectangleFloatRgNv = ((int)0x20b2),
        BindToTextureRectangleFloatRgbNv = ((int)0x20b3),
    }

    public enum WGL_ARB_pixel_format_float
    {
        TypeRgbaFloatArb = ((int)0x21a0),
    }

    public enum WGL_ATI_pixel_format_float
    {
        TypeRgbaFloatAti = ((int)0x21a0),
    }

    public enum WGL_font_type
    {
        FontLines = ((int)0),
    }

    public enum All
    {
        SwapCopyExt = ((int)0x2029),
        BackColorBufferBitArb = ((int)0x00000002),
        FullAccelerationArb = ((int)0x2027),
        AccelerationExt = ((int)0x2003),
        GenlockSourceMultiviewI3d = ((int)0x2044),
        Aux3Arb = ((int)0x208a),
        TextureCubeMapNegativeYArb = ((int)0x2080),
        DoubleBufferArb = ((int)0x2011),
        SwapUndefinedExt = ((int)0x202a),
        SupportGdiArb = ((int)0x200f),
        Aux2Arb = ((int)0x2089),
        TextureCubeMapArb = ((int)0x2078),
        SwapLayerBuffersExt = ((int)0x2006),
        SwapCopyArb = ((int)0x2029),
        ErrorIncompatibleDeviceContextsArb = ((int)0x2054),
        TypeColorindexArb = ((int)0x202c),
        DigitalVideoCursorIncludedI3d = ((int)0x2052),
        NeedPaletteExt = ((int)0x2004),
        RedBitsArb = ((int)0x2015),
        TextureCubeMapNegativeXArb = ((int)0x207e),
        SampleBuffersExt = ((int)0x2041),
        GenericAccelerationExt = ((int)0x2026),
        BindToTextureRectangleRgbaNv = ((int)0x20a1),
        NoTextureArb = ((int)0x2077),
        FrontColorBufferBitArb = ((int)0x00000001),
        TransparentValueExt = ((int)0x200b),
        AlphaBitsArb = ((int)0x201b),
        RedBitsExt = ((int)0x2015),
        PbufferHeightArb = ((int)0x2035),
        BindToTextureRectangleFloatRgbaNv = ((int)0x20b4),
        SampleBuffersArb = ((int)0x2041),
        MipmapLevelArb = ((int)0x207b),
        NeedSystemPaletteExt = ((int)0x2005),
        Aux4Arb = ((int)0x208b),
        TextureFormatArb = ((int)0x2072),
        AccumBitsExt = ((int)0x201d),
        AccumBlueBitsExt = ((int)0x2020),
        BackLeftArb = ((int)0x2085),
        AlphaBitsExt = ((int)0x201b),
        StencilBitsArb = ((int)0x2023),
        DrawToPbufferExt = ((int)0x202d),
        FullAccelerationExt = ((int)0x2027),
        ColorBitsExt = ((int)0x2014),
        BindToTextureRectangleFloatRgNv = ((int)0x20b2),
        DepthBufferBitArb = ((int)0x00000004),
        BindToTextureRgbaArb = ((int)0x2071),
        AccumGreenBitsArb = ((int)0x201f),
        AccumBitsArb = ((int)0x201d),
        TypeRgbaFloatArb = ((int)0x21a0),
        NeedPaletteArb = ((int)0x2004),
        ShareAccumArb = ((int)0x200e),
        TransparentArb = ((int)0x200a),
        ShareStencilArb = ((int)0x200d),
        Aux5Arb = ((int)0x208c),
        ImageBufferLockI3d = ((int)0x00000002),
        TextureFloatRNv = ((int)0x20b5),
        DepthComponentNv = ((int)0x20a7),
        FloatComponentsNv = ((int)0x20b0),
        TransparentGreenValueArb = ((int)0x2038),
        GenlockSourceExtenalTtlI3d = ((int)0x2047),
        NeedSystemPaletteArb = ((int)0x2005),
        BlueBitsExt = ((int)0x2019),
        GreenShiftExt = ((int)0x2018),
        OptimalPbufferWidthExt = ((int)0x2031),
        AuxBuffersExt = ((int)0x2024),
        TypeRgbaFloatAti = ((int)0x21a0),
        FrontRightArb = ((int)0x2084),
        DepthBitsExt = ((int)0x2022),
        GammaTableSizeI3d = ((int)0x204e),
        AccumAlphaBitsArb = ((int)0x2021),
        Aux0Arb = ((int)0x2087),
        TransparentIndexValueArb = ((int)0x203b),
        AccumGreenBitsExt = ((int)0x201f),
        TransparentBlueValueArb = ((int)0x2039),
        NoAccelerationArb = ((int)0x2025),
        MaxPbufferPixelsArb = ((int)0x202e),
        GammaExcludeDesktopI3d = ((int)0x204f),
        MaxPbufferPixelsExt = ((int)0x202e),
        AccumBlueBitsArb = ((int)0x2020),
        SwapUndefinedArb = ((int)0x202a),
        ShareDepthExt = ((int)0x200c),
        GenlockSourceEdgeBothI3d = ((int)0x204c),
        Samples3dfx = ((int)0x2061),
        DoubleBufferExt = ((int)0x2011),
        BindToTextureRectangleFloatRgbNv = ((int)0x20b3),
        SwapMethodExt = ((int)0x2007),
        ErrorInvalidPixelTypeArb = ((int)0x2043),
        GreenShiftArb = ((int)0x2018),
        TextureFloatRgbaNv = ((int)0x20b8),
        Aux1Arb = ((int)0x2088),
        GreenBitsArb = ((int)0x2017),
        NumberPixelFormatsExt = ((int)0x2000),
        NumberOverlaysExt = ((int)0x2008),
        PixelTypeArb = ((int)0x2013),
        SwapLayerBuffersArb = ((int)0x2006),
        DrawToBitmapArb = ((int)0x2002),
        NumberPixelFormatsArb = ((int)0x2000),
        PbufferLostArb = ((int)0x2036),
        Aux9Arb = ((int)0x2090),
        TextureCubeMapPositiveZArb = ((int)0x2081),
        MaxPbufferHeightArb = ((int)0x2030),
        TransparentExt = ((int)0x200a),
        PbufferLargestArb = ((int)0x2033),
        SwapMethodArb = ((int)0x2007),
        TextureRgbaArb = ((int)0x2076),
        PbufferWidthExt = ((int)0x2034),
        OptimalPbufferHeightExt = ((int)0x2032),
        StencilBitsExt = ((int)0x2023),
        ShareStencilExt = ((int)0x200d),
        DepthFloatExt = ((int)0x2040),
        BindToTextureRgbArb = ((int)0x2070),
        BindToTextureRectangleRgbNv = ((int)0x20a0),
        GenlockSourceDigitalSyncI3d = ((int)0x2048),
        AccumAlphaBitsExt = ((int)0x2021),
        GenlockSourceExtenalSyncI3d = ((int)0x2045),
        RedShiftExt = ((int)0x2016),
        GenlockSourceDigitalFieldI3d = ((int)0x2049),
        FrontLeftArb = ((int)0x2083),
        BlueShiftArb = ((int)0x201a),
        PbufferWidthArb = ((int)0x2034),
        CubeMapFaceArb = ((int)0x207c),
        StencilBufferBitArb = ((int)0x00000008),
        NumberOverlaysArb = ((int)0x2008),
        SwapExchangeExt = ((int)0x2028),
        BackRightArb = ((int)0x2086),
        DepthTextureFormatNv = ((int)0x20a5),
        TextureFloatRgNv = ((int)0x20b6),
        Texture1dArb = ((int)0x2079),
        DepthBitsArb = ((int)0x2022),
        BindToTextureDepthNv = ((int)0x20a3),
        DrawToWindowArb = ((int)0x2001),
        TypeRgbaExt = ((int)0x202b),
        DigitalVideoCursorAlphaValueI3d = ((int)0x2051),
        ErrorInvalidPixelTypeExt = ((int)0x2043),
        AccumRedBitsExt = ((int)0x201e),
        GreenBitsExt = ((int)0x2017),
        TypeRgbaArb = ((int)0x202b),
        DigitalVideoCursorAlphaFramebufferI3d = ((int)0x2050),
        AuxBuffersArb = ((int)0x2024),
        AccumRedBitsArb = ((int)0x201e),
        TextureFloatRgbNv = ((int)0x20b7),
        TypeColorindexExt = ((int)0x202c),
        TransparentAlphaValueArb = ((int)0x203a),
        BlueShiftExt = ((int)0x201a),
        RedShiftArb = ((int)0x2016),
        PbufferHeightExt = ((int)0x2035),
        GenlockSourceEdgeRisingI3d = ((int)0x204b),
        Texture2DArb = ((int)0x207a),
        NumberUnderlaysArb = ((int)0x2009),
        NumberUnderlaysExt = ((int)0x2009),
        DrawToBitmapExt = ((int)0x2002),
        ShareDepthArb = ((int)0x200c),
        TextureDepthComponentNv = ((int)0x20a6),
        NoAccelerationExt = ((int)0x2025),
        PixelTypeExt = ((int)0x2013),
        SupportOpenglArb = ((int)0x2010),
        TextureCubeMapPositiveYArb = ((int)0x207f),
        DrawToWindowExt = ((int)0x2001),
        PbufferLargestExt = ((int)0x2033),
        DrawToPbufferArb = ((int)0x202d),
        SupportOpenglExt = ((int)0x2010),
        SampleBuffers3dfx = ((int)0x2060),
        GenlockSourceExtenalFieldI3d = ((int)0x2046),
        MaxPbufferHeightExt = ((int)0x2030),
        SupportGdiExt = ((int)0x200f),
        Aux7Arb = ((int)0x208e),
        DigitalVideoGammaCorrectedI3d = ((int)0x2053),
        ColorBitsArb = ((int)0x2014),
        Aux6Arb = ((int)0x208d),
        ShareAccumExt = ((int)0x200e),
        StereoArb = ((int)0x2012),
        TextureRgbArb = ((int)0x2075),
        AccelerationArb = ((int)0x2003),
        TextureCubeMapPositiveXArb = ((int)0x207d),
        TransparentRedValueArb = ((int)0x2037),
        BlueBitsArb = ((int)0x2019),
        SwapExchangeArb = ((int)0x2028),
        SamplesExt = ((int)0x2042),
        AlphaShiftExt = ((int)0x201c),
        SamplesArb = ((int)0x2042),
        TextureTargetArb = ((int)0x2073),
        BindToTextureRectangleDepthNv = ((int)0x20a4),
        AlphaShiftArb = ((int)0x201c),
        Aux8Arb = ((int)0x208f),
        MaxPbufferWidthExt = ((int)0x202f),
        GenlockSourceEdgeFallingI3d = ((int)0x204a),
        StereoExt = ((int)0x2012),
        MaxPbufferWidthArb = ((int)0x202f),
        TextureRectangleNv = ((int)0x20a2),
        ImageBufferMinAccessI3d = ((int)0x00000001),
        TextureCubeMapNegativeZArb = ((int)0x2082),
        MipmapTextureArb = ((int)0x2074),
        GenericAccelerationArb = ((int)0x2026),
        BindToTextureRectangleFloatRNv = ((int)0x20b1),
        FontLines = ((int)0),
    }

    public enum WGL_ARB_extensions_string
    {
    }

    public enum WGL_I3D_image_buffer
    {
        ImageBufferMinAccessI3d = ((int)0x00000001),
        ImageBufferLockI3d = ((int)0x00000002),
    }

    public enum WGL_I3D_swap_frame_lock
    {
    }
}