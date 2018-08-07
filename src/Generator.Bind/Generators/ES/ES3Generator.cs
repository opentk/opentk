using System;
using System.IO;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 3.0.
    /// </summary>
    internal class ES3Generator : GeneratorBase
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES30";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es3";

        /// <inheritdoc/>
        public override string ProfileName => "gles2";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(2, 0), new Version(3, 0));

        /// <inheritdoc/>
        protected override string Version => "2.0|3.0";

        /// <summary>
        /// Initializes a new instance of the <see cref="ES3Generator"/> class.
        /// </summary>
        public ES3Generator()
        {
            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "GL2", "overrides.xml")
            };
        }
    }
}
