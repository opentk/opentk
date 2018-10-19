using System.Collections.Generic;
using System.Linq;
using Bind.Builders;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

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

            var functionsThatNeedOverloads = profile.NativeSignatures.Where(f => pipeline.HasApplicableStage(f));
            var newOverloads = pipeline.ConsumeSignatures(functionsThatNeedOverloads).ToList();

            // Discard duplicate overloads
            var optimizedOverloads = new List<FunctionSignature>(profile.Overloads);
            foreach (var extensionGroup in newOverloads.GroupBy(f => f.Extension))
            {
                var uniqueOverloads = new List<FunctionSignature>();
                foreach (var function in extensionGroup)
                {
                    if (uniqueOverloads.Any(f => f.HasSameSignatureAs(function)))
                    {
                        continue;
                    }

                    uniqueOverloads.Add(function);
                }

                optimizedOverloads.AddRange(uniqueOverloads);
            }

            return new ApiProfileBuilder(profile).WithOverloads(optimizedOverloads).Build();
        }
    }
}
