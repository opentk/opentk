using System;
using System.IO;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 2.0.
    /// </summary>
    internal class ES2Generator : GeneratorBase
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES20";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es2";

        /// <inheritdoc/>
        public override string ProfileName => "gles2";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(2, 0));

        /// <inheritdoc/>
        protected override string Version => "2.0";

        /// <summary>
        /// Initializes a new instance of the <see cref="ES2Generator"/> class.
        /// </summary>
        public ES2Generator()
        {
            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "GL2", "overrides.xml")
            };
        }
    }
}
