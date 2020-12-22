using GeneratorV2.Data;
using GeneratorV2.Parsing;
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
                    if (@enum.Type == TypeSuffix.Ull)
                    {
                        // This is a uint64 enum, which will not fit in any normal enum type.
                        // These enums are all part of the "SpecialNumbers" group
                        // that get special treatment later in the code.
                        continue;
                    }

                    if (@enum.Api != GLAPI.None && @enum.Api != GLAPI.GL)
                    {
                        // FIXME: For now we ignore gles and glsc enums
                        continue;
                    }

                    var e2 = @enum.Groups ?? Enumerable.Empty<string>();

                    // We skip the <enums> attribute group tag for now, because
                    // if we use it we need to deduplicate the names, which is a hassle.
                    // The code below can be used to detect the enums for which this will
                    // result in the wrong code being generated.
                    // This is 164 entires as of 2020-12-22
                    /**
                    var e1 = e.Groups ?? Enumerable.Empty<string>();
                    List<string> missing = new List<string>();
                    foreach (var item in e1)
                    {
                        if (e2.Contains(item) == false)
                        {
                            missing.Add(item);
                        }
                    }

                    if (missing.Count > 0)
                    {
                        Console.WriteLine($"Enum {@enum.Name} has missing enum tag! {string.Join(", ", missing)}");
                    }
                    */

                    foreach (var g in e2.Append("All"))
                    {
                        if (enumGroups.TryGetValue(g, out var egroup) == false)
                        {
                            egroup = new EnumGroup(g, new List<EnumMember>(), e.Type == EnumType.Bitmask);
                            enumGroups[g] = egroup;
                        }

                        egroup.Members.Add(new EnumMember(NameMangler.MangleEnumName(@enum.Name), @enum.Value));

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

        public static NativeFunction MakeNativeFunction(GLMethod method)
        {
            List<NativeParameter> parameters = new List<NativeParameter>();
            foreach (var p in method.Parameters)
            {
                ICSType t = MakeCSType(p.Type.Type, p.Type.Group);
                parameters.Add(new NativeParameter(t, NameMangler.MangleParameterName(p.Name)));
            }

            ICSType returnType = MakeCSType(method.ReturnType.Type, method.ReturnType.Group);

            return new NativeFunction(method.EntryPoint, parameters, returnType);
        }

        public static ICSType MakeCSType(GLType type, string? group = null)
        {
            switch (type)
            {
                case GLArrayType at:
                    return new CSArray(MakeCSType(at.BaseType, group), at.Length, at.Const);
                case GLPointerType pt:
                    return new CSPointer(MakeCSType(pt.BaseType, group), pt.Const);
                case GLBaseType bt:
                    return bt.Type switch
                    {
                        PrimitiveType.Void =>   new CSVoid(),
                        PrimitiveType.Byte =>   new CSType("byte", bt.Const),
                        PrimitiveType.Sbyte =>  new CSType("sbyte", bt.Const),
                        PrimitiveType.Short =>  new CSType("short", bt.Const),
                        PrimitiveType.Ushort => new CSType("ushort", bt.Const),
                        PrimitiveType.Int =>    new CSType("int", bt.Const),
                        PrimitiveType.Uint =>   new CSType("uint", bt.Const),
                        PrimitiveType.Long =>   new CSType("long", bt.Const),
                        PrimitiveType.Ulong =>  new CSType("ulong", bt.Const),
                        PrimitiveType.Half =>   new CSType("Half", bt.Const),
                        PrimitiveType.Float =>  new CSType("float", bt.Const),
                        PrimitiveType.Double => new CSType("double", bt.Const),
                        PrimitiveType.IntPtr => new CSType("IntPtr", bt.Const),

                        PrimitiveType.VoidPtr => new CSPointer(new CSVoid(), bt.Const),

                        // FIXME: Should this be treated special?
                        PrimitiveType.Enum => new CSType(group ?? "All", bt.Const),

                        // FIXME: Are these just normal CSType? probably?
                        PrimitiveType.GLHandleARB => new CSType("GLHandleARB", bt.Const),
                        PrimitiveType.GLSync =>      new CSType("GLSync", bt.Const),

                        PrimitiveType.CLContext => new CSType("CLContext", bt.Const),
                        PrimitiveType.CLEvent =>   new CSType("CLEvent", bt.Const),

                        PrimitiveType.GLDEBUGPROC =>    new CSType("GLDebugProc", bt.Const),
                        PrimitiveType.GLDEBUGPROCARB => new CSType("GLDebugProcARB", bt.Const),
                        PrimitiveType.GLDEBUGPROCKHR => new CSType("GLDebugProcKHR", bt.Const),
                        PrimitiveType.GLDEBUGPROCAMD => new CSType("GLDebugProcAMD", bt.Const),
                        PrimitiveType.GLDEBUGPROCNV =>  new CSType("GLDebugProcNV", bt.Const),

                        PrimitiveType.Invalid => throw new Exception(),
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }
    }
}
