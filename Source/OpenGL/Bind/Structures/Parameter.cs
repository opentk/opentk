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
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    public class Parameter
    {
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

        #region Constructors

        /// <summary>
        /// Creates a new Parameter without type and name.
        /// </summary>
        public Parameter() { }

        #endregion

        #region ToString function
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (UnmanagedType == UnmanagedType.AsAny && Flow == FlowDirection.In)
                sb.Append("[MarshalAs(UnmanagedType.AsAny)] ");

            if (UnmanagedType == UnmanagedType.LPArray)
                sb.Append("[MarshalAs(UnmanagedType.LPArray)] ");

            if (Flow == FlowDirection.Out && !Array && !(Type == "IntPtr"))
                sb.Append("out ");

            sb.Append(Type);
            if (Array)
                sb.Append("[]");

            sb.Append(" ");
            sb.Append(Name);

            return sb.ToString();
        }
        #endregion
    }
}
