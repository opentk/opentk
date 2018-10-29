using System;
using System.Collections.Generic;
using System.IO;
using Bind.XML;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Typemap
{
    /// <summary>
    /// The base class for typemap readers.
    /// </summary>
    public class TypemapReader : ITypemapReader
    {
        /// <inheritdoc/>
        [NotNull]
        public IReadOnlyDictionary<TypeSignature, TypeSignature> ReadTypemap([NotNull] Stream stream)
        {
            var typeMap = new Dictionary<TypeSignature, TypeSignature>();
            using (var streamReader = new StreamReader(stream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    if (line is null)
                    {
                        break;
                    }

                    if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    var commentIndex = line.IndexOf("#", StringComparison.Ordinal);
                    if (commentIndex > 0)
                    {
                        line = line.Remove(commentIndex);
                    }

                    var parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 2)
                    {
                        throw new InvalidDataException("Typemap element with more or less than two columns found.");
                    }

                    var fromType = ParsingHelpers.ParseTypeSignature(parts[0].Trim());
                    var toType = ParsingHelpers.ParseTypeSignature(parts[1].Trim());

                    typeMap.Add(fromType, toType);
                }
            }

            return typeMap;
        }
    }
}
