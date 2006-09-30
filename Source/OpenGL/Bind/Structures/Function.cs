/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    public class Function
    {
        #region Wrapper type property

        private WrapperTypes _wrapper_type = WrapperTypes.None;

        public WrapperTypes WrapperType
        {
            get { return _wrapper_type; }
            set { _wrapper_type = value; }
        }

        #endregion

        #region Needs wrapper property

        bool _needs_wrapper;

        /// <summary>
        /// Indicates whether this function needs to be wrapped with a Marshaling function.
        /// This flag is set if a function contains an Array parameter, or returns
        /// an Array or string.
        /// </summary>
        public bool NeedsWrapper
        {
            get { return _needs_wrapper; }
            set { _needs_wrapper = value; }
        }

        #endregion

        #region Return value property

        string _return_value;
        /// <summary>
        /// Gets or sets the return value of the opengl function.
        /// </summary>
        public string ReturnValue
        {
            get { return _return_value; }
            set { _return_value = value; }
        }

        #endregion

        #region Name property

        string _name;
        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value.Trim();
                else
                    _name = value;
            }
        }

        #endregion

        #region Parameter collection property

        ParameterCollection _parameters = new ParameterCollection();

        public ParameterCollection Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        #endregion

        #region Version property

        string _version;

        /// <summary>
        /// Defines the opengl version that introduced this function.
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        #endregion

        #region Extension property

        bool _extension = false;

        public bool Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        #endregion

        #region Constructor

        public Function()
        {
        }

        #endregion

        #region ToString function

        /// <summary>
        /// Gets the string representing the full function declaration without decorations
        /// (ie "void glClearColor(float red, float green, float blue, float alpha)"
        /// </summary>
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ReturnValue + " " + Name + Parameters.ToString());
            return sb.ToString();
        }

        #endregion

        #region Call function string

        public string CallString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append("(");
            foreach (Parameter p in Parameters)
            {
                sb.Append(p.Name);
                sb.Append(", ");
            }
            sb.Replace(", ", ")", sb.Length - 2, 2);

            return sb.ToString();
        }

        #endregion
    }
}
