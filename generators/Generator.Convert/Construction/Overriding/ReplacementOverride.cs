using Generator.Common;
using Newtonsoft.Json.Linq;

namespace Generator.Convert.Construction.Overriding
{
    /// <summary>
    /// Represents an override.
    /// </summary>
    public class ReplacementOverride
    {
        /// <summary>
        /// Gets or sets the JSON path to which this override should be applied.
        /// </summary>
        public string JsonPath { get; set; }

        /// <summary>
        /// Gets or sets the value of the property to replace.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Runs this override.
        /// </summary>
        /// <param name="jobj">The JSON object to apply the overrides to.</param>
        public void Run(JObject jobj)
        {
            foreach (var token in jobj.SelectTokens(JsonPath))
            {
                token.Replace(JToken.FromObject(Value));
            }
        }
    }
}
