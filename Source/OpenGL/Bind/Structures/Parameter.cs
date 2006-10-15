#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL.Bind
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

            this.Array = p.Array;
            this.Flow = p.Flow;
            this.Name = new string(p.Name.ToCharArray());
            this.NeedsWrapper = p.NeedsWrapper;
            this.PreviousType = new string(p.PreviousType.ToCharArray());
            this.Type = new string(p.Type.ToCharArray());
            this.Unchecked = p.Unchecked;
            this.UnmanagedType = p.UnmanagedType;
            this.WrapperType = p.WrapperType;
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
            get { return _type; }
            set
            {
                if (_type != null)
                    PreviousType = _type;
                _type = value;
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

        #region Array property

        bool _array = false;

        public bool Array
        {
            get { return _array; }
            set { _array = value; }
        }

        #endregion

        #region Unchecked property

        private bool _unchecked;

        public bool Unchecked
        {
            get { return _unchecked; }
            set { _unchecked = value; }
        }

        #endregion

        #region NeedsWrapper property

        private bool _needs_wrapper;

        public bool NeedsWrapper
        {
            get { return _needs_wrapper; }
            set { _needs_wrapper = value; }
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

        #region ToString function
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (UnmanagedType == UnmanagedType.AsAny && Flow == FlowDirection.In)
                sb.Append("[MarshalAs(UnmanagedType.AsAny)] ");

            if (UnmanagedType == UnmanagedType.LPArray)
                sb.Append("[MarshalAs(UnmanagedType.LPArray)] ");

            //if (Flow == FlowDirection.Out && !Array && !(Type == "IntPtr"))
            //    sb.Append("out ");

            sb.Append(Type);
            if (Array)
                sb.Append("[]");

            sb.Append(" ");
            sb.Append(Name);

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
        /// 
        /// </summary>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            if (this.Count > 0)
            {
                foreach (Parameter p in this)
                {
                    sb.Append(p.ToString());
                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
                sb.Append(")");

            return sb.ToString();
        }

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.Type == type)
                    return true;
            return false;
        }

        #endregion

        #region public ParameterCollection ReplaceAll(Parameter, Parameter)

        /// <summary>
        /// Replaces all parameters that match the old_param with the new_param.
        /// </summary>
        /// <param name="old_param"></param>
        /// <param name="new_param"></param>
        /// <returns></returns>
        /// <remarks>The PreviousType property is ignored in parameter matching, and is set to the previous type in case of replacement.</remarks>
        public ParameterCollection ReplaceAll(Parameter old_param, Parameter new_param)
        {
            if (old_param == null || new_param == null)
                return null;

            ParameterCollection pc = new ParameterCollection(this);

            foreach (Parameter p in pc)
            {
                if (p.Array == old_param.Array &&
                    p.Flow == old_param.Flow &&
                    p.Name == old_param.Name &&
                    //p.PreviousType == old_param.PreviousType &&
                    p.Type == old_param.Type &&
                    p.UnmanagedType == old_param.UnmanagedType)
                {
                    p.Array = new_param.Array;
                    p.Flow = new_param.Flow;
                    p.Name = new_param.Name;
                    p.PreviousType = p.Type;
                    p.Type = new_param.Type;
                    p.UnmanagedType = new_param.UnmanagedType;
                }
            }

            return pc;
        }

        #endregion

        #region public ParameterCollection Replace(Parameter, Parameter)

        /// <summary>
        /// Replaces the first parameter that matches old_param with new_param.
        /// </summary>
        /// <param name="old_param"></param>
        /// <param name="new_param"></param>
        /// <returns></returns>
        /// <remarks>The PreviousType property is ignored in parameter matching, and is set to the previous type in case of replacement.</remarks>
        public ParameterCollection Replace(Parameter old_param, Parameter new_param)
        {
            if (old_param == null || new_param == null)
                return null;

            ParameterCollection pc = new ParameterCollection(this);

            foreach (Parameter p in pc)
            {
                if (p.Array == old_param.Array &&
                    p.Flow == old_param.Flow &&
                    p.Name == old_param.Name &&
                    //p.PreviousType == old_param.PreviousType &&
                    p.Type == old_param.Type &&
                    p.UnmanagedType == old_param.UnmanagedType)
                {
                    p.Array = new_param.Array;
                    p.Flow = new_param.Flow;
                    p.Name = new_param.Name;
                    p.PreviousType = p.Type;
                    p.Type = new_param.Type;
                    p.UnmanagedType = new_param.UnmanagedType;
                    return pc;
                }
            }

            return pc;
        }

        #endregion
    }

    #endregion
}
