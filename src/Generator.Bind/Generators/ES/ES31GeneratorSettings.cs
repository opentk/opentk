using System;
using System.IO;
using System.Linq;
using Bind.Generators.Bases;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for the OpenGL ES 3.1 API.
    /// </summary>
    internal class ES31GeneratorSettings : OpenGLGeneratorSettingsBase
    {
        /// <summary>
        /// Gets a short-name identifier for the API.
        /// </summary>
        private const string APIIdentifier = "ES31";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenToolkit.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es3";

        /// <inheritdoc/>
        public override string ProfileName => "gles2";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(2, 0), new Version(3, 1));

        /// <summary>
        /// Initializes a new instance of the <see cref="ES31GeneratorSettings"/> class.
        /// </summary>
        public ES31GeneratorSettings()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "ES", "3.1");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "OpenGL", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
