#region --- OpenTK.OpenAL License ---
/* EfxTokens.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;

namespace OpenTK.OpenAL.Enums
{
    // Constants, might be removed if inline docu is sufficiently describing it
    // AL chorus effect parameter ranges and defaults
    // AL_CHORUS_WAVEFORM_SINUSOID                        0
    // AL_CHORUS_WAVEFORM_TRIANGLE                        1    

    // AL flanger effect parameter ranges and defaults
    // AL_FLANGER_WAVEFORM_SINUSOID                       0
    // AL_FLANGER_WAVEFORM_TRIANGLE                       1

    // AL ring modulator effect parameter ranges and defaults
    // AL_RING_MODULATOR_SINUSOID                         0
    // AL_RING_MODULATOR_SAWTOOTH                         1
    // AL_RING_MODULATOR_SQUARE                           2

    // AL vocal morpher effect parameter ranges and defaults
    // AL_VOCAL_MORPHER_WAVEFORM_SINUSOID                 0
    // AL_VOCAL_MORPHER_WAVEFORM_TRIANGLE                 1
    // AL_VOCAL_MORPHER_WAVEFORM_SAWTOOTH                 2

    // AL frequency shifter effect parameter ranges and defaults
    // AL_FREQUENCY_SHIFTER_DIRECTION_DOWN                0
    // AL_FREQUENCY_SHIFTER_DIRECTION_UP                  1
    // AL_FREQUENCY_SHIFTER_DIRECTION_OFF                 2

    #region Effect

    public enum EfxEffectf : int
    {
        ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
        ReverbDensity = 0x0001,
        ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
        ReverbDiffusion = 0x0002,
        ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.32f</summary>
        ReverbGain = 0x0003,
        ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.89f</summary>
        ReverbGainHF = 0x0004,
        ///<summary>Reverb Parameter. Unit: Seconds Range [0.1f .. 20.0f] Default: 1.49f</summary>
        ReverbDecayTime = 0x0005,
        ///<summary>Reverb Parameter. Range [0.1f .. 2.0f] Default: 0.83f</summary>
        ReverbDecayHFRatio = 0x0006,
        ///<summary>Reverb Parameter. Range [0.0f .. 3.16f] Default: 0.05f</summary>
        ReverbReflectionsGain = 0x0007,
        ///<summary>Reverb Parameter. Unit: Seconds Range [0.0f .. 0.3f] Default: 0.007f</summary>
        ReverbReflectionsDelay = 0x0008,
        ///<summary>Reverb Parameter. Range [0.0f .. 10.0f] Default: 1.26f</summary>
        ReverbLateReverbGain = 0x0009,
        ///<summary>Reverb Parameter. Unit: Seconds Range [0.0f .. 0.1f] Default: 0.011f</summary>
        ReverbLateReverbDelay = 0x000A,
        ///<summary>Reverb Parameter. Range [0.892f .. 1.0f] Default: 0.994f</summary>
        ReverbAirAbsorptionGainHF = 0x000B,
        ///<summary>Reverb Parameter. Range [0.0f .. 10.0f] Default: 0.0f</summary>
        ReverbRoomRolloffFactor = 0x000C,

        ///<summary>Chorus Parameter. Unit: Hz Range [0.0f .. 10.0f] Default: 1.1f</summary>
        ChorusRate = 0x0003,
        ///<summary>Chorus Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
        ChorusDepth = 0x0004,
        ///<summary>Chorus Parameter. Range [-1.0f .. +1.0f] Default: +0.25f</summary>
        ChorusFeedback = 0x0005,
        ///<summary>Chorus Parameter. Unit: Seconds Range [0.0f .. 0.016f] Default:  0.016f</summary>
        ChorusDelay = 0x0006,

        ///<summary>Distortion Parameter. Range [0.0f .. 1.0f] Default: 0.2f</summary>
        DistortionEdge = 0x0001,
        ///<summary>Distortion Parameter. Range [0.01f .. 1.0f] Default: 0.05f</summary>
        DistortionGain = 0x0002,
        ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 8000.0f</summary>
        DistortionLowpassCutoff = 0x0003,
        ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 3600.0f</summary>
        DistortionEQCenter = 0x0004,
        ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 3600.0f</summary>
        DistortionEQBandwidth = 0x0005,

        ///<summary>Echo Parameter. Unit: Seconds Range [0.0f .. 0.207f] Default: 0.1f</summary>
        EchoDelay = 0x0001,
        ///<summary>Echo Parameter. Unit: Seconds Range [0.0f .. 0.404f] Default: 0.1f</summary>
        EchoLRDelay = 0x0002,
        ///<summary>Echo Parameter. Range [0.0f .. 0.99f] Default: 0.5f</summary>
        EchoDamping = 0x0003,
        ///<summary>Echo Parameter. Range [0.0f .. 1.0f] Default: 0.5f</summary>
        EchoFeedback = 0x0004,
        ///<summary>Echo Parameter. Range [-1.0f .. +1.0f] Default: -1.0f</summary>
        EchoSpread = 0x0005,

        ///<summary>Flanger Parameter. Range [0.0f .. 10.0f] Default: 0.27f</summary>
        FlangerRate = 0x0003,
        ///<summary>Flanger Parameter. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        FlangerDepth = 0x0004,
        ///<summary>Flanger Parameter. Range [-1.0f .. +1.0f] Default: -0.5f</summary>
        FlangerFeedback = 0x0005,
        ///<summary>Flanger Parameter. Unit: Seconds Range [0.0f .. 0.004f] Default: 0.002f</summary>
        FlangerDelay = 0x0006,

        ///<summary>Frequencyshifter Parameter. Unit: Hz Range [0.0f .. 24000.0f] Default: 0.0f</summary>
        FrequencyShifterFrequency = 0x0001,

        ///<summary>Vocalmorpher Parameter. Unit: Hz Range [0.0f .. 10.0f] Default: 1.41f</summary>
        VocalMorpherRate = 0x0006,

        ///<summary>Ringmodulator Parameter. Unit: Hz Range [0.0f .. 8000.0f] Default: 440.0f</summary>
        RingModulatorFrequency = 0x0001,
        ///<summary>Ringmodulator Parameter. Unit: Hz Range [0.0f .. 24000.0f] Default: 800.0f</summary>
        RingModulatorHighpassCutoff = 0x0002,

        ///<summary>Autowah Parameter. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f</summary>
        AutowahAttackTime = 0x0001,
        ///<summary>Autowah Parameter. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f</summary>
        AutowahReleaseTime = 0x0002,
        ///<summary>Autowah Parameter. Range [2.0f .. 1000.0f] Default: 1000.0f</summary>
        AutowahResonance = 0x0003,
        ///<summary>Autowah Parameter. Range [0.00003f .. 31621.0f] Default: 11.22f</summary>
        AutowahPeakGain = 0x0004,

        ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
        EqualizerLowGain = 0x0001,
        ///<summary>Equalizer Parameter. Unit: Hz Range [50.0f .. 800.0f] Default: 200.0f</summary>
        EqualizerLowCutoff = 0x0002,
        ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
        EqualizerMid1Gain = 0x0003,
        ///<summary>Equalizer Parameter. Unit: Hz Range [200.0f .. 3000.0f] Default: 500.0f</summary>
        EqualizerMid1Center = 0x0004,
        ///<summary>Equalizer Parameter. Range [0.01f .. 1.0f] Default: 1.0f</summary>
        EqualizerMid1Width = 0x0005,
        ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
        EqualizerMid2Gain = 0x0006,
        ///<summary>Equalizer Parameter. Unit: Hz Range [1000.0f .. 8000.0f] Default: 3000.0f</summary>
        EqualizerMid2Center = 0x0007,
        ///<summary>Equalizer Parameter. Range [0.01f .. 1.0f] Default: 1.0f</summary>
        EqualizerMid2Width = 0x0008,
        ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
        EqualizerHighGain = 0x0009,
        ///<summary>Equalizer Parameter. Unit: Hz Range [4000.0f .. 16000.0f] Default: 6000.0f</summary>
        EqualizerHighCutoff = 0x000A,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        EaxReverbDensity = 0x0001,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        EaxReverbDiffusion = 0x0002,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.32f</summary>
        EaxReverbGain = 0x0003,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.89f</summary>
        EaxReverbGainHF = 0x0004,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        EaxReverbGainLF = 0x0005,
        ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.1f .. 20.0f] Default: 1.49f</summary>
        EaxReverbDecayTime = 0x0006,
        ///<summary>EAXReverb effect parameters. Range [0.1f .. 2.0f] Default: 0.83f</summary>
        EaxReverbDecayHFRatio = 0x0007,
        ///<summary>EAXReverb effect parameters. Range [0.1f .. 2.0f] Default: 1.0f</summary>
        EaxReverbDecayLFRatio = 0x0008,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 3.16f] Default: 0.05f</summary>
        EaxReverbReflectionsGain = 0x0009,
        ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.0f .. 0.3f] Default: 0.007f</summary>
        EaxReverbReflectionsDelay = 0x000A,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 10.0f] Default: 1.26f</summary>
        EaxReverbLateReverbGain = 0x000C,
        ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.0f .. 0.1f] Default: 0.011f</summary>
        EaxReverbLateReverbDelay = 0x000D,
        ///<summary>EAXReverb effect parameters. Range [0.075f .. 0.25f] Default: 0.25f</summary>
        EaxReverbEchoTime = 0x000F,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.0f</summary>
        EaxReverbEchoDepth = 0x0010,
        ///<summary>EAXReverb effect parameters. Range [0.04f .. 4.0f] Default: 0.25f</summary>
        EaxReverbModulationTime = 0x0011,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.0f</summary>
        EaxReverbModulationDepth = 0x0012,
        ///<summary>EAXReverb effect parameters. Range [0.892f .. 1.0f] Default: 0.994f</summary>
        EaxReverbAirAbsorptionGainHF = 0x0013,
        ///<summary>EAXReverb effect parameters. Unit: Hz Range [1000.0f .. 20000.0f] Default: 5000.0f</summary>
        EaxReverbHFReference = 0x0014,
        ///<summary>EAXReverb effect parameters. Unit: Hz Range [20.0f .. 1000.0f] Default: 250.0f</summary>
        EaxReverbLFReference = 0x0015,
        ///<summary>EAXReverb effect parameters. Range [0.0f .. 10.0f] Default: 0.0f</summary>
        EaxReverbRoomRolloffFactor = 0x0016,
    }

    public enum EfxEffect3f : int
    {
        /// <summary>EAXReverb effect parameters. Unit: Vector3 Default: {0.0f, 0.0f, 0.0f}</summary>  
        EaxReverbLateReverbPan = 0x000E,
        /// <summary>EAXReverb effect parameters. Unit: Vector3 Default: {0.0f, 0.0f, 0.0f}</summary>          
        EaxReverbReflectionsPan = 0x000B,
    }

    public enum EfxEffecti : int
    {
        ///<summary>Chorus Parameter. Unit: (0) Sinusoid, (1) Triangle [0 .. 1] Default: 1</summary>
        ChorusWaveform = 0x0001,
        ///<summary>Chorus Parameter. Unit: Degrees Range [-180 .. 180] Default: 90</summary>
        ChorusPhase = 0x0002,

        ///<summary>Flanger Parameter. Unit: (0) Sinusoid, (1) Triangle Range [0 .. 1] Default: 1</summary>
        FlangerWaveform = 0x0001,
        ///<summary>Flanger Parameter. Range [-180 .. +180] Default: 0</summary>
        FlangerPhase = 0x0002,

        ///<summary>Frequencyshifter Parameter. Unit: (0) Down, (1) Up, (2) Off Range [0 .. 2] Default: 0</summary>
        FrequencyShifterLeftDirection = 0x0002,
        ///<summary>Frequencyshifter Parameter. Unit: (0) Down, (1) Up, (2) Off Range [0 .. 2] Default: 0</summary>
        FrequencyShifterRightDirection = 0x0003,

        ///<summary>Vocalmorpher Parameter. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 0, AL_VOCAL_MORPHER_PHONEME_A</summary>
        VocalMorpherPhonemeA = 0x0001,
        ///<summary>Vocalmorpher Parameter. Unit: Semitones Range [-24 .. +24] Default: 0</summary>
        VocalMorpherPhonemeACoarseTuning = 0x0002,
        ///<summary>Vocalmorpher Parameter. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 10, AL_VOCAL_MORPHER_PHONEME_ER</summary>
        VocalMorpherPhonemeB = 0x0003,
        ///<summary>Vocalmorpher Parameter. Unit: Semitones Range [-24 .. +24] Default: 0</summary>
        VocalMorpherPhonemeBCoarseTuning = 0x0004,
        ///<summary>Vocalmorpher Parameter. Unit: (0) Sinusoid, (1) Triangle, (2) Sawtooth Range [0 .. 2] Default: 0</summary>
        VocalMorpherWaveform = 0x0005,

        ///<summary>Pitchshifter Parameter. Unit: Semitones Range [-12 .. +12] Default: +12</summary>
        PitchShifterCoarseTune = 0x0001,
        ///<summary>Pitchshifter Parameter. Unit: Cents Range [-50 .. +50] Default: 0</summary>
        PitchShifterFineTune = 0x0002,

        ///<summary>Ringmodulator Parameter. Unit: (0) Sinusoid, (1) Sawtooth, (2) Square Range [0 .. 2] Default: 0</summary>
        RingModulatorWaveform = 0x0003,

        ///<summary>Compressor Parameter. Unit: (0) Off, (1) On Range [0 .. 1] Default: 1</summary>
        CompressorOnoff = 0x0001,

        ///<summary>Reverb Parameter. Unit: (0) False, (1) True Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
        ReverbDecayHFLimit = 0x000D,

        ///<summary>EAXReverb effect parameters. Unit: (0) False, (1) True Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
        EaxReverbDecayHFLimit = 0x0017,

        AL_EFFECT_FIRST_PARAMETER = 0x0000,// deprecated?
        AL_EFFECT_LAST_PARAMETER = 0x8000, // deprecated?

        /// <summary>Used with the enum EfxEffectType as it's parameter.</summary>
        EffectType = 0x8001,
    }

    ///<summary>Vocal morpher effect parameters.</summary>
    public enum EfxFormantFilterSettings : int
    {
        AL_VOCAL_MORPHER_PHONEME_A = 0,
        AL_VOCAL_MORPHER_PHONEME_E = 1,
        AL_VOCAL_MORPHER_PHONEME_I = 2,
        AL_VOCAL_MORPHER_PHONEME_O = 3,
        AL_VOCAL_MORPHER_PHONEME_U = 4,
        AL_VOCAL_MORPHER_PHONEME_AA = 5,
        AL_VOCAL_MORPHER_PHONEME_AE = 6,
        AL_VOCAL_MORPHER_PHONEME_AH = 7,
        AL_VOCAL_MORPHER_PHONEME_AO = 8,
        AL_VOCAL_MORPHER_PHONEME_EH = 9,
        AL_VOCAL_MORPHER_PHONEME_ER = 10,
        AL_VOCAL_MORPHER_PHONEME_IH = 11,
        AL_VOCAL_MORPHER_PHONEME_IY = 12,
        AL_VOCAL_MORPHER_PHONEME_UH = 13,
        AL_VOCAL_MORPHER_PHONEME_UW = 14,
        AL_VOCAL_MORPHER_PHONEME_B = 15,
        AL_VOCAL_MORPHER_PHONEME_D = 16,
        AL_VOCAL_MORPHER_PHONEME_F = 17,
        AL_VOCAL_MORPHER_PHONEME_G = 18,
        AL_VOCAL_MORPHER_PHONEME_J = 19,
        AL_VOCAL_MORPHER_PHONEME_K = 20,
        AL_VOCAL_MORPHER_PHONEME_L = 21,
        AL_VOCAL_MORPHER_PHONEME_M = 22,
        AL_VOCAL_MORPHER_PHONEME_N = 23,
        AL_VOCAL_MORPHER_PHONEME_P = 24,
        AL_VOCAL_MORPHER_PHONEME_R = 25,
        AL_VOCAL_MORPHER_PHONEME_S = 26,
        AL_VOCAL_MORPHER_PHONEME_T = 27,
        AL_VOCAL_MORPHER_PHONEME_V = 28,
        AL_VOCAL_MORPHER_PHONEME_Z = 29,
    }

    ///<summary>Effect type definitions to be used with AL_EFFECT_TYPE.</summary>  
    public enum EfxEffectType : int
    {
        EffectNull = 0x0000, /* Can also be used as an Effect Object ID */
        EffectReverb = 0x0001,
        EffectChorus = 0x0002,
        EffectDistortion = 0x0003,
        EffectEcho = 0x0004,
        EffectFlanger = 0x0005,
        EffectFrequencyShifter = 0x0006,
        EffectVocalMorpher = 0x0007,
        EffectPitchShifter = 0x0008,
        EffectRingModulator = 0x0009,
        EffectAutowah = 0x000A,
        EffectCompressor = 0x000B,
        EffectEqualizer = 0x000C,

        EffectEaxReverb = 0x8000, // works on native HW only
    }

    #endregion Effect

    #region Auxiliary Effect Slot

    public enum EfxAuxiliaryi : int
    {
        /// <summary>This property is used to attach an Effect object to the Auxiliary Effect Slot object. After the attachment, the Auxiliary Effect Slot object will contain the effect type and have the same effect parameters that were stored in the Effect object. Any Sources feeding the Auxiliary Effect Slot will immediate feed the new effect type and new effect parameters.</summary>
        EffectslotEffect = 0x0001,

        /// <summary>This property is used to enable or disable automatic send adjustments based on the physical positions of the sources and the listener. This property should be enabled when an application wishes to use a reverb effect to simulate the environment surrounding a listener or a collection of Sources. Range [False .. True] Default: True </summary>
        EffectslotAuxiliarySendAuto = 0x0003,
  }

    public enum EfxAuxiliaryf : int
    {
        /// <summary>This property is used to specify an output level for the Auxiliary Effect Slot. Setting the gain to 0.0f mutes the output. Range [0.0f .. 1.0f] Default: 1.0f</summary>
        EffectslotGain = 0x0002,
    }

    #endregion Auxiliary Effect Slot

    #region Filter Object

    // Filter object definitions to be used with alFilter functions.
    public enum EfxFilterf : int
    {
        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        LowpassGain = 0x0001,
        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        LowpassGainHF = 0x0002,

        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        HighpassGain = 0x0001,
        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        HighpassGainLF = 0x0002,

        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        BandpassGain = 0x0001,
        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        BandpassGainLF = 0x0002,
        ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
        BandpassGainHF = 0x0003,
    }

    // Filter type 
    public enum EfxFilteri : int
    {
        AL_FILTER_FIRST_PARAMETER = 0x0000, // deprecated?
        AL_FILTER_LAST_PARAMETER = 0x8000, // deprecated?

        /// <summary>Used with the enum EfxFilterType as Parameter to select a filter logic.</summary>
        FilterType = 0x8001,
    }

    ///<summary>Filter type definitions to be used with AL_FILTER_TYPE.</summary>
    public enum EfxFilterType : int
    {
        FilterNull = 0x0000, // Can also be used as a Filter Object ID
        FilterLowpass = 0x0001,
        FilterHighpass = 0x0002,
        FilterBandpass = 0x0003,
    }

    #endregion Filter Object

}
