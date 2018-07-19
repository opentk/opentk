using System.Collections.Generic;
using System.IO;

namespace Bind.Typemap
{
    /// <summary>
    /// Represents a type that can read a typemap from a file.
    /// </summary>
    public interface ITypemapReader
    {
        /// <summary>
        /// Reads a typemap from the given stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>The type map.</returns>
        IReadOnlyDictionary<string, string> ReadTypemap(Stream stream);
    }
}
