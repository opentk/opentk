#region --- OpenTK.OpenAL License ---
/* EfxPresets.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */
#endregion

using System;


namespace OpenTK.Audio.OpenAL
{
    public partial class EffectsExtension
    {
        // Todo: Add documentation
        // Todo: CLS compliance.

#pragma warning disable 1591

        [CLSCompliant(false)]
        public struct EaxReverb
        {
            public uint Environment;            // TODO: EAX-EFX conversion
            public float EnvironmentSize;       // TODO: EAX-EFX conversion
            public float EnvironmentDiffusion;  // TODO: EAX-EFX conversion
            public int Room;                    // TODO: EAX-EFX conversion
            public int RoomHF;                  // TODO: EAX-EFX conversion
            public int RoomLF;                  // TODO: EAX-EFX conversion
            public float DecayTime;
            public float DecayHFRatio;
            public float DecayLFRatio;
            public int Reflections;             // TODO: EAX-EFX conversion
            public float ReflectionsDelay;
            public Vector3 ReflectionsPan;
            public int Reverb;                  // TODO: EAX-EFX conversion
            public float ReverbDelay;
            public Vector3 ReverbPan;
            public float EchoTime;
            public float EchoDepth;
            public float ModulationTime;
            public float ModulationDepth;
            public float AirAbsorptionHF;
            public float HFReference;
            public float LFReference;
            public float RoomRolloffFactor;
            public uint Flags;                  // TODO: EAX-EFX conversion

            public EaxReverb(uint environment,
                              float environmentSize,
                              float environmentDiffusion,
                              int room,
                              int roomHF,
                              int roomLF,
                              float decayTime,
                              float decayHFRatio,
                              float decayLFRatio,
                              int reflections,
                              float reflectionsDelay,
                              float reflectionsPanX,
                              float reflectionsPanY,
                              float reflectionsPanZ,
                              int reverb,
                              float reverbDelay,
                              float reverbPanX,
                              float reverbPanY,
                              float reverbPanZ,
                              float echoTime,
                              float echoDepth,
                              float modulationTime,
                              float modulationDepth,
                              float airAbsorptionHF,
                              float hfReference,
                              float lfReference,
                              float roomRolloffFactor,
                              uint flags)
            {
                Environment = environment;
                EnvironmentSize = environmentSize;
                EnvironmentDiffusion = environmentDiffusion;
                Room = room;
                RoomHF = roomHF;
                RoomLF = roomLF;
                DecayTime = decayTime;
                DecayHFRatio = decayHFRatio;
                DecayLFRatio = decayLFRatio;
                Reflections = reflections;
                ReflectionsDelay = reflectionsDelay;
                ReflectionsPan = new Vector3(reflectionsPanX, reflectionsPanY, reflectionsPanZ);
                Reverb = reverb;
                ReverbDelay = reverbDelay;
                ReverbPan = new Vector3(reverbPanX, reverbPanY, reverbPanZ);
                EchoTime = echoTime;
                EchoDepth = echoDepth;
                ModulationTime = modulationTime;
                ModulationDepth = modulationDepth;
                AirAbsorptionHF = airAbsorptionHF;
                HFReference = hfReference;
                LFReference = lfReference;
                RoomRolloffFactor = roomRolloffFactor;
                Flags = flags;
            }

        }

        // TODO: CLS compliance.
        [CLSCompliant(false)]
        public static void GetEaxFromEfxEax(ref EaxReverb input, out EfxEaxReverb output)
        {
            output.AirAbsorptionGainHF = 0.995f; // input.AirAbsorptionHF  * somegain?
            output.RoomRolloffFactor = input.RoomRolloffFactor;

            output.Density = 1f; // todo, currently default
            output.Diffusion = 1f; // todo, currently default

            output.DecayTime = input.DecayTime;
            output.DecayHFLimit = 1; // todo, currently default
            output.DecayHFRatio = input.DecayHFRatio;
            output.DecayLFRatio = input.DecayLFRatio;

            output.EchoDepth = input.EchoDepth;
            output.EchoTime = input.EchoTime;

            output.Gain = 0.32f; // todo, currently default
            output.GainHF = 0.89f; // todo, currently default
            output.GainLF = 1f;// todo, currently default

            output.LFReference = input.LFReference;
            output.HFReference = input.HFReference;

            output.LateReverbDelay = input.ReverbDelay;
            output.LateReverbGain = 1.26f; // todo, currently default
            output.LateReverbPan = input.ReverbPan;

            output.ModulationDepth = input.ModulationDepth;
            output.ModulationTime = input.ModulationTime;

            output.ReflectionsDelay = input.ReflectionsDelay;
            output.ReflectionsGain = 0.05f; // todo, currently default
            output.ReflectionsPan = input.ReflectionsPan;
        }

        public struct EfxEaxReverb
        {
            public float Density;
            public float Diffusion;
            public float Gain;
            public float GainHF;
            public float GainLF;
            public float DecayTime;
            public float DecayHFRatio;
            public float DecayLFRatio;
            public float ReflectionsGain;
            public float ReflectionsDelay;
            public Vector3 ReflectionsPan;
            public float LateReverbGain;
            public float LateReverbDelay;
            public Vector3 LateReverbPan;
            public float EchoTime;
            public float EchoDepth;
            public float ModulationTime;
            public float ModulationDepth;
            public float AirAbsorptionGainHF;
            public float HFReference;
            public float LFReference;
            public float RoomRolloffFactor;
            public int DecayHFLimit;
        }

        /*
                     public struct _EAXOBSTRUCTIONPROPERTIES
                     {
                         public int lObstruction;
                         public float flObstructionLFRatio;
                     }
                     _EAXOBSTRUCTIONPROPERTIES EAXOBSTRUCTIONPROPERTIES;//, *LPEAXOBSTRUCTIONPROPERTIES;

                     public struct _EAXOCCLUSIONPROPERTIES
                     {
                         public int lOcclusion;
                         public float flOcclusionLFRatio;
                         public float flOcclusionRoomRatio;
                         public float flOcclusionDirectRatio;
                     }
                     _EAXOCCLUSIONPROPERTIES EAXOCCLUSIONPROPERTIES;//, *LPEAXOCCLUSIONPROPERTIES;

                     public struct _EAXEXCLUSIONPROPERTIES
                     {
                         public int lExclusion;
                         public float flExclusionLFRatio;
                     }
                     _EAXEXCLUSIONPROPERTIES EAXEXCLUSIONPROPERTIES;//, *LPEAXEXCLUSIONPROPERTIES;

                     public struct _EFXLOWPASSFILTER
                     {
                         public float flGain;
                         public float flGainHF;
                     }
                     _EFXLOWPASSFILTER EFXLOWPASSFILTER;//, *LPEFXLOWPASSFILTER;

       
                     void ConvertReverbParameters(EAXREVERBPROPERTIES *pEAXProp, EFXEAXREVERBPROPERTIES *pEFXEAXReverb);
                     void ConvertObstructionParameters(EAXOBSTRUCTIONPROPERTIES *pObProp, EFXLOWPASSFILTER *pDirectLowPassFilter);
                     void ConvertExclusionParameters(EAXEXCLUSIONPROPERTIES *pExProp, EFXLOWPASSFILTER *pSendLowPassFilter);
                     void ConvertOcclusionParameters(EAXOCCLUSIONPROPERTIES *pOcProp, EFXLOWPASSFILTER *pDirectLowPassFilter, EFXLOWPASSFILTER *pSendLowPassFilter);
                             */

        // TODO: CLS compliance.
        ///<summary>EAX Reverb Presets in legacy format - use ConvertReverbParameters() to convert to EFX EAX Reverb Presets for use with the OpenAL Effects Extension.</summary>
        [CLSCompliant(false)]
        public static class ReverbPresets
        {
            // CASTLE PRESETS

            public static EaxReverb CastleSmallRoom = new EaxReverb(26, 8.3f, 0.890f, -1000, -800, -2000, 1.22f, 0.83f, 0.31f, -100, 0.022f, 0f, 0f, 0f, 600, 0.011f, 0f, 0f, 0f, 0.138f, 0.080f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleShortPassage = new EaxReverb(26, 8.3f, 0.890f, -1000, -1000, -2000, 2.32f, 0.83f, 0.31f, -100, 0.007f, 0f, 0f, 0f, 200, 0.023f, 0f, 0f, 0f, 0.138f, 0.080f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleMediumroom = new EaxReverb(26, 8.3f, 0.930f, -1000, -1100, -2000, 2.04f, 0.83f, 0.46f, -400, 0.022f, 0f, 0f, 0f, 400, 0.011f, 0f, 0f, 0f, 0.155f, 0.030f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleLongpassage = new EaxReverb(26, 8.3f, 0.890f, -1000, -800, -2000, 3.42f, 0.83f, 0.31f, -100, 0.007f, 0f, 0f, 0f, 300, 0.023f, 0f, 0f, 0f, 0.138f, 0.080f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleLargeroom = new EaxReverb(26, 8.3f, 0.820f, -1000, -1100, -1800, 2.53f, 0.83f, 0.50f, -700, 0.034f, 0f, 0f, 0f, 200, 0.016f, 0f, 0f, 0f, 0.185f, 0.070f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleHall = new EaxReverb(26, 8.3f, 0.810f, -1000, -1100, -1500, 3.14f, 0.79f, 0.62f, -1500, 0.056f, 0f, 0f, 0f, 100, 0.024f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleCupboard = new EaxReverb(26, 8.3f, 0.890f, -1000, -1100, -2000, 0.67f, 0.87f, 0.31f, 300, 0.010f, 0f, 0f, 0f, 1100, 0.007f, 0f, 0f, 0f, 0.138f, 0.080f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);
            public static EaxReverb CastleCourtyard = new EaxReverb(26, 8.3f, 0.420f, -1000, -700, -1400, 2.13f, 0.61f, 0.23f, -1300, 0.160f, 0f, 0f, 0f, -300, 0.036f, 0f, 0f, 0f, 0.250f, 0.370f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb CastleAlcove = new EaxReverb(26, 8.3f, 0.890f, -1000, -600, -2000, 1.64f, 0.87f, 0.31f, 00, 0.007f, 0f, 0f, 0f, 300, 0.034f, 0f, 0f, 0f, 0.138f, 0.080f, 0.250f, 0f, -5f, 5168.6f, 139.5f, 0f, 0x20);

            // FACTORY PRESETS

            public static EaxReverb FactoryAlcove = new EaxReverb(26, 1.8f, 0.590f, -1200, -200, -600, 3.14f, 0.65f, 1.31f, 300, 0.010f, 0f, 0f, 0f, 000, 0.038f, 0f, 0f, 0f, 0.114f, 0.100f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryShortpassage = new EaxReverb(26, 1.8f, 0.640f, -1200, -200, -600, 2.53f, 0.65f, 1.31f, 0, 0.010f, 0f, 0f, 0f, 200, 0.038f, 0f, 0f, 0f, 0.135f, 0.230f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryMediumroom = new EaxReverb(26, 1.9f, 0.820f, -1200, -200, -600, 2.76f, 0.65f, 1.31f, -1100, 0.022f, 0f, 0f, 0f, 300, 0.023f, 0f, 0f, 0f, 0.174f, 0.070f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryLongpassage = new EaxReverb(26, 1.8f, 0.640f, -1200, -200, -600, 4.06f, 0.65f, 1.31f, 0, 0.020f, 0f, 0f, 0f, 200, 0.037f, 0f, 0f, 0f, 0.135f, 0.230f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryLargeroom = new EaxReverb(26, 1.9f, 0.750f, -1200, -300, -400, 4.24f, 0.51f, 1.31f, -1500, 0.039f, 0f, 0f, 0f, 100, 0.023f, 0f, 0f, 0f, 0.231f, 0.070f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryHall = new EaxReverb(26, 1.9f, 0.750f, -1000, -300, -400, 7.43f, 0.51f, 1.31f, -2400, 0.073f, 0f, 0f, 0f, -100, 0.027f, 0f, 0f, 0f, 0.250f, 0.070f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryCupboard = new EaxReverb(26, 1.7f, 0.630f, -1200, -200, -600, 0.49f, 0.65f, 1.31f, 200, 0.010f, 0f, 0f, 0f, 600, 0.032f, 0f, 0f, 0f, 0.107f, 0.070f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactoryCourtyard = new EaxReverb(26, 1.7f, 0.570f, -1000, -1000, -400, 2.32f, 0.29f, 0.56f, -1300, 0.140f, 0f, 0f, 0f, -800, 0.039f, 0f, 0f, 0f, 0.250f, 0.290f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);
            public static EaxReverb FactorySmallroom = new EaxReverb(26, 1.8f, 0.820f, -1000, -200, -600, 1.72f, 0.65f, 1.31f, -300, 0.010f, 0f, 0f, 0f, 500, 0.024f, 0f, 0f, 0f, 0.119f, 0.070f, 0.250f, 0f, -5f, 3762.6f, 362.5f, 0f, 0x20);

            // ICE PALACE PRESETS

            public static EaxReverb IcepalaceAlcove = new EaxReverb(26, 2.7f, 0.840f, -1000, -500, -1100, 2.76f, 1.46f, 0.28f, 100, 0.010f, 0f, 0f, 0f, -100, 0.030f, 0f, 0f, 0f, 0.161f, 0.090f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceShortpassage = new EaxReverb(26, 2.7f, 0.750f, -1000, -500, -1100, 1.79f, 1.46f, 0.28f, -600, 0.010f, 0f, 0f, 0f, 100, 0.019f, 0f, 0f, 0f, 0.177f, 0.090f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceMediumroom = new EaxReverb(26, 2.7f, 0.870f, -1000, -500, -700, 2.22f, 1.53f, 0.32f, -800, 0.039f, 0f, 0f, 0f, 100, 0.027f, 0f, 0f, 0f, 0.186f, 0.120f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceLongpassage = new EaxReverb(26, 2.7f, 0.770f, -1000, -500, -800, 3.01f, 1.46f, 0.28f, -200, 0.012f, 0f, 0f, 0f, 200, 0.025f, 0f, 0f, 0f, 0.186f, 0.040f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceLargeroom = new EaxReverb(26, 2.9f, 0.810f, -1000, -500, -700, 3.14f, 1.53f, 0.32f, -1200, 0.039f, 0f, 0f, 0f, 000, 0.027f, 0f, 0f, 0f, 0.214f, 0.110f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceHall = new EaxReverb(26, 2.9f, 0.760f, -1000, -700, -500, 5.49f, 1.53f, 0.38f, -1900, 0.054f, 0f, 0f, 0f, -400, 0.052f, 0f, 0f, 0f, 0.226f, 0.110f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceCupboard = new EaxReverb(26, 2.7f, 0.830f, -1000, -600, -1300, 0.76f, 1.53f, 0.26f, 100, 0.012f, 0f, 0f, 0f, 600, 0.016f, 0f, 0f, 0f, 0.143f, 0.080f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceCourtyard = new EaxReverb(26, 2.9f, 0.590f, -1000, -1100, -1000, 2.04f, 1.20f, 0.38f, -1000, 0.173f, 0f, 0f, 0f, -1000, 0.043f, 0f, 0f, 0f, 0.235f, 0.480f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);
            public static EaxReverb IcepalaceSmallroom = new EaxReverb(26, 2.7f, 0.840f, -1000, -500, -1100, 1.51f, 1.53f, 0.27f, -100, 0.010f, 0f, 0f, 0f, 300, 0.011f, 0f, 0f, 0f, 0.164f, 0.140f, 0.250f, 0f, -5f, 12428.5f, 99.6f, 0f, 0x20);

            // SPACE STATION PRESETS

            public static EaxReverb SpacestationAlcove = new EaxReverb(26, 1.5f, 0.780f, -1000, -300, -100, 1.16f, 0.81f, 0.55f, 300, 0.007f, 0f, 0f, 0f, 000, 0.018f, 0f, 0f, 0f, 0.192f, 0.210f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationMediumroom = new EaxReverb(26, 1.5f, 0.750f, -1000, -400, -100, 3.01f, 0.50f, 0.55f, -800, 0.034f, 0f, 0f, 0f, 100, 0.035f, 0f, 0f, 0f, 0.209f, 0.310f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationShortpassage = new EaxReverb(26, 1.5f, 0.870f, -1000, -400, -100, 3.57f, 0.50f, 0.55f, 0, 0.012f, 0f, 0f, 0f, 100, 0.016f, 0f, 0f, 0f, 0.172f, 0.200f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationLongpassage = new EaxReverb(26, 1.9f, 0.820f, -1000, -400, -100, 4.62f, 0.62f, 0.55f, 0, 0.012f, 0f, 0f, 0f, 200, 0.031f, 0f, 0f, 0f, 0.250f, 0.230f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationLargeroom = new EaxReverb(26, 1.8f, 0.810f, -1000, -400, -100, 3.89f, 0.38f, 0.61f, -1000, 0.056f, 0f, 0f, 0f, -100, 0.035f, 0f, 0f, 0f, 0.233f, 0.280f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationHall = new EaxReverb(26, 1.9f, 0.870f, -1000, -400, -100, 7.11f, 0.38f, 0.61f, -1500, 0.100f, 0f, 0f, 0f, -400, 0.047f, 0f, 0f, 0f, 0.250f, 0.250f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationCupboard = new EaxReverb(26, 1.4f, 0.560f, -1000, -300, -100, 0.79f, 0.81f, 0.55f, 300, 0.007f, 0f, 0f, 0f, 500, 0.018f, 0f, 0f, 0f, 0.181f, 0.310f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);
            public static EaxReverb SpacestationSmallroom = new EaxReverb(26, 1.5f, 0.700f, -1000, -300, -100, 1.72f, 0.82f, 0.55f, -200, 0.007f, 0f, 0f, 0f, 300, 0.013f, 0f, 0f, 0f, 0.188f, 0.260f, 0.250f, 0f, -5f, 3316.1f, 458.2f, 0f, 0x20);

            // WOODEN GALLEON PRESETS

            public static EaxReverb WoodenAlcove = new EaxReverb(26, 7.5f, 1f, -1000, -1800, -1000, 1.22f, 0.62f, 0.91f, 100, 0.012f, 0f, 0f, 0f, -300, 0.024f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenShortpassage = new EaxReverb(26, 7.5f, 1f, -1000, -1800, -1000, 1.75f, 0.50f, 0.87f, -100, 0.012f, 0f, 0f, 0f, -400, 0.024f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenMediumroom = new EaxReverb(26, 7.5f, 1f, -1000, -2000, -1100, 1.47f, 0.42f, 0.82f, -100, 0.049f, 0f, 0f, 0f, -100, 0.029f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenLongpassage = new EaxReverb(26, 7.5f, 1f, -1000, -2000, -1000, 1.99f, 0.40f, 0.79f, 000, 0.020f, 0f, 0f, 0f, -700, 0.036f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenLargeroom = new EaxReverb(26, 7.5f, 1f, -1000, -2100, -1100, 2.65f, 0.33f, 0.82f, -100, 0.066f, 0f, 0f, 0f, -200, 0.049f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenHall = new EaxReverb(26, 7.5f, 1f, -1000, -2200, -1100, 3.45f, 0.30f, 0.82f, -100, 0.088f, 0f, 0f, 0f, -200, 0.063f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenCupboard = new EaxReverb(26, 7.5f, 1f, -1000, -1700, -1000, 0.56f, 0.46f, 0.91f, 100, 0.012f, 0f, 0f, 0f, 100, 0.028f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenSmallroom = new EaxReverb(26, 7.5f, 1f, -1000, -1900, -1000, 0.79f, 0.32f, 0.87f, 00, 0.032f, 0f, 0f, 0f, -100, 0.029f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);
            public static EaxReverb WoodenCourtyard = new EaxReverb(26, 7.5f, 0.650f, -1000, -2200, -1000, 1.79f, 0.35f, 0.79f, -500, 0.123f, 0f, 0f, 0f, -2000, 0.032f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 4705f, 99.6f, 0f, 0x3f);

            // SPORTS PRESETS

            public static EaxReverb SportEmptystadium = new EaxReverb(26, 7.2f, 1f, -1000, -700, -200, 6.26f, 0.51f, 1.10f, -2400, 0.183f, 0f, 0f, 0f, -800, 0.038f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb SportSquashcourt = new EaxReverb(26, 7.5f, 0.750f, -1000, -1000, -200, 2.22f, 0.91f, 1.16f, -700, 0.007f, 0f, 0f, 0f, -200, 0.011f, 0f, 0f, 0f, 0.126f, 0.190f, 0.250f, 0f, -5f, 7176.9f, 211.2f, 0f, 0x20);
            public static EaxReverb SportSmallswimmingpool = new EaxReverb(26, 36.2f, 0.700f, -1000, -200, -100, 2.76f, 1.25f, 1.14f, -400, 0.020f, 0f, 0f, 0f, -200, 0.030f, 0f, 0f, 0f, 0.179f, 0.150f, 0.895f, 0.190f, -5f, 5000f, 250f, 0f, 0x0);
            public static EaxReverb SportLargeswimmingpool = new EaxReverb(26, 36.2f, 0.820f, -1000, -200, 0, 5.49f, 1.31f, 1.14f, -700, 0.039f, 0f, 0f, 0f, -600, 0.049f, 0f, 0f, 0f, 0.222f, 0.550f, 1.159f, 0.210f, -5f, 5000f, 250f, 0f, 0x0);
            public static EaxReverb SportGymnasium = new EaxReverb(26, 7.5f, 0.810f, -1000, -700, -100, 3.14f, 1.06f, 1.35f, -800, 0.029f, 0f, 0f, 0f, -500, 0.045f, 0f, 0f, 0f, 0.146f, 0.140f, 0.250f, 0f, -5f, 7176.9f, 211.2f, 0f, 0x20);
            public static EaxReverb SportFullstadium = new EaxReverb(26, 7.2f, 1f, -1000, -2300, -200, 5.25f, 0.17f, 0.80f, -2000, 0.188f, 0f, 0f, 0f, -1100, 0.038f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb SportStadimtannoy = new EaxReverb(26, 3f, 0.780f, -1000, -500, -600, 2.53f, 0.88f, 0.68f, -1100, 0.230f, 0f, 0f, 0f, -600, 0.063f, 0f, 0f, 0f, 0.250f, 0.200f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x20);

            // PREFAB PRESETS

            public static EaxReverb PrefabWorkshop = new EaxReverb(26, 1.9f, 1f, -1000, -1700, -800, 0.76f, 1f, 1f, 0, 0.012f, 0f, 0f, 0f, 100, 0.012f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x0);
            public static EaxReverb PrefabSchoolroom = new EaxReverb(26, 1.86f, 0.690f, -1000, -400, -600, 0.98f, 0.45f, 0.18f, 300, 0.017f, 0f, 0f, 0f, 300, 0.015f, 0f, 0f, 0f, 0.095f, 0.140f, 0.250f, 0f, -5f, 7176.9f, 211.2f, 0f, 0x20);
            public static EaxReverb PrefabPractiseroom = new EaxReverb(26, 1.86f, 0.870f, -1000, -800, -600, 1.12f, 0.56f, 0.18f, 200, 0.010f, 0f, 0f, 0f, 300, 0.011f, 0f, 0f, 0f, 0.095f, 0.140f, 0.250f, 0f, -5f, 7176.9f, 211.2f, 0f, 0x20);
            public static EaxReverb PrefabOuthouse = new EaxReverb(26, 80.3f, 0.820f, -1000, -1900, -1600, 1.38f, 0.38f, 0.35f, -100, 0.024f, 0f, 0f, -0f, -400, 0.044f, 0f, 0f, 0f, 0.121f, 0.170f, 0.250f, 0f, -5f, 2854.4f, 107.5f, 0f, 0x0);
            public static EaxReverb PrefabCaravan = new EaxReverb(26, 8.3f, 1f, -1000, -2100, -1800, 0.43f, 1.50f, 1f, 0, 0.012f, 0f, 0f, 0f, 600, 0.012f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x1f);

            // DOME AND PIPE PRESETS

            public static EaxReverb DomeTomb = new EaxReverb(26, 51.8f, 0.790f, -1000, -900, -1300, 4.18f, 0.21f, 0.10f, -825, 0.030f, 0f, 0f, 0f, 450, 0.022f, 0f, 0f, 0f, 0.177f, 0.190f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x0);
            public static EaxReverb DomeSaintPauls = new EaxReverb(26, 50.3f, 0.870f, -1000, -900, -1300, 10.48f, 0.19f, 0.10f, -1500, 0.090f, 0f, 0f, 0f, 200, 0.042f, 0f, 0f, 0f, 0.250f, 0.120f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x3f);
            public static EaxReverb PipeSmall = new EaxReverb(26, 50.3f, 1f, -1000, -900, -1300, 5.04f, 0.10f, 0.10f, -600, 0.032f, 0f, 0f, 0f, 800, 0.015f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x3f);
            public static EaxReverb PipeLongthin = new EaxReverb(26, 1.6f, 0.910f, -1000, -700, -1100, 9.21f, 0.18f, 0.10f, -300, 0.010f, 0f, 0f, 0f, -300, 0.022f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x0);
            public static EaxReverb PipeLarge = new EaxReverb(26, 50.3f, 1f, -1000, -900, -1300, 8.45f, 0.10f, 0.10f, -800, 0.046f, 0f, 0f, 0f, 400, 0.032f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x3f);
            public static EaxReverb PipeResonant = new EaxReverb(26, 1.3f, 0.910f, -1000, -700, -1100, 6.81f, 0.18f, 0.10f, -300, 0.010f, 0f, 0f, 0f, 00, 0.022f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 2854.4f, 20f, 0f, 0x0);

            // OUTDOORS PRESETS

            public static EaxReverb OutdoorsBackyard = new EaxReverb(26, 80.3f, 0.450f, -1000, -1200, -600, 1.12f, 0.34f, 0.46f, -700, 0.069f, 0f, 0f, -0f, -300, 0.023f, 0f, 0f, 0f, 0.218f, 0.340f, 0.250f, 0f, -5f, 4399.1f, 242.9f, 0f, 0x0);
            public static EaxReverb OutdoorsRollingplains = new EaxReverb(26, 80.3f, 0f, -1000, -3900, -400, 2.13f, 0.21f, 0.46f, -1500, 0.300f, 0f, 0f, -0f, -700, 0.019f, 0f, 0f, 0f, 0.250f, 1f, 0.250f, 0f, -5f, 4399.1f, 242.9f, 0f, 0x0);
            public static EaxReverb OutdoorsDeepcanyon = new EaxReverb(26, 80.3f, 0.740f, -1000, -1500, -400, 3.89f, 0.21f, 0.46f, -1000, 0.223f, 0f, 0f, -0f, -900, 0.019f, 0f, 0f, 0f, 0.250f, 1f, 0.250f, 0f, -5f, 4399.1f, 242.9f, 0f, 0x0);
            public static EaxReverb OutdoorsCreek = new EaxReverb(26, 80.3f, 0.350f, -1000, -1500, -600, 2.13f, 0.21f, 0.46f, -800, 0.115f, 0f, 0f, -0f, -1400, 0.031f, 0f, 0f, 0f, 0.218f, 0.340f, 0.250f, 0f, -5f, 4399.1f, 242.9f, 0f, 0x0);
            public static EaxReverb OutdoorsValley = new EaxReverb(26, 80.3f, 0.280f, -1000, -3100, -1600, 2.88f, 0.26f, 0.35f, -1700, 0.263f, 0f, 0f, -0f, -800, 0.100f, 0f, 0f, 0f, 0.250f, 0.340f, 0.250f, 0f, -5f, 2854.4f, 107.5f, 0f, 0x0);

            // MOOD PRESETS

            public static EaxReverb MoodHeaven = new EaxReverb(26, 19.6f, 0.940f, -1000, -200, -700, 5.04f, 1.12f, 0.56f, -1230, 0.020f, 0f, 0f, 0f, 200, 0.029f, 0f, 0f, 0f, 0.250f, 0.080f, 2.742f, 0.050f, -2f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb MoodHell = new EaxReverb(26, 100f, 0.570f, -1000, -900, -700, 3.57f, 0.49f, 2f, -10000, 0.020f, 0f, 0f, 0f, 300, 0.030f, 0f, 0f, 0f, 0.110f, 0.040f, 2.109f, 0.520f, -5f, 5000f, 139.5f, 0f, 0x40);
            public static EaxReverb MoodMemory = new EaxReverb(26, 8f, 0.850f, -1000, -400, -900, 4.06f, 0.82f, 0.56f, -2800, 0f, 0f, 0f, 0f, 100, 0f, 0f, 0f, 0f, 0.250f, 0f, 0.474f, 0.450f, -10f, 5000f, 250f, 0f, 0x0);

            // DRIVING SIMULATION PRESETS

            public static EaxReverb DrivingCommentator = new EaxReverb(26, 3f, 0f, 1000, -500, -600, 2.42f, 0.88f, 0.68f, -1400, 0.093f, 0f, 0f, 0f, -1200, 0.017f, 0f, 0f, 0f, 0.250f, 1f, 0.250f, 0f, -10f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb DrivingPitgarage = new EaxReverb(26, 1.9f, 0.590f, -1000, -300, -500, 1.72f, 0.93f, 0.87f, -500, 0f, 0f, 0f, 0f, 200, 0.016f, 0f, 0f, 0f, 0.250f, 0.110f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x0);
            public static EaxReverb DrivingIncarRacer = new EaxReverb(26, 1.1f, 0.800f, -1000, 0, -200, 0.17f, 2f, 0.41f, 500, 0.007f, 0f, 0f, 0f, -300, 0.015f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 10268.2f, 251f, 0f, 0x20);
            public static EaxReverb DrivingIncarSports = new EaxReverb(26, 1.1f, 0.800f, -1000, -400, 0, 0.17f, 0.75f, 0.41f, 0, 0.010f, 0f, 0f, 0f, -500, 0f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 10268.2f, 251f, 0f, 0x20);
            public static EaxReverb DrivingIncarLuxury = new EaxReverb(26, 1.6f, 1f, -1000, -2000, -600, 0.13f, 0.41f, 0.46f, -200, 0.010f, 0f, 0f, 0f, 400, 0.010f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 10268.2f, 251f, 0f, 0x20);
            public static EaxReverb DrivingFullgrandstand = new EaxReverb(26, 8.3f, 1f, -1000, -1100, -400, 3.01f, 1.37f, 1.28f, -900, 0.090f, 0f, 0f, 0f, -1500, 0.049f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 10420.2f, 250f, 0f, 0x1f);
            public static EaxReverb DrivingEmptygrandstand = new EaxReverb(26, 8.3f, 1f, -1000, 0, -200, 4.62f, 1.75f, 1.40f, -1363, 0.090f, 0f, 0f, 0f, -1200, 0.049f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 10420.2f, 250f, 0f, 0x1f);
            public static EaxReverb DrivingTunnel = new EaxReverb(26, 3.1f, 0.810f, -1000, -800, -100, 3.42f, 0.94f, 1.31f, -300, 0.051f, 0f, 0f, 0f, -300, 0.047f, 0f, 0f, 0f, 0.214f, 0.050f, 0.250f, 0f, -5f, 5000f, 155.3f, 0f, 0x20);

            // CITY PRESETS

            public static EaxReverb CityStreets = new EaxReverb(26, 3f, 0.780f, -1000, -300, -100, 1.79f, 1.12f, 0.91f, -1100, 0.046f, 0f, 0f, 0f, -1400, 0.028f, 0f, 0f, 0f, 0.250f, 0.200f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb CitySubway = new EaxReverb(26, 3f, 0.740f, -1000, -300, -100, 3.01f, 1.23f, 0.91f, -300, 0.046f, 0f, 0f, 0f, 200, 0.028f, 0f, 0f, 0f, 0.125f, 0.210f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb CityMuseum = new EaxReverb(26, 80.3f, 0.820f, -1000, -1500, -1500, 3.28f, 1.40f, 0.57f, -1200, 0.039f, 0f, 0f, -0f, -100, 0.034f, 0f, 0f, 0f, 0.130f, 0.170f, 0.250f, 0f, -5f, 2854.4f, 107.5f, 0f, 0x0);
            public static EaxReverb CityLibrary = new EaxReverb(26, 80.3f, 0.820f, -1000, -1100, -2100, 2.76f, 0.89f, 0.41f, -900, 0.029f, 0f, 0f, -0f, -100, 0.020f, 0f, 0f, 0f, 0.130f, 0.170f, 0.250f, 0f, -5f, 2854.4f, 107.5f, 0f, 0x0);
            public static EaxReverb CityUnderpass = new EaxReverb(26, 3f, 0.820f, -1000, -700, -100, 3.57f, 1.12f, 0.91f, -800, 0.059f, 0f, 0f, 0f, -100, 0.037f, 0f, 0f, 0f, 0.250f, 0.140f, 0.250f, 0f, -7f, 5000f, 250f, 0f, 0x20);
            public static EaxReverb CityAbandoned = new EaxReverb(26, 3f, 0.690f, -1000, -200, -100, 3.28f, 1.17f, 0.91f, -700, 0.044f, 0f, 0f, 0f, -1100, 0.024f, 0f, 0f, 0f, 0.250f, 0.200f, 0.250f, 0f, -3f, 5000f, 250f, 0f, 0x20);

            // MISC ROOMS

            public static EaxReverb Generic = new EaxReverb(0, 7.5f, 1f, -1000, -100, 0, 1.49f, 0.83f, 1f, -2602, 0.007f, 0f, 0f, 0f, 200, 0.011f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Paddedcell = new EaxReverb(1, 1.4f, 1f, -1000, -6000, 0, 0.17f, 0.10f, 1f, -1204, 0.001f, 0f, 0f, 0f, 207, 0.002f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Room = new EaxReverb(2, 1.9f, 1f, -1000, -454, 0, 0.40f, 0.83f, 1f, -1646, 0.002f, 0f, 0f, 0f, 53, 0.003f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Bathroom = new EaxReverb(3, 1.4f, 1f, -1000, -1200, 0, 1.49f, 0.54f, 1f, -370, 0.007f, 0f, 0f, 0f, 1030, 0.011f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Livingroom = new EaxReverb(4, 2.5f, 1f, -1000, -6000, 0, 0.50f, 0.10f, 1f, -1376, 0.003f, 0f, 0f, 0f, -1104, 0.004f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Stoneroom = new EaxReverb(5, 11.6f, 1f, -1000, -300, 0, 2.31f, 0.64f, 1f, -711, 0.012f, 0f, 0f, 0f, 83, 0.017f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Auditorium = new EaxReverb(6, 21.6f, 1f, -1000, -476, 0, 4.32f, 0.59f, 1f, -789, 0.020f, 0f, 0f, 0f, -289, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Concerthall = new EaxReverb(7, 19.6f, 1f, -1000, -500, 0, 3.92f, 0.70f, 1f, -1230, 0.020f, 0f, 0f, 0f, -02, 0.029f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Cave = new EaxReverb(8, 14.6f, 1f, -1000, 0, 0, 2.91f, 1.30f, 1f, -602, 0.015f, 0f, 0f, 0f, -302, 0.022f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Arena = new EaxReverb(9, 36.2f, 1f, -1000, -698, 0, 7.24f, 0.33f, 1f, -1166, 0.020f, 0f, 0f, 0f, 16, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Hangar = new EaxReverb(10, 50.3f, 1f, -1000, -1000, 0, 10.05f, 0.23f, 1f, -602, 0.020f, 0f, 0f, 0f, 198, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Carpettedhallway = new EaxReverb(11, 1.9f, 1f, -1000, -4000, 0, 0.30f, 0.10f, 1f, -1831, 0.002f, 0f, 0f, 0f, -1630, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Hallway = new EaxReverb(12, 1.8f, 1f, -1000, -300, 0, 1.49f, 0.59f, 1f, -1219, 0.007f, 0f, 0f, 0f, 441, 0.011f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Stonecorridor = new EaxReverb(13, 13.5f, 1f, -1000, -237, 0, 2.70f, 0.79f, 1f, -1214, 0.013f, 0f, 0f, 0f, 395, 0.020f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Alley = new EaxReverb(14, 7.5f, 0.300f, -1000, -270, 0, 1.49f, 0.86f, 1f, -1204, 0.007f, 0f, 0f, 0f, -4, 0.011f, 0f, 0f, 0f, 0.125f, 0.950f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Forest = new EaxReverb(15, 38f, 0.300f, -1000, -3300, 0, 1.49f, 0.54f, 1f, -2560, 0.162f, 0f, 0f, 0f, -229, 0.088f, 0f, 0f, 0f, 0.125f, 1f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb City = new EaxReverb(16, 7.5f, 0.500f, -1000, -800, 0, 1.49f, 0.67f, 1f, -2273, 0.007f, 0f, 0f, 0f, -1691, 0.011f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Mountains = new EaxReverb(17, 100f, 0.270f, -1000, -2500, 0, 1.49f, 0.21f, 1f, -2780, 0.300f, 0f, 0f, 0f, -1434, 0.100f, 0f, 0f, 0f, 0.250f, 1f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Quarry = new EaxReverb(18, 17.5f, 1f, -1000, -1000, 0, 1.49f, 0.83f, 1f, -10000, 0.061f, 0f, 0f, 0f, 500, 0.025f, 0f, 0f, 0f, 0.125f, 0.700f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Plain = new EaxReverb(19, 42.5f, 0.210f, -1000, -2000, 0, 1.49f, 0.50f, 1f, -2466, 0.179f, 0f, 0f, 0f, -1926, 0.100f, 0f, 0f, 0f, 0.250f, 1f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Parkinglot = new EaxReverb(20, 8.3f, 1f, -1000, 0, 0, 1.65f, 1.50f, 1f, -1363, 0.008f, 0f, 0f, 0f, -1153, 0.012f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Sewerpipe = new EaxReverb(21, 1.7f, 0.800f, -1000, -1000, 0, 2.81f, 0.14f, 1f, 429, 0.014f, 0f, 0f, 0f, 1023, 0.021f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Underwater = new EaxReverb(22, 1.8f, 1f, -1000, -4000, 0, 1.49f, 0.10f, 1f, -449, 0.007f, 0f, 0f, 0f, 1700, 0.011f, 0f, 0f, 0f, 0.250f, 0f, 1.180f, 0.348f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Drugged = new EaxReverb(23, 1.9f, 0.500f, -1000, 0, 0, 8.39f, 1.39f, 1f, -115, 0.002f, 0f, 0f, 0f, 985, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 1f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Dizzy = new EaxReverb(24, 1.8f, 0.600f, -1000, -400, 0, 17.23f, 0.56f, 1f, -1713, 0.020f, 0f, 0f, 0f, -613, 0.030f, 0f, 0f, 0f, 0.250f, 1f, 0.810f, 0.310f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Psychotic = new EaxReverb(25, 1f, 0.500f, -1000, -151, 0, 7.56f, 0.91f, 1f, -626, 0.020f, 0f, 0f, 0f, 774, 0.030f, 0f, 0f, 0f, 0.250f, 0f, 4f, 1f, -5f, 5000f, 250f, 0f, 0x1f);
            public static EaxReverb Dustyroom = new EaxReverb(26, 1.8f, 0.560f, -1000, -200, -300, 1.79f, 0.38f, 0.21f, -600, 0.002f, 0f, 0f, 0f, 200, 0.006f, 0f, 0f, 0f, 0.202f, 0.050f, 0.250f, 0f, -10f, 13046f, 163.3f, 0f, 0x20);
            public static EaxReverb Chapel = new EaxReverb(26, 19.6f, 0.840f, -1000, -500, 0, 4.62f, 0.64f, 1.23f, -700, 0.032f, 0f, 0f, 0f, -200, 0.049f, 0f, 0f, 0f, 0.250f, 0f, 0.250f, 0.110f, -5f, 5000f, 250f, 0f, 0x3f);
            public static EaxReverb Smallwaterroom = new EaxReverb(26, 36.2f, 0.700f, -1000, -698, 0, 1.51f, 1.25f, 1.14f, -100, 0.020f, 0f, 0f, 0f, 300, 0.030f, 0f, 0f, 0f, 0.179f, 0.150f, 0.895f, 0.190f, -7f, 5000f, 250f, 0f, 0x0);
        }

#pragma warning restore 1591
    }
}
