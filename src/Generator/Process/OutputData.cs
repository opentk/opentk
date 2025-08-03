using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using GLGenerator.Parsing;
using System.CodeDom.Compiler;
using GeneratorBase.Utility;

namespace GLGenerator.Writing
{
    internal record OutputData(
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
    internal record Namespace(
        OutputApi Name,
        SortedDictionary<string, GLVendorFunctions> Vendors,
        List<EnumGroup> EnumGroups,
        Dictionary<NativeFunction, FunctionDocumentation> Documentation);

    internal record Pointers(
        GLFile File,
        List<NativeFunction> NativeFunctions);

    internal record FunctionDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        string? RefPagesLink,
        List<string> AddedIn,
        List<string>? RemovedIn
        );

    internal record GLVendorFunctions(
        List<OverloadedFunction> Functions,
        HashSet<NativeFunction> NativeFunctionsWithPostfix);

    internal record OverloadedFunction(
        NativeFunction NativeFunction,
        Overload[] Overloads) : IComparable<OverloadedFunction>
    {
        public int CompareTo(OverloadedFunction? other)
        {
            return NativeFunction.FunctionName.CompareTo(other?.NativeFunction.FunctionName);
        }
    }

    internal record NativeFunction(
        string EntryPoint,
        string FunctionName,
        List<Parameter> Parameters,
        BaseCSType ReturnType,
        // FIXME: Convert referencedEnumGroups to use GroupRef!
        GroupRef[] ReferencedEnumGroups);

    internal record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        NativeFunction NativeFunction,
        BaseCSType ReturnType,
        NameTable NameTable,
        string[] GenericTypes,
        string OverloadName);

    internal record Parameter(
        BaseCSType Type,
        // FIXME: Should we expose this exactly like it's exposed in gl.xml?
        string[] Kinds,
        string OriginalName,
        string Name,
        Expression? Length);


    internal record EnumGroupMember(
        string Name,
        string MangledName,
        ulong Value,
        GroupRef[] Groups,
        bool IsFlag) : IEquatable<EnumGroupMember?>
    {
        internal static int DefaultComparison(EnumGroupMember m1, EnumGroupMember m2)
        {
            int comp = m1.Value.CompareTo(m2.Value);
            if (comp == 0)
            {
                return m1.MangledName.CompareTo(m2.MangledName);
            }
            else
            {
                return comp;
            }
        }
    }

    internal record EnumGroup(
        string Name,
        bool IsFlags,
        List<EnumGroupMember> Members,
        List<(string Vendor, NativeFunction Function)>? FunctionsUsingEnumGroup);


    internal interface IOverloadLayer
    {
        internal void WritePrologue(IndentedTextWriter writer, NameTable nameTable);
        internal string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName);
    }


    internal abstract record BaseCSType()
    {
        // We use a custom ToString here to allow ToString to be used for debugging,
        // also this way we make sure you have to override the custom ToString method.
        internal abstract string ToCSString();
    }

    internal interface IConstantCSType
    {
        internal bool Constant { get; }
    }

    internal interface IBaseTypeCSType
    {
        internal BaseCSType BaseType { get; }

        internal bool TakeAddressInFixedStatement { get; }

        internal BaseCSType CreateWithNewType(BaseCSType type);
    }

    internal record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString() => "void";
    }

    internal record CSPrimitive(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        // FIXME: const??
        internal static CSPrimitive Sbyte(bool @const) => new CSPrimitive("sbyte", @const);
        internal static CSPrimitive Byte(bool @const) => new CSPrimitive("byte", @const);
        internal static CSPrimitive Short(bool @const) => new CSPrimitive("short", @const);
        internal static CSPrimitive Ushort(bool @const) => new CSPrimitive("ushort", @const);
        internal static CSPrimitive Int(bool @const) => new CSPrimitive("int", @const);
        internal static CSPrimitive Uint(bool @const) => new CSPrimitive("uint", @const);
        internal static CSPrimitive Long(bool @const) => new CSPrimitive("long", @const);
        internal static CSPrimitive Ulong(bool @const) => new CSPrimitive("ulong", @const);

        internal static CSPrimitive Nint(bool @const) => new CSPrimitive("nint", @const);
        internal static CSPrimitive Nuint(bool @const) => new CSPrimitive("nuint", @const);
        internal static CSPrimitive IntPtr(bool @const) => new CSPrimitive("IntPtr", @const);

        internal static CSPrimitive Half(bool @const) => new CSPrimitive("Half", @const);
        internal static CSPrimitive Float(bool @const) => new CSPrimitive("float", @const);
        internal static CSPrimitive Double(bool @const) => new CSPrimitive("double", @const);

        internal override string ToCSString()
        {
            return TypeName;
        }
    }

    internal record CSEnum(string TranslatedTypeName, GroupRef? GroupRef, CSPrimitive PrimitiveType, bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return TranslatedTypeName;
        }
    }

    internal record CSStructPrimitive(string StructName, bool Constant, CSPrimitive UnderlyingType) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return StructName;
        }
    }

    // This struct type is used internally to mark that this struct is opaque and needs to be converted to
    // a pointer variant before it can be used.
    // - Noggin_bops 2024-03-07
    internal record CSOpaqueStruct(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            throw new InvalidOperationException($"Opaque type '{TypeName}' should never be used directly");
        }
    }

    internal record CSStruct(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return TypeName;
        }
    }

    internal record CSBool8(bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return "bool";
        }
    }

    internal record CSBool32(bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return "int";
        }
    }

    internal interface ICSCharType : IConstantCSType { }

    internal record CSChar8(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        internal override string ToCSString()
        {
            return "byte";
        }
    }

    internal record CSChar16(bool Constant) : BaseCSType, IConstantCSType, ICSCharType
    {
        internal override string ToCSString()
        {
            return "char";
        }
    }

    internal record CSString(bool Nullable) : BaseCSType
    {
        internal override string ToCSString()
        {
            return $"string{(Nullable ? "?" : "")}";
        }
    }

    internal record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return $"{BaseType.ToCSString()}*";
        }
    }

    internal record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType, IBaseTypeCSType
    {
        internal enum Type { Ref, Out, RefReadonly }

        public BaseCSType BaseType => ReferencedType;

        public bool TakeAddressInFixedStatement => true;

        internal override string ToCSString()
        {
            string modifier = RefType switch
            {
                Type.Ref => "ref",
                Type.Out => "out",
                Type.RefReadonly => "ref readonly",
                _ => throw new Exception()
            };
            return $"{modifier} {ReferencedType.ToCSString()}";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSRef(RefType, type);
        }
    }

    internal record CSArray(BaseCSType BaseType) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        internal override string ToCSString()
        {
            return $"{BaseType.ToCSString()}[]";
        }

        public BaseCSType CreateWithNewType(BaseCSType type)
        {
            return new CSArray(type);
        }
    }

    internal record CSSpan(BaseCSType BaseType, bool Readonly) : BaseCSType, IBaseTypeCSType
    {
        public bool TakeAddressInFixedStatement => false;

        internal override string ToCSString()
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

    internal record CSGenericType(string GenericTypeName) : BaseCSType
    {
        internal override string ToCSString()
        {
            return GenericTypeName;
        }
    }

    internal record CSFunctionPointer(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        internal override string ToCSString()
        {
            return "IntPtr";
        }
    }

    internal record CSDelegateType(string TypeName) : BaseCSType
    {
        internal override string ToCSString()
        {
            return TypeName;
        }
    }


    // FIXME: Clean up our naming/renaming of variables entirely. Do we even need/want a nametable?
    // If we do this is definitely not the correct API for it.
    internal class NameTable
    {
        internal Dictionary<Parameter, string> Table = new Dictionary<Parameter, string>();

        internal HashSet<Parameter> FixedTable = new HashSet<Parameter>();

        internal string? ReturnName = "returnValue";

        internal NameTable()
        {
        }

        internal NameTable(NameTable table)
        {
            Table = new Dictionary<Parameter, string>(table.Table);
            FixedTable = new HashSet<Parameter>(table.FixedTable);
            ReturnName = table.ReturnName;
        }

        internal NameTable New()
        {
            return new NameTable(this);
        }

        internal void Rename(Parameter param, string name) => Table[param] = name;

        /// <summary>Mark this parameter as fixed, so generators don't try to use <see langword="fixed"/> on this parameter.</summary>
        internal void MarkFixed(Parameter param) => FixedTable.Add(param);

        internal bool IsFixed(Parameter param) => FixedTable.Contains(param);

        internal string this[Parameter param]
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

        internal void Apply(NameTable table)
        {
            foreach (var (param, name) in table.Table)
            {
                Table[param] = name;
            }

            foreach (var fixedParam in table.FixedTable)
            {
                FixedTable.Add(fixedParam);
            }

            // Replace the return name.
            ReturnName = table.ReturnName;
        }
    }


    internal enum OutputApi
    {
        Invalid,
        GL,
        GLCompat,
        GLES1,
        GLES2,
        WGL,
        GLX,
        EGL,
    }

    [Flags]
    internal enum OutputApiFlags
    {
        None = 0,
        GL = 1 << 0,
        GLCompat = 1 << 1,
        GLES1 = 1 << 2,
        GLES2 = 1 << 3,
        WGL = 1 << 4,
        GLX = 1 << 5,
        EGL = 1 << 6,
    }
}
