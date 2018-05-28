using System.IO;
using Bind.GL2;

namespace Bind.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 2.0.
    /// </summary>
    internal class ES2Generator : Generator
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES20";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => APIIdentifier;

        /// <inheritdoc/>
        protected override string ProfileName => "gles2";

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
