using System;
using System.IO;
using System.Linq;
using Bind.Generators.Bases;
using Bind.Versioning;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 1.0.
    /// </summary>
    internal class ES10GeneratorSettings : OpenGLGeneratorSettingsBase
    {
        /// <summary>
        /// Gets a short-name identifier for the API.
        /// </summary>
        private const string APIIdentifier = "ES10";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenToolkit.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es1";

        /// <inheritdoc/>
        public override string ProfileName => "gles1";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(1, 0));
    }
}
