using Newtonsoft.Json.Linq;

namespace Generator.Convert.Construction.Overriding
{
    /// <summary>
    /// Represents a JSONPath override that adds a JSON property.
    /// </summary>
    public class AdditiveOverride
    {
        /// <summary>
        /// Gets or sets the target path.
        /// </summary>
        public string JsonPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the property to add.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the property to add.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Runs this override.
        /// </summary>
        /// <param name="obj">The target JSON object.</param>
        public void Run(JObject obj)
        {
            // TODO
        }
    }
}
