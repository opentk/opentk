using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using Generator.Parsing;
using System.CodeDom.Compiler;

namespace Generator.Writing
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
    public record CSPrimitive(string TypeName, bool Constant) : BaseCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSStruct(string TypeName, bool Constant, CSPrimitive? UnderlyingType) : BaseCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSFunctionPointer(string TypeName, bool Constant) : BaseCSType
    {
        public override string ToCSString()
        {
            return "IntPtr";
        }
    }

    public record CSDelegateType(string TypeName) : BaseCSType
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

    public record CSBool8(bool Constant) : BaseCSType
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

    public record CSVoid(bool Constant) : BaseCSType
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
        public void WritePrologue(IndentedTextWriter writer, NameTable nameTable);
        public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName);

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

    public class NameTable
    {
        public Dictionary<Parameter, string> Table = new Dictionary<Parameter, string>();

        public NameTable()
        {
        }

        public NameTable(NameTable table)
        {
            Table = new Dictionary<Parameter, string>(table.Table);
        }

        public NameTable New()
        {
            return new NameTable(this);
        }

        public void Rename(Parameter param, string name) => Table[param] = name;

        public string this[Parameter param]
        {
            get
            {
                if (Table.TryGetValue(param, out var name) == false)
                {
                    name = param.Name;
                }

                return name;
            }
        }

        public void Apply(NameTable table)
        {
            foreach (var (param, name) in table.Table)
            {
                Table[param] = name;
            }
        }
    }

    public record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        NativeFunction NativeFunction,
        BaseCSType ReturnType,
        NameTable NameTable,
        string ReturnVariableName,
        string[] GenericTypes,
        string OverloadName);

    // FIXME: Better name
    public record EnumMemberData(
        string Name,
        ulong Value,
        string[]? Groups,
        bool IsFlag) : IEquatable<EnumMemberData?>;

    // FIXME: Better name
    public record EnumGroupData(
        string Name,
        bool IsFlags);

    public record EnumGroup(
        string Name,
        bool IsFlags,
        List<EnumMemberData> Members);

    // FIXME: Better name
    public record GLOutputApiGroup(
        List<NativeFunction> NativeFunctions,
        List<Overload[]> OverloadsGroupedByNativeFunctions,
        HashSet<NativeFunction> NativeFunctionsWithPostfix);

    public record GLOutputApi(
        OutputApi Api,
        Dictionary<string, GLOutputApiGroup> Vendors,
        List<EnumMemberData> AllEnums,
        List<EnumGroup> EnumGroups);

    public record OutputData(List<GLOutputApi> Apis);
}
