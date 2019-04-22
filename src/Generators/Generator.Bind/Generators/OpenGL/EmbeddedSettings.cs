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
    internal class EmbeddedSettings : OpenGLGeneratorSettingsBase
    {
        /// <summary>
        /// Gets a short-name identifier for the API.
        /// </summary>
        private const string APIIdentifier = "OpenGLES";

        /// <inheritdoc/>
        public override string Namespace => $"OpenToolkit.OpenGLES";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "es3";

        /// <inheritdoc/>
        public override string ProfileName => "gles2";

        /// <inheritdoc/>
        public override VersionRange Versions => new VersionRange(new Version(2, 0), new Version(3, 2));

        /// <inheritdoc />
        public override NameContainer NameContainer => new NameContainer()
        {
            Android = "libGLESv2.so",
            Linux = "libGLESv2.so",
            Windows = "libGLESv2.dll",
            ClassName = "OpenGLESLibraryNameContainer",
            IOS = "/System/Library/Frameworks/OpenGLES.framework/OpenGLES",
            MacOS = "/System/Library/Frameworks/OpenGLES.framework/OpenGLES"
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSettings"/> class.
        /// </summary>
        public EmbeddedSettings()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "ES", "3.2");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "OpenGL", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
