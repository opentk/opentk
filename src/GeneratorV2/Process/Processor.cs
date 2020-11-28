using GeneratorV2.Data;
using GeneratorV2.Writing2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Process
{
    static class Processor
    {
        public static OutputData ProcessSpec(Specification spec)
        {
            List<NativeFunction> functions = new List<NativeFunction>();
            foreach (var m in spec.Commands)
            {
                functions.Add(MakeNativeFunction(m.Value.Method));
            }

            var enumGroups = MakeEnumGroups(spec.Enums);

            GLVersionOutput o = new GLVersionOutput("Test", functions, enumGroups);

            return new OutputData(new List<GLVersionOutput>() { o });
        }


        public static List<EnumGroup> MakeEnumGroups(List<EnumsEntry> enums)
        {
            Dictionary<string, EnumGroup> enumGroups = new Dictionary<string, EnumGroup>();

            foreach (var e in enums)
            {
                foreach (var @enum in e.Enums)
                {
                    var e1 = e.Groups ?? Enumerable.Empty<string>();
                    var e2 = @enum.Groups ?? Enumerable.Empty<string>();
                    foreach (var g in Enumerable.Concat(e1, e2).Append("All"))
                    {
                        if (enumGroups.TryGetValue(g, out var egroup) == false)
                        {
                            egroup = new EnumGroup(g, new List<EnumMember>(), e.Type == EnumType.Bitmask);
                            enumGroups[g] = egroup;
                        }

                        // FIXME: Do name mangling!!!
                        egroup.Members.Add(new EnumMember(@enum.Name, @enum.Value));

                        // FIXME!!!
                        if (egroup.Flags && e.Type != EnumType.Bitmask)
                        {
                            egroup.Flags = false;
                        }
                    }
                }
            }

            return new List<EnumGroup>(enumGroups.Values);
        }

        public static NativeFunction MakeNativeFunction(Method2 method)
        {
            List<NativeParameter> parameters = new List<NativeParameter>();
            foreach (var p in method.Parameters)
            {
                CSType t = MakeCSType(p.Type);
                parameters.Add(new NativeParameter(t, p.Name));
            }

            CSType returnType = MakeCSType(method.ReturnType);

            return new NativeFunction(method.EntryPoint, parameters, returnType);
        }

        public static CSType MakeCSType(PType2 ptype)
        {
            return new CSType(ToString(ptype.Type, ptype.Group));
        }

        // FIXME: Remove!
        static string ToString(GLType t, string? group)
        {
            switch (t)
            {
                case GLArrayType at:
                    return $"{ToString(at.BaseType, group)}[{at.Length}]";
                case GLPointerType pt:
                    return $"{ToString(pt.BaseType, group)}*";
                case GLBaseType bt:
                    return bt.Type switch
                    {
                        PrimitiveType.Invalid => throw new Exception(),
                        PrimitiveType.Void => "void",
                        PrimitiveType.Byte => "byte",
                        PrimitiveType.Sbyte => "sbyte",
                        PrimitiveType.Short => "short",
                        PrimitiveType.Ushort => "ushort",
                        PrimitiveType.Int => "int",
                        PrimitiveType.Uint => "uint",
                        PrimitiveType.Long => "long",
                        PrimitiveType.Ulong => "ulong",
                        PrimitiveType.Half => "Half",
                        PrimitiveType.Float => "float",
                        PrimitiveType.Double => "double",
                        PrimitiveType.IntPtr => "IntPtr",
                        PrimitiveType.VoidPtr => "void*",
                        PrimitiveType.Enum => group ?? "All", // FIXME
                        PrimitiveType.GLHandleARB => "GLHandleARB",
                        PrimitiveType.GLSync => "GLSync",
                        PrimitiveType.CLContext => "CLContext",
                        PrimitiveType.CLEvent => "CLEvent",
                        PrimitiveType.GLDEBUGPROC => "GLDebugProc",
                        PrimitiveType.GLDEBUGPROCARB => "GLDebugProcArb",
                        PrimitiveType.GLDEBUGPROCKHR => "GLDebugProcKHR",
                        PrimitiveType.GLDEBUGPROCAMD => "GLDebugProcAMD",
                        PrimitiveType.GLDEBUGPROCNV => "GLDebugProcNV",
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }
    }
}
