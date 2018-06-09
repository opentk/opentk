/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;

namespace Bind.Structures
{
    internal class TypeDefinition : IComparable<TypeDefinition>, IEquatable<TypeDefinition>
    {
        private string _currentQualifier = string.Empty;

        public TypeDefinition()
        {
        }

        public TypeDefinition(TypeDefinition t)
        {
            if (t == null)
            {
                return;
            }

            QualifiedType = t.QualifiedType ?? t.CurrentType; // Covers current type and qualifier
            PreviousType = t.PreviousType;
            PreviousQualifier = t.PreviousQualifier;
            WrapperType = t.WrapperType;
            ArrayDimensions = t.ArrayDimensions;
            IndirectionLevel = t.IndirectionLevel;
            IsReference = t.IsReference;
            ElementCount = t.ElementCount;
            IsEnum = t.IsEnum;
        }

        private string CurrentQualifier
        {
            get => _currentQualifier;
            set { PreviousQualifier = CurrentQualifier; _currentQualifier = value; }
        }

        private string PreviousQualifier { get; set; } = string.Empty;

        public string QualifiedType
        {
            get => !string.IsNullOrEmpty(CurrentQualifier)
                ? $"{CurrentQualifier}.{CurrentType}"
                : CurrentType;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                var qualifierEnd = value.LastIndexOf('.');
                if (qualifierEnd > -1)
                {
                    CurrentQualifier = value.Substring(0, qualifierEnd);
                    CurrentType = value.Substring(qualifierEnd + 1);
                }
                else
                {
                    CurrentType = value;
                    CurrentQualifier = string.Empty;
                }
            }
        }

        private string _type;

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        public string CurrentType
        {
            get => _type;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                if (!string.IsNullOrEmpty(_type))
                {
                    PreviousType = _type;
                }
                if (!string.IsNullOrEmpty(value))
                {
                    _type = value.Trim();
                }

                while (_type.EndsWith("*"))
                {
                    _type = _type.Substring(0, _type.Length - 1).Trim();
                    IndirectionLevel++;
                }
            }
        }

        public string PreviousType { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the type is a CLR by-ref type (that is, out or ref).
        /// </summary>
        public bool IsReference { get; set; }

        /// <summary>
        /// Gets or sets the number of dimensions in the array (the level of the array).
        /// </summary>
        public uint ArrayDimensions { get; set; }

        /// <summary>
        /// Gets a value indicating whether the type is an array.
        /// </summary>
        public bool IsArray => ArrayDimensions > 0;

        /// <summary>
        /// Gets or sets the expected array length.
        /// </summary>
        public uint ElementCount { get; set; }

        /// <summary>
        /// Gets or sets the levels of pointer indirection that the type has.
        /// </summary>
        public uint IndirectionLevel { get; set; }

        /// <summary>
        /// Gets a value indicating whether the type is a pointer type.
        /// </summary>
        public bool IsPointer => IndirectionLevel > 0;

        /// <summary>
        /// Gets or sets a value indicating whether the type is an enum.
        /// </summary>
        public bool IsEnum { get; set; }

        /// <summary>
        /// Gets a value indicating whether the type is an unsigned type.
        /// </summary>
        public bool IsUnsigned => (CurrentType.Contains("UInt") || CurrentType.Contains("Byte"));

        public WrapperTypes WrapperType { get; set; } = WrapperTypes.None;

        private static readonly string[] PointerLevels =
        {
            "",
            "*",
            "**",
            "***",
            "****"
        };

        private static readonly string[] ArrayLevels =
        {
            "",
            "[]",
            "[,]",
            "[,,]"
        };

        // Only used for debugging.
        public override string ToString()
        {
            return $"{CurrentType}{PointerLevels[IndirectionLevel]}{ArrayLevels[ArrayDimensions]}";
        }

        public int CompareTo(TypeDefinition other)
        {
            // Make sure that Pointer parameters are sorted last to avoid bug [#1098].
            // The rest of the comparisons help maintain a stable order (useful for source control).
            // Note that CompareTo is stricter than Equals and that there is code in
            // DelegateCollection.Add that depends on this fact.
            var result = CurrentType.CompareTo(other.CurrentType);
            if (result == 0)
            {
                result = IndirectionLevel.CompareTo(other.IndirectionLevel); // Must come after array/ref, see issue [#1098]
            }
            if (result == 0)
            {
                result = IsReference.CompareTo(other.IsReference);
            }
            if (result == 0)
            {
                result = ArrayDimensions.CompareTo(other.ArrayDimensions);
            }
            if (result == 0)
            {
                result = ElementCount.CompareTo(other.ElementCount);
            }
            return result;
        }

        public bool Equals(TypeDefinition other)
        {
            var result =
                CurrentType.Equals(other.CurrentType) &&
                IndirectionLevel.Equals(other.IndirectionLevel) &&
                IsReference.Equals(other.IsReference) &&
                ArrayDimensions.Equals(other.ArrayDimensions);

            // Note: CLS-compliance and element count do not factor
            // factor into the equality calculations, i.e.
            //  Foo(single[]) == Foo(single[]) -> true
            // even if these types have different element counts.
            // This is necessary because otherwise we'd get
            // redefinition errors in the generated bindings.
            return result;
        }
    }
}
