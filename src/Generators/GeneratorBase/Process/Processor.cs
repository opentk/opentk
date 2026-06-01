using GeneratorBase.Overloading;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneratorBase.Process
{
    public class Processor
    {
        private record FunctionData(
            Function NativeFunction,
            Overload[] Overloads,
            bool ChangeNativeName);

        public static OutputData ProcessSpec(List<ResolvedApi> apis, SpecificationFile[] files, IDocumentation docs, IOverloader[] overloaders)
        {
            List<OutputApiData> outputNamespaces = new List<OutputApiData>(apis.Count);
            foreach (var api in apis)
            {
                List<VendorFunctions> vendorFunctions = CreateVendorFunctions(api.Api, api.Functions, docs, overloaders);
                List<EnumType> enumTypes = CreateEnumTypes(api.Api, api.Enums);

                MarkEnumsUsedByFunctions(api.Api, vendorFunctions, enumTypes);

                Dictionary<Function, FunctionDocumentation> functionDocumentation = docs.CreateFunctionDocumentation(api.Api, vendorFunctions);
                Dictionary<string, EnumMemberDocumentation> enumMemberDocumentation = docs.CreateEnumMemberDocumentation(api.Api, api.Enums);

                outputNamespaces.Add(new OutputApiData(api.Api, vendorFunctions, enumTypes, functionDocumentation, enumMemberDocumentation));
            }

            // FIXME: Potentially split the GLES function pointers from the GL ones.
            List<ApiPointers> pointers = new List<ApiPointers>(files.Length);
            foreach (var file in files)
            {
                ApiPointers filePointers = CreatePointersList(file);
                pointers.Add(filePointers);
            }

            return new OutputData(pointers, outputNamespaces);
        }

        public static void CrossReferenceEnums(SpecificationFile[] files)
        {
            static SpecificationFile GetFile(SpecificationFile[] files, ApiFile file)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].File == file)
                        return files[i];
                }
                throw new Exception();
            }

            foreach (SpecificationFile file in files)
            {
                foreach (EnumEntry @enum in file.Enums)
                {
                    if (@enum.IsCrossReferenced)
                        continue;

                    foreach (GroupRef group in @enum.Groups)
                    {
                        if (group.Namespace != file.File)
                        {
                            SpecificationFile referencedFile = GetFile(files, group.Namespace);
                            referencedFile.Enums.Add(@enum with { IsCrossReferenced = true });
                        }
                    }
                }
            }
        }

        public static List<API> MakeApis(SpecificationFile[] files)
        {
            List<API> apis = [];
            foreach (SpecificationFile file in files)
            {
                List<API> fileApis = MakeApis(file);
                apis.AddRange(fileApis);
            }
            return apis;
        }

        private static List<API> MakeApis(SpecificationFile file)
        {
            Span<OutputApi> outputApis = file.File switch
            {
                // FIXME: Should GLCompat be it's own output API?
                ApiFile.GL => [OutputApi.GL, OutputApi.GLCompat, OutputApi.GLES1, OutputApi.GLES2],
                ApiFile.WGL => [OutputApi.WGL],
                ApiFile.GLX => [OutputApi.GLX],
                ApiFile.EGL => [OutputApi.EGL],
                ApiFile.AL => [OutputApi.AL],
                ApiFile.ALC => [OutputApi.ALC],
                ApiFile.Vulkan => [OutputApi.Vulkan],
                _ => throw new Exception(),
            };

            List<API> apis = new List<API>(outputApis.Length);
            foreach (OutputApi outputApi in outputApis)
            {
                List<Feature> features = [];
                foreach (Feature feature in file.Features)
                {
                    // FIXME: GLCompat?
                    if (feature.Api == outputApi || (outputApi == OutputApi.GLCompat && feature.Api == OutputApi.GL))
                    {
                        features.Add(feature);
                    }
                }

                List<Extension> extensions = [];
                foreach (Extension extension in file.Extensions)
                {
                    if (extension.SupportedApis.Contains(outputApi) || (outputApi == OutputApi.GLCompat && extension.SupportedApis.Contains(OutputApi.GL)))
                    {
                        extensions.Add(extension);
                    }
                }

                var functionReferences = MakeFunctionReferences(features, extensions, outputApi);
                var enumReferences = MakeEnumReferences(features, extensions, outputApi);

                apis.Add(new API(outputApi, functionReferences, enumReferences));
            }
            return apis;

            static List<FunctionReference> MakeFunctionReferences(List<Feature> features, List<Extension> extensions, OutputApi api)
            {
                //List<FunctionReference> functions = new List<FunctionReference>();
                Dictionary<string, FunctionReference> entryPointToReference = new Dictionary<string, FunctionReference>();

                // FIXME: If we want to generate the compatibility thing we want to remove all of the 
                foreach (var feature in features)
                {
                    foreach (var requires in feature.RequireTags)
                    {
                        Debug.Assert(requires.Api == feature.Api);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(feature.Version, []) { Profile = requires.GLProfile });
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.VersionInfo.Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version } };

                                // Make sure we are not overriding with wrong profile info...
                                Debug.Assert(value.VersionInfo.Profile == GLProfile.None || value.VersionInfo.Profile == requires.GLProfile);
                                value.VersionInfo.Profile = requires.GLProfile;
                            }

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }

                    Debug.Assert(feature.DeprecateTags.Count == 0);

                    foreach (var removes in feature.RemoveTags)
                    {
                        bool isCompatibility = removes.Profile == GLProfile.Compatibility;

                        foreach (var entryPoint in removes.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(feature.Version, []));
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            value.VersionInfo.Remove(new RemoveReason(feature.Version, null, null) { Profile = removes.Profile });

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedApis.Contains(api) || (api == OutputApi.GLCompat && extension.SupportedApis.Contains(OutputApi.GL)));

                    foreach (var requires in extension.RequireTags)
                    {
                        if (api == OutputApi.GLCompat)
                        {
                            if (requires.Api != OutputApi.GL && requires.Api != OutputApi.GLCompat)
                                continue;
                        }
                        else if (requires.Api != api)
                            continue;

                        Debug.Assert(extension.SupportedApis.Contains(requires.Api));

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(null, []));
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            value.VersionInfo.Extensions.Add(new ExtensionInfo(extension.Name, extension.Vendor) { Profile = requires.GLProfile });

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }

                    Debug.Assert(extension.DeprecateTags.Count == 0);
                    Debug.Assert(extension.RemoveTags.Count == 0);
                }

                return entryPointToReference.Values.ToList();
            }

            static List<EnumReference> MakeEnumReferences(List<Feature> features, List<Extension> extensions, OutputApi api)
            {
                Dictionary<string, EnumReference> enumNameToReference = new Dictionary<string, EnumReference>();

                foreach (var feature in features)
                {
                    foreach (var requires in feature.RequireTags)
                    {
                        Debug.Assert(requires.Api == feature.Api);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(feature.Version, []) { Profile = requires.GLProfile }, false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            Debug.Assert(value.VersionInfo.RemovedBy.Count <= 1);

                            if (value.VersionInfo.RemovedBy.Count == 1 &&
                                value.VersionInfo.RemovedBy[0].Version != null &&
                                feature.Version > value.VersionInfo.RemovedBy[0].Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version, RemovedBy = [] } };
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.VersionInfo.Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version } };

                                // Make sure we are not overriding with wrong profile info...
                                Debug.Assert(value.VersionInfo.Profile == GLProfile.None || value.VersionInfo.Profile == requires.GLProfile);
                                value.VersionInfo.Profile = requires.GLProfile;
                            }

                            enumNameToReference[enumName.Name] = value;
                        }
                    }

                    foreach (var removes in feature.RemoveTags)
                    {
                        foreach (var enumName in removes.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(feature.Version, []), false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            Debug.Assert(removes.Profile == GLProfile.Core);

                            value.VersionInfo.Remove(new RemoveReason(feature.Version, null, null) { Profile = removes.Profile });

                            enumNameToReference[enumName.Name] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    if (extension.Name == "GL_EXT_separate_shader_objects")
                    {
                        ;
                    }

                    Debug.Assert(extension.SupportedApis.Contains(api) || (api == OutputApi.GLCompat && extension.SupportedApis.Contains(OutputApi.GL)));

                    foreach (var requires in extension.RequireTags)
                    {
                        if (api == OutputApi.GLCompat)
                        {
                            if (requires.Api != OutputApi.GL && requires.Api != OutputApi.GLCompat)
                                continue;
                        }
                        else if (requires.Api != api)
                            continue;

                        Debug.Assert(extension.SupportedApis.Contains(requires.Api));

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(null, []), false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            value.VersionInfo.Extensions.Add(new ExtensionInfo(extension.Name, extension.Vendor) { Profile = requires.GLProfile });

                            enumNameToReference[enumName.Name] = value;
                        }
                    }

                    Debug.Assert(extension.DeprecateTags.Count == 0);
                    Debug.Assert(extension.RemoveTags.Count == 0);
                }

                return enumNameToReference.Values.ToList();
            }
        }

        public static List<ResolvedApi> ResolveReferences(List<API> apis, SpecificationFile[] files)
        {
            List<ResolvedApi> resolvedApis = new List<ResolvedApi>(apis.Count);
            foreach (var api in apis)
            {
                SpecificationFile file = Array.Find(files, file => file.File == api.Name.ToApiFile())!;
                ResolvedApi resolvedApi = Processor.ResolveReferences(api, file);
                resolvedApis.Add(resolvedApi);
            }
            return resolvedApis;
        }

        private static ResolvedApi ResolveReferences(API api, SpecificationFile file)
        {
            Dictionary<string, Function> functionLookup = new Dictionary<string, Function>();
            foreach (var function in file.Functions)
            {
                functionLookup.Add(function.EntryPoint, function);
            }

            List<Function> apiFunctions = [];
            foreach (FunctionReference functionReference in api.Functions)
            {
                if (functionReference.VersionInfo.AvailableInApi(api.Name) == false)
                    continue;

                Function? function = FindFunction(functionLookup, functionReference.EntryPoint);
                Debug.Assert(function != null);
                Debug.Assert(function.VersionInfo == null);
                function = function with { VersionInfo = functionReference.VersionInfo };

                apiFunctions.Add(function);
            }

            Dictionary<string, List<EnumEntry>> enumLookup = new Dictionary<string, List<EnumEntry>>();
            foreach (var @enum in file.Enums)
            {
                enumLookup.AddToNestedList(@enum.OriginalName, @enum);
            }

            List<EnumMember> apiEnums = [];
            foreach (EnumReference enumReference in api.Enums)
            {
                if (enumReference.VersionInfo.AvailableInApi(api.Name) == false)
                    continue;

                EnumEntry? entry = FindEnum(enumLookup, enumReference.EnumName, api.Name);
                Debug.Assert(entry != null);
                Debug.Assert(entry.VersionInfo == null);
                EnumMember member = new EnumMember()
                {
                    Name = entry.Name,
                    OriginalName = entry.OriginalName,
                    Value = entry.Value,
                    Groups = entry.Groups,
                    IsFlag = entry.IsFlags,
                    EnumSize = entry.UnderlyingSize,
                    VersionInfo = enumReference.VersionInfo,
                };
                apiEnums.Add(member);
            }

            // Cross referenced enums are not referenced in <require> tags
            // so instead we need to add these manually.
            foreach (var @enum in file.Enums)
            {
                if (@enum.IsCrossReferenced)
                {
                    EnumMember member = new EnumMember()
                    {
                        Name = @enum.Name,
                        OriginalName = @enum.OriginalName,
                        Value = @enum.Value,
                        Groups = @enum.Groups,
                        IsFlag = @enum.IsFlags,
                        EnumSize = @enum.UnderlyingSize,
                        // FIXME: We don't know when this was introduced...
                        VersionInfo = new VersionInfo(null, []),
                    };
                    apiEnums.Add(member);
                }
            }

            return new ResolvedApi(api.Name, apiFunctions, apiEnums);

            static Function? FindFunction(Dictionary<string, Function> functions, string functionName)
            {
                functions.TryGetValue(functionName, out Function? function);
                return function;
            }
            static EnumEntry? FindEnum(Dictionary<string, List<EnumEntry>> enums, string enumName, OutputApi api)
            {
                if (enums.TryGetValue(enumName, out List<EnumEntry>? list))
                {
                    foreach (EnumEntry @enum in list)
                    {
                        if (@enum.Apis.HasFlag(api.ToFlag()))
                        {
                            return @enum;
                        }
                    }
                }
                return null;
            }
        }

        private static List<VendorFunctions> CreateVendorFunctions(OutputApi api, List<Function> functions, IDocumentation docs, IOverloader[] overloaders)
        {
            Dictionary<string, List<FunctionData>> functionsPerVendor = new Dictionary<string, List<FunctionData>>();
            foreach (var function in functions)
            {
                FunctionData overloadedFunction = GenerateOverloads(function, overloaders);

                bool keepRemovedFunctions = false;
                if (api == OutputApi.GLCompat)
                    keepRemovedFunctions = true;

                Debug.Assert(function.VersionInfo != null);
                if (function.VersionInfo.Version != null)
                {
                    if (function.VersionInfo.RemovedBy.Count > 0 || function.VersionInfo.Profile == GLProfile.Compatibility)
                    {
                        if (keepRemovedFunctions)
                        {
                            bool added = functionsPerVendor.AddToNestedListIfNotPresent("", overloadedFunction);
                            Debug.Assert(added);
                        }
                    }
                    else
                    {
                        bool added = functionsPerVendor.AddToNestedListIfNotPresent("", overloadedFunction);
                        Debug.Assert(added);
                    }
                }

                foreach (var extension in function.VersionInfo.Extensions)
                {
                    functionsPerVendor.AddToNestedListIfNotPresent(extension.Vendor, overloadedFunction);
                }
            }

            List<VendorFunctions> vendorFunctionsList = [];
            foreach (var (vendor, vendorFunctions) in functionsPerVendor)
            {
                List<OverloadedFunction> overloadedFunctions = [];
                HashSet<Function> nativeFunctionsWithPostfix = [];
                foreach (FunctionData functionData in vendorFunctions)
                {
                    overloadedFunctions.Add(new OverloadedFunction()
                    {
                        NativeFunction = functionData.NativeFunction,
                        Overloads = functionData.Overloads,
                        ChangeNativeName = functionData.ChangeNativeName
                    });

                    if (functionData.ChangeNativeName)
                        nativeFunctionsWithPostfix.Add(functionData.NativeFunction);
                }
                overloadedFunctions.Sort();
                vendorFunctionsList.Add(new VendorFunctions() { Vendor = vendor, Functions = overloadedFunctions, NativeFunctionsWithPostfix = nativeFunctionsWithPostfix });
            }

            foreach (VendorFunctions vendorFunctions in vendorFunctionsList)
            {
                vendorFunctions.Functions.Sort();
                foreach (var overloadedFunction in vendorFunctions.Functions)
                {
                    // FIXME: Sort order for overloads?
                    // overloadedFunction.Overloads.Sort();
                }
            }
            vendorFunctionsList.Sort((e1, e2) => e1.Vendor.CompareTo(e2.Vendor));

            return vendorFunctionsList;
        }

        private static List<EnumType> CreateEnumTypes(OutputApi api, List<EnumMember> enumMembers)
        {
            ApiFile apiFile = api.ToApiFile();
            EnumType allType = new EnumType()
            {
                Name = "All",
                OriginalName = "All",
                IsFlags = false,
                Members = [],

                StrongUnderlyingType = CSPrimitive.Uint(true),
            };

            Dictionary<(string TranslatedName, string OriginalName), List<EnumMember>> enumGroups = new Dictionary<(string, string), List<EnumMember>>();
            foreach (EnumMember member in enumMembers)
            {
                Debug.Assert(member.VersionInfo != null);

                if (member.Value <= uint.MaxValue)
                    allType.Members.Add(member);

                foreach (var group in member.Groups!)
                {
                    if (group.Namespace != apiFile)
                        continue;
                    enumGroups.AddToNestedList((group.TranslatedName, group.OriginalName), member);
                }
            }

            List<EnumType> enumTypes = new List<EnumType>();
            foreach (var (group, members) in enumGroups)
            {
                // FIXME: Here we want to actually look at all of the enum entries that say they belong to this group
                // not only the filtered ones for this output api.
                // - NogginBops 2026-05-12
                bool isFlag = members.Any(m => m.IsFlag);

                EnumSize size = EnumSize.Invalid;
                foreach (var member in members)
                {
                    switch ((size, member.EnumSize))
                    {
                        case (EnumSize.Invalid, _):
                            size = member.EnumSize;
                            break;
                        case var (a, b) when a == b:
                            break;
                        case (EnumSize.Int32, EnumSize.Int64):
                        case (EnumSize.Int64, EnumSize.Int32):
                        case (EnumSize.Int64, EnumSize.Int64):
                            size = EnumSize.Int64;
                            break;
                        case (EnumSize.Uint32, EnumSize.Uint64):
                        case (EnumSize.Uint64, EnumSize.Uint32):
                        case (EnumSize.Uint64, EnumSize.Uint64):
                            size = EnumSize.Int64;
                            break;
                        case (EnumSize.Int32, EnumSize.Uint32):
                        case (EnumSize.Int64, EnumSize.Uint64):
                            // FIXME: What should we do here?
                            break;
                        default:
                            throw new Exception("Incompatible enum sizes in enum group.");
                    }
                }

                CSPrimitive strongType = size switch
                {
                    EnumSize.Int32 => CSPrimitive.Int(true),
                    EnumSize.Uint32 => CSPrimitive.Uint(true),
                    EnumSize.Int64 => CSPrimitive.Long(true),
                    EnumSize.Uint64 => CSPrimitive.Ulong(true),
                    _ => throw new Exception(),
                };

                members.Sort(EnumMember.DefaultComparison);

                EnumType type = new EnumType()
                {
                    Name = group.TranslatedName,
                    OriginalName = group.OriginalName,

                    IsFlags = isFlag,
                    Members = members,

                    ReferencedBy = [],
                    FunctionsUsingEnumGroup = [],

                    StrongUnderlyingType = strongType,
                };

                enumTypes.Add(type);
            }

            allType.Members.Sort(EnumMember.DefaultComparison);

            enumTypes.Sort((g1, g2) => g1.Name.CompareTo(g2.Name));
            enumTypes.Insert(0, allType);

            return enumTypes;
        }

        private static void MarkEnumsUsedByFunctions(OutputApi api, List<VendorFunctions> vendorFunctions, List<EnumType> enumTypes)
        {
            ApiFile file = api.ToApiFile();
            foreach (var vendor in vendorFunctions)
            {
                foreach (OverloadedFunction function in vendor.Functions)
                {
                    foreach (var groupRef in function.NativeFunction.ReferencedEnumGroups)
                    {
                        if (groupRef.Namespace != file)
                        {
                            // FIXME: Here we need to check if the specified namespace is missing this
                            // enum group. So that that is never the case, but that is something we'd
                            // have to handle here.
                            // - NogginBops 2026-05-12
                            continue;
                        }


                        EnumType enumType = FindEnumType(enumTypes, groupRef.TranslatedName)!;
                        if (enumType == null)
                        {
                            Logger.Info($"Added missing enum group '{groupRef.OriginalName}' referenced by '{function.NativeFunction.EntryPoint}'");

                            enumType = new EnumType()
                            {
                                Name = groupRef.TranslatedName,
                                OriginalName = groupRef.OriginalName,
                                IsFlags = false,
                                Members = [],

                                FunctionsUsingEnumGroup = [],

                                StrongUnderlyingType = CSPrimitive.Int(true),
                            };

                            // Skip the "All" enum group in enumTypes[0] and find the index to insert the list for it to remain sorted.
                            int i = enumTypes.BinarySearch(1, enumTypes.Count - 1, enumType, new EnumType.NameComparer());
                            Debug.Assert(i < 0);
                            enumTypes.Insert(~i, enumType);
                        }

                        enumType.FunctionsUsingEnumGroup.Add((vendor.Vendor, function.NativeFunction));
                    }
                }
            }

            foreach (var enumType in enumTypes)
            {
                enumType.FunctionsUsingEnumGroup.Sort((f1, f2) =>
                {
                    // We want to prioritize "core" vendorFunctions before extensions.
                    if (f1.Vendor == "" && f2.Vendor != "") return -1;
                    if (f1.Vendor != "" && f2.Vendor == "") return 1;

                    return f1.Function.Name.CompareTo(f2.Function.Name);
                });
            }

            static EnumType? FindEnumType(List<EnumType> enumTypes, string name)
            {
                foreach (EnumType enumType in enumTypes)
                {
                    if (enumType.Name == name)
                    {
                        return enumType;
                    }
                }
                return null;
            }
        }

        private static ApiPointers CreatePointersList(SpecificationFile file)
        {
            SortedList<string, Function> allFunctions = new SortedList<string, Function>();

            foreach (Function function in file.Functions)
            {
                allFunctions.Add(function.EntryPoint, function);
            }

            return new ApiPointers(file.File, allFunctions.Values.ToList());
        }

        // Maybe we can do the return type overloading in a post processing step?
        private static FunctionData GenerateOverloads(Function nativeFunction, IOverloader[] overloaders)
        {
            List<Overload> overloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(null, null, nativeFunction.Parameters.ToArray(), nativeFunction, nativeFunction.StrongReturnType!,
                    new NameTable(), /*"returnValue",*/ Array.Empty<string>(), nativeFunction.Name),
            };

            bool hasOverloads = false;
            foreach (IOverloader overloader in overloaders)
            {
                List<Overload> newOverloads = new List<Overload>();
                foreach (Overload overload in overloads)
                {
                    if (overloader.TryGenerateOverloads(overload, out List<Overload>? overloaderOverloads))
                    {
                        hasOverloads = true;

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
            Overload[] overloadArray = hasOverloads ? overloads.ToArray() : [];

            bool changeNativeName = false;
            foreach (Overload overload in overloadArray)
            {
                if (AreSignaturesDifferent(nativeFunction, overload) == false)
                {
                    changeNativeName = true;
                }
            }

            return new FunctionData(nativeFunction, overloadArray, changeNativeName);

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
