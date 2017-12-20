/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bind.Structures
{
    internal class Function : Delegate, IEquatable<Function>, IComparable<Function>
    {
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

        public Delegate WrappedDelegate { get; set; }

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

        public override bool Unsafe
        {
            get
            {
                return base.Unsafe;
            }
        }

        public FunctionBody Body { get; set; }

        public string TrimmedName { get; set; }

        public Documentation Documentation { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}{2}",
                ReturnType,
                TrimmedName,
                Parameters);
        }

        public bool Equals(Function other)
        {
            bool result =
                !String.IsNullOrEmpty(TrimmedName) && !String.IsNullOrEmpty(other.TrimmedName) &&
                TrimmedName.Equals(other.TrimmedName) &&
                Parameters.Equals(other.Parameters);
            return result;
        }

        public int CompareTo(Function other)
        {
            int ret = Name.CompareTo(other.Name);
            if (ret == 0)
            {
                ret = Parameters.CompareTo(other.Parameters);
            }
            if (ret == 0)
            {
                ret = ReturnType.CompareTo(other.ReturnType);
            }
            return ret;
        }
    }

    /// <summary>
    /// The <see cref="FunctionBody"/> class acts as a wrapper around a block of source code that makes up the body
    /// of a function.
    /// </summary>
    public class FunctionBody : List<string>
    {
        /// <summary>
        /// Initializes an empty <see cref="FunctionBody"/>.
        /// </summary>
        public FunctionBody()
        {
        }

        /// <summary>
        /// Initializes a <see cref="FunctionBody"/> from an existing FunctionBody.
        /// </summary>
        /// <param name="fb">The body to copy from.</param>
        public FunctionBody(FunctionBody fb)
        {
            foreach (string s in fb)
            {
                Add(s);
            }
        }

        private string indent = "";

        /// <summary>
        /// Indents this <see cref="FunctionBody"/> another level.
        /// </summary>
        public void Indent()
        {
            indent += "    ";
        }

        /// <summary>
        /// Removes a level of indentation from this <see cref="FunctionBody"/>.
        /// </summary>
        public void Unindent()
        {
            if (indent.Length > 4)
            {
                indent = indent.Substring(4);
            }
            else
            {
                indent = String.Empty;
            }
        }

        /// <summary>
        /// Adds a line of source code to the body at the current indentation level.
        /// </summary>
        /// <param name="s">The line to add.</param>
        new public void Add(string s)
        {
            base.Add(indent + s.TrimEnd('\r', '\n'));
        }

        /// <summary>
        /// Adds a range of source code lines to the body at the current indentation level.
        /// </summary>
        /// <param name="collection"></param>
        new public void AddRange(IEnumerable<string> collection)
        {
            foreach (string t in collection)
            {
                Add(t);
            }
        }

        /// <summary>
        /// Builds the contents of the function body into a string and encloses it with braces.
        /// </summary>
        /// <returns>The body, enclosed in braces.</returns>
        public override string ToString()
        {
            if (Count == 0)
            {
                return String.Empty;
            }

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

    internal class FunctionCollection : SortedDictionary<string, List<Function>>
    {
        private Regex unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        private void Add(Function f)
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
}
