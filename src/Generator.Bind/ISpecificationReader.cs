/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using Bind.Structures;
using JetBrains.Annotations;

namespace Bind
{
    /// <summary>
    /// Interface for an API specification reader.
    /// </summary>
    internal interface ISpecificationReader
    {
        /// <summary>
        /// Reads the delegate specification into the given delegate collection.
        /// </summary>
        /// <param name="specFile">The file to read from.</param>
        /// <param name="overrideFiles">The override files to read from.</param>
        /// <param name="apiname">The name of the API.</param>
        /// <param name="apiversions">The versions of the API to read.</param>
        /// <returns>A delegate collection.</returns>
        [NotNull]
        DelegateCollection ReadDelegates
        (
            [NotNull, PathReference] string specFile,
            [NotNull] IEnumerable<string> overrideFiles,
            [NotNull] string apiname,
            [NotNull] string apiversions
        );

        /// <summary>
        /// Reads the enum specification into the given enum collection.
        /// </summary>
        /// <param name="specFile">The file to read from.</param>
        /// <param name="overrideFiles">The override files to read from.</param>
        /// <param name="apiname">The name of the API.</param>
        /// <param name="apiversions">The versions of the API to read.</param>
        /// <returns>An enumeration collection.</returns>
        [NotNull]
        EnumCollection ReadEnums
        (
            [NotNull, PathReference] string specFile,
            [NotNull] IEnumerable<string> overrideFiles,
            [NotNull] string apiname,
            [NotNull] string apiversions
        );

        /// <summary>
        /// Reads the typemap for the input API into a dictionary.
        /// </summary>
        /// <param name="file">The typemap file.</param>
        /// <returns>A dictionary of the mapped types.</returns>
        [NotNull]
        Dictionary<string, string> ReadAPITypeMap([NotNull, PathReference] string file);

        /// <summary>
        /// Reads the typemap for the output language into a dictionary.
        /// </summary>
        /// <param name="file">The typemap file.</param>
        /// <returns>A dictionary of the mapped types.</returns>
        [NotNull]
        Dictionary<string, string> ReadLanguageTypeMap([NotNull, PathReference] string file);
    }
}
