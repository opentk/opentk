//
// DesktopSettings.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Bind.Generators.Bases;
using JetBrains.Annotations;

namespace Bind.Generators.GL.Core
{
    /// <summary>
    /// Generates API bindings for the OpenGL 4 API.
    /// </summary>
    internal class DesktopSettings : OpenGLGeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string OutputSubfolder => "OpenGL";

        /// <inheritdoc/>
        public override string ProfileName => "glcore";

        /// <inheritdoc/>
        [NotNull]
        public override string BaseProfileName => "gl";

        /// <inheritdoc/>
        public override string Namespace => "OpenToolkit.OpenGL.Core";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "gl4";
    }
}
