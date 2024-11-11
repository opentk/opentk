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
    internal static class Processor
    {
        // These types are only used to pass data from ProcessSpec to GetOutputApiFromRequireTags.
        private record ProcessedGLInformation(
            Dictionary<string, OverloadedFunction> AllFunctions,
            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> AllEnumsPerAPI,
            List<EnumGroupInfo> AllEnumGroups);

        internal record OverloadedFunction(
            NativeFunction NativeFunction,
            Dictionary<OutputApi, CommandDocumentation> Documentation,
            Overload[] Overloads,
            bool ChangeNativeName);

        internal sealed record EnumGroupInfo(
            string OriginalName,
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

        internal static OutputData ProcessSpec(Specification2 spec, Documentation docs)
        {
            // The first thing we do is process all of the vendorFunctions defined into a dictionary of Functions.
            List<NativeFunction> allEntryPoints = new List<NativeFunction>(spec.Functions.Count);
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Functions.Count);
            foreach (NativeFunction nativeFunction in spec.Functions)
            {
                Dictionary<OutputApi, CommandDocumentation> functionDocumentation = MakeDocumentationForNativeFunction(nativeFunction, docs);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction, functionDocumentation);

                allEntryPoints.Add(nativeFunction);
                allFunctions.Add(nativeFunction.EntryPoint, overloadedFunction);
            }

            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> allEnumsPerAPI = new Dictionary<OutputApi, Dictionary<string, EnumGroupMember>>();
            Dictionary<OutputApi, HashSet<EnumGroupInfo>> allEnumGroups = new Dictionary<OutputApi, HashSet<EnumGroupInfo>>();
            foreach (OutputApi outputApi in Enum.GetValues<OutputApi>())
            {
                if (outputApi == OutputApi.Invalid) continue;
                allEnumsPerAPI.Add(outputApi, new Dictionary<string, EnumGroupMember>());
                allEnumGroups.Add(outputApi, new HashSet<EnumGroupInfo>());
            }

            foreach (EnumEntry @enum in spec.Enums)
            {
                bool isFlag = @enum.Type == EnumType.Bitmask;

                foreach ((string originalName, string translatedName, GLFile @namespace) in @enum.Groups)
                {
                    if (@namespace == GLFile.GL)
                    {
                        AddToGroup(allEnumGroups, OutputApi.GL, originalName, translatedName, isFlag);
                        AddToGroup(allEnumGroups, OutputApi.GLCompat, originalName, translatedName, isFlag);
                        AddToGroup(allEnumGroups, OutputApi.GLES1, originalName, translatedName, isFlag);
                        AddToGroup(allEnumGroups, OutputApi.GLES2, originalName, translatedName, isFlag);
                    }
                    else if (@namespace == GLFile.WGL)
                    {
                        AddToGroup(allEnumGroups, OutputApi.WGL, originalName, translatedName, isFlag);
                    }
                    else if (@namespace == GLFile.GLX)
                    {
                        AddToGroup(allEnumGroups, OutputApi.GLX, originalName, translatedName, isFlag);
                    }
                    else if (@namespace == GLFile.EGL)
                    {
                        AddToGroup(allEnumGroups, OutputApi.EGL, originalName, translatedName, isFlag);
                    }

                    static void AddToGroup(Dictionary<OutputApi, HashSet<EnumGroupInfo>> allEnumGroups, OutputApi api, string originalName, string translatedName, bool isFlag)
                    {
                        // If the first groupNameToEnumGroup tag wasn't flagged as a bitmask, but later ones in the same groupName are.
                        // Then we want the groupName to be considered a bitmask.
                        if (allEnumGroups[api].TryGetValue(new EnumGroupInfo(originalName, translatedName, isFlag), out EnumGroupInfo? actual))
                        {
                            // In the current spec this case never happens, but it could.
                            // - 2021-07-04
                            if (isFlag == true && actual.IsFlags == false)
                            {
                                allEnumGroups[api].Remove(actual);
                                allEnumGroups[api].Add(actual with { IsFlags = true });
                            }
                        }
                        else
                        {
                            allEnumGroups[api].Add(new EnumGroupInfo(originalName, translatedName, isFlag));
                        }
                    }
                }

                EnumGroupMember data = new EnumGroupMember(@enum.Name, @enum.MangledName, @enum.Value, @enum.Groups, isFlag);

                if (@enum.Apis == OutputApiFlags.None)
                {
                    throw new Exception();
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.GL))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.GL, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.GLCompat))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.GLCompat, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.GLES1))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.GLES1, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.GLES2))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.GLES2, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.WGL))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.WGL, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.GLX))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.GLX, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.EGL))
                {
                    allEnumsPerAPI.AddToNestedDict(OutputApi.EGL, @enum.Name, data);
                }
            }

            foreach (var (api, _, enums) in spec.APIs)
            {
                OutputApi outAPI = api switch
                {
                    InputAPI.GL => OutputApi.GL,
                    // FIXME?
                    //InputAPI.GLCompat => OutputApi.GLCompat,
                    InputAPI.GLES1 => OutputApi.GLES1,
                    InputAPI.GLES2 => OutputApi.GLES2,
                    InputAPI.WGL => OutputApi.WGL,
                    InputAPI.GLX => OutputApi.GLX,
                    InputAPI.EGL => OutputApi.EGL,

                    _ => throw new Exception(),
                };

                // FIXME: Do we need this here?
                GLFile file = api switch
                {
                    InputAPI.GL => GLFile.GL,
                    InputAPI.GLES1 => GLFile.GL,
                    InputAPI.GLES2 => GLFile.GL,
                    InputAPI.WGL => GLFile.WGL,
                    InputAPI.GLX => GLFile.GLX,
                    InputAPI.EGL => GLFile.EGL,

                    _ => throw new Exception(),
                };

                CrossReferenceEnums(outAPI, file);

                // FIXME: Do we need to do this for GLCompat?
                // Could there be enums there that needs to be cross referenced?
                if (outAPI == OutputApi.GL)
                {
                    CrossReferenceEnums(OutputApi.GLCompat, file);
                }

                void CrossReferenceEnums(OutputApi outAPI, GLFile glFile)
                {
                    bool removeFunctions = outAPI switch
                    {
                        OutputApi.GL => true,
                        OutputApi.GLES2 => true,
                        _ => false,
                    };

                    Dictionary<string, EnumGroupMember>? enumsDict = allEnumsPerAPI[outAPI];

                    foreach (EnumReference enumRef in enums)
                    {
                        if (enumRef.IsCrossReferenced)
                            continue;

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
                            foreach (var groupRef in @enum.Groups)
                            {
                                GLFile @namespace = groupRef.Namespace;
                                if (@namespace != glFile)
                                {
                                    if (@namespace == GLFile.GL)
                                    {
                                        // FIXME: Cleanup

                                        // FIXME: Should we really add it to all GL apis?
                                        // Is there some good way to detect which ones we should add it to?
                                        AddEnumToAPI(OutputApi.GL, @enum);
                                        AddEnumToAPI(OutputApi.GLCompat, @enum);
                                        AddEnumToAPI(OutputApi.GLES1, @enum);
                                        AddEnumToAPI(OutputApi.GLES2, @enum);
                                    }
                                    else if (@namespace == GLFile.WGL)
                                    {
                                        AddEnumToAPI(OutputApi.WGL, @enum);
                                    }
                                    else if (@namespace == GLFile.GLX)
                                    {
                                        AddEnumToAPI(OutputApi.GLX, @enum);
                                    }

                                    void AddEnumToAPI(OutputApi outputApi, EnumGroupMember @enum)
                                    {
                                        // FIXME: There is an issue where a cross referenced enum gets readded here.
                                        // We want to avoid this.

                                        if (allEnumsPerAPI[outputApi].ContainsKey(@enum.Name) == false)
                                        {
                                            allEnumsPerAPI.AddToNestedDict(outputApi, @enum.Name, @enum);
                                        }

                                        foreach (var api in spec.APIs)
                                        {
                                            if (MatchesAPI(api.Name, outputApi))
                                            {
                                                api.Enums.Add(new EnumReference(@enum.Name, null, null, new List<ExtensionReference>(), GLProfile.None, true));
                                                Logger.Info($"Added enum entry '{@enum.MangledName}' to {outputApi}.");
                                            }
                                        }

                                        AddToGroup(allEnumGroups, outputApi, groupRef, @enum.IsFlag);

                                        static bool MatchesAPI(InputAPI api, OutputApi output)
                                        {
                                            switch (api)
                                            {
                                                case InputAPI.GL: return output == OutputApi.GL || output == OutputApi.GLCompat;
                                                case InputAPI.GLES1: return output == OutputApi.GLES1;
                                                case InputAPI.GLES2: return output == OutputApi.GLES2;
                                                case InputAPI.WGL: return output == OutputApi.WGL;
                                                case InputAPI.GLX: return output == OutputApi.GLX;
                                                case InputAPI.EGL: return output == OutputApi.EGL;
                                                default: throw new Exception();
                                            }
                                        }

                                        // FIXME: Duplicate implementation, see above.
                                        static void AddToGroup(Dictionary<OutputApi, HashSet<EnumGroupInfo>> allEnumGroups, OutputApi api, GroupRef @ref, bool isFlag)
                                        {
                                            // If the first groupNameToEnumGroup tag wasn't flagged as a bitmask, but later ones in the same groupName are.
                                            // Then we want the groupName to be considered a bitmask.
                                            if (allEnumGroups[api].TryGetValue(new EnumGroupInfo(@ref.OriginalName, @ref.TranslatedName, isFlag), out EnumGroupInfo? actual))
                                            {
                                                // In the current spec this case never happens, but it could.
                                                // - 2021-07-04
                                                if (isFlag == true && actual.IsFlags == false)
                                                {
                                                    allEnumGroups[api].Remove(actual);
                                                    allEnumGroups[api].Add(actual with { IsFlags = true });
                                                }
                                            }
                                            else
                                            {
                                                allEnumGroups[api].Add(new EnumGroupInfo(@ref.OriginalName, @ref.TranslatedName, isFlag));
                                            }
                                        }
                                    }

                                    
                                }
                            }
                        }
                        else
                        {
                            throw new Exception($"Could not find any enum called '{enumRef.EnumName}'.");
                        }
                    }
                }
            }

            List<Namespace> outputNamespaces = new List<Namespace>();

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
                    InputAPI.EGL => OutputApi.EGL,

                    _ => throw new Exception(),
                };

                // FIXME: Do we need this here?
                GLFile file = api switch
                {
                    InputAPI.GL => GLFile.GL,
                    InputAPI.GLES1 => GLFile.GL,
                    InputAPI.GLES2 => GLFile.GL,
                    InputAPI.WGL => GLFile.WGL,
                    InputAPI.GLX => GLFile.GLX,
                    InputAPI.EGL => GLFile.EGL,

                    _ => throw new Exception(),
                };

                outputNamespaces.Add(CreateOutputAPI(outAPI, file));

                if (outAPI == OutputApi.GL)
                {
                    outputNamespaces.Add(CreateOutputAPI(OutputApi.GLCompat, file));
                }

                Namespace CreateOutputAPI(OutputApi outAPI, GLFile glFile)
                {
                    bool removeFunctions = outAPI switch
                    {
                        OutputApi.GL => true,
                        OutputApi.GLES2 => true,
                        _ => false,
                    };

                    HashSet<GroupRef> groupsReferencedByFunctions = new HashSet<GroupRef>();

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
                            // FIXME!
                            /*if (GeneratorSettings.Settings.IgnoreFunctions.Contains(functionRef.EntryPoint))
                            {
                                // We are ignoring this function.
                            }
                            else
                            {
                                throw new Exception($"Could not find function '{functionRef.EntryPoint}'!");
                            }*/
                        }
                    }

                    Dictionary<string, List<EnumGroupMember>> groupNameToEnumGroup = new Dictionary<string, List<EnumGroupMember>>();

                    // FIXME: Here we are trusting that the enum refs in the <require> tags tell us all of the
                    // enums to include. But this is not necessarily true as is the case with WGL as it references
                    // some enums from OpenGL without them going through the require tag...
                    // - Noggin_bops 2023-08-26
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
                            foreach (var (originalName, translatedName, @namespace) in @enum.Groups)
                            {
                                if (@namespace != glFile)
                                    continue;

                                if (groupNameToEnumGroup.TryGetValue(translatedName, out List<EnumGroupMember>? groupMembers) == false)
                                {
                                    groupMembers = new List<EnumGroupMember>();
                                    groupNameToEnumGroup.Add(translatedName, groupMembers);
                                }

                                if (groupMembers.Find(g => g.MangledName == @enum.MangledName) == null)
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
                    Dictionary<GroupRef, List<(string Vendor, NativeFunction Function)>> enumGroupToNativeFunctionsUsingThatEnumGroup = new Dictionary<GroupRef, List<(string Vendor, NativeFunction Function)>>();
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

                    foreach ((string originalName, string translatedName, bool isFlags) in allEnumGroups[outAPI])
                    {
                        groupNameToEnumGroup.TryGetValue(translatedName, out List<EnumGroupMember>? members);
                        members ??= new List<EnumGroupMember>();

                        // SpecialNumbers is not an enumName groupName that we want to output.
                        // We handle these entries differently as some of the entries don't fit in an int.
                        if (originalName == "SpecialNumbers")
                            continue;

                        // Remove all empty enumName groups, except the empty groups referenced by included vendorFunctions.
                        // In GL 4.1 to 4.5 there are vendorFunctions that use the groupName "ShaderBinaryFormat"
                        // while not including any members for that enumName groupName.
                        // This is needed to solve that case.
                        if (members.Count <= 0 && groupsReferencedByFunctions.Contains(new GroupRef(originalName, translatedName, glFile)) == false)
                            continue;

                        if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(new GroupRef(originalName, translatedName, glFile), out var functionsUsingEnumGroup) == false)
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

                        members.Sort(EnumGroupMember.DefaultComparison);

                        finalGroups.Add(new EnumGroup(translatedName, isFlags, members, functionsUsingEnumGroup));
                    }

                    // Sort enum groups be name
                    finalGroups.Sort((g1, g2) => g1.Name.CompareTo(g2.Name));

                    List<EnumGroupMember> allEnumGroup = theAllEnumGroup.ToList();
                    allEnumGroup.Sort(EnumGroupMember.DefaultComparison);

                    // Add the All enum group first.
                    finalGroups.Insert(0, new EnumGroup("All", false, allEnumGroup, null));

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

                    return new Namespace(outAPI, sortedVendors, finalGroups, documentation);
                    //return new GLOutputApi(outAPI, sortedVendors, finalGroups, documentation);
                }
            }

            // FIXME: This requires us to merge all input data!
            // FIXME: Potentially split the GLES function pointers from the GL ones.
            List<Pointers> pointers = new List<Pointers>();
            pointers.Add(CreatePointersList(GLFile.GL, outputNamespaces));
            pointers.Add(CreatePointersList(GLFile.WGL, outputNamespaces));
            pointers.Add(CreatePointersList(GLFile.GLX, outputNamespaces));
            pointers.Add(CreatePointersList(GLFile.EGL, outputNamespaces));

            return new OutputData(pointers, outputNamespaces);

            Pointers CreatePointersList(GLFile file, List<Namespace> namespaces)
            {
                List<NativeFunction> allFunctions = new List<NativeFunction>();
                foreach (Namespace @namespace in namespaces)
                {
                    bool addFunctions = false;
                    switch (file)
                    {
                        case GLFile.GL:
                            if (@namespace.Name == OutputApi.GL ||
                                @namespace.Name == OutputApi.GLCompat ||
                                @namespace.Name == OutputApi.GLES1 ||
                                @namespace.Name == OutputApi.GLES2)
                            {
                                addFunctions = true;
                            }
                            break;
                        case GLFile.WGL:
                            if (@namespace.Name == OutputApi.WGL)
                            {
                                addFunctions = true;
                            }
                            break;
                        case GLFile.GLX:
                            if (@namespace.Name == OutputApi.GLX)
                            {
                                addFunctions = true;
                            }
                            break;
                        case GLFile.EGL:
                            if (@namespace.Name == OutputApi.EGL)
                            {
                                addFunctions = true;
                            }
                            break;
                    }

                    if (addFunctions)
                    {
                        foreach (var (_, functions) in @namespace.Vendors)
                        {
                            foreach (var function in functions.Functions)
                            {
                                if (allFunctions.Contains(function.NativeFunction) == false)
                                {
                                    allFunctions.Add(function.NativeFunction);
                                }
                            }
                        }
                    }
                }

                allFunctions.Sort((f1, f2) => f1.EntryPoint.CompareTo(f2.EntryPoint));

                return new Pointers(file, allFunctions);
            }
        }

        internal static Dictionary<OutputApi, CommandDocumentation> MakeDocumentationForNativeFunction(NativeFunction function, Documentation documentation)
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
        internal static OverloadedFunction GenerateOverloads(NativeFunction nativeFunction, Dictionary<OutputApi, CommandDocumentation> functionDocumentation)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null, null, nativeFunction.Parameters.ToArray(), nativeFunction, nativeFunction.ReturnType,
                    new NameTable(), /*"returnValue",*/ Array.Empty<string>(), nativeFunction.FunctionName),
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
