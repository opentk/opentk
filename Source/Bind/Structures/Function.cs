#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bind.Structures
{
    class Function : Delegate, IEquatable<Function>, IComparable<Function>
    {
        #region Fields

        Delegate wrapped_delegate;

        #endregion
        
        #region --- Constructors ---

        public Function(Delegate d)
            : base(d)
        {
            Name = d.Name;
            Body = new FunctionBody();
            WrappedDelegate = d;
        }

        public Function(Function f)
            : this(f.WrappedDelegate)
        {
            Parameters = new ParameterCollection(f.Parameters);
            ReturnType = new Type(f.ReturnType);
            Body.AddRange(f.Body);
        }

        #endregion

        #region public Delegate WrappedDelegate

        public Delegate WrappedDelegate
        {
            get { return wrapped_delegate; }
            set { wrapped_delegate = value; }
        }

        #endregion

        #region public void TurnVoidPointersToIntPtr()

        public void TurnVoidPointersToIntPtr()
        {
            foreach (Parameter p in Parameters)
            {
                if (p.Pointer != 0 && p.CurrentType == "void")
                {
                    p.CurrentType = "IntPtr";
                    p.Pointer = 0;
                }
            }
        }

        #endregion

        #region public override bool Unsafe

        public override bool Unsafe
        {
            get
            {
                if ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None)
                    return false;

                return base.Unsafe;
            }
        }

        #endregion

        #region public FunctionBody Body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }

        #endregion

        #region public string TrimmedName

        public string TrimmedName;

        #endregion

        #region public override string Name

        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// If no Tao compatibility is set, set TrimmedName to Name, after removing
        /// [u][bsifd][v].
        /// </summary>
        public override string Name
        {
            get { return base.Name; }
            set
            {
                base.Name = value;

                if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
                {
                    // If we don't need compatibility with Tao,
                    // remove the Extension and the overload information from the name
                    // (Extension == "ARB", "EXT", etc, overload == [u][bsidf][v])
                    // TODO: Use some regex's here, to reduce clutter.
                    TrimmedName = value;
                }
                else
                {
                    TrimmedName = FuncProcessor.TrimName(Name, false);
                }
            }
        }

        #endregion

        #region public override string ToString()

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
            {
                sb.Append(Settings.FunctionPrefix);
            }
            sb.Append(!String.IsNullOrEmpty(TrimmedName) ? TrimmedName : Name);
            
            if (Parameters.HasGenericParameters)
            {
                sb.Append("<");
                foreach (Parameter p in Parameters)
                {
                    if (p.Generic)
                    {
                        sb.Append(p.CurrentType);
                        sb.Append(",");
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(">");
            }
            sb.AppendLine(Parameters.ToString(false));
            if (Parameters.HasGenericParameters)
            {
                foreach (Parameter p in Parameters)
                {
                    if (p.Generic)
                        sb.AppendLine(String.Format("    where {0} : struct", p.CurrentType));
                }
                
            }

            if (Body.Count > 0)
            {
                sb.Append(Body.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region IEquatable<Function> Members

        public bool Equals(Function other)
        {
            return
                !String.IsNullOrEmpty(TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                TrimmedName == other.TrimmedName &&
                Parameters.ToString(true) == other.Parameters.ToString(true);
        }

        #endregion

        #region IComparable<Function> Members

        public int CompareTo(Function other)
        {
            int ret = Name.CompareTo(other.Name);
            if (ret == 0)
                ret = Parameters.CompareTo(other.Parameters);
            if (ret == 0)
                ret = ReturnType.CompareTo(other.ReturnType);
            return ret;
        }

        #endregion
    }

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
                Add(s);
            }
        }

        private string indent = "";

        public void Indent()
        {
            indent += "    ";
        }

        public void Unindent()
        {
            if (indent.Length >= 4)
                indent = indent.Substring(4);
        }

        new public void Add(string s)
        {
            base.Add(indent + s);
        }

        new public void AddRange(IEnumerable<string> collection)
        {
            foreach (string t in collection)
            {
                Add(t);
            }
        }

        public override string ToString()
        {
            if (Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(Count);

            sb.AppendLine("{");
            foreach (string s in this)
            {
                sb.AppendLine("    " + s);
            }
            sb.Append("}");

            return sb.ToString();
        }
    }

    #endregion

    #region class FunctionCollection : SortedDictionary<string, List<Function>>

    class FunctionCollection : SortedDictionary<string, List<Function>>
    {
        Regex unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        public void Add(Function f)
        {
            if (!ContainsKey(f.Extension))
            {
                Add(f.Extension, new List<Function>());
                this[f.Extension].Add(f);
            }
            else
            {
                this[f.Extension].Add(f);
            }
        }

        public void AddRange(IEnumerable<Function> functions)
        {
            foreach (Function f in functions)
            {
                Add(f);
            }
        }

        /// <summary>
        /// Adds the function to the collection, if a function with the same name and parameters doesn't already exist.
        /// </summary>
        /// <param name="f">The Function to add.</param>
        public void AddChecked(Function f)
        {
            if (ContainsKey(f.Extension))
            {
                int index = this[f.Extension].IndexOf(f);
                if (index == -1)
                {
                    Add(f);
                }
                else
                {
                    Function existing = this[f.Extension][index];
                    if ((existing.Parameters.HasUnsignedParameters && !unsignedFunctions.IsMatch(existing.Name) && unsignedFunctions.IsMatch(f.Name)) ||
                        (!existing.Parameters.HasUnsignedParameters && unsignedFunctions.IsMatch(existing.Name) && !unsignedFunctions.IsMatch(f.Name)))
                    {
                        this[f.Extension].RemoveAt(index);
                        this[f.Extension].Add(f);
                    }
                }
            }
            else
            {
                Add(f);
            }
        }
    }

    #endregion
}
