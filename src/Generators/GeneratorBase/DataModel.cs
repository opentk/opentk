using System;
using System.Collections.Generic;
using System.Linq;
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
        List<IFunction> ReferencedBy { get; }
        void MarkReferencedBy(IFunction function)
        {
            ReferencedBy.Add(function);
        }
    }

    public interface IFunction
    {
        public string EntryPoint { get; }
        public string Name { get; }
        public string ReturnType { get; }
        public List<IFunctionParameter> Parameters { get; }

        public BaseCSType? StrongReturnType { get; set; }
        public VersionInfo? VersionInfo { get; set; }
    }

    // Should this type help us with overloading only
    // or should it also help with type resolution?
    // Type resolution might be too API specific but I'm not too sure...
    /*public record class Function
    {
        public string EntryPoint { get; init; }
        public string FunctionName { get; init; }
        public List<Parameter> Parameters { get; init; }
        public BaseCSType ReturnType { get; init; }
        public string? Alias { get; init; }

        public VersionInfo? VersionInfo { get; init; }
    }*/

    public interface IFunctionParameter
    {
        public string OriginalName { get; }
        public string Name { get; }
        public string Type { get; }
        public string? Length { get; }

        public BaseCSType? StrongType { get; set; }
        public Expression? StrongLength { get; set; }
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
}
