using System.IO;
using System.Linq;

namespace Bind.Generators.ES
{
    /// <summary>
    /// Generates API bindings for OpenGL ES 1.1.
    /// </summary>
    internal class ES11Generator : GeneratorBase
    {
        /// <inheritdoc/>
        public override string APIIdentifier => "ES11";

        /// <inheritdoc/>
        public override string OutputSubfolder => APIIdentifier;

        /// <inheritdoc/>
        public override string Namespace => $"OpenTK.Graphics.{APIIdentifier}";

        /// <remarks>
        /// The ES 1.1 generator uses the ES2.0 documentation, since there are no docbook sources available for 1.1.
        /// </remarks>
        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "ES20";

        /// <inheritdoc/>
        protected override string ProfileName => "gles1";

        /// <summary>
        /// Initializes a new instance of the <see cref="ES11Generator"/> class.
        /// </summary>
        public ES11Generator()
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
