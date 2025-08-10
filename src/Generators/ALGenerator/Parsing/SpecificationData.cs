using ALGenerator.Process;
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
    internal enum InputAPI
    {
        AL,
        ALC,
    }

    [Flags]
    internal enum EnumAPI
    {
        None = 0,
        AL = 1 << 0,
        ALC = 1 << 1,
    }

    internal record Specification(
        //List<Command> Commands,
        List<Function> Functions,
        List<EnumEntry> Enums,
        List<API> APIs);

    internal record API(
        InputAPI Name,
        List<FunctionReference> Functions,
        List<EnumReference> Enums);

    internal record FunctionReference(
        string EntryPoint,
        Version? AddedIn,
        Version? RemovedIn,
        List<ExtensionReference> PartOfExtensions);

    internal record EnumReference(
        string EnumName,
        Version? AddedIn,
        Version? RemovedIn,
        List<ExtensionReference> PartOfExtensions,
        // Is this enum reference copied from another namespace.
        bool IsCrossReferenced);

    internal record APIVersion(
        Version Name,
        List<string> EntryPoints,
        List<string> EnumValues);

    internal record ExtensionReference(
        string Name,
        string Vendor);

    internal record EnumEntry(
        string Name,
        string MangledName,
        ulong Value,
        OutputApiFlags Apis,
        EnumType Type,
        string? Vendor,
        string? Alias,
        GroupRef[] Groups,
        TypeSuffix Suffix);

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

    internal enum EnumType
    {
        Invalid,
        None,
        Bitmask
    }

    /// <summary>
    /// "
    /// Legal C suffix for the value to force it to a specific type.
    /// Currently only \code{u} and \code{ull} are used,
    /// for \code{unsigned} 32 - and 64 - bit integer values, respectively.
    /// Separated from the \attr{value} field since this eases parsing and
    /// sorting of values, and is rarely used.
    /// "
    /// <br/>
    /// Taken from <see href="https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383">KhronosGroup/OpenGL-Registry/xml/readme.tex#L383</see> 2020-11-22
    /// </summary>
    internal enum TypeSuffix
    {
        Invalid,
        None,
        U,
        Ull,
    }
}
