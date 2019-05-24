//
// DesktopCompatibilitySettings.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Bind.Generators.Bases;

namespace Bind.Generators.GL.Compatibility
{
    /// <summary>
    /// Generates API bindings for the OpenGL 2 API.
    /// </summary>
    internal class DesktopCompatibilitySettings : OpenGLGeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "gl4";

        /// <inheritdoc/>
        public override string Namespace => "OpenToolkit.OpenGL";

        /// <inheritdoc/>
        public override string ProfileName => "gl";
    }
}
