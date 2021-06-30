using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using Generator.Parsing;
using System.CodeDom.Compiler;

namespace Generator.Writing
{
    public record OutputData(List<GLOutputApi> Apis);


    public record GLOutputApi(
        OutputApi Api,
        Dictionary<string, GLVendorFunctions> Vendors,
        List<EnumGroupMember> AllEnums,
        List<EnumGroup> EnumGroups);


    public record GLVendorFunctions(
        List<NativeFunction> NativeFunctions,
        List<Overload[]> OverloadsGroupedByNativeFunctions,
        HashSet<NativeFunction> NativeFunctionsWithPostfix);

    public record NativeFunction(
        string EntryPoint,
        string FunctionName,
        List<Parameter> Parameters,
        BaseCSType ReturnType);

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

    public record Parameter(
        BaseCSType Type,
        string Name,
        Expression? Length);


    public record EnumGroupMember(
        string Name,
        ulong Value,
        string[] Groups,
        bool IsFlag) : IEquatable<EnumGroupMember?>;

    public record EnumGroup(
        string Name,
        bool IsFlags,
        List<EnumGroupMember> Members);


    public interface IOverloadLayer
    {
        public void WritePrologue(IndentedTextWriter writer, NameTable nameTable);
        public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName);
    }


    public abstract record BaseCSType()
    {
        // We use a custom ToString here to allow ToString to be used for debugging,
        // also this way we make sure you have to override the custom ToString method.
        public abstract string ToCSString();
    }

    public interface IConstantCSType
    {
        public bool Constant { get; }
    }

    public record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "void";
    }

    public record CSPrimitive(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSStruct(string TypeName, bool Constant, CSPrimitive? UnderlyingType) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSBool8(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "byte";
        }
    }

    public record CSChar8(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "byte";
        }
    }

    public record CSString(bool Nullable) : BaseCSType
    {
        public override string ToCSString()
        {
            return $"string{(Nullable ? "?" : "")}";
        }
    }

    public record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}*";
        }
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

    public record CSArray(BaseCSType BaseType) : BaseCSType
    {
        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}[]";
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

    public record CSFunctionPointer(string TypeName, bool Constant) : BaseCSType, IConstantCSType
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


    // FIXME: Clean up our naming/renaming of variables entirely. Do we even need/want a nametable?
    // If we do this is definitely not the correct API for it.
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


    public enum OutputApi
    {
        Invalid,
        GL,
        GLCompat,
        GLES1,
        GLES3
    }
}
