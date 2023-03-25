using System;
using System.Collections.Generic;
using System.Linq;
using Generator.Utility.Extensions;
using Generator.Utility;
using Generator.Writing;
using Generator.Parsing;
using System.Net.Http.Headers;
using System.Collections.Immutable;

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
            // When this case happens we want to consider the entire groupName as a bitmask.
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
            // The first thing we do is process all of the vendorFunctions defined into a dictionary of Functions.
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Commands.Count);
            foreach (Command command in spec.Commands)
            {
                NativeFunction nativeFunction = MakeNativeFunction(command);
                Dictionary<OutputApi, CommandDocumentation> functionDocumentation = MakeDocumentationForNativeFunction(nativeFunction, docs);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction, functionDocumentation);

                allFunctions.Add(nativeFunction.EntryPoint, overloadedFunction);
            }

            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumGroupMember>>()
            {
                { OutputApi.GLES1, new Dictionary<string, EnumGroupMember>() },
                { OutputApi.GLES2, new Dictionary<string, EnumGroupMember>() },
                { OutputApi.GL, new Dictionary<string, EnumGroupMember>() },
                { OutputApi.GLCompat, new Dictionary<string, EnumGroupMember>() },
                { OutputApi.WGL, new Dictionary<string, EnumGroupMember>() },
            };
            HashSet<EnumGroupInfo> allEnumGroups = new HashSet<EnumGroupInfo>();
            foreach (Enums enumsEntry in spec.Enums)
            {
                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                foreach (EnumEntry @enum in enumsEntry.Entries)
                {
                    foreach (string group in @enum.Groups)
                    {
                        // If the first groupNameToEnumGroup tag wasn't flagged as a bitmask, but later ones in the same groupName are.
                        // Then we want the groupName to be considered a bitmask.
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
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES2, @enum.Name, data);
                            break;
                        case GLAPI.GLES1:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                            break;
                        case GLAPI.GLES2:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES2, @enum.Name, data);
                            break;
                        case GLAPI.GL:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                            break;
                        case GLAPI.WGL:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.WGL, @enum.Name, data);
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }

            // Now that we have all of the vendorFunctions and groupNameToEnumGroup ready in dictionaries
            // we can start building all of the API versions.

            // Filter the features we actually want to output.
            List<Feature> features = spec.Features.FindAll(feature => feature.Api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 or GLAPI.WGL => true,
                GLAPI.GLSC2 or GLAPI.GLCore => false,
                _ or GLAPI.Invalid or GLAPI.None => throw new Exception($"Feature '{feature.Name}' doesn't have a proper api tag."),
            });
            List<Extension> extensions = spec.Extensions.FindAll(extension => extension.SupportedApis.Any(api => api switch
            {
                GLAPI.GL or GLAPI.GLES1 or GLAPI.GLES2 or GLAPI.WGL => true,
                GLAPI.GLSC2 or GLAPI.GLCore or GLAPI.None => false,
                _ => throw new Exception($"Extension '{extension.Name}' doesn't have a proper api tag."),
            }));

            List<RequireEntryInfo> glRequires = GetRequireEntries(features, extensions, GLAPI.GL);
            List<RequireEntryInfo> gles1Requires = GetRequireEntries(features, extensions, GLAPI.GLES1);
            List<RequireEntryInfo> gles2Requires = GetRequireEntries(features, extensions, GLAPI.GLES2);
            List<RequireEntryInfo> wglRequires = GetRequireEntries(features, extensions, GLAPI.WGL);
            List<RemoveEntryInfo> glRemoves = GetRemoveEntries(features, GLAPI.GL);
            // OpenGL ES doesn't have any remove tags as of yet, we are just doing this in case it gets added later.
            // - Noggin_bops 2023-01-26
            List<RemoveEntryInfo> gles2Removes = GetRemoveEntries(features, GLAPI.GLES2);
            List<RemoveEntryInfo> wglRemoves = GetRemoveEntries(features, GLAPI.WGL);

            ProcessedGLInformation info = new ProcessedGLInformation(allFunctions, allEnumsPerAPI, allEnumGroups.ToList());

            GLOutputApi gl = GetOutputApiFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
            GLOutputApi glCompat = GetOutputApiFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntryInfo>(), info);
            GLOutputApi gles1 = GetOutputApiFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntryInfo>(), info);
            GLOutputApi gles2 = GetOutputApiFromRequireTags(OutputApi.GLES2, gles2Requires, gles2Removes, info);
            GLOutputApi wgl = GetOutputApiFromRequireTags(OutputApi.WGL, wglRequires, wglRemoves, info);

            return new OutputData(allFunctions.Select(kvp => kvp.Value.NativeFunction).ToList(),
                new List<GLOutputApi>()
                {
                    gl, glCompat, gles1, gles2, wgl
                });
        }

        public static OutputData ProcessSpec2(Specification2 spec, Documentation docs)
        {
            // The first thing we do is process all of the vendorFunctions defined into a dictionary of Functions.
            List<NativeFunction> allEntryPoints = new List<NativeFunction>();
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Commands.Count);
            foreach (Command command in spec.Commands)
            {
                NativeFunction nativeFunction = MakeNativeFunction(command);
                Dictionary<OutputApi, CommandDocumentation> functionDocumentation = MakeDocumentationForNativeFunction(nativeFunction, docs);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction, functionDocumentation);

                allEntryPoints.Add(nativeFunction);
                allFunctions.Add(nativeFunction.EntryPoint, overloadedFunction);
            }

            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumGroupMember>>();

            // Add all of the relevant APIs to the dictionary
            foreach (var api in spec.APIs)
            {
                OutputApi outputApi = api.Name switch
                {
                    InputAPI.GL => OutputApi.GL,
                    // FIXME ? 
                    //InputAPI.GLCompat => OutputApi.GLCompat,
                    InputAPI.GLES1 => OutputApi.GLES1,
                    InputAPI.GLES2 => OutputApi.GLES2,
                    InputAPI.WGL => OutputApi.WGL,
                    InputAPI.GLX => OutputApi.GLX,

                    _ => throw new Exception(),
                };

                allEnumsPerAPI.Add(outputApi, new Dictionary<string, EnumGroupMember>());

                if (outputApi == OutputApi.GL)
                {
                    allEnumsPerAPI.Add(OutputApi.GLCompat, new Dictionary<string, EnumGroupMember>());
                }
            }

            HashSet<EnumGroupInfo> allEnumGroups = new HashSet<EnumGroupInfo>();
            foreach (Enums enumsEntry in spec.Enums)
            {
                bool isFlag = enumsEntry.Type == EnumType.Bitmask;
                foreach (EnumEntry @enum in enumsEntry.Entries)
                {
                    foreach (string group in @enum.Groups)
                    {
                        // If the first groupNameToEnumGroup tag wasn't flagged as a bitmask, but later ones in the same groupName are.
                        // Then we want the groupName to be considered a bitmask.
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
                            // If this enumName is not marked with a specific api, add it to all relevant apis.
                            foreach (var api in allEnumsPerAPI.Keys)
                            {
                                allEnumsPerAPI.AddToNestedDict(api, @enum.Name, data);
                            }
                            break;
                        case GLAPI.GLES1:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                            break;
                        case GLAPI.GLES2:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLES2, @enum.Name, data);
                            break;
                        case GLAPI.GL:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                            allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                            break;
                        case GLAPI.WGL:
                            allEnumsPerAPI.AddToNestedDict(OutputApi.WGL, @enum.Name, data);
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }

            List<GLOutputApi> outputAPIs = new List<GLOutputApi>();

            foreach (var (api, functions, enums) in spec.APIs)
            {
                // FIXME: Probably make these the same enum!
                OutputApi outAPI = api switch
                {
                    InputAPI.GL => OutputApi.GL,
                    // FIXME?
                    //InputAPI.GLCompat => OutputApi.GLCompat,
                    InputAPI.GLES1 => OutputApi.GLES1,
                    InputAPI.GLES2 => OutputApi.GLES2,
                    InputAPI.WGL => OutputApi.WGL,
                    InputAPI.GLX => OutputApi.GLX,

                    _ => throw new Exception(),
                };

                outputAPIs.Add(CreateOutputAPI(outAPI));

                if (outAPI == OutputApi.GL)
                {
                    outputAPIs.Add(CreateOutputAPI(OutputApi.GLCompat));
                }

                GLOutputApi CreateOutputAPI(OutputApi outAPI)
                {
                    bool removeFunctions = outAPI switch
                    {
                        OutputApi.GL => true,
                        OutputApi.GLES2 => true,
                        _ => false,
                    };

                    HashSet<string> groupsReferencedByFunctions = new HashSet<string>();

                    Dictionary<string, EnumGroupMember>? enumsDict = allEnumsPerAPI[outAPI];

                    // FIXME: Make api an OutputAPI

                    Dictionary<string, HashSet<OverloadedFunction>> functionsByVendor = new Dictionary<string, HashSet<OverloadedFunction>>();

                    HashSet<EnumGroupMember> theAllEnumGroup = new HashSet<EnumGroupMember>();

                    foreach (var functionRef in functions)
                    {
                        if (allFunctions.TryGetValue(functionRef.EntryPoint, out OverloadedFunction? overloadedFunction))
                        {
                            bool referenced = false;

                            if (functionRef.AddedIn != null)
                            {
                                if (removeFunctions && (functionRef.RemovedIn != null || functionRef.Profile == GLProfile.Compatibility))
                                {
                                    // Do not add this function
                                }
                                else
                                {
                                    functionsByVendor.AddToNestedHashSet("", overloadedFunction);

                                    referenced = true;
                                }
                            }

                            foreach (var extension in functionRef.PartOfExtensions)
                            {
                                functionsByVendor.AddToNestedHashSet(extension.Vendor, overloadedFunction);

                                referenced = true;
                            }

                            if (referenced)
                            {
                                groupsReferencedByFunctions.UnionWith(overloadedFunction.NativeFunction.ReferencedEnumGroups);
                            }
                        }
                        else
                        {
                            throw new Exception($"Could not find function '{functionRef.EntryPoint}'!");
                        }
                    }

                    Dictionary<string, List<EnumGroupMember>> groupNameToEnumGroup = new Dictionary<string, List<EnumGroupMember>>();

                    foreach (var enumRef in enums)
                    {
                        if (removeFunctions)
                        {
                            // FIXME: Should we check the profile of the extension??
                            if (enumRef.RemovedIn != null || enumRef.Profile == GLProfile.Compatibility)
                            {
                                // FIXME: Add the enum if an extension uses it??
                                continue;
                            }
                        }

                        // FIXME! This is a big hack!
                        // We don't want to process this "enum" as it is a string.
                        if (enumRef.EnumName == "GLX_EXTENSION_NAME") continue;

                        if (enumsDict.TryGetValue(enumRef.EnumName, out EnumGroupMember? @enum))
                        {
                            foreach (string group in @enum.Groups)
                            {
                                if (groupNameToEnumGroup.TryGetValue(group, out List<EnumGroupMember>? groupMembers) == false)
                                {
                                    groupMembers = new List<EnumGroupMember>();
                                    groupNameToEnumGroup.Add(group, groupMembers);
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
                            throw new Exception($"Could not find any enum called '{enumRef.EnumName}'.");
                        }
                    }

                    // Go through all vendorFunctions and build up a Dictionary from enumName groups to function using them
                    Dictionary<string, List<(string Vendor, NativeFunction Function)>> enumGroupToNativeFunctionsUsingThatEnumGroup = new Dictionary<string, List<(string Vendor, NativeFunction Function)>>();
                    foreach (var (vendor, vendorFunctions) in functionsByVendor)
                    {
                        foreach (var function in vendorFunctions)
                        {
                            foreach (var group in function.NativeFunction.ReferencedEnumGroups)
                            {
                                if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(group, out var listOfFunctions) == false)
                                {
                                    listOfFunctions = new List<(string Vendor, NativeFunction Function)>();
                                    enumGroupToNativeFunctionsUsingThatEnumGroup.Add(group, listOfFunctions);
                                }

                                if (listOfFunctions.Contains((vendor, function.NativeFunction)) == false)
                                {
                                    listOfFunctions.Add((vendor, function.NativeFunction));
                                }
                            }
                        }
                    }

                    // Go through all of the groupNameToEnumGroup and put them into their groups

                    // Add keys + lists for all enumName names
                    List<EnumGroup> finalGroups = new List<EnumGroup>();

                    List<EnumGroupMember> allEnumGroup = theAllEnumGroup.ToList();
                    allEnumGroup.Sort((e1, e2) =>
                    {
                        int comp = e1.Value.CompareTo(e2.Value);
                        if (comp == 0)
                        {
                            return e1.Name.CompareTo(e2.Name);
                        }
                        else
                        {
                            return comp;
                        }
                    });

                    // Add the All enumName groupName
                    finalGroups.Add(new EnumGroup("All", false, allEnumGroup, null));

                    foreach ((string groupName, bool isFlags) in allEnumGroups)
                    {
                        groupNameToEnumGroup.TryGetValue(groupName, out List<EnumGroupMember>? members);
                        members ??= new List<EnumGroupMember>();

                        // SpecialNumbers is not an enumName groupName that we want to output.
                        // We handle these entries differently as some of the entries don't fit in an int.
                        if (groupName == "SpecialNumbers")
                            continue;

                        // Remove all empty enumName groups, except the empty groups referenced by included vendorFunctions.
                        // In GL 4.1 to 4.5 there are vendorFunctions that use the groupName "ShaderBinaryFormat"
                        // while not including any members for that enumName groupName.
                        // This is needed to solve that case.
                        if (members.Count <= 0 && groupsReferencedByFunctions.Contains(groupName) == false)
                            continue;

                        if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(groupName, out var functionsUsingEnumGroup) == false)
                        {
                            functionsUsingEnumGroup = null;
                        }

                        // If there is a list, sort it by name
                        if (functionsUsingEnumGroup != null)
                            functionsUsingEnumGroup.Sort((f1, f2) => {
                                // We want to prioritize "core" vendorFunctions before extensions.
                                if (f1.Vendor == "" && f2.Vendor != "") return -1;
                                if (f1.Vendor != "" && f2.Vendor == "") return 1;

                                return f1.Function.FunctionName.CompareTo(f2.Function.FunctionName);
                            });

                        members.Sort((m1, m2) =>
                        {
                            int comp = m1.Value.CompareTo(m2.Value);
                            if (comp == 0)
                            {
                                return m1.Name.CompareTo(m2.Name);
                            }
                            else
                            {
                                return comp;
                            }
                        });

                        finalGroups.Add(new EnumGroup(groupName, isFlags, members, functionsUsingEnumGroup));
                    }

                    // Group vendors
                    // Group groupNameToEnumGroup
                    // Lookup documentation
                    Dictionary<string, GLVendorFunctions> vendors = new Dictionary<string, GLVendorFunctions>();
                    foreach ((string vendor, HashSet<OverloadedFunction> overloadedFunctions) in functionsByVendor)
                    {
                        foreach (OverloadedFunction overloadedFunction in overloadedFunctions)
                        {
                            if (!vendors.TryGetValue(vendor, out GLVendorFunctions? group))
                            {
                                group = new GLVendorFunctions(new List<Writing.OverloadedFunction>(), new HashSet<NativeFunction>());
                                vendors.Add(vendor, group);
                            }

                            group.Functions.Add(new Writing.OverloadedFunction(overloadedFunction.NativeFunction, overloadedFunction.Overloads));

                            if (overloadedFunction.ChangeNativeName)
                            {
                                group.NativeFunctionsWithPostfix.Add(overloadedFunction.NativeFunction);
                            }
                        }
                    }

                    SortedDictionary<string, GLVendorFunctions> sortedVendors = new SortedDictionary<string, GLVendorFunctions>(vendors);

                    foreach (var (vendor, vendorFunctions) in sortedVendors)
                    {
                        vendorFunctions.Functions.Sort();
                    }

                    Dictionary<NativeFunction, FunctionDocumentation> documentation = new Dictionary<NativeFunction, FunctionDocumentation>();
                    foreach (var (vendor, vendorFunctions) in functionsByVendor)
                    {
                        foreach (var function in vendorFunctions)
                        {
                            if (function.Documentation.TryGetValue(outAPI, out CommandDocumentation? commandDocumentation))
                            {
                                var func = functions.Find(f => f.EntryPoint == function.NativeFunction.EntryPoint);

                                if (func == null)
                                {
                                    throw new Exception($"Could not find function {function.NativeFunction.EntryPoint}!");
                                }

                                List<string> addedIn = new List<string>();
                                if (func.AddedIn != null)
                                {
                                    addedIn.Add($"v{func.AddedIn.Major}.{func.AddedIn.Minor}");
                                }

                                foreach (var extension in func.PartOfExtensions)
                                {
                                    addedIn.Add(extension.Name);
                                }

                                List<string> removedIn = new List<string>();
                                if (func.RemovedIn != null)
                                {
                                    removedIn.Add($"v{func.RemovedIn.Major}.{func.RemovedIn.Minor}");
                                }

                                // FIXME: Added and removed information.
                                documentation[function.NativeFunction] = new FunctionDocumentation(
                                    commandDocumentation.Name,
                                    commandDocumentation.Purpose,
                                    commandDocumentation.Parameters,
                                    commandDocumentation.RefPagesLink,
                                    addedIn,
                                    removedIn
                                    );
                            }
                            else
                            {
                                if (vendor == "")
                                {
                                    Logger.Warning($"{function.NativeFunction.EntryPoint} doesn't have any documentation for {api}");

                                    var func = functions.Find(f => f.EntryPoint == function.NativeFunction.EntryPoint);

                                    if (func == null)
                                    {
                                        throw new Exception($"Could not find function {function.NativeFunction.EntryPoint}!");
                                    }

                                    List<string> addedIn = new List<string>();
                                    if (func.AddedIn != null)
                                    {
                                        addedIn.Add($"v{func.AddedIn.Major}.{func.AddedIn.Minor}");
                                    }

                                    foreach (var extension in func.PartOfExtensions)
                                    {
                                        addedIn.Add(extension.Name);
                                    }

                                    List<string> removedIn = new List<string>();
                                    if (func.RemovedIn != null)
                                    {
                                        removedIn.Add($"v{func.RemovedIn.Major}.{func.RemovedIn.Minor}");
                                    }

                                    documentation[function.NativeFunction] = new FunctionDocumentation(
                                        function.NativeFunction.EntryPoint,
                                        "",
                                        Array.Empty<ParameterDocumentation>(),
                                        // TODO: Is it possible to get the functionRef spec file and link to it here?
                                        null,
                                        addedIn,
                                        removedIn);
                                }
                                else
                                {
                                    var func = functions.Find(f => f.EntryPoint == function.NativeFunction.EntryPoint);

                                    if (func == null)
                                    {
                                        throw new Exception($"Could not find function {function.NativeFunction.EntryPoint}!");
                                    }

                                    List<string> addedIn = new List<string>();
                                    if (func.AddedIn != null)
                                    {
                                        addedIn.Add($"v{func.AddedIn.Major}.{func.AddedIn.Minor}");
                                    }

                                    foreach (var extension in func.PartOfExtensions)
                                    {
                                        addedIn.Add(extension.Name);
                                    }

                                    List<string> removedIn = new List<string>();
                                    if (func.RemovedIn != null)
                                    {
                                        removedIn.Add($"v{func.RemovedIn.Major}.{func.RemovedIn.Minor}");
                                    }

                                    documentation[function.NativeFunction] = new FunctionDocumentation(
                                        function.NativeFunction.EntryPoint,
                                        "",
                                        Array.Empty<ParameterDocumentation>(),
                                        // TODO: Is it possible to get the extension spec file and link to it here?
                                        null,
                                        addedIn,
                                        removedIn);
                                    // Extensions don't have documentation (yet?)
                                }
                            }
                        }
                    }

                    return new GLOutputApi(outAPI, sortedVendors, finalGroups, documentation);
                }

                
            }

            return new OutputData(allEntryPoints, outputAPIs);
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
            // A list of vendorFunctions contained in this version.
            Dictionary<string, HashSet<OverloadedFunction>> functionsByVendor = new Dictionary<string, HashSet<OverloadedFunction>>();
            //HashSet<EnumGroupMember> groupNameToEnumGroup = new HashSet<EnumGroupMember>();
            Dictionary<string, List<EnumGroupMember>> groupNameToEnumGroup = new Dictionary<string, List<EnumGroupMember>>();

            HashSet<EnumGroupMember> theAllEnumGroup = new HashSet<EnumGroupMember>();

            // Deconstruct glInformation for easier access
            Dictionary<string, OverloadedFunction> allFunctions = glInformation.AllFunctions;
            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = glInformation.AllEnumsPerAPI;
            List<EnumGroupInfo> allEnumGroups = glInformation.AllEnumGroups;

            Dictionary<NativeFunction, List<string>> functionsAddedIn = new Dictionary<NativeFunction, List<string>>();
            // FIXME: Fill this with actual information...
            // This will need us to pass a list of remove entries to this functionRef even for compatibility.
            Dictionary<NativeFunction, List<string>> functionsRemovedIn = new Dictionary<NativeFunction, List<string>>();

            // Go through all the vendorFunctions that are required for this version and add them here.
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
                        foreach (string groupName in @enum.Groups)
                        {
                            if (groupNameToEnumGroup.TryGetValue(groupName, out List<EnumGroupMember>? groupMembers) == false)
                            {
                                groupMembers = new List<EnumGroupMember>();
                                groupNameToEnumGroup.Add(groupName, groupMembers);
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

                            if (functionsAddedIn.TryGetValue(function.NativeFunction, out List<string>? addedIn) == false)
                            {
                                throw new Exception($"{function.NativeFunction.EntryPoint} has no \"added in\" data.");
                            }

                            documentation[function.NativeFunction] = new FunctionDocumentation(
                                function.NativeFunction.EntryPoint,
                                "",
                                Array.Empty<ParameterDocumentation>(),
                                // TODO: Is it possible to get the functionRef spec file and link to it here?
                                null,
                                addedIn,
                                null);
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
                                null,
                                addedIn,
                                null);
                            // Extensions don't have documentation (yet?)
                        }
                    }
                }
            }

            // Go through all vendorFunctions and build up a Dictionary from enumName groups to vendorFunctions using them
            Dictionary<string, List<(string Vendor, NativeFunction Function)>> enumGroupToNativeFunctionsUsingThatEnumGroup = new Dictionary<string, List<(string Vendor, NativeFunction Function)>>();
            foreach (var (vendor, functions) in functionsByVendor)
            {
                foreach (var function in functions)
                {
                    foreach (var group in function.NativeFunction.ReferencedEnumGroups)
                    {
                        if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(group, out var listOfFunctions) == false)
                        {
                            listOfFunctions = new List<(string Vendor, NativeFunction Function)>();
                            enumGroupToNativeFunctionsUsingThatEnumGroup.Add(group, listOfFunctions);
                        }

                        if (listOfFunctions.Contains((vendor, function.NativeFunction)) == false)
                        {
                            listOfFunctions.Add((vendor, function.NativeFunction));
                        }
                    }
                }
            }

            // Go through all of the groupNameToEnumGroup and put them into their groups

            // Add keys + lists for all enumName names
            List<EnumGroup> finalGroups = new List<EnumGroup>();

            // Add the All enumName groupName
            finalGroups.Add(new EnumGroup("All", false, theAllEnumGroup.ToList(), null));

            foreach ((string groupName, bool isFlags) in allEnumGroups)
            {
                groupNameToEnumGroup.TryGetValue(groupName, out List<EnumGroupMember>? members);
                members ??= new List<EnumGroupMember>();

                // SpecialNumbers is not an enumName groupName that we want to output.
                // We handle these entries differently as some of the entries don't fit in an int.
                if (groupName == "SpecialNumbers")
                    continue;

                // Remove all empty enumName groups, except the empty groups referenced by included vendorFunctions.
                // In GL 4.1 to 4.5 there are vendorFunctions that use the groupName "ShaderBinaryFormat"
                // while not including any members for that enumName groupName.
                // This is needed to solve that case.
                if (members.Count <= 0 && groupsReferencedByFunctions.Contains(groupName) == false)
                    continue;

                if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(groupName, out var functionsUsingEnumGroup) == false)
                {
                    functionsUsingEnumGroup = null;
                }

                // If there is a list, sort it by name
                if (functionsUsingEnumGroup != null)
                    functionsUsingEnumGroup.Sort((f1, f2) => {
                        // We want to prioritize "core" vendorFunctions before extensions.
                        if (f1.Vendor == "" && f2.Vendor != "") return -1;
                        if (f1.Vendor != "" && f2.Vendor == "") return 1;

                        return f1.Function.FunctionName.CompareTo(f2.Function.FunctionName);
                    });

                finalGroups.Add(new EnumGroup(groupName, isFlags, members, functionsUsingEnumGroup));
            }

            Dictionary<string, GLVendorFunctions> vendors = new Dictionary<string, GLVendorFunctions>();
            foreach ((string vendor, HashSet<OverloadedFunction> overloadedFunctions) in functionsByVendor)
            {
                foreach (OverloadedFunction overloadedFunction in overloadedFunctions)
                {
                    if (!vendors.TryGetValue(vendor, out GLVendorFunctions? group))
                    {
                        group = new GLVendorFunctions(new List<Writing.OverloadedFunction>(), new HashSet<NativeFunction>());
                        vendors.Add(vendor, group);
                    }

                    group.Functions.Add(new Writing.OverloadedFunction(overloadedFunction.NativeFunction, overloadedFunction.Overloads));

                    if (overloadedFunction.ChangeNativeName)
                    {
                        group.NativeFunctionsWithPostfix.Add(overloadedFunction.NativeFunction);
                    }
                }
            }

            SortedDictionary<string, GLVendorFunctions> sortedVendors = new SortedDictionary<string, GLVendorFunctions>(vendors);

            return new GLOutputApi(api, sortedVendors, finalGroups, documentation);
        }

        public static NativeFunction MakeNativeFunction(Command command)
        {
            string functionName = NameMangler.MangleFunctionName(command.EntryPoint);

            HashSet<string> referencedEnumGroups = new HashSet<string>();

            List<Parameter> parameters = new List<Parameter>();
            foreach (GLParameter parameter in command.Parameters)
            {
                BaseCSType type = MakeCSType(parameter.Type.Type, parameter.Type.Handle, parameter.Type.Group);
                // FIXME: Maybe we want to do some kind of processing on parameter.Kind to not pass it directly as it is in gl.xml
                parameters.Add(new Parameter(type, parameter.Kinds, NameMangler.MangleParameterName(parameter.Name), parameter.Length));
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

                case GLBaseType bt:
                    {
                        if (Options.UseTypesafeGLHandles && handle != null)
                        {
                            return new CSStructPrimitive(handle.Value.ToString(), bt.Constant, new CSPrimitive("int", bt.Constant));
                        }

                        // To make OpenTK 5 more like OpenTK 4 we want handles to be int instead of uint
                        if (handle != null)
                        {
                            return new CSPrimitive("int", bt.Constant);
                        }

                        // For now we only expect int and uint to be able to be turned into groupNameToEnumGroup.
                        // - 2022-08-09
                        // FIXME: We might want to make sure that the underlying type for the enumName groupName is the same as the parameter groupName.
                        //   Right now we blindly substituting the type for the enumName.
                        if (group != null && (bt.Type == PrimitiveType.Int || bt.Type == PrimitiveType.Uint))
                        {
                            Console.WriteLine($"Making {bt} into group {group}");
                            CSPrimitive baseType = bt.Type switch
                            {
                                PrimitiveType.Int => new CSPrimitive("int", bt.Constant),
                                PrimitiveType.Uint => new CSPrimitive("uint", bt.Constant),
                                _ => throw new Exception("This should not happen!"),
                            };

                            return new CSEnum(group, baseType, bt.Constant);
                        }
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
                            PrimitiveType.Half => new CSStructPrimitive("Half", bt.Constant, new CSPrimitive("ushort", bt.Constant)),
                            PrimitiveType.Float => new CSPrimitive("float", bt.Constant),
                            PrimitiveType.Double => new CSPrimitive("double", bt.Constant),

                            // C interop types
                            PrimitiveType.Bool8 => new CSBool8(bt.Constant),
                            PrimitiveType.Bool32 => new CSBool32(bt.Constant),
                            PrimitiveType.Char8 => new CSChar8(bt.Constant),


                            // Enum
                            PrimitiveType.Enum => new CSEnum(group ?? "All", new CSPrimitive("uint", bt.Constant), bt.Constant),

                            // Pointers
                            PrimitiveType.IntPtr => new CSPrimitive("IntPtr", bt.Constant),
                            PrimitiveType.Nint => new CSPrimitive("nint", bt.Constant),
                            PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), bt.Constant),

                            // FIXME: Output the GLHandleARB again...
                            PrimitiveType.GLHandleARB => new CSStructPrimitive("GLHandleARB", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                            PrimitiveType.GLSync => new CSStructPrimitive("GLSync", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                            // OpenCL structs
                            PrimitiveType.CLContext => new CSStructPrimitive("CLContext", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),
                            PrimitiveType.CLEvent => new CSStructPrimitive("CLEvent", bt.Constant, new CSPrimitive("IntPtr", bt.Constant)),

                            // Function pointer types
                            PrimitiveType.GLDebugProc => new CSFunctionPointer("GLDebugProc", bt.Constant),
                            PrimitiveType.GLDebugProcARB => new CSFunctionPointer("GLDebugProcARB", bt.Constant),
                            PrimitiveType.GLDebugProcKHR => new CSFunctionPointer("GLDebugProcKHR", bt.Constant),
                            PrimitiveType.GLDebugProcAMD => new CSFunctionPointer("GLDebugProcAMD", bt.Constant),
                            PrimitiveType.GLDebugProcNV => new CSFunctionPointer("GLDebugProcNV", bt.Constant),
                            PrimitiveType.GLVulkanProcNV => new CSFunctionPointer("GLVulkanProcNV", bt.Constant),


                            // WGL
                            PrimitiveType.WGL_Proc => new CSFunctionPointer("???", bt.Constant),
                            
                            PrimitiveType.WGL_Rect => new CSStruct("Rect", bt.Constant),
                            PrimitiveType.WGL_LPString => new CSPointer(new CSChar16(true), bt.Constant),
                            PrimitiveType.WGL_COLORREF => new CSStructPrimitive("ColorRef", bt.Constant, new CSPrimitive("uint", false)),
                            PrimitiveType.WGL_LAYERPLANEDESCRIPTOR => new CSStruct("LayerPlaneDescriptor", bt.Constant),
                            PrimitiveType.WGL_PIXELFORMATDESCRIPTOR => new CSStruct("PixelFormatDescriptor", bt.Constant),
                            PrimitiveType.WGL_GPU_DEVICE => new CSStruct("_GPU_DEVICE", bt.Constant),
                            PrimitiveType.WGL_PGPU_DEVICE => new CSPointer(new CSStruct("_GPU_DEVICE", false), bt.Constant),

                            PrimitiveType.GLX_Colormap => new CSStructPrimitive("GLXColormap", bt.Constant, new CSPrimitive("ulong", bt.Constant)),
                            PrimitiveType.GLX_Display => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Font => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Pixmap => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Screen => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Status => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Window => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_XVisualInfo => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_DMbuffer => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_DMparams => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VLNode => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VLPath => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VLServer => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_FBConfigID => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_FBConfig => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_ContextID => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_Context => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPixmap => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXDrawable => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXWindow => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPbuffer => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VideoCaptureDeviceNV => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VideoDeviceNV => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_VideoSourceSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_FBConfigIDSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_FBConfigSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPbufferSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPbufferClobberEvent => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXBufferSwapComplete => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXEvent => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXStereoNotifyEventEXT => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXBufferClobberEventSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXHyperpipeNetworkSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXHyperpipeConfigSGIX => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPipeRect => new CSVoid(bt.Constant),
                            PrimitiveType.GLX_GLXPipeRectLimits => new CSVoid(bt.Constant),

                            PrimitiveType.Invalid => throw new Exception(),
                            _ => throw new Exception(),
                        };
                    }
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
