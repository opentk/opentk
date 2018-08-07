using System;
using System.IO;
using System.Linq;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 1.0.
    /// </summary>
    internal class ES10GeneratorSettings : GeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES10";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es1";

        /// <inheritdoc/>
        public override string ProfileName => "gles1";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(1, 0));

        /// <summary>
        /// Initializes a new instance of the <see cref="ES10GeneratorSettings"/> class.
        /// </summary>
        public ES10GeneratorSettings()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "GL2", "GL");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "GL2", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
