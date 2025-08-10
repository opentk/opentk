using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorBase
{
    public record DeprecationReason(Version? Version, string? Extension, string? ExplanationLink);
    public record RemoveReason(Version? Version, string? Extension, string? ExplanationLink);

    public record VersionInfo(Version? Version, List<string> Extensions)
    {
        // FIXME: Maybe we should record who removes this thing too?

        public List<DeprecationReason> DeprecatedBy = [];
        public List<RemoveReason> RemovedBy = [];

        public void Deprecate(DeprecationReason reason)
        {
            DeprecatedBy.Add(reason);
        }

        public void Remove(RemoveReason reason)
        {
            RemovedBy.Add(reason);
        }

        public override string ToString()
        {
            // V: X.x Deprecated: Y.y Removed: Z.z Extensions: API_EXT_EXTENSION
            return $"V: {Version}{(DeprecatedBy != null ? $" Deprecated: {string.Join(", ", DeprecatedBy.Select(d => d.Version?.ToString() ?? d.Extension))}" : "")}{(RemovedBy != null ? $"Removed: {string.Join(", ", RemovedBy.Select(d => d.Version?.ToString() ?? d.Extension))}" : "")} Extensions: {string.Join(", ", Extensions)}";
        }
    }

    public interface IReferable
    {
        List<Function> ReferencedBy { get; }
        void MarkReferencedBy(Function function)
        {
            ReferencedBy.Add(function);
        }
    }

    public record Feature
    {
        public required string Name { get; set; }
        public required Version Version { get; set; }
        public required List<RequireTag> RequireTags { get; set; }
        public required List<DeprecateTag> DeprecateTags { get; set; }
        public required List<RemoveTag> RemoveTags { get; set; }

        // OpenGL?
        public GLAPI GLApi { get; set; }

        // OpenGL?
        public ALAPI ALApi { get; set; }

        // Vulkan
        public string? Depends { get; init; }
    }

    public record Extension
    {
        public required string Name { get; init; }
        public required List<RequireTag> RequireTags { get; init; }
        public required List<DeprecateTag> DeprecateTags { get; init; }
        public required List<RemoveTag> RemoveTags { get; init; }

        public string? Comment { get; init; }

        // OpenGL/OpenAL
        public string Vendor { get; init; }

        // OpenGL
        public GLAPI[] SupportedGLApis { get; init; }

        // OpenAL
        public ALAPI[] SupportedALApis { get; init; }

        // Vulkan
        public int Number { get; init; }
        public int SortOrder { get; init; }
        public string? Protect { get; init; }
        public string? Platform { get; init; }
        public string Author { get; init; }
        public string Contact { get; init; }
        public string Type { get; init; }
        public string? Depends { get; init; }
        public string? Supported { get; init; }
        public string? Ratified { get; init; }
        public string? DeprecatedBy { get; init; }
        public string? ObsoletedBy { get; init; }
        public bool Provisional { get; init; }
        public string? SpecialUse { get; init; }
    }



    public record RequireTag
    {
        public required List<CommandRef> Commands { get; init; }
        public required List<EnumRef> Enums { get; init; }
        // FIXME??
        public required List<string> Constants { get; init; }

        public string? Comment { get; init; }

        // OpenGL
        public GLProfile GLProfile { get; init; }
        public GLAPI GLApi { get; init; }

        // OpenAL
        public ALAPI ALApi { get; init; }

        // Vulkan
        public List<TypeRef> Types { get; init; }
        public List<RequireEnum> AddedEnums { get; init; }
        public List<Constant> AddedConstants { get; init; }
    }

    public record DeprecateTag
    {
        public required List<CommandRef> Commands { get; init; }
        public required List<EnumRef> Enums { get; init; }
        // FIXME??
        public required List<string> Constants { get; init; }

        public string? Comment { get; init; }

        // OpenGL
        public GLProfile Profile;

        // Vulkan
        public List<TypeRef> Types { get; init; }
        public string? ExplanationLink { get; init; }
    }

    public record RemoveTag
    {
        public required List<CommandRef> Commands { get; init; }
        public required List<EnumRef> Enums { get; init; }
        // FIXME??
        public required List<string> Constants { get; init; }

        public string? Comment { get; init; }

        // OpenGL
        public GLProfile Profile { get; init; }

        // Vulkan
        public List<TypeRef> Types { get; init; }
        public string? ReasonLink { get; init; }
        // FIXME: Vulkan features...
    }

    // Vulkan
    public record RequireEnum(string Name, int? Value, string Extends, string? Alias, string? Comment);

    public record CommandRef(string Name);
    public record EnumRef(string Name);
    public record TypeRef(string Name);

    // Should this type help us with overloading only
    // or should it also help with type resolution?
    // Type resolution might be too API specific but I'm not too sure...
    public record class Function
    {
        public string? Alias { get; init; }

        public required string Name { get; init; }
        public required string EntryPoint { get; init; }
        public required List<Parameter> Parameters { get; init; }
        public required string ReturnType { get; init; }

        public BaseCSType? StrongReturnType { get; set; }
        public VersionInfo? VersionInfo { get; set; }

        // OpenGL/OpenAL
        public GroupRef[] ReferencedEnumGroups { get; set; }

        // Vulkan
        public CommandType CommandType { get; set; } = CommandType.Invalid;
    }

    public record class Parameter
    {
        public required string Name { get; init; }
        public required string OriginalName { get; init; }
        public required string Type { get; init; }
        public required string? Length { get; init; }

        public BaseCSType? StrongType { get; set; }
        public Expression? StrongLength { get; set; }

        // OpenGL/OpenAL
        public string[] Kinds { get; init; }

        // Vulkan
        public bool Optional { get; init; }
        public bool ExternSync { get; init; }
    }

    public enum ConstantType
    {
        Int32,
        Uint32,
        Uint64,
        Float,
        String,
    }

    // FIXME: Figure out what is Vulkan specific and what generalizes to other APIs.
    public record Constant(ConstantType Type, string Name, string? Extension, string? Comment, ulong IntValue, float FloatValue, string StringValue);

    public interface IStruct : IReferable
    {
        public string Name { get; }
        public List<IStructMember> Members { get; }
        public bool Union { get; }

        public VersionInfo? VersionInfo { get; set; }
    }

    public interface IStructMember
    {
        public string Name { get; }
        public string Type { get; }

        public BaseCSType? StrongType { get; set; }
    }

    public interface IEnum : IReferable
    {
        public string Name { get; }
        public List<IEnumMember> Members { get; }

        public BaseCSType? StrongUnderlyingType { get; set; }
    }

    public interface IEnumMember
    {
        public string Name { get; }
        public ulong Value { get; }

        public VersionInfo? VersionInfo { get; set; }
    }

    public enum APIFile
    {
        // OpenGL
        GL,
        WGL,
        GLX,
        EGL,

        // OpenAL
        AL,
        ALC,

        // Vulkan
        Vulkan,
    }

    #region OpenGL

    /// <param name="OriginalName">The name of the referenced enum group (as seen in the xml files).</param>
    /// <param name="TranslatedName">The name of the referenced enum group (as seen in OpenTK).</param>
    /// <param name="Namespace">The enum namespace that is referenced.</param>
    public record GroupRef(string OriginalName, string TranslatedName, APIFile Namespace);

    public enum GLProfile
    {
        Invalid,
        None,
        Core,
        Compatibility,
        Common,
    }

    public enum GLAPI
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
        GLCore,

        WGL,
        GLX,
        EGL,
    }

    #endregion

    #region OpenAL

    public enum ALAPI
    {
        Invalid,
        None,
        AL,
        ALC,
    }

    #endregion

    #region Vulkan

    public enum CommandType
    {
        /// <summary>This command does not have a resolved command type yet.</summary>
        Invalid,
        /// <summary>This command is one of the global vulkan commands.</summary>
        Global,
        /// <summary>This command is an instance command.</summary>
        Instance,
        /// <summary>This command is a device command.</summary>
        Device,
    }

    #endregion
}
