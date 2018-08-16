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
    }
}
