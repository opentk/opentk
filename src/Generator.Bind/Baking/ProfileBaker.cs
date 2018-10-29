using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Bind.Builders;
using Bind.Extensions;
using Bind.Translation.Translators;
using Bind.Translation.Trimmers;
using Bind.Versioning;
using Bind.XML;
using Bind.XML.Overrides;
using Bind.XML.Overrides.Enumerations;
using Bind.XML.Overrides.Functions;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;
using MoreLinq;

namespace Bind.Baking
{
    /// <summary>
    /// This class is responsible for taking the full set of signatures and the full set of overrides, and then
    /// combining them into final specification profiles.
    ///
    /// In short, it performs a union of all elements in a version range in both sets, and then applies the override set
    /// to the profile set.
    /// </summary>
    public class ProfileBaker
    {
        /// <summary>
        /// Gets the set of profiles to bake.
        /// </summary>
        [NotNull, ItemNotNull]
        private readonly IReadOnlyList<ApiProfile> _profiles;

        /// <summary>
        /// Gets the set of overrides to bake into the profiles.
        /// </summary>
        [NotNull, ItemNotNull]
        private readonly IReadOnlyList<ApiProfileOverride> _overrides;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileBaker"/> class.
        /// </summary>
        /// <param name="profiles">The profiles to use in the baking.</param>
        /// <param name="overrides">The overrides to use in the baking.</param>
        public ProfileBaker
        (
            [NotNull, ItemNotNull] IReadOnlyList<ApiProfile> profiles,
            [NotNull, ItemNotNull] IReadOnlyList<ApiProfileOverride> overrides
        )
        {
            _profiles = profiles ?? throw new ArgumentNullException(nameof(profiles));
            _overrides = overrides ?? throw new ArgumentNullException(nameof(overrides));
        }

        /// <summary>
        /// Bakes the named profile for the given version range.
        /// </summary>
        /// <param name="profileName">The name of the profile.</param>
        /// <param name="versionRange">The version range of the profile to bake.</param>
        /// <param name="baseProfileName">The name of the base profile, if any.</param>
        /// <returns>A baked profile.</returns>
        [NotNull]
        public ApiProfile BakeProfile
        (
            [NotNull] string profileName,
            [NotNull] VersionRange versionRange,
            [CanBeNull] string baseProfileName = null
        )
        {
            // Coalesce profile and overrides
            var coalescedProfile = CoalesceProfile(profileName, versionRange);
            var coalescedOverrides = CoalesceOverrides(profileName, versionRange);

            // Trim out deprecated tokens and overrides
            if (!(baseProfileName is null))
            {
                coalescedOverrides = TrimDeprecatedOverrides(coalescedOverrides, baseProfileName);
            }

            // Perform the second resolution pass over the override enumerations
            ResolveEnumerationOverrides(coalescedOverrides, coalescedProfile);

            var enumerationTranslator = new ProfileEnumerationTranslator();

            // Translate profile identifiers and types names
            var translatedProfile = new ProfileFunctionTranslator().Translate(coalescedProfile);
            translatedProfile = enumerationTranslator.Translate(translatedProfile);

            var translatedOverrides = enumerationTranslator.Translate(coalescedOverrides);

            // Apply profile overrides
            var overridenProfile = ApplyOverridesToProfile(translatedProfile, translatedOverrides);

            return overridenProfile;
        }

        /// <summary>
        /// Trims out any overrides or additions that are using deprecated functions as their base.
        /// </summary>
        /// <param name="coalescedOverrides">The coalesced overrides to trim.</param>
        /// <param name="baseProfileName">The name of the base profile to check for deprecated functions and tokens.</param>
        /// <returns>The trimmed overrides.</returns>
        [NotNull]
        private ApiProfileOverride TrimDeprecatedOverrides
        (
            [NotNull] ApiProfileOverride coalescedOverrides,
            [NotNull] string baseProfileName
        )
        {
            var coalescedBaseProfile = CoalesceProfile(baseProfileName, coalescedOverrides.Versions);
            var deprecatedTokens = coalescedBaseProfile.Enumerations
                .SelectMany(e => e.Tokens)
                .Where(t => t.IsDeprecated)
                .Where(t => t.DeprecatedIn < coalescedOverrides.Versions.Maximum)
                .ToList();

            var deprecatedFunctions = coalescedBaseProfile.NativeSignatures
                .Where(f => f.IsDeprecated)
                .Where(t => t.DeprecatedIn < coalescedOverrides.Versions.Maximum)
                .ToList();

            var newEnumerations = new List<EnumerationOverride>();
            foreach (var addedEnumeration in coalescedOverrides.AddedEnumerations)
            {
                var newDirectTokens = new List<TokenSignature>();
                foreach (var directToken in addedEnumeration.DirectTokens)
                {
                    if (deprecatedTokens.Any(dt => dt.Name == directToken.Name))
                    {
                        continue;
                    }

                    newDirectTokens.Add(directToken);
                }

                var newUseTokens = new List<UseTokenOverride>();
                foreach (var useToken in addedEnumeration.UseTokens)
                {
                    if (deprecatedTokens.Any(dt => dt.Name == useToken.Token))
                    {
                        continue;
                    }

                    newUseTokens.Add(useToken);
                }

                var newEnumeration = new EnumerationOverride
                (
                    addedEnumeration.Name,
                    newDirectTokens,
                    newUseTokens,
                    addedEnumeration.ReuseEnumerations
                );

                newEnumerations.Add(newEnumeration);
            }

            var newFunctionReplacements = new List<FunctionOverride>();
            foreach (var functionReplacement in coalescedOverrides.ReplacedFunctions)
            {
                var nameVariations = Utilities.GetNameVariations(functionReplacement);

                var isReplacementDeprecated = nameVariations.Any(variation => deprecatedFunctions.Any(df => df.Name == variation));
                if (!isReplacementDeprecated)
                {
                    newFunctionReplacements.Add(functionReplacement);
                }
            }

            var newFunctionOverloads = new List<FunctionOverride>();
            foreach (var functionOverload in coalescedOverrides.FunctionOverloads)
            {
                var nameVariations = Utilities.GetNameVariations(functionOverload);

                var isReplacementDeprecated = nameVariations.Any(variation => deprecatedFunctions.Any(df => df.Name == variation));
                if (!isReplacementDeprecated)
                {
                    newFunctionOverloads.Add(functionOverload);
                }
            }

            return new ApiProfileOverride
            (
                coalescedOverrides.Name,
                coalescedOverrides.Versions,
                newEnumerations,
                newFunctionReplacements,
                newFunctionOverloads
            );
        }

        /// <summary>
        /// Applies the set of overrides to the profile, replacing and overloading functions as required.
        /// </summary>
        /// <param name="coalescedProfile">The coalesced profile.</param>
        /// <param name="coalescedOverrides">The coalesced overrides relevant to the profile.</param>
        /// <returns>A new profile with the applied overrides.</returns>
        [NotNull]
        private ApiProfile ApplyOverridesToProfile([NotNull] ApiProfile coalescedProfile, [NotNull] ApiProfileOverride coalescedOverrides)
        {
            var newEnums = coalescedOverrides.AddedEnumerations
                .Select
                (
                    overrideEnum =>
                        new EnumerationSignature(overrideEnum.Name, overrideEnum.DirectTokens)
                )
                .Concat(coalescedProfile.Enumerations)
                .ToList();

            var newFunctions = coalescedProfile.NativeSignatures.ToList();

            foreach (var functionReplacement in coalescedOverrides.ReplacedFunctions)
            {
                var baseFunctions = FindBaseFunctions(newFunctions, functionReplacement);
                foreach (var baseFunction in baseFunctions)
                {
                    var overriddenFunction = CreateOverriddenFunction(baseFunction, functionReplacement);

                    newFunctions.Remove(baseFunction);
                    newFunctions.Add(overriddenFunction);
                }
            }

            var newOverloads = new List<FunctionSignature>(coalescedProfile.Overloads);
            foreach (var functionOverload in coalescedOverrides.FunctionOverloads)
            {
                var baseFunctions = FindBaseFunctions(newFunctions, functionOverload);
                foreach (var baseFunction in baseFunctions)
                {
                    var overloadedFunction = CreateOverriddenFunction(baseFunction, functionOverload);

                    newOverloads.Add(overloadedFunction);
                }
            }

            return new ApiProfileBuilder(coalescedProfile)
                .WithNativeSignatures(newFunctions)
                .WithEnumerations(newEnums)
                .WithOverloads(newOverloads)
                .Build();
        }

        /// <summary>
        /// Creates an overridden function based on the given function and its override.
        /// </summary>
        /// <param name="functionBase">The base function.</param>
        /// <param name="functionOverride">The function override.</param>
        /// <returns>An overridden function.</returns>
        [NotNull, Pure]
        private FunctionSignature CreateOverriddenFunction
        (
            [NotNull] FunctionSignature functionBase,
            [NotNull] FunctionOverride functionOverride
        )
        {
            var newVersion = functionOverride.NewVersion ?? functionBase.IntroducedIn;
            var newReturnType = functionOverride.NewReturnType ?? functionBase.ReturnType;

            var newParameters = CreateOverriddenParameters(functionBase, functionOverride);

            var newDeprecationReason = functionOverride.ObsoletionReason ?? functionBase.DeprecationReason;

            return new FunctionSignature
            (
                functionBase.Name,
                functionBase.NativeEntrypoint,
                functionBase.Categories,
                functionBase.Extension,
                newVersion,
                newReturnType,
                newParameters,
                functionBase.DeprecatedIn,
                newDeprecationReason
            );
        }

        /// <summary>
        /// Creates an overridden set of function parameters based on the given function and its override.
        /// </summary>
        /// <param name="functionBase">The base function.</param>
        /// <param name="functionOverride">The function override.</param>
        /// <returns>The set of overridden parameter.</returns>
        [NotNull, ItemNotNull]
        private static IReadOnlyList<ParameterSignature> CreateOverriddenParameters
        (
            [NotNull] FunctionSignature functionBase,
            [NotNull] FunctionOverride functionOverride
        )
        {
            var baseParameters = functionBase.Parameters;
            var parametersWithComputedCounts =
                new List<(ParameterSignature Parameter, IReadOnlyList<string> ComputedCountParameterNames)>();
            var parametersWithValueReferenceCounts =
                new List<(ParameterSignature Parameter, string ParameterReferenceName)>();

            var resultParameters = new List<ParameterSignature>(baseParameters);
            foreach (var overrideParameter in functionOverride.ParameterOverrides)
            {
                var baseParameter = functionBase.Parameters.FirstOrDefault(p => p.Name == overrideParameter.BaseName);
                if (baseParameter is null)
                {
                    throw new InvalidDataException
                    (
                        $"Could not find target parameter with name \"{overrideParameter.BaseName}\" to override."
                    );
                }

                var overriddenParameter = CreateOverriddenParameter
                (
                    baseParameter,
                    overrideParameter,
                    out var hasComputedCount,
                    out var computedCountParameterNames,
                    out var hasValueReference,
                    out var valueReferenceName,
                    out var valueReferenceExpression
                );

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((overriddenParameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((overriddenParameter, valueReferenceName));

                    // TODO: Pass on the mathematical expression
                }

                var baseIndex = resultParameters.IndexOf(baseParameter);
                resultParameters[baseIndex] = overriddenParameter;
            }

            ParsingHelpers.ResolveComputedCountSignatures(resultParameters, parametersWithComputedCounts);

            ParsingHelpers.ResolveReferenceCountSignatures(resultParameters, parametersWithValueReferenceCounts);

            return resultParameters;
        }

        /// <summary>
        /// Creates an overridden <see cref="ParameterSignature"/> from a given parameter override.
        /// </summary>
        /// <param name="baseParameter">The base parameter.</param>
        /// <param name="parameterOverride">The parameter override.</param>
        /// <param name="hasComputedCount">Whether or not the signature has a computed count.</param>
        /// <param name="computedCountParameterNames">The names of the parameters used in the computed count. </param>
        /// <param name="hasValueReference">Whether or not the signature has a value reference.</param>
        /// <param name="valueReferenceName">The name of the referenced parameter.</param>
        /// <param name="valueReferenceExpression">
        /// The mathematical expression to apply to the name of the referenced parameter.
        /// </param>
        /// <returns>An overriden parameter.</returns>
        [NotNull, ContractAnnotation("hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull")]
        private static ParameterSignature CreateOverriddenParameter
        (
            [NotNull] ParameterSignature baseParameter,
            [NotNull] ParameterOverride parameterOverride,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            computedCountParameterNames = null;
            valueReferenceName = null;
            valueReferenceExpression = null;

            hasComputedCount = false;
            hasValueReference = false;

            var newName = parameterOverride.NewName ?? baseParameter.Name;
            var newType = parameterOverride.NewType ?? baseParameter.Type;
            var newFlow = parameterOverride.NewFlow ?? baseParameter.Flow;

            var newCount = parameterOverride.NewCount is null
                ? baseParameter.Count
                : ParsingHelpers.ParseCountSignature
                (
                    parameterOverride.NewCount,
                    out hasComputedCount,
                    out computedCountParameterNames,
                    out hasValueReference,
                    out valueReferenceName,
                    out valueReferenceExpression
                );

            return new ParameterSignature(newName, newType, newFlow, newCount);
        }

        /// <summary>
        /// Searches a set of existing functions for the base functions a function override refers to.
        /// This method identifies the base method by its name and parameter names.
        ///
        /// Two options are considered when searching for the base function by name - its trimmed name, and its
        /// untrimmed name. Effectively, this means overrides can be matched against the final name, the entrypoint, or
        /// the entrypoint without its extension (if any).
        /// </summary>
        /// <param name="existingFunctions">The set of existing functions.</param>
        /// <param name="functionOverride">The override.</param>
        /// <returns>The base function of the override.</returns>
        /// <exception cref="InvalidDataException">Thrown if no base function could be found.</exception>
        /// <exception cref="AmbiguousMatchException">Thrown if multiple accepted bases were found.</exception>
        [NotNull]
        private static IEnumerable<FunctionSignature> FindBaseFunctions
        (
            [NotNull, ItemNotNull] IReadOnlyCollection<FunctionSignature> existingFunctions,
            [NotNull] FunctionOverride functionOverride
        )
        {
            // First, build the list of candidate names
            var variations = Utilities.GetNameVariations(functionOverride).ToList();
            foreach (var variation in variations)
            {
                var baseFunctionCandidates = existingFunctions.Where
                (
                    f =>
                        (f.Name == variation || f.NativeEntrypoint == variation)
                        && f.Extension == functionOverride.BaseExtension
                ).ToList();

                if (!baseFunctionCandidates.Any())
                {
                    baseFunctionCandidates = existingFunctions
                        .Where
                        (
                            f => f.Name == variation || f.NativeEntrypoint == variation
                        )
                        .ToList();
                }

                baseFunctionCandidates = baseFunctionCandidates.Where
                (
                    f =>
                        functionOverride.ParameterOverrides.All(po => f.Parameters.Any(p => p.Name == po.BaseName))
                ).ToList();

                // If we have a set of candidates at this point, we've found the most specific set of functions that are
                // applicable.
                if (baseFunctionCandidates.Any())
                {
                    return baseFunctionCandidates;
                }
            }

            // If we've reached this point, we couldn't find any targets. Let's gather as much information for the end
            // developer as possible.
            foreach (var variation in variations)
            {
                var noFunctionsWithThatName = existingFunctions.All(f => f.Name != variation);
                if (noFunctionsWithThatName)
                {
                    throw new InvalidDataException
                    (
                        $"No base function found for the override with the name \"{functionOverride.BaseName}\" when " +
                        $"considering the variation \"{variation}\". " +
                        $"Specify another name."
                    );
                }

                var parameterNames = new List<string>();
                var functionsWithThatName = existingFunctions.Where(f => f.Name == variation).ToList();
                foreach (var functionWithThatName in functionsWithThatName)
                {
                    var parameterNamesNotFound = functionOverride.ParameterOverrides
                        .Where
                        (
                            po =>
                                functionWithThatName.Parameters
                                    .All(p => p.Name != po.BaseName)
                        )
                        .Select(po => po.BaseName);

                    parameterNames.AddRange(parameterNamesNotFound);
                }

                if (parameterNames.Any())
                {
                    throw new InvalidDataException
                    (
                        $"No base function found for the override with the name \"{functionOverride.BaseName}\" when " +
                        $"considering the variation \"{variation}\" that had the following parameters: " +
                        $"({string.Join(", ", parameterNames.ToArray())})" +
                        $"Specify other parameter names."
                    );
                }
            }

            throw new InvalidDataException("No base function found for override.");
        }

        /// <summary>
        /// Resolves all external token references in the override enumerations, recursively searching for them as
        /// needed. This method modifies the contents of the <paramref name="coalescedOverrides"/> parameter.
        /// </summary>
        /// <param name="coalescedOverrides">The override profile to resolve the enumerations in.</param>
        /// <param name="coalescedProfile">The profile that the overrides are applicable to.</param>
        private void ResolveEnumerationOverrides([NotNull] ApiProfileOverride coalescedOverrides, [NotNull] ApiProfile coalescedProfile)
        {
            // Resolve the various token references in the enumeration overrides
            foreach (var enumeration in coalescedOverrides.AddedEnumerations.Where(e => e.UseTokens.Any()))
            {
                var resolvedTokens = new List<TokenSignature>();
                foreach (var useToken in enumeration.UseTokens)
                {
                    var tokenName = useToken.Token;
                    var targetEnumName = useToken.Enumeration;

                    var foundToken =
                        ResolveEnumerationTokenReference(tokenName, targetEnumName, coalescedProfile, coalescedOverrides);

                    if (foundToken is null)
                    {
                        throw new InvalidDataException
                        (
                            $"Failed to resolve token \"{tokenName}\". Consider using the optional attribute to " +
                            $"suppress this message, or fix the override."
                        );
                    }

                    resolvedTokens.Add(foundToken);
                }

                enumeration.DirectTokens = enumeration.DirectTokens
                    .Concat(resolvedTokens)
                    .DistinctBy(t => t.Name)
                    .ToList();

                enumeration.UseTokens = new List<UseTokenOverride>();
            }

            // Resolve enumeration reuses in the enumeration overrides
            foreach (var enumeration in coalescedOverrides.AddedEnumerations.Where(e => e.ReuseEnumerations.Any()))
            {
                var resolvedTokens = new List<TokenSignature>();
                foreach (var reuseToken in enumeration.ReuseEnumerations)
                {
                    var foundTokens =
                        ResolveReuseEnumerationToken(reuseToken.Enumeration, coalescedProfile, coalescedOverrides);
                    resolvedTokens.AddRange(foundTokens);
                }

                enumeration.DirectTokens = enumeration.DirectTokens
                    .Concat(resolvedTokens)
                    .DistinctBy(t => t.Name)
                    .ToList();

                enumeration.ReuseEnumerations = new List<ReuseEnumerationOverride>();
            }
        }

        /// <summary>
        /// Recursively resolves a set of tokens contained in another enumeration.
        /// </summary>
        /// <param name="reusedEnumeration">The name of the enumeration.</param>
        /// <param name="coalescedProfile">A coalesced profile.</param>
        /// <param name="coalescedOverrides">A coalesced override profile.</param>
        /// <returns>The set of tokens.</returns>
        /// <exception cref="InvalidDataException">Thrown if the directive couldn't be resolved.</exception>
        [NotNull, ItemNotNull]
        private IEnumerable<TokenSignature> ResolveReuseEnumerationToken
        (
            [NotNull] string reusedEnumeration,
            [NotNull] ApiProfile coalescedProfile,
            [NotNull] ApiProfileOverride coalescedOverrides
        )
        {
            var profileEnum = coalescedProfile.Enumerations.FirstOrDefault(e => e.Name == reusedEnumeration);
            if (!(profileEnum is null))
            {
                return profileEnum.Tokens;
            }

            var overrideEnum = coalescedOverrides.AddedEnumerations.FirstOrDefault(e => e.Name == reusedEnumeration);
            if (!(overrideEnum is null))
            {
                var results = overrideEnum.DirectTokens;

                foreach (var recursiveReuse in overrideEnum.ReuseEnumerations)
                {
                    results = results.Concat
                    (
                        ResolveReuseEnumerationToken(recursiveReuse.Enumeration, coalescedProfile, coalescedOverrides)
                    ).ToList();
                }

                return results;
            }

            throw new InvalidDataException("Enumeration reuse directive could not be resolved.");
        }

        /// <summary>
        /// Recursively resolves the concrete value of an enumeration token reference. This method will traverse any
        /// chained token references.
        /// </summary>
        /// <param name="tokenName">The name of the token to resolve.</param>
        /// <param name="targetEnumName">The name of the enumeration to search in.</param>
        /// <param name="coalescedProfile">A coalesced profile.</param>
        /// <param name="coalescedOverrides">A coalesced override profile.</param>
        /// <param name="visitedEnumerations">
        /// A list of names of visited enumerations. Used to break out of cyclic dependencies.
        /// </param>
        /// <returns>The token.</returns>
        /// <exception cref="InvalidDataException">Thrown if the directive couldn't be resolved.</exception>
        [CanBeNull]
        private static TokenSignature ResolveEnumerationTokenReference
        (
            [NotNull] string tokenName,
            [CanBeNull] string targetEnumName,
            [NotNull] ApiProfile coalescedProfile,
            [NotNull] ApiProfileOverride coalescedOverrides,
            [CanBeNull] List<string> visitedEnumerations = null
        )
        {
            visitedEnumerations = visitedEnumerations ?? new List<string>();

            if (visitedEnumerations.Contains(targetEnumName))
            {
                Debug.WriteLine
                (
                    $"Cyclical dependency in enum found when resolving \"{tokenName}\" in \"{targetEnumName}\"."
                );

                return null;
            }

            var profileEnumCandidates = targetEnumName is null
                ? coalescedProfile.Enumerations
                : coalescedProfile.Enumerations.Where(e => e.Name == targetEnumName);

            var overrideEnumCandidates = targetEnumName is null
                ? coalescedOverrides.AddedEnumerations
                : coalescedOverrides.AddedEnumerations.Where(e => e.Name == targetEnumName);

            foreach (var profileEnum in profileEnumCandidates)
            {
                var token = profileEnum.Tokens.FirstOrDefault(t => t.Name == tokenName);

                if (!(token is null))
                {
                    return token;
                }
            }

            foreach (var overrideEnum in overrideEnumCandidates)
            {
                var token = overrideEnum.DirectTokens.FirstOrDefault(t => t.Name == tokenName);

                if (!(token is null))
                {
                    return token;
                }

                var nestedUseToken = overrideEnum.UseTokens.FirstOrDefault(t => t.Token == tokenName);
                if (!(nestedUseToken is null))
                {
                    visitedEnumerations.Add(targetEnumName);

                    // We'll recursively resolve that token until we find it or run out of options, in which case an
                    // exception will be thrown.
                    token = ResolveEnumerationTokenReference
                    (
                        nestedUseToken.Token,
                        nestedUseToken.Enumeration,
                        coalescedProfile,
                        coalescedOverrides,
                        visitedEnumerations
                    );

                    if (!(token is null))
                    {
                        return token;
                    }
                }

                var reuseTokens = overrideEnum.ReuseEnumerations;
                foreach (var reuseToken in reuseTokens)
                {
                    visitedEnumerations.Add(targetEnumName);

                    // We'll recursively resolve that token until we find it or run out of options
                    token = ResolveEnumerationTokenReference
                    (
                        tokenName,
                        reuseToken.Enumeration,
                        coalescedProfile,
                        coalescedOverrides,
                        visitedEnumerations
                    );

                    if (!(token is null))
                    {
                        return token;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Coalesces the overrides in a given version range into a single override profile, combining their defined
        /// enumerations and functions into one monolithic profile.
        /// </summary>
        /// <param name="profileName">The name of the profile.</param>
        /// <param name="versionRange">The version range to coalesce.</param>
        /// <returns>A coalesced override profile.</returns>
        /// <exception cref="InvalidOperationException">Thrown if a function is defined in more than one version.</exception>
        [NotNull, Pure]
        private ApiProfileOverride CoalesceOverrides([NotNull] string profileName, [NotNull] VersionRange versionRange)
        {
            var profileOverrides = GetOverridesInRange(profileName, versionRange).OrderBy(o => o.Versions).ToList();

            var enums = new Dictionary<string, EnumerationOverride>();
            foreach (var profileOverride in profileOverrides)
            {
                foreach (var enumeration in profileOverride.AddedEnumerations)
                {
                    var directTokens = new List<TokenSignature>();
                    directTokens.AddRange(enumeration.DirectTokens);

                    var useTokens = new List<UseTokenOverride>();
                    useTokens.AddRange(enumeration.UseTokens);

                    var reuseEnumerations = new List<ReuseEnumerationOverride>();
                    reuseEnumerations.AddRange(enumeration.ReuseEnumerations);

                    var otherProfiles = profileOverrides.Where(p => p.Versions > profileOverride.Versions);
                    var otherEnums = otherProfiles.SelectMany(p => p.AddedEnumerations).Where(p => p.Name == enumeration.Name);

                    foreach (var otherEnum in otherEnums)
                    {
                        directTokens.AddRange(otherEnum.DirectTokens);
                        useTokens.AddRange(otherEnum.UseTokens);
                        reuseEnumerations.AddRange(otherEnum.ReuseEnumerations);
                    }

                    if (!enums.TryGetValue(enumeration.Name, out var targetEnum))
                    {
                        targetEnum = new EnumerationOverride(enumeration.Name);
                        enums.Add(enumeration.Name, enumeration);
                    }

                    targetEnum.DirectTokens = directTokens.DistinctBy(t => t.Name).ToList();
                    targetEnum.UseTokens = useTokens.DistinctBy(t => t.Token).ToList();
                    targetEnum.ReuseEnumerations = reuseEnumerations.DistinctBy(t => t.Enumeration).ToList();
                }
            }

            var overloads = new List<FunctionOverride>();
            var replacedFunctions = new List<FunctionOverride>();
            foreach (var profileOverride in profileOverrides)
            {
                foreach (var function in profileOverride.FunctionOverloads)
                {
                    if (overloads.Any(f => f.HasSameSignatureAs(function) && f.BaseExtension == function.BaseExtension))
                    {
                        throw new InvalidOperationException
                        (
                            "Duplicate overload redefinition in overrides detected - generator error or schema change."
                        );
                    }

                    overloads.Add(function);
                }

                foreach (var function in profileOverride.ReplacedFunctions)
                {
                    if (replacedFunctions.Any(f => f.HasSameSignatureAs(function) && f.BaseExtension == function.BaseExtension))
                    {
                        throw new InvalidOperationException
                        (
                            "Duplicate replaced function redefinition in overrides detected - generator error or schema change."
                        );
                    }

                    replacedFunctions.Add(function);
                }
            }

            return new ApiProfileOverride
            (
                profileName,
                versionRange,
                enums.Values.ToList(),
                replacedFunctions,
                overloads
            );
        }

        /// <summary>
        /// Coalesces the profiles in a given version range into a single profile, combining their defined enumerations
        /// and functions into one monolithic profile.
        /// </summary>
        /// <param name="profileName">The name of the profile.</param>
        /// <param name="versionRange">The version range to coalesce.</param>
        /// <returns>A coalesced profile.</returns>
        /// <exception cref="InvalidOperationException">Thrown if a function is defined in more than one version.</exception>
        [NotNull, Pure]
        private ApiProfile CoalesceProfile([NotNull] string profileName, [NotNull] VersionRange versionRange)
        {
            var profiles = GetProfilesInRange(profileName, versionRange).OrderBy(p => p.Versions).ToList();

            // Pre-bake stage: collect enums from the various profiles and union them together
            var enums = new Dictionary<string, EnumerationSignature>();
            foreach (var profile in profiles)
            {
                // Pre-bake any enumeration in the profile which hasn't already been pre-baked by a previous profile
                foreach (var enumeration in profile.Enumerations.Where(e => enums.Keys.All(k => k != e.Name)))
                {
                    var tokens = new List<TokenSignature>();
                    tokens.AddRange(enumeration.Tokens);

                    var otherProfiles = profiles.Where(p => p.Versions > profile.Versions);
                    var otherEnums = otherProfiles.SelectMany(p => p.Enumerations).Where(p => p.Name == enumeration.Name);

                    foreach (var otherEnum in otherEnums)
                    {
                        tokens.AddRange(otherEnum.Tokens);
                    }

                    if (!enums.TryGetValue(enumeration.Name, out var targetEnum))
                    {
                        targetEnum = new EnumerationSignature(enumeration.Name);
                        enums.Add(enumeration.Name, enumeration);
                    }

                    targetEnum.Tokens = tokens.DistinctBy(t => t.Name).ToList();
                }
            }

            // Pre-bake stage: collect functions
            var functions = new Dictionary<string, FunctionSignature>();
            foreach (var profile in profiles)
            {
                // Pre-bake any function in the profile which hasn't already been pre-baked by a previous profile
                foreach (var function in profile.NativeSignatures)
                {
                    if (functions.ContainsKey(function.Name))
                    {
                        Debug.WriteLine
                        (
                            $"Function redefinition of \"{function.Name}\" in profile \"{profile.GetFriendlyName()} " +
                            $"v{profile.Versions}\" detected - replacing existing definition."
                        );

                        functions[function.Name] = function;
                        continue;
                    }

                    functions.Add(function.Name, function);
                }
            }

            return new ApiProfile(profileName, versionRange, functions.Values.ToList(), enums.Values.ToList());
        }

        /// <summary>
        /// Gets the available profile names.
        /// </summary>
        /// <returns>The profile names.</returns>
        [NotNull, ItemNotNull, Pure]
        private IEnumerable<string> GetAvailableProfileNames()
        {
            return _profiles.Select(p => p.Name);
        }

        /// <summary>
        /// Gets the available version ranges for a given profile.
        /// </summary>
        /// <param name="profileName">The name of the profile to get ranges for.</param>
        /// <returns>The ranges.</returns>
        [NotNull, ItemNotNull, Pure]
        private IEnumerable<VersionRange> GetAvailableVersionRanges([NotNull] string profileName)
        {
            return _profiles
                .Where(p => p.Name == profileName)
                .Select(profile => new VersionRange(new Version(0, 0), profile.Versions.Maximum));
        }

        /// <summary>
        /// Gets the profiles that fall inside a given profile name and version range. A profile with the maximum
        /// version "0.0.0" is always considered in range.
        /// </summary>
        /// <param name="profileName">The name of the profile.</param>
        /// <param name="versionRange">The version range.</param>
        /// <returns>The profiles.</returns>
        [NotNull, ItemNotNull, Pure]
        private IEnumerable<ApiProfile> GetProfilesInRange
        (
            [NotNull] string profileName,
            [NotNull] VersionRange versionRange
        )
        {
            var zeroVersion = new Version(0, 0);
            return _profiles
                .Where
                (
                    p =>
                        p.Name == profileName &&
                        (versionRange.IsInRange(p.Versions.Maximum) || p.Versions.Maximum == zeroVersion)
                );
        }

        /// <summary>
        /// Gets the overrides that fall inside a given profile name and version range. An override with the maximum
        /// version "0.0.0" is always considered in range.
        /// </summary>
        /// <param name="profileName">The name of the profile.</param>
        /// <param name="versionRange">The version range.</param>
        /// <returns>The overrides.</returns>
        [NotNull, ItemNotNull, Pure]
        private IEnumerable<ApiProfileOverride> GetOverridesInRange
        (
            [NotNull] string profileName,
            [NotNull] VersionRange versionRange
        )
        {
            var zeroVersion = new Version(0, 0);
            return _overrides
                .Where
                (
                    p =>
                        p.Name == profileName &&
                        (versionRange.IsInRange(p.Versions.Maximum) || p.Versions.Maximum == zeroVersion)
                );
        }
    }
}
