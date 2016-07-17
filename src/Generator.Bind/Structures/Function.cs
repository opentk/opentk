#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
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
            TrimmedName = Name = d.Name;
            Body = new FunctionBody();
            WrappedDelegate = d;
        }

        public Function(Function f)
            : this(f.WrappedDelegate)
        {
            Parameters = new ParameterCollection(f.Parameters);
            ReturnType = new Type(f.ReturnType);
            TrimmedName = f.TrimmedName;
            Obsolete = f.Obsolete;
            CLSCompliant = f.CLSCompliant;
            Documentation = f.Documentation;
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

        public string TrimmedName { get; set; }

        #endregion

        #region Documentation

        public Documentation Documentation { get; set; }

        #endregion

        #region ToString

        public override string ToString()
        {
            return String.Format("{0} {1}{2}",
                ReturnType,
                TrimmedName,
                Parameters);
        }

        #endregion

        #region IEquatable<Function> Members

        public bool Equals(Function other)
        {
            bool result =
                !String.IsNullOrEmpty(TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                TrimmedName.Equals(other.TrimmedName) &&
                Parameters.Equals(other.Parameters);
            return result;
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
            if (indent.Length > 4)
                indent = indent.Substring(4);
            else
                indent = String.Empty;
        }

        new public void Add(string s)
        {
            base.Add(indent + s.TrimEnd('\r', '\n'));
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

        void Add(Function f)
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
                AddChecked(f);
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
                var list = this[f.Extension];
                int index = list.IndexOf(f);
                if (index == -1)
                {
                    Add(f);
                }
                else
                {
                    Function existing = list[index];
                    bool replace = existing.Parameters.HasUnsignedParameters &&
                        !unsignedFunctions.IsMatch(existing.Name) && unsignedFunctions.IsMatch(f.Name);
                    replace |= !existing.Parameters.HasUnsignedParameters &&
                        unsignedFunctions.IsMatch(existing.Name) && !unsignedFunctions.IsMatch(f.Name);
                    replace |=
                        (from p_old in existing.Parameters
                                        join p_new in f.Parameters on p_old.Name equals p_new.Name
                                        where p_new.ElementCount == 0 && p_old.ElementCount != 0
                                        select true)
                            .Count() != 0;
                    if (replace)
                    {
                        list[index] = f;
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
