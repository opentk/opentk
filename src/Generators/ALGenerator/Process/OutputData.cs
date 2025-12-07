using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using ALGenerator.Parsing;
using System.CodeDom.Compiler;
using GeneratorBase.Utility;
using GeneratorBase;
using GeneratorBase.Overloading;

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
        List<Namespace> Namespaces,
        Dictionary<string, EnumMemberDocumentation> EnumMemberDocumentation);

    // FIXME: Maybe change to API.. something? "namespace" is quite generic.
    internal record Namespace(
        OutputApi Name,
        List<VendorFunctions> VendorFunctions,
        List<EnumGroup> EnumGroups,
        Dictionary<Function, FunctionDocumentation> FunctionDocumentation);

    internal record Pointers(
        APIFile File,
        List<Function> NativeFunctions);

    internal record FunctionDocumentation(
        string Name,
        string Purpose,
        ParameterDocumentation[] Parameters,
        List<Link> RefPagesLinks,
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
