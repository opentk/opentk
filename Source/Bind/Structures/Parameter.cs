#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a single parameter of an opengl function.
    /// </summary>
    public class Parameter : Type
    {
        string cache;
        bool rebuild;

        #region Constructors

        /// <summary>
        /// Creates a new Parameter without type and name.
        /// </summary>
        public Parameter()
            :base()
        {
        }

        /// <summary>
        /// Creates a new parameter from the parameters passed (deep copy).
        /// </summary>
        /// <param name="p">The parameter to copy from.</param>
        public Parameter(Parameter p)
            : base(p)
        {
            if (p == null)
                return;

            this.Name = p.Name;
            this.Unchecked = p.Unchecked;
            this.UnmanagedType = p.UnmanagedType;
            this.Flow = p.Flow;
            this.cache = p.cache;
            //this.rebuild = false;
        }

        #endregion

        #region public string Name

        string _name = String.Empty;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    rebuild = true;
                }
            }
        }

        #endregion

        #region UnmanagedType property

        UnmanagedType _unmanaged_type;
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        private UnmanagedType UnmanagedType
        {
            get { return _unmanaged_type; }
            set
            {
                if (_unmanaged_type != value)
                {
                    _unmanaged_type = value;
                    rebuild = true;
                }
            }
        }

        #endregion

        #region public FlowDirection Flow

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
            set
            {
                if (_flow != value)
                {
                    _flow = value;
                    rebuild = true;
                }
            }
        }

        #endregion

        #region public bool NeedsPin

        public bool NeedsPin
        {
            get
            {
                return (Array > 0 || Reference || CurrentType == "object") &&
                        !CurrentType.ToLower().Contains("string");
            }
        }

        #endregion

        #region public bool Unchecked

        private bool _unchecked;

        public bool Unchecked
        {
            get { return _unchecked; }
            set
            {
                if (_unchecked != value)
                {
                    _unchecked = value;
                    rebuild = true;
                }
            }
        }

        #endregion

        #region public override string CurrentType

        public override string CurrentType
        {
            get
            {
                return base.CurrentType;
            }
            set
            {
                base.CurrentType = value;
                rebuild = true;
            }
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
            if (!String.IsNullOrEmpty(cache) && !rebuild)
            {
               return cache;
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                if (Flow == FlowDirection.Out)
                    sb.Append("[Out] ");
                else if (Flow == FlowDirection.Undefined)
                    sb.Append("[In, Out] ");

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
                        sb.Append(CurrentType);
                        if (Array > 0)
                            sb.Append("[]");
                    }
                }
                else
                {
                    sb.Append(CurrentType);
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

                rebuild = false;
                cache = sb.ToString();
                return cache;
            }
        }

        #endregion

        #region internal static Parameter Translate(Parameter par, string Category)
        
        internal static Parameter Translate(Parameter par, string Category)
        {
            Enum @enum;
            string s;
            Parameter p = new Parameter(par);
            
            // Translate enum types
            if ((Enum.GLEnums.TryGetValue(p.CurrentType, out @enum) ||
                (Enum.AuxEnums != null && Enum.AuxEnums.TryGetValue(p.CurrentType, out @enum))) &&
                @enum.Name != "GLenum")
            {
                if (Settings.Compatibility == Settings.Legacy.Tao)
                    p.CurrentType = "int";
                else
                    p.CurrentType = p.CurrentType.Insert(0, String.Format("{0}.", Settings.GLEnumsClass));
            }
            else if (Bind.Structures.Type.GLTypes.TryGetValue(p.CurrentType, out s))
            {
                // Check if the parameter is a generic GLenum. If yes,
                // check if a better match exists:
                if (s.Contains("GLenum") && !String.IsNullOrEmpty(Category))
                {
                    if (Settings.Compatibility == Settings.Legacy.None)
                    {
                        // Better match: enum.Name == function.Category (e.g. GL_VERSION_1_1 etc)
                        if (Enum.GLEnums.ContainsKey(Category))
                        {
                            p.CurrentType = String.Format("{0}.{1}", Settings.GLEnumsClass, Category);
                        }
                        else
                        {
                            p.CurrentType = String.Format("{0}.{1}", Settings.GLEnumsClass, Settings.CompleteEnumName);
                        }
                    }
                    else
                    {
                        p.CurrentType = "int";
                    }
                }
                else
                {
                    // This is not enum, default translation:
                    if (p.CurrentType == "PIXELFORMATDESCRIPTOR" || p.CurrentType == "LAYERPLANEDESCRIPTOR" ||
                        p.CurrentType == "GLYPHMETRICSFLOAT")
                    {
                        if (Settings.Compatibility == Settings.Legacy.Tao)
                        {
                            p.CurrentType = p.CurrentType.Insert(0, "Gdi.");
                        }
                        else
                        {
                            if (p.CurrentType == "PIXELFORMATDESCRIPTOR")
                                p.CurrentType ="PixelFormatDescriptor";
                            else if (p.CurrentType == "LAYERPLANEDESCRIPTOR")
                                p.CurrentType = "LayerPlaneDescriptor";
                            else if (p.CurrentType == "GLYPHMETRICSFLOAT")
                                p.CurrentType = "GlyphMetricsFloat";
                        }
                    }
                    else
                    {
                        p.CurrentType = s;
                    }
                    p.CurrentType =
                        Bind.Structures.Type.CSTypes.ContainsKey(p.CurrentType) ?
                        Bind.Structures.Type.CSTypes[p.CurrentType] : p.CurrentType;
                }
            }

            //if (CSTypes.ContainsKey(p.CurrentType))
            //    p.CurrentType = CSTypes[p.CurrentType];

            // Translate pointer parameters
            if (p.Pointer)
            {
                p.WrapperType = WrapperTypes.ArrayParameter;

                if (p.CurrentType.ToLower().Contains("char") || p.CurrentType.ToLower().Contains("string"))
                {
                    // char* or string -> [In] String or [Out] StringBuilder
                    p.CurrentType =
                        p.Flow == Parameter.FlowDirection.Out ?
                        "System.Text.StringBuilder" :
                        "System.String";

                    p.Pointer = false;
                    p.WrapperType = WrapperTypes.None;
                }
                else if (p.CurrentType.ToLower().Contains("void"))
                {
                    p.WrapperType = WrapperTypes.GenericParameter;
                }
            }

            if (p.Reference)
            {
                p.WrapperType = WrapperTypes.ReferenceParameter;
            }

            if (p.CurrentType.ToLower().Contains("bool"))
            {
                // Is this actually used anywhere?
                p.WrapperType = WrapperTypes.BoolParameter;
            }

            return p;
        }
        
        #endregion
    }

    #region ParameterCollection class

    /// <summary>
    /// Holds the parameter list of an opengl function.
    /// </summary>
    public class ParameterCollection : List<Parameter>
    {
        string cache = String.Empty;
        string callStringCache = String.Empty;
        bool rebuild = true;

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

        new public void Add(Parameter p)
        {
            rebuild = true;
            base.Add(p);
        }

        #region override public string ToString()

        /// <summary>
        /// Gets the parameter declaration string.
        /// </summary>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        override public string ToString()
        {
            return ToString(false);
        }

        #endregion

        #region public string ToString(bool taoCompatible)

        /// <summary>
        /// Gets the parameter declaration string.
        /// </summary>
        /// <param name="getCLSCompliant">If true, all types will be replaced by their CLSCompliant C# equivalents</param>
        /// <param name="CSTypes">The list of C# types equivalent to the OpenGL types.</param>
        /// <returns>The parameter list of an opengl function in the form ( [parameters] )</returns>
        public string ToString(bool taoCompatible)
        {
            if (!rebuild)
            {
                return cache;
            }
            else
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

                cache = sb.ToString();
                return cache;
            }
        }

        #endregion

        public string CallString()
        {
            return CallString(false);
        }

        public string CallString(bool taoCompatible)
        {
            if (!rebuild)
            {
                return callStringCache;
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("(");

                if (this.Count > 0)
                {
                    foreach (Parameter p in this)
                    {
                        if (p.Unchecked)
                            sb.Append("unchecked((" + p.CurrentType + ")");

                        if (p.CurrentType != "object")
                        {
                            if (p.CurrentType.ToLower().Contains("string"))
                            {
                                sb.Append(String.Format("({0}{1})",
                                    p.CurrentType, (p.Array > 0) ? "[]" : ""));

                            }
                            else if (p.Pointer || p.Array > 0 || p.Reference)
                            {
                                sb.Append(String.Format("({0}*)",
                                    p.CurrentType /*, (p.Pointer || p.Array > 0) ? "*" : ""*/));
                            }
                            //else if (p.Reference)
                            //{
                            //    sb.Append(String.Format("{0} ({1})",
                            //       p.Flow == Parameter.FlowDirection.Out ? "out" : "ref", p.CurrentType));
                            //}
                            else
                            {
                                sb.Append(String.Format("({0})", p.CurrentType));
                            }
                        }

                        sb.Append(
                            Utilities.Keywords.Contains(p.Name) ? "@" + p.Name : p.Name
                        );

                        if (p.Unchecked)
                            sb.Append(")");

                        sb.Append(", ");
                    }
                    sb.Replace(", ", ")", sb.Length - 2, 2);
                }
                else
                {
                    sb.Append(")");
                }

                callStringCache = sb.ToString();
                return callStringCache;
            }
        }

        public bool ContainsType(string type)
        {
            foreach (Parameter p in this)
                if (p.CurrentType == type)
                    return true;
            return false;
        }
    }

    #endregion
}
