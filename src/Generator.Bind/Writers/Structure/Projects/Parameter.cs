using System;
using System.Collections.Generic;
using Bind.XML.Signatures;
using JetBrains.Annotations;

namespace Bind.Writers.Structure.Projects
{
    public class Parameter
    {
        /// <summary>
        /// Gets the name of the type.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the level of indirection (i.e, the number of pointer levels) of the type.
        /// </summary>
        public int IndirectionLevel { get; }

        /// <summary>
        /// Gets the number of array dimensions of the type.
        /// </summary>
        public int ArrayDimensions { get; }

        /// <summary>
        /// Gets a value indicating whether the type is passed by reference.
        /// </summary>
        public bool IsByRef { get; }

        /// <summary>
        /// Gets a value indicating whether the type is an out-only by-ref value.
        /// </summary>
        public bool IsOut { get; }

        /// <summary>
        /// Gets a value indicating whether the type is a pointer.
        /// </summary>
        public bool IsPointer => IndirectionLevel > 0;

        /// <summary>
        /// Gets a value indicating whether the type is an array.
        /// </summary>
        public bool IsArray => ArrayDimensions > 0;
        public FlowDirection Flow { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}