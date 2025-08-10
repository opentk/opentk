using GeneratorBase;
using GLGenerator.Process;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO.Compression;
using System.Linq;

namespace GLGenerator.Parsing
{
    internal enum InputAPI
    {
        GL,
        GLES1,
        GLES2,
        WGL,
        GLX,
        EGL,
    }

    [Flags]
    internal enum EnumAPI
    {
        None = 0,
        GL = 1 << 0,
        GLCompat = 1 << 1,
        GLES1 = 1 << 2,
        GLES2 = 1 << 3,
        WGL = 1 << 4,
        GLX = 1 << 5,
        EGL = 1 << 6,
    }

    internal record Specification(
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
        List<ExtensionReference> PartOfExtensions,
        GLProfile Profile);

    internal record EnumReference(
        string EnumName,
        Version? AddedIn,
        Version? RemovedIn,
        List<ExtensionReference> PartOfExtensions,
        // FIXME! there can be multiple profiles??
        GLProfile Profile,
        // Is this enum reference copied from another namespace.
        bool IsCrossReferenced);

    internal record APIVersion(
        Version Name,
        List<string> EntryPoints,
        List<string> EnumValues);

    internal record ExtensionReference(string Name, string Vendor);

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

    internal enum HandleType
    {
        ProgramHandle,
        ProgramPipelineHandle,
        TextureHandle,
        BufferHandle,
        ShaderHandle,
        QueryHandle,
        FramebufferHandle,
        RenderbufferHandle,
        SamplerHandle,
        TransformFeedbackHandle,
        VertexArrayHandle,
        DisplayListHandle,
        PerfQueryHandle,
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
