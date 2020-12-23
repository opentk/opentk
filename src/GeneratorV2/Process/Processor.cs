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
            // The first thing we do is process all of the functions defined into a dictionary of NativeFunctions
            Dictionary<string, NativeFunction> allFunctions = new Dictionary<string, NativeFunction>(spec.Commands.Count);
            foreach (var command in spec.Commands)
            {
                var nativeFunction = MakeNativeFunction(command);
                allFunctions.Add(nativeFunction.EntryPoint, nativeFunction);
            }

            // We then make a dictionary of all the enums with their individual group data inside
            Dictionary<string, EnumMemberData> allEnums = new Dictionary<string, EnumMemberData>();
            Dictionary<string, EnumMemberData> allEnumsGLES2 = new Dictionary<string, EnumMemberData>();
            // FIXME: This is only here to mark groups as flags...
            Dictionary<string, EnumGroupData> allGroups = new Dictionary<string, EnumGroupData>();
            HashSet<string> allGroupNames = new HashSet<string>();
            foreach (var enumsEntry in spec.Enums)
            {
                // FIXME: Cleanup


                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                HashSet<string> entryGroups = new HashSet<string>();
                if (enumsEntry.Groups != null)
                {
                    foreach (var group in enumsEntry.Groups)
                    {
                        entryGroups.Add(group);
                        allGroupNames.Add(group);
                        allGroups.TryAdd(group, new EnumGroupData(group, isFlag));
                    }
                }

                foreach (var @enum in enumsEntry.Enums)
                {
                    HashSet<string> groups = new HashSet<string>(entryGroups);

                    if (@enum.Groups != null)
                    {
                        foreach (var group in @enum.Groups)
                        {
                            groups.Add(group);
                            allGroupNames.Add(group);
                            allGroups.TryAdd(group, new EnumGroupData(group, isFlag));
                        }
                    }

                    var data = new EnumMemberData(@enum.Name, @enum.Value, groups.ToArray(), isFlag);
                    if (@enum.Api == GLAPI.None)
                    {
                        allEnums.Add(@enum.Name, data);
                        allEnumsGLES2.Add(@enum.Name, data);
                    }
                    else if (@enum.Api == GLAPI.GLES2)
                    {
                        allEnumsGLES2.Add(@enum.Name, data);
                    }
                    else if (@enum.Api == GLAPI.GL)
                    {
                        allEnums.Add(@enum.Name, data);
                    }
                }
            }

            // Now that we have all of the functions ready in a nice dictionary
            // we can start building all of the API versions.

            // Group the features into GL and GL ES
            List<Feature> glFeatures = new List<Feature>();
            List<Feature> glesFeatures = new List<Feature>();
            foreach (var feature in spec.Features)
            {
                switch (feature.Api)
                {
                    case GLAPI.GL:
                        glFeatures.Add(feature);
                        break;
                    case GLAPI.GLES1:
                    case GLAPI.GLES2:
                        glesFeatures.Add(feature);
                        break;
                    case GLAPI.GLSC2:
                        // We don't care about GLSC 2
                        continue;
                    case GLAPI.Invalid:
                    case GLAPI.None:
                    default:
                        throw new Exception($"Feature '{feature.Name}' doesn't have a proper api tag.");
                }
            }

            List<GLVersionOutput> glVersions = new List<GLVersionOutput>();

            // Here we process all of the desktop OpenGL versions
            {
                List<NativeFunction> functionsInLastVersion = new List<NativeFunction>();
                HashSet<EnumMemberData> enumsInLastVersion = new HashSet<EnumMemberData>();
                foreach (var feature in glFeatures)
                {
                    StringBuilder name = new StringBuilder();
                    name.Append("GL");
                    name.Append(feature.Version.Major);
                    name.Append(feature.Version.Minor);

                    // A list of functions contained in this version.
                    List<NativeFunction> functions = new List<NativeFunction>();
                    HashSet<EnumMemberData> enums = new HashSet<EnumMemberData>();

                    // Go through all the functions that are required for this version and add them here.
                    foreach (var require in feature.Requires)
                    {
                        // FIXME: We need to deduplicate names here!
                        // This is because some functions are removed and then later reused.
                        // And because we don't remove anything from the lists we need to
                        // deduplicate the names, because otherwise we generate it two times.
                        foreach (var command in require.Commands)
                        {
                            if (allFunctions.TryGetValue(command, out var function))
                            {
                                functions.Add(function);
                            }
                            else
                            {
                                throw new Exception($"Could not find any function called '{command}'.");
                            }
                        }

                        foreach (var enumName in require.Enums)
                        {
                            if (allEnums.TryGetValue(enumName, out var @enum))
                            {
                                enums.Add(@enum);
                            }
                            else
                            {
                                throw new Exception($"Could not find any enum called '{enumName}'.");
                            }
                        }
                    }

                    // Make a copy of all the functions and enums contained in the previous version.
                    // We will remove items from this list according to the remove tags.
                    List<NativeFunction> functionsFromPreviousVersion = new List<NativeFunction>(functionsInLastVersion);
                    HashSet<EnumMemberData> enumsFromPreviousVersion = new HashSet<EnumMemberData>(enumsInLastVersion);

                    foreach (var remove in feature.Removes)
                    {
                        // FXIME: For now we don't remove anything as idk how we want to
                        // handle core vs not core. For now we just include all versions.

                        // We probably want to mark deprecated functions with a deprecated tag?
                    }

                    // Add all of the functions from the last version.
                    functions.AddRange(functionsFromPreviousVersion);
                    enums.UnionWith(enumsFromPreviousVersion);
                    //enums.AddRange();

                    // This is the new previous version.
                    functionsInLastVersion = functions;
                    enumsInLastVersion = enums;

                    // Go through all of the enums and put them into their groups
                    Dictionary<string, List<EnumMemberData>> enumGroups = new Dictionary<string, List<EnumMemberData>>();

                    // Add keys + lists for all enum names
                    foreach (var groupName in allGroupNames)
                    {
                        enumGroups.Add(groupName, new List<EnumMemberData>());
                    }

                    foreach (var @enum in enums)
                    {
                        // This enum doesn't have a group, so we skip it.
                        // It will still appear in the All enum.
                        if (@enum.Groups == null) continue;

                        foreach (var groupName in @enum.Groups)
                        {
                            // Here we rely on the step where we add all of the enum groups earlier.
                            enumGroups[groupName].Add(@enum);
                        }
                    }

                    // FIXME: Name
                    List<EnumGroup> finalGroups = new List<EnumGroup>();
                    foreach (var (groupName, members) in enumGroups)
                    {
                        // We will handle the special numbers in another way.
                        if (groupName == "SpecialNumbers")
                            continue;

                        // FIXME: Cleaner way to get this data?
                        bool isFlags = allGroups[groupName].IsFlags;
                        finalGroups.Add(new EnumGroup(groupName, isFlags, members));
                    }

                    glVersions.Add(new GLVersionOutput(name.ToString(), functions, enums.ToList(), finalGroups));
                }
            }

            return new OutputData(glVersions);
        }

        public static NativeFunction MakeNativeFunction(Command2 command)
        {
            List<NativeParameter> parameters = new List<NativeParameter>();
            foreach (var p in command.Parameters)
            {
                ICSType t = MakeCSType(p.Type.Type, p.Type.Group);
                parameters.Add(new NativeParameter(t, NameMangler.MangleParameterName(p.Name)));
            }

            ICSType returnType = MakeCSType(command.ReturnType.Type, command.ReturnType.Group);

            return new NativeFunction(command.EntryPoint, parameters, returnType);
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
