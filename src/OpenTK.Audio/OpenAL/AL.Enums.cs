// This file is auto generated, do not edit.
using System;

namespace OpenTK.Audio.OpenAL
{
#pragma warning disable CA1069 // Enums values should not be duplicated
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS0419 // Ambiguous reference in cref attribute
    public enum All : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_FIRST_PARAMETER]</remarks>
        EffectFirstParameter = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_NULL]</remarks>
        EffectNull = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECTSLOT_NULL]</remarks>
        EffectslotNull = 0,
        /// <summary><b>[requires: v1.0]</b> Boolean False.</summary>
        /// <remarks>[originally: AL_FALSE]</remarks>
        False = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_FIRST_PARAMETER]</remarks>
        FilterFirstParameter = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_NULL]</remarks>
        FilterNull = 0,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_FUMA_SOFT]</remarks>
        FumaSoft = 0,
        /// <summary><b>[requires: v1.0]</b> No error.</summary>
        /// <remarks>[originally: AL_NO_ERROR]</remarks>
        NoError = 0,
        /// <summary><b>[requires: v1.0]</b> No distance model or no buffer</summary>
        /// <remarks>[originally: AL_NONE]</remarks>
        None = 0,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_NORMAL_SOFT]</remarks>
        NormalSoft = 0,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_ACN_SOFT]</remarks>
        AcnSoft = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_ATTACK_TIME]</remarks>
        AutowahAttackTime = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAIN]</remarks>
        BandpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_WAVEFORM]</remarks>
        ChorusWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_COMPRESSOR_ONOFF]</remarks>
        CompressorOnoff = 1,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_CONTEXT_DEBUG_BIT_EXT]</remarks>
        ContextDebugBitExt = 1,
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> <b>[property on: effect][default value: 1]</b><br/></summary>
        /// <remarks>[originally: AL_DEDICATED_GAIN]</remarks>
        DedicatedGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EDGE]</remarks>
        DistortionEdge = 1,
        /// <summary><b>[requires: AL_SOFT_direct_channels_remix]</b> </summary>
        /// <remarks>[originally: AL_DROP_UNMATCHED_SOFT]</remarks>
        DropUnmatchedSoft = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DENSITY]</remarks>
        EaxreverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DELAY]</remarks>
        EchoDelay = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_REVERB]</remarks>
        EffectReverb = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_EFFECT]</remarks>
        EffectslotEffect = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_GAIN]</remarks>
        EqualizerLowGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_LOWPASS]</remarks>
        FilterLowpass = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_WAVEFORM]</remarks>
        FlangerWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_FREQUENCY]</remarks>
        FrequencyShifterFrequency = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_HIGHPASS_GAIN]</remarks>
        HighpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_LOWPASS_GAIN]</remarks>
        LowpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_COARSE_TUNE]</remarks>
        PitchShifterCoarseTune = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DENSITY]</remarks>
        ReverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_FREQUENCY]</remarks>
        RingModulatorFrequency = 1,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_SN3D_SOFT]</remarks>
        SN3DSoft = 1,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_SUPER_STEREO_SOFT]</remarks>
        SuperStereoSoft = 1,
        /// <summary><b>[requires: v1.0]</b> Boolean True.</summary>
        /// <remarks>[originally: AL_TRUE]</remarks>
        True = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA]</remarks>
        VocalMorpherPhonemea = 1,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> </summary>
        /// <remarks>[originally: AL_AUTO_SOFT]</remarks>
        AutoSoft = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RELEASE_TIME]</remarks>
        AutowahReleaseTime = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAINLF]</remarks>
        BandpassGainlf = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_PHASE]</remarks>
        ChorusPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_GAIN]</remarks>
        DistortionGain = 2,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DONT_CARE_EXT]</remarks>
        DontCareExt = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DIFFUSION]</remarks>
        EaxreverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_LRDELAY]</remarks>
        EchoLrdelay = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_CHORUS]</remarks>
        EffectChorus = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_GAIN]</remarks>
        EffectslotGain = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_CUTOFF]</remarks>
        EqualizerLowCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_HIGHPASS]</remarks>
        FilterHighpass = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_PHASE]</remarks>
        FlangerPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_LEFT_DIRECTION]</remarks>
        FrequencyShifterLeftDirection = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_HIGHPASS_GAINLF]</remarks>
        HighpassGainlf = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_LOWPASS_GAINHF]</remarks>
        LowpassGainhf = 2,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_N3D_SOFT]</remarks>
        N3DSoft = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_FINE_TUNE]</remarks>
        PitchShifterFineTune = 2,
        /// <summary><b>[requires: AL_SOFT_direct_channels_remix]</b> </summary>
        /// <remarks>[originally: AL_REMIX_UNMATCHED_SOFT]</remarks>
        RemixUnmatchedSoft = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DIFFUSION]</remarks>
        ReverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_HIGHPASS_CUTOFF]</remarks>
        RingModulatorHighpassCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING]</remarks>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RESONANCE]</remarks>
        AutowahResonance = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAINHF]</remarks>
        BandpassGainhf = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_RATE]</remarks>
        ChorusRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_LOWPASS_CUTOFF]</remarks>
        DistortionLowpassCutoff = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAIN]</remarks>
        EaxreverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DAMPING]</remarks>
        EchoDamping = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DISTORTION]</remarks>
        EffectDistortion = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_AUXILIARY_SEND_AUTO]</remarks>
        EffectslotAuxiliarySendAuto = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_GAIN]</remarks>
        EqualizerMid1Gain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_BANDPASS]</remarks>
        FilterBandpass = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_RATE]</remarks>
        FlangerRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION]</remarks>
        FrequencyShifterRightDirection = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAIN]</remarks>
        ReverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_WAVEFORM]</remarks>
        RingModulatorWaveform = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB]</remarks>
        VocalMorpherPhonemeb = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_PEAK_GAIN]</remarks>
        AutowahPeakGain = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DEPTH]</remarks>
        ChorusDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQCENTER]</remarks>
        DistortionEqcenter = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINHF]</remarks>
        EaxreverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_FEEDBACK]</remarks>
        EchoFeedback = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_ECHO]</remarks>
        EffectEcho = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_CENTER]</remarks>
        EqualizerMid1Center = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DEPTH]</remarks>
        FlangerDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAINHF]</remarks>
        ReverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING]</remarks>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_FEEDBACK]</remarks>
        ChorusFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQBANDWIDTH]</remarks>
        DistortionEqbandwidth = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINLF]</remarks>
        EaxreverbGainlf = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_SPREAD]</remarks>
        EchoSpread = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_FLANGER]</remarks>
        EffectFlanger = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_WIDTH]</remarks>
        EqualizerMid1Width = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_FEEDBACK]</remarks>
        FlangerFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_TIME]</remarks>
        ReverbDecayTime = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_WAVEFORM]</remarks>
        VocalMorpherWaveform = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DELAY]</remarks>
        ChorusDelay = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_TIME]</remarks>
        EaxreverbDecayTime = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_FREQUENCY_SHIFTER]</remarks>
        EffectFrequencyShifter = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_GAIN]</remarks>
        EqualizerMid2Gain = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DELAY]</remarks>
        FlangerDelay = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFRATIO]</remarks>
        ReverbDecayHfratio = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_RATE]</remarks>
        VocalMorpherRate = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFRATIO]</remarks>
        EaxreverbDecayHfratio = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_VOCAL_MORPHER]</remarks>
        EffectVocalMorpher = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_CENTER]</remarks>
        EqualizerMid2Center = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_GAIN]</remarks>
        ReverbReflectionsGain = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_LFRATIO]</remarks>
        EaxreverbDecayLfratio = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_PITCH_SHIFTER]</remarks>
        EffectPitchShifter = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_WIDTH]</remarks>
        EqualizerMid2Width = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_DELAY]</remarks>
        ReverbReflectionsDelay = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_GAIN]</remarks>
        EaxreverbReflectionsGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_RING_MODULATOR]</remarks>
        EffectRingModulator = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_GAIN]</remarks>
        EqualizerHighGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_GAIN]</remarks>
        ReverbLateReverbGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_DELAY]</remarks>
        EaxreverbReflectionsDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_AUTOWAH]</remarks>
        EffectAutowah = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_CUTOFF]</remarks>
        EqualizerHighCutoff = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_DELAY]</remarks>
        ReverbLateReverbDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_PAN]</remarks>
        EaxreverbReflectionsPan = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_COMPRESSOR]</remarks>
        EffectCompressor = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_AIR_ABSORPTION_GAINHF]</remarks>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_GAIN]</remarks>
        EaxreverbLateReverbGain = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EQUALIZER]</remarks>
        EffectEqualizer = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        ReverbRoomRolloffFactor = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_DELAY]</remarks>
        EaxreverbLateReverbDelay = 13,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFLIMIT]</remarks>
        ReverbDecayHflimit = 13,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_PAN]</remarks>
        EaxreverbLateReverbPan = 14,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_TIME]</remarks>
        EaxreverbEchoTime = 15,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_DEPTH]</remarks>
        EaxreverbEchoDepth = 16,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_TIME]</remarks>
        EaxreverbModulationTime = 17,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_DEPTH]</remarks>
        EaxreverbModulationDepth = 18,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_AIR_ABSORPTION_GAINHF]</remarks>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_HFREFERENCE]</remarks>
        EaxreverbHfreference = 20,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LFREFERENCE]</remarks>
        EaxreverbLfreference = 21,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        EaxreverbRoomRolloffFactor = 22,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFLIMIT]</remarks>
        EaxreverbDecayHflimit = 23,
        /// <summary><b>[requires: AL_EXT_source_distance_model]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_DISTANCE_MODEL]</remarks>
        SourceDistanceModel = 512,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_RELATIVE]</remarks>
        SourceRelative = 514,
        /// <summary><b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_SPATIAL_RENDERING_QUALITY_HIGH]</remarks>
        MacOsxSpatialRenderingQualityHigh = 1021,
        /// <summary><b>[requires: ALC_EXT_MAC_OSX]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_RENDER_CHANNEL_COUNT_STEREO]</remarks>
        MacOsxRenderChannelCountStereo = 1022,
        /// <summary><b>[requires: ALC_EXT_MAC_OSX]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_RENDER_CHANNEL_COUNT_MULTICHANNEL]</remarks>
        MacOsxRenderChannelCountMultichannel = 1023,
        /// <summary><b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_SPATIAL_RENDERING_QUALITY_LOW]</remarks>
        MacOsxSpatialRenderingQualityLow = 1023,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        /// <remarks>[originally: AL_PITCH]</remarks>
        Pitch = 4099,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        /// <remarks>[originally: AL_LOOPING]</remarks>
        Looping = 4103,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        /// <remarks>[originally: AL_BUFFER]</remarks>
        Buffer = 4105,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_BUFFER_EXT]</remarks>
        BufferExt = 4105,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: AL_LOKI_play_position]</b> </summary>
        /// <remarks>[originally: AL_BYTE_LOKI]</remarks>
        ByteLoki = 4108,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MIN_GAIN]</remarks>
        MinGain = 4109,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_GAIN]</remarks>
        MaxGain = 4110,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
        /// Listener orientation.
        /// 
        ///                 Effectively two three dimensional vectors. The first vector is the front (or
        ///                 "at") and the second is the top (or "up"). Both vectors are relative to the
        ///                 listener position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component of both vectors.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ORIENTATION]</remarks>
        Orientation = 4111,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>Source state (query only).</summary>
        /// <remarks>[originally: AL_SOURCE_STATE]</remarks>
        SourceState = 4112,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INITIAL]</remarks>
        Initial = 4113,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_PLAYING]</remarks>
        Playing = 4114,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_PAUSED]</remarks>
        Paused = 4115,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STOPPED]</remarks>
        Stopped = 4116,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_QUEUED]</remarks>
        BuffersQueued = 4117,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_PROCESSED]</remarks>
        BuffersProcessed = 4118,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_DISTANCE]</remarks>
        MaxDistance = 4131,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source type (query only).
        /// 
        ///                 A Source is Static if a Buffer has been attached using AL_BUFFER.
        /// 
        ///                 A Source is Streaming if one or more Buffers have been attached using
        ///                 alSourceQueueBuffers.
        /// 
        ///                 A Source is Undetermined when it has the NULL buffer attached using
        ///                 AL_BUFFER.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_TYPE]</remarks>
        SourceType = 4135,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STATIC]</remarks>
        Static = 4136,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STREAMING]</remarks>
        Streaming = 4137,
        /// <summary><b>[requires: AL_EXT_STEREO_ANGLES]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_ANGLES]</remarks>
        StereoAngles = 4144,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_UNDETERMINED]</remarks>
        Undetermined = 4144,
        /// <summary><b>[requires: AL_SOFT_buffer_samples | AL_SOFT_buffer_sub_data]</b> <b>[property on: source][range: [0.0, ) ]</b><br/></summary>
        /// <remarks>[originally: AL_BYTE_RW_OFFSETS_SOFT]</remarks>
        ByteRwOffsetsSoft = 4145,
        /// <summary><b>[requires: AL_EXT_SOURCE_RADIUS]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RADIUS]</remarks>
        SourceRadius = 4145,
        /// <summary><b>[requires: AL_SOFT_buffer_samples | AL_SOFT_buffer_sub_data]</b> <b>[property on: source][range: [0.0, ) ]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_RW_OFFSETS_SOFT]</remarks>
        SampleRwOffsetsSoft = 4146,
        /// <summary><b>[requires: AL_SOFT_direct_channels]</b> <b>[property on: source][default value: AL_FALSE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_CHANNELS_SOFT]</remarks>
        DirectChannelsSoft = 4147,
        /// <summary><b>[requires: v1.0]</b> Unsigned 8-bit mono buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_MONO8]</remarks>
        Mono8 = 4352,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO8_SOFT]</remarks>
        Mono8Soft = 4352,
        /// <summary><b>[requires: v1.0]</b> Signed 16-bit mono buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_MONO16]</remarks>
        Mono16 = 4353,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO16_SOFT]</remarks>
        Mono16Soft = 4353,
        /// <summary><b>[requires: v1.0]</b> Unsigned 8-bit stereo buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_STEREO8]</remarks>
        Stereo8 = 4354,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO8_SOFT]</remarks>
        Stereo8Soft = 4354,
        /// <summary><b>[requires: v1.0]</b> Signed 16-bit stereo buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_STEREO16]</remarks>
        Stereo16 = 4355,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO16_SOFT]</remarks>
        Stereo16Soft = 4355,
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET_LATENCY_SOFT]</remarks>
        SampleOffsetLatencySoft = 4608,
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_OFFSET_LATENCY_SOFT]</remarks>
        SecOffsetLatencySoft = 4609,
        /// <summary><b>[requires: ALC_SOFT_device_clock]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET_CLOCK_SOFT]</remarks>
        SampleOffsetClockSoft = 4610,
        /// <summary><b>[requires: ALC_SOFT_device_clock]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_OFFSET_CLOCK_SOFT]</remarks>
        SecOffsetClockSoft = 4611,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD8]</remarks>
        Quad8 = 4612,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD8_SOFT]</remarks>
        Quad8Soft = 4612,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD16]</remarks>
        Quad16 = 4613,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD16_SOFT]</remarks>
        Quad16Soft = 4613,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD32]</remarks>
        Quad32 = 4614,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD32F_SOFT]</remarks>
        Quad32fSoft = 4614,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR8]</remarks>
        Rear8 = 4615,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR8_SOFT]</remarks>
        Rear8Soft = 4615,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR16]</remarks>
        Rear16 = 4616,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR16_SOFT]</remarks>
        Rear16Soft = 4616,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR32]</remarks>
        Rear32 = 4617,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR32F_SOFT]</remarks>
        Rear32fSoft = 4617,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN8]</remarks>
        _51chn8 = 4618,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_8_SOFT]</remarks>
        _5point18Soft = 4618,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN16]</remarks>
        _51chn16 = 4619,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_16_SOFT]</remarks>
        _5point116Soft = 4619,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN32]</remarks>
        _51chn32 = 4620,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_32F_SOFT]</remarks>
        _5point132fSoft = 4620,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN8]</remarks>
        _61chn8 = 4621,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_8_SOFT]</remarks>
        _6point18Soft = 4621,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN16]</remarks>
        _61chn16 = 4622,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_16_SOFT]</remarks>
        _6point116Soft = 4622,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN32]</remarks>
        _61chn32 = 4623,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_32F_SOFT]</remarks>
        _6point132fSoft = 4623,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN8]</remarks>
        _71chn8 = 4624,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_8_SOFT]</remarks>
        _7point18Soft = 4624,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_NUM_RESAMPLERS_SOFT]</remarks>
        NumResamplersSoft = 4624,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN16]</remarks>
        _71chn16 = 4625,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_16_SOFT]</remarks>
        _7point116Soft = 4625,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_DEFAULT_RESAMPLER_SOFT]</remarks>
        DefaultResamplerSoft = 4625,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN32]</remarks>
        _71chn32 = 4626,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_32F_SOFT]</remarks>
        _7point132fSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RESAMPLER_SOFT]</remarks>
        SourceResamplerSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_RESAMPLER_NAME_SOFT]</remarks>
        ResamplerNameSoft = 4627,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_SPATIALIZE_SOFT]</remarks>
        SourceSpatializeSoft = 4628,
        /// <summary><b>[requires: AL_EXT_IMA4]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_IMA4]</remarks>
        MonoIMA4 = 4864,
        /// <summary><b>[requires: AL_EXT_IMA4]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_IMA4]</remarks>
        StereoIMA4 = 4865,
        /// <summary><b>[requires: AL_SOFT_MSADPCM]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MSADPCM_SOFT]</remarks>
        MonoMSADPCMSoft = 4866,
        /// <summary><b>[requires: AL_SOFT_MSADPCM]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MSADPCM_SOFT]</remarks>
        StereoMSADPCMSoft = 4867,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_BYTE_SOFT]</remarks>
        ByteSoft = 5120,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_BYTE_SOFT]</remarks>
        UnsignedByteSoft = 5121,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_SHORT_SOFT]</remarks>
        ShortSoft = 5122,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_SHORT_SOFT]</remarks>
        UnsignedShortSoft = 5123,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_INT_SOFT]</remarks>
        IntSoft = 5124,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_INT_SOFT]</remarks>
        UnsignedIntSoft = 5125,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_FLOAT_SOFT]</remarks>
        FloatSoft = 5126,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_DOUBLE_SOFT]</remarks>
        DoubleSoft = 5127,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_BYTE3_SOFT]</remarks>
        Byte3Soft = 5128,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_BYTE3_SOFT]</remarks>
        UnsignedByte3Soft = 5129,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO_SOFT]</remarks>
        MonoSoft = 5376,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO_SOFT]</remarks>
        StereoSoft = 5377,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD_SOFT]</remarks>
        QuadSoft = 5378,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR_SOFT]</remarks>
        RearSoft = 5379,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_SOFT]</remarks>
        _5point1Soft = 5380,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_SOFT]</remarks>
        _6point1Soft = 5381,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_SOFT]</remarks>
        _7point1Soft = 5382,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_LAYOUT_SOFT]</remarks>
        AmbisonicLayoutSoft = 6551,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_SCALING_SOFT]</remarks>
        AmbisonicScalingSoft = 6552,
        /// <summary><b>[requires: AL_SOFT_effect_target]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_TARGET_SOFT]</remarks>
        EffectslotTargetSoft = 6556,
        /// <summary><b>[requires: AL_SOFT_bformat_hoa]</b> <b>[property on: buffer][range: [1, 14] ][default value: 1]</b><br/></summary>
        /// <remarks>[originally: AL_UNPACK_AMBISONIC_ORDER_SOFT]</remarks>
        UnpackAmbisonicOrderSoft = 6557,
        /// <summary><b>[requires: AL_SOFT_callback_buffer]</b> <b>[property on: buffer][default value: NULL]</b><br/></summary>
        /// <remarks>[originally: AL_BUFFER_CALLBACK_FUNCTION_SOFT]</remarks>
        BufferCallbackFunctionSoft = 6560,
        /// <summary><b>[requires: AL_SOFT_callback_buffer]</b> <b>[property on: buffer][default value: NULL]</b><br/></summary>
        /// <remarks>[originally: AL_BUFFER_CALLBACK_USER_PARAM_SOFT]</remarks>
        BufferCallbackUserParamSoft = 6561,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_CALLBACK_FUNCTION_SOFT]</remarks>
        EventCallbackFunctionSoft = 6562,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN8_SOFT]</remarks>
        UHJ2chn8Soft = 6562,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_CALLBACK_USER_PARAM_SOFT]</remarks>
        EventCallbackUserParamSoft = 6563,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN16_SOFT]</remarks>
        UHJ2chn16Soft = 6563,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT]</remarks>
        EventTypeBufferCompletedSoft = 6564,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_FLOAT32_SOFT]</remarks>
        UHJ2chnFloat32Soft = 6564,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT]</remarks>
        EventTypeSourceStateChangedSoft = 6565,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN8_SOFT]</remarks>
        UHJ3chn8Soft = 6565,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_DISCONNECTED_SOFT]</remarks>
        EventTypeDisconnectedSoft = 6566,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN16_SOFT]</remarks>
        UHJ3chn16Soft = 6566,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_FLOAT32_SOFT]</remarks>
        UHJ3chnFloat32Soft = 6567,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN8_SOFT]</remarks>
        UHJ4chn8Soft = 6568,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN16_SOFT]</remarks>
        UHJ4chn16Soft = 6569,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_FLOAT32_SOFT]</remarks>
        UHJ4chnFloat32Soft = 6570,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_MODE_SOFT]</remarks>
        StereoModeSoft = 6576,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/></summary>
        /// <remarks>[originally: AL_SUPER_STEREO_WIDTH_SOFT]</remarks>
        SuperStereoWidthSoft = 6577,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_OUTPUT_EXT]</remarks>
        DebugOutputExt = 6578,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_CALLBACK_FUNCTION_EXT]</remarks>
        DebugCallbackFunctionExt = 6579,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_MULAW_SOFT]</remarks>
        UHJ2chnMULAWSoft = 6579,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_CALLBACK_USER_PARAM_EXT]</remarks>
        DebugCallbackUserParamExt = 6580,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_ALAW_SOFT]</remarks>
        UHJ2chnALAWSoft = 6580,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_API_EXT]</remarks>
        DebugSourceApiExt = 6581,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_IMA4_SOFT]</remarks>
        UHJ2chnIMA4Soft = 6581,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT]</remarks>
        DebugSourceAudioSystemExt = 6582,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_MSADPCM_SOFT]</remarks>
        UHJ2chnMSADPCMSoft = 6582,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_THIRD_PARTY_EXT]</remarks>
        DebugSourceThirdPartyExt = 6583,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_MULAW_SOFT]</remarks>
        UHJ3chnMULAWSoft = 6583,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_APPLICATION_EXT]</remarks>
        DebugSourceApplicationExt = 6584,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_ALAW_SOFT]</remarks>
        UHJ3chnALAWSoft = 6584,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_OTHER_EXT]</remarks>
        DebugSourceOtherExt = 6585,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_MULAW_SOFT]</remarks>
        UHJ4chnMULAWSoft = 6585,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_ERROR_EXT]</remarks>
        DebugTypeErrorExt = 6586,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_ALAW_SOFT]</remarks>
        UHJ4chnALAWSoft = 6586,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT]</remarks>
        DebugTypeDeprecatedBehaviorExt = 6587,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT]</remarks>
        DebugTypeUndefinedBehaviorExt = 6588,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PORTABILITY_EXT]</remarks>
        DebugTypePortabilityExt = 6589,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PERFORMANCE_EXT]</remarks>
        DebugTypePerformanceExt = 6590,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_MARKER_EXT]</remarks>
        DebugTypeMarkerExt = 6591,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PUSH_GROUP_EXT]</remarks>
        DebugTypePushGroupExt = 6592,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_POP_GROUP_EXT]</remarks>
        DebugTypePopGroupExt = 6593,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_OTHER_EXT]</remarks>
        DebugTypeOtherExt = 6594,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_HIGH_EXT]</remarks>
        DebugSeverityHighExt = 6595,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_MEDIUM_EXT]</remarks>
        DebugSeverityMediumExt = 6596,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_LOW_EXT]</remarks>
        DebugSeverityLowExt = 6597,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_NOTIFICATION_EXT]</remarks>
        DebugSeverityNotificationExt = 6598,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        DebugLoggedMessagesExt = 6599,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT]</remarks>
        DebugNextLoggedMessageLengthExt = 6600,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_MESSAGE_LENGTH_EXT]</remarks>
        MaxDebugMessageLengthExt = 6601,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        MaxDebugLoggedMessagesExt = 6602,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT]</remarks>
        MaxDebugGroupStackDepthExt = 6603,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_LABEL_LENGTH_EXT]</remarks>
        MaxLabelLengthExt = 6604,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_STACK_OVERFLOW_EXT]</remarks>
        StackOverflowExt = 6605,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_STACK_UNDERFLOW_EXT]</remarks>
        StackUnderflowExt = 6606,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_CONTEXT_FLAGS_EXT]</remarks>
        ContextFlagsExt = 6607,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_EXT]</remarks>
        SourceExt = 6608,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_FILTER_EXT]</remarks>
        FilterExt = 6609,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EXT]</remarks>
        EffectExt = 6610,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_AUXILIARY_EFFECT_SLOT_EXT]</remarks>
        AuxiliaryEffectSlotExt = 6611,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer frequency/sample rate (query only).</summary>
        /// <remarks>[originally: AL_FREQUENCY]</remarks>
        Frequency = 8193,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer bits per sample (query only).</summary>
        /// <remarks>[originally: AL_BITS]</remarks>
        Bits = 8194,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer channel count (query only).</summary>
        /// <remarks>[originally: AL_CHANNELS]</remarks>
        Channels = 8195,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer data size in bytes (query only).</summary>
        /// <remarks>[originally: AL_SIZE]</remarks>
        Size = 8196,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_INTERNAL_FORMAT_SOFT]</remarks>
        InternalFormatSoft = 8200,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_BYTE_LENGTH_SOFT]</remarks>
        ByteLengthSoft = 8201,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_LENGTH_SOFT]</remarks>
        SampleLengthSoft = 8202,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_LENGTH_SOFT]</remarks>
        SecLengthSoft = 8203,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_UNPACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        PackBlockAlignmentSoft = 8205,
        /// <summary><b>[requires: AL_SOFT_gain_clamp_ex]</b> </summary>
        /// <remarks>[originally: AL_GAIN_LIMIT_SOFT]</remarks>
        GainLimitSoft = 8206,
        /// <summary><b>[requires: AL_EXT_loop_points]</b> </summary>
        /// <remarks>[originally: AL_LOOP_POINTS_EXT]</remarks>
        LoopPointsExt = 8213,
        /// <summary><b>[requires: AL_SOFT_loop_points]</b> <b>[property on: buffer][default value: 0,0]</b><br/></summary>
        /// <remarks>[originally: AL_LOOP_POINTS_SOFT]</remarks>
        LoopPointsSoft = 8213,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_MODE_MONO]</remarks>
        FoldbackModeMono = 16641,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_MODE_STEREO]</remarks>
        FoldbackModeStereo = 16642,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_START]</remarks>
        FoldbackEventStart = 16657,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_BLOCK]</remarks>
        FoldbackEventBlock = 16658,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_STOP]</remarks>
        FoldbackEventStop = 16659,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EAXREVERB]</remarks>
        EffectEaxreverb = 32768,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_LAST_PARAMETER]</remarks>
        EffectLastParameter = 32768,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_LAST_PARAMETER]</remarks>
        FilterLastParameter = 32768,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECT_TYPE]</remarks>
        EffectType = 32769,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_FILTER_TYPE]</remarks>
        FilterType = 32769,
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT]</remarks>
        EffectDedicatedLowFrequencyEffect = 36864,
        /// <summary><b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> </summary>
        /// <remarks>[originally: AL_QUEUE_HAS_LOOPED]</remarks>
        QueueHasLooped = 36864,
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DEDICATED_DIALOGUE]</remarks>
        EffectDedicatedDialogue = 36865,
        /// <summary><b>[requires: v1.0]</b> Invalid name (ID) passed to an AL call.</summary>
        /// <remarks>[originally: AL_INVALID_NAME]</remarks>
        InvalidName = 40961,
        /// <summary><b>[requires: v1.0]</b> Invalid enumeration passed to AL call.</summary>
        /// <remarks>[originally: AL_INVALID_ENUM]</remarks>
        InvalidEnum = 40962,
        /// <summary><b>[requires: v1.0]</b> Invalid value passed to AL call.</summary>
        /// <remarks>[originally: AL_INVALID_VALUE]</remarks>
        InvalidValue = 40963,
        /// <summary><b>[requires: v1.0]</b> Illegal AL call.</summary>
        /// <remarks>[originally: AL_INVALID_OPERATION]</remarks>
        InvalidOperation = 40964,
        /// <summary><b>[requires: v1.0]</b> Not enough memory to execute the AL call.</summary>
        /// <remarks>[originally: AL_OUT_OF_MEMORY]</remarks>
        OutOfMemory = 40965,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Vendor name.</summary>
        /// <remarks>[originally: AL_VENDOR]</remarks>
        Vendor = 45057,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Version.</summary>
        /// <remarks>[originally: AL_VERSION]</remarks>
        Version = 45058,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Renderer name.</summary>
        /// <remarks>[originally: AL_RENDERER]</remarks>
        Renderer = 45059,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Space-separated extension list.</summary>
        /// <remarks>[originally: AL_EXTENSIONS]</remarks>
        Extensions = 45060,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Doppler scale.
        /// Scale for source and listener velocities.
        /// </summary>
        /// <remarks>[originally: AL_DOPPLER_FACTOR]</remarks>
        DopplerFactor = 49152,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>
        /// Doppler velocity (deprecated).
        /// A multiplier applied to the Speed of Sound.
        /// </summary>
        /// <remarks>[originally: AL_DOPPLER_VELOCITY]</remarks>
        DopplerVelocity = 49153,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context][range: [0.0001, ) ][default value: 343.3]</b><br/>
        /// Speed of Sound, in units per second.
        /// 
        ///                 The speed at which sound waves are assumed to travel, when calculating the
        ///                 doppler effect from source and listener velocities.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SPEED_OF_SOUND]</remarks>
        SpeedOfSound = 49155,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context][default value: AL_INVERSE_DISTANCE_CLAMPED]</b><br/>
        /// Distance attenuation model.
        /// 
        ///                 The model by which sources attenuate with distance.
        /// 
        ///                 None     - No distance attenuation.
        ///                 Inverse  - Doubling the distance halves the source gain.
        ///                 Linear   - Linear gain scaling between the reference and max distances.
        ///                 Exponent - Exponential gain dropoff.
        /// 
        ///                 Clamped variations work like the non-clamped counterparts, except the
        ///                 distance calculated is clamped between the reference and max distances.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DISTANCE_MODEL]</remarks>
        DistanceModel = 53248,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE]</remarks>
        InverseDistance = 53249,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_CLAMPED]</remarks>
        InverseDistanceClamped = 53250,
        /// <summary><b>[requires: v1.1 | AL_EXT_LINEAR_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE]</remarks>
        LinearDistance = 53251,
        /// <summary><b>[requires: v1.1 | AL_EXT_LINEAR_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_CLAMPED]</remarks>
        LinearDistanceClamped = 53252,
        /// <summary><b>[requires: v1.1 | AL_EXT_EXPONENT_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE]</remarks>
        ExponentDistance = 53253,
        /// <summary><b>[requires: v1.1 | AL_EXT_EXPONENT_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_CLAMPED]</remarks>
        ExponentDistanceClamped = 53254,
        /// <summary><b>[requires: ALC_MAC_OSX_CONVERT_DATA_UPON_LOADING]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_CONVERT_DATA_UPON_LOADING]</remarks>
        MacOsxConvertDataUponLoading = 61441,
        /// <summary><b>[requires: AL_LOKI_IMA_ADPCM_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_IMA_ADPCM_MONO16_EXT]</remarks>
        IMAADPCMMono16Ext = 65536,
        /// <summary><b>[requires: AL_LOKI_IMA_ADPCM_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_IMA_ADPCM_STEREO16_EXT]</remarks>
        IMAADPCMStereo16Ext = 65537,
        /// <summary><b>[requires: AL_LOKI_WAVE_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_WAVE_EXT]</remarks>
        WaveExt = 65538,
        /// <summary><b>[requires: AL_EXT_vorbis]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_VORBIS_EXT]</remarks>
        VorbisExt = 65539,
        /// <summary><b>[requires: AL_LOKI_quadriphonic]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD8_LOKI]</remarks>
        Quad8Loki = 65540,
        /// <summary><b>[requires: AL_LOKI_quadriphonic]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD16_LOKI]</remarks>
        Quad16Loki = 65541,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO32F_SOFT]</remarks>
        Mono32fSoft = 65552,
        /// <summary><b>[requires: AL_EXT_float32]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_FLOAT32]</remarks>
        MonoFloat32 = 65552,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO32F_SOFT]</remarks>
        Stereo32fSoft = 65553,
        /// <summary><b>[requires: AL_EXT_float32]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_FLOAT32]</remarks>
        StereoFloat32 = 65553,
        /// <summary><b>[requires: AL_EXT_double]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_DOUBLE_EXT]</remarks>
        MonoDoubleExt = 65554,
        /// <summary><b>[requires: AL_EXT_double]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_DOUBLE_EXT]</remarks>
        StereoDoubleExt = 65555,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MULAW]</remarks>
        MonoMULAW = 65556,
        /// <summary><b>[requires: AL_EXT_MULAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MULAW_EXT]</remarks>
        MonoMULAWExt = 65556,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MULAW]</remarks>
        StereoMULAW = 65557,
        /// <summary><b>[requires: AL_EXT_MULAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MULAW_EXT]</remarks>
        StereoMULAWExt = 65557,
        /// <summary><b>[requires: AL_EXT_ALAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_ALAW_EXT]</remarks>
        MonoALAWExt = 65558,
        /// <summary><b>[requires: AL_EXT_ALAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_ALAW_EXT]</remarks>
        StereoALAWExt = 65559,
        /// <summary><b>[requires: AL_EXT_mp3]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MP3_EXT]</remarks>
        Mp3Ext = 65568,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD_MULAW]</remarks>
        QuadMULAW = 65569,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR_MULAW]</remarks>
        RearMULAW = 65570,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN_MULAW]</remarks>
        _51chnMULAW = 65571,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN_MULAW]</remarks>
        _61chnMULAW = 65572,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN_MULAW]</remarks>
        _71chnMULAW = 65573,
        /// <summary><b>[requires: AL_EXT_MULAW_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_MULAW]</remarks>
        Bformat2DMULAW = 65585,
        /// <summary><b>[requires: AL_EXT_MULAW_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_MULAW]</remarks>
        Bformat3DMULAW = 65586,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_METERS_PER_UNIT]</remarks>
        MetersPerUnit = 131076,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER]</remarks>
        DirectFilter = 131077,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER]</remarks>
        AuxiliarySendFilter = 131078,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_AIR_ABSORPTION_FACTOR]</remarks>
        AirAbsorptionFactor = 131079,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_ROOM_ROLLOFF_FACTOR]</remarks>
        RoomRolloffFactor = 131080,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAINHF]</remarks>
        ConeOuterGainhf = 131081,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER_GAINHF_AUTO]</remarks>
        DirectFilterGainhfAuto = 131082,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAIN_AUTO]</remarks>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO]</remarks>
        AuxiliarySendFilterGainhfAuto = 131084,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_8]</remarks>
        Bformat2D8 = 131105,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_16]</remarks>
        Bformat2D16 = 131106,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_FLOAT32]</remarks>
        Bformat2DFloat32 = 131107,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_8]</remarks>
        Bformat3D8 = 131121,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_16]</remarks>
        Bformat3D16 = 131122,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_FLOAT32]</remarks>
        Bformat3DFloat32 = 131123,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_EAX_RAM_SIZE]</remarks>
        EaxRamSize = 2105857,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_EAX_RAM_FREE]</remarks>
        EaxRamFree = 2105858,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_AUTOMATIC]</remarks>
        StorageAutomatic = 2105859,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_HARDWARE]</remarks>
        StorageHardware = 2105860,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_ACCESSIBLE]</remarks>
        StorageAccessible = 2105861,
        /// <summary><b>[requires: AL_AAX_frequency_filter]</b> </summary>
        /// <remarks>[originally: AL_FREQUENCY_FILTER_ENABLE_AAX]</remarks>
        FrequencyFilterEnableAax = 2555904,
        /// <summary><b>[requires: AL_AAX_frequency_filter]</b> </summary>
        /// <remarks>[originally: AL_FREQUENCY_FILTER_GAINLF_AAX]</remarks>
        FrequencyFilterGainlfAax = 2555905,
        /// <summary><b>[requires: AL_AAX_frequency_filter]</b> </summary>
        /// <remarks>[originally: AL_FREQUENCY_FILTER_GAINHF_AAX]</remarks>
        FrequencyFilterGainhfAax = 2555906,
        /// <summary><b>[requires: AL_AAX_frequency_filter]</b> </summary>
        /// <remarks>[originally: AL_FREQUENCY_FILTER_CUTOFF_FREQ_AAX]</remarks>
        FrequencyFilterCutoffFreqAax = 2555907,
        /// <summary><b>[requires: AL_AAX_frequency_filter]</b> </summary>
        /// <remarks>[originally: AL_FREQUENCY_FILTER_PARAMS_AAX]</remarks>
        FrequencyFilterParamsAax = 2555908,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_ENABLE_AAX]</remarks>
        ReverbEnableAax = 2555912,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_PRE_DELAY_TIME_AAX]</remarks>
        ReverbPreDelayTimeAax = 2555913,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_REFLECTION_TIME_AAX]</remarks>
        ReverbReflectionTimeAax = 2555914,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_REFLECTION_FACTOR_AAX]</remarks>
        ReverbReflectionFactorAax = 2555915,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_DECAY_TIME_AAX]</remarks>
        ReverbDecayTimeAax = 2555916,
        /// <summary><b>[requires: AL_AAX_reverb]</b> </summary>
        /// <remarks>[originally: AL_REVERB_DECAY_TIME_HF_AAX]</remarks>
        ReverbDecayTimeHfAax = 2555917,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_DISTANCE_DELAY_MODEL_AAX]</remarks>
        DistanceDelayModelAax = 2609152,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_DELAY_AAX]</remarks>
        InverseDistanceDelayAax = 2609153,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        InverseDistanceDelayClampedAax = 2609154,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_DELAY_AAX]</remarks>
        LinearDistanceDelayAax = 2609155,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        LinearDistanceDelayClampedAax = 2609156,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_DELAY_AAX]</remarks>
        ExponentDistanceDelayAax = 2609157,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        ExponentDistanceDelayClampedAax = 2609158,
    }
    public enum AmbisonicLayout : uint
    {
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_FUMA_SOFT]</remarks>
        FumaSoft = 0,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_ACN_SOFT]</remarks>
        AcnSoft = 1,
    }
    public enum AmbisonicScaling : uint
    {
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_SN3D_SOFT]</remarks>
        SN3DSoft = 1,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> </summary>
        /// <remarks>[originally: AL_N3D_SOFT]</remarks>
        N3DSoft = 2,
    }
    public enum AutoWahParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_ATTACK_TIME]</remarks>
        AutowahAttackTime = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RELEASE_TIME]</remarks>
        AutowahReleaseTime = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RESONANCE]</remarks>
        AutowahResonance = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_PEAK_GAIN]</remarks>
        AutowahPeakGain = 4,
    }
    public enum AuxEffectSlotGetPNameB : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_AUXILIARY_SEND_AUTO]</remarks>
        EffectslotAuxiliarySendAuto = 3,
    }
    public enum AuxEffectSlotGetPNameBV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_AUXILIARY_SEND_AUTO]</remarks>
        EffectslotAuxiliarySendAuto = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotf" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotfDirect" /></summary>
    public enum AuxEffectSlotGetPNameF : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_GAIN]</remarks>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotfv" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotfvDirect" /></summary>
    public enum AuxEffectSlotGetPNameFV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_GAIN]</remarks>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSloti" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotiDirect" /></summary>
    public enum AuxEffectSlotGetPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_EFFECT]</remarks>
        EffectslotEffect = 1,
        /// <summary><b>[requires: AL_SOFT_effect_target]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_TARGET_SOFT]</remarks>
        EffectslotTargetSoft = 6556,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotiv" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotivDirect" /></summary>
    public enum AuxEffectSlotGetPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_EFFECT]</remarks>
        EffectslotEffect = 1,
    }
    public enum AuxEffectSlotPNameB : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_AUXILIARY_SEND_AUTO]</remarks>
        EffectslotAuxiliarySendAuto = 3,
    }
    public enum AuxEffectSlotPNameBV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_AUXILIARY_SEND_AUTO]</remarks>
        EffectslotAuxiliarySendAuto = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotf" />, <see cref="AL.EXT.AuxiliaryEffectSlotfDirect" /></summary>
    public enum AuxEffectSlotPNameF : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_GAIN]</remarks>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotfv" />, <see cref="AL.EXT.AuxiliaryEffectSlotfvDirect" /></summary>
    public enum AuxEffectSlotPNameFV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_GAIN]</remarks>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSloti" />, <see cref="AL.EXT.AuxiliaryEffectSlotiDirect" /></summary>
    public enum AuxEffectSlotPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_EFFECT]</remarks>
        EffectslotEffect = 1,
        /// <summary><b>[requires: AL_SOFT_effect_target]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_TARGET_SOFT]</remarks>
        EffectslotTargetSoft = 6556,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotiv" />, <see cref="AL.EXT.AuxiliaryEffectSlotivDirect" /></summary>
    public enum AuxEffectSlotPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECTSLOT_EFFECT]</remarks>
        EffectslotEffect = 1,
    }
    public enum BandpassParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAIN]</remarks>
        BandpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAINLF]</remarks>
        BandpassGainlf = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_BANDPASS_GAINHF]</remarks>
        BandpassGainhf = 3,
    }
    ///<summary>Used in <see cref="AL.GetBuffer3f" />, <see cref="AL.EXT.GetBuffer3fDirect" /></summary>
    public enum BufferGetPName3F : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetBuffer3i" />, <see cref="AL.EXT.GetBuffer3iDirect" /></summary>
    public enum BufferGetPName3I : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetBuffer3PtrDirectSOFT" />, <see cref="AL.SOFT.GetBuffer3PtrSOFT" /></summary>
    public enum BufferGetPName3Ptr : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetBufferf" />, <see cref="AL.EXT.GetBufferfDirect" /></summary>
    public enum BufferGetPNameF : uint
    {
        /// <summary><b>[requires: AL_SOFT_buffer_samples | AL_SOFT_buffer_sub_data]</b> <b>[property on: source][range: [0.0, ) ]</b><br/></summary>
        /// <remarks>[originally: AL_BYTE_RW_OFFSETS_SOFT]</remarks>
        ByteRwOffsetsSoft = 4145,
        /// <summary><b>[requires: AL_SOFT_buffer_samples | AL_SOFT_buffer_sub_data]</b> <b>[property on: source][range: [0.0, ) ]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_RW_OFFSETS_SOFT]</remarks>
        SampleRwOffsetsSoft = 4146,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_LENGTH_SOFT]</remarks>
        SecLengthSoft = 8203,
    }
    ///<summary>Used in <see cref="AL.GetBufferfv" />, <see cref="AL.EXT.GetBufferfvDirect" /></summary>
    public enum BufferGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetBufferi" />, <see cref="AL.EXT.GetBufferiDirect" /></summary>
    public enum BufferGetPNameI : uint
    {
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_LAYOUT_SOFT]</remarks>
        AmbisonicLayoutSoft = 6551,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_SCALING_SOFT]</remarks>
        AmbisonicScalingSoft = 6552,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer frequency/sample rate (query only).</summary>
        /// <remarks>[originally: AL_FREQUENCY]</remarks>
        Frequency = 8193,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer bits per sample (query only).</summary>
        /// <remarks>[originally: AL_BITS]</remarks>
        Bits = 8194,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer channel count (query only).</summary>
        /// <remarks>[originally: AL_CHANNELS]</remarks>
        Channels = 8195,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer data size in bytes (query only).</summary>
        /// <remarks>[originally: AL_SIZE]</remarks>
        Size = 8196,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_INTERNAL_FORMAT_SOFT]</remarks>
        InternalFormatSoft = 8200,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_BYTE_LENGTH_SOFT]</remarks>
        ByteLengthSoft = 8201,
        /// <summary><b>[requires: AL_SOFT_buffer_length_query | AL_SOFT_buffer_samples | AL_SOFT_source_length]</b> <b>[property on: buffer]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_LENGTH_SOFT]</remarks>
        SampleLengthSoft = 8202,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_UNPACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        PackBlockAlignmentSoft = 8205,
        /// <summary><b>[requires: AL_EXT_loop_points]</b> </summary>
        /// <remarks>[originally: AL_LOOP_POINTS_EXT]</remarks>
        LoopPointsExt = 8213,
    }
    ///<summary>Used in <see cref="AL.GetBufferiv" />, <see cref="AL.EXT.GetBufferivDirect" /></summary>
    public enum BufferGetPNameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer frequency/sample rate (query only).</summary>
        /// <remarks>[originally: AL_FREQUENCY]</remarks>
        Frequency = 8193,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer bits per sample (query only).</summary>
        /// <remarks>[originally: AL_BITS]</remarks>
        Bits = 8194,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer channel count (query only).</summary>
        /// <remarks>[originally: AL_CHANNELS]</remarks>
        Channels = 8195,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: buffer]</b><br/>Buffer data size in bytes (query only).</summary>
        /// <remarks>[originally: AL_SIZE]</remarks>
        Size = 8196,
        /// <summary><b>[requires: AL_SOFT_loop_points]</b> <b>[property on: buffer][default value: 0,0]</b><br/></summary>
        /// <remarks>[originally: AL_LOOP_POINTS_SOFT]</remarks>
        LoopPointsSoft = 8213,
    }
    ///<summary>Used in <see cref="AL.EXT.GetBufferPtrDirectSOFT" />, <see cref="AL.SOFT.GetBufferPtrSOFT" /></summary>
    public enum BufferGetPNamePtr : uint
    {
        /// <summary><b>[requires: AL_SOFT_callback_buffer]</b> <b>[property on: buffer][default value: NULL]</b><br/></summary>
        /// <remarks>[originally: AL_BUFFER_CALLBACK_FUNCTION_SOFT]</remarks>
        BufferCallbackFunctionSoft = 6560,
        /// <summary><b>[requires: AL_SOFT_callback_buffer]</b> <b>[property on: buffer][default value: NULL]</b><br/></summary>
        /// <remarks>[originally: AL_BUFFER_CALLBACK_USER_PARAM_SOFT]</remarks>
        BufferCallbackUserParamSoft = 6561,
    }
    ///<summary>Used in <see cref="AL.EXT.GetBufferPtrvDirectSOFT" />, <see cref="AL.SOFT.GetBufferPtrvSOFT" /></summary>
    public enum BufferGetPNamePtrV : uint
    {
    }
    ///<summary>Used in <see cref="AL.Buffer3f" />, <see cref="AL.EXT.Buffer3fDirect" /></summary>
    public enum BufferPName3F : uint
    {
    }
    ///<summary>Used in <see cref="AL.Buffer3i" />, <see cref="AL.EXT.Buffer3iDirect" /></summary>
    public enum BufferPName3I : uint
    {
    }
    ///<summary>Used in <see cref="AL.Bufferf" />, <see cref="AL.EXT.BufferfDirect" /></summary>
    public enum BufferPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.Bufferfv" />, <see cref="AL.EXT.BufferfvDirect" /></summary>
    public enum BufferPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.Bufferi" />, <see cref="AL.EXT.BufferiDirect" /></summary>
    public enum BufferPNameI : uint
    {
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_LAYOUT_SOFT]</remarks>
        AmbisonicLayoutSoft = 6551,
        /// <summary><b>[requires: AL_SOFT_bformat_ex]</b> <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_AMBISONIC_SCALING_SOFT]</remarks>
        AmbisonicScalingSoft = 6552,
        /// <summary><b>[requires: AL_SOFT_bformat_hoa]</b> <b>[property on: buffer][range: [1, 14] ][default value: 1]</b><br/></summary>
        /// <remarks>[originally: AL_UNPACK_AMBISONIC_ORDER_SOFT]</remarks>
        UnpackAmbisonicOrderSoft = 6557,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_UNPACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary><b>[requires: AL_SOFT_block_alignment]</b> <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PACK_BLOCK_ALIGNMENT_SOFT]</remarks>
        PackBlockAlignmentSoft = 8205,
        /// <summary><b>[requires: AL_EXT_loop_points]</b> </summary>
        /// <remarks>[originally: AL_LOOP_POINTS_EXT]</remarks>
        LoopPointsExt = 8213,
    }
    ///<summary>Used in <see cref="AL.Bufferiv" />, <see cref="AL.EXT.BufferivDirect" /></summary>
    public enum BufferPNameIV : uint
    {
        /// <summary><b>[requires: AL_SOFT_loop_points]</b> <b>[property on: buffer][default value: 0,0]</b><br/></summary>
        /// <remarks>[originally: AL_LOOP_POINTS_SOFT]</remarks>
        LoopPointsSoft = 8213,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.BufferSubSamplesDirectSOFT" />, ...</summary>
    public enum Channels : uint
    {
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO_SOFT]</remarks>
        MonoSoft = 5376,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO_SOFT]</remarks>
        StereoSoft = 5377,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD_SOFT]</remarks>
        QuadSoft = 5378,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR_SOFT]</remarks>
        RearSoft = 5379,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_SOFT]</remarks>
        _5point1Soft = 5380,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_SOFT]</remarks>
        _6point1Soft = 5381,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_SOFT]</remarks>
        _7point1Soft = 5382,
    }
    public enum ChorusParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_WAVEFORM]</remarks>
        ChorusWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_PHASE]</remarks>
        ChorusPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_RATE]</remarks>
        ChorusRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DEPTH]</remarks>
        ChorusDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_FEEDBACK]</remarks>
        ChorusFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DELAY]</remarks>
        ChorusDelay = 6,
    }
    public enum CompressorParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_COMPRESSOR_ONOFF]</remarks>
        CompressorOnoff = 1,
    }
    public enum ContextAttribute : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_CONTEXT_FLAGS_EXT]</remarks>
        ContextFlagsExt = 6607,
    }
    public enum ContextFlags : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_CONTEXT_DEBUG_BIT_EXT]</remarks>
        ContextDebugBitExt = 1,
    }
    ///<summary>Used in <see cref="AL.EXT.GetDebugMessageLogDirectEXT" />, <see cref="AL.EXT.GetDebugMessageLogEXT" /></summary>
    public enum DebugSeverity : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DONT_CARE_EXT]</remarks>
        DontCareExt = 2,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_HIGH_EXT]</remarks>
        DebugSeverityHighExt = 6595,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_MEDIUM_EXT]</remarks>
        DebugSeverityMediumExt = 6596,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_LOW_EXT]</remarks>
        DebugSeverityLowExt = 6597,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SEVERITY_NOTIFICATION_EXT]</remarks>
        DebugSeverityNotificationExt = 6598,
    }
    ///<summary>Used in <see cref="AL.EXT.DebugMessageControlDirectEXT" />, <see cref="AL.EXT.DebugMessageControlEXT" />, <see cref="AL.EXT.DebugMessageInsertDirectEXT" />, ...</summary>
    public enum DebugSource : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DONT_CARE_EXT]</remarks>
        DontCareExt = 2,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_API_EXT]</remarks>
        DebugSourceApiExt = 6581,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT]</remarks>
        DebugSourceAudioSystemExt = 6582,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_THIRD_PARTY_EXT]</remarks>
        DebugSourceThirdPartyExt = 6583,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_APPLICATION_EXT]</remarks>
        DebugSourceApplicationExt = 6584,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_SOURCE_OTHER_EXT]</remarks>
        DebugSourceOtherExt = 6585,
    }
    ///<summary>Used in <see cref="AL.EXT.DebugMessageControlDirectEXT" />, <see cref="AL.EXT.DebugMessageControlEXT" />, <see cref="AL.EXT.DebugMessageInsertDirectEXT" />, ...</summary>
    public enum DebugType : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DONT_CARE_EXT]</remarks>
        DontCareExt = 2,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_ERROR_EXT]</remarks>
        DebugTypeErrorExt = 6586,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT]</remarks>
        DebugTypeDeprecatedBehaviorExt = 6587,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT]</remarks>
        DebugTypeUndefinedBehaviorExt = 6588,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PORTABILITY_EXT]</remarks>
        DebugTypePortabilityExt = 6589,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PERFORMANCE_EXT]</remarks>
        DebugTypePerformanceExt = 6590,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_MARKER_EXT]</remarks>
        DebugTypeMarkerExt = 6591,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_PUSH_GROUP_EXT]</remarks>
        DebugTypePushGroupExt = 6592,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_POP_GROUP_EXT]</remarks>
        DebugTypePopGroupExt = 6593,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_TYPE_OTHER_EXT]</remarks>
        DebugTypeOtherExt = 6594,
    }
    public enum DedicatedDialogueParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> <b>[property on: effect][default value: 1]</b><br/></summary>
        /// <remarks>[originally: AL_DEDICATED_GAIN]</remarks>
        DedicatedGain = 1,
    }
    public enum DedicatedLowFrequencyParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> <b>[property on: effect][default value: 1]</b><br/></summary>
        /// <remarks>[originally: AL_DEDICATED_GAIN]</remarks>
        DedicatedGain = 1,
    }
    public enum DirectChannelMode : uint
    {
        /// <summary><b>[requires: v1.0]</b> Boolean False.</summary>
        /// <remarks>[originally: AL_FALSE]</remarks>
        False = 0,
        /// <summary><b>[requires: AL_SOFT_direct_channels_remix]</b> </summary>
        /// <remarks>[originally: AL_DROP_UNMATCHED_SOFT]</remarks>
        DropUnmatchedSoft = 1,
        /// <summary><b>[requires: v1.0]</b> Boolean True.</summary>
        /// <remarks>[originally: AL_TRUE]</remarks>
        True = 1,
        /// <summary><b>[requires: AL_SOFT_direct_channels_remix]</b> </summary>
        /// <remarks>[originally: AL_REMIX_UNMATCHED_SOFT]</remarks>
        RemixUnmatchedSoft = 2,
    }
    ///<summary>Used in <see cref="AL.DistanceModel" />, <see cref="AL.EXT.DistanceModelDirect" /></summary>
    public enum DistanceModel : uint
    {
        /// <summary><b>[requires: v1.0]</b> No distance model or no buffer</summary>
        /// <remarks>[originally: AL_NONE]</remarks>
        None = 0,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE]</remarks>
        InverseDistance = 53249,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_CLAMPED]</remarks>
        InverseDistanceClamped = 53250,
        /// <summary><b>[requires: v1.1 | AL_EXT_LINEAR_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE]</remarks>
        LinearDistance = 53251,
        /// <summary><b>[requires: v1.1 | AL_EXT_LINEAR_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_CLAMPED]</remarks>
        LinearDistanceClamped = 53252,
        /// <summary><b>[requires: v1.1 | AL_EXT_EXPONENT_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE]</remarks>
        ExponentDistance = 53253,
        /// <summary><b>[requires: v1.1 | AL_EXT_EXPONENT_DISTANCE]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_CLAMPED]</remarks>
        ExponentDistanceClamped = 53254,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_DELAY_AAX]</remarks>
        InverseDistanceDelayAax = 2609153,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_INVERSE_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        InverseDistanceDelayClampedAax = 2609154,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_DELAY_AAX]</remarks>
        LinearDistanceDelayAax = 2609155,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_LINEAR_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        LinearDistanceDelayClampedAax = 2609156,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_DELAY_AAX]</remarks>
        ExponentDistanceDelayAax = 2609157,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_EXPONENT_DISTANCE_DELAY_CLAMPED_AAX]</remarks>
        ExponentDistanceDelayClampedAax = 2609158,
    }
    public enum DistortionParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EDGE]</remarks>
        DistortionEdge = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_GAIN]</remarks>
        DistortionGain = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_LOWPASS_CUTOFF]</remarks>
        DistortionLowpassCutoff = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQCENTER]</remarks>
        DistortionEqcenter = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQBANDWIDTH]</remarks>
        DistortionEqbandwidth = 5,
    }
    ///<summary>Used in <see cref="AL.Creative.EAXGetBufferMode" />, <see cref="AL.EXT.EAXGetBufferModeDirect" />, <see cref="AL.Creative.EAXSetBufferMode" />, ...</summary>
    public enum EAXBufferMode : uint
    {
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_AUTOMATIC]</remarks>
        StorageAutomatic = 2105859,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_HARDWARE]</remarks>
        StorageHardware = 2105860,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_STORAGE_ACCESSIBLE]</remarks>
        StorageAccessible = 2105861,
    }
    public enum EAXReverbParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DENSITY]</remarks>
        EaxreverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DIFFUSION]</remarks>
        EaxreverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAIN]</remarks>
        EaxreverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINHF]</remarks>
        EaxreverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINLF]</remarks>
        EaxreverbGainlf = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_TIME]</remarks>
        EaxreverbDecayTime = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFRATIO]</remarks>
        EaxreverbDecayHfratio = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_LFRATIO]</remarks>
        EaxreverbDecayLfratio = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_GAIN]</remarks>
        EaxreverbReflectionsGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_DELAY]</remarks>
        EaxreverbReflectionsDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_PAN]</remarks>
        EaxreverbReflectionsPan = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_GAIN]</remarks>
        EaxreverbLateReverbGain = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_DELAY]</remarks>
        EaxreverbLateReverbDelay = 13,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_PAN]</remarks>
        EaxreverbLateReverbPan = 14,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_TIME]</remarks>
        EaxreverbEchoTime = 15,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_DEPTH]</remarks>
        EaxreverbEchoDepth = 16,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_TIME]</remarks>
        EaxreverbModulationTime = 17,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_DEPTH]</remarks>
        EaxreverbModulationDepth = 18,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_AIR_ABSORPTION_GAINHF]</remarks>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_HFREFERENCE]</remarks>
        EaxreverbHfreference = 20,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LFREFERENCE]</remarks>
        EaxreverbLfreference = 21,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        EaxreverbRoomRolloffFactor = 22,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFLIMIT]</remarks>
        EaxreverbDecayHflimit = 23,
    }
    public enum EchoParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DELAY]</remarks>
        EchoDelay = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_LRDELAY]</remarks>
        EchoLrdelay = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DAMPING]</remarks>
        EchoDamping = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_FEEDBACK]</remarks>
        EchoFeedback = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_SPREAD]</remarks>
        EchoSpread = 5,
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectf" />, <see cref="AL.EXT.GetEffectfDirect" /></summary>
    public enum EffectGetPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectfv" />, <see cref="AL.EXT.GetEffectfvDirect" /></summary>
    public enum EffectGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffecti" />, <see cref="AL.EXT.GetEffectiDirect" /></summary>
    public enum EffectGetPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECT_TYPE]</remarks>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectiv" />, <see cref="AL.EXT.GetEffectivDirect" /></summary>
    public enum EffectGetPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECT_TYPE]</remarks>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectf" />, <see cref="AL.EXT.EffectfDirect" /></summary>
    public enum EffectPNameF : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_ATTACK_TIME]</remarks>
        AutowahAttackTime = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EDGE]</remarks>
        DistortionEdge = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DENSITY]</remarks>
        EaxreverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DELAY]</remarks>
        EchoDelay = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_GAIN]</remarks>
        EqualizerLowGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_FREQUENCY]</remarks>
        FrequencyShifterFrequency = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DENSITY]</remarks>
        ReverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_FREQUENCY]</remarks>
        RingModulatorFrequency = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RELEASE_TIME]</remarks>
        AutowahReleaseTime = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_PHASE]</remarks>
        ChorusPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_GAIN]</remarks>
        DistortionGain = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DIFFUSION]</remarks>
        EaxreverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_LRDELAY]</remarks>
        EchoLrdelay = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_CUTOFF]</remarks>
        EqualizerLowCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_PHASE]</remarks>
        FlangerPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DIFFUSION]</remarks>
        ReverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_HIGHPASS_CUTOFF]</remarks>
        RingModulatorHighpassCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_RESONANCE]</remarks>
        AutowahResonance = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_RATE]</remarks>
        ChorusRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_LOWPASS_CUTOFF]</remarks>
        DistortionLowpassCutoff = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAIN]</remarks>
        EaxreverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_DAMPING]</remarks>
        EchoDamping = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_GAIN]</remarks>
        EqualizerMid1Gain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_RATE]</remarks>
        FlangerRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAIN]</remarks>
        ReverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/></summary>
        /// <remarks>[originally: AL_AUTOWAH_PEAK_GAIN]</remarks>
        AutowahPeakGain = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DEPTH]</remarks>
        ChorusDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQCENTER]</remarks>
        DistortionEqcenter = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINHF]</remarks>
        EaxreverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_FEEDBACK]</remarks>
        EchoFeedback = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_CENTER]</remarks>
        EqualizerMid1Center = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DEPTH]</remarks>
        FlangerDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAINHF]</remarks>
        ReverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_FEEDBACK]</remarks>
        ChorusFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/></summary>
        /// <remarks>[originally: AL_DISTORTION_EQBANDWIDTH]</remarks>
        DistortionEqbandwidth = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_GAINLF]</remarks>
        EaxreverbGainlf = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/></summary>
        /// <remarks>[originally: AL_ECHO_SPREAD]</remarks>
        EchoSpread = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_WIDTH]</remarks>
        EqualizerMid1Width = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_FEEDBACK]</remarks>
        FlangerFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_TIME]</remarks>
        ReverbDecayTime = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_DELAY]</remarks>
        ChorusDelay = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_TIME]</remarks>
        EaxreverbDecayTime = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_GAIN]</remarks>
        EqualizerMid2Gain = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DELAY]</remarks>
        FlangerDelay = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFRATIO]</remarks>
        ReverbDecayHfratio = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_RATE]</remarks>
        VocalMorpherRate = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFRATIO]</remarks>
        EaxreverbDecayHfratio = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_CENTER]</remarks>
        EqualizerMid2Center = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_GAIN]</remarks>
        ReverbReflectionsGain = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_LFRATIO]</remarks>
        EaxreverbDecayLfratio = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_WIDTH]</remarks>
        EqualizerMid2Width = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_DELAY]</remarks>
        ReverbReflectionsDelay = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_GAIN]</remarks>
        EaxreverbReflectionsGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_GAIN]</remarks>
        EqualizerHighGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_GAIN]</remarks>
        ReverbLateReverbGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_DELAY]</remarks>
        EaxreverbReflectionsDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_CUTOFF]</remarks>
        EqualizerHighCutoff = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_DELAY]</remarks>
        ReverbLateReverbDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_AIR_ABSORPTION_GAINHF]</remarks>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_GAIN]</remarks>
        EaxreverbLateReverbGain = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        ReverbRoomRolloffFactor = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_DELAY]</remarks>
        EaxreverbLateReverbDelay = 13,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_TIME]</remarks>
        EaxreverbEchoTime = 15,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ECHO_DEPTH]</remarks>
        EaxreverbEchoDepth = 16,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_TIME]</remarks>
        EaxreverbModulationTime = 17,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_MODULATION_DEPTH]</remarks>
        EaxreverbModulationDepth = 18,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_AIR_ABSORPTION_GAINHF]</remarks>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_HFREFERENCE]</remarks>
        EaxreverbHfreference = 20,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LFREFERENCE]</remarks>
        EaxreverbLfreference = 21,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        EaxreverbRoomRolloffFactor = 22,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectfv" />, <see cref="AL.EXT.EffectfvDirect" /></summary>
    public enum EffectPNameFV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_REFLECTIONS_PAN]</remarks>
        EaxreverbReflectionsPan = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_LATE_REVERB_PAN]</remarks>
        EaxreverbLateReverbPan = 14,
    }
    ///<summary>Used in <see cref="AL.EXT.Effecti" />, <see cref="AL.EXT.EffectiDirect" /></summary>
    public enum EffectPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_CHORUS_WAVEFORM]</remarks>
        ChorusWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_COMPRESSOR_ONOFF]</remarks>
        CompressorOnoff = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_WAVEFORM]</remarks>
        FlangerWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_COARSE_TUNE]</remarks>
        PitchShifterCoarseTune = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA]</remarks>
        VocalMorpherPhonemea = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_LEFT_DIRECTION]</remarks>
        FrequencyShifterLeftDirection = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_FINE_TUNE]</remarks>
        PitchShifterFineTune = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING]</remarks>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION]</remarks>
        FrequencyShifterRightDirection = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_WAVEFORM]</remarks>
        RingModulatorWaveform = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB]</remarks>
        VocalMorpherPhonemeb = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING]</remarks>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_WAVEFORM]</remarks>
        VocalMorpherWaveform = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFLIMIT]</remarks>
        ReverbDecayHflimit = 13,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_EAXREVERB_DECAY_HFLIMIT]</remarks>
        EaxreverbDecayHflimit = 23,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECT_TYPE]</remarks>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectiv" />, <see cref="AL.EXT.EffectivDirect" /></summary>
    public enum EffectPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_EFFECT_TYPE]</remarks>
        EffectType = 32769,
    }
    public enum EffectType : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_NULL]</remarks>
        EffectNull = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_REVERB]</remarks>
        EffectReverb = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_CHORUS]</remarks>
        EffectChorus = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DISTORTION]</remarks>
        EffectDistortion = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_ECHO]</remarks>
        EffectEcho = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_FLANGER]</remarks>
        EffectFlanger = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_FREQUENCY_SHIFTER]</remarks>
        EffectFrequencyShifter = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_VOCAL_MORPHER]</remarks>
        EffectVocalMorpher = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_PITCH_SHIFTER]</remarks>
        EffectPitchShifter = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_RING_MODULATOR]</remarks>
        EffectRingModulator = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_AUTOWAH]</remarks>
        EffectAutowah = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_COMPRESSOR]</remarks>
        EffectCompressor = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EQUALIZER]</remarks>
        EffectEqualizer = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EAXREVERB]</remarks>
        EffectEaxreverb = 32768,
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT]</remarks>
        EffectDedicatedLowFrequencyEffect = 36864,
        /// <summary><b>[requires: ALC_EXT_DEDICATED]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_DEDICATED_DIALOGUE]</remarks>
        EffectDedicatedDialogue = 36865,
    }
    ///<summary>Used in <see cref="AL.Disable" />, <see cref="AL.Enable" />, <see cref="AL.IsEnabled" />, ...</summary>
    public enum EnableCap : uint
    {
        /// <summary><b>[requires: AL_EXT_source_distance_model]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_DISTANCE_MODEL]</remarks>
        SourceDistanceModel = 512,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_OUTPUT_EXT]</remarks>
        DebugOutputExt = 6578,
        /// <summary><b>[requires: ALC_MAC_OSX_CONVERT_DATA_UPON_LOADING]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_CONVERT_DATA_UPON_LOADING]</remarks>
        MacOsxConvertDataUponLoading = 61441,
        /// <summary><b>[requires: AL_AAX_distance_delay_model]</b> </summary>
        /// <remarks>[originally: AL_DISTANCE_DELAY_MODEL_AAX]</remarks>
        DistanceDelayModelAax = 2609152,
    }
    public enum EqualizerParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_GAIN]</remarks>
        EqualizerLowGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_LOW_CUTOFF]</remarks>
        EqualizerLowCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_GAIN]</remarks>
        EqualizerMid1Gain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_CENTER]</remarks>
        EqualizerMid1Center = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID1_WIDTH]</remarks>
        EqualizerMid1Width = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_GAIN]</remarks>
        EqualizerMid2Gain = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_CENTER]</remarks>
        EqualizerMid2Center = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_MID2_WIDTH]</remarks>
        EqualizerMid2Width = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_GAIN]</remarks>
        EqualizerHighGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/></summary>
        /// <remarks>[originally: AL_EQUALIZER_HIGH_CUTOFF]</remarks>
        EqualizerHighCutoff = 10,
    }
    ///<summary>Used in <see cref="AL.GetError" />, <see cref="AL.EXT.GetErrorDirect" />, <see cref="AL.EXT.SourceAddNotification" />, ...</summary>
    public enum ErrorCode : uint
    {
        /// <summary><b>[requires: v1.0]</b> No error.</summary>
        /// <remarks>[originally: AL_NO_ERROR]</remarks>
        NoError = 0,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_STACK_OVERFLOW_EXT]</remarks>
        StackOverflowExt = 6605,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_STACK_UNDERFLOW_EXT]</remarks>
        StackUnderflowExt = 6606,
        /// <summary><b>[requires: v1.0]</b> Invalid name (ID) passed to an AL call.</summary>
        /// <remarks>[originally: AL_INVALID_NAME]</remarks>
        InvalidName = 40961,
        /// <summary><b>[requires: v1.0]</b> Invalid enumeration passed to AL call.</summary>
        /// <remarks>[originally: AL_INVALID_ENUM]</remarks>
        InvalidEnum = 40962,
        /// <summary><b>[requires: v1.0]</b> Invalid value passed to AL call.</summary>
        /// <remarks>[originally: AL_INVALID_VALUE]</remarks>
        InvalidValue = 40963,
        /// <summary><b>[requires: v1.0]</b> Illegal AL call.</summary>
        /// <remarks>[originally: AL_INVALID_OPERATION]</remarks>
        InvalidOperation = 40964,
        /// <summary><b>[requires: v1.0]</b> Not enough memory to execute the AL call.</summary>
        /// <remarks>[originally: AL_OUT_OF_MEMORY]</remarks>
        OutOfMemory = 40965,
    }
    ///<summary>Used in <see cref="AL.EXT.EventControlDirectSOFT" />, <see cref="AL.SOFT.EventControlSOFT" /></summary>
    public enum EventType : uint
    {
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT]</remarks>
        EventTypeBufferCompletedSoft = 6564,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT]</remarks>
        EventTypeSourceStateChangedSoft = 6565,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_TYPE_DISCONNECTED_SOFT]</remarks>
        EventTypeDisconnectedSoft = 6566,
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilterf" />, <see cref="AL.EXT.GetFilterfDirect" /></summary>
    public enum FilterGetPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilterfv" />, <see cref="AL.EXT.GetFilterfvDirect" /></summary>
    public enum FilterGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilteri" />, <see cref="AL.EXT.GetFilteriDirect" /></summary>
    public enum FilterGetPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_FILTER_TYPE]</remarks>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilteriv" />, <see cref="AL.EXT.GetFilterivDirect" /></summary>
    public enum FilterGetPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_FILTER_TYPE]</remarks>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Filterf" />, <see cref="AL.EXT.FilterfDirect" /></summary>
    public enum FilterPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.Filterfv" />, <see cref="AL.EXT.FilterfvDirect" /></summary>
    public enum FilterPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.Filteri" />, <see cref="AL.EXT.FilteriDirect" /></summary>
    public enum FilterPNameI : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_FILTER_TYPE]</remarks>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Filteriv" />, <see cref="AL.EXT.FilterivDirect" /></summary>
    public enum FilterPNameIV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_FILTER_TYPE]</remarks>
        FilterType = 32769,
    }
    public enum FilterType : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_NULL]</remarks>
        FilterNull = 0,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_LOWPASS]</remarks>
        FilterLowpass = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_HIGHPASS]</remarks>
        FilterHighpass = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> </summary>
        /// <remarks>[originally: AL_FILTER_BANDPASS]</remarks>
        FilterBandpass = 3,
    }
    public enum FlangerParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_WAVEFORM]</remarks>
        FlangerWaveform = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_PHASE]</remarks>
        FlangerPhase = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_RATE]</remarks>
        FlangerRate = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DEPTH]</remarks>
        FlangerDepth = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_FEEDBACK]</remarks>
        FlangerFeedback = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/></summary>
        /// <remarks>[originally: AL_FLANGER_DELAY]</remarks>
        FlangerDelay = 6,
    }
    public enum FoldbackEvent : uint
    {
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_START]</remarks>
        FoldbackEventStart = 16657,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_BLOCK]</remarks>
        FoldbackEventBlock = 16658,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_EVENT_STOP]</remarks>
        FoldbackEventStop = 16659,
    }
    ///<summary>Used in <see cref="AL.EXT.RequestFoldbackStart" />, <see cref="AL.EXT.RequestFoldbackStartDirect" /></summary>
    public enum FoldbackMode : uint
    {
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_MODE_MONO]</remarks>
        FoldbackModeMono = 16641,
        /// <summary><b>[requires: AL_EXT_FOLDBACK]</b> </summary>
        /// <remarks>[originally: AL_FOLDBACK_MODE_STEREO]</remarks>
        FoldbackModeStereo = 16642,
    }
    ///<summary>Used in <see cref="AL.BufferData" />, <see cref="AL.EXT.BufferCallbackDirectSOFT" />, <see cref="AL.SOFT.BufferCallbackSOFT" />, ...</summary>
    public enum Format : uint
    {
        /// <summary><b>[requires: v1.0]</b> Unsigned 8-bit mono buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_MONO8]</remarks>
        Mono8 = 4352,
        /// <summary><b>[requires: v1.0]</b> Signed 16-bit mono buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_MONO16]</remarks>
        Mono16 = 4353,
        /// <summary><b>[requires: v1.0]</b> Unsigned 8-bit stereo buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_STEREO8]</remarks>
        Stereo8 = 4354,
        /// <summary><b>[requires: v1.0]</b> Signed 16-bit stereo buffer format.</summary>
        /// <remarks>[originally: AL_FORMAT_STEREO16]</remarks>
        Stereo16 = 4355,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD8]</remarks>
        Quad8 = 4612,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD16]</remarks>
        Quad16 = 4613,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD32]</remarks>
        Quad32 = 4614,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR8]</remarks>
        Rear8 = 4615,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR16]</remarks>
        Rear16 = 4616,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR32]</remarks>
        Rear32 = 4617,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN8]</remarks>
        _51chn8 = 4618,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN16]</remarks>
        _51chn16 = 4619,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN32]</remarks>
        _51chn32 = 4620,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN8]</remarks>
        _61chn8 = 4621,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN16]</remarks>
        _61chn16 = 4622,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN32]</remarks>
        _61chn32 = 4623,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN8]</remarks>
        _71chn8 = 4624,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN16]</remarks>
        _71chn16 = 4625,
        /// <summary><b>[requires: AL_EXT_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN32]</remarks>
        _71chn32 = 4626,
        /// <summary><b>[requires: AL_EXT_IMA4]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_IMA4]</remarks>
        MonoIMA4 = 4864,
        /// <summary><b>[requires: AL_EXT_IMA4]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_IMA4]</remarks>
        StereoIMA4 = 4865,
        /// <summary><b>[requires: AL_SOFT_MSADPCM]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MSADPCM_SOFT]</remarks>
        MonoMSADPCMSoft = 4866,
        /// <summary><b>[requires: AL_SOFT_MSADPCM]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MSADPCM_SOFT]</remarks>
        StereoMSADPCMSoft = 4867,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN8_SOFT]</remarks>
        UHJ2chn8Soft = 6562,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN16_SOFT]</remarks>
        UHJ2chn16Soft = 6563,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_FLOAT32_SOFT]</remarks>
        UHJ2chnFloat32Soft = 6564,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN8_SOFT]</remarks>
        UHJ3chn8Soft = 6565,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN16_SOFT]</remarks>
        UHJ3chn16Soft = 6566,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_FLOAT32_SOFT]</remarks>
        UHJ3chnFloat32Soft = 6567,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN8_SOFT]</remarks>
        UHJ4chn8Soft = 6568,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN16_SOFT]</remarks>
        UHJ4chn16Soft = 6569,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_FLOAT32_SOFT]</remarks>
        UHJ4chnFloat32Soft = 6570,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_MULAW_SOFT]</remarks>
        UHJ2chnMULAWSoft = 6579,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_ALAW_SOFT]</remarks>
        UHJ2chnALAWSoft = 6580,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_IMA4_SOFT]</remarks>
        UHJ2chnIMA4Soft = 6581,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ2CHN_MSADPCM_SOFT]</remarks>
        UHJ2chnMSADPCMSoft = 6582,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_MULAW_SOFT]</remarks>
        UHJ3chnMULAWSoft = 6583,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ3CHN_ALAW_SOFT]</remarks>
        UHJ3chnALAWSoft = 6584,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_MULAW_SOFT]</remarks>
        UHJ4chnMULAWSoft = 6585,
        /// <summary><b>[requires: AL_SOFT_UHJ_ex]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_UHJ4CHN_ALAW_SOFT]</remarks>
        UHJ4chnALAWSoft = 6586,
        /// <summary><b>[requires: AL_LOKI_IMA_ADPCM_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_IMA_ADPCM_MONO16_EXT]</remarks>
        IMAADPCMMono16Ext = 65536,
        /// <summary><b>[requires: AL_LOKI_IMA_ADPCM_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_IMA_ADPCM_STEREO16_EXT]</remarks>
        IMAADPCMStereo16Ext = 65537,
        /// <summary><b>[requires: AL_LOKI_WAVE_format]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_WAVE_EXT]</remarks>
        WaveExt = 65538,
        /// <summary><b>[requires: AL_EXT_vorbis]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_VORBIS_EXT]</remarks>
        VorbisExt = 65539,
        /// <summary><b>[requires: AL_LOKI_quadriphonic]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD8_LOKI]</remarks>
        Quad8Loki = 65540,
        /// <summary><b>[requires: AL_LOKI_quadriphonic]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD16_LOKI]</remarks>
        Quad16Loki = 65541,
        /// <summary><b>[requires: AL_EXT_float32]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_FLOAT32]</remarks>
        MonoFloat32 = 65552,
        /// <summary><b>[requires: AL_EXT_float32]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_FLOAT32]</remarks>
        StereoFloat32 = 65553,
        /// <summary><b>[requires: AL_EXT_double]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_DOUBLE_EXT]</remarks>
        MonoDoubleExt = 65554,
        /// <summary><b>[requires: AL_EXT_double]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_DOUBLE_EXT]</remarks>
        StereoDoubleExt = 65555,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MULAW]</remarks>
        MonoMULAW = 65556,
        /// <summary><b>[requires: AL_EXT_MULAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_MULAW_EXT]</remarks>
        MonoMULAWExt = 65556,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MULAW]</remarks>
        StereoMULAW = 65557,
        /// <summary><b>[requires: AL_EXT_MULAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_MULAW_EXT]</remarks>
        StereoMULAWExt = 65557,
        /// <summary><b>[requires: AL_EXT_ALAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MONO_ALAW_EXT]</remarks>
        MonoALAWExt = 65558,
        /// <summary><b>[requires: AL_EXT_ALAW]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_STEREO_ALAW_EXT]</remarks>
        StereoALAWExt = 65559,
        /// <summary><b>[requires: AL_EXT_mp3]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_MP3_EXT]</remarks>
        Mp3Ext = 65568,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_QUAD_MULAW]</remarks>
        QuadMULAW = 65569,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_REAR_MULAW]</remarks>
        RearMULAW = 65570,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_51CHN_MULAW]</remarks>
        _51chnMULAW = 65571,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_61CHN_MULAW]</remarks>
        _61chnMULAW = 65572,
        /// <summary><b>[requires: AL_EXT_MULAW_MCFORMATS]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_71CHN_MULAW]</remarks>
        _71chnMULAW = 65573,
        /// <summary><b>[requires: AL_EXT_MULAW_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_MULAW]</remarks>
        Bformat2DMULAW = 65585,
        /// <summary><b>[requires: AL_EXT_MULAW_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_MULAW]</remarks>
        Bformat3DMULAW = 65586,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_8]</remarks>
        Bformat2D8 = 131105,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_16]</remarks>
        Bformat2D16 = 131106,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT2D_FLOAT32]</remarks>
        Bformat2DFloat32 = 131107,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_8]</remarks>
        Bformat3D8 = 131121,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_16]</remarks>
        Bformat3D16 = 131122,
        /// <summary><b>[requires: AL_EXT_BFORMAT]</b> </summary>
        /// <remarks>[originally: AL_FORMAT_BFORMAT3D_FLOAT32]</remarks>
        Bformat3DFloat32 = 131123,
    }
    public enum FrequencyShifterParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_FREQUENCY]</remarks>
        FrequencyShifterFrequency = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_LEFT_DIRECTION]</remarks>
        FrequencyShifterLeftDirection = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/></summary>
        /// <remarks>[originally: AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION]</remarks>
        FrequencyShifterRightDirection = 3,
    }
    ///<summary>Used in <see cref="AL.GetBoolean" />, <see cref="AL.EXT.GetBooleanDirect" /></summary>
    public enum GetPNameB : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        DebugLoggedMessagesExt = 6599,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT]</remarks>
        DebugNextLoggedMessageLengthExt = 6600,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_MESSAGE_LENGTH_EXT]</remarks>
        MaxDebugMessageLengthExt = 6601,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        MaxDebugLoggedMessagesExt = 6602,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT]</remarks>
        MaxDebugGroupStackDepthExt = 6603,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_LABEL_LENGTH_EXT]</remarks>
        MaxLabelLengthExt = 6604,
        /// <summary><b>[requires: AL_SOFT_gain_clamp_ex]</b> </summary>
        /// <remarks>[originally: AL_GAIN_LIMIT_SOFT]</remarks>
        GainLimitSoft = 8206,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetBooleanv" />, <see cref="AL.EXT.GetBooleanvDirect" /></summary>
    public enum GetPNameBV : uint
    {
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetDouble" />, <see cref="AL.EXT.GetDoubleDirect" /></summary>
    public enum GetPNameD : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        DebugLoggedMessagesExt = 6599,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT]</remarks>
        DebugNextLoggedMessageLengthExt = 6600,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_MESSAGE_LENGTH_EXT]</remarks>
        MaxDebugMessageLengthExt = 6601,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        MaxDebugLoggedMessagesExt = 6602,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT]</remarks>
        MaxDebugGroupStackDepthExt = 6603,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_LABEL_LENGTH_EXT]</remarks>
        MaxLabelLengthExt = 6604,
        /// <summary><b>[requires: AL_SOFT_gain_clamp_ex]</b> </summary>
        /// <remarks>[originally: AL_GAIN_LIMIT_SOFT]</remarks>
        GainLimitSoft = 8206,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetDoublev" />, <see cref="AL.EXT.GetDoublevDirect" /></summary>
    public enum GetPNameDV : uint
    {
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetFloat" />, <see cref="AL.EXT.GetFloatDirect" /></summary>
    public enum GetPNameF : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        DebugLoggedMessagesExt = 6599,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT]</remarks>
        DebugNextLoggedMessageLengthExt = 6600,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_MESSAGE_LENGTH_EXT]</remarks>
        MaxDebugMessageLengthExt = 6601,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        MaxDebugLoggedMessagesExt = 6602,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT]</remarks>
        MaxDebugGroupStackDepthExt = 6603,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_LABEL_LENGTH_EXT]</remarks>
        MaxLabelLengthExt = 6604,
        /// <summary><b>[requires: AL_SOFT_gain_clamp_ex]</b> </summary>
        /// <remarks>[originally: AL_GAIN_LIMIT_SOFT]</remarks>
        GainLimitSoft = 8206,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetFloatv" />, <see cref="AL.EXT.GetFloatvDirect" /></summary>
    public enum GetPNameFV : uint
    {
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetInteger" />, <see cref="AL.EXT.GetIntegerDirect" /></summary>
    public enum GetPNameI : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_NUM_RESAMPLERS_SOFT]</remarks>
        NumResamplersSoft = 4624,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        DebugLoggedMessagesExt = 6599,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT]</remarks>
        DebugNextLoggedMessageLengthExt = 6600,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_MESSAGE_LENGTH_EXT]</remarks>
        MaxDebugMessageLengthExt = 6601,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_LOGGED_MESSAGES_EXT]</remarks>
        MaxDebugLoggedMessagesExt = 6602,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT]</remarks>
        MaxDebugGroupStackDepthExt = 6603,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_MAX_LABEL_LENGTH_EXT]</remarks>
        MaxLabelLengthExt = 6604,
        /// <summary><b>[requires: AL_SOFT_gain_clamp_ex]</b> </summary>
        /// <remarks>[originally: AL_GAIN_LIMIT_SOFT]</remarks>
        GainLimitSoft = 8206,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_EAX_RAM_SIZE]</remarks>
        EaxRamSize = 2105857,
        /// <summary><b>[requires: EAX-RAM]</b> </summary>
        /// <remarks>[originally: AL_EAX_RAM_FREE]</remarks>
        EaxRamFree = 2105858,
    }
    ///<summary>Used in <see cref="AL.GetIntegerv" />, <see cref="AL.EXT.GetIntegervDirect" /></summary>
    public enum GetPNameIV : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_NUM_RESAMPLERS_SOFT]</remarks>
        NumResamplersSoft = 4624,
        /// <summary><b>[requires: AL_SOFT_deferred_updates]</b> </summary>
        /// <remarks>[originally: AL_DEFERRED_UPDATES_SOFT]</remarks>
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.EXT.GetPointerDirectEXT" />, <see cref="AL.EXT.GetPointerDirectSOFT" />, <see cref="AL.EXT.GetPointerEXT" />, ...</summary>
    public enum GetPNamePtr : uint
    {
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_CALLBACK_FUNCTION_SOFT]</remarks>
        EventCallbackFunctionSoft = 6562,
        /// <summary><b>[requires: AL_SOFT_events]</b> </summary>
        /// <remarks>[originally: AL_EVENT_CALLBACK_USER_PARAM_SOFT]</remarks>
        EventCallbackUserParamSoft = 6563,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_CALLBACK_FUNCTION_EXT]</remarks>
        DebugCallbackFunctionExt = 6579,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_DEBUG_CALLBACK_USER_PARAM_EXT]</remarks>
        DebugCallbackUserParamExt = 6580,
    }
    ///<summary>Used in <see cref="AL.EXT.GetPointervDirectSOFT" />, <see cref="AL.SOFT.GetPointervSOFT" /></summary>
    public enum GetPNamePtrV : uint
    {
    }
    public enum HighpassParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_HIGHPASS_GAIN]</remarks>
        HighpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_HIGHPASS_GAINLF]</remarks>
        HighpassGainlf = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetStringiDirectSOFT" />, <see cref="AL.SOFT.GetStringiSOFT" /></summary>
    public enum IndexedStringName : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_RESAMPLER_NAME_SOFT]</remarks>
        ResamplerNameSoft = 4627,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.IsBufferFormatSupportedDirectSOFT" />, ...</summary>
    public enum InternalFormat : uint
    {
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO8_SOFT]</remarks>
        Mono8Soft = 4352,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO16_SOFT]</remarks>
        Mono16Soft = 4353,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO8_SOFT]</remarks>
        Stereo8Soft = 4354,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO16_SOFT]</remarks>
        Stereo16Soft = 4355,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD8_SOFT]</remarks>
        Quad8Soft = 4612,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD16_SOFT]</remarks>
        Quad16Soft = 4613,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_QUAD32F_SOFT]</remarks>
        Quad32fSoft = 4614,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR8_SOFT]</remarks>
        Rear8Soft = 4615,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR16_SOFT]</remarks>
        Rear16Soft = 4616,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_REAR32F_SOFT]</remarks>
        Rear32fSoft = 4617,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_8_SOFT]</remarks>
        _5point18Soft = 4618,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_16_SOFT]</remarks>
        _5point116Soft = 4619,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_5POINT1_32F_SOFT]</remarks>
        _5point132fSoft = 4620,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_8_SOFT]</remarks>
        _6point18Soft = 4621,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_16_SOFT]</remarks>
        _6point116Soft = 4622,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_6POINT1_32F_SOFT]</remarks>
        _6point132fSoft = 4623,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_8_SOFT]</remarks>
        _7point18Soft = 4624,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_16_SOFT]</remarks>
        _7point116Soft = 4625,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_7POINT1_32F_SOFT]</remarks>
        _7point132fSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_MONO32F_SOFT]</remarks>
        Mono32fSoft = 65552,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_STEREO32F_SOFT]</remarks>
        Stereo32fSoft = 65553,
    }
    ///<summary>Used in <see cref="AL.GetListener3f" />, <see cref="AL.EXT.GetListener3fDirect" /></summary>
    public enum ListenerGetPName3F : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetListener3i" />, <see cref="AL.EXT.GetListener3iDirect" /></summary>
    public enum ListenerGetPName3I : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetListenerf" />, <see cref="AL.EXT.GetListenerfDirect" /></summary>
    public enum ListenerGetPNameF : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_METERS_PER_UNIT]</remarks>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.GetListenerfv" />, <see cref="AL.EXT.GetListenerfvDirect" /></summary>
    public enum ListenerGetPNameFV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
        /// Listener orientation.
        /// 
        ///                 Effectively two three dimensional vectors. The first vector is the front (or
        ///                 "at") and the second is the top (or "up"). Both vectors are relative to the
        ///                 listener position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component of both vectors.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ORIENTATION]</remarks>
        Orientation = 4111,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_METERS_PER_UNIT]</remarks>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.GetListeneri" />, <see cref="AL.EXT.GetListeneriDirect" /></summary>
    public enum ListenerGetPNameI : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetListeneriv" />, <see cref="AL.EXT.GetListenerivDirect" /></summary>
    public enum ListenerGetPNameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
        /// Listener orientation.
        /// 
        ///                 Effectively two three dimensional vectors. The first vector is the front (or
        ///                 "at") and the second is the top (or "up"). Both vectors are relative to the
        ///                 listener position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component of both vectors.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ORIENTATION]</remarks>
        Orientation = 4111,
    }
    ///<summary>Used in <see cref="AL.Listener3f" />, <see cref="AL.EXT.Listener3fDirect" /></summary>
    public enum ListenerPName3F : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Listener3i" />, <see cref="AL.EXT.Listener3iDirect" /></summary>
    public enum ListenerPName3I : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Listenerf" />, <see cref="AL.EXT.ListenerfDirect" /></summary>
    public enum ListenerPNameF : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_METERS_PER_UNIT]</remarks>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.Listenerfv" />, <see cref="AL.EXT.ListenerfvDirect" /></summary>
    public enum ListenerPNameFV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
        /// Listener orientation.
        /// 
        ///                 Effectively two three dimensional vectors. The first vector is the front (or
        ///                 "at") and the second is the top (or "up"). Both vectors are relative to the
        ///                 listener position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component of both vectors.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ORIENTATION]</remarks>
        Orientation = 4111,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_METERS_PER_UNIT]</remarks>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.Listeneri" />, <see cref="AL.EXT.ListeneriDirect" /></summary>
    public enum ListenerPNameI : uint
    {
    }
    ///<summary>Used in <see cref="AL.Listeneriv" />, <see cref="AL.EXT.ListenerivDirect" /></summary>
    public enum ListenerPNameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
        /// Listener orientation.
        /// 
        ///                 Effectively two three dimensional vectors. The first vector is the front (or
        ///                 "at") and the second is the top (or "up"). Both vectors are relative to the
        ///                 listener position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component of both vectors.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ORIENTATION]</remarks>
        Orientation = 4111,
    }
    public enum LowpassParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_LOWPASS_GAIN]</remarks>
        LowpassGain = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_LOWPASS_GAINHF]</remarks>
        LowpassGainhf = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.MacOSXGetRenderChannelCount" />, <see cref="AL.EXT.MacOSXGetRenderChannelCountDirect" />, <see cref="AL.EXT.MacOSXRenderChannelCount" />, ...</summary>
    public enum MacOSXRenderChannelCount : uint
    {
        /// <summary><b>[requires: ALC_EXT_MAC_OSX]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_RENDER_CHANNEL_COUNT_STEREO]</remarks>
        MacOsxRenderChannelCountStereo = 1022,
        /// <summary><b>[requires: ALC_EXT_MAC_OSX]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_RENDER_CHANNEL_COUNT_MULTICHANNEL]</remarks>
        MacOsxRenderChannelCountMultichannel = 1023,
    }
    ///<summary>Used in <see cref="AL.EXT.SourceGetRenderingQuality" />, <see cref="AL.EXT.SourceGetRenderingQualityDirect" />, <see cref="AL.EXT.SourceRenderingQuality" />, ...</summary>
    public enum MacOSXSpatialRenderingQuality : uint
    {
        /// <summary><b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_SPATIAL_RENDERING_QUALITY_HIGH]</remarks>
        MacOsxSpatialRenderingQualityHigh = 1021,
        /// <summary><b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> </summary>
        /// <remarks>[originally: ALC_MAC_OSX_SPATIAL_RENDERING_QUALITY_LOW]</remarks>
        MacOsxSpatialRenderingQualityLow = 1023,
    }
    ///<summary>Used in <see cref="AL.EXT.GetObjectLabelDirectEXT" />, <see cref="AL.EXT.GetObjectLabelEXT" />, <see cref="AL.EXT.ObjectLabelDirectEXT" />, ...</summary>
    public enum ObjectType : uint
    {
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_BUFFER_EXT]</remarks>
        BufferExt = 4105,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_EXT]</remarks>
        SourceExt = 6608,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_FILTER_EXT]</remarks>
        FilterExt = 6609,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_EFFECT_EXT]</remarks>
        EffectExt = 6610,
        /// <summary><b>[requires: AL_EXT_debug]</b> </summary>
        /// <remarks>[originally: AL_AUXILIARY_EFFECT_SLOT_EXT]</remarks>
        AuxiliaryEffectSlotExt = 6611,
    }
    public enum PitchShifterParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_COARSE_TUNE]</remarks>
        PitchShifterCoarseTune = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_PITCH_SHIFTER_FINE_TUNE]</remarks>
        PitchShifterFineTune = 2,
    }
    public enum ReverbParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DENSITY]</remarks>
        ReverbDensity = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DIFFUSION]</remarks>
        ReverbDiffusion = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAIN]</remarks>
        ReverbGain = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_GAINHF]</remarks>
        ReverbGainhf = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_TIME]</remarks>
        ReverbDecayTime = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFRATIO]</remarks>
        ReverbDecayHfratio = 6,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_GAIN]</remarks>
        ReverbReflectionsGain = 7,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_REFLECTIONS_DELAY]</remarks>
        ReverbReflectionsDelay = 8,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_GAIN]</remarks>
        ReverbLateReverbGain = 9,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_LATE_REVERB_DELAY]</remarks>
        ReverbLateReverbDelay = 10,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_AIR_ABSORPTION_GAINHF]</remarks>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_ROOM_ROLLOFF_FACTOR]</remarks>
        ReverbRoomRolloffFactor = 12,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_REVERB_DECAY_HFLIMIT]</remarks>
        ReverbDecayHflimit = 13,
    }
    public enum RingModulatorParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_FREQUENCY]</remarks>
        RingModulatorFrequency = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_HIGHPASS_CUTOFF]</remarks>
        RingModulatorHighpassCutoff = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_RING_MODULATOR_WAVEFORM]</remarks>
        RingModulatorWaveform = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.BufferSubSamplesDirectSOFT" />, ...</summary>
    public enum SampleType : uint
    {
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_BYTE_SOFT]</remarks>
        ByteSoft = 5120,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_BYTE_SOFT]</remarks>
        UnsignedByteSoft = 5121,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_SHORT_SOFT]</remarks>
        ShortSoft = 5122,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_SHORT_SOFT]</remarks>
        UnsignedShortSoft = 5123,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_INT_SOFT]</remarks>
        IntSoft = 5124,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_INT_SOFT]</remarks>
        UnsignedIntSoft = 5125,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_FLOAT_SOFT]</remarks>
        FloatSoft = 5126,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_DOUBLE_SOFT]</remarks>
        DoubleSoft = 5127,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_BYTE3_SOFT]</remarks>
        Byte3Soft = 5128,
        /// <summary><b>[requires: AL_SOFT_buffer_samples]</b> </summary>
        /// <remarks>[originally: AL_UNSIGNED_BYTE3_SOFT]</remarks>
        UnsignedByte3Soft = 5129,
    }
    public enum SourceGetPameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSource3dDirectSOFT" />, <see cref="AL.SOFT.GetSource3dSOFT" /></summary>
    public enum SourceGetPName3D : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetSource3f" />, <see cref="AL.EXT.GetSource3fDirect" /></summary>
    public enum SourceGetPName3F : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetSource3i" />, <see cref="AL.EXT.GetSource3iDirect" /></summary>
    public enum SourceGetPName3I : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER]</remarks>
        AuxiliarySendFilter = 131078,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSource3i64DirectSOFT" />, <see cref="AL.SOFT.GetSource3i64SOFT" /></summary>
    public enum SourceGetPName3I64 : uint
    {
    }
    public enum SourceGetPNameB : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_RELATIVE]</remarks>
        SourceRelative = 514,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER_GAINHF_AUTO]</remarks>
        DirectFilterGainhfAuto = 131082,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAIN_AUTO]</remarks>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO]</remarks>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    public enum SourceGetPNameBV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER_GAINHF_AUTO]</remarks>
        DirectFilterGainhfAuto = 131082,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAIN_AUTO]</remarks>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO]</remarks>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcedDirectSOFT" />, <see cref="AL.SOFT.GetSourcedSOFT" /></summary>
    public enum SourceGetPNameD : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcedvDirectSOFT" />, <see cref="AL.SOFT.GetSourcedvSOFT" /></summary>
    public enum SourceGetPNameDV : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_OFFSET_LATENCY_SOFT]</remarks>
        SecOffsetLatencySoft = 4609,
        /// <summary><b>[requires: ALC_SOFT_device_clock]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_OFFSET_CLOCK_SOFT]</remarks>
        SecOffsetClockSoft = 4611,
    }
    ///<summary>Used in <see cref="AL.GetSourcef" />, <see cref="AL.EXT.GetSourcefDirect" /></summary>
    public enum SourceGetPNameF : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        /// <remarks>[originally: AL_PITCH]</remarks>
        Pitch = 4099,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MIN_GAIN]</remarks>
        MinGain = 4109,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_GAIN]</remarks>
        MaxGain = 4110,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_DISTANCE]</remarks>
        MaxDistance = 4131,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: AL_EXT_STEREO_ANGLES]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_ANGLES]</remarks>
        StereoAngles = 4144,
        /// <summary><b>[requires: AL_EXT_SOURCE_RADIUS]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RADIUS]</remarks>
        SourceRadius = 4145,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/></summary>
        /// <remarks>[originally: AL_SUPER_STEREO_WIDTH_SOFT]</remarks>
        SuperStereoWidthSoft = 6577,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_AIR_ABSORPTION_FACTOR]</remarks>
        AirAbsorptionFactor = 131079,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_ROOM_ROLLOFF_FACTOR]</remarks>
        RoomRolloffFactor = 131080,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAINHF]</remarks>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.GetSourcefv" />, <see cref="AL.EXT.GetSourcefvDirect" /></summary>
    public enum SourceGetPNameFV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        /// <remarks>[originally: AL_PITCH]</remarks>
        Pitch = 4099,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MIN_GAIN]</remarks>
        MinGain = 4109,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_GAIN]</remarks>
        MaxGain = 4110,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/></summary>
        /// <remarks>[originally: AL_SUPER_STEREO_WIDTH_SOFT]</remarks>
        SuperStereoWidthSoft = 6577,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_AIR_ABSORPTION_FACTOR]</remarks>
        AirAbsorptionFactor = 131079,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_ROOM_ROLLOFF_FACTOR]</remarks>
        RoomRolloffFactor = 131080,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAINHF]</remarks>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.GetSourcei" />, <see cref="AL.EXT.GetSourceiDirect" /></summary>
    public enum SourceGetPNameI : uint
    {
        /// <summary><b>[requires: AL_EXT_source_distance_model]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_DISTANCE_MODEL]</remarks>
        SourceDistanceModel = 512,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        /// <remarks>[originally: AL_LOOPING]</remarks>
        Looping = 4103,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        /// <remarks>[originally: AL_BUFFER]</remarks>
        Buffer = 4105,
        /// <summary><b>[requires: AL_LOKI_play_position]</b> </summary>
        /// <remarks>[originally: AL_BYTE_LOKI]</remarks>
        ByteLoki = 4108,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>Source state (query only).</summary>
        /// <remarks>[originally: AL_SOURCE_STATE]</remarks>
        SourceState = 4112,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_QUEUED]</remarks>
        BuffersQueued = 4117,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_PROCESSED]</remarks>
        BuffersProcessed = 4118,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_DISTANCE]</remarks>
        MaxDistance = 4131,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source type (query only).
        /// 
        ///                 A Source is Static if a Buffer has been attached using AL_BUFFER.
        /// 
        ///                 A Source is Streaming if one or more Buffers have been attached using
        ///                 alSourceQueueBuffers.
        /// 
        ///                 A Source is Undetermined when it has the NULL buffer attached using
        ///                 AL_BUFFER.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_TYPE]</remarks>
        SourceType = 4135,
        /// <summary><b>[requires: AL_SOFT_direct_channels]</b> <b>[property on: source][default value: AL_FALSE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_CHANNELS_SOFT]</remarks>
        DirectChannelsSoft = 4147,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_DEFAULT_RESAMPLER_SOFT]</remarks>
        DefaultResamplerSoft = 4625,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RESAMPLER_SOFT]</remarks>
        SourceResamplerSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_SPATIALIZE_SOFT]</remarks>
        SourceSpatializeSoft = 4628,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_MODE_SOFT]</remarks>
        StereoModeSoft = 6576,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER]</remarks>
        DirectFilter = 131077,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcei64DirectSOFT" />, <see cref="AL.SOFT.GetSourcei64SOFT" /></summary>
    public enum SourceGetPNameI64 : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcei64vDirectSOFT" />, <see cref="AL.SOFT.GetSourcei64vSOFT" /></summary>
    public enum SourceGetPNameI64V : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET_LATENCY_SOFT]</remarks>
        SampleOffsetLatencySoft = 4608,
        /// <summary><b>[requires: ALC_SOFT_device_clock]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET_CLOCK_SOFT]</remarks>
        SampleOffsetClockSoft = 4610,
    }
    ///<summary>Used in <see cref="AL.GetSourceiv" />, <see cref="AL.EXT.GetSourceivDirect" /></summary>
    public enum SourceGetPNameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        /// <remarks>[originally: AL_LOOPING]</remarks>
        Looping = 4103,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        /// <remarks>[originally: AL_BUFFER]</remarks>
        Buffer = 4105,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_QUEUED]</remarks>
        BuffersQueued = 4117,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_PROCESSED]</remarks>
        BuffersProcessed = 4118,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source type (query only).
        /// 
        ///                 A Source is Static if a Buffer has been attached using AL_BUFFER.
        /// 
        ///                 A Source is Streaming if one or more Buffers have been attached using
        ///                 alSourceQueueBuffers.
        /// 
        ///                 A Source is Undetermined when it has the NULL buffer attached using
        ///                 AL_BUFFER.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_TYPE]</remarks>
        SourceType = 4135,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_DEFAULT_RESAMPLER_SOFT]</remarks>
        DefaultResamplerSoft = 4625,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RESAMPLER_SOFT]</remarks>
        SourceResamplerSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_SPATIALIZE_SOFT]</remarks>
        SourceSpatializeSoft = 4628,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_MODE_SOFT]</remarks>
        StereoModeSoft = 6576,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER]</remarks>
        DirectFilter = 131077,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER]</remarks>
        AuxiliarySendFilter = 131078,
    }
    public enum SourceNotification : uint
    {
        /// <summary><b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> </summary>
        /// <remarks>[originally: AL_QUEUE_HAS_LOOPED]</remarks>
        QueueHasLooped = 36864,
    }
    ///<summary>Used in <see cref="AL.EXT.Source3dDirectSOFT" />, <see cref="AL.SOFT.Source3dSOFT" /></summary>
    public enum SourcePName3D : uint
    {
    }
    ///<summary>Used in <see cref="AL.Source3f" />, <see cref="AL.EXT.Source3fDirect" /></summary>
    public enum SourcePName3F : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Source3i" />, <see cref="AL.EXT.Source3iDirect" /></summary>
    public enum SourcePName3I : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER]</remarks>
        AuxiliarySendFilter = 131078,
    }
    ///<summary>Used in <see cref="AL.EXT.Source3i64DirectSOFT" />, <see cref="AL.SOFT.Source3i64SOFT" /></summary>
    public enum SourcePName3I64 : uint
    {
    }
    public enum SourcePNameB : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_RELATIVE]</remarks>
        SourceRelative = 514,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER_GAINHF_AUTO]</remarks>
        DirectFilterGainhfAuto = 131082,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAIN_AUTO]</remarks>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO]</remarks>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    public enum SourcePNameBV : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER_GAINHF_AUTO]</remarks>
        DirectFilterGainhfAuto = 131082,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAIN_AUTO]</remarks>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_TRUE]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO]</remarks>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    ///<summary>Used in <see cref="AL.EXT.SourcedDirectSOFT" />, <see cref="AL.SOFT.SourcedSOFT" /></summary>
    public enum SourcePNameD : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.SourcedvDirectSOFT" />, <see cref="AL.SOFT.SourcedvSOFT" /></summary>
    public enum SourcePNameDV : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SEC_OFFSET_LATENCY_SOFT]</remarks>
        SecOffsetLatencySoft = 4609,
    }
    ///<summary>Used in <see cref="AL.Sourcef" />, <see cref="AL.EXT.SourcefDirect" /></summary>
    public enum SourcePNameF : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        /// <remarks>[originally: AL_PITCH]</remarks>
        Pitch = 4099,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MIN_GAIN]</remarks>
        MinGain = 4109,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_GAIN]</remarks>
        MaxGain = 4110,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_DISTANCE]</remarks>
        MaxDistance = 4131,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: AL_EXT_STEREO_ANGLES]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_ANGLES]</remarks>
        StereoAngles = 4144,
        /// <summary><b>[requires: AL_EXT_SOURCE_RADIUS]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RADIUS]</remarks>
        SourceRadius = 4145,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/></summary>
        /// <remarks>[originally: AL_SUPER_STEREO_WIDTH_SOFT]</remarks>
        SuperStereoWidthSoft = 6577,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_AIR_ABSORPTION_FACTOR]</remarks>
        AirAbsorptionFactor = 131079,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_ROOM_ROLLOFF_FACTOR]</remarks>
        RoomRolloffFactor = 131080,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAINHF]</remarks>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.Sourcefv" />, <see cref="AL.EXT.SourcefvDirect" /></summary>
    public enum SourcePNameFV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        /// <remarks>[originally: AL_PITCH]</remarks>
        Pitch = 4099,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
        /// Source or listener gain.
        /// 
        ///                 For sources, an initial linear gain value (before attenuation is applied).
        ///                 For the listener, an output linear gain adjustment.
        /// 
        ///                 A value of 1.0 means unattenuated. Each division by 2 equals an attenuation
        ///                 of about -6dB. Each multiplication by 2 equals an amplification of about
        ///                 +6dB.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_GAIN]</remarks>
        Gain = 4106,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MIN_GAIN]</remarks>
        MinGain = 4109,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_GAIN]</remarks>
        MaxGain = 4110,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][range: [0.0, 1.0] ]</b><br/></summary>
        /// <remarks>[originally: AL_SUPER_STEREO_WIDTH_SOFT]</remarks>
        SuperStereoWidthSoft = 6577,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_AIR_ABSORPTION_FACTOR]</remarks>
        AirAbsorptionFactor = 131079,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/></summary>
        /// <remarks>[originally: AL_ROOM_ROLLOFF_FACTOR]</remarks>
        RoomRolloffFactor = 131080,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/></summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAINHF]</remarks>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.Sourcei" />, <see cref="AL.EXT.SourceiDirect" /></summary>
    public enum SourcePNameI : uint
    {
        /// <summary><b>[requires: AL_EXT_source_distance_model]</b> </summary>
        /// <remarks>[originally: AL_SOURCE_DISTANCE_MODEL]</remarks>
        SourceDistanceModel = 512,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        /// <remarks>[originally: AL_LOOPING]</remarks>
        Looping = 4103,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        /// <remarks>[originally: AL_BUFFER]</remarks>
        Buffer = 4105,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_QUEUED]</remarks>
        BuffersQueued = 4117,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_PROCESSED]</remarks>
        BuffersProcessed = 4118,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_MAX_DISTANCE]</remarks>
        MaxDistance = 4131,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source type (query only).
        /// 
        ///                 A Source is Static if a Buffer has been attached using AL_BUFFER.
        /// 
        ///                 A Source is Streaming if one or more Buffers have been attached using
        ///                 alSourceQueueBuffers.
        /// 
        ///                 A Source is Undetermined when it has the NULL buffer attached using
        ///                 AL_BUFFER.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_TYPE]</remarks>
        SourceType = 4135,
        /// <summary><b>[requires: AL_SOFT_direct_channels]</b> <b>[property on: source][default value: AL_FALSE]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_CHANNELS_SOFT]</remarks>
        DirectChannelsSoft = 4147,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_DEFAULT_RESAMPLER_SOFT]</remarks>
        DefaultResamplerSoft = 4625,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RESAMPLER_SOFT]</remarks>
        SourceResamplerSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_SPATIALIZE_SOFT]</remarks>
        SourceSpatializeSoft = 4628,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_MODE_SOFT]</remarks>
        StereoModeSoft = 6576,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER]</remarks>
        DirectFilter = 131077,
    }
    ///<summary>Used in <see cref="AL.EXT.Sourcei64DirectSOFT" />, <see cref="AL.SOFT.Sourcei64SOFT" /></summary>
    public enum SourcePNameI64 : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.Sourcei64vDirectSOFT" />, <see cref="AL.SOFT.Sourcei64vSOFT" /></summary>
    public enum SourcePNameI64V : uint
    {
        /// <summary><b>[requires: AL_SOFT_source_latency]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET_LATENCY_SOFT]</remarks>
        SampleOffsetLatencySoft = 4608,
    }
    ///<summary>Used in <see cref="AL.Sourceiv" />, <see cref="AL.EXT.SourceivDirect" /></summary>
    public enum SourcePNameIV : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_INNER_ANGLE]</remarks>
        ConeInnerAngle = 4097,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_ANGLE]</remarks>
        ConeOuterAngle = 4098,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener position.
        /// 
        ///                 The source or listener location in three dimensional space.
        /// 
        ///                 OpenAL uses a right handed coordinate system, like OpenGL, where with a
        ///                 default view, X points right (thumb), Y points up (index finger), and Z
        ///                 points towards the viewer/camera (middle finger).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_POSITION]</remarks>
        Position = 4100,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_DIRECTION]</remarks>
        Direction = 4101,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_VELOCITY]</remarks>
        Velocity = 4102,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        /// <remarks>[originally: AL_LOOPING]</remarks>
        Looping = 4103,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        /// <remarks>[originally: AL_BUFFER]</remarks>
        Buffer = 4105,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_QUEUED]</remarks>
        BuffersQueued = 4117,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_BUFFERS_PROCESSED]</remarks>
        BuffersProcessed = 4118,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_REFERENCE_DISTANCE]</remarks>
        ReferenceDistance = 4128,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_ROLLOFF_FACTOR]</remarks>
        RolloffFactor = 4129,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_CONE_OUTER_GAIN]</remarks>
        ConeOuterGain = 4130,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in seconds.</summary>
        /// <remarks>[originally: AL_SEC_OFFSET]</remarks>
        SecOffset = 4132,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in sample frames.</summary>
        /// <remarks>[originally: AL_SAMPLE_OFFSET]</remarks>
        SampleOffset = 4133,
        /// <summary><b>[requires: v1.1 | AL_EXT_OFFSET]</b> <b>[property on: source][range: [0, ) ]</b><br/>Source buffer offset, in bytes.</summary>
        /// <remarks>[originally: AL_BYTE_OFFSET]</remarks>
        ByteOffset = 4134,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: source]</b><br/>
        /// Source type (query only).
        /// 
        ///                 A Source is Static if a Buffer has been attached using AL_BUFFER.
        /// 
        ///                 A Source is Streaming if one or more Buffers have been attached using
        ///                 alSourceQueueBuffers.
        /// 
        ///                 A Source is Undetermined when it has the NULL buffer attached using
        ///                 AL_BUFFER.
        /// 
        /// </summary>
        /// <remarks>[originally: AL_SOURCE_TYPE]</remarks>
        SourceType = 4135,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> </summary>
        /// <remarks>[originally: AL_DEFAULT_RESAMPLER_SOFT]</remarks>
        DefaultResamplerSoft = 4625,
        /// <summary><b>[requires: AL_SOFT_source_resampler]</b> <b>[property on: source]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_RESAMPLER_SOFT]</remarks>
        SourceResamplerSoft = 4626,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_SOURCE_SPATIALIZE_SOFT]</remarks>
        SourceSpatializeSoft = 4628,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/></summary>
        /// <remarks>[originally: AL_STEREO_MODE_SOFT]</remarks>
        StereoModeSoft = 6576,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_DIRECT_FILTER]</remarks>
        DirectFilter = 131077,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: source][default value: AL_FILTER_NULL]</b><br/></summary>
        /// <remarks>[originally: AL_AUXILIARY_SEND_FILTER]</remarks>
        AuxiliarySendFilter = 131078,
    }
    public enum SourceSpatializeMode : uint
    {
        /// <summary><b>[requires: v1.0]</b> Boolean False.</summary>
        /// <remarks>[originally: AL_FALSE]</remarks>
        False = 0,
        /// <summary><b>[requires: v1.0]</b> Boolean True.</summary>
        /// <remarks>[originally: AL_TRUE]</remarks>
        True = 1,
        /// <summary><b>[requires: AL_SOFT_source_spatialize]</b> </summary>
        /// <remarks>[originally: AL_AUTO_SOFT]</remarks>
        AutoSoft = 2,
    }
    public enum SourceState : uint
    {
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_INITIAL]</remarks>
        Initial = 4113,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_PLAYING]</remarks>
        Playing = 4114,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_PAUSED]</remarks>
        Paused = 4115,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STOPPED]</remarks>
        Stopped = 4116,
    }
    public enum SourceType : uint
    {
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STATIC]</remarks>
        Static = 4136,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_STREAMING]</remarks>
        Streaming = 4137,
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks>[originally: AL_UNDETERMINED]</remarks>
        Undetermined = 4144,
    }
    public enum StereoMode : uint
    {
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_NORMAL_SOFT]</remarks>
        NormalSoft = 0,
        /// <summary><b>[requires: AL_SOFT_UHJ]</b> </summary>
        /// <remarks>[originally: AL_SUPER_STEREO_SOFT]</remarks>
        SuperStereoSoft = 1,
    }
    ///<summary>Used in <see cref="AL.GetString" />, <see cref="AL.EXT.GetStringDirect" /></summary>
    public enum StringName : uint
    {
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Vendor name.</summary>
        /// <remarks>[originally: AL_VENDOR]</remarks>
        Vendor = 45057,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Version.</summary>
        /// <remarks>[originally: AL_VERSION]</remarks>
        Version = 45058,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Renderer name.</summary>
        /// <remarks>[originally: AL_RENDERER]</remarks>
        Renderer = 45059,
        /// <summary><b>[requires: v1.0]</b> <b>[property on: context]</b><br/>Context string: Space-separated extension list.</summary>
        /// <remarks>[originally: AL_EXTENSIONS]</remarks>
        Extensions = 45060,
    }
    public enum VocalMorpherParameterName : uint
    {
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA]</remarks>
        VocalMorpherPhonemea = 1,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING]</remarks>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB]</remarks>
        VocalMorpherPhonemeb = 3,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING]</remarks>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_WAVEFORM]</remarks>
        VocalMorpherWaveform = 5,
        /// <summary><b>[requires: ALC_EXT_EFX]</b> <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/></summary>
        /// <remarks>[originally: AL_VOCAL_MORPHER_RATE]</remarks>
        VocalMorpherRate = 6,
    }
#pragma warning restore CA1069 // Enums values should not be duplicated
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore CS0419 // Ambiguous reference in cref attribute
}
