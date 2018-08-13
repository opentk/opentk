using System.IO;
using System.Linq;
using Bind.Generators.Bases;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 1.1.
    /// </summary>
    internal class ES11GeneratorSettings : OpenGLGeneratorSettingsBase
    {
        /// <summary>
        /// Gets a short-name identifier for the API.
        /// </summary>
        private const string APIIdentifier = "ES11";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <remarks>
        /// The ES 1.1 generator uses the ES2.0 documentation, since there are no docbook sources available for 1.1.
        /// </remarks>
        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es1";

        /// <inheritdoc/>
        public override string ProfileName => "gles1";

        /// <summary>
        /// Initializes a new instance of the <see cref="ES11GeneratorSettings"/> class.
        /// </summary>
        public ES11GeneratorSettings()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "GL");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "OpenGL", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
