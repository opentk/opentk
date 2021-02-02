using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeneratorV2.Writing
{
    public enum OutputApi
    {
        Invalid,
        GL,
        GLES,
    }

    public abstract record BaseCSType()
    {
        // We use a custom To string here to allow tostring to be used for debugging,
        // also this way we make sure you have to override the tostring method.
        public abstract string ToCSString();
    }

    [DebuggerDisplay("{TypeName} (Constant = {Constant})")]
    public record CSType(string TypeName, bool Constant) : BaseCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSChar8(bool Constant) : BaseCSType
    {
        public override string ToCSString()
        {
            return "byte";
        }
    }

    // FIXME: Think through size, see GLArrayType
    public record CSArray(BaseCSType BaseType, bool Readonly) : BaseCSType
    {
        public override string ToCSString()
        {
            // FIXME: Maybe do something with size or constant??
            return $"{BaseType.ToCSString()}[]";
        }
    }

    public record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType
    {
        public override string ToCSString()
        {
            // FIXME: Maybe do something with constant??
            return $"{BaseType.ToCSString()}*";
        }
    }

    public record CSVoid() : BaseCSType
    {
        public override string ToCSString() => "void";
    }

    public record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType
    {
        public enum Type { Ref, Out, In }

        public override string ToCSString()
        {
            string modifier = RefType switch
            {
                Type.Ref => "ref",
                Type.Out => "out",
                Type.In => "in",
                _ => throw new Exception()
            };
            return $"{modifier} {ReferencedType.ToCSString()}";
        }
    }

    public record CSString(bool Nullable) : BaseCSType
    {
        public override string ToCSString()
        {
            return $"string{(Nullable ? "?" : "")}";
        }
    }

    public record CSSpan(BaseCSType BaseType, bool Readonly) : BaseCSType
    {
        public override string ToCSString()
        {
            if (Readonly)
            {
                return $"ReadOnlySpan<{BaseType.ToCSString()}>";
            }
            else
            {
                return $"Span<{BaseType.ToCSString()}>";
            }
        }
    }

    public record CSGenericType(string GenericTypeName) : BaseCSType
    {
        public override string ToCSString()
        {
            return GenericTypeName;
        }
    }

    public record Parameter(
        BaseCSType Type,
        string Name,
        // FIXME: This is only used for overloading,
        // this is the parsed version of the length without processing.
        // We might want to do further processing on this before overloading, or move it.
        Expression? Length);

    public record NativeFunction(
        string EntryPoint,
        string FunctionName,
        List<Parameter> Parameters,
        BaseCSType ReturnType);

    public record OverloadedFunction(NativeFunction NativeFunction, Overload[] Overloads, bool ChangeNativeName);

    public interface IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads);
    }

    // FIXME: We could maybe move this into the Overload class
    // and make the overloads inherit from this Overload.
    // Might be a cleaner solution, and stuff like that.
    public interface IOverloadLayer
    {
        public void WritePrologue(IndentedTextWriter writer);
        public string? WriteEpilogue(IndentedTextWriter writer, string? returnName);
    }

    public record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        NativeFunction NativeFunction,
        BaseCSType ReturnType,
        string ReturnVariableName,
        string[] GenericTypes);

    public record OverloaderNativeFunction(
        NativeFunction Function,
        bool PostfixName);

    public record OverloaderFunctionOverloads(
        Overload[] Overloads,
        bool PostfixName);

    // FIXME: Better name
    public record EnumMemberData(
        string Name,
        ulong Value,
        string[]? Groups,
        bool IsFlag) : IEquatable<EnumMemberData?>;

    // FIXME: Better name
    public record EnumGroupData (
        string Name,
        bool IsFlags);

    public record EnumGroup(
        string Name,
        bool IsFlags,
        List<EnumMemberData> Members);

    public record GLVersionOutput(
        OutputApi Api,
        Version Version,
        List<OverloaderNativeFunction> Functions,
        List<OverloaderFunctionOverloads> Overloads,
        List<EnumMemberData> AllEnums,
        List<EnumGroup> EnumGroups);

    public record OutputData(
        List<GLVersionOutput> Versions);
}
