//
// OpenGLGeneratorSettingsBase.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

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
        public override string Namespace => "OpenToolkit.OpenGL";

        /// <inheritdoc/>
        public override string ExtensionNamespace => Namespace + ".Extensions";

        /// <inheritdoc/>
        public override string ClassName => "GL";

        /// <inheritdoc/>
        public override string APIIdentifier => "OpenGL";

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

        /// <inheritdoc />
        public override NameContainer NameContainer => new NameContainer()
        {
            Android = "libGL.so",
            Linux = "libGL.so",
            Windows = "opengl32.dll",
            ClassName = "OpenGLLibraryNameContainer",
            IOS = "/System/Library/Frameworks/OpenGL.framework/OpenGL",
            MacOS = "/System/Library/Frameworks/OpenGL.framework/OpenGL",
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGeneratorSettingsBase"/> class.
        /// </summary>
        protected OpenGLGeneratorSettingsBase()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "OpenGL", "GL", "4.6");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "OpenGL", "overrides.xml"),
            }.Concat(extraOverrides);
        }
    }
}
