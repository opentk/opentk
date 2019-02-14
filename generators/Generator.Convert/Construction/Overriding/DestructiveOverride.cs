using System.Linq;
using Newtonsoft.Json.Linq;

namespace Generator.Convert.Construction.Overriding
{
    /// <summary>
    /// Represents a JSON override that deletes properties.
    /// </summary>
    public class DestructiveOverride
    {
        /// <summary>
        /// Gets or sets the target path.
        /// </summary>
        public string JsonPath { get; set; }

        /// <summary>
        /// Runs this override.
        /// </summary>
        /// <param name="json">The target JSON object.</param>
        public void Run(JObject json)
        {
            foreach (var token in json.SelectTokens(JsonPath))
            {
                token.Remove();
            }
        }
    }
}
