using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using GeneratorV2.Parsing;

namespace GeneratorV2.Writing
{
    public enum OutputApi
    {
        Invalid,
        GL,
        GLCompat,
        GLES1,
        GLES3
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

        // FIXME: Better place to put this?
        // FIXME: Better name, maybe even another structure...
        public static string? GetParameterExpression(Expression expr, out Func<string, string> parameterExpression)
        {
            switch (expr)
            {
                case Constant c:
                    parameterExpression = s => c.Value.ToString();
                    return null;
                case ParameterReference pr:
                    parameterExpression = s => $"{s}.Length";
                    return pr.ParameterName;
                case BinaryOperation bo:
                    // FIXME: We don't want to assume that the left expression contains the
                    // parameter name, but this is true for gl.xml 2020-12-30
                    string? reference = GetParameterExpression(bo.Left, out var leftExpr);
                    GetParameterExpression(bo.Right, out var rightExpr);
                    var invOp = BinaryOperation.Invert(bo.Operator);
                    parameterExpression = s => $"{leftExpr(s)} {BinaryOperation.GetOperationChar(invOp)} {rightExpr(s)}";
                    return reference;
                default:
                    parameterExpression = s => "";
                    return null;
            }
        }
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

    public record GLOutputApiGroup(
        List<OverloaderNativeFunction> Functions,
        List<OverloaderFunctionOverloads> Overloads);

    public record GLOutputApi(
        OutputApi Api,
        Dictionary<string, GLOutputApiGroup> Groups,
        List<EnumMemberData> AllEnums,
        List<EnumGroup> EnumGroups);

    public record OutputData(List<GLOutputApi> Apis);
}
