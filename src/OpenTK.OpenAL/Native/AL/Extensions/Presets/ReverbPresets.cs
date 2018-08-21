/* EfxPresets.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// EAX-EFX Reverb for use with the OpenAL Effects Extension.
    /// </summary>
    public static class ReverbPresets
    {
        // CASTLE PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small castle room.
        /// </summary>
        public static EfxEaxReverb CastleSmallRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.89f,
            Gain = 0.3162f,
            GainHf = 0.3981f,
            GainLf = 0.1f,
            DecayTime = 1.22f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 0.31f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.022f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.9953f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.138f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a short castle passage.
        /// </summary>
        public static EfxEaxReverb CastleShortPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.89f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 0.1f,
            DecayTime = 2.32f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 0.31f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.023f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.138f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a medium castle room.
        /// </summary>
        public static EfxEaxReverb CastleMediumRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.93f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.1f,
            DecayTime = 2.04f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.631f,
            ReflectionsDelay = 0.022f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.5849f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.155f,
            EchoDepth = 0.03f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long castle passage.
        /// </summary>
        public static EfxEaxReverb CastleLongPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.89f,
            Gain = 0.3162f,
            GainHf = 0.3981f,
            GainLf = 0.1f,
            DecayTime = 3.42f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 0.31f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.023f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.138f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large castle room.
        /// </summary>
        public static EfxEaxReverb CastleLargeRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.1259f,
            DecayTime = 2.53f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 0.5f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.034f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.016f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.185f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a castle hall.
        /// </summary>
        public static EfxEaxReverb CastleHall { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.81f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.1778f,
            DecayTime = 3.14f,
            DecayHfRatio = 0.79f,
            DecayLfRatio = 0.62f,
            ReflectionsGain = 0.1778f,
            ReflectionsDelay = 0.056f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.024f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a castle cupboard.
        /// </summary>
        public static EfxEaxReverb CastleCupboard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.89f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.1f,
            DecayTime = 0.67f,
            DecayHfRatio = 0.87f,
            DecayLfRatio = 0.31f,
            ReflectionsGain = 1.4125f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 3.5481f,
            LateReverbDelay = 0.007f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.138f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a castle courtyard.
        /// </summary>
        public static EfxEaxReverb CastleCourtyard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.42f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.1995f,
            DecayTime = 2.13f,
            DecayHfRatio = 0.61f,
            DecayLfRatio = 0.23f,
            ReflectionsGain = 0.2239f,
            ReflectionsDelay = 0.16f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.036f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.37f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an castle alcove.
        /// </summary>
        public static EfxEaxReverb CastleAlcove { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.89f,
            Gain = 0.3162f,
            GainHf = 0.5012f,
            GainLf = 0.1f,
            DecayTime = 1.64f,
            DecayHfRatio = 0.87f,
            DecayLfRatio = 0.31f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.034f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.138f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5168.6001f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // FACTORY PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an factory alcove.
        /// </summary>
        public static EfxEaxReverb FactoryAlcove { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.59f,
            Gain = 0.2512f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 3.14f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 1.4125f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1f,
            LateReverbDelay = 0.038f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.114f,
            EchoDepth = 0.1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a short factory passage.
        /// </summary>
        public static EfxEaxReverb FactoryShortPassage { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.64f,
            Gain = 0.2512f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 2.53f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.038f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.135f,
            EchoDepth = 0.23f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a medium factory room.
        /// </summary>
        public static EfxEaxReverb FactoryMediumRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.82f,
            Gain = 0.2512f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 2.76f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 0.2818f,
            ReflectionsDelay = 0.022f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.023f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.174f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long factory passage.
        /// </summary>
        public static EfxEaxReverb FactoryLongPassage { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.64f,
            Gain = 0.2512f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 4.06f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.037f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.135f,
            EchoDepth = 0.23f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large factory room.
        /// </summary>
        public static EfxEaxReverb FactoryLargeRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.75f,
            Gain = 0.2512f,
            GainHf = 0.7079f,
            GainLf = 0.631f,
            DecayTime = 4.24f,
            DecayHfRatio = 0.51f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 0.1778f,
            ReflectionsDelay = 0.039f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.023f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.231f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a factory hall.
        /// </summary>
        public static EfxEaxReverb FactoryHall { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.75f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.631f,
            DecayTime = 7.43f,
            DecayHfRatio = 0.51f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 0.0631f,
            ReflectionsDelay = 0.073f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.027f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a factory cubpoard.
        /// </summary>
        public static EfxEaxReverb FactoryCupboard { get; } = new EfxEaxReverb()
        {
            Density = 0.3071f,
            Diffusion = 0.63f,
            Gain = 0.2512f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 0.49f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 1.2589f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.9953f,
            LateReverbDelay = 0.032f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.107f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a factory courtyard.
        /// </summary>
        public static EfxEaxReverb FactoryCourtyard { get; } = new EfxEaxReverb()
        {
            Density = 0.3071f,
            Diffusion = 0.57f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 0.631f,
            DecayTime = 2.32f,
            DecayHfRatio = 0.29f,
            DecayLfRatio = 0.56f,
            ReflectionsGain = 0.2239f,
            ReflectionsDelay = 0.14f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.3981f,
            LateReverbDelay = 0.039f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.29f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small factory room.
        /// </summary>
        public static EfxEaxReverb FactorySmallRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 0.5012f,
            DecayTime = 1.72f,
            DecayHfRatio = 0.65f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 0.7079f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.7783f,
            LateReverbDelay = 0.024f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.119f,
            EchoDepth = 0.07f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3762.6001f,
            LfReference = 362.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // ICE PALACE PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an icepalace alcove.
        /// </summary>
        public static EfxEaxReverb IcepalaceAlcove { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.84f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.2818f,
            DecayTime = 2.76f,
            DecayHfRatio = 1.46f,
            DecayLfRatio = 0.28f,
            ReflectionsGain = 1.122f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.161f,
            EchoDepth = 0.09f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a short icepalace passage.
        /// </summary>
        public static EfxEaxReverb IcepalaceShortPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.75f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.2818f,
            DecayTime = 1.79f,
            DecayHfRatio = 1.46f,
            DecayLfRatio = 0.28f,
            ReflectionsGain = 0.5012f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.019f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.177f,
            EchoDepth = 0.09f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a medium icepalace room.
        /// </summary>
        public static EfxEaxReverb IcepalaceMediumRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.87f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.4467f,
            DecayTime = 2.22f,
            DecayHfRatio = 1.53f,
            DecayLfRatio = 0.32f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.039f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.027f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.186f,
            EchoDepth = 0.12f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long icepalace passage.
        /// </summary>
        public static EfxEaxReverb IcepalaceLongPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.77f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.3981f,
            DecayTime = 3.01f,
            DecayHfRatio = 1.46f,
            DecayLfRatio = 0.28f,
            ReflectionsGain = 0.7943f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.025f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.186f,
            EchoDepth = 0.04f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large icepalace room.
        /// </summary>
        public static EfxEaxReverb IcepalaceLargeRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.81f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.4467f,
            DecayTime = 3.14f,
            DecayHfRatio = 1.53f,
            DecayLfRatio = 0.32f,
            ReflectionsGain = 0.2512f,
            ReflectionsDelay = 0.039f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1f,
            LateReverbDelay = 0.027f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.214f,
            EchoDepth = 0.11f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a icepalace hall.
        /// </summary>
        public static EfxEaxReverb IcepalaceHall { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.76f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.5623f,
            DecayTime = 5.49f,
            DecayHfRatio = 1.53f,
            DecayLfRatio = 0.38f,
            ReflectionsGain = 0.1122f,
            ReflectionsDelay = 0.054f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.631f,
            LateReverbDelay = 0.052f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.226f,
            EchoDepth = 0.11f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a icepalace cupboard.
        /// </summary>
        public static EfxEaxReverb IcepalaceCupboard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.83f,
            Gain = 0.3162f,
            GainHf = 0.5012f,
            GainLf = 0.2239f,
            DecayTime = 0.76f,
            DecayHfRatio = 1.53f,
            DecayLfRatio = 0.26f,
            ReflectionsGain = 1.122f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.9953f,
            LateReverbDelay = 0.016f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.143f,
            EchoDepth = 0.08f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a icepalace courtyard.
        /// </summary>
        public static EfxEaxReverb IcepalaceCourtyard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.59f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.3162f,
            DecayTime = 2.04f,
            DecayHfRatio = 1.2f,
            DecayLfRatio = 0.38f,
            ReflectionsGain = 0.3162f,
            ReflectionsDelay = 0.173f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.3162f,
            LateReverbDelay = 0.043f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.235f,
            EchoDepth = 0.48f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small icepalace room.
        /// </summary>
        public static EfxEaxReverb IcepalaceSmallRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.84f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.2818f,
            DecayTime = 1.51f,
            DecayHfRatio = 1.53f,
            DecayLfRatio = 0.27f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.164f,
            EchoDepth = 0.14f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 12428.5f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // SPACE STATION PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an spacestation alcove.
        /// </summary>
        public static EfxEaxReverb SpacestationAlcove { get; } = new EfxEaxReverb()
        {
            Density = 0.2109f,
            Diffusion = 0.78f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.8913f,
            DecayTime = 1.16f,
            DecayHfRatio = 0.81f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 1.4125f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1f,
            LateReverbDelay = 0.018f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.192f,
            EchoDepth = 0.21f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a medium spacestation room.
        /// </summary>
        public static EfxEaxReverb SpacestationMediumRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.2109f,
            Diffusion = 0.75f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.8913f,
            DecayTime = 3.01f,
            DecayHfRatio = 0.5f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.034f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.035f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.209f,
            EchoDepth = 0.31f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a short spacestation passage.
        /// </summary>
        public static EfxEaxReverb SpacestationShortPassage { get; } = new EfxEaxReverb()
        {
            Density = 0.2109f,
            Diffusion = 0.87f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.8913f,
            DecayTime = 3.57f,
            DecayHfRatio = 0.5f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.016f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.172f,
            EchoDepth = 0.2f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long spacestation passage.
        /// </summary>
        public static EfxEaxReverb SpacestationLongPassage { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.8913f,
            DecayTime = 4.62f,
            DecayHfRatio = 0.62f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.031f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.23f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large spacestation room.
        /// </summary>
        public static EfxEaxReverb SpacestationLargeRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.81f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.8913f,
            DecayTime = 3.89f,
            DecayHfRatio = 0.38f,
            DecayLfRatio = 0.61f,
            ReflectionsGain = 0.3162f,
            ReflectionsDelay = 0.056f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.035f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.233f,
            EchoDepth = 0.28f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a spacestation hall.
        /// </summary>
        public static EfxEaxReverb SpacestationHall { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.87f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.8913f,
            DecayTime = 7.11f,
            DecayHfRatio = 0.38f,
            DecayLfRatio = 0.61f,
            ReflectionsGain = 0.1778f,
            ReflectionsDelay = 0.1f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.631f,
            LateReverbDelay = 0.047f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.25f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a spacestation cupboard.
        /// </summary>
        public static EfxEaxReverb SpacestationCupboard { get; } = new EfxEaxReverb()
        {
            Density = 0.1715f,
            Diffusion = 0.56f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.8913f,
            DecayTime = 0.79f,
            DecayHfRatio = 0.81f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 1.4125f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.7783f,
            LateReverbDelay = 0.018f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.181f,
            EchoDepth = 0.31f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small spacestation room.
        /// </summary>
        public static EfxEaxReverb SpacestationSmallRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.2109f,
            Diffusion = 0.7f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.8913f,
            DecayTime = 1.72f,
            DecayHfRatio = 0.82f,
            DecayLfRatio = 0.55f,
            ReflectionsGain = 0.7943f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.013f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.188f,
            EchoDepth = 0.26f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 3316.1001f,
            LfReference = 458.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // WOODEN GALLEON PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an wooden alcove.
        /// </summary>
        public static EfxEaxReverb WoodenAlcove { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1259f,
            GainLf = 0.3162f,
            DecayTime = 1.22f,
            DecayHfRatio = 0.62f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 1.122f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.024f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a short wooden passage.
        /// </summary>
        public static EfxEaxReverb WoodenShortPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1259f,
            GainLf = 0.3162f,
            DecayTime = 1.75f,
            DecayHfRatio = 0.5f,
            DecayLfRatio = 0.87f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.631f,
            LateReverbDelay = 0.024f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a medium wooden room.
        /// </summary>
        public static EfxEaxReverb WoodenMediumRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1f,
            GainLf = 0.2818f,
            DecayTime = 1.47f,
            DecayHfRatio = 0.42f,
            DecayLfRatio = 0.82f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.049f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.029f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long wooden passage.
        /// </summary>
        public static EfxEaxReverb WoodenLongPassage { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1f,
            GainLf = 0.3162f,
            DecayTime = 1.99f,
            DecayHfRatio = 0.4f,
            DecayLfRatio = 0.79f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.4467f,
            LateReverbDelay = 0.036f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large wooden room.
        /// </summary>
        public static EfxEaxReverb WoodenLargeRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.0891f,
            GainLf = 0.2818f,
            DecayTime = 2.65f,
            DecayHfRatio = 0.33f,
            DecayLfRatio = 0.82f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.066f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7943f,
            LateReverbDelay = 0.049f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a wooden hall.
        /// </summary>
        public static EfxEaxReverb WoodenHall { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.0794f,
            GainLf = 0.2818f,
            DecayTime = 3.45f,
            DecayHfRatio = 0.3f,
            DecayLfRatio = 0.82f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.088f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7943f,
            LateReverbDelay = 0.063f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a wooden cupboard.
        /// </summary>
        public static EfxEaxReverb WoodenCupboard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1413f,
            GainLf = 0.3162f,
            DecayTime = 0.56f,
            DecayHfRatio = 0.46f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 1.122f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.028f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small wooden room.
        /// </summary>
        public static EfxEaxReverb WoodenSmallRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1122f,
            GainLf = 0.3162f,
            DecayTime = 0.79f,
            DecayHfRatio = 0.32f,
            DecayLfRatio = 0.87f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.032f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.029f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a wooden courtyard.
        /// </summary>
        public static EfxEaxReverb WoodenCourtyard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.65f,
            Gain = 0.3162f,
            GainHf = 0.0794f,
            GainLf = 0.3162f,
            DecayTime = 1.79f,
            DecayHfRatio = 0.35f,
            DecayLfRatio = 0.79f,
            ReflectionsGain = 0.5623f,
            ReflectionsDelay = 0.123f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1f,
            LateReverbDelay = 0.032f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4705f,
            LfReference = 99.6f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // SPORTS PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a empty sports stadium.
        /// </summary>
        public static EfxEaxReverb SportEmptyStadium { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.7943f,
            DecayTime = 6.26f,
            DecayHfRatio = 0.51f,
            DecayLfRatio = 1.1f,
            ReflectionsGain = 0.0631f,
            ReflectionsDelay = 0.183f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.3981f,
            LateReverbDelay = 0.038f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a squash court.
        /// </summary>
        public static EfxEaxReverb SportSquashCourt { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.75f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 0.7943f,
            DecayTime = 2.22f,
            DecayHfRatio = 0.91f,
            DecayLfRatio = 1.16f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7943f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.126f,
            EchoDepth = 0.19f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 7176.8999f,
            LfReference = 211.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small swimming pool.
        /// </summary>
        public static EfxEaxReverb SportSmallSwimmingpool { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.7f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 0.8913f,
            DecayTime = 2.76f,
            DecayHfRatio = 1.25f,
            DecayLfRatio = 1.14f,
            ReflectionsGain = 0.631f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7943f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.179f,
            EchoDepth = 0.15f,
            ModulationTime = 0.895f,
            ModulationDepth = 0.19f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large swimming pool.
        /// </summary>
        public static EfxEaxReverb SportLargeSwimmingpool { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 1f,
            DecayTime = 5.49f,
            DecayHfRatio = 1.31f,
            DecayLfRatio = 1.14f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.039f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.5012f,
            LateReverbDelay = 0.049f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.222f,
            EchoDepth = 0.55f,
            ModulationTime = 1.159f,
            ModulationDepth = 0.21f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a sports gymnasium.
        /// </summary>
        public static EfxEaxReverb SportGymnasium { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.81f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.8913f,
            DecayTime = 3.14f,
            DecayHfRatio = 1.06f,
            DecayLfRatio = 1.35f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.029f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.5623f,
            LateReverbDelay = 0.045f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.146f,
            EchoDepth = 0.14f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 7176.8999f,
            LfReference = 211.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a full sports stadium.
        /// </summary>
        public static EfxEaxReverb SportFullStadium { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.0708f,
            GainLf = 0.7943f,
            DecayTime = 5.25f,
            DecayHfRatio = 0.17f,
            DecayLfRatio = 0.8f,
            ReflectionsGain = 0.1f,
            ReflectionsDelay = 0.188f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2818f,
            LateReverbDelay = 0.038f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a sports stadium tannoy.
        /// </summary>
        public static EfxEaxReverb SportStadiumTannoy { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.78f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.5012f,
            DecayTime = 2.53f,
            DecayHfRatio = 0.88f,
            DecayLfRatio = 0.68f,
            ReflectionsGain = 0.2818f,
            ReflectionsDelay = 0.23f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.5012f,
            LateReverbDelay = 0.063f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.2f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // PREFAB PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a workshop.
        /// </summary>
        public static EfxEaxReverb PrefabWorkshop { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1413f,
            GainLf = 0.3981f,
            DecayTime = 0.76f,
            DecayHfRatio = 1f,
            DecayLfRatio = 1f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0.012f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a school room.
        /// </summary>
        public static EfxEaxReverb PrefabSchoolRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.4022f,
            Diffusion = 0.69f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.5012f,
            DecayTime = 0.98f,
            DecayHfRatio = 0.45f,
            DecayLfRatio = 0.18f,
            ReflectionsGain = 1.4125f,
            ReflectionsDelay = 0.017f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.015f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.095f,
            EchoDepth = 0.14f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 7176.8999f,
            LfReference = 211.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a practise room.
        /// </summary>
        public static EfxEaxReverb PrefabPractiseRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.4022f,
            Diffusion = 0.87f,
            Gain = 0.3162f,
            GainHf = 0.3981f,
            GainLf = 0.5012f,
            DecayTime = 1.12f,
            DecayHfRatio = 0.56f,
            DecayLfRatio = 0.18f,
            ReflectionsGain = 1.2589f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.095f,
            EchoDepth = 0.14f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 7176.8999f,
            LfReference = 211.2f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an outhouse.
        /// </summary>
        public static EfxEaxReverb PrefabOuthouse { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.1122f,
            GainLf = 0.1585f,
            DecayTime = 1.38f,
            DecayHfRatio = 0.38f,
            DecayLfRatio = 0.35f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.024f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.631f,
            LateReverbDelay = 0.044f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.121f,
            EchoDepth = 0.17f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 107.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a caravan.
        /// </summary>
        public static EfxEaxReverb PrefabCaravan { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.0891f,
            GainLf = 0.1259f,
            DecayTime = 0.43f,
            DecayHfRatio = 1.5f,
            DecayLfRatio = 1f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.9953f,
            LateReverbDelay = 0.012f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        // DOME AND PIPE PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a dome tomb.
        /// </summary>
        public static EfxEaxReverb DomeTomb { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.79f,
            Gain = 0.3162f,
            GainHf = 0.3548f,
            GainLf = 0.2239f,
            DecayTime = 4.18f,
            DecayHfRatio = 0.21f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.3868f,
            ReflectionsDelay = 0.03f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.6788f,
            LateReverbDelay = 0.022f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.177f,
            EchoDepth = 0.19f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in the saint paul's dome.
        /// </summary>
        public static EfxEaxReverb DomeSaintPauls { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.87f,
            Gain = 0.3162f,
            GainHf = 0.3548f,
            GainLf = 0.2239f,
            DecayTime = 10.48f,
            DecayHfRatio = 0.19f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.1778f,
            ReflectionsDelay = 0.09f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.042f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.12f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small pipe.
        /// </summary>
        public static EfxEaxReverb PipeSmall { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.3548f,
            GainLf = 0.2239f,
            DecayTime = 5.04f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.5012f,
            ReflectionsDelay = 0.032f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 2.5119f,
            LateReverbDelay = 0.015f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a long and thin pipe.
        /// </summary>
        public static EfxEaxReverb PipeLongThin { get; } = new EfxEaxReverb()
        {
            Density = 0.256f,
            Diffusion = 0.91f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.2818f,
            DecayTime = 9.21f,
            DecayHfRatio = 0.18f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.7079f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.022f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a large pipe.
        /// </summary>
        public static EfxEaxReverb PipeLarge { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.3548f,
            GainLf = 0.2239f,
            DecayTime = 8.45f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.046f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.5849f,
            LateReverbDelay = 0.032f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a resonant pipe.
        /// </summary>
        public static EfxEaxReverb PipeResonant { get; } = new EfxEaxReverb()
        {
            Density = 0.1373f,
            Diffusion = 0.91f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.2818f,
            DecayTime = 6.81f,
            DecayHfRatio = 0.18f,
            DecayLfRatio = 0.1f,
            ReflectionsGain = 0.7079f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1f,
            LateReverbDelay = 0.022f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 20f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        // OUTDOORS PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a backyard.
        /// </summary>
        public static EfxEaxReverb OutdoorsBackyard { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.45f,
            Gain = 0.3162f,
            GainHf = 0.2512f,
            GainLf = 0.5012f,
            DecayTime = 1.12f,
            DecayHfRatio = 0.34f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.069f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.023f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.218f,
            EchoDepth = 0.34f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4399.1001f,
            LfReference = 242.9f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in rolling plains.
        /// </summary>
        public static EfxEaxReverb OutdoorsRollingPlains { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0f,
            Gain = 0.3162f,
            GainHf = 0.0112f,
            GainLf = 0.631f,
            DecayTime = 2.13f,
            DecayHfRatio = 0.21f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.1778f,
            ReflectionsDelay = 0.3f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.4467f,
            LateReverbDelay = 0.019f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4399.1001f,
            LfReference = 242.9f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a deep canyon.
        /// </summary>
        public static EfxEaxReverb OutdoorsDeepCanyon { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.74f,
            Gain = 0.3162f,
            GainHf = 0.1778f,
            GainLf = 0.631f,
            DecayTime = 3.89f,
            DecayHfRatio = 0.21f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.3162f,
            ReflectionsDelay = 0.223f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.3548f,
            LateReverbDelay = 0.019f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4399.1001f,
            LfReference = 242.9f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a creek.
        /// </summary>
        public static EfxEaxReverb OutdoorsCreek { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.35f,
            Gain = 0.3162f,
            GainHf = 0.1778f,
            GainLf = 0.5012f,
            DecayTime = 2.13f,
            DecayHfRatio = 0.21f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.115f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.1995f,
            LateReverbDelay = 0.031f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.218f,
            EchoDepth = 0.34f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 4399.1001f,
            LfReference = 242.9f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a valley.
        /// </summary>
        public static EfxEaxReverb OutdoorsValley { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.28f,
            Gain = 0.3162f,
            GainHf = 0.0282f,
            GainLf = 0.1585f,
            DecayTime = 2.88f,
            DecayHfRatio = 0.26f,
            DecayLfRatio = 0.35f,
            ReflectionsGain = 0.1413f,
            ReflectionsDelay = 0.263f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.3981f,
            LateReverbDelay = 0.1f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.34f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 107.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        // MOOD PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a heaven like mood.
        /// </summary>
        public static EfxEaxReverb MoodHeaven { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.94f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 0.4467f,
            DecayTime = 5.04f,
            DecayHfRatio = 1.12f,
            DecayLfRatio = 0.56f,
            ReflectionsGain = 0.2427f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.029f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.08f,
            ModulationTime = 2.742f,
            ModulationDepth = 0.05f,
            AirAbsorptionGainHf = 0.9977f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a hell like mood.
        /// </summary>
        public static EfxEaxReverb MoodHell { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.57f,
            Gain = 0.3162f,
            GainHf = 0.3548f,
            GainLf = 0.4467f,
            DecayTime = 3.57f,
            DecayHfRatio = 0.49f,
            DecayLfRatio = 2f,
            ReflectionsGain = 0f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.11f,
            EchoDepth = 0.04f,
            ModulationTime = 2.109f,
            ModulationDepth = 0.52f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 139.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a feeling like recalling ones memory.
        /// </summary>
        public static EfxEaxReverb MoodMemory { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.85f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 0.3548f,
            DecayTime = 4.06f,
            DecayHfRatio = 0.82f,
            DecayLfRatio = 0.56f,
            ReflectionsGain = 0.0398f,
            ReflectionsDelay = 0f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.122f,
            LateReverbDelay = 0f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.474f,
            ModulationDepth = 0.45f,
            AirAbsorptionGainHf = 0.9886f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        // DRIVING SIMULATION PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like a drivers commentary TODO? correct?.
        /// </summary>
        public static EfxEaxReverb DrivingCommentator { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 0.5012f,
            DecayTime = 2.42f,
            DecayHfRatio = 0.88f,
            DecayLfRatio = 0.68f,
            ReflectionsGain = 0.1995f,
            ReflectionsDelay = 0.093f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2512f,
            LateReverbDelay = 0.017f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9886f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a driving pit garage.
        /// </summary>
        public static EfxEaxReverb DrivingPitGarage { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.59f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.5623f,
            DecayTime = 1.72f,
            DecayHfRatio = 0.93f,
            DecayLfRatio = 0.87f,
            ReflectionsGain = 0.5623f,
            ReflectionsDelay = 0f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.016f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.11f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard from a driving in a car.
        /// </summary>
        public static EfxEaxReverb DrivingIncarRacer { get; } = new EfxEaxReverb()
        {
            Density = 0.0832f,
            Diffusion = 0.8f,
            Gain = 0.3162f,
            GainHf = 1f,
            GainLf = 0.7943f,
            DecayTime = 0.17f,
            DecayHfRatio = 2f,
            DecayLfRatio = 0.41f,
            ReflectionsGain = 1.7783f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.015f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 10268.2002f,
            LfReference = 251f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard from a driving sports car.
        /// </summary>
        public static EfxEaxReverb DrivingIncarSports { get; } = new EfxEaxReverb()
        {
            Density = 0.0832f,
            Diffusion = 0.8f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 1f,
            DecayTime = 0.17f,
            DecayHfRatio = 0.75f,
            DecayLfRatio = 0.41f,
            ReflectionsGain = 1f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.5623f,
            LateReverbDelay = 0f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 10268.2002f,
            LfReference = 251f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard from a driving in a luxury car.
        /// </summary>
        public static EfxEaxReverb DrivingIncarLuxury { get; } = new EfxEaxReverb()
        {
            Density = 0.256f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.1f,
            GainLf = 0.5012f,
            DecayTime = 0.13f,
            DecayHfRatio = 0.41f,
            DecayLfRatio = 0.46f,
            ReflectionsGain = 0.7943f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.5849f,
            LateReverbDelay = 0.01f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 10268.2002f,
            LfReference = 251f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard from a full grandstand.
        /// </summary>
        public static EfxEaxReverb DrivingFullGrandstand { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.631f,
            DecayTime = 3.01f,
            DecayHfRatio = 1.37f,
            DecayLfRatio = 1.28f,
            ReflectionsGain = 0.3548f,
            ReflectionsDelay = 0.09f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1778f,
            LateReverbDelay = 0.049f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 10420.2002f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard from a empty grandstand.
        /// </summary>
        public static EfxEaxReverb DrivingEmptyGrandstand { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 1f,
            GainLf = 0.7943f,
            DecayTime = 4.62f,
            DecayHfRatio = 1.75f,
            DecayLfRatio = 1.4f,
            ReflectionsGain = 0.2082f,
            ReflectionsDelay = 0.09f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2512f,
            LateReverbDelay = 0.049f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 10420.2002f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a tunnel.
        /// </summary>
        public static EfxEaxReverb DrivingTunnel { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.81f,
            Gain = 0.3162f,
            GainHf = 0.3981f,
            GainLf = 0.8913f,
            DecayTime = 3.42f,
            DecayHfRatio = 0.94f,
            DecayLfRatio = 1.31f,
            ReflectionsGain = 0.7079f,
            ReflectionsDelay = 0.051f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7079f,
            LateReverbDelay = 0.047f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.214f,
            EchoDepth = 0.05f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 155.3f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // CITY PRESETS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in the city streets.
        /// </summary>
        public static EfxEaxReverb CityStreets { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.78f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.8913f,
            DecayTime = 1.79f,
            DecayHfRatio = 1.12f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 0.2818f,
            ReflectionsDelay = 0.046f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1995f,
            LateReverbDelay = 0.028f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.2f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a subway.
        /// </summary>
        public static EfxEaxReverb CitySubway { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.74f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 0.8913f,
            DecayTime = 3.01f,
            DecayHfRatio = 1.23f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 0.7079f,
            ReflectionsDelay = 0.046f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.028f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.125f,
            EchoDepth = 0.21f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a museum.
        /// </summary>
        public static EfxEaxReverb CityMuseum { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.1778f,
            GainLf = 0.1778f,
            DecayTime = 3.28f,
            DecayHfRatio = 1.4f,
            DecayLfRatio = 0.57f,
            ReflectionsGain = 0.2512f,
            ReflectionsDelay = 0.039f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.034f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.13f,
            EchoDepth = 0.17f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 107.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a library.
        /// </summary>
        public static EfxEaxReverb CityLibrary { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.2818f,
            GainLf = 0.0891f,
            DecayTime = 2.76f,
            DecayHfRatio = 0.89f,
            DecayLfRatio = 0.41f,
            ReflectionsGain = 0.3548f,
            ReflectionsDelay = 0.029f,
            ReflectionsPan = new Vector3(0f, 0f, -0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.02f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.13f,
            EchoDepth = 0.17f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 2854.3999f,
            LfReference = 107.5f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an underpass.
        /// </summary>
        public static EfxEaxReverb CityUnderpass { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.82f,
            Gain = 0.3162f,
            GainHf = 0.4467f,
            GainLf = 0.8913f,
            DecayTime = 3.57f,
            DecayHfRatio = 1.12f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 0.3981f,
            ReflectionsDelay = 0.059f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.8913f,
            LateReverbDelay = 0.037f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.14f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.992f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an abondoned city.
        /// </summary>
        public static EfxEaxReverb CityAbandoned { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.69f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 0.8913f,
            DecayTime = 3.28f,
            DecayHfRatio = 1.17f,
            DecayLfRatio = 0.91f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.044f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2818f,
            LateReverbDelay = 0.024f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0.2f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9966f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        // MISC ROOMS

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a generic room.
        /// </summary>
        public static EfxEaxReverb Generic { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.8913f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.05f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a padded cell.
        /// </summary>
        public static EfxEaxReverb PaddedCell { get; } = new EfxEaxReverb()
        {
            Density = 0.1715f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.001f,
            GainLf = 1f,
            DecayTime = 0.17f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.25f,
            ReflectionsDelay = 0.001f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2691f,
            LateReverbDelay = 0.002f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a room.
        /// </summary>
        public static EfxEaxReverb Room { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.5929f,
            GainLf = 1f,
            DecayTime = 0.4f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.1503f,
            ReflectionsDelay = 0.002f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.0629f,
            LateReverbDelay = 0.003f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a bathroom.
        /// </summary>
        public static EfxEaxReverb Bathroom { get; } = new EfxEaxReverb()
        {
            Density = 0.1715f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.2512f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.54f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.6531f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 3.2734f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a livingroom.
        /// </summary>
        public static EfxEaxReverb Livingroom { get; } = new EfxEaxReverb()
        {
            Density = 0.9766f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.001f,
            GainLf = 1f,
            DecayTime = 0.5f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2051f,
            ReflectionsDelay = 0.003f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2805f,
            LateReverbDelay = 0.004f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a stone room.
        /// </summary>
        public static EfxEaxReverb StoneRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 1f,
            DecayTime = 2.31f,
            DecayHfRatio = 0.64f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.4411f,
            ReflectionsDelay = 0.012f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.1003f,
            LateReverbDelay = 0.017f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an auditorium.
        /// </summary>
        public static EfxEaxReverb Auditorium { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.5781f,
            GainLf = 1f,
            DecayTime = 4.32f,
            DecayHfRatio = 0.59f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.4032f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.717f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a concerthall.
        /// </summary>
        public static EfxEaxReverb Concerthall { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 1f,
            DecayTime = 3.92f,
            DecayHfRatio = 0.7f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2427f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.9977f,
            LateReverbDelay = 0.029f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a cave.
        /// </summary>
        public static EfxEaxReverb Cave { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 1f,
            GainLf = 1f,
            DecayTime = 2.91f,
            DecayHfRatio = 1.3f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.5f,
            ReflectionsDelay = 0.015f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7063f,
            LateReverbDelay = 0.022f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in an arena.
        /// </summary>
        public static EfxEaxReverb Arena { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.4477f,
            GainLf = 1f,
            DecayTime = 7.24f,
            DecayHfRatio = 0.33f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2612f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.0186f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a hangar.
        /// </summary>
        public static EfxEaxReverb Hangar { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 1f,
            DecayTime = 10.05f,
            DecayHfRatio = 0.23f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.5f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.256f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a carpetted hallway.
        /// </summary>
        public static EfxEaxReverb CarpettedHallway { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.01f,
            GainLf = 1f,
            DecayTime = 0.3f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.1215f,
            ReflectionsDelay = 0.002f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1531f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a hallway.
        /// </summary>
        public static EfxEaxReverb Hallway { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.7079f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.59f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2458f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.6615f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a stone corridor.
        /// </summary>
        public static EfxEaxReverb StoneCorridor { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.7612f,
            GainLf = 1f,
            DecayTime = 2.7f,
            DecayHfRatio = 0.79f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2472f,
            ReflectionsDelay = 0.013f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.5758f,
            LateReverbDelay = 0.02f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a alley.
        /// </summary>
        public static EfxEaxReverb Alley { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.3f,
            Gain = 0.3162f,
            GainHf = 0.7328f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.86f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.25f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.9954f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.125f,
            EchoDepth = 0.95f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a forest.
        /// </summary>
        public static EfxEaxReverb Forest { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.3f,
            Gain = 0.3162f,
            GainHf = 0.0224f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.54f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.0525f,
            ReflectionsDelay = 0.162f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7682f,
            LateReverbDelay = 0.088f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.125f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a city.
        /// </summary>
        public static EfxEaxReverb City { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.5f,
            Gain = 0.3162f,
            GainHf = 0.3981f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.67f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.073f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1427f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in the mountains.
        /// </summary>
        public static EfxEaxReverb Mountains { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.27f,
            Gain = 0.3162f,
            GainHf = 0.0562f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.21f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.0407f,
            ReflectionsDelay = 0.3f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1919f,
            LateReverbDelay = 0.1f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a quarry.
        /// </summary>
        public static EfxEaxReverb Quarry { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.83f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0f,
            ReflectionsDelay = 0.061f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.7783f,
            LateReverbDelay = 0.025f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.125f,
            EchoDepth = 0.7f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in plains.
        /// </summary>
        public static EfxEaxReverb Plain { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.21f,
            Gain = 0.3162f,
            GainHf = 0.1f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.5f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.0585f,
            ReflectionsDelay = 0.179f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.1089f,
            LateReverbDelay = 0.1f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a parking lot.
        /// </summary>
        public static EfxEaxReverb Parkinglot { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 1f,
            GainLf = 1f,
            DecayTime = 1.65f,
            DecayHfRatio = 1.5f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.2082f,
            ReflectionsDelay = 0.008f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.2652f,
            LateReverbDelay = 0.012f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a sewer pipe.
        /// </summary>
        public static EfxEaxReverb Sewerpipe { get; } = new EfxEaxReverb()
        {
            Density = 0.3071f,
            Diffusion = 0.8f,
            Gain = 0.3162f,
            GainHf = 0.3162f,
            GainLf = 1f,
            DecayTime = 2.81f,
            DecayHfRatio = 0.14f,
            DecayLfRatio = 1f,
            ReflectionsGain = 1.6387f,
            ReflectionsDelay = 0.014f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 3.2471f,
            LateReverbDelay = 0.021f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound heard while underwater.
        /// </summary>
        public static EfxEaxReverb Underwater { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 1f,
            Gain = 0.3162f,
            GainHf = 0.01f,
            GainLf = 1f,
            DecayTime = 1.49f,
            DecayHfRatio = 0.1f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.5963f,
            ReflectionsDelay = 0.007f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 7.0795f,
            LateReverbDelay = 0.011f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 1.18f,
            ModulationDepth = 0.348f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a drugged feeling.
        /// </summary>
        public static EfxEaxReverb Drugged { get; } = new EfxEaxReverb()
        {
            Density = 0.4287f,
            Diffusion = 0.5f,
            Gain = 0.3162f,
            GainHf = 1f,
            GainLf = 1f,
            DecayTime = 8.39f,
            DecayHfRatio = 1.39f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.876f,
            ReflectionsDelay = 0.002f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 3.1081f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 1f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a dizzy feeling.
        /// </summary>
        public static EfxEaxReverb Dizzy { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.6f,
            Gain = 0.3162f,
            GainHf = 0.631f,
            GainLf = 1f,
            DecayTime = 17.23f,
            DecayHfRatio = 0.56f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.1392f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.4937f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 1f,
            ModulationTime = 0.81f,
            ModulationDepth = 0.31f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound suggesting a psychotic feeling.
        /// </summary>
        public static EfxEaxReverb Psychotic { get; } = new EfxEaxReverb()
        {
            Density = 0.0625f,
            Diffusion = 0.5f,
            Gain = 0.3162f,
            GainHf = 0.8404f,
            GainLf = 1f,
            DecayTime = 7.56f,
            DecayHfRatio = 0.91f,
            DecayLfRatio = 1f,
            ReflectionsGain = 0.4864f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 2.4378f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 4f,
            ModulationDepth = 1f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a dusty room.
        /// </summary>
        public static EfxEaxReverb DustyRoom { get; } = new EfxEaxReverb()
        {
            Density = 0.3645f,
            Diffusion = 0.56f,
            Gain = 0.3162f,
            GainHf = 0.7943f,
            GainLf = 0.7079f,
            DecayTime = 1.79f,
            DecayHfRatio = 0.38f,
            DecayLfRatio = 0.21f,
            ReflectionsGain = 0.5012f,
            ReflectionsDelay = 0.002f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.2589f,
            LateReverbDelay = 0.006f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.202f,
            EchoDepth = 0.05f,
            ModulationTime = 0.25f,
            ModulationDepth = 0f,
            AirAbsorptionGainHf = 0.9886f,
            HfReference = 13046f,
            LfReference = 163.3f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a chapel.
        /// </summary>
        public static EfxEaxReverb Chapel { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.84f,
            Gain = 0.3162f,
            GainHf = 0.5623f,
            GainLf = 1f,
            DecayTime = 4.62f,
            DecayHfRatio = 0.64f,
            DecayLfRatio = 1.23f,
            ReflectionsGain = 0.4467f,
            ReflectionsDelay = 0.032f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 0.7943f,
            LateReverbDelay = 0.049f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.25f,
            EchoDepth = 0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.11f,
            AirAbsorptionGainHf = 0.9943f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = true,
        };

        /// <summary>
        /// Gets an <see cref="EfxEaxReverb"/> effect which generates sound like in a small water room.
        /// </summary>
        public static EfxEaxReverb SmallWaterRoom { get; } = new EfxEaxReverb()
        {
            Density = 1f,
            Diffusion = 0.7f,
            Gain = 0.3162f,
            GainHf = 0.4477f,
            GainLf = 1f,
            DecayTime = 1.51f,
            DecayHfRatio = 1.25f,
            DecayLfRatio = 1.14f,
            ReflectionsGain = 0.8913f,
            ReflectionsDelay = 0.02f,
            ReflectionsPan = new Vector3(0f, 0f, 0f),
            LateReverbGain = 1.4125f,
            LateReverbDelay = 0.03f,
            LateReverbPan = new Vector3(0f, 0f, 0f),
            EchoTime = 0.179f,
            EchoDepth = 0.15f,
            ModulationTime = 0.895f,
            ModulationDepth = 0.19f,
            AirAbsorptionGainHf = 0.992f,
            HfReference = 5000f,
            LfReference = 250f,
            RoomRolloffFactor = 0f,
            DecayHfLimit = false,
        };
    }
}
