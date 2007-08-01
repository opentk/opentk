#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Bind.Structures
{
    #region Parameter class

    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    public class Parameter
    {
        #region Constructors

        /// <summary>
        /// Creates a new Parameter without type and name.
        /// </summary>
        public Parameter()
        {
        }

        /// <summary>
        /// Creates a new parameter from the parameters passed (deep copy).
        /// </summary>
        /// <param name="p">The parameter to copy from.</param>
        public Parameter(Parameter p)
        {
            if (p == null)
                return;

            this.Name = !String.IsNullOrEmpty(p.Name) ? new string(p.Name.ToCharArray()) : "";
            //this.NeedsWrapper = p.NeedsWrapper;
            this.PreviousType = !String.IsNullOrEmpty(p.PreviousType) ? new string(p.PreviousType.ToCharArray()) : "";
            this.Unchecked = p.Unchecked;
            this.UnmanagedType = p.UnmanagedType;
            this.WrapperType = p.WrapperType;

            this.Type = new string(p.Type.ToCharArray());
            this.Flow = p.Flow;
            this.Array = p.Array;
            this.Pointer = p.Pointer;
            this.Reference = p.Reference;
            
        }

        #endregion

        #region Name property

        string _name;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region UnmanagedType property

        UnmanagedType _unmanaged_type;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public UnmanagedType UnmanagedType
        {
            get { return _unmanaged_type; }
            set { _unmanaged_type = value; }
        }

        #endregion

        #region Type property

        string _type;
        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        public string Type
        {
            //get { return _type; }
            get
            {
                //if (Pointer && Settings.Compatibility == Settings.Legacy.Tao)
                //    return "IntPtr";
                
                return _type;
            }
            set
            {
                if (!String.IsNullOrEmpty(_type))
                    PreviousType = _type;
                if (!String.IsNullOrEmpty(value))
                    _type = value.Trim();
                if (_type.EndsWith("*"))
                {
                    _type = _type.TrimEnd('*');
                    Pointer = true;
                }

                clsCompliant =
                    !(
                    (Pointer && (Settings.Compatibility != Settings.Legacy.Tao)) ||
                    (Type.Contains("GLu") && !Type.Contains("GLubyte")) ||
                    Type == "GLbitfield" ||
                    Type.Contains("GLhandle") ||
                    Type.Contains("GLhalf") ||
                    Type == "GLbyte");
            }
        }

        #endregion

        #region Previous type property

        private string _previous_type;

        public string PreviousType
        {
            get { return _previous_type; }
            set { _previous_type = value; }
        }


        #endregion

        #region Flow property

        /// <summary>
        /// Enumarates the possible flows of a parameter (ie. is this parameter
        /// used as input or as output?)
        /// </summary>
        public enum FlowDirection
        {
            Undefined = 0,
            In,
            Out
        }

        FlowDirection _flow;

        /// <summary>
        /// Gets or sets the flow of the parameter.
        /// </summary>
        public FlowDirection Flow
        {
            get { return _flow; }
            set { _flow = value; }
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

        #region public bool Array

        int array;

        public int Array
        {
            get { return array; }
            set { array = value > 0 ? value : 0; }
        }

        #endregion

        #region public bool Pointer

        bool pointer = false;

        public bool Pointer
        {
            get { return pointer; }
            set { pointer = value; }
        }

        #endregion

        #region public bool NeedsPin

        public bool NeedsPin
        {
            get { return
                (Array > 0 || Reference || Type == "object") &&
                !Type.ToLower().Contains("string"); }
        }

        #endregion

        #region public bool Unchecked

        private bool _unchecked;

        public bool Unchecked
        {
            get { return _unchecked; }
            set { _unchecked = value; }
        }

        #endregion

        #region WrapperType property

        private WrapperTypes _wrapper_type = WrapperTypes.None;

        public WrapperTypes WrapperType
        {
            get { return _wrapper_type; }
            set { _wrapper_type = value; }
        }
        
        #endregion

        #region public bool CLSCompliant

        private bool clsCompliant;

        public bool CLSCompliant
        {
            get
            {
                // Checked when setting the Type property.
                return clsCompliant || (Pointer && Settings.Compatibility == Settings.Legacy.Tao);
            }
        }

        #endregion

        #region public string GetFullType()

        public string GetFullType(Dictionary<string, string> CSTypes, bool compliant)
        {
            if (Pointer && Settings.Compatibility == Settings.Legacy.Tao)
                return "IntPtr";

            if (!compliant)
            {
                return
                    Type +
                    (Pointer ? "*" : "") +
                    (Array > 0 ? "[]" : "");
            }

            return 
                GetCLSCompliantType(CSTypes) +
                (Pointer ? "*" : "") +
                (Array > 0 ? "[]" : "");

        }

        #endregion

        #region public string GetCLSCompliantType(Dictionary<string, string> CSTypes)

        public string GetCLSCompliantType(Dictionary<string, string> CSTypes)
        {
            if (!CLSCompliant)
            {
                if (Pointer && Settings.Compatibility == Settings.Legacy.Tao)
                    return "IntPtr";
                    
                if (CSTypes.ContainsKey(Type))
                {
                    switch (CSTypes[Type])
                    {
                        case "UInt16":
                            return "Int16";
                        case "UInt32":
                            return "Int32";
                        case "UInt64":
                            return "Int64";
                        case "SByte":
                            return "Byte";
                    }
                }
            }
            
            return Type;
        }

        #endregion

        #region override public string ToString()

        override public string ToString()
        {
            return ToString(false);
        }

        #endregion

        #region public string ToString(bool taoCompatible)

        public string ToString(bool taoCompatible)
        {
            StringBuilder sb = new StringBuilder();

            //if (UnmanagedType == UnmanagedType.AsAny && Flow == FlowDirection.In)
            //    sb.Append("[MarshalAs(UnmanagedType.AsAny)] ");

            //if (UnmanagedType == UnmanagedType.LPArray)
            //    sb.Append("[MarshalAs(UnmanagedType.LPArray)] ");

            //if (Flow == FlowDirection.Out && !Array && !(Type == "IntPtr"))
            //    sb.Append("out ");

            if (Reference)
            {
                if (Flow == FlowDirection.Out)
                    sb.Append("out ");
                else
                    sb.Append("ref ");
            }

            if (taoCompatible && Settings.Compatibility == Settings.Legacy.Tao)
            {
                if (Pointer)
                {
                    sb.Append("IntPtr");
                }
                else
                {
                    sb.Append(Type);
                    if (Array > 0)
                        sb.Append("[]");
                }
            }
            else
            {
                sb.Append(Type);
                if (Pointer)
                    sb.Append("*");
                if (Array > 0)
                    sb.Append("[]");
            }

            if (!String.IsNullOrEmpty(Name))
            {
                sb.Append(" ");
                sb.Append(Utilities.Keywords.Contains(Name) ? "@" + Name : Name);
            }
            return sb.ToString();
        }

        #endregion
    }

    #endregion

    #region ParameterCollection class

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    public class ParameterCollection : List<Parameter>
    {
        #region Constructors

        public ParameterCollection()
        {
        }

        public ParameterCollection(ParameterCollection pc)
        {
            foreach (Parameter p in pc)
            {
                this.Add(new Parameter(p));
            }
        }

        #endregion

        #region override public string ToString()

        /// <summary>
        /// Gets the parameter declaration string.
        /// </summary>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        override public string ToString()
        {
            return ToString(false, null);
        }

        #endregion

        public string ToString(bool taoCompatible)
        {
            return ToString(true, null);
        }

        #region public string ToString(bool taoCompatible, Dictionary<string, string> CSTypes)

        /// <summary>
        /// Gets the parameter declaration string.
        /// </summary>
        /// <param name="getCLSCompliant">If true, all types will be replaced by their CLSCompliant C# equivalents</param>
        /// <param name="CSTypes">The list of C# types equivalent to the OpenGL types.</param>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        public string ToString(bool taoCompatible, Dictionary<string, string> CSTypes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            if (this.Count > 0)
            {
                foreach (Parameter p in this)
                {
                    if (taoCompatible)
                    {
                        sb.Append(p.ToString(true));
                    }
                    else
                    {
                        sb.Append(p.ToString());
                    }
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
                sb.Append(")");

            return sb.ToString();
        }

        #endregion

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.Type == type)
                    return true;
            return false;
        }
    }

    #endregion
}
