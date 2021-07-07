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
            foreach (Command command in spec.Commands)
            {
                NativeFunction nativeFunction = MakeNativeFunction(command);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction);

                allFunctions.Add(nativeFunction.EntryPoint, overloadedFunction);
            }

            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumGroupMember>>();
            HashSet<EnumGroupInfo> allEnumGroups = new HashSet<EnumGroupInfo>();
            foreach (Enums enumsEntry in spec.Enums)
            {
                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                foreach (EnumEntry @enum in enumsEntry.Entries)
                {
                    foreach (string group in @enum.Groups)
                    {
                        // If the first enums tag wasn't flagged as a bitmask, but later ones in the same group are.
                        // Then we want the group to be considered a bitmask.
                        if (allEnumGroups.TryGetValue(new EnumGroupInfo(group, isFlag), out EnumGroupInfo? actual))
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

            // Filter the features we actually want to output.
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

            List<(string vendor, RequireEntry entry)> glRequires = GetRequireEntries(features, extensions, GLAPI.GL);
            List<(string vendor, RequireEntry entry)> gles1Requires = GetRequireEntries(features, extensions, GLAPI.GLES1);
            List<(string vendor, RequireEntry entry)> gles3Requires = GetRequireEntries(features, extensions, GLAPI.GLES2);
            List<RemoveEntry> glRemoves = GetRemoveEntries(features, GLAPI.GL);
            // OpenGL ES doesn't have any remove tags as of yet, we are just doing this in case it gets added later. // 2021-03-04
            List<RemoveEntry> gles3Removes = GetRemoveEntries(features, GLAPI.GLES2);

            ProcessedGLInformation info = new ProcessedGLInformation(allFunctions, allEnumsPerAPI, allEnumGroups.ToList());

            GLOutputApi gl = GetOutputApiFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
            GLOutputApi glCompat = GetOutputApiFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntry>(), info);
            GLOutputApi gles1 = GetOutputApiFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntry>(), info);
            GLOutputApi gles3 = GetOutputApiFromRequireTags(OutputApi.GLES3, gles3Requires, gles3Removes, info);

            return new OutputData(new List<GLOutputApi>()
            {
                gl, glCompat, gles1, gles3
            });
        }

        private static List<(string vendor, RequireEntry entry)> GetRequireEntries(List<Feature> features, List<Extension> extensions, GLAPI api)
        {
            List<(string vendor, RequireEntry entry)> requireEntries = new List<(string vendor, RequireEntry entry)>();

            foreach (Feature feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (RequireEntry require in feature.Requires)
                    {
                        requireEntries.Add(("", require));
                    }
                }
            }

            foreach (Extension extension in extensions)
            {
                if (extension.SupportedApis.Contains(api))
                {
                    foreach (RequireEntry require in extension.Requires)
                    {
                        requireEntries.Add((extension.Vendor, require));
                    }
                }
            }

            return requireEntries;
        }

        private static List<RemoveEntry> GetRemoveEntries(List<Feature> features, GLAPI api)
        {
            List<RemoveEntry> removeEntries = new List<RemoveEntry>();

            foreach (Feature feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (RemoveEntry remove in feature.Removes)
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
            Dictionary<string, OverloadedFunction> allFunctions = glInformation.AllFunctions;
            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = glInformation.AllEnumsPerAPI;
            List<EnumGroupInfo> allEnumGroups = glInformation.AllEnumGroups;

            // Go through all the functions that are required for this version and add them here.
            foreach ((string vendor, RequireEntry requireEntry) in requireEntries)
            {
                foreach (string command in requireEntry.Commands)
                {
                    if (allFunctions.TryGetValue(command, out OverloadedFunction? function))
                    {
                        functionsByVendor.AddToNestedHashSet(vendor, function);

                        groupsReferencedByFunctions.UnionWith(function.NativeFunction.ReferencedEnumGroups);
                    }
                    else
                    {
                        throw new Exception($"Could not find any function called '{command}'.");
                    }
                }

                foreach (string? enumName in requireEntry.Enums)
                {
                    Dictionary<string, EnumGroupMember>? enumsDict = allEnumsPerAPI[api];
                    if (enumsDict.TryGetValue(enumName, out EnumGroupMember? @enum))
                    {
                        foreach (string group in @enum.Groups)
                        {
                            if (enums.TryGetValue(group, out List<EnumGroupMember>? groupMembers) == false)
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

            foreach (RemoveEntry remove in removeEntries)
            {
                foreach (string command in remove.Commands)
                {
                    foreach (HashSet<OverloadedFunction> functions in functionsByVendor.Values)
                    {
                        functions.RemoveWhere(f => f.NativeFunction.EntryPoint == command);
                    }
                }
            }

            // Go through all of the enums and put them into their groups

            // Add keys + lists for all enum names
            List<EnumGroup> finalGroups = new List<EnumGroup>();
            foreach ((string groupName, bool isFlags) in allEnumGroups)
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

            Dictionary<string, GLVendorFunctions> vendors = new Dictionary<string, GLVendorFunctions>();
            foreach ((string vendor, HashSet<OverloadedFunction> overloadedFunctions) in functionsByVendor)
            {
                foreach (OverloadedFunction overloadedFunction in overloadedFunctions)
                {
                    if (!vendors.TryGetValue(vendor, out GLVendorFunctions? group))
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

        public static NativeFunction MakeNativeFunction(Command command)
        {
            string functionName = NameMangler.MangleFunctionName(command.EntryPoint);

            HashSet<string> referencedEnumGroups = new HashSet<string>();

            List<Parameter> parameters = new List<Parameter>();
            foreach (GLParameter parameter in command.Parameters)
            {
                BaseCSType type = MakeCSType(parameter.Type.Type, parameter.Type.Handle, parameter.Type.Group);
                parameters.Add(new Parameter(type, NameMangler.MangleParameterName(parameter.Name), parameter.Length));
                if (parameter.Type.Group != null)
                {
                    referencedEnumGroups.Add(parameter.Type.Group);
                }
            }

            BaseCSType returnType = MakeCSType(command.ReturnType.Type, command.ReturnType.Handle, command.ReturnType.Group);
            if (command.ReturnType.Group != null)
            {
                referencedEnumGroups.Add(command.ReturnType.Group);
            }

            return new NativeFunction(command.EntryPoint, functionName, parameters, returnType, referencedEnumGroups.ToArray());
        }

        public static BaseCSType MakeCSType(GLType type, HandleType? handle, string? group)
        {
            switch (type)
            {
                case GLPointerType pt:
                    return new CSPointer(MakeCSType(pt.BaseType, handle, group), pt.Constant);

                case GLBaseType bt when handle != null:
                    return new CSStruct(handle.Value.ToString(), bt.Constant, new CSPrimitive("int", bt.Constant));

                case GLBaseType bt when handle == null:
                    return bt.Type switch
                    {
                        // C# primitive types
                        PrimitiveType.Void => new CSVoid(bt.Constant),
                        PrimitiveType.Byte => new CSPrimitive("byte", bt.Constant),
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

                        // C interop types
                        PrimitiveType.Bool8 => new CSBool8(bt.Constant),
                        PrimitiveType.Char8 => new CSChar8(bt.Constant),

                        // Enum
                        PrimitiveType.Enum => new CSPrimitive(group ?? "All", bt.Constant),

                        // Pointers
                        PrimitiveType.IntPtr => new CSPrimitive("IntPtr", bt.Constant),
                        PrimitiveType.Nint => new CSPrimitive("nint", bt.Constant),
                        PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), bt.Constant),

                        // FIXME: Output the GLHandleARB again...
                        PrimitiveType.GLHandleARB => new CSStruct("GLHandleARB", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                        PrimitiveType.GLSync => new CSStruct("GLSync", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                        // OpenCL structs
                        PrimitiveType.CLContext => new CSStruct("CLContext", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),
                        PrimitiveType.CLEvent => new CSStruct("CLEvent", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                        // Function pointer types
                        PrimitiveType.GLDebugProc => new CSFunctionPointer("GLDebugProc", bt.Constant),
                        PrimitiveType.GLDebugProcARB => new CSFunctionPointer("GLDebugProcARB", bt.Constant),
                        PrimitiveType.GLDebugProcKHR => new CSFunctionPointer("GLDebugProcKHR", bt.Constant),
                        PrimitiveType.GLDebugProcAMD => new CSFunctionPointer("GLDebugProcAMD", bt.Constant),
                        PrimitiveType.GLDebugProcNV => new CSFunctionPointer("GLDebugProcNV", bt.Constant),
                        PrimitiveType.GLVulkanProcNV => new CSFunctionPointer("GLVulkanProcNV", bt.Constant),

                        PrimitiveType.Invalid => throw new Exception(),
                        _ => throw new Exception(),
                    };
                default:
                    throw new Exception();
            }
        }

        // Maybe we can do the return type overloading in a post processing step?
        public static OverloadedFunction GenerateOverloads(NativeFunction nativeFunction)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null, null, nativeFunction.Parameters.ToArray(), nativeFunction, nativeFunction.ReturnType,
                    new NameTable(), "returnValue", Array.Empty<string>(), nativeFunction.FunctionName),
            };

            bool overloadedOnce = false;
            foreach (IOverloader overloader in IOverloader.Overloaders)
            {
                List<Overload> newOverloads = new List<Overload>();
                foreach (Overload overload in overloads)
                {
                    if (overloader.TryGenerateOverloads(overload, out List<Overload>? overloaderOverloads))
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
            Overload[] overloadArray = overloadedOnce ? overloads.ToArray() : Array.Empty<Overload>();

            bool changeNativeName = false;
            foreach (Overload overload in overloads)
            {
                if (AreSignaturesDifferent(nativeFunction, overload) == false)
                {
                    changeNativeName = true;
                }
            }

            return new OverloadedFunction(nativeFunction, overloadArray, changeNativeName);
        }

        private static bool AreSignaturesDifferent(NativeFunction nativeFunction, Overload overload)
        {
            if (nativeFunction.Parameters.Count != overload.InputParameters.Length)
            {
                return true;
            }

            if (overload.OverloadName != nativeFunction.FunctionName)
            {
                return true;
            }

            for (int i = 0; i < nativeFunction.Parameters.Count; i++)
            {
                if (nativeFunction.Parameters[i].Type.Equals(overload.InputParameters[i].Type) == false)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
