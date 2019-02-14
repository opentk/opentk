using System.Collections.Generic;
using Generator.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Generator.Convert.Construction.Overriding
{
    /// <summary>
    /// A container for overrides.
    /// </summary>
    public class Overrides
    {
        /// <summary>
        /// Gets or sets a list of baked API names to which this override file applies.
        /// </summary>
        public List<string> Apis { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a list of additive overrides.
        /// </summary>
        public List<AdditiveOverride> Add { get; set; } = new List<AdditiveOverride>();

        /// <summary>
        /// Gets or sets a list of destructive overrides.
        /// </summary>
        public List<DestructiveOverride> Remove { get; set; } = new List<DestructiveOverride>();

        /// <summary>
        /// Gets or sets a list of replacement overrides.
        /// </summary>
        public List<ReplacementOverride> Replace { get; set; } = new List<ReplacementOverride>();

        /// <summary>
        /// Overrides the given profile and outputs the JSON with optional pretty printing.
        /// </summary>
        /// <param name="profile">The profile to override.</param>
        /// <param name="pretty">Whether or not the output JSON should be pretty-printed.</param>
        /// <returns>The output JSON.</returns>
        public string OverrideProfile(Profile profile, bool pretty)
        {
            var json = JObject.FromObject(profile);
            foreach (var additiveOverride in Add)
            {
                additiveOverride.Run(json);
            }

            foreach (var destructiveOverride in Remove)
            {
                destructiveOverride.Run(json);
            }

            foreach (var replacementOverride in Replace)
            {
                replacementOverride.Run(json);
            }

            return json.ToString(pretty ? Formatting.Indented : Formatting.None);
        }
    }
}
