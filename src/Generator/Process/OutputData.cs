using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using Generator.Parsing;
using System.CodeDom.Compiler;
using Generator.Utility;

namespace Generator.Writing
{
    public record OutputData(
        /* FIXME: Maybe do like this?
        Namespace GL,
        Namespace GLCompat,
        Namespace GLES1,
        Namespace GLES2,
        Namespace WGL,
        Namespace GLX,
        */

        List<Pointers> Pointers,
        List<Namespace> Namespaces);

    // FIXME: Maybe change to API.. something? "namespace" is quite generic.
    public record Namespace(
        OutputApi Name,
        SortedDictionary<string, GLVendorFunctions> Vendors,
        List<EnumGroup> EnumGroups,
        Dictionary<NativeFunction, FunctionDocumentation> Documentation);

    public record Pointers(
        GLFile File,
        List<NativeFunction> NativeFunctions);

    /*
    public record GLOutputApi(
        OutputApi Api,
        SortedDictionary<string, GLVendorFunctions> Vendors,
        List<EnumGroup> EnumGroups,
        Dictionary<NativeFunction, FunctionDocumentation> Documentation);
    */

    public record FunctionDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        string? RefPagesLink,
        List<string> AddedIn,
        List<string>? RemovedIn
        );

    public record GLVendorFunctions(
        List<OverloadedFunction> Functions,
        HashSet<NativeFunction> NativeFunctionsWithPostfix);

    public record OverloadedFunction(
        NativeFunction NativeFunction,
        Overload[] Overloads) : IComparable<OverloadedFunction>
    {
        public int CompareTo(OverloadedFunction? other)
        {
            return NativeFunction.FunctionName.CompareTo(other?.NativeFunction.FunctionName);
        }
    }

    public record NativeFunction(
        string EntryPoint,
        string FunctionName,
        List<Parameter> Parameters,
        BaseCSType ReturnType,
        // FIXME: Convert referencedEnumGroups to use GroupRef!
        GroupRef[] ReferencedEnumGroups);

    public record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        NativeFunction NativeFunction,
        BaseCSType ReturnType,
        NameTable NameTable,
        string[] GenericTypes,
        string OverloadName);

    public record Parameter(
        BaseCSType Type,
        // FIXME: Should we expose this exactly like it's exposed in gl.xml?
        string[] Kinds,
        string Name,
        Expression? Length);


    public record EnumGroupMember(
        string Name,
        ulong Value,
        GroupRef[] Groups,
        bool IsFlag) : IEquatable<EnumGroupMember?>;

    public record EnumGroup(
        string Name,
        bool IsFlags,
        List<EnumGroupMember> Members,
        List<(string Vendor, NativeFunction Function)>? FunctionsUsingEnumGroup);


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

    public interface IBaseTypeCSType
    {
        public BaseCSType BaseType { get; }

        public bool TakeAddressInFixedStatement { get; }

        public BaseCSType CreateWithNewType(BaseCSType type);
    }

    public record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "void";
    }

    public record CSPrimitive(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        // FIXME: const??
        public static CSPrimitive Sbyte(bool @const) => new CSPrimitive("sbyte", @const);
        public static CSPrimitive Byte(bool @const) => new CSPrimitive("byte", @const);
        public static CSPrimitive Short(bool @const) => new CSPrimitive("short", @const);
        public static CSPrimitive Ushort(bool @const) => new CSPrimitive("ushort", @const);
        public static CSPrimitive Int(bool @const) => new CSPrimitive("int", @const);
        public static CSPrimitive Uint(bool @const) => new CSPrimitive("uint", @const);
        public static CSPrimitive Long(bool @const) => new CSPrimitive("long", @const);
        public static CSPrimitive Ulong(bool @const) => new CSPrimitive("ulong", @const);

        public static CSPrimitive Nint(bool @const) => new CSPrimitive("nint", @const);
        public static CSPrimitive Nuint(bool @const) => new CSPrimitive("nuint", @const);
        public static CSPrimitive IntPtr(bool @const) => new CSPrimitive("IntPtr", @const);

        public static CSPrimitive Half(bool @const) => new CSPrimitive("Half", @const);
        public static CSPrimitive Float(bool @const) => new CSPrimitive("float", @const);
        public static CSPrimitive Double(bool @const) => new CSPrimitive("double", @const);

        public override string ToCSString()
        {
            return TypeName;
        }
    }

    // FIXME: Maybe combine TypeName and GroupRef.
    public record CSEnum(string TypeName, GroupRef? GroupRef, CSPrimitive PrimitiveType, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return TypeName;
        }
    }

    public record CSStructPrimitive(string StructName, bool Constant, CSPrimitive UnderlyingType) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return StructName;
        }
    }

    public record CSStruct(string TypeName, bool Constant) : BaseCSType, IConstantCSType
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
            return "bool";
        }
    }

    public record CSBool32(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString()
        {
            return "int";
        }
    }

    public interface ICSCharType : IConstantCSType { }

    public record CSChar8(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        public override string ToCSString()
        {
            return "byte";
        }
    }

    public record CSChar16(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        public override string ToCSString()
        {
            return "char";
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

    public record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType, IBaseTypeCSType
    {
        public enum Type { Ref, Out, In }

        public BaseCSType BaseType => ReferencedType;

        public bool TakeAddressInFixedStatement => true;

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

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSRef(RefType, type);
        }
    }

    public record CSArray(BaseCSType BaseType) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        public override string ToCSString()
        {
            return $"{BaseType.ToCSString()}[]";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSArray(type);
        }
    }

    public record CSSpan(BaseCSType BaseType, bool Readonly) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

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

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSSpan(type, Readonly);
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

        public string? ReturnName = "returnValue";

        public NameTable()
        {
        }

        public NameTable(NameTable table)
        {
            Table = new Dictionary<Parameter, string>(table.Table);
            ReturnName = table.ReturnName;
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

            // Replace the return name.
            ReturnName = table.ReturnName;
        }
    }


    public enum OutputApi
    {
        Invalid,
        GL,
        GLCompat,
        GLES1,
        GLES2,
        WGL,
        GLX,
    }

    [Flags]
    public enum OutputApiFlags
    {
        None = 0,
        GL = 1 << 0,
        GLCompat = 1 << 1,
        GLES1 = 1 << 2,
        GLES2 = 1 << 3,
        WGL = 1 << 4,
        GLX = 1 << 5,
    }
}
