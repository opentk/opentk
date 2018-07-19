using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bind.Extensions;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Typemap
{
    /// <summary>
    /// Bakes typemaps together, resolving cross-map mappings.
    /// </summary>
    public static class TypemapBaker
    {
        /// <summary>
        /// Bakes the given set of typemaps together.
        /// </summary>
        /// <param name="typemaps">The set of typemaps.</param>
        /// <returns>The baked set of typemaps.</returns>
        [NotNull]
        public static IReadOnlyDictionary<TypeSignature, TypeSignature> BakeTypemaps
        (
            [NotNull, ItemNotNull] params IReadOnlyDictionary<TypeSignature, TypeSignature>[] typemaps
        )
        {
            // First, we combine the typemaps into one monolithic map
            var ambiguousEntries = new List<KeyValuePair<TypeSignature, TypeSignature>>();
            var newTypemap = new Dictionary<TypeSignature, TypeSignature>();
            foreach (var typemap in typemaps)
            {
                foreach (var (fromType, toType) in typemap)
                {
                    if (!newTypemap.ContainsKey(fromType))
                    {
                        newTypemap.Add(fromType, toType);
                        continue;
                    }

                    if (newTypemap[fromType] == toType)
                    {
                        continue;
                    }

                    ambiguousEntries.Add(new KeyValuePair<TypeSignature, TypeSignature>(fromType, toType));
                }
            }

            // Then, we'll reduce the typemap, resolving chains of mappings
            int condensedEntries;
            var entryUpdates = new List<(TypeSignature Key, TypeSignature Value)>();
            do
            {
                condensedEntries = 0;
                foreach (var (fromType, toType) in newTypemap)
                {
                    if (!newTypemap.ContainsValue(fromType))
                    {
                        continue;
                    }

                    foreach (var nestedMapping in newTypemap.Where(kvp => kvp.Value == fromType))
                    {
                        entryUpdates.Add((nestedMapping.Key, toType));
                        ++condensedEntries;
                    }
                }

                foreach (var (key, value) in entryUpdates)
                {
                    newTypemap[key] = value;
                }

                entryUpdates.Clear();
            }
            while (condensedEntries > 0);

            // And finally, we'll try to discard the ambiguous entries
            foreach (var (fromType, toType) in ambiguousEntries)
            {
                var existingMapping = newTypemap[fromType];

                if (existingMapping == toType)
                {
                    // If the mappings are now the same, we've resolved the ambiguity when reducing the map
                    continue;
                }

                throw new AmbiguousMatchException
                (
                    "Same-type remapping found in two or more maps, but they didn't map to the same type."
                );
            }

            return newTypemap;
        }
    }
}
