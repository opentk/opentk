using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Parsing
{
    public enum GLAPI
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
        GLCore,
    }

    public enum GLProfile
    {
        Invalid,
        None,
        Core,
        Compatibility,
        Common,
        // FIXME...
    }

    public enum PrimitiveType
    {
        Invalid,
        Void,
        Bool8,
        Byte,
        Char8,
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
        VoidPtr,

        Enum,

        GLHandleARB,

        // The following have a custom c# implementation in the writer.
        GLSync,
        CLContext,
        CLEvent,
        GLDEBUGPROC,
        GLDEBUGPROCARB,
        GLDEBUGPROCKHR,
        GLDEBUGPROCAMD,
        GLDEBUGPROCNV,
    }

    public record GLType();

    public record GLBaseType(string OriginalString, PrimitiveType Type, bool Constant) : GLType;

    public record GLPointerType(GLType BaseType, bool Constant) : GLType;

    public record GLArrayType(GLType BaseType, int Length, bool Constant) : GLType;

    public record PType(GLType Type, string? Group);

    public record GLParameter(PType Type, string Name, Expression? Length);

    public record Command(string EntryPoint, PType ReturnType, GLParameter[] Parameters);

    public enum EnumType
    {
        Invalid,
        None,
        Bitmask
    }

    public record EnumsEntry(
        string Namespace,
        string[]? Groups,
        EnumType Type,
        string? Vendor,
        Range? Range,
        string? Comment,
        List<EnumEntry> Enums);

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
    public enum TypeSuffix
    {
        Invalid,
        None,
        U,
        Ull,
    }

    public record EnumEntry(
        string Name,
        GLAPI Api,
        ulong Value,
        string? Alias,
        string? Comment,
        string[]? Groups,
        TypeSuffix Type);

    public record RequireEntry(
        GLAPI Api,
        GLProfile Profile,
        string? Comment,
        List<string> Commands,
        List<string> Enums);

    public record RemoveEntry(
        GLProfile Profile,
        string? Comment,
        List<string> Commands,
        List<string> Enums);

    public record Extension(
        string Name,
        string Vendor,
        GLAPI[] SupportedApis,
        string? Comment,
        List<RequireEntry> Requires);

    public record Feature(
        GLAPI Api,
        Version Version,
        string Name,
        List<RequireEntry> Requires,
        List<RemoveEntry> Removes);

    public record Specification(
        List<Command> Commands,
        List<EnumsEntry> Enums,
        List<Feature> Features,
        List<Extension> Extensions);
}
