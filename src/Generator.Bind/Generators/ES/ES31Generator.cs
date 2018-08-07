using System;
using System.IO;
using System.Linq;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for the OpenGL ES 3.1 API.
    /// </summary>
    internal class ES31Generator : GeneratorBase
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES31";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es3";

        /// <inheritdoc/>
        public override string ProfileName => "gles2";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(2, 0), new Version(3, 1));

        /// <inheritdoc/>
        protected override string Version => "2.0|3.0|3.1";

        /// <summary>
        /// Initializes a new instance of the <see cref="ES31Generator"/> class.
        /// </summary>
        public ES31Generator()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "GL2", "ES", "3.1");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "GL2", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
