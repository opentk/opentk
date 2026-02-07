// This file is auto generated, do not edit.
using System;

namespace OpenTK.Audio.OpenAL
{
#pragma warning disable CA1069 // Enums values should not be duplicated
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS0419 // Ambiguous reference in cref attribute
    public enum All : uint
    {
        EffectFirstParameter = 0,
        EffectNull = 0,
        EffectslotNull = 0,
        /// <summary>
        /// Boolean False.
        /// </summary>
        False = 0,
        FilterFirstParameter = 0,
        FilterNull = 0,
        FumaSoft = 0,
        /// <summary>
        /// No error.
        /// </summary>
        NoError = 0,
        /// <summary>
        /// No distance model or no buffer
        /// </summary>
        None = 0,
        NormalSoft = 0,
        AcnSoft = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahAttackTime = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        BandpassGain = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        ChorusWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        CompressorOnoff = 1,
        ContextDebugBitExt = 1,
        /// <summary>
        /// <b>[property on: effect][default value: 1]</b><br/>
        /// </summary>
        DedicatedGain = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/>
        /// </summary>
        DistortionEdge = 1,
        DropUnmatchedSoft = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoDelay = 1,
        EffectReverb = 1,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectslotEffect = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerLowGain = 1,
        FilterLowpass = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        FlangerWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/>
        /// </summary>
        FrequencyShifterFrequency = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        HighpassGain = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        LowpassGain = 1,
        /// <summary>
        /// <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/>
        /// </summary>
        PitchShifterCoarseTune = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/>
        /// </summary>
        RingModulatorFrequency = 1,
        Sn3dSoft = 1,
        SuperStereoSoft = 1,
        /// <summary>
        /// Boolean True.
        /// </summary>
        True = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemea = 1,
        AutoSoft = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahReleaseTime = 2,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        BandpassGainlf = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/>
        /// </summary>
        ChorusPhase = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/>
        /// </summary>
        DistortionGain = 2,
        DontCareExt = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoLrdelay = 2,
        EffectChorus = 2,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EffectslotGain = 2,
        /// <summary>
        /// <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/>
        /// </summary>
        EqualizerLowCutoff = 2,
        FilterHighpass = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/>
        /// </summary>
        FlangerPhase = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterLeftDirection = 2,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        HighpassGainlf = 2,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        LowpassGainhf = 2,
        N3dSoft = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/>
        /// </summary>
        PitchShifterFineTune = 2,
        RemixUnmatchedSoft = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/>
        /// </summary>
        RingModulatorHighpassCutoff = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary>
        /// <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/>
        /// </summary>
        AutowahResonance = 3,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        BandpassGainhf = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/>
        /// </summary>
        ChorusRate = 3,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/>
        /// </summary>
        DistortionLowpassCutoff = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        EaxreverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoDamping = 3,
        EffectDistortion = 3,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/>
        /// </summary>
        EffectslotAuxiliarySendAuto = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Gain = 3,
        FilterBandpass = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/>
        /// </summary>
        FlangerRate = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterRightDirection = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        ReverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/>
        /// </summary>
        RingModulatorWaveform = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/>
        /// </summary>
        VocalMorpherPhonemeb = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/>
        /// </summary>
        AutowahPeakGain = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/>
        /// </summary>
        ChorusDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqcenter = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        EaxreverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoFeedback = 4,
        EffectEcho = 4,
        /// <summary>
        /// <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/>
        /// </summary>
        EqualizerMid1Center = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        FlangerDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        ReverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/>
        /// </summary>
        ChorusFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqbandwidth = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbGainlf = 5,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/>
        /// </summary>
        EchoSpread = 5,
        EffectFlanger = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Width = 5,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/>
        /// </summary>
        FlangerFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        ReverbDecayTime = 5,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/>
        /// </summary>
        VocalMorpherWaveform = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/>
        /// </summary>
        ChorusDelay = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        EaxreverbDecayTime = 6,
        EffectFrequencyShifter = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Gain = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/>
        /// </summary>
        FlangerDelay = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        ReverbDecayHfratio = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/>
        /// </summary>
        VocalMorpherRate = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        EaxreverbDecayHfratio = 7,
        EffectVocalMorpher = 7,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/>
        /// </summary>
        EqualizerMid2Center = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        ReverbReflectionsGain = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDecayLfratio = 8,
        EffectPitchShifter = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Width = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        ReverbReflectionsDelay = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        EaxreverbReflectionsGain = 9,
        EffectRingModulator = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerHighGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        ReverbLateReverbGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        EaxreverbReflectionsDelay = 10,
        EffectAutowah = 10,
        /// <summary>
        /// <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/>
        /// </summary>
        EqualizerHighCutoff = 10,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        ReverbLateReverbDelay = 10,
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbReflectionsPan = 11,
        EffectCompressor = 11,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        EaxreverbLateReverbGain = 12,
        EffectEqualizer = 12,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        ReverbRoomRolloffFactor = 12,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        EaxreverbLateReverbDelay = 13,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        ReverbDecayHflimit = 13,
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbLateReverbPan = 14,
        /// <summary>
        /// <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbEchoTime = 15,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbEchoDepth = 16,
        /// <summary>
        /// <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbModulationTime = 17,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbModulationDepth = 18,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/>
        /// </summary>
        EaxreverbHfreference = 20,
        /// <summary>
        /// <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/>
        /// </summary>
        EaxreverbLfreference = 21,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbRoomRolloffFactor = 22,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        EaxreverbDecayHflimit = 23,
        SourceDistanceModel = 512,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        SourceRelative = 514,
        MacOsxSpatialRenderingQualityHigh = 1021,
        MacOsxRenderChannelCountStereo = 1022,
        MacOsxRenderChannelCountMultichannel = 1023,
        MacOsxSpatialRenderingQualityLow = 1023,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        Pitch = 4099,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        Looping = 4103,
        /// <summary>
        /// <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        Buffer = 4105,
        BufferExt = 4105,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        ByteLoki = 4108,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MinGain = 4109,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MaxGain = 4110,
        /// <summary>
        /// <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
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
        Orientation = 4111,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source state (query only).
        /// </summary>
        SourceState = 4112,
        Initial = 4113,
        Playing = 4114,
        Paused = 4115,
        Stopped = 4116,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        BuffersQueued = 4117,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        BuffersProcessed = 4118,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        MaxDistance = 4131,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
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
        SourceType = 4135,
        Static = 4136,
        Streaming = 4137,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        StereoAngles = 4144,
        Undetermined = 4144,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ]</b><br/>
        /// </summary>
        ByteRwOffsetsSoft = 4145,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceRadius = 4145,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ]</b><br/>
        /// </summary>
        SampleRwOffsetsSoft = 4146,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// </summary>
        DirectChannelsSoft = 4147,
        /// <summary>
        /// Unsigned 8-bit mono buffer format.
        /// </summary>
        FormatMono8 = 4352,
        Mono8Soft = 4352,
        /// <summary>
        /// Signed 16-bit mono buffer format.
        /// </summary>
        FormatMono16 = 4353,
        Mono16Soft = 4353,
        /// <summary>
        /// Unsigned 8-bit stereo buffer format.
        /// </summary>
        FormatStereo8 = 4354,
        Stereo8Soft = 4354,
        /// <summary>
        /// Signed 16-bit stereo buffer format.
        /// </summary>
        FormatStereo16 = 4355,
        Stereo16Soft = 4355,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SampleOffsetLatencySoft = 4608,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SecOffsetLatencySoft = 4609,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SampleOffsetClockSoft = 4610,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SecOffsetClockSoft = 4611,
        FormatQuad8 = 4612,
        Quad8Soft = 4612,
        FormatQuad16 = 4613,
        Quad16Soft = 4613,
        FormatQuad32 = 4614,
        Quad32fSoft = 4614,
        FormatRear8 = 4615,
        Rear8Soft = 4615,
        FormatRear16 = 4616,
        Rear16Soft = 4616,
        FormatRear32 = 4617,
        Rear32fSoft = 4617,
        _5point18Soft = 4618,
        Format51chn8 = 4618,
        _5point116Soft = 4619,
        Format51chn16 = 4619,
        _5point132fSoft = 4620,
        Format51chn32 = 4620,
        _6point18Soft = 4621,
        Format61chn8 = 4621,
        _6point116Soft = 4622,
        Format61chn16 = 4622,
        _6point132fSoft = 4623,
        Format61chn32 = 4623,
        _7point18Soft = 4624,
        Format71chn8 = 4624,
        NumResamplersSoft = 4624,
        _7point116Soft = 4625,
        DefaultResamplerSoft = 4625,
        Format71chn16 = 4625,
        _7point132fSoft = 4626,
        Format71chn32 = 4626,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceResamplerSoft = 4626,
        ResamplerNameSoft = 4627,
        /// <summary>
        /// <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/>
        /// </summary>
        SourceSpatializeSoft = 4628,
        FormatMonoIma4 = 4864,
        FormatStereoIma4 = 4865,
        FormatMonoMsadpcmSoft = 4866,
        FormatStereoMsadpcmSoft = 4867,
        ByteSoft = 5120,
        UnsignedByteSoft = 5121,
        ShortSoft = 5122,
        UnsignedShortSoft = 5123,
        IntSoft = 5124,
        UnsignedIntSoft = 5125,
        FloatSoft = 5126,
        DoubleSoft = 5127,
        Byte3Soft = 5128,
        UnsignedByte3Soft = 5129,
        MonoSoft = 5376,
        StereoSoft = 5377,
        QuadSoft = 5378,
        RearSoft = 5379,
        _5point1Soft = 5380,
        _6point1Soft = 5381,
        _7point1Soft = 5382,
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicLayoutSoft = 6551,
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicScalingSoft = 6552,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/>
        /// </summary>
        EffectslotTargetSoft = 6556,
        /// <summary>
        /// <b>[property on: buffer][range: [1, 14] ][default value: 1]</b><br/>
        /// </summary>
        UnpackAmbisonicOrderSoft = 6557,
        /// <summary>
        /// <b>[property on: buffer][default value: NULL]</b><br/>
        /// </summary>
        BufferCallbackFunctionSoft = 6560,
        /// <summary>
        /// <b>[property on: buffer][default value: NULL]</b><br/>
        /// </summary>
        BufferCallbackUserParamSoft = 6561,
        EventCallbackFunctionSoft = 6562,
        FormatUhj2chn8Soft = 6562,
        EventCallbackUserParamSoft = 6563,
        FormatUhj2chn16Soft = 6563,
        EventTypeBufferCompletedSoft = 6564,
        FormatUhj2chnFloat32Soft = 6564,
        EventTypeSourceStateChangedSoft = 6565,
        FormatUhj3chn8Soft = 6565,
        EventTypeDisconnectedSoft = 6566,
        FormatUhj3chn16Soft = 6566,
        FormatUhj3chnFloat32Soft = 6567,
        FormatUhj4chn8Soft = 6568,
        FormatUhj4chn16Soft = 6569,
        FormatUhj4chnFloat32Soft = 6570,
        /// <summary>
        /// <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/>
        /// </summary>
        StereoModeSoft = 6576,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// </summary>
        SuperStereoWidthSoft = 6577,
        DebugOutputExt = 6578,
        DebugCallbackFunctionExt = 6579,
        FormatUhj2chnMulawSoft = 6579,
        DebugCallbackUserParamExt = 6580,
        FormatUhj2chnAlawSoft = 6580,
        DebugSourceApiExt = 6581,
        FormatUhj2chnIma4Soft = 6581,
        DebugSourceAudioSystemExt = 6582,
        FormatUhj2chnMsadpcmSoft = 6582,
        DebugSourceThirdPartyExt = 6583,
        FormatUhj3chnMulawSoft = 6583,
        DebugSourceApplicationExt = 6584,
        FormatUhj3chnAlawSoft = 6584,
        DebugSourceOtherExt = 6585,
        FormatUhj4chnMulawSoft = 6585,
        DebugTypeErrorExt = 6586,
        FormatUhj4chnAlawSoft = 6586,
        DebugTypeDeprecatedBehaviorExt = 6587,
        DebugTypeUndefinedBehaviorExt = 6588,
        DebugTypePortabilityExt = 6589,
        DebugTypePerformanceExt = 6590,
        DebugTypeMarkerExt = 6591,
        DebugTypePushGroupExt = 6592,
        DebugTypePopGroupExt = 6593,
        DebugTypeOtherExt = 6594,
        DebugSeverityHighExt = 6595,
        DebugSeverityMediumExt = 6596,
        DebugSeverityLowExt = 6597,
        DebugSeverityNotificationExt = 6598,
        DebugLoggedMessagesExt = 6599,
        DebugNextLoggedMessageLengthExt = 6600,
        MaxDebugMessageLengthExt = 6601,
        MaxDebugLoggedMessagesExt = 6602,
        MaxDebugGroupStackDepthExt = 6603,
        MaxLabelLengthExt = 6604,
        StackOverflowExt = 6605,
        StackUnderflowExt = 6606,
        ContextFlagsExt = 6607,
        SourceExt = 6608,
        FilterExt = 6609,
        EffectExt = 6610,
        AuxiliaryEffectSlotExt = 6611,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer frequency/sample rate (query only).
        /// </summary>
        Frequency = 8193,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer bits per sample (query only).
        /// </summary>
        Bits = 8194,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer channel count (query only).
        /// </summary>
        Channels = 8195,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer data size in bytes (query only).
        /// </summary>
        Size = 8196,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        InternalFormatSoft = 8200,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        ByteLengthSoft = 8201,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        SampleLengthSoft = 8202,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        SecLengthSoft = 8203,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        PackBlockAlignmentSoft = 8205,
        GainLimitSoft = 8206,
        LoopPointsExt = 8213,
        /// <summary>
        /// <b>[property on: buffer][default value: 0,0]</b><br/>
        /// </summary>
        LoopPointsSoft = 8213,
        FoldbackModeMono = 16641,
        FoldbackModeStereo = 16642,
        FoldbackEventStart = 16657,
        FoldbackEventBlock = 16658,
        FoldbackEventStop = 16659,
        EffectEaxreverb = 32768,
        EffectLastParameter = 32768,
        FilterLastParameter = 32768,
        /// <summary>
        /// <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectType = 32769,
        /// <summary>
        /// <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        FilterType = 32769,
        EffectDedicatedLowFrequencyEffect = 36864,
        QueueHasLooped = 36864,
        EffectDedicatedDialogue = 36865,
        /// <summary>
        /// Invalid name (ID) passed to an AL call.
        /// </summary>
        InvalidName = 40961,
        /// <summary>
        /// Invalid enumeration passed to AL call.
        /// </summary>
        InvalidEnum = 40962,
        /// <summary>
        /// Invalid value passed to AL call.
        /// </summary>
        InvalidValue = 40963,
        /// <summary>
        /// Illegal AL call.
        /// </summary>
        InvalidOperation = 40964,
        /// <summary>
        /// Not enough memory to execute the AL call.
        /// </summary>
        OutOfMemory = 40965,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Vendor name.
        /// </summary>
        Vendor = 45057,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Version.
        /// </summary>
        Version = 45058,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Renderer name.
        /// </summary>
        Renderer = 45059,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Space-separated extension list.
        /// </summary>
        Extensions = 45060,
        /// <summary>
        /// <b>[property on: context][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Doppler scale.
        /// Scale for source and listener velocities.
        /// </summary>
        DopplerFactor = 49152,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Doppler velocity (deprecated).
        /// A multiplier applied to the Speed of Sound.
        /// </summary>
        DopplerVelocity = 49153,
        DeferredUpdatesSoft = 49154,
        /// <summary>
        /// <b>[property on: context][range: [0.0001, ) ][default value: 343.3]</b><br/>
        /// Speed of Sound, in units per second.
        /// 
        ///                 The speed at which sound waves are assumed to travel, when calculating the
        ///                 doppler effect from source and listener velocities.
        /// 
        /// </summary>
        SpeedOfSound = 49155,
        /// <summary>
        /// <b>[property on: context][default value: AL_INVERSE_DISTANCE_CLAMPED]</b><br/>
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
        DistanceModel = 53248,
        InverseDistance = 53249,
        InverseDistanceClamped = 53250,
        LinearDistance = 53251,
        LinearDistanceClamped = 53252,
        ExponentDistance = 53253,
        ExponentDistanceClamped = 53254,
        MacOsxConvertDataUponLoading = 61441,
        FormatImaAdpcmMono16Ext = 65536,
        FormatImaAdpcmStereo16Ext = 65537,
        FormatWaveExt = 65538,
        FormatVorbisExt = 65539,
        FormatQuad8Loki = 65540,
        FormatQuad16Loki = 65541,
        FormatMonoFloat32 = 65552,
        Mono32fSoft = 65552,
        FormatStereoFloat32 = 65553,
        Stereo32fSoft = 65553,
        FormatMonoDoubleExt = 65554,
        FormatStereoDoubleExt = 65555,
        FormatMonoMulaw = 65556,
        FormatMonoMulawExt = 65556,
        FormatStereoMulaw = 65557,
        FormatStereoMulawExt = 65557,
        FormatMonoAlawExt = 65558,
        FormatStereoAlawExt = 65559,
        FormatMp3Ext = 65568,
        FormatQuadMulaw = 65569,
        FormatRearMulaw = 65570,
        Format51chnMulaw = 65571,
        Format61chnMulaw = 65572,
        Format71chnMulaw = 65573,
        FormatBformat2dMulaw = 65585,
        FormatBformat3dMulaw = 65586,
        /// <summary>
        /// <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/>
        /// </summary>
        MetersPerUnit = 131076,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        DirectFilter = 131077,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        AuxiliarySendFilter = 131078,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        AirAbsorptionFactor = 131079,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        RoomRolloffFactor = 131080,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ConeOuterGainhf = 131081,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        DirectFilterGainhfAuto = 131082,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainhfAuto = 131084,
        FormatBformat2d8 = 131105,
        FormatBformat2d16 = 131106,
        FormatBformat2dFloat32 = 131107,
        FormatBformat3d8 = 131121,
        FormatBformat3d16 = 131122,
        FormatBformat3dFloat32 = 131123,
        EaxRamSize = 2105857,
        EaxRamFree = 2105858,
        StorageAutomatic = 2105859,
        StorageHardware = 2105860,
        StorageAccessible = 2105861,
        FrequencyFilterEnableAax = 2555904,
        FrequencyFilterGainlfAax = 2555905,
        FrequencyFilterGainhfAax = 2555906,
        FrequencyFilterCutoffFreqAax = 2555907,
        FrequencyFilterParamsAax = 2555908,
        ReverbEnableAax = 2555912,
        ReverbPreDelayTimeAax = 2555913,
        ReverbReflectionTimeAax = 2555914,
        ReverbReflectionFactorAax = 2555915,
        ReverbDecayTimeAax = 2555916,
        ReverbDecayTimeHfAax = 2555917,
        DistanceDelayModelAax = 2609152,
        InverseDistanceDelayAax = 2609153,
        InverseDistanceDelayClampedAax = 2609154,
        LinearDistanceDelayAax = 2609155,
        LinearDistanceDelayClampedAax = 2609156,
        ExponentDistanceDelayAax = 2609157,
        ExponentDistanceDelayClampedAax = 2609158,
    }
    public enum AmbisonicLayout : uint
    {
        FumaSoft = 0,
        AcnSoft = 1,
    }
    public enum AmbisonicScaling : uint
    {
        Sn3dSoft = 1,
        N3dSoft = 2,
    }
    public enum AutoWahParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahAttackTime = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahReleaseTime = 2,
        /// <summary>
        /// <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/>
        /// </summary>
        AutowahResonance = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/>
        /// </summary>
        AutowahPeakGain = 4,
    }
    public enum AuxEffectSlotGetPNameB : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/>
        /// </summary>
        EffectslotAuxiliarySendAuto = 3,
    }
    public enum AuxEffectSlotGetPNameBV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/>
        /// </summary>
        EffectslotAuxiliarySendAuto = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotf" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotfDirect" /></summary>
    public enum AuxEffectSlotGetPNameF : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotfv" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotfvDirect" /></summary>
    public enum AuxEffectSlotGetPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSloti" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotiDirect" /></summary>
    public enum AuxEffectSlotGetPNameI : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectslotEffect = 1,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/>
        /// </summary>
        EffectslotTargetSoft = 6556,
    }
    ///<summary>Used in <see cref="AL.EXT.GetAuxiliaryEffectSlotiv" />, <see cref="AL.EXT.GetAuxiliaryEffectSlotivDirect" /></summary>
    public enum AuxEffectSlotGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectslotEffect = 1,
    }
    public enum AuxEffectSlotPNameB : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/>
        /// </summary>
        EffectslotAuxiliarySendAuto = 3,
    }
    public enum AuxEffectSlotPNameBV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_TRUE]</b><br/>
        /// </summary>
        EffectslotAuxiliarySendAuto = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotf" />, <see cref="AL.EXT.AuxiliaryEffectSlotfDirect" /></summary>
    public enum AuxEffectSlotPNameF : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotfv" />, <see cref="AL.EXT.AuxiliaryEffectSlotfvDirect" /></summary>
    public enum AuxEffectSlotPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EffectslotGain = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSloti" />, <see cref="AL.EXT.AuxiliaryEffectSlotiDirect" /></summary>
    public enum AuxEffectSlotPNameI : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectslotEffect = 1,
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECTSLOT_NULL]</b><br/>
        /// </summary>
        EffectslotTargetSoft = 6556,
    }
    ///<summary>Used in <see cref="AL.EXT.AuxiliaryEffectSlotiv" />, <see cref="AL.EXT.AuxiliaryEffectSlotivDirect" /></summary>
    public enum AuxEffectSlotPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: auxiliary effect slot][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectslotEffect = 1,
    }
    public enum BandpassParameterName : uint
    {
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        BandpassGain = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        BandpassGainlf = 2,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
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
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ]</b><br/>
        /// </summary>
        ByteRwOffsetsSoft = 4145,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ]</b><br/>
        /// </summary>
        SampleRwOffsetsSoft = 4146,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        SecLengthSoft = 8203,
    }
    ///<summary>Used in <see cref="AL.GetBufferfv" />, <see cref="AL.EXT.GetBufferfvDirect" /></summary>
    public enum BufferGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetBufferi" />, <see cref="AL.EXT.GetBufferiDirect" /></summary>
    public enum BufferGetPNameI : uint
    {
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicLayoutSoft = 6551,
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicScalingSoft = 6552,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer frequency/sample rate (query only).
        /// </summary>
        Frequency = 8193,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer bits per sample (query only).
        /// </summary>
        Bits = 8194,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer channel count (query only).
        /// </summary>
        Channels = 8195,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer data size in bytes (query only).
        /// </summary>
        Size = 8196,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        InternalFormatSoft = 8200,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        ByteLengthSoft = 8201,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// </summary>
        SampleLengthSoft = 8202,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        PackBlockAlignmentSoft = 8205,
        LoopPointsExt = 8213,
    }
    ///<summary>Used in <see cref="AL.GetBufferiv" />, <see cref="AL.EXT.GetBufferivDirect" /></summary>
    public enum BufferGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer frequency/sample rate (query only).
        /// </summary>
        Frequency = 8193,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer bits per sample (query only).
        /// </summary>
        Bits = 8194,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer channel count (query only).
        /// </summary>
        Channels = 8195,
        /// <summary>
        /// <b>[property on: buffer]</b><br/>
        /// Buffer data size in bytes (query only).
        /// </summary>
        Size = 8196,
        /// <summary>
        /// <b>[property on: buffer][default value: 0,0]</b><br/>
        /// </summary>
        LoopPointsSoft = 8213,
    }
    ///<summary>Used in <see cref="AL.EXT.GetBufferPtrDirectSOFT" />, <see cref="AL.SOFT.GetBufferPtrSOFT" /></summary>
    public enum BufferGetPNamePtr : uint
    {
        /// <summary>
        /// <b>[property on: buffer][default value: NULL]</b><br/>
        /// </summary>
        BufferCallbackFunctionSoft = 6560,
        /// <summary>
        /// <b>[property on: buffer][default value: NULL]</b><br/>
        /// </summary>
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
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicLayoutSoft = 6551,
        /// <summary>
        /// <b>[property on: buffer][default value: AL_FUMA_SOFT]</b><br/>
        /// </summary>
        AmbisonicScalingSoft = 6552,
        /// <summary>
        /// <b>[property on: buffer][range: [1, 14] ][default value: 1]</b><br/>
        /// </summary>
        UnpackAmbisonicOrderSoft = 6557,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        UnpackBlockAlignmentSoft = 8204,
        /// <summary>
        /// <b>[property on: buffer][range: [0, ) ][default value: 0]</b><br/>
        /// </summary>
        PackBlockAlignmentSoft = 8205,
        LoopPointsExt = 8213,
    }
    ///<summary>Used in <see cref="AL.Bufferiv" />, <see cref="AL.EXT.BufferivDirect" /></summary>
    public enum BufferPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: buffer][default value: 0,0]</b><br/>
        /// </summary>
        LoopPointsSoft = 8213,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.BufferSubSamplesDirectSOFT" />, ...</summary>
    public enum Channels : uint
    {
        MonoSoft = 5376,
        StereoSoft = 5377,
        QuadSoft = 5378,
        RearSoft = 5379,
        _5point1Soft = 5380,
        _6point1Soft = 5381,
        _7point1Soft = 5382,
    }
    public enum ChorusParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        ChorusWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/>
        /// </summary>
        ChorusPhase = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/>
        /// </summary>
        ChorusRate = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/>
        /// </summary>
        ChorusDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/>
        /// </summary>
        ChorusFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/>
        /// </summary>
        ChorusDelay = 6,
    }
    public enum CompressorParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        CompressorOnoff = 1,
    }
    public enum ContextAttribute : uint
    {
        ContextFlagsExt = 6607,
    }
    public enum ContextFlags : uint
    {
        ContextDebugBitExt = 1,
    }
    ///<summary>Used in <see cref="AL.EXT.GetDebugMessageLogDirectEXT" />, <see cref="AL.EXT.GetDebugMessageLogEXT" /></summary>
    public enum DebugSeverity : uint
    {
        DontCareExt = 2,
        DebugSeverityHighExt = 6595,
        DebugSeverityMediumExt = 6596,
        DebugSeverityLowExt = 6597,
        DebugSeverityNotificationExt = 6598,
    }
    ///<summary>Used in <see cref="AL.EXT.DebugMessageControlDirectEXT" />, <see cref="AL.EXT.DebugMessageControlEXT" />, <see cref="AL.EXT.DebugMessageInsertDirectEXT" />, ...</summary>
    public enum DebugSource : uint
    {
        DontCareExt = 2,
        DebugSourceApiExt = 6581,
        DebugSourceAudioSystemExt = 6582,
        DebugSourceThirdPartyExt = 6583,
        DebugSourceApplicationExt = 6584,
        DebugSourceOtherExt = 6585,
    }
    ///<summary>Used in <see cref="AL.EXT.DebugMessageControlDirectEXT" />, <see cref="AL.EXT.DebugMessageControlEXT" />, <see cref="AL.EXT.DebugMessageInsertDirectEXT" />, ...</summary>
    public enum DebugType : uint
    {
        DontCareExt = 2,
        DebugTypeErrorExt = 6586,
        DebugTypeDeprecatedBehaviorExt = 6587,
        DebugTypeUndefinedBehaviorExt = 6588,
        DebugTypePortabilityExt = 6589,
        DebugTypePerformanceExt = 6590,
        DebugTypeMarkerExt = 6591,
        DebugTypePushGroupExt = 6592,
        DebugTypePopGroupExt = 6593,
        DebugTypeOtherExt = 6594,
    }
    public enum DedicatedDialogueParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: 1]</b><br/>
        /// </summary>
        DedicatedGain = 1,
    }
    public enum DedicatedLowFrequencyParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: 1]</b><br/>
        /// </summary>
        DedicatedGain = 1,
    }
    public enum DirectChannelMode : uint
    {
        /// <summary>
        /// Boolean False.
        /// </summary>
        False = 0,
        DropUnmatchedSoft = 1,
        /// <summary>
        /// Boolean True.
        /// </summary>
        True = 1,
        RemixUnmatchedSoft = 2,
    }
    ///<summary>Used in <see cref="AL.DistanceModel" />, <see cref="AL.EXT.DistanceModelDirect" /></summary>
    public enum DistanceModel : uint
    {
        /// <summary>
        /// No distance model or no buffer
        /// </summary>
        None = 0,
        InverseDistance = 53249,
        InverseDistanceClamped = 53250,
        LinearDistance = 53251,
        LinearDistanceClamped = 53252,
        ExponentDistance = 53253,
        ExponentDistanceClamped = 53254,
        InverseDistanceDelayAax = 2609153,
        InverseDistanceDelayClampedAax = 2609154,
        LinearDistanceDelayAax = 2609155,
        LinearDistanceDelayClampedAax = 2609156,
        ExponentDistanceDelayAax = 2609157,
        ExponentDistanceDelayClampedAax = 2609158,
    }
    public enum DistortionParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/>
        /// </summary>
        DistortionEdge = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/>
        /// </summary>
        DistortionGain = 2,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/>
        /// </summary>
        DistortionLowpassCutoff = 3,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqcenter = 4,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqbandwidth = 5,
    }
    ///<summary>Used in <see cref="AL.Creative.EAXGetBufferMode" />, <see cref="AL.EXT.EAXGetBufferModeDirect" />, <see cref="AL.Creative.EAXSetBufferMode" />, ...</summary>
    public enum EAXBufferMode : uint
    {
        StorageAutomatic = 2105859,
        StorageHardware = 2105860,
        StorageAccessible = 2105861,
    }
    public enum EAXReverbParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        EaxreverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        EaxreverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbGainlf = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        EaxreverbDecayTime = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        EaxreverbDecayHfratio = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDecayLfratio = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        EaxreverbReflectionsGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        EaxreverbReflectionsDelay = 10,
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbReflectionsPan = 11,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        EaxreverbLateReverbGain = 12,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        EaxreverbLateReverbDelay = 13,
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbLateReverbPan = 14,
        /// <summary>
        /// <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbEchoTime = 15,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbEchoDepth = 16,
        /// <summary>
        /// <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbModulationTime = 17,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbModulationDepth = 18,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/>
        /// </summary>
        EaxreverbHfreference = 20,
        /// <summary>
        /// <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/>
        /// </summary>
        EaxreverbLfreference = 21,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbRoomRolloffFactor = 22,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        EaxreverbDecayHflimit = 23,
    }
    public enum EchoParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoDelay = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoLrdelay = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoDamping = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoFeedback = 4,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/>
        /// </summary>
        EchoSpread = 5,
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectfDirect" />, <see cref="AL.EXT.GetEffectf" /></summary>
    public enum EffectGetPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectfvDirect" />, <see cref="AL.EXT.GetEffectfv" /></summary>
    public enum EffectGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffecti" />, <see cref="AL.EXT.GetEffectiDirect" /></summary>
    public enum EffectGetPNameI : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.GetEffectiv" />, <see cref="AL.EXT.GetEffectivDirect" /></summary>
    public enum EffectGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectf" />, <see cref="AL.EXT.EffectfDirect" /></summary>
    public enum EffectPNameF : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahAttackTime = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.2]</b><br/>
        /// </summary>
        DistortionEdge = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.207] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoDelay = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerLowGain = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/>
        /// </summary>
        FrequencyShifterFrequency = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/>
        /// </summary>
        RingModulatorFrequency = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0001, 1.0] ][default value: 0.06]</b><br/>
        /// </summary>
        AutowahReleaseTime = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 90]</b><br/>
        /// </summary>
        ChorusPhase = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 0.05]</b><br/>
        /// </summary>
        DistortionGain = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.404] ][default value: 0.1]</b><br/>
        /// </summary>
        EchoLrdelay = 2,
        /// <summary>
        /// <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/>
        /// </summary>
        EqualizerLowCutoff = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/>
        /// </summary>
        FlangerPhase = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/>
        /// </summary>
        RingModulatorHighpassCutoff = 2,
        /// <summary>
        /// <b>[property on: effect][range: [2.0, 1000.0] ][default value: 1000.0]</b><br/>
        /// </summary>
        AutowahResonance = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.1]</b><br/>
        /// </summary>
        ChorusRate = 3,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 8000]</b><br/>
        /// </summary>
        DistortionLowpassCutoff = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        EaxreverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.99] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoDamping = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Gain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/>
        /// </summary>
        FlangerRate = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        ReverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.00003, 31621.0] ][default value: 11.22]</b><br/>
        /// </summary>
        AutowahPeakGain = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.1]</b><br/>
        /// </summary>
        ChorusDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqcenter = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        EaxreverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.5]</b><br/>
        /// </summary>
        EchoFeedback = 4,
        /// <summary>
        /// <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/>
        /// </summary>
        EqualizerMid1Center = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        FlangerDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        ReverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: 0.25]</b><br/>
        /// </summary>
        ChorusFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [80.0, 24000] ][default value: 3600]</b><br/>
        /// </summary>
        DistortionEqbandwidth = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbGainlf = 5,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -1.0]</b><br/>
        /// </summary>
        EchoSpread = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Width = 5,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/>
        /// </summary>
        FlangerFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        ReverbDecayTime = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.016] ][default value: 0.016]</b><br/>
        /// </summary>
        ChorusDelay = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        EaxreverbDecayTime = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Gain = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/>
        /// </summary>
        FlangerDelay = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        ReverbDecayHfratio = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/>
        /// </summary>
        VocalMorpherRate = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        EaxreverbDecayHfratio = 7,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/>
        /// </summary>
        EqualizerMid2Center = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        ReverbReflectionsGain = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EaxreverbDecayLfratio = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Width = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        ReverbReflectionsDelay = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        EaxreverbReflectionsGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerHighGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        ReverbLateReverbGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        EaxreverbReflectionsDelay = 10,
        /// <summary>
        /// <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/>
        /// </summary>
        EqualizerHighCutoff = 10,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        ReverbLateReverbDelay = 10,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        EaxreverbLateReverbGain = 12,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        ReverbRoomRolloffFactor = 12,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        EaxreverbLateReverbDelay = 13,
        /// <summary>
        /// <b>[property on: effect][range: [0.075, 0.25] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbEchoTime = 15,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbEchoDepth = 16,
        /// <summary>
        /// <b>[property on: effect][range: [0.04, 4.0] ][default value: 0.25]</b><br/>
        /// </summary>
        EaxreverbModulationTime = 17,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbModulationDepth = 18,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        EaxreverbAirAbsorptionGainhf = 19,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 20000.0] ][default value: 5000.0]</b><br/>
        /// </summary>
        EaxreverbHfreference = 20,
        /// <summary>
        /// <b>[property on: effect][range: [20.0, 1000.0] ][default value: 250.0]</b><br/>
        /// </summary>
        EaxreverbLfreference = 21,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        EaxreverbRoomRolloffFactor = 22,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectfv" />, <see cref="AL.EXT.EffectfvDirect" /></summary>
    public enum EffectPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbReflectionsPan = 11,
        /// <summary>
        /// <b>[property on: effect][default value: 0.0,0.0,0.0]</b><br/>
        /// </summary>
        EaxreverbLateReverbPan = 14,
    }
    ///<summary>Used in <see cref="AL.EXT.Effecti" />, <see cref="AL.EXT.EffectiDirect" /></summary>
    public enum EffectPNameI : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_CHORUS_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        ChorusWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        CompressorOnoff = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        FlangerWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/>
        /// </summary>
        PitchShifterCoarseTune = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemea = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterLeftDirection = 2,
        /// <summary>
        /// <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/>
        /// </summary>
        PitchShifterFineTune = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterRightDirection = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/>
        /// </summary>
        RingModulatorWaveform = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/>
        /// </summary>
        VocalMorpherPhonemeb = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/>
        /// </summary>
        VocalMorpherWaveform = 5,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        ReverbDecayHflimit = 13,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        EaxreverbDecayHflimit = 23,
        /// <summary>
        /// <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Effectiv" />, <see cref="AL.EXT.EffectivDirect" /></summary>
    public enum EffectPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_EFFECT_NULL]</b><br/>
        /// </summary>
        EffectType = 32769,
    }
    public enum EffectType : uint
    {
        EffectNull = 0,
        EffectReverb = 1,
        EffectChorus = 2,
        EffectDistortion = 3,
        EffectEcho = 4,
        EffectFlanger = 5,
        EffectFrequencyShifter = 6,
        EffectVocalMorpher = 7,
        EffectPitchShifter = 8,
        EffectRingModulator = 9,
        EffectAutowah = 10,
        EffectCompressor = 11,
        EffectEqualizer = 12,
        EffectEaxreverb = 32768,
        EffectDedicatedLowFrequencyEffect = 36864,
        EffectDedicatedDialogue = 36865,
    }
    ///<summary>Used in <see cref="AL.Disable" />, <see cref="AL.Enable" />, <see cref="AL.IsEnabled" />, ...</summary>
    public enum EnableCap : uint
    {
        SourceDistanceModel = 512,
        DebugOutputExt = 6578,
        MacOsxConvertDataUponLoading = 61441,
        DistanceDelayModelAax = 2609152,
    }
    public enum EqualizerParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerLowGain = 1,
        /// <summary>
        /// <b>[property on: effect][range: [50.0, 800.0] ][default value: 200.0]</b><br/>
        /// </summary>
        EqualizerLowCutoff = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Gain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [200.0, 3000.0] ][default value: 500.0]</b><br/>
        /// </summary>
        EqualizerMid1Center = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid1Width = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Gain = 6,
        /// <summary>
        /// <b>[property on: effect][range: [1000.0, 8000.0] ][default value: 3000.0]</b><br/>
        /// </summary>
        EqualizerMid2Center = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.01, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerMid2Width = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.126, 7.943] ][default value: 1.0]</b><br/>
        /// </summary>
        EqualizerHighGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [4000.0, 16000.0] ][default value: 6000.0]</b><br/>
        /// </summary>
        EqualizerHighCutoff = 10,
    }
    ///<summary>Used in <see cref="AL.GetError" />, <see cref="AL.EXT.GetErrorDirect" />, <see cref="AL.EXT.SourceAddNotification" />, ...</summary>
    public enum ErrorCode : uint
    {
        /// <summary>
        /// No error.
        /// </summary>
        NoError = 0,
        StackOverflowExt = 6605,
        StackUnderflowExt = 6606,
        /// <summary>
        /// Invalid name (ID) passed to an AL call.
        /// </summary>
        InvalidName = 40961,
        /// <summary>
        /// Invalid enumeration passed to AL call.
        /// </summary>
        InvalidEnum = 40962,
        /// <summary>
        /// Invalid value passed to AL call.
        /// </summary>
        InvalidValue = 40963,
        /// <summary>
        /// Illegal AL call.
        /// </summary>
        InvalidOperation = 40964,
        /// <summary>
        /// Not enough memory to execute the AL call.
        /// </summary>
        OutOfMemory = 40965,
    }
    ///<summary>Used in <see cref="AL.EXT.EventControlDirectSOFT" />, <see cref="AL.SOFT.EventControlSOFT" /></summary>
    public enum EventType : uint
    {
        EventTypeBufferCompletedSoft = 6564,
        EventTypeSourceStateChangedSoft = 6565,
        EventTypeDisconnectedSoft = 6566,
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilterfDirect" />, <see cref="AL.EXT.GetFilterf" /></summary>
    public enum FilterGetPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilterfvDirect" />, <see cref="AL.EXT.GetFilterfv" /></summary>
    public enum FilterGetPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilteri" />, <see cref="AL.EXT.GetFilteriDirect" /></summary>
    public enum FilterGetPNameI : uint
    {
        /// <summary>
        /// <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.GetFilteriv" />, <see cref="AL.EXT.GetFilterivDirect" /></summary>
    public enum FilterGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.FilterfDirect" />, <see cref="AL.EXT.Filterf" /></summary>
    public enum FilterPNameF : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.FilterfvDirect" />, <see cref="AL.EXT.Filterfv" /></summary>
    public enum FilterPNameFV : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.Filteri" />, <see cref="AL.EXT.FilteriDirect" /></summary>
    public enum FilterPNameI : uint
    {
        /// <summary>
        /// <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        FilterType = 32769,
    }
    ///<summary>Used in <see cref="AL.EXT.Filteriv" />, <see cref="AL.EXT.FilterivDirect" /></summary>
    public enum FilterPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: filter][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        FilterType = 32769,
    }
    public enum FilterType : uint
    {
        FilterNull = 0,
        FilterLowpass = 1,
        FilterHighpass = 2,
        FilterBandpass = 3,
    }
    public enum FlangerParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_FLANGER_WAVEFORM_TRIANGLE]</b><br/>
        /// </summary>
        FlangerWaveform = 1,
        /// <summary>
        /// <b>[property on: effect][range: [-180, 180] ][default value: 0]</b><br/>
        /// </summary>
        FlangerPhase = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.27]</b><br/>
        /// </summary>
        FlangerRate = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        FlangerDepth = 4,
        /// <summary>
        /// <b>[property on: effect][range: [-1.0, 1.0] ][default value: -0.5]</b><br/>
        /// </summary>
        FlangerFeedback = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.004] ][default value: 0.002]</b><br/>
        /// </summary>
        FlangerDelay = 6,
    }
    public enum FoldbackEvent : uint
    {
        FoldbackEventStart = 16657,
        FoldbackEventBlock = 16658,
        FoldbackEventStop = 16659,
    }
    ///<summary>Used in <see cref="AL.EXT.RequestFoldbackStart" />, <see cref="AL.EXT.RequestFoldbackStartDirect" /></summary>
    public enum FoldbackMode : uint
    {
        FoldbackModeMono = 16641,
        FoldbackModeStereo = 16642,
    }
    ///<summary>Used in <see cref="AL.BufferData" />, <see cref="AL.EXT.BufferCallbackDirectSOFT" />, <see cref="AL.SOFT.BufferCallbackSOFT" />, ...</summary>
    public enum Format : uint
    {
        /// <summary>
        /// Unsigned 8-bit mono buffer format.
        /// </summary>
        FormatMono8 = 4352,
        /// <summary>
        /// Signed 16-bit mono buffer format.
        /// </summary>
        FormatMono16 = 4353,
        /// <summary>
        /// Unsigned 8-bit stereo buffer format.
        /// </summary>
        FormatStereo8 = 4354,
        /// <summary>
        /// Signed 16-bit stereo buffer format.
        /// </summary>
        FormatStereo16 = 4355,
        FormatQuad8 = 4612,
        FormatQuad16 = 4613,
        FormatQuad32 = 4614,
        FormatRear8 = 4615,
        FormatRear16 = 4616,
        FormatRear32 = 4617,
        Format51chn8 = 4618,
        Format51chn16 = 4619,
        Format51chn32 = 4620,
        Format61chn8 = 4621,
        Format61chn16 = 4622,
        Format61chn32 = 4623,
        Format71chn8 = 4624,
        Format71chn16 = 4625,
        Format71chn32 = 4626,
        FormatMonoIma4 = 4864,
        FormatStereoIma4 = 4865,
        FormatMonoMsadpcmSoft = 4866,
        FormatStereoMsadpcmSoft = 4867,
        FormatUhj2chn8Soft = 6562,
        FormatUhj2chn16Soft = 6563,
        FormatUhj2chnFloat32Soft = 6564,
        FormatUhj3chn8Soft = 6565,
        FormatUhj3chn16Soft = 6566,
        FormatUhj3chnFloat32Soft = 6567,
        FormatUhj4chn8Soft = 6568,
        FormatUhj4chn16Soft = 6569,
        FormatUhj4chnFloat32Soft = 6570,
        FormatUhj2chnMulawSoft = 6579,
        FormatUhj2chnAlawSoft = 6580,
        FormatUhj2chnIma4Soft = 6581,
        FormatUhj2chnMsadpcmSoft = 6582,
        FormatUhj3chnMulawSoft = 6583,
        FormatUhj3chnAlawSoft = 6584,
        FormatUhj4chnMulawSoft = 6585,
        FormatUhj4chnAlawSoft = 6586,
        FormatImaAdpcmMono16Ext = 65536,
        FormatImaAdpcmStereo16Ext = 65537,
        FormatWaveExt = 65538,
        FormatVorbisExt = 65539,
        FormatQuad8Loki = 65540,
        FormatQuad16Loki = 65541,
        FormatMonoFloat32 = 65552,
        FormatStereoFloat32 = 65553,
        FormatMonoDoubleExt = 65554,
        FormatStereoDoubleExt = 65555,
        FormatMonoMulaw = 65556,
        FormatMonoMulawExt = 65556,
        FormatStereoMulaw = 65557,
        FormatStereoMulawExt = 65557,
        FormatMonoAlawExt = 65558,
        FormatStereoAlawExt = 65559,
        FormatMp3Ext = 65568,
        FormatQuadMulaw = 65569,
        FormatRearMulaw = 65570,
        Format51chnMulaw = 65571,
        Format61chnMulaw = 65572,
        Format71chnMulaw = 65573,
        FormatBformat2dMulaw = 65585,
        FormatBformat3dMulaw = 65586,
        FormatBformat2d8 = 131105,
        FormatBformat2d16 = 131106,
        FormatBformat2dFloat32 = 131107,
        FormatBformat3d8 = 131121,
        FormatBformat3d16 = 131122,
        FormatBformat3dFloat32 = 131123,
    }
    public enum FrequencyShifterParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 0.0]</b><br/>
        /// </summary>
        FrequencyShifterFrequency = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterLeftDirection = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_FREQUENCY_SHIFTER_DIRECTION_DOWN]</b><br/>
        /// </summary>
        FrequencyShifterRightDirection = 3,
    }
    ///<summary>Used in <see cref="AL.GetBoolean" />, <see cref="AL.EXT.GetBooleanDirect" /></summary>
    public enum GetPNameB : uint
    {
        DebugLoggedMessagesExt = 6599,
        DebugNextLoggedMessageLengthExt = 6600,
        MaxDebugMessageLengthExt = 6601,
        MaxDebugLoggedMessagesExt = 6602,
        MaxDebugGroupStackDepthExt = 6603,
        MaxLabelLengthExt = 6604,
        GainLimitSoft = 8206,
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetBooleanv" />, <see cref="AL.EXT.GetBooleanvDirect" /></summary>
    public enum GetPNameBV : uint
    {
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetDouble" />, <see cref="AL.EXT.GetDoubleDirect" /></summary>
    public enum GetPNameD : uint
    {
        DebugLoggedMessagesExt = 6599,
        DebugNextLoggedMessageLengthExt = 6600,
        MaxDebugMessageLengthExt = 6601,
        MaxDebugLoggedMessagesExt = 6602,
        MaxDebugGroupStackDepthExt = 6603,
        MaxLabelLengthExt = 6604,
        GainLimitSoft = 8206,
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetDoublev" />, <see cref="AL.EXT.GetDoublevDirect" /></summary>
    public enum GetPNameDV : uint
    {
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetFloat" />, <see cref="AL.EXT.GetFloatDirect" /></summary>
    public enum GetPNameF : uint
    {
        DebugLoggedMessagesExt = 6599,
        DebugNextLoggedMessageLengthExt = 6600,
        MaxDebugMessageLengthExt = 6601,
        MaxDebugLoggedMessagesExt = 6602,
        MaxDebugGroupStackDepthExt = 6603,
        MaxLabelLengthExt = 6604,
        GainLimitSoft = 8206,
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetFloatv" />, <see cref="AL.EXT.GetFloatvDirect" /></summary>
    public enum GetPNameFV : uint
    {
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.GetInteger" />, <see cref="AL.EXT.GetIntegerDirect" /></summary>
    public enum GetPNameI : uint
    {
        NumResamplersSoft = 4624,
        DebugLoggedMessagesExt = 6599,
        DebugNextLoggedMessageLengthExt = 6600,
        MaxDebugMessageLengthExt = 6601,
        MaxDebugLoggedMessagesExt = 6602,
        MaxDebugGroupStackDepthExt = 6603,
        MaxLabelLengthExt = 6604,
        GainLimitSoft = 8206,
        DeferredUpdatesSoft = 49154,
        EaxRamSize = 2105857,
        EaxRamFree = 2105858,
    }
    ///<summary>Used in <see cref="AL.GetIntegerv" />, <see cref="AL.EXT.GetIntegervDirect" /></summary>
    public enum GetPNameIV : uint
    {
        NumResamplersSoft = 4624,
        DeferredUpdatesSoft = 49154,
    }
    ///<summary>Used in <see cref="AL.EXT.GetPointerDirectEXT" />, <see cref="AL.EXT.GetPointerDirectSOFT" />, <see cref="AL.EXT.GetPointerEXT" />, ...</summary>
    public enum GetPNamePtr : uint
    {
        EventCallbackFunctionSoft = 6562,
        EventCallbackUserParamSoft = 6563,
        DebugCallbackFunctionExt = 6579,
        DebugCallbackUserParamExt = 6580,
    }
    ///<summary>Used in <see cref="AL.EXT.GetPointervDirectSOFT" />, <see cref="AL.SOFT.GetPointervSOFT" /></summary>
    public enum GetPNamePtrV : uint
    {
    }
    public enum HighpassParameterName : uint
    {
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        HighpassGain = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        HighpassGainlf = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.GetStringiDirectSOFT" />, <see cref="AL.SOFT.GetStringiSOFT" /></summary>
    public enum IndexedStringName : uint
    {
        ResamplerNameSoft = 4627,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.IsBufferFormatSupportedDirectSOFT" />, ...</summary>
    public enum InternalFormat : uint
    {
        Mono8Soft = 4352,
        Mono16Soft = 4353,
        Stereo8Soft = 4354,
        Stereo16Soft = 4355,
        Quad8Soft = 4612,
        Quad16Soft = 4613,
        Quad32fSoft = 4614,
        Rear8Soft = 4615,
        Rear16Soft = 4616,
        Rear32fSoft = 4617,
        _5point18Soft = 4618,
        _5point116Soft = 4619,
        _5point132fSoft = 4620,
        _6point18Soft = 4621,
        _6point116Soft = 4622,
        _6point132fSoft = 4623,
        _7point18Soft = 4624,
        _7point116Soft = 4625,
        _7point132fSoft = 4626,
        Mono32fSoft = 65552,
        Stereo32fSoft = 65553,
    }
    ///<summary>Used in <see cref="AL.GetListener3f" />, <see cref="AL.EXT.GetListener3fDirect" /></summary>
    public enum ListenerGetPName3F : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetListener3i" />, <see cref="AL.EXT.GetListener3iDirect" /></summary>
    public enum ListenerGetPName3I : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetListenerf" />, <see cref="AL.EXT.GetListenerfDirect" /></summary>
    public enum ListenerGetPNameF : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/>
        /// </summary>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.GetListenerfv" />, <see cref="AL.EXT.GetListenerfvDirect" /></summary>
    public enum ListenerGetPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
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
        Orientation = 4111,
        /// <summary>
        /// <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/>
        /// </summary>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.GetListeneri" />, <see cref="AL.EXT.GetListeneriDirect" /></summary>
    public enum ListenerGetPNameI : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetListeneriv" />, <see cref="AL.EXT.GetListenerivDirect" /></summary>
    public enum ListenerGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
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
        Orientation = 4111,
    }
    ///<summary>Used in <see cref="AL.Listener3f" />, <see cref="AL.EXT.Listener3fDirect" /></summary>
    public enum ListenerPName3F : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Listener3i" />, <see cref="AL.EXT.Listener3iDirect" /></summary>
    public enum ListenerPName3I : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Listenerf" />, <see cref="AL.EXT.ListenerfDirect" /></summary>
    public enum ListenerPNameF : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/>
        /// </summary>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.Listenerfv" />, <see cref="AL.EXT.ListenerfvDirect" /></summary>
    public enum ListenerPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
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
        Orientation = 4111,
        /// <summary>
        /// <b>[property on: listener][range: [0, ) ][default value: 1.0]</b><br/>
        /// </summary>
        MetersPerUnit = 131076,
    }
    ///<summary>Used in <see cref="AL.Listeneri" />, <see cref="AL.EXT.ListeneriDirect" /></summary>
    public enum ListenerPNameI : uint
    {
    }
    ///<summary>Used in <see cref="AL.Listeneriv" />, <see cref="AL.EXT.ListenerivDirect" /></summary>
    public enum ListenerPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: listener][default value: 0.0,0.0,-1.0,0.0,1.0,0.0]</b><br/>
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
        Orientation = 4111,
    }
    public enum LowpassParameterName : uint
    {
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        LowpassGain = 1,
        /// <summary>
        /// <b>[property on: filter][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        LowpassGainhf = 2,
    }
    ///<summary>Used in <see cref="AL.EXT.MacOSXGetRenderChannelCount" />, <see cref="AL.EXT.MacOSXGetRenderChannelCountDirect" />, <see cref="AL.EXT.MacOSXRenderChannelCount" />, ...</summary>
    public enum MacOSXRenderChannelCount : uint
    {
        MacOsxRenderChannelCountStereo = 1022,
        MacOsxRenderChannelCountMultichannel = 1023,
    }
    ///<summary>Used in <see cref="AL.EXT.SourceGetRenderingQuality" />, <see cref="AL.EXT.SourceGetRenderingQualityDirect" />, <see cref="AL.EXT.SourceRenderingQuality" />, ...</summary>
    public enum MacOSXSpatialRenderingQuality : uint
    {
        MacOsxSpatialRenderingQualityHigh = 1021,
        MacOsxSpatialRenderingQualityLow = 1023,
    }
    ///<summary>Used in <see cref="AL.EXT.GetObjectLabelDirectEXT" />, <see cref="AL.EXT.GetObjectLabelEXT" />, <see cref="AL.EXT.ObjectLabelDirectEXT" />, ...</summary>
    public enum ObjectType : uint
    {
        BufferExt = 4105,
        SourceExt = 6608,
        FilterExt = 6609,
        EffectExt = 6610,
        AuxiliaryEffectSlotExt = 6611,
    }
    public enum PitchShifterParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [-12, 12] ][default value: 12]</b><br/>
        /// </summary>
        PitchShifterCoarseTune = 1,
        /// <summary>
        /// <b>[property on: effect][range: [-150, 50] ][default value: 0]</b><br/>
        /// </summary>
        PitchShifterFineTune = 2,
    }
    public enum ReverbParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDensity = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ReverbDiffusion = 2,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.32]</b><br/>
        /// </summary>
        ReverbGain = 3,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 1.0] ][default value: 0.89]</b><br/>
        /// </summary>
        ReverbGainhf = 4,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 20] ][default value: 1.49]</b><br/>
        /// </summary>
        ReverbDecayTime = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.1, 2.0] ][default value: 0.83]</b><br/>
        /// </summary>
        ReverbDecayHfratio = 6,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 3.16] ][default value: 0.05]</b><br/>
        /// </summary>
        ReverbReflectionsGain = 7,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.3] ][default value: 0.007]</b><br/>
        /// </summary>
        ReverbReflectionsDelay = 8,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.26]</b><br/>
        /// </summary>
        ReverbLateReverbGain = 9,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 0.1] ][default value: 0.011]</b><br/>
        /// </summary>
        ReverbLateReverbDelay = 10,
        /// <summary>
        /// <b>[property on: effect][range: [0.892, 1.0] ][default value: 0.994]</b><br/>
        /// </summary>
        ReverbAirAbsorptionGainhf = 11,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 0.0]</b><br/>
        /// </summary>
        ReverbRoomRolloffFactor = 12,
        /// <summary>
        /// <b>[property on: effect][default value: AL_TRUE]</b><br/>
        /// </summary>
        ReverbDecayHflimit = 13,
    }
    public enum RingModulatorParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 8000.0] ][default value: 440.0]</b><br/>
        /// </summary>
        RingModulatorFrequency = 1,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 24000.0] ][default value: 800.0]</b><br/>
        /// </summary>
        RingModulatorHighpassCutoff = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_RING_MODULATOR_SINUSOID]</b><br/>
        /// </summary>
        RingModulatorWaveform = 3,
    }
    ///<summary>Used in <see cref="AL.EXT.BufferSamplesDirectSOFT" />, <see cref="AL.SOFT.BufferSamplesSOFT" />, <see cref="AL.EXT.BufferSubSamplesDirectSOFT" />, ...</summary>
    public enum SampleType : uint
    {
        ByteSoft = 5120,
        UnsignedByteSoft = 5121,
        ShortSoft = 5122,
        UnsignedShortSoft = 5123,
        IntSoft = 5124,
        UnsignedIntSoft = 5125,
        FloatSoft = 5126,
        DoubleSoft = 5127,
        Byte3Soft = 5128,
        UnsignedByte3Soft = 5129,
    }
    public enum SourceGetPameIV : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSource3dDirectSOFT" />, <see cref="AL.SOFT.GetSource3dSOFT" /></summary>
    public enum SourceGetPName3D : uint
    {
    }
    ///<summary>Used in <see cref="AL.GetSource3f" />, <see cref="AL.EXT.GetSource3fDirect" /></summary>
    public enum SourceGetPName3F : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.GetSource3i" />, <see cref="AL.EXT.GetSource3iDirect" /></summary>
    public enum SourceGetPName3I : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        AuxiliarySendFilter = 131078,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSource3i64DirectSOFT" />, <see cref="AL.SOFT.GetSource3i64SOFT" /></summary>
    public enum SourceGetPName3I64 : uint
    {
    }
    public enum SourceGetPNameB : uint
    {
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        SourceRelative = 514,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        DirectFilterGainhfAuto = 131082,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    public enum SourceGetPNameBV : uint
    {
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        DirectFilterGainhfAuto = 131082,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcedDirectSOFT" />, <see cref="AL.SOFT.GetSourcedSOFT" /></summary>
    public enum SourceGetPNameD : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcedvDirectSOFT" />, <see cref="AL.SOFT.GetSourcedvSOFT" /></summary>
    public enum SourceGetPNameDV : uint
    {
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SecOffsetLatencySoft = 4609,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SecOffsetClockSoft = 4611,
    }
    ///<summary>Used in <see cref="AL.GetSourcef" />, <see cref="AL.EXT.GetSourcefDirect" /></summary>
    public enum SourceGetPNameF : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        Pitch = 4099,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MinGain = 4109,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MaxGain = 4110,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        MaxDistance = 4131,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        StereoAngles = 4144,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceRadius = 4145,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// </summary>
        SuperStereoWidthSoft = 6577,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        AirAbsorptionFactor = 131079,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        RoomRolloffFactor = 131080,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.GetSourcefv" />, <see cref="AL.EXT.GetSourcefvDirect" /></summary>
    public enum SourceGetPNameFV : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        Pitch = 4099,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MinGain = 4109,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MaxGain = 4110,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// </summary>
        SuperStereoWidthSoft = 6577,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        AirAbsorptionFactor = 131079,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        RoomRolloffFactor = 131080,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.GetSourcei" />, <see cref="AL.EXT.GetSourceiDirect" /></summary>
    public enum SourceGetPNameI : uint
    {
        SourceDistanceModel = 512,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        Looping = 4103,
        /// <summary>
        /// <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        Buffer = 4105,
        ByteLoki = 4108,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source state (query only).
        /// </summary>
        SourceState = 4112,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        BuffersQueued = 4117,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        BuffersProcessed = 4118,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        MaxDistance = 4131,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
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
        SourceType = 4135,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// </summary>
        DirectChannelsSoft = 4147,
        DefaultResamplerSoft = 4625,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceResamplerSoft = 4626,
        /// <summary>
        /// <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/>
        /// </summary>
        SourceSpatializeSoft = 4628,
        /// <summary>
        /// <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/>
        /// </summary>
        StereoModeSoft = 6576,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        DirectFilter = 131077,
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcei64DirectSOFT" />, <see cref="AL.SOFT.GetSourcei64SOFT" /></summary>
    public enum SourceGetPNameI64 : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.GetSourcei64vDirectSOFT" />, <see cref="AL.SOFT.GetSourcei64vSOFT" /></summary>
    public enum SourceGetPNameI64V : uint
    {
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SampleOffsetLatencySoft = 4608,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SampleOffsetClockSoft = 4610,
    }
    ///<summary>Used in <see cref="AL.GetSourceiv" />, <see cref="AL.EXT.GetSourceivDirect" /></summary>
    public enum SourceGetPNameIV : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        Looping = 4103,
        /// <summary>
        /// <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        Buffer = 4105,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        BuffersQueued = 4117,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        BuffersProcessed = 4118,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
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
        SourceType = 4135,
        DefaultResamplerSoft = 4625,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceResamplerSoft = 4626,
        /// <summary>
        /// <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/>
        /// </summary>
        SourceSpatializeSoft = 4628,
        /// <summary>
        /// <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/>
        /// </summary>
        StereoModeSoft = 6576,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        DirectFilter = 131077,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        AuxiliarySendFilter = 131078,
    }
    public enum SourceNotification : uint
    {
        QueueHasLooped = 36864,
    }
    ///<summary>Used in <see cref="AL.EXT.Source3dDirectSOFT" />, <see cref="AL.SOFT.Source3dSOFT" /></summary>
    public enum SourcePName3D : uint
    {
    }
    ///<summary>Used in <see cref="AL.Source3f" />, <see cref="AL.EXT.Source3fDirect" /></summary>
    public enum SourcePName3F : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
    }
    ///<summary>Used in <see cref="AL.Source3i" />, <see cref="AL.EXT.Source3iDirect" /></summary>
    public enum SourcePName3I : uint
    {
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        AuxiliarySendFilter = 131078,
    }
    ///<summary>Used in <see cref="AL.EXT.Source3i64DirectSOFT" />, <see cref="AL.SOFT.Source3i64SOFT" /></summary>
    public enum SourcePName3I64 : uint
    {
    }
    public enum SourcePNameB : uint
    {
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Relative source.
        /// Specifies if the source uses relative coordinates.
        /// </summary>
        SourceRelative = 514,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        DirectFilterGainhfAuto = 131082,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    public enum SourcePNameBV : uint
    {
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        DirectFilterGainhfAuto = 131082,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainAuto = 131083,
        /// <summary>
        /// <b>[property on: source][default value: AL_TRUE]</b><br/>
        /// </summary>
        AuxiliarySendFilterGainhfAuto = 131084,
    }
    ///<summary>Used in <see cref="AL.EXT.SourcedDirectSOFT" />, <see cref="AL.SOFT.SourcedSOFT" /></summary>
    public enum SourcePNameD : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.SourcedvDirectSOFT" />, <see cref="AL.SOFT.SourcedvSOFT" /></summary>
    public enum SourcePNameDV : uint
    {
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SecOffsetLatencySoft = 4609,
    }
    ///<summary>Used in <see cref="AL.Sourcef" />, <see cref="AL.EXT.SourcefDirect" /></summary>
    public enum SourcePNameF : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        Pitch = 4099,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MinGain = 4109,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MaxGain = 4110,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        MaxDistance = 4131,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        StereoAngles = 4144,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceRadius = 4145,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// </summary>
        SuperStereoWidthSoft = 6577,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        AirAbsorptionFactor = 131079,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        RoomRolloffFactor = 131080,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.Sourcefv" />, <see cref="AL.EXT.SourcefvDirect" /></summary>
    public enum SourcePNameFV : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][range: [0.5, 2.0] ][default value: 1.0]</b><br/>
        /// Source pitch.
        /// A multiplier for the sample rate of the source's buffer.
        /// </summary>
        Pitch = 4099,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source, listener][range: [0.0, ) ]</b><br/>
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
        Gain = 4106,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Minimum source gain.
        /// 
        ///                 The minimum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MinGain = 4109,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// Maximum source gain.
        /// 
        ///                 The maximum gain allowed for a source, after distance and cone attenuation
        ///                 are applied (if applicable).
        /// 
        /// </summary>
        MaxGain = 4110,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ]</b><br/>
        /// </summary>
        SuperStereoWidthSoft = 6577,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        AirAbsorptionFactor = 131079,
        /// <summary>
        /// <b>[property on: source][range: [0, 10] ][default value: 0]</b><br/>
        /// </summary>
        RoomRolloffFactor = 131080,
        /// <summary>
        /// <b>[property on: source][range: [0.0, 1.0] ][default value: 1.0]</b><br/>
        /// </summary>
        ConeOuterGainhf = 131081,
    }
    ///<summary>Used in <see cref="AL.Sourcei" />, <see cref="AL.EXT.SourceiDirect" /></summary>
    public enum SourcePNameI : uint
    {
        SourceDistanceModel = 512,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        Looping = 4103,
        /// <summary>
        /// <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        Buffer = 4105,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        BuffersQueued = 4117,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        BuffersProcessed = 4118,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: FLT_MAX]</b><br/>
        /// Source maximum distance.
        /// 
        ///                 The distance above which the source is not attenuated any further with a
        ///                 clamped distance model, or where attenuation reaches 0.0 gain for linear
        ///                 distance models with a default rolloff factor.
        /// 
        /// </summary>
        MaxDistance = 4131,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
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
        SourceType = 4135,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// </summary>
        DirectChannelsSoft = 4147,
        DefaultResamplerSoft = 4625,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceResamplerSoft = 4626,
        /// <summary>
        /// <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/>
        /// </summary>
        SourceSpatializeSoft = 4628,
        /// <summary>
        /// <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/>
        /// </summary>
        StereoModeSoft = 6576,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        DirectFilter = 131077,
    }
    ///<summary>Used in <see cref="AL.EXT.Sourcei64DirectSOFT" />, <see cref="AL.SOFT.Sourcei64SOFT" /></summary>
    public enum SourcePNameI64 : uint
    {
    }
    ///<summary>Used in <see cref="AL.EXT.Sourcei64vDirectSOFT" />, <see cref="AL.SOFT.Sourcei64vSOFT" /></summary>
    public enum SourcePNameI64V : uint
    {
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SampleOffsetLatencySoft = 4608,
    }
    ///<summary>Used in <see cref="AL.Sourceiv" />, <see cref="AL.EXT.SourceivDirect" /></summary>
    public enum SourcePNameIV : uint
    {
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Inner cone angle, in degrees.
        /// 
        ///                 The angle covered by the inner cone, the area within which the source will
        ///                 not be attenuated by direction.
        /// 
        /// </summary>
        ConeInnerAngle = 4097,
        /// <summary>
        /// <b>[property on: source][range: [0, 360] ][default value: 360]</b><br/>
        /// Outer cone angle, in degrees.
        /// 
        ///                 The angle covered by the outer cone, the area outside of which the source
        ///                 will be fully attenuated by direction.
        /// 
        /// </summary>
        ConeOuterAngle = 4098,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
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
        Position = 4100,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source direction.
        /// 
        ///                 Specifies the current direction in local space. A zero-length vector
        ///                 specifies an omni-directional source (cone is ignored).
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Direction = 4101,
        /// <summary>
        /// <b>[property on: source, listener][default value: 0,0,0]</b><br/>
        /// Source or listener velocity.
        /// 
        ///                 Specifies the current velocity, relative to the position.
        /// 
        ///                 To change from or to a left handed coordinate system, negate the Z
        ///                 component.
        /// 
        /// </summary>
        Velocity = 4102,
        /// <summary>
        /// <b>[property on: source][default value: AL_FALSE]</b><br/>
        /// Source looping.
        /// Specifies whether source playback loops.
        /// </summary>
        Looping = 4103,
        /// <summary>
        /// <b>[property on: source][default value: AL_NONE]</b><br/>
        /// Source buffer.
        /// Specifies the buffer to provide sound samples for a source.
        /// </summary>
        Buffer = 4105,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue size (query only).
        /// 
        ///                 The number of buffers queued using alSourceQueueBuffers, minus the buffers
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        /// </summary>
        BuffersQueued = 4117,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// Source Buffer Queue processed count (query only).
        /// 
        ///                 The number of queued buffers that have been fully processed, and can be
        ///                 removed with alSourceUnqueueBuffers.
        /// 
        ///                 Looping sources will never fully process buffers because they will be set to
        ///                 play again for when the source loops.
        /// 
        /// </summary>
        BuffersProcessed = 4118,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source reference distance.
        /// 
        ///                 The distance in units that no distance attenuation occurs.
        /// 
        ///                 At 0.0, no distance attenuation occurs with non-linear attenuation models.
        /// 
        /// </summary>
        ReferenceDistance = 4128,
        /// <summary>
        /// <b>[property on: source][range: [0.0, ) ][default value: 1.0]</b><br/>
        /// Source rolloff factor.
        /// 
        ///                 Multiplier to exaggerate or diminish distance attenuation.
        /// 
        ///                 At 0.0, no distance attenuation ever occurs.
        /// 
        /// </summary>
        RolloffFactor = 4129,
        /// <summary>
        /// <b>[property on: listener][range: [0.0, 1.0] ][default value: 0.0]</b><br/>
        /// Outer cone gain.
        /// 
        ///                 The gain attenuation applied when the listener is outside of the source's
        ///                 outer cone angle.
        /// 
        /// </summary>
        ConeOuterGain = 4130,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in seconds.
        /// </summary>
        SecOffset = 4132,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in sample frames.
        /// </summary>
        SampleOffset = 4133,
        /// <summary>
        /// <b>[property on: source][range: [0, ) ]</b><br/>
        /// Source buffer offset, in bytes.
        /// </summary>
        ByteOffset = 4134,
        /// <summary>
        /// <b>[property on: source]</b><br/>
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
        SourceType = 4135,
        DefaultResamplerSoft = 4625,
        /// <summary>
        /// <b>[property on: source]</b><br/>
        /// </summary>
        SourceResamplerSoft = 4626,
        /// <summary>
        /// <b>[property on: source][default value: AL_AUTO_SOFT]</b><br/>
        /// </summary>
        SourceSpatializeSoft = 4628,
        /// <summary>
        /// <b>[property on: source][default value: AL_NORMAL_SOFT]</b><br/>
        /// </summary>
        StereoModeSoft = 6576,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        DirectFilter = 131077,
        /// <summary>
        /// <b>[property on: source][default value: AL_FILTER_NULL]</b><br/>
        /// </summary>
        AuxiliarySendFilter = 131078,
    }
    public enum SourceSpatializeMode : uint
    {
        /// <summary>
        /// Boolean False.
        /// </summary>
        False = 0,
        /// <summary>
        /// Boolean True.
        /// </summary>
        True = 1,
        AutoSoft = 2,
    }
    public enum SourceState : uint
    {
        Initial = 4113,
        Playing = 4114,
        Paused = 4115,
        Stopped = 4116,
    }
    public enum SourceType : uint
    {
        Static = 4136,
        Streaming = 4137,
        Undetermined = 4144,
    }
    public enum StereoMode : uint
    {
        NormalSoft = 0,
        SuperStereoSoft = 1,
    }
    ///<summary>Used in <see cref="AL.GetString" />, <see cref="AL.EXT.GetStringDirect" /></summary>
    public enum StringName : uint
    {
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Vendor name.
        /// </summary>
        Vendor = 45057,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Version.
        /// </summary>
        Version = 45058,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Renderer name.
        /// </summary>
        Renderer = 45059,
        /// <summary>
        /// <b>[property on: context]</b><br/>
        /// Context string: Space-separated extension list.
        /// </summary>
        Extensions = 45060,
    }
    public enum VocalMorpherParameterName : uint
    {
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemea = 1,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemeaCoarseTuning = 2,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_ER]</b><br/>
        /// </summary>
        VocalMorpherPhonemeb = 3,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MOPRHER_PHONEME_A]</b><br/>
        /// </summary>
        VocalMorpherPhonemebCoarseTuning = 4,
        /// <summary>
        /// <b>[property on: effect][default value: AL_VOCAL_MORPHER_WAVEFORM_SINUSOID]</b><br/>
        /// </summary>
        VocalMorpherWaveform = 5,
        /// <summary>
        /// <b>[property on: effect][range: [0.0, 10.0] ][default value: 1.41]</b><br/>
        /// </summary>
        VocalMorpherRate = 6,
    }
#pragma warning restore CA1069 // Enums values should not be duplicated
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore CS0419 // Ambiguous reference in cref attribute
}
