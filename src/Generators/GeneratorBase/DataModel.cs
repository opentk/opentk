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
