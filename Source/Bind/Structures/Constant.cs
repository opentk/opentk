#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl constant in C# format. Both the constant name and value
    /// can be retrieved or set. The value can be either a number, another constant
    /// or an alias to a constant 
    /// </summary>
    public class Constant
    {
        #region public string Name

        string _name;

        /// <summary>
        /// Gets or sets the name of the opengl constant (eg. GL_LINES).
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value.Trim();
            }
        }

        #endregion

        #region public string Value

        string _value;

        /// <summary>
        /// Gets or sets the value of the opengl constant (eg. 0x00000001).
        /// </summary>
        public string Value
        {
            get { return _value; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _value = value.Trim();
            }
        }

        #endregion

        #region public string Reference

        string _reference;

        /// <summary>
        /// Gets or sets the value of the opengl constant (eg. 0x00000001).
        /// </summary>
        public string Reference
        {
            get { return _reference; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _reference = value.Trim();
            }
        }

        #endregion

        #region public bool Unchecked

        private bool @unchecked = false;

        public bool Unchecked
        {
            get { return @unchecked; }
            set { @unchecked = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an empty Constant.
        /// </summary>
        public Constant()
        {
        }

        /// <summary>
        /// Creates a Constant with the given name and value.
        /// </summary>
        /// <param name="name">The Name of the Constant.</param>
        /// <param name="value">The Type of the Constant.</param>
        public Constant(string name, string value)
        {
            Name = name;
            Value = value;
        }

        #endregion

        #region public override string ToString()

        /// <summary>
        /// Returns a string that represents the full constant declaration without decorations
        /// (eg GL_XXX_YYY = (int)0xDEADBEEF or GL_XXX_YYY = GL_ZZZ.FOOBAR).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(
                "{0} = {1}((int){2}{3})",
                Name,
                Unchecked ? "unchecked" : "",
                !String.IsNullOrEmpty(Reference) ? Reference + "." : "",
                Value
            );
        }

        #endregion
    }
}
