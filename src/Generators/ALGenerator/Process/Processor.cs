using System;
using System.Collections.Generic;
using System.Linq;
using GeneratorBase.Utility.Extensions;
using GeneratorBase.Utility;
using ALGenerator.Process;
using ALGenerator.Parsing;
using GeneratorBase;

namespace ALGenerator.Process
{
    internal static class Processor
    {
        // These types are only used to pass data from ProcessSpec to GetOutputApiFromRequireTags.
        private record ProcessedGLInformation(
            Dictionary<string, OverloadedFunction> AllFunctions,
            Dictionary<OutputApi, Dictionary<string, EnumGroupMember>> AllEnumsPerAPI,
            List<EnumGroupInfo> AllEnumGroups);

        internal record OverloadedFunction(
            Function NativeFunction,
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

        internal static OutputData ProcessSpec(Specification spec, Documentation docs)
        {
            // The first thing we do is process all of the vendorFunctions defined into a dictionary of Functions.
            Dictionary<string, OverloadedFunction> allFunctions = new Dictionary<string, OverloadedFunction>(spec.Functions.Count);
            foreach (Function nativeFunction in spec.Functions)
            {
                Dictionary<OutputApi, CommandDocumentation> functionDocumentation = MakeDocumentationForNativeFunction(nativeFunction, docs);
                OverloadedFunction overloadedFunction = GenerateOverloads(nativeFunction, functionDocumentation);

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

                foreach ((string originalName, string translatedName, APIFile @namespace) in @enum.Groups)
                {
                    switch (@namespace)
                    {
                        case APIFile.AL:
                            AddToGroup(allEnumGroups, OutputApi.AL, originalName, translatedName, isFlag);
                            break;
                        case APIFile.ALC:
                            AddToGroup(allEnumGroups, OutputApi.ALC, originalName, translatedName, isFlag);
                            break;
                        default:
                            throw new Exception();
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

                if (@enum.Apis.HasFlag(OutputApiFlags.AL))
                {
                    allEnumsPerAPI.AddToNestedDictIfNotPresent(OutputApi.AL, @enum.Name, data);
                }

                if (@enum.Apis.HasFlag(OutputApiFlags.ALC))
                {
                    allEnumsPerAPI.AddToNestedDictIfNotPresent(OutputApi.ALC, @enum.Name, data);
                }
            }

            // Resolve cross referenced enums between APIs
            foreach (var (api, _, enums) in spec.APIs)
            {
                OutputApi outAPI = api switch
                {
                    InputAPI.AL => OutputApi.AL,
                    InputAPI.ALC => OutputApi.ALC,

                    _ => throw new Exception(),
                };

                // FIXME: Do we need this here?
                APIFile file = api switch
                {
                    InputAPI.AL => APIFile.AL,
                    InputAPI.ALC => APIFile.ALC,

                    _ => throw new Exception(),
                };

                bool removeFunctions = outAPI switch
                {
                    OutputApi.AL => true,
                    OutputApi.ALC => true,
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
                        if (enumRef.RemovedIn != null)
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
                            APIFile @namespace = groupRef.Namespace;
                            if (@namespace != file)
                            {
                                switch (@namespace)
                                {
                                    case APIFile.AL:
                                        AddEnumToAPI(OutputApi.AL, @enum);
                                        break;
                                    case APIFile.ALC:
                                        AddEnumToAPI(OutputApi.ALC, @enum);
                                        break;
                                    default:
                                        throw new Exception();
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
                                            api.Enums.Add(new EnumReference(@enum.Name, null, null, new List<ExtensionReference>(), true));
                                            Logger.Info($"Added enum entry '{@enum.MangledName}' to {outputApi}.");
                                        }
                                    }

                                    AddToGroup(allEnumGroups, outputApi, groupRef, @enum.IsFlag);

                                    static bool MatchesAPI(InputAPI api, OutputApi output)
                                    {
                                        switch (api)
                                        {
                                            case InputAPI.AL: return output == OutputApi.AL;
                                            case InputAPI.ALC: return output == OutputApi.ALC;
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

            List<Namespace> outputNamespaces = new List<Namespace>();

            foreach (var (api, functions, enums) in spec.APIs)
            {
                // FIXME: Probably make these the same enum!
                OutputApi outAPI = api switch
                {
                    InputAPI.AL => OutputApi.AL,
                    InputAPI.ALC => OutputApi.ALC,

                    _ => throw new Exception(),
                };

                // FIXME: Do we need this here?
                APIFile file = api switch
                {
                    InputAPI.AL => APIFile.AL,
                    InputAPI.ALC => APIFile.ALC,

                    _ => throw new Exception(),
                };

                outputNamespaces.Add(CreateOutputAPI(outAPI, file));

                Namespace CreateOutputAPI(OutputApi outAPI, APIFile alFile)
                {
                    bool removeFunctions = outAPI switch
                    {
                        OutputApi.AL => true,
                        OutputApi.ALC => true,
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
                                if (removeFunctions && (functionRef.RemovedIn != null))
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
                            if (enumRef.RemovedIn != null)
                            {
                                // FIXME: Add the enum if an extension uses it??
                                continue;
                            }
                        }

                        if (enumsDict.TryGetValue(enumRef.EnumName, out EnumGroupMember? @enum))
                        {
                            foreach (var (originalName, translatedName, @namespace) in @enum.Groups)
                            {
                                if (@namespace != alFile)
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
                    Dictionary<GroupRef, List<(string Vendor, Function Function)>> enumGroupToNativeFunctionsUsingThatEnumGroup = new Dictionary<GroupRef, List<(string Vendor, Function Function)>>();
                    foreach (var (vendor, vendorFunctions) in functionsByVendor)
                    {
                        foreach (var function in vendorFunctions)
                        {
                            foreach (var group in function.NativeFunction.ReferencedEnumGroups)
                            {
                                if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(group, out var listOfFunctions) == false)
                                {
                                    listOfFunctions = new List<(string Vendor, Function Function)>();
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
                        if (members.Count <= 0 && groupsReferencedByFunctions.Contains(new GroupRef(originalName, translatedName, alFile)) == false)
                            continue;

                        if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(new GroupRef(originalName, translatedName, alFile), out var functionsUsingEnumGroup) == false)
                        {
                            functionsUsingEnumGroup = null;
                        }

                        // If there is a list, sort it by name
                        if (functionsUsingEnumGroup != null)
                            functionsUsingEnumGroup.Sort((f1, f2) => {
                                // We want to prioritize "core" vendorFunctions before extensions.
                                if (f1.Vendor == "" && f2.Vendor != "") return -1;
                                if (f1.Vendor != "" && f2.Vendor == "") return 1;

                                return f1.Function.Name.CompareTo(f2.Function.Name);
                            });

                        members.Sort(EnumGroupMember.DefaultComparison);

                        finalGroups.Add(new EnumGroup(translatedName, isFlags, members, functionsUsingEnumGroup));
                    }

                    foreach (var group in groupsReferencedByFunctions)
                    {
                        // This group is not part of this file, so we can't do anything here about adding it.
                        // For now this is not a problem as all referenced groups from between the different
                        // files are always populated, so we will never have to add them to the other file.
                        // - Noggin_bops 2025-08-05
                        if (group.Namespace != file)
                        {
                            continue;
                        }

                        if (groupNameToEnumGroup.TryGetValue(group.TranslatedName, out List<EnumGroupMember>? members) == false)
                        {
                            if (enumGroupToNativeFunctionsUsingThatEnumGroup.TryGetValue(group, out var functionsUsingEnumGroup) == false)
                            {
                                functionsUsingEnumGroup = null;
                            }

                            finalGroups.Add(new EnumGroup(group.TranslatedName, false, [], functionsUsingEnumGroup));
                        }
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
                    Dictionary<string, VendorFunctions> vendors = new Dictionary<string, VendorFunctions>();
                    foreach ((string vendor, HashSet<OverloadedFunction> overloadedFunctions) in functionsByVendor)
                    {
                        foreach (OverloadedFunction overloadedFunction in overloadedFunctions)
                        {
                            if (!vendors.TryGetValue(vendor, out VendorFunctions? group))
                            {
                                group = new VendorFunctions(vendor, new List<Process.OverloadedFunction>(), new HashSet<Function>());
                                vendors.Add(vendor, group);
                            }

                            group.Functions.Add(new Process.OverloadedFunction(overloadedFunction.NativeFunction, overloadedFunction.Overloads));

                            if (overloadedFunction.ChangeNativeName)
                            {
                                group.NativeFunctionsWithPostfix.Add(overloadedFunction.NativeFunction);
                            }
                        }
                    }

                    List<VendorFunctions> sortedVendorFunctions = [..vendors.Values];
                    foreach (VendorFunctions functions in sortedVendorFunctions)
                    {
                        functions.Functions.Sort();
                    }
                    sortedVendorFunctions.Sort((e1, e2) => e1.Vendor.CompareTo(e2.Vendor));

                    Dictionary<Function, FunctionDocumentation> documentation = new Dictionary<Function, FunctionDocumentation>();
                    foreach (var (vendor, vendorFunctions) in functionsByVendor)
                    {
                        foreach (var function in vendorFunctions)
                        {
                            FunctionReference func = functions.Find(f => f.EntryPoint == function.NativeFunction.EntryPoint) ?? throw new Exception($"Could not find function {function.NativeFunction.EntryPoint}!");

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

                            List<string> extensionURLs = [];
                            foreach (var extension in func.PartOfExtensions)
                            {
                                string ext = NameMangler.MaybeRemoveStart(extension.Name, "GL_");

                                // FIXME: This does not work super well here as there are
                                // ALC extensions like ALC_EXT_EFX that have many functions
                                // added to the AL api, which means we will choose the wrong
                                // api string in the url here.
                                // - Noggin_bops 2025-08-10
                                string apiString = api switch
                                {
                                    InputAPI.AL => "AL%20Extensions",
                                    InputAPI.ALC => "ALC%20Extensions",
                                    _ => throw new Exception()
                                };

                                string url = $"https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/{apiString}/{ext}.txt";
                                extensionURLs.Add(url);
                            }

                            if (function.Documentation.TryGetValue(outAPI, out CommandDocumentation? commandDocumentation))
                            {
                                // FIXME: Added and removed information.
                                documentation[function.NativeFunction] = new FunctionDocumentation(
                                    commandDocumentation.Name,
                                    commandDocumentation.Purpose,
                                    commandDocumentation.Parameters,
                                    [commandDocumentation.RefPagesLink, .. extensionURLs],
                                    addedIn,
                                    removedIn
                                    );
                            }
                            else
                            {
                                if (vendor == "")
                                {
                                    Logger.Warning($"{function.NativeFunction.EntryPoint} doesn't have any documentation for {api}");

                                    documentation[function.NativeFunction] = new FunctionDocumentation(
                                        function.NativeFunction.EntryPoint,
                                        "",
                                        Array.Empty<ParameterDocumentation>(),
                                        // TODO: Is it possible to get the functionRef spec file and link to it here?
                                        extensionURLs,
                                        addedIn,
                                        removedIn);
                                }
                                else
                                {
                                    // Extensions don't have documentation (yet?)
                                    documentation[function.NativeFunction] = new FunctionDocumentation(
                                        function.NativeFunction.EntryPoint,
                                        "",
                                        Array.Empty<ParameterDocumentation>(),
                                        // TODO: Is it possible to get the extension spec file and link to it here?
                                        extensionURLs,
                                        addedIn,
                                        removedIn);
                                }
                            }
                        }
                    }

                    return new Namespace(outAPI, sortedVendorFunctions, finalGroups, documentation);
                }
            }

            // FIXME: This requires us to merge all input data!
            List<Pointers> pointers = new List<Pointers>();
            pointers.Add(CreatePointersList(APIFile.AL, outputNamespaces));
            pointers.Add(CreatePointersList(APIFile.ALC, outputNamespaces));

            return new OutputData(pointers, outputNamespaces);

            Pointers CreatePointersList(APIFile file, List<Namespace> namespaces)
            {
                SortedList<string, Function> allFunctions = new SortedList<string, Function>();
                foreach (Namespace @namespace in namespaces)
                {
                    bool addFunctions = false;
                    switch (file)
                    {
                        case APIFile.AL:
                            if (@namespace.Name == OutputApi.AL)
                            {
                                addFunctions = true;
                            }
                            break;
                        case APIFile.ALC:
                            if (@namespace.Name == OutputApi.ALC)
                            {
                                addFunctions = true;
                            }
                            break;
                        default:
                            throw new Exception();
                    }

                    if (addFunctions)
                    {
                        foreach (var functions in @namespace.VendorFunctions)
                        {
                            foreach (var function in functions.Functions)
                            {
                                if (allFunctions.ContainsKey(function.NativeFunction.EntryPoint) == false)
                                {
                                    allFunctions.Add(function.NativeFunction.EntryPoint, function.NativeFunction);
                                }
                            }
                        }
                    }
                }

                return new Pointers(file, allFunctions.Values.ToList());
            }
        }

        internal static Dictionary<OutputApi, CommandDocumentation> MakeDocumentationForNativeFunction(Function function, Documentation documentation)
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
                        if (function.Parameters[i].OriginalName != commandDoc.Parameters[i].Name)
                        {
                            Logger.Warning($"[{version}][{function.EntryPoint}] Function parameter '{function.Parameters[i].OriginalName}' doesn't have the same name in the documentation. ('{commandDoc.Parameters[i].Name}')");
                        }
                    }

                    commandDocs.Add(version, commandDoc);
                }
            }

            return commandDocs;
        }

        // Maybe we can do the return type overloading in a post processing step?
        internal static OverloadedFunction GenerateOverloads(Function nativeFunction, Dictionary<OutputApi, CommandDocumentation> functionDocumentation)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null, null, nativeFunction.Parameters.ToArray(), nativeFunction, nativeFunction.StrongReturnType,
                    new NameTable(), /*"returnValue",*/ Array.Empty<string>(), nativeFunction.Name),
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

            static bool AreSignaturesDifferent(Function nativeFunction, Overload overload)
            {
                if (nativeFunction.Parameters.Count != overload.InputParameters.Length)
                {
                    return true;
                }

                if (overload.OverloadName != nativeFunction.Name)
                {
                    return true;
                }

                for (int i = 0; i < nativeFunction.Parameters.Count; i++)
                {
                    if (nativeFunction.Parameters[i].StrongType!.Equals(overload.InputParameters[i].StrongType!) == false)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
