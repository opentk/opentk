using System.Collections.Generic;
using System.Linq;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;
using MoreLinq.Extensions;

namespace Bind.Baking.Overloading
{
    /// <summary>
    /// Bakes overloads (for convenience, API flexibility, etc) into a given profile.
    /// </summary>
    public static class OverloadBaker
    {
        /// <summary>
        /// Bakes new overloads into the given profile, based on the available overloaders.
        /// </summary>
        /// <param name="profile">The profile to bake.</param>
        /// <returns>The baked profile.</returns>
        [NotNull]
        public static ApiProfile BakeOverloads([NotNull] ApiProfile profile)
        {
            var pipeline = new OverloaderPipeline();

            var functionsThatNeedOverloads = profile.Functions.Where(f => pipeline.HasApplicableStage(f));
            var newOverloads = pipeline.ConsumeSignatures(functionsThatNeedOverloads).ToList();

            var newFunctions = profile.Functions.Concat(newOverloads).ToList();

            // Discard duplicate overloads
            // TODO: Move to another dedicated class?
            var optimizedFunctions = new List<FunctionSignature>();
            foreach (var extensionGroup in newFunctions.GroupBy(f => f.Extension))
            {
                var uniqueFunctions = new List<FunctionSignature>();
                foreach (var function in extensionGroup)
                {
                    if (uniqueFunctions.Any(f => f.HasSameSignatureAs(function)))
                    {
                        continue;
                    }

                    uniqueFunctions.Add(function);
                }

                optimizedFunctions.AddRange(uniqueFunctions);
            }

            return new ApiProfile(profile.Name, profile.Versions, optimizedFunctions, profile.Enumerations);
        }
    }
}
