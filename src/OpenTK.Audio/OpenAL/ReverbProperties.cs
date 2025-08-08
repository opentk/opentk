//
// ReverbProperties.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenTK.Mathematics;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Defines a set of predefined reverb properties.
    /// </summary>
    public readonly struct ReverbProperties
    {
        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbDensity"/>.
        /// </summary>
        public readonly float Density;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbDiffusion "/>.
        /// </summary>
        public readonly float Diffusion;

        /// <summary>
        /// The preset value for <ReverbGainsee cref="ReverbParameterName.ReverbGain"/>.
        /// </summary>
        public readonly float Gain;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbGainhf"/>.
        /// </summary>
        public readonly float GainHF;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbGainlf"/>.
        /// </summary>
        public readonly float GainLF;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbDecayTime"/>.
        /// </summary>
        public readonly float DecayTime;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbDecayHfratio"/>.
        /// </summary>
        public readonly float DecayHFRatio;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbDecayLfratio"/>.
        /// </summary>
        public readonly float DecayLFRatio;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbReflectionsGain"/>.
        /// </summary>
        public readonly float ReflectionsGain;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbReflectionsDelay"/>.
        /// </summary>
        public readonly float ReflectionsDelay;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbReflectionsPan"/>.
        /// </summary>
        public readonly Vector3 ReflectionsPan;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbLateReverbGain"/>.
        /// </summary>
        public readonly float LateReverbGain;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbLateReverbDelay"/>.
        /// </summary>
        public readonly float LateReverbDelay;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbLateReverbPan"/>.
        /// </summary>
        public readonly Vector3 LateReverbPan;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbEchoTime"/>.
        /// </summary>
        public readonly float EchoTime;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbEchoDepth"/>.
        /// </summary>
        public readonly float EchoDepth;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbModulationTime"/>.
        /// </summary>
        public readonly float ModulationTime;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbModulationDepth"/>.
        /// </summary>
        public readonly float ModulationDepth;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbAirAbsorptionGainhf"/>.
        /// </summary>
        public readonly float AirAbsorptionGainHF;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbHfreference"/>.
        /// </summary>
        public readonly float HFReference;

        /// <summary>
        /// The preset value for <see cref="EAXReverbParameterName.EaxreverbLfreference"/>.
        /// </summary>
        public readonly float LFReference;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbRoomRolloffFactor"/>.
        /// </summary>
        public readonly float RoomRolloffFactor;

        /// <summary>
        /// The preset value for <see cref="ReverbParameterName.ReverbDecayHflimit"/>.
        /// </summary>
        public readonly int DecayHFLimit;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverbProperties"/> struct.
        /// </summary>
        /// <param name="density">See <see cref="Density"/>.</param>
        /// <param name="diffusion">See <see cref="Diffusion"/>.</param>
        /// <param name="gain">See <see cref="Gain"/>.</param>
        /// <param name="gainHF">See <see cref="GainHF"/>.</param>
        /// <param name="gainLF">See <see cref="GainLF"/>.</param>
        /// <param name="decayTime">See <see cref="DecayTime"/>.</param>
        /// <param name="decayHFRatio">See <see cref="DecayHFRatio"/>.</param>
        /// <param name="decayLFRatio">See <see cref="DecayLFRatio"/>.</param>
        /// <param name="reflectionsGain">See <see cref="ReflectionsGain"/>.</param>
        /// <param name="reflectionsDelay">See <see cref="ReflectionsDelay"/>.</param>
        /// <param name="reflectionsPan">See <see cref="ReflectionsPan"/>.</param>
        /// <param name="lateReverbGain">See <see cref="LateReverbGain"/>.</param>
        /// <param name="lateReverbDelay">See <see cref="LateReverbDelay"/>.</param>
        /// <param name="lateReverbPan">See <see cref="LateReverbPan"/>.</param>
        /// <param name="echoTime">See <see cref="EchoTime"/>.</param>
        /// <param name="echoDepth">See <see cref="EchoDepth"/>.</param>
        /// <param name="modulationTime">See <see cref="ModulationTime"/>.</param>
        /// <param name="modulationDepth">See <see cref="ModulationDepth"/>.</param>
        /// <param name="airAbsorptionGainHF">See <see cref="AirAbsorptionGainHF"/>.</param>
        /// <param name="hfReference">See <see cref="HFReference"/>.</param>
        /// <param name="lfReference">See <see cref="LFReference"/>.</param>
        /// <param name="roomRolloffFactor">See <see cref="RoomRolloffFactor"/>.</param>
        /// <param name="decayHFLimit">See <see cref="DecayHFLimit"/>.</param>
        public ReverbProperties
        (
            float density,
            float diffusion,
            float gain,
            float gainHF,
            float gainLF,
            float decayTime,
            float decayHFRatio,
            float decayLFRatio,
            float reflectionsGain,
            float reflectionsDelay,
            Vector3 reflectionsPan,
            float lateReverbGain,
            float lateReverbDelay,
            Vector3 lateReverbPan,
            float echoTime,
            float echoDepth,
            float modulationTime,
            float modulationDepth,
            float airAbsorptionGainHF,
            float hfReference,
            float lfReference,
            float roomRolloffFactor,
            int decayHFLimit
        )
        {
            Density = density;
            Diffusion = diffusion;
            Gain = gain;
            GainHF = gainHF;
            GainLF = gainLF;
            DecayTime = decayTime;
            DecayHFRatio = decayHFRatio;
            DecayLFRatio = decayLFRatio;
            ReflectionsGain = reflectionsGain;
            ReflectionsDelay = reflectionsDelay;
            ReflectionsPan = reflectionsPan;
            LateReverbGain = lateReverbGain;
            LateReverbDelay = lateReverbDelay;
            LateReverbPan = lateReverbPan;
            EchoTime = echoTime;
            EchoDepth = echoDepth;
            ModulationTime = modulationTime;
            ModulationDepth = modulationDepth;
            AirAbsorptionGainHF = airAbsorptionGainHF;
            HFReference = hfReference;
            LFReference = lfReference;
            RoomRolloffFactor = roomRolloffFactor;
            DecayHFLimit = decayHFLimit;
        }
    }
}
