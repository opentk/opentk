using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Common;
using Generator.Convert.Overrides;

namespace Generator.Convert.Construction
{
    public static class Overrider
    {
        public static Lazy<List<ApiProfileOverride>> Overrides { get; } = new Lazy<List<ApiProfileOverride>>
        (
            () => Program.CliOptions.Overrides?.SelectMany(OverrideReader.GetProfileOverrides).ToList()
        );

        public static void Override(Profile profile)
        {
            var overrides = Overrides?.Value.FirstOrDefault(x => x.Name == profile.Name && x.Version == profile.Version);
            if (overrides == null)
            {
                // no overrides available, the profile must be perfect.
                return;
            }
        }

        public static void ApplyEnumerationOverrides(ApiProfileOverride overrides, Profile profile)
        {
            // TODO (ApplyEnumerationOverrides)
        }

        public static void ApplyFunctionReplacement(ApiProfileOverride overrides, Profile profile)
        {
            // TODO (ApplyFunctionReplacement)
        }
    }
}
