using ALGenerator.Process;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.IO.Compression;

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

    internal record GLFileData(
        ALFile File,
        List<NativeFunction> Functions,
        List<EnumEntry> Enums,
        List<API> APIs);

    internal record Specification2(
        //List<Command> Commands,
        List<NativeFunction> Functions,
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
        //List<string> EntryPoints,
        //List<string> EnumValues);


    /*internal record Specification(
        List<Command> Commands,
        List<Enums> Enums,
        List<Feature> Features,
        List<Extension> Extensions);*/


    /*internal record Command(
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);*/

    // FIXME: Maybe flatten the list of enums?
    /*internal record Enums(
        string Namespace,
        GroupRef[] Groups,
        EnumType Type,
        string? Vendor,
        Range? Range,
        string? Comment,
        List<EnumEntry> Entries);*/

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


    internal record Feature(
        ALAPI Api,
        Version Version,
        string Name,
        List<RequireEntry> Requires,
        List<RemoveEntry> Removes);

    internal record Extension(
        string Name,
        string Vendor,
        ALAPI[] SupportedApis,
        string? Comment,
        List<RequireEntry> Requires);


    internal record RequireEntry(
        ALAPI Api,
        string? Comment,
        List<string> Commands,
        List<string> Enums);

    internal record RemoveEntry(
        string? Comment,
        List<string> Commands,
        List<string> Enums);


    internal record PType(
        GLType Type,
        HandleType? Handle,
        GroupRef? Group);

    internal enum ALFile
    {
        AL,
        ALC,
    }

    /// <param name="OriginalName">The name of the referenced enum group (as seen in the xml files).</param>
    /// <param name="TranslatedName">The name of the referenced enum group (as seen in OpenTK).</param>
    /// <param name="Namespace">The enum namespace that is referenced (gl, wgl, or glx).</param>
    internal record GroupRef(string OriginalName, string TranslatedName, ALFile Namespace);

    internal abstract record GLType();

    internal record GLBaseType(
        string OriginalString,
        PrimitiveType Type,
        bool Constant) : GLType;

    internal record GLPointerType(
        GLType BaseType,
        bool Constant) : GLType;


    


    internal enum ALAPI
    {
        Invalid,
        None,
        AL,
        ALC,
    }

    internal enum PrimitiveType
    {
        Invalid,

        Void,
        Byte,
        Sbyte,
        Short,
        Ushort,
        Int,
        Uint,
        Long,
        Ulong,
        Half,
        Float,
        Double,
        IntPtr,
        Nint,
        Enum,
        Bool8,
        Bool32,
        Char8,
        VoidPtr,
    }

    internal enum HandleType
    {
        // FIXME:
        Handle,
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
