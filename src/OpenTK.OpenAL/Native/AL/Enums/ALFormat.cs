namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Sound samples: Format specifier.
    /// </summary>
    public enum ALFormat
    {
        /// <summary>
        /// 1 Channel, 8 bits per sample.
        /// </summary>
        Mono8 = 0x1100,

        /// <summary>
        /// 1 Channel, 16 bits per sample.
        /// </summary>
        Mono16 = 0x1101,

        /// <summary>
        /// 2 Channels, 8 bits per sample each.
        /// </summary>
        Stereo8 = 0x1102,

        /// <summary>
        /// 2 Channels, 16 bits per sample each.
        /// </summary>
        Stereo16 = 0x1103,

        /// <summary>
        /// 1 Channel, A-law encoded data. Requires Extension: AL_EXT_ALAW.
        /// </summary>
        MonoALawExt = 0x10016,

        /// <summary>
        /// 2 Channels, A-law encoded data. Requires Extension: AL_EXT_ALAW.
        /// </summary>
        StereoALawExt = 0x10017,

        /// <summary>
        /// 1 Channel, µ-law encoded data. Requires Extension: AL_EXT_MULAW.
        /// </summary>
        MonoMuLawExt = 0x10014,

        /// <summary>
        /// 2 Channels, µ-law encoded data. Requires Extension: AL_EXT_MULAW.
        /// </summary>
        StereoMuLawExt = 0x10015,

        /// <summary>
        /// Ogg Vorbis encoded data. Requires Extension: AL_EXT_vorbis.
        /// </summary>
        VorbisExt = 0x10003,

        /// <summary>
        /// MP3 encoded data. Requires Extension: AL_EXT_mp3.
        /// </summary>
        Mp3Ext = 0x10020,

        /// <summary>
        /// 1 Channel, IMA4 ADPCM encoded data. Requires Extension: AL_EXT_IMA4.
        /// </summary>
        MonoIma4Ext = 0x1300,

        /// <summary>
        /// 2 Channels, IMA4 ADPCM encoded data. Requires Extension: AL_EXT_IMA4.
        /// </summary>
        StereoIma4Ext = 0x1301,

        /// <summary>
        /// 1 Channel, single-precision floating-point data. Requires Extension: AL_EXT_float32.
        /// </summary>
        MonoFloat32Ext = 0x10010,

        /// <summary>
        /// 2 Channels, single-precision floating-point data. Requires Extension: AL_EXT_float32.
        /// </summary>
        StereoFloat32Ext = 0x10011,

        /// <summary>
        /// 1 Channel, double-precision floating-point data. Requires Extension: AL_EXT_double.
        /// </summary>
        MonoDoubleExt = 0x10012,

        /// <summary>
        /// 2 Channels, double-precision floating-point data. Requires Extension: AL_EXT_double.
        /// </summary>
        StereoDoubleExt = 0x10013,

        /// <summary>
        /// Multichannel 5.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi51Chn16Ext = 0x120B,

        /// <summary>
        /// Multichannel 5.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi51Chn32Ext = 0x120C,

        /// <summary>
        /// Multichannel 5.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi51Chn8Ext = 0x120A,

        /// <summary>
        /// Multichannel 6.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi61Chn16Ext = 0x120E,

        /// <summary>
        /// Multichannel 6.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi61Chn32Ext = 0x120F,

        /// <summary>
        /// Multichannel 6.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi61Chn8Ext = 0x120D,

        /// <summary>
        /// Multichannel 7.1, 16-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi71Chn16Ext = 0x1211,

        /// <summary>
        /// Multichannel 7.1, 32-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi71Chn32Ext = 0x1212,

        /// <summary>
        /// Multichannel 7.1, 8-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        Multi71Chn8Ext = 0x1210,

        /// <summary>
        /// Multichannel 4.0, 16-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiQuad16Ext = 0x1205,

        /// <summary>
        /// Multichannel 4.0, 32-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiQuad32Ext = 0x1206,

        /// <summary>
        /// Multichannel 4.0, 8-bit data. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiQuad8Ext = 0x1204,

        /// <summary>
        /// 1 Channel rear speaker, 16-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiRear16Ext = 0x1208,

        /// <summary>
        /// 1 Channel rear speaker, 32-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiRear32Ext = 0x1209,

        /// <summary>
        /// 1 Channel rear speaker, 8-bit data. See Quadrophonic setups. Requires Extension: AL_EXT_MCFORMATS.
        /// </summary>
        MultiRear8Ext = 0x1207
    }
}
