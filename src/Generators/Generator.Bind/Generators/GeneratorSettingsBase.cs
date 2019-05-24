//
// GeneratorSettingsBase.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
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
        public abstract string APIIdentifier { get; }

        /// <inheritdoc/>
        public abstract string SpecificationFile { get; }

        /// <inheritdoc/>
        public abstract string ProfileName { get; }

        /// <inheritdoc/>
        public abstract string BaseProfileName { get; }

        /// <inheritdoc />
        public virtual VersionRange Versions => new VersionRange();

        /// <inheritdoc />
        public abstract NameContainer NameContainer { get; }

        /// <inheritdoc />
        public abstract string ExtensionNamespace { get; }
    }
}
