#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL.Bind
{
    #region class Function

    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    public class Function
    {
        #region Constructors

        public Function()
        {
            Parameters = new ParameterCollection();
            Body = new FunctionBody();
        }

        public Function(Function f)
        {
            this.Body = new FunctionBody(f.Body);
            this.Category = new string(f.Category.ToCharArray());
            this.Extension = f.Extension;
            this.Name = new string(f.Name.ToCharArray());
            this.NeedsWrapper = f.NeedsWrapper;
            this.Parameters = new ParameterCollection(f.Parameters);
            this.ReturnValue = new string(f.ReturnValue.ToCharArray());
            this.Version = new string(f.Version.ToCharArray());
            this.WrapperType = f.WrapperType;
        }

        #endregion

        #region Function body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }
        
        #endregion

        #region Category property

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        #endregion

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

        ParameterCollection _parameters;

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

        #region Call function string

        public string CallString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append("(");
            foreach (Parameter p in Parameters)
            {
                if (p.Unchecked)
                    sb.Append("unchecked((" + p.Type + ")");

                sb.Append(p.Name);

                if (p.Unchecked)
                    sb.Append(")");

                sb.Append(", ");
            }
            sb.Replace(", ", ")", sb.Length - 2, 2);

            return sb.ToString();
        }

        #endregion

        #region ToString function

        /// <summary>
        /// Gets the string representing the full function declaration without decorations
        /// (ie "void glClearColor(float red, float green, float blue, float alpha)"
        /// </summary>
        override public string ToString()
        {
            return ToString("");
        }

        public string ToString(string indentation)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(indentation + ReturnValue + " " + Name + Parameters.ToString());
            if (Body.Count > 0)
            {
                sb.AppendLine();
                sb.Append(Body.ToString(indentation));
            }

            return sb.ToString();
        }

        #endregion

    }

    #endregion

    #region class FunctionBody : List<string>

    public class FunctionBody : List<string>
    {
        public FunctionBody()
        {
        }

        public FunctionBody(FunctionBody fb)
        {
            foreach (string s in fb)
            {
                this.Add(s);
            }
        }

        public override string ToString()
        {
            return ToString("");
        }

        public string ToString(string indentation)
        {
            if (this.Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(this.Count);
            
            sb.AppendLine(indentation + "{");
            foreach (string s in this)
            {
                sb.AppendLine(indentation + "    " + s);
            }
            sb.AppendLine(indentation + "}");

            return sb.ToString();
        }
    }

    #endregion
}
