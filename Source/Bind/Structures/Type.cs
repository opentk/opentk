#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.XPath;

namespace Bind.Structures
{
    class Type : IComparable<Type>, IEquatable<Type>
    {
        string current_qualifier = String.Empty;
        string previous_qualifier = String.Empty;

        #region --- Constructors ---

        public Type()
        {
        }

        public Type(Type t)
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

        #endregion

        #region Private Members

        string CurrentQualifier
        {
            get { return current_qualifier; }
            set { PreviousQualifier = CurrentQualifier; current_qualifier = value; }
        }

        string PreviousQualifier
        {
            get { return previous_qualifier; }
            set { previous_qualifier = value; }
        }

        #endregion

        #region Public Members

        public string QualifiedType
        {
            get
            {
                return
                    !String.IsNullOrEmpty(CurrentQualifier) ?
                        String.Format("{0}.{1}", CurrentQualifier, CurrentType) :
                        CurrentType;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();

                int qualifier_end = value.LastIndexOf('.');
                if (qualifier_end > -1)
                {
                    CurrentQualifier = value.Substring(0, qualifier_end);
                    CurrentType = value.Substring(qualifier_end + 1);
                }
                else
                {
                    CurrentType = value;
                    CurrentQualifier = String.Empty;
                }
            }
        }

        #region public string CurrentType

        string type;
        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        public virtual string CurrentType
        {
            get
            {
                return type;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();

                if (!String.IsNullOrEmpty(type))
                    PreviousType = type;
                if (!String.IsNullOrEmpty(value))
                    type = value.Trim();

                while (type.EndsWith("*"))
                {
                    type = type.Substring(0, type.Length - 1).Trim();
                    Pointer++;
                }
            }
        }

        #endregion

        #region public string PreviousType

        private string _previous_type;

        public string PreviousType
        {
            get { return _previous_type; }
            private set { _previous_type = value; }
        }

        #endregion

        #region public bool Reference

        bool reference;

        public bool Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        #endregion

        #region public int Array

        int array;

        public int Array
        {
            get { return array; }
            set { array = value > 0 ? value : 0; }
        }

        #endregion

        #region public int ElementCount

        int element_count;

        // If the type is an array and ElementCount > 0, then ElemenCount defines the expected array length.
        public int ElementCount
        {
            get { return element_count; }
            set { element_count = value > 0 ? value : 0; }
        }

        #endregion

        #region public int Pointer

        int pointer;

        public int Pointer
        {
            get { return pointer; }
            set { pointer = value > 0 ? value : 0; }
        }

        #endregion

        // Set to true if parameter is an enum.
        public bool IsEnum { get; set; }

        #region IndirectionLevel

        // Gets the the level of indirection for this type. For example,
        // type 'foo' has indirection level = 0, while 'ref foo*[]' has
        // an indirection level of 3.
        public int IndirectionLevel
        {
            get { return Pointer + Array + (Reference ? 1 : 0); }
        }

        #endregion

        #region public bool CLSCompliant

        public bool CLSCompliant
        {
            get
            {
                bool compliant = true;

                switch (CurrentType.ToLower())
                {
                    case "sbyte":
                    case "ushort":
                    case "uint":
                    case "ulong":
                    case "uintptr":
                    case "uint16":
                    case "uint32":
                    case "uint64":
                        compliant = false;
                        break;

                    default:
                        compliant = Pointer == 0;
                        break;
                }

                return compliant;

                /*
                if (Pointer != 0)
                {
                    compliant &= CurrentType.Contains("IntPtr");    // IntPtr's are CLSCompliant.
                    // If the NoPublicUnsageFunctions is set, the pointer will be CLSCompliant.
                    compliant |= (Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None;
                }
                return compliant;
                */
                //return compliant && (!Pointer || CurrentType.Contains("IntPtr"));
                //return compliant && !(Pointer && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) == Settings.Legacy.None));

                /*
                 * return !(
                    (Pointer && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) == Settings.Legacy.None ) ||
                    CurrentType.Contains("UInt") ||
                    CurrentType.Contains("SByte")));
                */

                /*(Type.Contains("GLu") && !Type.Contains("GLubyte")) ||
                Type == "GLbitfield" ||
                Type.Contains("GLhandle") ||
                Type.Contains("GLhalf") ||
                Type == "GLbyte");*/
            }
        }

        #endregion

        #region public bool Unsigned

        public bool Unsigned
        {
            get
            {
                return (CurrentType.Contains("UInt") || CurrentType.Contains("Byte"));
            }
        }

        #endregion

        #region public WrapperTypes WrapperType

        private WrapperTypes _wrapper_type = WrapperTypes.None;

        public WrapperTypes WrapperType
        {
            get { return _wrapper_type; }
            set { _wrapper_type = value; }
        }

        #endregion

        #region public override string ToString()

        static readonly string[] PointerLevels =
        {
            "",
            "*",
            "**",
            "***",
            "****"
        };

        static readonly string[] ArrayLevels =
        {
            "",
            "[]",
            "[,]",
            "[,,]"
        };

        // Only used for debugging.
        public override string ToString()
        {
            return String.Format("{0}{1}{2}",
                CurrentType,
                PointerLevels[Pointer],
                ArrayLevels[Array]);
        }

        #endregion

        #endregion

        #region IComparable<Type> Members

        public int CompareTo(Type other)
        {
            // Make sure that Pointer parameters are sorted last to avoid bug [#1098].
            // The rest of the comparisons help maintain a stable order (useful for source control).
            // Note that CompareTo is stricter than Equals and that there is code in
            // DelegateCollection.Add that depends on this fact.
            int result = this.CurrentType.CompareTo(other.CurrentType);
            if (result == 0)
                result = Pointer.CompareTo(other.Pointer); // Must come after array/ref, see issue [#1098]
            if (result == 0)
                result = Reference.CompareTo(other.Reference);
            if (result == 0)
                result = Array.CompareTo(other.Array);
            // Note: CLS-compliance and element counts
            // are used for comparison calculations, in order
            // to maintain a stable sorting order, even though
            // they are not used in equality calculations.
            if (result == 0)
                result = CLSCompliant.CompareTo(other.CLSCompliant);
            if (result == 0)
                result = ElementCount.CompareTo(other.ElementCount);
            return result;
        }

        #endregion

        #region IEquatable<Type> Members

        public bool Equals(Type other)
        {
            bool result =
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

        #endregion
    }
}
