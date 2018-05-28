/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using Bind.Structures;

namespace Bind
{
    internal interface IGenerator
    {
        /// <summary>
        /// Gets a short-name identifier for the API (such as GL, GL4, ES10, etc)
        /// </summary>
        string APIIdentifier { get; }

        /// <summary>
        /// Gets the name of the subfolder where the generated files should be placed.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        /// Gets the namespace that the output classes and enums should live in.
        /// </summary>
        string OutputSubfolder { get; }

        /// <summary>
        /// Gets the name of the output class.
        /// </summary>
        string ClassName { get; }

        /// <summary>
        /// Gets the prefix of the functions in the API.
        /// </summary>
        string FunctionPrefix { get; }

        /// <summary>
        /// Gets the prefix of the constants defined in the API.
        /// </summary>
        string ConstantPrefix { get; }

        /// <summary>
        /// Gets the path to the directory that contains the API documentation.
        /// </summary>
        string SpecificationDocumentationPath { get; }

        /// <summary>
        /// Gets the delegates that were loaded from the API specification.
        /// </summary>
        DelegateCollection Delegates { get; }

        /// <summary>
        /// Gets the enums that were generated from the API specification.
        /// </summary>
        EnumCollection Enums { get; }

        /// <summary>
        /// Gets the function wrappers that were generated from the API specification.
        /// </summary>
        FunctionCollection Wrappers { get; }

        /// <summary>
        /// Gets the API typemap.
        /// </summary>
        IDictionary<string, string> APITypes { get; }

        /// <summary>
        /// Gets the language typemap.
        /// </summary>
        IDictionary<string, string> LanguageTypes { get; }

        /// <summary>
        /// Loads the data that the generator wraps.
        /// </summary>
        void LoadData();
    }
}
