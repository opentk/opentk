#region --- OpenTK.OpenAL License ---
/* EfxTokens.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;

namespace OpenTK.OpenAL
{
    public partial class Efx
    {
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

        private const string ALC_EXT_EFX_NAME = "ALC_EXT_EFX";

        /**
         * Context definitions to be used with alcCreateContext.
         * These values must be unique and not conflict with other 
         * al context values.
         */
        public enum NEWALCTOKENS : int
        {
            /// <summary>This Context property can be used by the application to retrieve the Major version number of the Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved using alcGetIntegerv.</summary>
            ALC_EFX_MAJOR_VERSION = 0x20001,

            /// <summary>This Context property can be used by the application to retrieve the Minor version number of the Effects Extension supported by this OpenAL implementation. As this is a Context property is should be retrieved using alcGetIntegerv.</summary>
            ALC_EFX_MINOR_VERSION = 0x20002,

            /// <summary>This Context property can be passed to OpenAL during Context creation (alcCreateContext) to request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired number of sends will be available, so an application should query this property after creating the context using alcGetIntergerv. Default: 2</summary>
            ALC_MAX_AUXILIARY_SENDS = 0x20003,
        }

        public enum NEWLISTENERTOKENS : int
        {

            /* Listener definitions to be used with alListener functions.
             * These values must be unique and not conflict with other 
             * al listener values.*/

            ///<summary>The Listener property allows an application to specify the relationship between the units passed to OpenAL calls such as positions, velocities, reference distance, etc … and the real-world. This information is critical if Air Absorption effects are enabled because the amount of Air Absorption applied is directly related to the real-world distance between the Source and the Listener. If the application is using centimeters for distance units, then this property should be set to 0.01 so that the amount of air absorption applied is not 100 times too great! Range [float.MinValue .. float.MaxValue] Default: 1.0f</summary>
            AL_METERS_PER_UNIT = 0x20004,
        }

        public enum NEWSSOURCETOKENS : int
        {
            /**
             * Source definitions to be used with alSource functions.
             * These values must be unique and not conflict with other 
             * al source values.
             */
            ///<summary>This Source property is used to apply filtering on the direct-path (dry signal) of a Source.</summary>
            AL_DIRECT_FILTER = 0x20005,
            ///<summary>This Source property is used to establish connections between Sources and Auxiliary Effect Slots. For a Source to feed an Effect that has been loaded into an Auxiliary Effect Slot the application must configure one of the Source’s auxiliary sends. This process involves setting 3 variables – the destination Auxiliary Effect Slot ID, the Auxiliary Send number, and an optional Filter ID.</summary>
            AL_AUXILIARY_SEND_FILTER = 0x20006, // Sourcei3

            ///<summary>This Source property is a multiplier on the amount of Air Absorption applied to the Source. The AL_AIR_ABSORPTION_FACTOR is multiplied by an internal Air Absorption Gain HF value of 0.994 (-0.05dB) per meter which represents normal atmospheric humidity and temperature. Range [0.0f .. 10.0f] Default: 0.0f</summary>
            AL_AIR_ABSORPTION_FACTOR = 0x20007,
            ///<summary>This Source property is defined the same way as the Reverb Room Rolloff property: it is one of two methods available in the Effect Extension to attenuate the reflected sound (early reflections and reverberation) according to source-listener distance. Range [0.0f .. 10.0f] Default: 0.0f</summary>
            AL_ROOM_ROLLOFF_FACTOR = 0x20008,
            ///<summary>This Source property enhances the directivity for individual Sources. A directed Source points in a specified direction. The Source sounds at full volume when the listener is directly in front of the source; it is attenuated as the listener circles the Source away from the front. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_CONE_OUTER_GAINHF = 0x20009,
            ///<summary>If this Source property is set to AL_TRUE (its default value), this Source’s direct-path is automatically filtered according to the orientation of the source relative to the listener and the setting of the Source property AL_CONE_OUTER_GAINHF. Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
            AL_DIRECT_FILTER_GAINHF_AUTO = 0x2000A,
            ///<summary>If this Source property is set to AL_TRUE (its default value), the intensity of this Source’s reflected sound is automatically attenuated according to source-listener distance and source directivity (as determined by the cone parameters). If it is AL_FALSE, the reflected sound is not attenuated according to distance and directivity. Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
            AL_AUXILIARY_SEND_FILTER_GAIN_AUTO = 0x2000B,
            ///<summary>If this Source property is AL_TRUE (its default value), the intensity of this Source’s reflected sound at high frequencies will be automatically attenuated according to the high-frequency source directivity as set by the AL_CONE_OUTER_GAINHF property. If this property is AL_FALSE, the Source’s reflected sound is not filtered at all according to the Source’s directivity. Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
            AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO = 0x2000C,
        }

        #region Effect

        public enum EfxEffectf : int
        {
            ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
            AL_REVERB_DENSITY = 0x0001,
            ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
            AL_REVERB_DIFFUSION = 0x0002,
            ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.32f</summary>
            AL_REVERB_GAIN = 0x0003,
            ///<summary>Reverb Parameter. Range [0.0f .. 1.0f] Default: 0.89f</summary>
            AL_REVERB_GAINHF = 0x0004,
            ///<summary>Reverb Parameter. Unit: Seconds Range [0.1f .. 20.0f] Default: 1.49f</summary>
            AL_REVERB_DECAY_TIME = 0x0005,
            ///<summary>Reverb Parameter. Range [0.1f .. 2.0f] Default: 0.83f</summary>
            AL_REVERB_DECAY_HFRATIO = 0x0006,
            ///<summary>Reverb Parameter. Range [0.0f .. 3.16f] Default: 0.05f</summary>
            AL_REVERB_REFLECTIONS_GAIN = 0x0007,
            ///<summary>Reverb Parameter. Unit: Seconds Range [0.0f .. 0.3f] Default: 0.007f</summary>
            AL_REVERB_REFLECTIONS_DELAY = 0x0008,
            ///<summary>Reverb Parameter. Range [0.0f .. 10.0f] Default: 1.26f</summary>
            AL_REVERB_LATE_REVERB_GAIN = 0x0009,
            ///<summary>Reverb Parameter. Unit: Seconds Range [0.0f .. 0.1f] Default: 0.011f</summary>
            AL_REVERB_LATE_REVERB_DELAY = 0x000A,
            ///<summary>Reverb Parameter. Range [0.892f .. 1.0f] Default: 0.994f</summary>
            AL_REVERB_AIR_ABSORPTION_GAINHF = 0x000B,
            ///<summary>Reverb Parameter. Range [0.0f .. 10.0f] Default: 0.0f</summary>
            AL_REVERB_ROOM_ROLLOFF_FACTOR = 0x000C,

            ///<summary>Chorus Parameter. Unit: Hz Range [0.0f .. 10.0f] Default: 1.1f</summary>
            AL_CHORUS_RATE = 0x0003,
            ///<summary>Chorus Parameter. Range [0.0f .. 1.0f] Default: 0.1f</summary>
            AL_CHORUS_DEPTH = 0x0004,
            ///<summary>Chorus Parameter. Range [-1.0f .. +1.0f] Default: +0.25f</summary>
            AL_CHORUS_FEEDBACK = 0x0005,
            ///<summary>Chorus Parameter. Unit: Seconds Range [0.0f .. 0.016f] Default:  0.016f</summary>
            AL_CHORUS_DELAY = 0x0006,

            ///<summary>Distortion Parameter. Range [0.0f .. 1.0f] Default: 0.2f</summary>
            AL_DISTORTION_EDGE = 0x0001,
            ///<summary>Distortion Parameter. Range [0.01f .. 1.0f] Default: 0.05f</summary>
            AL_DISTORTION_GAIN = 0x0002,
            ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 8000.0f</summary>
            AL_DISTORTION_LOWPASS_CUTOFF = 0x0003,
            ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 3600.0f</summary>
            AL_DISTORTION_EQCENTER = 0x0004,
            ///<summary>Distortion Parameter. Unit: Hz Range [80.0f .. 24000.0f] Default: 3600.0f</summary>
            AL_DISTORTION_EQBANDWIDTH = 0x0005,

            ///<summary>Echo Parameter. Unit: Seconds Range [0.0f .. 0.207f] Default: 0.1f</summary>
            AL_ECHO_DELAY = 0x0001,
            ///<summary>Echo Parameter. Unit: Seconds Range [0.0f .. 0.404f] Default: 0.1f</summary>
            AL_ECHO_LRDELAY = 0x0002,
            ///<summary>Echo Parameter. Range [0.0f .. 0.99f] Default: 0.5f</summary>
            AL_ECHO_DAMPING = 0x0003,
            ///<summary>Echo Parameter. Range [0.0f .. 1.0f] Default: 0.5f</summary>
            AL_ECHO_FEEDBACK = 0x0004,
            ///<summary>Echo Parameter. Range [-1.0f .. +1.0f] Default: -1.0f</summary>
            AL_ECHO_SPREAD = 0x0005,

            ///<summary>Flanger Parameter. Range [0.0f .. 10.0f] Default: 0.27f</summary>
            AL_FLANGER_RATE = 0x0003,
            ///<summary>Flanger Parameter. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_FLANGER_DEPTH = 0x0004,
            ///<summary>Flanger Parameter. Range [-1.0f .. +1.0f] Default: -0.5f</summary>
            AL_FLANGER_FEEDBACK = 0x0005,
            ///<summary>Flanger Parameter. Unit: Seconds Range [0.0f .. 0.004f] Default: 0.002f</summary>
            AL_FLANGER_DELAY = 0x0006,

            ///<summary>Frequencyshifter Parameter. Unit: Hz Range [0.0f .. 24000.0f] Default: 0.0f</summary>
            AL_FREQUENCY_SHIFTER_FREQUENCY = 0x0001,

            ///<summary>Vocalmorpher Parameter. Unit: Hz Range [0.0f .. 10.0f] Default: 1.41f</summary>
            AL_VOCAL_MORPHER_RATE = 0x0006,

            ///<summary>Ringmodulator Parameter. Unit: Hz Range [0.0f .. 8000.0f] Default: 440.0f</summary>
            AL_RING_MODULATOR_FREQUENCY = 0x0001,
            ///<summary>Ringmodulator Parameter. Unit: Hz Range [0.0f .. 24000.0f] Default: 800.0f</summary>
            AL_RING_MODULATOR_HIGHPASS_CUTOFF = 0x0002,

            ///<summary>Autowah Parameter. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f</summary>
            AL_AUTOWAH_ATTACK_TIME = 0x0001,
            ///<summary>Autowah Parameter. Unit: Seconds Range [0.0001f .. 1.0f] Default: 0.06f</summary>
            AL_AUTOWAH_RELEASE_TIME = 0x0002,
            ///<summary>Autowah Parameter. Range [2.0f .. 1000.0f] Default: 1000.0f</summary>
            AL_AUTOWAH_RESONANCE = 0x0003,
            ///<summary>Autowah Parameter. Range [0.00003f .. 31621.0f] Default: 11.22f</summary>
            AL_AUTOWAH_PEAK_GAIN = 0x0004,

            ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
            AL_EQUALIZER_LOW_GAIN = 0x0001,
            ///<summary>Equalizer Parameter. Unit: Hz Range [50.0f .. 800.0f] Default: 200.0f</summary>
            AL_EQUALIZER_LOW_CUTOFF = 0x0002,
            ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
            AL_EQUALIZER_MID1_GAIN = 0x0003,
            ///<summary>Equalizer Parameter. Unit: Hz Range [200.0f .. 3000.0f] Default: 500.0f</summary>
            AL_EQUALIZER_MID1_CENTER = 0x0004,
            ///<summary>Equalizer Parameter. Range [0.01f .. 1.0f] Default: 1.0f</summary>
            AL_EQUALIZER_MID1_WIDTH = 0x0005,
            ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
            AL_EQUALIZER_MID2_GAIN = 0x0006,
            ///<summary>Equalizer Parameter. Unit: Hz Range [1000.0f .. 8000.0f] Default: 3000.0f</summary>
            AL_EQUALIZER_MID2_CENTER = 0x0007,
            ///<summary>Equalizer Parameter. Range [0.01f .. 1.0f] Default: 1.0f</summary>
            AL_EQUALIZER_MID2_WIDTH = 0x0008,
            ///<summary>Equalizer Parameter. Range [0.126f .. 7.943f] Default: 1.0f</summary>
            AL_EQUALIZER_HIGH_GAIN = 0x0009,
            ///<summary>Equalizer Parameter. Unit: Hz Range [4000.0f .. 16000.0f] Default: 6000.0f</summary>
            AL_EQUALIZER_HIGH_CUTOFF = 0x000A,

            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_EAXREVERB_DENSITY = 0x0001,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_EAXREVERB_DIFFUSION = 0x0002,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.32f</summary>
            AL_EAXREVERB_GAIN = 0x0003,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.89f</summary>
            AL_EAXREVERB_GAINHF = 0x0004,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_EAXREVERB_GAINLF = 0x0005,
            ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.1f .. 20.0f] Default: 1.49f</summary>
            AL_EAXREVERB_DECAY_TIME = 0x0006,
            ///<summary>EAXReverb effect parameters. Range [0.1f .. 2.0f] Default: 0.83f</summary>
            AL_EAXREVERB_DECAY_HFRATIO = 0x0007,
            ///<summary>EAXReverb effect parameters. Range [0.1f .. 2.0f] Default: 1.0f</summary>
            AL_EAXREVERB_DECAY_LFRATIO = 0x0008,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 3.16f] Default: 0.05f</summary>
            AL_EAXREVERB_REFLECTIONS_GAIN = 0x0009,
            ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.0f .. 0.3f] Default: 0.007f</summary>
            AL_EAXREVERB_REFLECTIONS_DELAY = 0x000A,
            /// <summary>EAXReverb effect parameters. Unit: Vector3 Default: {0.0f, 0.0f, 0.0f}</summary>          
            AL_EAXREVERB_REFLECTIONS_PAN = 0x000B,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 10.0f] Default: 1.26f</summary>
            AL_EAXREVERB_LATE_REVERB_GAIN = 0x000C,
            ///<summary>EAXReverb effect parameters. Unit: Seconds Range [0.0f .. 0.1f] Default: 0.011f</summary>
            AL_EAXREVERB_LATE_REVERB_DELAY = 0x000D,
            /// <summary>EAXReverb effect parameters. Unit: Vector3 Default: {0.0f, 0.0f, 0.0f}</summary>  
            AL_EAXREVERB_LATE_REVERB_PAN = 0x000E,
            ///<summary>EAXReverb effect parameters. Range [0.075f .. 0.25f] Default: 0.25f</summary>
            AL_EAXREVERB_ECHO_TIME = 0x000F,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.0f</summary>
            AL_EAXREVERB_ECHO_DEPTH = 0x0010,
            ///<summary>EAXReverb effect parameters. Range [0.04f .. 4.0f] Default: 0.25f</summary>
            AL_EAXREVERB_MODULATION_TIME = 0x0011,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 1.0f] Default: 0.0f</summary>
            AL_EAXREVERB_MODULATION_DEPTH = 0x0012,
            ///<summary>EAXReverb effect parameters. Range [0.892f .. 1.0f] Default: 0.994f</summary>
            AL_EAXREVERB_AIR_ABSORPTION_GAINHF = 0x0013,
            ///<summary>EAXReverb effect parameters. Unit: Hz Range [1000.0f .. 20000.0f] Default: 5000.0f</summary>
            AL_EAXREVERB_HFREFERENCE = 0x0014,
            ///<summary>EAXReverb effect parameters. Unit: Hz Range [20.0f .. 1000.0f] Default: 250.0f</summary>
            AL_EAXREVERB_LFREFERENCE = 0x0015,
            ///<summary>EAXReverb effect parameters. Range [0.0f .. 10.0f] Default: 0.0f</summary>
            AL_EAXREVERB_ROOM_ROLLOFF_FACTOR = 0x0016,
        }

        public enum EfxEffecti : int
        {
            ///<summary>Chorus Parameter. Unit: (0) Sinusoid, (1) Triangle [0 .. 1] Default: 1</summary>
            AL_CHORUS_WAVEFORM = 0x0001,
            ///<summary>Chorus Parameter. Unit: Degrees Range [-180 .. 180] Default: 90</summary>
            AL_CHORUS_PHASE = 0x0002,

            ///<summary>Flanger Parameter. Unit: (0) Sinusoid, (1) Triangle Range [0 .. 1] Default: 1</summary>
            AL_FLANGER_WAVEFORM = 0x0001,
            ///<summary>Flanger Parameter. Range [-180 .. +180] Default: 0</summary>
            AL_FLANGER_PHASE = 0x0002,

            ///<summary>Frequencyshifter Parameter. Unit: (0) Down, (1) Up, (2) Off Range [0 .. 2] Default: 0</summary>
            AL_FREQUENCY_SHIFTER_LEFT_DIRECTION = 0x0002,
            ///<summary>Frequencyshifter Parameter. Unit: (0) Down, (1) Up, (2) Off Range [0 .. 2] Default: 0</summary>
            AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION = 0x0003,

            ///<summary>Vocalmorpher Parameter. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 0, AL_VOCAL_MORPHER_PHONEME_A</summary>
            AL_VOCAL_MORPHER_PHONEMEA = 0x0001,
            ///<summary>Vocalmorpher Parameter. Unit: Semitones Range [-24 .. +24] Default: 0</summary>
            AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING = 0x0002,
            ///<summary>Vocalmorpher Parameter. Unit: Use enum EfxFormantFilterSettings Range [0 .. 29] Default: 10, AL_VOCAL_MORPHER_PHONEME_ER</summary>
            AL_VOCAL_MORPHER_PHONEMEB = 0x0003,
            ///<summary>Vocalmorpher Parameter. Unit: Semitones Range [-24 .. +24] Default: 0</summary>
            AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING = 0x0004,
            ///<summary>Vocalmorpher Parameter. Unit: (0) Sinusoid, (1) Triangle, (2) Sawtooth Range [0 .. 2] Default: 0</summary>
            AL_VOCAL_MORPHER_WAVEFORM = 0x0005,

            ///<summary>Pitchshifter Parameter. Unit: Semitones Range [-12 .. +12] Default: +12</summary>
            AL_PITCH_SHIFTER_COARSE_TUNE = 0x0001,
            ///<summary>Pitchshifter Parameter. Unit: Cents Range [-50 .. +50] Default: 0</summary>
            AL_PITCH_SHIFTER_FINE_TUNE = 0x0002,

            ///<summary>Ringmodulator Parameter. Unit: (0) Sinusoid, (1) Sawtooth, (2) Square Range [0 .. 2] Default: 0</summary>
            AL_RING_MODULATOR_WAVEFORM = 0x0003,

            ///<summary>Compressor Parameter. Unit: (0) Off, (1) On Range [0 .. 1] Default: 1</summary>
            AL_COMPRESSOR_ONOFF = 0x0001,

            ///<summary>Reverb Parameter. Unit: (0) False, (1) True Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
            AL_REVERB_DECAY_HFLIMIT = 0x000D,

            ///<summary>EAXReverb effect parameters. Unit: (0) False, (1) True Range [AL_FALSE .. AL_TRUE] Default: AL_TRUE</summary>
            AL_EAXREVERB_DECAY_HFLIMIT = 0x0017,

            AL_EFFECT_FIRST_PARAMETER = 0x0000,
            AL_EFFECT_LAST_PARAMETER = 0x8000,

            /// <summary>Used with the enum EfxEffectType as it's parameter.</summary>
            AL_EFFECT_TYPE = 0x8001, // AL.BindEffect()
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
            AL_EFFECT_NULL = 0x0000, /* Can also be used as an Effect Object ID */
            AL_EFFECT_REVERB = 0x0001,
            AL_EFFECT_CHORUS = 0x0002,
            AL_EFFECT_DISTORTION = 0x0003,
            AL_EFFECT_ECHO = 0x0004,
            AL_EFFECT_FLANGER = 0x0005,
            AL_EFFECT_FREQUENCY_SHIFTER = 0x0006,
            AL_EFFECT_VOCAL_MORPHER = 0x0007,
            AL_EFFECT_PITCH_SHIFTER = 0x0008,
            AL_EFFECT_RING_MODULATOR = 0x0009,
            AL_EFFECT_AUTOWAH = 0x000A,
            AL_EFFECT_COMPRESSOR = 0x000B,
            AL_EFFECT_EQUALIZER = 0x000C,

            AL_EFFECT_EAXREVERB = 0x8000,
        }

        #endregion Effect

        #region Auxiliary Effect Slot

        public enum EfxAuxiliarySlot : int
        {
            // Auxiliary Slot object definitions to be used with alAuxiliaryEffectSlot functions.
            /// <summary>This property is used to attach an Effect object to the Auxiliary Effect Slot object. After the attachment, the Auxiliary Effect Slot object will contain the effect type and have the same effect parameters that were stored in the Effect object. Any Sources feeding the Auxiliary Effect Slot will immediate feed the new effect type and new effect parameters.</summary>
            AL_EFFECTSLOT_EFFECT = 0x0001,
            /// <summary>This property is used to specify an output level for the Auxiliary Effect Slot. Setting the gain to 0.0f mutes the output. Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_EFFECTSLOT_GAIN = 0x0002,
            /// <summary>This property is used to enable or disable automatic send adjustments based on the physical positions of the sources and the listener. This property should be enabled when an application wishes to use a reverb effect to simulate the environment surrounding a listener or a collection of Sources. Range [False .. True] Default: True </summary>
            AL_EFFECTSLOT_AUXILIARY_SEND_AUTO = 0x0003,

            // Value to be used as an Auxiliary Slot ID to disable a source send..
            AL_EFFECTSLOT_NULL = 0x0000,
        }

        #endregion Auxiliary Effect Slot

        #region Filter Object

        // Filter object definitions to be used with alFilter functions.
        public enum EfxFilterf : int
        {
            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_LOWPASS_GAIN = 0x0001,
            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_LOWPASS_GAINHF = 0x0002,

            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_HIGHPASS_GAIN = 0x0001,
            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_HIGHPASS_GAINLF = 0x0002,

            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_BANDPASS_GAIN = 0x0001,
            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_BANDPASS_GAINLF = 0x0002,
            ///<summary>Range [0.0f .. 1.0f] Default: 1.0f</summary>
            AL_BANDPASS_GAINHF = 0x0003,
        }

        // Filter type 
        public enum EfxFilteri : int
        {
            AL_FILTER_FIRST_PARAMETER = 0x0000,
            AL_FILTER_LAST_PARAMETER = 0x8000, // deprecated?
            AL_FILTER_TYPE = 0x8001,
        }

        // Filter type definitions to be used with AL_FILTER_TYPE. 
        public enum EfxFilterType : int
        {
            AL_FILTER_NULL = 0x0000, // Can also be used as a Filter Object ID
            AL_FILTER_LOWPASS = 0x0001,
            AL_FILTER_HIGHPASS = 0x0002,
            AL_FILTER_BANDPASS = 0x0003,
        }

        #endregion Filter Object
    }
}
