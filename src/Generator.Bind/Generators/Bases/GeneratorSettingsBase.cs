/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using System.IO;
using Bind.Versioning;

namespace Bind.Generators.Bases
{
    /// <summary>
    /// Base class for API generators.
    /// </summary>
    internal abstract class GeneratorSettingsBase : IGeneratorSettings
    {
        /// <inheritdoc/>
        public abstract string OutputSubfolder { get; }

        /// <inheritdoc/>
        public abstract string Namespace { get; }

        /// <inheritdoc/>
        public abstract string ClassName { get; }

        /// <inheritdoc/>
        public abstract string FunctionPrefix { get; }

        /// <inheritdoc/>
        public abstract string ConstantPrefix { get; }

        /// <inheritdoc/>
        public abstract string SpecificationDocumentationPath { get; }

        /// <inheritdoc/>
        public virtual IEnumerable<string> OverrideFiles { get; set; } = new List<string>();

        /// <inheritdoc/>
        public virtual string LanguageTypemap => "csharp.tm";

        /// <inheritdoc/>
        public abstract string APITypemap { get; }

        /// <inheritdoc/>
        public abstract string SpecificationFile { get; }

        /// <inheritdoc/>
        public abstract string ProfileName { get; }

        /// <inheritdoc/>
        public abstract string BaseProfileName { get; }

        /// <inheritdoc />
        public virtual VersionRange Versions => new VersionRange();
    }
}
