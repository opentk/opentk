#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    #region Constant class

    /// <summary>
    /// Represents an opengl constant in C# format. Both the constant name and value
    /// can be retrieved or set. The value can be either a number, another constant
    /// or an alias to a constant 
    /// </summary>
    public class Constant
    {
        #region Name

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

        #region Value

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

        #region public string ToString()

        /// <summary>
        /// Returns a string that represents the full constant declaration without decorations
        /// (eg const uint GL_XXX_YYY = 0xDEADBEEF).
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return Name + " = " + Value;
        }

        #endregion
    }

    #endregion
}
