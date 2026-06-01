using GeneratorBase;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace ALGenerator.Parsing
{
    internal record EFXPreset(
        string Name,
        float Density,
        float Diffusion,
        float Gain,
        float GainHF,
        float GainLF,
        float DecayTime,
        float DecayHFRatio,
        float DecayLFRatio,
        float ReflectionsGain,
        float RelfectionsDelay,
        Vector3 ReflectionsPan,
        float LateReverbGain,
        float LateReverbDelay,
        Vector3 LateReverbPan,
        float EchoTime,
        float EchoDepth,
        float ModulationTime,
        float ModulationDepth,
        float AirAbsorptionGainHF,
        float HFReference,
        float LFReference,
        float RoomRolloffFactor,
        bool DecayHFLimit);

    internal enum HandleType
    {
        // FIXME:
        Any,
        Source,
        Buffer,
        Effect,
        EffectSlot,
        Filter,
    }
}
