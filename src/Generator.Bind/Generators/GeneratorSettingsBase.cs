/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.IO;
using Bind.Versioning;

namespace Bind.Generators
{
    /// <summary>
    /// Base class for API generators.
    /// </summary>
    internal abstract class GeneratorSettingsBase : IGeneratorSettings
    {
        /// <inheritdoc/>
        public virtual string APIIdentifier => "GL";

        /// <inheritdoc/>
        public virtual string OutputSubfolder => "OpenGL";

        /// <inheritdoc/>
        public virtual string Namespace => "OpenTK.Graphics.OpenGL";

        /// <inheritdoc/>
        public virtual string ClassName => "GL";

        /// <inheritdoc/>
        public virtual string FunctionPrefix => "gl";

        /// <inheritdoc/>
        public virtual string ConstantPrefix => "GL_";

        /// <inheritdoc/>
        public virtual string SpecificationDocumentationPath => "GL";

        /// <inheritdoc/>
        public virtual IEnumerable<string> OverrideFiles { get; set; }

        /// <inheritdoc/>
        public virtual string LanguageTypemap => "csharp.tm";

        /// <inheritdoc/>
        public virtual string APITypemap => Path.Combine("GL2", "gl.tm");

        /// <inheritdoc/>
        public virtual string SpecificationFile => Path.Combine("GL2", "signatures.xml");

        /// <inheritdoc/>
        public virtual string ProfileName => "gl";

        /// <inheritdoc/>
        public virtual string BaseProfileName => null;

        /// <inheritdoc />
        public virtual VersionRange Versions => new VersionRange();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorSettingsBase"/> class.
        /// </summary>
        protected GeneratorSettingsBase()
        {
            OverrideFiles = new List<string>();
        }
    }
}
