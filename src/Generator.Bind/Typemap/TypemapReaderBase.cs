using System.Collections.Generic;
using System.IO;

namespace Bind.Typemap
{
    /// <summary>
    /// The base class for typemap readers.
    /// </summary>
    public abstract class TypemapReaderBase : ITypemapReader
    {
        /// <inheritdoc/>
        public IReadOnlyDictionary<string, string> ReadTypemap(Stream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}
