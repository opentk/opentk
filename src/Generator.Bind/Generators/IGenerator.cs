/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using Bind.Structures;
using JetBrains.Annotations;

namespace Bind.Generators
{
    /// <summary>
    /// Interface for API generation configuration objects.
    /// </summary>
    internal interface IGenerator
    {
        /// <summary>
        /// Gets a short-name identifier for the API (such as GL, GL4, ES10, etc).
        /// </summary>
        [NotNull]
        string APIIdentifier { get; }

        /// <summary>
        /// Gets the name of the subfolder where the generated files should be placed.
        /// </summary>
        [NotNull]
        string Namespace { get; }

        /// <summary>
        /// Gets the namespace that the output classes and enums should live in.
        /// </summary>
        [NotNull]
        string OutputSubfolder { get; }

        /// <summary>
        /// Gets the name of the output class.
        /// </summary>
        [NotNull]
        string ClassName { get; }

        /// <summary>
        /// Gets the prefix of the functions in the API.
        /// </summary>
        [NotNull]
        string FunctionPrefix { get; }

        /// <summary>
        /// Gets the prefix of the constants defined in the API.
        /// </summary>
        [NotNull]
        string ConstantPrefix { get; }

        /// <summary>
        /// Gets the path to the directory that contains the API documentation.
        /// </summary>
        [NotNull]
        string SpecificationDocumentationPath { get; }

        /// <summary>
        /// Gets the delegates that were loaded from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        DelegateCollection Delegates { get; }

        /// <summary>
        /// Gets the enums that were generated from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        EnumCollection Enums { get; }

        /// <summary>
        /// Gets the function wrappers that were generated from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        FunctionCollection Wrappers { get; }

        /// <summary>
        /// Gets the API typemap.
        /// </summary>
        [NotNull, Obsolete]
        IDictionary<string, string> APITypes { get; }

        /// <summary>
        /// Gets the language typemap.
        /// </summary>
        [NotNull, Obsolete]
        IDictionary<string, string> LanguageTypes { get; }

        /// <summary>
        /// Loads the data that the generator wraps.
        /// </summary>
        [Obsolete]
        void LoadData();
    }
}
