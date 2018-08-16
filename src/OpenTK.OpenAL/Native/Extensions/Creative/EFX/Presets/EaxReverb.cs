/* EfxPresets.cs
 * C headers: \OpenAL 1.1 SDK\include\ "efx.h", "efx-creative.h", "Efx-Util.h"
 * Spec: Effects Extension Guide.pdf (bundled with OpenAL SDK)
 * Copyright (c) 2008 Christoph Brandtner and Stefanos Apostolopoulos
 * See license.txt for license details
 * http://www.OpenTK.net */

using OpenTK.Mathematics;

namespace OpenTK.OpenAL.Native.Extensions.Creative.EFX
{
    public struct EaxReverb
    {
        public uint Environment; // TODO: EAX-EFX conversion
        public float EnvironmentSize; // TODO: EAX-EFX conversion
        public float EnvironmentDiffusion; // TODO: EAX-EFX conversion
        public int Room; // TODO: EAX-EFX conversion
        public int RoomHF; // TODO: EAX-EFX conversion
        public int RoomLF; // TODO: EAX-EFX conversion
        public float DecayTime;
        public float DecayHFRatio;
        public float DecayLFRatio;
        public int Reflections; // TODO: EAX-EFX conversion
        public float ReflectionsDelay;
        public Vector3 ReflectionsPan;
        public int Reverb; // TODO: EAX-EFX conversion
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
        public uint Flags; // TODO: EAX-EFX conversion

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
}
