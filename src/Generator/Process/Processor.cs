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
            Dictionary<OutputApi, CommandDocumentation> Documentation,
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

        record RequireEntryInfo(
            string Vendor,
            // FIXME: Make this just one string?
            Version? IntroducedInVersion,
            string? IntroducedInExtension,
            RequireEntry Entry);

        record RemoveEntryInfo(
            Version RemovedInVersion,
            RemoveEntry Entry);

        public static OutputData ProcessSpec(Specification spec, Documentation docs)
        {
            // The first thing we do is process all of the functions defined into a dictionary of NativeFunctions.
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Commands.Count);
            foreach (Command command in spec.Commands)
            {
                NativeFunction nativeFunction = MakeNativeFunction(command);
                Dictionary<OutputApi, CommandDocumentation> functionDocumentation = MakeDocumentationForNativeFunction(nativeFunction, docs);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction, functionDocumentation);

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

            List<RequireEntryInfo> glRequires = GetRequireEntries(features, extensions, GLAPI.GL);
            List<RequireEntryInfo> gles1Requires = GetRequireEntries(features, extensions, GLAPI.GLES1);
            List<RequireEntryInfo> gles3Requires = GetRequireEntries(features, extensions, GLAPI.GLES2);
            List<RemoveEntryInfo> glRemoves = GetRemoveEntries(features, GLAPI.GL);
            // OpenGL ES doesn't have any remove tags as of yet, we are just doing this in case it gets added later. // 2021-03-04
            List<RemoveEntryInfo> gles3Removes = GetRemoveEntries(features, GLAPI.GLES2);

            ProcessedGLInformation info = new ProcessedGLInformation(allFunctions, allEnumsPerAPI, allEnumGroups.ToList());

            GLOutputApi gl = GetOutputApiFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
            GLOutputApi glCompat = GetOutputApiFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntryInfo>(), info);
            GLOutputApi gles1 = GetOutputApiFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntryInfo>(), info);
            GLOutputApi gles3 = GetOutputApiFromRequireTags(OutputApi.GLES3, gles3Requires, gles3Removes, info);

            return new OutputData(new List<GLOutputApi>()
            {
                gl, glCompat, gles1, gles3
            });
        }

        private static List<RequireEntryInfo> GetRequireEntries(List<Feature> features, List<Extension> extensions, GLAPI api)
        {
            List<RequireEntryInfo> requireEntries = new List<RequireEntryInfo>();

            foreach (Feature feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (RequireEntry require in feature.Requires)
                    {
                        requireEntries.Add(new RequireEntryInfo("", feature.Version, null, require));
                    }
                }
            }

            foreach (Extension extension in extensions)
            {
                if (extension.SupportedApis.Contains(api))
                {
                    foreach (RequireEntry require in extension.Requires)
                    {
                        requireEntries.Add(new RequireEntryInfo(extension.Vendor, null, extension.Name, require));
                    }
                }
            }

            return requireEntries;
        }

        private static List<RemoveEntryInfo> GetRemoveEntries(List<Feature> features, GLAPI api)
        {
            List<RemoveEntryInfo> removeEntries = new List<RemoveEntryInfo>();

            foreach (Feature feature in features)
            {
                if (feature.Api == api)
                {
                    foreach (RemoveEntry remove in feature.Removes)
                    {
                        removeEntries.Add(new RemoveEntryInfo(feature.Version, remove));
                    }
                }
            }

            return removeEntries;
        }

        private static GLOutputApi GetOutputApiFromRequireTags(
            OutputApi api,
            List<RequireEntryInfo> requireEntries,
            List<RemoveEntryInfo> removeEntries,
            ProcessedGLInformation glInformation)
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

            Dictionary<NativeFunction, List<string>> functionsAddedIn = new Dictionary<NativeFunction, List<string>>();
            // FIXME: Fill this with actual information...
            // This will need us to pass a list of remove entries to this function even for compatibility.
            Dictionary<NativeFunction, List<string>> functionsRemovedIn = new Dictionary<NativeFunction, List<string>>();

            // Go through all the functions that are required for this version and add them here.
            foreach ((string vendor, Version? introducedInVersion, string? introducedInExtension, RequireEntry requireEntry) in requireEntries)
            {
                if (introducedInVersion != null && introducedInExtension != null)
                {
                    throw new Exception("This requires entry has both version and extension information, there is probably something weird going on?");
                }

                string? addedInString = null;
                // FIXME: Maybe we keep the version separate from the extension strings we can more easily
                // do something like "<version> or <extension_name>".
                if (introducedInVersion != null)
                {
                    addedInString = $"v{introducedInVersion.Major}.{introducedInVersion.Minor}";
                }

                if (introducedInExtension != null)
                {
                    addedInString = introducedInExtension;
                }

                if (addedInString == null)
                {
                    throw new Exception($"This requires entry does not have information on wether it is introduced in a GL version or extension.");
                }

                // Skip all of the compatibility profile requires if we are not doing GLCompat
                if (requireEntry.Profile == GLProfile.Compatibility && api != OutputApi.GLCompat)
                {
                    continue;
                }

                foreach (string command in requireEntry.Commands)
                {
                    if (allFunctions.TryGetValue(command, out OverloadedFunction? function))
                    {
                        functionsByVendor.AddToNestedHashSet(vendor, function);

                        groupsReferencedByFunctions.UnionWith(function.NativeFunction.ReferencedEnumGroups);

                        if (functionsAddedIn.TryGetValue(function.NativeFunction, out List<string>? addedIn) == false)
                        {
                            addedIn = new List<string>();
                            functionsAddedIn.Add(function.NativeFunction, addedIn);
                        }

                        addedIn.Add(addedInString);
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

            foreach ((Version removedInVersion, RemoveEntry removeEntry) in removeEntries)
            {
                foreach (string command in removeEntry.Commands)
                {
                    foreach (HashSet<OverloadedFunction> functions in functionsByVendor.Values)
                    {
                        functions.RemoveWhere(f => f.NativeFunction.EntryPoint == command);
                    }
                }
            }

            Dictionary<NativeFunction, FunctionDocumentation> documentation = new Dictionary<NativeFunction, FunctionDocumentation>();
            foreach (var (vendor, functions) in functionsByVendor)
            {
                foreach (var function in functions)
                {
                    if (function.Documentation.TryGetValue(api, out CommandDocumentation? commandDocumentation))
                    {
                        if (functionsAddedIn.TryGetValue(function.NativeFunction, out List<string>? addedIn) == false)
                        {
                            throw new Exception($"{function.NativeFunction.EntryPoint} has no \"added in\" data.");
                        }

                        // FIXME: Added and removed information.
                        documentation[function.NativeFunction] = new FunctionDocumentation(
                            commandDocumentation.Name,
                            commandDocumentation.Purpose,
                            commandDocumentation.Parameters,
                            commandDocumentation.RefPagesLink,
                            addedIn,
                            null
                            );
                    }
                    else
                    {
                        if (vendor == "")
                        {
                            Logger.Warning($"{function.NativeFunction.EntryPoint} doesn't have any documentation for {api}");
                        }
                        else
                        {
                            if (functionsAddedIn.TryGetValue(function.NativeFunction, out List<string>? addedIn) == false)
                            {
                                throw new Exception($"{function.NativeFunction.EntryPoint} has no \"added in\" data.");
                            }

                            documentation[function.NativeFunction] = new FunctionDocumentation(
                                function.NativeFunction.EntryPoint,
                                "",
                                Array.Empty<ParameterDocumentation>(),
                                // TODO: Is it possible to get the extension spec file and link to it here?
                                "",
                                addedIn,
                                null
                                );
                            // Extensions don't have documentation (yet?)
                        }
                    }
                }
            }

            // Go through all of the enums and put them into their groups

            // Add keys + lists for all enum names
            List<EnumGroup> finalGroups = new List<EnumGroup>();

            // Add the All enum group
            finalGroups.Add(new EnumGroup("All", false, theAllEnumGroup.ToList()));

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
                        group = new GLVendorFunctions(new List<NativeFunction>(), new List<Overload[]>(), new HashSet<NativeFunction>());
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

            return new GLOutputApi(api, vendors, finalGroups, documentation);
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

        public static Dictionary<OutputApi, CommandDocumentation> MakeDocumentationForNativeFunction(NativeFunction function, Documentation documentation)
        {
            Dictionary<OutputApi, CommandDocumentation> commandDocs = new Dictionary<OutputApi, CommandDocumentation>();

            foreach (var (version, versionDocumentation) in documentation.VersionDocumentation)
            {
                if (versionDocumentation.Commands.TryGetValue(function.EntryPoint, out CommandDocumentation? commandDoc))
                {
                    if (function.Parameters.Count != commandDoc.Parameters.Length)
                    {
                        Logger.Warning($"Function {function.EntryPoint} has differnet number of parameters than the parsed documentation. (gl.xml:{function.Parameters.Count}, documentation:{commandDoc.Parameters.Length})");
                    }

                    for (int i = 0; i < Math.Min(function.Parameters.Count, commandDoc.Parameters.Length); i++)
                    {
                        if (function.Parameters[i].Name != commandDoc.Parameters[i].Name)
                        {
                            Logger.Warning($"[{version}][{function.EntryPoint}] Function parameter '{function.Parameters[i].Name}' doesn't have the same name in the documentation. ('{commandDoc.Parameters[i].Name}')");
                        }
                    }

                    commandDocs.Add(version, commandDoc);
                }
            }

            return commandDocs;
        }

        // Maybe we can do the return type overloading in a post processing step?
        public static OverloadedFunction GenerateOverloads(NativeFunction nativeFunction, Dictionary<OutputApi, CommandDocumentation> functionDocumentation)
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
            foreach (Overload overload in overloadArray)
            {
                if (AreSignaturesDifferent(nativeFunction, overload) == false)
                {
                    changeNativeName = true;
                }
            }

            return new OverloadedFunction(nativeFunction, functionDocumentation, overloadArray, changeNativeName);
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
