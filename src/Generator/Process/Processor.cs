using System;
using System.Collections.Generic;
using System.Linq;
using Generator.Utility.Extensions;
using Generator.Utility;
using Generator.Writing;
using Generator.Parsing;

namespace Generator.Process
{
    public static class Processor
    {

        // These types are only used to pass data from ProcessSpec to GetOutputApiFromRequireTags.
        private record ProcessedGLInformation(
            Dictionary<string, OverloadedFunction> AllFunctions,
            Dictionary<NativeFunction, string[]> FunctionToEnumGroupsUsed,
            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> AllEnumsPerAPI,
            List<EnumGroupInfo> AllEnumGroups);

        public record OverloadedFunction(
            NativeFunction NativeFunction,
            Overload[] Overloads,
            bool ChangeNativeName);

        public sealed record EnumGroupInfo(
            string GroupName,
            bool IsFlags)
        {
            // To deduplicate these correctly we need special logic for the IsFlags bool
            // so we don't consider it in the equality check and hashcode to allow for that.
            //
            // Example:
            // PathFontStyle uses GL_NONE which is not marked as bitmask
            // but other entries such as GL_BOLD_BIT_NV is marked as bitmask.
            //
            // When this case happens we want to consider the entire group as a bitmask.
            //
            // In the current spec this case only happens for PathFontStyle.
            // - 2021-07-04
            public bool Equals(EnumGroupInfo? other) =>
                other?.GroupName == GroupName;

            public override int GetHashCode() =>
                HashCode.Combine(GroupName);
        };

        public static OutputData ProcessSpec(Specification spec)
        {
            // The first thing we do is process all of the functions defined into a dictionary of NativeFunctions.
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Commands.Count);
            Dictionary<NativeFunction, string[]> functionToEnumGroupsUsed = new Dictionary<NativeFunction, string[]>();
            foreach (var command in spec.Commands)
            {
                var nativeFunction = MakeNativeFunction(command, out string[] usedEnumGroups);
                var overloads = GenerateOverloads(nativeFunction, out bool changeNativeName);

                functionToEnumGroupsUsed.Add(nativeFunction, usedEnumGroups);
                allFunctions.Add(nativeFunction.EntryPoint, new OverloadedFunction(nativeFunction, overloads, changeNativeName));
            }

            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumGroupMember>>();
            HashSet<EnumGroupInfo> allEnumGroups = new HashSet<EnumGroupInfo>();
            foreach (var enumsEntry in spec.Enums)
            {
                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                foreach (var @enum in enumsEntry.Entries)
                {
                    foreach (var group in @enum.Groups)
                    {
                        // If the first enums tag wasn't flagged as a bitmask, but later ones in the same group are.
                        // Then we want the group to be considered a bitmask.
                        if (allEnumGroups.TryGetValue(new EnumGroupInfo(group, isFlag), out var actual))
                        {
                            // In the current spec this case never happens, but it could.
                            // - 2021-07-04
                            if (isFlag == true && actual.IsFlags == false)
                            {
                                allEnumGroups.Remove(actual);
                                allEnumGroups.Add(actual with { IsFlags = true });
                            }
                        }
                        else
                        {
                            allEnumGroups.Add(new EnumGroupInfo(group, isFlag));
                        }
                    }

                    EnumGroupMember data = new EnumGroupMember(NameMangler.MangleEnumName(@enum.Name), @enum.Value, @enum.Groups, isFlag);

                    switch (@enum.Api)
                    {
                        case GLAPI.None:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES3, @enum.Name, data);
                            break;
                        case GLAPI.GLES1:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                            break;
                        case GLAPI.GLES2:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES3, @enum.Name, data);
                            break;
                        case GLAPI.GL:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                            break;
                    }
                }
            }

            // Now that we have all of the functions and enums ready in dictionaries
            // we can start building all of the API versions.

            // Filter the features we actually want to emit
            List<Feature> features = spec.Features.FindAll(feature => feature.Api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 => true,
                GLAPI.GLSC2 or GLAPI.GLCore => false,
                _ or GLAPI.Invalid or GLAPI.None => throw new Exception($"Feature '{feature.Name}' doesn't have a proper api tag."),
            });
            List<Extension> extensions = spec.Extensions.FindAll(extension => extension.SupportedApis.Any(api => api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 => true,
                GLAPI.GLSC2 or GLAPI.GLCore or GLAPI.None => false,
                _ => throw new Exception($"Extension '{extension.Name}' doesn't have a proper api tag."),
            }));

            var glRequires = GetRequireEntries(features, extensions, GLAPI.GL);
            var gles1Requires = GetRequireEntries(features, extensions, GLAPI.GLES1);
            var gles3Requires = GetRequireEntries(features, extensions, GLAPI.GLES2);
            var glRemoves = GetRemoveEntries(features, GLAPI.GL);
            // OpenGL ES doesn't have any remove tags as of yet, we are just doing this in case it gets added later. // 2021-03-04
            var gles3Removes = GetRemoveEntries(features, GLAPI.GLES2);

            var info = new ProcessedGLInformation(allFunctions, functionToEnumGroupsUsed, allEnumsPerAPI, allEnumGroups.ToList());

            var gl = GetOutputApiFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
            var glCompat = GetOutputApiFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntry>(), info);
            var gles1 = GetOutputApiFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntry>(), info);
            var gles3 = GetOutputApiFromRequireTags(OutputApi.GLES3, gles3Requires, gles3Removes, info);

            return new OutputData(new List<GLOutputApi>()
            {
                gl, glCompat, gles1, gles3
            });
        }

        private static List<(string, RequireEntry entry)> GetRequireEntries(List<Feature> features, List<Extension> extensions, GLAPI api)
        {
            List<(string Vendor, RequireEntry entry)> requireEntries = new List<(string Vendor, RequireEntry entry)>();

            foreach (var feature in features)
            {
                if (feature.Api == api)
                {
                    AddAllRequires("", feature.Requires);
                }
            }

            foreach (var extension in extensions)
            {
                if (extension.SupportedApis.Contains(api))
                {
                    AddAllRequires(extension.Vendor, extension.Requires);
                }
            }

            return requireEntries;

            void AddAllRequires(string vendor, List<RequireEntry> requires)
            {
                foreach (var require in requires)
                {
                    requireEntries.Add((vendor, require));
                }
            }
        }

        private static List<RemoveEntry> GetRemoveEntries(List<Feature> features, GLAPI api)
        {
            List<RemoveEntry> removeEntries = new List<RemoveEntry>();

            foreach (var feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (var remove in feature.Removes)
                    {
                        removeEntries.Add(remove);
                    }
                }
            }

            return removeEntries;
        }

        private static GLOutputApi GetOutputApiFromRequireTags(
            OutputApi api,
            List<(string vendor, RequireEntry requireEntry)> requireEntries,
            List<RemoveEntry> removeEntries, ProcessedGLInformation glInformation)
        {
            HashSet<string> groupsReferencedByFunctions = new HashSet<string>();
            // A list of functions contained in this version.
            Dictionary<string, HashSet<OverloadedFunction>> functionsByVendor = new Dictionary<string, HashSet<OverloadedFunction>>();
            //HashSet<EnumGroupMember> enums = new HashSet<EnumGroupMember>();
            Dictionary<string, List<EnumGroupMember>> enums = new Dictionary<string, List<EnumGroupMember>>();

            HashSet<EnumGroupMember> theAllEnumGroup = new HashSet<EnumGroupMember>();

            // Deconstruct glInformation for easier access
            var (allFunctions, functionToEnumGroupsUsed, allEnumsPerAPI, allEnumGroupsToIsBitmask) = glInformation;

            // Go through all the functions that are required for this version and add them here.
            foreach (var (vendor, requireEntry) in requireEntries)
            {
                foreach (var command in requireEntry.Commands)
                {
                    if (allFunctions.TryGetValue(command, out var function))
                    {
                        functionsByVendor.AddToNestedHashSet(vendor, function);

                        var functionGroups = functionToEnumGroupsUsed[function.NativeFunction];
                        groupsReferencedByFunctions.UnionWith(functionGroups);
                    }
                    else
                    {
                        throw new Exception($"Could not find any function called '{command}'.");
                    }
                }

                foreach (var enumName in requireEntry.Enums)
                {
                    var enumsDict = allEnumsPerAPI[api];
                    if (enumsDict.TryGetValue(enumName, out var @enum))
                    {
                        foreach (string group in @enum.Groups)
                        {
                            if (enums.TryGetValue(group, out var groupMembers) == false)
                            {
                                groupMembers = new List<EnumGroupMember>();
                                enums.Add(group, groupMembers);
                            }

                            if (groupMembers.Find(g => g.Name == @enum.Name) == null)
                            {
                                groupMembers.Add(@enum);
                            }
                        }

                        if (@enum.Value <= uint.MaxValue)
                        {
                            theAllEnumGroup.Add(@enum);
                        }
                    }
                    else
                    {
                        throw new Exception($"Could not find any enum called '{enumName}'.");
                    }
                }
            }

            foreach (var remove in removeEntries)
            {
                foreach (var command in remove.Commands)
                {
                    foreach (var functions in functionsByVendor.Values)
                    {
                        functions.RemoveWhere(f => f.NativeFunction.EntryPoint == command);
                    }
                }
            }

            // Go through all of the enums and put them into their groups

            // Add keys + lists for all enum names
            List<EnumGroup> finalGroups = new List<EnumGroup>();
            foreach (var (groupName, isFlags) in allEnumGroupsToIsBitmask)
            {
                enums.TryGetValue(groupName, out List<EnumGroupMember>? members);
                members ??= new List<EnumGroupMember>();

                // SpecialNumbers is not an enum group that we want to output.
                // We handle these entries differently as some of the entries don't fit in an int.
                if (groupName == "SpecialNumbers")
                    continue;

                // Remove all empty enum groups, except the empty groups referenced by included functions.
                // In GL 4.1 to 4.5 there are functions that use the group "ShaderBinaryFormat"
                // while not including any members for that enum group.
                // This is needed to solve that case.
                if (members.Count <= 0 && groupsReferencedByFunctions.Contains(groupName) == false)
                    continue;

                finalGroups.Add(new EnumGroup(groupName, isFlags, members));
            }

            var vendors = new Dictionary<string, GLVendorFunctions>();
            foreach (var (vendor, overloadedFunctions) in functionsByVendor)
            {
                foreach (var overloadedFunction in overloadedFunctions)
                {
                    if (!vendors.TryGetValue(vendor, out var group))
                    {
                        group = new GLVendorFunctions(
                            new List<NativeFunction>(), new List<Overload[]>(), new HashSet<NativeFunction>());
                        vendors.Add(vendor, group);
                    }
                    group.NativeFunctions.Add(overloadedFunction.NativeFunction);
                    group.OverloadsGroupedByNativeFunctions.Add(overloadedFunction.Overloads);

                    if (overloadedFunction.ChangeNativeName)
                    {
                        group.NativeFunctionsWithPostfix.Add(overloadedFunction.NativeFunction);
                    }
                }
            }

            return new GLOutputApi(api, vendors, theAllEnumGroup.ToList(), finalGroups);
        }

        public static NativeFunction MakeNativeFunction(Command command, out string[] enumGroupsUsed)
        {
            string functionName = NameMangler.MangleFunctionName(command.EntryPoint);

            HashSet<string> enumGroups = new HashSet<string>();

            List<Parameter> parameters = new List<Parameter>();
            foreach (var p in command.Parameters)
            {
                BaseCSType t = MakeCSType(p.Type.Type, p.Type.Handle, p.Type.Group, out var length);
                parameters.Add(new Parameter(t, NameMangler.MangleParameterName(p.Name), p.Length ?? length));
                if (p.Type.Group != null)
                    enumGroups.Add(p.Type.Group);
            }

            BaseCSType returnType = MakeCSType(command.ReturnType.Type, command.ReturnType.Handle, command.ReturnType.Group, out _);
            if (command.ReturnType.Group != null)
                enumGroups.Add(command.ReturnType.Group);

            enumGroupsUsed = enumGroups.ToArray();

            return new NativeFunction(command.EntryPoint, functionName, parameters, returnType);
        }

        public static BaseCSType MakeCSType(GLType type, HandleType? handle, string? group, out Expression? length)
        {
            length = default;
            if (handle != null && type is GLBaseType handleType)
            {
                return new CSStruct(handle.ToString()!, handleType.Constant, new CSPrimitive("int", handleType.Constant));
            }

            switch (type)
            {
                case GLPointerType pt:
                    return new CSPointer(MakeCSType(pt.BaseType, handle, group, out length), pt.Constant);
                case GLBaseType bt:
                    return bt.Type switch
                    {
                        PrimitiveType.Void => new CSVoid(bt.Constant),
                        PrimitiveType.Bool8 => new CSBool8(bt.Constant),
                        PrimitiveType.Byte => new CSPrimitive("byte", bt.Constant),
                        PrimitiveType.Char8 => new CSChar8(bt.Constant),
                        PrimitiveType.Sbyte => new CSPrimitive("sbyte", bt.Constant),
                        PrimitiveType.Short => new CSPrimitive("short", bt.Constant),
                        PrimitiveType.Ushort => new CSPrimitive("ushort", bt.Constant),
                        PrimitiveType.Int => new CSPrimitive("int", bt.Constant),
                        PrimitiveType.Uint => new CSPrimitive("uint", bt.Constant),
                        PrimitiveType.Long => new CSPrimitive("long", bt.Constant),
                        PrimitiveType.Ulong => new CSPrimitive("ulong", bt.Constant),
                        // This might need an include, but the spec doesn't use this type
                        // so we don't really need to do anything...
                        PrimitiveType.Half => new CSStruct("Half", bt.Constant, new CSPrimitive("ushort", bt.Constant)),
                        PrimitiveType.Float => new CSPrimitive("float", bt.Constant),
                        PrimitiveType.Double => new CSPrimitive("double", bt.Constant),
                        PrimitiveType.IntPtr => new CSPrimitive("IntPtr", bt.Constant),
                        PrimitiveType.Nint => new CSPrimitive("nint", bt.Constant),

                        PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), bt.Constant),

                        // FIXME: Should this be treated special?
                        PrimitiveType.Enum => new CSPrimitive(group ?? "All", bt.Constant),

                        // FIXME: Are these just normal CSType? probably...
                        PrimitiveType.GLHandleARB => new CSStruct("GLHandleARB", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),
                        PrimitiveType.GLSync => new CSStruct("GLSync", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                        PrimitiveType.CLContext => new CSStruct("CLContext", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),
                        PrimitiveType.CLEvent => new CSStruct("CLEvent", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                        PrimitiveType.GLDEBUGPROC => new CSFunctionPointer("GLDebugProc", bt.Constant),
                        PrimitiveType.GLDEBUGPROCARB => new CSFunctionPointer("GLDebugProcARB", bt.Constant),
                        PrimitiveType.GLDEBUGPROCKHR => new CSFunctionPointer("GLDebugProcKHR", bt.Constant),
                        PrimitiveType.GLDEBUGPROCAMD => new CSFunctionPointer("GLDebugProcAMD", bt.Constant),
                        PrimitiveType.GLDEBUGPROCNV => new CSFunctionPointer("GLDebugProcNV", bt.Constant),
                        PrimitiveType.GLVULKANPROCNV => new CSFunctionPointer("GLVulkanProcNV", bt.Constant),

                        PrimitiveType.Invalid => throw new Exception(),
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }

        // FIXME: The return variable might go out of scope, declare the variables the first thing we do.
        // FIXME: Figure out how to cast ref/out/in to pointers.
        // FIXME: Figure out how we do return type overloading? Do we rename the raw function to something else?
        // FIXME: Should we only be able to have one return type overload?
        // Maybe we can do the return type overloading in a post processing step?
        public static Overload[] GenerateOverloads(NativeFunction function, out bool changeNativeName)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null, null, function.Parameters.ToArray(), function, function.ReturnType,
                    new NameTable(), "returnValue", Array.Empty<string>(), function.FunctionName),
            };

            bool overloadedOnce = false;
            foreach (var overloader in IOverloader.Overloaders)
            {
                List<Overload> newOverloads = new List<Overload>();
                foreach (var overload in overloads)
                {
                    if (overloader.TryGenerateOverloads(overload, out var overloaderOverloads))
                    {
                        overloadedOnce = true;

                        newOverloads.AddRange(overloaderOverloads);
                    }
                    else
                    {
                        newOverloads.Add(overload);
                    }
                }
                // Replace the old overloads with the new overloads
                overloads = newOverloads;
            }
            if (overloadedOnce)
            {
                changeNativeName = false;
                foreach (var overload in overloads)
                {
                    if (function.Parameters.Count != overload.InputParameters.Length ||
                        overload.OverloadName != function.FunctionName)
                    {
                        continue;
                    }

                    changeNativeName = true;
                    for (int i = 0; i < function.Parameters.Count; i++)
                    {
                        if (!function.Parameters[i].Type.Equals(overload.InputParameters[i].Type))
                        {
                            changeNativeName = false;
                            break;
                        }
                    }

                    if (changeNativeName == true)
                    {
                        break;
                    }
                }
                return overloads.ToArray();
            }
            else
            {
                changeNativeName = false;
                return Array.Empty<Overload>();
            }
        }
    }
}
