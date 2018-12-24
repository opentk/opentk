using Generator.Common;
using Newtonsoft.Json;

namespace Generator.Bind.Generators
{
    /// <summary>
    /// Contains extension methods for the <see cref="IGenerator"/> class.
    /// </summary>
    public static class GeneratorExtensions
    {
        /// <summary>
        /// Gets the profile from this generator.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>The profile.</returns>
        public static Profile GetProfile(this IGenerator generator)
        {
            return JsonConvert.DeserializeObject<Profile>(generator.Name + ".json");
        }
    }
}
