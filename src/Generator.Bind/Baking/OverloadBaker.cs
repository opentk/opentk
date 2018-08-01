using System.Collections.Generic;
using System.Linq;
using Bind.Overloaders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Baking
{
    /// <summary>
    /// Bakes overloads (for convenience, API flexibility, etc) into a given profile.
    /// </summary>
    public static class OverloadBaker
    {
        private static IReadOnlyList<IFunctionOverloader> _overloaders = new IFunctionOverloader[]
        {
            new ReturnTypeConvenienceOverloader(),
            new ArrayParameterConvenienceOverloader(),
            new PointerParameterPermutationOverloader(),
            new VoidPointerParameterOverloader(),
        };

        /// <summary>
        /// Bakes new overloads into the given profile, based on the available overloaders.
        /// </summary>
        /// <param name="profile">The profile to bake.</param>
        /// <returns>The baked profile.</returns>
        [NotNull]
        public static ApiProfile BakeOverloads([NotNull] ApiProfile profile)
        {
            var newOverloads = new List<FunctionSignature>();
            foreach (var function in profile.Functions)
            {
                foreach (var overloader in _overloaders)
                {
                    if (overloader.IsApplicable(function))
                    {
                        newOverloads.AddRange(overloader.CreateOverloads(function));
                    }
                }
            }

            var newFunctions = profile.Functions.Concat(newOverloads).ToList();

            return new ApiProfile(profile.Name, profile.Versions, newFunctions, profile.Enumerations);
        }
    }
}
