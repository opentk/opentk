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
            if (t != null)
            {
                QualifiedType = t.QualifiedType ?? t.CurrentType; // Covers current type and qualifier
                PreviousType = t.PreviousType;
                PreviousQualifier = t.PreviousQualifier;
                WrapperType = t.WrapperType;
                Array = t.Array;
                Pointer = t.Pointer;
                Reference = t.Reference;
                ElementCount = t.ElementCount;
                IsEnum = t.IsEnum;
            }
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
        public virtual string CurrentType
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
                    Pointer++;
                }
            }
        }

        public string PreviousType { get; private set; }

        public bool Reference { get; set; }

        private int _array;

        public int Array
        {
            get => _array;
            set => _array = value > 0 ? value : 0;
        }

        private int _elementCount;

        // If the type is an array and ElementCount > 0, then ElemenCount defines the expected array length.
        public int ElementCount
        {
            get => _elementCount;
            set => _elementCount = value > 0 ? value : 0;
        }

        private int _pointer;

        public int Pointer
        {
            get => _pointer;
            set => _pointer = value > 0 ? value : 0;
        }

        // Set to true if parameter is an enum.
        public bool IsEnum { get; set; }

        public bool Unsigned => (CurrentType.Contains("UInt") || CurrentType.Contains("Byte"));

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
            return $"{CurrentType}{PointerLevels[Pointer]}{ArrayLevels[Array]}";
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
                result = Pointer.CompareTo(other.Pointer); // Must come after array/ref, see issue [#1098]
            }
            if (result == 0)
            {
                result = Reference.CompareTo(other.Reference);
            }
            if (result == 0)
            {
                result = Array.CompareTo(other.Array);
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
                Pointer.Equals(other.Pointer) &&
                Reference.Equals(other.Reference) &&
                Array.Equals(other.Array);
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
