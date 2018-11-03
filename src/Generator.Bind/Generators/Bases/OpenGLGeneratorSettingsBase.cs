/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bind.Versioning;

namespace Bind.Generators.Bases
{
    /// <summary>
    /// Base class for OpenGL API generators.
    /// </summary>
    internal abstract class OpenGLGeneratorSettingsBase : GeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string OutputSubfolder => "OpenGL";

        /// <inheritdoc/>
        public override string Namespace => "OpenToolkit.Graphics.OpenGL";

        /// <inheritdoc/>
        public override string ClassName => "GL";

        /// <inheritdoc/>
        public override string FunctionPrefix => "gl";

        /// <inheritdoc/>
        public override string ConstantPrefix => "GL_";

        /// <inheritdoc/>
        public override string APITypemap => Path.Combine("OpenGL", "gl.tm");

        /// <inheritdoc/>
        public override string SpecificationFile => Path.Combine("OpenGL", "signatures.xml");

        /// <inheritdoc/>
        public override string BaseProfileName => null;

        /// <inheritdoc />
        public override VersionRange Versions => new VersionRange();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGeneratorSettingsBase"/> class.
        /// </summary>
        protected OpenGLGeneratorSettingsBase()
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
