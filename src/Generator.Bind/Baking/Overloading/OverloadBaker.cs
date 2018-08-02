using System.Linq;
using Bind.XML.Signatures;
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

            var functionsThatNeedOverloads = profile.Functions.Where(f => pipeline.HasApplicableStage(f));
            var newOverloads = pipeline.ConsumeSignatures(functionsThatNeedOverloads);
            var newFunctions = profile.Functions.Concat(newOverloads).ToList();

            return new ApiProfile(profile.Name, profile.Versions, newFunctions, profile.Enumerations);
        }
    }
}
