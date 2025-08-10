using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using ALGenerator.Parsing;
using System.CodeDom.Compiler;
using GeneratorBase.Utility;
using GeneratorBase;

namespace ALGenerator.Process
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
        List<VendorFunctions> VendorFunctions,
        List<EnumGroup> EnumGroups,
        Dictionary<Function, FunctionDocumentation> Documentation);

    internal record Pointers(
        APIFile File,
        List<Function> NativeFunctions);

    internal record FunctionDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        List<string> RefPagesLinks,
        List<string> AddedIn,
        List<string>? RemovedIn
        );

    internal record VendorFunctions(
        string Vendor,
        List<OverloadedFunction> Functions,
        HashSet<Function> NativeFunctionsWithPostfix);

    internal record OverloadedFunction(
        Function NativeFunction,
        Overload[] Overloads) : IComparable<OverloadedFunction>
    {
        public int CompareTo(OverloadedFunction? other)
        {
            return NativeFunction.Name.CompareTo(other?.NativeFunction.Name);
        }
    }

    internal record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        Function NativeFunction,
        BaseCSType ReturnType,
        NameTable NameTable,
        string[] GenericTypes,
        string OverloadName);


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
        List<(string Vendor, Function Function)>? FunctionsUsingEnumGroup);


    internal interface IOverloadLayer
    {
        internal void WritePrologue(IndentedTextWriter writer, NameTable nameTable);
        internal string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName);
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
        AL,
        ALC,
    }

    [Flags]
    internal enum OutputApiFlags
    {
        None = 0,
        AL = 1 << 0,
        ALC = 1 << 1,
    }
}
