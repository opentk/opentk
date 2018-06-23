/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using Bind.Extensions;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a type definition that's used for translation between the OpenGL specification and the CLR.
    /// </summary>
    public class TypeDefinition : IComparable<TypeDefinition>, IEquatable<TypeDefinition>, IDeclarable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeDefinition"/> class.
        ///
        /// </summary>
        public TypeDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeDefinition"/> class.
        /// This constructor performs a deep copy of the given definition.
        /// </summary>
        /// <param name="t">The definition to copy.</param>
        public TypeDefinition(TypeDefinition t)
        {
            if (t == null)
            {
                return;
            }

            QualifiedTypeName = t.QualifiedTypeName ?? t.TypeName; // Covers current type and qualifier
            WrapperType = t.WrapperType;
            ArrayDimensions = t.ArrayDimensions;
            IndirectionLevel = t.IndirectionLevel;
            IsReference = t.IsReference;
            ElementCount = t.ElementCount;
            IsEnum = t.IsEnum;
        }

        private string CurrentQualifier { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the fully-qualified name of the type. Setting this also sets <see cref="TypeName"/> to the
        /// unqualified type name.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
        public string QualifiedTypeName
        {
            get => !string.IsNullOrEmpty(CurrentQualifier)
                ? $"{CurrentQualifier}.{TypeName}"
                : TypeName;
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
                    TypeName = value.Substring(qualifierEnd + 1);
                }
                else
                {
                    CurrentQualifier = string.Empty;
                    TypeName = value;
                }
            }
        }

        private string _typeName;

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        public string TypeName
        {
            get => _typeName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                if (!string.IsNullOrEmpty(value))
                {
                    _typeName = value.Trim();
                }

                while (_typeName.EndsWith("*"))
                {
                    _typeName = _typeName.Substring(0, _typeName.Length - 1).Trim();
                    IndirectionLevel++;
                }
            }
        }

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
        public bool IsUnsigned => (TypeName.Contains("UInt") || TypeName.Contains("Byte"));

        /// <summary>
        /// Gets or sets the wrapper type hinting information for this definition.
        /// </summary>
        public WrapperTypes WrapperType { get; set; } = WrapperTypes.None;

        /// <inheritdoc/>
        public override string ToString()
        {
            var pointerLevelString = new string('*', (int)IndirectionLevel);
            var arrayLevelString = ArrayDimensions > 0
                ? ArrayDimensions == 1
                    ? "[]"
                    : $"[{new string(',', (int)ArrayDimensions - 1)}]"
                : string.Empty;

            return $"{TypeName}{pointerLevelString}{arrayLevelString}";
        }

        /// <inheritdoc/>
        public virtual string GetDeclarationString()
        {
            var typeName = this.GetQualifiedTypeOrAlias();
            var pointerLevelString = new string('*', (int)IndirectionLevel);
            var arrayLevelString = ArrayDimensions > 0
                ? ArrayDimensions == 1
                    ? "[]"
                    : $"[{new string(',', (int)ArrayDimensions - 1)}]"
                : string.Empty;

            return $"{typeName}{pointerLevelString}{arrayLevelString}";
        }

        /// <inheritdoc/>
        public int CompareTo(TypeDefinition other)
        {
            // Make sure that Pointer parameters are sorted last to avoid bug [#1098].
            // The rest of the comparisons help maintain a stable order (useful for source control).
            // Note that CompareTo is stricter than Equals and that there is code in
            // DelegateCollection.Add that depends on this fact.
            var result = TypeName.CompareTo(other.TypeName);
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

        /// <inheritdoc/>
        public bool Equals(TypeDefinition other)
        {
            var result =
                TypeName.Equals(other.TypeName) &&
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
